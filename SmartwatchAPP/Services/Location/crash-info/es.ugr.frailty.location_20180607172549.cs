S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 21412
Date: 2018-06-07 17:25:49+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf716852d, r5   = 0xf74e7f98
r6   = 0xff918580, r7   = 0xff918430
r8   = 0xf74e4c18, r9   = 0x00000000
r10  = 0xff91850c, fp   = 0xff918580
ip   = 0x00000001, sp   = 0xff918408
lr   = 0xf7168539, pc   = 0xf71d1228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    148300 KB
Buffers:      3056 KB
Cached:      61348 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11828 KB
VmRSS:       11828 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 21412 TID = 21412
21412 21415 

Maps Information
f4033000 f4832000 rw-p [stack:21415]
f4839000 f483b000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4843000 f4847000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4850000 f4852000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f485a000 f485d000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f486c000 f4871000 r-xp /usr/lib/libsystem.so.0.0.0
f487c000 f487f000 r-xp /lib/libattr.so.1.1.0
f4887000 f4897000 r-xp /usr/lib/libmdm-common.so.1.1.24
f489f000 f48a8000 r-xp /usr/lib/libedbus.so.1.7.99
f48b0000 f48b1000 r-xp /usr/lib/libresponse.so.0.2.96
f48ba000 f48bf000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6161000 f6267000 r-xp /usr/lib/libicuuc.so.57.1
f627d000 f6405000 r-xp /usr/lib/libicui18n.so.57.1
f6415000 f6422000 r-xp /usr/lib/libail.so.0.1.0
f642b000 f6432000 r-xp /usr/lib/libminizip.so.1.0.0
f643b000 f65e4000 r-xp /usr/lib/libcrypto.so.1.0.0
f6604000 f664b000 r-xp /usr/lib/libssl.so.1.0.0
f6657000 f6659000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6661000 f6668000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6671000 f6678000 r-xp /lib/libcrypt-2.13.so
f66a9000 f66ac000 r-xp /lib/libcap.so.2.21
f66b4000 f66b6000 r-xp /usr/lib/libiri.so
f66be000 f6707000 r-xp /usr/lib/libmdm.so.1.2.69
f670f000 f6715000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f671d000 f6740000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f674a000 f674c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6754000 f6771000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f677a000 f677e000 r-xp /usr/lib/libsmack.so.1.0.0
f6787000 f67a0000 r-xp /usr/lib/libnetwork.so.0.0.0
f67a9000 f67b1000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f67b9000 f67bf000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f67c8000 f67ca000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f67d3000 f67e3000 r-xp /lib/libresolv-2.13.so
f67e7000 f67ff000 r-xp /usr/lib/liblzma.so.5.0.3
f6808000 f680a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6812000 f682c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6834000 f6863000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f686c000 f687b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6885000 f688f000 r-xp /usr/lib/libsensord-shared.so
f6898000 f696b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6976000 f698c000 r-xp /lib/libz.so.1.2.5
f6994000 f6999000 r-xp /usr/lib/libffi.so.5.0.10
f69a1000 f69a2000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f69aa000 f69ba000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f69c2000 f69db000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f69e3000 f69e5000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f69ed000 f6a62000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a6c000 f6a72000 r-xp /lib/librt-2.13.so
f6a7b000 f6a99000 r-xp /usr/lib/libsystemd.so.0.4.0
f6aa3000 f6aa4000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6aac000 f6acf000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ad7000 f6adc000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ae4000 f6b0e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b17000 f6b2e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b36000 f6b9f000 r-xp /lib/libm-2.13.so
f6ba8000 f6c3c000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c4f000 f6c54000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c5c000 f6c63000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c6b000 f6c95000 r-xp /usr/lib/libsensor.so.1.9.6
f6c9e000 f6d6a000 r-xp /usr/lib/libxml2.so.2.7.8
f6d77000 f6d79000 r-xp /usr/lib/libiniparser.so.0
f6d82000 f6d88000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d91000 f6e61000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e62000 f6e96000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e9f000 f6edb000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6ee3000 f6ee6000 r-xp /usr/lib/libbundle.so.0.1.22
f6eee000 f6ef4000 r-xp /usr/lib/libappsvc.so.0.1.0
f6efc000 f6f3d000 r-xp /usr/lib/libeina.so.1.7.99
f6f46000 f6f5d000 r-xp /usr/lib/libecore.so.1.7.99
f6f74000 f6f7d000 r-xp /usr/lib/libvconf.so.0.2.45
f6f85000 f6f99000 r-xp /lib/libpthread-2.13.so
f6fa4000 f6fb1000 r-xp /usr/lib/libaul.so.0.1.0
f6fbb000 f6fbd000 r-xp /lib/libdl-2.13.so
f6fc6000 f6fd1000 r-xp /lib/libunwind.so.8.0.1
f6ffe000 f7006000 r-xp /lib/libgcc_s-4.6.so.1
f7007000 f712b000 r-xp /lib/libc-2.13.so
f7139000 f713b000 r-xp /usr/lib/libdlog.so.0.0.0
f7143000 f714f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7158000 f715d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7165000 f7174000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f717c000 f7180000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7189000 f718c000 r-xp /usr/lib/libappcore-agent.so.1.1
f7194000 f7196000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f719e000 f71a2000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f71aa000 f71c7000 r-xp /lib/ld-2.13.so
f71d0000 f71d3000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f71d3000 f71d7000 r-xp /usr/lib/libsys-assert.so
f74b4000 f7542000 rw-p [heap]
ff8f9000 ff91a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21412)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf71d1228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7168539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e6f3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e6dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e79e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e7fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e7fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6eb475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6eaf1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e6dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e79e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e7fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e7fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6eb1e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6eb2017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6eb9f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48511fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4844171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6917663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6dc4fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6dc67a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f56ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f51b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f525a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f52879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf718a183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf718a7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71d15c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf701e85c) [/lib/libc.so.6] + 0x1785c
29: (0xf71d0f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
-07 17:27:35.971+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:35:966,1061.000000
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
06-07 17:27:36.521+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11213616c6f631528385132
06-07 17:27:36.571+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:36.571+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:36:578,1061.000000
06-07 17:27:36.591+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:36.601+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:36.601+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:36:603,0.306532,-0.080980,9.801523
06-07 17:27:36.661+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:36.691+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:36.701+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:36.731+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:36.781+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:36.791+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:36.891+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:36.891+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:36.931+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:36:793,1061.000000
06-07 17:27:36.951+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:36.961+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:36:620,0.070000,0.070000,0.070000
06-07 17:27:36.981+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:36:800,0.293894,-0.080599,9.801914
06-07 17:27:36.991+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:36.991+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:36:674,0.301496,-0.078963,9.863215
06-07 17:27:37.011+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:36:736,-0.013144,0.005076,0.061975
06-07 17:27:37.011+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:37.051+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:37.061+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:37.081+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:37.081+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:37.121+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:36:964,1061.000000
06-07 17:27:37.151+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:36:996,0.070000,0.070000,0.070000
06-07 17:27:37.151+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:37.241+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:37:22,0.301871,-0.088985,9.801599
06-07 17:27:37.241+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:37.291+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:37.291+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:37:295,0.070000,0.070000,0.070000
06-07 17:27:37.291+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:37.411+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:37:74,-0.026572,-0.002769,0.064085
06-07 17:27:37.411+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:37.501+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:37.501+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:37.521+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:37:63,0.279960,-0.083749,9.865608
06-07 17:27:37.521+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:37.561+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:37.561+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:37.571+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:37:164,1060.000000
06-07 17:27:37.581+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:37.591+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:37:587,1059.000000
06-07 17:27:37.591+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:37.601+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:37:246,0.313053,-0.101485,9.801126
06-07 17:27:37.601+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:37:526,0.325424,-0.110070,9.827322
06-07 17:27:37.611+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:37.621+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:37:417,0.031530,-0.029471,0.025408
06-07 17:27:37.621+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:37:605,1058.000000
06-07 17:27:37.621+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:37:621,0.309777,-0.102870,9.801216
06-07 17:27:37.631+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:37:300,0.070000,0.070000,0.070000
06-07 17:27:37.631+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:37.631+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:37.651+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:37.651+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:37:658,0.040303,-0.042620,0.047259
06-07 17:27:37.661+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:37.661+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:37:664,0.070000,0.070000,0.070000
06-07 17:27:37.671+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:37:642,0.342174,-0.131605,9.848858
06-07 17:27:37.671+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:37.671+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:37:666,0.301917,-0.098983,9.801501
06-07 17:27:37.681+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:37.681+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:37.681+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:37.681+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:37.691+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:37:683,0.313460,-0.110070,9.870394
06-07 17:27:37.701+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:37:688,0.000407,-0.008585,0.069267
06-07 17:27:37.711+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:37:689,0.070000,0.070000,0.070000
06-07 17:27:37.711+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:37.711+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:37.721+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:37:719,-0.013067,0.007157,0.081141
06-07 17:27:37.721+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:37:718,0.296710,-0.095713,9.882358
06-07 17:27:37.751+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:37.761+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:37.761+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:37.771+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:37:768,1056.000000
06-07 17:27:37.771+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:37:765,0.304008,-0.101958,9.801407
06-07 17:27:37.771+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:37:772,0.070000,0.070000,0.070000
06-07 17:27:37.771+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:37.781+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:37:786,0.318245,-0.112463,9.872787
06-07 17:27:37.781+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:37.801+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:37:792,0.016328,-0.013479,0.071285
06-07 17:27:37.881+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:37.881+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:37.951+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:37.961+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:37.961+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:37:966,1055.000000
06-07 17:27:37.961+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:37:970,0.286853,-0.088542,9.802053
06-07 17:27:37.961+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:37.971+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:37:974,0.070000,0.070000,0.070000
06-07 17:27:37.971+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:37.981+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:37:985,0.260818,-0.066999,9.896714
06-07 17:27:37.981+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:37.981+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:37:991,-0.043190,0.034959,0.095307
06-07 17:27:38.081+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:38.081+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:38.161+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:38.161+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:38:166,1052.000000
06-07 17:27:38.161+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:38.161+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:38:170,0.302661,-0.096075,9.801508
06-07 17:27:38.161+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:38.191+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:38:174,0.070000,-0.070000,0.070000
06-07 17:27:38.191+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:38.201+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:38.201+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:38:206,0.050535,-0.026313,0.065947
06-07 17:27:38.201+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:38:204,0.337388,-0.114855,9.868000
06-07 17:27:38.301+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:38.301+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:38.361+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:38.361+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:38:366,1051.000000
06-07 17:27:38.361+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:38.361+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:38.361+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:38:370,0.310634,-0.092524,9.801292
06-07 17:27:38.361+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:38:370,0.070000,-0.070000,0.070000
06-07 17:27:38.371+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:38.371+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:38.381+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:38:376,0.029941,0.007540,0.076063
06-07 17:27:38.381+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:38:378,0.332602,-0.088534,9.877571
06-07 17:27:38.481+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:38.481+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:38.551+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:38.561+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:38.561+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:38:565,0.070000,0.070000,0.070000
06-07 17:27:38.561+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:38.561+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:38.561+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:38.581+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:38:571,-0.028281,-0.005582,0.059530
06-07 17:27:38.581+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:38:573,0.282353,-0.098106,9.860823
06-07 17:27:38.581+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:38:580,0.297681,-0.093078,9.801689
06-07 17:27:38.611+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:38:565,1051.000000
06-07 17:27:38.681+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:38.701+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:38.751+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:38.761+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:38:765,0.070000,0.070000,0.070000
06-07 17:27:38.761+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:38.761+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:38.761+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:38.771+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:38.781+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:38:771,1049.000000
06-07 17:27:38.781+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:38:777,0.034922,0.004544,0.078275
06-07 17:27:38.781+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:38:774,0.305067,-0.090209,9.801489
06-07 17:27:38.791+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:38:778,0.332602,-0.088534,9.879964
06-07 17:27:38.881+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:38.881+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:38.951+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:38.961+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:38:965,0.070000,0.070000,0.070000
06-07 17:27:38.961+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:38.971+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:38.971+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:38:971,1046.000000
06-07 17:27:38.971+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:38.981+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:38.991+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:38:983,0.314969,-0.082070,9.801247
06-07 17:27:38.991+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __alarm_handler_idle(1486) > Lock the display not to enter LCD OFF
06-07 17:27:39.001+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
06-07 17:27:39.001+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:38:986,0.351745,-0.069392,9.903893
06-07 17:27:39.011+0200 W/AUL     ( 2466): app_signal.c: aul_update_freezer_status(456) > aul_update_freezer_status pid(2696) type(wakeup)
06-07 17:27:39.021+0200 E/RESOURCED( 2560): freezer-process.c: freezer_process_pid_set(150) > Cant find process info for 2696
06-07 17:27:39.021+0200 E/ALARM_MANAGER( 2696): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.astarter] : Alarm id [1569623859]
06-07 17:27:39.021+0200 W/STARTER ( 2696): clock-mgr.c: __starter_clock_mgr_homescreen_alarm_cb(979) > [__starter_clock_mgr_homescreen_alarm_cb:979] homescreen alarm timer expired [1569623859]
06-07 17:27:39.021+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __alarm_expired(1447) > alarm_id[1569623859] is expired.
06-07 17:27:39.031+0200 E/ALARM_MANAGER( 2466): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1569623859, next duetime: 1528385279
06-07 17:27:39.031+0200 W/AUL     ( 2696): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-home)
06-07 17:27:39.031+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:27:39.031+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 2696
06-07 17:27:39.041+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_resume_request_signal(567) > aul_send_app_resume_request_signal app(com.samsung.w-home) pid(2762) type(uiapp) bg(0)
06-07 17:27:39.041+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 2762
06-07 17:27:39.041+0200 I/APP_CORE( 2762): appcore-efl.c: __do_app(453) > [APP 2762] Event: RESET State: PAUSED
06-07 17:27:39.041+0200 I/CAPI_APPFW_APPLICATION( 2762): app_main.c: app_appcore_reset(245) > app_appcore_reset
06-07 17:27:39.041+0200 W/CAPI_APPFW_APP_CONTROL( 2762): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:27:39.041+0200 W/W_HOME  ( 2762): main.c: _app_control_progress(1571) > Service value : show_clock
06-07 17:27:39.041+0200 W/W_HOME  ( 2762): main.c: _app_control_progress(1588) > Show clock operation
06-07 17:27:39.041+0200 W/W_HOME  ( 2762): gesture.c: _clock_show(242) > clock show
06-07 17:27:39.051+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(2762), cmd(0)
06-07 17:27:39.061+0200 W/AUL     ( 2696): launch.c: app_request_to_launchpad(298) > request cmd(0) result(2762)
06-07 17:27:39.071+0200 E/ALARM_MANAGER( 2466): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(97378666) is OVER.
06-07 17:27:39.071+0200 E/ALARM_MANAGER( 2466): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(127082321) is OVER.
06-07 17:27:39.071+0200 E/ALARM_MANAGER( 2466): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(405561765) is OVER.
06-07 17:27:39.071+0200 E/ALARM_MANAGER( 2466): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(2077840997) is OVER.
06-07 17:27:39.071+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
06-07 17:27:39.071+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 7-6-2018, 15:27:59 (UTC).
06-07 17:27:39.071+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
06-07 17:27:39.071+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __alarm_handler_idle(1512) > Unlock the display from LCD OFF
06-07 17:27:39.081+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
06-07 17:27:39.081+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2696].
06-07 17:27:39.081+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(1569623859)
06-07 17:27:39.081+0200 E/ALARM_MANAGER( 2466): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(97378666) is OVER.
06-07 17:27:39.081+0200 E/ALARM_MANAGER( 2466): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(127082321) is OVER.
06-07 17:27:39.091+0200 E/ALARM_MANAGER( 2466): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(405561765) is OVER.
06-07 17:27:39.091+0200 E/ALARM_MANAGER( 2466): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(2077840997) is OVER.
06-07 17:27:39.091+0200 W/W_HOME  ( 2762): gesture.c: _clock_show(257) > home raise
06-07 17:27:39.091+0200 E/W_HOME  ( 2762): gesture.c: gesture_win_aux_set(402) > wm.policy.win.do.not.use.deiconify.approve:-1
06-07 17:27:39.091+0200 W/W_HOME  ( 2762): dbus_util.c: home_dbus_home_raise_signal_send(298) > Sending HOME RAISE signal, result:0
06-07 17:27:39.091+0200 W/W_HOME  ( 2762): gesture.c: _clock_show(260) > home raise done
06-07 17:27:39.091+0200 W/W_HOME  ( 2762): gesture.c: _clock_show(267) > show clock
06-07 17:27:39.091+0200 W/W_HOME  ( 2762): index.c: index_hide(337) > hide VI:0 visibility:0 vi:(nil)
06-07 17:27:39.091+0200 W/W_HOME  ( 2762): move.c: move_back_to_home_no_anim(274) > back to home no anim
06-07 17:27:39.091+0200 W/W_HOME  ( 2762): rotary.c: rotary_attach(138) > rotary_attach:0xf7da22a8
06-07 17:27:39.091+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf7da22a8, elm_layout, _activated_obj : 0xf7cf54f0, activated : 1
06-07 17:27:39.091+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
06-07 17:27:39.091+0200 W/W_HOME  ( 2762): event_manager.c: _move_module_anim_start_cb(666) > state: 0 -> 1
06-07 17:27:39.091+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:3, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
06-07 17:27:39.091+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
06-07 17:27:39.091+0200 W/W_HOME  ( 2762): event_manager.c: _move_module_anim_end_cb(680) > state: 1 -> 0
06-07 17:27:39.091+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:3, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-07 17:27:39.091+0200 W/W_HOME  ( 2762): rotary.c: rotary_deattach(156) > rotary_deattach:0xf7da22a8
06-07 17:27:39.101+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
06-07 17:27:39.101+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf7da22a8, elm_layout, func : 0xf7719d05
06-07 17:27:39.101+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
06-07 17:27:39.101+0200 W/W_INDICATOR( 2702): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
06-07 17:27:39.101+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
06-07 17:27:39.101+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
06-07 17:27:39.101+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf7cf54f0, elm_box, _activated_obj : 0xf7da22a8, activated : 1
06-07 17:27:39.101+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
06-07 17:27:39.101+0200 E/wnotib  ( 2762): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
06-07 17:27:39.101+0200 I/wnotib  ( 2762): w-notification-board-broker-main.c: _wnb_handle_scroller_event(1206) > No second depth view available.
06-07 17:27:39.101+0200 W/W_HOME  ( 2762): gesture.c: _manual_render(182) > 
06-07 17:27:39.111+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
06-07 17:27:39.111+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
06-07 17:27:39.111+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 7-6-2018, 21:48:26 (UTC).
06-07 17:27:39.111+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
06-07 17:27:39.121+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
06-07 17:27:39.121+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: alarm_manager_alarm_delete(2462) > alarm_id[1569623859] is removed.
06-07 17:27:39.121+0200 W/STARTER ( 2696): pkg-monitor.c: _app_mgr_status_cb(416) > [_app_mgr_status_cb:416] Resume request [2762]
06-07 17:27:39.131+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:39.131+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:39.131+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:38:985,0.046678,0.020817,0.102405
06-07 17:27:39.151+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:39.161+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:39:165,0.070000,0.070000,0.070000
06-07 17:27:39.161+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:39.171+0200 W/W_INDICATOR( 2702): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-07 17:27:39.171+0200 W/W_INDICATOR( 2702): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
06-07 17:27:39.171+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:39.171+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:39.171+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:39:178,0.022419,-0.013643,0.100254
06-07 17:27:39.181+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:39.191+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:39:171,1048.000000
06-07 17:27:39.191+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:39:193,0.337388,-0.095713,9.901501
06-07 17:27:39.191+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:39:177,0.318370,-0.085085,9.801111
06-07 17:27:39.261+0200 I/APP_CORE( 2762): appcore-efl.c: __do_app(529) > Legacy lifecycle: 1
06-07 17:27:39.261+0200 W/W_HOME  ( 2762): event_manager.c: _apptray_visibility_cb(604) > apps,hide,start
06-07 17:27:39.261+0200 W/W_HOME  ( 2762): event_manager.c: _apptray_visibility_cb(624) > state: 1 -> 0
06-07 17:27:39.261+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-07 17:27:39.261+0200 W/W_INDICATOR( 2702): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
06-07 17:27:39.261+0200 W/W_INDICATOR( 2702): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-07 17:27:39.261+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-07 17:27:39.261+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-07 17:27:39.261+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:5, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-07 17:27:39.261+0200 W/W_HOME  ( 2762): clock_manager.c: _compositing_set(205) > hwc:1
06-07 17:27:39.261+0200 W/W_HOME  ( 2762): noti_broker.c: _apptray_visibility_cb(793) > apps,hide,start
06-07 17:27:39.261+0200 W/W_HOME  ( 2762): noti_broker.c: noti_broker_event_fire_to_plugin(1010) > source:1 event:80002
06-07 17:27:39.261+0200 W/wnotib  ( 2762): w-notification-board-broker-main.c: _wnb_handle_view_event(1289) > Home view event: 0x80002
06-07 17:27:39.261+0200 I/wnotib  ( 2762): w-notification-board-broker-main.c: _wnb_handle_view_event(1396) > Unhandled type: 0x80002
06-07 17:27:39.261+0200 W/W_HOME  ( 2762): event_manager.c: _apptray_visibility_cb(604) > apps,hide
06-07 17:27:39.261+0200 W/W_HOME  ( 2762): event_manager.c: _apptray_visibility_cb(624) > state: 1 -> 0
06-07 17:27:39.261+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-07 17:27:39.261+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-07 17:27:39.261+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-07 17:27:39.261+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:5, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-07 17:27:39.261+0200 W/W_HOME  ( 2762): noti_broker.c: _apptray_visibility_cb(793) > apps,hide
06-07 17:27:39.261+0200 W/W_HOME  ( 2762): noti_broker.c: noti_broker_event_fire_to_plugin(1010) > source:1 event:80001
06-07 17:27:39.261+0200 W/wnotib  ( 2762): w-notification-board-broker-main.c: _wnb_handle_view_event(1289) > Home view event: 0x80001
06-07 17:27:39.261+0200 I/wnotib  ( 2762): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed_cb(1030) > is_app_tray_displayed: 0
06-07 17:27:39.261+0200 W/wnotib  ( 2762): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(969) > No postponed update with is_for_VI: 0.
06-07 17:27:39.271+0200 E/APPS    ( 2762): apps_main.c: apps_main_pause(984) >  paused already
06-07 17:27:39.271+0200 W/W_HOME  ( 2762): clock_manager.c: _hwc_enabled_success_cb(153) > hwc enabled
06-07 17:27:39.271+0200 W/W_HOME  ( 2762): clock_manager.c: _hwc_enabled_success_cb(156) > do manual_render to show HWC window
06-07 17:27:39.281+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:39.291+0200 W/W_INDICATOR( 2702): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
06-07 17:27:39.281+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:39.291+0200 W/W_INDICATOR( 2702): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-07 17:27:39.391+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:39.391+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:39:395,0.070000,0.070000,0.070000
06-07 17:27:39.401+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:39.401+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:39:405,1051.000000
06-07 17:27:39.411+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:39.411+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:39.411+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:39.421+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:39:418,0.314430,-0.078497,9.801293
06-07 17:27:39.431+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:39:420,-0.000125,0.015693,0.054925
06-07 17:27:39.431+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:39:423,0.318245,-0.069392,9.856036
06-07 17:27:39.491+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:39.491+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:39.551+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:39.561+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:39.561+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:39.561+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:39:568,0.013387,0.009105,0.078671
06-07 17:27:39.571+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:39.571+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:39.581+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:39:578,0.070000,0.070000,0.070000
06-07 17:27:39.581+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:39:582,1048.000000
06-07 17:27:39.591+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:39:563,0.314423,-0.074110,9.801328
06-07 17:27:39.591+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:39:569,0.327817,-0.069392,9.879964
06-07 17:27:39.691+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:39.691+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:39.751+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:39.761+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:39.761+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:39.761+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:39.771+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:39:775,0.070000,0.070000,0.070000
06-07 17:27:39.771+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:39:770,1043.000000
06-07 17:27:39.781+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:39.781+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:39:789,-0.022499,-0.021603,0.081030
06-07 17:27:39.791+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:39:769,0.302853,-0.080017,9.801646
06-07 17:27:39.801+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:39:763,0.291924,-0.095713,9.882358
06-07 17:27:39.891+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:39.891+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:39.951+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:39.961+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:39.961+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:39.971+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:39:974,1046.000000
06-07 17:27:39.971+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:39:970,0.070000,0.070000,0.070000
06-07 17:27:39.971+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:39.971+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:39.981+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:39:964,-0.018107,-0.056374,0.054390
06-07 17:27:39.991+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:39:981,0.294081,-0.097415,9.801756
06-07 17:27:39.991+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:39:985,0.284746,-0.136391,9.856036
06-07 17:27:40.041+0200 W/AUL_AMD ( 2479): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-07 17:27:40.041+0200 W/AUL_AMD ( 2479): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
06-07 17:27:40.081+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:40.081+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:40.151+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:40.161+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:40.161+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:40:166,1051.000000
06-07 17:27:40.171+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:40:164,0.070000,0.070000,0.070000
06-07 17:27:40.171+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:40.181+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:40:185,0.290599,-0.089794,9.801932
06-07 17:27:40.181+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:40.181+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:40.181+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:40:191,0.294317,-0.078963,9.875179
06-07 17:27:40.191+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:40:189,0.000236,0.018452,0.073423
06-07 17:27:40.281+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:40.281+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:40.351+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:40.361+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:40.371+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:40:369,1049.000000
06-07 17:27:40.371+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:40:365,0.070000,0.070000,0.070000
06-07 17:27:40.371+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:40.371+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:40:378,0.285528,-0.079853,9.802167
06-07 17:27:40.371+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:40.381+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:40.381+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:40:383,-0.003460,0.025188,0.106746
06-07 17:27:40.391+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:40:387,0.287139,-0.064606,9.908678
06-07 17:27:40.491+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:40.491+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:40.551+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:40.561+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:40.571+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:40:566,0.070000,0.070000,0.070000
06-07 17:27:40.571+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:40:566,1047.000000
06-07 17:27:40.571+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:40.581+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:40.581+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:40.581+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:40:586,0.039896,-0.011074,0.092155
06-07 17:27:40.591+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:40:583,0.294751,-0.082074,9.801876
06-07 17:27:40.601+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:40:588,0.325424,-0.090927,9.894321
06-07 17:27:40.691+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:40.691+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:40.751+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:40.761+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:40:765,1046.000000
06-07 17:27:40.761+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:40.771+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:40:770,0.070000,0.070000,0.070000
06-07 17:27:40.771+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:40.771+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:40.781+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:40.781+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:40:788,0.363709,-0.050249,9.911072
06-07 17:27:40.791+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:40:778,0.310038,-0.070653,9.801494
06-07 17:27:40.791+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:40:785,0.068958,0.031824,0.109196
06-07 17:27:40.891+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:40.891+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:40.951+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:40.961+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:40.971+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:40:964,1055.000000
06-07 17:27:40.971+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:40.971+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:40:966,0.070000,0.070000,0.070000
06-07 17:27:41.021+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:40:983,0.314055,-0.072034,9.801355
06-07 17:27:41.041+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:41.041+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:41.041+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:41:51,0.334995,-0.078963,9.882358
06-07 17:27:41.051+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11214126c6f63152838514
