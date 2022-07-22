S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 11941
Date: 2018-06-07 16:52:56+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf704052d, r5   = 0xf7676f98
r6   = 0xfff620b0, r7   = 0xfff61f60
r8   = 0xf7673c18, r9   = 0x00000000
r10  = 0xfff6203c, fp   = 0xfff620b0
ip   = 0x00000001, sp   = 0xfff61f38
lr   = 0xf7040539, pc   = 0xf70a9228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    188648 KB
Buffers:     14772 KB
Cached:     127380 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11768 KB
VmRSS:       11764 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 11941 TID = 11941
11941 11946 

Maps Information
f3f0b000 f470a000 rw-p [stack:11946]
f4711000 f4713000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f471b000 f471f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4728000 f472a000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4732000 f4735000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4744000 f4749000 r-xp /usr/lib/libsystem.so.0.0.0
f4754000 f4757000 r-xp /lib/libattr.so.1.1.0
f475f000 f476f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4777000 f4780000 r-xp /usr/lib/libedbus.so.1.7.99
f4788000 f4789000 r-xp /usr/lib/libresponse.so.0.2.96
f4792000 f4797000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6039000 f613f000 r-xp /usr/lib/libicuuc.so.57.1
f6155000 f62dd000 r-xp /usr/lib/libicui18n.so.57.1
f62ed000 f62fa000 r-xp /usr/lib/libail.so.0.1.0
f6303000 f630a000 r-xp /usr/lib/libminizip.so.1.0.0
f6313000 f64bc000 r-xp /usr/lib/libcrypto.so.1.0.0
f64dc000 f6523000 r-xp /usr/lib/libssl.so.1.0.0
f652f000 f6531000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6539000 f6540000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6549000 f6550000 r-xp /lib/libcrypt-2.13.so
f6581000 f6584000 r-xp /lib/libcap.so.2.21
f658c000 f658e000 r-xp /usr/lib/libiri.so
f6596000 f65df000 r-xp /usr/lib/libmdm.so.1.2.69
f65e7000 f65ed000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f65f5000 f6618000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6622000 f6624000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f662c000 f6649000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6652000 f6656000 r-xp /usr/lib/libsmack.so.1.0.0
f665f000 f6678000 r-xp /usr/lib/libnetwork.so.0.0.0
f6681000 f6689000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6691000 f6697000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f66a0000 f66a2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f66ab000 f66bb000 r-xp /lib/libresolv-2.13.so
f66bf000 f66d7000 r-xp /usr/lib/liblzma.so.5.0.3
f66e0000 f66e2000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f66ea000 f6704000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f670c000 f673b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6744000 f6753000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f675d000 f6767000 r-xp /usr/lib/libsensord-shared.so
f6770000 f6843000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f684e000 f6864000 r-xp /lib/libz.so.1.2.5
f686c000 f6871000 r-xp /usr/lib/libffi.so.5.0.10
f6879000 f687a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6882000 f6892000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f689a000 f68b3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f68bb000 f68bd000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f68c5000 f693a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6944000 f694a000 r-xp /lib/librt-2.13.so
f6953000 f6971000 r-xp /usr/lib/libsystemd.so.0.4.0
f697b000 f697c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6984000 f69a7000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f69af000 f69b4000 r-xp /usr/lib/libxdgmime.so.1.1.0
f69bc000 f69e6000 r-xp /usr/lib/libdbus-1.so.3.8.12
f69ef000 f6a06000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a0e000 f6a77000 r-xp /lib/libm-2.13.so
f6a80000 f6b14000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b27000 f6b2c000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b34000 f6b3b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6b43000 f6b6d000 r-xp /usr/lib/libsensor.so.1.9.6
f6b76000 f6c42000 r-xp /usr/lib/libxml2.so.2.7.8
f6c4f000 f6c51000 r-xp /usr/lib/libiniparser.so.0
f6c5a000 f6c60000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c69000 f6d39000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d3a000 f6d6e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d77000 f6db3000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6dbb000 f6dbe000 r-xp /usr/lib/libbundle.so.0.1.22
f6dc6000 f6dcc000 r-xp /usr/lib/libappsvc.so.0.1.0
f6dd4000 f6e15000 r-xp /usr/lib/libeina.so.1.7.99
f6e1e000 f6e35000 r-xp /usr/lib/libecore.so.1.7.99
f6e4c000 f6e55000 r-xp /usr/lib/libvconf.so.0.2.45
f6e5d000 f6e71000 r-xp /lib/libpthread-2.13.so
f6e7c000 f6e89000 r-xp /usr/lib/libaul.so.0.1.0
f6e93000 f6e95000 r-xp /lib/libdl-2.13.so
f6e9e000 f6ea9000 r-xp /lib/libunwind.so.8.0.1
f6ed6000 f6ede000 r-xp /lib/libgcc_s-4.6.so.1
f6edf000 f7003000 r-xp /lib/libc-2.13.so
f7011000 f7013000 r-xp /usr/lib/libdlog.so.0.0.0
f701b000 f7027000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7030000 f7035000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f703d000 f704c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7054000 f7058000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7061000 f7064000 r-xp /usr/lib/libappcore-agent.so.1.1
f706c000 f706e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7076000 f707a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7082000 f709f000 r-xp /lib/ld-2.13.so
f70a8000 f70ab000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f70ab000 f70af000 r-xp /usr/lib/libsys-assert.so
f7643000 f76b4000 rw-p [heap]
fff43000 fff64000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11941)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf70a9228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7040539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6d473f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6d45c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6d51e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6d57be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6d57dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6d8c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6d871f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6d45c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6d51e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6d57be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6d57dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6d89e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6d8a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6d91f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47291fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf471c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf67ef663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6c9cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6c9e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e2eca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e29b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e2a5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e2a879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7062183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70627fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70a95c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6ef685c) [/lib/libc.so.6] + 0x1785c
29: (0xf70a8f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
-07 16:52:55.701+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:55:701,3.570000,-1.680000,0.070000
06-07 16:52:55.701+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:55:702,2.301233,-0.537398,9.517663
06-07 16:52:55.711+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:55.711+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:55.711+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:55:718,0.239945,-0.027308,0.020128
06-07 16:52:55.711+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:55:719,2.541178,-0.564706,9.537791
06-07 16:52:55.711+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:55.721+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:52:55.721+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:55:725,3.640000,-1.610000,0.280000
06-07 16:52:55.721+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:55:726,2.299348,-0.531514,9.518449
06-07 16:52:55.721+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:55.721+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:55.731+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:55:733,0.210722,0.021843,0.012163
06-07 16:52:55.731+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:55:734,2.510071,-0.509671,9.530612
06-07 16:52:55.731+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:52:55.731+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:55.741+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:55:742,5.390000,-1.540000,0.070000
06-07 16:52:55.741+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:55:742,2.288516,-0.519600,9.521717
06-07 16:52:55.741+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:55.741+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:55.751+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:55:754,2.531606,-0.461815,9.458827
06-07 16:52:55.751+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:55:753,0.243091,0.057785,-0.062890
06-07 16:52:55.751+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:55.761+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:52:55.761+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:55:763,6.300000,-1.050000,-0.140000
06-07 16:52:55.761+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:55:767,2.274173,-0.504076,9.525987
06-07 16:52:55.761+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:55.771+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:55.771+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:55:775,2.512464,-0.399601,9.451650
06-07 16:52:55.771+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:55.771+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:55:775,0.238291,0.104475,-0.074337
06-07 16:52:55.781+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:52:55.781+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:55:787,2.257278,-0.485849,9.530951
06-07 16:52:55.781+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:55.781+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:55.791+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:52:55.791+0200 I/heartrate(11839): es.ugr.frailty.heartrate: waiting for rigth values
06-07 16:52:55.791+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:55:795,2.490928,-0.416351,9.516255
06-07 16:52:55.791+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:55:784,6.440000,-0.770000,-0.420000
06-07 16:52:55.791+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:52:55.791+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:55.801+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:55:795,0.233650,0.069498,-0.014696
06-07 16:52:55.801+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:55:803,2.238792,-0.468974,9.536156
06-07 16:52:55.801+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:55:807,6.510000,-0.700000,-0.350000
06-07 16:52:55.811+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:55.811+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:52:55.811+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:52:55.811+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:55.811+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:55.811+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:55:818,2.219756,-0.449580,9.541538
06-07 16:52:55.821+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:55:818,6.790000,-1.050000,-0.140000
06-07 16:52:55.821+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:55:819,0.290422,0.112443,0.004028
06-07 16:52:55.821+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:55:823,2.529213,-0.356531,9.540184
06-07 16:52:55.821+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:52:55:825,1039.000000
06-07 16:52:55.821+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:55.821+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:55.831+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:52:55.831+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:55:835,0.347743,0.152870,-0.015711
06-07 16:52:55.831+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:55:836,2.201683,-0.428962,9.546673
06-07 16:52:55.831+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:55.841+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:55:841,6.440000,-0.770000,-0.140000
06-07 16:52:55.841+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:55:834,2.567499,-0.296710,9.525827
06-07 16:52:55.841+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:55.841+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:52:55.851+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:55.851+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:55:853,0.317959,0.115503,-0.095023
06-07 16:52:55.851+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:55.851+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:55:855,3.640000,0.210000,-0.280000
06-07 16:52:55.851+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:55:853,2.193844,-0.415769,9.549061
06-07 16:52:55.851+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:55:858,2.519642,-0.313460,9.451650
06-07 16:52:55.861+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:55.871+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:52:55.871+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:55:874,0.335369,0.147772,-0.071091
06-07 16:52:55.871+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:55.871+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:55.871+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:55:881,2.529213,-0.267996,9.477970
06-07 16:52:55.881+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:55:877,2.200680,-0.407682,9.547837
06-07 16:52:55.881+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:55:880,0.490000,-0.280000,-0.210000
06-07 16:52:55.881+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:55.891+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:52:55.891+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:55:895,0.359641,0.060723,-0.057902
06-07 16:52:55.891+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:55.891+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:55.891+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:55:901,2.560320,-0.346959,9.489935
06-07 16:52:55.901+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:55:897,2.210194,-0.403636,9.545811
06-07 16:52:55.901+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:55:900,0.560000,-0.280000,-0.210000
06-07 16:52:55.911+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:55.911+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:52:55.911+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:55.921+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:55.921+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:55:919,0.357305,0.085391,0.025480
06-07 16:52:55.921+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:55:919,2.210040,-0.395239,9.546198
06-07 16:52:55.921+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:52:55.931+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:55.931+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:55:925,1.960000,0.280000,-0.140000
06-07 16:52:55.931+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:55.941+0200 I/TDM     ( 1956): tdm_display.c: tdm_layer_unset_buffer(1602) > [7000.716306] layer(0x86a2c0) now usable
06-07 16:52:55.941+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [7000.716353] layer[0x869e10]zpos[1]
06-07 16:52:55.941+0200 I/TDM     ( 1956): tdm_display.c: tdm_layer_unset_buffer(1602) > [7000.716389] layer(0x86a310) now usable
06-07 16:52:55.941+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [7000.716406] layer[0x869f30]zpos[2]
06-07 16:52:55.941+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [7000.716428] dpms[0 -> 3]sync[1]
06-07 16:52:55.941+0200 I/TDM     ( 1956): 
06-07 16:52:55.951+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:55:926,2.567499,-0.318245,9.571291
06-07 16:52:55.961+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:55.961+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:55:937,0.300031,0.014780,-0.037121
06-07 16:52:55.961+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:55.971+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:55:969,2.510071,-0.380459,9.509077
06-07 16:52:55.981+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:55:973,0.313193,0.033991,-0.068145
06-07 16:52:55.981+0200 W/WAKEUP-SERVICE( 3285): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -147895540[0;m
06-07 16:52:55.981+0200 W/WAKEUP-SERVICE( 3285): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
06-07 16:52:55.991+0200 W/WATCH_CORE( 2865): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
06-07 16:52:55.991+0200 W/W_HOME  ( 2762): dbus.c: _dbus_message_recv_cb(204) > LCD off
06-07 16:52:55.991+0200 W/W_HOME  ( 2762): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
06-07 16:52:55.991+0200 W/W_HOME  ( 2762): gesture.c: _manual_render_disable_timer_del(157) > timer del
06-07 16:52:55.991+0200 W/W_HOME  ( 2762): gesture.c: _manual_render_enable(138) > 1
06-07 16:52:55.991+0200 W/W_HOME  ( 2762): event_manager.c: _lcd_off_cb(729) > lcd state: 0
06-07 16:52:55.991+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-07 16:52:55.991+0200 W/STARTER ( 2696): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
06-07 16:52:55.991+0200 W/STARTER ( 2696): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
06-07 16:52:55.991+0200 E/STARTER ( 2696): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
06-07 16:52:55.991+0200 E/STARTER ( 2696): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
06-07 16:52:55.991+0200 W/STARTER ( 2696): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 1
06-07 16:52:55.991+0200 W/STARTER ( 2696): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 1
06-07 16:52:55.991+0200 W/STARTER ( 2696): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] reserved app is running now. raise it.
06-07 16:52:56.001+0200 I/WIFI_EFL(10916): app_main.c: __wifi_manager_background_scan_cb(689) > [Enter]
06-07 16:52:56.021+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 16:52:56.031+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11356
06-07 16:52:56.031+0200 W/STARTER ( 2696): clock-mgr.c: _pre_lcd_off(1449) > [_pre_lcd_off:1449] [com.samsung.shealth.alert] is now running & will raise when lcd on.
06-07 16:52:56.061+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:52:56.071+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [7000.841455] dpms[3 -> 3]done
06-07 16:52:56.071+0200 I/TDM     ( 1956): 
06-07 16:52:56.081+0200 W/SHealthCommon( 2909): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
06-07 16:52:56.081+0200 I/watchface-viewer( 2865): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
06-07 16:52:56.081+0200 W/SHealthCommon( 3178): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
06-07 16:52:56.081+0200 W/SHealthService( 3178): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
06-07 16:52:56.091+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:52:56.091+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:52:56.091+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:52:56.101+0200 W/STARTER ( 2696): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
06-07 16:52:56.101+0200 W/STARTER ( 2696): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[com.samsung.shealth.alert] alpm mode[0]
06-07 16:52:56.101+0200 W/STARTER ( 2696): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 1
06-07 16:52:56.101+0200 W/STARTER ( 2696): clock-mgr.c: _post_lcd_off(1525) > [_post_lcd_off:1525] raise [com.samsung.shealth.alert] when lcd off after 20 sec.
06-07 16:52:56.101+0200 E/ALARM_MANAGER( 2696): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(7-6-2018, 16:53:16), repeat(1), interval(20), type(-1073741822)
06-07 16:52:56.101+0200 I/APP_CORE( 2762): appcore-efl.c: __do_app(453) > [APP 2762] Event: PAUSE State: RUNNING
06-07 16:52:56.101+0200 I/CAPI_APPFW_APPLICATION( 2762): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-07 16:52:56.101+0200 W/W_HOME  ( 2762): main.c: _appcore_pause_cb(488) > appcore pause
06-07 16:52:56.101+0200 W/W_HOME  ( 2762): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
06-07 16:52:56.101+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-07 16:52:56.101+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-07 16:52:56.101+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-07 16:52:56.101+0200 W/W_HOME  ( 2762): rotary.c: rotary_deattach(156) > rotary_deattach:0xee468850
06-07 16:52:56.101+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
06-07 16:52:56.101+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xee468850, elm_layout, func : 0xf7719d05
06-07 16:52:56.101+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
06-07 16:52:56.101+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
06-07 16:52:56.101+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
06-07 16:52:56.101+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf7cf54f0, elm_box, _activated_obj : 0xee468850, activated : 1
06-07 16:52:56.101+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
06-07 16:52:56.101+0200 E/wnotib  ( 2762): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
06-07 16:52:56.101+0200 I/wnotib  ( 2762): w-notification-board-broker-main.c: _wnb_handle_scroller_event(1206) > No second depth view available.
06-07 16:52:56.101+0200 W/W_HOME  ( 2762): win.c: win_back_gesture_disable_set(173) > enable back gesture
06-07 16:52:56.101+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-07 16:52:56.101+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-07 16:52:56.101+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-07 16:52:56.101+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-07 16:52:56.101+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-07 16:52:56.101+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-07 16:52:56.101+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-07 16:52:56.101+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-07 16:52:56.101+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-07 16:52:56.101+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-07 16:52:56.101+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-07 16:52:56.101+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-07 16:52:56.101+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-07 16:52:56.101+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-07 16:52:56.101+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-07 16:52:56.101+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-07 16:52:56.101+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-07 16:52:56.101+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-07 16:52:56.111+0200 I/heartrate(11839): es.ugr.frailty.heartrate: waiting for rigth values
06-07 16:52:56.111+0200 I/CAPI_NETWORK_WIFI(10916): libnetwork.c: __libnet_update_profile_iterator(227) > Wi-Fi profile count: 5
06-07 16:52:56.111+0200 I/WIFI_EFL(10916): wifi_manager.c: __update_ap_list_foreach(370) > EAP type AP skip(No SIM model).
06-07 16:52:56.111+0200 I/WIFI_EFL(10916): layout_scan.c: layout_scan_ap_list_clear_data(453) > AP data list is empty.
06-07 16:52:56.111+0200 E/EFL     (10916): elementary<10916> elm_genlist.c:6966 elm_genlist_item_prev_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
06-07 16:52:56.121+0200 E/EFL     (10916): elementary<10916> elm_genlist.c:6966 elm_genlist_item_prev_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
06-07 16:52:56.121+0200 E/EFL     (10916): elementary<10916> elm_genlist.c:6966 elm_genlist_item_prev_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
06-07 16:52:56.121+0200 E/EFL     (10916): elementary<10916> elm_genlist.c:6966 elm_genlist_item_prev_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
06-07 16:52:56.121+0200 E/EFL     (10916): elementary<10916> elm_genlist.c:6966 elm_genlist_item_prev_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
06-07 16:52:56.121+0200 E/EFL     (10916): elementary<10916> elm_genlist.c:6966 elm_genlist_item_prev_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
06-07 16:52:56.121+0200 E/EFL     (10916): elementary<10916> elm_genlist.c:6966 elm_genlist_item_prev_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
06-07 16:52:56.121+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2696].
06-07 16:52:56.121+0200 E/EFL     (10916): elementary<10916> elm_genlist.c:6966 elm_genlist_item_prev_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
06-07 16:52:56.131+0200 W/APPS    ( 2762): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
06-07 16:52:56.151+0200 E/CAPI_APPFW_APP_CONTROL( 3247): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-07 16:52:56.151+0200 W/MUSIC_CONTROL_SERVICE( 3247): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3247]   [com.samsung.w-home]register msg port [false][0m
06-07 16:52:56.151+0200 E/ALARM_MANAGER( 2466): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1614326345, next duetime: 1528383196
06-07 16:52:56.151+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(1614326345)
06-07 16:52:56.151+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1528408106), due_time(1528383196)
06-07 16:52:56.161+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:52:56.161+0200 W/WAKEUP-SERVICE( 3285): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
06-07 16:52:56.161+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
06-07 16:52:56.161+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
06-07 16:52:56.161+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 7-6-2018, 14:53:16 (UTC).
06-07 16:52:56.161+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
06-07 16:52:56.171+0200 W/SHealthCommon(11356): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
06-07 16:52:56.171+0200 W/W_INDICATOR( 2702): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
06-07 16:52:56.171+0200 W/W_INDICATOR( 2702): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
06-07 16:52:56.171+0200 E/WAKEUP-SERVICE( 3285): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
06-07 16:52:56.171+0200 W/W_INDICATOR( 2702): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-07 16:52:56.181+0200 W/W_INDICATOR( 2702): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
06-07 16:52:56.181+0200 E/WAKEUP-SERVICE( 3285): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
06-07 16:52:56.181+0200 W/W_INDICATOR( 2702): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
06-07 16:52:56.181+0200 W/W_INDICATOR( 2702): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
06-07 16:52:56.181+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
06-07 16:52:56.181+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:52:56:167,1051.000000
06-07 16:52:56.191+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:52:56.191+0200 I/heartrate(11839): es.ugr.frailty.heartrate: waiting for rigth values
06-07 16:52:56.191+0200 I/WIFI_EFL(10916): layout_scan.c: layout_scan_ap_list_update(432) > AP list update success and AP data list clear.
06-07 16:52:56.191+0200 I/WIFI_EFL(10916): layout_scan.c: layout_scan_ap_list_show(364) > AP list layout exists in naviframe.
06-07 16:52:56.191+0200 I/WIFI_EFL(10916): wifi_manager.c: _update_wifi_config_list(183) > [Enter]
06-07 16:52:56.191+0200 E/WAKEUP-SERVICE( 3285): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
06-07 16:52:56.201+0200 I/TIZEN_N_SOUND_MANAGER( 3285): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
06-07 16:52:56.201+0200 I/TIZEN_N_SOUND_MANAGER( 3285): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
06-07 16:52:56.201+0200 W/TIZEN_N_SOUND_MANAGER( 3285): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
06-07 16:52:56.201+0200 W/WAKEUP-SERVICE( 3285): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
06-07 16:52:56.201+0200 I/HIGEAR  ( 3285): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
06-07 16:52:56.211+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:52:56.211+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:55:938,1.890000,-0.070000,-0.140000
06-07 16:52:56.211+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:52:56:220,1050.000000
06-07 16:52:56.211+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:56.221+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:56.221+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:55:935,2.211235,-0.390521,9.546115
06-07 16:52:56.221+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:56.231+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:52:56.241+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:56:230,0.321333,0.006302,-0.033357
06-07 16:52:56.251+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:56:224,2.524428,-0.356531,9.477970
06-07 16:52:56.251+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:56.261+0200 E/CAPI_NETWORK_WIFI(10916): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
06-07 16:52:56.271+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:56.281+0200 W/LOCATION(11941): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 16:52:56.281+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:56:244,1.050000,-0.350000,-0.140000
06-07 16:52:56.281+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:56:246,2.217452,-0.386761,9.544827
06-07 16:52:56.281+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:56.281+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:52:56.281+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:56:288,1.330000,-0.490000,-0.280000
06-07 16:52:56.291+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:56:262,2.538785,-0.380459,9.511470
06-07 16:52:56.291+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:56:283,0.310673,0.046279,-0.001008
06-07 16:52:56.291+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:56.291+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:56.291+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:56:292,2.223326,-0.383667,9.543585
06-07 16:52:56.301+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:52:56.301+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:56.311+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:56:300,2.533999,-0.337388,9.542577
06-07 16:52:56.311+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:56.311+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:56:305,0.292402,0.096721,-0.003881
06-07 16:52:56.311+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:56.321+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:56:313,2.222455,-0.376681,9.544065
06-07 16:52:56.321+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:56:311,2.240000,-0.420000,-0.280000
06-07 16:52:56.321+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:52:56.331+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:56.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:52:56.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:52:56.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:52:56.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:52:56.331+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390376343,000000, pattern:[H:mm][0;m
06-07 16:52:56.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:52:56.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:52:56.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:52:56.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:52:56.331+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:52:56.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:52][0;m
06-07 16:52:56.341+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:56:320,2.514857,-0.279960,9.540184
06-07 16:52:56.341+0200 E/CAPI_NETWORK_WIFI(10916): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
06-07 16:52:56.351+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:56.351+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:56:326,0.315004,0.055905,-0.038565
06-07 16:52:56.351+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:56:342,2.450000,-0.840000,-0.210000
06-07 16:52:56.361+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:56:340,2.218996,-0.366972,9.545249
06-07 16:52:56.361+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:56.361+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:52:56.371+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:56.371+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:56:359,2.533999,-0.311067,9.506684
06-07 16:52:56.381+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:56.381+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:56:368,0.364847,0.099767,-0.030978
06-07 16:52:56.381+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:56.381+0200 I/servicemanager(11799): es.ugr.frailty.accelerometer alive timeout
06-07 16:52:56.391+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 16:52:56.391+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:52:56.391+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:52:56.401+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11823
06-07 16:52:56.401+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:52:56.401+0200 I/heartrate(11839): es.ugr.frailty.heartrate: waiting for rigth values
06-07 16:52:56.401+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11823)
06-07 16:52:56.401+0200 I/servicemanager(11799): es.ugr.frailty.accelerometer launch request sent!
06-07 16:52:56.401+0200 I/servicemanager(11799): App control destroyed.
06-07 16:52:56.401+0200 I/servicemanager(11799): es.ugr.frailty.gyroscope alive timeout
06-07 16:52:56.401+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 16:52:56.401+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:52:56.401+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:52:56.411+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:52:56.411+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:52:56:418,1052.000000
06-07 16:52:56.421+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11827
06-07 16:52:56.421+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11827)
06-07 16:52:56.421+0200 I/servicemanager(11799): es.ugr.frailty.gyroscope launch request sent!
06-07 16:52:56.421+0200 I/servicemanager(11799): App control destroyed.
06-07 16:52:56.421+0200 I/servicemanager(11799): es.ugr.frailty.heartrate alive timeout
06-07 16:52:56.421+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 16:52:56.421+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:52:56.421+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:52:56.431+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11839
06-07 16:52:56.441+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:52:56.441+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(11839), cmd(0)
06-07 16:52:56.441+0200 W/CAPI_APPFW_APP_CONTROL(11839): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:52:56.441+0200 I/utils   (11839): specific action
06-07 16:52:56.441+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11839)
06-07 16:52:56.441+0200 I/servicemanager(11799): es.ugr.frailty.heartrate launch request sent!
06-07 16:52:56.441+0200 I/servicemanager(11799): App control destroyed.
06-07 16:52:56.441+0200 I/servicemanager(11799): es.ugr.frailty.location alive timeout
06-07 16:52:56.441+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 16:52:56.441+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:52:56.441+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:52:56.451+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11941
06-07 16:52:56.451+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11941)
06-07 16:52:56.451+0200 I/servicemanager(11799): es.ugr.frailty.location launch request sent!
06-07 16:52:56.451+0200 I/servicemanager(11799): App control destroyed.
06-07 16:52:56.451+0200 I/servicemanager(11799): es.ugr.frailty.linearacceleration alive timeout
06-07 16:52:56.451+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 16:52:56.461+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:52:56.461+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:52:56.471+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11854
06-07 16:52:56.471+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11854)
06-07 16:52:56.471+0200 I/servicemanager(11799): es.ugr.frailty.linearacceleration launch request sent!
06-07 16:52:56.471+0200 I/servicemanager(11799): App control destroyed.
06-07 16:52:56.471+0200 I/servicemanager(11799): es.ugr.frailty.gravity alive timeout
06-07 16:52:56.471+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 16:52:56.471+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:52:56.471+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:52:56.481+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11864
06-07 16:52:56.491+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11864)
06-07 16:52:56.491+0200 I/servicemanager(11799): es.ugr.frailty.gravity launch request sent!
06-07 16:52:56.491+0200 I/servicemanager(11799): App control destroyed.
06-07 16:52:56.491+0200 I/servicemanager(11799): es.ugr.frailty.pressure alive timeout
06-07 16:52:56.491+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 16:52:56.491+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:52:56.491+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:52:56.501+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11875
06-07 16:52:56.501+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:52:56.501+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(11875), cmd(0)
06-07 16:52:56.501+0200 W/CAPI_APPFW_APP_CONTROL(11875): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:52:56.501+0200 I/utils   (11875): specific action
06-07 16:52:56.501+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11875)
06-07 16:52:56.501+0200 I/servicemanager(11799): es.ugr.frailty.pressure launch request sent!
06-07 16:52:56.501+0200 I/servicemanager(11799): App control destroyed.
06-07 16:52:56.501+0200 I/servicemanager(11799): es.ugr.frailty.light alive timeout
06-07 16:52:56.501+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 16:52:56.501+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:52:56.501+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:52:56.511+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11887
06-07 16:52:56.511+0200 W/CAPI_APPFW_APP_CONTROL(11887): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:52:56.511+0200 I/utils   (11887): specific action
06-07 16:52:56.521+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:52:56.521+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(11887), cmd(0)
06-07 16:52:56.521+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11887)
06-07 16:52:56.521+0200 I/servicemanager(11799): es.ugr.frailty.light launch request sent!
06-07 16:52:56.521+0200 I/servicemanager(11799): App control destroyed.
06-07 16:52:56.521+0200 I/servicemanager(11799): es.ugr.frailty.pedometer alive timeout
06-07 16:52:56.521+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 16:52:56.521+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:52:56.521+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:52:56.531+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11894
06-07 16:52:56.531+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:52:56.531+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(11894), cmd(0)
06-07 16:52:56.531+0200 W/CAPI_APPFW_APP_CONTROL(11894): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:52:56.531+0200 I/utils   (11894): specific action
06-07 16:52:56.531+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11894)
06-07 16:52:56.531+0200 I/servicemanager(11799): es.ugr.frailty.pedometer launch request sent!
06-07 16:52:56.531+0200 I/servicemanager(11799): App control destroyed.
06-07 16:52:56.541+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:56:377,2.221794,-0.360585,9.544841
06-07 16:52:56.541+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:52:56.541+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:56:381,1.820000,-1.190000,-0.420000
06-07 16:52:56.541+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:56:388,2.586641,-0.260818,9.513863
06-07 16:52:56.541+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:56.551+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:56:555,2.218422,-0.350204,9.546012
06-07 16:52:56.551+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:56:397,0.298827,0.125278,-0.001042
06-07 16:52:56.551+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:56.561+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:56.561+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:56:566,2.517249,-0.224925,9.544970
06-07 16:52:56.561+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:56.561+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:56:562,2.730000,-0.700000,-0.210000
06-07 16:52:56.561+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:56.561+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:52:56.571+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:56:571,2.541178,-0.284746,9.497113
06-07 16:52:56.571+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:56.571+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:56:577,2.519642,-0.318245,9.528220
06-07 16:52:56.571+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:56:575,2.213052,-0.339410,9.547648
06-07 16:52:56.571+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:52:56.571+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:56.581+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:56:582,2.555535,-0.224925,9.485149
06-07 16:52:56.581+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:56.581+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:56:587,2.545963,-0.236889,9.556933
06-07 16:52:56.581+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:56.581+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:56:573,2.240000,-0.350000,-0.210000
06-07 16:52:56.581+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:56.581+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:56:569,0.328126,0.054664,-0.050535
06-07 16:52:56.581+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:56.591+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:56:592,2.560320,-0.244068,9.509077
06-07 16:52:56.591+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:56.591+0200 W/CRASH_MANAGER(11751): worker.c: worker_job(1205) > 11119416c6f63152838317
