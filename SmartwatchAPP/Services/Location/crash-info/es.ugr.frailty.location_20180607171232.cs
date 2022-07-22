S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 17727
Date: 2018-06-07 17:12:32+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf774452d, r5   = 0xf7eebf98
r6   = 0xffbd41b0, r7   = 0xffbd4060
r8   = 0xf7ee8c18, r9   = 0x00000000
r10  = 0xffbd413c, fp   = 0xffbd41b0
ip   = 0x00000001, sp   = 0xffbd4038
lr   = 0xf7744539, pc   = 0xf77ad228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    263864 KB
Buffers:     11372 KB
Cached:      54108 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11336 KB
VmRSS:       11336 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 17727 TID = 17727
17727 17748 

Maps Information
f460f000 f4e0e000 rw-p [stack:17748]
f4e15000 f4e17000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4e1f000 f4e23000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4e2c000 f4e2e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4e36000 f4e39000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4e48000 f4e4d000 r-xp /usr/lib/libsystem.so.0.0.0
f4e58000 f4e5b000 r-xp /lib/libattr.so.1.1.0
f4e63000 f4e73000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e7b000 f4e84000 r-xp /usr/lib/libedbus.so.1.7.99
f4e8c000 f4e8d000 r-xp /usr/lib/libresponse.so.0.2.96
f4e96000 f4e9b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f673d000 f6843000 r-xp /usr/lib/libicuuc.so.57.1
f6859000 f69e1000 r-xp /usr/lib/libicui18n.so.57.1
f69f1000 f69fe000 r-xp /usr/lib/libail.so.0.1.0
f6a07000 f6a0e000 r-xp /usr/lib/libminizip.so.1.0.0
f6a17000 f6bc0000 r-xp /usr/lib/libcrypto.so.1.0.0
f6be0000 f6c27000 r-xp /usr/lib/libssl.so.1.0.0
f6c33000 f6c35000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6c3d000 f6c44000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6c4d000 f6c54000 r-xp /lib/libcrypt-2.13.so
f6c85000 f6c88000 r-xp /lib/libcap.so.2.21
f6c90000 f6c92000 r-xp /usr/lib/libiri.so
f6c9a000 f6ce3000 r-xp /usr/lib/libmdm.so.1.2.69
f6ceb000 f6cf1000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6cf9000 f6d1c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6d26000 f6d28000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6d30000 f6d4d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d56000 f6d5a000 r-xp /usr/lib/libsmack.so.1.0.0
f6d63000 f6d7c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d85000 f6d8d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d95000 f6d9b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6da4000 f6da6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6daf000 f6dbf000 r-xp /lib/libresolv-2.13.so
f6dc3000 f6ddb000 r-xp /usr/lib/liblzma.so.5.0.3
f6de4000 f6de6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6dee000 f6e08000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6e10000 f6e3f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e48000 f6e57000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e61000 f6e6b000 r-xp /usr/lib/libsensord-shared.so
f6e74000 f6f47000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f52000 f6f68000 r-xp /lib/libz.so.1.2.5
f6f70000 f6f75000 r-xp /usr/lib/libffi.so.5.0.10
f6f7d000 f6f7e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f86000 f6f96000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f9e000 f6fb7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6fbf000 f6fc1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6fc9000 f703e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f7048000 f704e000 r-xp /lib/librt-2.13.so
f7057000 f7075000 r-xp /usr/lib/libsystemd.so.0.4.0
f707f000 f7080000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7088000 f70ab000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f70b3000 f70b8000 r-xp /usr/lib/libxdgmime.so.1.1.0
f70c0000 f70ea000 r-xp /usr/lib/libdbus-1.so.3.8.12
f70f3000 f710a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7112000 f717b000 r-xp /lib/libm-2.13.so
f7184000 f7218000 r-xp /usr/lib/libstdc++.so.6.0.16
f722b000 f7230000 r-xp /usr/lib/libctx-client.so.0.8.3
f7238000 f723f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7247000 f7271000 r-xp /usr/lib/libsensor.so.1.9.6
f727a000 f7346000 r-xp /usr/lib/libxml2.so.2.7.8
f7353000 f7355000 r-xp /usr/lib/libiniparser.so.0
f735e000 f7364000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f736d000 f743d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f743e000 f7472000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f747b000 f74b7000 r-xp /usr/lib/libSLP-location.so.0.9.24
f74bf000 f74c2000 r-xp /usr/lib/libbundle.so.0.1.22
f74ca000 f74d0000 r-xp /usr/lib/libappsvc.so.0.1.0
f74d8000 f7519000 r-xp /usr/lib/libeina.so.1.7.99
f7522000 f7539000 r-xp /usr/lib/libecore.so.1.7.99
f7550000 f7559000 r-xp /usr/lib/libvconf.so.0.2.45
f7561000 f7575000 r-xp /lib/libpthread-2.13.so
f7580000 f758d000 r-xp /usr/lib/libaul.so.0.1.0
f7597000 f7599000 r-xp /lib/libdl-2.13.so
f75a2000 f75ad000 r-xp /lib/libunwind.so.8.0.1
f75da000 f75e2000 r-xp /lib/libgcc_s-4.6.so.1
f75e3000 f7707000 r-xp /lib/libc-2.13.so
f7715000 f7717000 r-xp /usr/lib/libdlog.so.0.0.0
f771f000 f772b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7734000 f7739000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7741000 f7750000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7758000 f775c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7765000 f7768000 r-xp /usr/lib/libappcore-agent.so.1.1
f7770000 f7772000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f777a000 f777e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7786000 f77a3000 r-xp /lib/ld-2.13.so
f77ac000 f77af000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f77af000 f77b3000 r-xp /usr/lib/libsys-assert.so
f7eb8000 f7f29000 rw-p [heap]
ffbb5000 ffbd6000 rw-p [stack]
End of Maps Information

