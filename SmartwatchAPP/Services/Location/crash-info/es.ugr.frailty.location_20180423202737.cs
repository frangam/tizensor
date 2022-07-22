S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 8421
Date: 2018-04-23 20:27:37+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70a052d, r5   = 0xf7547f98
r6   = 0xff8d8e90, r7   = 0xff8d8d40
r8   = 0xf7544c18, r9   = 0x00000000
r10  = 0xff8d8e1c, fp   = 0xff8d8e90
ip   = 0x00000001, sp   = 0xff8d8d18
lr   = 0xf70a0539, pc   = 0xf7109228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     52640 KB
Buffers:     42992 KB
Cached:     192608 KB
VmPeak:      53460 KB
VmSize:      53436 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12036 KB
VmRSS:       12032 KB
VmData:      11164 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 8421 TID = 8421
8421 8424 

Maps Information
f3f6b000 f476a000 rw-p [stack:8424]
f4771000 f4773000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f477b000 f477f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4788000 f478a000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4792000 f4795000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47a4000 f47a9000 r-xp /usr/lib/libsystem.so.0.0.0
f47b4000 f47b7000 r-xp /lib/libattr.so.1.1.0
f47bf000 f47cf000 r-xp /usr/lib/libmdm-common.so.1.1.24
f47d7000 f47e0000 r-xp /usr/lib/libedbus.so.1.7.99
f47e8000 f47e9000 r-xp /usr/lib/libresponse.so.0.2.96
f47f2000 f47f7000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6099000 f619f000 r-xp /usr/lib/libicuuc.so.57.1
f61b5000 f633d000 r-xp /usr/lib/libicui18n.so.57.1
f634d000 f635a000 r-xp /usr/lib/libail.so.0.1.0
f6363000 f636a000 r-xp /usr/lib/libminizip.so.1.0.0
f6373000 f651c000 r-xp /usr/lib/libcrypto.so.1.0.0
f653c000 f6583000 r-xp /usr/lib/libssl.so.1.0.0
f658f000 f6591000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6599000 f65a0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65a9000 f65b0000 r-xp /lib/libcrypt-2.13.so
f65e1000 f65e4000 r-xp /lib/libcap.so.2.21
f65ec000 f65ee000 r-xp /usr/lib/libiri.so
f65f6000 f663f000 r-xp /usr/lib/libmdm.so.1.2.69
f6647000 f664d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6655000 f6678000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6682000 f6684000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f668c000 f66a9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66b2000 f66b6000 r-xp /usr/lib/libsmack.so.1.0.0
f66bf000 f66d8000 r-xp /usr/lib/libnetwork.so.0.0.0
f66e1000 f66e9000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f66f1000 f66f7000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6700000 f6702000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f670b000 f671b000 r-xp /lib/libresolv-2.13.so
f671f000 f6737000 r-xp /usr/lib/liblzma.so.5.0.3
f6740000 f6742000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f674a000 f6764000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f676c000 f679b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67a4000 f67b3000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67bd000 f67c7000 r-xp /usr/lib/libsensord-shared.so
f67d0000 f68a3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68ae000 f68c4000 r-xp /lib/libz.so.1.2.5
f68cc000 f68d1000 r-xp /usr/lib/libffi.so.5.0.10
f68d9000 f68da000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f68e2000 f68f2000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f68fa000 f6913000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f691b000 f691d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6925000 f699a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69a4000 f69aa000 r-xp /lib/librt-2.13.so
f69b3000 f69d1000 r-xp /usr/lib/libsystemd.so.0.4.0
f69db000 f69dc000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f69e4000 f6a07000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a0f000 f6a14000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a1c000 f6a46000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a4f000 f6a66000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a6e000 f6ad7000 r-xp /lib/libm-2.13.so
f6ae0000 f6b74000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b87000 f6b8c000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b94000 f6b9b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ba3000 f6bcd000 r-xp /usr/lib/libsensor.so.1.9.6
f6bd6000 f6ca2000 r-xp /usr/lib/libxml2.so.2.7.8
f6caf000 f6cb1000 r-xp /usr/lib/libiniparser.so.0
f6cba000 f6cc0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6cc9000 f6d99000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d9a000 f6dce000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6dd7000 f6e13000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e1b000 f6e1e000 r-xp /usr/lib/libbundle.so.0.1.22
f6e26000 f6e2c000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e34000 f6e75000 r-xp /usr/lib/libeina.so.1.7.99
f6e7e000 f6e95000 r-xp /usr/lib/libecore.so.1.7.99
f6eac000 f6eb5000 r-xp /usr/lib/libvconf.so.0.2.45
f6ebd000 f6ed1000 r-xp /lib/libpthread-2.13.so
f6edc000 f6ee9000 r-xp /usr/lib/libaul.so.0.1.0
f6ef3000 f6ef5000 r-xp /lib/libdl-2.13.so
f6efe000 f6f09000 r-xp /lib/libunwind.so.8.0.1
f6f36000 f6f3e000 r-xp /lib/libgcc_s-4.6.so.1
f6f3f000 f7063000 r-xp /lib/libc-2.13.so
f7071000 f7073000 r-xp /usr/lib/libdlog.so.0.0.0
f707b000 f7087000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7090000 f7095000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f709d000 f70ac000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70b4000 f70b8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70c1000 f70c4000 r-xp /usr/lib/libappcore-agent.so.1.1
f70cc000 f70ce000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f70d6000 f70da000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f70e2000 f70ff000 r-xp /lib/ld-2.13.so
f7108000 f710b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f710b000 f710f000 r-xp /usr/lib/libsys-assert.so
f7514000 f7582000 rw-p [heap]
ff8ba000 ff8db000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8421)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7109228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf70a0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6da73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6da5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6db1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6db7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6db7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6dec75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6de71f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6da5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6db1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6db7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6db7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6de9e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6dea017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6df1f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47891fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf477c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf684f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6cfcfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6cfe7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e8eca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e89b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e8a5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e8a879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70c2183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70c27fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71094f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6f5685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7108f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
3): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:36.779+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:36:779,-0.002393,9.810574,0.756132
04-23 20:27:36.779+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:36.779+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:36.789+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:36:737,0.007432,-0.005756,-0.027566
04-23 20:27:36.789+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:36.789+0200 E/CAPI_TELEPHONY( 8322): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:27:36.789+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:36.789+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:36:790,-0.070000,-0.070000,0.070000
04-23 20:27:36.799+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:36:786,-0.011964,9.803394,0.792024
04-23 20:27:36.799+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:36.799+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:36:801,0.032608,9.770846,0.836591
04-23 20:27:36.799+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:36.799+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:36:805,0.028714,9.832108,0.789631
04-23 20:27:36.799+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:36.799+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:36.799+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:36:797,0.053533,0.015799,-0.066102
04-23 20:27:36.809+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:36.809+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:36:811,-0.070000,-0.070000,0.070000
04-23 20:27:36.809+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:36:813,-0.016402,0.022944,-0.048956
04-23 20:27:36.809+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:36.809+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:36:805,0.033152,9.770879,0.836195
04-23 20:27:36.809+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:36.819+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:36:819,-0.038245,0.039236,-0.074572
04-23 20:27:36.819+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:36.819+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:36:822,0.035852,9.771338,0.830704
04-23 20:27:36.819+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:36:810,-0.004786,9.793823,0.765703
04-23 20:27:36.819+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:36.819+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:36.829+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:36.829+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:36:830,0.070000,-0.140000,0.070000
04-23 20:27:36.829+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:36:825,-0.047062,0.032104,-0.039261
04-23 20:27:36.829+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:36.829+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:36:831,0.035892,9.801002,0.806381
04-23 20:27:36.829+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:36.829+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:36:837,-0.004731,0.060884,-0.042493
04-23 20:27:36.839+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:36.839+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:36:834,0.035098,9.771291,0.831285
04-23 20:27:36.839+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:36:843,-0.036225,0.022828,-0.069197
04-23 20:27:36.839+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:36.839+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:36.849+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:36.849+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:36:848,0.043071,9.801002,0.772882
04-23 20:27:36.849+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:36:852,0.070000,-0.140000,0.070000
04-23 20:27:36.849+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:36:855,0.033445,9.771225,0.832124
04-23 20:27:36.849+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:36:849,0.004430,0.029977,-0.028167
04-23 20:27:36.849+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:36.849+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:36.859+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:36.859+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:36:860,0.013194,0.030119,-0.063385
04-23 20:27:36.859+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:36.859+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:36:864,0.031440,9.770995,0.834900
04-23 20:27:36.859+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:36:865,0.010362,0.020553,-0.063422
04-23 20:27:36.859+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:36:860,0.040678,9.791430,0.772882
04-23 20:27:36.859+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:36.859+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:36.869+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:36.869+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:36:870,0.070000,-0.070000,0.070000
04-23 20:27:36.869+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:36.869+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:36:870,0.081356,9.810574,0.813560
04-23 20:27:36.869+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:36:875,0.050269,0.039448,-0.019822
04-23 20:27:36.869+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:36.869+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:36.879+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:36:874,0.031462,9.771025,0.834549
04-23 20:27:36.879+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:36:880,0.025721,0.046419,-0.010202
04-23 20:27:36.879+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:36.879+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:36:880,0.057428,9.817751,0.820738
04-23 20:27:36.879+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:36.879+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:36:884,0.029877,9.770883,0.836267
04-23 20:27:36.879+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:36.889+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:36.889+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:36:891,0.030316,9.770878,0.836304
04-23 20:27:36.889+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:36.889+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:36:890,0.070000,-0.070000,0.070000
04-23 20:27:36.889+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:36:893,0.006489,0.070204,-0.025154
04-23 20:27:36.889+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:36:896,0.031087,9.771126,0.833382
04-23 20:27:36.889+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:36.889+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:36.899+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:36:900,0.031706,9.771332,0.830940
04-23 20:27:36.899+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:36.899+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:36:900,0.040678,9.841680,0.803988
04-23 20:27:36.899+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:36.899+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:36:905,0.034189,9.771476,0.829142
04-23 20:27:36.899+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:36.909+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:36.909+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:36:911,0.035425,9.771476,0.829093
04-23 20:27:36.909+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:36.909+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:36:910,0.070000,-0.070000,0.070000
04-23 20:27:36.909+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:36:915,0.035815,9.771502,0.828762
04-23 20:27:36.909+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:36.909+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:36:913,0.002860,0.012776,-0.013140
04-23 20:27:36.919+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:36:920,0.038285,9.784252,0.815953
04-23 20:27:36.919+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:36.919+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:36.929+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:36.929+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:36:930,0.036083,9.771445,0.829418
04-23 20:27:36.929+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:36.929+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:36:930,0.070000,-0.070000,0.070000
04-23 20:27:36.929+0200 I/heartrate( 8278): capturing data from es.ugr.frailty.heartrate
04-23 20:27:36.929+0200 I/heartrate( 8278): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:27:36.929+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:36:933,-0.047780,0.043856,0.003941
04-23 20:27:36.929+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:36:936,-0.011964,9.815358,0.832702
04-23 20:27:36.939+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:36.939+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:36.939+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:36.949+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:36.949+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:36:951,0.033968,9.771151,0.832971
04-23 20:27:36.949+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:36:951,0.070000,0.070000,0.070000
04-23 20:27:36.949+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:36:955,-0.048047,0.051092,-0.015858
04-23 20:27:36.949+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:36:951,-0.011964,9.822537,0.813560
04-23 20:27:36.959+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:36.959+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:36.959+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:36.969+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:36.969+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:36:970,0.031961,9.770904,0.835943
04-23 20:27:36.969+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:36:970,-0.070000,-0.140000,0.070000
04-23 20:27:36.969+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:36:970,0.038285,9.810574,0.770489
04-23 20:27:36.969+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:36:973,0.004317,0.039423,-0.062482
04-23 20:27:36.979+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:36.979+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:36.979+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:36.989+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:36.989+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:36:990,0.032427,9.771094,0.833696
04-23 20:27:36.989+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:36:990,-0.070000,-0.140000,0.070000
04-23 20:27:36.989+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:36:993,-0.017604,0.087525,-0.053490
04-23 20:27:36.989+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:36:990,0.014357,9.858429,0.782453
04-23 20:27:36.999+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.009+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.009+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:10,0.031722,9.771083,0.833858
04-23 20:27:37.009+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.009+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:13,0.015429,0.061014,-0.084742
04-23 20:27:37.009+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.019+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:16,-0.070000,-0.140000,0.070000
04-23 20:27:37.019+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:20,0.047856,9.832108,0.748954
04-23 20:27:37.019+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.019+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.019+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.029+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:30,-0.007793,0.022740,-0.017906
04-23 20:27:37.039+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:30,-0.070000,0.070000,0.070000
04-23 20:27:37.049+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.049+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:30,0.032646,9.771400,0.830091
04-23 20:27:37.049+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.059+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.059+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.069+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:63,0.023928,9.793823,0.815953
04-23 20:27:37.069+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:54,-0.027860,0.017637,-0.021317
04-23 20:27:37.079+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:67,0.032391,9.771270,0.831634
04-23 20:27:37.079+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:66,-0.070000,-0.070000,0.070000
04-23 20:27:37.079+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.079+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.089+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.089+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:95,0.004786,9.789038,0.808774
04-23 20:27:37.099+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.099+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:106,-0.029998,0.027339,-0.018074
04-23 20:27:37.109+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:100,0.031229,9.771047,0.834298
04-23 20:27:37.109+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.109+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:99,-0.070000,0.070000,0.070000
04-23 20:27:37.109+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.119+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.119+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.129+0200 I/heartrate( 8278): capturing data from es.ugr.frailty.heartrate
04-23 20:27:37.129+0200 I/heartrate( 8278): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:27:37.139+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:124,0.023806,0.010812,-0.042273
04-23 20:27:37.139+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.139+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:128,0.002393,9.798609,0.813560
04-23 20:27:37.149+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:134,0.030006,9.770821,0.836988
04-23 20:27:37.149+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.149+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.149+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:130,0.070000,0.070000,0.070000
04-23 20:27:37.149+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:158,0.055035,9.781858,0.792024
04-23 20:27:37.159+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:147,-0.003685,0.032574,-0.044964
04-23 20:27:37.159+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.159+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.169+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:168,0.011719,0.025199,-0.040223
04-23 20:27:37.169+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.169+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:167,0.070000,-0.070000,0.070000
04-23 20:27:37.169+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:174,-0.007322,0.068281,-0.004484
04-23 20:27:37.169+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.169+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:166,0.031352,9.771017,0.834640
04-23 20:27:37.169+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.179+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:179,0.011107,0.051429,-0.019989
04-23 20:27:37.179+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.179+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.179+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:181,0.026321,9.803394,0.792024
04-23 20:27:37.179+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.179+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.189+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:190,-0.005410,0.049171,-0.019193
04-23 20:27:37.189+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:187,0.070000,0.070000,0.070000
04-23 20:27:37.189+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:187,0.043071,9.796216,0.794417
04-23 20:27:37.189+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:186,0.031251,9.771005,0.834793
04-23 20:27:37.189+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.189+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.189+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.189+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:197,0.023928,9.839286,0.830309
04-23 20:27:37.189+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.199+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:202,0.070000,-0.070000,0.070000
04-23 20:27:37.199+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:202,0.043071,9.822537,0.813560
04-23 20:27:37.199+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.199+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:207,0.026321,9.820145,0.815953
04-23 20:27:37.199+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.199+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:200,0.031964,9.771109,0.833549
04-23 20:27:37.209+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.209+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.209+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:212,0.017972,0.006175,-0.036801
04-23 20:27:37.209+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.209+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:214,0.031732,9.770973,0.835146
04-23 20:27:37.209+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:217,0.050249,9.777073,0.799203
04-23 20:27:37.219+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.219+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:216,0.070000,-0.070000,0.070000
04-23 20:27:37.219+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.219+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:224,0.032412,9.770992,0.834887
04-23 20:27:37.219+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.219+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.219+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.229+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:231,-0.068170,0.049247,-0.058336
04-23 20:27:37.229+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:231,-0.035892,9.820145,0.777667
04-23 20:27:37.229+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:225,0.070000,-0.070000,0.070000
04-23 20:27:37.229+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:228,0.032277,9.770898,0.836004
04-23 20:27:37.229+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.229+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.239+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:238,0.033291,9.770982,0.834984
04-23 20:27:37.239+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:239,-0.070000,-0.070000,0.070000
04-23 20:27:37.239+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.239+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:245,-0.070000,-0.070000,0.070000
04-23 20:27:37.249+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.249+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.249+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.249+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:255,0.030136,9.770659,0.838867
04-23 20:27:37.249+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.249+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:254,-0.030899,0.053947,-0.047746
04-23 20:27:37.259+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:255,0.002393,9.824929,0.787239
04-23 20:27:37.259+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:260,0.070000,-0.140000,0.070000
04-23 20:27:37.259+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.259+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.269+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:270,-0.002393,9.796216,0.794417
04-23 20:27:37.269+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:270,0.028969,9.770565,0.839998
04-23 20:27:37.269+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.269+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.269+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:274,-0.032529,0.025557,-0.044450
04-23 20:27:37.269+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:277,0.070000,-0.140000,0.070000
04-23 20:27:37.279+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:27:37.279+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:27:37.279+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:27:37.279+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.279+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.279+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.289+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.289+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:291,0.070000,-0.140000,0.070000
04-23 20:27:37.289+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:291,0.023928,9.815358,0.777667
04-23 20:27:37.289+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:291,-0.005040,0.044793,-0.062331
04-23 20:27:37.289+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:293,0.027635,9.770399,0.841975
04-23 20:27:37.299+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.299+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.309+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.309+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.309+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:313,-0.032420,0.018639,-0.021237
04-23 20:27:37.309+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:313,0.027608,9.770498,0.840826
04-23 20:27:37.309+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:310,0.070000,-0.070000,0.070000
04-23 20:27:37.309+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:310,-0.004786,9.789038,0.820738
04-23 20:27:37.319+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.319+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.329+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.329+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.329+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:331,0.070000,0.070000,0.070000
04-23 20:27:37.329+0200 I/heartrate( 8278): capturing data from es.ugr.frailty.heartrate
04-23 20:27:37.329+0200 I/heartrate( 8278): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:27:37.329+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:331,-0.003680,0.025718,-0.053587
04-23 20:27:37.339+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:336,0.023928,9.796216,0.787239
04-23 20:27:37.339+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:334,0.026222,9.770167,0.844709
04-23 20:27:37.339+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.339+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.349+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:352,0.070000,0.070000,0.070000
04-23 20:27:37.349+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.349+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.349+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:352,-0.011865,0.018870,-0.090970
04-23 20:27:37.359+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:358,0.026253,9.770188,0.844460
04-23 20:27:37.359+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:359,0.014357,9.789038,0.753739
04-23 20:27:37.359+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.369+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.369+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:373,0.031607,0.033200,-0.054782
04-23 20:27:37.369+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.379+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:370,-0.070000,0.140000,0.070000
04-23 20:27:37.379+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.379+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:380,0.057428,9.803394,0.789631
04-23 20:27:37.379+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.379+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.389+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:391,-0.070000,0.070000,0.070000
04-23 20:27:37.389+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:384,0.025820,9.770194,0.844414
04-23 20:27:37.389+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.389+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.399+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:392,-0.016249,-0.031405,-0.057175
04-23 20:27:37.399+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:399,0.027467,9.770478,0.841061
04-23 20:27:37.399+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:398,0.009571,9.738789,0.787239
04-23 20:27:37.399+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.399+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.409+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.409+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:413,-0.008325,0.023345,-0.056216
04-23 20:27:37.419+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:411,0.070000,0.070000,0.070000
04-23 20:27:37.419+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.419+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.429+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.429+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:412,0.019143,9.793823,0.784846
04-23 20:27:37.429+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.429+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:433,-0.038723,0.037837,-0.084131
04-23 20:27:37.439+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:438,-0.011964,9.808180,0.758525
04-23 20:27:37.449+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.449+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.449+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:454,0.019143,9.781858,0.777667
04-23 20:27:37.459+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:460,-0.007406,0.011496,-0.064760
04-23 20:27:37.459+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.459+0200 W/LOCATION( 8421): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:27:37.469+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:471,0.014357,9.822537,0.825524
04-23 20:27:37.469+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.469+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:424,0.026758,9.770343,0.842655
04-23 20:27:37.469+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.479+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:431,0.070000,-0.070000,0.070000
04-23 20:27:37.479+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.479+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:479,-0.010489,0.052424,-0.019850
04-23 20:27:37.479+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:484,0.070000,-0.070000,0.070000
04-23 20:27:37.479+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.489+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.489+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:490,0.052642,9.832108,0.801596
04-23 20:27:37.489+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:493,0.027909,0.061967,-0.043450
04-23 20:27:37.499+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.499+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:482,0.026548,9.770363,0.842427
04-23 20:27:37.499+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.499+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.499+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.509+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:513,0.040678,9.832108,0.784846
04-23 20:27:37.519+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:512,0.016291,0.062213,-0.063057
04-23 20:27:37.519+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:511,0.024846,9.770113,0.845373
04-23 20:27:37.519+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.519+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:505,-0.070000,-0.070000,0.070000
04-23 20:27:37.519+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.519+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.519+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.529+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:525,0.024733,9.770142,0.845046
04-23 20:27:37.529+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.529+0200 I/heartrate( 8278): capturing data from es.ugr.frailty.heartrate
04-23 20:27:37.529+0200 I/heartrate( 8278): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:27:37.529+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:530,0.009571,9.822537,0.792024
04-23 20:27:37.529+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:531,-0.016289,0.052407,-0.053120
04-23 20:27:37.539+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:529,-0.070000,0.070000,0.070000
04-23 20:27:37.539+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.539+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:535,0.024387,9.769896,0.847903
04-23 20:27:37.539+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.539+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.549+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:552,-0.007178,9.803394,0.780060
04-23 20:27:37.549+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.549+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:552,-0.033885,0.033077,-0.062898
04-23 20:27:37.559+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:548,-0.070000,0.070000,0.070000
04-23 20:27:37.559+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.559+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:558,0.025861,9.770130,0.845145
04-23 20:27:37.559+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.559+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.559+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.569+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:571,0.016750,9.812965,0.832702
04-23 20:27:37.569+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:566,-0.070000,0.070000,0.070000
04-23 20:27:37.569+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:571,-0.009297,0.042765,-0.011621
04-23 20:27:37.569+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.579+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:582,-0.070000,-0.070000,0.070000
04-23 20:27:37.579+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.579+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:568,0.026706,9.770317,0.842959
04-23 20:27:37.579+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.579+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.589+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.589+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:591,0.008902,0.035929,-0.065867
04-23 20:27:37.589+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:595,0.026046,9.770201,0.844323
04-23 20:27:37.589+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:589,-0.070000,0.140000,0.070000
04-23 20:27:37.589+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:590,0.033500,9.805787,0.782453
04-23 20:27:37.589+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.599+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:602,-0.070000,0.140000,0.070000
04-23 20:27:37.599+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.599+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.609+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.609+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:609,0.024597,9.769858,0.848320
04-23 20:27:37.609+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.609+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:611,0.006742,0.060129,-0.073791
04-23 20:27:37.609+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:613,0.031107,9.829715,0.777667
04-23 20:27:37.609+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:618,0.024365,9.769586,0.851458
04-23 20:27:37.609+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.619+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.619+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:624,0.024945,9.769751,0.849546
04-23 20:27:37.619+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.619+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.629+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:630,-0.027338,0.105429,-0.059914
04-23 20:27:37.629+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:630,-0.002393,9.875179,0.789631
04-23 20:27:37.629+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:622,-0.070000,0.070000,0.070000
04-23 20:27:37.629+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.629+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.629+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:637,0.025393,9.769953,0.847204
04-23 20:27:37.639+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:641,-0.070000,-0.070000,0.070000
04-23 20:27:37.639+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.639+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.649+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:652,0.024209,9.769698,0.850173
04-23 20:27:37.649+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.659+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:653,0.031107,9.812965,0.763310
04-23 20:27:37.659+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:660,0.005713,0.043013,-0.083894
04-23 20:27:37.659+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.659+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.669+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.669+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.679+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:671,0.021535,9.784252,0.813560
04-23 20:27:37.679+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:682,-0.002673,0.014554,-0.036613
04-23 20:27:37.679+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:671,0.024681,9.769959,0.847152
04-23 20:27:37.679+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.689+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.689+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:679,0.070000,0.070000,0.070000
04-23 20:27:37.689+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.689+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.699+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:693,0.024673,9.769846,0.848456
04-23 20:27:37.699+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:695,0.021535,9.822537,0.820738
04-23 20:27:37.709+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.709+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.709+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:703,0.070000,0.070000,0.070000
04-23 20:27:37.709+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:37:717,0.002393,9.808180,0.825524
04-23 20:27:37.719+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:706,-0.003146,0.052578,-0.026413
04-23 20:27:37.719+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:717,0.024662,9.769720,0.849908
04-23 20:27:37.719+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.719+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.729+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:37:728,0.070000,0.070000,0.070000
04-23 20:27:37.729+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:37.729+0200 I/heartrate( 8278): capturing data from es.ugr.frailty.heartrate
04-23 20:27:37.729+0200 I/heartrate( 8278): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:27:37.729+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:37.729+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:37:729,-0.022280,0.038334,-0.022932
04-23 20:27:37.739+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:37.739+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:37:741,0.023758,9.769366,0.853991
04-23 20:27:37.749+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:37.759+0200 W/CRASH_MANAGER( 8352): worker.c: worker_job(1205) > 11084216c6f63152450805
