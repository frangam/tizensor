S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 5814
Date: 2018-04-23 20:05:30+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6fd052d, r5   = 0xf7132958
r6   = 0xffdd85c0, r7   = 0xffdd8470
r8   = 0xf7145c18, r9   = 0x00000000
r10  = 0xffdd854c, fp   = 0xffdd85c0
ip   = 0x00000001, sp   = 0xffdd8448
lr   = 0xf6fd0539, pc   = 0xf7039228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     18432 KB
Buffers:     37072 KB
Cached:     224200 KB
VmPeak:      52532 KB
VmSize:      52528 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11944 KB
VmRSS:       11944 KB
VmData:      10256 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 5814 TID = 5814
5814 5817 

Maps Information
f3e9b000 f469a000 rw-p [stack:5817]
f46a1000 f46a3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f46ab000 f46af000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f46b8000 f46ba000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f46c2000 f46c5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f46d4000 f46d9000 r-xp /usr/lib/libsystem.so.0.0.0
f46e4000 f46e7000 r-xp /lib/libattr.so.1.1.0
f46ef000 f46ff000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4707000 f4710000 r-xp /usr/lib/libedbus.so.1.7.99
f4718000 f4719000 r-xp /usr/lib/libresponse.so.0.2.96
f4722000 f4727000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5fc9000 f60cf000 r-xp /usr/lib/libicuuc.so.57.1
f60e5000 f626d000 r-xp /usr/lib/libicui18n.so.57.1
f627d000 f628a000 r-xp /usr/lib/libail.so.0.1.0
f6293000 f629a000 r-xp /usr/lib/libminizip.so.1.0.0
f62a3000 f644c000 r-xp /usr/lib/libcrypto.so.1.0.0
f646c000 f64b3000 r-xp /usr/lib/libssl.so.1.0.0
f64bf000 f64c1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f64c9000 f64d0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f64d9000 f64e0000 r-xp /lib/libcrypt-2.13.so
f6511000 f6514000 r-xp /lib/libcap.so.2.21
f651c000 f651e000 r-xp /usr/lib/libiri.so
f6526000 f656f000 r-xp /usr/lib/libmdm.so.1.2.69
f6577000 f657d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6585000 f65a8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f65b2000 f65b4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f65bc000 f65d9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f65e2000 f65e6000 r-xp /usr/lib/libsmack.so.1.0.0
f65ef000 f6608000 r-xp /usr/lib/libnetwork.so.0.0.0
f6611000 f6619000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6621000 f6627000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6630000 f6632000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f663b000 f664b000 r-xp /lib/libresolv-2.13.so
f664f000 f6667000 r-xp /usr/lib/liblzma.so.5.0.3
f6670000 f6672000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f667a000 f6694000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f669c000 f66cb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f66d4000 f66e3000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f66ed000 f66f7000 r-xp /usr/lib/libsensord-shared.so
f6700000 f67d3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f67de000 f67f4000 r-xp /lib/libz.so.1.2.5
f67fc000 f6801000 r-xp /usr/lib/libffi.so.5.0.10
f6809000 f680a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6812000 f6822000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f682a000 f6843000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f684b000 f684d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6855000 f68ca000 r-xp /usr/lib/libsqlite3.so.0.8.6
f68d4000 f68da000 r-xp /lib/librt-2.13.so
f68e3000 f6901000 r-xp /usr/lib/libsystemd.so.0.4.0
f690b000 f690c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6914000 f6937000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f693f000 f6944000 r-xp /usr/lib/libxdgmime.so.1.1.0
f694c000 f6976000 r-xp /usr/lib/libdbus-1.so.3.8.12
f697f000 f6996000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f699e000 f6a07000 r-xp /lib/libm-2.13.so
f6a10000 f6aa4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ab7000 f6abc000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ac4000 f6acb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ad3000 f6afd000 r-xp /usr/lib/libsensor.so.1.9.6
f6b06000 f6bd2000 r-xp /usr/lib/libxml2.so.2.7.8
f6bdf000 f6be1000 r-xp /usr/lib/libiniparser.so.0
f6bea000 f6bf0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6bf9000 f6cc9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6cca000 f6cfe000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d07000 f6d43000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6d4b000 f6d4e000 r-xp /usr/lib/libbundle.so.0.1.22
f6d56000 f6d5c000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d64000 f6da5000 r-xp /usr/lib/libeina.so.1.7.99
f6dae000 f6dc5000 r-xp /usr/lib/libecore.so.1.7.99
f6ddc000 f6de5000 r-xp /usr/lib/libvconf.so.0.2.45
f6ded000 f6e01000 r-xp /lib/libpthread-2.13.so
f6e0c000 f6e19000 r-xp /usr/lib/libaul.so.0.1.0
f6e23000 f6e25000 r-xp /lib/libdl-2.13.so
f6e2e000 f6e39000 r-xp /lib/libunwind.so.8.0.1
f6e66000 f6e6e000 r-xp /lib/libgcc_s-4.6.so.1
f6e6f000 f6f93000 r-xp /lib/libc-2.13.so
f6fa1000 f6fa3000 r-xp /usr/lib/libdlog.so.0.0.0
f6fab000 f6fb7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6fc0000 f6fc5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6fcd000 f6fdc000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f6fe4000 f6fe8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6ff1000 f6ff4000 r-xp /usr/lib/libappcore-agent.so.1.1
f6ffc000 f6ffe000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7006000 f700a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7012000 f702f000 r-xp /lib/ld-2.13.so
f7038000 f703b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f703b000 f703f000 r-xp /usr/lib/libsys-assert.so
f7115000 f71a4000 rw-p [heap]
ffdb9000 ffdda000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5814)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7039228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf6fd0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6cd73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6cd5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6ce1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6ce7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6ce7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6d1c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6d171f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6cd5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6ce1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6ce7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6ce7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6d19e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6d1a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6d21f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf46b91fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf46ac171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf677f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6c2cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6c2e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6dbeca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6db9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6dba5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6dba879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf6ff2183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf6ff27fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70394f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6e8685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7038f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
leration
04-23 20:05:29.949+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:29.949+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:29.959+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:29.959+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:29.969+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:29:964,-0.029081,0.043530,-0.012820
04-23 20:05:29.969+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:29:956,0.053698,9.771811,0.824148
04-23 20:05:29.969+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:29:963,-0.070000,0.070000,0.070000
04-23 20:05:29.969+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:29.979+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:29:966,0.023928,9.815358,0.811167
04-23 20:05:29.979+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:29.979+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:29.979+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:29.989+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:29:993,0.008516,0.060298,-0.051266
04-23 20:05:29.999+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:29:984,0.052428,9.771711,0.825402
04-23 20:05:29.999+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:29:997,-0.070000,0.070000,0.070000
04-23 20:05:29.999+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:29.999+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:29:998,0.062213,9.832108,0.772882
04-23 20:05:29.999+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.009+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.009+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:10,0.053035,9.771854,0.823671
04-23 20:05:30.009+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.019+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:19,-0.038071,0.036469,-0.054913
04-23 20:05:30.019+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:21,0.014357,9.808180,0.770489
04-23 20:05:30.019+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:21,-0.070000,0.070000,0.070000
04-23 20:05:30.029+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.029+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.029+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.029+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.029+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:39,-0.070000,0.070000,0.070000
04-23 20:05:30.039+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:34,0.051318,9.771861,0.823703
04-23 20:05:30.049+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.049+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:43,-0.012357,0.045897,-0.060360
04-23 20:05:30.049+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:55,0.050949,9.771973,0.822402
04-23 20:05:30.049+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:43,0.040678,9.817751,0.763310
04-23 20:05:30.049+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.049+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.049+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.079+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.109+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:63,-0.070000,0.070000,0.070000
04-23 20:05:30.149+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:64,-0.048926,0.036319,-0.017322
04-23 20:05:30.149+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.149+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:68,0.002393,9.808180,0.806381
04-23 20:05:30.149+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.159+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.159+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:30.159+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:156,0.048789,9.771832,0.824189
04-23 20:05:30.169+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:161,-0.070000,0.070000,0.070000
04-23 20:05:30.169+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:30.169+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.169+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.169+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:156,-0.022235,0.038601,-0.008842
04-23 20:05:30.169+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.169+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:164,0.028714,9.810574,0.813560
04-23 20:05:30.169+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.179+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:176,0.047981,9.771721,0.825558
04-23 20:05:30.189+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:175,-0.070000,0.070000,0.070000
04-23 20:05:30.189+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:180,-0.046396,-0.011509,-0.017807
04-23 20:05:30.189+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.189+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.199+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:183,0.002393,9.760324,0.806381
04-23 20:05:30.199+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.199+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.209+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:205,0.069392,9.812965,0.787239
04-23 20:05:30.209+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.209+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:202,0.045964,9.771565,0.827511
04-23 20:05:30.209+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.209+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:219,0.047223,9.771675,0.826144
04-23 20:05:30.219+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:207,-0.070000,0.070000,0.070000
04-23 20:05:30.219+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.219+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:198,0.021411,0.041245,-0.038319
04-23 20:05:30.219+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.219+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:225,-0.070000,0.070000,0.070000
04-23 20:05:30.229+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:216,0.028714,9.798609,0.813560
04-23 20:05:30.229+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.239+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.239+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:228,-0.017250,0.027043,-0.013951
04-23 20:05:30.239+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.249+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.249+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:243,0.046170,9.771768,0.825110
04-23 20:05:30.249+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.259+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:237,0.078963,9.793823,0.772882
04-23 20:05:30.259+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.259+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:249,-0.070000,0.280000,-0.070000
04-23 20:05:30.259+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.259+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:253,0.031740,0.022148,-0.053262
04-23 20:05:30.259+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.269+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:265,0.033500,9.789038,0.803988
04-23 20:05:30.269+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.279+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:256,0.047873,9.771921,0.823193
04-23 20:05:30.279+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.279+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:267,-0.070000,0.280000,0.070000
04-23 20:05:30.279+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.289+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:285,0.047336,9.771845,0.824132
04-23 20:05:30.289+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.289+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:296,0.048525,9.771818,0.824381
04-23 20:05:30.289+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.289+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:270,-0.012670,0.017270,-0.021122
04-23 20:05:30.299+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.299+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:292,-0.070000,0.070000,0.070000
04-23 20:05:30.299+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:303,0.021519,0.019509,-0.014419
04-23 20:05:30.309+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:279,0.069392,9.791430,0.808774
04-23 20:05:30.309+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.309+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.309+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:319,-0.070000,0.070000,0.070000
04-23 20:05:30.319+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.319+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:324,0.057948,0.038729,-0.044072
04-23 20:05:30.319+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.319+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:329,0.008903,0.031576,-0.037143
04-23 20:05:30.329+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:300,0.051379,9.772017,0.821855
04-23 20:05:30.329+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:05:30.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:05:30.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:05:30.339+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:315,0.105284,9.810574,0.780060
04-23 20:05:30.339+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.339+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.349+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:350,0.057428,9.803394,0.787239
04-23 20:05:30.359+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:353,-0.070000,0.070000,0.070000
04-23 20:05:30.359+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.359+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.369+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:336,0.051802,9.772083,0.821031
04-23 20:05:30.369+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.369+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.369+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:376,-0.013094,0.040949,-0.010688
04-23 20:05:30.379+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:30.379+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:374,0.051302,9.771994,0.822126
04-23 20:05:30.379+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:369,0.038285,9.812965,0.811167
04-23 20:05:30.379+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.379+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:389,0.045464,9.805787,0.792024
04-23 20:05:30.389+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:365,0.070000,0.070000,0.070000
04-23 20:05:30.389+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.389+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:394,-0.070000,0.070000,0.070000
04-23 20:05:30.389+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.399+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.409+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.419+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:409,-0.006339,0.033704,-0.029006
04-23 20:05:30.419+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.429+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:417,0.051166,9.771993,0.822146
04-23 20:05:30.429+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.429+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:400,-0.070000,0.070000,0.070000
04-23 20:05:30.439+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.439+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.449+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:427,0.055035,9.789038,0.796810
04-23 20:05:30.449+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.449+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:437,0.003733,0.017044,-0.025316
04-23 20:05:30.449+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.459+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:447,0.051496,9.771985,0.822220
04-23 20:05:30.459+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.459+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:452,-0.070000,0.070000,0.070000
04-23 20:05:30.459+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.469+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:462,-0.000917,-0.002098,-0.003801
04-23 20:05:30.469+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:454,0.050249,9.769895,0.818345
04-23 20:05:30.469+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:30.469+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.469+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:464,0.051587,9.771873,0.823537
04-23 20:05:30.469+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.479+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.479+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:477,0.050249,9.808180,0.801596
04-23 20:05:30.489+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:471,-0.070000,0.070000,0.070000
04-23 20:05:30.489+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.489+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.489+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:486,-0.001247,0.036195,-0.020625
04-23 20:05:30.489+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.499+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:494,-0.070000,0.140000,0.070000
04-23 20:05:30.499+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:480,0.051658,9.771839,0.823934
04-23 20:05:30.499+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.499+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:509,0.052850,9.771874,0.823448
04-23 20:05:30.509+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:498,0.074178,9.846465,0.799203
04-23 20:05:30.509+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.509+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.519+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:500,0.022591,0.074592,-0.024335
04-23 20:05:30.519+0200 W/LOCATION( 5814): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:05:30.529+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:522,-0.070000,0.140000,0.070000
04-23 20:05:30.529+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.539+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.539+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:517,0.045464,9.798609,0.806381
04-23 20:05:30.539+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.549+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:555,-0.070000,0.140000,0.070000
04-23 20:05:30.549+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.559+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:539,-0.006194,0.026770,-0.017553
04-23 20:05:30.559+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:543,0.052637,9.771811,0.824218
04-23 20:05:30.559+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.569+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.569+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:561,0.047856,9.793823,0.827917
04-23 20:05:30.569+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.579+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.579+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:569,-0.004994,0.021949,0.004468
04-23 20:05:30.579+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:582,-0.070000,0.140000,0.070000
04-23 20:05:30.589+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:576,0.052548,9.771666,0.825943
04-23 20:05:30.589+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.589+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.599+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:593,0.038285,9.769895,0.801596
04-23 20:05:30.599+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.599+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:602,-0.014351,-0.001916,-0.022623
04-23 20:05:30.609+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.609+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:605,0.052013,9.771607,0.826661
04-23 20:05:30.609+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:618,0.021535,9.817751,0.818345
04-23 20:05:30.619+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:612,-0.070000,0.140000,0.070000
04-23 20:05:30.619+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.619+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.619+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:628,-0.031013,0.046085,-0.007597
04-23 20:05:30.629+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:30.629+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:30.629+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.639+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.639+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:634,0.050730,9.771514,0.827842
04-23 20:05:30.639+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:648,0.033500,9.791430,0.803988
04-23 20:05:30.649+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.649+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.659+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:644,-0.070000,-0.140000,0.070000
04-23 20:05:30.659+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.659+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.659+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:656,-0.018513,0.019823,-0.022673
04-23 20:05:30.669+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:658,0.050068,9.771478,0.828311
04-23 20:05:30.669+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.669+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.669+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:667,-0.070000,-0.070000,0.070000
04-23 20:05:30.689+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:675,0.011964,9.822537,0.823131
04-23 20:05:30.689+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.689+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:686,0.048421,9.771346,0.829963
04-23 20:05:30.689+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.709+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:703,0.033500,9.832108,0.782453
04-23 20:05:30.709+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:699,-0.070000,-0.070000,0.070000
04-23 20:05:30.709+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.709+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:684,-0.038104,0.051060,-0.005180
04-23 20:05:30.709+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.719+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.719+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.729+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:721,0.047845,9.771388,0.829499
04-23 20:05:30.729+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:723,-0.016568,0.060631,-0.045858
04-23 20:05:30.729+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.729+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.739+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:733,0.074178,9.789038,0.787239
04-23 20:05:30.739+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:730,-0.070000,0.070000,0.070000
04-23 20:05:30.749+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.749+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.759+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:743,0.049252,9.771503,0.828053
04-23 20:05:30.759+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:747,0.025756,0.017692,-0.042724
04-23 20:05:30.759+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:30.759+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:30.759+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:761,0.026321,9.765109,0.789631
04-23 20:05:30.769+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.769+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.769+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:758,-0.070000,0.070000,0.070000
04-23 20:05:30.789+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.789+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.789+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:779,0.048305,9.771475,0.828455
04-23 20:05:30.789+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:783,-0.021524,-0.006279,-0.039867
04-23 20:05:30.799+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.799+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.799+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:795,-0.070000,0.070000,0.070000
04-23 20:05:30.809+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.809+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:801,0.043071,9.779467,0.770489
04-23 20:05:30.809+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.819+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:811,0.048208,9.771560,0.827457
04-23 20:05:30.819+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:813,-0.006181,0.007963,-0.057564
04-23 20:05:30.819+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.829+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.829+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:819,-0.140000,0.070000,0.070000
04-23 20:05:30.839+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:823,0.076570,9.803394,0.818345
04-23 20:05:30.839+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.839+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:838,0.028265,0.031919,-0.010110
04-23 20:05:30.849+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.849+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:835,0.049704,9.771525,0.827772
04-23 20:05:30.859+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.859+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.859+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:849,-0.140000,-0.070000,0.070000
04-23 20:05:30.869+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.869+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:856,0.047856,9.791430,0.794417
04-23 20:05:30.869+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:865,0.049762,9.771537,0.827631
04-23 20:05:30.879+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.879+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:886,0.014357,9.798609,0.763310
04-23 20:05:30.889+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:868,-0.000352,0.019871,-0.033040
04-23 20:05:30.889+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.889+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.889+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:895,0.048211,9.771588,0.827117
04-23 20:05:30.889+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:880,-0.070000,0.070000,0.070000
04-23 20:05:30.899+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.899+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.909+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:913,0.026321,9.839286,0.832702
04-23 20:05:30.909+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:899,-0.035347,0.027083,-0.064461
04-23 20:05:30.909+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.909+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.919+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:905,-0.070000,-0.070000,0.070000
04-23 20:05:30.919+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.919+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:924,-0.023441,0.067749,0.005071
04-23 20:05:30.929+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.929+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:919,0.047318,9.771422,0.829125
04-23 20:05:30.929+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.939+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.939+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:937,0.066999,9.796216,0.813560
04-23 20:05:30.939+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:30:948,0.018788,0.024628,-0.013557
04-23 20:05:30.939+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:934,-0.070000,0.070000,0.070000
04-23 20:05:30.949+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.949+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.959+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:944,0.048405,9.771416,0.829136
04-23 20:05:30.959+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:30.959+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:30.989+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:30:967,0.050249,9.803394,0.789631
04-23 20:05:30.989+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:30.989+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:30.999+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:30:962,-0.070000,-0.070000,0.070000
04-23 20:05:30.999+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:30.999+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:30.999+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:31:3,0.002932,0.031972,-0.039494
04-23 20:05:31.009+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:31:7,-0.070000,-0.070000,0.070000
04-23 20:05:31.009+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:30:999,0.048649,9.771484,0.828321
04-23 20:05:31.019+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:31.019+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:31.019+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:31:21,0.023928,9.810574,0.818345
04-23 20:05:31.019+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:31:25,0.047331,9.771613,0.826879
04-23 20:05:31.029+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:31.029+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:31:26,-0.024477,0.039158,-0.010791
04-23 20:05:31.029+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:31.039+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:31:43,0.031107,9.772287,0.808774
04-23 20:05:31.039+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:31.039+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:31:37,-0.070000,-0.070000,-0.070000
04-23 20:05:31.049+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:31.059+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:31:52,0.046721,9.771543,0.827741
04-23 20:05:31.059+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:31.059+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:31.069+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:31:59,-0.017542,0.000803,-0.019547
04-23 20:05:31.069+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:31.069+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:31:66,-0.070000,-0.070000,0.070000
04-23 20:05:31.079+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:31.089+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:31.089+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:31:70,0.059821,9.812965,0.777667
04-23 20:05:31.089+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:31:95,-0.070000,-0.140000,0.070000
04-23 20:05:31.089+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:31.089+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:31:79,0.047512,9.771697,0.825868
04-23 20:05:31.099+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:31.099+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:31:86,0.012489,0.041352,-0.049212
04-23 20:05:31.099+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:31.099+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:31:105,0.048136,9.771716,0.825609
04-23 20:05:31.109+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:31:100,0.057428,9.812965,0.801596
04-23 20:05:31.109+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:31:115,0.010706,0.041423,-0.026145
04-23 20:05:31.109+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:31.119+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:31.119+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:31.119+0200 I/servicemanager( 5532): es.ugr.frailty.location sleep timeout
04-23 20:05:31.119+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:05:31.129+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:05:31.129+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:05:31.139+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5814
04-23 20:05:31.139+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5814)
04-23 20:05:31.139+0200 I/servicemanager( 5532): es.ugr.frailty.location stop request sent!
04-23 20:05:31.139+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:05:31.139+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:31.139+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:31:120,-0.070000,-0.070000,0.070000
04-23 20:05:31.139+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:31:124,0.043071,9.822537,0.813560
04-23 20:05:31.139+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:31.149+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:31.159+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:31:130,0.048046,9.771661,0.826268
04-23 20:05:31.159+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:31.159+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:31:150,-0.004441,0.050840,-0.012309
04-23 20:05:31.159+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:31.159+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:31.159+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:31:162,0.026321,9.812965,0.796810
04-23 20:05:31.169+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:31:157,-0.070000,-0.070000,0.070000
04-23 20:05:31.169+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:31.169+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:31.179+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:31.189+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:31:193,0.040678,9.815358,0.825524
04-23 20:05:31.189+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:31:167,0.047164,9.771635,0.826622
04-23 20:05:31.189+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:31:183,-0.021815,0.041249,-0.028799
04-23 20:05:31.189+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:31.199+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:31.199+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:31:184,-0.070000,-0.070000,0.070000
04-23 20:05:31.209+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:31.209+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:31.209+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:31:212,-0.007368,0.043697,-0.000744
04-23 20:05:31.219+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:31:202,0.047010,9.771529,0.827881
04-23 20:05:31.219+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:31.219+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:31:229,0.047209,9.771417,0.829196
04-23 20:05:31.229+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:31.229+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:31:215,-0.070000,-0.070000,0.070000
04-23 20:05:31.229+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:31:223,0.047856,9.781858,0.827917
04-23 20:05:31.229+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:31.229+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:31:238,0.000692,0.010223,0.001294
04-23 20:05:31.239+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:31:242,-0.070000,-0.070000,0.070000
04-23 20:05:31.239+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:31.239+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:31.249+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:31:251,0.023928,9.803394,0.811167
04-23 20:05:31.249+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:31.249+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:31.259+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:31:267,-0.023082,0.031865,-0.016714
04-23 20:05:31.269+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:31:253,0.046239,9.771309,0.830519
04-23 20:05:31.269+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:31.269+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:31:271,-0.070000,0.140000,0.070000
04-23 20:05:31.269+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:31.279+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:31.279+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:31:281,0.044653,9.771120,0.832827
04-23 20:05:31.279+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:31.289+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:31:279,0.009571,9.817751,0.832702
04-23 20:05:31.289+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:31.299+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:31.309+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:31:297,-0.070000,0.070000,0.070000
04-23 20:05:31.309+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:31:295,-0.037637,0.046334,0.003507
04-23 20:05:31.309+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:31.309+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:31.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:05:31.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:05:31.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:05:31.349+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:31:307,0.031107,9.834501,0.811167
04-23 20:05:31.359+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:31:325,-0.070000,0.070000,0.070000
04-23 20:05:31.359+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:31:310,0.044147,9.771054,0.833626
04-23 20:05:31.359+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:31.359+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:31.369+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:31.369+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:31.369+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:31:376,0.044811,9.771164,0.832305
04-23 20:05:31.379+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:31:358,-0.015133,0.063192,-0.019352
04-23 20:05:31.379+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:31.379+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:31.389+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:31:371,0.055035,9.815358,0.784846
04-23 20:05:31.389+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:31.399+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:31.399+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:31:391,0.010382,0.044238,-0.047981
04-23 20:05:31.409+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:31:390,-0.070000,0.070000,0.070000
04-23 20:05:31.409+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:31.409+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:31.409+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:31:403,0.088534,9.829715,0.806381
04-23 20:05:31.419+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:31:422,-0.140000,0.070000,0.070000
04-23 20:05:31.419+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:31:413,0.047023,9.771232,0.831391
04-23 20:05:31.419+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:31.429+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:31.429+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:31:423,0.044388,0.058661,-0.027245
04-23 20:05:31.439+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:31.439+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:31.439+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:31:435,0.047856,9.810574,0.758525
04-23 20:05:31.449+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:31.449+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:31:440,0.047211,9.771420,0.829153
04-23 20:05:31.459+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11058146c6f63152450673
