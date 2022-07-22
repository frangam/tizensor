S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 25463
Date: 2018-06-07 17:57:44+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf709452d, r5   = 0xf76caf98
r6   = 0xffe4b010, r7   = 0xffe4aec0
r8   = 0xf76c7c18, r9   = 0x00000000
r10  = 0xffe4af9c, fp   = 0xffe4b010
ip   = 0x00000001, sp   = 0xffe4ae98
lr   = 0xf7094539, pc   = 0xf70fd228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    292060 KB
Buffers:      5760 KB
Cached:      96808 KB
VmPeak:      53460 KB
VmSize:      53412 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11752 KB
VmRSS:       11748 KB
VmData:      11140 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 25463 TID = 25463
25463 25533 

Maps Information
f3f5f000 f475e000 rw-p [stack:25533]
f4765000 f4767000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f476f000 f4773000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f477c000 f477e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4786000 f4789000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4798000 f479d000 r-xp /usr/lib/libsystem.so.0.0.0
f47a8000 f47ab000 r-xp /lib/libattr.so.1.1.0
f47b3000 f47c3000 r-xp /usr/lib/libmdm-common.so.1.1.24
f47cb000 f47d4000 r-xp /usr/lib/libedbus.so.1.7.99
f47dc000 f47dd000 r-xp /usr/lib/libresponse.so.0.2.96
f47e6000 f47eb000 r-xp /usr/lib/libproc-stat.so.0.2.96
f608d000 f6193000 r-xp /usr/lib/libicuuc.so.57.1
f61a9000 f6331000 r-xp /usr/lib/libicui18n.so.57.1
f6341000 f634e000 r-xp /usr/lib/libail.so.0.1.0
f6357000 f635e000 r-xp /usr/lib/libminizip.so.1.0.0
f6367000 f6510000 r-xp /usr/lib/libcrypto.so.1.0.0
f6530000 f6577000 r-xp /usr/lib/libssl.so.1.0.0
f6583000 f6585000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f658d000 f6594000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f659d000 f65a4000 r-xp /lib/libcrypt-2.13.so
f65d5000 f65d8000 r-xp /lib/libcap.so.2.21
f65e0000 f65e2000 r-xp /usr/lib/libiri.so
f65ea000 f6633000 r-xp /usr/lib/libmdm.so.1.2.69
f663b000 f6641000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6649000 f666c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6676000 f6678000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6680000 f669d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66a6000 f66aa000 r-xp /usr/lib/libsmack.so.1.0.0
f66b3000 f66cc000 r-xp /usr/lib/libnetwork.so.0.0.0
f66d5000 f66dd000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f66e5000 f66eb000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f66f4000 f66f6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f66ff000 f670f000 r-xp /lib/libresolv-2.13.so
f6713000 f672b000 r-xp /usr/lib/liblzma.so.5.0.3
f6734000 f6736000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f673e000 f6758000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6760000 f678f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6798000 f67a7000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67b1000 f67bb000 r-xp /usr/lib/libsensord-shared.so
f67c4000 f6897000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68a2000 f68b8000 r-xp /lib/libz.so.1.2.5
f68c0000 f68c5000 r-xp /usr/lib/libffi.so.5.0.10
f68cd000 f68ce000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f68d6000 f68e6000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f68ee000 f6907000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f690f000 f6911000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6919000 f698e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6998000 f699e000 r-xp /lib/librt-2.13.so
f69a7000 f69c5000 r-xp /usr/lib/libsystemd.so.0.4.0
f69cf000 f69d0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f69d8000 f69fb000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a03000 f6a08000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a10000 f6a3a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a43000 f6a5a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a62000 f6acb000 r-xp /lib/libm-2.13.so
f6ad4000 f6b68000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b7b000 f6b80000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b88000 f6b8f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6b97000 f6bc1000 r-xp /usr/lib/libsensor.so.1.9.6
f6bca000 f6c96000 r-xp /usr/lib/libxml2.so.2.7.8
f6ca3000 f6ca5000 r-xp /usr/lib/libiniparser.so.0
f6cae000 f6cb4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6cbd000 f6d8d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d8e000 f6dc2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6dcb000 f6e07000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e0f000 f6e12000 r-xp /usr/lib/libbundle.so.0.1.22
f6e1a000 f6e20000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e28000 f6e69000 r-xp /usr/lib/libeina.so.1.7.99
f6e72000 f6e89000 r-xp /usr/lib/libecore.so.1.7.99
f6ea0000 f6ea9000 r-xp /usr/lib/libvconf.so.0.2.45
f6eb1000 f6ec5000 r-xp /lib/libpthread-2.13.so
f6ed0000 f6edd000 r-xp /usr/lib/libaul.so.0.1.0
f6ee7000 f6ee9000 r-xp /lib/libdl-2.13.so
f6ef2000 f6efd000 r-xp /lib/libunwind.so.8.0.1
f6f2a000 f6f32000 r-xp /lib/libgcc_s-4.6.so.1
f6f33000 f7057000 r-xp /lib/libc-2.13.so
f7065000 f7067000 r-xp /usr/lib/libdlog.so.0.0.0
f706f000 f707b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7084000 f7089000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7091000 f70a0000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70a8000 f70ac000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70b5000 f70b8000 r-xp /usr/lib/libappcore-agent.so.1.1
f70c0000 f70c2000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f70ca000 f70ce000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f70d6000 f70f3000 r-xp /lib/ld-2.13.so
f70fc000 f70ff000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f70ff000 f7103000 r-xp /usr/lib/libsys-assert.so
f7697000 f76fd000 rw-p [heap]
ffe2c000 ffe4d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:25463)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf70fd228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7094539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6d9b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6d99c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6da5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6dabbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6dabdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6de075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6ddb1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6d99c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6da5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6dabbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6dabdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6ddde5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6dde017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6de5f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf477d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4770171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6843663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6cf0fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6cf27a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e82ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e7db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e7e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e7e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70b6183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70b67fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70fd5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6f4a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf70fcf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
 17:57:43.611+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:43.611+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:43:612,0.886975,-0.339081,9.760568
