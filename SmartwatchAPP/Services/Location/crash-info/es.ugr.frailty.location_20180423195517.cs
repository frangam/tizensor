S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 3788
Date: 2018-04-23 19:55:17+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf729a52d, r5   = 0xf77cff98
r6   = 0xffb526e0, r7   = 0xffb52590
r8   = 0xf77ccc18, r9   = 0x00000000
r10  = 0xffb5266c, fp   = 0xffb526e0
ip   = 0x00000001, sp   = 0xffb52568
lr   = 0xf729a539, pc   = 0xf7303228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     78360 KB
Buffers:     31416 KB
Cached:     215388 KB
VmPeak:      53556 KB
VmSize:      53552 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12056 KB
VmRSS:       12056 KB
VmData:      11280 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3788 TID = 3788
3788 3818 

Maps Information
f4165000 f4964000 rw-p [stack:3818]
f496b000 f496d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4975000 f4979000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4982000 f4984000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f498c000 f498f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f499e000 f49a3000 r-xp /usr/lib/libsystem.so.0.0.0
f49ae000 f49b1000 r-xp /lib/libattr.so.1.1.0
f49b9000 f49c9000 r-xp /usr/lib/libmdm-common.so.1.1.24
f49d1000 f49da000 r-xp /usr/lib/libedbus.so.1.7.99
f49e2000 f49e3000 r-xp /usr/lib/libresponse.so.0.2.96
f49ec000 f49f1000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6293000 f6399000 r-xp /usr/lib/libicuuc.so.57.1
f63af000 f6537000 r-xp /usr/lib/libicui18n.so.57.1
f6547000 f6554000 r-xp /usr/lib/libail.so.0.1.0
f655d000 f6564000 r-xp /usr/lib/libminizip.so.1.0.0
f656d000 f6716000 r-xp /usr/lib/libcrypto.so.1.0.0
f6736000 f677d000 r-xp /usr/lib/libssl.so.1.0.0
f6789000 f678b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6793000 f679a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f67a3000 f67aa000 r-xp /lib/libcrypt-2.13.so
f67db000 f67de000 r-xp /lib/libcap.so.2.21
f67e6000 f67e8000 r-xp /usr/lib/libiri.so
f67f0000 f6839000 r-xp /usr/lib/libmdm.so.1.2.69
f6841000 f6847000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f684f000 f6872000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f687c000 f687e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6886000 f68a3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f68ac000 f68b0000 r-xp /usr/lib/libsmack.so.1.0.0
f68b9000 f68d2000 r-xp /usr/lib/libnetwork.so.0.0.0
f68db000 f68e3000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f68eb000 f68f1000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f68fa000 f68fc000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6905000 f6915000 r-xp /lib/libresolv-2.13.so
f6919000 f6931000 r-xp /usr/lib/liblzma.so.5.0.3
f693a000 f693c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6944000 f695e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6966000 f6995000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f699e000 f69ad000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f69b7000 f69c1000 r-xp /usr/lib/libsensord-shared.so
f69ca000 f6a9d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6aa8000 f6abe000 r-xp /lib/libz.so.1.2.5
f6ac6000 f6acb000 r-xp /usr/lib/libffi.so.5.0.10
f6ad3000 f6ad4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6adc000 f6aec000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6af4000 f6b0d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b15000 f6b17000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b1f000 f6b94000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b9e000 f6ba4000 r-xp /lib/librt-2.13.so
f6bad000 f6bcb000 r-xp /usr/lib/libsystemd.so.0.4.0
f6bd5000 f6bd6000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6bde000 f6c01000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c09000 f6c0e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c16000 f6c40000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c49000 f6c60000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c68000 f6cd1000 r-xp /lib/libm-2.13.so
f6cda000 f6d6e000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d81000 f6d86000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d8e000 f6d95000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d9d000 f6dc7000 r-xp /usr/lib/libsensor.so.1.9.6
f6dd0000 f6e9c000 r-xp /usr/lib/libxml2.so.2.7.8
f6ea9000 f6eab000 r-xp /usr/lib/libiniparser.so.0
f6eb4000 f6eba000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ec3000 f6f93000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f94000 f6fc8000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6fd1000 f700d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7015000 f7018000 r-xp /usr/lib/libbundle.so.0.1.22
f7020000 f7026000 r-xp /usr/lib/libappsvc.so.0.1.0
f702e000 f706f000 r-xp /usr/lib/libeina.so.1.7.99
f7078000 f708f000 r-xp /usr/lib/libecore.so.1.7.99
f70a6000 f70af000 r-xp /usr/lib/libvconf.so.0.2.45
f70b7000 f70cb000 r-xp /lib/libpthread-2.13.so
f70d6000 f70e3000 r-xp /usr/lib/libaul.so.0.1.0
f70ed000 f70ef000 r-xp /lib/libdl-2.13.so
f70f8000 f7103000 r-xp /lib/libunwind.so.8.0.1
f7130000 f7138000 r-xp /lib/libgcc_s-4.6.so.1
f7139000 f725d000 r-xp /lib/libc-2.13.so
f726b000 f726d000 r-xp /usr/lib/libdlog.so.0.0.0
f7275000 f7281000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f728a000 f728f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7297000 f72a6000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f72ae000 f72b2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f72bb000 f72be000 r-xp /usr/lib/libappcore-agent.so.1.1
f72c6000 f72c8000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f72d0000 f72d4000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f72dc000 f72f9000 r-xp /lib/ld-2.13.so
f7302000 f7305000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7305000 f7309000 r-xp /usr/lib/libsys-assert.so
f779c000 f7827000 rw-p [heap]
ffb33000 ffb54000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3788)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7303228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf729a539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6fa13f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f9fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6fabe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6fb1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6fb1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6fe675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6fe11f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f9fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6fabe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6fb1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6fb1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6fe3e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6fe4017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6febf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49831fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4976171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a49663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6ef6fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6ef87a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7088ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7083b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70845a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7084879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf72bc183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72bc7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73034f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf715085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7302f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
uring data from es.ugr.frailty.linearacceleration
04-23 19:55:17.029+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.039+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:39,-0.056604,0.022539,-0.069481
04-23 19:55:17.039+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:33,0.071785,9.817751,0.815953
04-23 19:55:17.039+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.039+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.039+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:47,0.034670,9.769122,0.856406
04-23 19:55:17.039+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:47,-0.023928,9.791430,0.789631
04-23 19:55:17.039+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:40,-0.070000,0.070000,0.070000
04-23 19:55:17.039+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.049+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.049+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.059+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:53,-0.070000,0.070000,0.070000
04-23 19:55:17.059+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.059+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:58,0.032329,0.055807,-0.061989
04-23 19:55:17.059+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.069+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:64,0.032001,9.768797,0.860217
04-23 19:55:17.069+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:59,0.066999,9.824929,0.794417
04-23 19:55:17.069+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:66,-0.070000,0.070000,0.070000
04-23 19:55:17.069+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.069+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.079+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.079+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:79,0.003891,0.039383,-0.041871
04-23 19:55:17.079+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:83,0.035892,9.808180,0.818345
04-23 19:55:17.079+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.079+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:79,-0.070000,-0.140000,0.070000
04-23 19:55:17.089+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:88,0.033834,9.769210,0.855440
04-23 19:55:17.089+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.089+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.089+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.099+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:101,0.009237,0.065291,-0.058630
04-23 19:55:17.099+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.099+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:106,0.034073,9.769200,0.855541
04-23 19:55:17.099+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:101,0.043071,9.834501,0.796810
04-23 19:55:17.099+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:106,-0.070000,0.070000,0.070000
04-23 19:55:17.109+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.109+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.109+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.119+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:120,-0.005359,0.034194,-0.058731
04-23 19:55:17.119+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.119+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:123,-0.070000,-0.070000,0.070000
04-23 19:55:17.119+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:125,0.034654,9.769379,0.853474
04-23 19:55:17.119+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:121,0.028714,9.803394,0.796810
04-23 19:55:17.129+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.129+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.139+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:138,0.006024,0.017266,-0.025558
04-23 19:55:17.139+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.149+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.149+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.169+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:159,0.015723,0.026772,-0.020025
04-23 19:55:17.169+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:139,0.034527,9.769444,0.852727
04-23 19:55:17.169+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:158,0.040678,9.786645,0.827917
04-23 19:55:17.169+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.179+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:153,-0.070000,-0.070000,0.070000
04-23 19:55:17.179+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.179+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.189+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.199+0200 I/heartrate( 3676): capturing data from es.ugr.frailty.heartrate
04-23 19:55:17.199+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:182,0.050249,9.796216,0.832702
04-23 19:55:17.199+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:185,-0.070000,-0.070000,0.070000
04-23 19:55:17.199+0200 I/heartrate( 3676): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:55:17.199+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:193,-0.039760,0.012433,-0.051333
04-23 19:55:17.199+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.209+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:187,0.034975,9.769425,0.852928
04-23 19:55:17.209+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:211,-0.007288,0.010204,-0.055548
04-23 19:55:17.209+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.219+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.219+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:223,-0.004786,9.781858,0.801596
04-23 19:55:17.219+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.229+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.229+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.239+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:239,0.036002,9.769262,0.854751
04-23 19:55:17.239+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:234,-0.070000,-0.070000,0.140000
04-23 19:55:17.239+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.239+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.249+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:221,0.049539,0.053437,-0.038329
04-23 19:55:17.249+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.259+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:249,-0.070000,-0.070000,0.070000
04-23 19:55:17.259+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.259+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:252,0.034210,9.769100,0.856674
04-23 19:55:17.269+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:229,0.028714,9.779467,0.799203
04-23 19:55:17.269+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.269+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.279+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:274,0.083749,9.822537,0.818345
04-23 19:55:17.279+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.279+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:257,-0.024536,0.036626,-0.047206
04-23 19:55:17.289+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:290,0.009571,9.805787,0.808774
04-23 19:55:17.289+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:268,-0.070000,-0.070000,0.070000
04-23 19:55:17.289+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.289+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.289+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:296,0.045464,9.786645,0.799203
04-23 19:55:17.289+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.299+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:282,0.034107,9.769161,0.855980
04-23 19:55:17.299+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.299+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.299+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:302,0.052642,9.791430,0.849452
04-23 19:55:17.299+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.299+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:308,0.045464,9.839286,0.811167
04-23 19:55:17.309+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:296,0.008856,0.017216,-0.053612
04-23 19:55:17.309+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.309+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:314,0.017167,0.022091,-0.004435
04-23 19:55:17.309+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.309+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.309+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:304,0.036607,9.769429,0.852814
04-23 19:55:17.309+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.319+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:306,-0.070000,-0.070000,0.070000
04-23 19:55:17.319+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.319+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:320,0.031107,9.777073,0.808774
04-23 19:55:17.319+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:326,0.009351,0.069798,-0.041009
04-23 19:55:17.319+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.319+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:324,-0.070000,-0.070000,0.070000
04-23 19:55:17.319+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.329+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:322,0.035475,9.769340,0.853887
04-23 19:55:17.329+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.329+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:332,-0.005937,0.007668,-0.044312
04-23 19:55:17.329+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.329+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:333,-0.070000,-0.070000,0.070000
04-23 19:55:17.339+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.339+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:340,0.052642,9.801002,0.799203
04-23 19:55:17.339+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.339+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:343,-0.070000,-0.070000,0.070000
04-23 19:55:17.339+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.339+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:346,0.015069,0.031544,-0.053250
04-23 19:55:17.349+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:349,-0.070000,0.140000,0.070000
04-23 19:55:17.349+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:335,0.036112,9.769487,0.852175
04-23 19:55:17.349+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.349+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.349+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:354,-0.070000,0.140000,0.070000
04-23 19:55:17.349+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.349+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.359+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.359+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:359,0.055035,9.784252,0.784846
04-23 19:55:17.359+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:354,0.037043,9.769404,0.853086
04-23 19:55:17.359+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.359+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:363,0.017629,0.014825,-0.067959
04-23 19:55:17.359+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:365,0.037573,9.769458,0.852452
04-23 19:55:17.359+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.359+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:360,0.070000,-0.210000,0.070000
04-23 19:55:17.359+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:369,0.037406,9.769427,0.852805
04-23 19:55:17.369+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.369+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:373,0.038297,9.769657,0.850127
04-23 19:55:17.369+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.369+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.379+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:380,0.031107,9.805787,0.847059
04-23 19:55:17.379+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.379+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.379+0200 I/heartrate( 3676): capturing data from es.ugr.frailty.heartrate
04-23 19:55:17.379+0200 I/heartrate( 3676): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:55:17.379+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:380,-0.007191,0.036130,-0.003068
04-23 19:55:17.379+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:386,0.039271,9.769945,0.846764
04-23 19:55:17.389+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:386,0.070000,-0.210000,0.070000
04-23 19:55:17.389+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.389+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.399+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:400,0.018157,-0.016800,-0.028419
04-23 19:55:17.399+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:400,0.057428,9.753145,0.818345
04-23 19:55:17.399+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.399+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.399+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:404,0.039028,9.769766,0.848848
04-23 19:55:17.399+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:405,-0.070000,0.070000,0.070000
04-23 19:55:17.409+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.409+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.419+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:419,0.023185,0.016879,-0.018538
04-23 19:55:17.419+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:420,0.062213,9.786645,0.830309
04-23 19:55:17.419+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.419+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.419+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:424,-0.070000,0.070000,0.070000
04-23 19:55:17.419+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:425,0.040055,9.769786,0.848571
04-23 19:55:17.429+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.429+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.439+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:439,-0.020913,0.026430,-0.015869
04-23 19:55:17.439+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.439+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:439,0.019143,9.796216,0.832702
04-23 19:55:17.439+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.439+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:444,-0.070000,0.070000,0.070000
04-23 19:55:17.439+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:445,0.041247,9.769769,0.848705
04-23 19:55:17.449+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.449+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.459+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:460,-0.017319,0.031233,-0.047110
04-23 19:55:17.459+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.469+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:471,-0.070000,0.070000,0.070000
04-23 19:55:17.469+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.479+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:480,-0.047523,0.024206,-0.020181
04-23 19:55:17.479+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 19:55:17.479+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:55:17.479+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 19:55:17.479+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.489+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:461,0.023928,9.801002,0.801596
04-23 19:55:17.489+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.489+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:492,-0.070000,0.070000,0.070000
04-23 19:55:17.489+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.489+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.499+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:497,-0.007178,9.793823,0.830309
04-23 19:55:17.499+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.499+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:500,0.010545,0.012256,-0.020382
04-23 19:55:17.499+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.509+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:499,0.040345,9.769617,0.850490
04-23 19:55:17.509+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.509+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.519+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:511,-0.070000,0.070000,0.070000
04-23 19:55:17.519+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:521,-0.035234,0.007711,-0.039993
04-23 19:55:17.519+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.519+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:519,0.039705,9.769603,0.850691
04-23 19:55:17.519+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.529+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:508,0.050249,9.781858,0.830309
04-23 19:55:17.529+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.529+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.539+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:533,-0.070000,-0.070000,0.070000
04-23 19:55:17.539+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:539,-0.002490,0.045995,-0.068652
04-23 19:55:17.539+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.539+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:537,0.002393,9.777073,0.813560
04-23 19:55:17.539+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.539+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:533,0.037627,9.769361,0.853552
04-23 19:55:17.549+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.549+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.549+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:551,0.035892,9.815358,0.784846
04-23 19:55:17.559+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:553,0.038383,9.769363,0.853498
04-23 19:55:17.559+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.559+0200 W/LOCATION( 3788): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:55:17.559+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.569+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:565,0.036826,9.769231,0.855077
04-23 19:55:17.569+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.569+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:570,0.043071,9.784252,0.844666
04-23 19:55:17.569+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.579+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:549,-0.070000,-0.070000,0.070000
04-23 19:55:17.579+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.579+0200 I/heartrate( 3676): capturing data from es.ugr.frailty.heartrate
04-23 19:55:17.579+0200 I/heartrate( 3676): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:55:17.579+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:561,0.006245,0.015021,-0.010411
04-23 19:55:17.579+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.579+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:586,-0.070000,-0.210000,0.070000
04-23 19:55:17.579+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.589+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:593,-0.070000,-0.070000,0.070000
04-23 19:55:17.589+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.589+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:577,0.036950,9.769431,0.852783
04-23 19:55:17.589+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.599+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:600,0.070000,-0.070000,0.070000
04-23 19:55:17.599+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:589,0.034834,0.041142,-0.063151
04-23 19:55:17.599+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:602,0.037396,9.769339,0.853824
04-23 19:55:17.599+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.599+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.599+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:606,0.039196,9.769690,0.849709
04-23 19:55:17.599+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:607,-0.008682,0.029270,0.014771
04-23 19:55:17.599+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:582,0.071785,9.810574,0.789631
04-23 19:55:17.599+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.609+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:612,0.028714,9.798609,0.868595
04-23 19:55:17.609+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.609+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.609+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.619+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:619,0.040678,9.798609,0.825524
04-23 19:55:17.619+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.619+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:623,-0.070000,-0.070000,0.070000
04-23 19:55:17.619+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:624,0.038862,9.769457,0.852395
04-23 19:55:17.619+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:620,0.001482,0.028919,-0.024185
04-23 19:55:17.629+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.629+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.639+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.639+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:640,0.016173,0.055472,-0.022086
04-23 19:55:17.639+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:644,0.055035,9.824929,0.830309
04-23 19:55:17.639+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:639,-0.070000,-0.070000,0.070000
04-23 19:55:17.639+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.649+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:650,0.039103,9.769445,0.852521
04-23 19:55:17.649+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.649+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.659+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.659+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:658,0.070000,-0.070000,0.070000
04-23 19:55:17.659+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:659,-0.012782,0.014807,-0.036569
04-23 19:55:17.659+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:663,0.026321,9.784252,0.815953
04-23 19:55:17.669+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.669+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:673,0.039999,9.769495,0.851907
04-23 19:55:17.669+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.669+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.669+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.679+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:679,0.070000,-0.070000,0.070000
04-23 19:55:17.679+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:683,-0.001714,0.067398,-0.069454
04-23 19:55:17.679+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.679+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:680,0.038285,9.836893,0.782453
04-23 19:55:17.679+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:687,0.039500,9.769491,0.851983
04-23 19:55:17.689+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.689+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.699+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:700,0.038285,9.774680,0.772882
04-23 19:55:17.699+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:700,0.070000,-0.070000,0.070000
04-23 19:55:17.699+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.699+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.699+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:704,-0.001214,0.005189,-0.079101
04-23 19:55:17.699+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:705,0.039587,9.769698,0.849602
04-23 19:55:17.709+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.709+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.709+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:719,0.001091,0.002589,-0.028863
04-23 19:55:17.709+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:719,0.040678,9.772287,0.820738
04-23 19:55:17.719+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.719+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:723,0.070000,-0.140000,0.070000
04-23 19:55:17.719+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.729+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:729,0.039689,9.769929,0.846931
04-23 19:55:17.729+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.729+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.729+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.739+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:740,0.010560,0.059786,0.021663
04-23 19:55:17.739+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.739+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:740,0.070000,-0.070000,0.070000
04-23 19:55:17.739+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:739,0.050249,9.829715,0.868595
04-23 19:55:17.739+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:746,0.039890,9.769931,0.846898
04-23 19:55:17.749+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.749+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.749+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:759,-0.070000,-0.070000,0.070000
04-23 19:55:17.749+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:759,0.062213,9.769895,0.823131
04-23 19:55:17.759+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.759+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:763,0.022323,-0.000036,-0.023767
04-23 19:55:17.759+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.759+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:769,0.040520,9.769737,0.849105
04-23 19:55:17.769+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.769+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.769+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.769+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:779,0.009571,9.796216,0.813560
04-23 19:55:17.779+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:779,-0.070000,-0.070000,0.070000
04-23 19:55:17.779+0200 I/heartrate( 3676): capturing data from es.ugr.frailty.heartrate
04-23 19:55:17.779+0200 I/heartrate( 3676): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:55:17.779+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:780,-0.030949,0.026479,-0.035545
04-23 19:55:17.779+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.779+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:789,0.041712,9.769774,0.848617
04-23 19:55:17.789+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.789+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.789+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.799+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:799,-0.070000,-0.070000,0.070000
04-23 19:55:17.799+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.799+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:803,0.030073,0.000120,-0.058985
04-23 19:55:17.799+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:800,0.071785,9.769895,0.789631
04-23 19:55:17.799+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:804,0.040337,9.769687,0.849695
04-23 19:55:17.809+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.809+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.809+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.819+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:819,-0.070000,-0.070000,0.070000
04-23 19:55:17.819+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.819+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:819,0.021535,9.803394,0.799203
04-23 19:55:17.819+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:821,-0.018801,0.033708,-0.050492
04-23 19:55:17.819+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:825,0.042015,9.769941,0.846678
04-23 19:55:17.839+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.839+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.839+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.849+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:846,0.031107,9.805787,0.820738
04-23 19:55:17.849+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:844,-0.010908,0.035846,-0.025940
04-23 19:55:17.849+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.849+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.859+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:863,0.035892,9.791430,0.799203
04-23 19:55:17.859+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.859+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:852,0.070000,-0.070000,0.070000
04-23 19:55:17.859+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.869+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:871,0.070000,0.140000,0.070000
04-23 19:55:17.869+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:871,0.041184,9.769972,0.846366
04-23 19:55:17.869+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:863,-0.005291,0.021459,-0.047163
04-23 19:55:17.869+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.869+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.879+0200 I/servicemanager( 3660): es.ugr.frailty.location sleep timeout
04-23 19:55:17.879+0200 W/AUL     ( 3660): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 19:55:17.879+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:55:17.879+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 3660
04-23 19:55:17.879+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:882,0.002393,9.817751,0.856631
04-23 19:55:17.879+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.879+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:888,-0.038441,0.047837,0.009578
04-23 19:55:17.879+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.889+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 3788
04-23 19:55:17.889+0200 W/AUL     ( 3660): launch.c: app_request_to_launchpad(298) > request cmd(0) result(3788)
04-23 19:55:17.889+0200 I/servicemanager( 3660): es.ugr.frailty.location stop request sent!
04-23 19:55:17.889+0200 I/servicemanager( 3660): App control destroyed.
04-23 19:55:17.889+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:879,0.070000,0.140000,0.070000
04-23 19:55:17.889+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:892,0.040834,9.769914,0.847052
04-23 19:55:17.889+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.889+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.899+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:899,0.070000,0.140000,0.070000
04-23 19:55:17.899+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:900,0.033500,9.779467,0.801596
04-23 19:55:17.899+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.899+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:905,-0.007230,0.009507,-0.044941
04-23 19:55:17.899+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.909+0200 E/AUL_AMD ( 2481): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 19:55:17.909+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 19:55:17.909+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(3788), cmd(0)
04-23 19:55:17.909+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:910,0.040730,9.769959,0.846537
04-23 19:55:17.909+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:17.919+0200 W/AUL     ( 3826): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 19:55:17.919+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 19:55:17.919+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 19:55:17.919+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:55:17.919+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 19:55:17.919+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 19:55:17.919+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 19:55:17.919+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 19:55:17.919+0200 E/CAPI_LOCATION_MANAGER( 3740): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 19:55:17.919+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 19:55:17.929+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 19:55:17.929+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 19:55:17.929+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 3788
04-23 19:55:17.929+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 19:55:17.929+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:17.929+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 3788
04-23 19:55:17.929+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(3788)
04-23 19:55:17.939+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:55:17.939+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.949+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:950,0.059821,9.798609,0.770489
04-23 19:55:17.949+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.949+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.949+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:954,0.020756,0.028908,-0.079101
04-23 19:55:17.959+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:958,0.050249,9.789038,0.825524
04-23 19:55:17.959+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.959+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:17.959+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:965,0.011310,0.019334,-0.024035
04-23 19:55:17.959+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:969,0.002393,9.796216,0.827917
04-23 19:55:17.969+0200 I/linearacceleration( 3792): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:17.969+0200 I/linearacceleration( 3792): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:17:974,-0.037698,0.026222,-0.018253
04-23 19:55:17.969+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:18.009+0200 I/CAPI_NETWORK_CONNECTION( 3740): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 19:55:18.009+0200 I/CAPI_NETWORK_CONNECTION( 3740): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 19:55:18.009+0200 I/CAPI_NETWORK_CONNECTION( 3740): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 19:55:18.009+0200 I/CAPI_NETWORK_CONNECTION( 3740): connection.c: connection_destroy(471) > Destroy handle: 0xf3e02690
04-23 19:55:18.009+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:17:935,-0.070000,0.140000,0.070000
04-23 19:55:18.019+0200 I/heartrate( 3676): capturing data from es.ugr.frailty.heartrate
04-23 19:55:18.019+0200 I/heartrate( 3676): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:55:18.019+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:18.019+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:18:25,-0.070000,0.140000,0.070000
04-23 19:55:18.019+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:18.029+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:18:33,-0.070000,0.070000,0.070000
04-23 19:55:18.029+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:18.029+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:18:37,-0.070000,0.070000,0.070000
04-23 19:55:18.029+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:18.039+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:18:41,-0.070000,-0.070000,0.070000
04-23 19:55:18.039+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:18.039+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:18:45,-0.070000,0.070000,0.070000
04-23 19:55:18.039+0200 I/gyroscope( 3776): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:18.049+0200 I/gyroscope( 3776): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:18:50,-0.070000,-0.070000,0.070000
04-23 19:55:18.049+0200 I/accelerometer( 3763): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:17:980,0.066999,9.796216,0.782453
04-23 19:55:18.049+0200 I/accelerometer( 3763): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:18.049+0200 I/gravity ( 3804): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:17:915,0.039065,9.769701,0.849590
04-23 19:55:18.059+0200 I/gravity ( 3804): capturing data from es.ugr.frailty.gravity
04-23 19:55:18.059+0200 W/CRASH_MANAGER( 3827): worker.c: worker_job(1205) > 11037886c6f63152450611
