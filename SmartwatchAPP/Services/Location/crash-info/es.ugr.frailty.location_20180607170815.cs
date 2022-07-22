S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 16473
Date: 2018-06-07 17:08:15+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf737052d, r5   = 0xf74b5f98
r6   = 0xff7efce0, r7   = 0xff7efb90
r8   = 0xf74b2c18, r9   = 0x00000000
r10  = 0xff7efc6c, fp   = 0xff7efce0
ip   = 0x00000001, sp   = 0xff7efb68
lr   = 0xf7370539, pc   = 0xf73d9228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     74932 KB
Buffers:      8136 KB
Cached:      50200 KB
VmPeak:      53460 KB
VmSize:      53420 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11852 KB
VmRSS:       11848 KB
VmData:      11148 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 16473 TID = 16473
16473 16479 

Maps Information
f423b000 f4a3a000 rw-p [stack:16479]
f4a41000 f4a43000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4a4b000 f4a4f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4a58000 f4a5a000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4a62000 f4a65000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4a74000 f4a79000 r-xp /usr/lib/libsystem.so.0.0.0
f4a84000 f4a87000 r-xp /lib/libattr.so.1.1.0
f4a8f000 f4a9f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4aa7000 f4ab0000 r-xp /usr/lib/libedbus.so.1.7.99
f4ab8000 f4ab9000 r-xp /usr/lib/libresponse.so.0.2.96
f4ac2000 f4ac7000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6369000 f646f000 r-xp /usr/lib/libicuuc.so.57.1
f6485000 f660d000 r-xp /usr/lib/libicui18n.so.57.1
f661d000 f662a000 r-xp /usr/lib/libail.so.0.1.0
f6633000 f663a000 r-xp /usr/lib/libminizip.so.1.0.0
f6643000 f67ec000 r-xp /usr/lib/libcrypto.so.1.0.0
f680c000 f6853000 r-xp /usr/lib/libssl.so.1.0.0
f685f000 f6861000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6869000 f6870000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6879000 f6880000 r-xp /lib/libcrypt-2.13.so
f68b1000 f68b4000 r-xp /lib/libcap.so.2.21
f68bc000 f68be000 r-xp /usr/lib/libiri.so
f68c6000 f690f000 r-xp /usr/lib/libmdm.so.1.2.69
f6917000 f691d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6925000 f6948000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6952000 f6954000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f695c000 f6979000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6982000 f6986000 r-xp /usr/lib/libsmack.so.1.0.0
f698f000 f69a8000 r-xp /usr/lib/libnetwork.so.0.0.0
f69b1000 f69b9000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f69c1000 f69c7000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f69d0000 f69d2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f69db000 f69eb000 r-xp /lib/libresolv-2.13.so
f69ef000 f6a07000 r-xp /usr/lib/liblzma.so.5.0.3
f6a10000 f6a12000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a1a000 f6a34000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a3c000 f6a6b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a74000 f6a83000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a8d000 f6a97000 r-xp /usr/lib/libsensord-shared.so
f6aa0000 f6b73000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b7e000 f6b94000 r-xp /lib/libz.so.1.2.5
f6b9c000 f6ba1000 r-xp /usr/lib/libffi.so.5.0.10
f6ba9000 f6baa000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6bb2000 f6bc2000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6bca000 f6be3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6beb000 f6bed000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6bf5000 f6c6a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c74000 f6c7a000 r-xp /lib/librt-2.13.so
f6c83000 f6ca1000 r-xp /usr/lib/libsystemd.so.0.4.0
f6cab000 f6cac000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6cb4000 f6cd7000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6cdf000 f6ce4000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6cec000 f6d16000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d1f000 f6d36000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d3e000 f6da7000 r-xp /lib/libm-2.13.so
f6db0000 f6e44000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e57000 f6e5c000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e64000 f6e6b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e73000 f6e9d000 r-xp /usr/lib/libsensor.so.1.9.6
f6ea6000 f6f72000 r-xp /usr/lib/libxml2.so.2.7.8
f6f7f000 f6f81000 r-xp /usr/lib/libiniparser.so.0
f6f8a000 f6f90000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f99000 f7069000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f706a000 f709e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f70a7000 f70e3000 r-xp /usr/lib/libSLP-location.so.0.9.24
f70eb000 f70ee000 r-xp /usr/lib/libbundle.so.0.1.22
f70f6000 f70fc000 r-xp /usr/lib/libappsvc.so.0.1.0
f7104000 f7145000 r-xp /usr/lib/libeina.so.1.7.99
f714e000 f7165000 r-xp /usr/lib/libecore.so.1.7.99
f717c000 f7185000 r-xp /usr/lib/libvconf.so.0.2.45
f718d000 f71a1000 r-xp /lib/libpthread-2.13.so
f71ac000 f71b9000 r-xp /usr/lib/libaul.so.0.1.0
f71c3000 f71c5000 r-xp /lib/libdl-2.13.so
f71ce000 f71d9000 r-xp /lib/libunwind.so.8.0.1
f7206000 f720e000 r-xp /lib/libgcc_s-4.6.so.1
f720f000 f7333000 r-xp /lib/libc-2.13.so
f7341000 f7343000 r-xp /usr/lib/libdlog.so.0.0.0
f734b000 f7357000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7360000 f7365000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f736d000 f737c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7384000 f7388000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7391000 f7394000 r-xp /usr/lib/libappcore-agent.so.1.1
f739c000 f739e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f73a6000 f73aa000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f73b2000 f73cf000 r-xp /lib/ld-2.13.so
f73d8000 f73db000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f73db000 f73df000 r-xp /usr/lib/libsys-assert.so
f7482000 f74ea000 rw-p [heap]
ff7d1000 ff7f2000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16473)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf73d9228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7370539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70773f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7075c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7081e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7087be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7087dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf70bc75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70b71f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7075c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7081e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7087be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7087dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf70b9e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf70ba017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf70c1f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4a591fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4a4c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6b1f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6fccfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6fce7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf715eca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7159b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf715a5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf715a879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7392183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73927fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73d95c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf722685c) [/lib/libc.so.6] + 0x1785c
29: (0xf73d8f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
6-07 17:08:14.441+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:439,9.198622,0.806892,3.302222
06-07 17:08:14.441+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:441,0.059254,-0.073349,0.078341
06-07 17:08:14.441+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.441+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.441+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.441+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:450,-0.140000,-0.630000,0.210000
06-07 17:08:14.451+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:451,9.199265,0.805491,3.300771
06-07 17:08:14.451+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.451+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:454,0.014684,0.038351,0.048540
06-07 17:08:14.451+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.451+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.461+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:464,9.199251,0.802259,3.301598
06-07 17:08:14.461+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:461,1.050000,-0.280000,-0.070000
06-07 17:08:14.461+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:467,0.061493,0.011878,0.009529
06-07 17:08:14.461+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.461+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.471+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:474,0.084671,0.007177,-0.005153
06-07 17:08:14.471+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.471+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:479,9.198227,0.803246,3.304208
06-07 17:08:14.471+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.481+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.481+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:482,1.470000,0.070000,-0.070000
06-07 17:08:14.481+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:487,9.196854,0.806854,3.307151
06-07 17:08:14.481+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:486,0.024036,-0.099348,0.025545
06-07 17:08:14.481+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.491+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.491+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:497,0.061798,-0.143941,0.049543
06-07 17:08:14.491+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.491+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:500,9.196048,0.808111,3.309086
06-07 17:08:14.501+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.501+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.501+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:502,0.070000,-0.070000,0.280000
06-07 17:08:14.501+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:507,9.196290,0.806775,3.308739
06-07 17:08:14.501+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.511+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:513,9.195971,0.805855,3.309849
06-07 17:08:14.511+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.511+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.511+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:512,0.054384,0.030008,0.043844
06-07 17:08:14.511+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:519,9.195599,0.812019,3.309378
06-07 17:08:14.511+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.511+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.521+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:521,-0.770000,-0.280000,-0.070000
06-07 17:08:14.521+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:525,9.194939,0.815590,3.310332
06-07 17:08:14.521+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.521+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:530,9.193660,0.811441,3.314902
06-07 17:08:14.531+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.531+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:530,-0.002465,0.084931,-0.072013
06-07 17:08:14.531+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:08:14.531+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:536,9.192971,0.812708,3.316499
06-07 17:08:14.531+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.541+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:08:14:541,373.000000
06-07 17:08:14.541+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:543,9.193244,0.813924,3.315446
06-07 17:08:14.541+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.541+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.541+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.541+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:549,9.194748,0.810763,3.312049
06-07 17:08:14.541+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.551+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:548,0.700000,-0.140000,-0.280000
06-07 17:08:14.551+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.551+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:553,0.047245,-0.010082,-0.021662
06-07 17:08:14.551+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:555,9.195471,0.808855,3.310506
06-07 17:08:14.551+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.561+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:561,1.400000,0.140000,-0.140000
06-07 17:08:14.561+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.561+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:567,9.195993,0.813217,3.307985
06-07 17:08:14.561+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:565,0.048994,-0.075680,0.015681
06-07 17:08:14.561+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.571+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.571+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.571+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:579,9.197665,0.813470,3.303271
06-07 17:08:14.571+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:575,0.025080,0.001729,0.041176
06-07 17:08:14.581+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:08:14.581+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:579,0.350000,-0.210000,0.070000
06-07 17:08:14.581+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:08:14:586,81
06-07 17:08:14.581+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.581+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.591+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:595,9.197126,0.811348,3.305295
06-07 17:08:14.591+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:594,0.050033,0.070134,0.017029
06-07 17:08:14.591+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.591+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.601+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.601+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:603,0.350000,-0.420000,0.070000
06-07 17:08:14.601+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:609,9.197520,0.809713,3.304598
06-07 17:08:14.601+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:606,0.049013,0.040205,0.054765
06-07 17:08:14.611+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.611+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.611+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.621+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:618,1.050000,0.700000,0.140000
06-07 17:08:14.621+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:616,0.021105,-0.023265,-0.018955
06-07 17:08:14.621+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:623,9.196340,0.812528,3.307192
06-07 17:08:14.621+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.621+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:631,0.028041,-0.024322,0.036427
06-07 17:08:14.631+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.631+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.631+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.641+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:639,-0.350000,0.210000,0.070000
06-07 17:08:14.641+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:639,9.197027,0.812353,3.305324
06-07 17:08:14.641+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.651+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:645,0.042716,0.110596,-0.022110
06-07 17:08:14.651+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.651+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.651+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:659,0.007197,0.061361,-0.026425
06-07 17:08:14.651+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:652,9.198321,0.811094,3.302028
06-07 17:08:14.651+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.661+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:659,-0.280000,-0.280000,0.070000
06-07 17:08:14.661+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.661+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:665,9.198393,0.816596,3.300473
06-07 17:08:14.661+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:670,0.029392,-0.078601,0.087476
06-07 17:08:14.671+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.671+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.671+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.671+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:676,9.197154,0.819709,3.303154
06-07 17:08:14.681+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.681+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:682,0.025886,0.014082,0.051800
06-07 17:08:14.681+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:678,0.700000,-0.490000,-0.140000
06-07 17:08:14.681+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:688,9.197114,0.817176,3.303892
06-07 17:08:14.681+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.691+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.691+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:693,0.045716,0.031959,0.033453
06-07 17:08:14.691+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.691+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.701+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:704,0.052623,-0.050613,-0.020529
06-07 17:08:14.701+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.701+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:698,9.198028,0.816039,3.301630
06-07 17:08:14.701+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.701+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:704,1.540000,-0.210000,-0.070000
06-07 17:08:14.701+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:709,0.046332,-0.047453,0.021153
06-07 17:08:14.701+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.711+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:714,0.038432,0.078882,-0.003625
06-07 17:08:14.711+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.711+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.711+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:713,9.199856,0.816571,3.296399
06-07 17:08:14.711+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:721,0.061837,0.019486,-0.058532
06-07 17:08:14.721+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.721+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:720,0.840000,0.070000,-0.070000
06-07 17:08:14.721+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.721+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:726,0.062558,-0.033410,0.051466
06-07 17:08:14.721+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.721+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:732,0.046348,-0.048037,0.003979
06-07 17:08:14.731+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:08:14.731+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.731+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:08:14:737,374.000000
06-07 17:08:14.731+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:738,-0.011474,0.042132,0.086032
06-07 17:08:14.731+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.731+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.741+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:744,0.051920,0.001031,0.002081
06-07 17:08:14.741+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.741+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:749,0.039268,-0.022722,-0.027157
06-07 17:08:14.741+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:730,9.199966,0.819227,3.295432
06-07 17:08:14.741+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.751+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:745,-0.210000,0.350000,0.420000
06-07 17:08:14.751+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.751+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.751+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:754,0.037974,0.112535,-0.007112
06-07 17:08:14.751+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:761,9.199967,0.821411,3.294886
06-07 17:08:14.751+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:758,-0.910000,-0.350000,0.210000
06-07 17:08:14.761+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.761+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:766,0.009189,0.073534,0.051872
06-07 17:08:14.761+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.761+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:771,9.200359,0.817593,3.294739
06-07 17:08:14.771+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.771+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.771+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.771+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:776,0.048713,-0.042042,0.044405
06-07 17:08:14.771+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:779,0.840000,-0.280000,0.210000
06-07 17:08:14.781+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:08:14.781+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:08:14:786,80
06-07 17:08:14.781+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.781+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:783,9.200459,0.813772,3.295406
06-07 17:08:14.791+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:794,0.051146,-0.029938,-0.001797
06-07 17:08:14.791+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.801+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:801,0.074161,-0.000087,-0.042606
06-07 17:08:14.801+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.801+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.801+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:806,1.470000,-0.280000,0.210000
06-07 17:08:14.811+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.821+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:818,0.280000,-0.280000,0.210000
06-07 17:08:14.831+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.851+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:806,9.202421,0.814749,3.289684
06-07 17:08:14.851+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.851+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.871+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:860,9.202766,0.813185,3.289103
06-07 17:08:14.881+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:838,-0.210000,-0.280000,0.070000
06-07 17:08:14.881+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.891+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:878,0.072332,0.052023,0.022446
06-07 17:08:14.891+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.891+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:892,0.630000,-0.280000,0.070000
06-07 17:08:14.891+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.901+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:905,9.203142,0.812987,3.288101
06-07 17:08:14.901+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.911+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:909,1.120000,-0.280000,0.210000
06-07 17:08:14.911+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.921+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:912,0.050686,0.068511,0.018627
06-07 17:08:14.921+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.921+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:926,0.210000,-0.280000,-0.210000
06-07 17:08:14.921+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.931+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:08:14.931+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:935,0.048292,-0.058100,0.016781
06-07 17:08:14.931+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:927,9.203294,0.813227,3.287616
06-07 17:08:14.931+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:08:14:938,373.000000
06-07 17:08:14.941+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.941+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.941+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.941+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:951,0.043115,-0.073426,0.091105
06-07 17:08:14.951+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:949,0.280000,0.210000,0.070000
06-07 17:08:14.951+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:947,9.204478,0.812567,3.284464
06-07 17:08:14.951+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.961+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.961+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.971+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:970,9.204647,0.813592,3.283737
06-07 17:08:14.971+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:967,-0.420000,-0.140000,0.070000
06-07 17:08:14.971+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:972,0.038228,0.018930,-0.041167
06-07 17:08:14.971+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:14.971+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:14.981+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:08:14.981+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:984,0.140000,-0.630000,0.070000
06-07 17:08:14.981+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:08:14:986,80
06-07 17:08:14.991+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:14.991+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.001+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:14:994,9.203610,0.814762,3.286352
06-07 17:08:15.001+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:14:996,0.026696,-0.022724,0.036340
06-07 17:08:15.001+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.001+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.011+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:14:999,1.400000,-0.210000,-0.420000
06-07 17:08:15.021+0200 W/LOCATION(16473): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:08:15.021+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.031+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:10,9.203218,0.813100,3.287863
06-07 17:08:15.031+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:30,1.120000,0.350000,-0.280000
06-07 17:08:15.031+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.031+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:23,0.040708,0.005160,0.003421
06-07 17:08:15.041+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.041+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.041+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:45,1.120000,0.280000,0.140000
06-07 17:08:15.051+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:08:15.051+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:08:15.051+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:08:15.061+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:54,9.204048,0.807767,3.286851
06-07 17:08:15.061+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.061+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:52,0.011618,0.005358,0.033137
06-07 17:08:15.071+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.071+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.071+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:70,-0.770000,-0.350000,0.210000
06-07 17:08:15.071+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.081+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:77,0.059322,-0.009239,0.014479
06-07 17:08:15.081+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:79,9.205576,0.806332,3.282922
06-07 17:08:15.091+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.091+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:85,0.980000,-0.420000,-0.210000
06-07 17:08:15.101+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.101+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.101+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:103,0.036602,0.015350,-0.001512
06-07 17:08:15.111+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:106,9.205455,0.812105,3.281840
06-07 17:08:15.111+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:115,2.030000,0.420000,-0.350000
06-07 17:08:15.111+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.121+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:125,0.029256,0.028682,0.078179
06-07 17:08:15.121+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.131+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.131+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:08:15.131+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:137,-0.140000,0.420000,0.070000
06-07 17:08:15.141+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:08:15:138,374.000000
06-07 17:08:15.141+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:133,9.205194,0.818660,3.280943
06-07 17:08:15.141+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.151+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.151+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.151+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:161,-1.050000,-0.140000,0.770000
06-07 17:08:15.161+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:154,9.205573,0.816551,3.280404
06-07 17:08:15.161+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.161+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:156,0.020720,-0.025130,0.042064
06-07 17:08:15.161+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.171+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.171+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:180,0.280000,0.210000,0.490000
06-07 17:08:15.171+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.181+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:08:15.181+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:08:15:186,81
06-07 17:08:15.181+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:169,9.205869,0.813861,3.280244
06-07 17:08:15.191+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:172,0.066577,-0.102432,0.038160
06-07 17:08:15.191+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.191+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:198,0.082496,-0.054028,-0.046970
06-07 17:08:15.191+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.201+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.211+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:214,9.205447,0.823007,3.279143
06-07 17:08:15.211+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.221+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:185,0.980000,-0.070000,-0.070000
06-07 17:08:15.221+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.231+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:202,0.049862,0.102941,-0.009541
06-07 17:08:15.231+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:222,9.205293,0.829565,3.277924
06-07 17:08:15.241+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.241+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:231,0.700000,-0.140000,-0.210000
06-07 17:08:15.241+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.251+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.251+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:246,0.061948,0.140239,0.037005
06-07 17:08:15.251+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.261+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:257,9.206095,0.824906,3.276847
06-07 17:08:15.261+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.271+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:252,0.070000,-0.070000,0.070000
06-07 17:08:15.271+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:262,0.009566,-0.026636,-0.000383
06-07 17:08:15.271+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.281+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:285,-0.280000,-0.140000,0.420000
06-07 17:08:15.291+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.291+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:275,9.206052,0.819420,3.278346
06-07 17:08:15.291+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.301+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:296,0.078579,-0.065205,0.057584
06-07 17:08:15.301+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.301+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:308,-0.490000,-0.140000,0.560000
06-07 17:08:15.311+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.311+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:305,9.205739,0.816887,3.279854
06-07 17:08:15.321+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.331+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:318,-0.010251,0.157625,-0.011648
06-07 17:08:15.331+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.331+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:08:15.321+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.331+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:326,0.210000,0.770000,-0.210000
06-07 17:08:15.331+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:08:15.341+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:08:15:341,373.000000
06-07 17:08:15.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:08:15.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:08:15.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:08:15.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:08:15.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:08:15.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:08:15.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:08:15.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:08:15.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:08:15.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:08:15.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:08:15.351+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391295357,000000, pattern:[H:mm][0;m
06-07 17:08:15.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:08:15.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:08:15.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:08:15.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:08:15.351+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:08:15.351+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:08][0;m
06-07 17:08:15.351+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:345,9.205950,0.820198,3.278436
06-07 17:08:15.351+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:336,0.040420,0.143693,-0.029690
06-07 17:08:15.351+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.361+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:355,1.050000,0.770000,-0.140000
06-07 17:08:15.361+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.371+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.381+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:08:15.381+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:374,0.083645,-0.049505,0.040921
06-07 17:08:15.381+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:08:15:386,81
06-07 17:08:15.381+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.391+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:374,9.206455,0.823537,3.276180
06-07 17:08:15.391+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.401+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:376,0.140000,0.210000,0.210000
06-07 17:08:15.401+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.401+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:397,0.003880,-0.097488,0.077890
06-07 17:08:15.411+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:399,9.208025,0.823801,3.271698
06-07 17:08:15.411+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.411+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:410,-0.280000,0.350000,0.140000
06-07 17:08:15.421+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.411+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.411+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:418,0.030244,-0.060895,0.076392
06-07 17:08:15.421+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:426,9.208974,0.819907,3.270007
06-07 17:08:15.421+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.441+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.441+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:432,0.040128,0.058886,-0.006473
06-07 17:08:15.441+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.441+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:431,0.910000,0.840000,0.140000
06-07 17:08:15.441+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.451+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:454,0.030346,0.074718,-0.028983
06-07 17:08:15.451+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:448,9.208045,0.817148,3.273310
06-07 17:08:15.461+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:453,1.120000,1.050000,-0.350000
06-07 17:08:15.461+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.461+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.461+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.471+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:472,0.025055,0.025915,-0.062619
06-07 17:08:15.481+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:468,9.207723,0.817434,3.274146
06-07 17:08:15.481+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.481+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.481+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:473,1.330000,0.630000,-0.700000
06-07 17:08:15.491+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.491+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:488,9.208270,0.817711,3.272536
06-07 17:08:15.501+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:492,0.040235,-0.050919,0.011255
06-07 17:08:15.501+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.501+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:498,1.960000,1.050000,-0.910000
06-07 17:08:15.501+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.511+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.511+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:512,0.008179,-0.070953,0.032089
06-07 17:08:15.511+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:514,3.640000,1.120000,-0.210000
06-07 17:08:15.511+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.521+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:516,9.209084,0.817352,3.270337
06-07 17:08:15.521+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.521+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.521+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:527,0.021072,-0.010767,0.012035
06-07 17:08:15.531+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:08:15.531+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:528,9.209206,0.818163,3.269789
06-07 17:08:15.541+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:08:15:538,375.000000
06-07 17:08:15.541+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.541+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.541+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:524,2.380000,2.730000,-0.070000
06-07 17:08:15.541+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.551+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:555,-0.560000,3.010000,0.840000
06-07 17:08:15.551+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:547,0.042930,0.015268,-0.010336
06-07 17:08:15.561+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:551,9.209384,0.820014,3.268824
06-07 17:08:15.561+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.571+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.571+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.581+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:08:15.581+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:08:15:586,81
06-07 17:08:15.591+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:569,9.208671,0.826102,3.269299
06-07 17:08:15.591+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.591+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:599,9.208679,0.828237,3.268735
06-07 17:08:15.591+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:576,0.039989,0.000634,-0.051796
06-07 17:08:15.591+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.601+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:582,-2.660000,3.290000,1.890000
06-07 17:08:15.601+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.601+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:605,0.055925,0.015350,0.007829
06-07 17:08:15.611+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.621+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.621+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:630,9.209938,0.836866,3.262986
06-07 17:08:15.621+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.631+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:609,-6.090000,5.390000,4.130000
06-07 17:08:15.631+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.641+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:624,0.022305,0.009754,-0.058621
06-07 17:08:15.641+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.651+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:637,-13.580000,8.890000,5.460000
06-07 17:08:15.651+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.661+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:635,9.209465,0.850728,3.260737
06-07 17:08:15.661+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:652,-0.020945,0.082080,-0.040906
06-07 17:08:15.661+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.671+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:657,-18.690001,12.460000,6.930000
06-07 17:08:15.671+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.671+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.671+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:15:681,9.209984,0.862881,3.256075
06-07 17:08:15.681+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:15:674,0.022840,-0.014935,-0.070095
06-07 17:08:15.691+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:678,-21.350000,13.160000,7.770000
06-07 17:08:15.691+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:15.691+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:15:698,-21.000000,12.460000,8.260000
06-07 17:08:15.701+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:15.701+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:08:15.701+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11164736c6f63152838409
