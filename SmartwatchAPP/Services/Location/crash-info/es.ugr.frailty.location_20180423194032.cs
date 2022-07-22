S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 19180
Date: 2018-04-23 19:40:32+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6fc652d, r5   = 0xf73b6f98
r6   = 0xffd8c220, r7   = 0xffd8c0d0
r8   = 0xf73b3c18, r9   = 0x00000000
r10  = 0xffd8c1ac, fp   = 0xffd8c220
ip   = 0x00000001, sp   = 0xffd8c0a8
lr   = 0xf6fc6539, pc   = 0xf702f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      8172 KB
Buffers:     55528 KB
Cached:     233992 KB
VmPeak:      53460 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11708 KB
VmRSS:       11708 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 19180 TID = 19180
19180 19196 

Maps Information
f3e91000 f4690000 rw-p [stack:19196]
f4697000 f4699000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f46a1000 f46a5000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f46ae000 f46b0000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f46b8000 f46bb000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f46ca000 f46cf000 r-xp /usr/lib/libsystem.so.0.0.0
f46da000 f46dd000 r-xp /lib/libattr.so.1.1.0
f46e5000 f46f5000 r-xp /usr/lib/libmdm-common.so.1.1.24
f46fd000 f4706000 r-xp /usr/lib/libedbus.so.1.7.99
f470e000 f470f000 r-xp /usr/lib/libresponse.so.0.2.96
f4718000 f471d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5fbf000 f60c5000 r-xp /usr/lib/libicuuc.so.57.1
f60db000 f6263000 r-xp /usr/lib/libicui18n.so.57.1
f6273000 f6280000 r-xp /usr/lib/libail.so.0.1.0
f6289000 f6290000 r-xp /usr/lib/libminizip.so.1.0.0
f6299000 f6442000 r-xp /usr/lib/libcrypto.so.1.0.0
f6462000 f64a9000 r-xp /usr/lib/libssl.so.1.0.0
f64b5000 f64b7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f64bf000 f64c6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f64cf000 f64d6000 r-xp /lib/libcrypt-2.13.so
f6507000 f650a000 r-xp /lib/libcap.so.2.21
f6512000 f6514000 r-xp /usr/lib/libiri.so
f651c000 f6565000 r-xp /usr/lib/libmdm.so.1.2.69
f656d000 f6573000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f657b000 f659e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f65a8000 f65aa000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f65b2000 f65cf000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f65d8000 f65dc000 r-xp /usr/lib/libsmack.so.1.0.0
f65e5000 f65fe000 r-xp /usr/lib/libnetwork.so.0.0.0
f6607000 f660f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6617000 f661d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6626000 f6628000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6631000 f6641000 r-xp /lib/libresolv-2.13.so
f6645000 f665d000 r-xp /usr/lib/liblzma.so.5.0.3
f6666000 f6668000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6670000 f668a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6692000 f66c1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f66ca000 f66d9000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f66e3000 f66ed000 r-xp /usr/lib/libsensord-shared.so
f66f6000 f67c9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f67d4000 f67ea000 r-xp /lib/libz.so.1.2.5
f67f2000 f67f7000 r-xp /usr/lib/libffi.so.5.0.10
f67ff000 f6800000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6808000 f6818000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6820000 f6839000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6841000 f6843000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f684b000 f68c0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f68ca000 f68d0000 r-xp /lib/librt-2.13.so
f68d9000 f68f7000 r-xp /usr/lib/libsystemd.so.0.4.0
f6901000 f6902000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f690a000 f692d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6935000 f693a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6942000 f696c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6975000 f698c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6994000 f69fd000 r-xp /lib/libm-2.13.so
f6a06000 f6a9a000 r-xp /usr/lib/libstdc++.so.6.0.16
f6aad000 f6ab2000 r-xp /usr/lib/libctx-client.so.0.8.3
f6aba000 f6ac1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ac9000 f6af3000 r-xp /usr/lib/libsensor.so.1.9.6
f6afc000 f6bc8000 r-xp /usr/lib/libxml2.so.2.7.8
f6bd5000 f6bd7000 r-xp /usr/lib/libiniparser.so.0
f6be0000 f6be6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6bef000 f6cbf000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6cc0000 f6cf4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6cfd000 f6d39000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6d41000 f6d44000 r-xp /usr/lib/libbundle.so.0.1.22
f6d4c000 f6d52000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d5a000 f6d9b000 r-xp /usr/lib/libeina.so.1.7.99
f6da4000 f6dbb000 r-xp /usr/lib/libecore.so.1.7.99
f6dd2000 f6ddb000 r-xp /usr/lib/libvconf.so.0.2.45
f6de3000 f6df7000 r-xp /lib/libpthread-2.13.so
f6e02000 f6e0f000 r-xp /usr/lib/libaul.so.0.1.0
f6e19000 f6e1b000 r-xp /lib/libdl-2.13.so
f6e24000 f6e2f000 r-xp /lib/libunwind.so.8.0.1
f6e5c000 f6e64000 r-xp /lib/libgcc_s-4.6.so.1
f6e65000 f6f89000 r-xp /lib/libc-2.13.so
f6f97000 f6f99000 r-xp /usr/lib/libdlog.so.0.0.0
f6fa1000 f6fad000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6fb6000 f6fbb000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6fc3000 f6fd2000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f6fda000 f6fde000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6fe7000 f6fea000 r-xp /usr/lib/libappcore-agent.so.1.1
f6ff2000 f6ff4000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f6ffc000 f7000000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7008000 f7025000 r-xp /lib/ld-2.13.so
f702e000 f7031000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7031000 f7035000 r-xp /usr/lib/libsys-assert.so
f7383000 f73f4000 rw-p [heap]
ffd6d000 ffd8e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19180)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf702f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf6fc6539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6ccd3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6ccbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6cd7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6cddbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6cdddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6d1275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6d0d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6ccbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6cd7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6cddbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6cdddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6d0fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6d10017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6d17f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf46af1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf46a2171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6775663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6c22fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6c247a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6db4ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6dafb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6db05a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6db0879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf6fe8183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf6fe87fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf702f4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6e7c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf702ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ilty.gyroscope
04-23 19:40:31.869+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:31:876,0.244743,-1.584991,-4.001096
04-23 19:40:31.879+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:31:803,0.820663,-6.366997,7.413383
04-23 19:40:31.879+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:31:879,27.299999,54.389999,-10.500000
04-23 19:40:31.879+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:31.879+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:31.879+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:31:884,-10.710000,61.250000,-7.630000
04-23 19:40:31.879+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:31.879+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:31.889+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:31:892,-72.940002,60.060001,-0.910000
04-23 19:40:31.889+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:31.889+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:31:897,-93.940002,48.090000,7.630000
04-23 19:40:31.889+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:31:897,0.748101,-6.228669,7.537534
04-23 19:40:31.889+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:31:816,0.875773,-7.044470,3.259024
04-23 19:40:31.889+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:31:892,0.098535,-1.991587,-2.761802
04-23 19:40:31.899+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:31.899+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:31.899+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:31:903,0.690976,-6.144435,7.611757
04-23 19:40:31.899+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:31.899+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:31.899+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:31.909+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:31:911,-73.290001,46.270000,4.550000
04-23 19:40:31.909+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:31:911,0.485661,-3.064976,-3.799771
04-23 19:40:31.909+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:31:908,0.662136,-6.153397,7.607080
04-23 19:40:31.909+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:31.919+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:31:918,0.616919,-6.239723,7.540269
04-23 19:40:31.919+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:31.929+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:31:905,0.969093,-7.539784,3.079563
04-23 19:40:31.929+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:31.929+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:31.939+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:31.939+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:31:943,-47.040001,46.200001,0.770000
04-23 19:40:31.939+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:31.939+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:31:943,0.882209,-4.021780,-4.746414
04-23 19:40:31.949+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:31.949+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:31:951,-5.670000,44.099998,3.500000
04-23 19:40:31.949+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:31:927,0.581538,-6.360353,7.441648
04-23 19:40:31.949+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:31.949+0200 I/heartrate(18904): capturing data from es.ugr.frailty.heartrate
04-23 19:40:31.949+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:31:958,0.586984,-6.509033,7.311520
04-23 19:40:31.949+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:31.959+0200 I/heartrate(18904): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:40:31:959,85
04-23 19:40:31.959+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:31:962,0.591103,-6.613326,7.216987
04-23 19:40:31.959+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:31.959+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:31:934,1.342373,-7.415358,2.512464
04-23 19:40:31.959+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:31:953,0.404312,-3.534635,-2.285379
04-23 19:40:31.959+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:31.959+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:31:967,0.535387,-6.575317,7.255960
04-23 19:40:31.969+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:31.969+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:31.969+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:31:976,10.850000,36.330002,0.350000
04-23 19:40:31.969+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:31.979+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:31:973,0.906880,-7.738388,3.605984
04-23 19:40:31.979+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:31:981,0.471328,-6.484921,7.341255
04-23 19:40:31.979+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:31:977,0.060426,-2.742334,-0.967622
04-23 19:40:31.979+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:31.979+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:31:986,0.715454,-8.231310,4.778467
04-23 19:40:31.979+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:31.979+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:31.979+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:31.989+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:31.989+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:31:992,0.155591,-2.110097,-3.275850
04-23 19:40:31.989+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:31:993,0.459073,-6.506064,7.323303
04-23 19:40:31.989+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:31:992,-20.020000,27.370001,-1.820000
04-23 19:40:31.989+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:31:997,1.067199,-9.425328,3.641876
04-23 19:40:31.989+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:31.999+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:1,1.469193,-10.530812,2.565106
04-23 19:40:31.999+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:31.999+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:31.999+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.009+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.009+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:13,-32.759998,19.040001,2.520000
04-23 19:40:32.009+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:11,0.465745,-6.581942,7.254758
04-23 19:40:32.009+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:11,0.194168,-3.053262,-3.573750
04-23 19:40:32.029+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.039+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:5,0.995414,-10.147961,4.931608
04-23 19:40:32.039+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.039+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:40,-0.023073,-3.934513,-1.736909
04-23 19:40:32.039+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:44,0.595813,-9.317651,6.288338
04-23 19:40:32.039+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.039+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.039+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.049+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:51,0.445661,-6.562399,7.273699
04-23 19:40:32.049+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.049+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:55,-0.630000,7.840000,5.250000
04-23 19:40:32.049+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.049+0200 E/CAPI_TELEPHONY(18958): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 19:40:32.049+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:59,72.379997,-5.600000,0.350000
04-23 19:40:32.059+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.059+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:55,0.848856,-4.832222,-1.526139
04-23 19:40:32.059+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:50,0.626920,-8.595018,4.065405
04-23 19:40:32.059+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.059+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:68,0.451473,-6.444719,7.377815
04-23 19:40:32.069+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:71,0.653241,-9.559326,3.749553
04-23 19:40:32.069+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.069+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.069+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.069+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:76,113.190002,-6.790000,-1.820000
04-23 19:40:32.069+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:76,1.190003,-1.540130,-1.580005
04-23 19:40:32.069+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:74,0.442672,-10.516455,5.517848
04-23 19:40:32.079+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.079+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.079+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:83,1.294517,-11.394621,5.747560
04-23 19:40:32.079+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.079+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:83,0.491858,-6.266489,7.527256
04-23 19:40:32.079+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:87,1.641476,-7.984849,5.797810
04-23 19:40:32.079+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.079+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.089+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:92,33.110001,-9.520000,-4.340000
04-23 19:40:32.089+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.089+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:92,1.886608,0.559607,-2.952178
04-23 19:40:32.089+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:96,2.378466,-5.706882,4.575077
04-23 19:40:32.089+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.099+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:99,0.576516,-6.281337,7.508849
04-23 19:40:32.099+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.099+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.109+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:111,2.421690,-0.440102,-4.441251
04-23 19:40:32.109+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:112,-87.779999,-15.890000,5.250000
04-23 19:40:32.109+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.109+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.119+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:117,2.998207,-6.721439,3.067599
04-23 19:40:32.119+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:118,0.727985,-6.611394,7.206240
04-23 19:40:32.119+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.119+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.129+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:132,2.571718,-1.741950,-4.851702
04-23 19:40:32.129+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.129+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:133,-138.809998,-7.210000,14.840000
04-23 19:40:32.129+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.129+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:136,3.299703,-8.353344,2.354537
04-23 19:40:32.129+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:138,0.958014,-7.162277,6.629810
04-23 19:40:32.139+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.139+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.149+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:151,1.913373,-2.208016,-4.741873
04-23 19:40:32.149+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.149+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:151,-143.639999,9.800000,7.070000
04-23 19:40:32.149+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.149+0200 I/heartrate(18904): capturing data from es.ugr.frailty.heartrate
04-23 19:40:32.149+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:157,1.131645,-7.649309,6.031404
04-23 19:40:32.149+0200 I/heartrate(18904): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:40:32:158,85
04-23 19:40:32.159+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:157,2.871387,-9.370294,1.887937
04-23 19:40:32.169+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.169+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.169+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:177,-152.809998,19.320000,-1.120000
04-23 19:40:32.169+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:177,1.553102,-1.845412,-4.578961
04-23 19:40:32.169+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.169+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.179+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:181,1.276411,-8.081747,5.406156
04-23 19:40:32.179+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:182,2.684747,-9.494720,1.452443
04-23 19:40:32.179+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.179+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.189+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:192,-161.910004,16.170000,4.340000
04-23 19:40:32.189+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.189+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:192,1.781616,-0.458237,-3.185616
04-23 19:40:32.199+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.199+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:203,1.386561,-8.419641,4.832957
04-23 19:40:32.199+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:198,3.058028,-8.539984,2.220540
04-23 19:40:32.199+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.199+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.209+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:212,-168.490005,9.730000,13.090000
04-23 19:40:32.209+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.209+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:212,1.393899,-0.275876,-4.895171
04-23 19:40:32.209+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.219+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:219,2.780460,-8.695518,-0.062213
04-23 19:40:32.219+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:221,1.481272,-8.807818,4.049513
04-23 19:40:32.219+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.219+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.229+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.229+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:232,1.122119,-1.622496,-7.054898
04-23 19:40:32.229+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.239+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:237,2.603391,-10.430314,-3.005385
04-23 19:40:32.249+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.259+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:256,1.025130,-2.541933,-6.576100
04-23 19:40:32.269+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:40:32.269+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:40:32.269+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:40:32.269+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.279+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:278,0.039743,-3.189458,-4.617053
04-23 19:40:32.279+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.279+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.299+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:232,-159.949997,22.049999,18.549999
04-23 19:40:32.299+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.309+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:241,1.461013,-9.039328,3.510895
04-23 19:40:32.309+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.319+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:312,-139.089996,41.860001,8.820000
04-23 19:40:32.319+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:318,1.434235,-9.195791,3.090432
04-23 19:40:32.319+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.319+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.329+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:328,-136.919998,52.080002,-3.360000
04-23 19:40:32.329+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.339+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:333,1.410669,-9.314327,2.724647
04-23 19:40:32.339+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:286,2.486143,-11.581261,-3.065206
04-23 19:40:32.349+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:292,0.575374,-2.513395,0.027100
04-23 19:40:32.349+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.349+0200 I/heartrate(18904): capturing data from es.ugr.frailty.heartrate
04-23 19:40:32.359+0200 I/heartrate(18904): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:40:32:359,85
04-23 19:40:32.359+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.369+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.369+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:341,-95.690002,37.029999,-4.830000
04-23 19:40:32.369+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.379+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:356,1.397808,-9.362407,2.561612
04-23 19:40:32.379+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:381,-10.220000,3.780000,-22.540001
04-23 19:40:32.379+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:370,1.473979,-12.385249,-1.526621
04-23 19:40:32.379+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.379+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.389+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:374,1.277368,-1.032015,0.182956
04-23 19:40:32.389+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.389+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:389,1.450280,-9.361868,2.534265
04-23 19:40:32.389+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:393,1.986043,-11.827723,2.751746
04-23 19:40:32.399+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.399+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:401,0.562084,-0.807628,-2.936259
04-23 19:40:32.399+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.399+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.399+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:404,-4.270000,2.450000,-38.779999
04-23 19:40:32.399+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:406,0.742803,-0.579416,-3.471195
04-23 19:40:32.399+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.409+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.409+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:410,0.885346,-0.641922,-1.671562
04-23 19:40:32.409+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.409+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.409+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:415,0.071649,-0.954167,-0.507725
04-23 19:40:32.409+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.409+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:409,1.537557,-9.420189,2.250856
04-23 19:40:32.419+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:419,-0.108071,-0.922747,-2.003486
04-23 19:40:32.419+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.419+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:414,2.675175,-10.394422,2.744568
04-23 19:40:32.419+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.419+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:424,2.012364,-10.169496,-0.401994
04-23 19:40:32.419+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.429+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:428,2.280360,-9.999605,-1.220340
04-23 19:40:32.429+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.429+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:434,2.476572,-10.143176,0.162712
04-23 19:40:32.429+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.429+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.439+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:439,1.665405,-10.523634,0.926022
04-23 19:40:32.439+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:445,-0.030895,0.083050,-4.327619
04-23 19:40:32.449+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.449+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:455,-0.054769,0.178826,-3.514127
04-23 19:40:32.449+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:421,-61.529999,-10.640000,-31.360001
04-23 19:40:32.449+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.459+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:425,1.591226,-9.501254,1.834274
04-23 19:40:32.459+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.459+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:465,1.593756,-9.569467,1.433748
04-23 19:40:32.459+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:460,-84.279999,-16.660000,-12.320000
04-23 19:40:32.459+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.469+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.469+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.469+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.469+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:476,0.849934,-1.712025,-3.757919
04-23 19:40:32.479+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:470,-42.349998,-5.880000,-12.250000
04-23 19:40:32.479+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.479+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.489+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:492,0.652549,-0.834704,-2.405047
04-23 19:40:32.489+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:474,1.579656,-9.598495,1.242568
04-23 19:40:32.489+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.499+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:488,17.010000,-9.380000,-16.450001
04-23 19:40:32.499+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.499+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.509+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:512,0.109483,0.506547,-1.983437
04-23 19:40:32.509+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:502,1.579051,-9.618448,1.078166
04-23 19:40:32.509+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.519+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:507,45.080002,1.540000,-24.219999
04-23 19:40:32.519+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.519+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:519,1.595746,-9.625690,0.984914
04-23 19:40:32.519+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.519+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.529+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:531,-0.394809,4.729543,-2.617591
04-23 19:40:32.529+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:529,1.569209,-9.649097,0.776462
04-23 19:40:32.529+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:524,-20.930000,17.920000,-19.250000
04-23 19:40:32.529+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.539+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:544,-30.309999,16.940001,-10.220000
04-23 19:40:32.539+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:473,1.471586,-10.521241,-0.760918
04-23 19:40:32.539+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.549+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:552,-2.222319,7.145867,-1.128047
04-23 19:40:32.549+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.549+0200 I/heartrate(18904): capturing data from es.ugr.frailty.heartrate
04-23 19:40:32.559+0200 I/heartrate(18904): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:40:32:560,85
04-23 19:40:32.559+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.569+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.569+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:576,-1.497278,1.562815,-0.997958
04-23 19:40:32.569+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.579+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:567,1.548156,-9.535398,-3.249453
04-23 19:40:32.579+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.579+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:566,1.548848,-9.662608,0.636751
04-23 19:40:32.579+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.579+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:581,20.370001,33.180000,-12.110000
04-23 19:40:32.579+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:584,1.540978,-9.446864,-2.529213
04-23 19:40:32.579+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.579+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:588,2.419144,-11.361122,-2.981457
04-23 19:40:32.579+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.589+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.589+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:592,-0.451615,1.029917,-2.305312
04-23 19:40:32.589+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.589+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:588,1.567886,-9.659093,0.643457
04-23 19:40:32.589+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.589+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:597,2.201397,-10.497313,-1.768296
04-23 19:40:32.589+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.589+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:593,48.860001,47.110001,-12.460000
04-23 19:40:32.599+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.599+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:601,1.677369,-9.152546,-1.339981
04-23 19:40:32.599+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.599+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:598,1.581649,-9.656364,0.650690
04-23 19:40:32.599+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.599+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:605,1.186840,-4.926822,-1.966900
04-23 19:40:32.599+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.599+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.609+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:603,-22.820000,40.110001,-1.050000
04-23 19:40:32.609+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:612,0.103848,0.946280,-3.450222
04-23 19:40:32.609+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.609+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:609,-0.679562,-2.524428,-0.602991
04-23 19:40:32.609+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.609+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:616,-167.720001,28.559999,14.280000
04-23 19:40:32.609+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:617,-0.181855,-8.154739,-0.902094
04-23 19:40:32.609+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:607,1.542757,-9.670295,0.525056
04-23 19:40:32.609+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.609+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.619+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:621,0.559920,-8.709875,-2.837888
04-23 19:40:32.619+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.619+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.619+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:622,1.315423,-9.717554,0.095864
04-23 19:40:32.619+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:625,0.772882,-8.772088,-4.579862
04-23 19:40:32.619+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.619+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.619+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:627,-234.360001,3.150000,41.860001
04-23 19:40:32.629+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.629+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:632,0.218140,0.437588,-3.516331
04-23 19:40:32.629+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.629+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:633,-180.880005,-6.440000,49.139999
04-23 19:40:32.629+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.629+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:636,0.519243,-9.217153,-5.209175
04-23 19:40:32.629+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:637,-160.369995,-10.430000,57.470001
04-23 19:40:32.629+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.639+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:629,1.011536,-9.739792,-0.532575
04-23 19:40:32.639+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:640,-134.750000,2.590000,81.340004
04-23 19:40:32.639+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.639+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:646,0.669034,-9.718369,-1.129640
04-23 19:40:32.639+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.649+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.649+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:654,0.247461,-1.816322,-3.960354
04-23 19:40:32.649+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.649+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.649+0200 W/LOCATION(19180): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:40:32.659+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:661,-20.860001,16.240000,77.840004
04-23 19:40:32.659+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:650,0.301102,-9.654740,-1.692844
04-23 19:40:32.659+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.659+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:667,-0.103892,-9.559156,-2.186808
04-23 19:40:32.659+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.669+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:659,0.143569,-11.375479,-6.147161
04-23 19:40:32.669+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.669+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.669+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:676,76.090004,29.330000,73.430000
04-23 19:40:32.669+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:672,-0.343908,-9.512259,-2.359883
04-23 19:40:32.669+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.669+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:677,0.767437,-1.944576,-3.280000
04-23 19:40:32.679+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:681,-0.473071,-9.520725,-2.302689
04-23 19:40:32.679+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.679+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:686,0.423530,-11.456835,-5.639884
04-23 19:40:32.679+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.679+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.689+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.689+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:692,107.169998,35.279999,58.450001
04-23 19:40:32.689+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:692,2.069084,-1.249370,-3.210375
04-23 19:40:32.689+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.689+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:693,-0.523841,-9.552629,-2.154824
04-23 19:40:32.699+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:700,1.596013,-10.770095,-5.513064
04-23 19:40:32.699+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.699+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.699+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.709+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:712,-0.575343,-9.570540,-2.060127
04-23 19:40:32.709+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:711,95.410004,49.980000,51.380001
04-23 19:40:32.709+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.719+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:712,2.808987,0.902575,-3.669307
04-23 19:40:32.719+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:721,2.285146,-8.650054,-5.824130
04-23 19:40:32.719+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.719+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.729+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:732,-0.605781,-9.578409,-2.014321
04-23 19:40:32.729+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:732,52.220001,72.379997,41.090000
04-23 19:40:32.729+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.739+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.739+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:743,2.520708,-0.307031,-3.929108
04-23 19:40:32.739+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:741,1.945365,-9.877571,-5.989235
04-23 19:40:32.739+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.749+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.749+0200 I/heartrate(18904): capturing data from es.ugr.frailty.heartrate
04-23 19:40:32.749+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:752,-0.578441,-9.611320,-1.859660
04-23 19:40:32.749+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:753,77.419998,68.949997,29.469999
04-23 19:40:32.749+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.749+0200 I/heartrate(18904): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:40:32:759,85
04-23 19:40:32.759+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.759+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:763,2.469790,-2.129672,-1.019778
04-23 19:40:32.759+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:761,1.864009,-11.708081,-3.034099
04-23 19:40:32.769+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.769+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.769+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:777,-0.486497,-9.656811,-1.636983
04-23 19:40:32.779+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:781,83.160004,55.439999,10.010000
04-23 19:40:32.779+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.779+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:786,2.024328,-11.392227,-0.413958
04-23 19:40:32.779+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.779+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.779+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.789+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:793,107.870003,40.670002,2.660000
04-23 19:40:32.789+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:793,-0.323553,-9.711497,-1.323828
04-23 19:40:32.789+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:790,2.602768,-1.780908,1.445702
04-23 19:40:32.799+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.799+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.799+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:805,1.957329,-11.449656,1.598405
04-23 19:40:32.799+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.809+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.809+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:813,-0.106927,-9.763896,-0.908452
04-23 19:40:32.809+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:811,147.279999,17.570000,-7.840000
04-23 19:40:32.809+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:808,2.443826,-1.792846,3.235389
04-23 19:40:32.809+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.819+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.819+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:824,1.610370,-11.533404,2.333002
04-23 19:40:32.819+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.829+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.829+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:833,0.106906,-9.793392,-0.498414
04-23 19:40:32.829+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:831,147.139999,6.160000,-12.740000
04-23 19:40:32.829+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:827,1.933923,-1.821907,3.656830
04-23 19:40:32.829+0200 I/accelerometer(19141): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:32.829+0200 I/linearacceleration(19167): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:32.839+0200 I/linearacceleration(19167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:32:843,1.578513,-0.061033,1.463586
04-23 19:40:32.839+0200 I/accelerometer(19141): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:32:842,1.471586,-9.824929,0.555135
04-23 19:40:32.839+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.839+0200 I/gravity (19182): capturing data from es.ugr.frailty.gravity
04-23 19:40:32.869+0200 I/gyroscope(19154): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:32:853,84.000000,3.990000,-5.530000
04-23 19:40:32.869+0200 I/gravity (19182): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:32:853,0.216423,-9.799979,-0.289732
04-23 19:40:32.869+0200 I/gyroscope(19154): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:32.869+0200 W/CRASH_MANAGER(18968): worker.c: worker_job(1205) > 11191806c6f63152450523