Callstack Information (PID:17727)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf77ad228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7744539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf744b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7449c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7455e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf745bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf745bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf749075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf748b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7449c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7455e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf745bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf745bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf748de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf748e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7495f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4e2d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4e20171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ef3663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf73a0fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73a27a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7532ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf752db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf752e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf752e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7766183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf77667fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf77ad5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf75fa85c) [/lib/libc.so.6] + 0x1785c
29: (0xf77acf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
1.741+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:31.751+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:31:740,0.711652,2.070020,-0.313305
06-07 17:12:31.751+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:31.751+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:31:736,34.299999,-2.870000,-7.420000
06-07 17:12:31.751+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:31.751+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:31.751+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:31:747,2.770572,-1.132120,9.338770
06-07 17:12:31.761+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:31.771+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:31:776,2.977336,-1.030178,9.286797
06-07 17:12:31.771+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:31:759,1.897508,0.236889,9.564112
06-07 17:12:31.771+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:31:761,27.370001,-8.400000,-8.610000
06-07 17:12:31.771+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:31.771+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:31:769,0.845892,0.976037,-0.157933
06-07 17:12:31.781+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:31.781+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:31.791+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:31.791+0200 W/LOCATION(17727): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:12:31.801+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:31:807,3.156218,-0.944975,9.236650
06-07 17:12:31.811+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:31:787,17.010000,-5.880000,-9.660000
06-07 17:12:31.811+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:31.811+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:31:794,1.466800,-0.129212,9.092726
06-07 17:12:31.811+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:31:795,0.436350,0.493762,-0.639718
06-07 17:12:31.811+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:31.811+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:31.821+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:31.831+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:31:835,3.292745,-0.846351,9.198473
06-07 17:12:31.831+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:31:823,0.700000,-1.890000,-6.650000
06-07 17:12:31.831+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:31:825,0.013408,1.140575,-0.274018
06-07 17:12:31.831+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:31.831+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:31.841+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:31:845,-1.488019,2.149070,0.411983
06-07 17:12:31.841+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:31:829,0.990629,0.636491,9.470792
06-07 17:12:31.841+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:31.841+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:31.851+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:31:858,1.282553,1.016950,9.750752
06-07 17:12:31.851+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:31:845,-20.230000,-1.190000,-4.970000
06-07 17:12:31.861+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:31.861+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:31:855,3.308064,-0.768259,9.199830
06-07 17:12:31.861+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:31.871+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:31.871+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:31.871+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:31:870,-1.362181,1.865273,0.729559
06-07 17:12:31.881+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:31.881+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:31:876,3.150725,-0.722832,9.258554
06-07 17:12:31.881+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:31:883,1.615155,0.835095,10.016356
06-07 17:12:31.881+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:31.881+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:31:868,-25.900000,6.720000,0.280000
06-07 17:12:31.881+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:31.891+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:31.891+0200 I/heartrate(17619): es.ugr.frailty.heartrate - capturing data
06-07 17:12:31.891+0200 I/heartrate(17619): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:12:31:898,77
06-07 17:12:31.891+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:31:894,-28.770000,3.150000,-0.490000
06-07 17:12:31.891+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:31.901+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:31:887,-1.608061,2.466811,0.875419
06-07 17:12:31.901+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:31:897,2.883504,-0.716990,9.345679
06-07 17:12:31.901+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:31.911+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:12:31.911+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:31:905,-16.940001,0.840000,1.680000
06-07 17:12:31.911+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:31.911+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:12:31:917,666.000000
06-07 17:12:31.921+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:31.921+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:31:905,1.548156,1.521835,10.112068
06-07 17:12:31.921+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:31.921+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:31:913,-1.629733,1.863300,0.930346
06-07 17:12:31.931+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:31:927,0.969478,-0.282720,9.754515
06-07 17:12:31.931+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:31.931+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:31:934,1.663012,1.016950,10.128819
06-07 17:12:31.931+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer alive timeout
06-07 17:12:31.931+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:12:31.931+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:31.931+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:31.931+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:31.941+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:31:941,-1.700087,0.794580,0.409745
06-07 17:12:31.941+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:31:945,1.014598,-0.308485,9.749145
06-07 17:12:31.941+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:31.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17664
06-07 17:12:31.951+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17664)
06-07 17:12:31.951+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer launch request sent!
06-07 17:12:31.951+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:31.951+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope alive timeout
06-07 17:12:31.951+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:12:31.951+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:31.951+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:31.951+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:31.951+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:31.961+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:31:957,1.607977,0.026321,9.609575
06-07 17:12:31.961+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:31:961,-1.937564,0.079162,0.903765
06-07 17:12:31.961+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17781
06-07 17:12:31.971+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17781)
06-07 17:12:31.971+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope launch request sent!
06-07 17:12:31.971+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:31.971+0200 I/servicemanager(12566): es.ugr.frailty.heartrate alive timeout
06-07 17:12:31.971+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:12:31.971+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:31.971+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:31.971+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:31.971+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:31.971+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:31:979,1.213161,-0.643669,10.162319
06-07 17:12:31.981+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:31:965,1.099862,-0.357116,9.738232
06-07 17:12:31.981+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:31.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17619
06-07 17:12:31.981+0200 W/CAPI_APPFW_APP_CONTROL(17619): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:31.981+0200 I/utils   (17619): specific action
06-07 17:12:31.981+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:31.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(17619), cmd(0)
06-07 17:12:31.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17619)
06-07 17:12:31.981+0200 I/servicemanager(12566): es.ugr.frailty.heartrate launch request sent!
06-07 17:12:31.981+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:31.981+0200 I/servicemanager(12566): es.ugr.frailty.location alive timeout
06-07 17:12:31.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:12:31.981+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:31.991+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:31.991+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:31.991+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:31:983,-1.763663,-0.307138,0.735283
06-07 17:12:31.991+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:31:920,-11.620000,-7.420000,4.200000
06-07 17:12:31.991+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:31.991+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:31:988,1.172352,-0.414119,9.727511
06-07 17:12:32.001+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17727
06-07 17:12:32.001+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17727)
06-07 17:12:32.001+0200 I/servicemanager(12566): es.ugr.frailty.location launch request sent!
06-07 17:12:32.001+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:32.001+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration alive timeout
06-07 17:12:32.001+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:12:32.001+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:32.001+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:32.001+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.011+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17793
06-07 17:12:32.011+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17793)
06-07 17:12:32.011+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:12:32.011+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:32.011+0200 I/servicemanager(12566): es.ugr.frailty.gravity alive timeout
06-07 17:12:32.011+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:12:32.021+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:32.021+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:32.021+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:32.021+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:32:5,0.394430,0.064973,-0.003762
06-07 17:12:32.031+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17731
06-07 17:12:32.031+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17731)
06-07 17:12:32.031+0200 I/servicemanager(12566): es.ugr.frailty.gravity launch request sent!
06-07 17:12:32.031+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:32.031+0200 I/servicemanager(12566): es.ugr.frailty.pressure alive timeout
06-07 17:12:32.031+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:12:32.031+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:32.031+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:32.041+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:32:5,1.119841,-1.024128,10.080962
06-07 17:12:32.041+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:32.041+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12603
06-07 17:12:32.041+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:32.051+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:26,-21.629999,-9.520000,4.900000
06-07 17:12:32.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:12:32.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:12:32.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:12:32.061+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.061+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:32.061+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(12603), cmd(0)
06-07 17:12:32.061+0200 W/CAPI_APPFW_APP_CONTROL(12603): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:32.061+0200 I/utils   (12603): specific action
06-07 17:12:32.061+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12603)
06-07 17:12:32.061+0200 I/servicemanager(12566): es.ugr.frailty.pressure launch request sent!
06-07 17:12:32.061+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:32.061+0200 I/servicemanager(12566): es.ugr.frailty.light alive timeout
06-07 17:12:32.061+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:12:32.061+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:32.061+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:32.071+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:32:35,1.223019,-0.470860,9.718688
06-07 17:12:32.071+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:32.071+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16749
06-07 17:12:32.081+0200 W/CAPI_APPFW_APP_CONTROL(16749): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:32.081+0200 I/utils   (16749): specific action
06-07 17:12:32.081+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:32.081+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(16749), cmd(0)
06-07 17:12:32.081+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:32:51,0.813518,0.112274,0.013572
06-07 17:12:32.081+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16749)
06-07 17:12:32.081+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 17:12:32.081+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:32.081+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 17:12:32.081+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:12:32.081+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:32.081+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:32.081+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:32:57,1.363909,-0.217747,9.750752
06-07 17:12:32.091+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:74,-22.820000,-0.840000,2.660000
06-07 17:12:32.091+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:32.091+0200 I/heartrate(17619): es.ugr.frailty.heartrate - capturing data
06-07 17:12:32.091+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 17:12:32.091+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:32.091+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(12618), cmd(0)
06-07 17:12:32.101+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:32.101+0200 I/heartrate(17619): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:12:32:101,77
06-07 17:12:32.101+0200 I/utils   (12618): specific action
06-07 17:12:32.101+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 17:12:32.101+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 17:12:32.101+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:32.101+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:32.101+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(17781), cmd(0)
06-07 17:12:32.101+0200 W/CAPI_APPFW_APP_CONTROL(17781): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:32.101+0200 I/utils   (17781): specific action
06-07 17:12:32.101+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.101+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:111,-18.830000,2.940000,-0.280000
06-07 17:12:32.111+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.111+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:12:32.111+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:116,-13.510000,-0.420000,-0.630000
06-07 17:12:32.111+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.111+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:121,-8.190000,-1.470000,-0.070000
06-07 17:12:32.121+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:12:32:118,661.000000
06-07 17:12:32.121+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.121+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:126,-0.280000,-1.470000,-1.820000
06-07 17:12:32.121+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.121+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:32.131+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:132,-0.630000,-0.840000,-2.450000
06-07 17:12:32.131+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.131+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:32:86,1.263654,-0.515525,9.711220
06-07 17:12:32.131+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:32.131+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:136,-4.340000,-0.490000,-1.680000
06-07 17:12:32.131+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.131+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:141,-2.380000,1.120000,-1.330000
06-07 17:12:32.141+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.141+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:146,-0.700000,1.960000,-1.400000
06-07 17:12:32.141+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.141+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:32:112,0.577507,-0.123841,-0.272225
06-07 17:12:32.141+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:150,1.260000,1.400000,-3.080000
06-07 17:12:32.141+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.151+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:154,-3.850000,-0.560000,-3.080000
06-07 17:12:32.151+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.151+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:32.151+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:159,-2.870000,-3.780000,-0.630000
06-07 17:12:32.151+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.151+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:32:134,1.828116,-0.196211,9.762716
06-07 17:12:32.161+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:32.161+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:32:146,1.291994,-0.544267,9.705921
06-07 17:12:32.161+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:163,-1.750000,-1.330000,-0.490000
06-07 17:12:32.161+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.161+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:32.161+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:169,-1.190000,2.380000,0.350000
06-07 17:12:32.161+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.171+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:173,-3.080000,3.010000,1.470000
06-07 17:12:32.171+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.171+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:178,-3.360000,0.070000,-1.540000
06-07 17:12:32.171+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.181+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:32:160,0.277698,-0.363548,-0.177756
06-07 17:12:32.181+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:32.181+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:182,-1.610000,-1.190000,-1.470000
06-07 17:12:32.181+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.181+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:187,-2.590000,-1.050000,0.140000
06-07 17:12:32.181+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.191+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:192,-3.010000,-0.490000,1.400000
06-07 17:12:32.191+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.191+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:197,-3.920000,-1.610000,1.120000
06-07 17:12:32.191+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:32:187,0.169604,-0.321165,-0.097148
06-07 17:12:32.191+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:32:168,1.677369,-0.480957,9.466006
06-07 17:12:32.201+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:32:175,1.301403,-0.537887,9.705020
06-07 17:12:32.201+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:32.201+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:32.201+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:32:209,1.450050,-0.777667,9.549755
06-07 17:12:32.211+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.211+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:216,-3.360000,0.630000,2.800000
06-07 17:12:32.211+0200 W/CAPI_APPFW_APP_CONTROL(17793): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:32.211+0200 I/utils   (17793): specific action
06-07 17:12:32.211+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:32.211+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(17793), cmd(0)
06-07 17:12:32.211+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:32.221+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.221+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:32:208,1.313310,-0.535713,9.703536
06-07 17:12:32.231+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:32.231+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:32.231+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:232,-2.590000,0.280000,0.700000
06-07 17:12:32.231+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:32:224,0.179219,-0.235821,0.199852
06-07 17:12:32.241+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:32.241+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.251+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:32:239,1.392623,-0.792024,9.621540
06-07 17:12:32.251+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:32:253,0.201128,0.139880,0.142937
06-07 17:12:32.251+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:32:242,1.329864,-0.536229,9.701253
06-07 17:12:32.251+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:32.251+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:253,-2.520000,0.910000,-0.910000
06-07 17:12:32.251+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:32.261+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:32.261+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.271+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:272,-2.240000,0.140000,-0.700000
06-07 17:12:32.271+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:32:275,0.227611,0.071287,-0.042802
06-07 17:12:32.281+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:32:268,1.442872,-0.751346,9.911072
06-07 17:12:32.281+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:32:265,1.341503,-0.546232,9.699092
06-07 17:12:32.281+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:32.281+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.281+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:32.281+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:32.281+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:291,-1.610000,-2.100000,0.630000
06-07 17:12:32.291+0200 I/heartrate(17619): es.ugr.frailty.heartrate - capturing data
06-07 17:12:32.291+0200 I/heartrate(17619): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:12:32:299,77
06-07 17:12:32.301+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:32:291,1.348122,-0.550265,9.697947
06-07 17:12:32.301+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:32:295,0.184597,0.172004,0.049609
06-07 17:12:32.301+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:32:294,1.493121,-0.404387,9.848858
06-07 17:12:32.301+0200 W/CAPI_APPFW_APP_CONTROL(17731): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:32.301+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:32.301+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(17731), cmd(0)
06-07 17:12:32.311+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:12:32.311+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.311+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:12:32:318,659.000000
06-07 17:12:32.311+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:319,-3.640000,0.280000,3.010000
06-07 17:12:32.311+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:32.321+0200 I/utils   (17731): specific action
06-07 17:12:32.321+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:32.321+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:32.321+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.331+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:32:331,0.199150,-0.128976,0.106927
06-07 17:12:32.331+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:331,-2.590000,2.730000,3.150000
06-07 17:12:32.331+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:32:326,1.347217,-0.554215,9.697847
06-07 17:12:32.331+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:32.331+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:32:332,1.529014,-0.466600,9.662218
06-07 17:12:32.341+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:32.341+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:32.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:12:32.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:12:32.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:12:32.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:12:32.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:12:32.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:12:32.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:12:32.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:12:32.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:12:32.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:12:32.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:12:32.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:12:32.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391552350,000000, pattern:[H:mm][0;m
06-07 17:12:32.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:12:32.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:12:32.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:12:32.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:12:32.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:12:32.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:12][0;m
06-07 17:12:32.351+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.351+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:32:347,0.218617,-0.085473,0.085160
06-07 17:12:32.351+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:32:344,1.355869,-0.551489,9.696796
06-07 17:12:32.351+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:32.351+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:32.361+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:356,-2.870000,5.880000,3.570000
06-07 17:12:32.361+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:32:349,1.497907,-0.363709,9.753145
06-07 17:12:32.361+0200 W/CAPI_APPFW_APP_CONTROL(17664): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:32.371+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:32.371+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(17664), cmd(0)
06-07 17:12:32.371+0200 I/utils   (17664): specific action
06-07 17:12:32.371+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:32.371+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.371+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:32:365,1.374048,-0.553534,9.694120
06-07 17:12:32.371+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:32.381+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:32:369,0.070821,-0.165189,-0.026158
06-07 17:12:32.381+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:32.391+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:380,-3.220000,3.780000,0.980000
06-07 17:12:32.391+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.391+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:32:390,-0.045521,0.209648,-0.045200
06-07 17:12:32.391+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:32:388,1.390662,-0.559654,9.691400
06-07 17:12:32.391+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:32:379,1.529014,-0.665205,9.808180
06-07 17:12:32.391+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:32.401+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:32.401+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:32.401+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:396,-5.180000,1.050000,3.010000
06-07 17:12:32.401+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:32:410,0.101360,0.111209,0.087456
06-07 17:12:32.411+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:32:402,1.560120,-0.631705,9.784252
06-07 17:12:32.411+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:32:408,1.391160,-0.558633,9.691387
06-07 17:12:32.411+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:32.411+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:32.411+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.421+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:32.421+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:423,-14.910000,-3.290000,5.880000
06-07 17:12:32.421+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.431+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:32:422,1.418944,-0.715454,9.671788
06-07 17:12:32.431+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:32:426,0.245893,-0.049457,0.161916
06-07 17:12:32.431+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:32:427,1.393367,-0.558948,9.691052
06-07 17:12:32.431+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:32.431+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:32.441+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:433,-22.469999,3.150000,14.560000
06-07 17:12:32.441+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:32:449,0.092888,0.045198,0.119174
06-07 17:12:32.441+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:32.451+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:32:453,1.403417,-0.571843,9.688849
06-07 17:12:32.451+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:32:445,1.301696,-0.344566,9.652647
06-07 17:12:32.451+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:32.451+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:32.451+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.461+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:32.461+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:463,-24.500000,6.930000,18.900000
06-07 17:12:32.461+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:32:464,1.457229,-0.440279,9.784252
06-07 17:12:32.461+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:32:460,0.030177,0.111175,-0.120096
06-07 17:12:32.461+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:32:467,1.412732,-0.576802,9.687201
06-07 17:12:32.471+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:32.471+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:32.471+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.471+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:32.471+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:478,-25.270000,2.590000,14.700000
06-07 17:12:32.471+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:32:481,1.619941,-0.602991,9.856036
06-07 17:12:32.481+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:32:485,1.423965,-0.573276,9.685766
06-07 17:12:32.481+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:32:478,0.030362,-0.132577,0.069271
06-07 17:12:32.481+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:32.481+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:32.481+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.491+0200 I/heartrate(17619): es.ugr.frailty.heartrate - capturing data
06-07 17:12:32.491+0200 I/heartrate(17619): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:12:32:499,77
06-07 17:12:32.491+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:32.501+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:495,-25.969999,4.270000,11.340000
06-07 17:12:32.501+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:32:507,1.433131,-0.573863,9.684380
06-07 17:12:32.501+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:32:505,1.483550,-0.514457,9.810574
06-07 17:12:32.511+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.511+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:12:32.511+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:12:32:518,655.000000
06-07 17:12:32.511+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:32:493,0.075347,-0.038327,0.174366
06-07 17:12:32.511+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:32.521+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:517,-29.680000,6.790000,8.680000
06-07 17:12:32.521+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:32.521+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:32.531+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.531+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:32:535,1.453684,-0.587491,9.680498
06-07 17:12:32.531+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:32:524,0.094747,0.189164,0.185585
06-07 17:12:32.531+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:537,-29.540001,7.000000,4.480000
06-07 17:12:32.531+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:32.531+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:32:533,1.421337,-0.447458,9.571291
06-07 17:12:32.541+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:32:545,0.040442,0.125818,0.086521
06-07 17:12:32.551+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.561+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:563,-16.450001,4.340000,3.570000
06-07 17:12:32.561+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:32.561+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:32.571+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.571+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:578,-11.550000,2.940000,2.520000
06-07 17:12:32.591+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.591+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:32:575,1.463360,-0.595165,9.678571
06-07 17:12:32.591+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:32:575,1.423729,-0.691526,9.760324
06-07 17:12:32.591+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:32.601+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:32.601+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:32.601+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:32:603,0.179632,-0.100913,0.099873
06-07 17:12:32.611+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:596,-4.970000,7.280000,1.330000
06-07 17:12:32.611+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:32.611+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:32:613,1.478764,-0.610170,9.863215
06-07 17:12:32.611+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:32.611+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:32:619,1.610000,6.510000,-0.700000
06-07 17:12:32.611+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:32:621,1.507478,-0.387637,9.872787
06-07 17:12:32.621+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:32.621+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:32.621+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:32:627,1.464408,-0.447458,9.772287
06-07 17:12:32.621+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:32:611,1.472382,-0.602981,9.676719
06-07 17:12:32.621+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:32.621+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:32.631+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11177276c6f63152838435
