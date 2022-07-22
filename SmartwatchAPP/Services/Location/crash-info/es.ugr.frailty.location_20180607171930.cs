S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 19979
Date: 2018-06-07 17:19:30+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf76f452d, r5   = 0xf7c89f98
r6   = 0xffdae010, r7   = 0xffdadec0
r8   = 0xf7c86c18, r9   = 0x00000000
r10  = 0xffdadf9c, fp   = 0xffdae010
ip   = 0x00000001, sp   = 0xffdade98
lr   = 0xf76f4539, pc   = 0xf775d228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    319576 KB
Buffers:      3120 KB
Cached:      58472 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11440 KB
VmRSS:       11436 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 19979 TID = 19979
19979 20032 

Maps Information
f45bf000 f4dbe000 rw-p [stack:20032]
f4dc5000 f4dc7000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4dcf000 f4dd3000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4ddc000 f4dde000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4de6000 f4de9000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4df8000 f4dfd000 r-xp /usr/lib/libsystem.so.0.0.0
f4e08000 f4e0b000 r-xp /lib/libattr.so.1.1.0
f4e13000 f4e23000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e2b000 f4e34000 r-xp /usr/lib/libedbus.so.1.7.99
f4e3c000 f4e3d000 r-xp /usr/lib/libresponse.so.0.2.96
f4e46000 f4e4b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f66ed000 f67f3000 r-xp /usr/lib/libicuuc.so.57.1
f6809000 f6991000 r-xp /usr/lib/libicui18n.so.57.1
f69a1000 f69ae000 r-xp /usr/lib/libail.so.0.1.0
f69b7000 f69be000 r-xp /usr/lib/libminizip.so.1.0.0
f69c7000 f6b70000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b90000 f6bd7000 r-xp /usr/lib/libssl.so.1.0.0
f6be3000 f6be5000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6bed000 f6bf4000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6bfd000 f6c04000 r-xp /lib/libcrypt-2.13.so
f6c35000 f6c38000 r-xp /lib/libcap.so.2.21
f6c40000 f6c42000 r-xp /usr/lib/libiri.so
f6c4a000 f6c93000 r-xp /usr/lib/libmdm.so.1.2.69
f6c9b000 f6ca1000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6ca9000 f6ccc000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6cd6000 f6cd8000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ce0000 f6cfd000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d06000 f6d0a000 r-xp /usr/lib/libsmack.so.1.0.0
f6d13000 f6d2c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d35000 f6d3d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d45000 f6d4b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d54000 f6d56000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d5f000 f6d6f000 r-xp /lib/libresolv-2.13.so
f6d73000 f6d8b000 r-xp /usr/lib/liblzma.so.5.0.3
f6d94000 f6d96000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d9e000 f6db8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6dc0000 f6def000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6df8000 f6e07000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e11000 f6e1b000 r-xp /usr/lib/libsensord-shared.so
f6e24000 f6ef7000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f02000 f6f18000 r-xp /lib/libz.so.1.2.5
f6f20000 f6f25000 r-xp /usr/lib/libffi.so.5.0.10
f6f2d000 f6f2e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f36000 f6f46000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f4e000 f6f67000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f6f000 f6f71000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f79000 f6fee000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ff8000 f6ffe000 r-xp /lib/librt-2.13.so
f7007000 f7025000 r-xp /usr/lib/libsystemd.so.0.4.0
f702f000 f7030000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7038000 f705b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7063000 f7068000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7070000 f709a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f70a3000 f70ba000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70c2000 f712b000 r-xp /lib/libm-2.13.so
f7134000 f71c8000 r-xp /usr/lib/libstdc++.so.6.0.16
f71db000 f71e0000 r-xp /usr/lib/libctx-client.so.0.8.3
f71e8000 f71ef000 r-xp /usr/lib/libctx-shared.so.0.8.3
f71f7000 f7221000 r-xp /usr/lib/libsensor.so.1.9.6
f722a000 f72f6000 r-xp /usr/lib/libxml2.so.2.7.8
f7303000 f7305000 r-xp /usr/lib/libiniparser.so.0
f730e000 f7314000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f731d000 f73ed000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f73ee000 f7422000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f742b000 f7467000 r-xp /usr/lib/libSLP-location.so.0.9.24
f746f000 f7472000 r-xp /usr/lib/libbundle.so.0.1.22
f747a000 f7480000 r-xp /usr/lib/libappsvc.so.0.1.0
f7488000 f74c9000 r-xp /usr/lib/libeina.so.1.7.99
f74d2000 f74e9000 r-xp /usr/lib/libecore.so.1.7.99
f7500000 f7509000 r-xp /usr/lib/libvconf.so.0.2.45
f7511000 f7525000 r-xp /lib/libpthread-2.13.so
f7530000 f753d000 r-xp /usr/lib/libaul.so.0.1.0
f7547000 f7549000 r-xp /lib/libdl-2.13.so
f7552000 f755d000 r-xp /lib/libunwind.so.8.0.1
f758a000 f7592000 r-xp /lib/libgcc_s-4.6.so.1
f7593000 f76b7000 r-xp /lib/libc-2.13.so
f76c5000 f76c7000 r-xp /usr/lib/libdlog.so.0.0.0
f76cf000 f76db000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f76e4000 f76e9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f76f1000 f7700000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7708000 f770c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7715000 f7718000 r-xp /usr/lib/libappcore-agent.so.1.1
f7720000 f7722000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f772a000 f772e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7736000 f7753000 r-xp /lib/ld-2.13.so
f775c000 f775f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f775f000 f7763000 r-xp /usr/lib/libsys-assert.so
f7c56000 f7cc7000 rw-p [heap]
ffd8f000 ffdb0000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19979)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf775d228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf76f4539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73fb3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf73f9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7405e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf740bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf740bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf744075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf743b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf73f9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7405e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf740bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf740bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf743de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf743e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7445f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4ddd1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4dd0171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ea3663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7350fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73527a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf74e2ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf74ddb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74de5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf74de879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7716183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf77167fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf775d5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf75aa85c) [/lib/libc.so.6] + 0x1785c
29: (0xf775cf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
0000,0.070000
06-07 17:19:48.641+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:48.651+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:48.651+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:19:48.661+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:19:48:662,948.000000
06-07 17:19:48.661+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:48:644,0.303287,-0.095333,9.801496
06-07 17:19:48.671+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:48:655,0.070000,0.070000,0.070000
06-07 17:19:48.681+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:48.701+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:48.701+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:48:706,0.304498,-0.094623,9.801465
06-07 17:19:48.701+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:48:696,0.294317,-0.100499,9.824929
06-07 17:19:48.711+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:48:687,0.016678,-0.004167,0.068861
06-07 17:19:48.711+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:48.711+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:48.711+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:48.741+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:48:727,0.016416,0.010186,0.071261
06-07 17:19:48.751+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:48.751+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:48:723,0.070000,0.070000,0.070000
06-07 17:19:48.751+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:48:756,0.305931,-0.092740,9.801438
06-07 17:19:48.751+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:48.751+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:48.761+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:48:732,0.275175,-0.078963,9.824929
06-07 17:19:48.761+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:48.791+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:48:767,0.070000,0.070000,0.070000
06-07 17:19:48.801+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:48.801+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:48:771,0.002119,-0.048075,0.052110
06-07 17:19:48.821+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:48:772,0.284746,-0.045464,9.832108
06-07 17:19:48.831+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:48.831+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:48.831+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:48.841+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:19:48.841+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:19:48.861+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:19:48.871+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:19:48:867,942.000000
06-07 17:19:48.881+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:48:817,0.308155,-0.091637,9.801379
06-07 17:19:48.881+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:48:845,0.287139,-0.129212,9.801002
06-07 17:19:48.891+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:48.891+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:48:840,0.002312,0.013809,0.035372
06-07 17:19:48.901+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:48:841,0.140000,0.070000,0.070000
06-07 17:19:48.901+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:48.901+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:48:904,0.309603,-0.092189,9.801328
06-07 17:19:48.901+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:48.911+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:48.931+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:48.961+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:48:930,0.070000,0.070000,0.070000
06-07 17:19:48.971+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:48:918,0.048306,-0.006207,0.035347
06-07 17:19:48.971+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:48:935,0.351745,-0.102891,9.851252
06-07 17:19:48.971+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:48.971+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:48.981+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:48:988,0.021820,-0.008127,0.040217
06-07 17:19:48.981+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:48.991+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:48:947,0.307708,-0.091323,9.801395
06-07 17:19:48.991+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:49.001+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:48:982,0.070000,0.070000,0.070000
06-07 17:19:49.001+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:48:997,0.296710,-0.107677,9.824929
06-07 17:19:49.011+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:49.011+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:49.031+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:49.031+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:49:6,0.308235,-0.092294,9.801371
06-07 17:19:49.031+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:49.041+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:19:49.041+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:19:49.041+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:49:20,0.070000,0.070000,0.070000
06-07 17:19:49.041+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:49:25,0.046768,-0.038688,0.047444
06-07 17:19:49.041+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:49:45,0.308794,-0.092562,9.801350
06-07 17:19:49.051+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:19:49.051+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:19:49:60,1012.000000
06-07 17:19:49.051+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:49.061+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:49.061+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:49:67,0.070000,0.070000,0.070000
06-07 17:19:49.071+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:49:44,0.320638,-0.105284,9.796216
06-07 17:19:49.071+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:49.071+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:49.081+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:49:76,0.005745,0.011112,0.057119
06-07 17:19:49.091+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:49.101+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:49.101+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:49:90,0.327817,-0.105284,9.832108
06-07 17:19:49.111+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:49.111+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:49:94,0.306474,-0.092760,9.801421
06-07 17:19:49.111+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:49.161+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:49:105,0.140000,0.070000,0.070000
06-07 17:19:49.201+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:49:114,0.021940,-0.022761,0.033206
06-07 17:19:49.241+0200 I/servicemanager(19582): es.ugr.frailty.accelerometer alive timeout
06-07 17:19:49.241+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:19:49.251+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:19:49.261+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:19:49.301+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:19:49.301+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:19:49.301+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:19:49.311+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19935
06-07 17:19:49.321+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:19:49:266,1026.000000
06-07 17:19:49.321+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:49.321+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19935)
06-07 17:19:49.321+0200 I/servicemanager(19582): es.ugr.frailty.accelerometer launch request sent!
06-07 17:19:49.321+0200 I/servicemanager(19582): App control destroyed.
06-07 17:19:49.321+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope alive timeout
06-07 17:19:49.321+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:19:49.321+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:19:49.321+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:19:49.331+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20019
06-07 17:19:49.341+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20019)
06-07 17:19:49.341+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope launch request sent!
06-07 17:19:49.341+0200 I/servicemanager(19582): App control destroyed.
06-07 17:19:49.341+0200 I/servicemanager(19582): es.ugr.frailty.heartrate alive timeout
06-07 17:19:49.341+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:19:49.341+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:19:49.341+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:19:49.351+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19621
06-07 17:19:49.351+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:19:49.351+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(32) , send fd(15), pid(19621), cmd(0)
06-07 17:19:49.361+0200 W/CAPI_APPFW_APP_CONTROL(19621): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:19:49.361+0200 I/utils   (19621): specific action
06-07 17:19:49.361+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19621)
06-07 17:19:49.361+0200 I/servicemanager(19582): es.ugr.frailty.heartrate launch request sent!
06-07 17:19:49.361+0200 I/servicemanager(19582): App control destroyed.
06-07 17:19:49.361+0200 I/servicemanager(19582): es.ugr.frailty.location alive timeout
06-07 17:19:49.361+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:19:49.361+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:19:49.371+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:19:49.381+0200 W/AUL_AMD ( 2479): amd_launch.c: start_process(606) > child process: 20076
06-07 17:19:49.381+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 3
06-07 17:19:49.411+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:49:125,0.325424,-0.086142,9.868000
06-07 17:19:49.411+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:49.411+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:49:417,0.346959,-0.086142,9.836893
06-07 17:19:49.411+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:49.411+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:49:422,0.318245,-0.066999,9.844072
06-07 17:19:49.431+0200 E/CAPI_APPFW_APPLICATION(20076): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-07 17:19:49.431+0200 E/CAPI_APPFW_APPLICATION(20076): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-07 17:19:49.461+0200 W/AUL_AMD ( 2479): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20076
06-07 17:19:49.461+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(20076) type(svcapp) bg(0)
06-07 17:19:49.461+0200 W/STARTER ( 2696): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20076]
06-07 17:19:49.461+0200 W/AUL_AMD ( 2479): amd_status.c: __socket_monitor_cb(1277) > (20076) was created
06-07 17:19:49.491+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:19:49.501+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20076
06-07 17:19:49.501+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:19:49.511+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20076
06-07 17:19:49.511+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 17:19:49.521+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 17:19:49.531+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20076)
06-07 17:19:49.531+0200 I/servicemanager(19582): es.ugr.frailty.location launch request sent!
06-07 17:19:49.531+0200 I/servicemanager(19582): App control destroyed.
06-07 17:19:49.531+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration alive timeout
06-07 17:19:49.531+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:19:49.531+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:19:49.531+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:19:49.541+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19983
06-07 17:19:49.541+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19983)
06-07 17:19:49.541+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:19:49.551+0200 I/servicemanager(19582): App control destroyed.
06-07 17:19:49.551+0200 I/servicemanager(19582): es.ugr.frailty.gravity alive timeout
06-07 17:19:49.551+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:19:49.551+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:19:49.551+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:19:49.561+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19995
06-07 17:19:49.561+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19995)
06-07 17:19:49.561+0200 I/servicemanager(19582): es.ugr.frailty.gravity launch request sent!
06-07 17:19:49.561+0200 I/servicemanager(19582): App control destroyed.
06-07 17:19:49.561+0200 I/servicemanager(19582): es.ugr.frailty.pressure alive timeout
06-07 17:19:49.571+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:19:49.571+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:19:49.571+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:19:49.581+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19663
06-07 17:19:49.581+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19663)
06-07 17:19:49.581+0200 I/servicemanager(19582): es.ugr.frailty.pressure launch request sent!
06-07 17:19:49.581+0200 I/servicemanager(19582): App control destroyed.
06-07 17:19:49.581+0200 I/servicemanager(19582): es.ugr.frailty.light alive timeout
06-07 17:19:49.581+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:19:49.591+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:19:49.591+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:19:49.601+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19670
06-07 17:19:49.601+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19670)
06-07 17:19:49.601+0200 I/servicemanager(19582): es.ugr.frailty.light launch request sent!
06-07 17:19:49.601+0200 I/servicemanager(19582): App control destroyed.
06-07 17:19:49.601+0200 I/servicemanager(19582): es.ugr.frailty.pedometer alive timeout
06-07 17:19:49.601+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:19:49.601+0200 W/CAPI_APPFW_APP_CONTROL(19670): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:19:49.611+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:19:49.611+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:19:49.621+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19682
06-07 17:19:49.621+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:19:49.621+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(35) , send fd(15), pid(19670), cmd(0)
06-07 17:19:49.621+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19682)
06-07 17:19:49.621+0200 I/servicemanager(19582): es.ugr.frailty.pedometer launch request sent!
06-07 17:19:49.621+0200 I/utils   (19670): specific action
06-07 17:19:49.621+0200 I/servicemanager(19582): App control destroyed.
06-07 17:19:49.631+0200 W/LOCATION(20076): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
06-07 17:19:49.631+0200 E/LOCATION(20076): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
06-07 17:19:49.631+0200 E/PKGMGR_INFO(20076): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
06-07 17:19:49.651+0200 W/LOCATION(20076): module-internal.c: module_is_supported(340) > module name(gps) is found
06-07 17:19:49.701+0200 I/LOCATION(20076): location.c: location_new(269) > method: 0
06-07 17:19:49.701+0200 W/LOCATION(20076): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
06-07 17:19:49.711+0200 W/LOCATION(20076): module-internal.c: module_is_supported(340) > module name(gps) is found
06-07 17:19:49.721+0200 W/LOCATION(20076): module-internal.c: module_is_supported(340) > module name(gps) is found
06-07 17:19:49.731+0200 W/LOCATION(20076): module-internal.c: module_new(311) > module (gps) open success
06-07 17:19:49.751+0200 W/LOCATION(20076): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
06-07 17:19:49.751+0200 W/LOCATION(20076): module-internal.c: module_new(311) > module (remote_gps) open success
06-07 17:19:49.761+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:19:49.761+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(34) , send fd(15), pid(19663), cmd(0)
06-07 17:19:49.761+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:19:49.761+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:19:49.761+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:19:49.771+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:19:49.771+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(36) , send fd(15), pid(19682), cmd(0)
06-07 17:19:49.781+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:19:49.781+0200 W/CAPI_APPFW_APP_CONTROL(19663): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:19:49.781+0200 W/CAPI_APPFW_APP_CONTROL(19682): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:19:49.781+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:19:49.781+0200 I/utils   (19682): specific action
06-07 17:19:49.781+0200 I/utils   (19663): specific action
06-07 17:19:49.781+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:19:49:773,1047.000000
06-07 17:19:49.781+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:19:49.781+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:19:49:790,1046.000000
06-07 17:19:49.791+0200 W/LOCATION(20076): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
06-07 17:19:49.791+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:49.791+0200 W/LOCATION(20076): location-gps.c: __update_remote_connection_status(362) > update FALSE
06-07 17:19:49.791+0200 W/LOCATION(20076): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
06-07 17:19:49.801+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:49.801+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:49:127,0.305189,-0.092128,9.801467
06-07 17:19:49.811+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:49:815,0.313460,-0.090927,9.805787
06-07 17:19:49.821+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:49:797,-0.019694,-0.007480,0.035637
06-07 17:19:49.821+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:49.821+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:49:812,0.140000,0.070000,0.070000
06-07 17:19:49.831+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:49.841+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:49.841+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:19:49.841+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:19:49.841+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:49.851+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:19:49.871+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:19:49:865,1046.000000
06-07 17:19:49.871+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:49:832,0.305238,-0.092257,9.801464
06-07 17:19:49.871+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:49:872,0.318245,-0.074178,9.877571
06-07 17:19:49.871+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:49:851,-0.013787,-0.002465,0.057139
06-07 17:19:49.881+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:49.891+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:49.891+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:49:855,0.070000,0.070000,0.070000
06-07 17:19:49.891+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:49.911+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:49:893,0.303575,-0.091628,9.801522
06-07 17:19:49.911+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:49.911+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:49:904,-0.024598,0.018994,0.066673
06-07 17:19:49.921+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:49:921,0.303888,-0.124427,9.817751
06-07 17:19:49.931+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:49.941+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:49.941+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:49:911,0.070000,0.070000,0.070000
06-07 17:19:49.941+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:49.951+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:49.951+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:49:952,0.015320,0.015479,0.037897
06-07 17:19:49.961+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:49:967,0.373280,-0.076570,9.820145
06-07 17:19:49.991+0200 W/LOCATION(20076): module-internal.c: module_is_supported(340) > module name(wps) is found
06-07 17:19:50.001+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:49:943,0.302895,-0.091631,9.801543
06-07 17:19:50.001+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:49:953,0.070000,0.070000,0.070000
06-07 17:19:50.001+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:50.001+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:50.011+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:50.011+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:50:17,0.303849,-0.089753,9.801531
06-07 17:19:50.021+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:50.041+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:50:26,0.004747,0.029270,-0.005147
06-07 17:19:50.041+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:50.041+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:50:27,0.070000,0.070000,0.070000
06-07 17:19:50.041+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:50:35,0.318245,-0.126820,9.803394
06-07 17:19:50.051+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:50.051+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:19:50.051+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:19:50:60,1046.000000
06-07 17:19:50.061+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:19:50.061+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:19:50.061+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:50.071+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:50:78,-0.004910,-0.022507,0.018770
06-07 17:19:50.081+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:50:53,0.303960,-0.089153,9.801533
06-07 17:19:50.091+0200 W/LOCATION(20076): module-internal.c: module_is_supported(340) > module name(wps) is found
06-07 17:19:50.091+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:50:82,0.070000,0.070000,0.070000
06-07 17:19:50.091+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:50.101+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:50.101+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:50:106,0.332602,-0.110070,9.812965
06-07 17:19:50.111+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:50.121+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:50.131+0200 W/LOCATION(20076): module-internal.c: module_new(311) > module (wps) open success
06-07 17:19:50.131+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:50.141+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:50:116,0.304222,-0.089150,9.801525
06-07 17:19:50.151+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:50.161+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:50:122,0.005305,-0.021614,0.057043
06-07 17:19:50.161+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:50.161+0200 W/LOCATION(20076): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
06-07 17:19:50.161+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:50:169,0.304163,-0.088316,9.801534
06-07 17:19:50.171+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:50:133,0.070000,0.070000,0.070000
06-07 17:19:50.171+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:50:179,0.015477,0.019711,0.052244
06-07 17:19:50.181+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:50.181+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:50:141,0.368495,-0.074178,9.844072
06-07 17:19:50.181+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:50.201+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:50:188,0.070000,0.070000,0.070000
06-07 17:19:50.201+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:50.201+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:50.211+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(19935) cmd(0)
06-07 17:19:50.211+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:50:215,0.303969,-0.090379,9.801521
06-07 17:19:50.211+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:50.221+0200 W/LOCATION(20076): module-internal.c: module_new(311) > module (remote_wps) open success
06-07 17:19:50.221+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:50:195,0.325424,-0.090927,9.798609
06-07 17:19:50.221+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(20019) cmd(0)
06-07 17:19:50.231+0200 W/LOCATION(20076): location-wps.c: __update_remote_connection_status(215) > update FALSE
06-07 17:19:50.231+0200 W/LOCATION(20076): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
06-07 17:19:50.231+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:50.241+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:50:215,0.005882,-0.014937,0.054627
06-07 17:19:50.241+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:50.251+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:19:50.261+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:19:50.261+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:19:50:266,1046.000000
06-07 17:19:50.261+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:19:50.261+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:50.271+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:50:230,0.070000,0.070000,0.070000
06-07 17:19:50.271+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:50.271+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:50:275,0.303439,-0.089506,9.801546
06-07 17:19:50.281+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:50:277,-0.000956,0.002300,0.045050
06-07 17:19:50.291+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:50:241,0.299103,-0.093320,9.858429
06-07 17:19:50.301+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:50.301+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:50:306,0.277567,-0.095713,9.820145
06-07 17:19:50.311+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:50.311+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:50.321+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:50:290,0.070000,-0.070000,0.070000
06-07 17:19:50.321+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:50.331+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:50:321,0.021261,-0.031524,0.047419
06-07 17:19:50.341+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:50.341+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:50:321,0.305996,-0.089979,9.801462
06-07 17:19:50.341+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:50.341+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(19983) cmd(0)
06-07 17:19:50.341+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:50.351+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:50:335,-0.070000,0.070000,0.070000
06-07 17:19:50.361+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:50.361+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:50:346,0.279960,-0.100499,9.832108
06-07 17:19:50.361+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(19995) cmd(0)
06-07 17:19:50.371+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:50.381+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:50:362,0.004365,0.017303,0.030683
06-07 17:19:50.391+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:50:399,0.303888,-0.098106,9.820145
06-07 17:19:50.391+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:50:361,0.307369,-0.090524,9.801414
06-07 17:19:50.391+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:50.401+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:50.411+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:50:421,0.310107,-0.092468,9.801310
06-07 17:19:50.411+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:50:375,0.070000,0.070000,0.070000
06-07 17:19:50.421+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:50.421+0200 W/LOCATION(20076): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
06-07 17:19:50.421+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:50.431+0200 I/LOCATION(20076): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7d19c18
06-07 17:19:50.431+0200 I/LOCATION(20076): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
06-07 17:19:50.431+0200 I/LOCATION(20076): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7d19c18
06-07 17:19:50.431+0200 I/LOCATION(20076): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
06-07 17:19:50.441+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:50:412,-0.007324,-0.026783,0.045021
06-07 17:19:50.441+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:50.441+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:19:50.441+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:19:50.441+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:50.451+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:19:50.451+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:19:50:460,1046.000000
06-07 17:19:50.461+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:50:429,0.140000,0.070000,0.070000
06-07 17:19:50.471+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:50:457,0.024571,-0.044841,0.068935
06-07 17:19:50.471+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:50.481+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:50:435,0.313460,-0.107677,9.822537
06-07 17:19:50.481+0200 I/location(20076): es.ugr.frailty.location: creado servicio de localización
06-07 17:19:50.481+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:50.481+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:50:475,0.310663,-0.092094,9.801295
06-07 17:19:50.491+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:50:486,0.140000,0.140000,0.070000
06-07 17:19:50.501+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:50.511+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:50.521+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:50:520,-0.002621,-0.004686,0.054623
06-07 17:19:50.521+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:50.531+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:50:495,0.334995,-0.129212,9.822537
06-07 17:19:50.531+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:50.531+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:50:522,0.311619,-0.093019,9.801256
06-07 17:19:50.541+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:50.561+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:50:572,0.005165,-0.004660,0.004354
06-07 17:19:50.571+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:50:537,0.140000,0.140000,0.070000
06-07 17:19:50.571+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:50.581+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:50.591+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:50:547,0.320638,-0.086142,9.829715
06-07 17:19:50.591+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:50.591+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:50:597,0.315853,-0.110070,9.801002
06-07 17:19:50.591+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:50.591+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:50:582,0.310497,-0.093248,9.801290
06-07 17:19:50.601+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:50.601+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:50:586,-0.070000,0.140000,0.070000
06-07 17:19:50.611+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:50.611+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:50:608,0.309344,-0.093171,9.801327
06-07 17:19:50.631+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:50.631+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:50:603,0.015152,-0.004763,0.076125
06-07 17:19:50.631+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:50.631+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:50:639,0.323031,-0.098106,9.863215
06-07 17:19:50.641+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:19:50.641+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:19:50.641+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:50.651+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:19:50.661+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:19:50:661,1041.000000
06-07 17:19:50.661+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:50:629,0.140000,0.070000,0.140000
06-07 17:19:50.661+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:50.681+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:50.681+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:50:645,0.027168,-0.019254,-0.000447
06-07 17:19:50.681+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:50:657,0.307711,-0.092050,9.801389
06-07 17:19:50.681+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:50.701+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:50.711+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:50:677,0.140000,0.070000,0.140000
06-07 17:19:50.711+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:50.711+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:50:693,0.301496,-0.129212,9.868000
06-07 17:19:50.721+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:50:717,0.308713,-0.091483,9.801363
06-07 17:19:50.731+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:50.731+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:50:702,0.002298,0.017372,0.083338
06-07 17:19:50.731+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:50.741+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:50.741+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:50:742,0.287139,-0.133998,9.841680
06-07 17:19:50.751+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:50:758,0.308798,-0.089956,9.801374
06-07 17:19:50.771+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:50:725,0.210000,0.070000,0.070000
06-07 17:19:50.771+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:50:744,0.050586,0.016332,0.042636
06-07 17:19:50.771+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:50.771+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:50:780,0.140000,0.070000,0.070000
06-07 17:19:50.781+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:50.781+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:50.791+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:50.801+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:50.811+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:50:815,0.140000,0.070000,0.070000
06-07 17:19:50.811+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:50:795,0.308674,-0.081356,9.836893
06-07 17:19:50.821+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:50:787,-0.015709,0.015417,0.042681
06-07 17:19:50.821+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:50.831+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:50:805,0.308155,-0.090849,9.801386
06-07 17:19:50.831+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:50.841+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:19:50.841+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:19:50.851+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:50.851+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:19:50.861+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:19:50:861,1040.000000
06-07 17:19:50.881+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:50.911+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:50:845,0.306281,-0.064606,9.805787
06-07 17:19:50.911+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:50:842,0.002238,0.019265,0.076133
06-07 17:19:50.911+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:50.911+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:50:886,0.307554,-0.091495,9.801399
06-07 17:19:50.911+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:50.911+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:50:892,0.140000,0.070000,0.070000
06-07 17:19:50.921+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:50.921+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:50.931+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:50:939,0.140000,0.070000,0.070000
06-07 17:19:50.941+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:50:921,-0.004506,-0.015361,0.025860
06-07 17:19:50.941+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:50:922,0.306281,-0.038285,9.853643
06-07 17:19:50.941+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:50.951+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:50.951+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:50:958,0.003318,-0.010025,0.049774
06-07 17:19:50.951+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:50:935,0.307577,-0.090348,9.801409
06-07 17:19:50.971+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:19:50.971+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:50.981+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:50.991+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:50:988,0.140000,-0.070000,0.140000
06-07 17:19:50.991+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:50:965,0.296710,-0.078963,9.834501
06-07 17:19:51.001+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:51.011+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11199796c6f63152838477
