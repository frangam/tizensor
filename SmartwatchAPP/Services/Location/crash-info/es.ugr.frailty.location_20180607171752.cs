S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 19627
Date: 2018-06-07 17:17:52+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6fd652d, r5   = 0xf7600f98
r6   = 0xff9ef270, r7   = 0xff9ef120
r8   = 0xf75fdc18, r9   = 0x00000000
r10  = 0xff9ef1fc, fp   = 0xff9ef270
ip   = 0x00000001, sp   = 0xff9ef0f8
lr   = 0xf6fd6539, pc   = 0xf703f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    272788 KB
Buffers:     11884 KB
Cached:     110636 KB
VmPeak:      53460 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11844 KB
VmRSS:       11844 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 19627 TID = 19627
19627 19707 

Maps Information
f3ea1000 f46a0000 rw-p [stack:19707]
f46a7000 f46a9000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f46b1000 f46b5000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f46be000 f46c0000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f46c8000 f46cb000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f46da000 f46df000 r-xp /usr/lib/libsystem.so.0.0.0
f46ea000 f46ed000 r-xp /lib/libattr.so.1.1.0
f46f5000 f4705000 r-xp /usr/lib/libmdm-common.so.1.1.24
f470d000 f4716000 r-xp /usr/lib/libedbus.so.1.7.99
f471e000 f471f000 r-xp /usr/lib/libresponse.so.0.2.96
f4728000 f472d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5fcf000 f60d5000 r-xp /usr/lib/libicuuc.so.57.1
f60eb000 f6273000 r-xp /usr/lib/libicui18n.so.57.1
f6283000 f6290000 r-xp /usr/lib/libail.so.0.1.0
f6299000 f62a0000 r-xp /usr/lib/libminizip.so.1.0.0
f62a9000 f6452000 r-xp /usr/lib/libcrypto.so.1.0.0
f6472000 f64b9000 r-xp /usr/lib/libssl.so.1.0.0
f64c5000 f64c7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f64cf000 f64d6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f64df000 f64e6000 r-xp /lib/libcrypt-2.13.so
f6517000 f651a000 r-xp /lib/libcap.so.2.21
f6522000 f6524000 r-xp /usr/lib/libiri.so
f652c000 f6575000 r-xp /usr/lib/libmdm.so.1.2.69
f657d000 f6583000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f658b000 f65ae000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f65b8000 f65ba000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f65c2000 f65df000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f65e8000 f65ec000 r-xp /usr/lib/libsmack.so.1.0.0
f65f5000 f660e000 r-xp /usr/lib/libnetwork.so.0.0.0
f6617000 f661f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6627000 f662d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6636000 f6638000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6641000 f6651000 r-xp /lib/libresolv-2.13.so
f6655000 f666d000 r-xp /usr/lib/liblzma.so.5.0.3
f6676000 f6678000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6680000 f669a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f66a2000 f66d1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f66da000 f66e9000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f66f3000 f66fd000 r-xp /usr/lib/libsensord-shared.so
f6706000 f67d9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f67e4000 f67fa000 r-xp /lib/libz.so.1.2.5
f6802000 f6807000 r-xp /usr/lib/libffi.so.5.0.10
f680f000 f6810000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6818000 f6828000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6830000 f6849000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6851000 f6853000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f685b000 f68d0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f68da000 f68e0000 r-xp /lib/librt-2.13.so
f68e9000 f6907000 r-xp /usr/lib/libsystemd.so.0.4.0
f6911000 f6912000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f691a000 f693d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6945000 f694a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6952000 f697c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6985000 f699c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f69a4000 f6a0d000 r-xp /lib/libm-2.13.so
f6a16000 f6aaa000 r-xp /usr/lib/libstdc++.so.6.0.16
f6abd000 f6ac2000 r-xp /usr/lib/libctx-client.so.0.8.3
f6aca000 f6ad1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ad9000 f6b03000 r-xp /usr/lib/libsensor.so.1.9.6
f6b0c000 f6bd8000 r-xp /usr/lib/libxml2.so.2.7.8
f6be5000 f6be7000 r-xp /usr/lib/libiniparser.so.0
f6bf0000 f6bf6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6bff000 f6ccf000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6cd0000 f6d04000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d0d000 f6d49000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6d51000 f6d54000 r-xp /usr/lib/libbundle.so.0.1.22
f6d5c000 f6d62000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d6a000 f6dab000 r-xp /usr/lib/libeina.so.1.7.99
f6db4000 f6dcb000 r-xp /usr/lib/libecore.so.1.7.99
f6de2000 f6deb000 r-xp /usr/lib/libvconf.so.0.2.45
f6df3000 f6e07000 r-xp /lib/libpthread-2.13.so
f6e12000 f6e1f000 r-xp /usr/lib/libaul.so.0.1.0
f6e29000 f6e2b000 r-xp /lib/libdl-2.13.so
f6e34000 f6e3f000 r-xp /lib/libunwind.so.8.0.1
f6e6c000 f6e74000 r-xp /lib/libgcc_s-4.6.so.1
f6e75000 f6f99000 r-xp /lib/libc-2.13.so
f6fa7000 f6fa9000 r-xp /usr/lib/libdlog.so.0.0.0
f6fb1000 f6fbd000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6fc6000 f6fcb000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6fd3000 f6fe2000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f6fea000 f6fee000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6ff7000 f6ffa000 r-xp /usr/lib/libappcore-agent.so.1.1
f7002000 f7004000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f700c000 f7010000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7018000 f7035000 r-xp /lib/ld-2.13.so
f703e000 f7041000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7041000 f7045000 r-xp /usr/lib/libsys-assert.so
f75cd000 f763c000 rw-p [heap]
ff9d0000 ff9f1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19627)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf703f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf6fd6539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6cdd3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6cdbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6ce7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6cedbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6ceddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6d2275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6d1d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6cdbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6ce7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6cedbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6ceddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6d1fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6d20017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6d27f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf46bf1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf46b2171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6785663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6c32fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6c347a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6dc4ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6dbfb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6dc05a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6dc0879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf6ff8183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf6ff87fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf703f5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6e8c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf703ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
621+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:51.621+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:51:629,-0.017603,0.000885,0.050338
06-07 17:17:51.631+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:51.631+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:51:632,0.070000,0.070000,0.070000
06-07 17:17:51.631+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:51.631+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:51.641+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:51.641+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:51:641,0.320837,-0.086534,9.801019
06-07 17:17:51.641+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:51:637,0.306281,-0.086142,9.851252
06-07 17:17:51.641+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:51.641+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:51:647,0.140000,0.070000,0.070000
06-07 17:17:51.651+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:51:644,0.012597,0.000769,0.064645
06-07 17:17:51.651+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:51:650,0.334995,-0.086142,9.865608
06-07 17:17:51.651+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:51.651+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:51.651+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:51.661+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:51:662,0.070000,0.070000,0.070000
06-07 17:17:51.661+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:51:663,0.320947,-0.086320,9.801017
06-07 17:17:51.661+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:51.671+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:51:662,0.050050,0.031499,0.031090
06-07 17:17:51.671+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:51:669,0.370888,-0.055035,9.832108
06-07 17:17:51.671+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:51.671+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:51.671+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:51.681+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:51:681,0.322462,-0.084717,9.800981
06-07 17:17:51.681+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:51.681+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:51:686,0.327817,-0.078963,9.839286
06-07 17:17:51.681+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:51:681,0.070000,0.070000,0.070000
06-07 17:17:51.681+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:51:680,0.006869,0.007356,0.038269
06-07 17:17:51.691+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:51.691+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:51.701+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:51:702,0.322190,-0.084257,9.800994
06-07 17:17:51.701+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:51:703,0.070000,0.070000,0.070000
06-07 17:17:51.701+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:51.701+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:51.701+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:51:708,0.346959,-0.102891,9.824929
06-07 17:17:51.701+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:51:709,0.024497,-0.018174,0.023949
06-07 17:17:51.711+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:51.711+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:51.721+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:51.721+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:51:722,0.322794,-0.084933,9.800968
06-07 17:17:51.721+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:51.721+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:51:722,0.070000,0.140000,0.070000
06-07 17:17:51.731+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:51:728,0.344566,-0.069392,9.877571
06-07 17:17:51.731+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:51:731,0.022377,0.014866,0.076577
06-07 17:17:51.731+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:51.731+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:51.731+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:51.741+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:51.741+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:51:742,0.323160,-0.084006,9.800964
06-07 17:17:51.741+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:51:742,0.070000,0.070000,0.070000
06-07 17:17:51.751+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:51:748,0.356531,-0.102891,9.824929
06-07 17:17:51.751+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:51:742,0.033736,-0.017958,0.023961
06-07 17:17:51.751+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:51.751+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:51.751+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:51.761+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:17:51.761+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:17:51.761+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:51:763,0.324321,-0.084713,9.800920
06-07 17:17:51.761+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:51.771+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:51:763,0.070000,0.070000,0.070000
06-07 17:17:51.771+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:17:51.771+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:51.781+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:51.781+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:51:772,0.291924,-0.100499,9.824929
06-07 17:17:51.781+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:51.781+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:51:782,0.070000,0.070000,0.070000
06-07 17:17:51.781+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:17:51:782,1027.000000
06-07 17:17:51.781+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:51:786,0.322230,-0.085322,9.800983
06-07 17:17:51.791+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:51:762,-0.031236,-0.016492,0.023965
06-07 17:17:51.791+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:51:789,0.370888,-0.098106,9.870394
06-07 17:17:51.791+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:51.791+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:51.791+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:51:797,0.046567,-0.013392,0.069474
06-07 17:17:51.791+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:51.801+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:51:802,0.070000,0.070000,0.070000
06-07 17:17:51.801+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:51.801+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:51:806,0.041479,-0.029534,0.067017
06-07 17:17:51.801+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:51.811+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:51:812,0.323962,-0.085730,9.800922
06-07 17:17:51.811+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:51:808,0.363709,-0.114855,9.868000
06-07 17:17:51.811+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:51.811+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:51.821+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:51.821+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:51.821+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:51:821,-0.022466,0.004374,0.019222
06-07 17:17:51.821+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:51:821,0.070000,0.140000,0.070000
06-07 17:17:51.821+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:51:828,0.325276,-0.086864,9.800869
06-07 17:17:51.831+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:51:827,0.301496,-0.081356,9.820145
06-07 17:17:51.831+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:51.831+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:51.841+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:51:842,-0.009424,-0.027991,0.000133
06-07 17:17:51.841+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:51:842,0.070000,0.070000,0.070000
06-07 17:17:51.841+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:51.841+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:51.841+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:51:847,0.323675,-0.086424,9.800926
06-07 17:17:51.851+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:51:852,0.315853,-0.114855,9.801002
06-07 17:17:51.851+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:51.851+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:51.851+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:51.861+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:51.861+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:51:865,0.322917,-0.087614,9.800941
06-07 17:17:51.861+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:51:862,-0.003037,-0.021253,0.021611
06-07 17:17:51.861+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:51:862,0.320638,-0.107677,9.822537
06-07 17:17:51.861+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:51:866,0.070000,0.070000,0.070000
06-07 17:17:51.861+0200 I/servicemanager(19582): es.ugr.frailty.accelerometer alive timeout
06-07 17:17:51.871+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:17:51.871+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:17:51.871+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:17:51.871+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:51.881+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:51.881+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:51.881+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19600
06-07 17:17:51.891+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:51:883,-0.009458,-0.034420,0.062275
06-07 17:17:51.891+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19600)
06-07 17:17:51.891+0200 I/servicemanager(19582): es.ugr.frailty.accelerometer launch request sent!
06-07 17:17:51.901+0200 I/servicemanager(19582): App control destroyed.
06-07 17:17:51.901+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope alive timeout
06-07 17:17:51.901+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:17:51.901+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:51.901+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:17:51.901+0200 W/CAPI_APPFW_APP_CONTROL(19600): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:17:51.901+0200 I/utils   (19600): specific action
06-07 17:17:51.901+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:51.901+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:17:51.911+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:51:910,0.313460,-0.122034,9.863215
06-07 17:17:51.911+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:51.911+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:51:917,0.301496,-0.119641,9.870394
06-07 17:17:51.911+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19605
06-07 17:17:51.921+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:17:51.921+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(19600), cmd(0)
06-07 17:17:51.921+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19605)
06-07 17:17:51.921+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope launch request sent!
06-07 17:17:51.921+0200 I/servicemanager(19582): App control destroyed.
06-07 17:17:51.921+0200 I/servicemanager(19582): es.ugr.frailty.heartrate alive timeout
06-07 17:17:51.921+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:17:51.921+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:51.921+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:17:51.921+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:51:894,0.070000,0.070000,0.070000
06-07 17:17:51.931+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:17:51.931+0200 W/CAPI_APPFW_APP_CONTROL(19605): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:17:51.931+0200 I/utils   (19605): specific action
06-07 17:17:51.931+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:51.931+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:51:930,-0.020884,-0.031251,0.069443
06-07 17:17:51.921+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:51:888,0.322380,-0.088390,9.800951
06-07 17:17:51.931+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:51.941+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:51.941+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:51:946,0.321484,-0.089794,9.800968
06-07 17:17:51.941+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:51.941+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19621
06-07 17:17:51.951+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:17:51.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(19605), cmd(0)
06-07 17:17:51.951+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:51:945,0.018297,0.008438,-0.081323
06-07 17:17:51.951+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:51:936,0.070000,0.070000,0.070000
06-07 17:17:51.951+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:51.951+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:17:51.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(19621), cmd(0)
06-07 17:17:51.961+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:51.961+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19621)
06-07 17:17:51.961+0200 W/CAPI_APPFW_APP_CONTROL(19621): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:17:51.961+0200 I/servicemanager(19582): es.ugr.frailty.heartrate launch request sent!
06-07 17:17:51.961+0200 I/servicemanager(19582): App control destroyed.
06-07 17:17:51.961+0200 I/servicemanager(19582): es.ugr.frailty.location alive timeout
06-07 17:17:51.961+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:17:51.961+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:51:961,0.070000,0.140000,0.070000
06-07 17:17:51.961+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:51.961+0200 I/utils   (19621): specific action
06-07 17:17:51.961+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:17:51.961+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:17:51.961+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:17:51.961+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:51:970,0.070000,0.070000,0.070000
06-07 17:17:51.961+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:51.971+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:17:51.971+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:51:951,0.319842,-0.091010,9.801010
06-07 17:17:51.971+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:51.971+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:51:966,0.015153,0.004869,0.031098
06-07 17:17:51.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19627
06-07 17:17:51.981+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:51:980,0.320427,-0.090422,9.800997
06-07 17:17:51.981+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:51.981+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:17:51.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(19627), cmd(0)
06-07 17:17:51.981+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:51.981+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19627)
06-07 17:17:51.981+0200 I/servicemanager(19582): es.ugr.frailty.location launch request sent!
06-07 17:17:51.981+0200 I/servicemanager(19582): App control destroyed.
06-07 17:17:51.981+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration alive timeout
06-07 17:17:51.981+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:17:51.981+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:17:51.991+0200 W/CAPI_APPFW_APP_CONTROL(19627): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:17:51.991+0200 I/utils   (19627): specific action
06-07 17:17:51.991+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:17:51.991+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:17:51.991+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:17:51:994,1127.000000
06-07 17:17:51.991+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:51:934,0.339781,-0.081356,9.719646
06-07 17:17:52.001+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.001+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19639
06-07 17:17:52.001+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:6,0.334995,-0.086142,9.832108
06-07 17:17:52.001+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.001+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19639)
06-07 17:17:52.001+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:17:52.001+0200 I/servicemanager(19582): App control destroyed.
06-07 17:17:52.001+0200 I/servicemanager(19582): es.ugr.frailty.gravity alive timeout
06-07 17:17:52.001+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:17:52.001+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:11,0.294317,-0.081356,9.903893
06-07 17:17:52.011+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.011+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:17:52.011+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:17:52.011+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:15,0.339781,-0.114855,9.834501
06-07 17:17:52.011+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.021+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:21,0.308674,-0.100499,9.858429
06-07 17:17:52.021+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.021+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19651
06-07 17:17:52.021+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:27,0.354138,-0.093320,9.841680
06-07 17:17:52.021+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19651)
06-07 17:17:52.021+0200 I/servicemanager(19582): es.ugr.frailty.gravity launch request sent!
06-07 17:17:52.021+0200 I/servicemanager(19582): App control destroyed.
06-07 17:17:52.021+0200 I/servicemanager(19582): es.ugr.frailty.pressure alive timeout
06-07 17:17:52.021+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:17:52.021+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:17:52.021+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:17:52.031+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:51:994,0.319924,-0.089711,9.801020
06-07 17:17:52.031+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:51:989,-0.026109,0.009066,0.102897
06-07 17:17:52.031+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:51:974,0.210000,0.140000,0.070000
06-07 17:17:52.031+0200 W/CAPI_APPFW_APP_CONTROL(19639): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:17:52.031+0200 I/utils   (19639): specific action
06-07 17:17:52.031+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:52.041+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19663
06-07 17:17:52.041+0200 W/CAPI_APPFW_APP_CONTROL(19651): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:17:52.041+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.041+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:17:52.041+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(19639), cmd(0)
06-07 17:17:52.041+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:17:52.041+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(19651), cmd(0)
06-07 17:17:52.041+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:52.041+0200 I/utils   (19651): specific action
06-07 17:17:52.041+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:52.041+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:17:52.041+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(19663), cmd(0)
06-07 17:17:52.051+0200 W/CAPI_APPFW_APP_CONTROL(19663): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:17:52.051+0200 I/utils   (19663): specific action
06-07 17:17:52.051+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19663)
06-07 17:17:52.051+0200 I/servicemanager(19582): es.ugr.frailty.pressure launch request sent!
06-07 17:17:52.051+0200 I/servicemanager(19582): App control destroyed.
06-07 17:17:52.051+0200 I/servicemanager(19582): es.ugr.frailty.light alive timeout
06-07 17:17:52.051+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:17:52.051+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:17:52.051+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:17:52.051+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:52:42,0.019856,-0.025145,0.033482
06-07 17:17:52.051+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:52:55,0.140000,0.070000,0.070000
06-07 17:17:52.061+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:52.061+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:52:55,0.317873,-0.088945,9.801093
06-07 17:17:52.061+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:49,0.318245,-0.031107,9.872787
06-07 17:17:52.061+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.071+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:52.071+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:52.071+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19670
06-07 17:17:52.081+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:52:70,-0.009199,-0.011553,0.057336
06-07 17:17:52.081+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:72,0.325424,-0.076570,9.920642
06-07 17:17:52.081+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:52:78,0.318537,-0.089973,9.801063
06-07 17:17:52.091+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:52.101+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.101+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:52:76,0.070000,0.070000,0.070000
06-07 17:17:52.101+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:52.101+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:52.111+0200 W/CAPI_APPFW_APP_CONTROL(19670): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:17:52.111+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:17:52.111+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(19670), cmd(0)
06-07 17:17:52.121+0200 I/utils   (19670): specific action
06-07 17:17:52.121+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:52:127,0.140000,0.140000,0.070000
06-07 17:17:52.121+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:110,0.291924,-0.050249,9.829715
06-07 17:17:52.121+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:52:101,0.035601,-0.003347,0.040617
06-07 17:17:52.121+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:52:114,0.317146,-0.090110,9.801106
06-07 17:17:52.131+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:52.131+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.131+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:52.131+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:52.141+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:17:52.141+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:17:52.141+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:17:52.141+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:52:137,0.001099,0.059003,0.071680
06-07 17:17:52.151+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19670)
06-07 17:17:52.151+0200 I/servicemanager(19582): es.ugr.frailty.light launch request sent!
06-07 17:17:52.151+0200 I/servicemanager(19582): App control destroyed.
06-07 17:17:52.151+0200 I/servicemanager(19582): es.ugr.frailty.pedometer alive timeout
06-07 17:17:52.151+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:17:52.161+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:17:52.161+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:17:52.161+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:17:52.161+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:17:52.171+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19682
06-07 17:17:52.181+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:17:52.181+0200 W/CAPI_APPFW_APP_CONTROL(19682): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:17:52.181+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:17:52.181+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(19682), cmd(0)
06-07 17:17:52.181+0200 I/utils   (19682): specific action
06-07 17:17:52.181+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19682)
06-07 17:17:52.181+0200 I/servicemanager(19582): es.ugr.frailty.pedometer launch request sent!
06-07 17:17:52.181+0200 I/servicemanager(19582): App control destroyed.
06-07 17:17:52.191+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:17:52:188,1154.000000
06-07 17:17:52.201+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:140,0.349352,-0.093320,9.841680
06-07 17:17:52.201+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:52.201+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.211+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:52:143,0.318201,-0.090061,9.801072
06-07 17:17:52.211+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:52.211+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:52:149,0.070000,0.140000,0.070000
06-07 17:17:52.211+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:52.221+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:214,0.344566,-0.076570,9.836893
06-07 17:17:52.221+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.221+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:52:208,0.007223,0.013491,0.119570
06-07 17:17:52.221+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:52.231+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:52:216,0.317535,-0.086995,9.801122
06-07 17:17:52.231+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:52.231+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:52:219,0.070000,0.140000,0.070000
06-07 17:17:52.231+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:52.241+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:52:232,-0.025611,0.036746,0.028593
06-07 17:17:52.241+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:52.241+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:229,0.358923,-0.078963,9.832108
06-07 17:17:52.241+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.241+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:52:243,0.070000,0.140000,0.070000
06-07 17:17:52.251+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:52:238,0.317110,-0.086260,9.801142
06-07 17:17:52.251+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:52:248,0.032242,-0.007060,0.040538
06-07 17:17:52.251+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:52.261+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:52.271+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:52.271+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:252,0.308674,-0.081356,9.853643
06-07 17:17:52.271+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.271+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:52:268,0.210000,0.140000,0.070000
06-07 17:17:52.281+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:52:263,0.314850,-0.083983,9.801234
06-07 17:17:52.281+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:52.281+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:52:276,0.029717,0.007412,0.035659
06-07 17:17:52.281+0200 W/LOCATION(19627): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:17:52.281+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:52.291+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:284,0.315853,-0.078963,9.772287
06-07 17:17:52.291+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:52.291+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:52:289,0.315972,-0.084241,9.801196
06-07 17:17:52.291+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:52:300,0.042952,0.005278,0.030912
06-07 17:17:52.291+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.301+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:52:292,0.070000,0.070000,0.070000
06-07 17:17:52.301+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:306,0.323031,-0.076570,9.925428
06-07 17:17:52.301+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:52.301+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:52.301+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:52:311,0.316732,-0.083707,9.801176
06-07 17:17:52.311+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:52:315,0.070000,0.070000,0.070000
06-07 17:17:52.311+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:52.311+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.311+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:52:319,-0.008058,0.002351,0.052467
06-07 17:17:52.321+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:325,0.294317,-0.043071,9.846465
06-07 17:17:52.321+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:52.321+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:52.331+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:52.331+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:52:336,-0.002255,0.004359,-0.028848
06-07 17:17:52.331+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:52:333,0.070000,0.070000,0.070000
06-07 17:17:52.331+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:52:331,0.318107,-0.083322,9.801135
06-07 17:17:52.341+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.341+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:52.341+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:52:349,0.317437,-0.083077,9.801159
06-07 17:17:52.341+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:52.351+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:52.351+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:52:354,0.070000,-0.070000,0.070000
06-07 17:17:52.351+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:345,0.315853,-0.143569,9.870394
06-07 17:17:52.361+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.361+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:17:52.361+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:17:52.361+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:52.361+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:52.371+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:52:357,0.005594,0.006507,0.124269
06-07 17:17:52.371+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:52.371+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:17:52.381+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:17:52:383,1154.000000
06-07 17:17:52.381+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:52:371,0.316949,-0.082721,9.801178
06-07 17:17:52.381+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:367,0.327817,-0.105284,9.836893
06-07 17:17:52.381+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.381+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:52:371,0.070000,0.070000,0.070000
06-07 17:17:52.391+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:52.391+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:52.391+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:52:381,-0.022632,0.039650,0.045287
06-07 17:17:52.401+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:52.401+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:52:408,-0.000726,-0.061359,0.069200
06-07 17:17:52.401+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:394,0.349352,-0.052642,9.858429
06-07 17:17:52.401+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:52:400,0.316579,-0.082210,9.801194
06-07 17:17:52.401+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.411+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:52:400,0.070000,0.070000,0.070000
06-07 17:17:52.411+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:52.411+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:52.421+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:416,0.327817,-0.114855,9.856036
06-07 17:17:52.421+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:52.421+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.421+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:52:421,0.070000,0.140000,0.070000
06-07 17:17:52.431+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:52:428,0.012834,-0.025202,0.035630
06-07 17:17:52.431+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:52:420,0.314983,-0.080082,9.801263
06-07 17:17:52.431+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:52.431+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:52.441+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:52.441+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:52:441,0.140000,0.070000,0.070000
06-07 17:17:52.451+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:435,0.378066,-0.076570,9.901501
06-07 17:17:52.451+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.451+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:52:443,0.314492,-0.082700,9.801257
06-07 17:17:52.451+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:52.461+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:52.461+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:52:448,0.034860,0.030058,0.057172
06-07 17:17:52.461+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:52.471+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:52:466,0.314274,-0.083406,9.801258
06-07 17:17:52.471+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:458,0.313460,-0.102891,9.798609
06-07 17:17:52.471+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.481+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:52:463,0.140000,0.140000,0.070000
06-07 17:17:52.481+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:52.481+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:52:475,0.013543,-0.031450,0.054778
06-07 17:17:52.481+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:52.491+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:52.491+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:485,0.306281,-0.088534,9.856036
06-07 17:17:52.501+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.501+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:52:495,0.314999,-0.081772,9.801249
06-07 17:17:52.501+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:52:493,0.070000,0.140000,0.070000
06-07 17:17:52.501+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:52.501+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:52.511+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:52:500,0.063067,0.005201,0.100252
06-07 17:17:52.511+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:52.511+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:509,0.299103,-0.078963,9.853643
06-07 17:17:52.511+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.521+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:17:52:512,0.070000,0.070000,0.070000
06-07 17:17:52.531+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:17:52:518,0.315218,-0.083130,9.801230
06-07 17:17:52.531+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:17:52.541+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:17:52.541+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:17:52:521,-0.001759,-0.019761,-0.002622
06-07 17:17:52.541+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:17:52.561+0200 W/libgps_d( 3131): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-07 17:17:52.561+0200 W/libgps  ( 3131): [proxy__gps_stop][line = 1067]: called.
06-07 17:17:52.561+0200 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:17:52.561+0200 W/libgps_d( 3131): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-07 17:17:52.561+0200 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-07 17:17:52.561+0200 W/libgps_d( 3131): GpsiHookStateGps              : EXIT
06-07 17:17:52.561+0200 W/libgps_d( 3131): GpsiHookStateIdle             : ENTRY
06-07 17:17:52.561+0200 W/gpsd    ( 3111): HandleIncomingMessage() dest id:0, msg id:2
06-07 17:17:52.561+0200 E/CAPI_LOCATION_MANAGER( 3823): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-07 17:17:52.571+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:17:52.571+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:17:52.581+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:17:52.591+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:17:52:591,1146.000000
06-07 17:17:52.601+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:528,0.344566,-0.081356,9.834501
06-07 17:17:52.601+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.601+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:610,0.311067,-0.102891,9.784252
06-07 17:17:52.601+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.611+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:615,0.346959,-0.069392,9.824929
06-07 17:17:52.611+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.621+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:17:52:622,0.320638,-0.045464,9.839286
06-07 17:17:52.621+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:17:52.621+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11196276c6f63152838467
