S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 21308
Date: 2018-06-07 17:25:15+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf730852d, r5   = 0xf7b72f98
r6   = 0xffbfdea0, r7   = 0xffbfdd50
r8   = 0xf7b6fc18, r9   = 0x00000000
r10  = 0xffbfde2c, fp   = 0xffbfdea0
ip   = 0x00000001, sp   = 0xffbfdd28
lr   = 0xf7308539, pc   = 0xf7371228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     39628 KB
Buffers:     16984 KB
Cached:     109132 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11824 KB
VmRSS:       11820 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 21308 TID = 21308
21308 21312 

Maps Information
f41d3000 f49d2000 rw-p [stack:21312]
f49d9000 f49db000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f49e3000 f49e7000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f49f0000 f49f2000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f49fa000 f49fd000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4a0c000 f4a11000 r-xp /usr/lib/libsystem.so.0.0.0
f4a1c000 f4a1f000 r-xp /lib/libattr.so.1.1.0
f4a27000 f4a37000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4a3f000 f4a48000 r-xp /usr/lib/libedbus.so.1.7.99
f4a50000 f4a51000 r-xp /usr/lib/libresponse.so.0.2.96
f4a5a000 f4a5f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6301000 f6407000 r-xp /usr/lib/libicuuc.so.57.1
f641d000 f65a5000 r-xp /usr/lib/libicui18n.so.57.1
f65b5000 f65c2000 r-xp /usr/lib/libail.so.0.1.0
f65cb000 f65d2000 r-xp /usr/lib/libminizip.so.1.0.0
f65db000 f6784000 r-xp /usr/lib/libcrypto.so.1.0.0
f67a4000 f67eb000 r-xp /usr/lib/libssl.so.1.0.0
f67f7000 f67f9000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6801000 f6808000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6811000 f6818000 r-xp /lib/libcrypt-2.13.so
f6849000 f684c000 r-xp /lib/libcap.so.2.21
f6854000 f6856000 r-xp /usr/lib/libiri.so
f685e000 f68a7000 r-xp /usr/lib/libmdm.so.1.2.69
f68af000 f68b5000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f68bd000 f68e0000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f68ea000 f68ec000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f68f4000 f6911000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f691a000 f691e000 r-xp /usr/lib/libsmack.so.1.0.0
f6927000 f6940000 r-xp /usr/lib/libnetwork.so.0.0.0
f6949000 f6951000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6959000 f695f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6968000 f696a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6973000 f6983000 r-xp /lib/libresolv-2.13.so
f6987000 f699f000 r-xp /usr/lib/liblzma.so.5.0.3
f69a8000 f69aa000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f69b2000 f69cc000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f69d4000 f6a03000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a0c000 f6a1b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a25000 f6a2f000 r-xp /usr/lib/libsensord-shared.so
f6a38000 f6b0b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b16000 f6b2c000 r-xp /lib/libz.so.1.2.5
f6b34000 f6b39000 r-xp /usr/lib/libffi.so.5.0.10
f6b41000 f6b42000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b4a000 f6b5a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b62000 f6b7b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b83000 f6b85000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b8d000 f6c02000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c0c000 f6c12000 r-xp /lib/librt-2.13.so
f6c1b000 f6c39000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c43000 f6c44000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c4c000 f6c6f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c77000 f6c7c000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c84000 f6cae000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6cb7000 f6cce000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6cd6000 f6d3f000 r-xp /lib/libm-2.13.so
f6d48000 f6ddc000 r-xp /usr/lib/libstdc++.so.6.0.16
f6def000 f6df4000 r-xp /usr/lib/libctx-client.so.0.8.3
f6dfc000 f6e03000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e0b000 f6e35000 r-xp /usr/lib/libsensor.so.1.9.6
f6e3e000 f6f0a000 r-xp /usr/lib/libxml2.so.2.7.8
f6f17000 f6f19000 r-xp /usr/lib/libiniparser.so.0
f6f22000 f6f28000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f31000 f7001000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7002000 f7036000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f703f000 f707b000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7083000 f7086000 r-xp /usr/lib/libbundle.so.0.1.22
f708e000 f7094000 r-xp /usr/lib/libappsvc.so.0.1.0
f709c000 f70dd000 r-xp /usr/lib/libeina.so.1.7.99
f70e6000 f70fd000 r-xp /usr/lib/libecore.so.1.7.99
f7114000 f711d000 r-xp /usr/lib/libvconf.so.0.2.45
f7125000 f7139000 r-xp /lib/libpthread-2.13.so
f7144000 f7151000 r-xp /usr/lib/libaul.so.0.1.0
f715b000 f715d000 r-xp /lib/libdl-2.13.so
f7166000 f7171000 r-xp /lib/libunwind.so.8.0.1
f719e000 f71a6000 r-xp /lib/libgcc_s-4.6.so.1
f71a7000 f72cb000 r-xp /lib/libc-2.13.so
f72d9000 f72db000 r-xp /usr/lib/libdlog.so.0.0.0
f72e3000 f72ef000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f72f8000 f72fd000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7305000 f7314000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f731c000 f7320000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7329000 f732c000 r-xp /usr/lib/libappcore-agent.so.1.1
f7334000 f7336000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f733e000 f7342000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f734a000 f7367000 r-xp /lib/ld-2.13.so
f7370000 f7373000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7373000 f7377000 r-xp /usr/lib/libsys-assert.so
f7b3f000 f7bcd000 rw-p [heap]
ffbdf000 ffc00000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21308)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7371228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7308539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf700f3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf700dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7019e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf701fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf701fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf705475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf704f1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf700dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7019e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf701fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf701fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7051e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7052017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7059f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49f11fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf49e4171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ab7663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f64fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f667a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf70f6ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf70f1b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70f25a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf70f2879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf732a183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf732a7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73715c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf71be85c) [/lib/libc.so.6] + 0x1785c
29: (0xf7370f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ailty.gyroscope - capturing data
06-07 17:27:21.661+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:21.671+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:21.671+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:21.671+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:21.691+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:21:665,0.325424,-0.078963,9.887143
06-07 17:27:21.701+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:21:676,0.313581,-0.098405,9.801141
06-07 17:27:21.701+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:21.701+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:21:675,0.070000,0.070000,0.070000
06-07 17:27:21.701+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:21.701+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:21.711+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:21:685,-0.014762,0.007123,0.050102
06-07 17:27:21.711+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:21.721+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:21:717,0.070000,0.070000,0.070000
06-07 17:27:21.721+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:21:709,0.325424,-0.110070,9.901501
06-07 17:27:21.721+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:21:713,0.299984,-0.099418,9.801557
06-07 17:27:21.731+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:21.731+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:21.741+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:21:726,0.000254,-0.014642,0.052470
06-07 17:27:21.741+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:21.751+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:21:752,971.000000
06-07 17:27:21.751+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:21.761+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:21.771+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:21:742,0.344566,-0.117248,9.815358
06-07 17:27:21.771+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:21:765,0.304231,-0.096645,9.801454
06-07 17:27:21.781+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:21.781+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:21:748,0.070000,0.070000,0.070000
06-07 17:27:21.781+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:21:769,0.007378,0.048376,0.069230
06-07 17:27:21.781+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:21.791+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:21.791+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:21:794,0.296710,-0.098106,9.851252
06-07 17:27:21.801+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:21:796,0.070000,0.070000,0.070000
06-07 17:27:21.801+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:21.801+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:21.811+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:21:805,0.062749,-0.025934,0.035696
06-07 17:27:21.821+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:21.821+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:21:814,0.330210,-0.076570,9.870394
06-07 17:27:21.821+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:21:827,-0.042706,-0.017731,0.019039
06-07 17:27:21.831+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:21:816,0.140000,0.070000,0.070000
06-07 17:27:21.841+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:21.841+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:21.841+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:21:848,0.344566,-0.095713,9.884750
06-07 17:27:21.851+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:21.851+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:21:847,0.070000,-0.070000,0.140000
06-07 17:27:21.861+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:21:861,0.022175,-0.002650,0.011780
06-07 17:27:21.861+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:21.861+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:21.871+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:21.871+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:21.871+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:21:877,0.070000,-0.070000,0.070000
06-07 17:27:21.881+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:21.881+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:21:872,0.279960,-0.086142,9.817751
06-07 17:27:21.881+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:21.891+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:21.901+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:21:889,-0.026269,-0.033803,0.054870
06-07 17:27:21.901+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:21.911+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:21:911,-0.018056,-0.019940,0.035710
06-07 17:27:21.921+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:21:901,0.070000,0.070000,0.070000
06-07 17:27:21.921+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:21.921+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:21:905,0.272782,-0.083749,9.827322
06-07 17:27:21.921+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:21:927,0.070000,-0.070000,0.070000
06-07 17:27:21.921+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:21.931+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:21.941+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:21.941+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:21.941+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:21.951+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:21:957,971.000000
06-07 17:27:21.961+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:21:954,0.302175,-0.087785,9.801600
06-07 17:27:21.961+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:21:934,0.332602,-0.043071,9.827322
06-07 17:27:21.961+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:21.971+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:21:944,0.013898,-0.026038,0.071587
06-07 17:27:21.971+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:21.971+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:21:978,0.311067,-0.083749,9.882358
06-07 17:27:21.981+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:21:949,0.070000,-0.070000,-0.070000
06-07 17:27:21.981+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:21.991+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:21:987,0.033101,0.003535,0.076377
06-07 17:27:21.991+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:21:994,0.070000,0.070000,-0.070000
06-07 17:27:22.001+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.001+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.021+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:22.021+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:13,0.001289,0.024561,0.021361
06-07 17:27:22.021+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:9,0.320638,-0.088534,9.882358
06-07 17:27:22.021+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.031+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.031+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:22:26,0.070000,0.070000,-0.070000
06-07 17:27:22.031+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:22.041+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:33,0.361316,-0.114855,9.882358
06-07 17:27:22.041+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.051+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:56,0.349352,-0.138784,9.860823
06-07 17:27:22.061+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:38,-0.011074,0.002124,0.040508
06-07 17:27:22.061+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.061+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:22:42,0.140000,0.070000,0.070000
06-07 17:27:22.061+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:22.071+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:22.071+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:22.081+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.081+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:69,0.020256,-0.050352,0.023752
06-07 17:27:22.091+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.101+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:86,0.356531,-0.110070,9.858429
06-07 17:27:22.101+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:22:73,0.070000,0.070000,0.070000
06-07 17:27:22.101+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.111+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:96,-0.033892,-0.011856,0.074075
06-07 17:27:22.111+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.111+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:117,-0.029256,-0.013859,0.026150
06-07 17:27:22.121+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:113,0.323031,-0.098106,9.889536
06-07 17:27:22.121+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.121+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:127,0.299103,-0.102891,9.841680
06-07 17:27:22.131+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.131+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:136,0.010958,-0.018143,0.047628
06-07 17:27:22.141+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.141+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:146,0.325424,-0.069392,9.887143
06-07 17:27:22.141+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:22.141+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:22.141+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:22.151+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:22:158,0.313899,-0.104546,9.801067
06-07 17:27:22.151+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:22:161,971.000000
06-07 17:27:22.171+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:22:153,0.070000,0.070000,0.140000
06-07 17:27:22.171+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.171+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:179,0.013282,0.025584,0.047637
06-07 17:27:22.171+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.181+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.181+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:186,0.315853,-0.102891,9.911072
06-07 17:27:22.191+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.201+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:190,-0.013156,-0.002138,0.059592
06-07 17:27:22.201+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.201+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:207,-0.007233,0.002554,0.071519
06-07 17:27:22.211+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:201,0.315853,-0.071785,9.882358
06-07 17:27:22.211+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.211+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.221+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:218,0.327817,-0.078963,9.860823
06-07 17:27:22.221+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:225,0.002138,-0.035555,0.066740
06-07 17:27:22.231+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.231+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.241+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:236,0.363709,-0.057428,9.851252
06-07 17:27:22.241+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.251+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:242,-0.000645,0.019008,0.026093
06-07 17:27:22.251+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.251+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:259,-0.003069,0.003865,0.057194
06-07 17:27:22.261+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:252,0.301496,-0.081356,9.851252
06-07 17:27:22.261+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.271+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.271+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:22.271+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:22.271+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:272,0.315853,-0.102891,9.853643
06-07 17:27:22.281+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.281+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:280,0.023543,-0.024950,0.035647
06-07 17:27:22.281+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.291+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:295,0.049143,-0.031157,0.014145
06-07 17:27:22.301+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:287,0.323031,-0.040678,9.870394
06-07 17:27:22.301+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.301+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:307,0.378066,-0.112463,9.836893
06-07 17:27:22.311+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.311+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:317,0.030373,-0.008356,0.047722
06-07 17:27:22.311+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.321+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.321+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:326,0.034355,0.020536,0.023821
06-07 17:27:22.331+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:322,0.275175,-0.105284,9.820145
06-07 17:27:22.331+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.331+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.341+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:22.341+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:22.341+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:22.361+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:22:354,0.314639,-0.105799,9.801030
06-07 17:27:22.371+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:22:355,0.070000,0.070000,0.070000
06-07 17:27:22.381+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:22:359,972.000000
06-07 17:27:22.381+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:339,0.337388,-0.090927,9.812965
06-07 17:27:22.391+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.391+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:396,0.289532,-0.122034,9.856036
06-07 17:27:22.391+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.401+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:404,0.296710,-0.110070,9.836893
06-07 17:27:22.401+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.401+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:410,0.327817,-0.117248,9.872787
06-07 17:27:22.401+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.411+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:415,0.346959,-0.088534,9.877571
06-07 17:27:22.411+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.411+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:420,0.315853,-0.066999,9.822537
06-07 17:27:22.421+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.421+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:426,0.303888,-0.088534,9.841680
06-07 17:27:22.421+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.431+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:432,0.334995,-0.141177,9.824929
06-07 17:27:22.431+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.431+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:438,0.282353,-0.105284,9.875179
06-07 17:27:22.431+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.441+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:443,0.284746,-0.107677,9.827322
06-07 17:27:22.441+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.441+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:449,0.323031,-0.112463,9.848858
06-07 17:27:22.441+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.451+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:344,-0.028777,0.000246,0.042982
06-07 17:27:22.451+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.461+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:465,-0.039165,-0.031006,0.076428
06-07 17:27:22.471+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:455,0.325424,-0.069392,9.848858
06-07 17:27:22.471+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.471+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:22.471+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:22.481+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.491+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:483,0.299103,-0.095713,9.860823
06-07 17:27:22.491+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.491+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:488,-0.003412,-0.041606,0.057228
06-07 17:27:22.501+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.501+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:500,0.303888,-0.090927,9.872787
06-07 17:27:22.511+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:513,-0.020897,-0.002042,0.074039
06-07 17:27:22.511+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.521+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.531+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:524,0.313460,-0.129212,9.868000
06-07 17:27:22.531+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:529,0.028028,-0.007224,0.085741
06-07 17:27:22.531+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.541+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:22.541+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:22.551+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:22:555,973.000000
06-07 17:27:22.561+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:22:553,0.324970,-0.103670,9.800715
06-07 17:27:22.561+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:22.571+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:22:575,0.070000,0.070000,0.140000
06-07 17:27:22.571+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.581+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:545,0.311067,-0.076570,9.827322
06-07 17:27:22.581+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.591+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:585,-0.005261,0.026963,0.059570
06-07 17:27:22.591+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.601+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:594,0.308674,-0.090927,9.858429
06-07 17:27:22.601+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.601+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:598,0.020492,-0.037213,0.064031
06-07 17:27:22.611+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.611+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:616,0.010914,0.023500,0.138565
06-07 17:27:22.621+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:610,0.334995,-0.119641,9.836893
06-07 17:27:22.621+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.621+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.631+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:634,0.017818,-0.005375,0.023714
06-07 17:27:22.631+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:628,0.361316,-0.126820,9.815358
06-07 17:27:22.631+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.651+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.651+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:645,0.344566,-0.105284,9.848858
06-07 17:27:22.651+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.651+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:656,0.014042,-0.021906,0.002404
06-07 17:27:22.651+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.671+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:663,0.349352,-0.076570,9.824929
06-07 17:27:22.671+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:22.671+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:22.671+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:668,0.047377,-0.018226,0.031452
06-07 17:27:22.671+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.681+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.691+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:683,0.287139,-0.095713,9.844072
06-07 17:27:22.691+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.701+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:688,-0.001705,0.036802,0.022576
06-07 17:27:22.701+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.701+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:705,0.275175,-0.126820,9.877571
06-07 17:27:22.711+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:714,0.020955,-0.029100,0.048703
06-07 17:27:22.711+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.721+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.731+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:725,0.308674,-0.138784,9.858429
06-07 17:27:22.731+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.731+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:732,-0.009385,0.000569,0.013043
06-07 17:27:22.731+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.741+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:22.741+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:22.741+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:22.761+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:22:753,0.070000,0.070000,0.070000
06-07 17:27:22.771+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:22:755,975.000000
06-07 17:27:22.771+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:22:755,0.320344,-0.095666,9.800949
06-07 17:27:22.771+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:743,0.014979,0.031567,0.055820
06-07 17:27:22.771+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:741,0.289532,-0.110070,9.875179
06-07 17:27:22.781+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.781+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.791+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:788,0.330210,-0.114855,9.887143
06-07 17:27:22.801+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:790,-0.039416,-0.041182,0.053266
06-07 17:27:22.801+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.801+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.801+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:810,0.301496,-0.081356,9.860823
06-07 17:27:22.811+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:815,-0.005967,0.009706,0.028915
06-07 17:27:22.811+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.811+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.821+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:825,0.010074,0.001649,0.031036
06-07 17:27:22.831+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:824,0.320638,-0.133998,9.865608
06-07 17:27:22.831+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.831+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.851+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:844,0.020959,0.044162,-0.007322
06-07 17:27:22.851+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:846,0.318245,-0.086142,9.939785
06-07 17:27:22.851+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.851+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.861+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:865,-0.001328,-0.017191,0.042871
06-07 17:27:22.871+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:867,0.327817,-0.107677,9.824929
06-07 17:27:22.871+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.871+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:22.871+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:22.881+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.881+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:883,0.009445,-0.003228,0.026047
06-07 17:27:22.881+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:888,0.330210,-0.126820,9.803394
06-07 17:27:22.891+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.891+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.891+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:897,0.004765,0.013327,0.040400
06-07 17:27:22.901+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:904,0.370888,-0.131605,9.832108
06-07 17:27:22.901+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.911+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.921+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:921,0.016307,0.009948,0.085748
06-07 17:27:22.921+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:922,0.339781,-0.083749,9.822537
06-07 17:27:22.921+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.921+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.941+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:933,0.036732,-0.033048,0.025922
06-07 17:27:22.941+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:935,0.361316,-0.136391,9.848858
06-07 17:27:22.941+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:22.941+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:22.941+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:22.941+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:22.971+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:22:955,0.323981,-0.095337,9.800833
06-07 17:27:22.971+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:22:955,977.000000
06-07 17:27:22.971+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:22:953,0.070000,0.070000,0.070000
06-07 17:27:22.981+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.991+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:22:982,0.005409,-0.028287,0.040678
06-07 17:27:22.991+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:22:986,0.334995,-0.114855,9.812965
06-07 17:27:22.991+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:22.991+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:23.001+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:23:1,-0.043734,0.006044,0.028755
06-07 17:27:23.001+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:2,0.351745,-0.081356,9.856036
06-07 17:27:23.011+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:23.011+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.021+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:23:19,0.035533,-0.010223,0.030493
06-07 17:27:23.031+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:23,0.296710,-0.141177,9.853643
06-07 17:27:23.031+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:23.031+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.031+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:39,0.313460,-0.102891,9.829715
06-07 17:27:23.041+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:23:39,0.041592,0.028128,0.014099
06-07 17:27:23.041+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.051+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:23.061+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:23:60,0.001522,-0.034596,0.028727
06-07 17:27:23.061+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:57,0.323031,-0.105284,9.832108
06-07 17:27:23.061+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.061+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:23.071+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:23.071+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:23.081+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:73,0.332602,-0.059821,9.793823
06-07 17:27:23.081+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:23:75,-0.008397,0.001915,0.043114
06-07 17:27:23.081+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.091+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:23.101+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:91,0.313460,-0.105284,9.844072
06-07 17:27:23.101+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.101+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:23:98,-0.016400,-0.030853,0.052540
06-07 17:27:23.101+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:23.121+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:111,0.320638,-0.095713,9.827322
06-07 17:27:23.121+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:23:115,0.023380,0.016705,0.021329
06-07 17:27:23.121+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.121+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:23.121+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:131,0.315853,-0.078963,9.841680
06-07 17:27:23.131+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:23:136,-0.031228,-0.006879,0.042932
06-07 17:27:23.141+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.151+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:23.151+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:23.151+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:23.161+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:23:160,979.000000
06-07 17:27:23.171+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:23:162,0.070000,0.070000,0.070000
06-07 17:27:23.171+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:23:162,0.319673,-0.098116,9.800947
06-07 17:27:23.181+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:23.181+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:23:188,0.027833,0.001312,0.030552
06-07 17:27:23.181+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:147,0.325424,-0.076570,9.887143
06-07 17:27:23.181+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.201+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:23.201+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:200,0.346959,-0.114855,9.827322
06-07 17:27:23.201+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.211+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:23:207,0.004443,0.022467,0.040226
06-07 17:27:23.211+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:23.221+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:217,0.325424,-0.119641,9.841680
06-07 17:27:23.221+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:23:223,0.039999,-0.055784,0.044865
06-07 17:27:23.231+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.231+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:23.241+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:237,0.275175,-0.093320,9.829715
06-07 17:27:23.241+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:23:241,0.011525,-0.007916,0.040612
06-07 17:27:23.241+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.251+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:23.261+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:252,0.334995,-0.105284,9.832108
06-07 17:27:23.261+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:23:263,0.041892,0.002908,0.023899
06-07 17:27:23.261+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.271+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:23.271+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:23.271+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:23.281+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:273,0.351745,-0.069392,9.815358
06-07 17:27:23.281+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:23:277,-0.004332,0.019921,0.031393
06-07 17:27:23.281+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.291+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:23.301+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:23:303,0.019437,-0.002440,-0.014304
06-07 17:27:23.301+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:296,0.323031,-0.122034,9.829715
06-07 17:27:23.311+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.311+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:23.321+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:23:323,-0.003343,-0.012340,0.038453
06-07 17:27:23.321+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:318,0.311067,-0.095713,9.844072
06-07 17:27:23.321+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.341+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:332,0.299103,-0.126820,9.853643
06-07 17:27:23.341+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.341+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:23.341+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:23.341+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:23.351+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:23:355,979.000000
06-07 17:27:23.361+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:23.391+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:23:354,0.070000,0.070000,0.070000
06-07 17:27:23.391+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:23:354,0.316695,-0.113255,9.800880
06-07 17:27:23.391+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:23:370,-0.001427,-0.050239,0.052696
06-07 17:27:23.401+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:350,0.332602,-0.088534,9.822537
06-07 17:27:23.401+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.411+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:413,0.282353,-0.105284,9.844072
06-07 17:27:23.411+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.421+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:424,0.327817,-0.098106,9.832108
06-07 17:27:23.421+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.431+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:435,0.308674,-0.074178,9.841680
06-07 17:27:23.431+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.441+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:444,0.342174,-0.143569,9.846465
06-07 17:27:23.441+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.451+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:454,0.325424,-0.112463,9.841680
06-07 17:27:23.451+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.461+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:464,0.356531,-0.102891,9.824929
06-07 17:27:23.461+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.461+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:470,0.320638,-0.083749,9.832108
06-07 17:27:23.471+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:23.471+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:23.471+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.481+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:483,0.339781,-0.098106,9.786645
06-07 17:27:23.481+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.501+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:494,0.320638,-0.107677,9.839286
06-07 17:27:23.501+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.511+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:514,0.318245,-0.148355,9.853643
06-07 17:27:23.541+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:23.551+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:23.551+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:23.551+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:23.561+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:23:560,0.008729,0.043863,0.036013
06-07 17:27:23.571+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:23:561,0.070000,0.070000,0.070000
06-07 17:27:23.571+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:23:557,982.000000
06-07 17:27:23.571+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:23:562,0.316340,-0.097246,9.801064
06-07 17:27:23.581+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:23.581+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:23:591,0.325424,-0.069392,9.836893
06-07 17:27:23.641+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11213086c6f63152838511
