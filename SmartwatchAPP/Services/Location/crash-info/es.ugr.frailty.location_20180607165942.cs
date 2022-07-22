S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 13997
Date: 2018-06-07 16:59:42+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf720052d, r5   = 0xf74bbf98
r6   = 0xff91a770, r7   = 0xff91a620
r8   = 0xf74b8c18, r9   = 0x00000000
r10  = 0xff91a6fc, fp   = 0xff91a770
ip   = 0x00000001, sp   = 0xff91a5f8
lr   = 0xf7200539, pc   = 0xf7269228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     93408 KB
Buffers:      7828 KB
Cached:      48120 KB
VmPeak:      53460 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11536 KB
VmRSS:       11536 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 13997 TID = 13997
13997 14001 

Maps Information
f40cb000 f48ca000 rw-p [stack:14001]
f48d1000 f48d3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f48db000 f48df000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f48e8000 f48ea000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f48f2000 f48f5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4904000 f4909000 r-xp /usr/lib/libsystem.so.0.0.0
f4914000 f4917000 r-xp /lib/libattr.so.1.1.0
f491f000 f492f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4937000 f4940000 r-xp /usr/lib/libedbus.so.1.7.99
f4948000 f4949000 r-xp /usr/lib/libresponse.so.0.2.96
f4952000 f4957000 r-xp /usr/lib/libproc-stat.so.0.2.96
f61f9000 f62ff000 r-xp /usr/lib/libicuuc.so.57.1
f6315000 f649d000 r-xp /usr/lib/libicui18n.so.57.1
f64ad000 f64ba000 r-xp /usr/lib/libail.so.0.1.0
f64c3000 f64ca000 r-xp /usr/lib/libminizip.so.1.0.0
f64d3000 f667c000 r-xp /usr/lib/libcrypto.so.1.0.0
f669c000 f66e3000 r-xp /usr/lib/libssl.so.1.0.0
f66ef000 f66f1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f66f9000 f6700000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6709000 f6710000 r-xp /lib/libcrypt-2.13.so
f6741000 f6744000 r-xp /lib/libcap.so.2.21
f674c000 f674e000 r-xp /usr/lib/libiri.so
f6756000 f679f000 r-xp /usr/lib/libmdm.so.1.2.69
f67a7000 f67ad000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f67b5000 f67d8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f67e2000 f67e4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f67ec000 f6809000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6812000 f6816000 r-xp /usr/lib/libsmack.so.1.0.0
f681f000 f6838000 r-xp /usr/lib/libnetwork.so.0.0.0
f6841000 f6849000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6851000 f6857000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6860000 f6862000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f686b000 f687b000 r-xp /lib/libresolv-2.13.so
f687f000 f6897000 r-xp /usr/lib/liblzma.so.5.0.3
f68a0000 f68a2000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f68aa000 f68c4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f68cc000 f68fb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6904000 f6913000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f691d000 f6927000 r-xp /usr/lib/libsensord-shared.so
f6930000 f6a03000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a0e000 f6a24000 r-xp /lib/libz.so.1.2.5
f6a2c000 f6a31000 r-xp /usr/lib/libffi.so.5.0.10
f6a39000 f6a3a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a42000 f6a52000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a5a000 f6a73000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a7b000 f6a7d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a85000 f6afa000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b04000 f6b0a000 r-xp /lib/librt-2.13.so
f6b13000 f6b31000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b3b000 f6b3c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b44000 f6b67000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b6f000 f6b74000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b7c000 f6ba6000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6baf000 f6bc6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6bce000 f6c37000 r-xp /lib/libm-2.13.so
f6c40000 f6cd4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ce7000 f6cec000 r-xp /usr/lib/libctx-client.so.0.8.3
f6cf4000 f6cfb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d03000 f6d2d000 r-xp /usr/lib/libsensor.so.1.9.6
f6d36000 f6e02000 r-xp /usr/lib/libxml2.so.2.7.8
f6e0f000 f6e11000 r-xp /usr/lib/libiniparser.so.0
f6e1a000 f6e20000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e29000 f6ef9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6efa000 f6f2e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f37000 f6f73000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f7b000 f6f7e000 r-xp /usr/lib/libbundle.so.0.1.22
f6f86000 f6f8c000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f94000 f6fd5000 r-xp /usr/lib/libeina.so.1.7.99
f6fde000 f6ff5000 r-xp /usr/lib/libecore.so.1.7.99
f700c000 f7015000 r-xp /usr/lib/libvconf.so.0.2.45
f701d000 f7031000 r-xp /lib/libpthread-2.13.so
f703c000 f7049000 r-xp /usr/lib/libaul.so.0.1.0
f7053000 f7055000 r-xp /lib/libdl-2.13.so
f705e000 f7069000 r-xp /lib/libunwind.so.8.0.1
f7096000 f709e000 r-xp /lib/libgcc_s-4.6.so.1
f709f000 f71c3000 r-xp /lib/libc-2.13.so
f71d1000 f71d3000 r-xp /usr/lib/libdlog.so.0.0.0
f71db000 f71e7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71f0000 f71f5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f71fd000 f720c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7214000 f7218000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7221000 f7224000 r-xp /usr/lib/libappcore-agent.so.1.1
f722c000 f722e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7236000 f723a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7242000 f725f000 r-xp /lib/ld-2.13.so
f7268000 f726b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f726b000 f726f000 r-xp /usr/lib/libsys-assert.so
f7488000 f74f9000 rw-p [heap]
ff8fb000 ff91c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13997)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7269228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7200539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f073f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f05c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f11e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f17be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f17dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f4c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f471f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f05c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f11e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f17be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f17dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f49e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f4a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f51f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48e91fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf48dc171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf69af663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e5cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e5e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6feeca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6fe9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6fea5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6fea879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7222183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72227fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72695c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf70b685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7268f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
9:41:751,2.318645,-0.813560,9.561719
06-07 16:59:41.751+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:41:751,0.128858,0.025764,0.039600
06-07 16:59:41.751+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:41.751+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:41.751+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:41:757,2.193089,-0.835534,9.521692
06-07 16:59:41.751+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:41:760,1.050000,-0.350000,-0.770000
06-07 16:59:41.761+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:41.761+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:41.761+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:41:770,0.168627,0.093759,-0.067650
06-07 16:59:41.771+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:41:771,2.361716,-0.741775,9.454042
06-07 16:59:41.771+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:41.771+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:59:41.771+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:41.771+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:59:41:777,83
06-07 16:59:41.771+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:41:779,2.197577,-0.827788,9.521335
06-07 16:59:41.781+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:41:776,1.610000,-0.420000,-0.770000
06-07 16:59:41.791+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:59:41.791+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:41.791+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:59:41:796,806.000000
06-07 16:59:41.791+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:41:797,0.118675,0.148226,0.028420
06-07 16:59:41.791+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:41.801+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:41.801+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:41.801+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:41:804,2.316252,-0.679562,9.549755
06-07 16:59:41.801+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:41.811+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:41.811+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:41:806,2.198642,-0.817127,9.522009
06-07 16:59:41.811+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:41:811,0.151110,0.139958,-0.020110
06-07 16:59:41.811+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:41:816,1.610000,-0.420000,-0.490000
06-07 16:59:41.811+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:41.811+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:41.821+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:41:823,2.201680,-0.808184,9.522071
06-07 16:59:41.821+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:41:813,2.349752,-0.677169,9.501899
06-07 16:59:41.821+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:41.821+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:41.831+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:41:831,0.155250,0.042481,0.077933
06-07 16:59:41.831+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:41:823,0.910000,0.350000,-0.560000
06-07 16:59:41.831+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:41.831+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:41.831+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer alive timeout
06-07 16:59:41.831+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 16:59:41.831+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:41.841+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:41.841+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:41:833,2.356930,-0.765703,9.600004
06-07 16:59:41.841+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:41.851+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:41:840,0.280000,-0.490000,-0.210000
06-07 16:59:41.851+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:41.851+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13850
06-07 16:59:41.851+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13850)
06-07 16:59:41.851+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer launch request sent!
06-07 16:59:41.851+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:41.851+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope alive timeout
06-07 16:59:41.851+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 16:59:41.851+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:41.851+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:41:851,2.323431,-0.768096,9.566505
06-07 16:59:41.851+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:41.851+0200 W/CAPI_APPFW_APP_CONTROL(13850): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:41.851+0200 I/utils   (13850): specific action
06-07 16:59:41.861+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:41:858,0.560000,-0.210000,-0.490000
06-07 16:59:41.861+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:41.861+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:41.861+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13929
06-07 16:59:41.871+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13929)
06-07 16:59:41.871+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope launch request sent!
06-07 16:59:41.871+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:41.871+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:41.871+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(13850), cmd(0)
06-07 16:59:41.871+0200 I/servicemanager(12566): es.ugr.frailty.heartrate alive timeout
06-07 16:59:41.871+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 16:59:41.871+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:41.871+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:41.871+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:41:869,0.115964,0.037189,0.045529
06-07 16:59:41.871+0200 W/CAPI_APPFW_APP_CONTROL(13929): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:41.871+0200 I/utils   (13929): specific action
06-07 16:59:41.871+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:41.881+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:41:871,2.304288,-0.832702,9.528220
06-07 16:59:41.881+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12595
06-07 16:59:41.881+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12595)
06-07 16:59:41.891+0200 I/servicemanager(12566): es.ugr.frailty.heartrate launch request sent!
06-07 16:59:41.891+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:41.891+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:41.891+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(13929), cmd(0)
06-07 16:59:41.891+0200 I/servicemanager(12566): es.ugr.frailty.location alive timeout
06-07 16:59:41.891+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 16:59:41.891+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:41.891+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12595), cmd(0)
06-07 16:59:41.891+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:41.891+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:41.891+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:41.891+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:41.891+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:41:899,0.093415,-0.030705,0.007756
06-07 16:59:41.901+0200 W/CAPI_APPFW_APP_CONTROL(12595): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:41.901+0200 I/utils   (12595): specific action
06-07 16:59:41.901+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13997
06-07 16:59:41.901+0200 W/CAPI_APPFW_APP_CONTROL(13997): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:41.901+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13997)
06-07 16:59:41.901+0200 I/servicemanager(12566): es.ugr.frailty.location launch request sent!
06-07 16:59:41.901+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:41.901+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration alive timeout
06-07 16:59:41.901+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:41.901+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(13997), cmd(0)
06-07 16:59:41.901+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 16:59:41.901+0200 I/utils   (13997): specific action
06-07 16:59:41.901+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:41.901+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:41:884,0.420000,-0.350000,-0.700000
06-07 16:59:41.901+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:41.911+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:41.911+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:41:898,2.306681,-0.839881,9.466006
06-07 16:59:41.911+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:41.911+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:41:919,-0.350000,0.490000,-1.050000
06-07 16:59:41.921+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:41.921+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13943
06-07 16:59:41.921+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13943)
06-07 16:59:41.921+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration launch request sent!
06-07 16:59:41.921+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:41.921+0200 I/servicemanager(12566): es.ugr.frailty.gravity alive timeout
06-07 16:59:41.921+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:41:842,2.207467,-0.805285,9.520976
06-07 16:59:41.921+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 16:59:41.921+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:41.921+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:41.931+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:41.931+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:41:932,2.354537,-0.823131,9.542577
06-07 16:59:41.931+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:41:928,0.091869,-0.037498,-0.053509
06-07 16:59:41.941+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13909
06-07 16:59:41.941+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13909)
06-07 16:59:41.941+0200 I/servicemanager(12566): es.ugr.frailty.gravity launch request sent!
06-07 16:59:41.941+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:41.941+0200 I/servicemanager(12566): es.ugr.frailty.pressure alive timeout
06-07 16:59:41.941+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 16:59:41.941+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:41.941+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(13909), cmd(0)
06-07 16:59:41.941+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:41.941+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:41.941+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:41:943,0.350000,0.280000,-0.840000
06-07 16:59:41.951+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:41.951+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:41:956,0.134667,-0.018625,0.024419
06-07 16:59:41.951+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:41.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12603
06-07 16:59:41.951+0200 W/CAPI_APPFW_APP_CONTROL(12603): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:41.951+0200 I/utils   (12603): specific action
06-07 16:59:41.951+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12603)
06-07 16:59:41.951+0200 I/servicemanager(12566): es.ugr.frailty.pressure launch request sent!
06-07 16:59:41.951+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:41.951+0200 I/servicemanager(12566): es.ugr.frailty.light alive timeout
06-07 16:59:41.951+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 16:59:41.951+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:41.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(12603), cmd(0)
06-07 16:59:41.951+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:41.961+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:41.961+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:41.961+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:41:970,1.680000,0.420000,-0.910000
06-07 16:59:41.971+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:41:961,2.414358,-0.801596,9.578469
06-07 16:59:41.971+0200 W/CAPI_APPFW_APP_CONTROL(13909): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:41.971+0200 I/utils   (13909): specific action
06-07 16:59:41.971+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:41.971+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:59:41.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12614
06-07 16:59:41.971+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12614)
06-07 16:59:41.971+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 16:59:41.971+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:41.971+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 16:59:41.971+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 16:59:41.971+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:41.971+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:41.971+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:59:41:978,83
06-07 16:59:41.971+0200 W/CAPI_APPFW_APP_CONTROL(12614): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:41.971+0200 I/utils   (12614): specific action
06-07 16:59:41.971+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:41.981+0200 W/CAPI_APPFW_APP_CONTROL(13943): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:41.981+0200 I/utils   (13943): specific action
06-07 16:59:41.981+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:41.981+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:41:987,0.190036,0.002502,0.061316
06-07 16:59:41.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 16:59:41.981+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:41.981+0200 I/utils   (12618): specific action
06-07 16:59:41.981+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:41.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(13943), cmd(0)
06-07 16:59:41.981+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:41.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(12614), cmd(0)
06-07 16:59:41.981+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:41.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(12618), cmd(0)
06-07 16:59:41.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 16:59:41.981+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 16:59:41.981+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:41.991+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:59:41.991+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:41.991+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:59:41:997,806.000000
06-07 16:59:41.991+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:41:997,1.820000,0.560000,-0.700000
06-07 16:59:41.991+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:41.991+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:41:977,2.210873,-0.801997,9.520464
06-07 16:59:41.991+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.001+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:2,0.980000,0.700000,-0.770000
06-07 16:59:42.001+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.001+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:41:985,2.411965,-0.727418,9.611969
06-07 16:59:42.001+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:42.001+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:5,2.214813,-0.802383,9.519515
06-07 16:59:42.001+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.001+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:7,0.910000,1.330000,-0.840000
06-07 16:59:42.011+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.011+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:42:13,2.285146,-0.739382,9.523434
06-07 16:59:42.011+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:42.001+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.011+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:17,0.840000,2.030000,-0.840000
06-07 16:59:42.011+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:42:19,2.301895,-0.698704,9.446864
06-07 16:59:42.011+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:42.011+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:21,0.185134,0.072301,0.095034
06-07 16:59:42.021+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:42:25,2.268396,-0.612563,9.485149
06-07 16:59:42.021+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:15,2.219870,-0.804506,9.518158
06-07 16:59:42.021+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:42.021+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.021+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:31,0.057494,0.052279,0.006017
06-07 16:59:42.021+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:42:31,2.344966,-0.669990,9.619147
06-07 16:59:42.031+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.031+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.031+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:36,1.470000,1.260000,0.140000
06-07 16:59:42.031+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.031+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:37,2.224322,-0.804098,9.517153
06-07 16:59:42.031+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.031+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:40,0.075713,0.087846,-0.071321
06-07 16:59:42.031+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.041+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:42,2.226831,-0.799719,9.516935
06-07 16:59:42.041+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.041+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:45,0.043312,0.167339,-0.033839
06-07 16:59:42.041+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.041+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:42.041+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.051+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:51,2.730000,0.420000,0.560000
06-07 16:59:42.051+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:49,0.124174,0.099177,0.098284
06-07 16:59:42.051+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.051+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:62,0.134331,0.095377,0.175863
06-07 16:59:42.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:59:42.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:59:42.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:59:42.061+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:42:51,2.352145,-0.665205,9.698111
06-07 16:59:42.061+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:48,2.227652,-0.791661,9.517417
06-07 16:59:42.061+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.061+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.061+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:71,2.450000,-0.210000,0.980000
06-07 16:59:42.061+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:71,0.111085,0.089334,0.061269
06-07 16:59:42.061+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.071+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:42.071+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:75,2.226183,-0.786550,9.518185
06-07 16:59:42.071+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.081+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:42:76,2.323431,-0.660419,9.585647
06-07 16:59:42.091+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.101+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:100,2.800000,-0.980000,1.470000
06-07 16:59:42.101+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:42.101+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.111+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.111+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:117,0.143317,0.010698,0.059729
06-07 16:59:42.111+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.121+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:123,0.087559,-0.090836,-0.048785
06-07 16:59:42.121+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:111,3.220000,0.420000,1.540000
06-07 16:59:42.121+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:42:108,2.352145,-0.729811,9.585647
06-07 16:59:42.131+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.131+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:42.131+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:138,4.620000,0.420000,1.890000
06-07 16:59:42.131+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.141+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:145,0.187479,0.022098,0.030896
06-07 16:59:42.141+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:84,2.225084,-0.779901,9.518989
06-07 16:59:42.141+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.151+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.151+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.151+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:42:141,2.294717,-0.825524,9.477970
06-07 16:59:42.151+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:156,0.195645,0.023664,0.044971
06-07 16:59:42.151+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:42.151+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:153,2.220792,-0.769167,9.520864
06-07 16:59:42.151+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.161+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:161,5.040000,0.420000,1.680000
06-07 16:59:42.161+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:165,2.217813,-0.760582,9.522247
06-07 16:59:42.161+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.161+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:42:165,2.388037,-0.710668,9.559326
06-07 16:59:42.161+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:170,0.180943,0.062451,0.051561
06-07 16:59:42.161+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.171+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.171+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:59:42.171+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:175,2.212346,-0.749753,9.524378
06-07 16:59:42.171+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.171+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:59:42:178,83
06-07 16:59:42.181+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:181,2.208827,-0.740509,9.525918
06-07 16:59:42.181+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.181+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:42.181+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:187,2.207158,-0.734688,9.526755
06-07 16:59:42.181+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.191+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:59:42.191+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:59:42:198,811.000000
06-07 16:59:42.191+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.201+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:184,4.830000,0.350000,1.890000
06-07 16:59:42.201+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:202,0.149980,0.102278,0.053182
06-07 16:59:42.201+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:192,2.200558,-0.732766,9.528430
06-07 16:59:42.201+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.201+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:42:192,2.388037,-0.698704,9.576077
06-07 16:59:42.201+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.201+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.211+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:210,0.124893,0.082244,0.131691
06-07 16:59:42.211+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:42.211+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:213,2.192392,-0.722368,9.531106
06-07 16:59:42.211+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.211+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:221,2.183165,-0.710906,9.534085
06-07 16:59:42.221+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.221+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:214,4.060000,-0.140000,2.310000
06-07 16:59:42.221+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:226,2.173451,-0.698091,9.537251
06-07 16:59:42.221+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.221+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.221+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:42:220,2.364109,-0.648455,9.585647
06-07 16:59:42.231+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:231,0.087823,0.015350,0.036338
06-07 16:59:42.231+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.231+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:232,2.870000,-0.560000,2.590000
06-07 16:59:42.231+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:42.231+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:238,2.165038,-0.685235,9.540097
06-07 16:59:42.231+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.241+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:243,2.159037,-0.675769,9.542131
06-07 16:59:42.241+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.241+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.241+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.251+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:252,0.155010,0.000293,0.018076
06-07 16:59:42.251+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:42:242,2.323431,-0.595813,9.590433
06-07 16:59:42.251+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:248,2.154064,-0.670283,9.543643
06-07 16:59:42.251+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.251+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:42.251+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:261,2.153888,-0.666465,9.543950
06-07 16:59:42.261+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:42:265,2.289931,-0.602991,9.671788
06-07 16:59:42.261+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.261+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:255,2.590000,-0.630000,2.170000
06-07 16:59:42.261+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.271+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:271,0.205435,-0.032239,0.020162
06-07 16:59:42.271+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.271+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:42.271+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:273,2.170000,-0.840000,2.030000
06-07 16:59:42.271+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:277,2.154591,-0.663652,9.543987
06-07 16:59:42.271+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.281+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:42:280,2.246860,-0.660419,9.578469
06-07 16:59:42.291+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.291+0200 W/LOCATION(13997): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 16:59:42.291+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:296,0.214303,-0.011124,0.020124
06-07 16:59:42.291+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.301+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:304,2.154981,-0.660467,9.544120
06-07 16:59:42.301+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.301+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:42.301+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:285,2.450000,-0.700000,2.380000
06-07 16:59:42.301+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:310,0.149307,0.012012,0.027171
06-07 16:59:42.311+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.311+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:42:312,2.309074,-0.669990,9.561719
06-07 16:59:42.311+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.311+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:315,2.155118,-0.657277,9.544310
06-07 16:59:42.311+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:319,1.960000,0.280000,2.170000
06-07 16:59:42.311+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:42.321+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.321+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.321+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:42:324,2.359323,-0.698704,9.564112
06-07 16:59:42.321+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:330,0.201812,-0.039034,0.160979
06-07 16:59:42.321+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.331+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:42.331+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:328,1.470000,-0.210000,1.960000
06-07 16:59:42.331+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:335,2.154800,-0.654530,9.544570
06-07 16:59:42.331+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.331+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:42:337,2.368894,-0.674776,9.564112
06-07 16:59:42.341+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:42.341+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:343,2.170000,-0.350000,1.540000
06-07 16:59:42.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:59:42.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:59:42.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:59:42.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:59:42.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390782350,000000, pattern:[H:mm][0;m
06-07 16:59:42.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:59:42.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:59:42.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:59:42.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:59:42.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:59:42.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:59][0;m
06-07 16:59:42.341+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.351+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.351+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:352,2.148255,-0.649225,9.546408
06-07 16:59:42.351+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.351+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:356,0.101631,-0.013067,0.043470
06-07 16:59:42.351+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:42:350,2.304288,-0.648455,9.571291
06-07 16:59:42.361+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:42.361+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:363,2.870000,0.210000,1.190000
06-07 16:59:42.361+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.361+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.361+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:370,0.105784,0.036663,-0.001438
06-07 16:59:42.361+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:370,2.145151,-0.643288,9.547507
06-07 16:59:42.371+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:59:42.371+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:59:42:378,83
06-07 16:59:42.371+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.381+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:42:376,2.356930,-0.696311,9.705289
06-07 16:59:42.381+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:384,2.240000,-0.490000,1.470000
06-07 16:59:42.381+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:42.391+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.391+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:59:42.391+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.391+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:397,0.156744,0.033119,0.105140
06-07 16:59:42.401+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:398,2.141312,-0.636016,9.548856
06-07 16:59:42.401+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.401+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:59:42:401,816.000000
06-07 16:59:42.401+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.401+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:410,0.234761,0.102417,0.127719
06-07 16:59:42.401+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.411+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:42:392,2.256432,-0.667598,9.588040
06-07 16:59:42.411+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:406,2.870000,-0.700000,1.680000
06-07 16:59:42.411+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:42.411+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:415,2.134277,-0.621686,9.551374
06-07 16:59:42.411+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.421+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.421+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.431+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:431,0.258546,0.088087,-0.035119
06-07 16:59:42.431+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:425,4.760000,-1.120000,1.890000
06-07 16:59:42.431+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:42:424,2.254039,-0.612563,9.544970
06-07 16:59:42.431+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:42.431+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.441+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:435,2.133176,-0.610666,9.552331
06-07 16:59:42.441+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.441+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:444,3.710000,-1.190000,1.750000
06-07 16:59:42.441+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:451,0.218968,0.007674,0.004602
06-07 16:59:42.451+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.451+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:42:445,2.301895,-0.610170,9.652647
06-07 16:59:42.451+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.451+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:42.461+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:464,1.260000,-2.240000,1.680000
06-07 16:59:42.461+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.461+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:42:465,2.376073,-0.533599,9.676575
06-07 16:59:42.461+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:470,0.270948,-0.078003,-0.082301
06-07 16:59:42.461+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:456,2.141017,-0.608737,9.550700
06-07 16:59:42.471+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.471+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:476,2.153033,-0.611219,9.547840
06-07 16:59:42.471+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.471+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:42.481+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:483,1.120000,-1.960000,1.190000
06-07 16:59:42.481+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:42:486,2.392823,-0.533599,9.516255
06-07 16:59:42.491+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.491+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.491+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:496,0.239789,-0.085092,-0.036370
06-07 16:59:42.491+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:42.491+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.501+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:42:496,2.156269,-0.609879,9.547195
06-07 16:59:42.501+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:42.501+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:42:501,2.800000,-0.980000,0.490000
06-07 16:59:42.501+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:42.501+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:42:510,0.217411,-0.055325,0.088701
06-07 16:59:42.511+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:42:504,2.352145,-0.602991,9.556933
06-07 16:59:42.511+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:42.531+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11139976c6f63152838358
