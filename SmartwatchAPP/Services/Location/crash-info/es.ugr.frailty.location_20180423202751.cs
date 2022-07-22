S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 8496
Date: 2018-04-23 20:27:51+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf776652d, r5   = 0xf7f25f98
r6   = 0xff80f530, r7   = 0xff80f3e0
r8   = 0xf7f22c18, r9   = 0x00000000
r10  = 0xff80f4bc, fp   = 0xff80f530
ip   = 0x00000001, sp   = 0xff80f3b8
lr   = 0xf7766539, pc   = 0xf77cf228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     10488 KB
Buffers:     43188 KB
Cached:     192908 KB
VmPeak:      52512 KB
VmSize:      52508 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11748 KB
VmRSS:       11748 KB
VmData:      10236 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 8496 TID = 8496
8496 8499 

Maps Information
f4631000 f4e30000 rw-p [stack:8499]
f4e37000 f4e39000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4e41000 f4e45000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4e4e000 f4e50000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4e58000 f4e5b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4e6a000 f4e6f000 r-xp /usr/lib/libsystem.so.0.0.0
f4e7a000 f4e7d000 r-xp /lib/libattr.so.1.1.0
f4e85000 f4e95000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e9d000 f4ea6000 r-xp /usr/lib/libedbus.so.1.7.99
f4eae000 f4eaf000 r-xp /usr/lib/libresponse.so.0.2.96
f4eb8000 f4ebd000 r-xp /usr/lib/libproc-stat.so.0.2.96
f675f000 f6865000 r-xp /usr/lib/libicuuc.so.57.1
f687b000 f6a03000 r-xp /usr/lib/libicui18n.so.57.1
f6a13000 f6a20000 r-xp /usr/lib/libail.so.0.1.0
f6a29000 f6a30000 r-xp /usr/lib/libminizip.so.1.0.0
f6a39000 f6be2000 r-xp /usr/lib/libcrypto.so.1.0.0
f6c02000 f6c49000 r-xp /usr/lib/libssl.so.1.0.0
f6c55000 f6c57000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6c5f000 f6c66000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6c6f000 f6c76000 r-xp /lib/libcrypt-2.13.so
f6ca7000 f6caa000 r-xp /lib/libcap.so.2.21
f6cb2000 f6cb4000 r-xp /usr/lib/libiri.so
f6cbc000 f6d05000 r-xp /usr/lib/libmdm.so.1.2.69
f6d0d000 f6d13000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6d1b000 f6d3e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6d48000 f6d4a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6d52000 f6d6f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d78000 f6d7c000 r-xp /usr/lib/libsmack.so.1.0.0
f6d85000 f6d9e000 r-xp /usr/lib/libnetwork.so.0.0.0
f6da7000 f6daf000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6db7000 f6dbd000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6dc6000 f6dc8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6dd1000 f6de1000 r-xp /lib/libresolv-2.13.so
f6de5000 f6dfd000 r-xp /usr/lib/liblzma.so.5.0.3
f6e06000 f6e08000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6e10000 f6e2a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6e32000 f6e61000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e6a000 f6e79000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e83000 f6e8d000 r-xp /usr/lib/libsensord-shared.so
f6e96000 f6f69000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f74000 f6f8a000 r-xp /lib/libz.so.1.2.5
f6f92000 f6f97000 r-xp /usr/lib/libffi.so.5.0.10
f6f9f000 f6fa0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6fa8000 f6fb8000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6fc0000 f6fd9000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6fe1000 f6fe3000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6feb000 f7060000 r-xp /usr/lib/libsqlite3.so.0.8.6
f706a000 f7070000 r-xp /lib/librt-2.13.so
f7079000 f7097000 r-xp /usr/lib/libsystemd.so.0.4.0
f70a1000 f70a2000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f70aa000 f70cd000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f70d5000 f70da000 r-xp /usr/lib/libxdgmime.so.1.1.0
f70e2000 f710c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7115000 f712c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7134000 f719d000 r-xp /lib/libm-2.13.so
f71a6000 f723a000 r-xp /usr/lib/libstdc++.so.6.0.16
f724d000 f7252000 r-xp /usr/lib/libctx-client.so.0.8.3
f725a000 f7261000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7269000 f7293000 r-xp /usr/lib/libsensor.so.1.9.6
f729c000 f7368000 r-xp /usr/lib/libxml2.so.2.7.8
f7375000 f7377000 r-xp /usr/lib/libiniparser.so.0
f7380000 f7386000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f738f000 f745f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7460000 f7494000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f749d000 f74d9000 r-xp /usr/lib/libSLP-location.so.0.9.24
f74e1000 f74e4000 r-xp /usr/lib/libbundle.so.0.1.22
f74ec000 f74f2000 r-xp /usr/lib/libappsvc.so.0.1.0
f74fa000 f753b000 r-xp /usr/lib/libeina.so.1.7.99
f7544000 f755b000 r-xp /usr/lib/libecore.so.1.7.99
f7572000 f757b000 r-xp /usr/lib/libvconf.so.0.2.45
f7583000 f7597000 r-xp /lib/libpthread-2.13.so
f75a2000 f75af000 r-xp /usr/lib/libaul.so.0.1.0
f75b9000 f75bb000 r-xp /lib/libdl-2.13.so
f75c4000 f75cf000 r-xp /lib/libunwind.so.8.0.1
f75fc000 f7604000 r-xp /lib/libgcc_s-4.6.so.1
f7605000 f7729000 r-xp /lib/libc-2.13.so
f7737000 f7739000 r-xp /usr/lib/libdlog.so.0.0.0
f7741000 f774d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7756000 f775b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7763000 f7772000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f777a000 f777e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7787000 f778a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7792000 f7794000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f779c000 f77a0000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f77a8000 f77c5000 r-xp /lib/ld-2.13.so
f77ce000 f77d1000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f77d1000 f77d5000 r-xp /usr/lib/libsys-assert.so
f7ef2000 f7f7c000 rw-p [heap]
ff7f0000 ff811000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8496)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf77cf228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7766539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf746d3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf746bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7477e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf747dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf747ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf74b275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf74ad1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf746bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7477e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf747dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf747ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf74afe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf74b0017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf74b7f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4e4f1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4e42171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6f15663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf73c2fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73c47a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7554ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf754fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf75505a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7550879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7788183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf77887fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf77cf4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf761c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf77cef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
apturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.229+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:216,0.023928,9.801002,0.815953
04-23 20:27:50.229+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:219,0.030076,9.770748,0.837835
04-23 20:27:50.229+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:192,-0.006308,0.030130,-0.020442
04-23 20:27:50.229+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.239+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.239+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.249+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:241,0.003423,0.047003,-0.024276
04-23 20:27:50.249+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.259+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:244,0.030377,9.770676,0.838668
04-23 20:27:50.259+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.259+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:264,0.031002,9.770662,0.838802
04-23 20:27:50.259+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.259+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:268,0.031843,9.770860,0.836460
04-23 20:27:50.259+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.269+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:230,0.070000,0.070000,0.070000
04-23 20:27:50.269+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:249,0.033500,9.817751,0.813560
04-23 20:27:50.269+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.269+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.279+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:279,-0.070000,0.070000,0.070000
04-23 20:27:50.279+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:262,0.010301,0.054254,-0.027501
04-23 20:27:50.289+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:276,0.040678,9.824929,0.811167
04-23 20:27:50.289+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.289+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.299+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.299+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:298,0.045464,9.791430,0.772882
04-23 20:27:50.299+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:27:50.299+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:27:50.299+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.299+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:27:50.309+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:304,-0.070000,0.070000,0.070000
04-23 20:27:50.309+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.319+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:296,0.014462,0.020768,-0.065920
04-23 20:27:50.319+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.319+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:325,-0.027057,0.037320,-0.022900
04-23 20:27:50.319+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.319+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:329,-0.016502,0.095174,-0.063782
04-23 20:27:50.329+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:272,0.030859,9.770434,0.841449
04-23 20:27:50.329+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.329+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:312,0.004786,9.808180,0.813560
04-23 20:27:50.329+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.339+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:321,-0.070000,0.070000,0.070000
04-23 20:27:50.339+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.339+0200 I/heartrate( 8278): capturing data from es.ugr.frailty.heartrate
04-23 20:27:50.339+0200 I/heartrate( 8278): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:27:50.339+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:337,0.030360,9.770208,0.844095
04-23 20:27:50.339+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.349+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:342,0.014357,9.865608,0.777667
04-23 20:27:50.349+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.359+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:345,-0.070000,0.070000,0.140000
04-23 20:27:50.359+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.359+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:364,-0.070000,0.070000,0.140000
04-23 20:27:50.359+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.359+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:369,-0.070000,-0.070000,0.140000
04-23 20:27:50.369+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.369+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:350,0.031952,9.770239,0.843678
04-23 20:27:50.369+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.379+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:374,0.027068,0.018829,-0.044893
04-23 20:27:50.379+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.379+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:386,-0.005631,0.064262,-0.042082
04-23 20:27:50.379+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.389+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:360,0.057428,9.789038,0.799203
04-23 20:27:50.389+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.389+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:380,0.031975,9.770020,0.846207
04-23 20:27:50.389+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.399+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:395,0.026321,9.834501,0.801596
04-23 20:27:50.399+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.399+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:404,0.055035,9.805787,0.813560
04-23 20:27:50.399+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.399+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:409,-0.004786,9.839286,0.811167
04-23 20:27:50.409+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.409+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:413,-0.070000,0.070000,0.140000
04-23 20:27:50.409+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.409+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:400,0.033354,9.769938,0.847094
04-23 20:27:50.409+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.419+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:390,0.023060,0.035767,-0.032647
04-23 20:27:50.419+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.429+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:420,0.031693,9.769659,0.850378
04-23 20:27:50.429+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.469+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:431,-0.038140,0.069347,-0.035927
04-23 20:27:50.469+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.529+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.529+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:534,0.038285,9.815358,0.758525
04-23 20:27:50.529+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:417,-0.070000,0.070000,0.140000
04-23 20:27:50.529+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.539+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:436,0.032157,9.769952,0.846987
04-23 20:27:50.539+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.539+0200 I/heartrate( 8278): capturing data from es.ugr.frailty.heartrate
04-23 20:27:50.539+0200 I/heartrate( 8278): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:27:50.539+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:476,0.006592,0.045699,-0.091853
04-23 20:27:50.539+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.549+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:540,-0.070000,0.070000,0.070000
04-23 20:27:50.549+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.549+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:555,-0.070000,0.070000,0.070000
04-23 20:27:50.549+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.549+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.559+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:559,0.062213,9.772287,0.815953
04-23 20:27:50.559+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.559+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:567,0.004786,9.810574,0.825524
04-23 20:27:50.559+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.569+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:546,0.033724,9.770064,0.845633
04-23 20:27:50.569+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.569+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:574,0.032503,9.769835,0.848327
04-23 20:27:50.569+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:552,0.030056,0.002336,-0.031034
04-23 20:27:50.569+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.579+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:559,-0.070000,0.070000,0.070000
04-23 20:27:50.579+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.579+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:587,0.070000,0.070000,0.070000
04-23 20:27:50.579+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.589+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:582,-0.028938,0.040509,-0.020109
04-23 20:27:50.589+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.589+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.589+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:598,0.032345,9.770077,0.845537
04-23 20:27:50.599+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:571,0.026321,9.820145,0.746561
04-23 20:27:50.599+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.599+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.609+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:607,0.032084,9.770065,0.845685
04-23 20:27:50.609+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.619+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:597,-0.006182,0.050310,-0.101766
04-23 20:27:50.619+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.619+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:613,0.023928,9.796216,0.796810
04-23 20:27:50.619+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.619+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:627,0.014357,9.834501,0.794417
04-23 20:27:50.619+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.629+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:591,0.070000,0.070000,0.070000
04-23 20:27:50.629+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.639+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:624,-0.008417,0.026139,-0.048727
04-23 20:27:50.639+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:635,0.070000,0.070000,0.070000
04-23 20:27:50.639+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:622,0.031376,9.770000,0.846470
04-23 20:27:50.639+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.649+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.649+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:655,0.007178,9.829715,0.770489
04-23 20:27:50.649+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:653,-0.017727,0.064436,-0.051267
04-23 20:27:50.659+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.659+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:663,0.070000,0.070000,0.070000
04-23 20:27:50.659+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.659+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:668,0.070000,-0.210000,0.070000
04-23 20:27:50.659+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.669+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:650,0.030378,9.770022,0.846246
04-23 20:27:50.669+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.669+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.679+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.679+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:683,-0.007178,9.808180,0.815953
04-23 20:27:50.679+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.689+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:676,0.028776,9.769753,0.849411
04-23 20:27:50.689+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:679,-0.024198,0.059715,-0.075981
04-23 20:27:50.689+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.689+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.699+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:699,0.028038,9.769604,0.851145
04-23 20:27:50.699+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:696,-0.037557,0.038157,-0.030293
04-23 20:27:50.709+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:689,0.009571,9.801002,0.818345
04-23 20:27:50.709+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.709+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.719+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:672,-0.070000,-0.210000,0.070000
04-23 20:27:50.719+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.719+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:725,0.027076,9.769407,0.853427
04-23 20:27:50.719+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.729+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.729+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:715,-0.019204,0.031249,-0.031066
04-23 20:27:50.729+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.739+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:719,0.004786,9.791430,0.792024
04-23 20:27:50.739+0200 I/heartrate( 8278): capturing data from es.ugr.frailty.heartrate
04-23 20:27:50.739+0200 I/heartrate( 8278): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:27:50.749+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.749+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:734,-0.070000,-0.210000,0.070000
04-23 20:27:50.759+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.769+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:737,-0.023253,0.021827,-0.059120
04-23 20:27:50.769+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.769+0200 W/LOCATION( 8496): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:27:50.779+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:729,0.025345,9.769048,0.857578
04-23 20:27:50.779+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.789+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:760,-0.011964,9.801002,0.768096
04-23 20:27:50.789+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:792,0.024045,9.768742,0.861098
04-23 20:27:50.799+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:764,-0.070000,0.070000,0.070000
04-23 20:27:50.799+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.799+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:809,-0.070000,0.070000,0.070000
04-23 20:27:50.809+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.819+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:803,-0.039040,0.031594,-0.085331
04-23 20:27:50.819+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.819+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:824,-0.030130,0.019990,-0.084696
04-23 20:27:50.819+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.819+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:828,0.026204,0.039438,-0.064288
04-23 20:27:50.819+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.829+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.829+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:833,0.025431,9.769107,0.856904
04-23 20:27:50.829+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.829+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:819,-0.004786,9.789038,0.772882
04-23 20:27:50.829+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.839+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.849+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:852,-0.070000,0.070000,0.070000
04-23 20:27:50.849+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.849+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:840,0.050249,9.808180,0.796810
04-23 20:27:50.849+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.859+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:837,0.025044,9.769012,0.857995
04-23 20:27:50.859+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.859+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:862,0.014357,9.851252,0.796810
04-23 20:27:50.859+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.869+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:867,0.025487,9.769306,0.854631
04-23 20:27:50.869+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.879+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:857,-0.070000,0.070000,0.070000
04-23 20:27:50.879+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.879+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:884,-0.070000,0.070000,0.070000
04-23 20:27:50.879+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.879+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:889,-0.070000,0.070000,0.070000
04-23 20:27:50.889+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:833,-0.011074,0.082145,-0.060094
04-23 20:27:50.889+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.889+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:872,0.031107,9.781858,0.758525
04-23 20:27:50.889+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.899+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:877,0.025096,9.769337,0.854287
04-23 20:27:50.899+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.909+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:897,0.006062,0.012846,-0.099470
04-23 20:27:50.909+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.909+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:902,0.014357,9.822537,0.760918
04-23 20:27:50.909+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.929+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.929+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:933,-0.070000,0.070000,0.070000
04-23 20:27:50.929+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.929+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:910,0.025877,9.769591,0.851350
04-23 20:27:50.929+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.939+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:923,0.038285,9.767502,0.777667
04-23 20:27:50.939+0200 I/heartrate( 8278): capturing data from es.ugr.frailty.heartrate
04-23 20:27:50.939+0200 I/heartrate( 8278): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:27:50.939+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:916,-0.011130,0.053231,-0.093714
04-23 20:27:50.939+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.949+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:941,0.026155,9.769701,0.850086
04-23 20:27:50.949+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.949+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.959+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:937,-0.070000,0.070000,0.070000
04-23 20:27:50.959+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.959+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:966,-0.070000,0.070000,0.070000
04-23 20:27:50.959+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:50.969+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:950,0.013189,-0.001835,-0.076620
04-23 20:27:50.969+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.979+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:959,0.028714,9.815358,0.782453
04-23 20:27:50.979+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.979+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:986,0.023928,9.789038,0.801596
04-23 20:27:50.979+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:50.989+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:957,0.026194,9.769652,0.850641
04-23 20:27:50.989+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:50.989+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:50:977,0.002837,0.045767,-0.068897
04-23 20:27:50.999+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:50.999+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:51:8,-0.002226,0.019337,-0.048491
04-23 20:27:50.999+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:51.009+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:50:996,0.027025,9.769814,0.848756
04-23 20:27:51.009+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:51.009+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:50:970,-0.070000,0.070000,0.070000
04-23 20:27:51.019+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:50:990,0.040678,9.798609,0.794417
04-23 20:27:51.019+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:51.029+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:51:20,0.025651,9.769524,0.852134
04-23 20:27:51.029+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:51.039+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:51.039+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:51:43,-0.070000,0.070000,0.070000
04-23 20:27:51.039+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:51.039+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:51:12,0.014484,0.028956,-0.056224
04-23 20:27:51.039+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:51.049+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:51:29,-0.004786,9.827322,0.782453
04-23 20:27:51.049+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:51.059+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:51:36,0.024374,9.769217,0.855675
04-23 20:27:51.059+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:51:50,-0.031811,0.057508,-0.066303
04-23 20:27:51.069+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:51:61,-0.004786,9.781858,0.806381
04-23 20:27:51.069+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:51.069+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:51:47,-0.070000,0.070000,0.070000
04-23 20:27:51.069+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:51.079+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:51.089+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:51.089+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:51:77,0.026217,9.769753,0.849484
04-23 20:27:51.089+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:51.099+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:51:88,-0.030437,0.012335,-0.045753
04-23 20:27:51.099+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:51:82,-0.070000,-0.140000,0.070000
04-23 20:27:51.099+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:51:94,0.059821,9.824929,0.789631
04-23 20:27:51.109+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:51.109+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:51.119+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:51.129+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:51:101,0.026037,9.769881,0.848015
04-23 20:27:51.129+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:51.129+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:51:134,0.025872,9.770013,0.846502
04-23 20:27:51.129+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:51:120,-0.070000,-0.140000,0.070000
04-23 20:27:51.129+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:51.139+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:51:123,0.019143,9.851252,0.768096
04-23 20:27:51.139+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:51.139+0200 I/heartrate( 8278): capturing data from es.ugr.frailty.heartrate
04-23 20:27:51.139+0200 I/heartrate( 8278): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:27:51.139+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:51:119,0.035446,0.055712,-0.066043
04-23 20:27:51.139+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:51.159+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:51.159+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:51:163,0.025862,9.769741,0.849635
04-23 20:27:51.159+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:51.159+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:51:167,0.025705,9.769851,0.848372
04-23 20:27:51.159+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:51.169+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:51:146,0.019143,9.781858,0.760918
04-23 20:27:51.169+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:51.169+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:51:149,-0.007074,0.081499,-0.081388
04-23 20:27:51.169+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:51.179+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:51:142,-0.070000,-0.140000,0.070000
04-23 20:27:51.179+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:51.179+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:51:184,-0.070000,-0.140000,0.070000
04-23 20:27:51.179+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:51.179+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:51:188,-0.070000,-0.140000,0.140000
04-23 20:27:51.189+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:51:181,-0.006894,0.011977,-0.087097
04-23 20:27:51.189+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:51.219+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:51:176,0.019143,9.851252,0.806381
04-23 20:27:51.219+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:51.229+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:51:202,-0.006730,0.081239,-0.040121
04-23 20:27:51.239+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:51:171,0.024760,9.769662,0.850575
04-23 20:27:51.239+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:51.239+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:51:246,0.023520,9.769380,0.853841
04-23 20:27:51.239+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:51.249+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:51:229,0.019143,9.789038,0.768096
04-23 20:27:51.249+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:51.249+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:51:254,0.002393,9.824929,0.796810
04-23 20:27:51.249+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:51.249+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:51.249+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:51.259+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:51:261,-0.070000,-0.140000,0.070000
04-23 20:27:51.259+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:51:262,-0.006719,0.019297,-0.081539
04-23 20:27:51.259+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:51.269+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:51.279+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:51:258,-0.004786,9.812965,0.794417
04-23 20:27:51.279+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:51:280,-0.070000,-0.140000,0.070000
04-23 20:27:51.289+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:51:270,-0.023312,0.055079,-0.051562
04-23 20:27:51.289+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:51.289+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:51:250,0.022179,9.769062,0.857508
04-23 20:27:51.289+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:51.289+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:27:51.289+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:27:51.289+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:27:51.299+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:51.299+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:51.299+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:51:304,-0.070000,-0.140000,0.070000
04-23 20:27:51.299+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:51.309+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:51:306,-0.007178,9.803394,0.744168
04-23 20:27:51.309+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:51.319+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:51:301,0.023631,9.769176,0.856179
04-23 20:27:51.319+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:51.319+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:51:326,0.023446,9.769103,0.857010
04-23 20:27:51.319+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:51.329+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:51:295,-0.029546,0.043303,-0.056158
04-23 20:27:51.329+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:51.329+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:51:334,-0.030698,0.034015,-0.109673
04-23 20:27:51.339+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:51:317,0.050249,9.803394,0.835095
04-23 20:27:51.339+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:51.339+0200 I/heartrate( 8278): capturing data from es.ugr.frailty.heartrate
04-23 20:27:51.339+0200 I/heartrate( 8278): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:27:51.339+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:51:312,-0.070000,0.070000,0.070000
04-23 20:27:51.339+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:51.349+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:51.359+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:51:346,0.016750,9.820145,0.794417
04-23 20:27:51.359+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:51.359+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:51:367,0.011964,9.796216,0.823131
04-23 20:27:51.359+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:51.369+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:51:352,-0.070000,0.070000,0.070000
04-23 20:27:51.369+0200 I/servicemanager( 8242): es.ugr.frailty.location sleep timeout
04-23 20:27:51.369+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:51:355,0.028070,0.034332,-0.022413
04-23 20:27:51.379+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:51:330,0.023049,9.768849,0.859907
04-23 20:27:51.379+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:27:51.379+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:51.379+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:51.379+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:51.389+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:27:51.389+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:27:51.399+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8496
04-23 20:27:51.399+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:51:387,-0.070000,0.070000,0.070000
04-23 20:27:51.399+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:51.409+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8496)
04-23 20:27:51.409+0200 I/servicemanager( 8242): es.ugr.frailty.location stop request sent!
04-23 20:27:51.409+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:27:51.409+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:51:372,0.064606,9.822537,0.811167
04-23 20:27:51.409+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:51.409+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:51:389,-0.006881,0.050969,-0.061761
04-23 20:27:51.409+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:51.419+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:51:384,0.025147,9.769281,0.854924
04-23 20:27:51.419+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:51.419+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:51:411,-0.070000,0.070000,0.070000
04-23 20:27:51.429+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:51.439+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:51:433,-0.070000,0.070000,0.070000
04-23 20:27:51.439+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:51.439+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:51:421,-0.011482,0.027113,-0.033879
04-23 20:27:51.439+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:51.449+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:51:425,0.025585,9.769330,0.854349
04-23 20:27:51.449+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:51.449+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:51:417,0.031107,9.789038,0.811167
04-23 20:27:51.459+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:51.459+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:51:457,0.024868,9.769169,0.856212
04-23 20:27:51.479+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:51:449,0.041557,0.053688,-0.048740
04-23 20:27:51.479+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:51.479+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:51:485,0.005960,0.019756,-0.043758
04-23 20:27:51.479+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:51.479+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:51:489,-0.018406,0.017315,-0.055146
04-23 20:27:51.489+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:51:447,-0.070000,-0.070000,0.070000
04-23 20:27:51.489+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:51.489+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:51.499+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:51:468,0.007178,9.786645,0.799203
04-23 20:27:51.499+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:51.499+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:51:504,0.052642,9.810574,0.818345
04-23 20:27:51.499+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:51:500,0.026324,9.769423,0.853259
04-23 20:27:51.499+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:51.509+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:51:495,-0.070000,-0.070000,0.070000
04-23 20:27:51.509+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:51.519+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:51.529+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:51.529+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:51:533,0.027774,0.041405,-0.037866
04-23 20:27:51.529+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:51:511,0.028065,9.769846,0.848356
04-23 20:27:51.529+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:51:523,0.059821,9.812965,0.794417
04-23 20:27:51.529+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:51.539+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:51:518,0.070000,-0.070000,0.070000
04-23 20:27:51.539+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:51.539+0200 I/heartrate( 8278): capturing data from es.ugr.frailty.heartrate
04-23 20:27:51.539+0200 I/heartrate( 8278): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:27:51.559+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:51.559+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:51:569,0.026763,9.769668,0.850448
04-23 20:27:51.569+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:51:573,-0.002393,9.791430,0.784846
04-23 20:27:51.569+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:51.569+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:51.579+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:51:544,0.070000,-0.070000,0.070000
04-23 20:27:51.579+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:51.579+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:51:584,0.070000,-0.070000,0.070000
04-23 20:27:51.579+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:51.589+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:51.589+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:51:593,0.025053,9.769318,0.854517
04-23 20:27:51.589+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:51.599+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:51:581,0.033497,0.043542,-0.058841
04-23 20:27:51.599+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:51.599+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:51:578,-0.011964,9.808180,0.782453
04-23 20:27:51.599+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:51.619+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:51:605,-0.030458,0.021585,-0.063510
04-23 20:27:51.619+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:51.619+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:51:612,0.019143,9.772287,0.770489
04-23 20:27:51.619+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:51.619+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:51:588,0.070000,0.070000,0.070000
04-23 20:27:51.629+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:51:598,0.024926,9.769437,0.853152
04-23 20:27:51.629+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:51.629+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:51.639+0200 W/CRASH_MANAGER( 8352): worker.c: worker_job(1205) > 11084966c6f63152450807
