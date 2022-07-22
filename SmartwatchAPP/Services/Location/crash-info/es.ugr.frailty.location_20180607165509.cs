S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 12695
Date: 2018-06-07 16:55:09+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf723052d, r5   = 0xf7649958
r6   = 0xffba58a0, r7   = 0xffba5750
r8   = 0xf765cc18, r9   = 0x00000000
r10  = 0xffba582c, fp   = 0xffba58a0
ip   = 0x00000001, sp   = 0xffba5728
lr   = 0xf7230539, pc   = 0xf7299228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    197040 KB
Buffers:      6940 KB
Cached:     112280 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11796 KB
VmRSS:       11796 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 12695 TID = 12695
12695 12713 

Maps Information
f40fb000 f48fa000 rw-p [stack:12713]
f4901000 f4903000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f490b000 f490f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4918000 f491a000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4922000 f4925000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4934000 f4939000 r-xp /usr/lib/libsystem.so.0.0.0
f4944000 f4947000 r-xp /lib/libattr.so.1.1.0
f494f000 f495f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4967000 f4970000 r-xp /usr/lib/libedbus.so.1.7.99
f4978000 f4979000 r-xp /usr/lib/libresponse.so.0.2.96
f4982000 f4987000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6229000 f632f000 r-xp /usr/lib/libicuuc.so.57.1
f6345000 f64cd000 r-xp /usr/lib/libicui18n.so.57.1
f64dd000 f64ea000 r-xp /usr/lib/libail.so.0.1.0
f64f3000 f64fa000 r-xp /usr/lib/libminizip.so.1.0.0
f6503000 f66ac000 r-xp /usr/lib/libcrypto.so.1.0.0
f66cc000 f6713000 r-xp /usr/lib/libssl.so.1.0.0
f671f000 f6721000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6729000 f6730000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6739000 f6740000 r-xp /lib/libcrypt-2.13.so
f6771000 f6774000 r-xp /lib/libcap.so.2.21
f677c000 f677e000 r-xp /usr/lib/libiri.so
f6786000 f67cf000 r-xp /usr/lib/libmdm.so.1.2.69
f67d7000 f67dd000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f67e5000 f6808000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6812000 f6814000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f681c000 f6839000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6842000 f6846000 r-xp /usr/lib/libsmack.so.1.0.0
f684f000 f6868000 r-xp /usr/lib/libnetwork.so.0.0.0
f6871000 f6879000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6881000 f6887000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6890000 f6892000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f689b000 f68ab000 r-xp /lib/libresolv-2.13.so
f68af000 f68c7000 r-xp /usr/lib/liblzma.so.5.0.3
f68d0000 f68d2000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f68da000 f68f4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f68fc000 f692b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6934000 f6943000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f694d000 f6957000 r-xp /usr/lib/libsensord-shared.so
f6960000 f6a33000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a3e000 f6a54000 r-xp /lib/libz.so.1.2.5
f6a5c000 f6a61000 r-xp /usr/lib/libffi.so.5.0.10
f6a69000 f6a6a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a72000 f6a82000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a8a000 f6aa3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6aab000 f6aad000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ab5000 f6b2a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b34000 f6b3a000 r-xp /lib/librt-2.13.so
f6b43000 f6b61000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b6b000 f6b6c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b74000 f6b97000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b9f000 f6ba4000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6bac000 f6bd6000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6bdf000 f6bf6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6bfe000 f6c67000 r-xp /lib/libm-2.13.so
f6c70000 f6d04000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d17000 f6d1c000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d24000 f6d2b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d33000 f6d5d000 r-xp /usr/lib/libsensor.so.1.9.6
f6d66000 f6e32000 r-xp /usr/lib/libxml2.so.2.7.8
f6e3f000 f6e41000 r-xp /usr/lib/libiniparser.so.0
f6e4a000 f6e50000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e59000 f6f29000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f2a000 f6f5e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f67000 f6fa3000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6fab000 f6fae000 r-xp /usr/lib/libbundle.so.0.1.22
f6fb6000 f6fbc000 r-xp /usr/lib/libappsvc.so.0.1.0
f6fc4000 f7005000 r-xp /usr/lib/libeina.so.1.7.99
f700e000 f7025000 r-xp /usr/lib/libecore.so.1.7.99
f703c000 f7045000 r-xp /usr/lib/libvconf.so.0.2.45
f704d000 f7061000 r-xp /lib/libpthread-2.13.so
f706c000 f7079000 r-xp /usr/lib/libaul.so.0.1.0
f7083000 f7085000 r-xp /lib/libdl-2.13.so
f708e000 f7099000 r-xp /lib/libunwind.so.8.0.1
f70c6000 f70ce000 r-xp /lib/libgcc_s-4.6.so.1
f70cf000 f71f3000 r-xp /lib/libc-2.13.so
f7201000 f7203000 r-xp /usr/lib/libdlog.so.0.0.0
f720b000 f7217000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7220000 f7225000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f722d000 f723c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7244000 f7248000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7251000 f7254000 r-xp /usr/lib/libappcore-agent.so.1.1
f725c000 f725e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7266000 f726a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7272000 f728f000 r-xp /lib/ld-2.13.so
f7298000 f729b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f729b000 f729f000 r-xp /usr/lib/libsys-assert.so
f762c000 f769d000 rw-p [heap]
ffb86000 ffba7000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12695)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7299228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7230539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f373f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f35c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f41e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f47be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f47dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f7c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f771f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f35c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f41e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f47be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f47dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f79e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f7a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f81f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49191fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf490c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf69df663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e8cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e8e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf701eca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7019b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf701a5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf701a879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7252183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72527fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72995c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf70e685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7298f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
06-07 16:55:09.121+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:124,3.127419,-0.093320,9.315259
06-07 16:55:09.121+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.121+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.131+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:130,4.864201,-0.021385,8.515250
06-07 16:55:09.131+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:126,-0.420000,-0.210000,0.070000
06-07 16:55:09.131+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:134,-2.390081,-0.077523,1.208019
06-07 16:55:09.131+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.131+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.141+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:145,4.837465,-0.020132,8.530469
06-07 16:55:09.141+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:145,3.141776,0.002393,9.343972
06-07 16:55:09.141+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.141+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.141+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:150,-1.722424,0.023778,0.828722
06-07 16:55:09.151+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:151,0.140000,-0.280000,0.140000
06-07 16:55:09.161+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.161+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.161+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:166,4.634581,-0.020498,8.642374
06-07 16:55:09.161+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:167,3.136991,-0.028714,9.372685
06-07 16:55:09.161+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.161+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.171+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:173,0.210000,-0.210000,0.070000
06-07 16:55:09.171+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:174,-1.700475,-0.008581,0.842216
06-07 16:55:09.171+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.171+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.181+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:185,4.511745,-0.021131,8.707129
06-07 16:55:09.181+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:185,3.108276,-0.028714,9.351151
06-07 16:55:09.181+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.181+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.181+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:55:09.191+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:55:09:193,83
06-07 16:55:09.191+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:193,-0.070000,-0.210000,-0.070000
06-07 16:55:09.191+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:192,-1.526304,-0.008216,0.708776
06-07 16:55:09.201+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.201+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:55:09.211+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:55:09:213,999.000000
06-07 16:55:09.211+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.211+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:214,3.079563,0.031107,9.375079
06-07 16:55:09.211+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.211+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.211+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.221+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:226,-1.432183,0.052238,0.667951
06-07 16:55:09.221+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.221+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:222,-0.140000,0.210000,-0.070000
06-07 16:55:09.231+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.231+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:219,4.715486,-0.018594,8.598502
06-07 16:55:09.231+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:226,3.074777,0.007178,9.418150
06-07 16:55:09.231+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.231+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:238,4.753040,-0.017048,8.577803
06-07 16:55:09.241+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.241+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:232,-1.640708,0.025772,0.819648
06-07 16:55:09.241+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.241+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:246,3.062813,0.031107,9.312866
06-07 16:55:09.241+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:239,0.140000,-0.070000,-0.070000
06-07 16:55:09.241+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.241+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:249,-1.690227,0.048155,0.735064
06-07 16:55:09.251+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.251+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:257,-0.140000,-0.070000,0.210000
06-07 16:55:09.251+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:257,4.976419,-0.014801,8.450172
06-07 16:55:09.261+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.261+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.261+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:267,3.103491,-0.002393,9.329616
06-07 16:55:09.261+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.271+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:275,-0.770000,-0.070000,0.280000
06-07 16:55:09.271+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.291+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:285,3.127419,-0.066999,9.377472
06-07 16:55:09.301+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.301+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.311+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.311+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:307,-0.350000,-0.070000,0.280000
06-07 16:55:09.311+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:310,3.146562,-0.062213,9.370294
06-07 16:55:09.321+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:317,-1.872928,0.012409,0.879443
06-07 16:55:09.321+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.331+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.331+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:55:09.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:55:09.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:55:09.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:55:09.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390509346,000000, pattern:[H:mm][0;m
06-07 16:55:09.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:55:09.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:55:09.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:55:09.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:55:09.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:55:09.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:55][0;m
06-07 16:55:09.341+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:266,5.015007,-0.015557,8.427327
06-07 16:55:09.351+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.351+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:331,-1.887589,-0.051442,0.950145
06-07 16:55:09.361+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:356,4.562252,-0.019278,8.680776
06-07 16:55:09.361+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:340,3.136991,-0.011964,9.339187
06-07 16:55:09.361+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.361+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:338,-0.350000,-0.070000,0.560000
06-07 16:55:09.361+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.371+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.371+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:376,4.263153,-0.022490,8.831501
06-07 16:55:09.371+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.391+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:55:09.401+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:55:09:401,83
06-07 16:55:09.401+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.401+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:55:09.401+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:373,-0.420000,-0.350000,0.280000
06-07 16:55:09.411+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:55:09:412,999.000000
06-07 16:55:09.411+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:382,-1.415690,-0.042936,0.689518
06-07 16:55:09.411+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.411+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:370,3.141776,0.014357,9.329616
06-07 16:55:09.411+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.411+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.421+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:407,4.249467,-0.022876,8.838093
06-07 16:55:09.421+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.421+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:419,-1.126162,0.010526,0.507686
06-07 16:55:09.421+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.431+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:422,3.091527,0.040678,9.353544
06-07 16:55:09.431+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:434,4.330064,-0.021895,8.798889
06-07 16:55:09.431+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.441+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:425,-0.420000,-0.280000,0.280000
06-07 16:55:09.441+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.441+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.441+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:441,4.426107,-0.018446,8.750978
06-07 16:55:09.441+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.451+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:453,4.545818,-0.017035,8.689398
06-07 16:55:09.451+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:450,3.091527,0.021535,9.339187
06-07 16:55:09.451+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.461+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:434,-1.107691,0.037232,0.491523
06-07 16:55:09.461+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:460,4.808037,-0.016554,8.547098
06-07 16:55:09.461+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.471+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.471+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.471+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:448,0.280000,-0.140000,0.280000
06-07 16:55:09.471+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.481+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:475,-1.238537,0.062573,0.554655
06-07 16:55:09.481+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:479,3.089134,0.021535,9.408579
06-07 16:55:09.491+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.491+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.491+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:483,-0.280000,0.210000,0.280000
06-07 16:55:09.491+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.501+0200 W/LOCATION(12695): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 16:55:09.501+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:502,-1.334580,0.039982,0.588208
06-07 16:55:09.511+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.511+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:504,-0.910000,0.070000,0.210000
06-07 16:55:09.511+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:503,3.084348,-0.047856,9.403792
06-07 16:55:09.521+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:476,4.556913,-0.019238,8.683579
06-07 16:55:09.521+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.521+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.521+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.521+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:527,4.667303,-0.018419,8.624751
06-07 16:55:09.521+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.521+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:530,-0.490000,0.070000,0.140000
06-07 16:55:09.521+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.531+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:526,3.113062,0.007178,9.343972
06-07 16:55:09.531+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:521,-1.456684,0.038570,0.719181
06-07 16:55:09.531+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.531+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:533,4.422997,-0.021016,8.752545
06-07 16:55:09.531+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.541+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.541+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:538,-1.723689,-0.031302,0.856694
06-07 16:55:09.541+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:534,-0.350000,0.070000,-0.070000
06-07 16:55:09.541+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:541,3.098706,-0.057428,9.324830
06-07 16:55:09.541+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.551+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.551+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:547,4.358740,-0.020374,8.784722
06-07 16:55:09.551+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.551+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.561+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:553,3.117848,-0.011964,9.358330
06-07 16:55:09.561+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.561+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:557,-1.443851,0.026417,0.660393
06-07 16:55:09.561+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.561+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:561,-0.280000,0.070000,-0.070000
06-07 16:55:09.561+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:561,4.339590,-0.020444,8.794199
06-07 16:55:09.561+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.561+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.571+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:568,3.091527,-0.014357,9.391829
06-07 16:55:09.571+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.571+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:570,-1.568597,-0.039009,0.700079
06-07 16:55:09.571+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.571+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:575,4.430493,-0.019094,8.748757
06-07 16:55:09.581+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.581+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:574,0.140000,0.070000,-0.070000
06-07 16:55:09.581+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.581+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:55:09.591+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:582,-1.305149,0.009052,0.605784
06-07 16:55:09.591+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.591+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:55:09:593,84
06-07 16:55:09.591+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:580,3.081956,0.014357,9.363115
06-07 16:55:09.591+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.591+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:588,-0.210000,-0.070000,-0.070000
06-07 16:55:09.591+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.591+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:587,4.566225,-0.016892,8.678692
06-07 16:55:09.591+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.601+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:601,3.086741,0.028714,9.334401
06-07 16:55:09.601+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.601+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:55:09.601+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:597,-1.267213,0.006017,0.607106
06-07 16:55:09.601+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.611+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:55:09:612,998.000000
06-07 16:55:09.611+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:604,-0.210000,-0.210000,0.070000
06-07 16:55:09.611+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.611+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:608,4.466154,-0.017364,8.730610
06-07 16:55:09.611+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:618,-0.070000,-0.210000,0.210000
06-07 16:55:09.611+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.621+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:614,-1.257634,0.034801,0.568916
06-07 16:55:09.621+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.621+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:624,4.281360,-0.018019,8.822699
06-07 16:55:09.621+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:609,3.079563,-0.014357,9.353544
06-07 16:55:09.621+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.621+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.631+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.631+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:634,3.098706,-0.033500,9.348758
06-07 16:55:09.631+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.641+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:635,4.115481,-0.017366,8.901286
06-07 16:55:09.641+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:628,-1.343752,0.047808,0.585644
06-07 16:55:09.641+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.641+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.641+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:647,4.113325,-0.015787,8.902286
06-07 16:55:09.641+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:635,-0.210000,-0.350000,0.280000
06-07 16:55:09.641+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.651+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.651+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:642,3.105884,-0.021535,9.379865
06-07 16:55:09.651+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.651+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:658,4.124993,-0.015675,8.896885
06-07 16:55:09.651+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:647,-1.486662,0.002535,0.674852
06-07 16:55:09.651+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.661+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:652,0.140000,-0.350000,-0.070000
06-07 16:55:09.661+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.661+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:667,0.490000,0.070000,-0.140000
06-07 16:55:09.661+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.661+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.661+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:671,0.210000,0.070000,-0.070000
06-07 16:55:09.661+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.671+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:662,-1.367448,-0.016136,0.618148
06-07 16:55:09.671+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:671,4.148882,-0.016268,8.885770
06-07 16:55:09.671+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.671+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:677,-1.175477,-0.003516,0.557166
06-07 16:55:09.671+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.671+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.681+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:658,3.105884,0.007178,9.391829
06-07 16:55:09.681+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.681+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:685,4.229446,-0.016702,8.847706
06-07 16:55:09.681+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:686,3.108276,-0.009571,9.365508
06-07 16:55:09.681+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.681+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:690,3.103491,-0.011964,9.399008
06-07 16:55:09.681+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.691+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:682,-1.009598,0.024545,0.490542
06-07 16:55:09.691+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.701+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:675,-0.140000,-0.140000,-0.140000
06-07 16:55:09.701+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.701+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.701+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:694,3.065206,-0.004786,9.332008
06-07 16:55:09.701+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.701+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:699,-1.005049,0.006216,0.463223
06-07 16:55:09.711+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:710,4.188560,-0.017374,8.867133
06-07 16:55:09.711+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:706,-0.420000,-0.140000,0.070000
06-07 16:55:09.711+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.711+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.711+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:719,-1.021502,0.003711,0.502123
06-07 16:55:09.711+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.721+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:714,3.136991,-0.019143,9.375079
06-07 16:55:09.721+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.721+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:725,4.401671,-0.014618,8.763302
06-07 16:55:09.721+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:718,-0.560000,-0.140000,0.070000
06-07 16:55:09.721+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.731+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.731+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:735,-1.083676,0.011483,0.446239
06-07 16:55:09.731+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:729,3.141776,0.040678,9.336794
06-07 16:55:09.741+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.741+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:733,-0.280000,-0.070000,0.070000
06-07 16:55:09.741+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.741+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.741+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:746,4.538861,-0.012528,8.693042
06-07 16:55:09.741+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:748,-1.092455,-0.002441,0.527373
06-07 16:55:09.751+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.751+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.751+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:747,-0.070000,0.070000,0.070000
06-07 16:55:09.751+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.751+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:756,-1.046783,0.058052,0.469661
06-07 16:55:09.761+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.761+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:756,3.098706,0.016750,9.348758
06-07 16:55:09.761+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.761+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:766,5.152845,-0.008593,8.343770
06-07 16:55:09.761+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.761+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:770,3.146562,0.050249,9.372685
06-07 16:55:09.771+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:760,0.210000,-0.070000,-0.280000
06-07 16:55:09.771+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.771+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:777,0.210000,-0.070000,-0.280000
06-07 16:55:09.771+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:773,-1.302965,0.031368,0.585456
06-07 16:55:09.771+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.771+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.781+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:785,5.619518,-0.006925,8.036875
06-07 16:55:09.781+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.781+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:785,3.132205,0.021535,9.387043
06-07 16:55:09.781+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:55:09.781+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.791+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:790,-1.392299,0.062777,0.679644
06-07 16:55:09.791+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.791+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:55:09:794,84
06-07 16:55:09.791+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:793,-0.140000,-0.210000,-0.070000
06-07 16:55:09.791+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:797,-2.020641,0.030128,1.043273
06-07 16:55:09.801+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.801+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:55:09.801+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.811+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:55:09:812,998.000000
06-07 16:55:09.801+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.811+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:812,3.086741,0.033500,9.351151
06-07 16:55:09.811+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:812,6.519520,-0.004141,7.325723
06-07 16:55:09.821+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.821+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.821+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:820,-0.210000,-0.070000,-0.140000
06-07 16:55:09.801+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.821+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.831+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:834,-2.532777,0.040424,1.314276
06-07 16:55:09.841+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer alive timeout
06-07 16:55:09.841+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 16:55:09.841+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:829,3.125026,0.038285,9.324830
06-07 16:55:09.841+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:826,7.238341,-0.000811,6.616404
06-07 16:55:09.851+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.851+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.851+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:834,-0.210000,-0.070000,-0.140000
06-07 16:55:09.851+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:55:09.861+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:55:09.861+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:863,-3.394494,0.042426,1.999107
06-07 16:55:09.861+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:856,6.366992,-0.005238,7.458671
06-07 16:55:09.861+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.871+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12588
06-07 16:55:09.871+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.871+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12588)
06-07 16:55:09.871+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer launch request sent!
06-07 16:55:09.871+0200 I/servicemanager(12566): App control destroyed.
06-07 16:55:09.871+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope alive timeout
06-07 16:55:09.871+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 16:55:09.871+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:55:09.871+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:55:09.881+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:874,-0.630000,0.350000,0.210000
06-07 16:55:09.881+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.881+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12592
06-07 16:55:09.881+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12592)
06-07 16:55:09.881+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope launch request sent!
06-07 16:55:09.881+0200 I/servicemanager(12566): App control destroyed.
06-07 16:55:09.881+0200 I/servicemanager(12566): es.ugr.frailty.heartrate alive timeout
06-07 16:55:09.881+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 16:55:09.881+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:55:09.881+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:55:09.891+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:09.891+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:881,5.980982,-0.007931,7.771626
06-07 16:55:09.891+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12595
06-07 16:55:09.901+0200 W/CAPI_APPFW_APP_CONTROL(12588): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:55:09.901+0200 I/utils   (12588): specific action
06-07 16:55:09.901+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12595)
06-07 16:55:09.901+0200 I/servicemanager(12566): es.ugr.frailty.heartrate launch request sent!
06-07 16:55:09.901+0200 I/servicemanager(12566): App control destroyed.
06-07 16:55:09.901+0200 I/servicemanager(12566): es.ugr.frailty.location alive timeout
06-07 16:55:09.901+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 16:55:09.901+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:55:09.901+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12588), cmd(0)
06-07 16:55:09.901+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:55:09.901+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.901+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:55:09.901+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:09:908,3.113062,-0.040678,9.310472
06-07 16:55:09.901+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:09.911+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:09:891,-4.125279,-0.039867,2.694069
06-07 16:55:09.911+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12695
06-07 16:55:09.911+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12695)
06-07 16:55:09.911+0200 I/servicemanager(12566): es.ugr.frailty.location launch request sent!
06-07 16:55:09.911+0200 I/servicemanager(12566): App control destroyed.
06-07 16:55:09.911+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration alive timeout
06-07 16:55:09.911+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 16:55:09.911+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:55:09.911+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:55:09.911+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:09.921+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:09:900,-1.120000,0.210000,0.350000
06-07 16:55:09.921+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:09:916,5.439478,-0.011479,8.159800
06-07 16:55:09.921+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12600
06-07 16:55:09.931+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:55:09.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(12595), cmd(0)
06-07 16:55:09.931+0200 W/CAPI_APPFW_APP_CONTROL(12595): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:55:09.931+0200 I/utils   (12595): specific action
06-07 16:55:09.931+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12600)
06-07 16:55:09.931+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration launch request sent!
06-07 16:55:09.931+0200 I/servicemanager(12566): App control destroyed.
06-07 16:55:09.931+0200 I/servicemanager(12566): es.ugr.frailty.gravity alive timeout
06-07 16:55:09.931+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 16:55:09.931+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:55:09.931+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:55:09.941+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12699
06-07 16:55:09.941+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12699)
06-07 16:55:09.941+0200 I/servicemanager(12566): es.ugr.frailty.gravity launch request sent!
06-07 16:55:09.941+0200 I/servicemanager(12566): App control destroyed.
06-07 16:55:09.941+0200 I/servicemanager(12566): es.ugr.frailty.pressure alive timeout
06-07 16:55:09.941+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 16:55:09.951+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:09.951+0200 W/CAPI_APPFW_APP_CONTROL(12592): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:55:09.961+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:55:09.961+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:55:09.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12603
06-07 16:55:09.971+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:55:09.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(12592), cmd(0)
06-07 16:55:09.971+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:55:09.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(12603), cmd(0)
06-07 16:55:09.971+0200 W/CAPI_APPFW_APP_CONTROL(12603): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:55:09.971+0200 I/utils   (12603): specific action
06-07 16:55:09.971+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12603)
06-07 16:55:09.971+0200 I/servicemanager(12566): es.ugr.frailty.pressure launch request sent!
06-07 16:55:09.971+0200 I/servicemanager(12566): App control destroyed.
06-07 16:55:09.971+0200 I/servicemanager(12566): es.ugr.frailty.light alive timeout
06-07 16:55:09.971+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 16:55:09.981+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:55:09.981+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:55:09.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12614
06-07 16:55:09.991+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:55:09.991+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:55:09.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(12614), cmd(0)
06-07 16:55:09.991+0200 W/CAPI_APPFW_APP_CONTROL(12614): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:55:09.991+0200 I/utils   (12614): specific action
06-07 16:55:09.991+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12614)
06-07 16:55:09.991+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 16:55:09.991+0200 I/servicemanager(12566): App control destroyed.
06-07 16:55:09.991+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 16:55:09.991+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 16:55:10.001+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:55:10.001+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:55:10.001+0200 I/utils   (12592): specific action
06-07 16:55:10.001+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:10.011+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 16:55:10.011+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:55:10.011+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(12618), cmd(0)
06-07 16:55:10.011+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:55:10.011+0200 I/utils   (12618): specific action
06-07 16:55:10.011+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:55:09:999,84
06-07 16:55:10.011+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 16:55:10.011+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 16:55:10.011+0200 I/servicemanager(12566): App control destroyed.
06-07 16:55:10.011+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:55:10.021+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:55:10:24,998.000000
06-07 16:55:10.021+0200 E/AUL_AMD ( 2479): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
06-07 16:55:10.021+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:55:10.021+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12695), cmd(0)
06-07 16:55:10.031+0200 W/AUL     (12723): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-07 16:55:10.031+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 23
06-07 16:55:10.031+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-07 16:55:10.031+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 12695
06-07 16:55:10.031+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 16:55:10.041+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11126956c6f63152838330
