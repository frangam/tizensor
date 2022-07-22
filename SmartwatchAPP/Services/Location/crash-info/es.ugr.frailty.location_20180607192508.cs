S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 30428
Date: 2018-06-07 19:25:08+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf74ec52d, r5   = 0xf7711150
r6   = 0xffc37d70, r7   = 0xffc37c20
r8   = 0xf7723c18, r9   = 0x00000000
r10  = 0xffc37cfc, fp   = 0xffc37d70
ip   = 0x00000001, sp   = 0xffc37bf8
lr   = 0xf74ec539, pc   = 0xf7555228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    264452 KB
Buffers:     14324 KB
Cached:     107992 KB
VmPeak:      53476 KB
VmSize:      53436 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11756 KB
VmRSS:       11752 KB
VmData:      11164 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 30428 TID = 30428
30428 30497 

Maps Information
f43b7000 f4bb6000 rw-p [stack:30497]
f4bbd000 f4bbf000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4bc7000 f4bcb000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4bd4000 f4bd6000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4bde000 f4be1000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4bf0000 f4bf5000 r-xp /usr/lib/libsystem.so.0.0.0
f4c00000 f4c03000 r-xp /lib/libattr.so.1.1.0
f4c0b000 f4c1b000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c23000 f4c2c000 r-xp /usr/lib/libedbus.so.1.7.99
f4c34000 f4c35000 r-xp /usr/lib/libresponse.so.0.2.96
f4c3e000 f4c43000 r-xp /usr/lib/libproc-stat.so.0.2.96
f64e5000 f65eb000 r-xp /usr/lib/libicuuc.so.57.1
f6601000 f6789000 r-xp /usr/lib/libicui18n.so.57.1
f6799000 f67a6000 r-xp /usr/lib/libail.so.0.1.0
f67af000 f67b6000 r-xp /usr/lib/libminizip.so.1.0.0
f67bf000 f6968000 r-xp /usr/lib/libcrypto.so.1.0.0
f6988000 f69cf000 r-xp /usr/lib/libssl.so.1.0.0
f69db000 f69dd000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f69e5000 f69ec000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f69f5000 f69fc000 r-xp /lib/libcrypt-2.13.so
f6a2d000 f6a30000 r-xp /lib/libcap.so.2.21
f6a38000 f6a3a000 r-xp /usr/lib/libiri.so
f6a42000 f6a8b000 r-xp /usr/lib/libmdm.so.1.2.69
f6a93000 f6a99000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6aa1000 f6ac4000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6ace000 f6ad0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ad8000 f6af5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6afe000 f6b02000 r-xp /usr/lib/libsmack.so.1.0.0
f6b0b000 f6b24000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b2d000 f6b35000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b3d000 f6b43000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b4c000 f6b4e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b57000 f6b67000 r-xp /lib/libresolv-2.13.so
f6b6b000 f6b83000 r-xp /usr/lib/liblzma.so.5.0.3
f6b8c000 f6b8e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b96000 f6bb0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6bb8000 f6be7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bf0000 f6bff000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c09000 f6c13000 r-xp /usr/lib/libsensord-shared.so
f6c1c000 f6cef000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6cfa000 f6d10000 r-xp /lib/libz.so.1.2.5
f6d18000 f6d1d000 r-xp /usr/lib/libffi.so.5.0.10
f6d25000 f6d26000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d2e000 f6d3e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d46000 f6d5f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d67000 f6d69000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d71000 f6de6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6df0000 f6df6000 r-xp /lib/librt-2.13.so
f6dff000 f6e1d000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e27000 f6e28000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e30000 f6e53000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e5b000 f6e60000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e68000 f6e92000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e9b000 f6eb2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6eba000 f6f23000 r-xp /lib/libm-2.13.so
f6f2c000 f6fc0000 r-xp /usr/lib/libstdc++.so.6.0.16
f6fd3000 f6fd8000 r-xp /usr/lib/libctx-client.so.0.8.3
f6fe0000 f6fe7000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6fef000 f7019000 r-xp /usr/lib/libsensor.so.1.9.6
f7022000 f70ee000 r-xp /usr/lib/libxml2.so.2.7.8
f70fb000 f70fd000 r-xp /usr/lib/libiniparser.so.0
f7106000 f710c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7115000 f71e5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71e6000 f721a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7223000 f725f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7267000 f726a000 r-xp /usr/lib/libbundle.so.0.1.22
f7272000 f7278000 r-xp /usr/lib/libappsvc.so.0.1.0
f7280000 f72c1000 r-xp /usr/lib/libeina.so.1.7.99
f72ca000 f72e1000 r-xp /usr/lib/libecore.so.1.7.99
f72f8000 f7301000 r-xp /usr/lib/libvconf.so.0.2.45
f7309000 f731d000 r-xp /lib/libpthread-2.13.so
f7328000 f7335000 r-xp /usr/lib/libaul.so.0.1.0
f733f000 f7341000 r-xp /lib/libdl-2.13.so
f734a000 f7355000 r-xp /lib/libunwind.so.8.0.1
f7382000 f738a000 r-xp /lib/libgcc_s-4.6.so.1
f738b000 f74af000 r-xp /lib/libc-2.13.so
f74bd000 f74bf000 r-xp /usr/lib/libdlog.so.0.0.0
f74c7000 f74d3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74dc000 f74e1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74e9000 f74f8000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7500000 f7504000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f750d000 f7510000 r-xp /usr/lib/libappcore-agent.so.1.1
f7518000 f751a000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7522000 f7526000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f752e000 f754b000 r-xp /lib/ld-2.13.so
f7554000 f7557000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7557000 f755b000 r-xp /usr/lib/libsys-assert.so
f76f3000 f7761000 rw-p [heap]
ffc19000 ffc3a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:30428)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7555228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf74ec539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71f33f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf71f1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf71fde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7203be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7203dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf723875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72331f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf71f1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf71fde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7203be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7203dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7235e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7236017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf723df93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4bd51fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4bc8171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c9b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7148fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf714a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf72daca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf72d5b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72d65a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf72d6879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf750e183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf750e7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75555c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf73a285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7554f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
yroscope - capturing data
06-07 19:25:08.121+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:122,0.326308,-0.052809,9.801078
06-07 19:25:08.121+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.121+0200 I/light   (30467): es.ugr.frailty.light: SM-R760,07/06/2018,19:25:08:121,6153.000000
06-07 19:25:08.121+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:123,0.210000,0.070000,0.070000
06-07 19:25:08.131+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:129,0.017511,-0.007706,0.057385
06-07 19:25:08.131+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.131+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.131+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.141+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.141+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:141,0.344566,-0.062213,9.858429
06-07 19:25:08.141+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:140,0.326505,-0.053076,9.801069
06-07 19:25:08.141+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:146,0.070000,0.070000,0.070000
06-07 19:25:08.141+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:146,0.018258,-0.002225,0.074101
06-07 19:25:08.141+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.151+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.151+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.161+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.161+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:155,0.344566,-0.055035,9.875179
06-07 19:25:08.161+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:160,0.070000,0.070000,0.070000
06-07 19:25:08.161+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:161,0.326597,-0.052988,9.801066
06-07 19:25:08.161+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.161+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:166,-0.029795,-0.045029,0.110003
06-07 19:25:08.171+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:171,0.296710,-0.098106,9.911072
06-07 19:25:08.171+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.171+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.181+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:183,0.324386,-0.054992,9.801129
06-07 19:25:08.181+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:183,0.070000,0.070000,-0.070000
06-07 19:25:08.181+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.181+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.181+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:189,-0.001173,0.026667,0.069327
06-07 19:25:08.181+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:189,0.325424,-0.026321,9.870394
06-07 19:25:08.191+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.191+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.191+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:199,0.070000,0.070000,-0.070000
06-07 19:25:08.191+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.191+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.191+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:200,0.303888,-0.055035,9.872787
06-07 19:25:08.201+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:205,0.323636,-0.053430,9.801163
06-07 19:25:08.201+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:210,-0.020498,-0.000043,0.071657
06-07 19:25:08.211+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.211+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.211+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:220,0.070000,0.070000,-0.070000
06-07 19:25:08.211+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.211+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.221+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:220,0.337388,-0.083749,9.848858
06-07 19:25:08.221+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:228,0.013752,-0.030319,0.047695
06-07 19:25:08.231+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:225,0.322003,-0.053325,9.801217
06-07 19:25:08.231+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.231+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.241+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.241+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.241+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:241,0.070000,0.070000,0.070000
06-07 19:25:08.241+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:240,0.380459,-0.045464,9.908678
06-07 19:25:08.241+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:246,0.058456,0.007861,0.107461
06-07 19:25:08.251+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:247,0.322299,-0.054580,9.801200
06-07 19:25:08.251+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.251+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.261+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.261+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.261+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:261,0.070000,0.070000,0.070000
06-07 19:25:08.261+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:267,0.323931,-0.053995,9.801149
06-07 19:25:08.261+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:261,0.363709,-0.083749,9.860823
06-07 19:25:08.271+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:266,0.041410,-0.029169,0.059623
06-07 19:25:08.271+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.271+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.281+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.281+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.281+0200 I/heartrate(30415): es.ugr.frailty.heartrate - capturing data
06-07 19:25:08.281+0200 I/heartrate(30415): es.ugr.frailty.heartrate: waiting for rigth values
06-07 19:25:08.281+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:283,0.070000,0.070000,0.070000
06-07 19:25:08.281+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:287,0.025421,0.025281,0.078815
06-07 19:25:08.291+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:283,0.325416,-0.055196,9.801094
06-07 19:25:08.291+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:285,0.349352,-0.028714,9.879964
06-07 19:25:08.291+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.291+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.301+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.301+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:301,0.070000,0.070000,0.070000
06-07 19:25:08.301+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:306,0.294317,-0.023928,9.868000
06-07 19:25:08.301+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.301+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:301,-0.031099,0.031268,0.066906
06-07 19:25:08.311+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:312,0.325526,-0.053773,9.801098
06-07 19:25:08.311+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.311+0200 I/light   (30467): es.ugr.frailty.light - capturing data
06-07 19:25:08.311+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.311+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.321+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:321,0.070000,0.070000,0.070000
06-07 19:25:08.321+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:321,-0.019245,0.010703,0.088438
06-07 19:25:08.321+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:324,0.306281,-0.043071,9.889536
06-07 19:25:08.321+0200 I/light   (30467): es.ugr.frailty.light: SM-R760,07/06/2018,19:25:08:321,6164.000000
06-07 19:25:08.331+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.331+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.331+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:338,0.323474,-0.052121,9.801175
06-07 19:25:08.341+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.341+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.341+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.341+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:347,0.321905,-0.051498,9.801230
06-07 19:25:08.351+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:340,0.025878,-0.000521,0.023754
06-07 19:25:08.351+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.351+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:346,0.349352,-0.052642,9.824929
06-07 19:25:08.351+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.361+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:362,0.323414,-0.051692,9.801179
06-07 19:25:08.361+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.361+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:364,0.385244,-0.038285,9.889536
06-07 19:25:08.361+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:370,0.063340,0.013213,0.088305
06-07 19:25:08.371+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:350,0.070000,0.070000,0.070000
06-07 19:25:08.371+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.371+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.371+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:378,-0.070000,0.070000,0.070000
06-07 19:25:08.371+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.371+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.381+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:382,0.303888,-0.069392,9.851252
06-07 19:25:08.381+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:384,-0.070000,0.070000,0.070000
06-07 19:25:08.381+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.381+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:384,0.326068,-0.051226,9.801094
06-07 19:25:08.381+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:390,-0.019526,-0.017699,0.050073
06-07 19:25:08.391+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.391+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.391+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:399,-0.070000,0.070000,0.070000
06-07 19:25:08.391+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.391+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.401+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:405,0.337388,-0.076570,9.860823
06-07 19:25:08.401+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:404,0.011320,-0.025344,0.059729
06-07 19:25:08.401+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:400,0.325201,-0.052245,9.801117
06-07 19:25:08.411+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.411+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.421+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.421+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.421+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:421,0.070000,-0.070000,0.070000
06-07 19:25:08.421+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:428,0.315853,-0.035892,9.879964
06-07 19:25:08.421+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:422,-0.009349,0.016352,0.078847
06-07 19:25:08.431+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:426,0.325517,-0.053237,9.801102
06-07 19:25:08.431+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.431+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.441+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.441+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:440,0.070000,-0.070000,0.070000
06-07 19:25:08.441+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.441+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:446,0.325424,-0.090927,9.829715
06-07 19:25:08.441+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:440,-0.000094,-0.037690,0.028613
06-07 19:25:08.441+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:449,0.324620,-0.052244,9.801137
06-07 19:25:08.451+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.451+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.461+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.461+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:460,0.070000,-0.070000,0.070000
06-07 19:25:08.461+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.461+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:466,0.351745,-0.066999,9.906286
06-07 19:25:08.461+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:461,0.027125,-0.014756,0.105149
06-07 19:25:08.461+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:468,0.324515,-0.053936,9.801131
06-07 19:25:08.471+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.471+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.481+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.481+0200 I/heartrate(30415): es.ugr.frailty.heartrate - capturing data
06-07 19:25:08.481+0200 I/heartrate(30415): es.ugr.frailty.heartrate: waiting for rigth values
06-07 19:25:08.481+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:484,0.070000,-0.070000,0.070000
06-07 19:25:08.481+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.481+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:485,0.000909,-0.008278,0.083619
06-07 19:25:08.491+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:491,0.325395,-0.054382,9.801099
06-07 19:25:08.491+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.491+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.491+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:500,0.070000,0.070000,0.070000
06-07 19:25:08.501+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:488,0.325424,-0.062213,9.884750
06-07 19:25:08.501+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.501+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.501+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:508,0.324678,-0.054570,9.801122
06-07 19:25:08.501+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:500,0.007207,-0.029367,0.042974
06-07 19:25:08.501+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:508,0.332602,-0.083749,9.844072
06-07 19:25:08.511+0200 I/light   (30467): es.ugr.frailty.light - capturing data
06-07 19:25:08.511+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.521+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.541+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:549,0.005531,-0.022000,0.052522
06-07 19:25:08.551+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.561+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:558,0.043068,0.024972,0.057341
06-07 19:25:08.561+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.571+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:570,0.007690,-0.002962,0.047757
06-07 19:25:08.571+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.571+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.581+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:579,0.325427,-0.056078,9.801088
06-07 19:25:08.581+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.591+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:584,-0.005241,0.000469,0.090852
06-07 19:25:08.591+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.601+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:594,0.324913,-0.056858,9.801101
06-07 19:25:08.601+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.601+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:601,0.004681,-0.009073,0.062127
06-07 19:25:08.611+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.611+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:618,0.330210,-0.076570,9.853643
06-07 19:25:08.621+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.621+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:521,-0.070000,0.070000,0.070000
06-07 19:25:08.621+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:627,0.368495,-0.031107,9.858429
06-07 19:25:08.621+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.621+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.631+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:633,0.332602,-0.059821,9.848858
06-07 19:25:08.631+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.631+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.631+0200 I/light   (30467): es.ugr.frailty.light: SM-R760,07/06/2018,19:25:08:521,6164.000000
06-07 19:25:08.651+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:641,0.320638,-0.055035,9.891929
06-07 19:25:08.651+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.651+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:657,0.330210,-0.064606,9.863215
06-07 19:25:08.651+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:607,0.325879,-0.055504,9.801077
06-07 19:25:08.651+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.661+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.661+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:664,0.315853,-0.107677,9.824929
06-07 19:25:08.661+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.661+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:633,-0.009573,-0.052050,0.023838
06-07 19:25:08.671+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.671+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:671,0.342174,-0.102891,9.879964
06-07 19:25:08.671+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.671+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:660,0.070000,0.140000,0.070000
06-07 19:25:08.681+0200 I/heartrate(30415): es.ugr.frailty.heartrate - capturing data
06-07 19:25:08.681+0200 I/heartrate(30415): es.ugr.frailty.heartrate: waiting for rigth values
06-07 19:25:08.681+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:683,0.358923,-0.062213,9.923036
06-07 19:25:08.681+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.681+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:685,0.016323,-0.046714,0.078890
06-07 19:25:08.681+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:690,0.299103,-0.078963,9.827322
06-07 19:25:08.691+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.691+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:666,0.325529,-0.055534,9.801088
06-07 19:25:08.691+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.691+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.691+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:698,0.070000,0.070000,0.070000
06-07 19:25:08.701+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.701+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:699,0.303888,-0.055035,9.879964
06-07 19:25:08.701+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:705,0.325425,-0.055627,9.801091
06-07 19:25:08.701+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.711+0200 I/light   (30467): es.ugr.frailty.light - capturing data
06-07 19:25:08.711+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.711+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.711+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:708,0.034167,-0.003765,0.121939
06-07 19:25:08.721+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.721+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:724,0.330210,-0.117248,9.882358
06-07 19:25:08.721+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:715,0.070000,0.070000,0.070000
06-07 19:25:08.721+0200 I/light   (30467): es.ugr.frailty.light: SM-R760,07/06/2018,19:25:08:721,6147.000000
06-07 19:25:08.721+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:721,0.325850,-0.056177,9.801074
06-07 19:25:08.721+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.731+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.731+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:727,-0.026090,-0.018634,0.026251
06-07 19:25:08.731+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.731+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:733,-0.070000,0.070000,0.070000
06-07 19:25:08.731+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:740,0.313460,-0.052642,9.875179
06-07 19:25:08.741+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.741+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.751+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:741,0.324757,-0.058448,9.801097
06-07 19:25:08.751+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.751+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:747,-0.021730,0.004927,0.078905
06-07 19:25:08.751+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.751+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.751+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:761,0.337388,-0.098106,9.844072
06-07 19:25:08.761+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:761,0.005268,-0.056175,0.081283
06-07 19:25:08.761+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:754,-0.070000,0.070000,0.070000
06-07 19:25:08.761+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.761+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.761+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:757,0.325193,-0.060329,9.801071
06-07 19:25:08.761+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.771+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:773,-0.010635,0.008254,0.074076
06-07 19:25:08.771+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.771+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.781+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:782,0.013338,-0.034771,0.042982
06-07 19:25:08.781+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.781+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:783,0.291924,-0.090927,9.875179
06-07 19:25:08.791+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:787,-0.030998,-0.028299,0.074047
06-07 19:25:08.791+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.791+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.801+0200 W/LOCATION(30428): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 19:25:08.801+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:801,0.356531,-0.055035,9.868000
06-07 19:25:08.801+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:777,0.325618,-0.059962,9.801059
06-07 19:25:08.801+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.811+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:775,0.070000,0.140000,0.070000
06-07 19:25:08.811+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.811+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.811+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:800,0.033306,0.009070,0.066888
06-07 19:25:08.821+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.821+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:816,0.070000,0.070000,0.070000
06-07 19:25:08.821+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.821+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:821,0.361316,-0.057428,9.851252
06-07 19:25:08.821+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:813,0.324941,-0.061074,9.801075
06-07 19:25:08.821+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:826,0.040356,0.007807,0.050073
06-07 19:25:08.821+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.831+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:834,0.324094,-0.060896,9.801104
06-07 19:25:08.831+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:826,0.210000,-0.140000,0.070000
06-07 19:25:08.831+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.831+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.831+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.831+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:840,0.342174,-0.052642,9.894321
06-07 19:25:08.841+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.841+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:841,0.020697,0.011792,0.093154
06-07 19:25:08.841+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:839,-0.070000,-0.140000,0.070000
06-07 19:25:08.841+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.841+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:845,0.324050,-0.063334,9.801090
06-07 19:25:08.841+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.851+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.851+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.861+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:861,0.373280,-0.071785,9.889536
06-07 19:25:08.861+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:862,0.049935,-0.007539,0.088428
06-07 19:25:08.861+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:850,-0.070000,0.070000,-0.070000
06-07 19:25:08.861+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.861+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:855,0.322922,-0.062628,9.801132
06-07 19:25:08.861+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.861+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:872,0.323224,-0.064105,9.801112
06-07 19:25:08.871+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:869,0.070000,0.070000,-0.070000
06-07 19:25:08.871+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.871+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:878,0.070000,0.070000,-0.070000
06-07 19:25:08.871+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.871+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.881+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:883,0.358923,-0.057428,9.879964
06-07 19:25:08.881+0200 I/heartrate(30415): es.ugr.frailty.heartrate - capturing data
06-07 19:25:08.881+0200 I/heartrate(30415): es.ugr.frailty.heartrate: waiting for rigth values
06-07 19:25:08.881+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.881+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:883,0.035843,0.005931,0.078842
06-07 19:25:08.881+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.891+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:889,0.320961,-0.065235,9.801179
06-07 19:25:08.891+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.891+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.891+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.891+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:901,0.361316,-0.062213,9.903893
06-07 19:25:08.901+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:901,0.036583,0.001355,0.102828
06-07 19:25:08.901+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:896,0.321477,-0.064434,9.801167
06-07 19:25:08.901+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.901+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:892,0.070000,0.070000,-0.070000
06-07 19:25:08.901+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.911+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:909,0.070000,0.070000,0.070000
06-07 19:25:08.911+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.911+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:907,0.323345,-0.064246,9.801107
06-07 19:25:08.921+0200 I/light   (30467): es.ugr.frailty.light - capturing data
06-07 19:25:08.921+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 19:25:08.921+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 19:25:08.921+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 19:25:08.921+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.921+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.911+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:916,0.140000,0.070000,0.070000
06-07 19:25:08.921+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:928,0.334995,-0.071785,9.810574
06-07 19:25:08.921+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.931+0200 I/light   (30467): es.ugr.frailty.light: SM-R760,07/06/2018,19:25:08:927,6147.000000
06-07 19:25:08.931+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.931+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.931+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:939,0.291924,-0.035892,9.834501
06-07 19:25:08.931+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:931,0.009440,-0.008681,0.009532
06-07 19:25:08.931+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.941+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:934,-0.070000,0.070000,0.070000
06-07 19:25:08.941+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.941+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:937,0.323080,-0.063358,9.801122
06-07 19:25:08.941+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.941+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:947,0.140000,0.070000,0.070000
06-07 19:25:08.941+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.941+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:944,-0.034826,0.027013,0.033498
06-07 19:25:08.951+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:952,0.070000,0.070000,0.070000
06-07 19:25:08.951+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.951+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.951+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.961+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:961,0.289532,-0.035892,9.856036
06-07 19:25:08.961+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:958,0.070000,0.070000,0.070000
06-07 19:25:08.961+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:948,0.324733,-0.063569,9.801065
06-07 19:25:08.961+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.961+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.961+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:970,0.070000,-0.070000,0.070000
06-07 19:25:08.961+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.971+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:974,0.070000,-0.070000,-0.070000
06-07 19:25:08.971+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.971+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:961,-0.037403,0.027291,0.055041
06-07 19:25:08.971+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.971+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.981+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:968,0.325555,-0.063104,9.801042
06-07 19:25:08.981+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.981+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:08:982,0.358923,-0.033500,9.946963
06-07 19:25:08.981+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:980,-0.140000,0.070000,-0.070000
06-07 19:25:08.981+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.981+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:991,0.070000,0.070000,-0.070000
06-07 19:25:08.991+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:986,0.326750,-0.062905,9.801003
06-07 19:25:08.991+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:08.991+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:08:982,0.032895,0.028613,0.145931
06-07 19:25:08.991+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:08.991+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:08.991+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:08:999,-0.560000,0.210000,0.070000
06-07 19:25:08.991+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:08.991+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:09:0,0.334995,-0.062213,9.994821
06-07 19:25:09.001+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:08:996,0.326935,-0.063184,9.800995
06-07 19:25:09.001+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:09.001+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:09:3,0.011141,-0.001577,0.193707
06-07 19:25:09.001+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:09:8,0.326029,-0.062112,9.801032
06-07 19:25:09.011+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:09.011+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:09.011+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:09.011+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:09.011+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:09:21,0.318245,-0.016750,9.882358
06-07 19:25:09.021+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:09:23,-0.009568,0.043777,0.081375
06-07 19:25:09.021+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:09:20,-0.070000,0.210000,0.070000
06-07 19:25:09.021+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:09:15,0.323854,-0.060636,9.801113
06-07 19:25:09.021+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:09.031+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:09:31,0.327813,-0.060527,9.800982
06-07 19:25:09.031+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:09.031+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:09.031+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:09.031+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:09.041+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:09:40,0.342174,-0.055035,9.870394
06-07 19:25:09.041+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:09:40,0.210000,-0.070000,0.070000
06-07 19:25:09.041+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:09:42,0.014388,0.005627,0.069411
06-07 19:25:09.041+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:09:37,0.327786,-0.060662,9.800982
06-07 19:25:09.041+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:09.051+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:09:54,0.326256,-0.058088,9.801049
06-07 19:25:09.051+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:09.051+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:09.051+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:09:60,0.210000,0.070000,0.070000
06-07 19:25:09.051+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:09:60,0.323031,-0.122034,9.832108
06-07 19:25:09.051+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:09.061+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:09:64,-0.003225,-0.063946,0.031059
06-07 19:25:09.061+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:09.061+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:09:68,0.325428,-0.057460,9.801081
06-07 19:25:09.071+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:09.071+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:09.071+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:09.081+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:09:83,0.002389,0.004818,0.007099
06-07 19:25:09.081+0200 I/heartrate(30415): es.ugr.frailty.heartrate - capturing data
06-07 19:25:09.081+0200 I/heartrate(30415): es.ugr.frailty.heartrate: waiting for rigth values
06-07 19:25:09.081+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:09:85,0.327817,-0.052642,9.808180
06-07 19:25:09.081+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:09:83,0.210000,0.070000,-0.070000
06-07 19:25:09.081+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:09.091+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:09:93,0.324197,-0.060014,9.801106
06-07 19:25:09.091+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:09.091+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:09.091+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:09.091+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:09:100,0.037119,0.004979,0.059716
06-07 19:25:09.101+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:09:104,0.361316,-0.055035,9.860823
06-07 19:25:09.101+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:09:101,0.210000,0.070000,-0.070000
06-07 19:25:09.101+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:09.111+0200 I/gravity (30442): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:25:09:112,0.322974,-0.059188,9.801151
06-07 19:25:09.111+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:09.111+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope - capturing data
06-07 19:25:09.111+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:09.111+0200 I/light   (30467): es.ugr.frailty.light - capturing data
06-07 19:25:09.121+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:09:120,0.038342,0.016117,0.129064
06-07 19:25:09.121+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:25:09:123,0.361316,-0.043071,9.930215
06-07 19:25:09.121+0200 I/light   (30467): es.ugr.frailty.light: SM-R760,07/06/2018,19:25:09:122,6164.000000
06-07 19:25:09.121+0200 I/gyroscope(30393): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:25:09:121,-0.070000,-0.070000,-0.070000
06-07 19:25:09.121+0200 I/gravity (30442): es.ugr.frailty.gravity - capturing data
06-07 19:25:09.131+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:09.141+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:09:141,0.012233,0.001724,0.200918
06-07 19:25:09.151+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration - capturing data
06-07 19:25:09.151+0200 I/linearacceleration(30431): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:25:09:161,0.013099,0.030709,0.083803
06-07 19:25:09.161+0200 I/accelerometer(30390): es.ugr.frailty.accelerometer - capturing data
06-07 19:25:09.161+0200 W/CRASH_MANAGER(30257): worker.c: worker_job(1205) > 11304286c6f63152839230
