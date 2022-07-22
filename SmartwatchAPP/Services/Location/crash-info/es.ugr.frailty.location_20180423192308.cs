S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 13261
Date: 2018-04-23 19:23:08+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf75de52d, r5   = 0xf7c7df98
r6   = 0xff873000, r7   = 0xff872eb0
r8   = 0xf7c7ac18, r9   = 0x00000000
r10  = 0xff872f8c, fp   = 0xff873000
ip   = 0x00000001, sp   = 0xff872e88
lr   = 0xf75de539, pc   = 0xf7647228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     24272 KB
Buffers:     50420 KB
Cached:     234496 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11876 KB
VmRSS:       11872 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 13261 TID = 13261
13261 13303 

Maps Information
f44a9000 f4ca8000 rw-p [stack:13303]
f4caf000 f4cb1000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4cb9000 f4cbd000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4cc6000 f4cc8000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4cd0000 f4cd3000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4ce2000 f4ce7000 r-xp /usr/lib/libsystem.so.0.0.0
f4cf2000 f4cf5000 r-xp /lib/libattr.so.1.1.0
f4cfd000 f4d0d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d15000 f4d1e000 r-xp /usr/lib/libedbus.so.1.7.99
f4d26000 f4d27000 r-xp /usr/lib/libresponse.so.0.2.96
f4d30000 f4d35000 r-xp /usr/lib/libproc-stat.so.0.2.96
f65d7000 f66dd000 r-xp /usr/lib/libicuuc.so.57.1
f66f3000 f687b000 r-xp /usr/lib/libicui18n.so.57.1
f688b000 f6898000 r-xp /usr/lib/libail.so.0.1.0
f68a1000 f68a8000 r-xp /usr/lib/libminizip.so.1.0.0
f68b1000 f6a5a000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a7a000 f6ac1000 r-xp /usr/lib/libssl.so.1.0.0
f6acd000 f6acf000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6ad7000 f6ade000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6ae7000 f6aee000 r-xp /lib/libcrypt-2.13.so
f6b1f000 f6b22000 r-xp /lib/libcap.so.2.21
f6b2a000 f6b2c000 r-xp /usr/lib/libiri.so
f6b34000 f6b7d000 r-xp /usr/lib/libmdm.so.1.2.69
f6b85000 f6b8b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b93000 f6bb6000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6bc0000 f6bc2000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6bca000 f6be7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6bf0000 f6bf4000 r-xp /usr/lib/libsmack.so.1.0.0
f6bfd000 f6c16000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c1f000 f6c27000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c2f000 f6c35000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c3e000 f6c40000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c49000 f6c59000 r-xp /lib/libresolv-2.13.so
f6c5d000 f6c75000 r-xp /usr/lib/liblzma.so.5.0.3
f6c7e000 f6c80000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c88000 f6ca2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6caa000 f6cd9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ce2000 f6cf1000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6cfb000 f6d05000 r-xp /usr/lib/libsensord-shared.so
f6d0e000 f6de1000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6dec000 f6e02000 r-xp /lib/libz.so.1.2.5
f6e0a000 f6e0f000 r-xp /usr/lib/libffi.so.5.0.10
f6e17000 f6e18000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e20000 f6e30000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e38000 f6e51000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e59000 f6e5b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e63000 f6ed8000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ee2000 f6ee8000 r-xp /lib/librt-2.13.so
f6ef1000 f6f0f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f19000 f6f1a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f22000 f6f45000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f4d000 f6f52000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f5a000 f6f84000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f8d000 f6fa4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6fac000 f7015000 r-xp /lib/libm-2.13.so
f701e000 f70b2000 r-xp /usr/lib/libstdc++.so.6.0.16
f70c5000 f70ca000 r-xp /usr/lib/libctx-client.so.0.8.3
f70d2000 f70d9000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70e1000 f710b000 r-xp /usr/lib/libsensor.so.1.9.6
f7114000 f71e0000 r-xp /usr/lib/libxml2.so.2.7.8
f71ed000 f71ef000 r-xp /usr/lib/libiniparser.so.0
f71f8000 f71fe000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7207000 f72d7000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f72d8000 f730c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7315000 f7351000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7359000 f735c000 r-xp /usr/lib/libbundle.so.0.1.22
f7364000 f736a000 r-xp /usr/lib/libappsvc.so.0.1.0
f7372000 f73b3000 r-xp /usr/lib/libeina.so.1.7.99
f73bc000 f73d3000 r-xp /usr/lib/libecore.so.1.7.99
f73ea000 f73f3000 r-xp /usr/lib/libvconf.so.0.2.45
f73fb000 f740f000 r-xp /lib/libpthread-2.13.so
f741a000 f7427000 r-xp /usr/lib/libaul.so.0.1.0
f7431000 f7433000 r-xp /lib/libdl-2.13.so
f743c000 f7447000 r-xp /lib/libunwind.so.8.0.1
f7474000 f747c000 r-xp /lib/libgcc_s-4.6.so.1
f747d000 f75a1000 r-xp /lib/libc-2.13.so
f75af000 f75b1000 r-xp /usr/lib/libdlog.so.0.0.0
f75b9000 f75c5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75ce000 f75d3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75db000 f75ea000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f75f2000 f75f6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75ff000 f7602000 r-xp /usr/lib/libappcore-agent.so.1.1
f760a000 f760c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7614000 f7618000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7620000 f763d000 r-xp /lib/ld-2.13.so
f7646000 f7649000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7649000 f764d000 r-xp /usr/lib/libsys-assert.so
f7c4a000 f7cbb000 rw-p [heap]
ff854000 ff875000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13261)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7647228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf75de539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72e53f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf72e3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf72efe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf72f5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf72f5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf732a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73251f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf72e3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf72efe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf72f5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf72f5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7327e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7328017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf732ff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4cc71fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4cba171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d8d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf723afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf723c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf73ccca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf73c7b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73c85a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf73c8879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7600183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76007fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76474f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf749485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7646f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
3247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:307,0.560000,1.120000,0.210000
04-23 19:23:07.309+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.319+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:236,-0.086142,-7.929814,5.943772
04-23 19:23:07.319+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:234,0.090055,-0.052146,0.105820
04-23 19:23:07.319+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.329+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.329+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:337,-0.129212,-7.946564,5.934200
04-23 19:23:07.329+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.339+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:320,0.560000,0.210000,-0.140000
04-23 19:23:07.339+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.339+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:284,-0.171871,-7.889910,5.821526
04-23 19:23:07.339+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.349+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:345,0.350000,-0.350000,-0.210000
04-23 19:23:07.349+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:325,0.043172,-0.062722,0.104475
04-23 19:23:07.349+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.349+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:342,-0.148355,-7.965706,5.934200
04-23 19:23:07.349+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:351,-0.172285,-7.892388,5.818154
04-23 19:23:07.359+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:357,0.023516,-0.075796,0.112674
04-23 19:23:07.359+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.359+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:366,0.023930,-0.058961,0.051439
04-23 19:23:07.359+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.369+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.369+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.379+0200 I/heartrate(13102): capturing data from es.ugr.frailty.heartrate
04-23 19:23:07.399+0200 I/heartrate(13102): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:23:07:392,80
04-23 19:23:07.399+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:374,-0.172735,-7.897984,5.810543
04-23 19:23:07.409+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.419+0200 E/CAPI_TELEPHONY(13183): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 19:23:07.419+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:422,0.350000,-0.420000,-0.490000
04-23 19:23:07.419+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.429+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:427,0.350000,-0.210000,-0.420000
04-23 19:23:07.429+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.429+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:434,0.350000,0.420000,-0.420000
04-23 19:23:07.429+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.439+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.449+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:381,-0.148355,-7.951349,5.869594
04-23 19:23:07.449+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:440,0.700000,1.050000,0.420000
04-23 19:23:07.449+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.449+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.459+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:458,1.120000,1.120000,0.350000
04-23 19:23:07.459+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.459+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:465,1.050000,0.770000,0.210000
04-23 19:23:07.469+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.469+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:370,-0.052190,-0.043794,0.087766
04-23 19:23:07.469+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.479+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:477,0.630000,0.420000,0.070000
04-23 19:23:07.479+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:452,-0.176416,-7.903212,5.803318
04-23 19:23:07.479+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.479+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:471,-0.224925,-7.941778,5.898308
04-23 19:23:07.479+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.489+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:488,-0.229711,-7.948956,5.869594
04-23 19:23:07.489+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.489+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:496,-0.129212,-7.953743,5.905487
04-23 19:23:07.489+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.499+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:502,-0.150748,-7.972885,5.905487
04-23 19:23:07.499+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.499+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.499+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:507,-0.117248,-7.972885,5.986843
04-23 19:23:07.499+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.509+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:511,0.630000,1.120000,0.420000
04-23 19:23:07.509+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:481,-0.053295,-0.045744,0.066276
04-23 19:23:07.509+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.509+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:512,-0.105284,-7.972885,5.984450
04-23 19:23:07.509+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.509+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:487,-0.178861,-7.904930,5.800903
04-23 19:23:07.509+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.509+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:517,-0.162712,-7.968100,5.972485
04-23 19:23:07.509+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.509+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.519+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:521,-0.198604,-7.948956,5.927022
04-23 19:23:07.519+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.519+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:522,1.260000,0.980000,0.420000
04-23 19:23:07.519+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:520,-0.175825,-7.903351,5.803146
04-23 19:23:07.519+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.519+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:525,-0.217747,-7.936993,5.912664
04-23 19:23:07.519+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.519+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:528,-0.173470,-7.904988,5.800987
04-23 19:23:07.529+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:516,0.049648,-0.048812,0.104584
04-23 19:23:07.529+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.529+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:529,-0.133998,-7.932207,5.986843
04-23 19:23:07.529+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.529+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:535,0.025077,-0.069534,0.102340
04-23 19:23:07.539+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.539+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:540,-0.200997,-7.972885,5.927022
04-23 19:23:07.539+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.539+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:543,1.540000,0.840000,0.350000
04-23 19:23:07.539+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:544,-0.198604,-8.051848,5.907879
04-23 19:23:07.539+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.539+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.539+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.539+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:549,0.056222,-0.067897,0.185856
04-23 19:23:07.539+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.549+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:549,-0.133998,-7.994420,5.934200
04-23 19:23:07.549+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.549+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.549+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:556,-0.148355,-8.003991,5.912664
04-23 19:23:07.549+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:556,1.820000,1.120000,0.490000
04-23 19:23:07.549+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:548,-0.169910,-7.906611,5.798880
04-23 19:23:07.549+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.559+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:553,0.064626,-0.066274,0.185570
04-23 19:23:07.559+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.559+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:561,-0.166502,-7.914918,5.787636
04-23 19:23:07.559+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.559+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:565,0.003791,-0.053182,0.184849
04-23 19:23:07.559+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:565,-0.167736,-7.915380,5.786970
04-23 19:23:07.559+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.559+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.569+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:569,-0.170598,-7.916854,5.784868
04-23 19:23:07.569+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.569+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.569+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.569+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:576,-0.119641,-7.951349,5.903094
04-23 19:23:07.569+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:576,1.820000,1.330000,0.770000
04-23 19:23:07.579+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:573,-0.173738,-7.916596,5.785128
04-23 19:23:07.579+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.579+0200 I/heartrate(13102): capturing data from es.ugr.frailty.heartrate
04-23 19:23:07.579+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:583,-0.172238,-7.915682,5.786423
04-23 19:23:07.579+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.579+0200 I/heartrate(13102): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:23:07:584,80
04-23 19:23:07.579+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:572,-0.030869,-0.033577,0.140052
04-23 19:23:07.579+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.579+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:587,-0.175076,-7.917078,5.784429
04-23 19:23:07.579+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.589+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:589,-0.047149,-0.020139,0.127797
04-23 19:23:07.589+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.589+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:591,-0.177504,-7.918078,5.782985
04-23 19:23:07.589+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.589+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:594,0.039740,-0.015611,0.201715
04-23 19:23:07.589+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:595,-0.176590,-7.918031,5.783077
04-23 19:23:07.589+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.589+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.589+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.589+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.599+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:601,-0.141177,-7.999206,5.972485
04-23 19:23:07.599+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:601,1.890000,1.750000,1.050000
04-23 19:23:07.599+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:599,-0.176846,-7.918641,5.782235
04-23 19:23:07.599+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.599+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:599,-0.028759,-0.057203,0.140598
04-23 19:23:07.599+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.599+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:607,-0.176360,-7.917284,5.784108
04-23 19:23:07.599+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.609+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:609,-0.023528,-0.134770,0.123450
04-23 19:23:07.609+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.609+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:611,-0.177636,-7.914889,5.787344
04-23 19:23:07.609+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.609+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.609+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:616,2.240000,1.960000,1.190000
04-23 19:23:07.609+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.609+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:616,-0.131605,-8.011170,5.991628
04-23 19:23:07.619+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:621,-0.178782,-7.912221,5.790957
04-23 19:23:07.619+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:614,0.043506,-0.076342,0.151216
04-23 19:23:07.619+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.619+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:626,0.028235,-0.085960,0.129587
04-23 19:23:07.619+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.619+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:629,0.057205,-0.032709,0.120859
04-23 19:23:07.619+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.629+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.629+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.629+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:633,0.035183,-0.081923,0.188377
04-23 19:23:07.629+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.629+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:637,0.046031,-0.096281,0.204284
04-23 19:23:07.629+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.639+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:641,0.004106,-0.077414,0.157600
04-23 19:23:07.639+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:637,2.240000,1.960000,1.120000
04-23 19:23:07.639+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:637,-0.174676,-7.989635,5.948557
04-23 19:23:07.639+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.639+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:645,-0.181820,-7.910299,5.793488
04-23 19:23:07.649+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.649+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.649+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:658,-0.187162,-7.905794,5.799464
04-23 19:23:07.649+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:658,-0.234497,-7.956135,5.919843
04-23 19:23:07.649+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.649+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.659+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:662,-0.052676,-0.045836,0.126356
04-23 19:23:07.659+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:662,1.750000,1.610000,1.050000
04-23 19:23:07.669+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.669+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.669+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:678,-0.191345,-7.901911,5.804616
04-23 19:23:07.669+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:678,-0.215354,-7.980063,5.852845
04-23 19:23:07.669+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.669+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.679+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:682,-0.028192,-0.074270,0.053381
04-23 19:23:07.679+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:682,1.680000,1.470000,1.120000
04-23 19:23:07.689+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.689+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.699+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:702,-0.148355,-7.972885,5.979663
04-23 19:23:07.699+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.709+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.709+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.709+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:709,0.042990,-0.070974,0.175047
04-23 19:23:07.719+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.719+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:716,-0.141177,-8.008778,5.986843
04-23 19:23:07.729+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:723,0.051389,-0.111803,0.175553
04-23 19:23:07.729+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.729+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.739+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:736,-0.165105,-7.932207,6.027520
04-23 19:23:07.749+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.749+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:741,0.029104,-0.039432,0.210582
04-23 19:23:07.749+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.759+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:727,1.890000,1.750000,1.260000
04-23 19:23:07.759+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.769+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:702,-0.192565,-7.896975,5.811289
04-23 19:23:07.769+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.779+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:756,-0.153141,-7.889136,5.970093
04-23 19:23:07.779+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.789+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:766,2.520000,2.240000,1.540000
04-23 19:23:07.789+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.799+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:777,-0.194209,-7.892775,5.816938
04-23 19:23:07.799+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.799+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:761,0.043938,-0.000171,0.148085
04-23 19:23:07.799+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:788,-0.224925,-7.829315,5.953342
04-23 19:23:07.799+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.809+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.819+0200 I/heartrate(13102): capturing data from es.ugr.frailty.heartrate
04-23 19:23:07.819+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:805,-0.197079,-7.888965,5.822008
04-23 19:23:07.819+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.819+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:817,-0.025769,0.059150,0.130729
04-23 19:23:07.819+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.829+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:798,3.080000,2.520000,1.470000
04-23 19:23:07.829+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.829+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:834,3.010000,2.590000,1.330000
04-23 19:23:07.829+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.839+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:810,-0.260818,-7.891530,5.938986
04-23 19:23:07.839+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.839+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:845,-0.232104,-7.970492,5.986843
04-23 19:23:07.839+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.849+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:828,-0.199156,-7.888465,5.822614
04-23 19:23:07.849+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.859+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:832,-0.056277,-0.003371,0.116143
04-23 19:23:07.859+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.859+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:841,2.310000,2.660000,1.260000
04-23 19:23:07.859+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.869+0200 I/heartrate(13102): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:23:07:832,80
04-23 19:23:07.869+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:859,-0.204540,-7.888159,5.822843
04-23 19:23:07.869+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.869+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:867,-0.021136,-0.082642,0.163812
04-23 19:23:07.869+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.869+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:876,-0.210967,-7.887851,5.823031
04-23 19:23:07.869+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.879+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:849,-0.258425,-7.958528,5.989235
04-23 19:23:07.879+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.879+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:881,-0.214665,-7.887115,5.823893
04-23 19:23:07.879+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.879+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:872,1.680000,2.380000,1.190000
04-23 19:23:07.879+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:887,-0.218172,-7.886166,5.825047
04-23 19:23:07.889+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.889+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.889+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:878,-0.043760,-0.071414,0.165342
04-23 19:23:07.889+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.889+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:894,-0.219738,-7.886441,5.824615
04-23 19:23:07.889+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.889+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:884,-0.229711,-7.963314,5.991628
04-23 19:23:07.889+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.899+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:900,-0.223383,-7.886562,5.824313
04-23 19:23:07.899+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.899+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:902,-0.272782,-7.925028,5.953342
04-23 19:23:07.899+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.899+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:907,-0.224516,-7.886312,5.824609
04-23 19:23:07.899+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:909,-0.222532,-7.910671,6.022735
04-23 19:23:07.909+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:897,-0.011539,-0.077147,0.166581
04-23 19:23:07.909+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:894,1.260000,1.750000,0.910000
04-23 19:23:07.909+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.909+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.909+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.909+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:914,1.400000,1.120000,0.420000
04-23 19:23:07.909+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.909+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:916,-0.225494,-7.887962,5.822335
04-23 19:23:07.919+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:915,-0.053044,-0.038587,0.128727
04-23 19:23:07.919+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:920,1.890000,0.980000,0.210000
04-23 19:23:07.919+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.919+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.919+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:925,1.960000,1.050000,0.210000
04-23 19:23:07.919+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.919+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:926,0.000850,-0.024109,0.198421
04-23 19:23:07.919+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.929+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.929+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:931,0.011555,-0.024360,0.188554
04-23 19:23:07.929+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:929,1.960000,1.120000,0.210000
04-23 19:23:07.929+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.929+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.929+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:936,-0.227497,-7.888627,5.821357
04-23 19:23:07.929+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.929+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:937,1.820000,1.400000,0.280000
04-23 19:23:07.929+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.939+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:941,-0.004217,-0.010745,0.171685
04-23 19:23:07.939+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:942,1.610000,1.470000,0.420000
04-23 19:23:07.939+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:933,-0.212961,-7.910671,6.013163
04-23 19:23:07.939+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.949+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:949,-0.229711,-7.898707,5.994020
04-23 19:23:07.949+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.949+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.949+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.949+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:956,1.260000,0.980000,0.350000
04-23 19:23:07.959+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:958,-0.018963,0.023419,0.158306
04-23 19:23:07.959+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:956,-0.229704,-7.886231,5.824515
04-23 19:23:07.959+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.959+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:964,-0.246461,-7.865208,5.979663
04-23 19:23:07.969+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.969+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:07:976,1.260000,1.120000,0.490000
04-23 19:23:07.979+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:07.979+0200 I/heartrate(13102): capturing data from es.ugr.frailty.heartrate
04-23 19:23:07.979+0200 I/heartrate(13102): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:23:07:984,80
04-23 19:23:07.979+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:07:983,-0.217747,-7.939385,5.982057
04-23 19:23:07.979+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.989+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:07.989+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:07:993,0.011957,-0.053154,0.157542
04-23 19:23:07.989+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:07:991,-0.230706,-7.885255,5.825797
04-23 19:23:07.989+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:07.999+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:08:0,1.400000,1.190000,0.560000
04-23 19:23:07.999+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:07.999+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:23:07.999+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:23:07.999+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:23:08.009+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:08:5,-0.231568,-7.883533,5.828094
04-23 19:23:08.009+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:08.009+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:08.009+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:08.019+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:08:22,-0.212961,-7.953743,6.015556
04-23 19:23:08.019+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:08:14,0.017744,-0.068488,0.189759
04-23 19:23:08.019+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:08.019+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:08.029+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:08:19,1.470000,1.120000,0.630000
04-23 19:23:08.029+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:08.029+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:08.039+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:08:31,-0.232243,-7.880847,5.831697
04-23 19:23:08.039+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:08:42,-0.208176,-7.929814,5.986843
04-23 19:23:08.039+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:08:29,0.023393,-0.046282,0.158749
04-23 19:23:08.039+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:08.039+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:08.049+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:08:39,1.190000,1.190000,0.700000
04-23 19:23:08.049+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:08.049+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:08.049+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:08:59,0.910000,1.400000,0.630000
04-23 19:23:08.059+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:08:53,-0.231422,-7.879207,5.833946
04-23 19:23:08.059+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:08:51,0.059960,0.015640,0.097718
04-23 19:23:08.059+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:08:64,-0.172283,-7.865208,5.929415
04-23 19:23:08.059+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:08.069+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:08.069+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:08.079+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:08.079+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:08:74,-0.235389,-7.878407,5.834867
04-23 19:23:08.079+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:08:82,1.190000,0.980000,0.420000
04-23 19:23:08.079+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:08:74,-0.038966,0.023571,0.095469
04-23 19:23:08.089+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:08.089+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:08.089+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:08:86,-0.270389,-7.855636,5.929415
04-23 19:23:08.089+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:08.099+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:08.119+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:08:96,-0.015857,-0.046621,0.168725
04-23 19:23:08.119+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:08:103,1.260000,0.700000,0.280000
04-23 19:23:08.129+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:08:95,-0.237471,-7.876377,5.837524
04-23 19:23:08.129+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:08.129+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:08.139+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:08:108,-0.251246,-7.925028,6.003592
04-23 19:23:08.139+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:08.139+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:08:138,-0.236755,-7.873643,5.841239
04-23 19:23:08.139+0200 W/LOCATION(13261): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:23:08.139+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:08.149+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:08:139,0.034082,-0.029510,0.199567
04-23 19:23:08.149+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:08:144,1.190000,0.910000,0.490000
04-23 19:23:08.149+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:08:153,-0.203390,-7.905886,6.037091
04-23 19:23:08.149+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:08.149+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:08.159+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:08.159+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:08.169+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:08:173,-0.210568,-7.946564,5.991628
04-23 19:23:08.169+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:08:162,-0.236886,-7.871920,5.843556
04-23 19:23:08.169+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:08:163,0.026187,-0.072921,0.150389
04-23 19:23:08.169+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:08.169+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:08.179+0200 I/heartrate(13102): capturing data from es.ugr.frailty.heartrate
04-23 19:23:08.179+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:08:168,1.190000,1.330000,0.630000
04-23 19:23:08.179+0200 I/heartrate(13102): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:23:08:183,80
04-23 19:23:08.179+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:08.179+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:08:182,0.016747,-0.079430,0.219857
04-23 19:23:08.189+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:08.189+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:08:183,-0.237988,-7.870263,5.845743
04-23 19:23:08.189+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:08.189+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:08.199+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:08:191,1.680000,1.470000,0.630000
04-23 19:23:08.199+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:08.199+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:08:196,-0.220140,-7.951349,6.063413
04-23 19:23:08.209+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:08.209+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:08:216,-0.253639,-7.941778,5.996413
04-23 19:23:08.219+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:08:202,-0.240789,-7.869773,5.846287
04-23 19:23:08.219+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:08:203,-0.015651,-0.071515,0.150670
04-23 19:23:08.219+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:08.219+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:08.219+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:08:227,-0.242287,-7.869092,5.847143
04-23 19:23:08.219+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:08:210,2.100000,1.680000,0.630000
04-23 19:23:08.229+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:08.229+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:08.229+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:08:225,0.015864,-0.048077,0.207554
04-23 19:23:08.229+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:08:234,2.030000,1.680000,0.700000
04-23 19:23:08.239+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:08.239+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:08:244,-0.052030,0.020633,0.156449
04-23 19:23:08.239+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:08.239+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:08:237,-0.224925,-7.917850,6.053841
04-23 19:23:08.249+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:08.249+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:08.249+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:08:256,-0.294317,-7.848458,6.003592
04-23 19:23:08.249+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:08:254,0.980000,1.330000,0.630000
04-23 19:23:08.259+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:08.259+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:08:250,-0.247189,-7.866427,5.850521
04-23 19:23:08.259+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:08.259+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:08:264,-0.073450,0.051469,0.145892
04-23 19:23:08.259+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:08:268,-0.252723,-7.862649,5.855362
04-23 19:23:08.259+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:08.269+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:08.269+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:08:276,-0.320638,-7.814958,5.996413
04-23 19:23:08.269+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:08.269+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:08:272,0.420000,0.770000,0.280000
04-23 19:23:08.279+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:08:283,-0.036808,-0.038451,0.121909
04-23 19:23:08.279+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:08.279+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:08.279+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:08.289+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:08:287,-0.255427,-7.862029,5.856077
04-23 19:23:08.289+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:08.289+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:08.299+0200 I/accelerometer(13234): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:08:293,-0.289532,-7.901100,5.977271
04-23 19:23:08.299+0200 I/gyroscope(13247): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:08:291,0.700000,0.350000,0.280000
04-23 19:23:08.299+0200 I/gyroscope(13247): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:08.309+0200 I/accelerometer(13234): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:08.309+0200 I/linearacceleration(13277): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:08:301,-0.007783,-0.022321,0.173836
04-23 19:23:08.319+0200 I/linearacceleration(13277): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:08.319+0200 I/gravity (13282): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:08:303,-0.256376,-7.857216,5.862492
04-23 19:23:08.319+0200 I/gravity (13282): capturing data from es.ugr.frailty.gravity
04-23 19:23:08.329+0200 W/CRASH_MANAGER(13195): worker.c: worker_job(1205) > 11132616c6f63152450418
