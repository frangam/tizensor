S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 16533
Date: 2018-06-07 17:08:31+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf74e052d, r5   = 0xf7c1cf98
r6   = 0xff90ae10, r7   = 0xff90acc0
r8   = 0xf7c19c18, r9   = 0x00000000
r10  = 0xff90ad9c, fp   = 0xff90ae10
ip   = 0x00000001, sp   = 0xff90ac98
lr   = 0xf74e0539, pc   = 0xf7549228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    206092 KB
Buffers:      8584 KB
Cached:      49420 KB
VmPeak:      53592 KB
VmSize:      53564 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11696 KB
VmRSS:       11692 KB
VmData:      11292 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 16533 TID = 16533
16533 16550 

Maps Information
f43ab000 f4baa000 rw-p [stack:16550]
f4bb1000 f4bb3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4bbb000 f4bbf000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4bc8000 f4bca000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4bd2000 f4bd5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4be4000 f4be9000 r-xp /usr/lib/libsystem.so.0.0.0
f4bf4000 f4bf7000 r-xp /lib/libattr.so.1.1.0
f4bff000 f4c0f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c17000 f4c20000 r-xp /usr/lib/libedbus.so.1.7.99
f4c28000 f4c29000 r-xp /usr/lib/libresponse.so.0.2.96
f4c32000 f4c37000 r-xp /usr/lib/libproc-stat.so.0.2.96
f64d9000 f65df000 r-xp /usr/lib/libicuuc.so.57.1
f65f5000 f677d000 r-xp /usr/lib/libicui18n.so.57.1
f678d000 f679a000 r-xp /usr/lib/libail.so.0.1.0
f67a3000 f67aa000 r-xp /usr/lib/libminizip.so.1.0.0
f67b3000 f695c000 r-xp /usr/lib/libcrypto.so.1.0.0
f697c000 f69c3000 r-xp /usr/lib/libssl.so.1.0.0
f69cf000 f69d1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f69d9000 f69e0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f69e9000 f69f0000 r-xp /lib/libcrypt-2.13.so
f6a21000 f6a24000 r-xp /lib/libcap.so.2.21
f6a2c000 f6a2e000 r-xp /usr/lib/libiri.so
f6a36000 f6a7f000 r-xp /usr/lib/libmdm.so.1.2.69
f6a87000 f6a8d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a95000 f6ab8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6ac2000 f6ac4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6acc000 f6ae9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6af2000 f6af6000 r-xp /usr/lib/libsmack.so.1.0.0
f6aff000 f6b18000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b21000 f6b29000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b31000 f6b37000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b40000 f6b42000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b4b000 f6b5b000 r-xp /lib/libresolv-2.13.so
f6b5f000 f6b77000 r-xp /usr/lib/liblzma.so.5.0.3
f6b80000 f6b82000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b8a000 f6ba4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6bac000 f6bdb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6be4000 f6bf3000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6bfd000 f6c07000 r-xp /usr/lib/libsensord-shared.so
f6c10000 f6ce3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6cee000 f6d04000 r-xp /lib/libz.so.1.2.5
f6d0c000 f6d11000 r-xp /usr/lib/libffi.so.5.0.10
f6d19000 f6d1a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d22000 f6d32000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d3a000 f6d53000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d5b000 f6d5d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d65000 f6dda000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6de4000 f6dea000 r-xp /lib/librt-2.13.so
f6df3000 f6e11000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e1b000 f6e1c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e24000 f6e47000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e4f000 f6e54000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e5c000 f6e86000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e8f000 f6ea6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6eae000 f6f17000 r-xp /lib/libm-2.13.so
f6f20000 f6fb4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6fc7000 f6fcc000 r-xp /usr/lib/libctx-client.so.0.8.3
f6fd4000 f6fdb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6fe3000 f700d000 r-xp /usr/lib/libsensor.so.1.9.6
f7016000 f70e2000 r-xp /usr/lib/libxml2.so.2.7.8
f70ef000 f70f1000 r-xp /usr/lib/libiniparser.so.0
f70fa000 f7100000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7109000 f71d9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71da000 f720e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7217000 f7253000 r-xp /usr/lib/libSLP-location.so.0.9.24
f725b000 f725e000 r-xp /usr/lib/libbundle.so.0.1.22
f7266000 f726c000 r-xp /usr/lib/libappsvc.so.0.1.0
f7274000 f72b5000 r-xp /usr/lib/libeina.so.1.7.99
f72be000 f72d5000 r-xp /usr/lib/libecore.so.1.7.99
f72ec000 f72f5000 r-xp /usr/lib/libvconf.so.0.2.45
f72fd000 f7311000 r-xp /lib/libpthread-2.13.so
f731c000 f7329000 r-xp /usr/lib/libaul.so.0.1.0
f7333000 f7335000 r-xp /lib/libdl-2.13.so
f733e000 f7349000 r-xp /lib/libunwind.so.8.0.1
f7376000 f737e000 r-xp /lib/libgcc_s-4.6.so.1
f737f000 f74a3000 r-xp /lib/libc-2.13.so
f74b1000 f74b3000 r-xp /usr/lib/libdlog.so.0.0.0
f74bb000 f74c7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74d0000 f74d5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74dd000 f74ec000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f74f4000 f74f8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7501000 f7504000 r-xp /usr/lib/libappcore-agent.so.1.1
f750c000 f750e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7516000 f751a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7522000 f753f000 r-xp /lib/ld-2.13.so
f7548000 f754b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f754b000 f754f000 r-xp /usr/lib/libsys-assert.so
f7be9000 f7c77000 rw-p [heap]
ff8ec000 ff90d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16533)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7549228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf74e0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71e73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf71e5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf71f1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf71f7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf71f7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf722c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72271f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf71e5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf71f1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf71f7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf71f7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7229e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf722a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7231f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4bc91fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4bbc171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c8f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf713cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf713e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf72ceca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf72c9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72ca5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf72ca879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7502183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75027fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75495c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf739685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7548f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
 capturing data
