S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 30249
Date: 2018-04-23 17:24:24+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf725a52d, r5   = 0xf750ef98
r6   = 0xffb708e0, r7   = 0xffb70790
r8   = 0xf750bc18, r9   = 0x00000000
r10  = 0xffb7086c, fp   = 0xffb708e0
ip   = 0x00000001, sp   = 0xffb6f610
lr   = 0xf725a539, pc   = 0xf72c32b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     16624 KB
Buffers:     66108 KB
Cached:     219904 KB
VmPeak:      53460 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12028 KB
VmRSS:       12028 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 30249 TID = 30249
30249 30252 

Maps Information
f4125000 f4924000 rw-p [stack:30252]
f492b000 f492d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4935000 f4939000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4942000 f4944000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f494c000 f494f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f495e000 f4963000 r-xp /usr/lib/libsystem.so.0.0.0
f496e000 f4971000 r-xp /lib/libattr.so.1.1.0
f4979000 f4989000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4991000 f499a000 r-xp /usr/lib/libedbus.so.1.7.99
f49a2000 f49a3000 r-xp /usr/lib/libresponse.so.0.2.96
f49ac000 f49b1000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6253000 f6359000 r-xp /usr/lib/libicuuc.so.57.1
f636f000 f64f7000 r-xp /usr/lib/libicui18n.so.57.1
f6507000 f6514000 r-xp /usr/lib/libail.so.0.1.0
f651d000 f6524000 r-xp /usr/lib/libminizip.so.1.0.0
f652d000 f66d6000 r-xp /usr/lib/libcrypto.so.1.0.0
f66f6000 f673d000 r-xp /usr/lib/libssl.so.1.0.0
f6749000 f674b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6753000 f675a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6763000 f676a000 r-xp /lib/libcrypt-2.13.so
f679b000 f679e000 r-xp /lib/libcap.so.2.21
f67a6000 f67a8000 r-xp /usr/lib/libiri.so
f67b0000 f67f9000 r-xp /usr/lib/libmdm.so.1.2.69
f6801000 f6807000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f680f000 f6832000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f683c000 f683e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6846000 f6863000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f686c000 f6870000 r-xp /usr/lib/libsmack.so.1.0.0
f6879000 f6892000 r-xp /usr/lib/libnetwork.so.0.0.0
f689b000 f68a3000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f68ab000 f68b1000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f68ba000 f68bc000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f68c5000 f68d5000 r-xp /lib/libresolv-2.13.so
f68d9000 f68f1000 r-xp /usr/lib/liblzma.so.5.0.3
f68fa000 f68fc000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6904000 f691e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6926000 f6955000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f695e000 f696d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6977000 f6981000 r-xp /usr/lib/libsensord-shared.so
f698a000 f6a5d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a68000 f6a7e000 r-xp /lib/libz.so.1.2.5
f6a86000 f6a8b000 r-xp /usr/lib/libffi.so.5.0.10
f6a93000 f6a94000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a9c000 f6aac000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ab4000 f6acd000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6ad5000 f6ad7000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6adf000 f6b54000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b5e000 f6b64000 r-xp /lib/librt-2.13.so
f6b6d000 f6b8b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b95000 f6b96000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b9e000 f6bc1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6bc9000 f6bce000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6bd6000 f6c00000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c09000 f6c20000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c28000 f6c91000 r-xp /lib/libm-2.13.so
f6c9a000 f6d2e000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d41000 f6d46000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d4e000 f6d55000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d5d000 f6d87000 r-xp /usr/lib/libsensor.so.1.9.6
f6d90000 f6e5c000 r-xp /usr/lib/libxml2.so.2.7.8
f6e69000 f6e6b000 r-xp /usr/lib/libiniparser.so.0
f6e74000 f6e7a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e83000 f6f53000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f54000 f6f88000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f91000 f6fcd000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6fd5000 f6fd8000 r-xp /usr/lib/libbundle.so.0.1.22
f6fe0000 f6fe6000 r-xp /usr/lib/libappsvc.so.0.1.0
f6fee000 f702f000 r-xp /usr/lib/libeina.so.1.7.99
f7038000 f704f000 r-xp /usr/lib/libecore.so.1.7.99
f7066000 f706f000 r-xp /usr/lib/libvconf.so.0.2.45
f7077000 f708b000 r-xp /lib/libpthread-2.13.so
f7096000 f70a3000 r-xp /usr/lib/libaul.so.0.1.0
f70ad000 f70af000 r-xp /lib/libdl-2.13.so
f70b8000 f70c3000 r-xp /lib/libunwind.so.8.0.1
f70f0000 f70f8000 r-xp /lib/libgcc_s-4.6.so.1
f70f9000 f721d000 r-xp /lib/libc-2.13.so
f722b000 f722d000 r-xp /usr/lib/libdlog.so.0.0.0
f7235000 f7241000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f724a000 f724f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7257000 f7266000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f726e000 f7272000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f727b000 f727e000 r-xp /usr/lib/libappcore-agent.so.1.1
f7286000 f7288000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7290000 f7294000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f729c000 f72b9000 r-xp /lib/ld-2.13.so
f72c2000 f72c5000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f72c5000 f72c9000 r-xp /usr/lib/libsys-assert.so
f74db000 f754c000 rw-p [heap]
ffb52000 ffb73000 rw-p [stack]
End of Maps Information