06-07 17:57:43.611+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:43.621+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:43:623,-0.013595,0.020836,0.073934
06-07 17:57:43.621+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:43.621+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:43:616,0.140000,-0.140000,0.070000
06-07 17:57:43.621+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:43.631+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:43:629,0.873380,-0.318245,9.834501
06-07 17:57:43.631+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:43:625,0.885173,-0.337589,9.760783
06-07 17:57:43.631+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:43:630,0.140000,0.210000,0.070000
06-07 17:57:43.631+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:43.631+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:43.641+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:43.641+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:43.641+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:43:643,0.043242,0.004987,0.045004
06-07 17:57:43.651+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:43:644,0.886890,-0.337177,9.760641
06-07 17:57:43.651+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:43:648,0.070000,-0.070000,0.140000
06-07 17:57:43.651+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:43:650,0.928415,-0.332602,9.805787
06-07 17:57:43.651+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:43.651+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:43.661+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:43:664,0.888099,-0.337047,9.760536
06-07 17:57:43.661+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:43.661+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:43:664,0.027168,-0.000210,0.033182
06-07 17:57:43.661+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:43:669,0.070000,-0.140000,0.070000
06-07 17:57:43.661+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:43.671+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:43:674,0.914058,-0.337388,9.793823
06-07 17:57:43.671+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:43.671+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:43.681+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:43:683,0.888026,-0.337221,9.760536
06-07 17:57:43.681+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:43.681+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:43:684,0.002031,-0.007519,0.059608
06-07 17:57:43.681+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:43.681+0200 I/heartrate(25441): es.ugr.frailty.heartrate - capturing data
06-07 17:57:43.681+0200 I/heartrate(25441): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:57:43.681+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:43:688,0.890130,-0.344566,9.820145
06-07 17:57:43.681+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:43:691,0.070000,-0.140000,0.070000
06-07 17:57:43.691+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:43.691+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:43.701+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:43:704,0.887558,-0.335558,9.760636
06-07 17:57:43.701+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:43.701+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:43:704,0.006889,0.028547,0.064393
06-07 17:57:43.701+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:43.701+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:43:710,0.070000,0.140000,0.070000
06-07 17:57:43.711+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:43:711,0.894916,-0.308674,9.824929
06-07 17:57:43.711+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:43.711+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:43.721+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:43.721+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:43.731+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:43:724,0.888754,-0.336166,9.760507
06-07 17:57:43.731+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:43:724,0.038464,-0.018580,0.057115
06-07 17:57:43.731+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:43:730,0.926022,-0.354138,9.817751
06-07 17:57:43.731+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:43:730,0.070000,0.070000,0.070000
06-07 17:57:43.731+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:43.731+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:43.741+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:43:743,0.042054,0.013135,0.030924
06-07 17:57:43.741+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:43.741+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:43.741+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:43:744,0.890182,-0.335328,9.760406
06-07 17:57:43.751+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:43:750,0.070000,0.070000,0.070000
06-07 17:57:43.751+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:43:750,0.930808,-0.323031,9.791430
06-07 17:57:43.751+0200 I/light   (25499): es.ugr.frailty.light - capturing data
06-07 17:57:43.751+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:43.761+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:43.771+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:43.771+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:43:771,0.070000,0.070000,0.070000
06-07 17:57:43.781+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:43:766,0.891295,-0.336733,9.760256
06-07 17:57:43.781+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:43:777,0.926022,-0.370888,9.815358
06-07 17:57:43.781+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:43.791+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:43.791+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:43.801+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:57:43.801+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:57:43.801+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:57:43.801+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:43:792,0.890314,-0.337745,9.760310
06-07 17:57:43.801+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:43.801+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:43:797,0.070000,0.140000,0.070000
06-07 17:57:43.801+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:43.811+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:43:814,0.035840,-0.035559,0.054953
06-07 17:57:43.811+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:43:814,0.890499,-0.336379,9.760341
06-07 17:57:43.811+0200 I/light   (25499): es.ugr.frailty.light: SM-R760,07/06/2018,17:57:43:767,1707.000000
06-07 17:57:43.811+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:43.811+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:43.821+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:43:807,0.885344,-0.363709,9.803394
06-07 17:57:43.821+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:43.821+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:43:823,-0.005951,-0.026976,0.043139
06-07 17:57:43.821+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:43.821+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:43:822,0.070000,0.070000,0.070000
06-07 17:57:43.821+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:43.821+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:43:829,0.014172,0.024286,0.023942
06-07 17:57:43.821+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:43.831+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:43:827,0.904487,-0.313460,9.784252
06-07 17:57:43.831+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:43:835,0.018773,0.015741,0.066981
06-07 17:57:43.831+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:43.831+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:43.831+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:43:834,0.890711,-0.335353,9.760356
06-07 17:57:43.841+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:43.841+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:43:843,0.035311,-0.002035,0.019111
06-07 17:57:43.841+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:43:848,0.909273,-0.320638,9.827322
06-07 17:57:43.841+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:43.841+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:43:841,0.070000,0.070000,0.070000
06-07 17:57:43.851+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:43.851+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:43:853,0.891901,-0.335247,9.760251
06-07 17:57:43.851+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:43.851+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:43:856,0.070000,0.070000,0.070000
06-07 17:57:43.851+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:43.861+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:43:865,-0.008950,0.005038,-0.016678
06-07 17:57:43.861+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:43.871+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:43:872,0.891158,-0.334871,9.760332
06-07 17:57:43.871+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:43.871+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:43.881+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:43:884,0.044436,0.050125,0.055026
06-07 17:57:43.881+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:43:859,0.926022,-0.337388,9.779467
06-07 17:57:43.881+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:43.881+0200 I/heartrate(25441): es.ugr.frailty.heartrate - capturing data
06-07 17:57:43.881+0200 I/heartrate(25441): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:57:43.891+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:43:879,0.070000,0.070000,0.140000
06-07 17:57:43.891+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:43.901+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:43.901+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:43.901+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:43:906,0.038244,-0.014710,0.023959
06-07 17:57:43.901+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:43:894,0.892564,-0.332249,9.760293
06-07 17:57:43.901+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:43:901,0.882952,-0.330210,9.743573
06-07 17:57:43.901+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:43.901+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:43.911+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:43:906,0.070000,0.070000,0.070000
06-07 17:57:43.911+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:43.911+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:43:913,0.893885,-0.332733,9.760156
06-07 17:57:43.911+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:43:913,0.935594,-0.284746,9.815358
06-07 17:57:43.911+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:43.911+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:43.911+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:43.921+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:43:924,0.032137,-0.030976,0.069559
06-07 17:57:43.921+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:43:917,0.070000,0.070000,0.070000
06-07 17:57:43.921+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:43:922,0.930808,-0.346959,9.784252
06-07 17:57:43.921+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:43.921+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:43.921+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:43:929,0.926022,-0.363709,9.829715
06-07 17:57:43.921+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:43:931,0.070000,0.070000,0.070000
06-07 17:57:43.931+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:43:924,0.894747,-0.333902,9.760036
06-07 17:57:43.931+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:43.931+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:43.931+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:43.941+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:43:943,0.019311,0.006086,-0.009284
06-07 17:57:43.941+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:43:943,0.895617,-0.333512,9.759971
06-07 17:57:43.941+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:43.941+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:43:949,0.914058,-0.327817,9.750752
06-07 17:57:43.941+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:43:949,0.070000,-0.070000,0.070000
06-07 17:57:43.951+0200 I/light   (25499): es.ugr.frailty.light - capturing data
06-07 17:57:43.951+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:43.951+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:43.961+0200 I/light   (25499): es.ugr.frailty.light: SM-R760,07/06/2018,17:57:43:964,1709.000000
06-07 17:57:43.961+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:43.961+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:43:965,0.013656,-0.032589,0.052995
06-07 17:57:43.961+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:43:969,0.895682,-0.334791,9.759921
06-07 17:57:43.961+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:43:965,0.070000,0.070000,0.070000
06-07 17:57:43.961+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:43.971+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:43:975,0.909273,-0.366102,9.812965
06-07 17:57:43.971+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:43.971+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:43.981+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:43:983,0.896463,-0.333182,9.759904
06-07 17:57:43.981+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:43:983,0.030340,0.028509,0.055437
06-07 17:57:43.981+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:43.981+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:43.981+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:43:988,0.926022,-0.306281,9.815358
06-07 17:57:43.981+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:43:988,0.070000,0.070000,0.070000
06-07 17:57:43.991+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:43.991+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.001+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:4,0.029560,0.034080,0.050670
06-07 17:57:44.001+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.001+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.011+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:5,0.897225,-0.331317,9.759897
06-07 17:57:44.011+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:10,0.070000,0.070000,0.070000
06-07 17:57:44.011+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:10,0.926022,-0.299103,9.810574
06-07 17:57:44.011+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.011+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.021+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.021+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.021+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:30,0.921237,-0.342174,9.798609
06-07 17:57:44.031+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:24,0.897812,-0.331596,9.759834
06-07 17:57:44.031+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:24,0.024012,-0.010856,0.038712
06-07 17:57:44.031+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:31,0.070000,0.070000,0.070000
06-07 17:57:44.031+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.031+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.041+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.041+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.041+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:44,0.897884,-0.330188,9.759875
06-07 17:57:44.041+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:44,0.011461,0.025315,0.019632
06-07 17:57:44.051+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:50,0.070000,0.070000,0.070000
06-07 17:57:44.051+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:50,0.909273,-0.306281,9.779467
06-07 17:57:44.051+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.061+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.081+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:70,0.030531,-0.009593,0.005234
06-07 17:57:44.081+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.081+0200 I/heartrate(25441): es.ugr.frailty.heartrate - capturing data
06-07 17:57:44.081+0200 I/heartrate(25441): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:57:44.081+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:87,-0.008791,0.007431,0.079515
06-07 17:57:44.101+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.101+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:65,0.898921,-0.330462,9.759770
06-07 17:57:44.101+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.111+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:114,0.897642,-0.329786,9.759912
06-07 17:57:44.111+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.111+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:108,0.040344,-0.021959,0.076982
06-07 17:57:44.111+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.121+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:120,0.898681,-0.330494,9.759791
06-07 17:57:44.121+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:124,0.039305,-0.026037,0.081888
06-07 17:57:44.121+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.131+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.141+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.141+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.151+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:149,0.070000,0.070000,0.070000
06-07 17:57:44.151+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:146,0.928415,-0.339781,9.765109
06-07 17:57:44.151+0200 I/light   (25499): es.ugr.frailty.light - capturing data
06-07 17:57:44.161+0200 I/light   (25499): es.ugr.frailty.light: SM-R760,07/06/2018,17:57:44:165,1708.000000
06-07 17:57:44.171+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.181+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.181+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:145,0.011623,-0.015266,0.036591
06-07 17:57:44.181+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:135,0.900042,-0.331694,9.759625
06-07 17:57:44.181+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.191+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:182,0.890130,-0.323031,9.839286
06-07 17:57:44.191+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:186,0.070000,0.140000,0.070000
06-07 17:57:44.191+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.191+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.191+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:195,-0.012557,-0.019277,0.024676
06-07 17:57:44.191+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.201+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:203,0.070000,0.140000,0.070000
06-07 17:57:44.201+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.201+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:203,0.900294,-0.332468,9.759576
06-07 17:57:44.201+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:200,0.937986,-0.351745,9.836893
06-07 17:57:44.201+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:210,-0.070000,0.140000,0.140000
06-07 17:57:44.201+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.211+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.211+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:216,-0.070000,0.140000,0.140000
06-07 17:57:44.211+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.211+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.221+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.221+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:220,0.070000,0.070000,0.070000
06-07 17:57:44.221+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.221+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:230,0.140000,0.070000,0.070000
06-07 17:57:44.221+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.231+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:235,0.070000,0.070000,0.070000
06-07 17:57:44.231+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.231+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:220,0.937986,-0.356531,9.841680
06-07 17:57:44.241+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:222,-0.009087,0.002968,0.007851
06-07 17:57:44.241+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:241,0.070000,0.070000,0.070000
06-07 17:57:44.241+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.241+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.241+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.241+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:233,0.899217,-0.333178,9.759651
06-07 17:57:44.241+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:247,0.140000,0.070000,0.070000
06-07 17:57:44.241+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.251+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:251,0.066130,-0.016649,0.031668
06-07 17:57:44.261+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.261+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:247,0.911665,-0.346959,9.796216
06-07 17:57:44.261+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.261+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.261+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:265,0.140000,0.070000,0.070000
06-07 17:57:44.261+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:258,0.898178,-0.332704,9.759763
06-07 17:57:44.261+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.261+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:267,0.887737,-0.351745,9.784252
06-07 17:57:44.271+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:275,0.900752,-0.333270,9.759506
06-07 17:57:44.271+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:269,-0.017800,0.024596,0.043888
06-07 17:57:44.271+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.271+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.271+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.281+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:284,0.140000,0.070000,0.070000
06-07 17:57:44.281+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.281+0200 I/heartrate(25441): es.ugr.frailty.heartrate - capturing data
06-07 17:57:44.281+0200 I/heartrate(25441): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:57:44.291+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:285,0.890130,-0.330210,9.767502
06-07 17:57:44.291+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:285,-0.009242,-0.003139,0.019785
06-07 17:57:44.291+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:292,0.899371,-0.331856,9.759682
06-07 17:57:44.291+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.291+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.301+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.301+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.301+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:306,0.070000,0.070000,0.070000
06-07 17:57:44.301+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:302,0.964308,-0.349352,9.791430
06-07 17:57:44.311+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.311+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:304,0.015788,-0.008127,0.057961
06-07 17:57:44.311+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.311+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.321+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:325,0.140000,0.070000,0.070000
06-07 17:57:44.321+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:308,0.898271,-0.331654,9.759789
06-07 17:57:44.331+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.331+0200 W/LOCATION(25463): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:57:44.331+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:332,0.882952,-0.308674,9.803394
06-07 17:57:44.331+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.331+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.341+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:321,0.030231,0.003806,0.038810
06-07 17:57:44.341+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.341+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:345,0.140000,0.070000,0.070000
06-07 17:57:44.341+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:347,-0.008711,-0.018293,0.062779
06-07 17:57:44.341+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.341+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:337,0.898184,-0.331622,9.759799
06-07 17:57:44.341+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.341+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:344,0.890130,-0.334995,9.779467
06-07 17:57:44.351+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:355,0.898841,-0.331059,9.759758
06-07 17:57:44.351+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.351+0200 I/light   (25499): es.ugr.frailty.light - capturing data
06-07 17:57:44.351+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.371+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:351,-0.010045,-0.039229,0.031596
06-07 17:57:44.371+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.371+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:376,0.140000,0.070000,0.070000
06-07 17:57:44.371+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.371+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.381+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:384,0.140000,0.070000,0.140000
06-07 17:57:44.381+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:361,0.914058,-0.339781,9.817751
06-07 17:57:44.381+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:382,0.897783,-0.331658,9.759834
06-07 17:57:44.361+0200 I/light   (25499): es.ugr.frailty.light: SM-R760,07/06/2018,17:57:44:364,1708.000000
06-07 17:57:44.381+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.391+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:377,-0.006478,-0.004238,0.033932
06-07 17:57:44.391+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.391+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.391+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:399,0.006513,-0.023554,0.014688
06-07 17:57:44.391+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.401+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.401+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:404,-0.005135,-0.010819,0.103221
06-07 17:57:44.401+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:406,0.140000,0.070000,0.070000
06-07 17:57:44.401+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:395,0.928415,-0.327817,9.798609
06-07 17:57:44.401+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.401+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:399,0.896608,-0.333150,9.759892
06-07 17:57:44.411+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.411+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:416,0.890130,-0.349352,9.822537
06-07 17:57:44.411+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.411+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.411+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:412,-0.011035,0.029893,0.071998
06-07 17:57:44.411+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.421+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:424,-0.070000,0.070000,0.070000
06-07 17:57:44.421+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:425,-0.009661,0.008888,0.043095
06-07 17:57:44.421+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.421+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:431,0.887737,-0.370888,9.791430
06-07 17:57:44.431+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:420,0.895581,-0.332977,9.759992
06-07 17:57:44.431+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.431+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:437,0.895265,-0.333747,9.759995
06-07 17:57:44.431+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.431+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.431+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.441+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:444,-0.004268,0.008528,-0.004829
06-07 17:57:44.441+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:444,0.070000,-0.070000,0.070000
06-07 17:57:44.441+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.451+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:441,0.890130,-0.337388,9.793823
06-07 17:57:44.451+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.451+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:457,0.902094,-0.356531,9.774680
06-07 17:57:44.451+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:451,0.893987,-0.333781,9.760111
06-07 17:57:44.451+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.451+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.451+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.461+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:465,-0.070000,0.070000,0.070000
06-07 17:57:44.461+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:464,0.034268,-0.006344,0.028629
06-07 17:57:44.461+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.471+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:462,0.892613,-0.331919,9.760300
06-07 17:57:44.471+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.471+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:477,0.892005,-0.331559,9.760367
06-07 17:57:44.471+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:474,0.890130,-0.344566,9.863215
06-07 17:57:44.471+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.471+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.481+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:484,0.140000,0.070000,0.070000
06-07 17:57:44.481+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:483,0.035155,-0.041852,0.055100
06-07 17:57:44.481+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.481+0200 I/heartrate(25441): es.ugr.frailty.heartrate - capturing data
06-07 17:57:44.481+0200 I/heartrate(25441): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:57:44.481+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.491+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:490,0.882952,-0.303888,9.832108
06-07 17:57:44.491+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:494,0.891754,-0.331044,9.760408
06-07 17:57:44.491+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.491+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.501+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.501+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:507,0.140000,-0.070000,0.070000
06-07 17:57:44.501+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:506,0.007945,0.026697,0.014557
06-07 17:57:44.511+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.511+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:517,0.893260,-0.331429,9.760258
06-07 17:57:44.511+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:501,0.882952,-0.323031,9.803394
06-07 17:57:44.511+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.511+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.521+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.521+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:524,-0.006450,0.008385,0.074328
06-07 17:57:44.521+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:526,0.070000,0.140000,0.070000
06-07 17:57:44.531+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:522,0.887737,-0.323031,9.755538
06-07 17:57:44.531+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.531+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:539,0.894149,-0.332978,9.760123
06-07 17:57:44.531+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.541+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.541+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.541+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:547,0.140000,0.140000,0.070000
06-07 17:57:44.541+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:551,0.013836,0.005277,0.035914
06-07 17:57:44.551+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.551+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.561+0200 I/light   (25499): es.ugr.frailty.light - capturing data
06-07 17:57:44.561+0200 I/light   (25499): es.ugr.frailty.light: SM-R760,07/06/2018,17:57:44:566,1708.000000
06-07 17:57:44.571+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.581+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:577,-0.012247,-0.028880,0.052619
06-07 17:57:44.581+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:567,-0.070000,0.070000,0.070000
06-07 17:57:44.581+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.591+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:558,0.926022,-0.337388,9.789038
06-07 17:57:44.591+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.591+0200 W/libgps_d( 3131): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-07 17:57:44.591+0200 W/libgps  ( 3131): [proxy__gps_stop][line = 1067]: called.
06-07 17:57:44.591+0200 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:57:44.591+0200 W/libgps_d( 3131): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-07 17:57:44.591+0200 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-07 17:57:44.591+0200 W/libgps_d( 3131): GpsiHookStateGps              : EXIT
06-07 17:57:44.591+0200 W/libgps_d( 3131): GpsiHookStateIdle             : ENTRY
06-07 17:57:44.601+0200 W/AUL     (25539): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-07 17:57:44.601+0200 E/CAPI_LOCATION_MANAGER( 3823): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-07 17:57:44.601+0200 W/gpsd    ( 3111): HandleIncomingMessage() dest id:0, msg id:2
06-07 17:57:44.601+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 23
06-07 17:57:44.601+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-07 17:57:44.601+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 24798
06-07 17:57:44.601+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 17:57:44.611+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 24798
06-07 17:57:44.611+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(24798)
06-07 17:57:44.621+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:601,0.026814,-0.027456,0.026277
06-07 17:57:44.621+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.621+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:630,-0.000708,-0.028468,0.059933
06-07 17:57:44.621+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.631+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.631+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:635,0.035840,-0.005853,0.047945
06-07 17:57:44.631+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.641+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:600,-0.070000,0.070000,0.070000
06-07 17:57:44.641+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.641+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:644,0.031954,-0.010310,0.036129
06-07 17:57:44.651+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:57:44:650,0.070000,0.070000,0.070000
06-07 17:57:44.651+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-07 17:57:44.651+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration - capturing data
06-07 17:57:44.671+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:564,0.894187,-0.331416,9.760173
06-07 17:57:44.671+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.681+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:672,0.928415,-0.373280,9.815358
06-07 17:57:44.681+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:683,0.893043,-0.330701,9.760302
06-07 17:57:44.681+0200 I/heartrate(25441): es.ugr.frailty.heartrate - capturing data
06-07 17:57:44.681+0200 I/heartrate(25441): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:57:44.681+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.691+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.691+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:57:44:693,0.902094,-0.306281,9.774680
06-07 17:57:44.691+0200 I/accelerometer(25426): es.ugr.frailty.accelerometer - capturing data
06-07 17:57:44.701+0200 I/gravity (25480): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:57:44:697,0.892806,-0.330043,9.760346
06-07 17:57:44.701+0200 I/gravity (25480): es.ugr.frailty.gravity - capturing data
06-07 17:57:44.701+0200 I/linearacceleration(25468): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:57:44:665,0.021161,-0.024136,0.067366
06-07 17:57:44.711+0200 W/CRASH_MANAGER(25538): worker.c: worker_job(1205) > 11254636c6f63152838706
