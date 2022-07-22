S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 6887
Date: 2018-04-23 19:03:13+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf745e52d, r5   = 0xf765af98
r6   = 0xffe46340, r7   = 0xffe461f0
r8   = 0xf7657c18, r9   = 0x00000000
r10  = 0xffe462cc, fp   = 0xffe46340
ip   = 0x00000001, sp   = 0xffe461c8
lr   = 0xf745e539, pc   = 0xf74c7228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     58180 KB
Buffers:     40648 KB
Cached:     226688 KB
VmPeak:      53524 KB
VmSize:      53520 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12028 KB
VmRSS:       12028 KB
VmData:      11248 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 6887 TID = 6887
6887 6942 

Maps Information
f4329000 f4b28000 rw-p [stack:6942]
f4b2f000 f4b31000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b39000 f4b3d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b46000 f4b48000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b50000 f4b53000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b62000 f4b67000 r-xp /usr/lib/libsystem.so.0.0.0
f4b72000 f4b75000 r-xp /lib/libattr.so.1.1.0
f4b7d000 f4b8d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b95000 f4b9e000 r-xp /usr/lib/libedbus.so.1.7.99
f4ba6000 f4ba7000 r-xp /usr/lib/libresponse.so.0.2.96
f4bb0000 f4bb5000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6457000 f655d000 r-xp /usr/lib/libicuuc.so.57.1
f6573000 f66fb000 r-xp /usr/lib/libicui18n.so.57.1
f670b000 f6718000 r-xp /usr/lib/libail.so.0.1.0
f6721000 f6728000 r-xp /usr/lib/libminizip.so.1.0.0
f6731000 f68da000 r-xp /usr/lib/libcrypto.so.1.0.0
f68fa000 f6941000 r-xp /usr/lib/libssl.so.1.0.0
f694d000 f694f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6957000 f695e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6967000 f696e000 r-xp /lib/libcrypt-2.13.so
f699f000 f69a2000 r-xp /lib/libcap.so.2.21
f69aa000 f69ac000 r-xp /usr/lib/libiri.so
f69b4000 f69fd000 r-xp /usr/lib/libmdm.so.1.2.69
f6a05000 f6a0b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a13000 f6a36000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a40000 f6a42000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a4a000 f6a67000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a70000 f6a74000 r-xp /usr/lib/libsmack.so.1.0.0
f6a7d000 f6a96000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a9f000 f6aa7000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6aaf000 f6ab5000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6abe000 f6ac0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6ac9000 f6ad9000 r-xp /lib/libresolv-2.13.so
f6add000 f6af5000 r-xp /usr/lib/liblzma.so.5.0.3
f6afe000 f6b00000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b08000 f6b22000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b2a000 f6b59000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b62000 f6b71000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b7b000 f6b85000 r-xp /usr/lib/libsensord-shared.so
f6b8e000 f6c61000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c6c000 f6c82000 r-xp /lib/libz.so.1.2.5
f6c8a000 f6c8f000 r-xp /usr/lib/libffi.so.5.0.10
f6c97000 f6c98000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ca0000 f6cb0000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6cb8000 f6cd1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6cd9000 f6cdb000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ce3000 f6d58000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d62000 f6d68000 r-xp /lib/librt-2.13.so
f6d71000 f6d8f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d99000 f6d9a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6da2000 f6dc5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6dcd000 f6dd2000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6dda000 f6e04000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e0d000 f6e24000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e2c000 f6e95000 r-xp /lib/libm-2.13.so
f6e9e000 f6f32000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f45000 f6f4a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f52000 f6f59000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f61000 f6f8b000 r-xp /usr/lib/libsensor.so.1.9.6
f6f94000 f7060000 r-xp /usr/lib/libxml2.so.2.7.8
f706d000 f706f000 r-xp /usr/lib/libiniparser.so.0
f7078000 f707e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7087000 f7157000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7158000 f718c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7195000 f71d1000 r-xp /usr/lib/libSLP-location.so.0.9.24
f71d9000 f71dc000 r-xp /usr/lib/libbundle.so.0.1.22
f71e4000 f71ea000 r-xp /usr/lib/libappsvc.so.0.1.0
f71f2000 f7233000 r-xp /usr/lib/libeina.so.1.7.99
f723c000 f7253000 r-xp /usr/lib/libecore.so.1.7.99
f726a000 f7273000 r-xp /usr/lib/libvconf.so.0.2.45
f727b000 f728f000 r-xp /lib/libpthread-2.13.so
f729a000 f72a7000 r-xp /usr/lib/libaul.so.0.1.0
f72b1000 f72b3000 r-xp /lib/libdl-2.13.so
f72bc000 f72c7000 r-xp /lib/libunwind.so.8.0.1
f72f4000 f72fc000 r-xp /lib/libgcc_s-4.6.so.1
f72fd000 f7421000 r-xp /lib/libc-2.13.so
f742f000 f7431000 r-xp /usr/lib/libdlog.so.0.0.0
f7439000 f7445000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f744e000 f7453000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f745b000 f746a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7472000 f7476000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f747f000 f7482000 r-xp /usr/lib/libappcore-agent.so.1.1
f748a000 f748c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7494000 f7498000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f74a0000 f74bd000 r-xp /lib/ld-2.13.so
f74c6000 f74c9000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f74c9000 f74cd000 r-xp /usr/lib/libsys-assert.so
f7627000 f76aa000 rw-p [heap]
ffe27000 ffe48000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6887)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf74c7228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf745e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71653f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7163c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf716fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7175be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7175dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf71aa75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71a51f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7163c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf716fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7175be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7175dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf71a7e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf71a8017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf71aff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b471fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b3a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c0d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf70bafcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70bc7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf724cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7247b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72485a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7248879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7480183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74807fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74c74f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf731485c) [/lib/libc.so.6] + 0x1785c
29: (0xf74c6f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
8): capturing data from es.ugr.frailty.gravity
04-23 19:03:12.959+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:12.959+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:12:961,-0.121575,-0.191654,-0.042518
04-23 19:03:12.959+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:12.959+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:12:962,8.527849,0.387371,4.826605
04-23 19:03:12.959+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:12:967,8.400000,-9.170000,-0.420000
04-23 19:03:12.969+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:12:963,8.372486,0.198604,4.843073
04-23 19:03:12.969+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:12.969+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:12.969+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:12.979+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:12.979+0200 I/heartrate( 6875): capturing data from es.ugr.frailty.heartrate
04-23 19:03:12.979+0200 I/heartrate( 6875): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:03:12.979+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:12:981,8.596976,0.396576,4.701608
04-23 19:03:12.979+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:12:986,17.570000,-10.430000,0.560000
04-23 19:03:12.979+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:12:980,-0.152970,-0.026055,-0.072066
04-23 19:03:12.989+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:12:980,8.374879,0.361316,4.754539
04-23 19:03:12.989+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:12.989+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:12.999+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:12.999+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:2,-0.159883,0.338021,-0.303599
04-23 19:03:12.999+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:3,8.652105,0.413509,4.597877
04-23 19:03:12.999+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.009+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:2,8.437093,0.734596,4.398008
04-23 19:03:13.009+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:8,7.980000,-12.390000,2.660000
04-23 19:03:13.009+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.009+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.019+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.019+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.019+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:21,8.691424,0.410383,4.523397
04-23 19:03:13.019+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:21,-0.145621,0.170340,0.041807
04-23 19:03:13.029+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:23,8.506484,0.583849,4.639683
04-23 19:03:13.029+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:21,0.210000,-12.250000,6.370000
04-23 19:03:13.029+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.029+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.029+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.039+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.039+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:41,8.758864,0.377608,4.394324
04-23 19:03:13.039+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:41,-0.170583,-0.472596,0.350783
04-23 19:03:13.049+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:40,8.260000,-14.280000,8.610000
04-23 19:03:13.049+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:43,8.520842,-0.062213,4.874180
04-23 19:03:13.049+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.049+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.049+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.059+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.059+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:61,-0.209310,-0.370429,0.166396
04-23 19:03:13.059+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:63,8.549555,0.007178,4.560720
04-23 19:03:13.059+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:61,8.866920,0.354545,4.174018
04-23 19:03:13.069+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:61,23.730000,-14.000000,10.290000
04-23 19:03:13.069+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.069+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.069+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.079+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.079+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:81,0.125308,0.054628,0.197669
04-23 19:03:13.079+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:83,8.972377,0.348876,3.942731
04-23 19:03:13.089+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:81,28.070000,-14.560000,11.970000
04-23 19:03:13.089+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:81,8.992228,0.409173,4.371687
04-23 19:03:13.089+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.089+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.089+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.099+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.099+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:102,0.292632,-0.128736,0.641917
04-23 19:03:13.099+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:103,9.265009,0.220140,4.584648
04-23 19:03:13.109+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:102,9.058130,0.314427,3.744568
04-23 19:03:13.109+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.119+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.119+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.129+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:123,9.166592,0.242388,3.476381
04-23 19:03:13.139+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:127,0.266700,-0.848026,1.266002
04-23 19:03:13.139+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.139+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:122,9.324830,-0.533599,5.010571
04-23 19:03:13.139+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.139+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.159+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:151,9.290541,0.174047,3.134636
04-23 19:03:13.159+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.169+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:150,8.970692,-0.672383,4.862216
04-23 19:03:13.169+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:102,11.200000,-8.120000,17.430000
04-23 19:03:13.169+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:146,-0.195900,-0.914771,1.385834
04-23 19:03:13.169+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.169+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.179+0200 I/heartrate( 6875): capturing data from es.ugr.frailty.heartrate
04-23 19:03:13.179+0200 I/heartrate( 6875): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:03:13.179+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.189+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:182,8.846266,-0.306281,4.496114
04-23 19:03:13.189+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.199+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:187,-0.444275,-0.480328,1.361478
04-23 19:03:13.199+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.209+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:181,10.220000,-4.900000,19.879999
04-23 19:03:13.209+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.209+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:167,9.382273,0.131592,2.850620
04-23 19:03:13.209+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.219+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:208,-0.318260,-0.157913,1.456461
04-23 19:03:13.229+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:200,9.064013,-0.026321,4.307081
04-23 19:03:13.229+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:222,9.442854,0.101742,2.644341
04-23 19:03:13.229+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.229+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:214,29.610001,-2.100000,20.230000
04-23 19:03:13.229+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.229+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.239+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.239+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:233,-0.543946,-0.006029,1.497635
04-23 19:03:13.239+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.239+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:247,-0.883766,-0.231109,1.658028
04-23 19:03:13.239+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.249+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:235,9.485963,0.070790,2.486340
04-23 19:03:13.249+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.249+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:241,8.898908,0.095713,4.141976
04-23 19:03:13.249+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.249+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:256,9.531693,0.019957,2.305825
04-23 19:03:13.249+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.259+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:241,49.910000,-0.840000,21.350000
04-23 19:03:13.259+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.259+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:262,9.574131,-0.037460,2.122498
04-23 19:03:13.259+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.259+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:266,57.260002,-2.170000,24.080000
04-23 19:03:13.259+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.259+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:267,9.592069,-0.069046,2.039076
04-23 19:03:13.269+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:257,8.602197,-0.160319,4.144369
04-23 19:03:13.269+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.269+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:251,-0.723713,-0.390844,1.750010
04-23 19:03:13.269+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.269+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.269+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:270,51.939999,1.470000,27.020000
04-23 19:03:13.269+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.279+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:280,9.595864,-0.080287,2.020725
04-23 19:03:13.279+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:275,8.807980,-0.370888,4.055835
04-23 19:03:13.279+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.279+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:277,-0.313908,0.011139,1.701233
04-23 19:03:13.279+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.279+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:287,9.260223,-0.026321,3.823731
04-23 19:03:13.279+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:288,-0.391666,0.499754,1.322840
04-23 19:03:13.279+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.289+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:282,45.990002,4.620000,29.889999
04-23 19:03:13.289+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.289+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:292,9.200402,0.430708,3.361916
04-23 19:03:13.289+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:294,56.910000,2.800000,31.430000
04-23 19:03:13.289+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.289+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.289+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.299+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:301,8.901299,0.452243,3.390630
04-23 19:03:13.299+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:302,9.602048,-0.099571,1.990263
04-23 19:03:13.299+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.299+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:306,-0.694565,0.532530,1.369905
04-23 19:03:13.299+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:298,68.180000,4.130000,31.150000
04-23 19:03:13.309+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.309+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:313,59.990002,8.260000,31.570000
04-23 19:03:13.309+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.309+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.309+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.319+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:320,8.994620,0.148355,3.546163
04-23 19:03:13.319+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.319+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:321,9.616838,-0.137645,1.915170
04-23 19:03:13.319+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:319,38.500000,13.790000,32.060001
04-23 19:03:13.319+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.319+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:325,-0.607428,0.247926,1.555901
04-23 19:03:13.329+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:329,32.270000,13.440001,32.270000
04-23 19:03:13.329+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.329+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.339+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:340,9.157332,0.215354,3.701697
04-23 19:03:13.339+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.339+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.339+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:340,40.320000,15.750000,32.689999
04-23 19:03:13.339+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:340,9.624158,-0.166608,1.875688
04-23 19:03:13.339+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:344,-0.459505,0.352999,1.786527
04-23 19:03:13.349+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.349+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.359+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:361,44.799999,21.700001,29.820000
04-23 19:03:13.359+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:361,8.726624,0.160319,4.029513
04-23 19:03:13.359+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.359+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.359+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:366,9.622444,-0.185487,1.882697
04-23 19:03:13.369+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:368,-0.897534,0.326927,2.153825
04-23 19:03:13.369+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.369+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.379+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.379+0200 I/heartrate( 6875): capturing data from es.ugr.frailty.heartrate
04-23 19:03:13.379+0200 I/heartrate( 6875): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:03:13.379+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:381,8.377272,0.559920,3.845266
04-23 19:03:13.379+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:380,38.500000,20.860001,28.350000
04-23 19:03:13.379+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.389+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:389,-1.245173,0.745408,1.962569
04-23 19:03:13.389+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:387,9.612027,-0.181782,1.935529
04-23 19:03:13.389+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.389+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.399+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:402,8.829515,0.811167,3.584448
04-23 19:03:13.399+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:402,24.780001,16.520000,28.980000
04-23 19:03:13.399+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.399+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.399+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:407,-0.782512,0.992949,1.648919
04-23 19:03:13.399+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:407,9.605518,-0.176109,1.968091
04-23 19:03:13.409+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.409+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.419+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:421,9.456435,0.461815,4.000800
04-23 19:03:13.419+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.419+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.429+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:428,-0.149083,0.637923,2.032709
04-23 19:03:13.429+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:421,15.120000,13.160000,29.469999
04-23 19:03:13.429+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:427,9.611818,-0.197417,1.935036
04-23 19:03:13.429+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.439+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.439+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:442,13.090000,19.250000,26.389999
04-23 19:03:13.439+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.449+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.449+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:453,-0.277417,-0.056222,2.910430
04-23 19:03:13.459+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:452,9.623019,-0.242139,1.873299
04-23 19:03:13.459+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:445,9.334401,-0.253639,4.845466
04-23 19:03:13.459+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.459+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.469+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.469+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:471,8.681160,-0.830309,5.297709
04-23 19:03:13.469+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.469+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.479+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:480,8.542377,0.150748,5.027320
04-23 19:03:13.479+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:481,-0.941859,-0.588171,3.424410
04-23 19:03:13.479+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.479+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:487,-1.090833,0.443830,3.214655
04-23 19:03:13.479+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:474,26.040001,19.670000,21.770000
04-23 19:03:13.489+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.489+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:470,9.633210,-0.293082,1.812666
04-23 19:03:13.489+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:494,35.209999,13.160000,19.389999
04-23 19:03:13.489+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.499+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.499+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.499+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:503,23.799999,4.270000,19.670000
04-23 19:03:13.499+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:503,9.142976,0.650848,5.051248
04-23 19:03:13.499+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.509+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:499,9.623233,-0.288021,1.865693
04-23 19:03:13.509+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:509,-0.480257,0.938869,3.185555
04-23 19:03:13.509+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.509+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.509+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.529+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:521,9.387043,0.267996,5.235496
04-23 19:03:13.529+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:516,9.613471,-0.270244,1.917948
04-23 19:03:13.529+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.549+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:03:13.549+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:03:13.549+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:03:13.549+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.559+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:557,-0.226428,0.538240,3.317548
04-23 19:03:13.559+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:521,22.680000,-0.140000,20.580000
04-23 19:03:13.559+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.569+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.569+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:568,25.340000,-1.190000,20.510000
04-23 19:03:13.569+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.579+0200 W/LOCATION( 6887): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:03:13.579+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:574,-0.449859,0.310688,3.174350
04-23 19:03:13.579+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.579+0200 I/heartrate( 6875): capturing data from es.ugr.frailty.heartrate
04-23 19:03:13.579+0200 I/heartrate( 6875): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:03:13.579+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:582,22.540001,-2.590000,17.290001
04-23 19:03:13.579+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.579+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.589+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:584,-0.559979,-0.080161,3.722480
04-23 19:03:13.589+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.589+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:596,-0.472811,-0.591452,3.007306
04-23 19:03:13.589+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:542,9.164511,0.035892,5.087141
04-23 19:03:13.599+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.599+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:540,9.614369,-0.274796,1.912791
04-23 19:03:13.599+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:591,19.740000,-14.420000,13.580000
04-23 19:03:13.599+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.599+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.599+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.609+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:611,-0.125445,-0.668126,2.203438
04-23 19:03:13.609+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:606,20.860001,-17.150000,7.630000
04-23 19:03:13.609+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:604,9.059227,-0.368495,5.608776
04-23 19:03:13.609+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.609+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.619+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.619+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:612,9.619206,-0.288334,1.886296
04-23 19:03:13.619+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:623,-0.014268,-0.569689,2.293292
04-23 19:03:13.619+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.629+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:622,9.154939,-0.904487,4.845466
04-23 19:03:13.629+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:629,9.627749,-0.313035,1.838160
04-23 19:03:13.629+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:621,15.960000,-11.830000,1.190000
04-23 19:03:13.629+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.629+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.639+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.639+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.639+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:638,9.528220,-1.028914,3.890730
04-23 19:03:13.639+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.639+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:643,7.140000,-8.680000,-4.830000
04-23 19:03:13.649+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:651,9.669396,-0.973879,3.787838
04-23 19:03:13.649+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:644,9.653666,-0.360787,1.687292
04-23 19:03:13.649+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:642,-0.334516,-0.024312,2.383942
04-23 19:03:13.649+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.649+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.659+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.659+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.659+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:659,9.683664,-0.404190,1.494546
04-23 19:03:13.659+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:661,-0.279399,0.190786,2.485922
04-23 19:03:13.659+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.659+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:663,-10.500000,-8.120000,-10.430000
04-23 19:03:13.659+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:664,9.372685,-0.454636,3.708875
04-23 19:03:13.669+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:669,9.707201,-0.430325,1.324933
04-23 19:03:13.669+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.669+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.669+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.679+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:676,9.439686,-0.232104,3.723232
04-23 19:03:13.679+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.679+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:681,9.719085,-0.422890,1.237310
04-23 19:03:13.679+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:683,-11.340000,-5.040000,-13.090000
04-23 19:03:13.679+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.679+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:681,-0.438117,0.195675,2.225209
04-23 19:03:13.679+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.689+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:688,9.291330,-0.205783,3.385844
04-23 19:03:13.689+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:691,9.729447,-0.401458,1.160635
04-23 19:03:13.689+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.689+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.699+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.699+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.699+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:703,9.358330,0.165105,3.117848
04-23 19:03:13.699+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:703,-0.379991,0.539916,2.024676
04-23 19:03:13.699+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:699,9.738320,-0.374811,1.093171
04-23 19:03:13.709+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:702,-8.610000,0.070000,-13.650000
04-23 19:03:13.709+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.709+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:714,9.735813,-0.328492,1.129789
04-23 19:03:13.709+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.709+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.719+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.719+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:721,9.183653,-0.220140,3.172883
04-23 19:03:13.719+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:723,-15.960000,10.010000,-13.230000
04-23 19:03:13.719+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:721,-0.552160,0.108352,2.043094
04-23 19:03:13.719+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.729+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:730,9.743169,-0.305219,1.071391
04-23 19:03:13.729+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.729+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.739+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.739+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:741,9.097511,-0.320638,3.541377
04-23 19:03:13.739+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.739+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:743,-8.400000,16.100000,-11.340000
04-23 19:03:13.739+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:741,-0.645658,-0.015419,2.469986
04-23 19:03:13.739+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:745,9.748142,-0.286360,1.030587
04-23 19:03:13.749+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.749+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.759+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.759+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:761,8.961121,0.380459,4.201797
04-23 19:03:13.759+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.759+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:761,-0.787022,0.666819,3.171210
04-23 19:03:13.759+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:763,6.160000,21.629999,-10.080000
04-23 19:03:13.759+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:765,9.720564,-0.230396,1.275908
04-23 19:03:13.769+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.769+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.779+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.779+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:780,8.721838,1.002593,4.362115
04-23 19:03:13.779+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.779+0200 I/heartrate( 6875): capturing data from es.ugr.frailty.heartrate
04-23 19:03:13.779+0200 I/heartrate( 6875): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:03:13.779+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:783,13.370000,23.520000,-7.070000
04-23 19:03:13.779+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:780,-0.998726,1.232989,3.086207
04-23 19:03:13.789+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:785,9.659369,-0.148074,1.686723
04-23 19:03:13.789+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.789+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.799+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.799+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:802,24.570000,24.080000,-0.980000
04-23 19:03:13.799+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:803,-0.758070,1.083667,2.888354
04-23 19:03:13.809+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.809+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:802,8.901299,0.935594,4.575077
04-23 19:03:13.809+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.809+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.819+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.819+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:821,8.865408,0.406780,4.264010
04-23 19:03:13.819+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:823,25.200001,29.889999,2.310000
04-23 19:03:13.819+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:821,-0.729376,0.485211,2.238091
04-23 19:03:13.819+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:813,9.594784,-0.078431,2.025919
04-23 19:03:13.819+0200 I/servicemanager( 6846): es.ugr.frailty.location sleep timeout
04-23 19:03:13.819+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.819+0200 W/AUL     ( 6846): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 19:03:13.829+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:03:13.829+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6846
04-23 19:03:13.829+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.839+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.839+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6887
04-23 19:03:13.839+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:843,-0.971569,0.195374,2.026733
04-23 19:03:13.839+0200 W/AUL     ( 6846): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6887)
04-23 19:03:13.839+0200 I/servicemanager( 6846): es.ugr.frailty.location stop request sent!
04-23 19:03:13.839+0200 I/servicemanager( 6846): App control destroyed.
04-23 19:03:13.839+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.839+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:842,22.400000,31.639999,2.520000
04-23 19:03:13.849+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:832,9.554625,-0.042233,2.208563
04-23 19:03:13.849+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.849+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:849,8.583055,0.153141,4.235296
04-23 19:03:13.849+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:854,9.525932,-0.021490,2.329494
04-23 19:03:13.849+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.849+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.859+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.859+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:862,8.341379,1.792224,5.391029
04-23 19:03:13.859+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.859+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:862,-1.184553,1.813714,3.061535
04-23 19:03:13.859+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:863,12.180000,32.060001,7.560000
04-23 19:03:13.869+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:868,9.434375,0.064139,2.675600
04-23 19:03:13.869+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.869+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.869+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.879+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:880,8.102098,1.021735,5.721239
04-23 19:03:13.879+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.879+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:882,-16.170000,19.600000,10.780000
04-23 19:03:13.879+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:880,-1.332277,0.957596,3.045639
04-23 19:03:13.879+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:885,9.394445,0.086362,2.811995
04-23 19:03:13.889+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.889+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.899+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.899+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:902,7.992027,-0.124427,6.130411
04-23 19:03:13.899+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:903,-12.110000,16.590000,12.110000
04-23 19:03:13.899+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.899+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:902,-1.402418,-0.210788,3.318416
04-23 19:03:13.899+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:907,9.408092,0.049543,2.766902
04-23 19:03:13.919+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.919+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.919+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:926,14.000000,7.980000,11.340000
04-23 19:03:13.919+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.929+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:930,-1.396921,0.082062,2.392024
04-23 19:03:13.929+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.939+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:936,9.409965,0.040837,2.760666
04-23 19:03:13.939+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.939+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.939+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:944,18.410000,5.250000,12.740000
04-23 19:03:13.949+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:946,-1.121227,0.368336,1.376524
04-23 19:03:13.949+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.949+0200 I/gyroscope( 6863): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:13.959+0200 I/linearacceleration( 6910): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:13.959+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:924,8.011170,0.131605,5.158926
04-23 19:03:13.959+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.959+0200 I/linearacceleration( 6910): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:13:963,-0.773600,-0.148089,1.948591
04-23 19:03:13.959+0200 I/gyroscope( 6863): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:13:961,-7.420000,7.840000,12.460000
04-23 19:03:13.959+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:965,8.288737,0.409173,4.137190
04-23 19:03:13.959+0200 I/accelerometer( 6861): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:13.959+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:954,9.409296,0.045197,2.762876
04-23 19:03:13.969+0200 I/gravity ( 6928): capturing data from es.ugr.frailty.gravity
04-23 19:03:13.969+0200 I/accelerometer( 6861): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:13:969,8.635696,-0.102891,4.711468
04-23 19:03:13.969+0200 I/gravity ( 6928): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:13:973,9.442333,0.008278,2.648144
04-23 19:03:13.969+0200 W/CRASH_MANAGER( 5847): worker.c: worker_job(1205) > 11068876c6f63152450299
