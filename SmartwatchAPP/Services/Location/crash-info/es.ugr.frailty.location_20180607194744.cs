S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 31005
Date: 2018-06-07 19:47:44+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf72b652d, r5   = 0xf767b150
r6   = 0xff8e7fa0, r7   = 0xff8e7e50
r8   = 0xf768dc18, r9   = 0x00000000
r10  = 0xff8e7f2c, fp   = 0xff8e7fa0
ip   = 0x00000001, sp   = 0xff8e7e28
lr   = 0xf72b6539, pc   = 0xf731f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    236196 KB
Buffers:     18264 KB
Cached:     114252 KB
VmPeak:      53444 KB
VmSize:      53436 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11676 KB
VmRSS:       11672 KB
VmData:      11164 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 31005 TID = 31005
31005 31077 

Maps Information
f4181000 f4980000 rw-p [stack:31077]
f4987000 f4989000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4991000 f4995000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f499e000 f49a0000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f49a8000 f49ab000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f49ba000 f49bf000 r-xp /usr/lib/libsystem.so.0.0.0
f49ca000 f49cd000 r-xp /lib/libattr.so.1.1.0
f49d5000 f49e5000 r-xp /usr/lib/libmdm-common.so.1.1.24
f49ed000 f49f6000 r-xp /usr/lib/libedbus.so.1.7.99
f49fe000 f49ff000 r-xp /usr/lib/libresponse.so.0.2.96
f4a08000 f4a0d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f62af000 f63b5000 r-xp /usr/lib/libicuuc.so.57.1
f63cb000 f6553000 r-xp /usr/lib/libicui18n.so.57.1
f6563000 f6570000 r-xp /usr/lib/libail.so.0.1.0
f6579000 f6580000 r-xp /usr/lib/libminizip.so.1.0.0
f6589000 f6732000 r-xp /usr/lib/libcrypto.so.1.0.0
f6752000 f6799000 r-xp /usr/lib/libssl.so.1.0.0
f67a5000 f67a7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f67af000 f67b6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f67bf000 f67c6000 r-xp /lib/libcrypt-2.13.so
f67f7000 f67fa000 r-xp /lib/libcap.so.2.21
f6802000 f6804000 r-xp /usr/lib/libiri.so
f680c000 f6855000 r-xp /usr/lib/libmdm.so.1.2.69
f685d000 f6863000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f686b000 f688e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6898000 f689a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f68a2000 f68bf000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f68c8000 f68cc000 r-xp /usr/lib/libsmack.so.1.0.0
f68d5000 f68ee000 r-xp /usr/lib/libnetwork.so.0.0.0
f68f7000 f68ff000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6907000 f690d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6916000 f6918000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6921000 f6931000 r-xp /lib/libresolv-2.13.so
f6935000 f694d000 r-xp /usr/lib/liblzma.so.5.0.3
f6956000 f6958000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6960000 f697a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6982000 f69b1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f69ba000 f69c9000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f69d3000 f69dd000 r-xp /usr/lib/libsensord-shared.so
f69e6000 f6ab9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ac4000 f6ada000 r-xp /lib/libz.so.1.2.5
f6ae2000 f6ae7000 r-xp /usr/lib/libffi.so.5.0.10
f6aef000 f6af0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6af8000 f6b08000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b10000 f6b29000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b31000 f6b33000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b3b000 f6bb0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6bba000 f6bc0000 r-xp /lib/librt-2.13.so
f6bc9000 f6be7000 r-xp /usr/lib/libsystemd.so.0.4.0
f6bf1000 f6bf2000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6bfa000 f6c1d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c25000 f6c2a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c32000 f6c5c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c65000 f6c7c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c84000 f6ced000 r-xp /lib/libm-2.13.so
f6cf6000 f6d8a000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d9d000 f6da2000 r-xp /usr/lib/libctx-client.so.0.8.3
f6daa000 f6db1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6db9000 f6de3000 r-xp /usr/lib/libsensor.so.1.9.6
f6dec000 f6eb8000 r-xp /usr/lib/libxml2.so.2.7.8
f6ec5000 f6ec7000 r-xp /usr/lib/libiniparser.so.0
f6ed0000 f6ed6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6edf000 f6faf000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6fb0000 f6fe4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6fed000 f7029000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7031000 f7034000 r-xp /usr/lib/libbundle.so.0.1.22
f703c000 f7042000 r-xp /usr/lib/libappsvc.so.0.1.0
f704a000 f708b000 r-xp /usr/lib/libeina.so.1.7.99
f7094000 f70ab000 r-xp /usr/lib/libecore.so.1.7.99
f70c2000 f70cb000 r-xp /usr/lib/libvconf.so.0.2.45
f70d3000 f70e7000 r-xp /lib/libpthread-2.13.so
f70f2000 f70ff000 r-xp /usr/lib/libaul.so.0.1.0
f7109000 f710b000 r-xp /lib/libdl-2.13.so
f7114000 f711f000 r-xp /lib/libunwind.so.8.0.1
f714c000 f7154000 r-xp /lib/libgcc_s-4.6.so.1
f7155000 f7279000 r-xp /lib/libc-2.13.so
f7287000 f7289000 r-xp /usr/lib/libdlog.so.0.0.0
f7291000 f729d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f72a6000 f72ab000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f72b3000 f72c2000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f72ca000 f72ce000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f72d7000 f72da000 r-xp /usr/lib/libappcore-agent.so.1.1
f72e2000 f72e4000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f72ec000 f72f0000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f72f8000 f7315000 r-xp /lib/ld-2.13.so
f731e000 f7321000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7321000 f7325000 r-xp /usr/lib/libsys-assert.so
f765d000 f76cb000 rw-p [heap]
ff8c9000 ff8ea000 rw-p [stack]
End of Maps Information