06-07 17:08:30.401+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:404,7.640282,-5.008178,3.897908
06-07 17:08:30.401+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.401+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:30.401+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:409,7.659425,-4.984250,3.952943
06-07 17:08:30.401+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:30.401+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.411+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:414,7.645068,-4.874180,3.924229
06-07 17:08:30.411+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:30:410,0.039781,-0.015148,0.052711
06-07 17:08:30.411+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:30:414,3.500000,-0.210000,-0.490000
06-07 17:08:30.411+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:30.411+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.421+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:30:422,0.107104,0.035582,0.178879
06-07 17:08:30.421+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:30.421+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:30.421+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.421+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:429,7.685746,-4.785645,4.051049
06-07 17:08:30.431+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:30:429,1.960000,0.420000,-0.280000
06-07 17:08:30.431+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:30:428,0.121353,-0.088895,0.003101
06-07 17:08:30.431+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:423,7.532275,-4.925301,3.895720
06-07 17:08:30.431+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:30.431+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:30:438,0.113321,-0.194486,0.033699
06-07 17:08:30.431+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.431+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:30.441+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:443,7.532932,-4.924425,3.895557
06-07 17:08:30.441+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:30:443,0.100894,-0.057831,0.014809
06-07 17:08:30.441+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:30.441+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.441+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:450,7.611568,-4.967500,4.027121
06-07 17:08:30.441+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:30:450,-1.540000,-0.630000,-0.280000
06-07 17:08:30.441+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:30.451+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.451+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:30:454,0.073680,-0.004677,0.035695
06-07 17:08:30.451+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:30.451+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:30:460,0.093409,-0.053480,-0.020062
06-07 17:08:30.451+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:30.461+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:458,7.533503,-4.923638,3.895446
06-07 17:08:30.461+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.461+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.461+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:470,7.642675,-4.993821,3.964907
06-07 17:08:30.461+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:30.471+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:30:465,0.098645,-0.061279,0.061870
06-07 17:08:30.471+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:30.471+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:30:474,0.420000,-0.560000,-0.140000
06-07 17:08:30.471+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:467,7.533178,-4.921726,3.898491
06-07 17:08:30.471+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:30:478,0.086463,-0.093500,0.001066
06-07 17:08:30.471+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:30.471+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.481+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:30:483,0.109756,-0.050309,0.074232
06-07 17:08:30.481+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:30.481+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.481+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:490,7.657032,-4.948357,3.979264
06-07 17:08:30.481+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:30.491+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:30:494,2.660000,-0.770000,-0.630000
06-07 17:08:30.491+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:30:489,0.113554,0.010974,0.105449
06-07 17:08:30.491+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:484,7.533287,-4.916890,3.904378
06-07 17:08:30.491+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:30.491+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.491+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:30:499,0.081228,-0.099776,0.026746
06-07 17:08:30.491+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:30.501+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:503,7.534140,-4.918976,3.900101
06-07 17:08:30.501+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:30:504,0.124380,-0.101572,0.127837
06-07 17:08:30.501+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.501+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:30.501+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:30.511+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.511+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:30:515,2.660000,-0.630000,-0.560000
06-07 17:08:30.511+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:516,7.640282,-4.991428,3.955336
06-07 17:08:30.511+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:30:510,0.100654,-0.101789,-0.007439
06-07 17:08:30.511+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:510,7.532210,-4.924026,3.897455
06-07 17:08:30.511+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:30.521+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.521+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:30:523,0.117670,-0.080228,0.048729
06-07 17:08:30.521+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:30.521+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.521+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:529,7.680960,-4.926822,3.976871
06-07 17:08:30.521+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:30.531+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:30:532,3.220000,-0.910000,-0.630000
06-07 17:08:30.531+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:30:533,0.101358,0.025642,0.018520
06-07 17:08:30.531+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:30.531+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:30:539,0.138518,0.106815,0.142908
06-07 17:08:30.531+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:526,7.533103,-4.922145,3.898105
06-07 17:08:30.531+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:30.531+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.541+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:30:544,0.061653,-0.084896,0.111851
06-07 17:08:30.541+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.541+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:549,7.664211,-4.835894,3.919443
06-07 17:08:30.541+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:08:30.541+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:30.541+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:30.551+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:30:554,0.093892,-0.109618,0.049448
06-07 17:08:30.551+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:30.551+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:30:553,3.150000,-0.980000,-0.700000
06-07 17:08:30.551+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:08:30:555,399.000000
06-07 17:08:30.561+0200 E/RESOURCED( 2560): lowmem-limit.c: lowmem_limit_cb(305) > some application was crashed by kernel when it exceeded the threshold (104857600)
06-07 17:08:30.561+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.561+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:30.571+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:544,7.534910,-4.918806,3.898828
06-07 17:08:30.571+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.571+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:577,7.536852,-4.918184,3.895858
06-07 17:08:30.571+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.581+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:585,7.537070,-4.917071,3.896842
06-07 17:08:30.591+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:08:30.591+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:08:30:598,79
06-07 17:08:30.601+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.601+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:571,7.683353,-4.790431,3.964907
06-07 17:08:30.611+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:613,7.537705,-4.917191,3.895461
06-07 17:08:30.621+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.621+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.621+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:626,7.538692,-4.913868,3.897743
06-07 17:08:30.621+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.631+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:627,7.618747,-4.893322,3.964907
06-07 17:08:30.631+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.641+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:635,7.539912,-4.908402,3.902269
06-07 17:08:30.641+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.641+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:30:633,0.910000,0.140000,-0.420000
06-07 17:08:30.641+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:30.641+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:30:647,-1.190000,0.210000,0.140000
06-07 17:08:30.641+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:30.651+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:647,7.539831,-4.908998,3.901676
06-07 17:08:30.651+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.651+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:639,7.683353,-4.991428,4.031906
06-07 17:08:30.651+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:659,7.539629,-4.906389,3.905347
06-07 17:08:30.661+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.661+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:666,7.628319,-5.024928,3.964907
06-07 17:08:30.661+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:30:652,-1.820000,-0.490000,0.070000
06-07 17:08:30.661+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:30.661+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.661+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:30:671,0.840000,0.070000,-0.210000
06-07 17:08:30.661+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:30.671+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:671,7.541755,-4.904021,3.904214
06-07 17:08:30.671+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.681+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.681+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:686,7.637890,-4.931608,3.996014
06-07 17:08:30.681+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:682,7.543710,-4.899822,3.905709
06-07 17:08:30.681+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.681+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:30:675,2.520000,-0.420000,-0.700000
06-07 17:08:30.681+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:30.691+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.691+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:697,7.692925,-4.878965,3.914658
06-07 17:08:30.691+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.691+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:692,7.547228,-4.892460,3.908141
06-07 17:08:30.691+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.691+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:701,7.721639,-4.859823,3.905087
06-07 17:08:30.701+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:30:694,0.350000,-1.540000,0.070000
06-07 17:08:30.701+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:30.701+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:704,7.549916,-4.882604,3.915270
06-07 17:08:30.711+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.711+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:30:713,-0.070000,0.490000,-0.070000
06-07 17:08:30.711+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:30.711+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:30:719,-0.070000,1.120000,-0.070000
06-07 17:08:30.721+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.721+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:30.721+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:30:731,-0.490000,0.070000,0.350000
06-07 17:08:30.731+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:715,7.548783,-4.884203,3.915459
06-07 17:08:30.731+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.731+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:737,7.548777,-4.884947,3.914543
06-07 17:08:30.731+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.731+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:741,7.550820,-4.880505,3.916142
06-07 17:08:30.731+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.741+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:726,7.645068,-4.816752,4.041477
06-07 17:08:30.741+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.741+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:08:30.741+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:748,7.616355,-4.859823,4.005585
06-07 17:08:30.741+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.751+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:08:30:752,398.000000
06-07 17:08:30.751+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:30.761+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:752,7.659425,-5.027320,4.024727
06-07 17:08:30.761+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.761+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:30:766,-0.490000,-0.630000,0.210000
06-07 17:08:30.761+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:30.791+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:08:30.801+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:745,7.551772,-4.878507,3.916797
06-07 17:08:30.801+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.811+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:815,7.554790,-4.872563,3.918375
06-07 17:08:30.811+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:770,7.702496,-4.929214,4.067799
06-07 17:08:30.811+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.821+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.831+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:823,7.582855,-4.902894,4.003192
06-07 17:08:30.831+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.831+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:828,7.559972,-4.864423,3.918494
06-07 17:08:30.831+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.831+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:08:30:801,79
06-07 17:08:30.841+0200 W/AUL     (16619): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.linearacceleration]
06-07 17:08:30.841+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 23
06-07 17:08:30.841+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-07 17:08:30.841+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 16440
06-07 17:08:30.841+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 17:08:30.841+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 16440
06-07 17:08:30.851+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(16440)
06-07 17:08:30.851+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:839,7.680960,-4.998606,4.003192
06-07 17:08:30.851+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.861+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:841,7.563468,-4.857602,3.920208
06-07 17:08:30.861+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.871+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:862,7.735995,-4.902894,3.991228
06-07 17:08:30.871+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:873,7.562648,-4.858998,3.920060
06-07 17:08:30.871+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.871+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.881+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:30:775,1.400000,1.050000,-0.280000
06-07 17:08:30.881+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:30.881+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:884,7.661818,-4.864608,3.993621
06-07 17:08:30.881+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.891+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:882,7.561179,-4.862136,3.919003
06-07 17:08:30.891+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.891+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:30:891,0.560000,0.560000,-0.070000
06-07 17:08:30.891+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:894,7.599605,-4.898108,3.996014
06-07 17:08:30.891+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.891+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:30.901+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:897,7.559172,-4.865104,3.919193
06-07 17:08:30.901+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.901+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:908,7.560056,-4.861440,3.922033
06-07 17:08:30.901+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.901+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:902,7.633104,-4.945964,4.027121
06-07 17:08:30.911+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.911+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:30:907,-0.280000,-1.330000,0.280000
06-07 17:08:30.911+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:916,7.649854,-4.895715,3.988836
06-07 17:08:30.911+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:913,7.564136,-4.858625,3.917651
06-07 17:08:30.911+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.921+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:30.921+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.921+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:30:928,-0.280000,-0.420000,-0.070000
06-07 17:08:30.921+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:930,7.664211,-4.883751,3.914658
06-07 17:08:30.921+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:924,7.566797,-4.856203,3.915515
06-07 17:08:30.921+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.931+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:935,7.565953,-4.852802,3.921360
06-07 17:08:30.931+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.931+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:940,7.564990,-4.852449,3.923653
06-07 17:08:30.931+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.931+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:30.941+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:08:30.941+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.941+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:950,7.719246,-4.888536,3.912265
06-07 17:08:30.941+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:944,7.562606,-4.856457,3.923288
06-07 17:08:30.951+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.951+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:08:30:953,398.000000
06-07 17:08:30.951+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:956,7.561191,-4.853940,3.929127
06-07 17:08:30.951+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.951+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:960,7.559150,-4.854252,3.932667
06-07 17:08:30.951+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.961+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:30:945,-0.210000,0.700000,-0.210000
06-07 17:08:30.961+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.961+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:969,7.673782,-4.929214,3.996014
06-07 17:08:30.961+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:30.971+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:965,7.559037,-4.856483,3.930130
06-07 17:08:30.971+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.971+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:30:975,-0.490000,0.280000,-0.210000
06-07 17:08:30.971+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:976,7.561213,-4.854325,3.928608
06-07 17:08:30.971+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.981+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:981,7.561415,-4.852546,3.930417
06-07 17:08:30.981+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.981+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:986,7.560222,-4.853189,3.931918
06-07 17:08:30.981+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:30.981+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:30.981+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:30:992,7.680960,-4.986642,3.969693
06-07 17:08:30.991+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:08:30.991+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.991+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:30:997,7.559319,-4.854388,3.932175
06-07 17:08:30.991+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:30.991+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:08:30:997,79
06-07 17:08:31.001+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:2,7.560283,-4.851876,3.933421
06-07 17:08:31.001+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.001+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:7,7.563005,-4.849305,3.931357
06-07 17:08:31.001+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.001+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:31.011+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:30:995,-0.350000,-0.840000,0.140000
06-07 17:08:31.011+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:31:14,7.688138,-4.898108,3.948158
06-07 17:08:31.011+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.011+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:11,7.565338,-4.848737,3.927569
06-07 17:08:31.011+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.021+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:31.031+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:31:31,7.702496,-4.859823,3.988836
06-07 17:08:31.031+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:23,7.563914,-4.849606,3.929237
06-07 17:08:31.031+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.031+0200 W/LOCATION(16533): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:08:31.041+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:42,7.563134,-4.851461,3.928449
06-07 17:08:31.041+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.041+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:31.051+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:08:31.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:08:31.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:08:31.061+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:37,1.680000,-0.630000,0.140000
06-07 17:08:31.061+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:31:50,7.647461,-4.905287,4.058227
06-07 17:08:31.061+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.061+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:31.071+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:31:73,7.601997,-5.039285,4.070191
06-07 17:08:31.071+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:47,7.564641,-4.850053,3.927286
06-07 17:08:31.071+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.081+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:75,1.540000,-0.630000,-0.070000
06-07 17:08:31.081+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:82,7.564887,-4.849178,3.927892
06-07 17:08:31.081+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.081+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.081+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:31.081+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:31:91,7.645068,-4.977071,3.998406
06-07 17:08:31.091+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:87,7.562465,-4.850928,3.930396
06-07 17:08:31.091+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.091+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:99,7.558609,-4.854594,3.933286
06-07 17:08:31.091+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.101+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:88,-0.280000,-0.140000,0.280000
06-07 17:08:31.101+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.101+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:104,7.559113,-4.852035,3.935475
06-07 17:08:31.101+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:31.111+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:106,0.070000,0.770000,0.140000
06-07 17:08:31.111+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.111+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.111+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:31:115,7.661818,-4.948357,3.866802
06-07 17:08:31.111+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:117,0.840000,-0.210000,0.280000
06-07 17:08:31.111+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:119,7.562372,-4.849531,3.932297
06-07 17:08:31.121+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.121+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:31.121+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:130,0.630000,-0.210000,0.070000
06-07 17:08:31.121+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.131+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.131+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:134,7.567300,-4.845672,3.927571
06-07 17:08:31.131+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:31:129,7.707282,-4.850252,3.862016
06-07 17:08:31.131+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:138,-1.190000,0.910000,0.070000
06-07 17:08:31.141+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.141+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:31.141+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.141+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:08:31.151+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:31:150,7.697710,-4.905287,3.998406
06-07 17:08:31.151+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:153,7.567264,-4.845138,3.928301
06-07 17:08:31.151+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:08:31:154,397.000000
06-07 17:08:31.151+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:147,-1.960000,0.630000,0.070000
06-07 17:08:31.161+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.161+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:31.161+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.161+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:166,0.420000,-0.420000,-0.210000
06-07 17:08:31.171+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.171+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:31:170,7.630712,-4.859823,4.034299
06-07 17:08:31.171+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:172,7.565545,-4.844024,3.932982
06-07 17:08:31.181+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:177,3.640000,-0.910000,-0.350000
06-07 17:08:31.181+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.181+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:31.181+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:190,3.850000,-1.120000,-0.140000
06-07 17:08:31.181+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:31:191,7.623533,-4.833502,4.048656
06-07 17:08:31.191+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.191+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:08:31.191+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:196,7.564314,-4.841901,3.937961
06-07 17:08:31.191+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:08:31:198,79
06-07 17:08:31.201+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.201+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:31.211+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.211+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:211,1.190000,-0.560000,-0.280000
06-07 17:08:31.211+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.211+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:215,7.563814,-4.841233,3.939742
06-07 17:08:31.211+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:31:215,7.664211,-4.934000,4.046263
06-07 17:08:31.221+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:221,-0.070000,0.280000,0.070000
06-07 17:08:31.221+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.221+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.221+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:31.231+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:230,0.140000,0.910000,0.070000
06-07 17:08:31.231+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:230,7.563949,-4.843854,3.936259
06-07 17:08:31.231+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.231+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:31:231,7.647461,-5.003392,3.912265
06-07 17:08:31.241+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:240,0.490000,0.350000,0.420000
06-07 17:08:31.241+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:31.241+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.241+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.251+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:250,1.400000,-1.120000,0.560000
06-07 17:08:31.251+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:31:255,7.671390,-4.950750,3.917051
06-07 17:08:31.251+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.251+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:251,7.564075,-4.845257,3.934292
06-07 17:08:31.251+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:259,1.540000,-0.770000,0.070000
06-07 17:08:31.261+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.261+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:31.261+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.261+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:270,0.770000,0.420000,-0.070000
06-07 17:08:31.271+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.271+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:271,7.563287,-4.843023,3.938553
06-07 17:08:31.271+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:31:272,7.618747,-4.859823,4.027121
06-07 17:08:31.281+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:279,0.700000,0.630000,-0.350000
06-07 17:08:31.281+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:31.281+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.281+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.291+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:292,0.700000,-0.280000,0.280000
06-07 17:08:31.291+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:31:296,7.683353,-4.871787,3.945765
06-07 17:08:31.291+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:292,7.565042,-4.841416,3.937158
06-07 17:08:31.301+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:31.301+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.301+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.311+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:315,0.140000,-0.630000,0.560000
06-07 17:08:31.311+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:31:315,7.645068,-4.910072,3.888337
06-07 17:08:31.311+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:315,7.566139,-4.843282,3.932753
06-07 17:08:31.321+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.321+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:31.321+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.331+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:330,7.566272,-4.842319,3.933683
06-07 17:08:31.331+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:31:330,7.707282,-4.845466,4.017549
06-07 17:08:31.331+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:329,-1.540000,0.700000,0.210000
06-07 17:08:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:08:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:08:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:08:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:08:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:08:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:08:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:08:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:08:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:08:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:08:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:08:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:08:31.331+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391311343,000000, pattern:[H:mm][0;m
06-07 17:08:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:08:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:08:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:08:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:08:31.331+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:08:31.331+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:08][0;m
06-07 17:08:31.341+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:08:31.341+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.341+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:31.341+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.351+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:31:353,7.654640,-4.965107,4.007978
06-07 17:08:31.351+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:08:31:355,395.000000
06-07 17:08:31.351+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:353,7.562742,-4.847521,3.934065
06-07 17:08:31.351+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:350,-2.170000,1.260000,0.140000
06-07 17:08:31.361+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.361+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:31.361+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.371+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:369,1.190000,0.070000,-0.140000
06-07 17:08:31.371+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:372,7.561598,-4.847738,3.935995
06-07 17:08:31.371+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:31:370,7.659425,-4.962714,4.015156
06-07 17:08:31.381+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.381+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:31.381+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.391+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:08:31.391+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:392,7.563498,-4.844696,3.936089
06-07 17:08:31.391+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:08:31:399,79
06-07 17:08:31.391+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:391,2.380000,-0.560000,-0.070000
06-07 17:08:31.401+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:31:396,7.642675,-4.883751,3.940979
06-07 17:08:31.401+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.411+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.411+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:31:416,7.567168,-4.844824,3.928871
06-07 17:08:31.411+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:415,0.420000,-0.770000,0.280000
06-07 17:08:31.421+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.421+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:31.421+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:31:430,-0.560000,1.120000,-0.210000
06-07 17:08:31.421+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:31.441+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:31.441+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11165336c6f63152838411
