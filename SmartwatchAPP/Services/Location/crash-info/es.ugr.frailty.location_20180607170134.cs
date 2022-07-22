S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 14541
Date: 2018-06-07 17:01:34+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70d452d, r5   = 0xf753df98
r6   = 0xffba48e0, r7   = 0xffba4790
r8   = 0xf753ac18, r9   = 0x00000000
r10  = 0xffba486c, fp   = 0xffba48e0
ip   = 0x00000001, sp   = 0xffba4768
lr   = 0xf70d4539, pc   = 0xf713d228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    139944 KB
Buffers:      7648 KB
Cached:      51776 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11424 KB
VmRSS:       11424 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 14541 TID = 14541
14541 14544 

Maps Information
f3f9f000 f479e000 rw-p [stack:14544]
f47a5000 f47a7000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f47af000 f47b3000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f47bc000 f47be000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f47c6000 f47c9000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47d8000 f47dd000 r-xp /usr/lib/libsystem.so.0.0.0
f47e8000 f47eb000 r-xp /lib/libattr.so.1.1.0
f47f3000 f4803000 r-xp /usr/lib/libmdm-common.so.1.1.24
f480b000 f4814000 r-xp /usr/lib/libedbus.so.1.7.99
f481c000 f481d000 r-xp /usr/lib/libresponse.so.0.2.96
f4826000 f482b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f60cd000 f61d3000 r-xp /usr/lib/libicuuc.so.57.1
f61e9000 f6371000 r-xp /usr/lib/libicui18n.so.57.1
f6381000 f638e000 r-xp /usr/lib/libail.so.0.1.0
f6397000 f639e000 r-xp /usr/lib/libminizip.so.1.0.0
f63a7000 f6550000 r-xp /usr/lib/libcrypto.so.1.0.0
f6570000 f65b7000 r-xp /usr/lib/libssl.so.1.0.0
f65c3000 f65c5000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f65cd000 f65d4000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65dd000 f65e4000 r-xp /lib/libcrypt-2.13.so
f6615000 f6618000 r-xp /lib/libcap.so.2.21
f6620000 f6622000 r-xp /usr/lib/libiri.so
f662a000 f6673000 r-xp /usr/lib/libmdm.so.1.2.69
f667b000 f6681000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6689000 f66ac000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f66b6000 f66b8000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f66c0000 f66dd000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66e6000 f66ea000 r-xp /usr/lib/libsmack.so.1.0.0
f66f3000 f670c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6715000 f671d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6725000 f672b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6734000 f6736000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f673f000 f674f000 r-xp /lib/libresolv-2.13.so
f6753000 f676b000 r-xp /usr/lib/liblzma.so.5.0.3
f6774000 f6776000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f677e000 f6798000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f67a0000 f67cf000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67d8000 f67e7000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67f1000 f67fb000 r-xp /usr/lib/libsensord-shared.so
f6804000 f68d7000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68e2000 f68f8000 r-xp /lib/libz.so.1.2.5
f6900000 f6905000 r-xp /usr/lib/libffi.so.5.0.10
f690d000 f690e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6916000 f6926000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f692e000 f6947000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f694f000 f6951000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6959000 f69ce000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69d8000 f69de000 r-xp /lib/librt-2.13.so
f69e7000 f6a05000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a0f000 f6a10000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a18000 f6a3b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a43000 f6a48000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a50000 f6a7a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a83000 f6a9a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6aa2000 f6b0b000 r-xp /lib/libm-2.13.so
f6b14000 f6ba8000 r-xp /usr/lib/libstdc++.so.6.0.16
f6bbb000 f6bc0000 r-xp /usr/lib/libctx-client.so.0.8.3
f6bc8000 f6bcf000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6bd7000 f6c01000 r-xp /usr/lib/libsensor.so.1.9.6
f6c0a000 f6cd6000 r-xp /usr/lib/libxml2.so.2.7.8
f6ce3000 f6ce5000 r-xp /usr/lib/libiniparser.so.0
f6cee000 f6cf4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6cfd000 f6dcd000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6dce000 f6e02000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e0b000 f6e47000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e4f000 f6e52000 r-xp /usr/lib/libbundle.so.0.1.22
f6e5a000 f6e60000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e68000 f6ea9000 r-xp /usr/lib/libeina.so.1.7.99
f6eb2000 f6ec9000 r-xp /usr/lib/libecore.so.1.7.99
f6ee0000 f6ee9000 r-xp /usr/lib/libvconf.so.0.2.45
f6ef1000 f6f05000 r-xp /lib/libpthread-2.13.so
f6f10000 f6f1d000 r-xp /usr/lib/libaul.so.0.1.0
f6f27000 f6f29000 r-xp /lib/libdl-2.13.so
f6f32000 f6f3d000 r-xp /lib/libunwind.so.8.0.1
f6f6a000 f6f72000 r-xp /lib/libgcc_s-4.6.so.1
f6f73000 f7097000 r-xp /lib/libc-2.13.so
f70a5000 f70a7000 r-xp /usr/lib/libdlog.so.0.0.0
f70af000 f70bb000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f70c4000 f70c9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70d1000 f70e0000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70e8000 f70ec000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70f5000 f70f8000 r-xp /usr/lib/libappcore-agent.so.1.1
f7100000 f7102000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f710a000 f710e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7116000 f7133000 r-xp /lib/ld-2.13.so
f713c000 f713f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f713f000 f7143000 r-xp /usr/lib/libsys-assert.so
f750a000 f7598000 rw-p [heap]
ffb86000 ffba7000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14541)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf713d228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf70d4539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6ddb3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6dd9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6de5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6debbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6debdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e2075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e1b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6dd9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6de5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6debbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6debdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e1de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e1e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e25f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47bd1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf47b0171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6883663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d30fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d327a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6ec2ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6ebdb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6ebe5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6ebe879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70f6183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70f67fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf713d5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6f8a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf713cf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.011+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:15,13.790000,6.580000,4.060000
06-07 17:01:34.011+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:19,-0.016098,-1.769444,0.296695
06-07 17:01:34.011+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.021+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:23,-0.063475,-1.285770,0.334907
06-07 17:01:34.021+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.021+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:27,9.260223,2.459821,0.806381
06-07 17:01:34.021+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:28,0.045218,-1.144759,-0.218306
06-07 17:01:34.021+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.021+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:31,0.239543,-0.268282,-0.821344
06-07 17:01:34.031+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.031+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:26,9.034166,3.537416,1.428603
06-07 17:01:34.031+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.031+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:36,6.230000,7.630000,4.060000
06-07 17:01:34.031+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.031+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:40,19.530001,5.810000,0.280000
06-07 17:01:34.031+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.041+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.041+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.041+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:45,0.272847,-0.437131,-0.347604
06-07 17:01:34.041+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:44,22.400000,10.920000,-2.590000
06-07 17:01:34.041+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.041+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:01:34.051+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:46,9.045115,3.499296,1.453002
06-07 17:01:34.051+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.051+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:49,8.987441,1.859223,1.689333
06-07 17:01:34.061+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:01:34.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:01:34.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:01:34.061+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:01:34:53,85
06-07 17:01:34.061+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:01:34.061+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.071+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:01:34:73,444.000000
06-07 17:01:34.071+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:73,0.168612,-1.146482,-0.163156
06-07 17:01:34.071+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:53,14.770000,13.930000,-5.040000
06-07 17:01:34.071+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.071+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:81,7.700000,13.020000,-3.010000
06-07 17:01:34.081+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.081+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.081+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:70,8.970692,2.251646,1.763510
06-07 17:01:34.081+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:86,0.132754,-1.185675,-0.140533
06-07 17:01:34.081+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:65,9.044609,3.498592,1.457835
06-07 17:01:34.081+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:86,11.690000,12.670000,-5.460000
06-07 17:01:34.081+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.081+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.091+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.091+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:94,19.809999,14.210000,-10.220000
06-07 17:01:34.091+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:98,9.090333,2.354537,1.234696
06-07 17:01:34.091+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:96,9.025661,3.554979,1.438731
06-07 17:01:34.091+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.101+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.101+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:106,-0.052610,-0.417296,0.296538
06-07 17:01:34.101+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:110,9.015040,3.579983,1.443316
06-07 17:01:34.101+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.111+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.111+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:116,27.719999,17.780001,-11.340000
06-07 17:01:34.111+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.111+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:115,9.284152,3.230310,0.636491
06-07 17:01:34.121+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.121+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:126,-0.017150,-0.396731,0.300380
06-07 17:01:34.121+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.121+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:131,9.298509,3.117848,1.091127
06-07 17:01:34.131+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.131+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:121,9.015007,3.573712,1.458978
06-07 17:01:34.131+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.131+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:136,45.849998,13.370000,-13.370000
06-07 17:01:34.131+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.131+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:137,9.006553,3.587786,1.476543
06-07 17:01:34.141+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.141+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.141+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:146,55.439999,8.750000,-15.400000
06-07 17:01:34.141+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:146,0.153910,-0.255307,0.230752
06-07 17:01:34.141+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.141+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:142,9.183653,2.433501,1.280160
06-07 17:01:34.151+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:153,8.971092,3.660542,1.513379
06-07 17:01:34.151+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.151+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:158,9.147761,2.388037,1.318445
06-07 17:01:34.151+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.161+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.161+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:163,8.929245,3.753613,1.532758
06-07 17:01:34.161+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.161+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.161+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:170,62.369999,6.650000,-14.210000
06-07 17:01:34.161+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:170,-0.060262,-0.895374,-0.109608
06-07 17:01:34.171+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.171+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:168,8.953942,3.170490,1.773082
06-07 17:01:34.171+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:180,8.882599,3.862474,1.533337
06-07 17:01:34.171+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.181+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.181+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.181+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:186,86.519997,9.170000,-18.620001
06-07 17:01:34.181+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:186,0.029990,-0.767926,-0.205466
06-07 17:01:34.181+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:191,8.953942,3.263810,1.813759
06-07 17:01:34.191+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.191+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:195,8.844989,3.955165,1.514340
06-07 17:01:34.191+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.191+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:200,9.083155,3.498307,1.763510
06-07 17:01:34.191+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.201+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.201+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:207,0.223067,0.158090,-0.146825
06-07 17:01:34.201+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:205,8.776339,4.117884,1.479628
06-07 17:01:34.211+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.211+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.211+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:216,96.669998,10.990000,-17.850000
06-07 17:01:34.211+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.211+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:216,8.822337,2.967100,1.423729
06-07 17:01:34.221+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.221+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:226,-0.040409,0.266253,-0.325015
06-07 17:01:34.221+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.221+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:232,8.874979,3.187240,1.308874
06-07 17:01:34.231+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.231+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:221,8.666534,4.359074,1.435284
06-07 17:01:34.231+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.231+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:236,84.559998,5.950000,-14.280000
06-07 17:01:34.231+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.231+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:237,8.554364,4.593165,1.376979
06-07 17:01:34.231+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.241+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.241+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:245,59.430000,-4.690000,-11.270000
06-07 17:01:34.241+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:246,0.002369,0.185301,-0.539491
06-07 17:01:34.241+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.251+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:01:34.251+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:242,8.999406,4.275974,1.332802
06-07 17:01:34.251+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.251+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:251,8.473800,4.760529,1.304786
06-07 17:01:34.251+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:01:34:255,86
06-07 17:01:34.251+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:259,8.626125,4.625326,1.110270
06-07 17:01:34.251+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.261+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:265,8.556733,4.778467,0.837488
06-07 17:01:34.261+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:01:34.261+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.271+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.271+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.271+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:276,37.310001,-12.460000,-5.530000
06-07 17:01:34.271+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:280,8.438288,4.843020,1.229162
06-07 17:01:34.271+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:01:34:276,432.000000
06-07 17:01:34.281+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:272,0.231289,-0.144773,-0.651546
06-07 17:01:34.281+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.281+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.281+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.281+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:286,21.700001,-12.320000,-5.600000
06-07 17:01:34.281+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:289,0.687938,-0.507226,-0.815204
06-07 17:01:34.291+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:293,8.428184,4.878324,1.156751
06-07 17:01:34.291+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.291+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:297,8.705089,4.615755,0.653241
06-07 17:01:34.291+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.301+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.301+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:306,0.542508,-1.080914,-0.651865
06-07 17:01:34.301+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:304,9.126225,4.335794,0.413958
06-07 17:01:34.301+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.301+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.311+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.311+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:314,8.417490,4.907784,1.109010
06-07 17:01:34.311+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:315,8.970692,3.797409,0.504886
06-07 17:01:34.311+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:314,19.110001,-3.290000,-5.950000
06-07 17:01:34.321+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.321+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:01:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:01:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:01:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:01:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:01:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:01:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:01:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:01:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:01:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:01:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:01:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:01:34.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390894349,000000, pattern:[H:mm][0;m
06-07 17:01:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:01:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:01:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:01:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:01:34.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:01:34.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:01][0;m
06-07 17:01:34.371+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.371+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:378,0.557988,-0.758630,0.180722
06-07 17:01:34.371+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.381+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:330,8.975478,4.149154,1.289732
06-07 17:01:34.381+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:382,8.364016,5.000312,1.100231
06-07 17:01:34.381+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.381+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.381+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:388,8.738588,4.065405,0.660419
06-07 17:01:34.381+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:389,8.228052,5.233431,1.039584
06-07 17:01:34.381+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.381+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.391+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.391+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:393,8.042710,5.528738,0.958255
06-07 17:01:34.391+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.391+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:396,0.374573,-0.934906,-0.439812
06-07 17:01:34.391+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.391+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:398,7.919590,5.713374,0.898797
06-07 17:01:34.391+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:400,0.606249,-0.172612,-0.802695
06-07 17:01:34.401+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.401+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:409,7.898241,5.743952,0.891735
06-07 17:01:34.401+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:393,8.834301,5.060820,0.236889
06-07 17:01:34.411+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.411+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:328,39.130001,6.650000,-8.820000
06-07 17:01:34.411+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.421+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:422,68.949997,8.330000,-11.410000
06-07 17:01:34.421+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.421+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.431+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:427,64.820000,9.940000,-9.450000
06-07 17:01:34.431+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.431+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:437,40.529999,6.160000,-2.450000
06-07 17:01:34.431+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.431+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:441,29.120001,0.140000,-1.190000
06-07 17:01:34.441+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.451+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:01:34.451+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:453,7.890274,5.756232,0.883038
06-07 17:01:34.451+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.451+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:01:34:456,86
06-07 17:01:34.461+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:415,8.539984,4.938786,0.344566
06-07 17:01:34.461+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:435,0.497273,-0.589952,-0.613689
06-07 17:01:34.461+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.461+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:01:34.471+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:471,0.768748,-1.147868,0.355042
06-07 17:01:34.471+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.471+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:01:34:472,409.000000
06-07 17:01:34.471+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.471+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:468,7.731048,5.979187,0.806600
06-07 17:01:34.481+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:476,0.842741,-2.080541,0.594208
06-07 17:01:34.481+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.481+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.481+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:479,46.619999,-4.200000,-2.450000
06-07 17:01:34.481+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.481+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.491+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:487,1.073240,-1.798504,-0.234583
06-07 17:01:34.491+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.491+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:494,7.493912,6.287491,0.692187
06-07 17:01:34.491+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:490,8.688338,4.565506,1.253839
06-07 17:01:34.501+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:490,67.410004,-0.630000,-5.670000
06-07 17:01:34.501+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.501+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.511+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:507,49.420002,3.360000,-4.410000
06-07 17:01:34.511+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.511+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.511+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:517,7.360357,6.452018,0.605800
06-07 17:01:34.511+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:509,8.740981,3.663411,1.485943
06-07 17:01:34.511+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:503,1.230072,-1.423253,-1.208594
06-07 17:01:34.511+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.521+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.521+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:525,1.263819,-2.088087,-1.216215
06-07 17:01:34.521+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.521+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.531+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:534,7.282912,6.544943,0.541578
06-07 17:01:34.531+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:518,15.750000,-1.050000,-0.980000
06-07 17:01:34.531+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.541+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:532,8.963513,3.957729,0.648455
06-07 17:01:34.541+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.541+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:544,10.570000,-4.900000,-5.600000
06-07 17:01:34.541+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.541+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.551+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:529,1.624692,-2.977639,-0.828332
06-07 17:01:34.551+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.561+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:553,8.961121,4.555934,-0.401994
06-07 17:01:34.561+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:555,7.102057,6.746458,0.465257
06-07 17:01:34.561+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.561+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:553,24.290001,1.680000,-8.120000
06-07 17:01:34.561+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.561+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.571+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:560,1.939027,-2.833675,-0.814359
06-07 17:01:34.571+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.571+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:577,6.952559,6.903403,0.418726
06-07 17:01:34.581+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.581+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:569,8.757731,4.199404,-0.524028
06-07 17:01:34.581+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.581+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:587,6.745108,7.109935,0.350326
06-07 17:01:34.581+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.591+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:593,6.535479,7.306092,0.280915
06-07 17:01:34.591+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:569,33.740002,6.370000,-4.340000
06-07 17:01:34.591+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.591+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:598,36.400002,3.150000,-7.700000
06-07 17:01:34.591+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.601+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.611+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:611,6.485763,7.351165,0.256188
06-07 17:01:34.611+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:577,1.875813,-2.637982,-0.216403
06-07 17:01:34.611+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.611+0200 W/LOCATION(14541): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:01:34.621+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:621,1.647246,-3.077280,-0.382833
06-07 17:01:34.621+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.621+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.631+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:589,8.985049,3.474378,-0.222532
06-07 17:01:34.631+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.631+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:635,6.573123,7.272514,0.273808
06-07 17:01:34.641+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.641+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:638,9.221939,3.711268,-0.272782
06-07 17:01:34.641+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.641+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:629,2.232763,-2.573143,-0.510646
06-07 17:01:34.641+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.641+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:647,6.721623,7.133959,0.311125
06-07 17:01:34.651+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:01:34.651+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:01:34:656,86
06-07 17:01:34.661+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:602,27.860001,1.890000,-7.420000
06-07 17:01:34.661+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:648,8.977871,4.108476,0.248854
06-07 17:01:34.661+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:01:34.661+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.671+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.671+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:651,2.262929,-2.855443,-0.245023
06-07 17:01:34.671+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:673,7.036428,6.820521,0.373559
06-07 17:01:34.671+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:01:34:674,389.000000
06-07 17:01:34.681+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.681+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.681+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:687,7.570749,6.215758,0.467438
06-07 17:01:34.681+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:688,8.599805,3.826123,0.035892
06-07 17:01:34.681+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:676,8.050000,-0.560000,-1.330000
06-07 17:01:34.681+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.691+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.701+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.701+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:702,2.528000,-2.984263,0.145807
06-07 17:01:34.701+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.701+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:707,7.978261,5.677553,0.532104
06-07 17:01:34.711+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.711+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:694,-1.260000,0.420000,-2.590000
06-07 17:01:34.711+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.721+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.721+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:728,8.191781,5.361986,0.560551
06-07 17:01:34.721+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:708,2.356891,-2.190159,0.207150
06-07 17:01:34.721+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.731+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:722,-11.270000,3.920000,-0.210000
06-07 17:01:34.731+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.731+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:718,8.977871,4.536791,-0.160319
06-07 17:01:34.731+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.741+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.741+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:747,8.346370,5.117285,0.567353
06-07 17:01:34.741+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:738,-38.920002,1.050000,5.110000
06-07 17:01:34.741+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.751+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:742,8.798409,4.450650,0.035892
06-07 17:01:34.751+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.751+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:735,1.737006,-2.173638,-0.000058
06-07 17:01:34.751+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.761+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:763,1.546627,-1.908057,0.413680
06-07 17:01:34.761+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.761+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.761+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:772,8.544064,4.780023,0.566341
06-07 17:01:34.771+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:761,9.013763,4.366901,0.401994
06-07 17:01:34.771+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:752,-59.010002,-8.400000,11.270000
06-07 17:01:34.771+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.781+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.781+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:785,1.268338,-1.652646,0.389192
06-07 17:01:34.781+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.781+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:786,8.709827,4.474197,0.539312
06-07 17:01:34.791+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.791+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:782,-49.560001,-8.890000,10.920000
06-07 17:01:34.791+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.801+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.801+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:807,8.801965,4.294898,0.499650
06-07 17:01:34.801+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:789,1.109679,-0.836873,-0.017647
06-07 17:01:34.801+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.811+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:799,-37.240002,-3.010000,10.150000
06-07 17:01:34.811+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.811+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:795,8.930015,5.082355,0.480957
06-07 17:01:34.821+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.821+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.821+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:828,8.859438,4.177495,0.478831
06-07 17:01:34.821+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:814,0.699948,-0.238953,-0.763941
06-07 17:01:34.821+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.831+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:826,8.458629,4.960321,0.311067
06-07 17:01:34.831+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.841+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.841+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:819,-47.599998,3.290000,13.580000
06-07 17:01:34.841+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.841+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:846,8.923289,4.039416,0.477922
06-07 17:01:34.841+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:01:34.851+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:01:34:853,86
06-07 17:01:34.861+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:833,0.222328,-0.020573,-1.079417
06-07 17:01:34.861+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:840,8.583055,4.912465,0.787239
06-07 17:01:34.861+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.861+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:01:34.861+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.861+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:849,-68.739998,0.350000,19.950001
06-07 17:01:34.861+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.871+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.881+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:873,9.022902,3.807271,0.512174
06-07 17:01:34.881+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:01:34:874,425.000000
06-07 17:01:34.891+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:870,8.839087,4.563113,0.856631
06-07 17:01:34.891+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.901+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:906,9.087940,4.840680,0.514457
06-07 17:01:34.901+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.911+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.911+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:875,-60.410000,-5.110000,21.070000
06-07 17:01:34.911+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:915,8.891729,5.123034,-0.203390
06-07 17:01:34.911+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.911+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.921+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:880,-0.008865,-0.300659,-1.181297
06-07 17:01:34.921+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:916,9.105958,3.599982,0.540409
06-07 17:01:34.921+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.921+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:923,-37.170002,-2.730000,15.540000
06-07 17:01:34.921+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.921+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.931+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:935,-33.529999,4.410000,17.430000
06-07 17:01:34.931+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:927,8.568698,5.096712,-0.512064
06-07 17:01:34.931+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.931+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:933,0.327864,-0.238901,-1.185374
06-07 17:01:34.931+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.931+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.941+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:941,8.535198,4.479364,-0.614955
06-07 17:01:34.941+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.951+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:946,-48.790001,10.220000,25.340000
06-07 17:01:34.951+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.951+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:931,9.145499,3.491647,0.581913
06-07 17:01:34.951+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:953,9.037691,4.235296,-0.646062
06-07 17:01:34.951+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:34.951+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.961+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:960,-66.500000,3.150000,34.299999
06-07 17:01:34.961+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:34.971+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:966,9.200402,4.596612,-0.507278
06-07 17:01:34.971+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:34.971+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:972,-68.320000,2.520000,35.980000
06-07 17:01:34.971+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:944,0.398438,0.301714,-1.006928
06-07 17:01:34.971+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:34.971+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:35.011+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:34:980,8.781659,4.508078,-0.459422
06-07 17:01:35.011+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:34:984,-52.360001,10.500000,37.799999
06-07 17:01:35.011+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:35.011+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:35.011+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:35:20,8.616554,4.098906,0.421137
06-07 17:01:35.021+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:35:24,-35.490002,17.639999,41.160000
06-07 17:01:35.021+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:35.021+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:35.021+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:34:964,9.158494,3.449708,0.626017
06-07 17:01:35.021+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:35.031+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:35:32,-30.590000,18.129999,46.549999
06-07 17:01:35.031+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:35:30,8.997013,3.955336,0.404387
06-07 17:01:35.031+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:34:983,-0.077779,0.330583,-0.938253
06-07 17:01:35.031+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:35.031+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:35.031+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:35.031+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11145416c6f63152838369
