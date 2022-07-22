S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 22460
Date: 2018-06-12 19:51:56+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf72a052d, r5   = 0xf7525150
r6   = 0xffebc1e0, r7   = 0xffebc090
r8   = 0xf7537c18, r9   = 0x00000000
r10  = 0xffebc16c, fp   = 0xffebc1e0
ip   = 0x00000001, sp   = 0xffebc068
lr   = 0xf72a0539, pc   = 0xf7309270
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     91788 KB
Buffers:     51168 KB
Cached:     174596 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11768 KB
VmRSS:       11768 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 22460 TID = 22460
22460 22483 

Maps Information
f416b000 f496a000 rw-p [stack:22483]
f4971000 f4973000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f497b000 f497f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4988000 f498a000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4992000 f4995000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f49a4000 f49a9000 r-xp /usr/lib/libsystem.so.0.0.0
f49b4000 f49b7000 r-xp /lib/libattr.so.1.1.0
f49bf000 f49cf000 r-xp /usr/lib/libmdm-common.so.1.1.24
f49d7000 f49e0000 r-xp /usr/lib/libedbus.so.1.7.99
f49e8000 f49e9000 r-xp /usr/lib/libresponse.so.0.2.96
f49f2000 f49f7000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6299000 f639f000 r-xp /usr/lib/libicuuc.so.57.1
f63b5000 f653d000 r-xp /usr/lib/libicui18n.so.57.1
f654d000 f655a000 r-xp /usr/lib/libail.so.0.1.0
f6563000 f656a000 r-xp /usr/lib/libminizip.so.1.0.0
f6573000 f671c000 r-xp /usr/lib/libcrypto.so.1.0.0
f673c000 f6783000 r-xp /usr/lib/libssl.so.1.0.0
f678f000 f6791000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6799000 f67a0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f67a9000 f67b0000 r-xp /lib/libcrypt-2.13.so
f67e1000 f67e4000 r-xp /lib/libcap.so.2.21
f67ec000 f67ee000 r-xp /usr/lib/libiri.so
f67f6000 f683f000 r-xp /usr/lib/libmdm.so.1.2.69
f6847000 f684d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6855000 f6878000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6882000 f6884000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f688c000 f68a9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f68b2000 f68b6000 r-xp /usr/lib/libsmack.so.1.0.0
f68bf000 f68d8000 r-xp /usr/lib/libnetwork.so.0.0.0
f68e1000 f68e9000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f68f1000 f68f7000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6900000 f6902000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f690b000 f691b000 r-xp /lib/libresolv-2.13.so
f691f000 f6937000 r-xp /usr/lib/liblzma.so.5.0.3
f6940000 f6942000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f694a000 f6964000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f696c000 f699b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f69a4000 f69b3000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f69bd000 f69c7000 r-xp /usr/lib/libsensord-shared.so
f69d0000 f6aa3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6aae000 f6ac4000 r-xp /lib/libz.so.1.2.5
f6acc000 f6ad1000 r-xp /usr/lib/libffi.so.5.0.10
f6ad9000 f6ada000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ae2000 f6af2000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6afa000 f6b13000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b1b000 f6b1d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b25000 f6b9a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ba4000 f6bc2000 r-xp /usr/lib/libsystemd.so.0.4.0
f6bcc000 f6bcd000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6bd5000 f6bf8000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c00000 f6c05000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c0d000 f6c37000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c40000 f6c57000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c5f000 f6c65000 r-xp /lib/librt-2.13.so
f6c6e000 f6cd7000 r-xp /lib/libm-2.13.so
f6ce0000 f6d74000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d87000 f6d8c000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d94000 f6d9b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6da3000 f6dcd000 r-xp /usr/lib/libsensor.so.1.9.6
f6dd6000 f6ea2000 r-xp /usr/lib/libxml2.so.2.7.8
f6eaf000 f6eb1000 r-xp /usr/lib/libiniparser.so.0
f6eba000 f6ec0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ec9000 f6f99000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f9a000 f6fce000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6fd7000 f7013000 r-xp /usr/lib/libSLP-location.so.0.9.24
f701b000 f701e000 r-xp /usr/lib/libbundle.so.0.1.22
f7026000 f702c000 r-xp /usr/lib/libappsvc.so.0.1.0
f7034000 f7075000 r-xp /usr/lib/libeina.so.1.7.99
f707e000 f7087000 r-xp /usr/lib/libvconf.so.0.2.45
f708f000 f70a3000 r-xp /lib/libpthread-2.13.so
f70ae000 f70bb000 r-xp /usr/lib/libaul.so.0.1.0
f70c5000 f70c7000 r-xp /lib/libdl-2.13.so
f70d0000 f70db000 r-xp /lib/libunwind.so.8.0.1
f7108000 f7110000 r-xp /lib/libgcc_s-4.6.so.1
f7111000 f7235000 r-xp /lib/libc-2.13.so
f7243000 f725a000 r-xp /usr/lib/libecore.so.1.7.99
f7271000 f7273000 r-xp /usr/lib/libdlog.so.0.0.0
f727b000 f7287000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7290000 f7295000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f729d000 f72ac000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f72b4000 f72b8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f72c1000 f72c4000 r-xp /usr/lib/libappcore-agent.so.1.1
f72cc000 f72ce000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f72d6000 f72da000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f72e2000 f72ff000 r-xp /lib/ld-2.13.so
f7308000 f730b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f730b000 f730f000 r-xp /usr/lib/libsys-assert.so
f7507000 f7575000 rw-p [heap]
ffe9d000 ffebe000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22460)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7309270) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1270
 1: (0xf72a0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6fa73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6fa5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6fb1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6fb7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6fb7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6fec75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6fe71f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6fa5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6fb1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6fb7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6fb7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6fe9e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6fea017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6ff1f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49891fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf497c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a4f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6efcfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6efe7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7253ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf724eb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf724f5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf724f879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf72c2183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72c27fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf730960b) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x160b
