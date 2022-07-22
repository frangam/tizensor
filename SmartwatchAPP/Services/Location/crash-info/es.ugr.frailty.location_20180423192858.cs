S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 15453
Date: 2018-04-23 19:28:58+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf709652d, r5   = 0xf782df98
r6   = 0xfffc8960, r7   = 0xfffc8810
r8   = 0xf782ac18, r9   = 0x00000000
r10  = 0xfffc88ec, fp   = 0xfffc8960
ip   = 0x00000001, sp   = 0xfffc87e8
lr   = 0xf7096539, pc   = 0xf70ff228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      8300 KB
Buffers:     52780 KB
Cached:     235140 KB
VmPeak:      52512 KB
VmSize:      52508 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11740 KB
VmRSS:       11740 KB
VmData:      10236 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 15453 TID = 15453
15453 15482 

Maps Information
f3f61000 f4760000 rw-p [stack:15482]
f4767000 f4769000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4771000 f4775000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f477e000 f4780000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4788000 f478b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f479a000 f479f000 r-xp /usr/lib/libsystem.so.0.0.0
f47aa000 f47ad000 r-xp /lib/libattr.so.1.1.0
f47b5000 f47c5000 r-xp /usr/lib/libmdm-common.so.1.1.24
f47cd000 f47d6000 r-xp /usr/lib/libedbus.so.1.7.99
f47de000 f47df000 r-xp /usr/lib/libresponse.so.0.2.96
f47e8000 f47ed000 r-xp /usr/lib/libproc-stat.so.0.2.96
f608f000 f6195000 r-xp /usr/lib/libicuuc.so.57.1
f61ab000 f6333000 r-xp /usr/lib/libicui18n.so.57.1
f6343000 f6350000 r-xp /usr/lib/libail.so.0.1.0
f6359000 f6360000 r-xp /usr/lib/libminizip.so.1.0.0
f6369000 f6512000 r-xp /usr/lib/libcrypto.so.1.0.0
f6532000 f6579000 r-xp /usr/lib/libssl.so.1.0.0
f6585000 f6587000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f658f000 f6596000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f659f000 f65a6000 r-xp /lib/libcrypt-2.13.so
f65d7000 f65da000 r-xp /lib/libcap.so.2.21
f65e2000 f65e4000 r-xp /usr/lib/libiri.so
f65ec000 f6635000 r-xp /usr/lib/libmdm.so.1.2.69
f663d000 f6643000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f664b000 f666e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6678000 f667a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6682000 f669f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66a8000 f66ac000 r-xp /usr/lib/libsmack.so.1.0.0
f66b5000 f66ce000 r-xp /usr/lib/libnetwork.so.0.0.0
f66d7000 f66df000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f66e7000 f66ed000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f66f6000 f66f8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6701000 f6711000 r-xp /lib/libresolv-2.13.so
f6715000 f672d000 r-xp /usr/lib/liblzma.so.5.0.3
f6736000 f6738000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6740000 f675a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6762000 f6791000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f679a000 f67a9000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67b3000 f67bd000 r-xp /usr/lib/libsensord-shared.so
f67c6000 f6899000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68a4000 f68ba000 r-xp /lib/libz.so.1.2.5
f68c2000 f68c7000 r-xp /usr/lib/libffi.so.5.0.10
f68cf000 f68d0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f68d8000 f68e8000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f68f0000 f6909000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6911000 f6913000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f691b000 f6990000 r-xp /usr/lib/libsqlite3.so.0.8.6
f699a000 f69a0000 r-xp /lib/librt-2.13.so
f69a9000 f69c7000 r-xp /usr/lib/libsystemd.so.0.4.0
f69d1000 f69d2000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f69da000 f69fd000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a05000 f6a0a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a12000 f6a3c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a45000 f6a5c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a64000 f6acd000 r-xp /lib/libm-2.13.so
f6ad6000 f6b6a000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b7d000 f6b82000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b8a000 f6b91000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6b99000 f6bc3000 r-xp /usr/lib/libsensor.so.1.9.6
f6bcc000 f6c98000 r-xp /usr/lib/libxml2.so.2.7.8
f6ca5000 f6ca7000 r-xp /usr/lib/libiniparser.so.0
f6cb0000 f6cb6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6cbf000 f6d8f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d90000 f6dc4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6dcd000 f6e09000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e11000 f6e14000 r-xp /usr/lib/libbundle.so.0.1.22
f6e1c000 f6e22000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e2a000 f6e6b000 r-xp /usr/lib/libeina.so.1.7.99
f6e74000 f6e8b000 r-xp /usr/lib/libecore.so.1.7.99
f6ea2000 f6eab000 r-xp /usr/lib/libvconf.so.0.2.45
f6eb3000 f6ec7000 r-xp /lib/libpthread-2.13.so
f6ed2000 f6edf000 r-xp /usr/lib/libaul.so.0.1.0
f6ee9000 f6eeb000 r-xp /lib/libdl-2.13.so
f6ef4000 f6eff000 r-xp /lib/libunwind.so.8.0.1
f6f2c000 f6f34000 r-xp /lib/libgcc_s-4.6.so.1
f6f35000 f7059000 r-xp /lib/libc-2.13.so
f7067000 f7069000 r-xp /usr/lib/libdlog.so.0.0.0
f7071000 f707d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7086000 f708b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7093000 f70a2000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70aa000 f70ae000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70b7000 f70ba000 r-xp /usr/lib/libappcore-agent.so.1.1
f70c2000 f70c4000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f70cc000 f70d0000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f70d8000 f70f5000 r-xp /lib/ld-2.13.so
f70fe000 f7101000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7101000 f7105000 r-xp /usr/lib/libsys-assert.so
f77fa000 f7884000 rw-p [heap]
fffaa000 fffcb000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15453)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf70ff228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7096539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6d9d3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6d9bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6da7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6dadbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6daddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6de275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6ddd1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6d9bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6da7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6dadbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6daddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6ddfe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6de0017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6de7f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf477f1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4772171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6845663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6cf2fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6cf47a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e84ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e7fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e805a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e80879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70b8183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70b87fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70ff4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6f4c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf70fef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
8:57.319+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:319,2.153540,-2.376073,9.372685
04-23 19:28:57.319+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.319+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:328,2.100105,-2.281562,9.303463
04-23 19:28:57.319+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.319+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:323,1.960000,0.770000,0.700000
04-23 19:28:57.329+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:331,2.103002,-2.282637,9.302545
04-23 19:28:57.329+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.329+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.329+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:330,0.052372,-0.089824,0.070614
04-23 19:28:57.329+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.329+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:335,2.215754,-2.316252,9.355937
04-23 19:28:57.339+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.339+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:340,0.116640,-0.031241,0.053097
04-23 19:28:57.339+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.339+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:337,1.400000,0.630000,0.420000
04-23 19:28:57.339+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.339+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.339+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:348,2.106126,-2.283892,9.301530
04-23 19:28:57.349+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:345,2.261217,-2.285146,9.320045
04-23 19:28:57.349+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:345,0.160119,-0.002786,0.017002
04-23 19:28:57.349+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.349+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:348,0.840000,0.560000,0.350000
04-23 19:28:57.349+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.349+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.349+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:354,0.042679,-0.048305,0.060597
04-23 19:28:57.349+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.349+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:358,0.840000,0.840000,0.350000
04-23 19:28:57.349+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:358,0.029663,-0.049239,0.038529
04-23 19:28:57.349+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.359+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:356,2.148755,-2.328217,9.363115
04-23 19:28:57.359+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.359+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.359+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:362,0.100962,-0.114297,0.069094
04-23 19:28:57.359+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.359+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.359+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:366,-0.010478,-0.105053,0.129730
04-23 19:28:57.359+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.359+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:367,2.106223,-2.286372,9.300899
04-23 19:28:57.369+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:370,0.077364,-0.039476,-0.019311
04-23 19:28:57.369+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.369+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:365,2.134398,-2.328217,9.341579
04-23 19:28:57.369+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:374,0.098395,-0.050365,-0.004036
04-23 19:28:57.369+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.369+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:371,0.700000,0.980000,0.420000
04-23 19:28:57.369+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.369+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.369+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:377,0.052200,-0.080217,0.056800
04-23 19:28:57.379+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:381,0.700000,0.770000,0.210000
04-23 19:28:57.379+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:379,2.203789,-2.392823,9.372685
04-23 19:28:57.379+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.379+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.379+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.379+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.379+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:387,2.103478,-2.291871,9.300166
04-23 19:28:57.379+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:387,-0.005325,-0.142343,0.035895
04-23 19:28:57.389+0200 I/heartrate(15180): capturing data from es.ugr.frailty.heartrate
04-23 19:28:57.389+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:385,2.093720,-2.385644,9.432507
04-23 19:28:57.389+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.389+0200 I/heartrate(15180): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:28:57:395,75
04-23 19:28:57.389+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:395,2.177469,-2.321038,9.284152
04-23 19:28:57.389+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.389+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:385,0.840000,0.700000,0.070000
04-23 19:28:57.389+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.389+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:399,2.201397,-2.333002,9.298509
04-23 19:28:57.389+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.399+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:401,0.280000,0.210000,0.070000
04-23 19:28:57.399+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.399+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:402,2.158326,-2.364109,9.358330
04-23 19:28:57.399+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.399+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:405,0.210000,0.490000,0.140000
04-23 19:28:57.399+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.399+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:406,2.100898,-2.428715,9.336794
04-23 19:28:57.399+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.399+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.409+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.409+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:411,2.201397,-2.407180,9.370294
04-23 19:28:57.409+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:413,2.104543,-2.292976,9.299653
04-23 19:28:57.409+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:410,-0.140000,0.770000,0.210000
04-23 19:28:57.409+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.409+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:411,0.097918,-0.115309,0.070127
04-23 19:28:57.409+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:419,-0.140000,0.910000,0.350000
04-23 19:28:57.419+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.419+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.419+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.419+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.419+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:426,2.120041,-2.297110,9.367901
04-23 19:28:57.419+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:423,1.400000,0.490000,0.490000
04-23 19:28:57.419+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.429+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:430,0.015498,-0.004134,0.068248
04-23 19:28:57.429+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:432,1.890000,0.280000,0.350000
04-23 19:28:57.429+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:427,2.102248,-2.288486,9.301278
04-23 19:28:57.439+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.439+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.439+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:448,1.750000,0.210000,0.490000
04-23 19:28:57.439+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:448,2.208575,-2.364109,9.367901
04-23 19:28:57.439+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.449+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.449+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:453,0.106327,-0.075623,0.066623
04-23 19:28:57.459+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.459+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.459+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:468,0.840000,0.420000,0.490000
04-23 19:28:57.469+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:452,2.104062,-2.287439,9.301126
04-23 19:28:57.469+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.469+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:471,2.167897,-2.366502,9.379865
04-23 19:28:57.469+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.469+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:473,2.104208,-2.288123,9.300924
04-23 19:28:57.469+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:477,0.063835,-0.079063,0.078739
04-23 19:28:57.479+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.479+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.479+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:487,0.560000,-0.140000,0.210000
04-23 19:28:57.479+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:487,2.151148,-2.404787,9.300901
04-23 19:28:57.479+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.479+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.489+0200 I/heartrate(15180): capturing data from es.ugr.frailty.heartrate
04-23 19:28:57.489+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:492,2.105799,-2.292346,9.299524
04-23 19:28:57.489+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:492,0.046940,-0.116664,-0.000023
04-23 19:28:57.489+0200 I/heartrate(15180): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:28:57:495,74
04-23 19:28:57.499+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.499+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.509+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:511,1.750000,0.490000,-0.490000
04-23 19:28:57.509+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.509+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.509+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:516,2.109939,-2.288309,9.299580
04-23 19:28:57.509+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:516,0.141062,-0.009549,-0.008194
04-23 19:28:57.509+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:512,2.246860,-2.301895,9.291330
04-23 19:28:57.519+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.519+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.519+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:526,1.960000,0.980000,-0.420000
04-23 19:28:57.519+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.519+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.519+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:527,0.005316,0.039056,0.128141
04-23 19:28:57.529+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:532,2.115255,-2.249253,9.427721
04-23 19:28:57.529+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:531,2.105613,-2.280046,9.302589
04-23 19:28:57.539+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.539+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.539+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:547,1.120000,0.490000,-0.070000
04-23 19:28:57.539+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.539+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:548,0.016820,0.049935,0.151453
04-23 19:28:57.549+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.549+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:555,2.122434,-2.230111,9.454042
04-23 19:28:57.559+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.559+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.569+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:567,0.067143,-0.069178,0.065519
04-23 19:28:57.569+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:552,2.103147,-2.273396,9.304774
04-23 19:28:57.569+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.569+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:573,2.170290,-2.342573,9.370294
04-23 19:28:57.579+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.589+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.589+0200 I/heartrate(15180): capturing data from es.ugr.frailty.heartrate
04-23 19:28:57.589+0200 I/heartrate(15180): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:28:57:596,74
04-23 19:28:57.599+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:583,2.104752,-2.275266,9.303954
04-23 19:28:57.599+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:588,0.079895,-0.141485,-0.034160
04-23 19:28:57.599+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:593,2.184647,-2.416751,9.269794
04-23 19:28:57.599+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.609+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.609+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:614,0.210000,0.140000,0.350000
04-23 19:28:57.619+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.619+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.619+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.619+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:628,2.189433,-2.407180,9.265009
04-23 19:28:57.629+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:612,0.082004,-0.125853,-0.036856
04-23 19:28:57.629+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.629+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:633,0.140000,0.350000,0.350000
04-23 19:28:57.639+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:624,2.107429,-2.281327,9.301865
04-23 19:28:57.639+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.649+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.649+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.649+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:655,2.148755,-2.232504,9.377472
04-23 19:28:57.649+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:642,0.039572,0.052805,0.076982
04-23 19:28:57.659+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.659+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:649,2.109182,-2.285309,9.300489
04-23 19:28:57.659+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:659,0.560000,0.770000,0.070000
04-23 19:28:57.659+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.659+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.669+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:672,0.980000,0.700000,-0.420000
04-23 19:28:57.669+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.669+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.669+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:677,1.330000,0.980000,0.210000
04-23 19:28:57.669+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.679+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:669,0.047620,0.044231,0.072876
04-23 19:28:57.679+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.679+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:681,0.700000,0.700000,0.560000
04-23 19:28:57.679+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:673,2.108313,-2.279127,9.302203
04-23 19:28:57.679+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.679+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:686,0.034916,-0.129700,0.135534
04-23 19:28:57.679+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:687,-0.420000,0.280000,0.560000
04-23 19:28:57.679+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:677,2.155933,-2.234896,9.375079
04-23 19:28:57.679+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.679+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.689+0200 I/heartrate(15180): capturing data from es.ugr.frailty.heartrate
04-23 19:28:57.689+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:692,2.141576,-2.402394,9.439686
04-23 19:28:57.689+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.689+0200 I/heartrate(15180): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:28:57:695,74
04-23 19:28:57.689+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:697,2.158326,-2.385644,9.322437
04-23 19:28:57.689+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.699+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:693,2.106661,-2.272694,9.304152
04-23 19:28:57.699+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.699+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:702,0.053940,-0.110531,0.018363
04-23 19:28:57.699+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:705,2.104386,-2.275113,9.304074
04-23 19:28:57.699+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.699+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.699+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.709+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.709+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:711,0.195952,-0.107451,0.005698
04-23 19:28:57.709+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:713,2.301895,-2.388037,9.308081
04-23 19:28:57.709+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:712,-0.840000,0.070000,0.070000
04-23 19:28:57.719+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:710,2.105944,-2.280586,9.302382
04-23 19:28:57.719+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.719+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.719+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.729+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.729+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:736,-0.011647,-0.022437,0.085794
04-23 19:28:57.739+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:723,2.114938,-2.286637,9.298856
04-23 19:28:57.739+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.739+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.739+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:748,0.036474,-0.025292,0.055233
04-23 19:28:57.749+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:743,2.103291,-2.309074,9.384650
04-23 19:28:57.749+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:727,0.770000,1.470000,0.070000
04-23 19:28:57.749+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.759+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:746,2.109888,-2.283782,9.300704
04-23 19:28:57.759+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.759+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.769+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:768,0.087076,-0.059169,0.142466
04-23 19:28:57.769+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:766,2.107143,-2.281012,9.302006
04-23 19:28:57.769+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.769+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:778,2.107461,-2.280912,9.301959
04-23 19:28:57.779+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.779+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:783,2.146362,-2.309074,9.355937
04-23 19:28:57.779+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.779+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:787,0.129828,-0.049698,0.063549
04-23 19:28:57.779+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:762,0.910000,1.470000,0.140000
04-23 19:28:57.779+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.789+0200 I/heartrate(15180): capturing data from es.ugr.frailty.heartrate
04-23 19:28:57.789+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:792,0.210000,0.840000,0.420000
04-23 19:28:57.789+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.789+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:796,1.120000,0.840000,0.490000
04-23 19:28:57.789+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.799+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:800,2.194218,-2.340181,9.444471
04-23 19:28:57.799+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.799+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:804,2.237289,-2.330609,9.365508
04-23 19:28:57.799+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.799+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.799+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.809+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:812,0.108487,0.106666,-0.142119
04-23 19:28:57.809+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:808,2.109660,-2.279349,9.301844
04-23 19:28:57.809+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.819+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.819+0200 I/heartrate(15180): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:28:57:808,75
04-23 19:28:57.829+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:28:57.829+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:28:57.829+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:28:57.829+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:826,0.021406,0.040133,-0.096956
04-23 19:28:57.829+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.829+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:838,2.218147,-2.172683,9.159724
04-23 19:28:57.829+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:811,-0.140000,1.470000,0.910000
04-23 19:28:57.839+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.839+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.839+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:848,0.011314,-0.109637,0.111033
04-23 19:28:57.839+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:818,2.112992,-2.275029,9.302145
04-23 19:28:57.839+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.849+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:853,2.111120,-2.276007,9.302330
04-23 19:28:57.849+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.849+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:858,2.134398,-2.234896,9.205189
04-23 19:28:57.849+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:844,-1.680000,2.310000,1.470000
04-23 19:28:57.849+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.859+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:862,-0.630000,2.450000,1.330000
04-23 19:28:57.859+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.859+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:867,0.041046,-0.077763,0.218170
04-23 19:28:57.859+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.869+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.869+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:874,2.122434,-2.385644,9.413363
04-23 19:28:57.869+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:872,2.105316,-2.279167,9.302872
04-23 19:28:57.869+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.879+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:881,2.030000,1.960000,0.140000
04-23 19:28:57.879+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.879+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.879+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:888,-0.007819,-0.283665,0.189254
04-23 19:28:57.889+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.889+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:891,2.099146,-2.274262,9.305467
04-23 19:28:57.889+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.899+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.899+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:894,2.146362,-2.356930,9.521042
04-23 19:28:57.899+0200 I/heartrate(15180): capturing data from es.ugr.frailty.heartrate
04-23 19:28:57.899+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.899+0200 I/heartrate(15180): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:28:57:908,74
04-23 19:28:57.909+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.909+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:912,0.034183,-0.185677,0.011365
04-23 19:28:57.909+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:902,3.570000,0.420000,-0.910000
04-23 19:28:57.909+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.909+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:914,2.091327,-2.557927,9.494720
04-23 19:28:57.909+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.909+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:918,3.990000,-0.420000,-1.680000
04-23 19:28:57.909+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:919,2.127219,-2.462214,9.317651
04-23 19:28:57.919+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:909,2.093036,-2.276538,9.306286
04-23 19:28:57.919+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.919+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.919+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:924,2.092374,-2.276081,9.306546
04-23 19:28:57.919+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.919+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:927,0.044417,-0.097599,0.070926
04-23 19:28:57.919+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:928,2.089976,-2.268910,9.308836
04-23 19:28:57.919+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.919+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.929+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:932,4.620000,0.280000,-2.100000
04-23 19:28:57.929+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:932,2.136791,-2.373680,9.377472
04-23 19:28:57.939+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.939+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.939+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:948,1.680000,-1.120000,-2.590000
04-23 19:28:57.939+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.939+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:948,0.085100,0.029228,0.054279
04-23 19:28:57.949+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.949+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:952,2.095380,-2.263269,9.308994
04-23 19:28:57.949+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:954,2.175076,-2.239682,9.363115
04-23 19:28:57.959+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.959+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.959+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:968,0.156266,0.035552,0.003872
04-23 19:28:57.969+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.969+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.979+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:57:973,2.251646,-2.227718,9.312866
04-23 19:28:57.979+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:57:975,2.102058,-2.254151,9.309701
04-23 19:28:57.979+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:57.979+0200 W/LOCATION(15453): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:28:57.989+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:57:990,0.017983,0.093432,0.062984
04-23 19:28:57.989+0200 I/heartrate(15180): capturing data from es.ugr.frailty.heartrate
04-23 19:28:57.989+0200 I/heartrate(15180): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:28:57:995,74
04-23 19:28:57.989+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:57.989+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:57:968,2.870000,-0.280000,-3.290000
04-23 19:28:57.989+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.999+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:57.999+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:58:3,2.096933,-2.237359,9.314906
04-23 19:28:57.999+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:58:0,2.120041,-2.160719,9.372685
04-23 19:28:57.999+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:58:1,4.550000,1.400000,-2.520000
04-23 19:28:57.999+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:57.999+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:58.009+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:58.009+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:58:12,2.380000,0.980000,-1.750000
04-23 19:28:58.009+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:58:12,0.030287,0.045533,0.057779
04-23 19:28:58.009+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:58:17,2.127219,-2.191825,9.372685
04-23 19:28:58.009+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:58.019+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:58:21,2.094626,-2.227972,9.317675
04-23 19:28:58.019+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:58.019+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:58.019+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:58:27,0.080449,-0.014103,-0.026344
04-23 19:28:58.019+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:58.029+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:58.029+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:58:34,2.175076,-2.242075,9.291330
04-23 19:28:58.029+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:58:27,0.770000,1.260000,-0.630000
04-23 19:28:58.029+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:58:31,2.095561,-2.225596,9.318032
04-23 19:28:58.039+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:58.039+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:58.039+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:58:47,-0.630000,1.820000,0.630000
04-23 19:28:58.049+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:58:48,0.034051,-0.109799,-0.079345
04-23 19:28:58.049+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:58.049+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:58.049+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:58:57,2.129612,-2.335395,9.238688
04-23 19:28:58.059+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:58:55,2.094264,-2.231073,9.317015
04-23 19:28:58.059+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:58.059+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:58.059+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:58:67,-0.630000,1.680000,1.190000
04-23 19:28:58.059+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:58:67,0.044919,-0.188071,0.007815
04-23 19:28:58.069+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:58.069+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:58.069+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:58:73,2.092492,-2.239445,9.315404
04-23 19:28:58.079+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:58:77,2.139183,-2.419144,9.324830
04-23 19:28:58.079+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:58.079+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:58.079+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:58:87,1.540000,1.610000,0.630000
04-23 19:28:58.079+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:58:87,0.065834,-0.220377,0.138638
04-23 19:28:58.089+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:58.089+0200 I/heartrate(15180): capturing data from es.ugr.frailty.heartrate
04-23 19:28:58.089+0200 I/heartrate(15180): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:28:58:95,74
04-23 19:28:58.089+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:58.099+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:58:93,2.088846,-2.243150,9.315331
04-23 19:28:58.099+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:58:103,2.158326,-2.459821,9.454042
04-23 19:28:58.099+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:58.099+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:58.109+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:58:111,1.960000,0.630000,0.490000
04-23 19:28:58.109+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:58:112,0.122123,-0.087459,0.145890
04-23 19:28:58.109+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:58.109+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:58.119+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:58:117,2.089511,-2.240939,9.315714
04-23 19:28:58.119+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:58.119+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:58.119+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:58:127,1.470000,-0.070000,0.490000
04-23 19:28:58.119+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:58:127,0.133422,-0.077706,0.126365
04-23 19:28:58.119+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:58.129+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:58:133,2.092715,-2.240174,9.315179
04-23 19:28:58.129+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:58:120,2.210968,-2.330609,9.461221
04-23 19:28:58.129+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:58.139+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:58:138,2.222932,-2.318645,9.442079
04-23 19:28:58.139+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:58.139+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:58.139+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:58:147,0.490000,0.560000,0.560000
04-23 19:28:58.149+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:58:148,0.108682,0.026813,0.047936
04-23 19:28:58.149+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:58.149+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:58.149+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:58:155,2.095376,-2.236971,9.315350
04-23 19:28:58.149+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:58:155,2.201397,-2.213361,9.363115
04-23 19:28:58.159+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:58.159+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:58.159+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:58:167,-0.490000,1.400000,0.350000
04-23 19:28:58.159+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:58:167,0.113199,0.100181,-0.026412
04-23 19:28:58.159+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:58.169+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:58.169+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:58:176,2.098429,-2.232215,9.315804
04-23 19:28:58.169+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:58:174,2.208575,-2.136791,9.288938
04-23 19:28:58.179+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:58.179+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:58.179+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:58:187,-0.770000,1.960000,0.420000
04-23 19:28:58.179+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:58:188,0.052718,-0.055324,0.047312
04-23 19:28:58.179+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:58.189+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:58.189+0200 I/heartrate(15180): capturing data from es.ugr.frailty.heartrate
04-23 19:28:58.189+0200 I/heartrate(15180): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:28:58:196,75
04-23 19:28:58.199+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:58:193,2.151148,-2.287539,9.363115
04-23 19:28:58.199+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:58:195,2.096752,-2.233916,9.315773
04-23 19:28:58.209+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:58.209+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:58:214,0.047217,-0.067979,0.102377
04-23 19:28:58.209+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:58.209+0200 I/gravity (15469): capturing data from es.ugr.frailty.gravity
04-23 19:28:58.219+0200 I/accelerometer(15427): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:58:218,2.143969,-2.301895,9.418150
04-23 19:28:58.219+0200 I/linearacceleration(15455): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:58.219+0200 I/linearacceleration(15455): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:58:229,0.040173,-0.207000,0.205217
04-23 19:28:58.229+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:58.229+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:58:233,-0.910000,1.960000,0.770000
04-23 19:28:58.229+0200 I/gyroscope(15440): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:58.229+0200 I/gyroscope(15440): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:58:238,-1.050000,0.630000,0.350000
04-23 19:28:58.239+0200 I/gravity (15469): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:58:222,2.094225,-2.236072,9.315825
04-23 19:28:58.239+0200 I/accelerometer(15427): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:58.239+0200 W/CRASH_MANAGER(15241): worker.c: worker_job(1205) > 11154536c6f63152450453
