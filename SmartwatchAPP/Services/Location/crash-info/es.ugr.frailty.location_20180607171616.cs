S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 18971
Date: 2018-06-07 17:16:16+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf739c52d, r5   = 0xf7595f98
r6   = 0xff817040, r7   = 0xff816ef0
r8   = 0xf7592c18, r9   = 0x00000000
r10  = 0xff816fcc, fp   = 0xff817040
ip   = 0x00000001, sp   = 0xff816ec8
lr   = 0xf739c539, pc   = 0xf7405228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    319548 KB
Buffers:      6960 KB
Cached:      50168 KB
VmPeak:      53636 KB
VmSize:      53572 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11852 KB
VmRSS:       11848 KB
VmData:      11300 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 18971 TID = 18971
18971 18979 

Maps Information
f4267000 f4a66000 rw-p [stack:18979]
f4a6d000 f4a6f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4a77000 f4a7b000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4a84000 f4a86000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4a8e000 f4a91000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4aa0000 f4aa5000 r-xp /usr/lib/libsystem.so.0.0.0
f4ab0000 f4ab3000 r-xp /lib/libattr.so.1.1.0
f4abb000 f4acb000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4ad3000 f4adc000 r-xp /usr/lib/libedbus.so.1.7.99
f4ae4000 f4ae5000 r-xp /usr/lib/libresponse.so.0.2.96
f4aee000 f4af3000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6395000 f649b000 r-xp /usr/lib/libicuuc.so.57.1
f64b1000 f6639000 r-xp /usr/lib/libicui18n.so.57.1
f6649000 f6656000 r-xp /usr/lib/libail.so.0.1.0
f665f000 f6666000 r-xp /usr/lib/libminizip.so.1.0.0
f666f000 f6818000 r-xp /usr/lib/libcrypto.so.1.0.0
f6838000 f687f000 r-xp /usr/lib/libssl.so.1.0.0
f688b000 f688d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6895000 f689c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f68a5000 f68ac000 r-xp /lib/libcrypt-2.13.so
f68dd000 f68e0000 r-xp /lib/libcap.so.2.21
f68e8000 f68ea000 r-xp /usr/lib/libiri.so
f68f2000 f693b000 r-xp /usr/lib/libmdm.so.1.2.69
f6943000 f6949000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6951000 f6974000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f697e000 f6980000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6988000 f69a5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f69ae000 f69b2000 r-xp /usr/lib/libsmack.so.1.0.0
f69bb000 f69d4000 r-xp /usr/lib/libnetwork.so.0.0.0
f69dd000 f69e5000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f69ed000 f69f3000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f69fc000 f69fe000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a07000 f6a17000 r-xp /lib/libresolv-2.13.so
f6a1b000 f6a33000 r-xp /usr/lib/liblzma.so.5.0.3
f6a3c000 f6a3e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a46000 f6a60000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a68000 f6a97000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6aa0000 f6aaf000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6ab9000 f6ac3000 r-xp /usr/lib/libsensord-shared.so
f6acc000 f6b9f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6baa000 f6bc0000 r-xp /lib/libz.so.1.2.5
f6bc8000 f6bcd000 r-xp /usr/lib/libffi.so.5.0.10
f6bd5000 f6bd6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6bde000 f6bee000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6bf6000 f6c0f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c17000 f6c19000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c21000 f6c96000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ca0000 f6ca6000 r-xp /lib/librt-2.13.so
f6caf000 f6ccd000 r-xp /usr/lib/libsystemd.so.0.4.0
f6cd7000 f6cd8000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ce0000 f6d03000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d0b000 f6d10000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d18000 f6d42000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d4b000 f6d62000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d6a000 f6dd3000 r-xp /lib/libm-2.13.so
f6ddc000 f6e70000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e83000 f6e88000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e90000 f6e97000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e9f000 f6ec9000 r-xp /usr/lib/libsensor.so.1.9.6
f6ed2000 f6f9e000 r-xp /usr/lib/libxml2.so.2.7.8
f6fab000 f6fad000 r-xp /usr/lib/libiniparser.so.0
f6fb6000 f6fbc000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6fc5000 f7095000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7096000 f70ca000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f70d3000 f710f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7117000 f711a000 r-xp /usr/lib/libbundle.so.0.1.22
f7122000 f7128000 r-xp /usr/lib/libappsvc.so.0.1.0
f7130000 f7171000 r-xp /usr/lib/libeina.so.1.7.99
f717a000 f7191000 r-xp /usr/lib/libecore.so.1.7.99
f71a8000 f71b1000 r-xp /usr/lib/libvconf.so.0.2.45
f71b9000 f71cd000 r-xp /lib/libpthread-2.13.so
f71d8000 f71e5000 r-xp /usr/lib/libaul.so.0.1.0
f71ef000 f71f1000 r-xp /lib/libdl-2.13.so
f71fa000 f7205000 r-xp /lib/libunwind.so.8.0.1
f7232000 f723a000 r-xp /lib/libgcc_s-4.6.so.1
f723b000 f735f000 r-xp /lib/libc-2.13.so
f736d000 f736f000 r-xp /usr/lib/libdlog.so.0.0.0
f7377000 f7383000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f738c000 f7391000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7399000 f73a8000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f73b0000 f73b4000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f73bd000 f73c0000 r-xp /usr/lib/libappcore-agent.so.1.1
f73c8000 f73ca000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f73d2000 f73d6000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f73de000 f73fb000 r-xp /lib/ld-2.13.so
f7404000 f7407000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7407000 f740b000 r-xp /usr/lib/libsys-assert.so
f7562000 f75f0000 rw-p [heap]
ff7f8000 ff819000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18971)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7405228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf739c539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70a33f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf70a1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf70ade57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf70b3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf70b3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf70e875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70e31f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf70a1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf70ade57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf70b3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf70b3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf70e5e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf70e6017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf70edf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4a851fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4a78171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6b4b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6ff8fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6ffa7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf718aca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7185b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71865a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7186879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf73be183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73be7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74055c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf725285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7404f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:16:605,-0.000309,-0.011495,0.066743
06-07 17:16:16.601+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:16.601+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:16:592,0.311470,-0.094787,9.801244
06-07 17:16:16.601+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:16.601+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:16:611,0.011365,0.017912,0.021297
06-07 17:16:16.611+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:16.611+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:16:599,0.351745,-0.124427,9.887143
06-07 17:16:16.611+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:16:16.621+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:16:16:621,979.000000
06-07 17:16:16.621+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:16:616,0.009169,-0.026343,0.066742
06-07 17:16:16.621+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:16.621+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:16:602,0.070000,0.070000,0.070000
06-07 17:16:16.621+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:16:621,0.310689,-0.094961,9.801268
06-07 17:16:16.621+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:16.621+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:16.621+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:16:628,-0.002792,0.001011,0.100252
06-07 17:16:16.621+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:16.631+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:16.631+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:16:636,0.007718,-0.011372,0.045182
06-07 17:16:16.631+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:16.641+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:16:638,0.339781,-0.129212,9.841680
06-07 17:16:16.641+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:16:16.641+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:16:16.641+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:16:644,0.005416,-0.001456,0.028433
06-07 17:16:16.641+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:16:634,0.311532,-0.095022,9.801240
06-07 17:16:16.641+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:16.641+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:16.651+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:16:634,0.070000,0.070000,0.070000
06-07 17:16:16.651+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:16.651+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:16.651+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:16:654,0.323031,-0.069392,9.853643
06-07 17:16:16.651+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:16:658,-0.001567,0.007999,0.095425
06-07 17:16:16.651+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:16:654,0.311485,-0.094980,9.801242
06-07 17:16:16.661+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:16.661+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:16:666,0.311375,-0.093789,9.801257
06-07 17:16:16.661+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:16.661+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:16:671,0.005934,0.002662,0.102589
06-07 17:16:16.671+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:16.671+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:16.671+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:16.671+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:16:665,0.070000,0.070000,0.070000
06-07 17:16:16.671+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:16:676,0.311666,-0.094482,9.801241
06-07 17:16:16.671+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:16.671+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:16.681+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:16:689,0.070000,0.070000,0.140000
06-07 17:16:16.681+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:16:681,0.006225,0.023852,0.073862
06-07 17:16:16.691+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:16:689,0.311469,-0.093298,9.801258
06-07 17:16:16.691+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:16:680,0.327817,-0.074178,9.853643
06-07 17:16:16.691+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:16.701+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:16.701+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:16.701+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:16:706,0.023480,-0.013535,0.073832
06-07 17:16:16.701+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:16.711+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:16:703,0.320638,-0.074178,9.868000
06-07 17:16:16.711+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:16.711+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:16:711,0.070000,0.070000,0.070000
06-07 17:16:16.711+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:16.711+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:16.711+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:16:707,0.311466,-0.094331,9.801249
06-07 17:16:16.721+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:16.721+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:16:724,0.011157,-0.003685,0.071453
06-07 17:16:16.721+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:16:722,-0.070000,-0.070000,0.070000
06-07 17:16:16.731+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:16:726,0.310527,-0.093913,9.801283
06-07 17:16:16.731+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:16.731+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:16:718,0.339781,-0.112463,9.858429
06-07 17:16:16.731+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:16.731+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:16.741+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:16.741+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:16:746,-0.026881,0.015276,0.037943
06-07 17:16:16.741+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:16:736,0.310437,-0.094257,9.801282
06-07 17:16:16.741+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:16.751+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:16:739,0.323031,-0.131605,9.836893
06-07 17:16:16.751+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:16.751+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:16:742,0.140000,0.070000,0.070000
06-07 17:16:16.751+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:16.751+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:16.761+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:16:757,0.306281,-0.093320,9.863215
06-07 17:16:16.761+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:16.761+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:16:765,0.001153,-0.014368,0.073773
06-07 17:16:16.761+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:16:763,0.070000,0.070000,0.070000
06-07 17:16:16.761+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:16.761+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:16:751,0.310241,-0.094140,9.801290
06-07 17:16:16.771+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:16.771+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:16.781+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:16:776,0.309919,-0.093589,9.801305
06-07 17:16:16.781+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:16:772,0.140000,0.070000,0.070000
06-07 17:16:16.781+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:16.781+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:16.781+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:16:768,0.294317,-0.098106,9.839286
06-07 17:16:16.791+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:16.791+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:16:784,-0.007975,0.002857,0.054622
06-07 17:16:16.791+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:16:793,0.309628,-0.093244,9.801317
06-07 17:16:16.791+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:16.791+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:16.801+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:16:791,0.070000,0.070000,0.070000
06-07 17:16:16.801+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:16.801+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:16:796,0.351745,-0.117248,9.856036
06-07 17:16:16.801+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:16.811+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:16:804,0.029039,-0.007199,0.066545
06-07 17:16:16.811+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:16:803,0.309122,-0.091749,9.801348
06-07 17:16:16.811+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:16.811+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:16:16.811+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:16.821+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:16:16:823,971.000000
06-07 17:16:16.821+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:16:814,0.325424,-0.090927,9.860823
06-07 17:16:16.821+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:16.821+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:16:832,0.311067,-0.102891,9.822537
06-07 17:16:16.831+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:16:825,0.025809,-0.011840,0.073752
06-07 17:16:16.831+0200 I/servicemanager(17973): es.ugr.frailty.accelerometer alive timeout
06-07 17:16:16.831+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:16:16.831+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:16.831+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:16.841+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:16.841+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:16:846,0.058597,-0.009095,0.068993
06-07 17:16:16.841+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19019
06-07 17:16:16.851+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:16:16.851+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:16:16.851+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19019)
06-07 17:16:16.851+0200 I/servicemanager(17973): es.ugr.frailty.accelerometer launch request sent!
06-07 17:16:16.851+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:16.851+0200 I/servicemanager(17973): es.ugr.frailty.gyroscope alive timeout
06-07 17:16:16.851+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:16:16.851+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:16.851+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:16.851+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:16.861+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19004
06-07 17:16:16.861+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19004)
06-07 17:16:16.861+0200 I/servicemanager(17973): es.ugr.frailty.gyroscope launch request sent!
06-07 17:16:16.861+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:16.861+0200 I/servicemanager(17973): es.ugr.frailty.heartrate alive timeout
06-07 17:16:16.861+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:16:16.871+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:16.871+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:16.871+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:16:864,-0.005630,-0.035192,0.006844
06-07 17:16:16.871+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:16.881+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18034
06-07 17:16:16.881+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:16:884,0.017006,-0.017248,0.080998
06-07 17:16:16.881+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:16:16.881+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(18034), cmd(0)
06-07 17:16:16.891+0200 W/CAPI_APPFW_APP_CONTROL(18034): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:16:16.891+0200 I/utils   (18034): specific action
06-07 17:16:16.891+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18034)
06-07 17:16:16.891+0200 I/servicemanager(17973): es.ugr.frailty.heartrate launch request sent!
06-07 17:16:16.891+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:16.891+0200 I/servicemanager(17973): es.ugr.frailty.location alive timeout
06-07 17:16:16.891+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:16:16.891+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:16.891+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:16.901+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:16.901+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18971
06-07 17:16:16.901+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:16:908,0.014295,-0.004684,0.116905
06-07 17:16:16.901+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18971)
06-07 17:16:16.901+0200 I/servicemanager(17973): es.ugr.frailty.location launch request sent!
06-07 17:16:16.901+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:16.901+0200 I/servicemanager(17973): es.ugr.frailty.linearacceleration alive timeout
06-07 17:16:16.901+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:16:16.911+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:16.911+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:16.921+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:16:808,0.070000,0.070000,0.070000
06-07 17:16:16.921+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:16.921+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19049
06-07 17:16:16.921+0200 W/CAPI_APPFW_APP_CONTROL(19049): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:16:16.931+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:16:16.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(19049), cmd(0)
06-07 17:16:16.931+0200 I/utils   (19049): specific action
06-07 17:16:16.931+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:16.931+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19049)
06-07 17:16:16.931+0200 I/servicemanager(17973): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:16:16.931+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:16.931+0200 I/servicemanager(17973): es.ugr.frailty.gravity alive timeout
06-07 17:16:16.931+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:16:16.931+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:16.931+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:16.951+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:16:937,-0.012114,-0.019046,0.045124
06-07 17:16:16.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19031
06-07 17:16:16.951+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:16:929,0.070000,-0.070000,0.070000
06-07 17:16:16.951+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:16.951+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19031)
06-07 17:16:16.951+0200 I/servicemanager(17973): es.ugr.frailty.gravity launch request sent!
06-07 17:16:16.951+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:16.951+0200 I/servicemanager(17973): es.ugr.frailty.pressure alive timeout
06-07 17:16:16.951+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:16:16.961+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:16.961+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:16.961+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:16.961+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:16:968,0.000886,0.000820,0.033134
06-07 17:16:16.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18075
06-07 17:16:16.981+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:16:16.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(18075), cmd(0)
06-07 17:16:16.981+0200 W/CAPI_APPFW_APP_CONTROL(18075): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:16:16.981+0200 I/utils   (18075): specific action
06-07 17:16:16.981+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18075)
06-07 17:16:16.981+0200 I/servicemanager(17973): es.ugr.frailty.pressure launch request sent!
06-07 17:16:16.981+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:16.981+0200 I/servicemanager(17973): es.ugr.frailty.light alive timeout
06-07 17:16:16.911+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:16.981+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:16:16.981+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:16.981+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:16.981+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:16:989,0.327817,-0.081356,9.856036
06-07 17:16:16.991+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:16:961,0.070000,0.070000,0.070000
06-07 17:16:16.991+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:16.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18079
06-07 17:16:16.991+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:16.991+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18079)
06-07 17:16:17.001+0200 I/servicemanager(17973): es.ugr.frailty.light launch request sent!
06-07 17:16:17.001+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:17.001+0200 I/servicemanager(17973): es.ugr.frailty.pedometer alive timeout
06-07 17:16:17.001+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:16:17.001+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:17.001+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:17.001+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:17.011+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18111
06-07 17:16:17.011+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:16:820,0.309481,-0.092028,9.801333
06-07 17:16:17.011+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:17.011+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18111)
06-07 17:16:17.011+0200 I/servicemanager(17973): es.ugr.frailty.pedometer launch request sent!
06-07 17:16:17.011+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:17.021+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:16:17.021+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(18079), cmd(0)
06-07 17:16:17.021+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:16:17.021+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(18111), cmd(0)
06-07 17:16:17.021+0200 W/CAPI_APPFW_APP_CONTROL(18079): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:16:17.021+0200 W/CAPI_APPFW_APP_CONTROL(18111): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:16:17.021+0200 I/utils   (18111): specific action
06-07 17:16:17.021+0200 I/utils   (18079): specific action
06-07 17:16:17.021+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:16:17.031+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:16:17:35,961.000000
06-07 17:16:17.031+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:17:12,0.140000,0.070000,0.070000
06-07 17:16:17.031+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:12,0.315853,-0.141177,9.844072
06-07 17:16:17.031+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.041+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:43,0.306281,-0.102891,9.889536
06-07 17:16:17.041+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:16:17.041+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:17:21,0.008481,0.012556,0.059441
06-07 17:16:17.041+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:16:17.041+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.041+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:17:29,0.309234,-0.091846,9.801343
06-07 17:16:17.041+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:17.051+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:51,0.339781,-0.100499,9.870394
06-07 17:16:17.051+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.051+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:16:17.051+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:16:17.051+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:16:17.061+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:58,0.320638,-0.098106,9.841680
06-07 17:16:17.061+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:17.061+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.061+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:17.061+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:70,0.320638,-0.074178,9.868000
06-07 17:16:17.071+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.071+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:17:53,0.140000,0.070000,0.070000
06-07 17:16:17.071+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:76,0.311067,-0.105284,9.868000
06-07 17:16:17.071+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:16:17.071+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(19019), cmd(0)
06-07 17:16:17.081+0200 W/CAPI_APPFW_APP_CONTROL(19019): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:16:17.081+0200 I/utils   (19019): specific action
06-07 17:16:17.081+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.081+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:88,0.323031,-0.076570,9.822537
06-07 17:16:17.081+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.091+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:17:69,0.015785,0.006974,0.073786
06-07 17:16:17.091+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:93,0.320638,-0.119641,9.868000
06-07 17:16:17.091+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.091+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:17.091+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:17:84,0.307521,-0.090916,9.801406
06-07 17:16:17.091+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:99,0.308674,-0.093320,9.901501
06-07 17:16:17.091+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:17.101+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.101+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:17:105,0.140000,0.070000,0.070000
06-07 17:16:17.101+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:106,0.318245,-0.105284,9.846465
06-07 17:16:17.101+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.101+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:17.111+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:111,0.315853,-0.095713,9.829715
06-07 17:16:17.111+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.111+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:17:117,0.307078,-0.091392,9.801414
06-07 17:16:17.111+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:117,0.308674,-0.086142,9.896714
06-07 17:16:17.111+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.121+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:122,0.315853,-0.090927,9.903893
06-07 17:16:17.121+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.121+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:17:103,0.039028,-0.033933,0.052269
06-07 17:16:17.121+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:127,0.315853,-0.069392,9.875179
06-07 17:16:17.121+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:17.121+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.121+0200 W/CAPI_APPFW_APP_CONTROL(19004): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:16:17.121+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:16:17.121+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(19004), cmd(0)
06-07 17:16:17.131+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:17.131+0200 I/utils   (19004): specific action
06-07 17:16:17.131+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:17.131+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:132,0.332602,-0.105284,9.875179
06-07 17:16:17.131+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.141+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:142,0.320638,-0.095713,9.872787
06-07 17:16:17.141+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.141+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:17:133,-0.034761,0.034747,0.037991
06-07 17:16:17.141+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:147,0.282353,-0.076570,9.839286
06-07 17:16:17.141+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.141+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:152,0.308674,-0.105284,9.875179
06-07 17:16:17.151+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.151+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:17.151+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:17:138,0.070000,0.070000,0.070000
06-07 17:16:17.151+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:156,0.299103,-0.088534,9.856036
06-07 17:16:17.151+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.151+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:17.151+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:17:143,0.305956,-0.090907,9.801455
06-07 17:16:17.161+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:162,0.334995,-0.098106,9.868000
06-07 17:16:17.161+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.161+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:169,0.332602,-0.102891,9.875179
06-07 17:16:17.161+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.171+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:16:17.171+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(19031), cmd(0)
06-07 17:16:17.171+0200 W/CAPI_APPFW_APP_CONTROL(19031): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:16:17.171+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:17:161,-0.006236,-0.041485,0.088152
06-07 17:16:17.171+0200 I/utils   (19031): specific action
06-07 17:16:17.171+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:17.171+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:173,0.366102,-0.100499,9.870394
06-07 17:16:17.171+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.181+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:17:166,0.070000,0.070000,0.070000
06-07 17:16:17.181+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:185,0.303888,-0.126820,9.808180
06-07 17:16:17.181+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:17.181+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.181+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:17:178,0.306793,-0.091051,9.801427
06-07 17:16:17.181+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:190,0.325424,-0.110070,9.882358
06-07 17:16:17.181+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.191+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:195,0.323031,-0.098106,9.918249
06-07 17:16:17.191+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:17.191+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.201+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:203,0.296710,-0.112463,9.846465
06-07 17:16:17.201+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.201+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:17.201+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:208,0.308674,-0.093320,9.834501
06-07 17:16:17.201+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.211+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:17:206,0.140000,0.070000,0.070000
06-07 17:16:17.211+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:214,0.315853,-0.081356,9.860823
06-07 17:16:17.211+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:17:195,0.025620,-0.008635,0.080967
06-07 17:16:17.211+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.211+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:16:17.221+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:17.221+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:16:17:223,965.000000
06-07 17:16:17.221+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:17:227,-0.001232,0.008290,0.049879
06-07 17:16:17.221+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:220,0.323031,-0.086142,9.875179
06-07 17:16:17.221+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.221+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:17:210,0.307504,-0.091403,9.801401
06-07 17:16:17.221+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:17.231+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:234,0.346959,-0.126820,9.853643
06-07 17:16:17.231+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.231+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:17.241+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:240,0.275175,-0.059821,9.839286
06-07 17:16:17.241+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.241+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:16:17.241+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:16:17.241+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:247,0.301496,-0.133998,9.889536
06-07 17:16:17.241+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:17.241+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.251+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:17:255,0.035354,0.007674,0.016351
06-07 17:16:17.251+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:255,0.332602,-0.102891,9.882358
06-07 17:16:17.251+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:17:235,0.070000,0.070000,0.140000
06-07 17:16:17.251+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.251+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:17.261+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:262,0.306281,-0.086142,9.851252
06-07 17:16:17.261+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.261+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:17:243,0.309519,-0.091628,9.801336
06-07 17:16:17.261+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:17.261+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:268,0.342174,-0.086142,9.817751
06-07 17:16:17.261+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.271+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:274,0.308674,-0.093320,9.839286
06-07 17:16:17.271+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.271+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:17.271+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:17:268,0.070000,0.070000,0.070000
06-07 17:16:17.281+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:279,0.320638,-0.057428,9.851252
06-07 17:16:17.281+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.281+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:287,0.332602,-0.117248,9.846465
06-07 17:16:17.281+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.281+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:17:275,0.308418,-0.092822,9.801359
06-07 17:16:17.281+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:17.291+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:292,0.301496,-0.107677,9.868000
06-07 17:16:17.291+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:17.291+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.291+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:17:281,-0.000087,0.000323,0.037945
06-07 17:16:17.301+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:300,0.327817,-0.098106,9.844072
06-07 17:16:17.301+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.301+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:307,0.330210,-0.059821,9.848858
06-07 17:16:17.301+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.301+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:17.311+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:17:297,0.070000,0.140000,0.070000
06-07 17:16:17.311+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:314,0.318245,-0.102891,9.839286
06-07 17:16:17.311+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.311+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:17:305,0.308736,-0.093422,9.801344
06-07 17:16:17.321+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:321,0.346959,-0.107677,9.899107
06-07 17:16:17.321+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.321+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:17.321+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:17:330,0.210000,0.070000,0.070000
06-07 17:16:17.331+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:17.331+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:327,0.291924,-0.090927,9.856036
06-07 17:16:17.321+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:17:318,0.012355,0.036013,0.049893
06-07 17:16:17.331+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.331+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:17.341+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:17:343,0.024276,-0.025713,0.045091
06-07 17:16:17.341+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:17.341+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:17:335,0.308824,-0.093417,9.801341
06-07 17:16:17.341+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:17:349,0.070000,0.070000,0.070000
06-07 17:16:17.341+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:337,0.344566,-0.107677,9.817751
06-07 17:16:17.341+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.351+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:17.351+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:17.361+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:17.361+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:17:357,-0.007591,-0.015134,0.066659
06-07 17:16:17.361+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:17:357,0.307788,-0.094140,9.801367
06-07 17:16:17.361+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:17.361+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:17:368,0.070000,0.070000,0.070000
06-07 17:16:17.361+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:357,0.311067,-0.090927,9.839286
06-07 17:16:17.371+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:17.371+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:17:380,0.307372,-0.093912,9.801382
06-07 17:16:17.381+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.391+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:17.401+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:395,0.299103,-0.100499,9.875179
06-07 17:16:17.411+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:17.411+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:17:393,0.019593,-0.005043,0.042709
06-07 17:16:17.411+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:17.411+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:16:17.421+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:16:17:423,969.000000
06-07 17:16:17.421+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:17:418,0.021538,0.033291,0.047509
06-07 17:16:17.421+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:17.421+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.421+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:17:406,0.307246,-0.093115,9.801394
06-07 17:16:17.421+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:17:429,0.009152,-0.011538,0.037934
06-07 17:16:17.431+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:17.431+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:17.431+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:17:437,0.037882,-0.015968,0.097758
06-07 17:16:17.431+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:17.431+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:17:421,0.070000,0.070000,0.070000
06-07 17:16:17.441+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:16:17.441+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:16:17.441+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:17:444,-0.019211,0.001664,0.054761
06-07 17:16:17.441+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:17.441+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:17:432,0.323031,-0.071785,9.901501
06-07 17:16:17.441+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:17.451+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:17:452,0.034791,-0.015463,0.016429
06-07 17:16:17.451+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:17.451+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:17.461+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:17:458,-0.000253,0.001882,0.038018
06-07 17:16:17.461+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:17.471+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:17:443,0.307931,-0.092887,9.801374
06-07 17:16:17.471+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11189716c6f63152838457
