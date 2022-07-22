S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 13199
Date: 2018-06-07 16:57:02+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf758c52d, r5   = 0xf7c00f98
r6   = 0xff97ff90, r7   = 0xff97fe40
r8   = 0xf7bfdc18, r9   = 0x00000000
r10  = 0xff97ff1c, fp   = 0xff97ff90
ip   = 0x00000001, sp   = 0xff97fe18
lr   = 0xf758c539, pc   = 0xf75f5228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     53920 KB
Buffers:      5372 KB
Cached:      57176 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       10944 KB
VmRSS:       10940 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 13199 TID = 13199
13199 13203 

Maps Information
f4457000 f4c56000 rw-p [stack:13203]
f4c5d000 f4c5f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c67000 f4c6b000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c74000 f4c76000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c7e000 f4c81000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4c90000 f4c95000 r-xp /usr/lib/libsystem.so.0.0.0
f4ca0000 f4ca3000 r-xp /lib/libattr.so.1.1.0
f4cab000 f4cbb000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4cc3000 f4ccc000 r-xp /usr/lib/libedbus.so.1.7.99
f4cd4000 f4cd5000 r-xp /usr/lib/libresponse.so.0.2.96
f4cde000 f4ce3000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6585000 f668b000 r-xp /usr/lib/libicuuc.so.57.1
f66a1000 f6829000 r-xp /usr/lib/libicui18n.so.57.1
f6839000 f6846000 r-xp /usr/lib/libail.so.0.1.0
f684f000 f6856000 r-xp /usr/lib/libminizip.so.1.0.0
f685f000 f6a08000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a28000 f6a6f000 r-xp /usr/lib/libssl.so.1.0.0
f6a7b000 f6a7d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a85000 f6a8c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a95000 f6a9c000 r-xp /lib/libcrypt-2.13.so
f6acd000 f6ad0000 r-xp /lib/libcap.so.2.21
f6ad8000 f6ada000 r-xp /usr/lib/libiri.so
f6ae2000 f6b2b000 r-xp /usr/lib/libmdm.so.1.2.69
f6b33000 f6b39000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b41000 f6b64000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b6e000 f6b70000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b78000 f6b95000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b9e000 f6ba2000 r-xp /usr/lib/libsmack.so.1.0.0
f6bab000 f6bc4000 r-xp /usr/lib/libnetwork.so.0.0.0
f6bcd000 f6bd5000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6bdd000 f6be3000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6bec000 f6bee000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6bf7000 f6c07000 r-xp /lib/libresolv-2.13.so
f6c0b000 f6c23000 r-xp /usr/lib/liblzma.so.5.0.3
f6c2c000 f6c2e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c36000 f6c50000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c58000 f6c87000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c90000 f6c9f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6ca9000 f6cb3000 r-xp /usr/lib/libsensord-shared.so
f6cbc000 f6d8f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d9a000 f6db0000 r-xp /lib/libz.so.1.2.5
f6db8000 f6dbd000 r-xp /usr/lib/libffi.so.5.0.10
f6dc5000 f6dc6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6dce000 f6dde000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6de6000 f6dff000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e07000 f6e09000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e11000 f6e86000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e90000 f6e96000 r-xp /lib/librt-2.13.so
f6e9f000 f6ebd000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ec7000 f6ec8000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ed0000 f6ef3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6efb000 f6f00000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f08000 f6f32000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f3b000 f6f52000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f5a000 f6fc3000 r-xp /lib/libm-2.13.so
f6fcc000 f7060000 r-xp /usr/lib/libstdc++.so.6.0.16
f7073000 f7078000 r-xp /usr/lib/libctx-client.so.0.8.3
f7080000 f7087000 r-xp /usr/lib/libctx-shared.so.0.8.3
f708f000 f70b9000 r-xp /usr/lib/libsensor.so.1.9.6
f70c2000 f718e000 r-xp /usr/lib/libxml2.so.2.7.8
f719b000 f719d000 r-xp /usr/lib/libiniparser.so.0
f71a6000 f71ac000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f71b5000 f7285000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7286000 f72ba000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f72c3000 f72ff000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7307000 f730a000 r-xp /usr/lib/libbundle.so.0.1.22
f7312000 f7318000 r-xp /usr/lib/libappsvc.so.0.1.0
f7320000 f7361000 r-xp /usr/lib/libeina.so.1.7.99
f736a000 f7381000 r-xp /usr/lib/libecore.so.1.7.99
f7398000 f73a1000 r-xp /usr/lib/libvconf.so.0.2.45
f73a9000 f73bd000 r-xp /lib/libpthread-2.13.so
f73c8000 f73d5000 r-xp /usr/lib/libaul.so.0.1.0
f73df000 f73e1000 r-xp /lib/libdl-2.13.so
f73ea000 f73f5000 r-xp /lib/libunwind.so.8.0.1
f7422000 f742a000 r-xp /lib/libgcc_s-4.6.so.1
f742b000 f754f000 r-xp /lib/libc-2.13.so
f755d000 f755f000 r-xp /usr/lib/libdlog.so.0.0.0
f7567000 f7573000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f757c000 f7581000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7589000 f7598000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f75a0000 f75a4000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75ad000 f75b0000 r-xp /usr/lib/libappcore-agent.so.1.1
f75b8000 f75ba000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f75c2000 f75c6000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f75ce000 f75eb000 r-xp /lib/ld-2.13.so
f75f4000 f75f7000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f75f7000 f75fb000 r-xp /usr/lib/libsys-assert.so
f7bcd000 f7c3b000 rw-p [heap]
ff961000 ff982000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13199)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf75f5228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf758c539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72933f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7291c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf729de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf72a3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf72a3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf72d875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72d31f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7291c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf729de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf72a3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf72a3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf72d5e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf72d6017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf72ddf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c751fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4c68171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d3b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf71e8fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71ea7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf737aca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7375b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73765a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7376879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf75ae183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75ae7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75f55c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf744285c) [/lib/libc.so.6] + 0x1785c
29: (0xf75f4f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
-R760,07/06/2018,16:57:01:541,5.867667,0.630755,7.832178
06-07 16:57:01.541+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:01.541+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:01:546,-2.926406,-0.885323,1.717365
06-07 16:57:01.541+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:01.541+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:01:550,-0.980000,1.120000,-1.610000
06-07 16:57:01.551+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:01.551+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:01.551+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:01.551+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:01:561,-2.030000,0.560000,-1.960000
06-07 16:57:01.561+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:01:565,5.907186,0.586963,7.805832
06-07 16:57:01.561+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:01:561,2.885744,-0.248854,9.621540
06-07 16:57:01.561+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:01.571+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:01:571,-2.981923,-0.879608,1.789362
06-07 16:57:01.571+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:01.581+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:01.581+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:01:585,2.964707,-0.210568,9.408579
06-07 16:57:01.581+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:01:586,5.966650,0.548901,7.763258
06-07 16:57:01.581+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:01.581+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:01.591+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:01:591,-3.010000,-0.910000,-1.960000
06-07 16:57:01.591+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:01:593,-2.942479,-0.797531,1.602747
06-07 16:57:01.591+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:01.591+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:01.591+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:01:601,2.900101,-0.203390,9.403792
06-07 16:57:01.601+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:01.601+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:01:601,6.014335,0.512989,7.728842
06-07 16:57:01.601+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:01.601+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:01:606,-1.470000,-1.540000,-1.610000
06-07 16:57:01.601+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:01:608,-3.066550,-0.752291,1.640534
06-07 16:57:01.611+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:01.611+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:01.621+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:01:623,6.032432,0.482299,7.716705
06-07 16:57:01.621+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:01:623,2.950350,-0.167498,9.372685
06-07 16:57:01.621+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:01.621+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:01.631+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:01:630,1.750000,-1.050000,-1.610000
06-07 16:57:01.631+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:01:632,-3.063985,-0.680487,1.643844
06-07 16:57:01.631+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:01.631+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:01.641+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:01:642,2.952743,-0.057428,9.410972
06-07 16:57:01.641+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:01:643,6.034101,0.457868,7.716888
06-07 16:57:01.641+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:01.641+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:01.641+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:01:649,1.190000,-0.700000,-1.190000
06-07 16:57:01.651+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:01:651,-3.079688,-0.539727,1.694266
06-07 16:57:01.651+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:01.651+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:01.661+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:01:662,2.945565,-0.102891,9.425328
06-07 16:57:01.661+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:57:01.661+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:01.661+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:01:663,6.069526,0.430677,7.690628
06-07 16:57:01.661+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:57:01:669,85
06-07 16:57:01.671+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:01:669,-1.540000,-0.770000,-0.770000
06-07 16:57:01.671+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:01.671+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:01:679,-3.088536,-0.560759,1.708440
06-07 16:57:01.681+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:01.681+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:01.681+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:57:01.681+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:01:686,6.113454,0.400361,7.657400
06-07 16:57:01.691+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:01.691+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:01:692,2.876173,-0.184247,9.432507
06-07 16:57:01.691+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:57:01:687,849.000000
06-07 16:57:01.691+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:01.691+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:01.691+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:01.701+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:01:702,6.108133,0.374686,7.662943
06-07 16:57:01.701+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:01:696,-3.193353,-0.614924,1.741879
06-07 16:57:01.701+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:01.711+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer alive timeout
06-07 16:57:01.711+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 16:57:01.711+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:01:713,-3.242067,-0.555895,1.794250
06-07 16:57:01.711+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:57:01.711+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:57:01.711+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:01.721+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:01:723,6.073134,0.355906,7.691603
06-07 16:57:01.721+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:01.731+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13214
06-07 16:57:01.731+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:01:732,-3.119498,-0.444078,1.704957
06-07 16:57:01.731+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13214)
06-07 16:57:01.731+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer launch request sent!
06-07 16:57:01.731+0200 I/servicemanager(12566): App control destroyed.
06-07 16:57:01.731+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope alive timeout
06-07 16:57:01.731+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 16:57:01.731+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:57:01.731+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:57:01.731+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:01.741+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:01:742,6.069258,0.337352,7.695498
06-07 16:57:01.741+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:01.741+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13058
06-07 16:57:01.741+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13058)
06-07 16:57:01.741+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope launch request sent!
06-07 16:57:01.741+0200 I/servicemanager(12566): App control destroyed.
06-07 16:57:01.741+0200 I/servicemanager(12566): es.ugr.frailty.heartrate alive timeout
06-07 16:57:01.741+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 16:57:01.741+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:57:01.741+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:57:01.751+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:01:750,-3.120391,-0.403762,1.714583
06-07 16:57:01.751+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:01.761+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12595
06-07 16:57:01.761+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:57:01.761+0200 W/CAPI_APPFW_APP_CONTROL(12595): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:57:01.761+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(12595), cmd(0)
06-07 16:57:01.761+0200 I/utils   (12595): specific action
06-07 16:57:01.761+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12595)
06-07 16:57:01.761+0200 I/servicemanager(12566): es.ugr.frailty.heartrate launch request sent!
06-07 16:57:01.761+0200 I/servicemanager(12566): App control destroyed.
06-07 16:57:01.761+0200 I/servicemanager(12566): es.ugr.frailty.location alive timeout
06-07 16:57:01.761+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 16:57:01.761+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:57:01.761+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:01:761,6.115608,0.314763,7.659677
06-07 16:57:01.761+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:57:01.761+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:01.771+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:01:705,2.871387,-0.155533,9.451650
06-07 16:57:01.771+0200 W/CAPI_APPFW_APP_CONTROL(13214): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:57:01.771+0200 I/utils   (13214): specific action
06-07 16:57:01.771+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:01.771+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:01:705,-1.050000,-0.560000,-0.910000
06-07 16:57:01.781+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:01.781+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13199
06-07 16:57:01.781+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13199)
06-07 16:57:01.781+0200 I/servicemanager(12566): es.ugr.frailty.location launch request sent!
06-07 16:57:01.781+0200 I/servicemanager(12566): App control destroyed.
06-07 16:57:01.781+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration alive timeout
06-07 16:57:01.781+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 16:57:01.781+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:57:01.781+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:01.781+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:57:01.781+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:01:789,3.080000,0.350000,-1.050000
06-07 16:57:01.791+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:01:773,-3.056694,-0.442636,1.732224
06-07 16:57:01.791+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:01.791+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13072
06-07 16:57:01.791+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:01:786,6.154034,0.292720,7.629716
06-07 16:57:01.791+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13072)
06-07 16:57:01.791+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration launch request sent!
06-07 16:57:01.791+0200 I/servicemanager(12566): App control destroyed.
06-07 16:57:01.791+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:57:01.791+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(13214), cmd(0)
06-07 16:57:01.801+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:01:777,2.988636,-0.069392,9.367901
06-07 16:57:01.801+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:57:01.801+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(13199), cmd(0)
06-07 16:57:01.801+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:01.801+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:01.801+0200 W/CAPI_APPFW_APP_CONTROL(13199): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:57:01.801+0200 I/utils   (13199): specific action
06-07 16:57:01.801+0200 W/CAPI_APPFW_APP_CONTROL(13058): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:57:01.801+0200 I/utils   (13058): specific action
06-07 16:57:01.801+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:01.801+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:57:01.801+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(13058), cmd(0)
06-07 16:57:01.811+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:01:807,6.186563,0.269100,7.604237
06-07 16:57:01.811+0200 I/servicemanager(12566): es.ugr.frailty.gravity alive timeout
06-07 16:57:01.811+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 16:57:01.811+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:57:01.811+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:57:01.811+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:01:806,2.952743,-0.047856,9.406186
06-07 16:57:01.811+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:01.821+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:01:799,-3.141330,-0.427225,1.736938
06-07 16:57:01.821+0200 W/CAPI_APPFW_APP_CONTROL(13072): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:57:01.821+0200 I/utils   (13072): specific action
06-07 16:57:01.821+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:01.821+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:01:828,-3.244362,-0.465004,1.707078
06-07 16:57:01.821+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:01:813,4.690000,0.560000,-0.700000
06-07 16:57:01.821+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13086
06-07 16:57:01.831+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:57:01.831+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(13072), cmd(0)
06-07 16:57:01.831+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13086)
06-07 16:57:01.831+0200 I/servicemanager(12566): es.ugr.frailty.gravity launch request sent!
06-07 16:57:01.831+0200 I/servicemanager(12566): App control destroyed.
06-07 16:57:01.831+0200 I/servicemanager(12566): es.ugr.frailty.pressure alive timeout
06-07 16:57:01.831+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 16:57:01.831+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:57:01.831+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:57:01.831+0200 W/CAPI_APPFW_APP_CONTROL(13086): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:57:01.831+0200 I/utils   (13086): specific action
06-07 16:57:01.831+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:01.831+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:01:824,3.012564,-0.105284,9.427721
06-07 16:57:01.831+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:01.841+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:01.841+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12603
06-07 16:57:01.841+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12603)
06-07 16:57:01.841+0200 I/servicemanager(12566): es.ugr.frailty.pressure launch request sent!
06-07 16:57:01.841+0200 I/servicemanager(12566): App control destroyed.
06-07 16:57:01.841+0200 I/servicemanager(12566): es.ugr.frailty.light alive timeout
06-07 16:57:01.841+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 16:57:01.841+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:57:01.841+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:57:01.841+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:01:838,6.233763,0.248747,7.566288
06-07 16:57:01.841+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:01.851+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:01.851+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:01:857,-3.257747,-0.383955,1.804342
06-07 16:57:01.851+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12614
06-07 16:57:01.851+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12614)
06-07 16:57:01.851+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 16:57:01.851+0200 I/servicemanager(12566): App control destroyed.
06-07 16:57:01.851+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 16:57:01.851+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 16:57:01.851+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:57:01.851+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(13086), cmd(0)
06-07 16:57:01.851+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:57:01.861+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:57:01.861+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:57:01.861+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:57:01:868,85
06-07 16:57:01.861+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:01:845,2.974278,-0.112463,9.396614
06-07 16:57:01.871+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 16:57:01.871+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 16:57:01.871+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 16:57:01.871+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:57:01.871+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12618), cmd(0)
06-07 16:57:01.871+0200 I/servicemanager(12566): App control destroyed.
06-07 16:57:01.871+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:57:01.871+0200 I/utils   (12618): specific action
06-07 16:57:01.871+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:01:846,1.120000,0.420000,-0.700000
06-07 16:57:01.871+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:57:01.871+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(12614), cmd(0)
06-07 16:57:01.871+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:57:01.871+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(12603), cmd(0)
06-07 16:57:01.871+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:01.871+0200 W/CAPI_APPFW_APP_CONTROL(12614): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:57:01.871+0200 W/CAPI_APPFW_APP_CONTROL(12603): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:57:01.871+0200 I/utils   (12603): specific action
06-07 16:57:01.871+0200 I/utils   (12614): specific action
06-07 16:57:01.871+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:01:880,-1.260000,0.070000,0.770000
06-07 16:57:01.881+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:57:01.881+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:01.881+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:57:01:885,850.000000
06-07 16:57:01.881+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:01:886,2.909672,-0.172283,9.336794
06-07 16:57:01.881+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:01.881+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:01:854,6.391637,0.222670,7.434230
06-07 16:57:01.881+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:01:890,2.928815,-0.114855,9.408579
06-07 16:57:01.881+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:01.881+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:01.891+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:01.891+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:01:894,6.617723,0.187524,7.234705
06-07 16:57:01.891+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:01.891+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:01.891+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:01:900,6.748381,0.162451,7.113604
06-07 16:57:01.891+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:01:902,-0.350000,0.070000,1.190000
06-07 16:57:01.901+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:01.901+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:01:897,-3.257092,-0.452137,1.741793
06-07 16:57:01.901+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:01.901+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:01:906,6.926800,0.131479,6.940644
06-07 16:57:01.901+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:01:893,2.976671,-0.203390,9.308081
06-07 16:57:01.901+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:01.901+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:01:908,-3.410180,-0.600736,1.998276
06-07 16:57:01.911+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:01.911+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:01.911+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:01:916,1.330000,0.490000,1.120000
06-07 16:57:01.911+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:01:916,-3.655409,-0.414842,2.276764
06-07 16:57:01.911+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:01.911+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:01.921+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:01:922,-3.824351,-0.389769,2.436152
06-07 16:57:01.921+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:01:922,7.078988,0.113883,6.785673
06-07 16:57:01.921+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:01.921+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:01:913,2.981457,-0.378066,9.432507
06-07 16:57:01.921+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:01.921+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:01:927,-4.093698,0.354264,2.140118
06-07 16:57:01.921+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:01:929,2.962314,-0.227318,9.511470
06-07 16:57:01.921+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:01.921+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:01.931+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:01:933,2.924029,-0.227318,9.549755
06-07 16:57:01.931+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:01.931+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:01:934,-0.910000,0.560000,0.910000
06-07 16:57:01.931+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:01.931+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:01:936,2.833102,0.485743,9.080762
06-07 16:57:01.931+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:01.931+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:01:940,-6.160000,-0.210000,0.700000
06-07 16:57:01.941+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:01.941+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:01.941+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:01:945,-4.049674,0.292896,1.902666
06-07 16:57:01.941+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:01:946,-7.490000,-0.490000,0.280000
06-07 16:57:01.941+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:01:942,7.197104,0.030534,6.661167
06-07 16:57:01.941+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:01.941+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:01.951+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:01:952,3.029313,0.406780,8.688338
06-07 16:57:01.951+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:01:952,-4.760000,0.140000,0.350000
06-07 16:57:01.951+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:01.951+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:01.951+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:01:957,-12.740000,4.130000,-0.070000
06-07 16:57:01.951+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:01.951+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:01:961,-4.043364,-0.477991,2.230562
06-07 16:57:01.961+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:01.961+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:01:963,-48.439999,7.140000,0.700000
06-07 16:57:01.961+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:01.961+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:01:966,7.023530,-0.184184,6.841527
06-07 16:57:01.961+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:01.961+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:01:969,-102.760002,5.040000,0.700000
06-07 16:57:01.961+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:01.961+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:01:971,3.153740,-0.447458,8.891729
06-07 16:57:01.971+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:01:974,-146.580002,1.610000,2.240000
06-07 16:57:01.981+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:01.981+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:01.991+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:01:987,-4.099500,-1.486006,2.454589
06-07 16:57:01.991+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:01:993,6.634162,-0.516918,7.203546
06-07 16:57:01.991+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:02.001+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:02.001+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:02.001+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:02.001+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:02:6,-163.729996,3.570000,3.430000
06-07 16:57:02.011+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:02:7,2.924029,-1.670190,9.296116
06-07 16:57:02.011+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:02.021+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:02:4,6.274186,-0.881338,7.485200
06-07 16:57:02.021+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:02.021+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:02.021+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:02:10,-3.851310,-1.780192,2.145212
06-07 16:57:02.021+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:02.041+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:02:27,6.052182,-1.254036,7.613729
06-07 16:57:02.041+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:02:17,2.782853,-2.297110,9.348758
06-07 16:57:02.041+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:02.051+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:02:32,-3.331014,-1.461236,1.174425
06-07 16:57:02.051+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:02.051+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:02:29,-171.779999,11.130000,3.570000
06-07 16:57:02.061+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:02.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:57:02.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:57:02.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:57:02.061+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:57:02.071+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:57:02:69,85
06-07 16:57:02.071+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:02:54,2.943172,-2.342573,8.659625
06-07 16:57:02.071+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:02.071+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:57:02.081+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:02.081+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:57:02:82,670.000000
06-07 16:57:02.081+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:02:67,-198.869995,12.390000,1.400000
06-07 16:57:02.091+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:02:83,5.889173,-1.662457,7.663176
06-07 16:57:02.091+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:02.091+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:02:59,-3.015690,-2.277771,0.847291
06-07 16:57:02.091+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:02:89,3.036492,-3.531806,8.461020
06-07 16:57:02.091+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:02.101+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:02.101+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:02.101+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:02:108,-3.022571,-2.855193,0.795453
06-07 16:57:02.111+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:02:104,-208.110001,4.690000,0.490000
06-07 16:57:02.111+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:02:107,2.866602,-4.517649,8.458629
06-07 16:57:02.111+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:02.121+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:02:112,5.738674,-2.066736,7.678972
06-07 16:57:02.121+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:02.121+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:02.121+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:02.141+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:02:142,-3.152033,-2.917514,0.947154
06-07 16:57:02.141+0200 W/LOCATION(13199): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 16:57:02.141+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:02:149,5.584213,-2.441944,7.682699
06-07 16:57:02.141+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:02:131,-195.509995,10.220000,-0.630000
06-07 16:57:02.141+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:02:129,2.586641,-4.984250,8.626125
06-07 16:57:02.151+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:02.151+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:02.161+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:02.161+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:02.171+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:02:157,2.452643,-5.347959,8.427521
06-07 16:57:02.171+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:02.171+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:02:178,2.732604,-5.261817,8.070991
06-07 16:57:02.171+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:02:172,5.451767,-2.787357,7.660239
06-07 16:57:02.171+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:02:162,-177.449997,17.500000,-2.310000
06-07 16:57:02.181+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:02:168,-3.131570,-2.906015,0.744822
06-07 16:57:02.181+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:02.181+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:02.181+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:02.191+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:02.201+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:02:192,-161.000000,12.390000,-4.270000
06-07 16:57:02.201+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:02:197,5.359942,-3.100116,7.604649
06-07 16:57:02.201+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:02.201+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:02:195,-2.719164,-2.474460,0.410752
06-07 16:57:02.201+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:02.211+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:02:202,2.675175,-5.876772,7.575676
06-07 16:57:02.211+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:02.211+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:02.221+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:02:216,-153.089996,7.280000,-5.460000
06-07 16:57:02.221+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:02:224,5.275348,-3.415670,7.528233
06-07 16:57:02.221+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:02:219,-2.684767,-2.776656,-0.028973
06-07 16:57:02.221+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:02:222,2.400001,-6.470192,7.532606
06-07 16:57:02.231+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:02.231+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:02.231+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:02.231+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:02.241+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:02:240,2.373680,-6.764510,7.353144
06-07 16:57:02.241+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:02:245,-2.875347,-3.054522,0.004373
06-07 16:57:02.241+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:02.251+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:02:251,5.178926,-3.716127,7.452484
06-07 16:57:02.251+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:02:242,-149.169998,6.020000,-2.520000
06-07 16:57:02.251+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:02:257,2.455036,-6.664011,6.977471
06-07 16:57:02.251+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:02.251+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:02.261+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:02.261+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:57:02.261+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:57:02:269,85
06-07 16:57:02.271+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:02:267,-135.169998,4.830000,-1.050000
06-07 16:57:02.271+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:02.281+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:57:02.281+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:02:274,5.081503,-3.977502,7.384320
06-07 16:57:02.281+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:02:273,-2.805245,-3.048383,-0.099340
06-07 16:57:02.281+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:57:02:286,533.000000
06-07 16:57:02.281+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:02.281+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:02.291+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:02:283,2.713461,-6.537192,6.544370
06-07 16:57:02.291+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:02.291+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:02.291+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:02:300,-2.626467,-2.686508,-0.406849
06-07 16:57:02.301+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:02:298,-108.709999,2.310000,0.210000
06-07 16:57:02.301+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:02.301+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:02.301+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:02:302,4.990825,-4.198925,7.323324
06-07 16:57:02.311+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:02.311+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:02:304,2.703890,-6.876972,6.317052
06-07 16:57:02.311+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:02.311+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:02:310,-2.277364,-2.338266,-0.778954
06-07 16:57:02.311+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:02.321+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:02:323,4.921572,-4.401809,7.250696
06-07 16:57:02.321+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:02:318,-85.540001,1.050000,0.280000
06-07 16:57:02.321+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:02:321,2.658426,-7.611568,6.606583
06-07 16:57:02.321+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:02.331+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:02.331+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:02.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:57:02.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:57:02.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:57:02.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:57:02.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390622347,000000, pattern:[H:mm][0;m
06-07 16:57:02.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:57:02.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:57:02.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:57:02.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:57:02.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:57:02.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:57][0;m
06-07 16:57:02.341+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:02:338,2.478964,-7.917850,6.577869
06-07 16:57:02.351+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:02.351+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:02:342,4.857166,-4.618560,7.158716
06-07 16:57:02.351+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:02:341,-78.959999,0.490000,-0.210000
06-07 16:57:02.351+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:02.351+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:02.361+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:02:357,2.450250,-7.640282,6.309873
06-07 16:57:02.361+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:02:365,-86.660004,0.140000,2.380000
06-07 16:57:02.361+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:02:323,-2.217682,-2.475163,-0.933644
06-07 16:57:02.361+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:02.361+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:02.371+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:02:365,4.785732,-4.830266,7.066519
06-07 16:57:02.371+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:02.371+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:02:374,-2.198740,-2.993008,-0.552133
06-07 16:57:02.371+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:02:375,2.565106,-7.448857,6.041877
06-07 16:57:02.381+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:02.381+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:57:02.381+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:02.381+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11131996c6f63152838342
