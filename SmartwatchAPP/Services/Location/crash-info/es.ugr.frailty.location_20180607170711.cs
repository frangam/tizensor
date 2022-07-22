S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 16169
Date: 2018-06-07 17:07:11+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf757a52d, r5   = 0xf7ae8f98
r6   = 0xffcee900, r7   = 0xffcee7b0
r8   = 0xf7ae5c18, r9   = 0x00000000
r10  = 0xffcee88c, fp   = 0xffcee900
ip   = 0x00000001, sp   = 0xffcee788
lr   = 0xf757a539, pc   = 0xf75e3228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    233360 KB
Buffers:      7888 KB
Cached:      52084 KB
VmPeak:      53568 KB
VmSize:      53564 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11784 KB
VmRSS:       11784 KB
VmData:      11292 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 16169 TID = 16169
16169 16194 

Maps Information
f4445000 f4c44000 rw-p [stack:16194]
f4c4b000 f4c4d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c55000 f4c59000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c62000 f4c64000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c6c000 f4c6f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4c7e000 f4c83000 r-xp /usr/lib/libsystem.so.0.0.0
f4c8e000 f4c91000 r-xp /lib/libattr.so.1.1.0
f4c99000 f4ca9000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4cb1000 f4cba000 r-xp /usr/lib/libedbus.so.1.7.99
f4cc2000 f4cc3000 r-xp /usr/lib/libresponse.so.0.2.96
f4ccc000 f4cd1000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6573000 f6679000 r-xp /usr/lib/libicuuc.so.57.1
f668f000 f6817000 r-xp /usr/lib/libicui18n.so.57.1
f6827000 f6834000 r-xp /usr/lib/libail.so.0.1.0
f683d000 f6844000 r-xp /usr/lib/libminizip.so.1.0.0
f684d000 f69f6000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a16000 f6a5d000 r-xp /usr/lib/libssl.so.1.0.0
f6a69000 f6a6b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a73000 f6a7a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a83000 f6a8a000 r-xp /lib/libcrypt-2.13.so
f6abb000 f6abe000 r-xp /lib/libcap.so.2.21
f6ac6000 f6ac8000 r-xp /usr/lib/libiri.so
f6ad0000 f6b19000 r-xp /usr/lib/libmdm.so.1.2.69
f6b21000 f6b27000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b2f000 f6b52000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b5c000 f6b5e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b66000 f6b83000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b8c000 f6b90000 r-xp /usr/lib/libsmack.so.1.0.0
f6b99000 f6bb2000 r-xp /usr/lib/libnetwork.so.0.0.0
f6bbb000 f6bc3000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6bcb000 f6bd1000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6bda000 f6bdc000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6be5000 f6bf5000 r-xp /lib/libresolv-2.13.so
f6bf9000 f6c11000 r-xp /usr/lib/liblzma.so.5.0.3
f6c1a000 f6c1c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c24000 f6c3e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c46000 f6c75000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c7e000 f6c8d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c97000 f6ca1000 r-xp /usr/lib/libsensord-shared.so
f6caa000 f6d7d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d88000 f6d9e000 r-xp /lib/libz.so.1.2.5
f6da6000 f6dab000 r-xp /usr/lib/libffi.so.5.0.10
f6db3000 f6db4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6dbc000 f6dcc000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6dd4000 f6ded000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6df5000 f6df7000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6dff000 f6e74000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e7e000 f6e84000 r-xp /lib/librt-2.13.so
f6e8d000 f6eab000 r-xp /usr/lib/libsystemd.so.0.4.0
f6eb5000 f6eb6000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ebe000 f6ee1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ee9000 f6eee000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ef6000 f6f20000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f29000 f6f40000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f48000 f6fb1000 r-xp /lib/libm-2.13.so
f6fba000 f704e000 r-xp /usr/lib/libstdc++.so.6.0.16
f7061000 f7066000 r-xp /usr/lib/libctx-client.so.0.8.3
f706e000 f7075000 r-xp /usr/lib/libctx-shared.so.0.8.3
f707d000 f70a7000 r-xp /usr/lib/libsensor.so.1.9.6
f70b0000 f717c000 r-xp /usr/lib/libxml2.so.2.7.8
f7189000 f718b000 r-xp /usr/lib/libiniparser.so.0
f7194000 f719a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f71a3000 f7273000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7274000 f72a8000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f72b1000 f72ed000 r-xp /usr/lib/libSLP-location.so.0.9.24
f72f5000 f72f8000 r-xp /usr/lib/libbundle.so.0.1.22
f7300000 f7306000 r-xp /usr/lib/libappsvc.so.0.1.0
f730e000 f734f000 r-xp /usr/lib/libeina.so.1.7.99
f7358000 f736f000 r-xp /usr/lib/libecore.so.1.7.99
f7386000 f738f000 r-xp /usr/lib/libvconf.so.0.2.45
f7397000 f73ab000 r-xp /lib/libpthread-2.13.so
f73b6000 f73c3000 r-xp /usr/lib/libaul.so.0.1.0
f73cd000 f73cf000 r-xp /lib/libdl-2.13.so
f73d8000 f73e3000 r-xp /lib/libunwind.so.8.0.1
f7410000 f7418000 r-xp /lib/libgcc_s-4.6.so.1
f7419000 f753d000 r-xp /lib/libc-2.13.so
f754b000 f754d000 r-xp /usr/lib/libdlog.so.0.0.0
f7555000 f7561000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f756a000 f756f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7577000 f7586000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f758e000 f7592000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f759b000 f759e000 r-xp /usr/lib/libappcore-agent.so.1.1
f75a6000 f75a8000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f75b0000 f75b4000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f75bc000 f75d9000 r-xp /lib/ld-2.13.so
f75e2000 f75e5000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f75e5000 f75e9000 r-xp /usr/lib/libsys-assert.so
f7ab5000 f7b43000 rw-p [heap]
ffcd0000 ffcf1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16169)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf75e3228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf757a539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72813f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf727fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf728be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7291be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7291dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf72c675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72c11f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf727fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf728be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7291be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7291dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf72c3e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf72c4017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf72cbf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c631fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4c56171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d29663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf71d6fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71d87a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7368ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7363b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73645a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7364879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf759c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf759c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75e35c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf743085c) [/lib/libc.so.6] + 0x1785c
29: (0xf75e2f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
17:07:10.701+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:10.701+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:10:704,1.273340,-1.939224,9.528295
06-07 17:07:10.701+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:10:707,1.277767,-1.861616,9.600004
06-07 17:07:10.701+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:10.701+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:10.711+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:10:714,0.049891,0.101536,0.059746
06-07 17:07:10.711+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:10.711+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:10:718,1.323231,-1.837688,9.588040
06-07 17:07:10.711+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:10.711+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:10:715,3.780000,-1.820000,-0.140000
06-07 17:07:10.721+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:10:722,1.276787,-1.928352,9.530040
06-07 17:07:10.731+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:10.751+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:10:738,3.640000,-1.820000,-0.070000
06-07 17:07:10.751+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:10.761+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:10:764,2.800000,-1.470000,-0.280000
06-07 17:07:10.771+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:10.771+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:10:776,2.520000,-0.770000,-0.140000
06-07 17:07:10.791+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:07:10.791+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:10.811+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:10.821+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:10:804,0.127800,0.174413,0.065179
06-07 17:07:10.821+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:07:10:799,79
06-07 17:07:10.831+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:10.831+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:10.831+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:10.841+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:10:821,1.404587,-1.753939,9.595219
06-07 17:07:10.841+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:10.851+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:10:848,1.445265,-1.840081,9.580862
06-07 17:07:10.871+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:10:844,1.283893,-1.913897,9.531999
06-07 17:07:10.871+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:10:839,0.161372,0.073817,0.048863
06-07 17:07:10.881+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:10.881+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:10.881+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:10:843,1.470000,-0.560000,-0.210000
06-07 17:07:10.891+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:07:10.901+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:07:10:896,501.000000
06-07 17:07:10.901+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:10.911+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:10:915,1.383051,-1.751546,9.633504
06-07 17:07:10.911+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:10.921+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:10:922,1.409373,-1.847259,9.635897
06-07 17:07:10.921+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:10.931+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:10.931+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:07:10.931+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:10:937,1.371087,-1.801795,9.628718
06-07 17:07:10.941+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:07:10:941,79
06-07 17:07:10.941+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:10.951+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:10:891,0.090838,0.154076,0.100971
06-07 17:07:10.951+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:10:933,1.610000,-0.490000,-0.280000
06-07 17:07:10.951+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:10.951+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:10:908,1.292213,-1.905622,9.532533
06-07 17:07:10.961+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:10.971+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:10:948,1.366302,-1.811367,9.621540
06-07 17:07:10.981+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:10.981+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:10.991+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:10:985,1.402194,-1.811367,9.535398
06-07 17:07:10.991+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:10:965,0.113469,0.045359,0.101274
06-07 17:07:11.001+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.001+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.001+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:8,1.385444,-1.749153,9.621540
06-07 17:07:11.001+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.011+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:10:983,1.295903,-1.892618,9.534622
06-07 17:07:11.011+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:13,1.349552,-1.756332,9.667004
06-07 17:07:11.011+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.011+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:10:993,1.960000,-0.560000,-0.350000
06-07 17:07:11.011+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.021+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.021+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:19,1.349552,-1.718047,9.628718
06-07 17:07:11.021+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.031+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:14,0.070444,0.084972,0.093582
06-07 17:07:11.041+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:34,1.332802,-1.765903,9.628718
06-07 17:07:11.041+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.041+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.041+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:28,1.300644,-1.886767,9.535136
06-07 17:07:11.041+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:47,1.387837,-1.828116,9.635897
06-07 17:07:11.041+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.051+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:52,1.402194,-1.811367,9.597611
06-07 17:07:11.051+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.051+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:30,2.170000,-0.210000,-0.490000
06-07 17:07:11.061+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:60,1.411765,-1.718047,9.645468
06-07 17:07:11.061+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.071+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:73,1.335195,-1.746760,9.597611
06-07 17:07:11.071+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.071+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:07:11.071+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:07:11.071+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:07:11.071+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.071+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:79,1.337588,-1.773082,9.655040
06-07 17:07:11.081+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.081+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:50,0.062946,0.067366,0.085188
06-07 17:07:11.081+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:86,1.359123,-1.777867,9.525827
06-07 17:07:11.081+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.081+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.081+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:90,1.383051,-1.794617,9.626326
06-07 17:07:11.091+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:07:11.091+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:07:11:96,502.000000
06-07 17:07:11.091+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.091+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.091+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:90,2.310000,0.350000,-0.070000
06-07 17:07:11.101+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:102,1.397408,-1.780260,9.676575
06-07 17:07:11.101+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.101+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:86,1.303356,-1.878733,9.536352
06-07 17:07:11.101+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:107,1.470000,0.070000,-0.070000
06-07 17:07:11.101+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.101+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.101+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.111+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:114,1.361516,-1.670190,9.623933
06-07 17:07:11.111+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:111,0.770000,-0.210000,-0.070000
06-07 17:07:11.111+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.111+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:120,0.630000,-0.280000,-0.070000
06-07 17:07:11.111+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:107,0.096512,0.059633,-0.002155
06-07 17:07:11.111+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.111+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.121+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:115,1.305682,-1.871000,9.537554
06-07 17:07:11.121+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:124,0.840000,-0.280000,-0.140000
06-07 17:07:11.121+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.121+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:128,1.260000,-0.140000,-0.210000
06-07 17:07:11.121+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.131+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.131+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.131+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:135,1.387837,-1.722832,9.640682
06-07 17:07:11.131+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:07:11.131+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:133,1.540000,-0.070000,-0.280000
06-07 17:07:11.131+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.141+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:143,1.050000,0.350000,-0.280000
06-07 17:07:11.141+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.141+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:148,0.770000,0.350000,0.210000
06-07 17:07:11.141+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.151+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:154,0.140000,0.140000,-0.070000
06-07 17:07:11.151+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.151+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:158,0.840000,0.350000,0.280000
06-07 17:07:11.151+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.151+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.161+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:165,1.402194,-1.751546,9.611969
06-07 17:07:11.161+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:07:11:141,79
06-07 17:07:11.161+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.171+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:177,1.309215,-1.863328,9.538571
06-07 17:07:11.171+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.181+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:183,1.310014,-1.851369,9.540791
06-07 17:07:11.181+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.181+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:188,1.310003,-1.842268,9.542553
06-07 17:07:11.181+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.191+0200 W/LOCATION(16169): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:07:11.191+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:175,1.368695,-1.765903,9.619147
06-07 17:07:11.191+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:162,1.260000,0.140000,-0.070000
06-07 17:07:11.191+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:128,0.076230,0.114174,0.082969
06-07 17:07:11.201+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.201+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.201+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:196,1.311343,-1.833977,9.543966
06-07 17:07:11.201+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.201+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.211+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:206,1.610000,0.210000,0.140000
06-07 17:07:11.211+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:213,1.399801,-1.818545,9.604790
06-07 17:07:11.211+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.211+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:211,0.039538,0.095037,0.126213
06-07 17:07:11.211+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:213,1.312013,-1.828896,9.544849
06-07 17:07:11.221+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.221+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.221+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.231+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:223,0.630000,-0.140000,0.070000
06-07 17:07:11.231+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.231+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:233,1.373480,-1.763510,9.652647
06-07 17:07:11.231+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:229,1.314887,-1.826394,9.544932
06-07 17:07:11.231+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.231+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:228,0.039549,0.124221,0.086165
06-07 17:07:11.231+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.241+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.241+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:250,1.289732,-1.768296,9.643075
06-07 17:07:11.241+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:242,1.317971,-1.822428,9.545265
06-07 17:07:11.241+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:240,-0.280000,-0.140000,0.280000
06-07 17:07:11.251+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.251+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.251+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:245,0.021459,0.068074,0.084752
06-07 17:07:11.251+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.261+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.261+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:256,1.320868,-1.813026,9.546656
06-07 17:07:11.261+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:267,1.387837,-1.734797,9.626326
06-07 17:07:11.261+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.261+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:257,-0.420000,-0.140000,-0.070000
06-07 17:07:11.261+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.261+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:262,0.075824,0.000779,0.091047
06-07 17:07:11.271+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.271+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:272,1.319871,-1.806493,9.548032
06-07 17:07:11.271+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.271+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.271+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:275,-0.280000,-0.210000,-0.070000
06-07 17:07:11.271+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.281+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:283,1.318696,-1.801873,9.549067
06-07 17:07:11.281+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:278,0.087307,0.015027,0.052679
06-07 17:07:11.281+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.291+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:07:11.291+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:290,0.140000,0.210000,0.140000
06-07 17:07:11.291+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:286,1.399801,-1.696511,9.535398
06-07 17:07:11.291+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:07:11:296,503.000000
06-07 17:07:11.291+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.291+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.291+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.301+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:295,0.093795,0.104381,0.100203
06-07 17:07:11.301+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:304,1.385444,-1.797010,9.611969
06-07 17:07:11.301+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.311+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:305,1.320316,-1.800273,9.549145
06-07 17:07:11.311+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:304,0.140000,0.070000,-0.070000
06-07 17:07:11.311+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.311+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.311+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:314,0.014327,0.066265,0.050956
06-07 17:07:11.311+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:321,0.280000,-0.420000,0.140000
06-07 17:07:11.311+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.321+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:319,1.321261,-1.797040,9.549623
06-07 17:07:11.321+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.321+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:325,1.373480,-1.806581,9.647861
06-07 17:07:11.321+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.331+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.331+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:332,1.322755,-1.792106,9.550344
06-07 17:07:11.331+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:330,0.017716,0.033412,0.107008
06-07 17:07:11.331+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.331+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:07:11.331+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.341+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:336,-0.490000,-0.070000,0.140000
06-07 17:07:11.341+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:07:11:342,79
06-07 17:07:11.341+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:342,0.040427,0.024006,-0.023239
06-07 17:07:11.341+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:340,1.406980,-1.787439,9.583255
06-07 17:07:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:07:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:07:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:07:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:07:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:07:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:07:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:07:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:07:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:07:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:07:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:07:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:07:11.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391231353,000000, pattern:[H:mm][0;m
06-07 17:07:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:07:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:07:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:07:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:07:11.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:07:11.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:07][0;m
06-07 17:07:11.341+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.351+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.361+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:355,1.322598,-1.781913,9.552272
06-07 17:07:11.361+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.361+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.371+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.381+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:383,1.324892,-1.777104,9.552850
06-07 17:07:11.401+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:363,-0.350000,0.210000,0.350000
06-07 17:07:11.401+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.401+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.401+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:375,0.062736,0.005656,0.077181
06-07 17:07:11.401+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:372,1.418944,-1.775474,9.614362
06-07 17:07:11.401+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.411+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.431+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:411,1.328465,-1.776131,9.552535
06-07 17:07:11.431+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:420,0.076147,0.016780,0.126951
06-07 17:07:11.431+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.441+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:440,0.038761,0.121915,0.073589
06-07 17:07:11.441+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.451+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:408,-0.700000,0.070000,-0.070000
06-07 17:07:11.481+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.481+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:07:11.491+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:07:11:495,503.000000
06-07 17:07:11.491+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:450,0.065239,0.059080,0.088410
06-07 17:07:11.491+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.501+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.511+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:489,1.330501,-1.776024,9.552272
06-07 17:07:11.521+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:419,1.395016,-1.756332,9.611969
06-07 17:07:11.521+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.521+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:506,0.140000,-0.070000,-0.070000
06-07 17:07:11.521+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.521+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:529,0.350000,-0.070000,-0.070000
06-07 17:07:11.521+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.531+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:534,0.140000,0.070000,0.140000
06-07 17:07:11.531+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.531+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:07:11.531+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:540,0.350000,0.280000,0.280000
06-07 17:07:11.541+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.541+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:546,0.840000,-0.210000,0.210000
06-07 17:07:11.541+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.541+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:550,0.910000,-0.210000,0.140000
06-07 17:07:11.541+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.551+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:07:11:542,79
06-07 17:07:11.551+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.551+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:555,0.700000,0.210000,0.070000
06-07 17:07:11.551+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.551+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:562,0.490000,0.210000,-0.210000
06-07 17:07:11.561+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.561+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:566,0.490000,-0.420000,-0.210000
06-07 17:07:11.561+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.561+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:510,0.077302,0.025558,0.059119
06-07 17:07:11.571+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:528,1.342373,-1.789831,9.604790
06-07 17:07:11.571+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.571+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:571,0.070000,-0.490000,-0.350000
06-07 17:07:11.571+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.581+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.581+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:579,1.361516,-1.780260,9.667004
06-07 17:07:11.581+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.581+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:585,0.040229,0.010228,0.066612
06-07 17:07:11.581+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:588,1.339981,-1.763510,9.667004
06-07 17:07:11.581+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.591+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:566,1.333937,-1.778274,9.551373
06-07 17:07:11.591+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.591+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:595,1.373480,-1.722832,9.578469
06-07 17:07:11.591+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.591+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:602,1.335195,-1.718047,9.647861
06-07 17:07:11.601+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.601+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.601+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:584,0.350000,-0.280000,0.140000
06-07 17:07:11.601+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.601+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:607,1.428515,-1.761117,9.609575
06-07 17:07:11.601+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:597,1.334533,-1.776109,9.551693
06-07 17:07:11.601+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.601+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.611+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:614,1.399801,-1.773082,9.655040
06-07 17:07:11.611+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:607,0.069301,-0.042521,0.052518
06-07 17:07:11.611+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.611+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.611+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:611,0.350000,-0.280000,-0.070000
06-07 17:07:11.621+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:621,1.426122,-1.734797,9.609575
06-07 17:07:11.621+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.621+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:614,1.331667,-1.774632,9.552368
06-07 17:07:11.621+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.621+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:628,1.404587,-1.773082,9.645468
06-07 17:07:11.621+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.631+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.631+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:633,1.344766,-1.749153,9.638289
06-07 17:07:11.631+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.631+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:638,0.070000,0.140000,0.140000
06-07 17:07:11.631+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.631+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:640,1.351945,-1.761117,9.659825
06-07 17:07:11.641+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.641+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:647,1.378266,-1.751546,9.614362
06-07 17:07:11.641+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.641+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:620,0.039543,0.014764,0.101274
06-07 17:07:11.641+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.651+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:632,1.334441,-1.772065,9.552457
06-07 17:07:11.651+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.651+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:652,1.375873,-1.715654,9.592826
06-07 17:07:11.651+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.651+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:652,-0.044801,0.007813,0.091382
06-07 17:07:11.651+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:660,1.390230,-1.775474,9.597611
06-07 17:07:11.651+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:642,0.070000,-0.490000,-0.210000
06-07 17:07:11.661+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.661+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.671+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.671+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:657,1.338111,-1.769688,9.552384
06-07 17:07:11.671+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.671+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:675,1.392623,-1.844866,9.554541
06-07 17:07:11.671+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:672,0.056170,0.039835,0.073957
06-07 17:07:11.671+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.681+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:676,-0.140000,-0.210000,-0.210000
06-07 17:07:11.681+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.681+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:07:11.681+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.691+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:679,1.339583,-1.770965,9.551942
06-07 17:07:11.691+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.691+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:683,0.065361,0.075554,-0.017058
06-07 17:07:11.691+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.691+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:694,1.399801,-1.780260,9.633504
06-07 17:07:11.691+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:07:11:695,504.000000
06-07 17:07:11.691+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:689,-0.350000,-0.350000,0.210000
06-07 17:07:11.701+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.701+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:696,1.340885,-1.773086,9.551365
06-07 17:07:11.701+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.701+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.701+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:701,0.047333,-0.027322,0.059585
06-07 17:07:11.711+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:714,1.414158,-1.727618,9.585647
06-07 17:07:11.711+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:710,1.343754,-1.773154,9.550949
06-07 17:07:11.711+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.711+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.721+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:706,-0.490000,-0.350000,0.210000
06-07 17:07:11.721+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.721+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:723,1.346691,-1.771945,9.550760
06-07 17:07:11.721+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.721+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:722,0.033897,-0.035616,0.095919
06-07 17:07:11.721+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.731+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:731,1.348242,-1.770289,9.550848
06-07 17:07:11.731+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.731+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:732,0.066095,-0.014352,0.031890
06-07 17:07:11.731+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:727,-0.070000,-0.140000,0.070000
06-07 17:07:11.731+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:07:11.741+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.741+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:737,1.402194,-1.682154,9.614362
06-07 17:07:11.741+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:07:11:742,79
06-07 17:07:11.741+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:745,0.420000,-0.210000,-0.210000
06-07 17:07:11.741+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.741+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.741+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.751+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:751,1.346671,-1.769748,9.551170
06-07 17:07:11.751+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.751+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.751+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:754,0.075190,-0.002320,0.063413
06-07 17:07:11.751+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.751+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:759,1.399801,-1.737189,9.664611
06-07 17:07:11.751+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:761,0.048325,0.015613,0.061209
06-07 17:07:11.761+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:757,1.346350,-1.767839,9.551569
06-07 17:07:11.761+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.761+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:750,0.560000,-0.070000,0.070000
06-07 17:07:11.761+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.761+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.771+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:774,0.070000,-0.070000,-0.070000
06-07 17:07:11.771+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:774,1.371087,-1.808974,9.635897
06-07 17:07:11.771+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.771+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.771+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:770,1.345043,-1.765108,9.552258
06-07 17:07:11.771+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:780,-0.005868,-0.019542,0.053942
06-07 17:07:11.771+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.781+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:785,1.345251,-1.761132,9.552962
06-07 17:07:11.781+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.781+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:11.781+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.791+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:795,0.014845,-0.010512,0.115833
06-07 17:07:11.791+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.791+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:11:795,1.395016,-1.768296,9.609575
06-07 17:07:11.791+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:779,0.210000,0.070000,-0.070000
06-07 17:07:11.791+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.791+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:790,1.343499,-1.756951,9.553979
06-07 17:07:11.791+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.791+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:802,0.070000,-0.210000,-0.140000
06-07 17:07:11.801+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:799,-0.006370,0.004328,0.115435
06-07 17:07:11.801+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.801+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:11:804,1.347601,-1.756015,9.553574
06-07 17:07:11.811+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:11.811+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.821+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:820,-0.070000,-0.140000,-0.140000
06-07 17:07:11.821+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.831+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:813,0.028437,0.042276,0.026211
06-07 17:07:11.831+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.831+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:11:831,0.070000,-0.070000,-0.140000
06-07 17:07:11.831+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:11.841+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:11:837,-0.010056,0.043086,0.094898
06-07 17:07:11.841+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:11.841+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11161696c6f63152838403
