S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 9757
Date: 2018-04-23 19:11:17+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf76fc52d, r5   = 0xf7b96958
r6   = 0xff8fc040, r7   = 0xff8fbef0
r8   = 0xf7ba9c18, r9   = 0x00000000
r10  = 0xff8fbfcc, fp   = 0xff8fc040
ip   = 0x00000001, sp   = 0xff8fbec8
lr   = 0xf76fc539, pc   = 0xf7765228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     44948 KB
Buffers:     46120 KB
Cached:     232428 KB
VmPeak:      53556 KB
VmSize:      53552 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12208 KB
VmRSS:       12204 KB
VmData:      11280 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 9757 TID = 9757
9757 9811 

Maps Information
f45c7000 f4dc6000 rw-p [stack:9811]
f4dcd000 f4dcf000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4dd7000 f4ddb000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4de4000 f4de6000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4dee000 f4df1000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4e00000 f4e05000 r-xp /usr/lib/libsystem.so.0.0.0
f4e10000 f4e13000 r-xp /lib/libattr.so.1.1.0
f4e1b000 f4e2b000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e33000 f4e3c000 r-xp /usr/lib/libedbus.so.1.7.99
f4e44000 f4e45000 r-xp /usr/lib/libresponse.so.0.2.96
f4e4e000 f4e53000 r-xp /usr/lib/libproc-stat.so.0.2.96
f66f5000 f67fb000 r-xp /usr/lib/libicuuc.so.57.1
f6811000 f6999000 r-xp /usr/lib/libicui18n.so.57.1
f69a9000 f69b6000 r-xp /usr/lib/libail.so.0.1.0
f69bf000 f69c6000 r-xp /usr/lib/libminizip.so.1.0.0
f69cf000 f6b78000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b98000 f6bdf000 r-xp /usr/lib/libssl.so.1.0.0
f6beb000 f6bed000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6bf5000 f6bfc000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6c05000 f6c0c000 r-xp /lib/libcrypt-2.13.so
f6c3d000 f6c40000 r-xp /lib/libcap.so.2.21
f6c48000 f6c4a000 r-xp /usr/lib/libiri.so
f6c52000 f6c9b000 r-xp /usr/lib/libmdm.so.1.2.69
f6ca3000 f6ca9000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6cb1000 f6cd4000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6cde000 f6ce0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ce8000 f6d05000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d0e000 f6d12000 r-xp /usr/lib/libsmack.so.1.0.0
f6d1b000 f6d34000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d3d000 f6d45000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d4d000 f6d53000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d5c000 f6d5e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d67000 f6d77000 r-xp /lib/libresolv-2.13.so
f6d7b000 f6d93000 r-xp /usr/lib/liblzma.so.5.0.3
f6d9c000 f6d9e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6da6000 f6dc0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6dc8000 f6df7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e00000 f6e0f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e19000 f6e23000 r-xp /usr/lib/libsensord-shared.so
f6e2c000 f6eff000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f0a000 f6f20000 r-xp /lib/libz.so.1.2.5
f6f28000 f6f2d000 r-xp /usr/lib/libffi.so.5.0.10
f6f35000 f6f36000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f3e000 f6f4e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f56000 f6f6f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f77000 f6f79000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f81000 f6ff6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f7000000 f7006000 r-xp /lib/librt-2.13.so
f700f000 f702d000 r-xp /usr/lib/libsystemd.so.0.4.0
f7037000 f7038000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7040000 f7063000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f706b000 f7070000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7078000 f70a2000 r-xp /usr/lib/libdbus-1.so.3.8.12
f70ab000 f70c2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70ca000 f7133000 r-xp /lib/libm-2.13.so
f713c000 f71d0000 r-xp /usr/lib/libstdc++.so.6.0.16
f71e3000 f71e8000 r-xp /usr/lib/libctx-client.so.0.8.3
f71f0000 f71f7000 r-xp /usr/lib/libctx-shared.so.0.8.3
f71ff000 f7229000 r-xp /usr/lib/libsensor.so.1.9.6
f7232000 f72fe000 r-xp /usr/lib/libxml2.so.2.7.8
f730b000 f730d000 r-xp /usr/lib/libiniparser.so.0
f7316000 f731c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7325000 f73f5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f73f6000 f742a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7433000 f746f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7477000 f747a000 r-xp /usr/lib/libbundle.so.0.1.22
f7482000 f7488000 r-xp /usr/lib/libappsvc.so.0.1.0
f7490000 f74d1000 r-xp /usr/lib/libeina.so.1.7.99
f74da000 f74f1000 r-xp /usr/lib/libecore.so.1.7.99
f7508000 f7511000 r-xp /usr/lib/libvconf.so.0.2.45
f7519000 f752d000 r-xp /lib/libpthread-2.13.so
f7538000 f7545000 r-xp /usr/lib/libaul.so.0.1.0
f754f000 f7551000 r-xp /lib/libdl-2.13.so
f755a000 f7565000 r-xp /lib/libunwind.so.8.0.1
f7592000 f759a000 r-xp /lib/libgcc_s-4.6.so.1
f759b000 f76bf000 r-xp /lib/libc-2.13.so
f76cd000 f76cf000 r-xp /usr/lib/libdlog.so.0.0.0
f76d7000 f76e3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f76ec000 f76f1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f76f9000 f7708000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7710000 f7714000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f771d000 f7720000 r-xp /usr/lib/libappcore-agent.so.1.1
f7728000 f772a000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7732000 f7736000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f773e000 f775b000 r-xp /lib/ld-2.13.so
f7764000 f7767000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7767000 f776b000 r-xp /usr/lib/libsys-assert.so
f7b79000 f7c04000 rw-p [heap]
ff8dd000 ff8fe000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9757)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7765228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf76fc539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf74033f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7401c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf740de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7413be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7413dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf744875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf74431f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7401c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf740de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7413be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7413dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7445e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7446017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf744df93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4de51fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4dd8171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6eab663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7358fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf735a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf74eaca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf74e5b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74e65a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf74e6879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf771e183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf771e7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf77654f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf75b285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7764f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:475,0.072985,0.111434,0.179699
04-23 19:11:16.469+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:473,2.380000,-2.030000,8.260000
04-23 19:11:16.479+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.479+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:16.479+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:487,9.594560,-1.143426,1.675527
04-23 19:11:16.479+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:16.479+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.489+0200 I/heartrate( 9753): capturing data from es.ugr.frailty.heartrate
04-23 19:11:16.489+0200 I/heartrate( 9753): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:11:16.489+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:491,-0.036899,0.266313,0.056033
04-23 19:11:16.489+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:16:487,9.561719,-0.866202,1.715654
04-23 19:11:16.489+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:491,3.850000,-3.710000,10.010000
04-23 19:11:16.499+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.499+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:16.499+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:16.499+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:509,9.591388,-1.150630,1.688705
04-23 19:11:16.509+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.509+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:513,0.050908,0.188690,-0.010122
04-23 19:11:16.509+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:510,6.580000,-5.110000,12.250000
04-23 19:11:16.509+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:16:509,9.645468,-0.954736,1.665405
04-23 19:11:16.519+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:16.519+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.519+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:527,8.820000,-4.270000,13.720000
04-23 19:11:16.519+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:16.519+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:527,9.587099,-1.164546,1.703451
04-23 19:11:16.519+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.529+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:16:531,9.669396,-1.033699,1.476372
04-23 19:11:16.529+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:533,0.078009,0.116930,-0.212333
04-23 19:11:16.539+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.539+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:16.539+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:16.549+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:549,9.582705,-1.186572,1.712951
04-23 19:11:16.549+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.549+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:549,6.370000,-2.450000,15.120000
04-23 19:11:16.549+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:555,0.027263,-0.170649,-0.444827
04-23 19:11:16.549+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:16:551,9.614362,-1.335195,1.258625
04-23 19:11:16.559+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.559+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:16.559+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:16.569+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:568,9.578108,-1.227120,1.710094
04-23 19:11:16.569+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.569+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:574,0.072335,-0.478833,-0.518932
04-23 19:11:16.569+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:569,3.290000,-2.730000,17.010000
04-23 19:11:16.569+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:16:574,9.655040,-1.665405,1.194018
04-23 19:11:16.579+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:16.579+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.579+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:16.589+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.589+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:587,9.571926,-1.276491,1.708564
04-23 19:11:16.589+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:588,12.530000,-1.540000,16.309999
04-23 19:11:16.589+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:593,0.088896,-0.737388,-0.482576
04-23 19:11:16.589+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:16:591,9.667004,-1.964507,1.227518
04-23 19:11:16.599+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.599+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:16.599+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:16.609+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:609,9.561310,-1.330408,1.726778
04-23 19:11:16.609+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.619+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:16:609,9.705289,-1.739582,1.540978
04-23 19:11:16.619+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:610,29.120001,4.620000,14.210000
04-23 19:11:16.619+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:16.619+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:16.639+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:633,30.450001,5.180000,15.330000
04-23 19:11:16.639+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:16:632,9.513863,-1.411765,1.557728
04-23 19:11:16.639+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:16.649+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:16.649+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.649+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:655,9.548649,-1.374235,1.762147
04-23 19:11:16.649+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:16:654,9.463614,-1.514657,1.409373
04-23 19:11:16.649+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.649+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:649,25.340000,4.340000,16.520000
04-23 19:11:16.659+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:16.659+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:16.669+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:668,28.840000,3.220000,17.010000
04-23 19:11:16.669+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:16:669,9.552148,-1.842474,1.643869
04-23 19:11:16.679+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:616,0.133363,-0.463091,-0.167586
04-23 19:11:16.679+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:16.689+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:16.689+0200 I/heartrate( 9753): capturing data from es.ugr.frailty.heartrate
04-23 19:11:16.689+0200 I/heartrate( 9753): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:11:16.689+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.689+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:16:693,9.580862,-2.644069,1.100698
04-23 19:11:16.699+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:689,43.189999,1.190000,14.140000
04-23 19:11:16.699+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:16.709+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:16.709+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:16:714,9.772287,-2.907279,1.265803
04-23 19:11:16.709+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:661,9.537626,-1.406467,1.796085
04-23 19:11:16.709+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:703,-0.047447,-0.081358,-0.169050
04-23 19:11:16.719+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.719+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:710,59.080002,6.860000,9.870000
04-23 19:11:16.719+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.719+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:16.729+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:16.729+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:734,61.180000,15.610000,3.780000
04-23 19:11:16.729+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:16:738,9.884750,-2.366502,1.789831
04-23 19:11:16.739+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:723,-0.085035,-0.140422,-0.352775
04-23 19:11:16.739+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:729,9.527767,-1.441570,1.820415
04-23 19:11:16.739+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.739+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.739+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:16.739+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:16.749+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:746,0.014522,-0.436006,-0.152216
04-23 19:11:16.749+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.749+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:755,0.053095,-1.202499,-0.719716
04-23 19:11:16.749+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.759+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:760,0.256363,-1.431233,-0.588609
04-23 19:11:16.759+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.759+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:750,9.515924,-1.476047,1.854412
04-23 19:11:16.759+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.759+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:753,38.360001,13.300000,2.800000
04-23 19:11:16.759+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:765,0.381543,-0.837118,-0.086447
04-23 19:11:16.759+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:16:753,9.384650,-1.536192,1.459622
04-23 19:11:16.759+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.759+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:16.759+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:16.769+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:770,-0.102201,0.043715,-0.457132
04-23 19:11:16.769+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.769+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:773,23.520000,10.570000,4.830000
04-23 19:11:16.769+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:774,0.011979,-0.111558,-0.660953
04-23 19:11:16.769+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:769,9.503207,-1.529384,1.876279
04-23 19:11:16.769+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.769+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:16:774,9.485149,-1.722832,1.296910
04-23 19:11:16.779+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:781,9.486851,-1.579907,1.916754
04-23 19:11:16.779+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.779+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.779+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:16.779+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:788,0.231861,-0.541312,-0.472698
04-23 19:11:16.779+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:16.789+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:786,9.473170,-1.611274,1.957862
04-23 19:11:16.789+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.789+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:788,19.670000,9.450000,3.080000
04-23 19:11:16.789+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:16:793,9.700503,-2.160719,1.500300
04-23 19:11:16.789+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:796,9.468642,-1.619406,1.972998
04-23 19:11:16.789+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.799+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:801,9.467183,-1.632137,1.969506
04-23 19:11:16.799+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.799+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:16.809+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:809,0.293140,-0.504653,-0.002606
04-23 19:11:16.809+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:11:16.809+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:11:16.809+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:11:16.809+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.809+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:16.819+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.819+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:821,9.460990,-1.654623,1.980475
04-23 19:11:16.819+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.829+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:829,9.453979,-1.669392,2.001451
04-23 19:11:16.829+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:828,0.005016,-0.171100,0.053424
04-23 19:11:16.829+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:819,17.290001,15.190001,-1.680000
04-23 19:11:16.829+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:16.839+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:16:822,9.760324,-2.136791,1.966900
04-23 19:11:16.839+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:16.839+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.839+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.839+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:848,-0.129148,-0.393221,0.278909
04-23 19:11:16.849+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:840,2.800000,15.750000,-6.440000
04-23 19:11:16.849+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:16.849+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:849,9.451751,-1.672161,2.009645
04-23 19:11:16.849+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:16:844,9.466006,-1.825724,2.033899
04-23 19:11:16.849+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:16.849+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:853,-12.320000,11.620000,-8.050000
04-23 19:11:16.849+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:16:857,9.324830,-2.062613,2.280360
04-23 19:11:16.859+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.859+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:16.859+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:868,0.038184,-0.440702,0.129539
04-23 19:11:16.859+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:16.869+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.869+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:16:873,9.489935,-2.112862,2.139183
04-23 19:11:16.869+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:874,9.446049,-1.681208,2.028815
04-23 19:11:16.869+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:869,-10.850000,11.690000,-10.360000
04-23 19:11:16.879+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.879+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:16.879+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.879+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:887,0.031921,0.075624,0.172582
04-23 19:11:16.879+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:16.889+0200 I/heartrate( 9753): capturing data from es.ugr.frailty.heartrate
04-23 19:11:16.889+0200 I/heartrate( 9753): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:11:16.889+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:16:891,9.477970,-1.605584,2.201397
04-23 19:11:16.889+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:888,-5.950000,8.540000,-12.810000
04-23 19:11:16.889+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:889,9.445252,-1.681726,2.032089
04-23 19:11:16.899+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.899+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:16.899+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:16.899+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.899+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:908,0.042290,0.310639,0.142986
04-23 19:11:16.909+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:16:909,9.487542,-1.371087,2.175076
04-23 19:11:16.909+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:911,-17.080000,9.310000,-12.320000
04-23 19:11:16.909+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:914,9.447253,-1.666047,2.035701
04-23 19:11:16.919+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:16.919+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:16.919+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.929+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:929,0.057038,0.137033,-0.140585
04-23 19:11:16.929+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:928,-19.809999,7.560000,-11.410000
04-23 19:11:16.929+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.929+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:16:928,9.504292,-1.529014,1.895115
04-23 19:11:16.939+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:938,9.451673,-1.641676,2.034986
04-23 19:11:16.939+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:16.939+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.949+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.949+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:16.949+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:953,9.457014,-1.625790,2.022889
04-23 19:11:16.949+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:949,0.167475,0.332802,-0.211655
04-23 19:11:16.949+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:949,-17.570000,7.840000,-11.340000
04-23 19:11:16.949+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:16:953,9.619147,-1.308874,1.823331
04-23 19:11:16.959+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.969+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:16:968,0.233917,0.683018,-0.213915
04-23 19:11:16.969+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:16.969+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.979+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:16.979+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:976,9.462544,-1.603815,2.014552
04-23 19:11:16.989+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:16.989+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:16:996,9.470453,-1.565846,2.007245
04-23 19:11:16.999+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:16.999+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:16:978,9.690931,-0.942772,1.808974
04-23 19:11:17.009+0200 W/LOCATION( 9757): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:11:17.009+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:17:5,-0.027644,0.416975,0.232308
04-23 19:11:17.009+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:17.019+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:17.019+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:16:983,-18.900000,10.710000,-10.570000
04-23 19:11:17.029+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:17.029+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:17.029+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:17:23,-0.018804,0.328757,0.464541
04-23 19:11:17.029+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:17.029+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:17:28,9.434900,-1.186840,2.246860
04-23 19:11:17.029+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:17.039+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:17:33,9.473914,-1.538709,2.011890
04-23 19:11:17.039+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:17:37,-20.510000,10.150000,-9.520000
04-23 19:11:17.039+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:17.039+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:17:40,0.056698,0.605508,0.321112
04-23 19:11:17.049+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:17.049+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:17.059+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:17:53,-15.470000,5.460000,-9.240000
04-23 19:11:17.059+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:17.059+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:17:42,9.451650,-1.237089,2.471786
04-23 19:11:17.059+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:17:50,9.475415,-1.514941,2.022830
04-23 19:11:17.059+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:17.059+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:17:58,0.081518,0.629596,0.381957
04-23 19:11:17.059+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:17.069+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:17.069+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:17:67,-13.860000,3.850000,-8.610000
04-23 19:11:17.079+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:17.079+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:17:69,9.530612,-0.933201,2.333002
04-23 19:11:17.079+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:17.079+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:17:76,0.054743,0.549870,0.711348
04-23 19:11:17.079+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:17.079+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:17:72,9.480656,-1.480678,2.023649
04-23 19:11:17.079+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:17.079+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:17:84,-16.450001,1.050000,-5.950000
04-23 19:11:17.089+0200 I/heartrate( 9753): capturing data from es.ugr.frailty.heartrate
04-23 19:11:17.089+0200 I/heartrate( 9753): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:11:17.089+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:17.089+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:17:93,-0.084717,0.239953,0.612436
04-23 19:11:17.099+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:17:89,9.483725,-1.453114,2.029240
04-23 19:11:17.099+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:17.099+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:17:86,9.556933,-0.885344,2.404787
04-23 19:11:17.099+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:17:100,-20.299999,1.400000,-3.220000
04-23 19:11:17.099+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:17.099+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:17.109+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:17.109+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:17:109,-0.020525,-0.482338,0.084179
04-23 19:11:17.109+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:17:107,9.535398,-0.930808,2.734996
04-23 19:11:17.109+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:17:115,-25.059999,-1.750000,-1.120000
04-23 19:11:17.119+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:17:105,9.484138,-1.434313,2.040648
04-23 19:11:17.119+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:17.119+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:17.119+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:17.119+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:17.119+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:17:128,0.095850,-0.615162,0.086418
04-23 19:11:17.129+0200 I/servicemanager( 9717): es.ugr.frailty.location sleep timeout
04-23 19:11:17.129+0200 W/AUL     ( 9717): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 19:11:17.129+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:11:17.129+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9717
04-23 19:11:17.129+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:17:126,9.399008,-1.213161,2.641676
04-23 19:11:17.129+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:17.139+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:17:124,9.485012,-1.428308,2.040802
04-23 19:11:17.139+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:17.139+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9757
04-23 19:11:17.139+0200 W/AUL     ( 9717): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9757)
04-23 19:11:17.139+0200 I/servicemanager( 9717): es.ugr.frailty.location stop request sent!
04-23 19:11:17.139+0200 I/servicemanager( 9717): App control destroyed.
04-23 19:11:17.139+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:17.139+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:17:142,9.463614,-1.916651,2.124826
04-23 19:11:17.139+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:17.149+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:17:123,-21.559999,-8.050000,0.770000
04-23 19:11:17.149+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:17:150,0.167355,-0.138676,0.019112
04-23 19:11:17.149+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:17.149+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:17:144,9.485292,-1.442980,2.029144
04-23 19:11:17.149+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:17.159+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:17:159,-1.750000,-6.440000,-1.750000
04-23 19:11:17.159+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:17.159+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:17:152,9.580862,-2.043471,2.127219
04-23 19:11:17.159+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:17.159+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:17.159+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:17:162,9.483481,-1.451041,2.031856
04-23 19:11:17.159+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:17.169+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:17:168,0.173951,0.422127,-0.033849
04-23 19:11:17.169+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:17:165,20.020000,-2.100000,-4.340000
04-23 19:11:17.169+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:17.169+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:17:167,9.652647,-1.581656,2.048256
04-23 19:11:17.169+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:17:178,21.840000,-0.560000,-4.690000
04-23 19:11:17.179+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:17:171,9.485368,-1.437593,2.032610
04-23 19:11:17.179+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:17.179+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:17.179+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:17.179+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:17:187,5.040000,0.210000,-2.660000
04-23 19:11:17.179+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:17:188,-0.000218,0.583355,-0.187743
04-23 19:11:17.179+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:17.189+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:17:185,9.657433,-1.028914,1.998007
04-23 19:11:17.189+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:17.189+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:17:191,9.490370,-1.409093,2.029215
04-23 19:11:17.189+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:17:197,9.485149,-0.854238,1.844866
04-23 19:11:17.199+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:17.199+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:17.199+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:17.209+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:17:209,0.068956,0.071505,-0.490630
04-23 19:11:17.209+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:17.209+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:17:209,-3.990000,-3.710000,-0.490000
04-23 19:11:17.209+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:17:210,9.498342,-1.378906,2.012589
04-23 19:11:17.209+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:17:215,9.559326,-1.337588,1.538585
04-23 19:11:17.219+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:17.219+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:17.219+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:17.219+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:17:228,0.302660,0.065247,-0.088760
04-23 19:11:17.229+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:17.229+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:17:231,9.505130,-1.373069,1.984333
04-23 19:11:17.229+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:17:228,0.070000,-1.400000,-1.960000
04-23 19:11:17.229+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:17:233,9.801002,-1.313660,1.923829
04-23 19:11:17.239+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:17.239+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:17.239+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:17.249+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:17:249,0.130767,-0.045875,0.528131
04-23 19:11:17.249+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:17.249+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:17:250,9.506253,-1.362261,1.986399
04-23 19:11:17.249+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:17:249,9.870000,3.150000,-2.380000
04-23 19:11:17.249+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:17:254,9.635897,-1.418944,2.512464
04-23 19:11:17.259+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:17.259+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:17.259+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:17:268,18.410000,-0.980000,-3.360000
04-23 19:11:17.259+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:17:267,-0.143138,-0.116504,0.341817
04-23 19:11:17.259+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:17.269+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:17.269+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:17:271,9.503488,-1.349771,2.008038
04-23 19:11:17.269+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:17:273,9.363115,-1.478764,2.328217
04-23 19:11:17.279+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:17.279+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:17.279+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:17.279+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:17:288,0.007982,0.213181,0.097646
04-23 19:11:17.279+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:17.289+0200 I/heartrate( 9753): capturing data from es.ugr.frailty.heartrate
04-23 19:11:17.289+0200 I/heartrate( 9753): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:11:17.289+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:17:290,9.502066,-1.343671,2.018831
04-23 19:11:17.289+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:17:288,12.250000,-2.380000,-3.360000
04-23 19:11:17.289+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:17:293,9.511470,-1.136591,2.105684
04-23 19:11:17.299+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:17.299+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:17.299+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:17.309+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:17:309,0.152974,-0.214057,-0.549638
04-23 19:11:17.309+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:17.309+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:17:308,9.505574,-1.328174,2.012558
04-23 19:11:17.309+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:17:311,-0.840000,-3.570000,-1.540000
04-23 19:11:17.309+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:17:315,9.655040,-1.557728,1.469193
04-23 19:11:17.319+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:17.319+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:17.319+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:17.319+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:17:328,0.249964,-0.057270,-0.107871
04-23 19:11:17.329+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:17.329+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:17:328,0.490000,-0.070000,-1.680000
04-23 19:11:17.329+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:17:328,9.510619,-1.336400,1.983062
04-23 19:11:17.329+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:17:334,9.755538,-1.385444,1.904687
04-23 19:11:17.339+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:17.339+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:17.339+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:17.349+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:17:349,0.075027,-0.039473,0.450438
04-23 19:11:17.349+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:17:349,8.050000,2.100000,-2.450000
04-23 19:11:17.349+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:17:350,9.511689,-1.330914,1.981622
04-23 19:11:17.349+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:17.349+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:17:358,9.585647,-1.375873,2.433501
04-23 19:11:17.359+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:17.359+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:17.369+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:17.369+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:17:368,12.250000,0.140000,-3.570000
04-23 19:11:17.379+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:17.389+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:17:391,14.140000,-3.290000,-3.780000
04-23 19:11:17.399+0200 E/AUL_AMD ( 2478): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 19:11:17.399+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 19:11:17.399+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(9757), cmd(0)
04-23 19:11:17.409+0200 W/libgps_d( 3158): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 19:11:17.409+0200 W/libgps  ( 3158): [proxy__gps_stop][line = 1067]: called.
04-23 19:11:17.409+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:11:17.409+0200 W/libgps_d( 3158): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 19:11:17.409+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 19:11:17.409+0200 W/libgps_d( 3158): GpsiHookStateGps              : EXIT
04-23 19:11:17.409+0200 W/libgps_d( 3158): GpsiHookStateIdle             : ENTRY
04-23 19:11:17.409+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:17.409+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:0, msg id:2
04-23 19:11:17.409+0200 E/CAPI_LOCATION_MANAGER( 9812): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 19:11:17.419+0200 I/gyroscope( 9733): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:17:418,4.970000,-2.870000,-4.410000
04-23 19:11:17.419+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:11:17.429+0200 W/AUL     ( 9822): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 19:11:17.429+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 19:11:17.429+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 19:11:17.429+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 9342
04-23 19:11:17.429+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 19:11:17.429+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9342
04-23 19:11:17.429+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(9342)
04-23 19:11:17.479+0200 I/gyroscope( 9733): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:17.489+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:17:372,-0.100718,0.232608,0.415986
04-23 19:11:17.489+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:17.489+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:17:373,9.509155,-1.320907,2.000386
04-23 19:11:17.489+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:17.499+0200 I/CAPI_NETWORK_CONNECTION( 9812): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 19:11:17.499+0200 I/CAPI_NETWORK_CONNECTION( 9812): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 19:11:17.499+0200 I/CAPI_NETWORK_CONNECTION( 9812): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 19:11:17.499+0200 I/CAPI_NETWORK_CONNECTION( 9812): connection.c: connection_destroy(471) > Destroy handle: 0xf74f6c88
04-23 19:11:17.499+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:17.499+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:17:503,9.510170,-1.296131,2.011738
04-23 19:11:17.499+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:17.509+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:17:500,-0.086220,0.356600,0.069405
04-23 19:11:17.509+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:17.519+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:17:509,9.410972,-1.098306,2.397608
04-23 19:11:17.519+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:17.519+0200 I/heartrate( 9753): capturing data from es.ugr.frailty.heartrate
04-23 19:11:17.519+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:17:515,0.130512,0.226540,-0.437261
04-23 19:11:17.519+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:17.519+0200 I/gravity ( 9789): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:17:513,9.515428,-1.267701,2.004983
04-23 19:11:17.529+0200 I/heartrate( 9753): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:11:17.529+0200 I/accelerometer( 9730): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:17:523,9.422935,-0.964308,2.069792
04-23 19:11:17.529+0200 I/gravity ( 9789): capturing data from es.ugr.frailty.gravity
04-23 19:11:17.529+0200 I/accelerometer( 9730): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:17.539+0200 I/linearacceleration( 9774): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:17:530,0.254467,-0.084244,-0.138581
04-23 19:11:17.539+0200 I/linearacceleration( 9774): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:17.539+0200 W/CRASH_MANAGER( 9824): worker.c: worker_job(1205) > 11097576c6f63152450347
