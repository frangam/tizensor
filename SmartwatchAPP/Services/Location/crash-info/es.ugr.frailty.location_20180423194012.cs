S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 18925
Date: 2018-04-23 19:40:12+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf76ea52d, r5   = 0xf78c0f98
r6   = 0xffe1d990, r7   = 0xffe1d840
r8   = 0xf78bdc18, r9   = 0x00000000
r10  = 0xffe1d91c, fp   = 0xffe1d990
ip   = 0x00000001, sp   = 0xffe1d818
lr   = 0xf76ea539, pc   = 0xf7753228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      8632 KB
Buffers:     55364 KB
Cached:     236980 KB
VmPeak:      53552 KB
VmSize:      53548 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12100 KB
VmRSS:       12100 KB
VmData:      11276 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 18925 TID = 18925
18925 18957 

Maps Information
f45b5000 f4db4000 rw-p [stack:18957]
f4dbb000 f4dbd000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4dc5000 f4dc9000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4dd2000 f4dd4000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4ddc000 f4ddf000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4dee000 f4df3000 r-xp /usr/lib/libsystem.so.0.0.0
f4dfe000 f4e01000 r-xp /lib/libattr.so.1.1.0
f4e09000 f4e19000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e21000 f4e2a000 r-xp /usr/lib/libedbus.so.1.7.99
f4e32000 f4e33000 r-xp /usr/lib/libresponse.so.0.2.96
f4e3c000 f4e41000 r-xp /usr/lib/libproc-stat.so.0.2.96
f66e3000 f67e9000 r-xp /usr/lib/libicuuc.so.57.1
f67ff000 f6987000 r-xp /usr/lib/libicui18n.so.57.1
f6997000 f69a4000 r-xp /usr/lib/libail.so.0.1.0
f69ad000 f69b4000 r-xp /usr/lib/libminizip.so.1.0.0
f69bd000 f6b66000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b86000 f6bcd000 r-xp /usr/lib/libssl.so.1.0.0
f6bd9000 f6bdb000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6be3000 f6bea000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6bf3000 f6bfa000 r-xp /lib/libcrypt-2.13.so
f6c2b000 f6c2e000 r-xp /lib/libcap.so.2.21
f6c36000 f6c38000 r-xp /usr/lib/libiri.so
f6c40000 f6c89000 r-xp /usr/lib/libmdm.so.1.2.69
f6c91000 f6c97000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c9f000 f6cc2000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6ccc000 f6cce000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6cd6000 f6cf3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6cfc000 f6d00000 r-xp /usr/lib/libsmack.so.1.0.0
f6d09000 f6d22000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d2b000 f6d33000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d3b000 f6d41000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d4a000 f6d4c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d55000 f6d65000 r-xp /lib/libresolv-2.13.so
f6d69000 f6d81000 r-xp /usr/lib/liblzma.so.5.0.3
f6d8a000 f6d8c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d94000 f6dae000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6db6000 f6de5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6dee000 f6dfd000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e07000 f6e11000 r-xp /usr/lib/libsensord-shared.so
f6e1a000 f6eed000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ef8000 f6f0e000 r-xp /lib/libz.so.1.2.5
f6f16000 f6f1b000 r-xp /usr/lib/libffi.so.5.0.10
f6f23000 f6f24000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f2c000 f6f3c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f44000 f6f5d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f65000 f6f67000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f6f000 f6fe4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6fee000 f6ff4000 r-xp /lib/librt-2.13.so
f6ffd000 f701b000 r-xp /usr/lib/libsystemd.so.0.4.0
f7025000 f7026000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f702e000 f7051000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7059000 f705e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7066000 f7090000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7099000 f70b0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70b8000 f7121000 r-xp /lib/libm-2.13.so
f712a000 f71be000 r-xp /usr/lib/libstdc++.so.6.0.16
f71d1000 f71d6000 r-xp /usr/lib/libctx-client.so.0.8.3
f71de000 f71e5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f71ed000 f7217000 r-xp /usr/lib/libsensor.so.1.9.6
f7220000 f72ec000 r-xp /usr/lib/libxml2.so.2.7.8
f72f9000 f72fb000 r-xp /usr/lib/libiniparser.so.0
f7304000 f730a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7313000 f73e3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f73e4000 f7418000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7421000 f745d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7465000 f7468000 r-xp /usr/lib/libbundle.so.0.1.22
f7470000 f7476000 r-xp /usr/lib/libappsvc.so.0.1.0
f747e000 f74bf000 r-xp /usr/lib/libeina.so.1.7.99
f74c8000 f74df000 r-xp /usr/lib/libecore.so.1.7.99
f74f6000 f74ff000 r-xp /usr/lib/libvconf.so.0.2.45
f7507000 f751b000 r-xp /lib/libpthread-2.13.so
f7526000 f7533000 r-xp /usr/lib/libaul.so.0.1.0
f753d000 f753f000 r-xp /lib/libdl-2.13.so
f7548000 f7553000 r-xp /lib/libunwind.so.8.0.1
f7580000 f7588000 r-xp /lib/libgcc_s-4.6.so.1
f7589000 f76ad000 r-xp /lib/libc-2.13.so
f76bb000 f76bd000 r-xp /usr/lib/libdlog.so.0.0.0
f76c5000 f76d1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f76da000 f76df000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f76e7000 f76f6000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f76fe000 f7702000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f770b000 f770e000 r-xp /usr/lib/libappcore-agent.so.1.1
f7716000 f7718000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7720000 f7724000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f772c000 f7749000 r-xp /lib/ld-2.13.so
f7752000 f7755000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7755000 f7759000 r-xp /usr/lib/libsys-assert.so
f788d000 f7917000 rw-p [heap]
ffdff000 ffe20000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18925)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7753228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf76ea539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73f13f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf73efc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf73fbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7401be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7401dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf743675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf74311f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf73efc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf73fbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7401be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7401dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7433e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7434017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf743bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4dd31fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4dc6171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e99663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7346fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73487a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf74d8ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf74d3b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74d45a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf74d4879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf770c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf770c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf77534f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf75a085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7752f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
:40:11.809+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:11:811,7.970492,-5.422136,-0.375673
04-23 19:40:11.809+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:11.809+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:11.809+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:11.809+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:11.809+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:11:818,6.146861,-7.613183,0.652633
04-23 19:40:11.809+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:11:818,2.224825,2.413221,-0.651425
04-23 19:40:11.819+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:11:816,8.188239,-5.544170,-0.870987
04-23 19:40:11.819+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:11.819+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:11:817,1.820000,0.210000,-3.220000
04-23 19:40:11.819+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:11.819+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:11:825,8.226524,-5.479564,-0.480957
04-23 19:40:11.819+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:11.819+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:11:826,5.390000,-9.590000,-1.680000
04-23 19:40:11.819+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:11.829+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:11:829,7.858029,-4.864608,0.497707
04-23 19:40:11.829+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:11.829+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:11:832,17.150000,-6.720000,-0.910000
04-23 19:40:11.829+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:11:833,7.731210,-5.008178,-0.016750
04-23 19:40:11.829+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:11.829+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:11.829+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:11.839+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:11:839,6.218858,-7.556127,0.633346
04-23 19:40:11.839+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:11:839,2.091628,3.265425,-0.599991
04-23 19:40:11.839+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:11:837,8.145168,-5.484349,-0.102891
04-23 19:40:11.839+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:11.839+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:11.839+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:11:848,8.274381,-5.276174,0.016750
04-23 19:40:11.839+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:11.849+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:11:848,8.540000,-4.200000,0.770000
04-23 19:40:11.849+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:11:852,8.238488,-4.347759,0.052642
04-23 19:40:11.859+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:11.859+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:11.859+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:11.859+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:11:863,6.221545,-7.557632,0.587338
04-23 19:40:11.859+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:11.859+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:11:864,1.887731,3.205088,-0.582552
04-23 19:40:11.859+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:11:868,-9.240000,-7.000000,7.280000
04-23 19:40:11.869+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:11:868,8.109276,-4.352544,0.004786
04-23 19:40:11.869+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:11.869+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:11.869+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:11.879+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:11:878,-17.570000,-11.690000,12.110000
04-23 19:40:11.879+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:11:881,6.162384,-7.610729,0.521742
04-23 19:40:11.879+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:11:879,1.847053,2.621239,-0.285842
04-23 19:40:11.879+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:11.889+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:11:891,8.068598,-4.936393,0.301496
04-23 19:40:11.889+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:11.889+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:11.889+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:11.889+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:11:899,6.185946,-7.593700,0.490072
04-23 19:40:11.889+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:11:898,-6.860000,-15.330000,15.470000
04-23 19:40:11.899+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:11:898,1.973213,2.186200,-0.945272
04-23 19:40:11.899+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:11.899+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:11:906,8.135597,-5.424529,-0.423530
04-23 19:40:11.909+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:11.909+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:11.919+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:11.919+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:11:919,4.620000,-12.250000,18.270000
04-23 19:40:11.919+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:11:923,2.162612,2.374955,-0.415894
04-23 19:40:11.919+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:11.919+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:11:920,6.155992,-7.621260,0.436520
04-23 19:40:11.919+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:11:927,8.348558,-5.218746,0.074178
04-23 19:40:11.929+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:11.929+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:11.939+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:11.939+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:11:940,13.720000,-13.510000,23.030001
04-23 19:40:11.939+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:11.939+0200 I/heartrate(18904): capturing data from es.ugr.frailty.heartrate
04-23 19:40:11.939+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:11:945,8.193025,-5.367101,-0.224925
04-23 19:40:11.939+0200 I/heartrate(18904): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:40:11:945,76
04-23 19:40:11.939+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:11:940,6.271998,-7.526575,0.427883
04-23 19:40:11.949+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:11:943,2.037033,2.254158,-0.661445
04-23 19:40:11.959+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:11.959+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:11.959+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:11:966,18.200001,-13.860000,24.500000
04-23 19:40:11.959+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:11:966,8.271988,-5.879165,-0.600598
04-23 19:40:11.959+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:11.969+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:11.969+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:11.969+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:11.979+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:11:973,1.999990,1.647410,-1.028481
04-23 19:40:11.979+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:11.979+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:11:971,6.381746,-7.434872,0.407898
04-23 19:40:11.979+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:11:979,12.880000,-6.370000,26.320000
04-23 19:40:11.979+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:11.979+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:11:984,1.744279,1.378637,-1.006104
04-23 19:40:11.979+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:11:979,8.126025,-6.056234,-0.598206
04-23 19:40:11.989+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:11:989,6.380798,-7.437737,0.368588
04-23 19:40:11.989+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:11.989+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:11.999+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:11:998,8.044669,-6.209375,-0.248854
04-23 19:40:11.999+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:11.999+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:11.999+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:11:998,14.770000,-6.300000,29.960001
04-23 19:40:11.999+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:4,1.663871,1.228363,-0.617441
04-23 19:40:11.999+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:7,6.398644,-7.424005,0.334497
04-23 19:40:12.009+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.009+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.019+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:20,8.035098,-6.297909,-0.299103
04-23 19:40:12.019+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:20,17.080000,-7.350000,31.219999
04-23 19:40:12.019+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.019+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.019+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:26,1.636454,1.126096,-0.633600
04-23 19:40:12.029+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:27,6.512703,-7.324695,0.322386
04-23 19:40:12.029+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.039+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.039+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:40,20.650000,-4.550000,29.889999
04-23 19:40:12.049+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.049+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.049+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:44,8.147561,-6.080163,-0.461815
04-23 19:40:12.059+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.059+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.069+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:54,1.634858,1.244532,-0.784201
04-23 19:40:12.069+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:75,8.499306,-6.934400,-1.028914
04-23 19:40:12.069+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.079+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:58,6.663047,-7.188507,0.315518
04-23 19:40:12.079+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.079+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:84,1.836258,0.254107,-1.344432
04-23 19:40:12.079+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:64,27.930000,-4.060000,25.340000
04-23 19:40:12.089+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.089+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.099+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:94,43.119999,12.740000,19.530001
04-23 19:40:12.099+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.099+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:89,6.887617,-6.973902,0.309526
04-23 19:40:12.099+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:107,1.568619,0.805206,-1.391082
04-23 19:40:12.099+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.109+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.109+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:99,8.456236,-6.168696,-1.081556
04-23 19:40:12.109+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.119+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:123,7.846066,-6.221339,-1.308874
04-23 19:40:12.119+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:117,37.799999,18.270000,14.280000
04-23 19:40:12.119+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:112,7.127325,-6.727040,0.344328
04-23 19:40:12.119+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.129+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.129+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.139+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.139+0200 I/heartrate(18904): capturing data from es.ugr.frailty.heartrate
04-23 19:40:12.139+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:145,8.020741,-7.123433,-0.026321
04-23 19:40:12.139+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.139+0200 I/heartrate(18904): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:40:12:147,76
04-23 19:40:12.149+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:132,0.718741,0.505702,-1.653202
04-23 19:40:12.149+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:140,29.120001,21.490000,12.600000
04-23 19:40:12.149+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.149+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.149+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:155,35.840000,13.860000,2.030000
04-23 19:40:12.149+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:137,7.226744,-6.620197,0.342836
04-23 19:40:12.149+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.149+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:154,0.793997,-0.503235,-0.369157
04-23 19:40:12.149+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.159+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.159+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:160,7.230415,-6.617141,0.323922
04-23 19:40:12.159+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.159+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:163,37.240002,14.700000,-3.010000
04-23 19:40:12.159+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:166,7.379437,-6.448474,0.362593
04-23 19:40:12.159+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.159+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:162,0.531901,-1.212174,-0.158817
04-23 19:40:12.169+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.169+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:151,7.762317,-7.829315,0.165105
04-23 19:40:12.169+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.169+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.169+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:176,7.697710,-7.482357,0.394816
04-23 19:40:12.169+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.179+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:179,20.299999,11.410000,-10.710000
04-23 19:40:12.179+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:174,0.318273,-1.033883,0.032223
04-23 19:40:12.179+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.179+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:170,7.488973,-6.317708,0.415013
04-23 19:40:12.179+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.179+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:181,7.910671,-6.046663,0.535992
04-23 19:40:12.179+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:186,0.421698,0.271045,0.120980
04-23 19:40:12.189+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:187,7.512140,-6.287909,0.447594
04-23 19:40:12.189+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.189+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.189+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:198,-7.840000,7.980000,-12.530000
04-23 19:40:12.199+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.199+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.199+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:203,0.446388,0.722204,-0.311203
04-23 19:40:12.199+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:198,7.958528,-5.565705,0.136391
04-23 19:40:12.199+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:204,7.459726,-6.349544,0.454049
04-23 19:40:12.209+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.209+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.209+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:219,7.992027,-6.178268,0.186640
04-23 19:40:12.209+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:219,-25.620001,10.220000,-11.060000
04-23 19:40:12.219+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.219+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.219+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:223,7.297717,-6.537035,0.425304
04-23 19:40:12.229+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:227,0.532301,0.171276,-0.267409
04-23 19:40:12.229+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.229+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.229+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.239+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:40:12.239+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:40:12.239+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:40:12.239+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:239,-26.250000,13.930000,-13.790000
04-23 19:40:12.239+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.249+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:249,7.788638,-6.407979,0.564706
04-23 19:40:12.249+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:242,0.490921,0.129056,0.139402
04-23 19:40:12.249+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.249+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:255,7.078397,-6.775381,0.401110
04-23 19:40:12.259+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.259+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.259+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:263,0.423102,0.439187,0.015242
04-23 19:40:12.259+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:263,6.922564,-6.934760,0.396989
04-23 19:40:12.259+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:259,-20.370001,11.270000,-14.140000
04-23 19:40:12.259+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.269+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:271,7.501499,-6.336195,0.416351
04-23 19:40:12.269+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.269+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.279+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.279+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.279+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:281,-16.870001,7.770000,-14.490000
04-23 19:40:12.279+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:279,0.593291,0.940739,-0.054816
04-23 19:40:12.279+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:284,6.802216,-7.053473,0.385702
04-23 19:40:12.289+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:283,7.515855,-5.994020,0.342174
04-23 19:40:12.289+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.289+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.289+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:298,0.665783,1.538016,0.025863
04-23 19:40:12.299+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.299+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:299,-16.870001,6.160000,-13.790000
04-23 19:40:12.299+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.299+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:303,7.467999,-5.515456,0.411566
04-23 19:40:12.299+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:306,6.692621,-7.158403,0.369411
04-23 19:40:12.309+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.309+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.319+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.319+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:320,-17.710001,5.880000,-10.640000
04-23 19:40:12.319+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.319+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:319,0.560024,0.968171,-0.003309
04-23 19:40:12.329+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:323,7.252645,-6.190232,0.366102
04-23 19:40:12.329+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:329,6.597181,-7.247094,0.356685
04-23 19:40:12.329+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.329+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.339+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.339+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:340,-23.309999,4.340000,-10.290000
04-23 19:40:12.339+0200 I/heartrate(18904): capturing data from es.ugr.frailty.heartrate
04-23 19:40:12.339+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.339+0200 I/heartrate(18904): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:40:12:346,76
04-23 19:40:12.349+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:348,6.421390,-7.404540,0.330042
04-23 19:40:12.349+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:339,0.610000,1.131039,-0.435648
04-23 19:40:12.349+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:343,7.207181,-6.116055,-0.078963
04-23 19:40:12.359+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.359+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.359+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:363,0.965254,0.924777,-0.856463
04-23 19:40:12.359+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.359+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:364,-30.520000,2.450000,-11.060000
04-23 19:40:12.369+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.369+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:370,7.386643,-6.479764,-0.526421
04-23 19:40:12.369+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.369+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.379+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:379,1.762898,0.923810,-0.373219
04-23 19:40:12.379+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.389+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:374,6.087953,-7.683534,0.265541
04-23 19:40:12.389+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.389+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:387,7.850852,-6.759724,-0.107677
04-23 19:40:12.389+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.399+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.399+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:395,5.724534,-7.960058,0.193808
04-23 19:40:12.409+0200 W/LOCATION(18925): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:40:12.409+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:408,7.836494,-6.374479,0.485743
04-23 19:40:12.409+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.419+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.419+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:421,5.644606,-8.017315,0.177405
04-23 19:40:12.419+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:427,7.506285,-6.271588,0.567099
04-23 19:40:12.429+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.429+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:380,-20.090000,3.080000,-11.410000
04-23 19:40:12.429+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.429+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:403,2.111960,1.585579,0.291935
04-23 19:40:12.429+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.429+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.439+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:433,5.906741,-7.825189,0.217313
04-23 19:40:12.439+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:434,-4.900000,7.070000,-13.440001
04-23 19:40:12.439+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.439+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.439+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:441,7.558927,-5.769095,0.222532
04-23 19:40:12.439+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:446,8.960000,6.020000,-13.230000
04-23 19:40:12.439+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.449+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:448,6.253970,-7.549036,0.265149
04-23 19:40:12.449+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:440,1.861679,1.745727,0.389694
04-23 19:40:12.449+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.449+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:455,1.652186,2.056093,0.005219
04-23 19:40:12.459+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.459+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.459+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.459+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:451,16.799999,-0.280000,-10.430000
04-23 19:40:12.459+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:464,7.867601,-4.697111,-0.184247
04-23 19:40:12.469+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.469+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.469+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:463,1.613631,2.851924,-0.449396
04-23 19:40:12.479+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:468,6.450562,-7.381277,0.278182
04-23 19:40:12.479+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.479+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.479+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:479,7.996813,-5.465207,-0.315853
04-23 19:40:12.479+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:486,1.546250,1.916070,-0.594035
04-23 19:40:12.489+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:475,10.570000,-3.220000,-6.230000
04-23 19:40:12.489+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.489+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.489+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.489+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:494,-8.960000,-0.630000,-0.420000
04-23 19:40:12.499+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.499+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:492,6.315896,-7.498160,0.239672
04-23 19:40:12.499+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:498,1.659382,1.169144,0.382462
04-23 19:40:12.499+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.499+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:504,-16.100000,5.600000,-0.980000
04-23 19:40:12.499+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:499,7.975278,-6.329016,0.622134
04-23 19:40:12.509+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:511,5.996225,-7.757556,0.189708
04-23 19:40:12.509+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.509+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.519+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:519,1.806770,1.215579,0.810492
04-23 19:40:12.519+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.519+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:520,-0.630000,1.190000,-4.620000
04-23 19:40:12.519+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:524,7.802995,-6.541977,1.000200
04-23 19:40:12.519+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.529+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:532,6.162000,-7.625891,0.214327
04-23 19:40:12.529+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.529+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.529+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:538,1.813278,1.512229,0.431736
04-23 19:40:12.539+0200 I/heartrate(18904): capturing data from es.ugr.frailty.heartrate
04-23 19:40:12.539+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:539,13.790000,-3.920000,-6.020000
04-23 19:40:12.539+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.539+0200 I/heartrate(18904): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:40:12:545,76
04-23 19:40:12.549+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.549+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:547,7.975278,-6.113662,0.646062
04-23 19:40:12.549+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:554,6.565432,-7.279525,0.272033
04-23 19:40:12.559+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.559+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.559+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:563,1.495987,1.787997,-0.374925
04-23 19:40:12.559+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.559+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:568,8.061419,-5.491528,-0.102891
04-23 19:40:12.569+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:564,15.260000,-5.320000,-7.490000
04-23 19:40:12.569+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.569+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.569+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.569+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:579,1.208837,1.589239,-0.872045
04-23 19:40:12.579+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.579+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:579,13.930000,-4.130000,-5.670000
04-23 19:40:12.579+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:575,6.883690,-6.977875,0.307339
04-23 19:40:12.579+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.589+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:584,8.092526,-5.388636,-0.564706
04-23 19:40:12.589+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:591,7.055460,-6.804444,0.300669
04-23 19:40:12.589+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.589+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.589+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:598,1.187814,1.097562,-0.480131
04-23 19:40:12.589+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.599+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:602,8.243275,-5.706882,-0.179462
04-23 19:40:12.599+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:598,11.550000,-0.910000,-4.410000
04-23 19:40:12.599+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.599+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:607,7.111898,-6.746722,0.270240
04-23 19:40:12.609+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.609+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.619+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.619+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:619,0.999771,0.597168,0.502642
04-23 19:40:12.619+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:620,11.620000,0.840000,-7.280000
04-23 19:40:12.619+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:624,8.111670,-6.149554,0.772882
04-23 19:40:12.619+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.629+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:631,7.227801,-6.622685,0.263285
04-23 19:40:12.629+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.629+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.629+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:638,0.742691,0.908625,0.394741
04-23 19:40:12.629+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:639,16.030001,-1.610000,-8.540000
04-23 19:40:12.629+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.639+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.639+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:643,7.970492,-5.714060,0.658026
04-23 19:40:12.639+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:643,7.477540,-6.337610,0.302443
04-23 19:40:12.639+0200 I/servicemanager(18878): es.ugr.frailty.location sleep timeout
04-23 19:40:12.639+0200 W/AUL     (18878): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 19:40:12.639+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:40:12.649+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18878
04-23 19:40:12.649+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18925
04-23 19:40:12.659+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.659+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.659+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:663,0.464237,1.106899,-0.228266
04-23 19:40:12.659+0200 W/AUL     (18878): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18925)
04-23 19:40:12.659+0200 I/servicemanager(18878): es.ugr.frailty.location stop request sent!
04-23 19:40:12.659+0200 I/servicemanager(18878): App control destroyed.
04-23 19:40:12.659+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:665,7.654435,-6.121779,0.322235
04-23 19:40:12.659+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.659+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:669,9.940000,-5.810000,-8.120000
04-23 19:40:12.669+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.669+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:674,7.941778,-5.230711,0.074178
04-23 19:40:12.669+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.669+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.669+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:678,0.512269,0.515396,-0.877370
04-23 19:40:12.669+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:679,7.783498,-5.957529,0.308873
04-23 19:40:12.679+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.679+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.689+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.689+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:698,0.519596,0.291325,-0.356729
04-23 19:40:12.699+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.699+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:705,7.847790,-5.874132,0.277760
04-23 19:40:12.699+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:683,7.840000,-6.650000,-6.510000
04-23 19:40:12.709+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.709+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.719+0200 I/gravity (18940): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:12:721,7.942186,-5.745422,0.286687
04-23 19:40:12.719+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:718,10.290000,0.490000,-6.650000
04-23 19:40:12.719+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.719+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.719+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:728,19.180000,5.390000,-5.810000
04-23 19:40:12.729+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:729,0.117917,0.071537,0.490336
04-23 19:40:12.729+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:690,8.166703,-5.606383,-0.555135
04-23 19:40:12.729+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.729+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.729+0200 I/gravity (18940): capturing data from es.ugr.frailty.gravity
04-23 19:40:12.729+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:738,-0.194227,-0.081101,0.139235
04-23 19:40:12.729+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.739+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:742,20.719999,0.210000,-5.670000
04-23 19:40:12.749+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:737,8.303094,-5.666204,-0.047856
04-23 19:40:12.749+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.749+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:755,7.965706,-5.802595,0.768096
04-23 19:40:12.749+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.759+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:760,7.747960,-5.826523,0.425922
04-23 19:40:12.769+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.779+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:781,8.400000,-6.650000,-4.760000
04-23 19:40:12.779+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.779+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.789+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:789,-2.240000,-6.090000,-0.840000
04-23 19:40:12.789+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:787,8.212167,-5.082355,-0.074178
04-23 19:40:12.789+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.789+0200 I/heartrate(18904): capturing data from es.ugr.frailty.heartrate
04-23 19:40:12.789+0200 I/heartrate(18904): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:40:12:798,76
04-23 19:40:12.789+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.799+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:803,8.590233,-5.233103,-0.055035
04-23 19:40:12.799+0200 I/gyroscope(18892): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:12:798,2.940000,3.850000,-1.820000
04-23 19:40:12.799+0200 I/accelerometer(18889): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:12.799+0200 I/accelerometer(18889): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:12:808,8.413164,-5.589634,0.543171
04-23 19:40:12.809+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.809+0200 I/linearacceleration(18929): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:12:813,0.156030,0.499966,-0.400851
04-23 19:40:12.809+0200 I/linearacceleration(18929): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:12.819+0200 I/gyroscope(18892): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:12.819+0200 W/CRASH_MANAGER(18968): worker.c: worker_job(1205) > 11189256c6f63152450521
