S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 22672
Date: 2018-06-07 17:33:35+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf715252d, r5   = 0xf768ef98
r6   = 0xffba3310, r7   = 0xffba31c0
r8   = 0xf768bc18, r9   = 0x00000000
r10  = 0xffba329c, fp   = 0xffba3310
ip   = 0x00000001, sp   = 0xffba3198
lr   = 0xf7152539, pc   = 0xf71bb228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    315044 KB
Buffers:      2600 KB
Cached:      73396 KB
VmPeak:      53460 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11864 KB
VmRSS:       11864 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 22672 TID = 22672
22672 22746 

Maps Information
f401d000 f481c000 rw-p [stack:22746]
f4823000 f4825000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f482d000 f4831000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f483a000 f483c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4844000 f4847000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4856000 f485b000 r-xp /usr/lib/libsystem.so.0.0.0
f4866000 f4869000 r-xp /lib/libattr.so.1.1.0
f4871000 f4881000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4889000 f4892000 r-xp /usr/lib/libedbus.so.1.7.99
f489a000 f489b000 r-xp /usr/lib/libresponse.so.0.2.96
f48a4000 f48a9000 r-xp /usr/lib/libproc-stat.so.0.2.96
f614b000 f6251000 r-xp /usr/lib/libicuuc.so.57.1
f6267000 f63ef000 r-xp /usr/lib/libicui18n.so.57.1
f63ff000 f640c000 r-xp /usr/lib/libail.so.0.1.0
f6415000 f641c000 r-xp /usr/lib/libminizip.so.1.0.0
f6425000 f65ce000 r-xp /usr/lib/libcrypto.so.1.0.0
f65ee000 f6635000 r-xp /usr/lib/libssl.so.1.0.0
f6641000 f6643000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f664b000 f6652000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f665b000 f6662000 r-xp /lib/libcrypt-2.13.so
f6693000 f6696000 r-xp /lib/libcap.so.2.21
f669e000 f66a0000 r-xp /usr/lib/libiri.so
f66a8000 f66f1000 r-xp /usr/lib/libmdm.so.1.2.69
f66f9000 f66ff000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6707000 f672a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6734000 f6736000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f673e000 f675b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6764000 f6768000 r-xp /usr/lib/libsmack.so.1.0.0
f6771000 f678a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6793000 f679b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f67a3000 f67a9000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f67b2000 f67b4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f67bd000 f67cd000 r-xp /lib/libresolv-2.13.so
f67d1000 f67e9000 r-xp /usr/lib/liblzma.so.5.0.3
f67f2000 f67f4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f67fc000 f6816000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f681e000 f684d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6856000 f6865000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f686f000 f6879000 r-xp /usr/lib/libsensord-shared.so
f6882000 f6955000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6960000 f6976000 r-xp /lib/libz.so.1.2.5
f697e000 f6983000 r-xp /usr/lib/libffi.so.5.0.10
f698b000 f698c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6994000 f69a4000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f69ac000 f69c5000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f69cd000 f69cf000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f69d7000 f6a4c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a56000 f6a5c000 r-xp /lib/librt-2.13.so
f6a65000 f6a83000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a8d000 f6a8e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a96000 f6ab9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ac1000 f6ac6000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ace000 f6af8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b01000 f6b18000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b20000 f6b89000 r-xp /lib/libm-2.13.so
f6b92000 f6c26000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c39000 f6c3e000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c46000 f6c4d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c55000 f6c7f000 r-xp /usr/lib/libsensor.so.1.9.6
f6c88000 f6d54000 r-xp /usr/lib/libxml2.so.2.7.8
f6d61000 f6d63000 r-xp /usr/lib/libiniparser.so.0
f6d6c000 f6d72000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d7b000 f6e4b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e4c000 f6e80000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e89000 f6ec5000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6ecd000 f6ed0000 r-xp /usr/lib/libbundle.so.0.1.22
f6ed8000 f6ede000 r-xp /usr/lib/libappsvc.so.0.1.0
f6ee6000 f6f27000 r-xp /usr/lib/libeina.so.1.7.99
f6f30000 f6f47000 r-xp /usr/lib/libecore.so.1.7.99
f6f5e000 f6f67000 r-xp /usr/lib/libvconf.so.0.2.45
f6f6f000 f6f83000 r-xp /lib/libpthread-2.13.so
f6f8e000 f6f9b000 r-xp /usr/lib/libaul.so.0.1.0
f6fa5000 f6fa7000 r-xp /lib/libdl-2.13.so
f6fb0000 f6fbb000 r-xp /lib/libunwind.so.8.0.1
f6fe8000 f6ff0000 r-xp /lib/libgcc_s-4.6.so.1
f6ff1000 f7115000 r-xp /lib/libc-2.13.so
f7123000 f7125000 r-xp /usr/lib/libdlog.so.0.0.0
f712d000 f7139000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7142000 f7147000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f714f000 f715e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7166000 f716a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7173000 f7176000 r-xp /usr/lib/libappcore-agent.so.1.1
f717e000 f7180000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7188000 f718c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7194000 f71b1000 r-xp /lib/ld-2.13.so
f71ba000 f71bd000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f71bd000 f71c1000 r-xp /usr/lib/libsys-assert.so
f765b000 f76ca000 rw-p [heap]
ffb84000 ffba5000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22672)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf71bb228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7152539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e593f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e57c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e63e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e69be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e69dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e9e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e991f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e57c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e63e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e69be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e69dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e9be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e9c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6ea3f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf483b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf482e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6901663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6daefcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6db07a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f40ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f3bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f3c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f3c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7174183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71747fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71bb5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf700885c) [/lib/libc.so.6] + 0x1785c
29: (0xf71baf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
0,07/06/2018,17:33:34:596,0.140000,0.070000,0.070000
06-07 17:33:34.591+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:34.591+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:34.591+0200 I/heartrate(22662): es.ugr.frailty.heartrate - capturing data
06-07 17:33:34.591+0200 I/heartrate(22662): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:33:34.601+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:34:604,0.310430,-0.088374,9.801337
06-07 17:33:34.601+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:34:604,0.042453,0.013408,0.030728
06-07 17:33:34.611+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:34.611+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:34.611+0200 I/light   (22704): es.ugr.frailty.light - capturing data
06-07 17:33:34.611+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:34:617,0.070000,0.070000,0.070000
06-07 17:33:34.611+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:34.621+0200 I/light   (22704): es.ugr.frailty.light: SM-R760,07/06/2018,17:33:34:623,907.000000
06-07 17:33:34.621+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:34:617,0.332602,-0.124427,9.865608
06-07 17:33:34.621+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:34:624,0.311725,-0.087549,9.801303
06-07 17:33:34.621+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:34.631+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:34:631,0.022173,-0.036053,0.064271
06-07 17:33:34.631+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:34.631+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:34.631+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:34:638,0.070000,0.070000,0.070000
06-07 17:33:34.631+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:34.641+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:34:639,0.311067,-0.090927,9.868000
06-07 17:33:34.641+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:34.641+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:34:645,0.312367,-0.089068,9.801270
06-07 17:33:34.651+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:34.651+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:34:656,0.070000,0.070000,0.070000
06-07 17:33:34.651+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:34.661+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:34:651,-0.000658,-0.003378,0.066697
06-07 17:33:34.661+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:34.661+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:34:668,0.001093,-0.006645,0.040410
06-07 17:33:34.671+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:34.671+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:34:662,0.311784,-0.088956,9.801289
06-07 17:33:34.681+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:34.681+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:34.691+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:33:34.691+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:33:34.691+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:33:34.691+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:34.701+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:34:681,0.313460,-0.095713,9.841680
06-07 17:33:34.701+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:34:701,0.018425,0.009993,0.035604
06-07 17:33:34.701+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:34.701+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:34:691,0.070000,0.070000,0.070000
06-07 17:33:34.701+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:34:708,-0.000672,0.011856,0.057134
06-07 17:33:34.711+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:34.711+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:34.711+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:34.711+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:34:698,0.311390,-0.089089,9.801300
06-07 17:33:34.711+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:34:718,0.006507,0.021427,0.023634
06-07 17:33:34.711+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:34.721+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:34:717,0.070000,0.070000,0.070000
06-07 17:33:34.721+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:34.721+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:34:721,0.330210,-0.078963,9.836893
06-07 17:33:34.721+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:34.731+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:34:731,0.070000,0.070000,0.070000
06-07 17:33:34.731+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:34.731+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:34:732,0.311067,-0.076570,9.858429
06-07 17:33:34.731+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:34.731+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:34:739,0.023810,-0.027192,0.052324
06-07 17:33:34.731+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:34.731+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:34:741,0.318245,-0.066999,9.824929
06-07 17:33:34.741+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:34.741+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:34:744,0.070000,0.070000,-0.070000
06-07 17:33:34.741+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:34:725,0.311739,-0.088426,9.801295
06-07 17:33:34.741+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:34.741+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:34:746,0.334995,-0.114855,9.853643
06-07 17:33:34.751+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:34.751+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:34.751+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:34:757,0.026362,-0.006831,0.088201
06-07 17:33:34.751+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:34:757,0.070000,0.070000,-0.070000
06-07 17:33:34.751+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:34.761+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:34:751,0.311185,-0.087663,9.801319
06-07 17:33:34.761+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:34.761+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:34:762,0.337388,-0.093320,9.889536
06-07 17:33:34.761+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:34:767,0.311026,-0.086489,9.801335
06-07 17:33:34.761+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:34.771+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:34.771+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:34:772,0.311793,-0.087615,9.801301
06-07 17:33:34.771+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:34.771+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:34:776,0.140000,0.070000,-0.070000
06-07 17:33:34.771+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:34.771+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:34:778,0.312176,-0.087520,9.801290
06-07 17:33:34.771+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:34.781+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:34:781,0.020810,-0.039205,0.066699
06-07 17:33:34.781+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:34:783,0.332602,-0.126820,9.868000
06-07 17:33:34.791+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:34.791+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:34.791+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:34:796,0.312805,-0.089148,9.801254
06-07 17:33:34.791+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:34.791+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:34.791+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:34:796,0.070000,0.070000,0.070000
06-07 17:33:34.791+0200 I/heartrate(22662): es.ugr.frailty.heartrate - capturing data
06-07 17:33:34.791+0200 I/heartrate(22662): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:33:34.801+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:34:801,0.366102,-0.090927,9.827322
06-07 17:33:34.801+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:34:801,0.053926,-0.003407,0.026032
06-07 17:33:34.811+0200 I/light   (22704): es.ugr.frailty.light - capturing data
06-07 17:33:34.811+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:34.811+0200 I/light   (22704): es.ugr.frailty.light: SM-R760,07/06/2018,17:33:34:816,905.000000
06-07 17:33:34.811+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:34.811+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:34:817,0.314742,-0.089077,9.801193
06-07 17:33:34.811+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:34.821+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:34.821+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:34:822,0.034154,-0.018529,0.023675
06-07 17:33:34.821+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:34:821,0.070000,0.070000,0.070000
06-07 17:33:34.821+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:34:827,0.346959,-0.107677,9.824929
06-07 17:33:34.831+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:34.831+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:34.841+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:34:841,0.070000,0.070000,0.070000
06-07 17:33:34.841+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:34.841+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:34.841+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:34:843,0.315862,-0.089770,9.801150
06-07 17:33:34.841+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:34:849,-0.022817,-0.018600,0.059629
06-07 17:33:34.851+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:34.851+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:34.851+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:34.851+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:34:848,0.291924,-0.107677,9.860823
06-07 17:33:34.851+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:34:857,0.314183,-0.090449,9.801199
06-07 17:33:34.861+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:34.861+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:34:857,0.070000,0.070000,0.070000
06-07 17:33:34.861+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:34:862,-0.031116,-0.005943,0.064458
06-07 17:33:34.861+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:34:867,0.284746,-0.095713,9.865608
06-07 17:33:34.871+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:34.901+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:34.901+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:34.901+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:34.911+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:34:914,0.318245,-0.133998,9.827322
06-07 17:33:34.911+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:34:908,-0.070000,0.070000,0.070000
06-07 17:33:34.921+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:34.921+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:34:915,0.004062,-0.043549,0.026123
06-07 17:33:34.931+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:34.931+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:34.941+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:34:938,-0.030399,0.047753,0.033260
06-07 17:33:34.941+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:34:927,0.070000,0.070000,0.070000
06-07 17:33:34.941+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:34.951+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:34:940,0.282353,-0.043071,9.834501
06-07 17:33:34.951+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:34:879,0.312752,-0.090824,9.801241
06-07 17:33:34.951+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:34.961+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:34:965,0.312722,-0.092667,9.801225
06-07 17:33:34.961+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:34.981+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:34:972,0.311058,-0.090023,9.801302
06-07 17:33:34.981+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:34.981+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:34.991+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:34:988,0.310354,-0.089764,9.801327
06-07 17:33:34.991+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:34.991+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:34.991+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:34:951,0.070000,0.070000,0.070000
06-07 17:33:34.991+0200 I/heartrate(22662): es.ugr.frailty.heartrate - capturing data
06-07 17:33:35.001+0200 I/heartrate(22662): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:33:35.001+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:34:999,0.310600,-0.089519,9.801321
06-07 17:33:35.001+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.011+0200 I/light   (22704): es.ugr.frailty.light - capturing data
06-07 17:33:35.011+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:10,0.311665,-0.090522,9.801278
06-07 17:33:35.011+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.011+0200 I/light   (22704): es.ugr.frailty.light: SM-R760,07/06/2018,17:33:35:17,901.000000
06-07 17:33:35.011+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:20,0.311296,-0.088951,9.801304
06-07 17:33:35.021+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.021+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.021+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:26,0.309478,-0.089198,9.801360
06-07 17:33:35.031+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:6,-0.006441,0.004133,0.038061
06-07 17:33:35.031+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:8,0.306281,-0.088534,9.839286
06-07 17:33:35.031+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.031+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.031+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:32,0.070000,0.070000,0.070000
06-07 17:33:35.031+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.031+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:40,0.310504,-0.090187,9.801318
06-07 17:33:35.041+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.041+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:43,0.325424,-0.088534,9.829715
06-07 17:33:35.051+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.051+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:44,0.014366,0.001489,0.028413
06-07 17:33:35.051+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:57,0.308047,-0.089194,9.801405
06-07 17:33:35.051+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.061+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.061+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:54,0.070000,0.070000,-0.070000
06-07 17:33:35.071+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.071+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:76,0.306459,-0.089149,9.801455
06-07 17:33:35.071+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.071+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:66,0.339781,-0.114855,9.812965
06-07 17:33:35.081+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.081+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:86,0.315853,-0.062213,9.901501
06-07 17:33:35.081+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.091+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.091+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:81,0.070000,0.070000,-0.070000
06-07 17:33:35.091+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:68,0.029427,-0.025092,0.011639
06-07 17:33:35.091+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.091+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.101+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:101,0.005252,0.027305,0.100180
06-07 17:33:35.101+0200 W/LOCATION(22672): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:33:35.101+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.101+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:105,0.070000,0.070000,-0.070000
06-07 17:33:35.111+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:111,-0.026550,-0.009154,0.076267
06-07 17:33:35.111+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.111+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:96,0.306575,-0.088907,9.801454
06-07 17:33:35.111+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.111+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.111+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:118,0.070000,0.070000,-0.070000
06-07 17:33:35.121+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.121+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:122,0.305070,-0.088977,9.801500
06-07 17:33:35.121+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:130,0.070000,0.070000,-0.070000
06-07 17:33:35.121+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:125,0.028485,-0.025904,0.066696
06-07 17:33:35.121+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:92,0.284746,-0.098106,9.877571
06-07 17:33:35.131+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.131+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.131+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.131+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.131+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:136,-0.037722,0.013616,0.016433
06-07 17:33:35.141+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.141+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:137,0.339781,-0.114855,9.868000
06-07 17:33:35.141+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:139,0.305248,-0.089071,9.801494
06-07 17:33:35.141+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:141,0.140000,0.070000,-0.070000
06-07 17:33:35.141+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.141+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.151+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.151+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:148,-0.018579,-0.005526,0.093003
06-07 17:33:35.151+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:153,0.140000,0.070000,0.070000
06-07 17:33:35.151+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.151+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:153,0.272782,-0.076570,9.817751
06-07 17:33:35.151+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.161+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:161,0.014984,0.000660,0.049847
06-07 17:33:35.161+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:156,0.305005,-0.088959,9.801502
06-07 17:33:35.161+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.161+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.161+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:165,0.070000,0.140000,0.070000
06-07 17:33:35.161+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:170,0.291924,-0.095713,9.894321
06-07 17:33:35.171+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.171+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.171+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:170,-0.012142,-0.008957,0.064154
06-07 17:33:35.171+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.171+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:178,0.140000,0.140000,0.070000
06-07 17:33:35.181+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.181+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:177,0.306724,-0.088644,9.801452
06-07 17:33:35.181+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.181+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:187,0.323031,-0.088534,9.851252
06-07 17:33:35.181+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:185,0.016456,-0.006806,0.068940
06-07 17:33:35.191+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.191+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.191+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:190,0.070000,0.140000,0.070000
06-07 17:33:35.191+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:196,0.306349,-0.087002,9.801477
06-07 17:33:35.191+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.191+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.191+0200 I/heartrate(22662): es.ugr.frailty.heartrate - capturing data
06-07 17:33:35.191+0200 I/heartrate(22662): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:33:35.201+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:196,0.005997,-0.001950,0.066500
06-07 17:33:35.201+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.201+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:202,0.070000,0.070000,0.070000
06-07 17:33:35.201+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:205,0.294317,-0.098106,9.865608
06-07 17:33:35.201+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.201+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.211+0200 I/light   (22704): es.ugr.frailty.light - capturing data
06-07 17:33:35.211+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.211+0200 I/light   (22704): es.ugr.frailty.light: SM-R760,07/06/2018,17:33:35:217,900.000000
06-07 17:33:35.211+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:217,0.306922,-0.086443,9.801465
06-07 17:33:35.211+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:209,0.051282,0.002930,0.097613
06-07 17:33:35.221+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.221+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:216,0.323031,-0.095713,9.870394
06-07 17:33:35.221+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:214,0.070000,0.070000,0.070000
06-07 17:33:35.221+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.221+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.231+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:227,0.016307,0.024038,0.078512
06-07 17:33:35.231+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.231+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.231+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:233,0.210000,0.070000,0.070000
06-07 17:33:35.231+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:237,0.023486,0.009681,0.037834
06-07 17:33:35.231+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:239,0.306014,-0.087765,9.801481
06-07 17:33:35.231+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.241+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:233,0.311067,-0.090927,9.868000
06-07 17:33:35.241+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.241+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:244,0.070000,0.070000,0.070000
06-07 17:33:35.241+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.241+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:249,0.356531,-0.086142,9.899107
06-07 17:33:35.241+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:249,-0.014424,-0.030246,0.068916
06-07 17:33:35.241+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.251+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.251+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.251+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:257,0.305752,-0.086742,9.801498
06-07 17:33:35.251+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:253,0.070000,-0.070000,0.070000
06-07 17:33:35.251+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.251+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.261+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:258,-0.003033,0.017051,0.021072
06-07 17:33:35.261+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.261+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:263,0.323031,-0.064606,9.879964
06-07 17:33:35.261+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.261+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:263,0.070000,-0.070000,0.070000
06-07 17:33:35.271+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.271+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.271+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:277,0.305169,-0.086941,9.801515
06-07 17:33:35.271+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:271,0.002660,-0.010341,0.040198
06-07 17:33:35.281+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:279,0.140000,0.070000,0.070000
06-07 17:33:35.281+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.281+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:274,0.330210,-0.078963,9.839286
06-07 17:33:35.281+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:287,-0.004257,0.005386,0.114358
06-07 17:33:35.281+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.291+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.291+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.291+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:297,0.304157,-0.086298,9.801552
06-07 17:33:35.291+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.291+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:293,0.291924,-0.117248,9.870394
06-07 17:33:35.291+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:297,0.140000,0.070000,-0.070000
06-07 17:33:35.291+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.301+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:301,0.023660,-0.018987,0.071235
06-07 17:33:35.301+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:304,0.303888,-0.069392,9.822537
06-07 17:33:35.301+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.301+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:309,0.308674,-0.098106,9.841680
06-07 17:33:35.301+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.311+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.311+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.311+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.311+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:316,0.305347,-0.087284,9.801506
06-07 17:33:35.311+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:314,0.301496,-0.081356,9.915856
06-07 17:33:35.311+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.321+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:318,-0.070000,0.070000,-0.070000
06-07 17:33:35.321+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:317,0.038017,-0.035736,0.078412
06-07 17:33:35.321+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:325,0.327817,-0.105284,9.872787
06-07 17:33:35.321+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.321+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:330,0.342174,-0.122034,9.879964
06-07 17:33:35.331+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.331+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.331+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.331+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:339,0.307255,-0.088985,9.801432
06-07 17:33:35.341+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:340,-0.018208,-0.029964,0.047352
06-07 17:33:35.341+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.341+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:343,-0.070000,0.070000,-0.070000
06-07 17:33:35.341+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:346,0.287139,-0.117248,9.848858
06-07 17:33:35.351+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.351+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.351+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.351+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:357,-0.070000,0.070000,-0.070000
06-07 17:33:35.351+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:357,0.306327,-0.090458,9.801447
06-07 17:33:35.351+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:357,0.015776,-0.028263,0.040248
06-07 17:33:35.361+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.361+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:367,0.323031,-0.117248,9.841680
06-07 17:33:35.371+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.371+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.371+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.371+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:377,-0.070000,0.070000,0.070000
06-07 17:33:35.371+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:377,0.015790,-0.018244,0.064202
06-07 17:33:35.371+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.371+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:377,0.307241,-0.091826,9.801406
06-07 17:33:35.381+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:383,0.323031,-0.110070,9.865608
06-07 17:33:35.391+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.391+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.391+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:396,-0.070000,0.070000,0.070000
06-07 17:33:35.391+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.391+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:396,0.308027,-0.092784,9.801373
06-07 17:33:35.391+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.391+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:401,0.011004,0.048755,0.049846
06-07 17:33:35.391+0200 I/heartrate(22662): es.ugr.frailty.heartrate - capturing data
06-07 17:33:35.401+0200 I/heartrate(22662): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:33:35.401+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:402,0.318245,-0.043071,9.851252
06-07 17:33:35.411+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.411+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.411+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.411+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:417,0.307736,-0.090068,9.801407
06-07 17:33:35.411+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:419,0.007826,-0.034035,0.059450
06-07 17:33:35.411+0200 I/light   (22704): es.ugr.frailty.light - capturing data
06-07 17:33:35.411+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:416,0.140000,0.070000,0.070000
06-07 17:33:35.421+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.421+0200 I/light   (22704): es.ugr.frailty.light: SM-R760,07/06/2018,17:33:35:423,899.000000
06-07 17:33:35.421+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:425,0.315853,-0.126820,9.860823
06-07 17:33:35.431+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.431+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.431+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.431+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:439,0.307482,-0.091437,9.801402
06-07 17:33:35.441+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.441+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:442,0.005724,0.003926,0.023522
06-07 17:33:35.441+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:438,0.140000,0.070000,0.070000
06-07 17:33:35.441+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:446,0.313460,-0.086142,9.824929
06-07 17:33:35.451+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.451+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.451+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.451+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:457,0.008371,-0.013847,0.037884
06-07 17:33:35.451+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:458,0.307304,-0.091002,9.801412
06-07 17:33:35.451+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.451+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:456,0.070000,0.070000,0.070000
06-07 17:33:35.461+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:464,0.315853,-0.105284,9.839286
06-07 17:33:35.471+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.471+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.471+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:476,0.070000,0.070000,0.070000
06-07 17:33:35.471+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.471+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:477,0.307268,-0.091487,9.801408
06-07 17:33:35.471+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.471+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:481,0.034870,-0.011889,0.040268
06-07 17:33:35.481+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:482,0.342174,-0.102891,9.841680
06-07 17:33:35.491+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.491+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.491+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.491+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:500,0.308449,-0.091838,9.801368
06-07 17:33:35.501+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.501+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:507,0.346959,-0.052642,9.889536
06-07 17:33:35.511+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.511+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:517,0.309987,-0.090130,9.801335
06-07 17:33:35.521+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:499,0.039691,0.038845,0.088128
06-07 17:33:35.521+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.521+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:496,0.070000,0.070000,0.070000
06-07 17:33:35.521+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.521+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.531+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:528,-0.070000,0.070000,0.070000
06-07 17:33:35.531+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:526,0.005011,0.039196,0.028347
06-07 17:33:35.531+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.531+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:541,-0.006099,-0.015154,0.066665
06-07 17:33:35.541+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:529,0.313460,-0.052642,9.829715
06-07 17:33:35.541+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.541+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:547,0.303888,-0.105284,9.868000
06-07 17:33:35.541+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.541+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.541+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:550,0.070000,0.070000,0.070000
06-07 17:33:35.551+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.551+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:554,0.309684,-0.088148,9.801363
06-07 17:33:35.551+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.551+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:557,-0.005795,-0.026708,0.088173
06-07 17:33:35.551+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.551+0200 I/gravity (22681): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:33:35:559,0.308898,-0.088764,9.801382
06-07 17:33:35.551+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.561+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:563,0.070000,0.070000,0.070000
06-07 17:33:35.571+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.571+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope - capturing data
06-07 17:33:35.581+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:562,0.303888,-0.114855,9.889536
06-07 17:33:35.601+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:33:35:576,-0.019366,-0.035663,0.049870
06-07 17:33:35.601+0200 I/linearacceleration(22677): es.ugr.frailty.linearacceleration - capturing data
06-07 17:33:35.601+0200 I/gravity (22681): es.ugr.frailty.gravity - capturing data
06-07 17:33:35.621+0200 I/light   (22704): es.ugr.frailty.light - capturing data
06-07 17:33:35.621+0200 I/light   (22704): es.ugr.frailty.light: SM-R760,07/06/2018,17:33:35:630,897.000000
06-07 17:33:35.621+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.631+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:635,0.289532,-0.124427,9.851252
06-07 17:33:35.631+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.641+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:642,0.291924,-0.081356,9.875179
06-07 17:33:35.641+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.641+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:33:35:649,0.315853,-0.110070,9.803394
06-07 17:33:35.651+0200 I/heartrate(22662): es.ugr.frailty.heartrate - capturing data
06-07 17:33:35.651+0200 I/heartrate(22662): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:33:35.651+0200 I/accelerometer(22636): es.ugr.frailty.accelerometer - capturing data
06-07 17:33:35.661+0200 W/AUL     (22754): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-07 17:33:35.661+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 23
06-07 17:33:35.661+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-07 17:33:35.661+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21939
06-07 17:33:35.661+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 17:33:35.671+0200 I/gyroscope(22639): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:33:35:581,0.070000,0.070000,0.070000
06-07 17:33:35.671+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21939
06-07 17:33:35.671+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21939)
06-07 17:33:35.671+0200 W/CRASH_MANAGER(22750): worker.c: worker_job(1205) > 11226726c6f63152838561
