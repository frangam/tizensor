S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 6999
Date: 2018-04-23 20:09:01+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6ffe52d, r5   = 0xf7824f98
r6   = 0xfff15ff0, r7   = 0xfff15ea0
r8   = 0xf7821c18, r9   = 0x00000000
r10  = 0xfff15f7c, fp   = 0xfff15ff0
ip   = 0x00000001, sp   = 0xfff15e78
lr   = 0xf6ffe539, pc   = 0xf7067228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    107564 KB
Buffers:     39596 KB
Cached:     185724 KB
VmPeak:      52512 KB
VmSize:      52508 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12008 KB
VmRSS:       12004 KB
VmData:      10236 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 6999 TID = 6999
6999 7002 

Maps Information
f3ec9000 f46c8000 rw-p [stack:7002]
f46cf000 f46d1000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f46d9000 f46dd000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f46e6000 f46e8000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f46f0000 f46f3000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4702000 f4707000 r-xp /usr/lib/libsystem.so.0.0.0
f4712000 f4715000 r-xp /lib/libattr.so.1.1.0
f471d000 f472d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4735000 f473e000 r-xp /usr/lib/libedbus.so.1.7.99
f4746000 f4747000 r-xp /usr/lib/libresponse.so.0.2.96
f4750000 f4755000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5ff7000 f60fd000 r-xp /usr/lib/libicuuc.so.57.1
f6113000 f629b000 r-xp /usr/lib/libicui18n.so.57.1
f62ab000 f62b8000 r-xp /usr/lib/libail.so.0.1.0
f62c1000 f62c8000 r-xp /usr/lib/libminizip.so.1.0.0
f62d1000 f647a000 r-xp /usr/lib/libcrypto.so.1.0.0
f649a000 f64e1000 r-xp /usr/lib/libssl.so.1.0.0
f64ed000 f64ef000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f64f7000 f64fe000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6507000 f650e000 r-xp /lib/libcrypt-2.13.so
f653f000 f6542000 r-xp /lib/libcap.so.2.21
f654a000 f654c000 r-xp /usr/lib/libiri.so
f6554000 f659d000 r-xp /usr/lib/libmdm.so.1.2.69
f65a5000 f65ab000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f65b3000 f65d6000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f65e0000 f65e2000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f65ea000 f6607000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6610000 f6614000 r-xp /usr/lib/libsmack.so.1.0.0
f661d000 f6636000 r-xp /usr/lib/libnetwork.so.0.0.0
f663f000 f6647000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f664f000 f6655000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f665e000 f6660000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6669000 f6679000 r-xp /lib/libresolv-2.13.so
f667d000 f6695000 r-xp /usr/lib/liblzma.so.5.0.3
f669e000 f66a0000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f66a8000 f66c2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f66ca000 f66f9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6702000 f6711000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f671b000 f6725000 r-xp /usr/lib/libsensord-shared.so
f672e000 f6801000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f680c000 f6822000 r-xp /lib/libz.so.1.2.5
f682a000 f682f000 r-xp /usr/lib/libffi.so.5.0.10
f6837000 f6838000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6840000 f6850000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6858000 f6871000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6879000 f687b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6883000 f68f8000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6902000 f6908000 r-xp /lib/librt-2.13.so
f6911000 f692f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6939000 f693a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6942000 f6965000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f696d000 f6972000 r-xp /usr/lib/libxdgmime.so.1.1.0
f697a000 f69a4000 r-xp /usr/lib/libdbus-1.so.3.8.12
f69ad000 f69c4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f69cc000 f6a35000 r-xp /lib/libm-2.13.so
f6a3e000 f6ad2000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ae5000 f6aea000 r-xp /usr/lib/libctx-client.so.0.8.3
f6af2000 f6af9000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6b01000 f6b2b000 r-xp /usr/lib/libsensor.so.1.9.6
f6b34000 f6c00000 r-xp /usr/lib/libxml2.so.2.7.8
f6c0d000 f6c0f000 r-xp /usr/lib/libiniparser.so.0
f6c18000 f6c1e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c27000 f6cf7000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6cf8000 f6d2c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d35000 f6d71000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6d79000 f6d7c000 r-xp /usr/lib/libbundle.so.0.1.22
f6d84000 f6d8a000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d92000 f6dd3000 r-xp /usr/lib/libeina.so.1.7.99
f6ddc000 f6df3000 r-xp /usr/lib/libecore.so.1.7.99
f6e0a000 f6e13000 r-xp /usr/lib/libvconf.so.0.2.45
f6e1b000 f6e2f000 r-xp /lib/libpthread-2.13.so
f6e3a000 f6e47000 r-xp /usr/lib/libaul.so.0.1.0
f6e51000 f6e53000 r-xp /lib/libdl-2.13.so
f6e5c000 f6e67000 r-xp /lib/libunwind.so.8.0.1
f6e94000 f6e9c000 r-xp /lib/libgcc_s-4.6.so.1
f6e9d000 f6fc1000 r-xp /lib/libc-2.13.so
f6fcf000 f6fd1000 r-xp /usr/lib/libdlog.so.0.0.0
f6fd9000 f6fe5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6fee000 f6ff3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6ffb000 f700a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7012000 f7016000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f701f000 f7022000 r-xp /usr/lib/libappcore-agent.so.1.1
f702a000 f702c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7034000 f7038000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7040000 f705d000 r-xp /lib/ld-2.13.so
f7066000 f7069000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7069000 f706d000 r-xp /usr/lib/libsys-assert.so
f77f1000 f787b000 rw-p [heap]
ffef7000 fff18000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6999)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7067228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf6ffe539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6d053f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6d03c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6d0fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6d15be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6d15dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6d4a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6d451f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6d03c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6d0fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6d15be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6d15dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6d47e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6d48017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6d4ff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf46e71fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf46da171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf67ad663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6c5afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6c5c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6decca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6de7b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6de85a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6de8879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7020183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70207fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70674f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6eb485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7066f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ty ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:51.349+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:51:357,0.048357,9.773265,0.807054
04-23 20:08:51.549+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:51.549+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:51:558,0.051588,9.773218,0.807418
04-23 20:08:51.749+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:51.749+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:51:758,0.045739,9.772865,0.812037
04-23 20:08:51.799+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:08:51.949+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:51.949+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:51:958,0.041880,9.772285,0.819203
04-23 20:08:52.149+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:52.149+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:52:158,0.052034,9.772964,0.810470
04-23 20:08:52.349+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:52.359+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:52:357,0.055614,9.773328,0.805828
04-23 20:08:52.549+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:52.549+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:52:558,0.047651,9.772985,0.810490
04-23 20:08:52.749+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:52.749+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:52:758,0.049571,9.773203,0.807728
04-23 20:08:52.949+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:52.949+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:52:958,0.058894,9.774909,0.786177
04-23 20:08:53.159+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:53.159+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:53:163,0.058875,9.773448,0.804134
04-23 20:08:53.349+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:53.349+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:53:357,0.051614,9.773278,0.806688
04-23 20:08:53.549+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:53.549+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:53:558,0.053204,9.772555,0.815299
04-23 20:08:53.749+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:53.759+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:53:759,0.050847,9.772350,0.817908
04-23 20:08:53.949+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:53.949+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:53:958,0.036351,9.771893,0.824123
04-23 20:08:54.149+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:54.159+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:54:162,0.034792,9.771632,0.827271
04-23 20:08:54.349+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:54.349+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:54:357,0.036924,9.771585,0.827739
04-23 20:08:54.549+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:54.549+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:54:559,0.041479,9.772146,0.820868
04-23 20:08:54.749+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:54.759+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:54:759,0.036575,9.772558,0.816178
04-23 20:08:54.949+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:54.949+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:54:959,0.044522,9.773715,0.801810
04-23 20:08:55.149+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:55.149+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:55:158,0.049110,9.774572,0.791018
04-23 20:08:55.349+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:55.359+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:55:357,0.040910,9.774228,0.795724
04-23 20:08:55.549+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:55.549+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:55:559,0.033178,9.772549,0.816441
04-23 20:08:55.749+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:55.749+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:55:758,0.034295,9.771813,0.825149
04-23 20:08:55.949+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:55.949+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:55:959,0.039859,9.771995,0.822749
04-23 20:08:56.149+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:56.159+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:56:159,0.054807,9.773493,0.803881
04-23 20:08:56.349+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:56.349+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:56:358,0.068359,9.772372,0.816371
04-23 20:08:56.549+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:56.549+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:56:559,0.055330,9.772027,0.821472
04-23 20:08:56.749+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:56.759+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:56:759,0.043414,9.771986,0.822673
04-23 20:08:56.949+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:56.959+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:56:959,0.057363,9.774447,0.792004
04-23 20:08:57.149+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:57.169+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:57:159,0.062440,9.773057,0.808605
04-23 20:08:57.349+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:57.359+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:57:358,0.065066,9.774124,0.795389
04-23 20:08:57.549+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:57.549+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:57:559,0.056349,9.774106,0.796283
04-23 20:08:57.749+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:57.749+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:57:759,0.041643,9.774062,0.797718
04-23 20:08:57.949+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:57.949+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:57:959,0.045428,9.772909,0.811522
04-23 20:08:58.039+0200 E/wnoti-ancs( 2993): wnoti-ancs.c: __wnoti_received_noti(2175) > received_len = 8 :: [0][10][9][1][3][0][0][0][0][0][0][0][0][0][0]
04-23 20:08:58.149+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:58.149+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:58:159,0.053013,9.773766,0.800670
04-23 20:08:58.349+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:58.349+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:58:357,0.053831,9.772607,0.814637
04-23 20:08:58.549+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:58.549+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:58:559,0.071879,9.768970,0.855839
04-23 20:08:58.749+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:58.749+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:58:759,0.067337,9.770370,0.840068
04-23 20:08:58.799+0200 I/servicemanager( 5532): es.ugr.frailty.location alive timeout
04-23 20:08:58.799+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:08:58.799+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:08:58.799+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:08:58.809+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 6999
04-23 20:08:58.809+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:08:58.849+0200 E/CAPI_APPFW_APPLICATION( 6999): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:08:58.849+0200 E/CAPI_APPFW_APPLICATION( 6999): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:08:58.859+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6999
04-23 20:08:58.859+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(6999) type(svcapp) bg(0)
04-23 20:08:58.859+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6999]
04-23 20:08:58.859+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (6999) was created
04-23 20:08:58.859+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6999)
04-23 20:08:58.869+0200 I/servicemanager( 5532): es.ugr.frailty.location launch request sent!
04-23 20:08:58.869+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:08:58.879+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:08:58.879+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6999
04-23 20:08:58.889+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:08:58.889+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:08:58.899+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6999
04-23 20:08:58.899+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:08:58.929+0200 W/LOCATION( 6999): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:08:58.929+0200 E/LOCATION( 6999): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:08:58.929+0200 E/PKGMGR_INFO( 6999): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:08:58.929+0200 W/LOCATION( 6999): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:58.949+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:58.949+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:58:958,0.059400,9.770841,0.835181
04-23 20:08:58.959+0200 I/LOCATION( 6999): location.c: location_new(269) > method: 0
04-23 20:08:58.959+0200 W/LOCATION( 6999): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:58.959+0200 W/LOCATION( 6999): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:58.969+0200 W/LOCATION( 6999): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:58.969+0200 W/LOCATION( 6999): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:58.979+0200 W/LOCATION( 6999): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:58.979+0200 W/LOCATION( 6999): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:58.979+0200 W/LOCATION( 6999): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:58.979+0200 W/LOCATION( 6999): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:58.979+0200 W/LOCATION( 6999): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:58.999+0200 W/LOCATION( 6999): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:08:58.999+0200 W/LOCATION( 6999): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:08:59.009+0200 W/LOCATION( 6999): module-internal.c: module_new(311) > module (wps) open success
04-23 20:08:59.009+0200 W/LOCATION( 6999): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:08:59.019+0200 W/LOCATION( 6999): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:08:59.019+0200 W/LOCATION( 6999): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:08:59.019+0200 W/LOCATION( 6999): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:08:59.029+0200 W/LOCATION( 6999): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:08:59.029+0200 I/LOCATION( 6999): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7821c18
04-23 20:08:59.029+0200 I/LOCATION( 6999): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:08:59.029+0200 I/LOCATION( 6999): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7821c18
04-23 20:08:59.029+0200 I/LOCATION( 6999): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:08:59.039+0200 I/location( 6999): es.ugr.frailty.location: creado servicio de localización
04-23 20:08:59.079+0200 I/LOCATION( 6999): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:08:59.119+0200 W/LOCATION( 6999): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:59.119+0200 W/LOCATION( 6999): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:59.119+0200 I/LOCATION( 6999): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:08:59.149+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.149+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:159,0.053256,9.772018,0.821707
04-23 20:08:59.199+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:08:59.199+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:08:59.199+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:08:59.199+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:08:59.199+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:08:59.199+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:08:59.199+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:59.199+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:59.209+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:08:59.209+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:08:59.209+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:08:59.209+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:08:59.209+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:08:59.209+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:08:59.209+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:08:59.209+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:08:59.209+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:08:59.209+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:08:59.269+0200 W/LOCATION( 6999): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:08:59.269+0200 W/LOCATION( 6999): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:08:59.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:08:59.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:59.349+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:08:59.359+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.369+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:59.389+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:363,0.050806,9.772517,0.815911
04-23 20:08:59.419+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79d8ce0]
04-23 20:08:59.419+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:08:59.419+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:08:59.419+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:08:59.419+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:08:59.419+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:59.419+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:59.439+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:59.439+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:59.439+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:08:59.439+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:08:59.439+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:59.439+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:59.439+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:59.439+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:59.439+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:59.439+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:59.439+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:59.449+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:59.459+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:08:59.459+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(1014721), time2(1001498)
04-23 20:08:59.459+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:08:59.459+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:08:59.459+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:08:59.459+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:08:59.469+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:59.469+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:08:59.469+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.469+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:59.499+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:483,0.050466,9.772622,0.814669
04-23 20:08:59.519+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:59.559+0200 W/LOCATION( 6999): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:08:59.559+0200 I/LOCATION( 6999): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:08:59.559+0200 I/LOCATION( 6999): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:08:59.559+0200 I/location( 6999): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:08:59.559+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.579+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:573,0.051525,9.772984,0.810265
04-23 20:08:59.579+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.579+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:584,0.051046,9.773161,0.808152
04-23 20:08:59.579+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.589+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:592,0.051855,9.773288,0.806565
04-23 20:08:59.599+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.599+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:603,0.052837,9.773447,0.804564
04-23 20:08:59.599+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.619+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:613,0.052872,9.773534,0.803512
04-23 20:08:59.619+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.619+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:624,0.053239,9.773626,0.802357
04-23 20:08:59.619+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.619+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:628,0.052898,9.773414,0.804966
04-23 20:08:59.629+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.629+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:638,0.053015,9.773387,0.805279
04-23 20:08:59.639+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.639+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:647,0.052098,9.773420,0.804937
04-23 20:08:59.649+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.659+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:654,0.052707,9.773390,0.805273
04-23 20:08:59.659+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.669+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:667,0.052267,9.773467,0.804355
04-23 20:08:59.669+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.679+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:683,0.054442,9.773515,0.803630
04-23 20:08:59.679+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.679+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:687,0.053700,9.773443,0.804554
04-23 20:08:59.689+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.689+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:696,0.053447,9.773343,0.805791
04-23 20:08:59.699+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.699+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:707,0.053315,9.773309,0.806217
04-23 20:08:59.709+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.719+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:714,0.052292,9.773287,0.806548
04-23 20:08:59.719+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.719+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:725,0.053834,9.773509,0.803742
04-23 20:08:59.729+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.729+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:737,0.054269,9.773722,0.801121
04-23 20:08:59.749+0200 I/LOCATION( 6999): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:08:59.749+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.749+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:759,0.056035,9.773726,0.800943
04-23 20:08:59.769+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.769+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:779,0.055229,9.773639,0.802077
04-23 20:08:59.789+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.789+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:797,0.054901,9.773569,0.802938
04-23 20:08:59.809+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.809+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:818,0.053323,9.773593,0.802754
04-23 20:08:59.819+0200 E/location( 6999): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:08:59.819+0200 W/AUL     ( 6999): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:08:59.819+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:08:59.819+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 6999
04-23 20:08:59.829+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:08:59.829+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:08:59.829+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:08:59.829+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.839+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:59.839+0200 I/utils   ( 5532): specific action
04-23 20:08:59.839+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:59.839+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:59.839+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:59.839+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:08:59.839+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:08:59.839+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:08:59.849+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:08:59.849+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:08:59.849+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:08:59.849+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:59.849+0200 I/utils   ( 5538): specific action
04-23 20:08:59.849+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:59.849+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:59.849+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:59.849+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:59.849+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:08:59.849+0200 I/recorder( 5538): guardando datos en local
04-23 20:08:59.849+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:08:59.849+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:08:59.849+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:08:59.849+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:842,0.055336,9.773567,0.802939
04-23 20:08:59.849+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.859+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:863,0.055146,9.773623,0.802261
04-23 20:08:59.859+0200 W/AUL     ( 6999): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:08:59.859+0200 I/location( 6999): request sent to service es.ugr.frailty.servicemanager
04-23 20:08:59.859+0200 W/CAPI_APPFW_APP_CONTROL( 6999): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:59.859+0200 I/utils   ( 6999): specific action
04-23 20:08:59.869+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.869+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:878,0.054490,9.773625,0.802287
04-23 20:08:59.889+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.889+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:897,0.055237,9.773644,0.802006
04-23 20:08:59.909+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.909+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:917,0.054907,9.773621,0.802314
04-23 20:08:59.929+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.939+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:938,0.056311,9.773757,0.800556
04-23 20:08:59.949+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.949+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:959,0.056388,9.773726,0.800928
04-23 20:08:59.969+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:977,0.055903,9.773589,0.802634
04-23 20:08:59.989+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:08:59.989+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:08:59:998,0.053705,9.773572,0.802993
04-23 20:09:00.009+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.009+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:18,0.052991,9.773554,0.803259
04-23 20:09:00.029+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.029+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:37,0.053440,9.773562,0.803125
04-23 20:09:00.049+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.049+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:59,0.052054,9.773527,0.803644
04-23 20:09:00.069+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.069+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:77,0.052559,9.773680,0.801756
04-23 20:09:00.089+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.089+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:97,0.052468,9.773638,0.802268
04-23 20:09:00.109+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.109+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:118,0.051237,9.773611,0.802671
04-23 20:09:00.129+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.139+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:138,0.049946,9.773674,0.801992
04-23 20:09:00.149+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.149+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:158,0.050320,9.773685,0.801822
04-23 20:09:00.169+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.169+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:178,0.050564,9.773786,0.800588
04-23 20:09:00.189+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.189+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:197,0.051288,9.773755,0.800918
04-23 20:09:00.209+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.209+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:217,0.051505,9.773869,0.799517
04-23 20:09:00.229+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.229+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:238,0.049524,9.773835,0.800053
04-23 20:09:00.249+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.259+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:259,0.049240,9.773870,0.799644
04-23 20:09:00.269+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.269+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:277,0.050695,9.774060,0.797226
04-23 20:09:00.289+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.289+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:298,0.051045,9.774070,0.797083
04-23 20:09:00.309+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.309+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:318,0.051530,9.774010,0.797783
04-23 20:09:00.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:09:00.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:09:00.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:09:00.399+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.399+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:404,0.051733,9.773882,0.799334
04-23 20:09:00.429+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.429+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:436,0.051138,9.773783,0.800588
04-23 20:09:00.439+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.449+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:446,0.051171,9.773651,0.802190
04-23 20:09:00.449+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.469+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:456,0.052409,9.773726,0.801194
04-23 20:09:00.469+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.479+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:482,0.051089,9.773731,0.801221
04-23 20:09:00.489+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.489+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:494,0.051215,9.773851,0.799746
04-23 20:09:00.499+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.499+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:504,0.052115,9.773811,0.800180
04-23 20:09:00.499+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.519+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:513,0.052856,9.773946,0.798485
04-23 20:09:00.539+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.549+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:553,0.054134,9.773967,0.798136
04-23 20:09:00.579+0200 E/CAPI_TELEPHONY( 4477): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:09:00.579+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.589+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:590,0.053297,9.773840,0.799747
04-23 20:09:00.589+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.589+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:595,0.052839,9.773830,0.799895
04-23 20:09:00.589+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.599+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:602,0.052637,9.773833,0.799874
04-23 20:09:00.599+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.599+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:607,0.053123,9.773745,0.800928
04-23 20:09:00.599+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.609+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:613,0.052234,9.773627,0.802409
04-23 20:09:00.609+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.619+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:619,0.050148,9.773439,0.804825
04-23 20:09:00.629+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.629+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:639,0.051669,9.773436,0.804777
04-23 20:09:00.649+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.649+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:658,0.052968,9.773405,0.805062
04-23 20:09:00.669+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.669+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:676,0.053796,9.773358,0.805581
04-23 20:09:00.689+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.689+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:696,0.052997,9.773299,0.806347
04-23 20:09:00.709+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.709+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:716,0.052047,9.773286,0.806578
04-23 20:09:00.729+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.729+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:735,0.052472,9.773225,0.807279
04-23 20:09:00.749+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.749+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:756,0.051053,9.773168,0.808066
04-23 20:09:00.769+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.769+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:776,0.051269,9.773088,0.809017
04-23 20:09:00.789+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.789+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:795,0.049305,9.773003,0.810168
04-23 20:09:00.809+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.809+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:815,0.051072,9.773067,0.809285
04-23 20:09:00.829+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.829+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:836,0.051101,9.773044,0.809558
04-23 20:09:00.849+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.849+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:856,0.051016,9.773071,0.809238
04-23 20:09:00.869+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.869+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:875,0.050897,9.772951,0.810693
04-23 20:09:00.889+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.959+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:901,0.050318,9.773018,0.809918
04-23 20:09:00.959+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.959+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:967,0.049204,9.772942,0.810915
04-23 20:09:00.959+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:971,0.049392,9.772891,0.811510
04-23 20:09:00.969+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:975,0.049899,9.772812,0.812429
04-23 20:09:00.969+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.979+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:980,0.049029,9.772708,0.813728
04-23 20:09:00.989+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:00.989+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:00:995,0.049002,9.772723,0.813549
04-23 20:09:01.009+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.009+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:16,0.048634,9.772799,0.812661
04-23 20:09:01.029+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.029+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:35,0.048403,9.772764,0.813094
04-23 20:09:01.049+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.049+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:56,0.050340,9.772873,0.811666
04-23 20:09:01.069+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.069+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:76,0.050933,9.772848,0.811924
04-23 20:09:01.089+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.089+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:95,0.049919,9.772796,0.812618
04-23 20:09:01.109+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.109+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:115,0.050096,9.772943,0.810828
04-23 20:09:01.129+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.129+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:136,0.050260,9.773077,0.809213
04-23 20:09:01.149+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.149+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:156,0.050525,9.773089,0.809041
04-23 20:09:01.169+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.169+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:176,0.050906,9.772932,0.810921
04-23 20:09:01.189+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.189+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:197,0.052930,9.772888,0.811320
04-23 20:09:01.209+0200 W/LOCATION( 6999): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:09:01.219+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.229+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:229,0.053669,9.772844,0.811800
04-23 20:09:01.229+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.239+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:240,0.053197,9.772985,0.810134
04-23 20:09:01.249+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.249+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:258,0.051273,9.772872,0.811623
04-23 20:09:01.269+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.269+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:277,0.052512,9.772853,0.811774
04-23 20:09:01.289+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.289+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:296,0.051882,9.772762,0.812906
04-23 20:09:01.309+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.309+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:317,0.051151,9.772877,0.811570
04-23 20:09:01.329+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:09:01.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:09:01.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:09:01.359+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:337,0.050902,9.772905,0.811238
04-23 20:09:01.359+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.359+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:366,0.051468,9.772764,0.812900
04-23 20:09:01.369+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.369+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:377,0.050865,9.772785,0.812697
04-23 20:09:01.389+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.389+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:396,0.050892,9.772861,0.811767
04-23 20:09:01.409+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.409+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:416,0.050572,9.772809,0.812425
04-23 20:09:01.429+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.429+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:437,0.051397,9.772910,0.811157
04-23 20:09:01.449+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.449+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:457,0.051601,9.772675,0.813970
04-23 20:09:01.489+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.489+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:497,0.053503,9.772774,0.812655
04-23 20:09:01.499+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.509+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:504,0.054519,9.772868,0.811451
04-23 20:09:01.509+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:01.509+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:01:516,0.054574,9.772758,0.812775
04-23 20:09:01.519+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11069996c6f63152450694
