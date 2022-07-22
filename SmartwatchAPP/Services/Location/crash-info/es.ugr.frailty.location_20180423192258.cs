S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 13114
Date: 2018-04-23 19:22:58+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf718852d, r5   = 0xf7505958
r6   = 0xffbfd610, r7   = 0xffbfd4c0
r8   = 0xf7518c18, r9   = 0x00000000
r10  = 0xffbfd59c, fp   = 0xffbfd610
ip   = 0x00000001, sp   = 0xffbfd498
lr   = 0xf7188539, pc   = 0xf71f1228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     24124 KB
Buffers:     50252 KB
Cached:     234184 KB
VmPeak:      53560 KB
VmSize:      53556 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12136 KB
VmRSS:       12136 KB
VmData:      11284 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 13114 TID = 13114
13114 13182 

Maps Information
f4053000 f4852000 rw-p [stack:13182]
f4859000 f485b000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4863000 f4867000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4870000 f4872000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f487a000 f487d000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f488c000 f4891000 r-xp /usr/lib/libsystem.so.0.0.0
f489c000 f489f000 r-xp /lib/libattr.so.1.1.0
f48a7000 f48b7000 r-xp /usr/lib/libmdm-common.so.1.1.24
f48bf000 f48c8000 r-xp /usr/lib/libedbus.so.1.7.99
f48d0000 f48d1000 r-xp /usr/lib/libresponse.so.0.2.96
f48da000 f48df000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6181000 f6287000 r-xp /usr/lib/libicuuc.so.57.1
f629d000 f6425000 r-xp /usr/lib/libicui18n.so.57.1
f6435000 f6442000 r-xp /usr/lib/libail.so.0.1.0
f644b000 f6452000 r-xp /usr/lib/libminizip.so.1.0.0
f645b000 f6604000 r-xp /usr/lib/libcrypto.so.1.0.0
f6624000 f666b000 r-xp /usr/lib/libssl.so.1.0.0
f6677000 f6679000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6681000 f6688000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6691000 f6698000 r-xp /lib/libcrypt-2.13.so
f66c9000 f66cc000 r-xp /lib/libcap.so.2.21
f66d4000 f66d6000 r-xp /usr/lib/libiri.so
f66de000 f6727000 r-xp /usr/lib/libmdm.so.1.2.69
f672f000 f6735000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f673d000 f6760000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f676a000 f676c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6774000 f6791000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f679a000 f679e000 r-xp /usr/lib/libsmack.so.1.0.0
f67a7000 f67c0000 r-xp /usr/lib/libnetwork.so.0.0.0
f67c9000 f67d1000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f67d9000 f67df000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f67e8000 f67ea000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f67f3000 f6803000 r-xp /lib/libresolv-2.13.so
f6807000 f681f000 r-xp /usr/lib/liblzma.so.5.0.3
f6828000 f682a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6832000 f684c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6854000 f6883000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f688c000 f689b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f68a5000 f68af000 r-xp /usr/lib/libsensord-shared.so
f68b8000 f698b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6996000 f69ac000 r-xp /lib/libz.so.1.2.5
f69b4000 f69b9000 r-xp /usr/lib/libffi.so.5.0.10
f69c1000 f69c2000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f69ca000 f69da000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f69e2000 f69fb000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a03000 f6a05000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a0d000 f6a82000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a8c000 f6a92000 r-xp /lib/librt-2.13.so
f6a9b000 f6ab9000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ac3000 f6ac4000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6acc000 f6aef000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6af7000 f6afc000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b04000 f6b2e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b37000 f6b4e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b56000 f6bbf000 r-xp /lib/libm-2.13.so
f6bc8000 f6c5c000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c6f000 f6c74000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c7c000 f6c83000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c8b000 f6cb5000 r-xp /usr/lib/libsensor.so.1.9.6
f6cbe000 f6d8a000 r-xp /usr/lib/libxml2.so.2.7.8
f6d97000 f6d99000 r-xp /usr/lib/libiniparser.so.0
f6da2000 f6da8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6db1000 f6e81000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e82000 f6eb6000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ebf000 f6efb000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f03000 f6f06000 r-xp /usr/lib/libbundle.so.0.1.22
f6f0e000 f6f14000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f1c000 f6f5d000 r-xp /usr/lib/libeina.so.1.7.99
f6f66000 f6f7d000 r-xp /usr/lib/libecore.so.1.7.99
f6f94000 f6f9d000 r-xp /usr/lib/libvconf.so.0.2.45
f6fa5000 f6fb9000 r-xp /lib/libpthread-2.13.so
f6fc4000 f6fd1000 r-xp /usr/lib/libaul.so.0.1.0
f6fdb000 f6fdd000 r-xp /lib/libdl-2.13.so
f6fe6000 f6ff1000 r-xp /lib/libunwind.so.8.0.1
f701e000 f7026000 r-xp /lib/libgcc_s-4.6.so.1
f7027000 f714b000 r-xp /lib/libc-2.13.so
f7159000 f715b000 r-xp /usr/lib/libdlog.so.0.0.0
f7163000 f716f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7178000 f717d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7185000 f7194000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f719c000 f71a0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f71a9000 f71ac000 r-xp /usr/lib/libappcore-agent.so.1.1
f71b4000 f71b6000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f71be000 f71c2000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f71ca000 f71e7000 r-xp /lib/ld-2.13.so
f71f0000 f71f3000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f71f3000 f71f7000 r-xp /usr/lib/libsys-assert.so
f74e8000 f7572000 rw-p [heap]
ffbde000 ffbff000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13114)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf71f1228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7188539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e8f3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e8dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e99e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e9fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e9fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6ed475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6ecf1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e8dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e99e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e9fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e9fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6ed1e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6ed2017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6ed9f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48711fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4864171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6937663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6de4fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6de67a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f76ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f71b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f725a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f72879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf71aa183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71aa7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71f14f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf703e85c) [/lib/libc.so.6] + 0x1785c
29: (0xf71f0f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
roscope
04-23 19:22:57.809+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:57:815,0.182103,-0.020943,0.035263
04-23 19:22:57.809+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:57.819+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:57:822,4.699504,-2.232504,8.453842
04-23 19:22:57.819+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:57.829+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:57:833,0.157453,0.023316,0.064705
04-23 19:22:57.829+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:57.839+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:57.849+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:57:839,4.523114,-2.202465,8.417896
04-23 19:22:57.849+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:57.849+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:57.859+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:57:857,0.183568,0.051318,0.083803
04-23 19:22:57.859+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:57:859,4.527640,-2.196226,8.417092
04-23 19:22:57.859+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:57.869+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:57.879+0200 I/heartrate(13102): capturing data from es.ugr.frailty.heartrate
04-23 19:22:57.879+0200 I/heartrate(13102): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:22:57.879+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:57:886,4.534638,-2.191194,8.414637
04-23 19:22:57.889+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:57:848,4.677969,-2.184647,8.482556
04-23 19:22:57.889+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:57:822,2.030000,-0.070000,0.070000
04-23 19:22:57.889+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:57:872,0.202970,0.028329,0.005643
04-23 19:22:57.889+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:57.889+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:57.889+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:57:898,0.243829,-0.010203,0.003313
04-23 19:22:57.899+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:57.899+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:57.909+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:57:917,4.706682,-2.151148,8.501699
04-23 19:22:57.919+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:57:921,1.820000,-0.210000,-0.140000
04-23 19:22:57.919+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:57.919+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:57:905,4.542727,-2.187372,8.411267
04-23 19:22:57.919+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:57.919+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:57.919+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:57.929+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:57:931,1.190000,-0.210000,-0.490000
04-23 19:22:57.929+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:57.929+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:57:933,0.230955,-0.124095,0.004291
04-23 19:22:57.929+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:57.929+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:57:936,1.260000,-0.210000,-0.980000
04-23 19:22:57.929+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:57.939+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:57:941,1.260000,0.140000,-1.330000
04-23 19:22:57.939+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:57.939+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:57:945,-0.280000,0.140000,-1.470000
04-23 19:22:57.939+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:57.949+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:57:950,-0.210000,-0.280000,-0.980000
04-23 19:22:57.949+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:57:937,0.183119,-0.146622,-0.006308
04-23 19:22:57.949+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:57.949+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:57:939,4.552277,-2.191166,8.405115
04-23 19:22:57.949+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:57.949+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:57:933,4.730610,-2.167897,8.422735
04-23 19:22:57.949+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:57.949+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:57:958,0.122376,-0.260785,0.088051
04-23 19:22:57.949+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:57.959+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:57:962,4.778467,-2.201397,8.417950
04-23 19:22:57.959+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:57:963,4.560378,-2.196643,8.399291
04-23 19:22:57.959+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:57.959+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:57:961,0.280000,-0.980000,0.420000
04-23 19:22:57.959+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:57.959+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:57.959+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:57.969+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:57:971,0.100477,-0.171514,0.073108
04-23 19:22:57.969+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:57:973,4.773681,-2.311467,8.415558
04-23 19:22:57.969+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:57:971,1.260000,-1.120000,1.960000
04-23 19:22:57.969+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:57.969+0200 I/heartrate(13102): capturing data from es.ugr.frailty.heartrate
04-23 19:22:57.979+0200 I/heartrate(13102): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:22:57.979+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:57:981,4.735396,-2.337788,8.398808
04-23 19:22:57.979+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:57.979+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:57:967,4.563134,-2.206952,8.395091
04-23 19:22:57.979+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:57.979+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:57:986,4.682754,-2.457429,8.487342
04-23 19:22:57.979+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:57.979+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:57.989+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:57:993,1.400000,-0.630000,2.520000
04-23 19:22:57.989+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:57:990,4.663611,-2.378466,8.468199
04-23 19:22:57.989+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:22:57.989+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:22:57.999+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:22:57.999+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:22:57.999+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:22:57.999+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:57.999+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:57.999+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:57:989,4.562954,-2.213090,8.393573
04-23 19:22:57.999+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:57.999+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.009+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:10,-0.350000,0.420000,2.100000
04-23 19:22:58.009+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:4,0.220298,0.033229,0.096162
04-23 19:22:58.009+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.019+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:4,4.783253,-2.179861,8.489735
04-23 19:22:58.019+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.019+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:20,0.284482,0.144374,0.106287
04-23 19:22:58.019+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:8,4.565770,-2.209380,8.393019
04-23 19:22:58.019+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.019+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.019+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.029+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:31,-1.610000,1.890000,0.980000
04-23 19:22:58.029+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:26,4.572039,-2.202635,8.391379
04-23 19:22:58.029+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.029+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:31,0.189678,-0.003547,0.088784
04-23 19:22:58.029+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:24,4.850252,-2.065006,8.499306
04-23 19:22:58.029+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.029+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:37,4.574984,-2.203928,8.389435
04-23 19:22:58.039+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:40,4.761717,-2.206182,8.480164
04-23 19:22:58.039+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.049+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.049+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.049+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:53,-0.210000,3.360000,-0.350000
04-23 19:22:58.049+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:54,0.091020,-0.047718,0.196012
04-23 19:22:58.049+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.049+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:57,4.568945,-2.202905,8.392993
04-23 19:22:58.049+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:53,4.666004,-2.251646,8.585447
04-23 19:22:58.059+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.059+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.059+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.059+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.069+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:71,0.700000,4.410000,-1.190000
04-23 19:22:58.069+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:71,0.180808,0.092436,0.132634
04-23 19:22:58.069+0200 I/heartrate(13102): capturing data from es.ugr.frailty.heartrate
04-23 19:22:58.069+0200 I/heartrate(13102): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:22:58.079+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:70,4.565626,-2.193319,8.397308
04-23 19:22:58.079+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:71,4.749753,-2.110470,8.525627
04-23 19:22:58.079+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.079+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.089+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:92,-1.750000,5.040000,-1.540000
04-23 19:22:58.089+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:92,0.164984,0.075671,0.137890
04-23 19:22:58.089+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.089+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.089+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:98,4.564274,-2.188192,8.399382
04-23 19:22:58.099+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:99,4.730610,-2.117648,8.535198
04-23 19:22:58.099+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.109+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.109+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:112,0.135230,-0.058669,0.066424
04-23 19:22:58.109+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.109+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.109+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:116,-2.100000,5.670000,-2.170000
04-23 19:22:58.119+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:118,4.699504,-2.246860,8.465806
04-23 19:22:58.119+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:120,4.562647,-2.189799,8.399846
04-23 19:22:58.119+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.119+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.129+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:131,0.136857,-0.088168,0.051603
04-23 19:22:58.129+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:131,-0.140000,7.000000,-3.010000
04-23 19:22:58.129+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.129+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.129+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:135,4.556945,-2.188555,8.403265
04-23 19:22:58.129+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:136,4.699504,-2.277967,8.451449
04-23 19:22:58.139+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.139+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.149+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:151,-0.070000,7.210000,-3.640000
04-23 19:22:58.149+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.149+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:151,0.159308,-0.003270,0.045792
04-23 19:22:58.149+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.149+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:156,4.552749,-2.182850,8.407022
04-23 19:22:58.159+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:157,4.716253,-2.191825,8.449057
04-23 19:22:58.159+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.169+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.169+0200 I/heartrate(13102): capturing data from es.ugr.frailty.heartrate
04-23 19:22:58.179+0200 I/heartrate(13102): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:22:58.179+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:173,0.113256,-0.092724,0.001356
04-23 19:22:58.189+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.189+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.189+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.189+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:22:58.189+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:22:58.189+0200 W/LOCATION(13114): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:22:58.199+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:197,4.666004,-2.275574,8.408379
04-23 19:22:58.199+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.209+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:171,-1.820000,6.510000,-3.780000
04-23 19:22:58.209+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.209+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:199,0.030986,-0.210398,-0.010898
04-23 19:22:58.209+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.219+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:198,4.551269,-2.184817,8.407312
04-23 19:22:58.219+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.219+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:219,-1.190000,5.390000,-3.780000
04-23 19:22:58.219+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.229+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:208,4.582255,-2.395216,8.396415
04-23 19:22:58.229+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.229+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:220,-0.056250,-0.220151,0.036782
04-23 19:22:58.229+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.239+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:233,0.700000,4.060000,-3.360000
04-23 19:22:58.239+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.239+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:225,4.547578,-2.191814,8.407489
04-23 19:22:58.239+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.239+0200 I/servicemanager(13086): es.ugr.frailty.location sleep timeout
04-23 19:22:58.239+0200 W/AUL     (13086): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 19:22:58.249+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:22:58.249+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13086
04-23 19:22:58.259+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:253,1.470000,2.450000,-2.240000
04-23 19:22:58.259+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.259+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13114
04-23 19:22:58.259+0200 W/AUL     (13086): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13114)
04-23 19:22:58.259+0200 I/servicemanager(13086): es.ugr.frailty.location stop request sent!
04-23 19:22:58.259+0200 I/servicemanager(13086): App control destroyed.
04-23 19:22:58.269+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:264,0.350000,0.280000,-0.630000
04-23 19:22:58.269+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.269+0200 I/heartrate(13102): capturing data from es.ugr.frailty.heartrate
04-23 19:22:58.269+0200 I/heartrate(13102): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:22:58.279+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:235,4.491328,-2.411965,8.444271
04-23 19:22:58.279+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.279+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:275,0.770000,-1.960000,0.770000
04-23 19:22:58.279+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:242,0.000332,-0.097931,-0.002527
04-23 19:22:58.279+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.279+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:250,4.538852,-2.196786,8.410906
04-23 19:22:58.279+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.289+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.289+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:294,1.260000,-3.990000,2.030000
04-23 19:22:58.289+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:291,0.007301,-0.107896,-0.000312
04-23 19:22:58.289+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.299+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:292,4.534276,-2.196392,8.413476
04-23 19:22:58.299+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.299+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.299+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:286,4.539185,-2.294717,8.408379
04-23 19:22:58.309+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:310,2.240000,-4.830000,2.590000
04-23 19:22:58.309+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.319+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:318,4.541577,-2.304288,8.413164
04-23 19:22:58.319+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.319+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.319+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:307,4.533682,-2.200075,8.412834
04-23 19:22:58.319+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.329+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:299,0.010288,-0.113785,-0.028384
04-23 19:22:58.329+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.329+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:331,3.990000,-4.550000,3.150000
04-23 19:22:58.339+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:333,4.535710,-2.205251,8.410385
04-23 19:22:58.339+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:334,0.084830,-0.166037,-0.054648
04-23 19:22:58.339+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.339+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.349+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.349+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:348,0.123492,-0.179496,0.013358
04-23 19:22:58.349+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.349+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:353,5.460000,-3.850000,3.290000
04-23 19:22:58.349+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:349,4.542512,-2.213327,8.404592
04-23 19:22:58.359+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:326,4.543970,-2.313859,8.384450
04-23 19:22:58.359+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.359+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.359+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:363,4.548960,-2.220171,8.399297
04-23 19:22:58.359+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.359+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:360,0.133794,-0.155901,0.080867
04-23 19:22:58.359+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.369+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.369+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:370,4.900000,-2.730000,3.430000
04-23 19:22:58.369+0200 I/heartrate(13102): capturing data from es.ugr.frailty.heartrate
04-23 19:22:58.369+0200 I/heartrate(13102): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:22:58.379+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:365,4.620540,-2.371287,8.355737
04-23 19:22:58.379+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:373,4.551064,-2.222678,8.397494
04-23 19:22:58.379+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.379+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:373,0.153226,-0.072039,0.154453
04-23 19:22:58.379+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.379+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.389+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.389+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:388,4.549396,-2.218136,8.399599
04-23 19:22:58.389+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.389+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:395,4.666004,-2.392823,8.417950
04-23 19:22:58.389+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:389,0.166858,0.102880,0.118850
04-23 19:22:58.389+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:22:58.389+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:22:58.389+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.399+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:397,4.548237,-2.206750,8.403224
04-23 19:22:58.399+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.399+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:393,3.150000,-2.590000,3.150000
04-23 19:22:58.399+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.399+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:405,4.544798,-2.199959,8.406865
04-23 19:22:58.399+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.409+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:401,0.144088,0.024496,0.313829
04-23 19:22:58.409+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.409+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:410,5.180000,-0.630000,2.730000
04-23 19:22:58.409+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.409+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:414,0.200170,0.194773,0.097226
04-23 19:22:58.419+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:418,4.542019,-2.182820,8.412832
04-23 19:22:58.419+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:409,4.682754,-2.376073,8.480164
04-23 19:22:58.419+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.419+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.419+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.429+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:430,-0.210000,0.770000,2.310000
04-23 19:22:58.429+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.429+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:432,0.109628,-0.016185,0.031439
04-23 19:22:58.429+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:436,4.541827,-2.184533,8.412492
04-23 19:22:58.429+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:430,4.704289,-2.294717,8.551948
04-23 19:22:58.439+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.439+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:443,4.716253,-2.115255,8.518449
04-23 19:22:58.439+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.439+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.449+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.449+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.449+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:453,0.152891,-0.059935,-0.274502
04-23 19:22:58.449+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:451,-3.360000,7.210000,2.100000
04-23 19:22:58.449+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:455,4.541943,-2.194118,8.409934
04-23 19:22:58.459+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:450,4.692325,-2.182254,8.717053
04-23 19:22:58.459+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.459+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.459+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.469+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.469+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:470,3.150000,1.750000,1.050000
04-23 19:22:58.469+0200 I/heartrate(13102): capturing data from es.ugr.frailty.heartrate
04-23 19:22:58.469+0200 I/heartrate(13102): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:22:58.479+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:472,4.541265,-2.183716,8.413007
04-23 19:22:58.479+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:473,0.246096,0.081255,0.060658
04-23 19:22:58.479+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:466,4.744967,-2.005185,8.504091
04-23 19:22:58.479+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.479+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:487,4.651647,-2.199004,8.444271
04-23 19:22:58.479+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.479+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.489+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.489+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.489+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:492,4.480000,2.240000,-0.630000
04-23 19:22:58.489+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:494,4.534247,-2.167542,8.420971
04-23 19:22:58.489+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:496,0.107989,0.135459,0.093477
04-23 19:22:58.499+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:491,4.694718,-2.244468,8.137990
04-23 19:22:58.499+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.499+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.499+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.509+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.509+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:510,1.470000,1.330000,-1.260000
04-23 19:22:58.509+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:511,4.535498,-2.163003,8.421464
04-23 19:22:58.519+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:513,0.186792,-0.026676,0.119013
04-23 19:22:58.519+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:507,4.788038,-2.112862,8.470592
04-23 19:22:58.519+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.519+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.519+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.529+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.529+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:531,-0.630000,2.030000,-1.330000
04-23 19:22:58.529+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:532,4.537316,-2.161543,8.420859
04-23 19:22:58.529+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:533,0.106578,0.002284,0.037165
04-23 19:22:58.529+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:527,4.649254,-2.048256,8.506484
04-23 19:22:58.529+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.539+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:542,4.721039,-2.194218,8.539984
04-23 19:22:58.539+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.539+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.539+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.549+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.549+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:551,-2.030000,1.400000,-1.330000
04-23 19:22:58.549+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:552,4.543319,-2.166768,8.416279
04-23 19:22:58.549+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:553,0.171759,-0.106853,0.085625
04-23 19:22:58.549+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:547,4.642076,-2.160719,8.458629
04-23 19:22:58.549+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.559+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:562,4.709075,-2.268396,8.506484
04-23 19:22:58.559+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.559+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.569+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.569+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:570,-2.730000,2.590000,-0.630000
04-23 19:22:58.569+0200 I/heartrate(13102): capturing data from es.ugr.frailty.heartrate
04-23 19:22:58.569+0200 I/heartrate(13102): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:22:58.579+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:571,4.547552,-2.166807,8.413982
04-23 19:22:58.579+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:573,0.139435,0.049120,0.049527
04-23 19:22:58.579+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.589+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.589+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:596,0.101703,-0.075268,0.140358
04-23 19:22:58.589+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.589+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:22:58.589+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:22:58.599+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.609+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:600,4.547877,-2.170122,8.412952
04-23 19:22:58.609+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.609+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.619+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:608,4.682754,-2.117648,8.465806
04-23 19:22:58.619+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.619+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:619,0.173162,-0.086310,0.107889
04-23 19:22:58.629+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:606,-1.820000,2.240000,-0.980000
04-23 19:22:58.629+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:618,4.544279,-2.166745,8.415767
04-23 19:22:58.629+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.629+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.629+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.629+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:624,4.649254,-2.242075,8.554340
04-23 19:22:58.629+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:635,0.073869,0.013205,0.045254
04-23 19:22:58.639+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:634,1.960000,3.500000,-1.540000
04-23 19:22:58.639+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.639+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.639+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:634,4.539363,-2.161428,8.419785
04-23 19:22:58.649+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.649+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.649+0200 W/WATCH_CORE( 2849): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
04-23 19:22:58.649+0200 W/W_HOME  ( 2773): dbus.c: _dbus_message_recv_cb(204) > LCD off
04-23 19:22:58.649+0200 W/W_HOME  ( 2773): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 19:22:58.649+0200 W/W_HOME  ( 2773): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-23 19:22:58.649+0200 W/W_HOME  ( 2773): gesture.c: _manual_render_enable(138) > 1
04-23 19:22:58.649+0200 W/W_HOME  ( 2773): event_manager.c: _lcd_off_cb(729) > lcd state: 0
04-23 19:22:58.649+0200 W/W_HOME  ( 2773): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 19:22:58.649+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
04-23 19:22:58.649+0200 W/STARTER ( 2701): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-23 19:22:58.659+0200 E/STARTER ( 2701): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
04-23 19:22:58.659+0200 E/STARTER ( 2701): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
04-23 19:22:58.659+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
04-23 19:22:58.659+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
04-23 19:22:58.659+0200 I/gyroscope(13101): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:22:58:644,1.050000,3.780000,-1.470000
04-23 19:22:58.659+0200 W/WAKEUP-SERVICE( 3256): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -145052916[0;m
04-23 19:22:58.659+0200 W/WAKEUP-SERVICE( 3256): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-23 19:22:58.659+0200 W/WAKEUP-SERVICE( 3256): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-23 19:22:58.659+0200 E/WAKEUP-SERVICE( 3256): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 19:22:58.659+0200 I/gyroscope(13101): capturing data from es.ugr.frailty.gyroscope
04-23 19:22:58.669+0200 E/WAKEUP-SERVICE( 3256): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 19:22:58.669+0200 E/WAKEUP-SERVICE( 3256): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 19:22:58.669+0200 I/TIZEN_N_SOUND_MANAGER( 3256): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-23 19:22:58.669+0200 I/TDM     ( 1956): tdm_display.c: tdm_layer_unset_buffer(1602) > [1838.958416] layer(0x8fd2c0) now usable
04-23 19:22:58.669+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [1838.958439] layer[0x8fce10]zpos[1]
04-23 19:22:58.669+0200 I/TDM     ( 1956): tdm_display.c: tdm_layer_unset_buffer(1602) > [1838.958462] layer(0x8fd310) now usable
04-23 19:22:58.669+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [1838.958473] layer[0x8fcf30]zpos[2]
04-23 19:22:58.669+0200 I/TDM     ( 1956): tdm_display.c: tdm_layer_unset_buffer(1602) > [1838.958492] layer(0x8fd250) now usable
04-23 19:22:58.669+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [1838.958502] layer[0x8fccf0]zpos[0]
04-23 19:22:58.669+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [1838.958516] dpms[0 -> 3]sync[1]
04-23 19:22:58.669+0200 I/TDM     ( 1956): 
04-23 19:22:58.679+0200 I/heartrate(13102): capturing data from es.ugr.frailty.heartrate
04-23 19:22:58.699+0200 I/heartrate(13102): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:22:58.719+0200 I/TIZEN_N_SOUND_MANAGER( 3256): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-23 19:22:58.719+0200 W/TIZEN_N_SOUND_MANAGER( 3256): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 19:22:58.719+0200 W/WAKEUP-SERVICE( 3256): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-23 19:22:58.719+0200 I/HIGEAR  ( 3256): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-23 19:22:58.719+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:645,4.721039,-2.256432,8.520842
04-23 19:22:58.719+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.729+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:659,4.533118,-2.163012,8.422744
04-23 19:22:58.729+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:656,0.071606,-0.145253,0.074735
04-23 19:22:58.729+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.729+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.729+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:737,0.085030,-0.057528,0.004777
04-23 19:22:58.739+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:727,4.618148,-2.153540,8.461020
04-23 19:22:58.739+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.739+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:743,4.527678,-2.160793,8.426238
04-23 19:22:58.749+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.749+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:748,4.610970,-2.306681,8.494520
04-23 19:22:58.749+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.759+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.759+0200 I/accelerometer(13097): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:22:58:764,4.618148,-2.220540,8.427521
04-23 19:22:58.759+0200 I/linearacceleration(13138): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:22:58:757,0.068935,-0.112388,0.046747
04-23 19:22:58.769+0200 I/linearacceleration(13138): capturing data from es.ugr.frailty.linearacceleration
04-23 19:22:58.769+0200 I/heartrate(13102): capturing data from es.ugr.frailty.heartrate
04-23 19:22:58.769+0200 I/heartrate(13102): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:22:58.779+0200 I/gravity (13145): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:22:58:761,4.525240,-2.164700,8.426545
04-23 19:22:58.779+0200 I/gravity (13145): capturing data from es.ugr.frailty.gravity
04-23 19:22:58.779+0200 I/accelerometer(13097): capturing data from es.ugr.frailty.accelerometer
04-23 19:22:58.779+0200 W/CRASH_MANAGER(13195): worker.c: worker_job(1205) > 11131146c6f63152450417
