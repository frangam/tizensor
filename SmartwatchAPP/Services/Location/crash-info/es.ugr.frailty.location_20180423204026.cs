S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 12090
Date: 2018-04-23 20:40:26+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf71d052d, r5   = 0xf76abf98
r6   = 0xffc99ca0, r7   = 0xffc99b50
r8   = 0xf76a8c18, r9   = 0x00000000
r10  = 0xffc99c2c, fp   = 0xffc99ca0
ip   = 0x00000001, sp   = 0xffc99b28
lr   = 0xf71d0539, pc   = 0xf7239228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    128668 KB
Buffers:     40016 KB
Cached:     160656 KB
VmPeak:      53592 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11892 KB
VmRSS:       11888 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 12090 TID = 12090
12090 12138 

Maps Information
f409b000 f489a000 rw-p [stack:12138]
f48a1000 f48a3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f48ab000 f48af000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f48b8000 f48ba000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f48c2000 f48c5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f48d4000 f48d9000 r-xp /usr/lib/libsystem.so.0.0.0
f48e4000 f48e7000 r-xp /lib/libattr.so.1.1.0
f48ef000 f48ff000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4907000 f4910000 r-xp /usr/lib/libedbus.so.1.7.99
f4918000 f4919000 r-xp /usr/lib/libresponse.so.0.2.96
f4922000 f4927000 r-xp /usr/lib/libproc-stat.so.0.2.96
f61c9000 f62cf000 r-xp /usr/lib/libicuuc.so.57.1
f62e5000 f646d000 r-xp /usr/lib/libicui18n.so.57.1
f647d000 f648a000 r-xp /usr/lib/libail.so.0.1.0
f6493000 f649a000 r-xp /usr/lib/libminizip.so.1.0.0
f64a3000 f664c000 r-xp /usr/lib/libcrypto.so.1.0.0
f666c000 f66b3000 r-xp /usr/lib/libssl.so.1.0.0
f66bf000 f66c1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f66c9000 f66d0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f66d9000 f66e0000 r-xp /lib/libcrypt-2.13.so
f6711000 f6714000 r-xp /lib/libcap.so.2.21
f671c000 f671e000 r-xp /usr/lib/libiri.so
f6726000 f676f000 r-xp /usr/lib/libmdm.so.1.2.69
f6777000 f677d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6785000 f67a8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f67b2000 f67b4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f67bc000 f67d9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f67e2000 f67e6000 r-xp /usr/lib/libsmack.so.1.0.0
f67ef000 f6808000 r-xp /usr/lib/libnetwork.so.0.0.0
f6811000 f6819000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6821000 f6827000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6830000 f6832000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f683b000 f684b000 r-xp /lib/libresolv-2.13.so
f684f000 f6867000 r-xp /usr/lib/liblzma.so.5.0.3
f6870000 f6872000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f687a000 f6894000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f689c000 f68cb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68d4000 f68e3000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f68ed000 f68f7000 r-xp /usr/lib/libsensord-shared.so
f6900000 f69d3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f69de000 f69f4000 r-xp /lib/libz.so.1.2.5
f69fc000 f6a01000 r-xp /usr/lib/libffi.so.5.0.10
f6a09000 f6a0a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a12000 f6a22000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a2a000 f6a43000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a4b000 f6a4d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a55000 f6aca000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ad4000 f6ada000 r-xp /lib/librt-2.13.so
f6ae3000 f6b01000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b0b000 f6b0c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b14000 f6b37000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b3f000 f6b44000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b4c000 f6b76000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b7f000 f6b96000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b9e000 f6c07000 r-xp /lib/libm-2.13.so
f6c10000 f6ca4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6cb7000 f6cbc000 r-xp /usr/lib/libctx-client.so.0.8.3
f6cc4000 f6ccb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6cd3000 f6cfd000 r-xp /usr/lib/libsensor.so.1.9.6
f6d06000 f6dd2000 r-xp /usr/lib/libxml2.so.2.7.8
f6ddf000 f6de1000 r-xp /usr/lib/libiniparser.so.0
f6dea000 f6df0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6df9000 f6ec9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6eca000 f6efe000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f07000 f6f43000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f4b000 f6f4e000 r-xp /usr/lib/libbundle.so.0.1.22
f6f56000 f6f5c000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f64000 f6fa5000 r-xp /usr/lib/libeina.so.1.7.99
f6fae000 f6fc5000 r-xp /usr/lib/libecore.so.1.7.99
f6fdc000 f6fe5000 r-xp /usr/lib/libvconf.so.0.2.45
f6fed000 f7001000 r-xp /lib/libpthread-2.13.so
f700c000 f7019000 r-xp /usr/lib/libaul.so.0.1.0
f7023000 f7025000 r-xp /lib/libdl-2.13.so
f702e000 f7039000 r-xp /lib/libunwind.so.8.0.1
f7066000 f706e000 r-xp /lib/libgcc_s-4.6.so.1
f706f000 f7193000 r-xp /lib/libc-2.13.so
f71a1000 f71a3000 r-xp /usr/lib/libdlog.so.0.0.0
f71ab000 f71b7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71c0000 f71c5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f71cd000 f71dc000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f71e4000 f71e8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f71f1000 f71f4000 r-xp /usr/lib/libappcore-agent.so.1.1
f71fc000 f71fe000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7206000 f720a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7212000 f722f000 r-xp /lib/ld-2.13.so
f7238000 f723b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f723b000 f723f000 r-xp /usr/lib/libsys-assert.so
f7678000 f76e9000 rw-p [heap]
ffc7b000 ffc9c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12090)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7239228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf71d0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6ed73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6ed5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6ee1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6ee7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6ee7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f1c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f171f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6ed5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6ee1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6ee7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6ee7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f19e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f1a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f21f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48b91fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf48ac171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf697f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e2cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e2e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6fbeca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6fb9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6fba5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6fba879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf71f2183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71f27fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72395c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf708685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7238f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ilty.gravity
04-23 20:40:25.859+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:25:859,0.055035,9.769895,0.811167
04-23 20:40:25.859+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:25:849,-0.070000,0.140000,0.070000
04-23 20:40:25.859+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:25.859+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:25:858,-0.053957,0.072423,-0.019070
04-23 20:40:25.859+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:25.859+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:25:867,-0.070000,-0.210000,0.070000
04-23 20:40:25.869+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:25.869+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:25:872,-0.037638,-0.011373,-0.025695
04-23 20:40:25.869+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:25:874,0.066999,9.791430,0.806381
04-23 20:40:25.869+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:25.869+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:25.869+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:25:863,0.044816,9.769310,0.853788
04-23 20:40:25.869+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:25.879+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:25:879,-0.018461,0.036619,-0.080009
04-23 20:40:25.879+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:25.879+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.147468] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:25.879+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:25:879,-0.070000,-0.210000,0.070000
04-23 20:40:25.889+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:25.889+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:25:889,-0.007359,0.020016,-0.065011
04-23 20:40:25.889+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:25.889+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:25:894,0.009571,9.808180,0.861416
04-23 20:40:25.889+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:25.889+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:25:882,0.045481,9.769423,0.852461
04-23 20:40:25.889+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:40:25.889+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:40:25.899+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:25:897,0.010071,0.000740,-0.044393
04-23 20:40:25.899+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:25.899+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:25.899+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:25:903,0.046657,9.769548,0.850963
04-23 20:40:25.899+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:25:904,0.022183,0.022120,-0.047407
04-23 20:40:25.899+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:25.899+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:25:899,-0.070000,0.070000,0.070000
04-23 20:40:25.899+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:25:908,-0.035910,0.038756,0.008956
04-23 20:40:25.899+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:25.909+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:25.909+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:25.909+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:25:913,0.064606,9.810574,0.806381
04-23 20:40:25.919+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:25.919+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:25:914,0.017949,0.041025,-0.044582
04-23 20:40:25.919+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.184055] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:25.919+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:25:918,-0.070000,0.070000,0.070000
04-23 20:40:25.929+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:25.929+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:25.929+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:25:935,0.059821,9.815358,0.818345
04-23 20:40:25.929+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:25.929+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:25:936,0.014763,0.046041,-0.035346
04-23 20:40:25.939+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:25:940,0.070000,-0.140000,0.070000
04-23 20:40:25.939+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:25:926,0.045058,9.769318,0.853691
04-23 20:40:25.939+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:25.939+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:25:946,0.046147,9.769511,0.851413
04-23 20:40:25.949+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:25.949+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.214503] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:25.949+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:25.949+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:25:955,0.031107,9.784252,0.820738
04-23 20:40:25.949+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:25.959+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:25:959,-0.140000,0.070000,0.070000
04-23 20:40:25.959+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:25:959,-0.015040,0.014741,-0.030674
04-23 20:40:25.959+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:25.959+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:25:967,0.046940,9.769546,0.850975
04-23 20:40:25.959+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:25.969+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:25.969+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:25.969+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:25:974,0.012881,0.012313,-0.003916
04-23 20:40:25.969+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:25:973,0.059821,9.781858,0.847059
04-23 20:40:25.969+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:25:978,-0.070000,0.070000,0.070000
04-23 20:40:25.969+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:25.979+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.246569] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:25.979+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:25:982,0.046330,9.769495,0.851588
04-23 20:40:25.989+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:25.989+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:25.989+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:25:994,-0.060687,-0.004386,-0.028457
04-23 20:40:25.989+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:25.989+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:25.989+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:40:25.989+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:40:25.989+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:25:998,-0.070000,0.070000,0.070000
04-23 20:40:25.999+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:25:994,-0.014357,9.765109,0.823131
04-23 20:40:25.999+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:25:997,0.047112,9.769394,0.852702
04-23 20:40:26.009+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.009+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.009+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:14,0.021535,9.829715,0.806381
04-23 20:40:26.009+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.019+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.281608] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:26.019+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:13,-0.025577,0.060321,-0.046321
04-23 20:40:26.019+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.019+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:22,0.044480,9.769078,0.856458
04-23 20:40:26.019+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:26,-0.070000,0.070000,0.140000
04-23 20:40:26.029+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.029+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.029+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:35,-0.020551,0.036709,-0.057256
04-23 20:40:26.029+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:35,0.023928,9.805787,0.799203
04-23 20:40:26.029+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.029+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.039+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:39,0.043520,9.769074,0.856543
04-23 20:40:26.039+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:40,-0.070000,0.070000,0.070000
04-23 20:40:26.049+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.049+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.314556] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:26.049+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.049+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:56,0.030657,0.019963,-0.081269
04-23 20:40:26.049+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.059+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:58,0.074178,9.789038,0.775275
04-23 20:40:26.059+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.059+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:64,0.042743,9.769138,0.855862
04-23 20:40:26.059+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:62,-0.070000,-0.140000,0.070000
04-23 20:40:26.069+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.069+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.069+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.069+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:74,0.023928,9.734003,0.780060
04-23 20:40:26.069+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.069+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:75,-0.018815,-0.035135,-0.075802
04-23 20:40:26.089+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.353626] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:26.089+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.099+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:40:26.099+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:40:26.099+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:78,0.044437,9.769531,0.851280
04-23 20:40:26.099+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.099+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:73,-0.070000,-0.140000,0.070000
04-23 20:40:26.099+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.109+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:97,0.062213,9.822537,0.832702
04-23 20:40:26.109+0200 W/LOCATION(12090): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:40:26.119+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.119+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.385068] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:26.119+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.129+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:129,0.033500,9.805787,0.813560
04-23 20:40:26.129+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.129+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:127,0.017776,0.053006,-0.018578
04-23 20:40:26.129+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:137,0.083749,9.798609,0.782453
04-23 20:40:26.129+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:106,0.043766,9.769482,0.851876
04-23 20:40:26.129+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.139+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:108,-0.070000,-0.070000,0.140000
04-23 20:40:26.139+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.139+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:142,0.044925,9.769347,0.853359
04-23 20:40:26.139+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.139+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:147,0.044535,9.769366,0.853156
04-23 20:40:26.149+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.149+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.415962] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:26.149+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.159+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:160,0.050249,9.812965,0.813560
04-23 20:40:26.159+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.159+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:156,-0.010266,0.036305,-0.038316
04-23 20:40:26.169+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:167,0.046573,9.769701,0.849212
04-23 20:40:26.169+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.169+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:147,-0.070000,0.070000,0.140000
04-23 20:40:26.169+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.169+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:173,0.026321,9.803394,0.763310
04-23 20:40:26.169+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.169+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.179+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:179,0.047039,9.769612,0.850208
04-23 20:40:26.189+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.450501] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:26.189+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.189+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:179,-0.070000,-0.070000,0.070000
04-23 20:40:26.189+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:40:26.189+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:40:26.189+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:194,0.011964,9.784252,0.784846
04-23 20:40:26.189+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.199+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:201,0.046185,9.769749,0.848683
04-23 20:40:26.199+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:186,0.038824,0.029262,-0.070906
04-23 20:40:26.199+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.199+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.199+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:207,-0.070000,0.070000,0.070000
04-23 20:40:26.199+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.209+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.209+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.209+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:208,0.005714,0.043599,-0.039596
04-23 20:40:26.219+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.219+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.482108] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:26.219+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:214,0.038285,9.796216,0.832702
04-23 20:40:26.219+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:216,0.044836,9.769611,0.850332
04-23 20:40:26.219+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:224,-0.020252,0.033693,-0.085901
04-23 20:40:26.219+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:211,-0.070000,0.070000,0.140000
04-23 20:40:26.229+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.229+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.229+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:235,-0.011964,9.789038,0.815953
04-23 20:40:26.229+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.229+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.229+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:239,0.044668,9.769527,0.851305
04-23 20:40:26.239+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:233,-0.140000,0.070000,0.070000
04-23 20:40:26.239+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.239+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:240,-0.035075,0.014640,-0.065362
04-23 20:40:26.239+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.239+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:246,-0.070000,0.070000,0.140000
04-23 20:40:26.239+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.249+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.515323] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:26.249+0200 I/servicemanager(12059): es.ugr.frailty.location sleep timeout
04-23 20:40:26.249+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:40:26.249+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:40:26.249+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.249+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.249+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12059
04-23 20:40:26.259+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:260,0.042261,9.769214,0.855018
04-23 20:40:26.259+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:259,0.055035,9.781858,0.815953
04-23 20:40:26.259+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:250,-0.070000,0.070000,0.070000
04-23 20:40:26.269+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.269+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.269+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12090
04-23 20:40:26.269+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12090)
04-23 20:40:26.269+0200 I/servicemanager(12059): es.ugr.frailty.location stop request sent!
04-23 20:40:26.269+0200 I/servicemanager(12059): App control destroyed.
04-23 20:40:26.269+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:273,0.043028,9.769305,0.853932
04-23 20:40:26.269+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:274,0.023928,9.827322,0.770489
04-23 20:40:26.279+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.279+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:248,-0.007900,0.026467,-0.015980
04-23 20:40:26.279+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.279+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.548744] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:26.289+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:283,0.070000,0.070000,0.140000
04-23 20:40:26.289+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.289+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.289+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.289+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:40:26.289+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:40:26.299+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:300,0.038285,9.796216,0.784846
04-23 20:40:26.299+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:290,-0.056800,0.019426,-0.034380
04-23 20:40:26.299+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:296,0.042415,9.769302,0.853997
04-23 20:40:26.299+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.299+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:294,-0.070000,-0.070000,0.070000
04-23 20:40:26.299+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.299+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:308,-0.140000,-0.070000,0.140000
04-23 20:40:26.309+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.309+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.309+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:305,0.010367,0.012331,-0.035352
04-23 20:40:26.309+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.309+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:314,0.066999,9.815358,0.818345
04-23 20:40:26.309+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.309+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:315,-0.018333,0.058108,-0.084529
04-23 20:40:26.319+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.319+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.581556] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:26.319+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:324,-0.004743,0.026911,-0.069086
04-23 20:40:26.319+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.319+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:318,0.042518,9.769286,0.854182
04-23 20:40:26.329+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.329+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.329+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:329,0.024584,0.046056,-0.035652
04-23 20:40:26.329+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.329+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:335,0.043821,9.769382,0.853009
04-23 20:40:26.329+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:334,0.031107,9.810574,0.832702
04-23 20:40:26.329+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:338,-0.011411,0.041287,-0.021479
04-23 20:40:26.339+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:313,-0.140000,0.070000,0.140000
04-23 20:40:26.339+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.339+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:347,-0.140000,0.070000,0.070000
04-23 20:40:26.349+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.349+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.616841] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:26.349+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.349+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:358,-0.012714,0.019655,-0.080127
04-23 20:40:26.359+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.359+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:360,0.031107,9.789038,0.772882
04-23 20:40:26.359+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:365,0.043504,9.769178,0.855360
04-23 20:40:26.359+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.369+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.369+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.369+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:374,0.071785,9.729217,0.736989
04-23 20:40:26.369+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.369+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:374,0.028281,-0.039962,-0.118370
04-23 20:40:26.369+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:378,0.042745,9.769628,0.850254
04-23 20:40:26.379+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:371,0.070000,0.070000,0.140000
04-23 20:40:26.379+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.379+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.648369] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:26.389+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:384,0.070000,0.070000,-0.070000
04-23 20:40:26.389+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.389+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.389+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:395,-0.014031,0.036160,0.001591
04-23 20:40:26.389+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:395,0.028714,9.805787,0.851845
04-23 20:40:26.389+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.389+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:40:26.389+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:40:26.399+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.399+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:403,0.070000,-0.070000,0.140000
04-23 20:40:26.399+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:399,0.044502,9.770075,0.845013
04-23 20:40:26.409+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.409+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.409+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.409+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.409+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:413,0.040678,9.798609,0.897308
04-23 20:40:26.419+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:415,-0.003824,0.028534,0.052296
04-23 20:40:26.419+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.682452] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:26.419+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:413,0.070000,-0.140000,0.070000
04-23 20:40:26.429+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.429+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:436,-0.017594,-0.009614,-0.073748
04-23 20:40:26.429+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.429+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.439+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:416,0.043915,9.769938,0.846629
04-23 20:40:26.439+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.439+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:443,0.043920,9.769643,0.850016
04-23 20:40:26.439+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:440,0.070000,-0.140000,0.070000
04-23 20:40:26.439+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:440,0.026321,9.760324,0.772882
04-23 20:40:26.449+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.449+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.716264] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:26.449+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:455,-0.010420,0.024180,-0.072349
04-23 20:40:26.449+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.459+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:461,0.033500,9.793823,0.777667
04-23 20:40:26.459+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.459+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:466,0.043216,9.769726,0.849106
04-23 20:40:26.459+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.469+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.469+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.469+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:473,0.016605,0.081526,-0.090581
04-23 20:40:26.469+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.479+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:474,0.059821,9.851252,0.758525
04-23 20:40:26.479+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.748409] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:26.489+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.489+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:471,-0.070000,0.140000,0.070000
04-23 20:40:26.489+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.489+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:494,-0.002211,0.045527,-0.036728
04-23 20:40:26.489+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:40:26.489+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:40:26.499+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.499+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:498,-0.070000,0.140000,0.070000
04-23 20:40:26.499+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.499+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:504,-0.070000,0.140000,0.070000
04-23 20:40:26.499+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:479,0.042889,9.769832,0.847895
04-23 20:40:26.499+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.509+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.509+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.509+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:514,-0.003165,0.061923,0.003299
04-23 20:40:26.509+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:503,0.040678,9.815358,0.811167
04-23 20:40:26.519+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.788761] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:26.529+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:515,-0.070000,0.140000,0.140000
04-23 20:40:26.539+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.539+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.549+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.549+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:559,0.040678,9.832108,0.847059
04-23 20:40:26.559+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:510,0.043843,9.770185,0.843761
04-23 20:40:26.559+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:552,-0.012870,0.021395,-0.010391
04-23 20:40:26.559+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.559+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.824494] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:26.559+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:552,-0.070000,0.070000,0.140000
04-23 20:40:26.559+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.559+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.569+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.569+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:572,-0.070000,0.070000,0.140000
04-23 20:40:26.569+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:565,-0.032144,0.007314,-0.054254
04-23 20:40:26.569+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.569+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:579,0.018424,0.017144,-0.050066
04-23 20:40:26.579+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:570,0.043977,9.770036,0.845487
04-23 20:40:26.579+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:576,0.031107,9.791430,0.835095
04-23 20:40:26.579+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.589+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.589+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:593,0.044108,9.769759,0.848671
04-23 20:40:26.589+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.589+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.589+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:40:26.589+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:40:26.599+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.863598] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:26.599+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:597,0.043789,9.769501,0.851661
04-23 20:40:26.599+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:591,0.011964,9.777073,0.794417
04-23 20:40:26.599+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.609+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.619+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.619+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:600,-0.035384,0.031692,-0.069063
04-23 20:40:26.619+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.619+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.886656] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:26.629+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:628,-0.036469,0.026737,-0.043142
04-23 20:40:26.629+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:616,0.062213,9.786645,0.801596
04-23 20:40:26.629+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:627,0.042563,9.769310,0.853909
04-23 20:40:26.639+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.639+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.639+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.639+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:613,-0.070000,0.070000,0.140000
04-23 20:40:26.639+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.649+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:643,0.007178,9.801002,0.784846
04-23 20:40:26.649+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:648,0.043647,9.769479,0.851916
04-23 20:40:26.649+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.918781] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:26.649+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.659+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.659+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:649,-0.022898,0.021995,-0.015003
04-23 20:40:26.659+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.669+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:649,-0.070000,0.070000,0.070000
04-23 20:40:26.669+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.669+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:665,0.042040,9.769436,0.852491
04-23 20:40:26.669+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:673,0.002848,0.033792,-0.005996
04-23 20:40:26.669+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:662,0.007178,9.796216,0.808774
04-23 20:40:26.679+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.679+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.689+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.952205] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:26.689+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:40:26.689+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:40:26.689+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:40:26.699+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:40:26.699+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:40:26.699+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:677,-0.070000,0.070000,0.070000
04-23 20:40:26.699+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.699+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.699+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:704,-0.070000,0.070000,-0.070000
04-23 20:40:26.699+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.699+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:709,-0.070000,0.070000,0.140000
04-23 20:40:26.709+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.709+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:689,0.040222,9.769603,0.850662
04-23 20:40:26.709+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:26:687,0.019143,9.791430,0.837488
04-23 20:40:26.709+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:26.709+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:26.709+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:713,-0.070000,0.140000,0.070000
04-23 20:40:26.709+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.719+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2901.982532] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:26.719+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:26:704,-0.001238,0.014976,-0.060015
04-23 20:40:26.719+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:26.719+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:26:724,0.039524,9.769277,0.854432
04-23 20:40:26.729+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:718,-0.070000,0.140000,0.070000
04-23 20:40:26.749+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2902.016350] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:26.759+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.779+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2902.048861] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:26.789+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:767,-0.070000,-0.070000,0.070000
04-23 20:40:26.789+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:40:26.789+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:40:26.789+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.799+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:801,-0.070000,-0.070000,0.070000
04-23 20:40:26.799+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.799+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:807,-0.140000,0.070000,0.070000
04-23 20:40:26.799+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:26.819+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2902.084767] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:40:26.819+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:26:811,-0.070000,0.070000,0.070000
04-23 20:40:26.819+0200 W/CRASH_MANAGER(12149): worker.c: worker_job(1205) > 11120906c6f63152450882
