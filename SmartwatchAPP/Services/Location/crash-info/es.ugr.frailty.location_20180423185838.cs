S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 4950
Date: 2018-04-23 18:58:38+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf74f852d, r5   = 0xf7a0cf98
r6   = 0xffdf7880, r7   = 0xffdf7730
r8   = 0xf7a09c18, r9   = 0x00000000
r10  = 0xffdf780c, fp   = 0xffdf7880
ip   = 0x00000001, sp   = 0xffdf7708
lr   = 0xf74f8539, pc   = 0xf7561228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     73492 KB
Buffers:     35360 KB
Cached:     222276 KB
VmPeak:      53544 KB
VmSize:      53540 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12160 KB
VmRSS:       12160 KB
VmData:      11268 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 4950 TID = 4950
4950 4981 

Maps Information
f43c3000 f4bc2000 rw-p [stack:4981]
f4bc9000 f4bcb000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4bd3000 f4bd7000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4be0000 f4be2000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4bea000 f4bed000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4bfc000 f4c01000 r-xp /usr/lib/libsystem.so.0.0.0
f4c0c000 f4c0f000 r-xp /lib/libattr.so.1.1.0
f4c17000 f4c27000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c2f000 f4c38000 r-xp /usr/lib/libedbus.so.1.7.99
f4c40000 f4c41000 r-xp /usr/lib/libresponse.so.0.2.96
f4c4a000 f4c4f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f64f1000 f65f7000 r-xp /usr/lib/libicuuc.so.57.1
f660d000 f6795000 r-xp /usr/lib/libicui18n.so.57.1
f67a5000 f67b2000 r-xp /usr/lib/libail.so.0.1.0
f67bb000 f67c2000 r-xp /usr/lib/libminizip.so.1.0.0
f67cb000 f6974000 r-xp /usr/lib/libcrypto.so.1.0.0
f6994000 f69db000 r-xp /usr/lib/libssl.so.1.0.0
f69e7000 f69e9000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f69f1000 f69f8000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a01000 f6a08000 r-xp /lib/libcrypt-2.13.so
f6a39000 f6a3c000 r-xp /lib/libcap.so.2.21
f6a44000 f6a46000 r-xp /usr/lib/libiri.so
f6a4e000 f6a97000 r-xp /usr/lib/libmdm.so.1.2.69
f6a9f000 f6aa5000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6aad000 f6ad0000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6ada000 f6adc000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ae4000 f6b01000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b0a000 f6b0e000 r-xp /usr/lib/libsmack.so.1.0.0
f6b17000 f6b30000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b39000 f6b41000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b49000 f6b4f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b58000 f6b5a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b63000 f6b73000 r-xp /lib/libresolv-2.13.so
f6b77000 f6b8f000 r-xp /usr/lib/liblzma.so.5.0.3
f6b98000 f6b9a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6ba2000 f6bbc000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6bc4000 f6bf3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bfc000 f6c0b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c15000 f6c1f000 r-xp /usr/lib/libsensord-shared.so
f6c28000 f6cfb000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d06000 f6d1c000 r-xp /lib/libz.so.1.2.5
f6d24000 f6d29000 r-xp /usr/lib/libffi.so.5.0.10
f6d31000 f6d32000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d3a000 f6d4a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d52000 f6d6b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d73000 f6d75000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d7d000 f6df2000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6dfc000 f6e02000 r-xp /lib/librt-2.13.so
f6e0b000 f6e29000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e33000 f6e34000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e3c000 f6e5f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e67000 f6e6c000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e74000 f6e9e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ea7000 f6ebe000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ec6000 f6f2f000 r-xp /lib/libm-2.13.so
f6f38000 f6fcc000 r-xp /usr/lib/libstdc++.so.6.0.16
f6fdf000 f6fe4000 r-xp /usr/lib/libctx-client.so.0.8.3
f6fec000 f6ff3000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ffb000 f7025000 r-xp /usr/lib/libsensor.so.1.9.6
f702e000 f70fa000 r-xp /usr/lib/libxml2.so.2.7.8
f7107000 f7109000 r-xp /usr/lib/libiniparser.so.0
f7112000 f7118000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7121000 f71f1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71f2000 f7226000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f722f000 f726b000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7273000 f7276000 r-xp /usr/lib/libbundle.so.0.1.22
f727e000 f7284000 r-xp /usr/lib/libappsvc.so.0.1.0
f728c000 f72cd000 r-xp /usr/lib/libeina.so.1.7.99
f72d6000 f72ed000 r-xp /usr/lib/libecore.so.1.7.99
f7304000 f730d000 r-xp /usr/lib/libvconf.so.0.2.45
f7315000 f7329000 r-xp /lib/libpthread-2.13.so
f7334000 f7341000 r-xp /usr/lib/libaul.so.0.1.0
f734b000 f734d000 r-xp /lib/libdl-2.13.so
f7356000 f7361000 r-xp /lib/libunwind.so.8.0.1
f738e000 f7396000 r-xp /lib/libgcc_s-4.6.so.1
f7397000 f74bb000 r-xp /lib/libc-2.13.so
f74c9000 f74cb000 r-xp /usr/lib/libdlog.so.0.0.0
f74d3000 f74df000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74e8000 f74ed000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74f5000 f7504000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f750c000 f7510000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7519000 f751c000 r-xp /usr/lib/libappcore-agent.so.1.1
f7524000 f7526000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f752e000 f7532000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f753a000 f7557000 r-xp /lib/ld-2.13.so
f7560000 f7563000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7563000 f7567000 r-xp /usr/lib/libsys-assert.so
f79d9000 f7a61000 rw-p [heap]
ffdd8000 ffdf9000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4950)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7561228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf74f8539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71ff3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf71fdc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7209e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf720fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf720fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf724475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf723f1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf71fdc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7209e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf720fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf720fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7241e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7242017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7249f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4be11fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4bd4171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ca7663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7154fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71567a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf72e6ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf72e1b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72e25a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf72e2879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf751a183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf751a7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75614f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf73ae85c) [/lib/libc.so.6] + 0x1785c
29: (0xf7560f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 18:58:37.399+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:58:37.399+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 18:58:37.399+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.419+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.419+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:411,-0.119608,0.276762,0.326172
04-23 18:58:37.429+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.429+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:432,0.073497,0.181655,0.172532
04-23 18:58:37.429+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.439+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:393,-1.470000,2.240000,-2.310000
04-23 18:58:37.439+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:423,9.710074,-0.559920,1.832902
04-23 18:58:37.439+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:441,0.118308,-0.074330,0.067263
04-23 18:58:37.439+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.439+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.449+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.459+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:460,0.065063,-0.030370,-0.038888
04-23 18:58:37.459+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:450,-2.380000,-2.240000,-1.120000
04-23 18:58:37.459+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:450,9.757930,-0.792024,1.720440
04-23 18:58:37.459+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.459+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.459+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:466,9.705289,-0.748954,1.610370
04-23 18:58:37.469+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:467,-0.280000,-2.030000,-0.490000
04-23 18:58:37.469+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.469+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.469+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:477,2.730000,1.050000,-1.540000
04-23 18:58:37.469+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.469+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.479+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:479,0.028522,0.237669,-0.127053
04-23 18:58:37.479+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:482,2.730000,0.350000,-1.330000
04-23 18:58:37.479+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:482,9.669396,-0.478565,1.519442
04-23 18:58:37.489+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.489+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.499+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:499,0.083371,0.171544,0.137270
04-23 18:58:37.499+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.499+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:499,-10.990000,-0.280000,0.070000
04-23 18:58:37.499+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:508,9.726824,-0.528814,1.775474
04-23 18:58:37.509+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.519+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:519,-0.125447,-0.349099,0.066640
04-23 18:58:37.519+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.519+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:525,9.518648,-1.043271,1.703690
04-23 18:58:37.519+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.529+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.539+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:541,-0.115946,-0.371835,0.046012
04-23 18:58:37.539+0200 I/heartrate( 4929): capturing data from es.ugr.frailty.heartrate
04-23 18:58:37.539+0200 I/heartrate( 4929): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:58:37.539+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.539+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:548,9.525827,-1.088734,1.686940
04-23 18:58:37.539+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:532,-13.160000,0.070000,1.050000
04-23 18:58:37.549+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.549+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.549+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:558,0.103553,-0.023178,-0.003980
04-23 18:58:37.559+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.559+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:553,0.280000,-2.170000,0.700000
04-23 18:58:37.559+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.559+0200 E/CAPI_TELEPHONY( 3701): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 18:58:37.559+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:566,13.160000,-0.980000,-1.540000
04-23 18:58:37.569+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:563,9.743573,-0.758525,1.639083
04-23 18:58:37.569+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.569+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.569+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:578,9.927821,-0.739382,1.505085
04-23 18:58:37.569+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.569+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:578,0.286981,-0.010511,-0.136048
04-23 18:58:37.579+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:582,9.870000,0.700000,-4.620000
04-23 18:58:37.589+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.589+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.589+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:598,9.777073,-0.717847,1.689333
04-23 18:58:37.589+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.599+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:599,0.133095,-0.001285,0.061262
04-23 18:58:37.599+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:602,0.210000,3.570000,-1.960000
04-23 18:58:37.609+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.609+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.619+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.619+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:619,0.910000,2.660000,-3.150000
04-23 18:58:37.619+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:619,9.585647,-0.904487,1.921437
04-23 18:58:37.619+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:623,-0.057771,-0.190903,0.288745
04-23 18:58:37.629+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.629+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.629+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:638,10.360000,-0.210000,-2.730000
04-23 18:58:37.639+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.639+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:643,-0.000303,-0.089198,0.177906
04-23 18:58:37.639+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:638,9.640682,-0.806381,1.823331
04-23 18:58:37.649+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.649+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.659+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.659+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:660,0.136629,0.205557,0.323599
04-23 18:58:37.659+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:663,9.777073,-0.507278,1.974079
04-23 18:58:37.669+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:660,17.500000,0.210000,-3.640000
04-23 18:58:37.669+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.669+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.679+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.679+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:679,6.510000,-0.070000,-3.220000
04-23 18:58:37.679+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:683,-0.002197,0.307829,0.149345
04-23 18:58:37.679+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:679,9.638289,-0.382852,1.808974
04-23 18:58:37.689+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.689+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.699+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.699+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:700,-5.320000,-3.080000,-0.420000
04-23 18:58:37.699+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:704,-0.011213,0.212387,0.073776
04-23 18:58:37.709+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:699,9.631111,-0.454636,1.732404
04-23 18:58:37.709+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.709+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.719+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.719+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:720,-8.680000,-2.800000,-0.140000
04-23 18:58:37.719+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:723,0.175644,-0.009782,-0.011497
04-23 18:58:37.719+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:719,9.820145,-0.665205,1.639083
04-23 18:58:37.729+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.729+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.739+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.739+0200 I/heartrate( 4929): capturing data from es.ugr.frailty.heartrate
04-23 18:58:37.739+0200 I/heartrate( 4929): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:58:37.739+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:740,1.260000,-0.560000,-1.120000
04-23 18:58:37.739+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:743,0.164061,-0.227201,0.072224
04-23 18:58:37.749+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:740,9.810574,-0.882952,1.710868
04-23 18:58:37.749+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.759+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.759+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.759+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:763,0.078332,-0.054930,0.134881
04-23 18:58:37.759+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:763,10.640000,-0.280000,-2.660000
04-23 18:58:37.769+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:761,9.724431,-0.717847,1.773082
04-23 18:58:37.769+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.769+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.779+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.779+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:780,6.720000,-0.420000,-1.750000
04-23 18:58:37.779+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:783,9.580862,-0.373280,1.808974
04-23 18:58:37.789+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:781,-0.065228,0.283595,0.168285
04-23 18:58:37.789+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.789+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.789+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.799+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:799,-2.310000,-2.870000,0.700000
04-23 18:58:37.799+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:800,-0.121001,0.321865,-0.007208
04-23 18:58:37.809+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:802,9.525827,-0.315853,1.636691
04-23 18:58:37.809+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.809+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.819+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.819+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:823,9.798609,-0.768096,1.610370
04-23 18:58:37.819+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:820,-1.400000,-4.060000,2.240000
04-23 18:58:37.829+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:820,0.149745,-0.145501,-0.027366
04-23 18:58:37.829+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.829+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.839+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.839+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:840,5.670000,-0.070000,0.910000
04-23 18:58:37.849+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.859+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:843,0.180542,0.048557,-0.148602
04-23 18:58:37.859+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.859+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:841,9.829715,-0.583849,1.483550
04-23 18:58:37.859+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:864,0.052979,0.142046,-0.073277
04-23 18:58:37.859+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.869+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:860,7.350000,1.820000,0.420000
04-23 18:58:37.869+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.869+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.879+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:872,9.702895,-0.488136,1.555335
04-23 18:58:37.879+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.879+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:880,-0.013762,0.024791,-0.242662
04-23 18:58:37.879+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:880,2.870000,0.770000,0.770000
04-23 18:58:37.889+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:884,9.635897,-0.598206,1.390230
04-23 18:58:37.889+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.889+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.899+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:900,0.104842,0.183126,-0.061691
04-23 18:58:37.899+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:900,-6.160000,1.680000,1.610000
04-23 18:58:37.899+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.909+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:907,9.755538,-0.440279,1.564906
04-23 18:58:37.909+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.909+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.919+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:920,-7.630000,-0.210000,2.450000
04-23 18:58:37.929+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:37.929+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:920,-0.045949,-0.502661,0.085457
04-23 18:58:37.929+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.939+0200 I/heartrate( 4929): capturing data from es.ugr.frailty.heartrate
04-23 18:58:37.939+0200 I/heartrate( 4929): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:58:37.939+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:940,0.980000,0.280000,0.560000
04-23 18:58:37.939+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.959+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.959+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:952,0.129990,-0.290736,0.324392
04-23 18:58:37.959+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.969+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:963,4.200000,3.990000,-0.070000
04-23 18:58:37.969+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:970,0.047716,0.067653,0.008143
04-23 18:58:37.979+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:37.989+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:37.999+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:37:994,0.068409,0.040893,-0.224524
04-23 18:58:37.999+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:37:985,-1.400000,2.030000,-0.980000
04-23 18:58:37.999+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:37:937,9.604790,-1.122234,1.713261
04-23 18:58:37.999+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.009+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.009+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.019+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:12,9.777073,-0.940379,1.962115
04-23 18:58:38.019+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:13,0.210000,2.030000,-1.750000
04-23 18:58:38.029+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:22,0.226863,0.073952,-0.099958
04-23 18:58:38.029+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.029+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.039+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.049+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:36,9.690931,-0.595813,1.663012
04-23 18:58:38.049+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:36,-3.430000,1.890000,-4.410000
04-23 18:58:38.049+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.049+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.049+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:44,0.055430,-0.114989,-0.414399
04-23 18:58:38.059+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.059+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:60,9.710074,-0.619741,1.440479
04-23 18:58:38.059+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:66,0.095870,-0.374565,-0.356493
04-23 18:58:38.059+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.059+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:61,-6.230000,0.350000,-5.040000
04-23 18:58:38.069+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.069+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.069+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:71,0.318693,0.048816,0.272597
04-23 18:58:38.069+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:74,-0.280000,3.010000,-8.890000
04-23 18:58:38.069+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:74,9.870394,-0.583849,1.555335
04-23 18:58:38.069+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.079+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.079+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.079+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:83,9.700503,-0.765703,1.234696
04-23 18:58:38.079+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.079+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:85,-0.073776,-0.081905,0.575713
04-23 18:58:38.089+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:82,-1.540000,1.890000,-7.560000
04-23 18:58:38.089+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:90,9.745967,-1.024128,1.263410
04-23 18:58:38.089+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.089+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.089+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:96,9.973285,-0.610170,1.861616
04-23 18:58:38.089+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.099+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.099+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:98,-0.118332,-0.446377,0.326784
04-23 18:58:38.099+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:103,9.583255,-0.720240,2.158326
04-23 18:58:38.099+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:103,4.340000,-1.960000,-9.240000
04-23 18:58:38.099+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.109+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:109,9.537791,-1.074377,1.919044
04-23 18:58:38.109+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.109+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.119+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.119+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:119,-0.023582,-0.099945,0.078783
04-23 18:58:38.119+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:119,9.633504,-0.727418,1.665405
04-23 18:58:38.119+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:123,5.250000,-0.910000,-8.960000
04-23 18:58:38.129+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.129+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.139+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:140,-0.034663,0.293391,0.027072
04-23 18:58:38.139+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:140,9.626326,-0.318245,1.596013
04-23 18:58:38.139+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.139+0200 I/heartrate( 4929): capturing data from es.ugr.frailty.heartrate
04-23 18:58:38.139+0200 I/heartrate( 4929): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:58:38.139+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:145,4.690000,1.190000,-6.090000
04-23 18:58:38.149+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.149+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.149+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.159+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:160,-0.114809,0.430295,0.232211
04-23 18:58:38.169+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:162,3.780000,1.820000,-2.870000
04-23 18:58:38.169+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:161,9.549755,-0.153141,1.789831
04-23 18:58:38.169+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.169+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.179+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.179+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:183,6.020000,0.420000,1.050000
04-23 18:58:38.179+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:181,-0.110992,0.628356,0.381538
04-23 18:58:38.179+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:180,9.554541,0.071785,1.942972
04-23 18:58:38.189+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.189+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.199+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.199+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:200,-0.031352,0.698150,0.133077
04-23 18:58:38.199+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:203,9.633504,0.169890,1.708475
04-23 18:58:38.199+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:199,9.730000,-0.700000,2.940000
04-23 18:58:38.209+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.209+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.219+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.219+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:220,0.112272,0.380647,-0.192976
04-23 18:58:38.219+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:223,9.777073,-0.117248,1.392623
04-23 18:58:38.219+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:220,11.410000,0.770000,5.390000
04-23 18:58:38.229+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.229+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.239+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.249+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 18:58:38.249+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:58:38.249+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 18:58:38.249+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:239,0.137972,0.192878,-0.307529
04-23 18:58:38.249+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.249+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:239,12.600000,4.200000,7.350000
04-23 18:58:38.259+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:243,9.801002,-0.294317,1.292124
04-23 18:58:38.259+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.259+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.269+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:262,0.084868,0.096651,-0.179008
04-23 18:58:38.269+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.269+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:267,9.743573,-0.394816,1.445265
04-23 18:58:38.279+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.279+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:269,19.320000,7.490000,7.910000
04-23 18:58:38.279+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.279+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:283,9.655040,-0.337388,1.550549
04-23 18:58:38.279+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:280,0.004456,0.164307,-0.118255
04-23 18:58:38.289+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.289+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.299+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:300,-0.000272,0.082908,0.145633
04-23 18:58:38.299+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:300,9.640682,-0.428315,1.866402
04-23 18:58:38.299+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:290,17.710001,7.280000,9.100000
04-23 18:58:38.299+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.309+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:311,10.710000,7.980000,10.430000
04-23 18:58:38.309+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.309+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.319+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.319+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:321,0.010511,0.115384,0.227003
04-23 18:58:38.319+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:320,9.638289,-0.413958,2.014757
04-23 18:58:38.329+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:325,5.670000,7.910000,11.550000
04-23 18:58:38.329+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.339+0200 I/heartrate( 4929): capturing data from es.ugr.frailty.heartrate
04-23 18:58:38.339+0200 I/heartrate( 4929): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:58:38.339+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:341,9.631111,-0.418744,1.873580
04-23 18:58:38.349+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.359+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.359+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:354,0.018063,0.130521,0.014012
04-23 18:58:38.359+0200 W/LOCATION( 4950): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 18:58:38.359+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.369+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.379+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:363,9.710074,-0.569492,1.794617
04-23 18:58:38.379+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.379+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:371,0.111595,0.002919,-0.132019
04-23 18:58:38.389+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:377,4.270000,6.440000,13.650000
04-23 18:58:38.389+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.389+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.389+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:385,9.793823,-0.815953,1.954936
04-23 18:58:38.399+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.399+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:394,7.350000,5.390000,14.280000
04-23 18:58:38.399+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.399+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:396,0.209619,-0.214366,-0.032903
04-23 18:58:38.409+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.409+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:410,18.760000,6.370000,13.230000
04-23 18:58:38.409+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.409+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:404,9.745967,-0.521635,1.947758
04-23 18:58:38.409+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:416,14.000000,8.960000,12.320000
04-23 18:58:38.409+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.409+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.419+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:414,0.179193,0.113805,-0.112204
04-23 18:58:38.419+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.419+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:423,-3.850000,5.110000,13.440001
04-23 18:58:38.429+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.429+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:423,9.504292,-0.569492,2.009971
04-23 18:58:38.429+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.439+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:438,-13.650000,2.030000,14.910000
04-23 18:58:38.439+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:431,-0.045723,0.084645,-0.120691
04-23 18:58:38.439+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.449+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:441,9.473185,-0.863809,1.651048
04-23 18:58:38.449+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:450,-0.063917,-0.183601,-0.528722
04-23 18:58:38.449+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.449+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.459+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:459,-7.770000,2.240000,14.700000
04-23 18:58:38.459+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:461,9.863215,-1.055235,1.718047
04-23 18:58:38.459+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.459+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:466,0.330878,-0.330617,-0.468245
04-23 18:58:38.469+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.469+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.479+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:479,4.760000,5.880000,11.970000
04-23 18:58:38.479+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.479+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:479,9.860823,-0.933201,1.847259
04-23 18:58:38.479+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:483,0.334002,-0.161109,-0.346813
04-23 18:58:38.489+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.489+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.499+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:499,9.940000,8.680000,10.850000
04-23 18:58:38.499+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.499+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:504,0.099055,0.071542,-0.477747
04-23 18:58:38.499+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:499,9.616754,-0.732204,1.744368
04-23 18:58:38.509+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.509+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.519+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:519,-0.210000,6.160000,11.410000
04-23 18:58:38.519+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.519+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:520,9.621540,-0.993021,1.794617
04-23 18:58:38.519+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:523,0.113534,-0.170044,-0.461689
04-23 18:58:38.529+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.529+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.529+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:538,-7.840000,7.420000,13.650000
04-23 18:58:38.529+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.539+0200 I/heartrate( 4929): capturing data from es.ugr.frailty.heartrate
04-23 18:58:38.539+0200 I/heartrate( 4929): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:58:38.539+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:539,9.604790,-1.201197,2.256432
04-23 18:58:38.539+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:543,0.103378,-0.344841,-0.015178
04-23 18:58:38.549+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.549+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.559+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:559,-1.400000,5.740000,12.670000
04-23 18:58:38.559+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:560,9.556933,-0.966700,1.952543
04-23 18:58:38.559+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.559+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:564,0.069540,-0.063635,-0.359212
04-23 18:58:38.569+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.569+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.569+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:579,0.700000,5.250000,14.420000
04-23 18:58:38.579+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:579,9.645468,-0.782453,2.031506
04-23 18:58:38.579+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.579+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:583,0.166762,0.151630,-0.303451
04-23 18:58:38.599+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.599+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.609+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:610,-4.480000,5.880000,14.700000
04-23 18:58:38.619+0200 W/libgps_d( 3158): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 18:58:38.619+0200 W/libgps  ( 3158): [proxy__gps_stop][line = 1067]: called.
04-23 18:58:38.619+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:58:38.619+0200 W/libgps_d( 3158): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 18:58:38.619+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 18:58:38.619+0200 W/libgps_d( 3158): GpsiHookStateGps              : EXIT
04-23 18:58:38.619+0200 W/libgps_d( 3158): GpsiHookStateIdle             : ENTRY
04-23 18:58:38.619+0200 E/CAPI_LOCATION_MANAGER( 3701): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 18:58:38.619+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:0, msg id:2
04-23 18:58:38.629+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.629+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:58:38.639+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:634,-10.500000,4.760000,15.190001
04-23 18:58:38.649+0200 W/AUL     ( 4990): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 18:58:38.649+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 18:58:38.649+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 18:58:38.649+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 4950
04-23 18:58:38.649+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 18:58:38.649+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4950
04-23 18:58:38.649+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(4950)
04-23 18:58:38.699+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:612,9.647861,-0.801596,2.033899
04-23 18:58:38.699+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.699+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:704,9.564112,-1.155733,2.000400
04-23 18:58:38.699+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.699+0200 I/accelerometer( 4913): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:38:708,9.623933,-1.921437,1.818545
04-23 18:58:38.699+0200 I/accelerometer( 4913): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:38.709+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.709+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.719+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:717,-12.180000,0.770000,14.490000
04-23 18:58:38.719+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.719+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:715,0.180034,0.155747,-0.335515
04-23 18:58:38.719+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.719+0200 I/linearacceleration( 4966): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:38:726,0.106163,-0.173145,-0.397957
04-23 18:58:38.729+0200 I/gyroscope( 4916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:38:724,-3.360000,7.140000,14.490000
04-23 18:58:38.729+0200 I/gyroscope( 4916): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:38.729+0200 I/linearacceleration( 4966): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:38.739+0200 I/CAPI_NETWORK_CONNECTION( 3701): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 18:58:38.739+0200 I/CAPI_NETWORK_CONNECTION( 3701): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 18:58:38.739+0200 I/heartrate( 4929): capturing data from es.ugr.frailty.heartrate
04-23 18:58:38.739+0200 I/heartrate( 4929): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:58:38.749+0200 I/CAPI_NETWORK_CONNECTION( 3701): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 18:58:38.749+0200 I/CAPI_NETWORK_CONNECTION( 3701): connection.c: connection_destroy(471) > Destroy handle: 0xf3f26688
04-23 18:58:38.749+0200 W/CRASH_MANAGER( 4992): worker.c: worker_job(1205) > 11049506c6f63152450271
