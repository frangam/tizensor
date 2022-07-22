S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 28403
Date: 2018-06-07 18:35:05+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf71b452d, r5   = 0xf754ef98
r6   = 0xffc4fe68, r7   = 0xffc4fd18
r8   = 0xf754bc18, r9   = 0x00000000
r10  = 0xffc4fdf4, fp   = 0xffc4fe68
ip   = 0x00000001, sp   = 0xffc4fcf0
lr   = 0xf71b4539, pc   = 0xf721d228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    273888 KB
Buffers:      6212 KB
Cached:      97760 KB
VmPeak:      53460 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11552 KB
VmRSS:       11548 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 28403 TID = 28403
28403 28477 

Maps Information
f407f000 f487e000 rw-p [stack:28477]
f4885000 f4887000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f488f000 f4893000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f489c000 f489e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f48a6000 f48a9000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f48b8000 f48bd000 r-xp /usr/lib/libsystem.so.0.0.0
f48c8000 f48cb000 r-xp /lib/libattr.so.1.1.0
f48d3000 f48e3000 r-xp /usr/lib/libmdm-common.so.1.1.24
f48eb000 f48f4000 r-xp /usr/lib/libedbus.so.1.7.99
f48fc000 f48fd000 r-xp /usr/lib/libresponse.so.0.2.96
f4906000 f490b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f61ad000 f62b3000 r-xp /usr/lib/libicuuc.so.57.1
f62c9000 f6451000 r-xp /usr/lib/libicui18n.so.57.1
f6461000 f646e000 r-xp /usr/lib/libail.so.0.1.0
f6477000 f647e000 r-xp /usr/lib/libminizip.so.1.0.0
f6487000 f6630000 r-xp /usr/lib/libcrypto.so.1.0.0
f6650000 f6697000 r-xp /usr/lib/libssl.so.1.0.0
f66a3000 f66a5000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f66ad000 f66b4000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f66bd000 f66c4000 r-xp /lib/libcrypt-2.13.so
f66f5000 f66f8000 r-xp /lib/libcap.so.2.21
f6700000 f6702000 r-xp /usr/lib/libiri.so
f670a000 f6753000 r-xp /usr/lib/libmdm.so.1.2.69
f675b000 f6761000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6769000 f678c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6796000 f6798000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f67a0000 f67bd000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f67c6000 f67ca000 r-xp /usr/lib/libsmack.so.1.0.0
f67d3000 f67ec000 r-xp /usr/lib/libnetwork.so.0.0.0
f67f5000 f67fd000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6805000 f680b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6814000 f6816000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f681f000 f682f000 r-xp /lib/libresolv-2.13.so
f6833000 f684b000 r-xp /usr/lib/liblzma.so.5.0.3
f6854000 f6856000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f685e000 f6878000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6880000 f68af000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68b8000 f68c7000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f68d1000 f68db000 r-xp /usr/lib/libsensord-shared.so
f68e4000 f69b7000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f69c2000 f69d8000 r-xp /lib/libz.so.1.2.5
f69e0000 f69e5000 r-xp /usr/lib/libffi.so.5.0.10
f69ed000 f69ee000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f69f6000 f6a06000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a0e000 f6a27000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a2f000 f6a31000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a39000 f6aae000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ab8000 f6abe000 r-xp /lib/librt-2.13.so
f6ac7000 f6ae5000 r-xp /usr/lib/libsystemd.so.0.4.0
f6aef000 f6af0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6af8000 f6b1b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b23000 f6b28000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b30000 f6b5a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b63000 f6b7a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b82000 f6beb000 r-xp /lib/libm-2.13.so
f6bf4000 f6c88000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c9b000 f6ca0000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ca8000 f6caf000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6cb7000 f6ce1000 r-xp /usr/lib/libsensor.so.1.9.6
f6cea000 f6db6000 r-xp /usr/lib/libxml2.so.2.7.8
f6dc3000 f6dc5000 r-xp /usr/lib/libiniparser.so.0
f6dce000 f6dd4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ddd000 f6ead000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6eae000 f6ee2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6eeb000 f6f27000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f2f000 f6f32000 r-xp /usr/lib/libbundle.so.0.1.22
f6f3a000 f6f40000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f48000 f6f89000 r-xp /usr/lib/libeina.so.1.7.99
f6f92000 f6fa9000 r-xp /usr/lib/libecore.so.1.7.99
f6fc0000 f6fc9000 r-xp /usr/lib/libvconf.so.0.2.45
f6fd1000 f6fe5000 r-xp /lib/libpthread-2.13.so
f6ff0000 f6ffd000 r-xp /usr/lib/libaul.so.0.1.0
f7007000 f7009000 r-xp /lib/libdl-2.13.so
f7012000 f701d000 r-xp /lib/libunwind.so.8.0.1
f704a000 f7052000 r-xp /lib/libgcc_s-4.6.so.1
f7053000 f7177000 r-xp /lib/libc-2.13.so
f7185000 f7187000 r-xp /usr/lib/libdlog.so.0.0.0
f718f000 f719b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71a4000 f71a9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f71b1000 f71c0000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f71c8000 f71cc000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f71d5000 f71d8000 r-xp /usr/lib/libappcore-agent.so.1.1
f71e0000 f71e2000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f71ea000 f71ee000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f71f6000 f7213000 r-xp /lib/ld-2.13.so
f721c000 f721f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f721f000 f7223000 r-xp /usr/lib/libsys-assert.so
f751b000 f758c000 rw-p [heap]
ffc31000 ffc52000 rw-p [stack]
End of Maps Information

