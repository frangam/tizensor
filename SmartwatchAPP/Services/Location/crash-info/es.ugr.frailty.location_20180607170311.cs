S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 15042
Date: 2018-06-07 17:03:11+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf73de52d, r5   = 0xf7a68f98
r6   = 0xffb19a70, r7   = 0xffb19920
r8   = 0xf7a65c18, r9   = 0x00000000
r10  = 0xffb199fc, fp   = 0xffb19a70
ip   = 0x00000001, sp   = 0xffb198f8
lr   = 0xf73de539, pc   = 0xf7447228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     43924 KB
Buffers:      9600 KB
Cached:      51204 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11540 KB
VmRSS:       11540 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 15042 TID = 15042
15042 15047 

Maps Information
f42a9000 f4aa8000 rw-p [stack:15047]
f4aaf000 f4ab1000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ab9000 f4abd000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4ac6000 f4ac8000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4ad0000 f4ad3000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4ae2000 f4ae7000 r-xp /usr/lib/libsystem.so.0.0.0
f4af2000 f4af5000 r-xp /lib/libattr.so.1.1.0
f4afd000 f4b0d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b15000 f4b1e000 r-xp /usr/lib/libedbus.so.1.7.99
f4b26000 f4b27000 r-xp /usr/lib/libresponse.so.0.2.96
f4b30000 f4b35000 r-xp /usr/lib/libproc-stat.so.0.2.96
f63d7000 f64dd000 r-xp /usr/lib/libicuuc.so.57.1
f64f3000 f667b000 r-xp /usr/lib/libicui18n.so.57.1
f668b000 f6698000 r-xp /usr/lib/libail.so.0.1.0
f66a1000 f66a8000 r-xp /usr/lib/libminizip.so.1.0.0
f66b1000 f685a000 r-xp /usr/lib/libcrypto.so.1.0.0
f687a000 f68c1000 r-xp /usr/lib/libssl.so.1.0.0
f68cd000 f68cf000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f68d7000 f68de000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f68e7000 f68ee000 r-xp /lib/libcrypt-2.13.so
f691f000 f6922000 r-xp /lib/libcap.so.2.21
f692a000 f692c000 r-xp /usr/lib/libiri.so
f6934000 f697d000 r-xp /usr/lib/libmdm.so.1.2.69
f6985000 f698b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6993000 f69b6000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f69c0000 f69c2000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f69ca000 f69e7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f69f0000 f69f4000 r-xp /usr/lib/libsmack.so.1.0.0
f69fd000 f6a16000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a1f000 f6a27000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a2f000 f6a35000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a3e000 f6a40000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a49000 f6a59000 r-xp /lib/libresolv-2.13.so
f6a5d000 f6a75000 r-xp /usr/lib/liblzma.so.5.0.3
f6a7e000 f6a80000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a88000 f6aa2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6aaa000 f6ad9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ae2000 f6af1000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6afb000 f6b05000 r-xp /usr/lib/libsensord-shared.so
f6b0e000 f6be1000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6bec000 f6c02000 r-xp /lib/libz.so.1.2.5
f6c0a000 f6c0f000 r-xp /usr/lib/libffi.so.5.0.10
f6c17000 f6c18000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c20000 f6c30000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c38000 f6c51000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c59000 f6c5b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c63000 f6cd8000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ce2000 f6ce8000 r-xp /lib/librt-2.13.so
f6cf1000 f6d0f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d19000 f6d1a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d22000 f6d45000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d4d000 f6d52000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d5a000 f6d84000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d8d000 f6da4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6dac000 f6e15000 r-xp /lib/libm-2.13.so
f6e1e000 f6eb2000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ec5000 f6eca000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ed2000 f6ed9000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ee1000 f6f0b000 r-xp /usr/lib/libsensor.so.1.9.6
f6f14000 f6fe0000 r-xp /usr/lib/libxml2.so.2.7.8
f6fed000 f6fef000 r-xp /usr/lib/libiniparser.so.0
f6ff8000 f6ffe000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7007000 f70d7000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70d8000 f710c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7115000 f7151000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7159000 f715c000 r-xp /usr/lib/libbundle.so.0.1.22
f7164000 f716a000 r-xp /usr/lib/libappsvc.so.0.1.0
f7172000 f71b3000 r-xp /usr/lib/libeina.so.1.7.99
f71bc000 f71d3000 r-xp /usr/lib/libecore.so.1.7.99
f71ea000 f71f3000 r-xp /usr/lib/libvconf.so.0.2.45
f71fb000 f720f000 r-xp /lib/libpthread-2.13.so
f721a000 f7227000 r-xp /usr/lib/libaul.so.0.1.0
f7231000 f7233000 r-xp /lib/libdl-2.13.so
f723c000 f7247000 r-xp /lib/libunwind.so.8.0.1
f7274000 f727c000 r-xp /lib/libgcc_s-4.6.so.1
f727d000 f73a1000 r-xp /lib/libc-2.13.so
f73af000 f73b1000 r-xp /usr/lib/libdlog.so.0.0.0
f73b9000 f73c5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f73ce000 f73d3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f73db000 f73ea000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f73f2000 f73f6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f73ff000 f7402000 r-xp /usr/lib/libappcore-agent.so.1.1
f740a000 f740c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7414000 f7418000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7420000 f743d000 r-xp /lib/ld-2.13.so
f7446000 f7449000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7449000 f744d000 r-xp /usr/lib/libsys-assert.so
f7a35000 f7aa3000 rw-p [heap]
ffafb000 ffb1c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15042)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7447228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf73de539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70e53f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf70e3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf70efe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf70f5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf70f5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf712a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71251f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf70e3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf70efe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf70f5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf70f5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7127e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7128017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf712ff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4ac71fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4aba171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6b8d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf703afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf703c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf71ccca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf71c7b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71c85a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf71c8879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7400183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74007fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74475c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf729485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7446f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
0 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:10.451+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:10.451+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:10:456,2.572284,-0.468993,9.537791
06-07 17:03:10.451+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:10:457,2.621148,-0.484590,9.437433
06-07 17:03:10.461+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.461+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:10.471+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:10:473,0.006172,-0.041831,0.074037
06-07 17:03:10.471+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:473,0.210000,-0.910000,0.980000
06-07 17:03:10.471+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:10.471+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:10.471+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:10:478,2.627320,-0.526421,9.511470
06-07 17:03:10.471+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:10:479,2.619675,-0.486436,9.437747
06-07 17:03:10.481+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.481+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:10.481+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:10:489,-0.021069,-0.006485,0.073723
06-07 17:03:10.481+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:489,1.400000,-0.420000,0.770000
06-07 17:03:10.491+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:10.491+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:10.491+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:10:496,2.610150,-0.484086,9.440506
06-07 17:03:10.491+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:10:496,2.598605,-0.492921,9.511470
06-07 17:03:10.501+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.501+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:10.511+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:511,1.330000,-0.420000,0.700000
06-07 17:03:10.511+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:03:10.511+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:10.511+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:03:10:518,82
06-07 17:03:10.511+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:10:518,2.598482,-0.479356,9.443966
06-07 17:03:10.511+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:10:512,-0.080937,0.046199,0.087714
06-07 17:03:10.521+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:10.521+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:10:526,2.529213,-0.437887,9.528220
06-07 17:03:10.521+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.521+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:10.531+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:534,1.190000,-0.630000,0.420000
06-07 17:03:10.531+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:10:535,2.588215,-0.475948,9.446958
06-07 17:03:10.531+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:03:10.531+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:10.541+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:03:10:541,673.000000
06-07 17:03:10.541+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:10.541+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:10.541+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.571+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:10:548,2.507678,-0.454636,9.501899
06-07 17:03:10.571+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:10.631+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:10:636,2.605784,-0.437887,9.533006
06-07 17:03:10.631+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:10.641+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:10:642,2.672783,-0.464208,9.540184
06-07 17:03:10.641+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:10.641+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:10:649,2.622534,-0.435494,9.535398
06-07 17:03:10.641+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:10.651+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:10:655,2.627320,-0.433101,9.578469
06-07 17:03:10.661+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:10.681+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:552,1.540000,-0.700000,0.280000
06-07 17:03:10.681+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:10:667,2.687140,-0.406780,9.513863
06-07 17:03:10.681+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:10:544,-0.090804,0.024719,0.057933
06-07 17:03:10.691+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.691+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:10.691+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:10.701+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:10:562,2.580857,-0.471047,9.449216
06-07 17:03:10.701+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:10.711+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:03:10.711+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:03:10:718,82
06-07 17:03:10.711+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:703,1.610000,-0.630000,0.070000
06-07 17:03:10.721+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:03:10.731+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:03:10:735,677.000000
06-07 17:03:10.751+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:10:743,2.576380,-0.467354,9.450621
06-07 17:03:10.761+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:10:711,0.017569,0.038061,0.086048
06-07 17:03:10.761+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.761+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:10:709,2.617748,-0.430708,9.456435
06-07 17:03:10.761+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:10.761+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:10.771+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:10:780,0.091926,0.006839,0.090968
06-07 17:03:10.771+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:10.781+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:775,1.330000,-0.350000,0.070000
06-07 17:03:10.781+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.781+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:791,1.610000,-0.490000,-0.700000
06-07 17:03:10.781+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:10:791,2.570840,-0.463030,9.452342
06-07 17:03:10.791+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.791+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:796,1.610000,-0.700000,-0.770000
06-07 17:03:10.791+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.791+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:10:787,2.584249,-0.428315,9.525827
06-07 17:03:10.801+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:801,1.260000,-0.420000,-0.700000
06-07 17:03:10.801+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:10.801+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.801+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:806,1.680000,-0.350000,-0.770000
06-07 17:03:10.801+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.801+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:10.811+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:10.811+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:812,1.750000,-0.350000,-0.840000
06-07 17:03:10.811+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.811+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:10:806,0.046154,0.031860,0.084778
06-07 17:03:10.811+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:818,2.240000,-0.280000,-0.770000
06-07 17:03:10.811+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.821+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:822,1.540000,-0.210000,-0.700000
06-07 17:03:10.821+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.821+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:827,0.980000,-0.210000,-0.700000
06-07 17:03:10.821+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:10:814,2.660819,-0.468993,9.537791
06-07 17:03:10.821+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.821+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:10.831+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:10:820,2.565118,-0.457922,9.454145
06-07 17:03:10.831+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:832,0.910000,-0.140000,-0.560000
06-07 17:03:10.831+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.831+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:10.831+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:10.831+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:838,-0.490000,-0.280000,-0.490000
06-07 17:03:10.831+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.841+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:843,0.490000,-0.280000,-0.490000
06-07 17:03:10.841+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.841+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:849,0.700000,-0.140000,-0.280000
06-07 17:03:10.841+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.851+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:10:833,0.056479,0.029929,0.126127
06-07 17:03:10.851+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:854,0.280000,-0.070000,-0.280000
06-07 17:03:10.851+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:10:850,2.563265,-0.451951,9.454935
06-07 17:03:10.851+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:10.851+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:10.851+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:10:845,2.651247,-0.397209,9.485149
06-07 17:03:10.851+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:10:861,2.560532,-0.448206,9.455853
06-07 17:03:10.861+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:10.861+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:10.861+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:10:867,2.553270,-0.443506,9.458039
06-07 17:03:10.861+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.861+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:10:865,0.122022,0.051142,0.059717
06-07 17:03:10.871+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:873,0.560000,-0.140000,-0.280000
06-07 17:03:10.871+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:10.871+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:10:876,2.636890,-0.334995,9.547362
06-07 17:03:10.871+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:10:879,2.549324,-0.440726,9.459233
06-07 17:03:10.871+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:10.881+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:10.881+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:10:883,2.542300,-0.433818,9.461443
06-07 17:03:10.881+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.881+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:10.881+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:889,0.700000,0.070000,-0.280000
06-07 17:03:10.881+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:10.891+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:10:887,0.052630,0.027214,0.002290
06-07 17:03:10.891+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:10:895,2.537455,-0.425617,9.463116
06-07 17:03:10.891+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:10.891+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:10:901,2.535629,-0.420191,9.463847
06-07 17:03:10.901+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:10.901+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:10.901+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.901+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:10:898,2.624927,-0.361316,9.544970
06-07 17:03:10.901+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:910,0.280000,0.070000,0.280000
06-07 17:03:10.911+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:10.911+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:03:10.911+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:03:10:918,82
06-07 17:03:10.911+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:10:906,2.534737,-0.415049,9.464314
06-07 17:03:10.911+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:10.921+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:10:909,0.023716,0.019890,0.069974
06-07 17:03:10.921+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:10.921+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:10:916,2.634498,-0.356531,9.501899
06-07 17:03:10.921+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:10:925,2.542296,-0.414158,9.462325
06-07 17:03:10.921+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:10.921+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:03:10.931+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:10:926,0.107549,-0.025487,0.079752
06-07 17:03:10.931+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.931+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:10.931+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:10.931+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:03:10:936,676.000000
06-07 17:03:10.941+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:938,-1.120000,0.070000,0.210000
06-07 17:03:10.941+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.951+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:10:932,2.634498,-0.380459,9.513863
06-07 17:03:10.951+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:10:942,2.546725,-0.417020,9.461008
06-07 17:03:10.951+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:10:939,0.101924,0.043518,0.025916
06-07 17:03:10.951+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:953,-1.820000,-0.070000,0.280000
06-07 17:03:10.951+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:10.951+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:10.951+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:10.961+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:10:960,2.670390,-0.500100,9.475577
06-07 17:03:10.961+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:10.961+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.961+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:10:964,2.546897,-0.415951,9.461009
06-07 17:03:10.961+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:10.971+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:10:960,0.094591,0.098822,0.085919
06-07 17:03:10.971+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:972,-0.630000,0.770000,0.210000
06-07 17:03:10.971+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:10.971+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:10:969,2.653640,-0.430708,9.549755
06-07 17:03:10.971+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:10.981+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:10:983,2.646462,-0.387637,9.511470
06-07 17:03:10.981+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:10:977,0.087472,0.064300,0.081854
06-07 17:03:10.981+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:10.981+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:10.981+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:10.991+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:10:974,2.549237,-0.413822,9.460472
06-07 17:03:10.991+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.001+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:10:991,-0.280000,0.420000,0.070000
06-07 17:03:11.001+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:10:988,0.098868,0.063660,0.038052
06-07 17:03:11.001+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.001+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:10:998,2.549471,-0.409321,9.460605
06-07 17:03:11.001+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.011+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:11,0.099761,0.034591,0.049549
06-07 17:03:11.011+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.011+0200 W/LOCATION(15042): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:03:11.011+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:11:14,2.549021,-0.403366,9.460981
06-07 17:03:11.011+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.021+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:11.021+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:11:25,2.548859,-0.397509,9.461273
06-07 17:03:11.021+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:20,0.128095,-0.085942,0.013252
06-07 17:03:11.031+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.031+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.031+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:11:39,2.560795,-0.396090,9.458109
06-07 17:03:11.031+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:11:30,-0.910000,0.490000,-0.210000
06-07 17:03:11.031+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.041+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:11.041+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:35,0.106915,-0.013689,0.088747
06-07 17:03:11.041+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:8,2.639283,-0.346959,9.506684
06-07 17:03:11.041+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.041+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:47,0.099565,0.028314,0.050461
06-07 17:03:11.041+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.041+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.051+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:11:44,2.574721,-0.399947,9.454165
06-07 17:03:11.051+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.051+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:52,0.090046,0.066863,0.046212
06-07 17:03:11.051+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:03:11.061+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:11:58,2.579618,-0.403406,9.452683
06-07 17:03:11.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:03:11.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:03:11.061+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.061+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:64,0.108955,0.091075,0.041294
06-07 17:03:11.061+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.071+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:11:72,2.585100,-0.405011,9.451117
06-07 17:03:11.071+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:11:47,-1.260000,0.350000,-0.350000
06-07 17:03:11.071+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:11.071+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:74,0.092655,0.109049,0.091166
06-07 17:03:11.071+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.081+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.081+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:54,2.658426,-0.318245,9.501899
06-07 17:03:11.081+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.081+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:11:85,2.592153,-0.406314,9.449129
06-07 17:03:11.081+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.091+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:84,0.138281,0.079263,-0.028767
06-07 17:03:11.091+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.091+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:11:86,-1.050000,1.400000,0.280000
06-07 17:03:11.091+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:95,2.641676,-0.294317,9.552148
06-07 17:03:11.091+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:11:95,2.600203,-0.404842,9.446980
06-07 17:03:11.091+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:11.091+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:96,0.095238,-0.005905,0.091646
06-07 17:03:11.101+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.101+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.101+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:11:110,2.606967,-0.396728,9.445460
06-07 17:03:11.101+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:11:105,-5.040000,1.890000,2.450000
06-07 17:03:11.111+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:107,0.076526,-0.049903,0.045340
06-07 17:03:11.111+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.111+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:03:11.111+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:03:11:119,82
06-07 17:03:11.111+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.121+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:11.121+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:117,2.687140,-0.318245,9.432507
06-07 17:03:11.121+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.121+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.121+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:129,0.129058,-0.027302,0.075537
06-07 17:03:11.131+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:03:11.131+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:03:11:136,676.000000
06-07 17:03:11.131+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:132,2.656033,-0.401994,9.549755
06-07 17:03:11.131+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.141+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:11:124,2.634972,-0.394545,9.437778
06-07 17:03:11.141+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:144,2.651247,-0.449851,9.499505
06-07 17:03:11.141+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.141+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:11:126,-9.730000,1.750000,4.340000
06-07 17:03:11.141+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.141+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:11.141+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:11:151,-11.200000,1.680000,4.900000
06-07 17:03:11.141+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:151,2.708675,-0.430708,9.528220
06-07 17:03:11.151+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.151+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.151+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:156,0.066147,0.005410,0.057961
06-07 17:03:11.151+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.151+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:157,2.651247,-0.399601,9.509077
06-07 17:03:11.151+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.151+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:161,0.027988,0.078497,0.062341
06-07 17:03:11.151+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.161+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:163,2.620141,-0.327817,9.511470
06-07 17:03:11.161+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.161+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:11:148,2.688113,-0.407724,9.422218
06-07 17:03:11.161+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:11.161+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:169,2.694318,-0.191426,9.437292
06-07 17:03:11.161+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:11:171,-9.450000,0.350000,3.290000
06-07 17:03:11.171+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.171+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.171+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:11:175,2.737835,-0.432542,9.406782
06-07 17:03:11.171+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:176,2.689533,-0.124427,9.387043
06-07 17:03:11.171+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.171+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.171+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:181,2.696711,-0.239282,9.559326
06-07 17:03:11.181+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.181+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:165,0.094115,0.213416,-0.009688
06-07 17:03:11.181+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:11.181+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:187,2.581856,-0.437887,9.667004
06-07 17:03:11.181+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.181+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:11:190,-4.690000,-0.210000,1.260000
06-07 17:03:11.181+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:11.191+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:194,2.395216,-0.777667,9.745967
06-07 17:03:11.191+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:11:180,2.758482,-0.468295,9.399035
06-07 17:03:11.191+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.191+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:11:199,2.774504,-0.487315,9.393351
06-07 17:03:11.191+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.191+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.201+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.201+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:205,2.644069,-0.665205,9.422935
06-07 17:03:11.201+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:11:195,-2.170000,2.240000,-1.960000
06-07 17:03:11.201+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:11.211+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:206,0.082566,0.272301,-0.058417
06-07 17:03:11.211+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.211+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.211+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:217,0.061739,0.155263,0.121549
06-07 17:03:11.211+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:217,2.641676,-0.540778,9.468399
06-07 17:03:11.211+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.211+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:222,-0.106257,-0.030162,0.244785
06-07 17:03:11.221+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.221+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:11:213,-1.890000,3.780000,-1.680000
06-07 17:03:11.221+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:11.221+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:11:228,-4.200000,3.010000,-1.960000
06-07 17:03:11.231+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:11:204,2.777470,-0.493071,9.392174
06-07 17:03:11.231+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.231+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:232,2.510071,-0.411566,9.346365
06-07 17:03:11.231+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.231+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:11:237,2.772659,-0.492088,9.393646
06-07 17:03:11.231+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.241+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.241+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:11.241+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:246,-0.342620,-0.345126,0.339185
06-07 17:03:11.241+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.241+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:242,2.596212,-0.495314,9.473185
06-07 17:03:11.251+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:251,-0.114413,-0.196910,0.023900
06-07 17:03:11.251+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.251+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.251+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:11:249,-4.830000,3.990000,-1.330000
06-07 17:03:11.251+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:256,-0.132828,-0.053463,0.075048
06-07 17:03:11.251+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.251+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:260,2.490928,-0.617348,9.681360
06-07 17:03:11.251+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:260,-0.267399,0.081506,-0.045809
06-07 17:03:11.251+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.261+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:11:242,2.783976,-0.499407,9.389913
06-07 17:03:11.261+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.261+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:11.261+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:11:267,2.783461,-0.513117,9.389326
06-07 17:03:11.261+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.261+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.271+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:11:272,2.774567,-0.532974,9.390852
06-07 17:03:11.271+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.271+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:11:267,-3.990000,2.520000,-1.120000
06-07 17:03:11.271+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:11:277,2.774479,-0.545186,9.390177
06-07 17:03:11.271+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:11.271+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:265,-0.176447,-0.003226,0.079538
06-07 17:03:11.281+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.281+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:11:285,-2.660000,1.470000,-0.630000
06-07 17:03:11.281+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:286,-0.293047,-0.117941,0.291448
06-07 17:03:11.281+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.281+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:278,2.438286,-0.784846,9.583255
06-07 17:03:11.281+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.281+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:11:291,2.764461,-0.554193,9.392604
06-07 17:03:11.291+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.291+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:11.291+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:296,-0.345174,-0.271728,0.193929
06-07 17:03:11.291+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.291+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:301,-0.178355,-0.153766,-0.015773
06-07 17:03:11.301+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.301+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:295,2.596212,-0.686740,9.375079
06-07 17:03:11.301+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:306,-0.161516,-0.160697,0.071044
06-07 17:03:11.301+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.301+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:11:301,-1.120000,2.310000,-0.770000
06-07 17:03:11.301+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.301+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:11:311,2.750942,-0.553874,9.396591
06-07 17:03:11.311+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:03:11.311+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.311+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:03:11:319,82
06-07 17:03:11.311+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:320,-0.151499,0.011022,-0.055810
06-07 17:03:11.311+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:11.321+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:11:325,-0.280000,3.710000,0.140000
06-07 17:03:11.321+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:319,2.612962,-0.705883,9.461221
06-07 17:03:11.331+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.331+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.331+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:03:11.331+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:336,2.612962,-0.543171,9.336794
06-07 17:03:11.331+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.331+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:11:340,2.757399,-0.561818,9.394227
06-07 17:03:11.331+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:03:11:336,670.000000
06-07 17:03:11.331+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:341,2.586641,-0.538385,9.315259
06-07 17:03:11.341+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.341+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:11.341+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:346,-0.164301,0.015489,-0.081332
06-07 17:03:11.341+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.341+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:03:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:03:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:03:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:03:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:03:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:03:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:03:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:03:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:03:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:03:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:03:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:03:11.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390991353,000000, pattern:[H:mm][0;m
06-07 17:03:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:03:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:03:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:03:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:03:11.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:03:11.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:03][0;m
06-07 17:03:11.341+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:351,2.801995,-0.540778,9.595219
06-07 17:03:11.351+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.351+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:357,0.044596,0.021041,0.200992
06-07 17:03:11.351+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:11:352,2.768875,-0.569221,9.390405
06-07 17:03:11.361+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:11:350,-4.550000,4.200000,0.210000
06-07 17:03:11.361+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:11.361+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.361+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:11:367,-4.830000,4.970000,0.770000
06-07 17:03:11.361+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:11.371+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:11:375,-6.510000,7.560000,0.280000
06-07 17:03:11.371+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.371+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.381+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:381,-0.225305,-0.033770,-0.156502
06-07 17:03:11.381+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.381+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:11.391+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:393,-0.323697,0.008775,0.171268
06-07 17:03:11.391+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:373,2.543570,-0.602991,9.233903
06-07 17:03:11.401+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.411+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:412,-0.332296,-0.013145,0.162259
06-07 17:03:11.411+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:11.411+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:11:393,-5.390000,6.650000,0.700000
06-07 17:03:11.411+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:11:385,2.773948,-0.583052,9.388059
06-07 17:03:11.411+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:11.421+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:11:421,2.450250,-0.574277,9.559326
06-07 17:03:11.421+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.431+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:03:11.431+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:11:435,-0.380969,0.067092,0.246794
06-07 17:03:11.441+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:11.451+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:11:425,-3.360000,8.190000,1.050000
06-07 17:03:11.461+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11150426c6f63152838379