Callstack Information (PID:31005)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf731f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf72b6539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6fbd3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6fbbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6fc7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6fcdbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6fcddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf700275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6ffd1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6fbbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6fc7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6fcdbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6fcddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6fffe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7000017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7007f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf499f1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4992171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a65663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f12fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f147a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf70a4ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf709fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70a05a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf70a0879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf72d8183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72d87fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf731f5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf716c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf731ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
apturing data
06-07 19:47:44.231+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.231+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:234,8.985049,-0.423530,1.074377
06-07 19:47:44.231+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.231+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:236,-0.111786,-1.036892,-0.522730
06-07 19:47:44.231+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.231+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:240,9.016156,-1.323231,2.292324
06-07 19:47:44.231+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.241+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:232,-36.189999,-42.910000,-3.920000
06-07 19:47:44.241+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:241,9.452314,-1.172439,2.334420
06-07 19:47:44.241+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:245,9.054441,-2.749353,2.833102
06-07 19:47:44.241+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.241+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.241+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.251+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:253,0.386971,-0.844710,-0.747979
06-07 19:47:44.251+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.251+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:250,9.336794,-2.182254,1.840081
06-07 19:47:44.251+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.251+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:250,28.980000,-45.360001,-33.599998
06-07 19:47:44.251+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:260,9.839286,-2.017149,1.586441
06-07 19:47:44.261+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:258,9.455997,-1.119829,2.345310
06-07 19:47:44.261+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.261+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:267,17.360001,-23.379999,-12.110000
06-07 19:47:44.261+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.261+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.271+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.271+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:271,107.379997,11.830000,-34.720001
06-07 19:47:44.271+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.271+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:276,-0.315414,3.594008,-2.900445
06-07 19:47:44.271+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:277,79.870003,4.830000,-35.070000
06-07 19:47:44.271+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.271+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:274,9.140583,2.474179,-0.555135
06-07 19:47:44.281+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:282,9.475469,-1.065345,2.291487
06-07 19:47:44.281+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.281+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.291+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:293,0.851954,-0.047318,-2.092882
06-07 19:47:44.291+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:293,-4.060000,-7.700000,0.490000
06-07 19:47:44.291+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.291+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.291+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:299,10.327423,-1.112662,0.198604
06-07 19:47:44.291+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:299,9.520932,-0.905471,2.168490
06-07 19:47:44.301+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.301+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.311+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:314,-0.196102,0.601583,-1.235289
06-07 19:47:44.311+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:314,13.650000,-0.630000,-6.020000
06-07 19:47:44.311+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.311+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.311+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:319,9.324830,-0.303888,0.933201
06-07 19:47:44.311+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:319,9.555632,-0.911795,2.007215
06-07 19:47:44.331+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.331+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.331+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:337,-13.370000,-3.080000,-1.750000
06-07 19:47:44.331+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.331+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.341+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:338,0.312368,-0.133869,-1.444902
06-07 19:47:44.341+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:343,9.571651,-0.881411,1.943452
06-07 19:47:44.341+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:343,9.868000,-1.045663,0.562313
06-07 19:47:44.341+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.341+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.351+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:354,-16.520000,-1.190000,-0.490000
06-07 19:47:44.351+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.351+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.351+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:359,9.841680,-1.351945,1.914258
06-07 19:47:44.351+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:359,9.591920,-0.899329,1.832118
06-07 19:47:44.351+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:354,0.270029,-0.470534,-0.029194
06-07 19:47:44.371+0200 I/light   (31046): es.ugr.frailty.light - capturing data
06-07 19:47:44.371+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.371+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.381+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:380,16.379999,3.920000,-11.060000
06-07 19:47:44.381+0200 I/light   (31046): es.ugr.frailty.light: SM-R760,07/06/2018,19:47:44:375,977.000000
06-07 19:47:44.401+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.401+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.411+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 19:47:44.411+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 19:47:44.411+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 19:47:44.411+0200 I/heartrate(30989): es.ugr.frailty.heartrate - capturing data
06-07 19:47:44.411+0200 I/heartrate(30989): es.ugr.frailty.heartrate: waiting for rigth values
06-07 19:47:44.421+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:377,0.529719,-0.644041,0.785630
06-07 19:47:44.421+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.421+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.431+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:428,-1.046468,3.400183,-2.774052
06-07 19:47:44.431+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.431+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:415,10.121639,-1.543371,2.617748
06-07 19:47:44.441+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:415,9.593630,-0.892505,1.826494
06-07 19:47:44.441+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:442,0.493648,-0.159890,-1.086278
06-07 19:47:44.441+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.451+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:435,-49.070000,9.030000,-16.309999
06-07 19:47:44.451+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.451+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:454,-0.379869,0.118000,2.338639
06-07 19:47:44.451+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.451+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.461+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:460,0.105874,-1.030555,1.757184
06-07 19:47:44.461+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.461+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:458,8.547162,2.507678,-0.947558
06-07 19:47:44.461+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.471+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:461,9.595336,-0.899202,1.814208
06-07 19:47:44.471+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.471+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.471+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:474,0.531592,1.302396,-0.252216
06-07 19:47:44.471+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:468,-90.370003,-1.890000,1.260000
06-07 19:47:44.471+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.481+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:483,-11.620000,5.390000,11.410000
06-07 19:47:44.481+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.481+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:479,10.135997,-0.926022,0.528814
06-07 19:47:44.481+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:480,9.642349,-0.766133,1.615092
06-07 19:47:44.481+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.481+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.481+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.491+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:493,-0.041438,1.632540,-1.240327
06-07 19:47:44.491+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:490,65.940002,-0.980000,-3.850000
06-07 19:47:44.491+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.491+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:495,9.644878,-0.809526,1.578411
06-07 19:47:44.491+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:495,9.265009,-0.691526,3.917051
06-07 19:47:44.501+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.501+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:502,65.660004,6.510000,-3.640000
06-07 19:47:44.501+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.501+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.501+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:508,35.279999,12.460000,-4.900000
06-07 19:47:44.501+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.511+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:508,9.750752,-1.840081,3.335595
06-07 19:47:44.511+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:514,-0.207273,1.039484,-0.495696
06-07 19:47:44.511+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:508,9.628333,-0.790331,1.685516
06-07 19:47:44.511+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.511+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.511+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.511+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:520,-3.500000,16.379999,-3.150000
06-07 19:47:44.521+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:522,9.605550,-0.814194,1.800247
06-07 19:47:44.521+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.521+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:525,10.159925,0.512064,1.433301
06-07 19:47:44.521+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.521+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:528,9.606281,-0.733202,1.830891
06-07 19:47:44.521+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.531+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.531+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:531,9.564112,0.818345,0.559920
06-07 19:47:44.531+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.531+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:536,-0.015055,-0.243472,0.183368
06-07 19:47:44.531+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.531+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:538,9.399008,0.306281,1.335195
06-07 19:47:44.531+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.531+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:541,-28.910000,14.770000,6.160000
06-07 19:47:44.541+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:544,9.595219,-0.887737,2.026721
06-07 19:47:44.541+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:533,9.610273,-0.644265,1.843353
06-07 19:47:44.541+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.541+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.541+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.551+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:553,-0.224825,-1.474759,1.333110
06-07 19:47:44.551+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:554,0.840000,23.309999,6.160000
06-07 19:47:44.551+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.551+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:550,9.607082,-0.618961,1.868487
06-07 19:47:44.551+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.551+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:560,9.382257,-2.093720,3.201597
06-07 19:47:44.561+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:561,9.589608,-0.651610,1.945560
06-07 19:47:44.571+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.571+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.571+0200 I/light   (31046): es.ugr.frailty.light - capturing data
06-07 19:47:44.571+0200 I/light   (31046): es.ugr.frailty.light: SM-R760,07/06/2018,19:47:44:576,977.000000
06-07 19:47:44.571+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:576,0.027145,-0.626158,0.487941
06-07 19:47:44.571+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.571+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:580,25.270000,30.450001,-12.110000
06-07 19:47:44.581+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:582,9.560751,-0.690561,2.070158
06-07 19:47:44.581+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.581+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:587,9.616754,-1.277767,2.433501
06-07 19:47:44.581+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.581+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.581+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.591+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:594,3.150000,32.340000,-18.340000
06-07 19:47:44.591+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:594,10.341780,0.361316,1.797010
06-07 19:47:44.591+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.591+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:594,0.781029,1.051877,-0.273148
06-07 19:47:44.601+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:600,9.553153,-0.688374,2.105658
06-07 19:47:44.611+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.611+0200 I/heartrate(30989): es.ugr.frailty.heartrate - capturing data
06-07 19:47:44.611+0200 I/heartrate(30989): es.ugr.frailty.heartrate: waiting for rigth values
06-07 19:47:44.651+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.651+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:657,-31.850000,44.380001,-20.440001
06-07 19:47:44.651+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.651+0200 I/APP_CORE( 2762): appcore-efl.c: __do_app(453) > [APP 2762] Event: MEM_FLUSH State: PAUSED
06-07 19:47:44.661+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:665,0.537379,0.702731,-0.643643
06-07 19:47:44.661+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.661+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.671+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.681+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:678,10.090532,0.014357,1.462015
06-07 19:47:44.681+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.691+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:671,-28.210001,49.910000,-7.910000
06-07 19:47:44.691+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:673,-0.310697,-0.496826,-0.579947
06-07 19:47:44.691+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.691+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.701+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:616,9.558956,-0.615836,2.101782
06-07 19:47:44.701+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.701+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:703,-18.480000,46.689999,-10.290000
06-07 19:47:44.701+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.711+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:690,9.248260,-1.112662,1.521835
06-07 19:47:44.711+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.711+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:705,-0.629869,-0.081385,-0.453148
06-07 19:47:44.711+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.721+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:710,9.552706,-0.588605,2.137695
06-07 19:47:44.721+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.731+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:723,0.560000,48.090000,-7.630000
06-07 19:47:44.731+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:725,-0.426097,0.274162,0.193150
06-07 19:47:44.731+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.731+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.731+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:734,9.542751,-0.618729,2.173351
06-07 19:47:44.731+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:718,8.922836,-0.669990,1.684547
06-07 19:47:44.741+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.741+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:739,21.000000,34.090000,-4.130000
06-07 19:47:44.741+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:740,-0.875349,-0.076200,0.233103
06-07 19:47:44.741+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.741+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.741+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.751+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:751,0.423260,7.460194,-2.260511
06-07 19:47:44.751+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:752,-221.619995,-39.759998,-12.390000
06-07 19:47:44.751+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.751+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.751+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:746,9.116654,-0.344566,2.366502
06-07 19:47:44.751+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.761+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:754,9.527796,-0.624897,2.236290
06-07 19:47:44.761+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:762,2.796835,-6.837903,0.407159
06-07 19:47:44.761+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:764,8.652447,-0.701097,2.469393
06-07 19:47:44.761+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.761+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:764,28.280001,-8.540000,32.759998
06-07 19:47:44.761+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.761+0200 I/light   (31046): es.ugr.frailty.light - capturing data
06-07 19:47:44.771+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.771+0200 I/light   (31046): es.ugr.frailty.light: SM-R760,07/06/2018,19:47:44:776,1007.000000
06-07 19:47:44.771+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.781+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:777,9.511740,-0.607149,2.308367
06-07 19:47:44.781+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.781+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:774,0.431216,2.177101,0.715460
06-07 19:47:44.781+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:783,57.540001,58.660000,-11.270000
06-07 19:47:44.781+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.781+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:771,9.934999,6.853044,0.047856
06-07 19:47:44.791+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.791+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:795,-2.036157,3.311301,1.492454
06-07 19:47:44.791+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.791+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:796,-23.030001,3.500000,2.310000
06-07 19:47:44.791+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.801+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.801+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:790,9.554914,-0.649239,2.110091
06-07 19:47:44.801+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.801+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:807,-7.280000,-14.420000,-5.180000
06-07 19:47:44.811+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:806,0.938258,-2.518111,0.790448
06-07 19:47:44.811+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:803,12.351749,-7.487142,2.517249
06-07 19:47:44.811+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.811+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.811+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.811+0200 I/heartrate(30989): es.ugr.frailty.heartrate - capturing data
06-07 19:47:44.811+0200 I/heartrate(30989): es.ugr.frailty.heartrate: waiting for rigth values
06-07 19:47:44.811+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:807,9.573175,-0.573909,2.048250
06-07 19:47:44.811+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.821+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:818,0.480002,-0.975222,1.109656
06-07 19:47:44.821+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:820,58.730000,-7.350000,-0.560000
06-07 19:47:44.821+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:817,10.004392,1.603191,2.763710
06-07 19:47:44.821+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.831+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.831+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.831+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:836,-0.111000,0.644093,1.018863
06-07 19:47:44.831+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:836,38.709999,-20.790001,-3.080000
06-07 19:47:44.841+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:834,7.489535,2.660819,3.730411
06-07 19:47:44.841+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.841+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:825,9.525692,-0.650483,2.237957
06-07 19:47:44.841+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.841+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.851+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:853,-0.043954,0.483381,0.558266
06-07 19:47:44.851+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.851+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:848,10.478169,-3.081956,2.991028
06-07 19:47:44.861+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:859,-20.650000,-13.370000,18.270000
06-07 19:47:44.861+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:850,9.539911,-0.563845,2.200581
06-07 19:47:44.861+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.861+0200 W/LOCATION(31005): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 19:47:44.861+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.871+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.871+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:875,-0.146762,0.614634,0.533611
06-07 19:47:44.871+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.881+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:879,-73.010002,-19.040001,23.730000
06-07 19:47:44.881+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:872,9.565067,-0.472436,2.111084
06-07 19:47:44.881+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.881+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:886,10.045070,-1.447658,3.220739
06-07 19:47:44.881+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.881+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.891+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.891+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:894,0.086625,-3.644241,2.670184
06-07 19:47:44.891+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:897,9.439686,0.141177,3.187240
06-07 19:47:44.891+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:897,-41.720001,-18.830000,-2.100000
06-07 19:47:44.901+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.901+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:890,9.550686,-0.502916,2.168377
06-07 19:47:44.901+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.901+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:907,9.545853,-0.516880,2.186302
06-07 19:47:44.901+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.901+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.911+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.911+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:907,9.501899,-0.033500,2.744568
06-07 19:47:44.911+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.911+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:914,35.279999,14.560000,-8.190000
06-07 19:47:44.911+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:916,-0.021221,-0.994529,1.370275
06-07 19:47:44.921+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:912,9.536198,-0.528492,2.225314
06-07 19:47:44.921+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.921+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:921,9.389436,0.086142,2.758924
06-07 19:47:44.921+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.921+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:930,9.532522,-0.571913,2.230317
06-07 19:47:44.921+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.931+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.931+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.931+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:932,9.619147,-4.216154,4.900501
06-07 19:47:44.931+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.941+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:938,-0.096486,-0.375870,-0.455172
06-07 19:47:44.941+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:937,20.650000,4.620000,-4.200000
06-07 19:47:44.941+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.941+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:944,9.528220,-1.538585,3.534199
06-07 19:47:44.941+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.951+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.951+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:954,-17.219999,-3.430000,0.910000
06-07 19:47:44.961+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:958,9.418150,-0.969093,1.844866
06-07 19:47:44.961+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:956,-0.083225,-0.324844,-0.454657
06-07 19:47:44.961+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:935,9.549441,-0.544056,2.163924
06-07 19:47:44.961+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.961+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.961+0200 I/light   (31046): es.ugr.frailty.light - capturing data
06-07 19:47:44.971+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.971+0200 I/light   (31046): es.ugr.frailty.light: SM-R760,07/06/2018,19:47:44:975,1013.000000
06-07 19:47:44.971+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.971+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:979,-0.131490,-0.830338,0.087704
06-07 19:47:44.971+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:975,2.940000,9.380000,-3.290000
06-07 19:47:44.981+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:971,9.410972,-0.945165,1.921437
06-07 19:47:44.981+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:971,9.514636,-0.593223,2.300038
06-07 19:47:44.981+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.981+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:44.981+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:44:987,9.494197,-0.620321,2.376093
06-07 19:47:44.981+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:44.981+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:44.991+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:44:987,9.370294,-1.476372,2.426322
06-07 19:47:44.991+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:44.991+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:44:994,9.170000,-0.770000,-7.280000
06-07 19:47:44.991+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:44:995,-0.486032,0.552258,1.231544
06-07 19:47:44.991+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:45.001+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:45:5,9.501783,-0.646033,2.338618
06-07 19:47:45.001+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:45:0,9.016156,-0.105284,3.565305
06-07 19:47:45.001+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:45.001+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:45.001+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:45.011+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:45.011+0200 I/heartrate(30989): es.ugr.frailty.heartrate - capturing data
06-07 19:47:45.011+0200 I/heartrate(30989): es.ugr.frailty.heartrate: waiting for rigth values
06-07 19:47:45.011+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:45:18,9.231510,-1.342373,3.579663
06-07 19:47:45.021+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:45:15,-0.269705,-0.664313,1.247812
06-07 19:47:45.021+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:45:14,31.920000,-7.560000,-18.200001
06-07 19:47:45.021+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:45:10,9.502189,-0.657542,2.333761
06-07 19:47:45.021+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:45.031+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:45.031+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:45.031+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:45.031+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:45:37,9.741181,-0.892523,2.112862
06-07 19:47:45.041+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:45:37,58.380001,-15.820000,-5.180000
06-07 19:47:45.041+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:45:38,0.245031,-0.288364,-0.259584
06-07 19:47:45.041+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:45:33,9.501215,-0.678060,2.331851
06-07 19:47:45.041+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:45.041+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:45.041+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:45.051+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:45:55,9.468399,1.969293,1.284946
06-07 19:47:45.051+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:45:55,-0.027751,2.573451,-1.087501
06-07 19:47:45.061+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:45.061+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:45:55,-43.610001,-51.310001,-6.790000
06-07 19:47:45.061+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:45:67,9.510433,-0.604338,2.314482
06-07 19:47:45.061+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:45.061+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:45.071+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:45.071+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:45:74,9.681360,-1.753939,2.201397
06-07 19:47:45.071+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:45:75,-43.959999,-21.770000,-1.330000
06-07 19:47:45.071+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:45:74,0.143267,-1.151934,0.003047
06-07 19:47:45.071+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:45.081+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:45:84,9.496150,-0.604158,2.372447
06-07 19:47:45.081+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:45.081+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:45.081+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:45.091+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:45.091+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:45:94,9.951750,-1.476372,2.383251
06-07 19:47:45.091+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:45:96,-6.440000,-9.870000,-0.910000
06-07 19:47:45.091+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:45:93,0.372843,-0.993730,0.338261
06-07 19:47:45.091+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:45:90,9.538094,-0.602005,2.198350
06-07 19:47:45.091+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:45.101+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:45:105,9.578907,-0.482641,2.044991
06-07 19:47:45.101+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:45.101+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:45.101+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:45.101+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:45.111+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:45:115,9.367901,-1.272982,3.113062
06-07 19:47:45.111+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:45:115,-0.207747,-0.737118,1.066060
06-07 19:47:45.121+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:45:116,15.120000,-19.320000,0.350000
06-07 19:47:45.121+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:45:110,9.575647,-0.535863,2.047002
06-07 19:47:45.121+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:45.121+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:45:130,9.575121,-0.566497,2.041207
06-07 19:47:45.131+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:45.131+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:45.131+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:45.131+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:45:136,9.781858,-2.184647,2.053042
06-07 19:47:45.131+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:45:137,0.206738,-1.618150,0.011835
06-07 19:47:45.141+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:45:138,116.760002,-8.610000,-9.940000
06-07 19:47:45.141+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:45.141+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:45.141+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:45.151+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:45.151+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:45:154,9.537791,1.751546,0.981057
06-07 19:47:45.161+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:45:155,-0.018468,2.294678,-1.152790
06-07 19:47:45.161+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:45:156,97.160004,-12.320000,-3.850000
06-07 19:47:45.171+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:45:149,9.556259,-0.543132,2.133847
06-07 19:47:45.171+0200 I/light   (31046): es.ugr.frailty.light - capturing data
06-07 19:47:45.171+0200 I/light   (31046): es.ugr.frailty.light: SM-R760,07/06/2018,19:47:45:178,980.000000
06-07 19:47:45.181+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:45.191+0200 I/gravity (31018): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:47:45:191,9.540231,-0.574121,2.196537
06-07 19:47:45.191+0200 I/gravity (31018): es.ugr.frailty.gravity - capturing data
06-07 19:47:45.201+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:45.211+0200 I/heartrate(30989): es.ugr.frailty.heartrate - capturing data
06-07 19:47:45.211+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:45.221+0200 I/heartrate(30989): es.ugr.frailty.heartrate: waiting for rigth values
06-07 19:47:45.231+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:45:226,-14.770000,-26.740000,-1.400000
06-07 19:47:45.231+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:45:206,9.750752,0.701097,0.119641
06-07 19:47:45.231+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:45.231+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:45.241+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:45.241+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:45:247,0.210522,1.275218,-2.076896
06-07 19:47:45.241+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:45:242,-32.900002,-20.650000,2.730000
06-07 19:47:45.251+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:45:242,9.808180,-0.552742,1.270589
06-07 19:47:45.251+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:45.251+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:45.251+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:45.251+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:45:260,9.482756,-0.478565,1.478764
06-07 19:47:45.261+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:45:259,-34.790001,-9.520000,-1.820000
06-07 19:47:45.261+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:45:269,0.236647,-0.096017,-0.814486
06-07 19:47:45.271+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:45.271+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:45.271+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration - capturing data
06-07 19:47:45.271+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:47:45:279,9.856036,-0.847059,1.091127
06-07 19:47:45.281+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:47:45:277,-32.270000,-9.590000,-0.770000
06-07 19:47:45.281+0200 I/gyroscope(30962): es.ugr.frailty.gyroscope - capturing data
06-07 19:47:45.291+0200 I/accelerometer(30959): es.ugr.frailty.accelerometer - capturing data
06-07 19:47:45.291+0200 I/linearacceleration(31012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:47:45:284,-0.097899,-0.088979,-0.577850
06-07 19:47:45.301+0200 W/CRASH_MANAGER(31088): worker.c: worker_job(1205) > 11310056c6f63152839366
