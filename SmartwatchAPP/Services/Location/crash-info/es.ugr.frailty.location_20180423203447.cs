S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 10481
Date: 2018-04-23 20:34:47+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf727652d, r5   = 0xf7af6958
r6   = 0xffc34a00, r7   = 0xffc348b0
r8   = 0xf7b09c18, r9   = 0x00000000
r10  = 0xffc3498c, fp   = 0xffc34a00
ip   = 0x00000001, sp   = 0xffc34888
lr   = 0xf7276539, pc   = 0xf72df228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     49344 KB
Buffers:     37108 KB
Cached:     156268 KB
VmPeak:      53452 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11704 KB
VmRSS:       11704 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 10481 TID = 10481
10481 10484 

Maps Information
f4141000 f4940000 rw-p [stack:10484]
f4947000 f4949000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4951000 f4955000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f495e000 f4960000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4968000 f496b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f497a000 f497f000 r-xp /usr/lib/libsystem.so.0.0.0
f498a000 f498d000 r-xp /lib/libattr.so.1.1.0
f4995000 f49a5000 r-xp /usr/lib/libmdm-common.so.1.1.24
f49ad000 f49b6000 r-xp /usr/lib/libedbus.so.1.7.99
f49be000 f49bf000 r-xp /usr/lib/libresponse.so.0.2.96
f49c8000 f49cd000 r-xp /usr/lib/libproc-stat.so.0.2.96
f626f000 f6375000 r-xp /usr/lib/libicuuc.so.57.1
f638b000 f6513000 r-xp /usr/lib/libicui18n.so.57.1
f6523000 f6530000 r-xp /usr/lib/libail.so.0.1.0
f6539000 f6540000 r-xp /usr/lib/libminizip.so.1.0.0
f6549000 f66f2000 r-xp /usr/lib/libcrypto.so.1.0.0
f6712000 f6759000 r-xp /usr/lib/libssl.so.1.0.0
f6765000 f6767000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f676f000 f6776000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f677f000 f6786000 r-xp /lib/libcrypt-2.13.so
f67b7000 f67ba000 r-xp /lib/libcap.so.2.21
f67c2000 f67c4000 r-xp /usr/lib/libiri.so
f67cc000 f6815000 r-xp /usr/lib/libmdm.so.1.2.69
f681d000 f6823000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f682b000 f684e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6858000 f685a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6862000 f687f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6888000 f688c000 r-xp /usr/lib/libsmack.so.1.0.0
f6895000 f68ae000 r-xp /usr/lib/libnetwork.so.0.0.0
f68b7000 f68bf000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f68c7000 f68cd000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f68d6000 f68d8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f68e1000 f68f1000 r-xp /lib/libresolv-2.13.so
f68f5000 f690d000 r-xp /usr/lib/liblzma.so.5.0.3
f6916000 f6918000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6920000 f693a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6942000 f6971000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f697a000 f6989000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6993000 f699d000 r-xp /usr/lib/libsensord-shared.so
f69a6000 f6a79000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a84000 f6a9a000 r-xp /lib/libz.so.1.2.5
f6aa2000 f6aa7000 r-xp /usr/lib/libffi.so.5.0.10
f6aaf000 f6ab0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ab8000 f6ac8000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ad0000 f6ae9000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6af1000 f6af3000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6afb000 f6b70000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b7a000 f6b80000 r-xp /lib/librt-2.13.so
f6b89000 f6ba7000 r-xp /usr/lib/libsystemd.so.0.4.0
f6bb1000 f6bb2000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6bba000 f6bdd000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6be5000 f6bea000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6bf2000 f6c1c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c25000 f6c3c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c44000 f6cad000 r-xp /lib/libm-2.13.so
f6cb6000 f6d4a000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d5d000 f6d62000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d6a000 f6d71000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d79000 f6da3000 r-xp /usr/lib/libsensor.so.1.9.6
f6dac000 f6e78000 r-xp /usr/lib/libxml2.so.2.7.8
f6e85000 f6e87000 r-xp /usr/lib/libiniparser.so.0
f6e90000 f6e96000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e9f000 f6f6f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f70000 f6fa4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6fad000 f6fe9000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6ff1000 f6ff4000 r-xp /usr/lib/libbundle.so.0.1.22
f6ffc000 f7002000 r-xp /usr/lib/libappsvc.so.0.1.0
f700a000 f704b000 r-xp /usr/lib/libeina.so.1.7.99
f7054000 f706b000 r-xp /usr/lib/libecore.so.1.7.99
f7082000 f708b000 r-xp /usr/lib/libvconf.so.0.2.45
f7093000 f70a7000 r-xp /lib/libpthread-2.13.so
f70b2000 f70bf000 r-xp /usr/lib/libaul.so.0.1.0
f70c9000 f70cb000 r-xp /lib/libdl-2.13.so
f70d4000 f70df000 r-xp /lib/libunwind.so.8.0.1
f710c000 f7114000 r-xp /lib/libgcc_s-4.6.so.1
f7115000 f7239000 r-xp /lib/libc-2.13.so
f7247000 f7249000 r-xp /usr/lib/libdlog.so.0.0.0
f7251000 f725d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7266000 f726b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7273000 f7282000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f728a000 f728e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7297000 f729a000 r-xp /usr/lib/libappcore-agent.so.1.1
f72a2000 f72a4000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f72ac000 f72b0000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f72b8000 f72d5000 r-xp /lib/ld-2.13.so
f72de000 f72e1000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f72e1000 f72e5000 r-xp /usr/lib/libsys-assert.so
f7ad9000 f7b4a000 rw-p [heap]
ffc16000 ffc37000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10481)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf72df228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7276539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f7d3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f7bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f87e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f8dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f8ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6fc275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6fbd1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f7bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f87e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f8dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f8ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6fbfe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6fc0017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6fc7f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf495f1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4952171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a25663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6ed2fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6ed47a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7064ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf705fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70605a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7060879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7298183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72987fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72df53f) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x153f
28: __libc_start_main + 0x114 (0xf712c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf72def2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
20:34:46.829+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:46.829+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:46.839+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:46:841,0.078963,9.815358,0.768096
04-23 20:34:46.839+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:46:838,-0.070000,0.070000,0.070000
04-23 20:34:46.839+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:46:841,0.041716,9.771122,0.832958
04-23 20:34:46.839+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:46:837,-0.021135,0.027891,-0.064988
04-23 20:34:46.839+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:46.839+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:46.849+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:46:850,0.020413,0.042247,-0.065017
04-23 20:34:46.849+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:46.849+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:46:851,-0.140000,0.070000,0.070000
04-23 20:34:46.849+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:46.849+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:46:855,-0.007032,0.042011,-0.031108
04-23 20:34:46.849+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:46.849+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:46:857,-0.070000,0.140000,0.070000
04-23 20:34:46.859+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:46.859+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:46.859+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:46:863,0.042612,9.771209,0.831892
04-23 20:34:46.859+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:46:863,0.057428,9.808180,0.789631
04-23 20:34:46.859+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:46.869+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:46:860,0.019482,0.008563,-0.024530
04-23 20:34:46.869+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:46:870,-0.070000,0.070000,0.070000
04-23 20:34:46.869+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:46.869+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:46.869+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:46:876,-0.140000,0.070000,0.070000
04-23 20:34:46.869+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:46.879+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:46.879+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:46:883,0.050249,9.815358,0.808774
04-23 20:34:46.879+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:46:883,0.043142,9.771226,0.831666
04-23 20:34:46.879+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:46.879+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:46:878,0.011231,0.025319,-0.005420
04-23 20:34:46.879+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:46.879+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:46:888,-0.140000,-0.210000,0.070000
04-23 20:34:46.889+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:46:890,0.039281,0.044579,-0.068970
04-23 20:34:46.889+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:46.889+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:46:894,0.015712,0.037058,-0.043327
04-23 20:34:46.889+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:46.889+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:46.889+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:46.899+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:46:901,0.047856,9.817751,0.825524
04-23 20:34:46.899+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:46:901,0.043514,9.771152,0.832523
04-23 20:34:46.899+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:46.899+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:46:898,0.007638,0.044149,-0.023118
04-23 20:34:46.899+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:46.899+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:46:906,-0.070000,-0.070000,0.070000
04-23 20:34:46.899+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:46:908,0.004715,0.046525,-0.006142
04-23 20:34:46.909+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:46.909+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:46.919+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:46:921,0.047856,9.817751,0.803988
04-23 20:34:46.919+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:46:921,0.043876,9.771161,0.832384
04-23 20:34:46.919+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:46.919+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:46.919+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:34:46.919+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:34:46.919+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:46:926,0.004342,0.046599,-0.028535
04-23 20:34:46.929+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:46:928,-0.140000,-0.070000,0.070000
04-23 20:34:46.929+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:46.929+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:46.939+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:46:941,0.014357,9.817751,0.799203
04-23 20:34:46.939+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:46:942,0.042612,9.771075,0.833458
04-23 20:34:46.939+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:46.939+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:46.939+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:46:947,-0.029519,0.046590,-0.033181
04-23 20:34:46.949+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:46:948,-0.070000,0.070000,0.070000
04-23 20:34:46.949+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:46.949+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:46.959+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:46:962,0.041659,9.770838,0.836292
04-23 20:34:46.959+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:46:962,0.019143,9.791430,0.842274
04-23 20:34:46.959+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:46.959+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:46.959+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:46:967,-0.023469,0.020355,0.008816
04-23 20:34:46.959+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:46:967,-0.140000,0.070000,0.070000
04-23 20:34:46.969+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:46.969+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:46.979+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:46:981,0.050249,9.803394,0.796810
04-23 20:34:46.979+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:46:981,0.042211,9.770891,0.835641
04-23 20:34:46.979+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:46.979+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:46.989+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:46:987,0.008591,0.032557,-0.039482
04-23 20:34:46.989+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:46:989,-0.070000,0.070000,0.070000
04-23 20:34:46.989+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:46.999+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:46.999+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:46.999+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:46.999+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:3,0.031107,9.815358,0.794417
04-23 20:34:46.999+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:3,0.041823,9.770887,0.835703
04-23 20:34:47.009+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:3,-0.011105,0.044467,-0.041224
04-23 20:34:47.009+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:2,-0.070000,0.070000,0.070000
04-23 20:34:47.009+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.009+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.019+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.019+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:22,-0.140000,0.070000,0.070000
04-23 20:34:47.019+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:23,0.031107,9.832108,0.835095
04-23 20:34:47.019+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.029+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:22,0.041459,9.770718,0.837703
04-23 20:34:47.029+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:29,-0.010716,0.061221,-0.000608
04-23 20:34:47.029+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.029+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.029+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.039+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:42,0.033500,9.805787,0.789631
04-23 20:34:47.039+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:42,-0.070000,0.070000,0.070000
04-23 20:34:47.039+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.049+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:42,0.041222,9.770746,0.837375
04-23 20:34:47.049+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:50,-0.007960,0.035069,-0.048071
04-23 20:34:47.059+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.059+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.059+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:64,-0.140000,0.070000,0.070000
04-23 20:34:47.059+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:65,0.026321,9.784252,0.813560
04-23 20:34:47.059+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.059+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.079+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:73,0.040664,9.770635,0.838706
04-23 20:34:47.079+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:72,-0.014901,0.013506,-0.023815
04-23 20:34:47.089+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.089+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:34:47.089+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:34:47.089+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:34:47.099+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:96,-0.070000,0.070000,0.140000
04-23 20:34:47.099+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.099+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.109+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.109+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.119+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:107,-0.021521,0.016010,-0.003611
04-23 20:34:47.129+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:108,0.039946,9.770298,0.842658
04-23 20:34:47.129+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.129+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:114,0.019143,9.786645,0.835095
04-23 20:34:47.129+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.129+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.129+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:123,-0.070000,0.070000,0.070000
04-23 20:34:47.129+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.139+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:148,0.047856,9.789038,0.796810
04-23 20:34:47.149+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:34:47.149+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:34:47.149+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:153,-0.070000,0.070000,0.070000
04-23 20:34:47.159+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:145,0.040470,9.770370,0.841787
04-23 20:34:47.159+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:143,0.007910,0.018740,-0.045848
04-23 20:34:47.159+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.159+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.159+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.159+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.179+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:171,0.007387,0.042595,-0.068905
04-23 20:34:47.179+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:173,0.040971,9.770561,0.839551
04-23 20:34:47.189+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:177,-0.070000,0.070000,0.070000
04-23 20:34:47.189+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.189+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.189+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:174,0.047856,9.812965,0.772882
04-23 20:34:47.189+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.189+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.199+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:205,0.023928,9.832108,0.813560
04-23 20:34:47.199+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.209+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:200,-0.017043,0.061547,-0.025992
04-23 20:34:47.209+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:212,0.062213,9.810574,0.770489
04-23 20:34:47.209+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.219+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:203,0.040301,9.770473,0.840597
04-23 20:34:47.219+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:218,0.045464,9.793823,0.768096
04-23 20:34:47.219+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.219+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:208,0.070000,0.070000,0.070000
04-23 20:34:47.219+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.219+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.219+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.219+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:226,-0.019143,9.767502,0.811167
04-23 20:34:47.219+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.229+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:232,0.045464,9.781858,0.794417
04-23 20:34:47.229+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:230,0.041495,9.770764,0.837148
04-23 20:34:47.229+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.239+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.239+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:233,0.070000,0.210000,0.070000
04-23 20:34:47.239+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:229,0.021912,0.040100,-0.070108
04-23 20:34:47.239+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:243,0.028714,9.817751,0.784846
04-23 20:34:47.239+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.239+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.239+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:240,0.041815,9.770935,0.835142
04-23 20:34:47.239+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.249+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:252,0.039056,9.770694,0.838096
04-23 20:34:47.249+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.249+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:250,0.003969,0.023059,-0.069052
04-23 20:34:47.249+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:252,0.070000,0.140000,0.070000
04-23 20:34:47.249+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.259+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.259+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.259+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:262,0.016750,9.815358,0.801596
04-23 20:34:47.259+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:258,0.039514,9.770798,0.836855
04-23 20:34:47.259+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.269+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:266,0.070000,-0.070000,0.070000
04-23 20:34:47.269+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:271,0.039132,9.770850,0.836271
04-23 20:34:47.269+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:268,-0.060958,-0.003433,-0.023975
04-23 20:34:47.269+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.269+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.269+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.269+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.279+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:281,0.050249,9.798609,0.775275
04-23 20:34:47.279+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:282,0.006408,0.011165,-0.043679
04-23 20:34:47.279+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:276,0.038203,9.770782,0.837114
04-23 20:34:47.279+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.279+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.289+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:289,-0.010800,0.046953,-0.052009
04-23 20:34:47.289+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.289+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:279,0.070000,0.070000,0.070000
04-23 20:34:47.289+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.289+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:295,-0.022382,0.044508,-0.034675
04-23 20:34:47.289+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:296,0.070000,0.070000,0.070000
04-23 20:34:47.289+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.289+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.289+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.299+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:288,0.038933,9.771004,0.834475
04-23 20:34:47.299+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.299+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:302,0.040678,9.808180,0.808774
04-23 20:34:47.299+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:305,0.039163,9.771019,0.834290
04-23 20:34:47.299+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:300,0.012046,0.027827,-0.061839
04-23 20:34:47.299+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:300,0.070000,-0.070000,0.070000
04-23 20:34:47.299+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.309+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.309+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:313,0.001745,0.037176,-0.025701
04-23 20:34:47.309+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:313,0.070000,-0.070000,0.070000
04-23 20:34:47.309+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.309+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.319+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:322,0.039272,9.771114,0.833171
04-23 20:34:47.319+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:322,0.038285,9.798609,0.787239
04-23 20:34:47.319+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.319+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.319+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:34:47.319+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:34:47.319+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:327,0.070000,-0.070000,0.070000
04-23 20:34:47.329+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:328,-0.000878,0.027590,-0.047052
04-23 20:34:47.329+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.329+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.339+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.339+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:341,0.025335,0.041851,0.006709
04-23 20:34:47.339+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:343,0.040594,9.770991,0.834545
04-23 20:34:47.339+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:341,0.064606,9.812965,0.839881
04-23 20:34:47.339+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.349+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:350,-0.070000,0.070000,0.070000
04-23 20:34:47.349+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.359+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.359+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.359+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:363,-0.021451,0.046760,-0.085591
04-23 20:34:47.359+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:363,0.039699,9.771093,0.833392
04-23 20:34:47.359+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.359+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:363,0.019143,9.817751,0.748954
04-23 20:34:47.359+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:367,-0.070000,0.070000,0.070000
04-23 20:34:47.369+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.369+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.379+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.379+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:381,-0.008592,0.049051,-0.048547
04-23 20:34:47.379+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.389+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:383,0.031107,9.820145,0.784846
04-23 20:34:47.389+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:389,-0.070000,0.070000,0.070000
04-23 20:34:47.389+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:382,0.039430,9.771117,0.833125
04-23 20:34:47.389+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.389+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.389+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.399+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:402,-0.010716,0.032277,-0.036315
04-23 20:34:47.399+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.409+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:403,0.039063,9.771077,0.833618
04-23 20:34:47.409+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:402,0.028714,9.803394,0.796810
04-23 20:34:47.409+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:409,-0.070000,0.070000,0.070000
04-23 20:34:47.419+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.419+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.419+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.419+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:423,-0.019921,0.041888,-0.017665
04-23 20:34:47.419+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.429+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:424,0.038263,9.770932,0.835350
04-23 20:34:47.429+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:426,0.019143,9.812965,0.815953
04-23 20:34:47.429+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:432,-0.070000,0.070000,0.070000
04-23 20:34:47.429+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.429+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.439+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:442,0.016772,0.020498,-0.002648
04-23 20:34:47.439+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.439+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.449+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:443,0.039193,9.770826,0.836537
04-23 20:34:47.449+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:449,-0.070000,0.070000,0.070000
04-23 20:34:47.449+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:448,0.055035,9.791430,0.832702
04-23 20:34:47.459+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.459+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.459+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:463,0.038599,9.770820,0.836650
04-23 20:34:47.459+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.459+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.469+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:469,0.070000,0.070000,0.070000
04-23 20:34:47.469+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:463,-0.015265,0.056496,-0.042120
04-23 20:34:47.469+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:470,0.023928,9.827322,0.794417
04-23 20:34:47.469+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.469+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.469+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.479+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:482,0.039648,9.771022,0.834238
04-23 20:34:47.479+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.489+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:483,0.018829,0.030182,-0.066161
04-23 20:34:47.489+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:488,-0.140000,0.140000,0.070000
04-23 20:34:47.489+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.509+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.509+0200 W/LOCATION(10481): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:34:47.509+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:490,0.057428,9.801002,0.770489
04-23 20:34:47.519+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.519+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:34:47.519+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:34:47.519+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.529+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:514,0.041081,9.771021,0.834171
04-23 20:34:47.529+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.539+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:531,0.066999,9.812965,0.815953
04-23 20:34:47.539+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:503,0.027351,0.041944,-0.018285
04-23 20:34:47.539+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.539+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.539+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:528,-0.140000,0.070000,0.070000
04-23 20:34:47.539+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.549+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:540,0.040302,9.770894,0.835698
04-23 20:34:47.549+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.549+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:552,-0.019546,0.029981,-0.023004
04-23 20:34:47.549+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:555,0.040355,9.771069,0.833652
04-23 20:34:47.549+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:545,0.021535,9.801002,0.811167
04-23 20:34:47.559+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.559+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:563,0.038285,9.808180,0.756132
04-23 20:34:47.559+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.559+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:553,-0.140000,0.070000,0.070000
04-23 20:34:47.569+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.569+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.569+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:573,-0.004786,9.801002,0.792024
04-23 20:34:47.569+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.569+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:569,0.038349,9.770890,0.835832
04-23 20:34:47.579+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.579+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.589+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:584,0.039520,9.771042,0.834005
04-23 20:34:47.589+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:580,-0.002017,0.037286,-0.079566
04-23 20:34:47.589+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.599+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:580,-0.140000,0.070000,0.070000
04-23 20:34:47.599+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.599+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.599+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:604,0.040624,9.771063,0.833709
04-23 20:34:47.599+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:604,-0.140000,0.070000,0.070000
04-23 20:34:47.599+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:584,0.059821,9.812965,0.784846
04-23 20:34:47.599+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.599+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:598,-0.045141,0.029933,-0.041628
04-23 20:34:47.609+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.609+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:611,0.059821,9.798609,0.808774
04-23 20:34:47.609+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.609+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:615,0.021472,0.042075,-0.050986
04-23 20:34:47.619+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.619+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.619+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:624,0.019143,9.822537,0.811167
04-23 20:34:47.619+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:623,0.039745,9.770944,0.835146
04-23 20:34:47.619+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.619+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:618,-0.140000,0.070000,0.070000
04-23 20:34:47.629+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:630,0.020300,0.027567,-0.025231
04-23 20:34:47.629+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.629+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:636,-0.021482,0.051475,-0.022543
04-23 20:34:47.629+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.629+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.639+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.639+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:642,0.040172,9.770801,0.836798
04-23 20:34:47.639+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:643,0.045464,9.774680,0.839881
04-23 20:34:47.639+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.639+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:641,-0.070000,0.070000,0.070000
04-23 20:34:47.639+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.649+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:649,0.005718,0.003736,0.004734
04-23 20:34:47.649+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:651,-0.070000,0.070000,0.070000
04-23 20:34:47.649+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.659+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.659+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.659+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:663,0.016750,9.777073,0.808774
04-23 20:34:47.659+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.659+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:668,-0.023422,0.006272,-0.028024
04-23 20:34:47.659+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:664,0.039219,9.770703,0.837975
04-23 20:34:47.669+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:661,-0.070000,-0.070000,0.070000
04-23 20:34:47.669+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.669+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.669+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.679+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:681,0.043071,9.839286,0.823131
04-23 20:34:47.679+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.679+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:682,0.039535,9.770637,0.838743
04-23 20:34:47.679+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:686,0.003852,0.068583,-0.014844
04-23 20:34:47.689+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:680,-0.070000,-0.070000,0.070000
04-23 20:34:47.689+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.689+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.689+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.689+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.699+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:701,0.023928,9.791430,0.806381
04-23 20:34:47.699+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:706,0.038937,9.770557,0.839693
04-23 20:34:47.699+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:702,-0.015606,0.020794,-0.032361
04-23 20:34:47.699+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:698,-0.070000,0.070000,0.070000
04-23 20:34:47.709+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.709+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:713,-0.070000,0.070000,0.070000
04-23 20:34:47.719+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.719+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.719+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.719+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.719+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:723,0.043071,9.805787,0.777667
04-23 20:34:47.719+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:34:47.719+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:34:47.719+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:728,0.004133,0.035230,-0.062026
04-23 20:34:47.729+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:724,0.039281,9.770692,0.838102
04-23 20:34:47.729+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:729,-0.070000,0.070000,0.070000
04-23 20:34:47.729+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.729+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.729+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.739+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.739+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:742,0.052642,9.803394,0.835095
04-23 20:34:47.739+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:743,0.040049,9.770585,0.839315
04-23 20:34:47.749+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:746,0.013361,0.032702,-0.003007
04-23 20:34:47.749+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:742,-0.070000,0.070000,0.070000
04-23 20:34:47.749+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.749+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.759+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.759+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.759+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:763,0.059821,9.791430,0.784846
04-23 20:34:47.759+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:762,-0.070000,0.070000,0.070000
04-23 20:34:47.759+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:763,0.041143,9.770751,0.837332
04-23 20:34:47.769+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:767,0.019772,0.020845,-0.054469
04-23 20:34:47.769+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.769+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.779+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.779+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.779+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:783,0.041729,9.770834,0.836328
04-23 20:34:47.779+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:782,-0.070000,0.070000,0.070000
04-23 20:34:47.789+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:786,0.009106,0.003929,-0.047701
04-23 20:34:47.789+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:783,0.050249,9.774680,0.789631
04-23 20:34:47.789+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.789+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.789+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.799+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:801,-0.070000,-0.070000,0.070000
04-23 20:34:47.799+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.799+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:802,0.043071,9.815358,0.799203
04-23 20:34:47.799+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:803,0.041946,9.770881,0.835768
04-23 20:34:47.799+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:806,0.001342,0.044524,-0.037126
04-23 20:34:47.819+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:47.819+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:47.819+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:47:823,-0.070000,0.140000,0.070000
04-23 20:34:47.819+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:47.819+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:47.819+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:47:828,0.028714,9.832108,0.825524
04-23 20:34:47.819+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:47:824,0.041451,9.770741,0.837422
04-23 20:34:47.829+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:47:828,-0.013232,0.061228,-0.010244
04-23 20:34:47.849+0200 W/CRASH_MANAGER(10205): worker.c: worker_job(1205) > 11104816c6f63152450848
