S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 12283
Date: 2018-04-23 20:40:52+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf718652d, r5   = 0xf78e3f98
r6   = 0xffb932f0, r7   = 0xffb931a0
r8   = 0xf78e0c18, r9   = 0x00000000
r10  = 0xffb9327c, fp   = 0xffb932f0
ip   = 0x00000001, sp   = 0xffb93178
lr   = 0xf7186539, pc   = 0xf71ef228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     93072 KB
Buffers:     40224 KB
Cached:     161156 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11664 KB
VmRSS:       11664 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 12283 TID = 12283
12283 12286 

Maps Information
f4051000 f4850000 rw-p [stack:12286]
f4857000 f4859000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4861000 f4865000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f486e000 f4870000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4878000 f487b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f488a000 f488f000 r-xp /usr/lib/libsystem.so.0.0.0
f489a000 f489d000 r-xp /lib/libattr.so.1.1.0
f48a5000 f48b5000 r-xp /usr/lib/libmdm-common.so.1.1.24
f48bd000 f48c6000 r-xp /usr/lib/libedbus.so.1.7.99
f48ce000 f48cf000 r-xp /usr/lib/libresponse.so.0.2.96
f48d8000 f48dd000 r-xp /usr/lib/libproc-stat.so.0.2.96
f617f000 f6285000 r-xp /usr/lib/libicuuc.so.57.1
f629b000 f6423000 r-xp /usr/lib/libicui18n.so.57.1
f6433000 f6440000 r-xp /usr/lib/libail.so.0.1.0
f6449000 f6450000 r-xp /usr/lib/libminizip.so.1.0.0
f6459000 f6602000 r-xp /usr/lib/libcrypto.so.1.0.0
f6622000 f6669000 r-xp /usr/lib/libssl.so.1.0.0
f6675000 f6677000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f667f000 f6686000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f668f000 f6696000 r-xp /lib/libcrypt-2.13.so
f66c7000 f66ca000 r-xp /lib/libcap.so.2.21
f66d2000 f66d4000 r-xp /usr/lib/libiri.so
f66dc000 f6725000 r-xp /usr/lib/libmdm.so.1.2.69
f672d000 f6733000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f673b000 f675e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6768000 f676a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6772000 f678f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6798000 f679c000 r-xp /usr/lib/libsmack.so.1.0.0
f67a5000 f67be000 r-xp /usr/lib/libnetwork.so.0.0.0
f67c7000 f67cf000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f67d7000 f67dd000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f67e6000 f67e8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f67f1000 f6801000 r-xp /lib/libresolv-2.13.so
f6805000 f681d000 r-xp /usr/lib/liblzma.so.5.0.3
f6826000 f6828000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6830000 f684a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6852000 f6881000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f688a000 f6899000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f68a3000 f68ad000 r-xp /usr/lib/libsensord-shared.so
f68b6000 f6989000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6994000 f69aa000 r-xp /lib/libz.so.1.2.5
f69b2000 f69b7000 r-xp /usr/lib/libffi.so.5.0.10
f69bf000 f69c0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f69c8000 f69d8000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f69e0000 f69f9000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a01000 f6a03000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a0b000 f6a80000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a8a000 f6a90000 r-xp /lib/librt-2.13.so
f6a99000 f6ab7000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ac1000 f6ac2000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6aca000 f6aed000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6af5000 f6afa000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b02000 f6b2c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b35000 f6b4c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b54000 f6bbd000 r-xp /lib/libm-2.13.so
f6bc6000 f6c5a000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c6d000 f6c72000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c7a000 f6c81000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c89000 f6cb3000 r-xp /usr/lib/libsensor.so.1.9.6
f6cbc000 f6d88000 r-xp /usr/lib/libxml2.so.2.7.8
f6d95000 f6d97000 r-xp /usr/lib/libiniparser.so.0
f6da0000 f6da6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6daf000 f6e7f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e80000 f6eb4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ebd000 f6ef9000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f01000 f6f04000 r-xp /usr/lib/libbundle.so.0.1.22
f6f0c000 f6f12000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f1a000 f6f5b000 r-xp /usr/lib/libeina.so.1.7.99
f6f64000 f6f7b000 r-xp /usr/lib/libecore.so.1.7.99
f6f92000 f6f9b000 r-xp /usr/lib/libvconf.so.0.2.45
f6fa3000 f6fb7000 r-xp /lib/libpthread-2.13.so
f6fc2000 f6fcf000 r-xp /usr/lib/libaul.so.0.1.0
f6fd9000 f6fdb000 r-xp /lib/libdl-2.13.so
f6fe4000 f6fef000 r-xp /lib/libunwind.so.8.0.1
f701c000 f7024000 r-xp /lib/libgcc_s-4.6.so.1
f7025000 f7149000 r-xp /lib/libc-2.13.so
f7157000 f7159000 r-xp /usr/lib/libdlog.so.0.0.0
f7161000 f716d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7176000 f717b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7183000 f7192000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f719a000 f719e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f71a7000 f71aa000 r-xp /usr/lib/libappcore-agent.so.1.1
f71b2000 f71b4000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f71bc000 f71c0000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f71c8000 f71e5000 r-xp /lib/ld-2.13.so
f71ee000 f71f1000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f71f1000 f71f5000 r-xp /usr/lib/libsys-assert.so
f78b0000 f791e000 rw-p [heap]
ffb74000 ffb95000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12283)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf71ef228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7186539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e8d3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e8bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e97e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e9dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e9ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6ed275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6ecd1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e8bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e97e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e9dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e9ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6ecfe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6ed0017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6ed7f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf486f1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4862171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6935663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6de2fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6de47a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f74ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f6fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f705a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f70879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf71a8183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71a87fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71ef5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf703c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf71eef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
18,20:40:51:625,0.028714,9.789038,0.803988
04-23 20:40:51.639+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:51.649+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:51.649+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:51:653,0.044528,9.772432,0.817292
04-23 20:40:51.649+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:51.649+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:51:657,0.044868,9.772218,0.819834
04-23 20:40:51.649+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:51.659+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:51:651,0.059821,9.781858,0.751346
04-23 20:40:51.659+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:51.659+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:51:669,0.043071,9.786645,0.751346
04-23 20:40:51.669+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:51:641,-0.001373,0.014357,-0.067672
04-23 20:40:51.669+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:51.679+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:40:51.679+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:40:51.679+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:51:647,-0.140000,0.070000,0.140000
04-23 20:40:51.679+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:40:51.679+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:51.689+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:51.689+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:51:691,-0.140000,0.070000,0.070000
04-23 20:40:51.689+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:51.689+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:51:675,0.000935,0.038141,-0.010911
04-23 20:40:51.689+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:51.699+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:51:661,0.043338,9.772101,0.821300
04-23 20:40:51.699+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:51.699+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:51:694,0.045464,9.810574,0.806381
04-23 20:40:51.699+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:51.709+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:51:702,-0.035296,-0.035823,-0.037381
04-23 20:40:51.709+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:51:698,-0.140000,0.070000,0.070000
04-23 20:40:51.709+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:51.709+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:51:719,-0.070000,0.070000,0.070000
04-23 20:40:51.719+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:51.719+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:40:51.719+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:51:705,0.042336,9.771973,0.822884
04-23 20:40:51.719+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:51.729+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:51:712,0.009571,9.736395,0.782453
04-23 20:40:51.729+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:51.729+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:40:51.729+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:51:735,0.019143,9.817751,0.801596
04-23 20:40:51.729+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:51.729+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:51:739,0.031107,9.853643,0.782453
04-23 20:40:51.739+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:51:724,-0.024195,0.045650,-0.019704
04-23 20:40:51.739+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:51.739+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:51:744,-0.011230,0.081671,-0.040431
04-23 20:40:51.739+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:51.739+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:51.749+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:51:730,0.041936,9.771979,0.822831
04-23 20:40:51.749+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:51.749+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:51:755,0.041448,9.771923,0.823522
04-23 20:40:51.749+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:51.749+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:51:759,0.041780,9.771996,0.822630
04-23 20:40:51.759+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:51:750,-0.070000,0.140000,0.070000
04-23 20:40:51.759+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:51.759+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:51:748,-0.013222,0.005094,-0.035592
04-23 20:40:51.759+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:51.769+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:51.769+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:51:773,0.028714,9.777073,0.787239
04-23 20:40:51.769+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:51:765,-0.070000,0.070000,0.070000
04-23 20:40:51.769+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:51.769+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:51:778,-0.070000,0.210000,0.070000
04-23 20:40:51.769+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:51.779+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:51.779+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:51.789+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:51:786,0.042882,9.772022,0.822273
04-23 20:40:51.789+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:51.789+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:51:795,0.043513,9.771884,0.823879
04-23 20:40:51.789+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:51.789+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:51:799,0.042850,9.771701,0.826084
04-23 20:40:51.799+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:51:772,0.004016,0.050614,-0.045854
04-23 20:40:51.799+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:51.799+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:51:804,0.020433,0.024220,-0.030606
04-23 20:40:51.799+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:51.799+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:51:782,-0.070000,0.140000,0.140000
04-23 20:40:51.799+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:51.809+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:51:790,0.045464,9.822537,0.777667
04-23 20:40:51.809+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:51.809+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:51:814,0.062213,9.796216,0.792024
04-23 20:40:51.809+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:51.809+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:51:818,0.050249,9.827322,0.796810
04-23 20:40:51.809+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:51.829+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:51:813,-0.070000,0.070000,0.070000
04-23 20:40:51.829+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:51.829+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:51:808,0.007367,0.055300,-0.025463
04-23 20:40:51.829+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:51.829+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:51:839,-0.017192,0.017154,0.001644
04-23 20:40:51.829+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:51.839+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:51.839+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:51:834,-0.070000,0.140000,0.070000
04-23 20:40:51.839+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:51.839+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:51:843,0.043792,9.771712,0.825900
04-23 20:40:51.839+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:51.849+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:51:822,0.026321,9.789038,0.825524
04-23 20:40:51.849+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:51:852,0.043010,9.771502,0.828418
04-23 20:40:51.849+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:51.859+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:51:848,-0.070000,0.070000,0.070000
04-23 20:40:51.859+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:51.859+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:51.869+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:51:842,0.016970,0.024515,-0.026881
04-23 20:40:51.869+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:51.869+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:51:870,0.059821,9.796216,0.799203
04-23 20:40:51.869+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:51:862,0.044855,9.771496,0.828398
04-23 20:40:51.879+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:51:865,-0.070000,-0.070000,0.070000
04-23 20:40:51.879+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:51.879+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:51:884,-0.070000,-0.070000,0.070000
04-23 20:40:51.879+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:51.889+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:51:875,-0.019864,-0.023353,0.004409
04-23 20:40:51.889+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:51.889+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:51:894,0.035953,0.027106,-0.007680
04-23 20:40:51.889+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:51.889+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:51:898,0.003001,0.000792,-0.005267
04-23 20:40:51.889+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:51.899+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:51.899+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:51:903,0.045157,9.771402,0.829479
04-23 20:40:51.899+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:51.899+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:51:889,0.023928,9.748360,0.830309
04-23 20:40:51.899+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:51.909+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:51.919+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:40:51.939+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:40:51.979+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:51:921,-0.070000,0.070000,0.070000
04-23 20:40:51.979+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:51.999+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:51:910,0.078963,9.798609,0.820738
04-23 20:40:51.999+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:51.999+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:6,0.047856,9.772287,0.823131
04-23 20:40:52.009+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:51:907,0.044285,9.771388,0.829699
04-23 20:40:52.009+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.009+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:51:902,-0.021229,0.039171,-0.044633
04-23 20:40:52.009+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.009+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:18,0.027500,0.034399,-0.023318
04-23 20:40:52.009+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.019+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:51:986,-0.070000,0.070000,0.070000
04-23 20:40:52.019+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.019+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.019+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:29,0.023928,9.810574,0.784846
04-23 20:40:52.029+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:14,0.045728,9.771424,0.829198
04-23 20:40:52.029+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.029+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:34,0.045627,9.771604,0.827087
04-23 20:40:52.029+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.039+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:28,-0.070000,0.070000,0.070000
04-23 20:40:52.039+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.039+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:44,-0.070000,0.070000,0.070000
04-23 20:40:52.039+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.039+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.049+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:22,-0.005050,0.055898,-0.075459
04-23 20:40:52.049+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.049+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:57,-0.014521,0.031791,-0.025491
04-23 20:40:52.049+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.059+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:51,0.071785,9.805787,0.806381
04-23 20:40:52.059+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.059+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:38,0.045081,9.771541,0.827857
04-23 20:40:52.059+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.069+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:48,-0.070000,0.140000,0.070000
04-23 20:40:52.069+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.069+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:77,-0.070000,0.070000,0.070000
04-23 20:40:52.069+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.079+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:65,0.040678,9.827322,0.753739
04-23 20:40:52.079+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:70,0.044554,9.771526,0.828051
04-23 20:40:52.079+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.079+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:88,0.031107,9.803394,0.801596
04-23 20:40:52.089+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.089+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:60,-0.013974,0.012712,-0.043011
04-23 20:40:52.089+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.089+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:97,-0.015840,0.029475,-0.059955
04-23 20:40:52.089+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.099+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:93,0.043938,9.771584,0.827409
04-23 20:40:52.099+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.099+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.109+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:110,0.031107,9.784252,0.784846
04-23 20:40:52.109+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.109+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:80,-0.070000,0.070000,0.070000
04-23 20:40:52.109+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.109+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:119,-0.070000,0.070000,0.070000
04-23 20:40:52.109+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.119+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:105,0.043923,9.771435,0.829168
04-23 20:40:52.119+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.119+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:125,0.042653,9.771391,0.829752
04-23 20:40:52.119+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:101,-0.003260,0.046167,0.002900
04-23 20:40:52.119+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:40:52.119+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.129+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:115,0.028714,9.801002,0.768096
04-23 20:40:52.129+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:123,-0.070000,0.140000,0.070000
04-23 20:40:52.129+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:40:52.129+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.129+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:139,-0.070000,0.070000,0.070000
04-23 20:40:52.129+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.139+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.139+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:144,0.040678,9.817751,0.830309
04-23 20:40:52.139+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.149+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.149+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:153,0.043266,9.771408,0.829519
04-23 20:40:52.149+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.149+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:132,-0.029566,0.022388,-0.049107
04-23 20:40:52.149+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.159+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:148,0.014357,9.793823,0.780060
04-23 20:40:52.159+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.169+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:161,0.009989,0.022432,-0.032942
04-23 20:40:52.169+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.169+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:157,0.043176,9.771347,0.830244
04-23 20:40:52.169+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.179+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:143,-0.070000,0.070000,0.070000
04-23 20:40:52.179+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.179+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:165,0.052642,9.793823,0.796810
04-23 20:40:52.179+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:176,-0.004981,0.012844,-0.023138
04-23 20:40:52.179+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.189+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.189+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:180,0.043666,9.771462,0.828853
04-23 20:40:52.189+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.189+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:192,0.007074,0.005726,-0.054970
04-23 20:40:52.189+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.199+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:185,-0.070000,0.070000,0.070000
04-23 20:40:52.199+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.199+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:196,0.044007,9.771441,0.829087
04-23 20:40:52.199+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.209+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:209,-0.070000,0.070000,0.070000
04-23 20:40:52.209+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.209+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:193,0.038285,9.784252,0.806381
04-23 20:40:52.209+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.209+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:218,0.050249,9.777073,0.775275
04-23 20:40:52.209+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.219+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:202,0.004191,0.027146,-0.024865
04-23 20:40:52.219+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.219+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:212,0.042506,9.771365,0.830061
04-23 20:40:52.219+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.229+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:217,-0.070000,0.070000,0.070000
04-23 20:40:52.229+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.229+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:222,0.047856,9.798609,0.803988
04-23 20:40:52.239+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:237,-0.070000,0.070000,0.070000
04-23 20:40:52.239+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.239+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:246,-0.070000,0.070000,0.070000
04-23 20:40:52.239+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.259+0200 W/LOCATION(12283): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:40:52.279+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:251,-0.070000,0.140000,0.070000
04-23 20:40:52.279+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.279+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:287,-0.070000,0.070000,0.070000
04-23 20:40:52.279+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.289+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:292,-0.070000,0.070000,0.070000
04-23 20:40:52.289+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.299+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:302,-0.070000,0.070000,0.070000
04-23 20:40:52.299+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.309+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:310,-0.070000,-0.070000,0.070000
04-23 20:40:52.309+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:40:52.309+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:40:52.309+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.319+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:319,0.070000,0.070000,0.070000
04-23 20:40:52.319+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.329+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:330,-0.070000,0.070000,0.070000
04-23 20:40:52.329+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.339+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:340,-0.070000,0.140000,0.070000
04-23 20:40:52.339+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.349+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:348,-0.070000,0.140000,0.070000
04-23 20:40:52.349+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.349+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:359,-0.070000,0.070000,0.070000
04-23 20:40:52.359+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.359+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:368,-0.070000,0.070000,0.070000
04-23 20:40:52.379+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.379+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:383,-0.070000,0.070000,0.070000
04-23 20:40:52.379+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.389+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:227,-0.034436,0.029560,-0.044242
04-23 20:40:52.389+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:232,0.041532,9.771367,0.830091
04-23 20:40:52.389+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.389+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:388,-0.070000,0.070000,0.070000
04-23 20:40:52.399+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.399+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.399+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:402,0.042316,9.771373,0.829983
04-23 20:40:52.399+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.409+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:415,0.009571,9.801002,0.784846
04-23 20:40:52.409+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:413,-0.023363,0.000922,-0.059572
04-23 20:40:52.409+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.419+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:405,-0.070000,0.070000,0.070000
04-23 20:40:52.419+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:424,0.041591,9.771272,0.831201
04-23 20:40:52.419+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.419+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.419+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.429+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:436,0.013503,0.022456,-0.026103
04-23 20:40:52.439+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:432,-0.070000,0.070000,0.070000
04-23 20:40:52.439+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.439+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:433,0.019143,9.772287,0.770489
04-23 20:40:52.449+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.449+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.449+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.459+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:464,-0.018388,-0.001478,-0.025994
04-23 20:40:52.459+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:451,0.042139,9.771342,0.830350
04-23 20:40:52.469+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:463,-0.070000,0.070000,0.070000
04-23 20:40:52.469+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:462,0.055035,9.793823,0.803988
04-23 20:40:52.469+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.469+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:478,0.042439,9.771343,0.830320
04-23 20:40:52.469+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.469+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.479+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.489+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:484,-0.070000,0.070000,0.070000
04-23 20:40:52.499+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.499+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:491,0.008658,0.046479,-0.043963
04-23 20:40:52.499+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:485,0.023928,9.769895,0.803988
04-23 20:40:52.499+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.499+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.509+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.509+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:40:52.509+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:40:52.509+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:505,0.042730,9.771315,0.830639
04-23 20:40:52.519+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:519,0.003325,0.032052,-0.031148
04-23 20:40:52.519+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:513,-0.070000,0.070000,0.070000
04-23 20:40:52.519+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.529+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:513,0.050249,9.817751,0.787239
04-23 20:40:52.529+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.529+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.529+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.539+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:544,-0.070000,0.070000,0.070000
04-23 20:40:52.549+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:543,0.045464,9.803394,0.799203
04-23 20:40:52.549+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:534,0.040935,9.771246,0.831539
04-23 20:40:52.549+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.559+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:563,0.040515,9.771174,0.832401
04-23 20:40:52.559+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:547,0.003025,0.008123,-0.026332
04-23 20:40:52.559+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.559+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.559+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.569+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:575,-0.040337,0.056007,-0.057758
04-23 20:40:52.569+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.569+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:571,-0.070000,0.070000,0.070000
04-23 20:40:52.579+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:573,0.045464,9.779467,0.803988
04-23 20:40:52.589+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.589+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.589+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.599+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:585,0.039865,9.771103,0.833273
04-23 20:40:52.599+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:599,-0.012222,0.010612,-0.022765
04-23 20:40:52.609+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.609+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:597,0.002393,9.827322,0.772882
04-23 20:40:52.609+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:615,0.039936,9.771291,0.831058
04-23 20:40:52.609+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:596,-0.070000,0.070000,0.070000
04-23 20:40:52.609+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.609+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.609+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.619+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:623,-0.070000,0.070000,0.140000
04-23 20:40:52.639+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.639+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:630,-0.016587,0.027434,-0.026020
04-23 20:40:52.639+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:646,0.038734,9.771235,0.831782
04-23 20:40:52.639+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:626,0.028714,9.781858,0.808774
04-23 20:40:52.649+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.649+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.649+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.659+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.659+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:655,-0.070000,0.140000,0.070000
04-23 20:40:52.659+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:660,0.023928,9.798609,0.806381
04-23 20:40:52.659+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:657,-0.001580,0.037077,-0.079533
04-23 20:40:52.669+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.669+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.669+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.669+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:676,-0.070000,0.070000,0.070000
04-23 20:40:52.679+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:666,0.038745,9.771066,0.833766
04-23 20:40:52.679+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:40:52.679+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:40:52.679+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:40:52.679+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.699+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:680,-0.027972,0.015354,-0.058176
04-23 20:40:52.699+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.699+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:684,0.038285,9.808180,0.753739
04-23 20:40:52.699+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.699+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.709+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:713,0.011964,9.786645,0.772882
04-23 20:40:52.709+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:693,0.037608,9.771005,0.834529
04-23 20:40:52.709+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:40:52.709+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:40:52.709+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:707,-0.070000,0.070000,0.140000
04-23 20:40:52.709+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.719+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:710,-0.002842,-0.022875,-0.006258
04-23 20:40:52.719+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.719+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.719+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.719+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:721,0.038009,9.771165,0.832634
04-23 20:40:52.729+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:733,0.035892,9.748360,0.825524
04-23 20:40:52.739+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:731,-0.026781,0.032329,-0.053705
04-23 20:40:52.739+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:727,-0.070000,0.070000,0.070000
04-23 20:40:52.739+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.739+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.749+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.749+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:754,-0.070000,0.070000,0.070000
04-23 20:40:52.749+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.749+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:748,0.037137,9.771121,0.833182
04-23 20:40:52.749+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:759,0.011964,9.803394,0.780060
04-23 20:40:52.759+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:762,0.005463,0.065888,-0.064040
04-23 20:40:52.759+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.769+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.769+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.779+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:783,-0.070000,0.070000,0.070000
04-23 20:40:52.779+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:768,0.036885,9.771132,0.833062
04-23 20:40:52.779+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.789+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:788,0.043071,9.836893,0.770489
04-23 20:40:52.789+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.799+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:790,-0.021259,0.025051,-0.052574
04-23 20:40:52.829+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.839+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:841,-0.070000,0.070000,0.070000
04-23 20:40:52.839+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.839+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:845,-0.070000,0.070000,0.070000
04-23 20:40:52.839+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.849+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:850,-0.070000,0.140000,0.070000
04-23 20:40:52.849+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.849+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:855,-0.070000,0.070000,0.070000
04-23 20:40:52.849+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.859+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:860,-0.070000,0.070000,0.070000
04-23 20:40:52.859+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.859+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:865,-0.070000,0.070000,0.070000
04-23 20:40:52.859+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.869+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:871,-0.070000,0.070000,0.070000
04-23 20:40:52.869+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.869+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:876,-0.070000,0.070000,0.070000
04-23 20:40:52.869+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.879+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:881,-0.070000,0.070000,0.070000
04-23 20:40:52.879+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.879+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:886,-0.070000,0.070000,0.070000
04-23 20:40:52.879+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.889+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:891,-0.070000,0.070000,0.070000
04-23 20:40:52.889+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.889+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:897,-0.070000,0.070000,0.070000
04-23 20:40:52.889+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.899+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:901,-0.070000,0.070000,0.070000
04-23 20:40:52.899+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.899+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.909+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:910,-0.070000,0.070000,0.070000
04-23 20:40:52.909+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:40:52.909+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:40:52.909+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:908,0.016750,9.796216,0.780060
04-23 20:40:52.909+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.919+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:922,0.028714,9.765109,0.780060
04-23 20:40:52.919+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.919+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.929+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:930,-0.070000,0.070000,0.070000
04-23 20:40:52.929+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:927,0.028714,9.808180,0.799203
04-23 20:40:52.929+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.929+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:52:938,0.021535,9.844072,0.830309
04-23 20:40:52.939+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:52.939+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:52.939+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:52:801,0.036639,9.771079,0.833699
04-23 20:40:52.939+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:52.949+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:52:951,-0.070000,0.070000,0.070000
04-23 20:40:52.949+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:52:956,-0.008423,-0.006012,-0.053122
04-23 20:40:52.949+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:52.949+0200 W/CRASH_MANAGER(12149): worker.c: worker_job(1205) > 11122836c6f63152450885