Callstack Information (PID:30249)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf72c32b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf725a539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f613f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f5fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f6be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f71be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f71dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6fa675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6fa11f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f5fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f6be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f71be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f71dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6fa3e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6fa4017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6fabf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49431fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4936171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a09663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6eb6fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6eb87a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7048ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7043b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70445a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7044879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf727c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf727c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72c36c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16c3
28: __libc_start_main + 0x114 (0xf711085c) [/lib/libc.so.6] + 0x1785c
29: (0xf72c2fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
 capturing data from es.ugr.frailty.accelerometer
04-23 17:24:15.601+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:24:15.611+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:24:15:612,0.980000,2.940000,-7.490000
04-23 17:24:15.621+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:24:15:611,9.609575,0.401994,1.976472
04-23 17:24:15.771+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:24:15.781+0200 I/heartrate(30131): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:24:15:779,80
04-23 17:24:15.801+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:24:15.801+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:24:15.821+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:24:15:812,9.449257,1.031307,1.938186
04-23 17:24:15.821+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:24:15:812,-15.890000,1.470000,-1.820000
04-23 17:24:15.971+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:24:15.981+0200 I/heartrate(30131): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:24:15:979,81
04-23 17:24:16.001+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:24:16.011+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:24:16.011+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:24:16:11,-1.260000,3.780000,-1.540000
04-23 17:24:16.021+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:24:16:15,9.573684,-0.055035,2.127219
04-23 17:24:16.171+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:24:16.181+0200 I/heartrate(30131): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:24:16:179,81
04-23 17:24:16.201+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:24:16.211+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:24:16.221+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:24:16:215,9.643075,0.406780,1.976472
04-23 17:24:16.221+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:24:16:212,-1.540000,-1.540000,2.520000
04-23 17:24:16.371+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:24:16.381+0200 I/heartrate(30131): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:24:16:379,81
04-23 17:24:16.401+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:24:16.411+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:24:16.421+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:24:16:415,9.690931,0.131605,2.067399
04-23 17:24:16.421+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:24:16:412,4.130000,-0.630000,3.570000
04-23 17:24:16.571+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:24:16.581+0200 I/heartrate(30131): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:24:16:579,80
04-23 17:24:16.601+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:24:16.611+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:24:16.621+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:24:16:615,9.678967,0.234497,1.981257
04-23 17:24:16.621+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:24:16:612,1.470000,-3.150000,2.660000
04-23 17:24:16.771+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:24:16.781+0200 I/heartrate(30131): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:24:16:780,80
04-23 17:24:16.801+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:24:16.801+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:24:16.821+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:24:16:812,9.602397,-0.014357,2.069792
04-23 17:24:16.821+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:24:16:813,-8.470000,-2.030000,13.930000
04-23 17:24:16.971+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:24:16.981+0200 I/heartrate(30131): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:24:16:980,80
04-23 17:24:17.001+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:24:17.001+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:24:17.011+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:24:17:13,28.420000,6.930000,23.100000
04-23 17:24:17.021+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:24:17:13,9.667004,-0.605384,1.576870
04-23 17:24:17.171+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:24:17.181+0200 I/heartrate(30131): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:24:17:180,80
04-23 17:24:17.201+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:24:17.211+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:24:17.221+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:24:17:215,9.571291,-1.478764,2.553142
04-23 17:24:17.221+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:24:17:212,-9.310000,4.340000,-6.720000
04-23 17:24:17.371+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:24:17.381+0200 I/heartrate(30131): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:24:17:380,79
04-23 17:24:17.401+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:24:17.401+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:24:17.421+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:24:17:412,-1.050000,-2.310000,-7.420000
04-23 17:24:17.421+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:24:17:413,9.602397,-0.844666,2.529213
04-23 17:24:17.571+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:24:17.581+0200 I/heartrate(30131): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:24:17:580,79
04-23 17:24:17.601+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:24:17.611+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:24:17.621+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:24:17:613,4.410000,-0.840000,-6.020000
04-23 17:24:17.621+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:24:17:615,9.638289,-0.526421,2.237289
04-23 17:24:17.771+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:24:17.781+0200 I/heartrate(30131): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:24:17:780,78
04-23 17:24:17.801+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:24:17.801+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:24:17.821+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:24:17:813,-0.700000,-2.030000,-4.340000
04-23 17:24:17.821+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:24:17:813,9.683753,-0.045464,2.316252
04-23 17:24:17.971+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:24:17.981+0200 I/heartrate(30131): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:24:17:980,79
04-23 17:24:18.001+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:24:18.011+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:24:18.021+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:24:18:14,2.450000,-1.960000,-3.990000
04-23 17:24:18.021+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:24:18:15,9.832108,-0.413958,1.947758
04-23 17:24:18.171+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:24:18.181+0200 I/heartrate(30131): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:24:18:181,79
04-23 17:24:18.201+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:24:18.211+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:24:18.221+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:24:18:213,9.547362,-0.057428,2.170290
04-23 17:24:18.221+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:24:18:215,-2.730000,-2.170000,-10.710000
04-23 17:24:18.371+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:24:18.381+0200 I/heartrate(30131): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:24:18:381,78
04-23 17:24:18.401+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:24:18.401+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:24:18.421+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:24:18:414,-3.710000,-2.170000,-2.730000
04-23 17:24:18.421+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:24:18:413,9.609575,0.234497,2.009971
04-23 17:24:18.571+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:24:18.581+0200 I/heartrate(30131): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:24:18:581,78
04-23 17:24:18.601+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:24:18.611+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:24:18.621+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:24:18:613,9.504292,0.076570,2.529213
04-23 17:24:18.621+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:24:18:615,-14.840000,-3.220000,3.640000
04-23 17:24:18.731+0200 I/servicemanager(30105): es.ugr.frailty.accelerometer sleep timeout
04-23 17:24:18.731+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 17:24:18.731+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:24:18.731+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30105
04-23 17:24:18.751+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30116
04-23 17:24:18.751+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30116)
04-23 17:24:18.751+0200 I/servicemanager(30105): es.ugr.frailty.accelerometer stop request sent!
04-23 17:24:18.751+0200 I/servicemanager(30105): App control destroyed.
04-23 17:24:18.761+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:24:18.761+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30116), cmd(0)
04-23 17:24:18.761+0200 I/accelerometer(30116): stopping es.ugr.frailty.accelerometer service
04-23 17:24:18.761+0200 W/AUL     (30116): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 17:24:18.791+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:24:18.811+0200 I/heartrate(30131): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:24:18:796,78
04-23 17:24:18.811+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:24:18.821+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:24:18.821+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30116
04-23 17:24:18.841+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30105
04-23 17:24:18.851+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:24:18.851+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30105), cmd(0)
04-23 17:24:18.851+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:18.851+0200 I/utils   (30105): specific action
04-23 17:24:18.851+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:24:18:823,1.540000,-1.820000,3.640000
04-23 17:24:18.851+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 17:24:18.851+0200 W/AUL     (30116): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30105)
04-23 17:24:18.851+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:24:18.851+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30105
04-23 17:24:18.851+0200 I/accelerometer(30116): request sent to service es.ugr.frailty.servicemanager
04-23 17:24:18.851+0200 I/CAPI_APPFW_APPLICATION(30116): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 17:24:18.861+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30110
04-23 17:24:18.871+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 17:24:18.871+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 17:24:18.871+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:24:18.871+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30110), cmd(0)
04-23 17:24:18.871+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30110)
04-23 17:24:18.871+0200 I/servicemanager(30105): request sent to service es.ugr.frailty.recorder
04-23 17:24:18.871+0200 I/servicemanager(30105): requesting to save local data
04-23 17:24:18.871+0200 I/servicemanager(30105): es.ugr.frailty.gyroscope sleep timeout
04-23 17:24:18.871+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 17:24:18.871+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:18.871+0200 I/utils   (30110): specific action
04-23 17:24:18.871+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:18.871+0200 I/recorder(30110): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 17:24:18.871+0200 I/recorder(30110): guardando datos en local
04-23 17:24:18.871+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:24:18.871+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30105
04-23 17:24:18.881+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30119
04-23 17:24:18.891+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30119)
04-23 17:24:18.891+0200 I/servicemanager(30105): es.ugr.frailty.gyroscope stop request sent!
04-23 17:24:18.891+0200 I/servicemanager(30105): App control destroyed.
04-23 17:24:18.891+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:24:18.891+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30119), cmd(0)
04-23 17:24:18.891+0200 I/servicemanager(30105): es.ugr.frailty.heartrate sleep timeout
04-23 17:24:18.891+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 17:24:18.891+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:24:18.891+0200 I/gyroscope(30119): stopping es.ugr.frailty.gyroscope service
04-23 17:24:18.891+0200 W/AUL     (30119): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 17:24:18.891+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30105
04-23 17:24:18.901+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30131
04-23 17:24:18.901+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30131)
04-23 17:24:18.901+0200 I/servicemanager(30105): es.ugr.frailty.heartrate stop request sent!
04-23 17:24:18.901+0200 I/servicemanager(30105): App control destroyed.
04-23 17:24:18.911+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:24:18.911+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30119
04-23 17:24:18.921+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30105
04-23 17:24:18.931+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:24:18.931+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(30105), cmd(0)
04-23 17:24:18.931+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:18.931+0200 I/utils   (30105): specific action
04-23 17:24:18.931+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:18.931+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 17:24:18.931+0200 W/AUL     (30119): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30105)
04-23 17:24:18.931+0200 I/gyroscope(30119): request sent to service es.ugr.frailty.servicemanager
04-23 17:24:18.931+0200 I/CAPI_APPFW_APPLICATION(30119): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 17:24:18.941+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:24:18.941+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30105
04-23 17:24:18.941+0200 I/heartrate(30131): stopping es.ugr.frailty.heartrate service
04-23 17:24:18.941+0200 W/AUL     (30131): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 17:24:18.951+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30110
04-23 17:24:18.951+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 17:24:18.951+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 17:24:18.951+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:24:18.951+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30131), cmd(0)
04-23 17:24:18.951+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 17:24:18.951+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:24:18.951+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30131
04-23 17:24:18.961+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 17:24:18.961+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30105
04-23 17:24:18.961+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30110)
04-23 17:24:18.961+0200 I/servicemanager(30105): request sent to service es.ugr.frailty.recorder
04-23 17:24:18.961+0200 I/servicemanager(30105): requesting to save local data
04-23 17:24:18.961+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:24:18.961+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30105), cmd(0)
04-23 17:24:18.961+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:18.961+0200 I/utils   (30105): specific action
04-23 17:24:18.961+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:18.961+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:18.961+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 17:24:18.971+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:24:18.971+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30105
04-23 17:24:18.971+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:18.971+0200 I/utils   (30110): specific action
04-23 17:24:18.971+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:18.971+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:18.971+0200 I/recorder(30110): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
04-23 17:24:18.971+0200 I/recorder(30110): guardando datos en local
04-23 17:24:18.981+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30110
04-23 17:24:18.981+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:18.981+0200 I/utils   (30110): specific action
04-23 17:24:18.981+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:18.981+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:18.981+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:18.981+0200 I/recorder(30110): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.heartrate.csv
04-23 17:24:18.981+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:24:18.981+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(30110), cmd(0)
04-23 17:24:18.981+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:24:18.981+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30110), cmd(0)
04-23 17:24:18.981+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30110)
04-23 17:24:18.981+0200 I/servicemanager(30105): request sent to service es.ugr.frailty.recorder
04-23 17:24:18.981+0200 I/servicemanager(30105): requesting to save local data
04-23 17:24:18.981+0200 W/AUL     (30131): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30105)
04-23 17:24:18.981+0200 I/heartrate(30131): request sent to service es.ugr.frailty.servicemanager
04-23 17:24:18.981+0200 I/CAPI_APPFW_APPLICATION(30131): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 17:24:18.981+0200 I/recorder(30110): guardando datos en local
04-23 17:24:18.981+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 17:24:18.981+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 17:24:18.991+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer listener destroyed
04-23 17:24:19.051+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 17:24:19.061+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 17:24:19.071+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 17:24:19.081+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 17:24:19.081+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope listener destroyed
04-23 17:24:19.101+0200 I/heartrate(30131): es.ugr.frailty.heartrate listener destroyed
04-23 17:24:19.121+0200 W/AUL     (30244): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 17:24:19.121+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:24:19.121+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:24:19.121+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 30116
04-23 17:24:19.121+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:24:19.131+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 30116
04-23 17:24:19.131+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(30116)
04-23 17:24:19.231+0200 W/AUL     (30247): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 17:24:19.231+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:24:19.231+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:24:19.231+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 30119
04-23 17:24:19.231+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:24:19.251+0200 W/AUL     (30248): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 17:24:19.251+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:24:19.251+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:24:19.251+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 30131
04-23 17:24:19.251+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:24:19.281+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 30119
04-23 17:24:19.281+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(30119)
04-23 17:24:19.281+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 30131
04-23 17:24:19.281+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(30131)
04-23 17:24:20.871+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 17:24:20.951+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 17:24:20.991+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 17:24:22.191+0200 I/servicemanager(30105): es.ugr.frailty.location alive timeout
04-23 17:24:22.191+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 17:24:22.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:24:22.191+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30105
04-23 17:24:22.211+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 30249
04-23 17:24:22.221+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 17:24:22.271+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 30249
04-23 17:24:22.271+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(30249) type(svcapp) bg(0)
04-23 17:24:22.271+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30249)
04-23 17:24:22.281+0200 I/servicemanager(30105): es.ugr.frailty.location launch request sent!
04-23 17:24:22.281+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [30249]
04-23 17:24:22.311+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:24:22.331+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 30249
04-23 17:24:22.331+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:24:22.341+0200 I/servicemanager(30105): App control destroyed.
04-23 17:24:22.371+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:24:22.381+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 30249
04-23 17:24:22.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:24:22.421+0200 E/CAPI_APPFW_APPLICATION(30249): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:24:22.421+0200 E/CAPI_APPFW_APPLICATION(30249): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:24:22.431+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (30249) was created
04-23 17:24:22.451+0200 W/LOCATION(30249): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 17:24:22.451+0200 E/LOCATION(30249): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 17:24:22.451+0200 E/PKGMGR_INFO(30249): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 17:24:22.461+0200 W/LOCATION(30249): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:24:22.481+0200 I/LOCATION(30249): location.c: location_new(269) > method: 0
04-23 17:24:22.481+0200 W/LOCATION(30249): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:24:22.481+0200 W/LOCATION(30249): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:24:22.491+0200 W/LOCATION(30249): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:24:22.491+0200 W/LOCATION(30249): module-internal.c: module_new(311) > module (gps) open success
04-23 17:24:22.501+0200 W/LOCATION(30249): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:24:22.501+0200 W/LOCATION(30249): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:24:22.501+0200 W/LOCATION(30249): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:24:22.501+0200 W/LOCATION(30249): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:24:22.501+0200 W/LOCATION(30249): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:24:22.521+0200 W/LOCATION(30249): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:24:22.531+0200 W/LOCATION(30249): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:24:22.531+0200 W/LOCATION(30249): module-internal.c: module_new(311) > module (wps) open success
04-23 17:24:22.531+0200 W/LOCATION(30249): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 17:24:22.541+0200 W/LOCATION(30249): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 17:24:22.541+0200 W/LOCATION(30249): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:24:22.541+0200 W/LOCATION(30249): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:24:22.561+0200 W/LOCATION(30249): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 17:24:22.561+0200 I/LOCATION(30249): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf750bc18
04-23 17:24:22.561+0200 I/LOCATION(30249): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 17:24:22.561+0200 I/LOCATION(30249): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf750bc18
04-23 17:24:22.561+0200 I/LOCATION(30249): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 17:24:22.561+0200 I/location(30249): es.ugr.frailty.location: creado servicio de localización
04-23 17:24:22.601+0200 I/LOCATION(30249): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 17:24:22.651+0200 W/LOCATION(30249): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:24:22.651+0200 W/LOCATION(30249): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:24:22.651+0200 I/LOCATION(30249): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:24:22.711+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:24:22.711+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 17:24:22.711+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 17:24:22.711+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 17:24:22.711+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 17:24:22.711+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 17:24:22.711+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 17:24:22.711+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:24:22.711+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:24:22.721+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:24:22.721+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 17:24:22.721+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 17:24:22.721+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:24:22.721+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:24:22.731+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:24:22.731+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 17:24:22.731+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:24:22.731+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 17:24:22.731+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 17:24:22.741+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:24:22.751+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:24:22.751+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 17:24:22.751+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:24:22.751+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:24:22.761+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:24:22.761+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 17:24:22.761+0200 E/lhd     ( 2444): checkForcedLogSetting: BRCM forced log (TIZEN) NOT detected. Disabling BRCM GPS log.
04-23 17:24:22.761+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 17:24:22.761+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 17:24:22.761+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 17:24:22.761+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 17:24:22.791+0200 W/LOCATION(30249): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:24:22.791+0200 W/LOCATION(30249): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:24:22.861+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:24:22.891+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: connection_create(453) > New handle created[0xf74a2200]
04-23 17:24:22.891+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:24:22.891+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:24:22.891+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:24:22.891+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:24:22.901+0200 W/LOCATION(30159): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:24:22.901+0200 W/LOCATION(30159): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:24:22.911+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:24:22.911+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:24:22.911+0200 E/LOCATION(30159): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:24:22.911+0200 I/LOCATION(30159): location.c: location_new(269) > method: 1
04-23 17:24:22.911+0200 W/LOCATION(30159): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:24:22.911+0200 W/LOCATION(30159): module-internal.c: module_new(311) > module (gps) open success
04-23 17:24:22.911+0200 W/LOCATION(30159): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:24:22.911+0200 W/LOCATION(30159): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:24:22.911+0200 W/LOCATION(30159): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:24:22.911+0200 W/LOCATION(30159): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:24:22.911+0200 W/LOCATION(30159): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:24:22.921+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:24:22.931+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:24:22.931+0200 E/LOCATION(30159): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:24:22.931+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:24:22.971+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:24:22.991+0200 W/LOCATION(30249): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:24:22.991+0200 I/LOCATION(30249): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 17:24:22.991+0200 I/LOCATION(30249): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 17:24:22.991+0200 I/location(30249): es.ugr.frailty.location:iniciado servicio de localización
04-23 17:24:23.061+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::OnStart took 301 ms (from 10958427 to 10958728) (logOverhead=0,0,0,0,0,0,0), start: 17:24:22.772
04-23 17:24:23.071+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): marshal_gps_start took 306 ms (from 10958425 to 10958731) (logOverhead=0,0,0,0,0,0,0), start: 17:24:22.770
04-23 17:24:23.071+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 306 ms (from 10958425 to 10958731) (logOverhead=0,0,0,0,0,0,0), start: 17:24:22.770
04-23 17:24:23.101+0200 I/LOCATION(30249): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:24:23.141+0200 E/location(30249): es.ugr.frailty.location: error intentando obtener la última localización
04-23 17:24:23.141+0200 W/AUL     (30249): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 17:24:23.151+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:24:23.151+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30249
04-23 17:24:23.151+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30105
04-23 17:24:23.161+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:23.161+0200 I/utils   (30105): specific action
04-23 17:24:23.161+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:23.161+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:23.161+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:23.161+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 17:24:23.161+0200 W/AUL     (30249): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30105)
04-23 17:24:23.161+0200 I/location(30249): request sent to service es.ugr.frailty.servicemanager
04-23 17:24:23.161+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:24:23.161+0200 W/CAPI_APPFW_APP_CONTROL(30249): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:23.161+0200 I/utils   (30249): specific action
04-23 17:24:23.161+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30105
04-23 17:24:23.171+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30110
04-23 17:24:23.171+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:23.171+0200 I/utils   (30110): specific action
04-23 17:24:23.171+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:23.171+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:23.171+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30110)
04-23 17:24:23.171+0200 I/servicemanager(30105): request sent to service es.ugr.frailty.recorder
04-23 17:24:23.171+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:24:23.171+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30105), cmd(0)
04-23 17:24:23.171+0200 I/servicemanager(30105): requesting to save local data
04-23 17:24:23.171+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:23.171+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:24:23.171+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:23.171+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(30110), cmd(0)
04-23 17:24:23.171+0200 I/recorder(30110): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 17:24:23.171+0200 I/recorder(30110): guardando datos en local
04-23 17:24:23.341+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 17:24:23.341+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(10959000), time2(10895587)
04-23 17:24:23.341+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 17:24:23.341+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 17:24:23.341+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 17:24:23.341+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 17:24:23.881+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 143 ms (from 10959405 to 10959548) (logOverhead=0,0,0,0,0,0,0), start: 17:24:23.750
04-23 17:24:23.881+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 143 ms (from 10959405 to 10959548) (logOverhead=0,0,0,0,0,0,0), start: 17:24:23.750
04-23 17:24:23.941+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:24:23.941+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:24:23.941+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:24:24.051+0200 E/CAPI_TELEPHONY(30159): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 17:24:24.751+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:24:24.751+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:24:24.761+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:24:24.851+0200 W/LOCATION(30249): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 17:24:25.111+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 17:24:25.111+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 17:24:25.111+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:24:25.111+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 17:24:25.111+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 17:24:25.111+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 17:24:25.111+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 17:24:25.111+0200 E/CAPI_LOCATION_MANAGER(30159): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 17:24:25.111+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 17:24:25.121+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:24:25.121+0200 W/AUL     (30261): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 17:24:25.131+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:24:25.131+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:24:25.131+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 30149
04-23 17:24:25.131+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:24:25.131+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 30149
04-23 17:24:25.131+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(30149)
04-23 17:24:25.201+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:24:25.201+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:24:25.201+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:24:25.201+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: connection_destroy(471) > Destroy handle: 0xf74a2200
04-23 17:24:25.211+0200 W/CRASH_MANAGER(30262): worker.c: worker_job(1205) > 11302496c6f63152449706
