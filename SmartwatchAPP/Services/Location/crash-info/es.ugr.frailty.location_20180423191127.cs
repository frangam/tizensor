S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 9886
Date: 2018-04-23 19:11:27+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf76c852d, r5   = 0xf7bbbf98
r6   = 0xffd50b50, r7   = 0xffd50a00
r8   = 0xf7bb8c18, r9   = 0x00000000
r10  = 0xffd50adc, fp   = 0xffd50b50
ip   = 0x00000001, sp   = 0xffd509d8
lr   = 0xf76c8539, pc   = 0xf7731228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     43312 KB
Buffers:     46340 KB
Cached:     232716 KB
VmPeak:      53548 KB
VmSize:      53544 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11928 KB
VmRSS:       11928 KB
VmData:      11272 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 9886 TID = 9886
9886 9930 

Maps Information
f4593000 f4d92000 rw-p [stack:9930]
f4d99000 f4d9b000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4da3000 f4da7000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4db0000 f4db2000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4dba000 f4dbd000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4dcc000 f4dd1000 r-xp /usr/lib/libsystem.so.0.0.0
f4ddc000 f4ddf000 r-xp /lib/libattr.so.1.1.0
f4de7000 f4df7000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4dff000 f4e08000 r-xp /usr/lib/libedbus.so.1.7.99
f4e10000 f4e11000 r-xp /usr/lib/libresponse.so.0.2.96
f4e1a000 f4e1f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f66c1000 f67c7000 r-xp /usr/lib/libicuuc.so.57.1
f67dd000 f6965000 r-xp /usr/lib/libicui18n.so.57.1
f6975000 f6982000 r-xp /usr/lib/libail.so.0.1.0
f698b000 f6992000 r-xp /usr/lib/libminizip.so.1.0.0
f699b000 f6b44000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b64000 f6bab000 r-xp /usr/lib/libssl.so.1.0.0
f6bb7000 f6bb9000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6bc1000 f6bc8000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6bd1000 f6bd8000 r-xp /lib/libcrypt-2.13.so
f6c09000 f6c0c000 r-xp /lib/libcap.so.2.21
f6c14000 f6c16000 r-xp /usr/lib/libiri.so
f6c1e000 f6c67000 r-xp /usr/lib/libmdm.so.1.2.69
f6c6f000 f6c75000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c7d000 f6ca0000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6caa000 f6cac000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6cb4000 f6cd1000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6cda000 f6cde000 r-xp /usr/lib/libsmack.so.1.0.0
f6ce7000 f6d00000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d09000 f6d11000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d19000 f6d1f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d28000 f6d2a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d33000 f6d43000 r-xp /lib/libresolv-2.13.so
f6d47000 f6d5f000 r-xp /usr/lib/liblzma.so.5.0.3
f6d68000 f6d6a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d72000 f6d8c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d94000 f6dc3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6dcc000 f6ddb000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6de5000 f6def000 r-xp /usr/lib/libsensord-shared.so
f6df8000 f6ecb000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ed6000 f6eec000 r-xp /lib/libz.so.1.2.5
f6ef4000 f6ef9000 r-xp /usr/lib/libffi.so.5.0.10
f6f01000 f6f02000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f0a000 f6f1a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f22000 f6f3b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f43000 f6f45000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f4d000 f6fc2000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6fcc000 f6fd2000 r-xp /lib/librt-2.13.so
f6fdb000 f6ff9000 r-xp /usr/lib/libsystemd.so.0.4.0
f7003000 f7004000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f700c000 f702f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7037000 f703c000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7044000 f706e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7077000 f708e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7096000 f70ff000 r-xp /lib/libm-2.13.so
f7108000 f719c000 r-xp /usr/lib/libstdc++.so.6.0.16
f71af000 f71b4000 r-xp /usr/lib/libctx-client.so.0.8.3
f71bc000 f71c3000 r-xp /usr/lib/libctx-shared.so.0.8.3
f71cb000 f71f5000 r-xp /usr/lib/libsensor.so.1.9.6
f71fe000 f72ca000 r-xp /usr/lib/libxml2.so.2.7.8
f72d7000 f72d9000 r-xp /usr/lib/libiniparser.so.0
f72e2000 f72e8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f72f1000 f73c1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f73c2000 f73f6000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f73ff000 f743b000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7443000 f7446000 r-xp /usr/lib/libbundle.so.0.1.22
f744e000 f7454000 r-xp /usr/lib/libappsvc.so.0.1.0
f745c000 f749d000 r-xp /usr/lib/libeina.so.1.7.99
f74a6000 f74bd000 r-xp /usr/lib/libecore.so.1.7.99
f74d4000 f74dd000 r-xp /usr/lib/libvconf.so.0.2.45
f74e5000 f74f9000 r-xp /lib/libpthread-2.13.so
f7504000 f7511000 r-xp /usr/lib/libaul.so.0.1.0
f751b000 f751d000 r-xp /lib/libdl-2.13.so
f7526000 f7531000 r-xp /lib/libunwind.so.8.0.1
f755e000 f7566000 r-xp /lib/libgcc_s-4.6.so.1
f7567000 f768b000 r-xp /lib/libc-2.13.so
f7699000 f769b000 r-xp /usr/lib/libdlog.so.0.0.0
f76a3000 f76af000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f76b8000 f76bd000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f76c5000 f76d4000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f76dc000 f76e0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f76e9000 f76ec000 r-xp /usr/lib/libappcore-agent.so.1.1
f76f4000 f76f6000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f76fe000 f7702000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f770a000 f7727000 r-xp /lib/ld-2.13.so
f7730000 f7733000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7733000 f7737000 r-xp /usr/lib/libsys-assert.so
f7b88000 f7c11000 rw-p [heap]
ffd32000 ffd53000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9886)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7731228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf76c8539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73cf3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf73cdc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf73d9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf73dfbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf73dfdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf741475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf740f1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf73cdc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf73d9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf73dfbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf73dfdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7411e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7412017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7419f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4db11fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4da4171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e77663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7324fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73267a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf74b6ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf74b1b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74b25a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf74b2879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf76ea183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76ea7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf77314f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf757e85c) [/lib/libc.so.6] + 0x1785c
29: (0xf7730f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
,-1.897643,9.352250
04-23 19:11:26.259+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:243,2.337788,-1.792224,9.468399
04-23 19:11:26.259+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.259+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:247,0.840000,0.560000,0.700000
04-23 19:11:26.259+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.259+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.259+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:267,1.540000,0.840000,0.700000
04-23 19:11:26.259+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.269+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:268,0.093128,0.040712,0.036988
04-23 19:11:26.269+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.269+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.269+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:278,2.263466,-1.909686,9.348807
04-23 19:11:26.279+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:265,2.349752,-1.859223,9.389436
04-23 19:11:26.279+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.279+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:284,2.368894,-2.091327,9.291330
04-23 19:11:26.279+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:271,-0.070000,0.420000,0.630000
04-23 19:11:26.279+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.289+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.289+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.289+0200 I/heartrate( 9753): capturing data from es.ugr.frailty.heartrate
04-23 19:11:26.289+0200 I/heartrate( 9753): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:11:26.299+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:300,2.340181,-2.148755,9.406186
04-23 19:11:26.299+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:280,0.109526,-0.193684,-0.060920
04-23 19:11:26.299+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.309+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:309,0.076714,-0.239068,0.057379
04-23 19:11:26.319+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.329+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:331,0.056177,0.133170,0.172416
04-23 19:11:26.329+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.329+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:336,0.032007,0.166173,0.023380
04-23 19:11:26.339+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.339+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:295,2.264861,-1.920608,9.346232
04-23 19:11:26.339+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.339+0200 E/CAPI_TELEPHONY( 9812): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 19:11:26.349+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:292,-1.820000,1.400000,0.770000
04-23 19:11:26.349+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:344,2.321038,-1.787439,9.518648
04-23 19:11:26.349+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.349+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.349+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:357,2.294717,-1.741975,9.372685
04-23 19:11:26.349+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:357,-0.700000,0.840000,0.350000
04-23 19:11:26.349+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.349+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.359+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.359+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:351,2.262709,-1.908148,9.349305
04-23 19:11:26.359+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.359+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:365,2.261756,-1.896015,9.352003
04-23 19:11:26.359+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.359+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:361,0.030568,-0.030207,-0.010424
04-23 19:11:26.359+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:365,2.292324,-1.926222,9.341579
04-23 19:11:26.359+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:368,2.262002,-1.896327,9.351881
04-23 19:11:26.369+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.369+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:360,2.100000,0.490000,-0.210000
04-23 19:11:26.369+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.369+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:374,0.047071,-0.101679,0.059091
04-23 19:11:26.369+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:374,1.890000,0.280000,-0.210000
04-23 19:11:26.369+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.369+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.369+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:378,0.350000,0.420000,-0.140000
04-23 19:11:26.369+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.369+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:378,2.309074,-1.998007,9.410972
04-23 19:11:26.379+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.379+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:383,2.263142,-1.899301,9.351002
04-23 19:11:26.379+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:382,0.630000,-0.280000,0.070000
04-23 19:11:26.389+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.389+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.389+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:394,2.262008,-1.893224,9.352508
04-23 19:11:26.389+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.389+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.389+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:397,3.150000,0.840000,-0.280000
04-23 19:11:26.389+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:394,0.112931,-0.046064,0.091077
04-23 19:11:26.389+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:397,2.376073,-1.945365,9.442079
04-23 19:11:26.409+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.409+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.409+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:419,2.260198,-1.888069,9.353988
04-23 19:11:26.419+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.419+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.419+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:423,2.800000,1.120000,-0.630000
04-23 19:11:26.419+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:423,2.349752,-1.942972,9.401401
04-23 19:11:26.419+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:419,0.087744,-0.049748,0.048893
04-23 19:11:26.429+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.429+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.429+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:434,2.259234,-1.894918,9.352836
04-23 19:11:26.429+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.429+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.439+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:440,0.072804,-0.229579,0.021091
04-23 19:11:26.439+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:434,0.630000,1.750000,-1.120000
04-23 19:11:26.439+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:442,2.333002,-2.117648,9.375079
04-23 19:11:26.449+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.449+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.449+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.459+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:457,2.254341,-1.897938,9.353404
04-23 19:11:26.459+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.459+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:458,1.400000,2.170000,-1.260000
04-23 19:11:26.469+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.479+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:462,2.287539,-2.086541,9.403792
04-23 19:11:26.479+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.489+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:477,2.730000,1.960000,-1.050000
04-23 19:11:26.489+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:485,2.361716,-1.866402,9.420543
04-23 19:11:26.499+0200 I/heartrate( 9753): capturing data from es.ugr.frailty.heartrate
04-23 19:11:26.499+0200 I/heartrate( 9753): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:11:26.499+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.509+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.509+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.519+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:508,1.610000,1.610000,-0.630000
04-23 19:11:26.519+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.519+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:516,2.340181,-1.883151,9.468399
04-23 19:11:26.519+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:514,2.251943,-1.888171,9.355958
04-23 19:11:26.529+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.529+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:531,0.280000,0.280000,-0.210000
04-23 19:11:26.529+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.539+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:540,2.249924,-1.881988,9.357689
04-23 19:11:26.539+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:547,2.321038,-1.883151,9.403792
04-23 19:11:26.539+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.549+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.559+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.559+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:564,2.342573,-1.832902,9.432507
04-23 19:11:26.559+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:552,0.700000,0.420000,0.140000
04-23 19:11:26.559+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.569+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:558,2.251830,-1.880622,9.357506
04-23 19:11:26.569+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:571,-0.630000,1.610000,-0.210000
04-23 19:11:26.569+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.579+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.589+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.589+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:581,2.253468,-1.875923,9.358054
04-23 19:11:26.589+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:597,1.330000,1.260000,0.070000
04-23 19:11:26.589+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.599+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:584,2.251646,-1.914258,9.288938
04-23 19:11:26.599+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.609+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.609+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:603,2.251575,-1.878214,9.358050
04-23 19:11:26.619+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.619+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:608,2.299503,-2.026721,9.475577
04-23 19:11:26.619+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:466,0.028304,-0.191623,0.050957
04-23 19:11:26.619+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.619+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:615,1.610000,2.030000,0.070000
04-23 19:11:26.619+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.619+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:628,0.107375,0.031536,0.067139
04-23 19:11:26.619+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.629+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:625,2.248151,-1.880126,9.358490
04-23 19:11:26.629+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.639+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:642,-0.490000,0.350000,0.420000
04-23 19:11:26.639+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.639+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:631,2.340181,-1.933401,9.387043
04-23 19:11:26.639+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.639+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:632,0.088238,0.005020,0.112441
04-23 19:11:26.639+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.649+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:653,2.306681,-1.964507,9.399008
04-23 19:11:26.649+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:651,2.245873,-1.877302,9.359603
04-23 19:11:26.659+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.659+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.659+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.669+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:664,0.770000,1.190000,0.420000
04-23 19:11:26.669+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.679+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:669,2.247660,-1.881698,9.358292
04-23 19:11:26.679+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:670,2.409572,-1.947758,9.355937
04-23 19:11:26.679+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.679+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:651,0.071114,-0.001164,0.046103
04-23 19:11:26.679+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.679+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.689+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:686,2.251259,-1.882146,9.357336
04-23 19:11:26.689+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:692,2.294717,-1.926222,9.473185
04-23 19:11:26.689+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:680,0.910000,1.330000,0.140000
04-23 19:11:26.689+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.689+0200 I/heartrate( 9753): capturing data from es.ugr.frailty.heartrate
04-23 19:11:26.699+0200 I/heartrate( 9753): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:11:26:701,78
04-23 19:11:26.699+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:706,0.560000,0.840000,0.140000
04-23 19:11:26.699+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:689,0.090743,0.047719,0.075001
04-23 19:11:26.699+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.709+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.709+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.709+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:714,-0.001822,-0.038335,-0.069117
04-23 19:11:26.719+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:712,2.248106,-1.880224,9.358480
04-23 19:11:26.719+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.719+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:726,1.330000,0.700000,-0.070000
04-23 19:11:26.719+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.719+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.729+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:719,2.325824,-1.897508,9.427721
04-23 19:11:26.729+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.729+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:731,2.248402,-1.878526,9.358750
04-23 19:11:26.739+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:736,2.261217,-1.957329,9.399008
04-23 19:11:26.739+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.739+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.739+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:744,2.344966,-1.942972,9.511470
04-23 19:11:26.739+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.739+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:735,0.047927,-0.148507,0.117527
04-23 19:11:26.739+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.739+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:748,2.368894,-1.871187,9.442079
04-23 19:11:26.739+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.739+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:745,1.680000,0.630000,-0.210000
04-23 19:11:26.749+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.749+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.749+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:755,2.297110,-1.919044,9.375079
04-23 19:11:26.749+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:753,1.470000,0.490000,-0.070000
04-23 19:11:26.749+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.759+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:751,2.245525,-1.878461,9.359454
04-23 19:11:26.759+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:755,0.092030,-0.053275,0.028553
04-23 19:11:26.759+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.759+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:762,0.770000,0.840000,0.140000
04-23 19:11:26.759+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.759+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:765,2.245166,-1.875885,9.360057
04-23 19:11:26.769+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.769+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.769+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:773,2.247181,-1.871347,9.360482
04-23 19:11:26.769+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.769+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:775,2.268396,-1.914258,9.456435
04-23 19:11:26.769+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.769+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:777,2.246525,-1.871142,9.360681
04-23 19:11:26.769+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.769+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:770,0.060808,-0.087205,0.039405
04-23 19:11:26.769+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.779+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:781,2.243133,-1.869399,9.361842
04-23 19:11:26.779+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:779,1.120000,0.910000,0.350000
04-23 19:11:26.779+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:783,0.161912,-0.066059,-0.002355
04-23 19:11:26.779+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.779+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:788,0.043458,-0.044077,0.115849
04-23 19:11:26.779+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.789+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.789+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:792,0.077718,-0.017284,0.069241
04-23 19:11:26.789+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.789+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:795,2.243979,-1.866307,9.362256
04-23 19:11:26.789+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:795,0.012815,-0.078802,0.040257
04-23 19:11:26.789+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.789+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.789+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:799,0.099441,-0.064511,0.152016
04-23 19:11:26.789+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.799+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:799,2.340181,-1.873580,9.415757
04-23 19:11:26.799+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.799+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:803,0.123729,0.004697,0.082022
04-23 19:11:26.799+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.799+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:805,1.120000,0.700000,0.420000
04-23 19:11:26.799+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:806,0.049929,-0.047697,0.014597
04-23 19:11:26.799+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.809+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:810,0.021870,-0.043116,0.095755
04-23 19:11:26.809+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.809+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:814,0.097047,-0.004181,0.053915
04-23 19:11:26.809+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.809+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.819+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.819+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:821,2.244753,-1.866394,9.362053
04-23 19:11:26.819+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:823,2.311467,-1.916651,9.475577
04-23 19:11:26.829+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:11:26.829+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:11:26.829+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:11:26.829+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.829+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.829+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:838,2.246684,-1.869883,9.360893
04-23 19:11:26.829+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.839+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:820,0.700000,-0.070000,0.630000
04-23 19:11:26.839+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.839+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:841,2.337788,-1.962115,9.317651
04-23 19:11:26.839+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:837,0.067488,-0.050344,0.113321
04-23 19:11:26.839+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.839+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:847,0.093035,-0.095721,-0.044402
04-23 19:11:26.839+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:843,0.210000,1.050000,0.350000
04-23 19:11:26.849+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.849+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.849+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:853,2.242265,-1.871241,9.361682
04-23 19:11:26.849+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:854,1.680000,0.350000,0.560000
04-23 19:11:26.849+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.849+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.849+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:858,-0.018966,-0.113767,0.047686
04-23 19:11:26.849+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:858,2.227718,-1.983650,9.408579
04-23 19:11:26.869+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.869+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.869+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:875,1.750000,1.330000,0.560000
04-23 19:11:26.869+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.869+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.869+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:879,2.411965,-1.916651,9.446864
04-23 19:11:26.869+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:879,0.169700,-0.045410,0.085182
04-23 19:11:26.879+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:876,2.243817,-1.867923,9.361973
04-23 19:11:26.889+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.889+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.889+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:895,-0.420000,0.560000,0.560000
04-23 19:11:26.889+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.889+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.889+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:895,0.015008,-0.132477,0.123177
04-23 19:11:26.889+0200 I/heartrate( 9753): capturing data from es.ugr.frailty.heartrate
04-23 19:11:26.899+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:899,2.258825,-2.000400,9.485149
04-23 19:11:26.899+0200 I/heartrate( 9753): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:11:26:902,78
04-23 19:11:26.899+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:900,2.242049,-1.873460,9.361290
04-23 19:11:26.909+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.909+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.919+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:919,1.400000,0.420000,0.560000
04-23 19:11:26.919+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.919+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:919,0.069417,-0.004906,0.099931
04-23 19:11:26.919+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.919+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:924,2.311467,-1.878366,9.461221
04-23 19:11:26.919+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:926,2.241384,-1.869759,9.362189
04-23 19:11:26.929+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.929+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.929+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:934,0.980000,0.980000,0.140000
04-23 19:11:26.929+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.939+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:935,0.048547,0.005750,-0.018217
04-23 19:11:26.939+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.939+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:942,2.289931,-1.864009,9.343972
04-23 19:11:26.939+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:945,2.240586,-1.866861,9.362958
04-23 19:11:26.949+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.949+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.959+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.959+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:957,0.046952,-0.080897,0.131763
04-23 19:11:26.959+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.959+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:963,2.287539,-1.947758,9.494720
04-23 19:11:26.959+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:956,0.280000,-0.210000,0.350000
04-23 19:11:26.959+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:964,2.241113,-1.869045,9.362396
04-23 19:11:26.969+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:26.969+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.969+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:26.979+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:975,0.146924,-0.059570,-0.013638
04-23 19:11:26.979+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:26.989+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:26.999+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:26:996,-0.016898,-0.077513,-0.032180
04-23 19:11:26.999+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:26:986,2.244616,-1.867852,9.361795
04-23 19:11:27.009+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:27.009+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:27.019+0200 W/LOCATION( 9886): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:11:27.029+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:27:14,2.241710,-1.869411,9.362181
04-23 19:11:27.029+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:27.029+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:27:20,0.084114,-0.078347,0.127754
04-23 19:11:27.029+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:27.039+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:26:981,2.388037,-1.928615,9.348758
04-23 19:11:27.039+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:27:41,0.115959,-0.041193,-0.011433
04-23 19:11:27.039+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:27.039+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:27:47,2.227718,-1.945365,9.329616
04-23 19:11:27.039+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:27.049+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:26:975,1.610000,0.630000,-0.070000
04-23 19:11:27.049+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:27:36,2.240972,-1.868280,9.362583
04-23 19:11:27.049+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:27.049+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:27.049+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:27:54,0.910000,0.630000,0.070000
04-23 19:11:27.049+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:27.049+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:27.059+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:27:56,0.008083,-0.012644,0.167566
04-23 19:11:27.059+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:27:60,1.470000,0.630000,0.140000
04-23 19:11:27.059+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:27.059+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:27:61,2.241170,-1.865721,9.363046
04-23 19:11:27.059+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:27.059+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:27:68,1.400000,1.750000,-0.280000
04-23 19:11:27.069+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:27.069+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:27:52,2.325824,-1.947758,9.489935
04-23 19:11:27.069+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:27.069+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:27:75,0.142959,-0.034860,0.056103
04-23 19:11:27.079+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:27:69,2.237899,-1.862649,9.364440
04-23 19:11:27.079+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:27.079+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:27:85,2.240227,-1.860298,9.364350
04-23 19:11:27.089+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:27.089+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:27.089+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:27:94,0.980000,0.350000,0.140000
04-23 19:11:27.089+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:27.089+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:27.089+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:27:95,0.032954,-0.034818,0.037050
04-23 19:11:27.089+0200 I/heartrate( 9753): capturing data from es.ugr.frailty.heartrate
04-23 19:11:27.099+0200 I/heartrate( 9753): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:11:27:102,78
04-23 19:11:27.099+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:27:100,2.238497,-1.857946,9.365231
04-23 19:11:27.099+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:27:78,2.356930,-1.909473,9.351151
04-23 19:11:27.099+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:27.109+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:27:99,1.260000,0.910000,0.140000
04-23 19:11:27.109+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:27.109+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:27:113,2.249253,-1.878366,9.530612
04-23 19:11:27.109+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:27.109+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:27.109+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:27.119+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:27:119,0.065791,-0.099383,-0.016473
04-23 19:11:27.119+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:27:116,1.680000,0.350000,0.280000
04-23 19:11:27.119+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:27.119+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:27:124,2.380858,-1.897508,9.420543
04-23 19:11:27.119+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:27.119+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:27:126,1.050000,0.350000,0.140000
04-23 19:11:27.119+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:27:119,2.239490,-1.860157,9.364554
04-23 19:11:27.129+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:27.129+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:27:134,0.098298,-0.099564,0.027274
04-23 19:11:27.129+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:27.129+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:27:139,2.240345,-1.860941,9.364195
04-23 19:11:27.139+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:27.139+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:27:129,2.273181,-1.895115,9.401401
04-23 19:11:27.139+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:27.139+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:27:143,1.400000,0.700000,0.140000
04-23 19:11:27.139+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:27:146,2.304288,-1.957329,9.348758
04-23 19:11:27.139+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:27.149+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:27.149+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:27.149+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:27.149+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:27:155,1.750000,1.540000,-0.350000
04-23 19:11:27.159+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:27:159,2.234554,-1.854488,9.366858
04-23 19:11:27.159+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:27:156,0.013695,0.006503,0.142489
04-23 19:11:27.159+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:27:152,2.337788,-1.959722,9.391829
04-23 19:11:27.159+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:27.159+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:27:168,2.254039,-1.854438,9.506684
04-23 19:11:27.169+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:27.169+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:27.169+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:27.169+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:27:174,1.750000,0.840000,-0.420000
04-23 19:11:27.169+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:27:178,2.233650,-1.851289,9.367706
04-23 19:11:27.179+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:27:175,0.076912,-0.043020,0.072828
04-23 19:11:27.179+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:27.179+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:27:185,2.311467,-1.897508,9.439686
04-23 19:11:27.189+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:27.189+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:27.189+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:27:195,1.330000,0.280000,-0.420000
04-23 19:11:27.189+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:27.189+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:27:199,0.106530,-0.010327,0.071980
04-23 19:11:27.189+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:27:195,2.235731,-1.847853,9.367888
04-23 19:11:27.199+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:27.199+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:27:204,2.340181,-1.861616,9.439686
04-23 19:11:27.209+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:27.209+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:27.209+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:27:219,0.560000,0.280000,0.210000
04-23 19:11:27.219+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:27.219+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:27:223,0.102056,-0.066405,0.059833
04-23 19:11:27.219+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:27:219,2.238219,-1.848911,9.367085
04-23 19:11:27.219+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:27.219+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:27:228,2.337788,-1.914258,9.427721
04-23 19:11:27.229+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:27.229+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:27.229+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:27:234,0.980000,1.050000,0.350000
04-23 19:11:27.229+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:27.229+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:27:238,0.125890,-0.041419,0.005600
04-23 19:11:27.229+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:27:235,2.240247,-1.847882,9.366803
04-23 19:11:27.239+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:27.239+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:27:245,2.364109,-1.890330,9.372685
04-23 19:11:27.249+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:27.249+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:27.249+0200 I/linearacceleration( 9901): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:27.249+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:27:256,0.420000,1.470000,-0.140000
04-23 19:11:27.249+0200 I/gravity ( 9909): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:27:256,2.234621,-1.850191,9.367692
04-23 19:11:27.259+0200 I/linearacceleration( 9901): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:27:258,-0.043636,-0.095090,0.008276
04-23 19:11:27.259+0200 I/accelerometer( 9860): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:27.259+0200 I/accelerometer( 9860): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:27:266,2.196611,-1.942972,9.375079
04-23 19:11:27.269+0200 I/gyroscope( 9873): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:27.269+0200 I/gyroscope( 9873): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:27:275,1.050000,1.260000,-0.140000
04-23 19:11:27.269+0200 I/gravity ( 9909): capturing data from es.ugr.frailty.gravity
04-23 19:11:27.269+0200 W/CRASH_MANAGER( 9824): worker.c: worker_job(1205) > 11098866c6f63152450348