28: __libc_start_main + 0x114 (0xf712885c) [/lib/libc.so.6] + 0x1785c
29: (0xf7308f74) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf74
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
23): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:68,2.873780,-1.581656,9.360723
06-12 19:51:56.061+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.061+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:44,0.012528,-0.085978,0.045296
06-12 19:51:56.071+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:73,2.897708,-1.524228,9.303294
06-12 19:51:56.071+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.071+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:78,-0.027482,-0.187045,0.093039
06-12 19:51:56.071+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.081+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.081+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:85,2.853359,-1.500748,9.261559
06-12 19:51:56.081+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.081+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:90,2.880959,-1.519442,9.288938
06-12 19:51:56.091+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:83,0.002672,-0.202172,0.087912
06-12 19:51:56.091+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.091+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.101+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.101+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:106,2.866602,-1.545763,9.305687
06-12 19:51:56.101+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:102,2.848606,-1.500186,9.263113
06-12 19:51:56.111+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:100,0.020864,-0.221806,0.155481
06-12 19:51:56.111+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.111+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.111+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.121+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:123,2.845921,-1.499587,9.264036
06-12 19:51:56.121+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:127,2.924029,-1.545763,9.434900
06-12 19:51:56.121+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:66,-3.850000,-0.980000,-0.420000
06-12 19:51:56.131+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.131+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:120,0.030206,0.181849,0.029448
06-12 19:51:56.131+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.131+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:136,-3.780000,-1.120000,0.350000
06-12 19:51:56.131+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.131+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.131+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.141+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:140,-1.330000,-1.120000,-0.420000
06-12 19:51:56.141+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.141+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:142,2.841157,-1.497741,9.265797
06-12 19:51:56.141+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:146,0.280000,-0.350000,0.840000
06-12 19:51:56.141+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.141+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:144,2.866602,-1.529014,9.410972
06-12 19:51:56.141+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:137,-0.150796,-0.147228,-0.175940
06-12 19:51:56.141+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:150,3.220000,0.910000,-0.420000
06-12 19:51:56.151+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.151+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.151+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:155,-0.490000,1.260000,-0.350000
06-12 19:51:56.151+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.151+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:156,0.068382,-0.097834,0.084352
06-12 19:51:56.151+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.151+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.151+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.161+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:159,3.010000,0.630000,-0.070000
06-12 19:51:56.161+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.161+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:165,3.990000,2.660000,1.050000
06-12 19:51:56.161+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.161+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:164,2.838539,-1.492415,9.267458
06-12 19:51:56.161+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:165,2.892922,-1.440479,9.420543
06-12 19:51:56.161+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:170,1.750000,1.260000,0.910000
06-12 19:51:56.161+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.171+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:174,1.680000,0.910000,0.490000
06-12 19:51:56.171+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.171+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:161,-0.000925,0.009739,0.103931
06-12 19:51:56.171+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.171+0200 I/light   (22499): es.ugr.frailty.light - capturing data
06-12 19:51:56.171+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.171+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.171+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:179,3.850000,0.700000,0.280000
06-12 19:51:56.181+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.181+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:185,4.130000,0.700000,0.700000
06-12 19:51:56.181+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.181+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:184,2.836064,-1.494658,9.267855
06-12 19:51:56.181+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:190,2.660000,-0.070000,0.420000
06-12 19:51:56.181+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.191+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:185,2.854637,-1.579263,9.353544
06-12 19:51:56.191+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:194,2.660000,-0.280000,0.420000
06-12 19:51:56.191+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.191+0200 I/light   (22499): es.ugr.frailty.light: SM-R760,12/06/2018,19:51:56:186,133.000000
06-12 19:51:56.191+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.191+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:198,2.380000,0.560000,-0.560000
06-12 19:51:56.191+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.191+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.201+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:204,3.010000,1.050000,0.070000
06-12 19:51:56.201+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.201+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:203,2.831209,-1.495422,9.269216
06-12 19:51:56.201+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:180,0.006440,-0.062239,0.270013
06-12 19:51:56.201+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:209,2.240000,1.470000,0.700000
06-12 19:51:56.201+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.201+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:204,2.885744,-1.615155,9.332008
06-12 19:51:56.201+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.211+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:213,0.910000,1.400000,0.350000
06-12 19:51:56.211+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.211+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:214,0.061613,-0.103176,0.122959
06-12 19:51:56.211+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.211+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.211+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:218,0.700000,0.840000,0.980000
06-12 19:51:56.211+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.211+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.221+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:223,2.885744,-1.471586,9.351151
06-12 19:51:56.221+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:223,0.980000,0.840000,0.420000
06-12 19:51:56.221+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.221+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:223,2.826582,-1.489556,9.271571
06-12 19:51:56.221+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:227,0.980000,0.210000,1.190000
06-12 19:51:56.221+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.221+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:231,0.015680,-0.117326,-0.029105
06-12 19:51:56.231+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.231+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:231,0.840000,-0.140000,1.050000
06-12 19:51:56.231+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.231+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:236,0.085354,-0.138662,-0.017439
06-12 19:51:56.231+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.231+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:237,2.170000,0.770000,0.980000
06-12 19:51:56.231+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.231+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.231+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.241+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:241,2.030000,0.910000,0.840000
06-12 19:51:56.241+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.241+0200 I/heartrate(22447): es.ugr.frailty.heartrate - capturing data
06-12 19:51:56.241+0200 I/heartrate(22447): es.ugr.frailty.heartrate: waiting for rigth values
06-12 19:51:56.241+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:247,-0.560000,0.070000,0.840000
06-12 19:51:56.251+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:245,2.828575,-1.491077,9.270720
06-12 19:51:56.251+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:243,2.880959,-1.500300,9.315259
06-12 19:51:56.251+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:240,0.061993,-0.195533,0.131340
06-12 19:51:56.251+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.251+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.261+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:263,-1.960000,-0.910000,0.840000
06-12 19:51:56.261+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:259,0.130703,-0.003683,0.197526
06-12 19:51:56.261+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.261+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:269,0.000446,-0.067477,0.107529
06-12 19:51:56.261+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.271+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:272,0.030743,-0.012877,0.047663
06-12 19:51:56.271+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.271+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:277,0.020705,-0.014288,0.030220
06-12 19:51:56.271+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.281+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.281+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:285,1.400000,0.420000,0.700000
06-12 19:51:56.281+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:282,0.013242,-0.045015,0.044127
06-12 19:51:56.281+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.291+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:292,0.075423,-0.045578,0.171787
06-12 19:51:56.291+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.291+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:296,0.020681,-0.029427,0.146935
06-12 19:51:56.291+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.291+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.301+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.301+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:306,2.834688,-1.502171,9.267060
06-12 19:51:56.301+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.301+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:310,2.836339,-1.504328,9.266206
06-12 19:51:56.301+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.311+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:303,2.450000,1.470000,0.140000
06-12 19:51:56.311+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.311+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.321+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:323,0.770000,0.560000,0.140000
06-12 19:51:56.321+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:318,2.900101,-1.651048,9.379865
06-12 19:51:56.321+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.321+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:300,0.051765,0.057262,0.154746
06-12 19:51:56.321+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.331+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:313,2.830540,-1.502963,9.268200
06-12 19:51:56.331+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.331+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:334,0.016098,-0.086848,0.086086
06-12 19:51:56.331+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.331+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:337,2.830004,-1.502652,9.268414
06-12 19:51:56.331+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.331+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.341+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:343,2.833025,-1.502642,9.267493
06-12 19:51:56.341+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:343,-0.840000,0.420000,-0.210000
06-12 19:51:56.341+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:338,0.049680,-0.120497,0.064154
06-12 19:51:56.341+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.341+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:331,2.981457,-1.622334,9.324830
06-12 19:51:56.341+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.341+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:349,0.054535,0.023836,0.081935
06-12 19:51:56.341+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.351+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:350,2.866602,-1.591227,9.243474
06-12 19:51:56.351+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.351+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:353,0.054376,-0.010743,0.043688
06-12 19:51:56.351+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.351+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:356,2.928815,-1.562513,9.430114
06-12 19:51:56.351+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.351+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:357,0.071526,-0.159971,0.109145
06-12 19:51:56.351+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.351+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.351+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.361+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:364,-0.630000,-0.420000,0.070000
06-12 19:51:56.361+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:364,2.833372,-1.505672,9.266895
06-12 19:51:56.361+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:361,2.902494,-1.485943,9.334401
06-12 19:51:56.361+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.361+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:361,0.146769,-0.120163,0.057770
06-12 19:51:56.361+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.371+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:372,2.833102,-1.552942,9.379865
06-12 19:51:56.371+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:372,0.030262,-0.086899,-0.022732
06-12 19:51:56.371+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.371+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:376,0.098275,-0.059550,0.161914
06-12 19:51:56.371+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.371+0200 I/light   (22499): es.ugr.frailty.light - capturing data
06-12 19:51:56.381+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.381+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.381+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.381+0200 I/light   (22499): es.ugr.frailty.light: SM-R760,12/06/2018,19:51:56:384,133.000000
06-12 19:51:56.381+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:380,0.072490,0.016709,0.065987
06-12 19:51:56.381+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.381+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:389,0.000077,-0.050300,0.112371
06-12 19:51:56.381+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.391+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:389,2.847459,-1.598405,9.284152
06-12 19:51:56.391+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:394,0.014087,-0.092733,0.017257
06-12 19:51:56.391+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:386,2.100000,0.490000,0.140000
06-12 19:51:56.391+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:389,2.828924,-1.505491,9.268283
06-12 19:51:56.391+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.391+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.391+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.401+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.401+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:402,0.035285,0.084154,-0.043952
06-12 19:51:56.401+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:404,2.823071,-1.495409,9.271699
06-12 19:51:56.401+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:405,2.940000,1.400000,0.280000
06-12 19:51:56.401+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:407,2.864209,-1.421337,9.224331
06-12 19:51:56.411+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.411+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.421+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.421+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:423,0.074637,-0.033605,0.172772
06-12 19:51:56.421+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.421+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:425,2.820960,-1.493998,9.272569
06-12 19:51:56.421+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:423,0.630000,0.910000,0.140000
06-12 19:51:56.421+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:427,2.897708,-1.529014,9.444471
06-12 19:51:56.431+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.431+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.431+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.431+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.441+0200 I/heartrate(22447): es.ugr.frailty.heartrate - capturing data
06-12 19:51:56.441+0200 I/heartrate(22447): es.ugr.frailty.heartrate: waiting for rigth values
06-12 19:51:56.441+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:442,2.907279,-1.543371,9.430114
06-12 19:51:56.441+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:442,0.350000,1.330000,-0.210000
06-12 19:51:56.441+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:444,0.086319,-0.049373,0.157545
06-12 19:51:56.441+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:444,2.819392,-1.493588,9.273112
06-12 19:51:56.451+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.451+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.461+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.461+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:463,2.818018,-1.501132,9.272311
06-12 19:51:56.461+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.461+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:465,2.840281,-1.674976,9.413363
06-12 19:51:56.461+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:463,-0.280000,0.420000,-0.210000
06-12 19:51:56.461+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:468,0.020888,-0.181387,0.140251
06-12 19:51:56.471+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.471+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.481+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.481+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.481+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:484,2.822573,-1.503745,9.270502
06-12 19:51:56.481+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:484,2.933600,-1.598405,9.305687
06-12 19:51:56.491+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:486,0.115583,-0.097274,0.033376
06-12 19:51:56.491+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:485,0.840000,-0.700000,-0.210000
06-12 19:51:56.491+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.491+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.501+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.501+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:504,2.821683,-1.503654,9.270788
06-12 19:51:56.501+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.511+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:504,2.883351,-1.596013,9.355937
06-12 19:51:56.511+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:508,2.100000,-0.770000,0.350000
06-12 19:51:56.511+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.511+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.521+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:513,0.060778,-0.092268,0.085435
06-12 19:51:56.521+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:524,2.820396,-1.497257,9.272215
06-12 19:51:56.521+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.531+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.531+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:524,3.290000,-0.770000,0.140000
06-12 19:51:56.531+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.531+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.541+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:532,2.890530,-1.500300,9.276974
06-12 19:51:56.541+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.541+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:543,2.818966,-1.494336,9.273121
06-12 19:51:56.541+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:537,0.068846,0.003354,0.006186
06-12 19:51:56.541+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:542,2.660000,0.070000,-0.280000
06-12 19:51:56.541+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.551+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:547,2.904887,-1.560120,9.308081
06-12 19:51:56.551+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:552,0.084491,-0.062864,0.035866
06-12 19:51:56.551+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.551+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.561+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.561+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:564,2.822571,-1.496831,9.271622
06-12 19:51:56.561+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.571+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:564,-0.070000,-0.140000,-0.210000
06-12 19:51:56.571+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:570,2.890530,-1.548156,9.269794
06-12 19:51:56.571+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:571,0.071563,-0.053820,-0.003326
06-12 19:51:56.571+0200 I/light   (22499): es.ugr.frailty.light - capturing data
06-12 19:51:56.571+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.581+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:585,2.829000,-1.501364,9.268929
06-12 19:51:56.581+0200 I/light   (22499): es.ugr.frailty.light: SM-R760,12/06/2018,19:51:56:584,133.000000
06-12 19:51:56.581+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.581+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.591+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:590,0.115815,-0.082432,0.046029
06-12 19:51:56.591+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.591+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:596,2.938386,-1.579263,9.317651
06-12 19:51:56.591+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.591+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.591+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.601+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:603,2.831972,-1.502543,9.267831
06-12 19:51:56.601+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:591,-0.700000,-0.280000,-0.560000
06-12 19:51:56.601+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.601+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:604,2.971886,-1.603191,9.317651
06-12 19:51:56.601+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:602,0.142886,-0.101827,0.048721
06-12 19:51:56.611+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:610,1.400000,0.070000,-0.210000
06-12 19:51:56.611+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.611+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.621+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.621+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.621+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:623,2.829917,-1.497906,9.269209
06-12 19:51:56.621+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:623,0.111199,-0.064756,0.042642
06-12 19:51:56.631+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:629,3.360000,0.420000,-0.630000
06-12 19:51:56.631+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:626,2.943172,-1.567299,9.310472
06-12 19:51:56.631+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.631+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.641+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.641+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.661+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:649,2.931208,-1.593620,9.384650
06-12 19:51:56.661+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:645,3.360000,0.980000,-0.770000
06-12 19:51:56.661+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:643,0.101291,-0.095714,0.115441
06-12 19:51:56.671+0200 W/LOCATION(22460): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 19:51:56.681+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 19:51:56.681+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 19:51:56.681+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 19:51:56.681+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 19:51:56.681+0200 I/heartrate(22447): es.ugr.frailty.heartrate - capturing data
06-12 19:51:56.681+0200 I/heartrate(22447): es.ugr.frailty.heartrate: waiting for rigth values
06-12 19:51:56.681+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.681+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:643,2.825405,-1.493854,9.271239
06-12 19:51:56.681+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.691+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.691+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.701+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:699,2.878566,-1.452443,9.329616
06-12 19:51:56.701+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.711+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:699,0.700000,0.630000,-0.630000
06-12 19:51:56.711+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.711+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:695,0.053161,0.041411,0.058376
06-12 19:51:56.711+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.711+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:694,2.824936,-1.489454,9.272090
06-12 19:51:56.711+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.721+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:720,0.115843,-0.063488,0.031204
06-12 19:51:56.721+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.731+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:724,2.834864,-1.496429,9.267936
06-12 19:51:56.731+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.741+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:711,2.940779,-1.552942,9.303294
06-12 19:51:56.741+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:717,-2.380000,-0.350000,-0.910000
06-12 19:51:56.741+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.751+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.751+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:733,0.091558,-0.001478,-0.000533
06-12 19:51:56.751+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.761+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:750,2.926422,-1.497907,9.267403
06-12 19:51:56.761+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.761+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:755,-0.280000,0.280000,-0.350000
06-12 19:51:56.761+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.761+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:739,2.838952,-1.496590,9.266659
06-12 19:51:56.761+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.771+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:761,0.065935,0.010647,0.043814
06-12 19:51:56.771+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.781+0200 I/light   (22499): es.ugr.frailty.light - capturing data
06-12 19:51:56.781+0200 I/light   (22499): es.ugr.frailty.light: SM-R760,12/06/2018,19:51:56:785,132.000000
06-12 19:51:56.781+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:774,2.836333,-1.492050,9.268192
06-12 19:51:56.791+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:769,1.540000,1.120000,-0.070000
06-12 19:51:56.791+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.791+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:767,2.904887,-1.485943,9.310472
06-12 19:51:56.791+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.791+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.801+0200 E/WMS     ( 2465): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23480) > _wms_event_handler_cb_nomove_detector is called
06-12 19:51:56.811+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:800,2.900101,-1.450050,9.305687
06-12 19:51:56.811+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:803,2.831368,-1.484979,9.270845
06-12 19:51:56.811+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.811+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:779,0.063768,0.042000,0.037495
06-12 19:51:56.821+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:797,2.030000,1.750000,0.280000
06-12 19:51:56.821+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.821+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.821+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:828,-0.017408,-0.039249,0.104234
06-12 19:51:56.821+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.821+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.831+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:833,2.813959,-1.524228,9.375079
06-12 19:51:56.831+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.841+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:826,-0.350000,1.890000,0.490000
06-12 19:51:56.841+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:820,2.825616,-1.486115,9.272418
06-12 19:51:56.841+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.841+0200 I/heartrate(22447): es.ugr.frailty.heartrate - capturing data
06-12 19:51:56.841+0200 I/heartrate(22447): es.ugr.frailty.heartrate: waiting for rigth values
06-12 19:51:56.841+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.851+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:832,0.084056,0.012136,0.131374
06-12 19:51:56.851+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.851+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:839,2.909672,-1.473979,9.403792
06-12 19:51:56.861+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:850,-2.240000,0.560000,1.050000
06-12 19:51:56.861+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.861+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:848,2.829553,-1.489101,9.270739
06-12 19:51:56.861+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.871+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.871+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:875,2.837888,-1.607977,9.372685
06-12 19:51:56.881+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:860,0.008335,-0.118876,0.101947
06-12 19:51:56.881+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.891+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:872,2.828726,-1.496453,9.269807
06-12 19:51:56.891+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:867,-1.400000,0.840000,0.560000
06-12 19:51:56.891+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.891+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.901+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.911+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:904,1.190000,0.490000,0.840000
06-12 19:51:56.921+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:887,0.004376,-0.137845,0.114843
06-12 19:51:56.921+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.921+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:906,2.823576,-1.499757,9.270844
06-12 19:51:56.921+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:904,2.833102,-1.634298,9.384650
06-12 19:51:56.921+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.921+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.921+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.941+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:929,0.090882,0.020992,0.006130
06-12 19:51:56.941+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:935,2.660000,1.050000,0.980000
06-12 19:51:56.941+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:941,2.820028,-1.493222,9.272978
06-12 19:51:56.941+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.941+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:936,2.914458,-1.478764,9.276974
06-12 19:51:56.941+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.941+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.951+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.951+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:952,0.056145,0.012065,0.104494
06-12 19:51:56.971+0200 W/AUL     (22540): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-12 19:51:56.971+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:962,2.818709,-1.490886,9.273754
06-12 19:51:56.971+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:957,0.560000,0.420000,0.840000
06-12 19:51:56.971+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:56.981+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:956,2.876173,-1.481157,9.377472
06-12 19:51:56.981+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:56.981+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:56.981+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:56.991+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 19:51:56.991+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 19:51:56.991+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 19:51:57.001+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:56:993,-1.190000,0.350000,0.980000
06-12 19:51:57.001+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:56:984,0.050285,-0.057270,0.094147
06-12 19:51:57.001+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration - capturing data
06-12 19:51:57.001+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:56:991,2.868994,-1.548156,9.367901
06-12 19:51:57.001+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer - capturing data
06-12 19:51:57.011+0200 I/linearacceleration(22461): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:51:57:13,0.024839,-0.217882,0.107295
06-12 19:51:57.011+0200 I/gravity (22474): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:51:56:994,2.820227,-1.495379,9.272570
06-12 19:51:57.011+0200 I/gravity (22474): es.ugr.frailty.gravity - capturing data
06-12 19:51:57.011+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope - capturing data
06-12 19:51:57.021+0200 I/accelerometer(22423): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:51:57:21,2.845066,-1.713261,9.379865
06-12 19:51:57.021+0200 I/gyroscope(22426): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:51:57:23,-0.700000,-0.350000,0.630000
06-12 19:51:57.031+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
06-12 19:51:57.031+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-12 19:51:57.031+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22342
06-12 19:51:57.031+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-12 19:51:57.061+0200 W/CRASH_MANAGER(22538): worker.c: worker_job(1205) > 11224606c6f63152882591
