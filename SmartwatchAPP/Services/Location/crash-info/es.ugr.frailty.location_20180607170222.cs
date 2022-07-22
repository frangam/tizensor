S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 14799
Date: 2018-06-07 17:02:22+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf71f052d, r5   = 0xf7a59958
r6   = 0xffc62310, r7   = 0xffc621c0
r8   = 0xf7a6cc18, r9   = 0x00000000
r10  = 0xffc6229c, fp   = 0xffc62310
ip   = 0x00000001, sp   = 0xffc62198
lr   = 0xf71f0539, pc   = 0xf7259228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    151088 KB
Buffers:      9060 KB
Cached:      50672 KB
VmPeak:      53568 KB
VmSize:      53564 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11672 KB
VmRSS:       11672 KB
VmData:      11292 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 14799 TID = 14799
14799 14820 

Maps Information
f40bb000 f48ba000 rw-p [stack:14820]
f48c1000 f48c3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f48cb000 f48cf000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f48d8000 f48da000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f48e2000 f48e5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f48f4000 f48f9000 r-xp /usr/lib/libsystem.so.0.0.0
f4904000 f4907000 r-xp /lib/libattr.so.1.1.0
f490f000 f491f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4927000 f4930000 r-xp /usr/lib/libedbus.so.1.7.99
f4938000 f4939000 r-xp /usr/lib/libresponse.so.0.2.96
f4942000 f4947000 r-xp /usr/lib/libproc-stat.so.0.2.96
f61e9000 f62ef000 r-xp /usr/lib/libicuuc.so.57.1
f6305000 f648d000 r-xp /usr/lib/libicui18n.so.57.1
f649d000 f64aa000 r-xp /usr/lib/libail.so.0.1.0
f64b3000 f64ba000 r-xp /usr/lib/libminizip.so.1.0.0
f64c3000 f666c000 r-xp /usr/lib/libcrypto.so.1.0.0
f668c000 f66d3000 r-xp /usr/lib/libssl.so.1.0.0
f66df000 f66e1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f66e9000 f66f0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f66f9000 f6700000 r-xp /lib/libcrypt-2.13.so
f6731000 f6734000 r-xp /lib/libcap.so.2.21
f673c000 f673e000 r-xp /usr/lib/libiri.so
f6746000 f678f000 r-xp /usr/lib/libmdm.so.1.2.69
f6797000 f679d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f67a5000 f67c8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f67d2000 f67d4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f67dc000 f67f9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6802000 f6806000 r-xp /usr/lib/libsmack.so.1.0.0
f680f000 f6828000 r-xp /usr/lib/libnetwork.so.0.0.0
f6831000 f6839000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6841000 f6847000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6850000 f6852000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f685b000 f686b000 r-xp /lib/libresolv-2.13.so
f686f000 f6887000 r-xp /usr/lib/liblzma.so.5.0.3
f6890000 f6892000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f689a000 f68b4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f68bc000 f68eb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68f4000 f6903000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f690d000 f6917000 r-xp /usr/lib/libsensord-shared.so
f6920000 f69f3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f69fe000 f6a14000 r-xp /lib/libz.so.1.2.5
f6a1c000 f6a21000 r-xp /usr/lib/libffi.so.5.0.10
f6a29000 f6a2a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a32000 f6a42000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a4a000 f6a63000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a6b000 f6a6d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a75000 f6aea000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6af4000 f6afa000 r-xp /lib/librt-2.13.so
f6b03000 f6b21000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b2b000 f6b2c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b34000 f6b57000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b5f000 f6b64000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b6c000 f6b96000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b9f000 f6bb6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6bbe000 f6c27000 r-xp /lib/libm-2.13.so
f6c30000 f6cc4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6cd7000 f6cdc000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ce4000 f6ceb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6cf3000 f6d1d000 r-xp /usr/lib/libsensor.so.1.9.6
f6d26000 f6df2000 r-xp /usr/lib/libxml2.so.2.7.8
f6dff000 f6e01000 r-xp /usr/lib/libiniparser.so.0
f6e0a000 f6e10000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e19000 f6ee9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6eea000 f6f1e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f27000 f6f63000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f6b000 f6f6e000 r-xp /usr/lib/libbundle.so.0.1.22
f6f76000 f6f7c000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f84000 f6fc5000 r-xp /usr/lib/libeina.so.1.7.99
f6fce000 f6fe5000 r-xp /usr/lib/libecore.so.1.7.99
f6ffc000 f7005000 r-xp /usr/lib/libvconf.so.0.2.45
f700d000 f7021000 r-xp /lib/libpthread-2.13.so
f702c000 f7039000 r-xp /usr/lib/libaul.so.0.1.0
f7043000 f7045000 r-xp /lib/libdl-2.13.so
f704e000 f7059000 r-xp /lib/libunwind.so.8.0.1
f7086000 f708e000 r-xp /lib/libgcc_s-4.6.so.1
f708f000 f71b3000 r-xp /lib/libc-2.13.so
f71c1000 f71c3000 r-xp /usr/lib/libdlog.so.0.0.0
f71cb000 f71d7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71e0000 f71e5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f71ed000 f71fc000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7204000 f7208000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7211000 f7214000 r-xp /usr/lib/libappcore-agent.so.1.1
f721c000 f721e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7226000 f722a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7232000 f724f000 r-xp /lib/ld-2.13.so
f7258000 f725b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f725b000 f725f000 r-xp /usr/lib/libsys-assert.so
f7a3c000 f7aca000 rw-p [heap]
ffc43000 ffc64000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14799)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7259228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf71f0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6ef73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6ef5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f01e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f07be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f07dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f3c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f371f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6ef5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f01e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f07be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f07dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f39e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f3a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f41f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48d91fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf48cc171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf699f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e4cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e4e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6fdeca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6fd9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6fda5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6fda879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7212183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72127fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72595c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf70a685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7258f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
17:02:22.181+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:175,0.770000,-0.980000,0.420000
06-07 17:02:22.181+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:184,2.318645,-0.141177,9.619147
06-07 17:02:22.181+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.181+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:188,1.050000,-0.490000,0.420000
06-07 17:02:22.181+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.191+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:192,0.840000,-0.420000,0.140000
06-07 17:02:22.191+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.191+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.191+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.201+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:202,0.138522,-0.022263,0.106311
06-07 17:02:22.201+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:203,2.206108,-0.147150,9.554152
06-07 17:02:22.201+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.201+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:202,0.700000,-0.840000,-0.140000
06-07 17:02:22.201+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:208,2.347359,-0.169890,9.659825
06-07 17:02:22.211+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.211+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.211+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.211+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:218,0.105359,-0.010776,0.067389
06-07 17:02:22.211+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:218,2.204842,-0.146705,9.554451
06-07 17:02:22.211+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.211+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:217,0.420000,-0.210000,-0.140000
06-07 17:02:22.221+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:223,2.311467,-0.157926,9.621540
06-07 17:02:22.231+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.231+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.231+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.241+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:241,0.140000,0.560000,0.210000
06-07 17:02:22.241+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:242,2.207525,-0.151026,9.553764
06-07 17:02:22.241+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:245,0.077911,-0.094970,-0.088445
06-07 17:02:22.241+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.251+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:251,2.282753,-0.241675,9.466006
06-07 17:02:22.251+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.251+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.251+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.251+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:258,0.070000,0.770000,0.140000
06-07 17:02:22.251+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.261+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:261,0.048907,-0.052364,-0.030331
06-07 17:02:22.261+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:265,2.207856,-0.153379,9.553650
06-07 17:02:22.261+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:264,2.256432,-0.203390,9.523434
06-07 17:02:22.271+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.271+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.271+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:278,0.350000,0.770000,0.140000
06-07 17:02:22.271+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.271+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.281+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:02:22.281+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:02:22:286,81
06-07 17:02:22.281+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:285,2.333002,-0.184247,9.664611
06-07 17:02:22.281+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:279,2.205702,-0.153986,9.554138
06-07 17:02:22.291+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:284,0.125146,-0.030869,0.110961
06-07 17:02:22.291+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.291+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.301+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:02:22.301+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.301+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:304,2.268396,-0.145962,9.635897
06-07 17:02:22.311+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:303,0.770000,-0.280000,0.140000
06-07 17:02:22.311+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.311+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:02:22:306,737.000000
06-07 17:02:22.311+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.311+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.321+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:311,2.196699,-0.151997,9.556244
06-07 17:02:22.321+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.321+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:322,0.062693,0.008023,0.081758
06-07 17:02:22.331+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:323,2.263610,-0.095713,9.595219
06-07 17:02:22.331+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:319,0.770000,-0.560000,-0.070000
06-07 17:02:22.331+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.331+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.341+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:334,2.188302,-0.147705,9.558237
06-07 17:02:22.341+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:02:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:02:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:02:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:02:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:02:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:02:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:02:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:02:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:02:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:02:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:02:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:02:22.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390942352,000000, pattern:[H:mm][0;m
06-07 17:02:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:02:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:02:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:02:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:02:22.341+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:340,0.560000,-0.770000,-0.070000
06-07 17:02:22.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:02:22.351+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:02][0;m
06-07 17:02:22.351+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.351+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.361+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:350,2.316252,-0.117248,9.585647
06-07 17:02:22.361+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.361+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:365,0.420000,-0.420000,0.070000
06-07 17:02:22.361+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:341,0.066912,0.056284,0.038975
06-07 17:02:22.371+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:360,2.186219,-0.145105,9.558754
06-07 17:02:22.371+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.371+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.371+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:378,0.420000,-0.140000,0.210000
06-07 17:02:22.381+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:379,0.127951,0.030456,0.027410
06-07 17:02:22.381+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.381+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.381+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:386,2.185603,-0.144983,9.558897
06-07 17:02:22.381+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.381+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:389,0.108498,-0.015214,0.010143
06-07 17:02:22.391+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.391+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:371,2.294717,-0.160319,9.568897
06-07 17:02:22.391+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.391+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.391+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:397,0.159364,-0.003372,0.026750
06-07 17:02:22.391+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.401+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:399,2.344966,-0.148355,9.585647
06-07 17:02:22.401+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.401+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:405,0.145043,-0.054303,0.062625
06-07 17:02:22.401+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:409,2.330609,-0.198604,9.621540
06-07 17:02:22.401+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:393,2.185567,-0.144301,9.558915
06-07 17:02:22.411+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.411+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:402,0.210000,-0.350000,0.210000
06-07 17:02:22.411+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.411+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.411+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:419,1.120000,-0.140000,0.210000
06-07 17:02:22.411+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.421+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:419,0.088324,-0.044985,0.065983
06-07 17:02:22.421+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:424,2.277967,-0.191426,9.623933
06-07 17:02:22.421+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:417,2.189644,-0.146441,9.557950
06-07 17:02:22.421+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.431+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:433,2.177355,-0.146256,9.560760
06-07 17:02:22.431+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.431+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.441+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:441,0.110184,0.009865,0.041637
06-07 17:02:22.441+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:441,1.750000,-0.490000,0.070000
06-07 17:02:22.441+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.441+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.441+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:447,2.156660,-0.142161,9.565511
06-07 17:02:22.441+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:448,2.287539,-0.136391,9.602397
06-07 17:02:22.451+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.451+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.451+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:458,1.890000,-0.210000,0.070000
06-07 17:02:22.451+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:458,0.173950,0.015341,0.000995
06-07 17:02:22.451+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.451+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.461+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:463,2.135592,-0.137519,9.570304
06-07 17:02:22.461+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:463,2.330609,-0.126820,9.566505
06-07 17:02:22.471+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.471+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.471+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:480,2.030000,-0.070000,-0.210000
06-07 17:02:22.471+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:481,0.130411,-0.029978,0.039271
06-07 17:02:22.481+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:02:22.481+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.481+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:02:22:486,81
06-07 17:02:22.481+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:486,2.112451,-0.134620,9.575480
06-07 17:02:22.481+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.491+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:492,2.266003,-0.167498,9.609575
06-07 17:02:22.501+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:02:22.521+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.521+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:02:22:508,738.000000
06-07 17:02:22.531+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:526,1.960000,-0.350000,-0.420000
06-07 17:02:22.531+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.551+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:551,1.890000,-0.420000,-0.210000
06-07 17:02:22.551+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.561+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:559,1.260000,-0.280000,0.140000
06-07 17:02:22.561+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.571+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.571+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.581+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:577,2.091093,-0.129590,9.580236
06-07 17:02:22.581+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:577,0.182266,0.017371,0.012561
06-07 17:02:22.581+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:570,0.840000,-0.280000,0.210000
06-07 17:02:22.581+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.591+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.591+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.591+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.591+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:595,0.280000,-0.420000,0.210000
06-07 17:02:22.591+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.601+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:603,0.770000,-0.140000,0.140000
06-07 17:02:22.601+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:598,0.208410,0.007556,0.024553
06-07 17:02:22.601+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.611+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:613,0.228425,0.027112,0.044078
06-07 17:02:22.611+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.611+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.621+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:621,0.840000,-0.140000,-0.070000
06-07 17:02:22.621+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:618,0.282108,0.051910,-0.035344
06-07 17:02:22.621+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.631+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:633,0.293356,-0.028800,0.001505
06-07 17:02:22.631+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.631+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.641+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:642,1.330000,0.490000,-0.630000
06-07 17:02:22.651+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:600,2.071078,-0.125218,9.584641
06-07 17:02:22.651+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.651+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.651+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:599,2.294717,-0.117248,9.588040
06-07 17:02:22.651+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.661+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:660,2.058073,-0.121302,9.587492
06-07 17:02:22.661+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.661+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:667,2.051610,-0.117162,9.588928
06-07 17:02:22.671+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.671+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:641,0.251053,-0.015998,0.041688
06-07 17:02:22.671+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:658,2.170000,0.910000,-0.280000
06-07 17:02:22.671+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.671+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:679,2.060413,-0.118000,9.587030
06-07 17:02:22.681+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:02:22.681+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.681+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:02:22:685,81
06-07 17:02:22.681+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:686,2.057926,-0.117144,9.587575
06-07 17:02:22.681+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.691+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.691+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:692,2.052415,-0.114090,9.588794
06-07 17:02:22.691+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.691+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:699,2.037137,-0.109746,9.592101
06-07 17:02:22.691+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:02:22.691+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.701+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:02:22:704,738.000000
06-07 17:02:22.701+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:705,2.002716,-0.102448,9.599428
06-07 17:02:22.701+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:663,2.299503,-0.122034,9.604790
06-07 17:02:22.701+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.701+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.701+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:710,2.299503,-0.098106,9.628718
06-07 17:02:22.701+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:711,1.990834,-0.096625,9.601959
06-07 17:02:22.711+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.711+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:683,0.700000,-0.070000,-0.070000
06-07 17:02:22.711+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.711+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:716,2.006247,-0.096719,9.598750
06-07 17:02:22.711+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.721+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:723,2.005924,-0.094342,9.598842
06-07 17:02:22.721+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:696,0.279862,0.026217,0.053107
06-07 17:02:22.721+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:721,-0.280000,-0.420000,0.070000
06-07 17:02:22.721+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.721+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.721+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:731,0.420000,-0.490000,0.140000
06-07 17:02:22.731+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.731+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.731+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:739,1.999360,-0.092541,9.600228
06-07 17:02:22.731+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:739,0.910000,-0.490000,0.140000
06-07 17:02:22.731+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.741+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:730,0.237516,0.027948,0.011210
06-07 17:02:22.741+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.741+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:745,2.340181,-0.069392,9.552148
06-07 17:02:22.741+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.741+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:746,0.236044,0.054711,-0.056703
06-07 17:02:22.751+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:751,2.344966,-0.145962,9.590433
06-07 17:02:22.751+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.751+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.751+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:758,2.311467,-0.133998,9.628718
06-07 17:02:22.751+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:758,1.983849,-0.090330,9.603466
06-07 17:02:22.751+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.751+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.761+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:764,2.337788,-0.090927,9.640682
06-07 17:02:22.761+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:764,1.610000,-0.280000,-0.140000
06-07 17:02:22.761+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.761+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:770,2.289931,-0.086142,9.600004
06-07 17:02:22.761+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.771+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.771+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.771+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:776,2.273181,-0.055035,9.535398
06-07 17:02:22.771+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.771+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:779,1.971730,-0.087987,9.605984
06-07 17:02:22.771+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.781+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:783,2.280360,-0.011964,9.602397
06-07 17:02:22.781+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:774,0.277644,0.090484,0.002969
06-07 17:02:22.781+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.781+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.781+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:790,2.316252,-0.086142,9.645468
06-07 17:02:22.781+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:785,1.330000,-0.630000,-0.210000
06-07 17:02:22.791+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.791+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:796,2.316252,-0.064606,9.645468
06-07 17:02:22.791+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.791+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:788,0.325418,0.010483,0.043509
06-07 17:02:22.801+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.801+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:803,1.977859,-0.086567,9.604736
06-07 17:02:22.801+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.801+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.801+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:809,0.350000,-0.560000,-0.280000
06-07 17:02:22.801+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:807,2.294717,-0.095713,9.592826
06-07 17:02:22.811+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:809,0.310005,0.032113,0.046718
06-07 17:02:22.811+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.811+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.811+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.811+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:818,1.965834,-0.083830,9.607229
06-07 17:02:22.821+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.821+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:821,2.316252,-0.117248,9.530612
06-07 17:02:22.821+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:820,0.288793,-0.001371,-0.006016
06-07 17:02:22.821+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.821+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.831+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:826,1.260000,-0.350000,-0.280000
06-07 17:02:22.831+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:832,0.316892,-0.024707,-0.069616
06-07 17:02:22.831+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.831+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.831+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:833,2.292324,-0.100499,9.576077
06-07 17:02:22.841+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.841+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:841,1.951373,-0.081860,9.610194
06-07 17:02:22.841+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.841+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:843,0.308475,-0.010169,-0.027390
06-07 17:02:22.841+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:848,1.470000,-0.140000,-0.070000
06-07 17:02:22.851+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.851+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.851+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:847,2.340181,-0.074178,9.544970
06-07 17:02:22.861+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.861+0200 W/LOCATION(14799): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:02:22.861+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:867,1.190000,-0.070000,-0.210000
06-07 17:02:22.861+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:860,1.932792,-0.077541,9.613984
06-07 17:02:22.871+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.871+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.871+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.881+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:02:22.881+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:882,2.330609,-0.086142,9.590433
06-07 17:02:22.881+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.881+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:02:22:886,81
06-07 17:02:22.881+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:879,1.260000,-0.280000,-0.210000
06-07 17:02:22.891+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:864,0.368450,0.013810,-0.061014
06-07 17:02:22.891+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.891+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:883,1.913121,-0.073179,9.617951
06-07 17:02:22.891+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:892,2.311467,-0.107677,9.561719
06-07 17:02:22.891+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:02:22.891+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.901+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:02:22:904,740.000000
06-07 17:02:22.901+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.901+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:905,2.289931,-0.045464,9.609575
06-07 17:02:22.901+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:910,1.400000,-0.420000,-0.210000
06-07 17:02:22.911+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.911+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.911+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:898,0.352750,0.000425,-0.014303
06-07 17:02:22.911+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.911+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.921+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:918,2.313859,-0.043071,9.631111
06-07 17:02:22.921+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:915,1.891758,-0.068766,9.622209
06-07 17:02:22.921+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.921+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:925,1.260000,-0.280000,-0.210000
06-07 17:02:22.931+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.931+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:933,2.337788,-0.043071,9.552148
06-07 17:02:22.931+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:923,0.345633,-0.023847,-0.045510
06-07 17:02:22.931+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.931+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.931+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.941+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:940,1.260000,0.140000,-0.140000
06-07 17:02:22.941+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:943,0.338558,0.036396,-0.000619
06-07 17:02:22.941+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.941+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:938,1.870364,-0.064286,9.626422
06-07 17:02:22.951+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.951+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:951,0.381068,0.034470,0.017127
06-07 17:02:22.951+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.951+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:947,2.321038,-0.031107,9.499505
06-07 17:02:22.951+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:956,1.853174,-0.061030,9.629766
06-07 17:02:22.951+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:959,0.980000,-0.070000,-0.070000
06-07 17:02:22.951+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.951+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.961+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:965,0.424667,0.030108,-0.065804
06-07 17:02:22.961+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.961+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.961+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:970,0.429280,0.037660,-0.122704
06-07 17:02:22.971+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.971+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:968,2.383251,-0.052642,9.602397
06-07 17:02:22.971+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.971+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:973,1.837532,-0.057845,9.632783
06-07 17:02:22.971+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:22:978,0.700000,-0.210000,-0.210000
06-07 17:02:22.971+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.981+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:22.981+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:975,0.512888,0.011644,-0.024025
06-07 17:02:22.981+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.981+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:989,0.465471,0.022745,-0.020191
06-07 17:02:22.981+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:22:984,2.318645,-0.038285,9.609575
06-07 17:02:22.981+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:22.991+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:22:994,0.505042,-0.030690,-0.037564
06-07 17:02:22.991+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:22:991,1.842311,-0.057774,9.631871
06-07 17:02:22.991+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:22.991+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:22.991+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:23.001+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:23:3,1.400000,-0.350000,-0.140000
06-07 17:02:23.001+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:23.001+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:23:4,1.823007,-0.055092,9.635559
06-07 17:02:23.001+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:23:8,0.493084,-0.006832,0.006418
06-07 17:02:23.001+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:23:0,2.342573,-0.088534,9.595219
06-07 17:02:23.011+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:23.011+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:23.011+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:23.011+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:23:19,1.120000,0.140000,0.140000
06-07 17:02:23.011+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:23:19,1.798523,-0.051040,9.640182
06-07 17:02:23.011+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:23.021+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:23:24,0.531530,0.035949,-0.030769
06-07 17:02:23.021+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:23:15,2.335395,-0.064606,9.638289
06-07 17:02:23.021+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:23.031+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:23:33,2.354537,-0.019143,9.604790
06-07 17:02:23.031+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:23.031+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:23.031+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:23:41,0.280000,-0.210000,0.140000
06-07 17:02:23.031+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:23:41,1.789523,-0.047928,9.641872
06-07 17:02:23.031+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:23.041+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:23:45,0.512943,0.053432,-0.013856
06-07 17:02:23.041+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:23.051+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:23:50,2.311467,0.002393,9.626326
06-07 17:02:23.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:02:23.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:02:23.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:02:23.061+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:23.061+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:23.061+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:23.071+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:23:72,1.797102,-0.048017,9.640462
06-07 17:02:23.071+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:23.071+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:23:80,1.780370,-0.044383,9.643583
06-07 17:02:23.071+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:23:72,0.350000,-0.280000,0.140000
06-07 17:02:23.081+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:02:23.081+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:02:23:86,81
06-07 17:02:23.081+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:23:74,0.493230,-0.016678,-0.034689
06-07 17:02:23.081+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:23.091+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:23.091+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:02:23.101+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:23.101+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:02:23:104,741.000000
06-07 17:02:23.101+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:23.101+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:23:106,1.787055,-0.043180,9.642352
06-07 17:02:23.101+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:23:95,0.490000,-0.070000,0.140000
06-07 17:02:23.101+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:23.111+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:23:95,0.521543,0.055196,-0.085921
06-07 17:02:23.111+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:23.111+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:23.111+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:23:118,1.805238,-0.043560,9.638963
06-07 17:02:23.121+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:23:109,2.282753,-0.064606,9.607183
06-07 17:02:23.121+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:23.121+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:23:114,-0.070000,-0.210000,0.280000
06-07 17:02:23.121+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:23.131+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:23:121,0.550240,0.030026,-0.041186
06-07 17:02:23.131+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:23.131+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:23.141+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:23:145,1.777183,-0.041014,9.644186
06-07 17:02:23.141+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:23:127,2.318645,0.007178,9.554541
06-07 17:02:23.141+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:23.151+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:23.151+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:23:159,1.723267,-0.035244,9.653989
06-07 17:02:23.161+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:23:133,-0.350000,1.050000,0.140000
06-07 17:02:23.161+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:23.161+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:23:168,1.400000,0.210000,-0.420000
06-07 17:02:23.161+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:23.171+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:23:136,0.481341,0.007288,-0.042348
06-07 17:02:23.171+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:23.171+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11147996c6f63152838374
