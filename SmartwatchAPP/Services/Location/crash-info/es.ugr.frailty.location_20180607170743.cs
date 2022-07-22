S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 16326
Date: 2018-06-07 17:07:43+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf71b252d, r5   = 0xf7709f98
r6   = 0xffd4d000, r7   = 0xffd4ceb0
r8   = 0xf7706c18, r9   = 0x00000000
r10  = 0xffd4cf8c, fp   = 0xffd4d000
ip   = 0x00000001, sp   = 0xffd4ce88
lr   = 0xf71b2539, pc   = 0xf721b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     78364 KB
Buffers:      7608 KB
Cached:      50772 KB
VmPeak:      53520 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11500 KB
VmRSS:       11496 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 16326 TID = 16326
16326 16334 

Maps Information
f407d000 f487c000 rw-p [stack:16334]
f4883000 f4885000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f488d000 f4891000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f489a000 f489c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f48a4000 f48a7000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f48b6000 f48bb000 r-xp /usr/lib/libsystem.so.0.0.0
f48c6000 f48c9000 r-xp /lib/libattr.so.1.1.0
f48d1000 f48e1000 r-xp /usr/lib/libmdm-common.so.1.1.24
f48e9000 f48f2000 r-xp /usr/lib/libedbus.so.1.7.99
f48fa000 f48fb000 r-xp /usr/lib/libresponse.so.0.2.96
f4904000 f4909000 r-xp /usr/lib/libproc-stat.so.0.2.96
f61ab000 f62b1000 r-xp /usr/lib/libicuuc.so.57.1
f62c7000 f644f000 r-xp /usr/lib/libicui18n.so.57.1
f645f000 f646c000 r-xp /usr/lib/libail.so.0.1.0
f6475000 f647c000 r-xp /usr/lib/libminizip.so.1.0.0
f6485000 f662e000 r-xp /usr/lib/libcrypto.so.1.0.0
f664e000 f6695000 r-xp /usr/lib/libssl.so.1.0.0
f66a1000 f66a3000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f66ab000 f66b2000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f66bb000 f66c2000 r-xp /lib/libcrypt-2.13.so
f66f3000 f66f6000 r-xp /lib/libcap.so.2.21
f66fe000 f6700000 r-xp /usr/lib/libiri.so
f6708000 f6751000 r-xp /usr/lib/libmdm.so.1.2.69
f6759000 f675f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6767000 f678a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6794000 f6796000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f679e000 f67bb000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f67c4000 f67c8000 r-xp /usr/lib/libsmack.so.1.0.0
f67d1000 f67ea000 r-xp /usr/lib/libnetwork.so.0.0.0
f67f3000 f67fb000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6803000 f6809000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6812000 f6814000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f681d000 f682d000 r-xp /lib/libresolv-2.13.so
f6831000 f6849000 r-xp /usr/lib/liblzma.so.5.0.3
f6852000 f6854000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f685c000 f6876000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f687e000 f68ad000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68b6000 f68c5000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f68cf000 f68d9000 r-xp /usr/lib/libsensord-shared.so
f68e2000 f69b5000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f69c0000 f69d6000 r-xp /lib/libz.so.1.2.5
f69de000 f69e3000 r-xp /usr/lib/libffi.so.5.0.10
f69eb000 f69ec000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f69f4000 f6a04000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a0c000 f6a25000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a2d000 f6a2f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a37000 f6aac000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ab6000 f6abc000 r-xp /lib/librt-2.13.so
f6ac5000 f6ae3000 r-xp /usr/lib/libsystemd.so.0.4.0
f6aed000 f6aee000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6af6000 f6b19000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b21000 f6b26000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b2e000 f6b58000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b61000 f6b78000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b80000 f6be9000 r-xp /lib/libm-2.13.so
f6bf2000 f6c86000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c99000 f6c9e000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ca6000 f6cad000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6cb5000 f6cdf000 r-xp /usr/lib/libsensor.so.1.9.6
f6ce8000 f6db4000 r-xp /usr/lib/libxml2.so.2.7.8
f6dc1000 f6dc3000 r-xp /usr/lib/libiniparser.so.0
f6dcc000 f6dd2000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ddb000 f6eab000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6eac000 f6ee0000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ee9000 f6f25000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f2d000 f6f30000 r-xp /usr/lib/libbundle.so.0.1.22
f6f38000 f6f3e000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f46000 f6f87000 r-xp /usr/lib/libeina.so.1.7.99
f6f90000 f6fa7000 r-xp /usr/lib/libecore.so.1.7.99
f6fbe000 f6fc7000 r-xp /usr/lib/libvconf.so.0.2.45
f6fcf000 f6fe3000 r-xp /lib/libpthread-2.13.so
f6fee000 f6ffb000 r-xp /usr/lib/libaul.so.0.1.0
f7005000 f7007000 r-xp /lib/libdl-2.13.so
f7010000 f701b000 r-xp /lib/libunwind.so.8.0.1
f7048000 f7050000 r-xp /lib/libgcc_s-4.6.so.1
f7051000 f7175000 r-xp /lib/libc-2.13.so
f7183000 f7185000 r-xp /usr/lib/libdlog.so.0.0.0
f718d000 f7199000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71a2000 f71a7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f71af000 f71be000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f71c6000 f71ca000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f71d3000 f71d6000 r-xp /usr/lib/libappcore-agent.so.1.1
f71de000 f71e0000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f71e8000 f71ec000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f71f4000 f7211000 r-xp /lib/ld-2.13.so
f721a000 f721d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f721d000 f7221000 r-xp /usr/lib/libsys-assert.so
f76d6000 f7747000 rw-p [heap]
ffd2e000 ffd4f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16326)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf721b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf71b2539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6eb93f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6eb7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6ec3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6ec9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6ec9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6efe75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6ef91f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6eb7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6ec3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6ec9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6ec9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6efbe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6efc017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f03f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf489b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf488e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6961663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e0efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e107a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6fa0ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f9bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f9c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f9c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf71d4183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71d47fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf721b5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf706885c) [/lib/libc.so.6] + 0x1785c
29: (0xf721af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
0.361148,2.000777
06-07 17:07:42.431+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.441+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:438,9.688539,0.423530,1.744368
06-07 17:07:42.441+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:445,0.910000,-1.050000,6.720000
06-07 17:07:42.441+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.441+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:451,9.657433,0.425922,1.976472
06-07 17:07:42.451+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.451+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.451+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:434,0.592813,0.199781,-1.999480
06-07 17:07:42.451+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.451+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:460,0.439621,0.398579,-1.489283
06-07 17:07:42.451+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.461+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:458,-1.890000,-2.380000,6.790000
06-07 17:07:42.461+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:460,9.676575,0.404387,1.830509
06-07 17:07:42.461+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.461+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.471+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:470,9.736395,0.275175,1.672583
06-07 17:07:42.471+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:445,9.607521,0.352170,1.934401
06-07 17:07:42.471+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.471+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.471+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:472,-3.850000,-0.490000,7.210000
06-07 17:07:42.471+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:479,9.620114,0.340173,1.872985
06-07 17:07:42.471+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.481+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.481+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:465,0.348570,0.644888,-1.234243
06-07 17:07:42.481+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:480,9.645468,0.294317,1.799403
06-07 17:07:42.481+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.481+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:487,-1.470000,-0.980000,6.930000
06-07 17:07:42.481+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:490,0.226315,0.435690,-1.027130
06-07 17:07:42.481+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.481+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.491+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:494,9.664611,0.368495,1.952543
06-07 17:07:42.491+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.491+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.501+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:483,9.629811,0.329091,1.824507
06-07 17:07:42.501+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.501+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:501,-1.120000,-2.660000,8.050000
06-07 17:07:42.501+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:507,9.638478,0.315853,1.780550
06-07 17:07:42.501+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.501+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:506,9.829715,0.246461,1.220340
06-07 17:07:42.501+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:511,9.647738,0.300379,1.732433
06-07 17:07:42.511+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:07:42.511+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:07:42:518,330.000000
06-07 17:07:42.511+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.521+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.521+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:495,0.213406,0.151688,-0.707345
06-07 17:07:42.521+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.521+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:524,-3.080000,-1.050000,8.890000
06-07 17:07:42.521+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:528,0.223618,0.268492,-0.812042
06-07 17:07:42.521+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:526,9.949356,0.265603,1.416551
06-07 17:07:42.521+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.521+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.531+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.531+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:538,9.824929,0.306281,1.741975
06-07 17:07:42.531+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:541,-5.740000,1.050000,8.820000
06-07 17:07:42.541+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.541+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.541+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.541+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:545,9.656771,0.279416,1.684963
06-07 17:07:42.541+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.541+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:548,9.662218,0.179462,2.349752
06-07 17:07:42.541+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:549,9.665339,0.259646,1.638348
06-07 17:07:42.541+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.551+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:533,0.184323,0.384019,-0.919705
06-07 17:07:42.551+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.551+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.551+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:559,0.152466,0.392379,-0.693055
06-07 17:07:42.551+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:553,-5.460000,-1.190000,9.030000
06-07 17:07:42.551+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:07:42.561+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:07:42:564,80
06-07 17:07:42.561+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.561+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:559,9.430114,-0.148355,2.522035
06-07 17:07:42.571+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.571+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:553,9.671473,0.244341,1.604151
06-07 17:07:42.571+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.571+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:576,9.444471,-0.461815,2.251646
06-07 17:07:42.571+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:577,9.681697,0.223927,1.544342
06-07 17:07:42.571+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.571+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:571,-8.400000,-2.030000,8.610000
06-07 17:07:42.571+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:580,9.688823,0.203602,1.501879
06-07 17:07:42.571+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.571+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.581+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.581+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.581+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:586,0.050212,0.284178,-0.299339
06-07 17:07:42.581+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.581+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:590,9.736395,-0.272782,1.548156
06-07 17:07:42.581+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:591,0.074476,0.108445,-0.279029
06-07 17:07:42.591+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:585,-13.860000,0.140000,8.400000
06-07 17:07:42.591+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.591+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.591+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:600,-21.980000,1.190000,8.400000
06-07 17:07:42.601+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:604,9.801002,-0.045464,1.459622
06-07 17:07:42.601+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:584,9.693508,0.186307,1.473624
06-07 17:07:42.601+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.601+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.601+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.601+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:608,9.700357,0.160737,1.430947
06-07 17:07:42.601+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.611+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:615,-24.150000,-1.540000,7.910000
06-07 17:07:42.611+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:611,9.454042,-0.480957,1.545763
06-07 17:07:42.611+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.621+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.621+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:623,9.741181,-0.803988,1.430908
06-07 17:07:42.621+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.621+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:626,0.098404,0.111082,-0.412019
06-07 17:07:42.621+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.621+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:630,-20.580000,-8.050000,9.590000
06-07 17:07:42.621+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:631,0.051884,0.064774,-0.455014
06-07 17:07:42.631+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:612,9.712877,0.122255,1.347391
06-07 17:07:42.631+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.631+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.631+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:636,9.728636,0.078771,1.232000
06-07 17:07:42.631+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.631+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:638,9.779467,-0.114855,1.466800
06-07 17:07:42.631+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.631+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:640,9.747442,0.037714,1.075325
06-07 17:07:42.631+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.641+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:643,-16.030001,-11.900000,9.870000
06-07 17:07:42.641+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.641+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:650,-12.880000,-9.870000,6.650000
06-07 17:07:42.641+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.651+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.651+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.651+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:656,0.081017,0.071359,-0.190034
06-07 17:07:42.651+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.651+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:659,9.597611,-0.303888,1.347159
06-07 17:07:42.651+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:661,0.037318,0.085749,0.103486
06-07 17:07:42.661+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:655,-24.639999,-4.060000,8.540000
06-07 17:07:42.661+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.661+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:668,-30.520000,-6.160000,11.270000
06-07 17:07:42.661+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.671+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:674,-20.860001,-7.420000,7.840000
06-07 17:07:42.671+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:644,9.768754,0.002638,0.861292
06-07 17:07:42.671+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.671+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.671+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.671+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:678,9.798984,-0.042301,0.385373
06-07 17:07:42.671+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.681+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.681+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:683,9.686146,-0.464208,1.337588
06-07 17:07:42.681+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:686,0.046763,0.075296,0.006003
06-07 17:07:42.681+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:680,-17.010000,-0.350000,7.350000
06-07 17:07:42.681+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.681+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.681+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:691,0.097917,-0.040678,-0.107967
06-07 17:07:42.691+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.691+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:697,9.753145,-0.868595,1.517050
06-07 17:07:42.691+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:693,-15.680000,0.910000,6.510000
06-07 17:07:42.691+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.701+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:682,9.697216,-0.090205,-1.458167
06-07 17:07:42.701+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.701+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:705,-16.379999,-1.260000,6.370000
06-07 17:07:42.701+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:708,9.451752,-0.093544,-2.612667
06-07 17:07:42.701+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.701+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.711+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.711+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:07:42.711+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:712,8.760118,-0.115683,4.406509
06-07 17:07:42.711+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.711+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.711+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:720,9.259430,-0.161957,3.226007
06-07 17:07:42.711+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.721+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:07:42:720,320.000000
06-07 17:07:42.721+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:716,-0.002270,-0.006062,0.066970
06-07 17:07:42.721+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:721,9.722038,-0.823131,1.773082
06-07 17:07:42.721+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:713,-12.810000,1.820000,6.510000
06-07 17:07:42.731+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.731+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.731+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.731+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:737,0.007840,0.089079,0.267581
06-07 17:07:42.731+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:738,9.678967,-0.844666,1.507478
06-07 17:07:42.731+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.741+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:736,-3.220000,5.250000,4.130000
06-07 17:07:42.741+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:724,9.437425,-0.207959,2.657471
06-07 17:07:42.741+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.751+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.751+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:743,0.164375,-0.013185,-0.418008
06-07 17:07:42.751+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.751+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.751+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:759,0.277884,0.021262,-0.187600
06-07 17:07:42.751+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:759,9.645468,-0.521635,1.548156
06-07 17:07:42.751+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:07:42.761+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.761+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:07:42:764,79
06-07 17:07:42.761+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:765,0.143232,0.082354,0.197633
06-07 17:07:42.761+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.761+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:770,-0.026605,-0.024141,0.847873
06-07 17:07:42.771+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:753,9.485289,-0.237180,2.478595
06-07 17:07:42.771+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.771+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:777,9.524225,-0.264765,2.321513
06-07 17:07:42.771+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.781+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.781+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:783,9.719646,-0.361316,1.732404
06-07 17:07:42.781+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:771,6.650000,6.090000,0.910000
06-07 17:07:42.781+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:786,-0.263394,-0.334662,1.048411
06-07 17:07:42.781+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.781+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.781+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:791,-0.255886,-0.622552,0.820699
06-07 17:07:42.791+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.791+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.791+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:797,9.710074,0.244068,1.823331
06-07 17:07:42.791+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:801,9.535153,-0.275118,2.274983
06-07 17:07:42.801+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:791,9.660000,5.670000,-0.140000
06-07 17:07:42.801+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.801+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.801+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:809,13.020000,5.740000,-0.140000
06-07 17:07:42.811+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.811+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.811+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:816,0.023518,-0.395037,0.200766
06-07 17:07:42.811+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.811+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:817,9.621540,0.485743,1.756332
06-07 17:07:42.811+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.811+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:821,0.072366,-0.124235,0.227622
06-07 17:07:42.821+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:812,9.527232,-0.274127,2.308046
06-07 17:07:42.821+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.821+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:826,9.489408,-0.253633,2.461135
06-07 17:07:42.821+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:830,20.719999,8.190000,-0.630000
06-07 17:07:42.831+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.831+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.831+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.831+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:836,-0.293400,-0.518671,0.470439
06-07 17:07:42.831+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.831+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:839,9.540184,-0.928415,0.478565
06-07 17:07:42.831+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.831+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:841,-0.027573,-0.806627,0.569616
06-07 17:07:42.841+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:844,9.403283,-0.232601,2.773905
06-07 17:07:42.841+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:836,11.900000,8.400000,3.080000
06-07 17:07:42.841+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.851+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.851+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.851+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:857,-0.019517,-0.072554,1.081428
06-07 17:07:42.851+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.851+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.851+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:861,9.531869,-0.282789,2.287769
06-07 17:07:42.861+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:858,10.045070,-0.646062,1.433301
06-07 17:07:42.861+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:854,7.630000,5.950000,8.470000
06-07 17:07:42.861+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.861+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:871,8.820000,12.530000,1.750000
06-07 17:07:42.871+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:862,-0.099605,-0.213683,2.805326
06-07 17:07:42.871+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.871+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:877,0.234394,-0.370664,3.950255
06-07 17:07:42.871+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.871+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.871+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.881+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:883,9.918249,-0.535992,1.414158
06-07 17:07:42.881+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:887,9.542398,-0.299552,2.241268
06-07 17:07:42.881+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:42.891+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:42:892,13.370000,15.540000,0.070000
06-07 17:07:42.891+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:882,0.993027,-0.752911,-2.889459
06-07 17:07:42.891+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:42.891+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.891+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.891+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:897,0.462608,-0.661174,-1.452925
06-07 17:07:42.891+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.901+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:904,0.241543,-0.636708,-1.149993
06-07 17:07:42.911+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.921+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:919,0.160179,-0.284456,-0.930438
06-07 17:07:42.931+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.941+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:07:42.941+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:935,0.195420,-0.096551,-0.589109
06-07 17:07:42.941+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.951+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:950,0.174921,0.519186,-0.451652
06-07 17:07:42.951+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:42.961+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:07:42.981+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:976,9.458827,-0.165105,2.268396
06-07 17:07:42.981+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:42.981+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:991,9.420543,-0.296710,2.565106
06-07 17:07:42.981+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:43.001+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:07:42:970,79
06-07 17:07:43.001+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:42:898,9.555156,-0.310296,2.184741
06-07 17:07:43.001+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:43.001+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:07:42:972,321.000000
06-07 17:07:43.011+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:42:962,0.094308,0.759870,-0.551714
06-07 17:07:43.011+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:43.021+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:43:9,9.548478,-0.306686,2.214249
06-07 17:07:43.021+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:43.031+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:43.031+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:42:995,9.645468,-0.624527,2.440679
06-07 17:07:43.031+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:43.041+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:43:34,9.542403,-0.306602,2.240293
06-07 17:07:43.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:07:43.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:07:43.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:07:43.071+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:43:35,4.690000,15.190001,-1.120000
06-07 17:07:43.071+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:43.071+0200 W/LOCATION(16326): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:07:43.081+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:43.081+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:43:86,9.538811,-0.315852,2.254266
06-07 17:07:43.081+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:43.091+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:43:41,9.623933,-0.760918,1.856830
06-07 17:07:43.091+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:43.101+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:43:20,0.050776,-0.674782,-1.982570
06-07 17:07:43.101+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:43.101+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:43:107,0.641787,-0.413461,-1.340604
06-07 17:07:43.111+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:43:77,0.490000,4.130000,1.260000
06-07 17:07:43.111+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:07:43.111+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:43.111+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:43:118,0.980000,2.310000,0.140000
06-07 17:07:43.111+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:07:43:118,328.000000
06-07 17:07:43.111+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:43.131+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:43:90,9.539027,-0.329443,2.251401
06-07 17:07:43.131+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:43.131+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:43.141+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:43:100,9.626326,-0.911665,1.560120
06-07 17:07:43.141+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:43.141+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:43:143,0.386380,-0.253203,-0.873611
06-07 17:07:43.141+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:43.151+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:43:147,9.717253,-0.837488,1.902294
06-07 17:07:43.151+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:43.151+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:07:43.161+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:43:142,9.543628,-0.342561,2.229845
06-07 17:07:43.161+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:43.161+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:07:43:165,79
06-07 17:07:43.161+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:43:166,9.529945,-0.336776,2.288472
06-07 17:07:43.161+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:43.171+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:43:123,6.160000,6.090000,-1.750000
06-07 17:07:43.181+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:43:154,-0.083571,0.134447,0.027128
06-07 17:07:43.181+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:43:162,9.676575,-0.894916,1.919044
06-07 17:07:43.181+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:43.191+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:43.201+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:43.201+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:43:170,9.508276,-0.312537,2.380208
06-07 17:07:43.201+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:43:201,17.780001,8.890000,-2.100000
06-07 17:07:43.201+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:43.211+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:43:206,-0.134613,0.013586,0.380365
06-07 17:07:43.211+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:43:212,9.484499,-0.273421,2.477884
06-07 17:07:43.221+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:43.221+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:43:192,9.741181,-0.535992,2.009971
06-07 17:07:43.221+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:43.221+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:43.221+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:43:229,31.080000,11.060000,-4.830000
06-07 17:07:43.221+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:43.231+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:43:227,9.442912,-0.194021,2.638967
06-07 17:07:43.231+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:43.241+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:43:239,9.322018,-0.113470,3.042614
06-07 17:07:43.241+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:43:227,9.798609,0.803988,1.907080
06-07 17:07:43.241+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:43.241+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:43.241+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:43.251+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:43:250,9.233967,-0.066364,3.301491
06-07 17:07:43.251+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:43:234,0.096990,-0.317841,0.226430
06-07 17:07:43.251+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:43.251+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:43.261+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:43:247,9.509077,1.110270,1.105484
06-07 17:07:43.261+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:43.261+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:43:261,9.403111,-0.049586,2.783780
06-07 17:07:43.261+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:43:267,9.473185,0.672383,1.691726
06-07 17:07:43.261+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:43.261+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:43.261+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:43:270,9.688539,-0.102891,2.462214
06-07 17:07:43.261+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:43.271+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:43:252,58.590000,13.370000,-7.910000
06-07 17:07:43.271+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:43:271,9.535461,-0.040901,2.289911
06-07 17:07:43.271+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:43.271+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:43:261,0.085122,-0.445066,-0.397436
06-07 17:07:43.281+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:43.281+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:43.291+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:43:286,88.830002,17.500000,-14.770000
06-07 17:07:43.291+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:43:287,0.087515,-0.595814,-0.694146
06-07 17:07:43.291+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:43:289,9.722058,-0.001337,1.285291
06-07 17:07:43.291+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:43.291+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:43.301+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:43.301+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:43:275,9.674182,-0.466600,2.955136
06-07 17:07:43.301+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:43.301+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:43:309,9.757157,0.035787,-0.983357
06-07 17:07:43.311+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:07:43.311+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:43:300,0.178226,-0.508045,-0.349107
06-07 17:07:43.311+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:43.311+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:07:43:319,343.000000
06-07 17:07:43.321+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:43:309,9.446864,0.406780,2.931208
06-07 17:07:43.321+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:43.321+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:43:306,75.669998,27.020000,-16.170000
06-07 17:07:43.321+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:43.331+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:43.331+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:43:321,0.132947,-0.552355,-0.310801
06-07 17:07:43.331+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:43:335,9.743708,0.047833,-1.108265
06-07 17:07:43.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:07:43.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:07:43.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:07:43.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:07:43.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:07:43.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:07:43.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:07:43.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:07:43.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:07:43.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:07:43.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:07:43.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:07:43.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391263350,000000, pattern:[H:mm][0;m
06-07 17:07:43.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:07:43.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:07:43.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:07:43.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:07:43.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:07:43.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:07][0;m
06-07 17:07:43.351+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:43:329,9.296116,0.708275,2.828316
06-07 17:07:43.351+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:43.351+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:43.361+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:07:43.361+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:43:356,9.317651,0.105284,2.835495
06-07 17:07:43.371+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:43:361,0.211236,-0.199216,-0.278501
06-07 17:07:43.371+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:43.381+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:07:43:374,79
06-07 17:07:43.381+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:43.391+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:43:339,32.830002,22.750000,-10.150000
06-07 17:07:43.391+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:43.391+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:43.391+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:43:401,-7.420000,14.980000,-5.740000
06-07 17:07:43.401+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:43.401+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:43:407,-15.330000,13.580000,-5.460000
06-07 17:07:43.401+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:43.411+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:43:413,2.380000,16.379999,-9.520000
06-07 17:07:43.411+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:43:395,9.487542,-0.193819,3.201597
06-07 17:07:43.411+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:43.411+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:43.411+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:43:400,9.738387,0.052568,-1.153879
06-07 17:07:43.421+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:43:421,9.170000,18.129999,-12.110000
06-07 17:07:43.421+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:43:378,0.314110,1.077410,-0.570804
06-07 17:07:43.421+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:43.421+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:43.421+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:43:427,-3.570000,14.700000,-9.730000
06-07 17:07:43.421+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:43.431+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:43.431+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:43:427,9.492328,-0.045464,3.165704
06-07 17:07:43.431+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:43.441+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:43:443,9.351151,0.107677,3.043670
06-07 17:07:43.441+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:43.451+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11163266c6f63152838406
