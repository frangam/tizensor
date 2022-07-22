S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 12970
Date: 2018-06-07 16:56:14+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6fd252d, r5   = 0xf71c2f98
r6   = 0xffafdb00, r7   = 0xffafd9b0
r8   = 0xf71bfc18, r9   = 0x00000000
r10  = 0xffafda8c, fp   = 0xffafdb00
ip   = 0x00000001, sp   = 0xffafd988
lr   = 0xf6fd2539, pc   = 0xf703b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      5148 KB
Buffers:      3720 KB
Cached:      67152 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11436 KB
VmRSS:       11436 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 12970 TID = 12970
12970 12974 

Maps Information
f3e9d000 f469c000 rw-p [stack:12974]
f46a3000 f46a5000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f46ad000 f46b1000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f46ba000 f46bc000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f46c4000 f46c7000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f46d6000 f46db000 r-xp /usr/lib/libsystem.so.0.0.0
f46e6000 f46e9000 r-xp /lib/libattr.so.1.1.0
f46f1000 f4701000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4709000 f4712000 r-xp /usr/lib/libedbus.so.1.7.99
f471a000 f471b000 r-xp /usr/lib/libresponse.so.0.2.96
f4724000 f4729000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5fcb000 f60d1000 r-xp /usr/lib/libicuuc.so.57.1
f60e7000 f626f000 r-xp /usr/lib/libicui18n.so.57.1
f627f000 f628c000 r-xp /usr/lib/libail.so.0.1.0
f6295000 f629c000 r-xp /usr/lib/libminizip.so.1.0.0
f62a5000 f644e000 r-xp /usr/lib/libcrypto.so.1.0.0
f646e000 f64b5000 r-xp /usr/lib/libssl.so.1.0.0
f64c1000 f64c3000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f64cb000 f64d2000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f64db000 f64e2000 r-xp /lib/libcrypt-2.13.so
f6513000 f6516000 r-xp /lib/libcap.so.2.21
f651e000 f6520000 r-xp /usr/lib/libiri.so
f6528000 f6571000 r-xp /usr/lib/libmdm.so.1.2.69
f6579000 f657f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6587000 f65aa000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f65b4000 f65b6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f65be000 f65db000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f65e4000 f65e8000 r-xp /usr/lib/libsmack.so.1.0.0
f65f1000 f660a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6613000 f661b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6623000 f6629000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6632000 f6634000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f663d000 f664d000 r-xp /lib/libresolv-2.13.so
f6651000 f6669000 r-xp /usr/lib/liblzma.so.5.0.3
f6672000 f6674000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f667c000 f6696000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f669e000 f66cd000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f66d6000 f66e5000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f66ef000 f66f9000 r-xp /usr/lib/libsensord-shared.so
f6702000 f67d5000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f67e0000 f67f6000 r-xp /lib/libz.so.1.2.5
f67fe000 f6803000 r-xp /usr/lib/libffi.so.5.0.10
f680b000 f680c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6814000 f6824000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f682c000 f6845000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f684d000 f684f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6857000 f68cc000 r-xp /usr/lib/libsqlite3.so.0.8.6
f68d6000 f68dc000 r-xp /lib/librt-2.13.so
f68e5000 f6903000 r-xp /usr/lib/libsystemd.so.0.4.0
f690d000 f690e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6916000 f6939000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6941000 f6946000 r-xp /usr/lib/libxdgmime.so.1.1.0
f694e000 f6978000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6981000 f6998000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f69a0000 f6a09000 r-xp /lib/libm-2.13.so
f6a12000 f6aa6000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ab9000 f6abe000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ac6000 f6acd000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ad5000 f6aff000 r-xp /usr/lib/libsensor.so.1.9.6
f6b08000 f6bd4000 r-xp /usr/lib/libxml2.so.2.7.8
f6be1000 f6be3000 r-xp /usr/lib/libiniparser.so.0
f6bec000 f6bf2000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6bfb000 f6ccb000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6ccc000 f6d00000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d09000 f6d45000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6d4d000 f6d50000 r-xp /usr/lib/libbundle.so.0.1.22
f6d58000 f6d5e000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d66000 f6da7000 r-xp /usr/lib/libeina.so.1.7.99
f6db0000 f6dc7000 r-xp /usr/lib/libecore.so.1.7.99
f6dde000 f6de7000 r-xp /usr/lib/libvconf.so.0.2.45
f6def000 f6e03000 r-xp /lib/libpthread-2.13.so
f6e0e000 f6e1b000 r-xp /usr/lib/libaul.so.0.1.0
f6e25000 f6e27000 r-xp /lib/libdl-2.13.so
f6e30000 f6e3b000 r-xp /lib/libunwind.so.8.0.1
f6e68000 f6e70000 r-xp /lib/libgcc_s-4.6.so.1
f6e71000 f6f95000 r-xp /lib/libc-2.13.so
f6fa3000 f6fa5000 r-xp /usr/lib/libdlog.so.0.0.0
f6fad000 f6fb9000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6fc2000 f6fc7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6fcf000 f6fde000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f6fe6000 f6fea000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6ff3000 f6ff6000 r-xp /usr/lib/libappcore-agent.so.1.1
f6ffe000 f7000000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7008000 f700c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7014000 f7031000 r-xp /lib/ld-2.13.so
f703a000 f703d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f703d000 f7041000 r-xp /usr/lib/libsys-assert.so
f718f000 f721d000 rw-p [heap]
ffadf000 ffb00000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12970)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf703b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf6fd2539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6cd93f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6cd7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6ce3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6ce9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6ce9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6d1e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6d191f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6cd7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6ce3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6ce9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6ce9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6d1be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6d1c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6d23f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf46bb1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf46ae171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6781663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6c2efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6c307a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6dc0ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6dbbb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6dbc5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6dbc879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf6ff4183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf6ff47fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf703b5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6e8885c) [/lib/libc.so.6] + 0x1785c
29: (0xf703af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
13:659,-0.594707,-0.267316,1.656554
06-07 16:56:13.661+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:13.661+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:13:664,7.407032,2.234928,6.025891
06-07 16:56:13.661+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:13.661+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:13.661+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:13:670,-0.568345,0.574246,0.480194
06-07 16:56:13.671+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:13:649,-17.500000,14.910000,-6.230000
06-07 16:56:13.671+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:13.671+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:13:674,7.392313,2.292593,6.022300
06-07 16:56:13.671+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:13:677,-39.060001,17.710001,-7.840000
06-07 16:56:13.671+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:13:673,6.838687,2.809174,6.506085
06-07 16:56:13.671+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:13.681+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:13:682,-7.210000,17.920000,-4.340000
06-07 16:56:13.681+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:13.681+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:13.681+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:13.681+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:13:689,-0.070276,0.200728,-0.109636
06-07 16:56:13.681+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:13.691+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:13:689,7.322037,2.493321,5.912664
06-07 16:56:13.691+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:13:687,34.369999,15.680000,-7.980000
06-07 16:56:13.691+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:13:693,7.389212,2.301128,6.022852
06-07 16:56:13.691+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:13.691+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:13:698,21.420000,-4.550000,-6.510000
06-07 16:56:13.691+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:13.701+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:13:703,-8.400000,-8.890000,-5.530000
06-07 16:56:13.701+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:13.701+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:13.701+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:13.701+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:13:710,0.117073,-0.276800,-0.186758
06-07 16:56:13.701+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:13.711+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:13:710,7.506285,2.024328,5.836094
06-07 16:56:13.711+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:13:715,-14.840000,-3.850000,-3.990000
06-07 16:56:13.711+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:13:712,7.385583,2.278833,6.035765
06-07 16:56:13.721+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:13.721+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:13.721+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:13:730,-0.027654,-0.941245,0.099432
06-07 16:56:13.721+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:13:730,7.357929,1.337588,6.135197
06-07 16:56:13.721+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:13.721+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:13.731+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:13:734,7.374943,2.244662,6.061526
06-07 16:56:13.731+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:13:735,0.140000,4.340000,-7.000000
06-07 16:56:13.741+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:13.741+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:13.751+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:13.751+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:13:753,-0.191689,0.346765,0.377560
06-07 16:56:13.751+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:13.751+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:13:753,7.183254,2.591427,6.439085
06-07 16:56:13.751+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:13:759,17.850000,9.870000,-2.660000
06-07 16:56:13.761+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:13:756,7.357077,2.281793,6.069368
06-07 16:56:13.761+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:13.761+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:13.761+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:13.761+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:13:769,0.323884,0.096673,0.096937
06-07 16:56:13.761+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:13.771+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:13:769,7.680960,2.378466,6.166305
06-07 16:56:13.771+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:13:775,8.540000,-3.080000,-4.760000
06-07 16:56:13.771+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:13:772,7.365131,2.297621,6.053607
06-07 16:56:13.781+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:13.781+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:13.781+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:13.781+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:13:790,0.193795,-0.105796,0.813794
06-07 16:56:13.791+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:13.791+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:13:792,7.356252,2.294639,6.065523
06-07 16:56:13.791+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:13:797,7.070000,1.470000,-0.560000
06-07 16:56:13.791+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:13:791,7.558927,2.191825,6.867401
06-07 16:56:13.801+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:13.801+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:13.801+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:13.811+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:13:815,7.340037,2.308044,6.080063
06-07 16:56:13.811+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:13:810,7.013363,2.297110,7.125826
06-07 16:56:13.821+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:13.821+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:13:809,-0.342889,0.002471,1.060303
06-07 16:56:13.821+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:13.821+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:13.821+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:13:828,14.630000,-2.030000,-1.330000
06-07 16:56:13.821+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:13.831+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:56:13.831+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:56:13:836,87
06-07 16:56:13.831+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:13.831+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:13:834,7.348024,2.340499,6.057969
06-07 16:56:13.841+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:13:841,19.809999,-10.430000,-0.770000
06-07 16:56:13.841+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:13:833,6.915257,2.555535,6.496514
06-07 16:56:13.841+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:13:836,-0.424779,0.247490,0.416451
06-07 16:56:13.841+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:13.841+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:56:13.851+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:13.851+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:13:854,7.384326,2.343050,6.012673
06-07 16:56:13.851+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:13.851+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:13:855,12.880000,-14.140000,0.910000
06-07 16:56:13.851+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:13:860,7.238289,2.108077,5.781059
06-07 16:56:13.851+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:56:13:854,549.000000
06-07 16:56:13.861+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:13.861+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:13.861+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:13:866,-0.109735,-0.232422,-0.276909
06-07 16:56:13.861+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:13.861+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:13.871+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:13.871+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:13:869,7.415914,2.329579,5.978936
06-07 16:56:13.871+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:13:875,0.210000,-10.990000,1.050000
06-07 16:56:13.871+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:13:874,7.422535,2.031506,5.491528
06-07 16:56:13.881+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:13.891+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:13.891+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:13:896,7.274181,2.297110,5.441278
06-07 16:56:13.891+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:13:890,7.440413,2.335839,5.945965
06-07 16:56:13.891+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:13:873,0.038209,-0.311543,-0.521145
06-07 16:56:13.901+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:13.911+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:13:915,5.460000,-6.300000,1.610000
06-07 16:56:13.911+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:13.921+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:13.921+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:13:927,11.900000,-4.340000,2.100000
06-07 16:56:13.931+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:13:923,-0.141733,-0.032469,-0.537657
06-07 16:56:13.931+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:13.931+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:13.941+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:13:937,0.015623,0.183803,0.074377
06-07 16:56:13.941+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:13.951+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:13:945,24.990000,-4.060000,5.740000
06-07 16:56:13.951+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:13.951+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:13:951,0.245168,0.603349,0.108475
06-07 16:56:13.961+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:13.961+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:13:957,17.639999,-3.080000,8.400000
06-07 16:56:13.971+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:13.971+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:13:967,0.111711,0.339235,-0.581847
06-07 16:56:13.971+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:13.981+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer alive timeout
06-07 16:56:13.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 16:56:13.981+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:13.981+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:13.981+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:13.991+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:13.991+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:13:991,7.454935,2.351787,5.921438
06-07 16:56:13.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12809
06-07 16:56:13.991+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12809)
06-07 16:56:13.991+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer launch request sent!
06-07 16:56:13.991+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:13.991+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope alive timeout
06-07 16:56:13.991+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 16:56:13.991+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:13.991+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:13.991+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:13.991+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:13:996,7.456036,2.519642,6.020342
06-07 16:56:14.001+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:14.001+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:3,7.483108,2.390975,5.869985
06-07 16:56:14.001+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12853
06-07 16:56:14.001+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12853)
06-07 16:56:14.001+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope launch request sent!
06-07 16:56:14.001+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:14.001+0200 I/servicemanager(12566): es.ugr.frailty.heartrate alive timeout
06-07 16:56:14.011+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 16:56:14.011+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:14.011+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:14.011+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.011+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:14:11,7.700103,2.955136,6.029913
06-07 16:56:14.011+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:14.021+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12595
06-07 16:56:14.021+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12595)
06-07 16:56:14.021+0200 I/servicemanager(12566): es.ugr.frailty.heartrate launch request sent!
06-07 16:56:14.021+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:14.021+0200 I/servicemanager(12566): es.ugr.frailty.location alive timeout
06-07 16:56:14.021+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 16:56:14.021+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:18,7.522919,2.414675,5.809081
06-07 16:56:14.021+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:14.021+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:14.021+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:14:25,7.594819,2.730211,5.288138
06-07 16:56:14.031+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:14.031+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12970
06-07 16:56:14.031+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12970)
06-07 16:56:14.031+0200 I/servicemanager(12566): es.ugr.frailty.location launch request sent!
06-07 16:56:14.031+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:14.031+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration alive timeout
06-07 16:56:14.031+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 16:56:14.031+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:14.031+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(12595), cmd(0)
06-07 16:56:14.031+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:14.031+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:14:37,7.719246,2.038685,4.809574
06-07 16:56:14.031+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:14.031+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:14.041+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12857
06-07 16:56:14.041+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:56:14.041+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12857)
06-07 16:56:14.051+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration launch request sent!
06-07 16:56:14.051+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:14.051+0200 I/servicemanager(12566): es.ugr.frailty.gravity alive timeout
06-07 16:56:14.051+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:14.051+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(12970), cmd(0)
06-07 16:56:14.051+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 16:56:14.051+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:14.051+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:56:14:54,532.000000
06-07 16:56:14.051+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:14:44,8.085347,1.454836,5.297709
06-07 16:56:14.061+0200 W/CAPI_APPFW_APP_CONTROL(12809): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:14.061+0200 I/utils   (12809): specific action
06-07 16:56:14.061+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:14.061+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:14.061+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:14:67,7.463214,2.256432,5.972485
06-07 16:56:14.061+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:14.071+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:56:14.071+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:56:14.071+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:56:14.071+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12871
06-07 16:56:14.071+0200 W/CAPI_APPFW_APP_CONTROL(12595): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:14.071+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:14.071+0200 I/utils   (12595): specific action
06-07 16:56:14.071+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12809), cmd(0)
06-07 16:56:14.071+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12871)
06-07 16:56:14.071+0200 I/servicemanager(12566): es.ugr.frailty.gravity launch request sent!
06-07 16:56:14.071+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:14.071+0200 I/servicemanager(12566): es.ugr.frailty.pressure alive timeout
06-07 16:56:14.071+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 16:56:14.071+0200 W/CAPI_APPFW_APP_CONTROL(12970): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:14.081+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:14.081+0200 I/utils   (12970): specific action
06-07 16:56:14.081+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:56:14.081+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:14.091+0200 W/CAPI_APPFW_APP_CONTROL(12871): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:14.091+0200 I/utils   (12871): specific action
06-07 16:56:14.091+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.101+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:101,7.579612,2.398132,5.741848
06-07 16:56:14.101+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.101+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12603
06-07 16:56:14.101+0200 W/CAPI_APPFW_APP_CONTROL(12603): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:14.101+0200 I/utils   (12603): specific action
06-07 16:56:14.101+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:14.101+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(12871), cmd(0)
06-07 16:56:14.101+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:14.101+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12603), cmd(0)
06-07 16:56:14.101+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12603)
06-07 16:56:14.101+0200 I/servicemanager(12566): es.ugr.frailty.pressure launch request sent!
06-07 16:56:14.101+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:14.101+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:107,7.643391,2.370059,5.668490
06-07 16:56:14.101+0200 I/servicemanager(12566): es.ugr.frailty.light alive timeout
06-07 16:56:14.101+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 16:56:14.101+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.111+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:14.111+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:14.111+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:115,7.678776,2.421730,5.598393
06-07 16:56:14.111+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.111+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:120,7.737741,2.493547,5.484521
06-07 16:56:14.121+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.121+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12614
06-07 16:56:14.121+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:126,7.792466,2.523876,5.392394
06-07 16:56:14.121+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:14.121+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12614), cmd(0)
06-07 16:56:14.121+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.121+0200 W/CAPI_APPFW_APP_CONTROL(12614): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:14.121+0200 I/utils   (12614): specific action
06-07 16:56:14.121+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12614)
06-07 16:56:14.131+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 16:56:14.131+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:131,7.784749,2.665185,5.335247
06-07 16:56:14.131+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:14.131+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 16:56:14.131+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 16:56:14.131+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.131+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:14.131+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:14.131+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:138,7.783506,2.788110,5.273884
06-07 16:56:14.131+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.141+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:143,7.763512,2.921051,5.231226
06-07 16:56:14.141+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.141+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 16:56:14.141+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:14.141+0200 I/utils   (12618): specific action
06-07 16:56:14.141+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:14.141+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12618), cmd(0)
06-07 16:56:14.141+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:149,7.737172,3.032064,5.207028
06-07 16:56:14.151+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.151+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 16:56:14.151+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 16:56:14.151+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:14.151+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:156,7.706757,3.094313,5.215506
06-07 16:56:14.161+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:56:14:114,87
06-07 16:56:14.161+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.171+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:13:977,10.080000,-5.740000,9.520000
06-07 16:56:14.171+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:169,7.663137,3.143331,5.250351
06-07 16:56:14.181+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:14.181+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(12853), cmd(0)
06-07 16:56:14.191+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:14:74,7.635497,2.627320,5.417351
06-07 16:56:14.191+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:13:982,0.196327,-0.375990,-0.999507
06-07 16:56:14.191+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:14.191+0200 W/CAPI_APPFW_APP_CONTROL(12853): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:14.191+0200 I/utils   (12853): specific action
06-07 16:56:14.201+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:14.201+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:14.201+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(12857), cmd(0)
06-07 16:56:14.201+0200 W/CAPI_APPFW_APP_CONTROL(12857): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:14.201+0200 I/utils   (12857): specific action
06-07 16:56:14.201+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:14.201+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.211+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:14:206,35.490002,0.140000,11.340000
06-07 16:56:14.211+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:14.211+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:14:203,7.467999,1.768296,5.584848
06-07 16:56:14.211+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:212,7.588500,3.180061,5.335940
06-07 16:56:14.211+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:14:212,0.505735,-0.943296,-0.444139
06-07 16:56:14.221+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.221+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:14.221+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:14.221+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:14:231,-0.180177,-0.113628,0.303995
06-07 16:56:14.231+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:56:14.231+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:228,7.511171,3.094851,5.493140
06-07 16:56:14.231+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.231+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:56:14:236,88
06-07 16:56:14.231+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:14:228,7.204789,3.728018,6.367301
06-07 16:56:14.231+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:14.241+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:14:217,73.919998,9.380000,9.590000
06-07 16:56:14.241+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:14.241+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:242,7.452389,2.904770,5.674028
06-07 16:56:14.241+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:14:248,84.559998,0.140000,11.690000
06-07 16:56:14.241+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:56:14.241+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.251+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:56:14:254,483.000000
06-07 16:56:14.251+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:14.251+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:255,7.388189,2.704843,5.853962
06-07 16:56:14.251+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:14:244,7.343572,3.259024,5.998806
06-07 16:56:14.251+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:14.261+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.261+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:14:259,-0.043279,0.205590,-0.181042
06-07 16:56:14.261+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:14.261+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:14:271,-0.269742,-0.725251,0.100327
06-07 16:56:14.271+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:14.281+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:14:276,86.870003,1.190000,11.410000
06-07 16:56:14.281+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:269,7.331152,2.577338,5.981799
06-07 16:56:14.281+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:14:264,7.389036,4.173083,5.888737
06-07 16:56:14.281+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.291+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:14.291+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:294,7.265645,2.489551,6.097780
06-07 16:56:14.301+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:14.301+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:14.311+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.311+0200 W/LOCATION(12970): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 16:56:14.311+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:14:295,111.230003,15.120000,11.340000
06-07 16:56:14.311+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:14:306,-0.587677,1.204142,0.974907
06-07 16:56:14.311+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:14.321+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:14:307,7.262216,4.558327,5.477170
06-07 16:56:14.321+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:14.321+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:14.321+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:316,7.194480,2.356750,6.233423
06-07 16:56:14.321+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.331+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:14:329,107.309998,9.730000,4.130000
06-07 16:56:14.331+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:14.331+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:338,7.105735,2.187172,6.394935
06-07 16:56:14.341+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:14:325,-0.441176,0.593839,0.663559
06-07 16:56:14.341+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:14:332,7.255038,4.197011,5.201996
06-07 16:56:14.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:56:14.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:56:14.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:56:14.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:56:14.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390574349,000000, pattern:[H:mm][0;m
06-07 16:56:14.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:56:14.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:56:14.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:56:14.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:56:14.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:56:14.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:56][0;m
06-07 16:56:14.351+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.351+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:14.351+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:356,7.022376,2.044299,6.532799
06-07 16:56:14.351+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:14:356,7.200003,4.168297,5.185246
06-07 16:56:14.351+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:14.351+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:14.361+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.361+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:14:340,85.889999,10.570000,5.950000
06-07 16:56:14.361+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:14.361+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:14:365,-0.394471,1.384973,0.614852
06-07 16:56:14.361+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:370,6.934698,1.968292,6.648773
06-07 16:56:14.361+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:14.371+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:14:375,-0.501296,1.637276,0.245944
06-07 16:56:14.381+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:14:361,7.221539,4.137190,5.982057
06-07 16:56:14.381+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:14:371,51.170002,9.310000,7.840000
06-07 16:56:14.381+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:14.381+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.381+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:14.381+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:390,6.787939,1.798403,6.845437
06-07 16:56:14.391+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:14.391+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:14:397,7.800602,4.321437,6.934400
06-07 16:56:14.391+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:14.401+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.401+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:14:388,12.460000,12.110000,5.740000
06-07 16:56:14.401+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:14.401+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:410,6.618129,1.569300,7.064563
06-07 16:56:14.411+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:14:392,-0.482134,1.164947,-0.005032
06-07 16:56:14.411+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:14.411+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:14:414,-3.990000,18.340000,3.360000
06-07 16:56:14.421+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:14:418,-0.506754,1.073983,-0.030259
06-07 16:56:14.421+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:14:402,7.896315,2.969493,7.003791
06-07 16:56:14.421+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.431+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:56:14.431+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:56:14:437,88
06-07 16:56:14.431+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:14.441+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:14.441+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:14.441+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:431,6.527253,1.467146,7.170275
06-07 16:56:14.441+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:56:14.451+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:56:14:454,565.000000
06-07 16:56:14.451+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.461+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:14:446,7.343572,1.823331,6.790830
06-07 16:56:14.461+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:14:452,-0.441598,0.993859,0.731705
06-07 16:56:14.461+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:14.461+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:14:443,-21.770000,21.000000,-6.440000
06-07 16:56:14.471+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:14.471+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:14.471+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:462,6.469458,1.421266,7.231632
06-07 16:56:14.471+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.481+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:14:477,7.051648,2.261217,5.871986
06-07 16:56:14.481+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:14.491+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:14:471,0.212101,1.141376,1.598460
06-07 16:56:14.491+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:14.491+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:14:480,-112.209999,14.910000,-4.480000
06-07 16:56:14.491+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:14.501+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:485,6.331056,1.254650,7.383358
06-07 16:56:14.501+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:14:494,7.429714,2.943172,6.022735
06-07 16:56:14.501+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.501+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:14:499,0.385144,-0.125358,1.510651
06-07 16:56:14.511+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:14:503,-168.490005,-5.740000,4.970000
06-07 16:56:14.511+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:14.521+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:14.521+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:14.521+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:512,6.096927,1.028816,7.611794
06-07 16:56:14.531+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:14:527,7.281359,2.354537,5.711668
06-07 16:56:14.531+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:14.541+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.541+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:546,5.919341,0.889305,7.767942
06-07 16:56:14.541+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:14:530,-0.108817,-1.081439,1.116802
06-07 16:56:14.541+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:14.541+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:14:520,-139.229996,-5.740000,4.200000
06-07 16:56:14.551+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:14.551+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.561+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:14:553,-0.336541,-0.443625,0.018024
06-07 16:56:14.561+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:14:540,7.288538,1.406980,5.927022
06-07 16:56:14.561+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:14.561+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:14:557,-102.410004,-1.120000,4.620000
06-07 16:56:14.561+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:14.571+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:561,5.777282,0.786075,7.885143
06-07 16:56:14.571+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.571+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:14.581+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:14:575,-96.389999,-1.260000,1.960000
06-07 16:56:14.591+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:14:582,0.098561,0.365834,0.040936
06-07 16:56:14.591+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:14:580,5.638382,0.706321,7.992505
06-07 16:56:14.591+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:14.591+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:14:571,7.673782,1.249053,6.099305
06-07 16:56:14.601+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:14.601+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:14.611+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:56:14.611+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:14:615,-117.389999,-6.300000,3.920000
06-07 16:56:14.621+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:14:612,7.257431,1.928615,5.876772
06-07 16:56:14.631+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:56:14.641+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11129706c6f63152838337