Callstack Information (PID:28403)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf721d228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf71b4539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6ebb3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6eb9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6ec5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6ecbbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6ecbdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f0075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6efb1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6eb9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6ec5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6ecbbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6ecbdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6efde5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6efe017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f028d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf71ec0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4890171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6963663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e10fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e127a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6fa2ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f9db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f9e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f9e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf71d6183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71d67fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf721d5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf706a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf721cf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
eration - capturing data
06-07 18:35:04.911+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:04:919,0.070000,0.070000,0.070000
06-07 18:35:04.921+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:04:923,0.060103,-0.036551,0.040232
06-07 18:35:04.921+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:04.921+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:04.931+0200 I/light   (28441): es.ugr.frailty.light - capturing data
06-07 18:35:04.931+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:04:934,0.070000,0.070000,0.070000
06-07 18:35:04.931+0200 I/light   (28441): es.ugr.frailty.light: SM-R760,07/06/2018,18:35:04:935,1486.000000
06-07 18:35:04.931+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:04:933,0.312641,-0.084843,9.801298
06-07 18:35:04.931+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:04.941+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:04.941+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:04:942,0.356531,-0.093320,9.798609
06-07 18:35:04.941+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:04.941+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:04.951+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:04:953,0.311950,-0.083869,9.801329
06-07 18:35:04.951+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:04.951+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:04:947,0.045591,-0.008731,-0.002746
06-07 18:35:04.951+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:04.951+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:04:954,0.315853,-0.071785,9.877571
06-07 18:35:04.951+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:04:959,0.003211,0.013058,0.076273
06-07 18:35:04.961+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:04:958,0.140000,0.070000,0.070000
06-07 18:35:04.961+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:04.961+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:04.961+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:04.971+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:04:972,0.310313,-0.083759,9.801381
06-07 18:35:04.971+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:04.971+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:04:971,0.140000,0.070000,0.070000
06-07 18:35:04.971+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:04:973,-0.017633,-0.004666,0.042744
06-07 18:35:04.981+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:04:983,0.294317,-0.088534,9.844072
06-07 18:35:04.981+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:04.981+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:04.981+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:04.991+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:04:993,0.310722,-0.083874,9.801368
06-07 18:35:04.991+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:04.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 18:35:04.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 18:35:04.991+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:04:998,0.140000,0.070000,0.070000
06-07 18:35:04.991+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:04:994,0.334995,-0.093320,9.836893
06-07 18:35:04.991+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:04:994,0.024682,-0.009561,0.035512
06-07 18:35:05.001+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.011+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.011+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.011+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:12,0.308546,-0.083771,9.801437
06-07 18:35:05.011+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.011+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:19,0.282353,-0.088534,9.851252
06-07 18:35:05.011+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:20,0.140000,0.070000,0.070000
06-07 18:35:05.021+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:18,-0.028369,-0.004660,0.049884
06-07 18:35:05.021+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.021+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.021+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.031+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:33,0.308525,-0.084332,9.801433
06-07 18:35:05.031+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.031+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:38,0.140000,0.070000,0.070000
06-07 18:35:05.041+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:35,0.014485,-0.019120,0.037848
06-07 18:35:05.041+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:36,0.323031,-0.102891,9.839286
06-07 18:35:05.041+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.041+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.051+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:54,0.007328,-0.004202,0.061783
06-07 18:35:05.051+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.051+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.051+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:59,0.140000,0.070000,0.070000
06-07 18:35:05.051+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:59,0.315853,-0.088534,9.863215
06-07 18:35:05.051+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:54,0.308072,-0.084183,9.801448
06-07 18:35:05.061+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.061+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.071+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.071+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.071+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:73,0.308938,-0.084880,9.801415
06-07 18:35:05.071+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:76,0.070000,0.070000,0.070000
06-07 18:35:05.081+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:72,0.026923,-0.018708,0.025874
06-07 18:35:05.081+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.081+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.091+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:93,0.016485,0.025059,0.045050
06-07 18:35:05.091+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.091+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:99,0.070000,0.070000,0.070000
06-07 18:35:05.091+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:81,0.334995,-0.102891,9.827322
06-07 18:35:05.101+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.101+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:93,0.309123,-0.083508,9.801421
06-07 18:35:05.101+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.111+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.111+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.111+0200 I/heartrate(28387): es.ugr.frailty.heartrate - capturing data
06-07 18:35:05.111+0200 I/heartrate(28387): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:35:05.111+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:113,0.309873,-0.082514,9.801406
06-07 18:35:05.121+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:107,0.325424,-0.059821,9.846465
06-07 18:35:05.121+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.121+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:123,0.016301,0.023687,0.028294
06-07 18:35:05.121+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.121+0200 I/light   (28441): es.ugr.frailty.light - capturing data
06-07 18:35:05.131+0200 I/light   (28441): es.ugr.frailty.light: SM-R760,07/06/2018,18:35:05:136,1490.000000
06-07 18:35:05.131+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:119,-0.070000,0.070000,0.140000
06-07 18:35:05.131+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.131+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.141+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:135,0.310279,-0.082455,9.801394
06-07 18:35:05.141+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:128,0.325424,-0.059821,9.829715
06-07 18:35:05.151+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:143,0.008372,0.003551,0.064202
06-07 18:35:05.151+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.151+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.151+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:142,-0.070000,0.070000,0.070000
06-07 18:35:05.151+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.151+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:157,-0.003998,-0.020436,0.028321
06-07 18:35:05.161+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.161+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:161,0.308795,-0.082791,9.801437
06-07 18:35:05.161+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:160,0.318245,-0.078963,9.865608
06-07 18:35:05.161+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.171+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:167,0.280000,0.070000,0.070000
06-07 18:35:05.171+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.171+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.171+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:172,0.038164,0.015792,0.080920
06-07 18:35:05.181+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.181+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.191+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:181,0.309556,-0.081832,9.801421
06-07 18:35:05.191+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 18:35:05.191+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 18:35:05.191+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:192,0.006297,-0.006703,0.016330
06-07 18:35:05.191+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.201+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:203,0.309388,-0.081976,9.801426
06-07 18:35:05.211+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 18:35:05.211+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.221+0200 W/libgps_d( 3131): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
06-07 18:35:05.221+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:222,0.025608,-0.006559,0.042646
06-07 18:35:05.221+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.221+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
06-07 18:35:05.221+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 18:35:05.221+0200 E/CAPI_LOCATION_MANAGER( 3823): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-07 18:35:05.241+0200 I/AUL     ( 3823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-07 18:35:05.251+0200 I/AUL     ( 3823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-07 18:35:05.251+0200 E/LOCATION( 3823): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
06-07 18:35:05.251+0200 I/LOCATION( 3823): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
06-07 18:35:05.251+0200 I/LOCATION( 3823): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-07 18:35:05.251+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.251+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:177,0.306281,-0.102891,9.829715
06-07 18:35:05.251+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:195,0.070000,0.210000,0.070000
06-07 18:35:05.261+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.261+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:260,-0.034758,-0.001668,0.052236
06-07 18:35:05.261+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.261+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.261+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:266,0.346959,-0.066999,9.882358
06-07 18:35:05.261+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:231,0.309933,-0.082081,9.801408
06-07 18:35:05.261+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.271+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.271+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:270,0.070000,0.070000,0.140000
06-07 18:35:05.271+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:277,0.315853,-0.088534,9.817751
06-07 18:35:05.271+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.281+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.281+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:276,0.307565,-0.081969,9.801483
06-07 18:35:05.281+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:288,0.334995,-0.088534,9.844072
06-07 18:35:05.281+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:282,0.070000,0.140000,0.070000
06-07 18:35:05.281+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.291+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:269,0.032216,0.000614,0.047375
06-07 18:35:05.291+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.291+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.291+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.291+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:294,0.070000,0.140000,0.070000
06-07 18:35:05.291+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.291+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:300,0.275175,-0.083749,9.853643
06-07 18:35:05.301+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:306,0.140000,0.070000,0.070000
06-07 18:35:05.301+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.301+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.311+0200 I/heartrate(28387): es.ugr.frailty.heartrate - capturing data
06-07 18:35:05.311+0200 I/heartrate(28387): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:35:05.311+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:301,0.308230,-0.081610,9.801465
06-07 18:35:05.311+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.311+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:311,0.339781,-0.081356,9.848858
06-07 18:35:05.311+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:299,0.007622,-0.006924,0.059358
06-07 18:35:05.311+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.311+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.321+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:315,0.140000,0.070000,0.070000
06-07 18:35:05.321+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:324,0.315853,-0.088534,9.860823
06-07 18:35:05.321+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.321+0200 I/light   (28441): es.ugr.frailty.light - capturing data
06-07 18:35:05.331+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.331+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:330,0.070000,0.070000,0.070000
06-07 18:35:05.331+0200 I/light   (28441): es.ugr.frailty.light: SM-R760,07/06/2018,18:35:05:335,1492.000000
06-07 18:35:05.331+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.331+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:321,0.307787,-0.081592,9.801479
06-07 18:35:05.331+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:341,0.070000,0.070000,0.070000
06-07 18:35:05.341+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:336,0.342174,-0.090927,9.870394
06-07 18:35:05.341+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.341+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.341+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:324,0.034386,-0.009335,0.068914
06-07 18:35:05.351+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:348,0.320638,-0.090927,9.815358
06-07 18:35:05.351+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.351+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.351+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:351,0.070000,0.070000,0.070000
06-07 18:35:05.351+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.351+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.361+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:356,0.308858,-0.081838,9.801443
06-07 18:35:05.361+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.361+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:360,0.320638,-0.045464,9.846465
06-07 18:35:05.361+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.361+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:363,0.070000,0.070000,0.070000
06-07 18:35:05.371+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.371+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:376,0.070000,0.070000,0.070000
06-07 18:35:05.371+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:374,0.325424,-0.083749,9.812965
06-07 18:35:05.371+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.381+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:363,0.011780,-0.009090,0.013915
06-07 18:35:05.381+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.381+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:385,0.339781,-0.124427,9.858429
06-07 18:35:05.381+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.391+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:393,0.140000,0.070000,0.070000
06-07 18:35:05.391+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.391+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 18:35:05.391+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 18:35:05.391+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:369,0.308972,-0.082093,9.801437
06-07 18:35:05.391+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.391+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:398,0.325424,-0.045464,9.844072
06-07 18:35:05.401+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:387,0.011666,0.036629,0.045028
06-07 18:35:05.401+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.411+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.411+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:416,0.070000,0.070000,0.070000
06-07 18:35:05.411+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.411+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:403,0.308918,-0.080163,9.801455
06-07 18:35:05.411+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:421,0.311067,-0.055035,9.829715
06-07 18:35:05.421+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.421+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:427,0.309226,-0.080160,9.801446
06-07 18:35:05.421+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.421+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.431+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:433,0.070000,0.070000,0.070000
06-07 18:35:05.431+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:406,0.016506,-0.003586,0.011510
06-07 18:35:05.431+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:435,0.330210,-0.110070,9.839286
06-07 18:35:05.431+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.431+0200 I/LOCATION(28403): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-07 18:35:05.441+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.441+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.441+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.451+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:452,0.140000,0.070000,0.070000
06-07 18:35:05.451+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:442,0.030555,-0.044266,0.056983
06-07 18:35:05.451+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:455,0.334995,-0.088534,9.839286
06-07 18:35:05.451+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.461+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:450,0.310415,-0.082014,9.801393
06-07 18:35:05.461+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.461+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.461+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.471+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:472,0.140000,0.070000,0.070000
06-07 18:35:05.471+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:463,0.015009,0.036550,0.042680
06-07 18:35:05.471+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.481+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:468,0.310207,-0.079943,9.801416
06-07 18:35:05.481+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.481+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:474,0.327817,-0.107677,9.829715
06-07 18:35:05.481+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:486,0.309726,-0.078566,9.801443
06-07 18:35:05.481+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.481+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.491+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:492,0.140000,0.070000,0.070000
06-07 18:35:05.491+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:484,0.000860,0.024908,0.028298
06-07 18:35:05.491+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.491+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.491+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:496,0.344566,-0.059821,9.839286
06-07 18:35:05.501+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:499,0.020483,-0.031504,0.037843
06-07 18:35:05.501+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.501+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:503,0.310342,-0.079854,9.801413
06-07 18:35:05.501+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.501+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.511+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:513,0.140000,0.070000,0.070000
06-07 18:35:05.511+0200 I/heartrate(28387): es.ugr.frailty.heartrate - capturing data
06-07 18:35:05.511+0200 I/heartrate(28387): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:35:05.511+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.511+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:509,0.024653,-0.008681,0.037873
06-07 18:35:05.511+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:512,0.310717,-0.079928,9.801400
06-07 18:35:05.521+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.521+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:523,0.334995,-0.095713,9.832108
06-07 18:35:05.521+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.521+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:527,0.017100,-0.027749,0.028315
06-07 18:35:05.521+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.521+0200 I/light   (28441): es.ugr.frailty.light - capturing data
06-07 18:35:05.531+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:534,0.070000,0.070000,0.070000
06-07 18:35:05.531+0200 I/light   (28441): es.ugr.frailty.light: SM-R760,07/06/2018,18:35:05:536,1494.000000
06-07 18:35:05.531+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.531+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.541+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:529,0.310872,-0.080897,9.801388
06-07 18:35:05.541+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.541+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:542,0.033695,0.021076,0.037898
06-07 18:35:05.541+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.551+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:553,-0.070000,0.070000,0.070000
06-07 18:35:05.551+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.551+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:547,0.311471,-0.079589,9.801379
06-07 18:35:05.551+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:542,0.291924,-0.059821,9.827322
06-07 18:35:05.551+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.551+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.551+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:560,0.023525,-0.016124,0.030729
06-07 18:35:05.561+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:566,0.311850,-0.080014,9.801364
06-07 18:35:05.561+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.561+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.571+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:566,0.334995,-0.112463,9.834501
06-07 18:35:05.571+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:572,-0.070000,0.070000,0.070000
06-07 18:35:05.571+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.571+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.571+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:571,-0.019926,0.020194,0.025958
06-07 18:35:05.581+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.581+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:587,0.024544,-0.033613,0.033084
06-07 18:35:05.581+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:582,0.310451,-0.078849,9.801417
06-07 18:35:05.581+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.581+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.591+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:593,-0.070000,0.070000,0.070000
06-07 18:35:05.591+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:585,0.315853,-0.083749,9.812965
06-07 18:35:05.591+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 18:35:05.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 18:35:05.591+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.591+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:592,0.311877,-0.080539,9.801358
06-07 18:35:05.601+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:602,0.003976,-0.003210,0.011607
06-07 18:35:05.601+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.601+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:603,0.308674,-0.047856,9.815358
06-07 18:35:05.601+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.611+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:612,-0.070000,0.070000,0.070000
06-07 18:35:05.611+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.611+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.611+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:608,0.312178,-0.080822,9.801347
06-07 18:35:05.611+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.621+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:621,-0.003504,0.032966,0.014011
06-07 18:35:05.621+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.631+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:634,0.070000,0.070000,0.070000
06-07 18:35:05.631+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:625,0.306281,-0.074178,9.889536
06-07 18:35:05.631+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.631+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.631+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:627,0.312134,-0.079359,9.801360
06-07 18:35:05.641+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.641+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:640,-0.005853,0.005181,0.088176
06-07 18:35:05.641+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.651+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:640,0.334995,-0.064606,9.817751
06-07 18:35:05.651+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:655,0.070000,0.070000,0.070000
06-07 18:35:05.651+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.651+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.661+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:647,0.311861,-0.079212,9.801370
06-07 18:35:05.661+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.661+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:662,0.023134,0.014606,0.016381
06-07 18:35:05.661+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.661+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:662,0.337388,-0.069392,9.824929
06-07 18:35:05.671+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.671+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:674,0.070000,0.070000,0.070000
06-07 18:35:05.671+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.671+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:668,0.312379,-0.078357,9.801360
06-07 18:35:05.671+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.681+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:680,0.025009,0.008965,0.023569
06-07 18:35:05.681+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:676,0.332602,-0.059821,9.810574
06-07 18:35:05.681+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.681+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.691+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.691+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:694,0.070000,0.070000,0.070000
06-07 18:35:05.691+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:685,0.312986,-0.077766,9.801346
06-07 18:35:05.691+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.691+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:697,0.323031,-0.086142,9.810574
06-07 18:35:05.701+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:692,0.019616,0.017945,0.009228
06-07 18:35:05.701+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:703,0.313340,-0.076751,9.801342
06-07 18:35:05.701+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.701+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.701+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.711+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.711+0200 I/heartrate(28387): es.ugr.frailty.heartrate - capturing data
06-07 18:35:05.711+0200 I/heartrate(28387): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:35:05.711+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:717,-0.070000,0.070000,0.070000
06-07 18:35:05.711+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:714,0.308674,-0.100499,9.865608
06-07 18:35:05.721+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:725,0.313340,-0.077024,9.801340
06-07 18:35:05.721+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:710,0.009691,-0.009391,0.009232
06-07 18:35:05.721+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.721+0200 I/light   (28441): es.ugr.frailty.light - capturing data
06-07 18:35:05.721+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.731+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.731+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:735,0.070000,0.070000,0.070000
06-07 18:35:05.731+0200 I/light   (28441): es.ugr.frailty.light: SM-R760,07/06/2018,18:35:05:735,1496.000000
06-07 18:35:05.731+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.731+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:738,0.311067,-0.105284,9.812965
06-07 18:35:05.741+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:732,-0.004666,-0.023475,0.064268
06-07 18:35:05.741+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.741+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.741+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.751+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:754,0.070000,0.070000,0.070000
06-07 18:35:05.751+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:744,0.313194,-0.078252,9.801335
06-07 18:35:05.751+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:753,0.318245,-0.069392,9.822537
06-07 18:35:05.751+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.761+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:763,0.312672,-0.079363,9.801343
06-07 18:35:05.761+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:752,-0.002127,-0.027033,0.011630
06-07 18:35:05.761+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.761+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.761+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.771+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:773,0.070000,0.140000,0.070000
06-07 18:35:05.771+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:773,0.289532,-0.117248,9.808180
06-07 18:35:05.771+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.781+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:783,0.312425,-0.078711,9.801356
06-07 18:35:05.781+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.781+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:769,0.005573,0.009971,0.021194
06-07 18:35:05.781+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.781+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.791+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:793,0.070000,0.140000,0.070000
06-07 18:35:05.791+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:793,0.342174,-0.081356,9.810574
06-07 18:35:05.791+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:788,0.310694,-0.080383,9.801397
06-07 18:35:05.791+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 18:35:05.791+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 18:35:05.791+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.791+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.801+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:801,0.311521,-0.080246,9.801373
06-07 18:35:05.801+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:802,-0.022893,-0.038537,0.006824
06-07 18:35:05.801+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.801+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.811+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.811+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.811+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:816,0.070000,0.070000,0.070000
06-07 18:35:05.821+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.831+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:835,0.140000,0.070000,0.070000
06-07 18:35:05.841+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.851+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:853,0.140000,0.070000,0.070000
06-07 18:35:05.861+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:813,0.344566,-0.064606,9.822537
06-07 18:35:05.861+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.861+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:05.881+0200 W/libgps_d( 3131): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
06-07 18:35:05.881+0200 W/libgps  ( 3131): [proxy__gps_stop][line = 1067]: called.
06-07 18:35:05.881+0200 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
06-07 18:35:05.881+0200 W/libgps_d( 3131): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-07 18:35:05.881+0200 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
06-07 18:35:05.881+0200 W/libgps_d( 3131): GpsiHookStateGps              : EXIT
06-07 18:35:05.881+0200 W/libgps_d( 3131): GpsiHookStateIdle             : ENTRY
06-07 18:35:05.881+0200 E/CAPI_LOCATION_MANAGER( 3823): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-07 18:35:05.881+0200 W/gpsd    ( 3111): HandleIncomingMessage() dest id:0, msg id:2
06-07 18:35:05.891+0200 W/AUL     (28483): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-07 18:35:05.891+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 23
06-07 18:35:05.891+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-07 18:35:05.891+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 27780
06-07 18:35:05.891+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 18:35:05.901+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 27780
06-07 18:35:05.901+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(27780)
06-07 18:35:05.911+0200 I/heartrate(28387): es.ugr.frailty.heartrate - capturing data
06-07 18:35:05.911+0200 I/heartrate(28387): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:35:05.921+0200 I/gyroscope(28373): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:05:873,0.070000,0.070000,0.070000
06-07 18:35:05.921+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:05:869,0.294317,-0.083749,9.860823
06-07 18:35:05.931+0200 I/light   (28441): es.ugr.frailty.light - capturing data
06-07 18:35:05.931+0200 I/light   (28441): es.ugr.frailty.light: SM-R760,07/06/2018,18:35:05:940,1499.000000
06-07 18:35:05.951+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:822,0.312454,-0.079351,9.801350
06-07 18:35:05.951+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.961+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:810,0.031480,-0.000973,0.009176
06-07 18:35:05.961+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.961+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:966,0.033046,0.015640,0.021165
06-07 18:35:05.961+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:959,0.310738,-0.079225,9.801406
06-07 18:35:05.961+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.971+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:05.971+0200 I/accelerometer(28370): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:05.971+0200 I/gravity (28425): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:05:973,0.309845,-0.078422,9.801440
06-07 18:35:05.981+0200 I/gravity (28425): es.ugr.frailty.gravity - capturing data
06-07 18:35:05.981+0200 I/linearacceleration(28412): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:05:978,-0.018136,-0.004398,0.059473
06-07 18:35:05.991+0200 W/CRASH_MANAGER(28485): worker.c: worker_job(1205) > 11284036c6f63152838930
