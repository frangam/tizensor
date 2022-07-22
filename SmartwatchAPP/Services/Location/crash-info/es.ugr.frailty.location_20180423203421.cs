S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 10336
Date: 2018-04-23 20:34:21+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70a652d, r5   = 0xf76bbf98
r6   = 0xffa693e0, r7   = 0xffa69290
r8   = 0xf76b8c18, r9   = 0x00000000
r10  = 0xffa6936c, fp   = 0xffa693e0
ip   = 0x00000001, sp   = 0xffa69268
lr   = 0xf70a6539, pc   = 0xf710f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    109012 KB
Buffers:     36876 KB
Cached:     155788 KB
VmPeak:      53592 KB
VmSize:      53544 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11908 KB
VmRSS:       11908 KB
VmData:      11272 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 10336 TID = 10336
10336 10339 

Maps Information
f3f71000 f4770000 rw-p [stack:10339]
f4777000 f4779000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4781000 f4785000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f478e000 f4790000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4798000 f479b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47aa000 f47af000 r-xp /usr/lib/libsystem.so.0.0.0
f47ba000 f47bd000 r-xp /lib/libattr.so.1.1.0
f47c5000 f47d5000 r-xp /usr/lib/libmdm-common.so.1.1.24
f47dd000 f47e6000 r-xp /usr/lib/libedbus.so.1.7.99
f47ee000 f47ef000 r-xp /usr/lib/libresponse.so.0.2.96
f47f8000 f47fd000 r-xp /usr/lib/libproc-stat.so.0.2.96
f609f000 f61a5000 r-xp /usr/lib/libicuuc.so.57.1
f61bb000 f6343000 r-xp /usr/lib/libicui18n.so.57.1
f6353000 f6360000 r-xp /usr/lib/libail.so.0.1.0
f6369000 f6370000 r-xp /usr/lib/libminizip.so.1.0.0
f6379000 f6522000 r-xp /usr/lib/libcrypto.so.1.0.0
f6542000 f6589000 r-xp /usr/lib/libssl.so.1.0.0
f6595000 f6597000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f659f000 f65a6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65af000 f65b6000 r-xp /lib/libcrypt-2.13.so
f65e7000 f65ea000 r-xp /lib/libcap.so.2.21
f65f2000 f65f4000 r-xp /usr/lib/libiri.so
f65fc000 f6645000 r-xp /usr/lib/libmdm.so.1.2.69
f664d000 f6653000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f665b000 f667e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6688000 f668a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6692000 f66af000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66b8000 f66bc000 r-xp /usr/lib/libsmack.so.1.0.0
f66c5000 f66de000 r-xp /usr/lib/libnetwork.so.0.0.0
f66e7000 f66ef000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f66f7000 f66fd000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6706000 f6708000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6711000 f6721000 r-xp /lib/libresolv-2.13.so
f6725000 f673d000 r-xp /usr/lib/liblzma.so.5.0.3
f6746000 f6748000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6750000 f676a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6772000 f67a1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67aa000 f67b9000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67c3000 f67cd000 r-xp /usr/lib/libsensord-shared.so
f67d6000 f68a9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68b4000 f68ca000 r-xp /lib/libz.so.1.2.5
f68d2000 f68d7000 r-xp /usr/lib/libffi.so.5.0.10
f68df000 f68e0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f68e8000 f68f8000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6900000 f6919000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6921000 f6923000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f692b000 f69a0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69aa000 f69b0000 r-xp /lib/librt-2.13.so
f69b9000 f69d7000 r-xp /usr/lib/libsystemd.so.0.4.0
f69e1000 f69e2000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f69ea000 f6a0d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a15000 f6a1a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a22000 f6a4c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a55000 f6a6c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a74000 f6add000 r-xp /lib/libm-2.13.so
f6ae6000 f6b7a000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b8d000 f6b92000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b9a000 f6ba1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ba9000 f6bd3000 r-xp /usr/lib/libsensor.so.1.9.6
f6bdc000 f6ca8000 r-xp /usr/lib/libxml2.so.2.7.8
f6cb5000 f6cb7000 r-xp /usr/lib/libiniparser.so.0
f6cc0000 f6cc6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ccf000 f6d9f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6da0000 f6dd4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ddd000 f6e19000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e21000 f6e24000 r-xp /usr/lib/libbundle.so.0.1.22
f6e2c000 f6e32000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e3a000 f6e7b000 r-xp /usr/lib/libeina.so.1.7.99
f6e84000 f6e9b000 r-xp /usr/lib/libecore.so.1.7.99
f6eb2000 f6ebb000 r-xp /usr/lib/libvconf.so.0.2.45
f6ec3000 f6ed7000 r-xp /lib/libpthread-2.13.so
f6ee2000 f6eef000 r-xp /usr/lib/libaul.so.0.1.0
f6ef9000 f6efb000 r-xp /lib/libdl-2.13.so
f6f04000 f6f0f000 r-xp /lib/libunwind.so.8.0.1
f6f3c000 f6f44000 r-xp /lib/libgcc_s-4.6.so.1
f6f45000 f7069000 r-xp /lib/libc-2.13.so
f7077000 f7079000 r-xp /usr/lib/libdlog.so.0.0.0
f7081000 f708d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7096000 f709b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70a3000 f70b2000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70ba000 f70be000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70c7000 f70ca000 r-xp /usr/lib/libappcore-agent.so.1.1
f70d2000 f70d4000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f70dc000 f70e0000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f70e8000 f7105000 r-xp /lib/ld-2.13.so
f710e000 f7111000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7111000 f7115000 r-xp /usr/lib/libsys-assert.so
f7688000 f7711000 rw-p [heap]
ffa4a000 ffa6b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10336)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf710f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf70a6539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6dad3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6dabc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6db7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6dbdbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6dbddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6df275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6ded1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6dabc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6db7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6dbdbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6dbddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6defe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6df0017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6df7f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf478f1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4782171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6855663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d02fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d047a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e94ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e8fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e905a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e90879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70c8183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70c87fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf710f53f) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x153f
28: __libc_start_main + 0x114 (0xf6f5c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf710ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.479+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.479+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.479+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.479+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:484,0.031318,9.770349,0.842436
04-23 20:34:20.489+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:484,0.003048,0.013787,-0.022680
04-23 20:34:20.489+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:486,0.035892,9.784252,0.818345
04-23 20:34:20.489+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:488,-0.070000,-0.140000,0.070000
04-23 20:34:20.499+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.499+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.499+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:503,0.033500,9.779467,0.813560
04-23 20:34:20.499+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:504,0.031672,9.770259,0.843463
04-23 20:34:20.499+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.499+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.499+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:34:20.499+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:34:20.509+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:511,0.002181,0.009118,-0.028876
04-23 20:34:20.509+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:510,-0.070000,0.140000,0.070000
04-23 20:34:20.519+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.519+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.519+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:524,0.035892,9.784252,0.792024
04-23 20:34:20.519+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.519+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:524,0.031904,9.770197,0.844165
04-23 20:34:20.519+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.519+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:529,-0.070000,0.070000,0.070000
04-23 20:34:20.529+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:530,0.004220,0.013993,-0.051439
04-23 20:34:20.539+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.539+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.539+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:546,0.032241,9.770255,0.843481
04-23 20:34:20.539+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:546,0.055035,9.772287,0.784846
04-23 20:34:20.549+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.549+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.549+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:553,0.023131,0.002090,-0.059319
04-23 20:34:20.549+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:553,-0.070000,0.070000,0.070000
04-23 20:34:20.559+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.559+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.559+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.559+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:564,0.057428,9.789038,0.820738
04-23 20:34:20.559+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.559+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:564,0.033481,9.770467,0.840977
04-23 20:34:20.569+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:569,0.025187,0.018783,-0.022743
04-23 20:34:20.569+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:563,-0.070000,0.070000,0.070000
04-23 20:34:20.579+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.579+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.579+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.589+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:585,0.034746,9.770459,0.841010
04-23 20:34:20.589+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:588,0.035892,9.793823,0.799203
04-23 20:34:20.589+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:588,-0.070000,0.140000,0.070000
04-23 20:34:20.589+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.589+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:597,0.002412,0.023356,-0.041774
04-23 20:34:20.599+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.599+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.599+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:605,0.028714,9.841680,0.820738
04-23 20:34:20.599+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.599+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:606,-0.070000,0.140000,0.070000
04-23 20:34:20.609+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.609+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:614,-0.006033,0.071220,-0.020272
04-23 20:34:20.619+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.619+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.619+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:623,0.028714,9.757930,0.813560
04-23 20:34:20.619+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.619+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:611,0.034939,9.770453,0.841076
04-23 20:34:20.619+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.629+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:624,0.070000,0.070000,0.070000
04-23 20:34:20.629+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:630,0.034776,9.770376,0.841977
04-23 20:34:20.629+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:629,-0.006225,-0.012524,-0.027517
04-23 20:34:20.639+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.639+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.639+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.639+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:647,0.019143,9.801002,0.796810
04-23 20:34:20.639+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.649+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:647,-0.015633,0.030625,-0.045167
04-23 20:34:20.649+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:647,0.070000,0.070000,0.070000
04-23 20:34:20.649+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:652,0.034632,9.770305,0.842817
04-23 20:34:20.659+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.659+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.659+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:663,0.047856,9.781858,0.818345
04-23 20:34:20.659+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.659+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.659+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:668,0.013225,0.011554,-0.024471
04-23 20:34:20.659+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:668,0.034189,9.770065,0.845598
04-23 20:34:20.659+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:663,-0.070000,0.070000,0.140000
04-23 20:34:20.679+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.679+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.689+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.689+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.699+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:685,0.034974,9.770091,0.845271
04-23 20:34:20.699+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.699+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:690,0.032810,0.021365,-0.017682
04-23 20:34:20.709+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:694,0.070000,0.070000,0.070000
04-23 20:34:20.709+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.719+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:711,0.036611,9.770132,0.844726
04-23 20:34:20.729+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.739+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:721,-0.006260,0.038089,-0.050854
04-23 20:34:20.739+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.739+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:737,0.036522,9.770008,0.846164
04-23 20:34:20.739+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:745,-0.027039,0.047619,-0.023988
04-23 20:34:20.739+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.749+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.759+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:752,0.035397,9.769877,0.847713
04-23 20:34:20.759+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.759+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:758,0.035263,0.052529,-0.034997
04-23 20:34:20.769+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.769+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:774,0.005281,0.009589,-0.108331
04-23 20:34:20.769+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:765,0.037262,9.770114,0.844911
04-23 20:34:20.779+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.779+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.789+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:34:20.789+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:34:20.789+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.789+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:795,0.070000,0.140000,0.070000
04-23 20:34:20.799+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:694,0.066999,9.791430,0.827917
04-23 20:34:20.799+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.799+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:789,0.020166,0.035673,-0.083993
04-23 20:34:20.799+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.799+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:784,0.037591,9.770499,0.840430
04-23 20:34:20.809+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.809+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.819+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:814,-0.006484,0.064002,-0.046013
04-23 20:34:20.819+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.819+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:807,0.070000,0.070000,0.140000
04-23 20:34:20.819+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.819+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:812,0.028714,9.808180,0.794417
04-23 20:34:20.819+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:827,0.004371,0.039704,0.003821
04-23 20:34:20.829+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:818,0.038700,9.770869,0.836060
04-23 20:34:20.829+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.829+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.829+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:834,0.009571,9.817751,0.820738
04-23 20:34:20.829+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:834,0.038495,9.770948,0.835145
04-23 20:34:20.829+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:829,0.070000,-0.070000,0.070000
04-23 20:34:20.829+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.829+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.839+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.839+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:841,0.071785,9.822537,0.811167
04-23 20:34:20.839+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.839+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.839+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:844,-0.000210,0.034839,-0.033550
04-23 20:34:20.849+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:848,0.040678,9.779467,0.739382
04-23 20:34:20.849+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.849+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:848,0.038867,9.770867,0.836079
04-23 20:34:20.849+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:854,0.057428,9.805787,0.760918
04-23 20:34:20.849+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:841,0.070000,-0.070000,0.070000
04-23 20:34:20.849+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.849+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.859+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.859+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:860,0.031107,9.834501,0.794417
04-23 20:34:20.859+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.859+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.859+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:863,0.001811,0.051670,-0.010555
04-23 20:34:20.859+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:867,0.043071,9.810574,0.839881
04-23 20:34:20.859+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.869+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:861,0.070000,-0.070000,0.070000
04-23 20:34:20.869+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:873,0.038285,9.805787,0.801596
04-23 20:34:20.869+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:867,0.038968,9.770870,0.836034
04-23 20:34:20.869+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.869+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.869+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:877,0.040678,9.822537,0.825524
04-23 20:34:20.879+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.879+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.879+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:884,0.004786,9.789038,0.806381
04-23 20:34:20.879+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:884,-0.034183,0.018167,-0.029653
04-23 20:34:20.879+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.879+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:879,0.070000,-0.070000,0.070000
04-23 20:34:20.889+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:888,0.039179,9.770799,0.836868
04-23 20:34:20.889+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.889+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:894,0.070000,-0.210000,0.070000
04-23 20:34:20.889+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.889+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:898,0.070000,-0.210000,0.070000
04-23 20:34:20.889+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.899+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.899+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.899+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.899+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:904,0.031107,9.805787,0.808774
04-23 20:34:20.899+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:34:20.899+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:34:20.909+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:905,-0.008073,0.034988,-0.028094
04-23 20:34:20.909+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:903,0.070000,0.140000,0.070000
04-23 20:34:20.909+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.909+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:907,0.037698,9.770679,0.838322
04-23 20:34:20.909+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:915,0.070000,0.070000,0.070000
04-23 20:34:20.909+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.919+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.919+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.919+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:923,0.043071,9.769895,0.818345
04-23 20:34:20.919+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.919+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:919,0.070000,-0.070000,0.070000
04-23 20:34:20.919+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.919+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:927,0.037534,9.770673,0.838411
04-23 20:34:20.919+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:928,0.070000,-0.070000,0.070000
04-23 20:34:20.919+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:924,0.005373,-0.000785,-0.019977
04-23 20:34:20.939+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.939+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.939+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.939+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:947,0.110070,9.817751,0.787239
04-23 20:34:20.939+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.939+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:949,0.072536,0.047078,-0.051172
04-23 20:34:20.949+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:947,0.037937,9.770592,0.839337
04-23 20:34:20.949+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:951,-0.070000,0.140000,0.070000
04-23 20:34:20.959+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.959+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.959+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:963,-0.004437,0.049553,-0.028170
04-23 20:34:20.959+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:963,0.033500,9.820145,0.811167
04-23 20:34:20.959+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.959+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.959+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:968,-0.070000,0.140000,0.070000
04-23 20:34:20.959+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:967,0.041505,9.770967,0.834777
04-23 20:34:20.979+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.979+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.979+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:20.979+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:20:984,-0.003220,0.041998,-0.045146
04-23 20:34:20.979+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:20.989+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:20:984,0.038285,9.812965,0.789631
04-23 20:34:20.989+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:20:990,-0.070000,0.140000,0.070000
04-23 20:34:20.989+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:20:992,0.041259,9.770889,0.835710
04-23 20:34:20.999+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:20.999+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:20.999+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.009+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.009+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:21:6,-0.012545,0.054040,-0.081970
04-23 20:34:21.009+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:6,0.028714,9.824929,0.753739
04-23 20:34:21.019+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:21.019+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:8,0.041253,9.770919,0.835360
04-23 20:34:21.019+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:21.019+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:21:13,-0.070000,0.140000,0.070000
04-23 20:34:21.019+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.019+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.029+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:25,0.076570,9.820145,0.760918
04-23 20:34:21.039+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:21.039+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:21:32,-0.070000,0.140000,0.070000
04-23 20:34:21.039+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:21:28,0.035318,0.049226,-0.074443
04-23 20:34:21.039+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:32,0.040784,9.771051,0.833831
04-23 20:34:21.049+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.049+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:21.049+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:48,0.078963,9.810574,0.823131
04-23 20:34:21.059+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.059+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:21.069+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:21:54,-0.070000,-0.070000,0.070000
04-23 20:34:21.069+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.079+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:34:21.089+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:34:21.089+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:34:21.099+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:63,0.042664,9.771428,0.829312
04-23 20:34:21.099+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.099+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:34:21.109+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:34:21.109+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:109,0.044518,9.771420,0.829315
04-23 20:34:21.109+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.119+0200 W/LOCATION(10336): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:34:21.119+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:71,0.016750,9.781858,0.780060
04-23 20:34:21.119+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:21.129+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:21:56,0.038179,0.039522,-0.010700
04-23 20:34:21.129+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:21.139+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:21:81,-0.070000,-0.070000,0.070000
04-23 20:34:21.139+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.139+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:123,0.043348,9.771407,0.829518
04-23 20:34:21.139+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.139+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:21:138,-0.027768,0.010439,-0.049255
04-23 20:34:21.149+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:21:146,-0.070000,-0.070000,0.070000
04-23 20:34:21.149+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.149+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:132,0.045464,9.808180,0.806381
04-23 20:34:21.149+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:21.149+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:21.159+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:157,0.043589,9.771375,0.829888
04-23 20:34:21.159+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.169+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:21:162,0.000945,0.036760,-0.022934
04-23 20:34:21.169+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:160,0.031107,9.767502,0.792024
04-23 20:34:21.169+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:21.169+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:21.179+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:21:158,-0.070000,0.070000,0.070000
04-23 20:34:21.179+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.179+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:173,0.043143,9.771345,0.830264
04-23 20:34:21.179+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.179+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:177,0.021535,9.815358,0.784846
04-23 20:34:21.179+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:21.189+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:21:180,-0.012241,-0.003905,-0.037494
04-23 20:34:21.189+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:21.189+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:21:185,-0.070000,0.070000,0.070000
04-23 20:34:21.189+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.189+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:188,0.042252,9.771320,0.830597
04-23 20:34:21.199+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:192,0.011964,9.803394,0.799203
04-23 20:34:21.199+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.199+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:21:195,-0.022054,0.043983,-0.045042
04-23 20:34:21.199+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:21.209+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:21:199,-0.070000,0.070000,0.070000
04-23 20:34:21.209+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.209+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:21.209+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:209,0.040968,9.771231,0.831714
04-23 20:34:21.209+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.209+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:218,0.043071,9.769895,0.827917
04-23 20:34:21.219+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:223,0.041215,9.771094,0.833310
04-23 20:34:21.219+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:21:210,-0.031179,0.032049,-0.031061
04-23 20:34:21.219+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:21.219+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:21:228,0.000818,-0.001426,-0.002681
04-23 20:34:21.229+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.229+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:21:215,-0.070000,-0.070000,0.070000
04-23 20:34:21.229+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.229+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:21:235,-0.070000,0.070000,0.070000
04-23 20:34:21.229+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.229+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:21.239+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:234,0.040302,9.771075,0.833581
04-23 20:34:21.239+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:241,0.019143,9.791430,0.780060
04-23 20:34:21.239+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:21.239+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.239+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:247,0.035892,9.801002,0.823131
04-23 20:34:21.239+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:21.249+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:21.249+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:21:253,-0.021826,0.020200,-0.051654
04-23 20:34:21.249+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:21.249+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:247,0.040249,9.770982,0.834672
04-23 20:34:21.249+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.249+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:21:240,-0.070000,0.070000,0.070000
04-23 20:34:21.259+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.259+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:260,0.039962,9.770835,0.836409
04-23 20:34:21.259+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:251,0.031107,9.841680,0.844666
04-23 20:34:21.259+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:21.269+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.269+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:21:258,-0.005323,0.029907,-0.010179
04-23 20:34:21.269+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:21.269+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:21:265,-0.070000,-0.070000,0.070000
04-23 20:34:21.279+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.279+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:21:284,0.070000,-0.070000,0.070000
04-23 20:34:21.279+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.279+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:274,0.038998,9.770871,0.836028
04-23 20:34:21.279+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.289+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:21:277,-0.009196,0.070604,0.011085
04-23 20:34:21.289+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:21.289+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:289,0.040264,9.771201,0.832102
04-23 20:34:21.289+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:272,0.016750,9.820145,0.780060
04-23 20:34:21.289+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:21.299+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:21:288,0.070000,-0.070000,0.070000
04-23 20:34:21.299+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.299+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.299+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:299,0.062213,9.820145,0.765703
04-23 20:34:21.299+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:21.299+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:21:295,-0.023499,0.049163,-0.054611
04-23 20:34:21.299+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:34:21.299+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:34:21.299+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:21.309+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:306,0.040426,9.771119,0.833054
04-23 20:34:21.309+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:21:312,0.022251,0.049310,-0.070705
04-23 20:34:21.309+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:307,0.040678,9.824929,0.830309
04-23 20:34:21.309+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:21.319+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.319+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:21:304,0.070000,-0.070000,0.070000
04-23 20:34:21.319+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.319+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:21.319+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:324,0.040925,9.771258,0.831393
04-23 20:34:21.319+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:322,0.047856,9.779467,0.777667
04-23 20:34:21.329+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:21:324,0.070000,-0.070000,0.070000
04-23 20:34:21.329+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.329+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:21:326,0.000414,0.053728,-0.001792
04-23 20:34:21.329+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:21.339+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:21.339+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.339+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:21:341,0.007592,0.008265,-0.054434
04-23 20:34:21.339+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:21.339+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:21:336,0.070000,0.070000,0.070000
04-23 20:34:21.339+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:345,0.039673,9.771280,0.831202
04-23 20:34:21.339+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.349+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:343,0.011964,9.767502,0.753739
04-23 20:34:21.349+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:21.349+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:21:350,-0.028462,-0.003617,-0.079315
04-23 20:34:21.349+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:21.359+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.359+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:365,0.039526,9.771089,0.833461
04-23 20:34:21.359+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:354,0.033500,9.803394,0.837488
04-23 20:34:21.359+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:21:352,-0.070000,0.070000,0.070000
04-23 20:34:21.369+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.369+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:21.369+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:376,0.007178,9.741181,0.777667
04-23 20:34:21.369+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:21:359,-0.007425,0.032136,0.006095
04-23 20:34:21.379+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.379+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:384,0.038137,9.771029,0.834230
04-23 20:34:21.379+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:21:373,-0.070000,0.070000,0.070000
04-23 20:34:21.379+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.389+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:21.389+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:21.389+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:397,0.055035,9.815358,0.801596
04-23 20:34:21.389+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:21:390,-0.070000,-0.070000,0.070000
04-23 20:34:21.399+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:21:393,-0.032495,-0.030099,-0.053535
04-23 20:34:21.399+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:21.399+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.399+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:407,0.039081,9.771080,0.833574
04-23 20:34:21.399+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.409+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:21.409+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:413,0.047856,9.798609,0.825524
04-23 20:34:21.409+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:21:404,0.015509,0.044270,-0.031866
04-23 20:34:21.419+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.419+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:424,0.039634,9.770984,0.834679
04-23 20:34:21.419+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:21:412,-0.070000,0.070000,0.070000
04-23 20:34:21.419+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.429+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:21.429+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:21.439+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:21:431,-0.070000,0.070000,0.070000
04-23 20:34:21.439+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:433,0.047856,9.784252,0.799203
04-23 20:34:21.439+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:21:440,0.009720,0.027580,-0.008706
04-23 20:34:21.439+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:21.439+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.449+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:451,0.040172,9.771008,0.834373
04-23 20:34:21.449+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.449+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:21.459+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.459+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:464,0.041926,9.771148,0.832648
04-23 20:34:21.459+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:21:456,-0.070000,0.070000,0.070000
04-23 20:34:21.469+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:457,0.074178,9.820145,0.796810
04-23 20:34:21.469+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:21.469+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:21:448,0.008776,0.013172,-0.034371
04-23 20:34:21.469+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:21.469+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:479,0.040678,9.817751,0.803988
04-23 20:34:21.479+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:21.479+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.479+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:485,0.047856,9.779467,0.815953
04-23 20:34:21.479+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:485,0.042000,9.771114,0.833033
04-23 20:34:21.479+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.479+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:21:479,0.034543,0.049161,-0.037869
04-23 20:34:21.479+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:21.489+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:21:490,-0.070000,0.070000,0.070000
04-23 20:34:21.489+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.489+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:21:492,0.000506,0.046743,-0.030384
04-23 20:34:21.489+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:21.489+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:21:498,0.005930,0.008319,-0.016695
04-23 20:34:21.499+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:21.499+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:21.499+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:21:504,0.045464,9.781858,0.803988
04-23 20:34:21.499+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:21:504,0.042424,9.771051,0.833755
04-23 20:34:21.499+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:21.499+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:21:494,-0.070000,0.140000,0.070000
04-23 20:34:21.499+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:21.499+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:34:21.509+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:34:21.509+0200 W/CRASH_MANAGER(10205): worker.c: worker_job(1205) > 11103366c6f63152450846
