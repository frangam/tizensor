S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 21631
Date: 2018-04-23 19:46:42+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6fb252d, r5   = 0xf7716958
r6   = 0xffda3990, r7   = 0xffda3840
r8   = 0xf7729c18, r9   = 0x00000000
r10  = 0xffda391c, fp   = 0xffda3990
ip   = 0x00000001, sp   = 0xffda3818
lr   = 0xf6fb2539, pc   = 0xf701b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      5368 KB
Buffers:     57352 KB
Cached:     234412 KB
VmPeak:      53528 KB
VmSize:      53524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11868 KB
VmRSS:       11868 KB
VmData:      11252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 21631 TID = 21631
21631 21672 

Maps Information
f3e7d000 f467c000 rw-p [stack:21672]
f4683000 f4685000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f468d000 f4691000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f469a000 f469c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f46a4000 f46a7000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f46b6000 f46bb000 r-xp /usr/lib/libsystem.so.0.0.0
f46c6000 f46c9000 r-xp /lib/libattr.so.1.1.0
f46d1000 f46e1000 r-xp /usr/lib/libmdm-common.so.1.1.24
f46e9000 f46f2000 r-xp /usr/lib/libedbus.so.1.7.99
f46fa000 f46fb000 r-xp /usr/lib/libresponse.so.0.2.96
f4704000 f4709000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5fab000 f60b1000 r-xp /usr/lib/libicuuc.so.57.1
f60c7000 f624f000 r-xp /usr/lib/libicui18n.so.57.1
f625f000 f626c000 r-xp /usr/lib/libail.so.0.1.0
f6275000 f627c000 r-xp /usr/lib/libminizip.so.1.0.0
f6285000 f642e000 r-xp /usr/lib/libcrypto.so.1.0.0
f644e000 f6495000 r-xp /usr/lib/libssl.so.1.0.0
f64a1000 f64a3000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f64ab000 f64b2000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f64bb000 f64c2000 r-xp /lib/libcrypt-2.13.so
f64f3000 f64f6000 r-xp /lib/libcap.so.2.21
f64fe000 f6500000 r-xp /usr/lib/libiri.so
f6508000 f6551000 r-xp /usr/lib/libmdm.so.1.2.69
f6559000 f655f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6567000 f658a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6594000 f6596000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f659e000 f65bb000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f65c4000 f65c8000 r-xp /usr/lib/libsmack.so.1.0.0
f65d1000 f65ea000 r-xp /usr/lib/libnetwork.so.0.0.0
f65f3000 f65fb000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6603000 f6609000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6612000 f6614000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f661d000 f662d000 r-xp /lib/libresolv-2.13.so
f6631000 f6649000 r-xp /usr/lib/liblzma.so.5.0.3
f6652000 f6654000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f665c000 f6676000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f667e000 f66ad000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f66b6000 f66c5000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f66cf000 f66d9000 r-xp /usr/lib/libsensord-shared.so
f66e2000 f67b5000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f67c0000 f67d6000 r-xp /lib/libz.so.1.2.5
f67de000 f67e3000 r-xp /usr/lib/libffi.so.5.0.10
f67eb000 f67ec000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f67f4000 f6804000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f680c000 f6825000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f682d000 f682f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6837000 f68ac000 r-xp /usr/lib/libsqlite3.so.0.8.6
f68b6000 f68bc000 r-xp /lib/librt-2.13.so
f68c5000 f68e3000 r-xp /usr/lib/libsystemd.so.0.4.0
f68ed000 f68ee000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f68f6000 f6919000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6921000 f6926000 r-xp /usr/lib/libxdgmime.so.1.1.0
f692e000 f6958000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6961000 f6978000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6980000 f69e9000 r-xp /lib/libm-2.13.so
f69f2000 f6a86000 r-xp /usr/lib/libstdc++.so.6.0.16
f6a99000 f6a9e000 r-xp /usr/lib/libctx-client.so.0.8.3
f6aa6000 f6aad000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ab5000 f6adf000 r-xp /usr/lib/libsensor.so.1.9.6
f6ae8000 f6bb4000 r-xp /usr/lib/libxml2.so.2.7.8
f6bc1000 f6bc3000 r-xp /usr/lib/libiniparser.so.0
f6bcc000 f6bd2000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6bdb000 f6cab000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6cac000 f6ce0000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ce9000 f6d25000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6d2d000 f6d30000 r-xp /usr/lib/libbundle.so.0.1.22
f6d38000 f6d3e000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d46000 f6d87000 r-xp /usr/lib/libeina.so.1.7.99
f6d90000 f6da7000 r-xp /usr/lib/libecore.so.1.7.99
f6dbe000 f6dc7000 r-xp /usr/lib/libvconf.so.0.2.45
f6dcf000 f6de3000 r-xp /lib/libpthread-2.13.so
f6dee000 f6dfb000 r-xp /usr/lib/libaul.so.0.1.0
f6e05000 f6e07000 r-xp /lib/libdl-2.13.so
f6e10000 f6e1b000 r-xp /lib/libunwind.so.8.0.1
f6e48000 f6e50000 r-xp /lib/libgcc_s-4.6.so.1
f6e51000 f6f75000 r-xp /lib/libc-2.13.so
f6f83000 f6f85000 r-xp /usr/lib/libdlog.so.0.0.0
f6f8d000 f6f99000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6fa2000 f6fa7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6faf000 f6fbe000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f6fc6000 f6fca000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6fd3000 f6fd6000 r-xp /usr/lib/libappcore-agent.so.1.1
f6fde000 f6fe0000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f6fe8000 f6fec000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f6ff4000 f7011000 r-xp /lib/ld-2.13.so
f701a000 f701d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f701d000 f7021000 r-xp /usr/lib/libsys-assert.so
f76f9000 f777d000 rw-p [heap]
ffd85000 ffda6000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21631)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf701b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf6fb2539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6cb93f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6cb7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6cc3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6cc9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6cc9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6cfe75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6cf91f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6cb7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6cc3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6cc9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6cc9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6cfbe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6cfc017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6d03f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf469b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf468e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6761663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6c0efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6c107a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6da0ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6d9bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6d9c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6d9c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf6fd4183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf6fd47fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf701b4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6e6885c) [/lib/libc.so.6] + 0x1785c
29: (0xf701af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.419+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.429+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:431,2.316252,-1.241875,9.623933
04-23 19:46:41.429+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:428,0.161554,0.399920,0.301765
04-23 19:46:41.439+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.439+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.449+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.449+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.459+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:461,-20.650000,2.590000,2.660000
04-23 19:46:41.459+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.459+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:445,-0.153168,0.071533,0.144979
04-23 19:46:41.459+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:446,2.404787,-0.928415,9.755538
04-23 19:46:41.469+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.469+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.479+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:467,-43.959999,-0.350000,3.220000
04-23 19:46:41.489+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:481,-0.174977,-0.243814,0.106066
04-23 19:46:41.489+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:483,2.122434,-1.277767,9.588040
04-23 19:46:41.489+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.499+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:502,-0.144872,-0.633438,-0.055606
04-23 19:46:41.499+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.499+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:508,-0.200759,-0.547926,0.013125
04-23 19:46:41.509+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.509+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:515,2.163112,-1.679761,9.521042
04-23 19:46:41.509+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.519+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.519+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.519+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:527,-48.650002,-5.180000,3.710000
04-23 19:46:41.529+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:531,0.013383,-0.491721,0.025407
04-23 19:46:41.529+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.529+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:454,2.243232,-1.328335,9.453773
04-23 19:46:41.529+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.529+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.539+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:519,2.268396,-2.182254,9.322437
04-23 19:46:41.539+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:540,-0.047378,-0.540576,-0.029496
04-23 19:46:41.539+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:536,-33.529999,-1.610000,4.200000
04-23 19:46:41.539+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.539+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:539,2.275601,-1.349301,9.443062
04-23 19:46:41.539+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.539+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.539+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:548,2.338089,-1.435948,9.414976
04-23 19:46:41.539+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.549+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:552,2.413268,-1.548816,9.378043
04-23 19:46:41.549+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.549+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.559+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:546,2.256432,-2.194218,9.363115
04-23 19:46:41.559+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.559+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:561,-0.029449,-0.454553,-0.231485
04-23 19:46:41.559+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:549,-15.330000,-0.350000,4.760000
04-23 19:46:41.559+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:559,2.457191,-1.646292,9.349990
04-23 19:46:41.559+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.559+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.559+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:568,2.465581,-1.702497,9.337708
04-23 19:46:41.559+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.569+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:569,-6.440000,0.630000,4.970000
04-23 19:46:41.569+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:572,2.468914,-1.737391,9.330398
04-23 19:46:41.569+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.569+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.569+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:566,2.478964,-2.194218,9.363115
04-23 19:46:41.569+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.569+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:578,-0.114802,-0.744488,-0.360662
04-23 19:46:41.569+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.579+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:576,2.462949,-1.765987,9.326605
04-23 19:46:41.579+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.579+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:585,2.464554,-1.801476,9.319390
04-23 19:46:41.579+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.589+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:579,2.421536,-2.277967,9.300901
04-23 19:46:41.589+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.589+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:590,2.476601,-1.857434,9.305202
04-23 19:46:41.589+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:583,-2.310000,1.400000,4.340000
04-23 19:46:41.589+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.589+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.589+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:46:41.589+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:46:41.589+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:598,0.035863,-0.176465,0.184733
04-23 19:46:41.589+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.599+0200 I/heartrate(21618): capturing data from es.ugr.frailty.heartrate
04-23 19:46:41.599+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:602,2.470523,-1.857484,9.306807
04-23 19:46:41.599+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:595,2.433501,-2.220540,9.095119
04-23 19:46:41.599+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.599+0200 I/heartrate(21618): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:46:41:605,80
04-23 19:46:41.599+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:607,2.349752,-2.545963,8.958728
04-23 19:46:41.599+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.599+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:601,-7.140000,2.800000,3.850000
04-23 19:46:41.609+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.609+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:611,2.512464,-2.033899,9.489935
04-23 19:46:41.609+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:614,-10.290000,-0.490000,0.700000
04-23 19:46:41.609+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.609+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:618,3.360000,-0.420000,1.610000
04-23 19:46:41.619+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.619+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.619+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.619+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:625,-0.173413,0.182508,0.018023
04-23 19:46:41.619+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:626,2.447908,-1.830826,9.318058
04-23 19:46:41.619+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.629+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:623,9.590000,0.420000,2.100000
04-23 19:46:41.629+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:630,2.297110,-1.674976,9.324830
04-23 19:46:41.629+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.639+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:46:41.639+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:46:41.639+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:46:41.649+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:640,2.439592,-1.826054,9.321175
04-23 19:46:41.649+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.649+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.649+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.659+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:658,-0.107728,0.055351,-0.038692
04-23 19:46:41.659+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.659+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.659+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:664,-0.164017,-0.667267,0.269258
04-23 19:46:41.669+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:661,2.423790,-1.857750,9.319034
04-23 19:46:41.669+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:655,2.170000,-0.560000,3.150000
04-23 19:46:41.669+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:665,2.340181,-1.775474,9.279366
04-23 19:46:41.669+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.669+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.669+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.669+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:677,0.033639,-0.214434,0.362327
04-23 19:46:41.669+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.669+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:675,2.275574,-2.493321,9.590433
04-23 19:46:41.669+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.679+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:681,2.423960,-1.883142,9.313891
04-23 19:46:41.679+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:681,2.457429,-2.072184,9.681360
04-23 19:46:41.679+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:676,-2.240000,1.540000,5.810000
04-23 19:46:41.679+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.689+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:691,-9.450000,2.520000,5.460000
04-23 19:46:41.689+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.689+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.689+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:698,-0.363740,0.557519,0.769464
04-23 19:46:41.689+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:699,2.060220,-1.325624,10.083356
04-23 19:46:41.689+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.699+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.699+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:702,2.438946,-1.891675,9.308249
04-23 19:46:41.699+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:703,-13.580000,-11.620000,8.960000
04-23 19:46:41.709+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.719+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.719+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.719+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:722,-0.474439,-0.101546,0.502325
04-23 19:46:41.719+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:726,2.401541,-1.868273,9.322690
04-23 19:46:41.719+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.729+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:724,1.964507,-1.993221,9.810574
04-23 19:46:41.729+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:731,17.990000,-9.520000,9.800000
04-23 19:46:41.729+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.729+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.739+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.739+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:740,-0.221680,0.501971,0.116996
04-23 19:46:41.739+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.739+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:740,2.342885,-1.772495,9.356256
04-23 19:46:41.739+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:743,2.179861,-1.366302,9.439686
04-23 19:46:41.739+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:745,39.270000,-3.080000,12.180000
04-23 19:46:41.749+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.749+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.749+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.759+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:761,0.401683,0.544977,-0.445385
04-23 19:46:41.759+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.759+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:761,2.744568,-1.227518,8.910872
04-23 19:46:41.759+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:758,2.342242,-1.712169,9.367644
04-23 19:46:41.759+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:765,22.400000,-4.690000,10.010000
04-23 19:46:41.769+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.769+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.769+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.769+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:778,0.646394,-0.075269,-0.600343
04-23 19:46:41.779+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.779+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:778,2.409388,-1.774314,9.339006
04-23 19:46:41.779+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:783,-24.080000,-2.520000,7.840000
04-23 19:46:41.779+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:778,2.988636,-1.787439,8.767302
04-23 19:46:41.789+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.789+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.789+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:46:41.789+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:46:41.799+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.799+0200 I/heartrate(21618): capturing data from es.ugr.frailty.heartrate
04-23 19:46:41.799+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:800,0.325608,-0.931969,-0.464027
04-23 19:46:41.799+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.799+0200 I/heartrate(21618): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:46:41:806,80
04-23 19:46:41.799+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:807,-38.779999,4.690000,4.410000
04-23 19:46:41.809+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:799,2.734996,-2.706282,8.874979
04-23 19:46:41.809+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:803,2.467366,-1.894997,9.300079
04-23 19:46:41.819+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.819+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.819+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:824,2.359323,-3.737589,9.413363
04-23 19:46:41.819+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:825,-0.108042,-1.842591,0.113284
04-23 19:46:41.819+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.819+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.829+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:829,2.467413,-1.976422,9.283104
04-23 19:46:41.829+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:833,-6.300000,2.450000,0.420000
04-23 19:46:41.829+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.829+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.829+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.839+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:842,-0.170303,-1.100748,0.175723
04-23 19:46:41.839+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.839+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:840,2.297110,-3.077170,9.458827
04-23 19:46:41.839+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:841,2.410853,-1.941425,9.305324
04-23 19:46:41.839+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:847,36.750000,3.640000,-5.600000
04-23 19:46:41.849+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.849+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.849+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.859+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.859+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:860,-0.238170,0.321484,0.203753
04-23 19:46:41.859+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:864,2.351290,-1.840190,9.341066
04-23 19:46:41.859+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:859,40.389999,1.820000,-6.790000
04-23 19:46:41.869+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:860,2.172683,-1.619941,9.509077
04-23 19:46:41.869+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.869+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.879+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.899+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:878,-0.087680,0.548066,-0.140664
04-23 19:46:41.909+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.909+0200 W/LOCATION(21631): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:46:41.919+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:879,2.342996,-1.786794,9.353509
04-23 19:46:41.919+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.929+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.929+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:883,13.650000,-2.730000,-5.740000
04-23 19:46:41.929+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:933,2.361434,-1.776442,9.350843
04-23 19:46:41.929+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.939+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:933,0.109648,0.317601,-0.093286
04-23 19:46:41.939+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:941,2.336063,-1.744960,9.363135
04-23 19:46:41.939+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.939+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.939+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:932,2.263610,-1.292124,9.200402
04-23 19:46:41.939+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:947,2.279973,-1.651502,9.393863
04-23 19:46:41.949+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.949+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.949+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.959+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:961,2.252146,-1.594417,9.410422
04-23 19:46:41.959+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:947,-1.890000,-3.360000,-4.900000
04-23 19:46:41.969+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.969+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:961,2.452643,-1.469193,9.260223
04-23 19:46:41.969+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.969+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.969+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:963,0.093602,-0.494347,0.031414
04-23 19:46:41.969+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:974,25.129999,0.210000,-4.690000
04-23 19:46:41.979+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.979+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:979,2.244740,-1.559485,9.418043
04-23 19:46:41.979+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:41.979+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:974,2.455036,-2.270789,9.382257
04-23 19:46:41.989+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:41.989+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:41.989+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:41:983,0.111794,0.263802,0.119620
04-23 19:46:41.989+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:46:41.989+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:46:41.989+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:41.999+0200 I/heartrate(21618): capturing data from es.ugr.frailty.heartrate
04-23 19:46:41.999+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:41:991,35.700001,8.260000,-3.710000
04-23 19:46:41.999+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:41:999,2.237299,-1.519255,9.426385
04-23 19:46:41.999+0200 I/heartrate(21618): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:46:42:5,80
04-23 19:46:42.009+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:41:994,2.447858,-1.481157,9.482756
04-23 19:46:42.009+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:42:3,0.036280,0.385698,0.684707
04-23 19:46:42.009+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:42.009+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:42.009+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:42:17,15.750000,1.960000,-1.330000
04-23 19:46:42.009+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:42:17,2.316252,-1.265803,10.078569
04-23 19:46:42.019+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:42.019+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:42.019+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:42.019+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:42:28,2.223266,-1.482221,9.435597
04-23 19:46:42.029+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:42.029+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:42:33,10.080000,-2.100000,0.840000
04-23 19:46:42.029+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:42:33,2.407180,-1.330409,9.903893
04-23 19:46:42.029+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:42.029+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:42:26,0.155033,0.264007,0.493471
04-23 19:46:42.029+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:42.039+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:42.039+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:42:40,2.176277,-1.399557,9.459146
04-23 19:46:42.039+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:42.049+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:42:41,0.195939,0.219505,0.280067
04-23 19:46:42.049+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:42.049+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:42:47,15.050000,-3.850000,1.400000
04-23 19:46:42.049+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:42.059+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:42.069+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:42:57,0.244058,-0.225113,-0.415015
04-23 19:46:42.069+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:42.069+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:42:66,2.146780,-1.343745,9.473968
04-23 19:46:42.069+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:42:65,26.389999,-3.500000,2.310000
04-23 19:46:42.069+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:42.069+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:42:50,2.440679,-1.339981,9.698111
04-23 19:46:42.069+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:42.079+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:42.079+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:42:76,0.186306,0.223596,-0.261516
04-23 19:46:42.079+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:42:81,2.139673,-1.310497,9.480231
04-23 19:46:42.079+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:42:86,34.299999,4.480000,1.330000
04-23 19:46:42.089+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:42.089+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:42:83,2.481357,-1.744368,9.011370
04-23 19:46:42.089+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:42.089+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:42.089+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:42.089+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:42:99,2.153865,-1.316864,9.476134
04-23 19:46:42.099+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:42:95,2.409572,-1.258625,9.174082
04-23 19:46:42.099+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:42.099+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:42:95,0.297902,0.138540,0.052324
04-23 19:46:42.099+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:42.099+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:42:102,21.700001,4.760000,-0.280000
04-23 19:46:42.099+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:42:105,2.474179,-1.261017,9.511470
04-23 19:46:42.099+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:42.109+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:42.109+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:42:109,2.543570,-1.071985,9.705289
04-23 19:46:42.109+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:42.109+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:42:109,0.396790,0.271761,0.231321
04-23 19:46:42.109+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:42:114,2.438286,-1.268196,9.504292
04-23 19:46:42.109+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:42.109+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:42:114,7.420000,4.200000,-0.210000
04-23 19:46:42.119+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:42.119+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:42.119+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:42.129+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:42:127,2.166687,-1.325685,9.471980
04-23 19:46:42.129+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:42:132,2.474179,-1.368695,9.466006
04-23 19:46:42.129+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:42.129+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:42:132,-5.180000,2.240000,-0.280000
04-23 19:46:42.129+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:42.139+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:42.139+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:42:140,2.162036,-1.320037,9.473832
04-23 19:46:42.139+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:42:119,0.298614,0.042301,0.024060
04-23 19:46:42.139+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:42.139+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:42:144,-4.130000,2.870000,0.350000
04-23 19:46:42.139+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:42:146,0.320314,-0.051831,-0.010128
04-23 19:46:42.139+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:42.149+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:42:149,0.082566,0.055096,0.087346
04-23 19:46:42.149+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:42:143,2.249253,-1.270589,9.559326
04-23 19:46:42.149+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:42.149+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:42.149+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:42.159+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:42:160,2.155334,-1.304270,9.477542
04-23 19:46:42.159+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:42.159+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:42:165,0.070000,3.150000,0.280000
04-23 19:46:42.159+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:42.159+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:42:160,2.409572,-1.277767,9.489935
04-23 19:46:42.159+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:42:159,0.247537,0.042269,0.016103
04-23 19:46:42.169+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:42:169,5.180000,4.060000,0.280000
04-23 19:46:42.169+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:42.169+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:42.169+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:42:178,0.249453,0.227499,0.108105
04-23 19:46:42.169+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:42:178,2.404787,-1.076770,9.585647
04-23 19:46:42.169+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:42.169+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:42.179+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:42:183,7.070000,5.040000,0.280000
04-23 19:46:42.179+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:42:182,2.142441,-1.274610,9.484498
04-23 19:46:42.189+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:42.189+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:42.189+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:46:42.189+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:46:42.189+0200 I/servicemanager(21592): es.ugr.frailty.location sleep timeout
04-23 19:46:42.189+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 19:46:42.189+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:42:198,0.240810,0.401230,0.113113
04-23 19:46:42.189+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:46:42.189+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:42.199+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 21592
04-23 19:46:42.199+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:42:202,2.154992,-1.266287,9.482769
04-23 19:46:42.199+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:42:199,2.383251,-0.873380,9.597611
04-23 19:46:42.199+0200 I/heartrate(21618): capturing data from es.ugr.frailty.heartrate
04-23 19:46:42.199+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21631
04-23 19:46:42.209+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21631)
04-23 19:46:42.209+0200 I/servicemanager(21592): es.ugr.frailty.location stop request sent!
04-23 19:46:42.209+0200 I/servicemanager(21592): App control destroyed.
04-23 19:46:42.209+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:42.209+0200 I/heartrate(21618): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:46:42:210,80
04-23 19:46:42.219+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:42.219+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:42.219+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:42:224,0.161260,-0.391939,0.052629
04-23 19:46:42.219+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:42:228,2.316252,-1.658226,9.535398
04-23 19:46:42.219+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:42.229+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:42:232,2.170399,-1.294556,9.475435
04-23 19:46:42.229+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:42.229+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:42:220,-6.440000,2.380000,1.120000
04-23 19:46:42.229+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:42.239+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:42.239+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:42.239+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:42:240,0.145853,-0.198565,0.155676
04-23 19:46:42.249+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:42.249+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:42:244,2.154377,-1.279529,9.481132
04-23 19:46:42.249+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:42.249+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:42:244,2.316252,-1.493121,9.631111
04-23 19:46:42.259+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:42.259+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:42:259,0.054199,0.214723,0.138016
04-23 19:46:42.259+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:42:242,-4.760000,-0.700000,1.330000
04-23 19:46:42.259+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:42.269+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:42.269+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:42:264,2.208575,-1.064806,9.619147
04-23 19:46:42.269+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:42:267,2.143579,-1.253438,9.487062
04-23 19:46:42.269+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:42.269+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:42.279+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:42:279,0.258815,-0.062614,0.108156
04-23 19:46:42.279+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:42:283,2.402394,-1.316052,9.595219
04-23 19:46:42.279+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:42:267,10.850000,1.680000,1.050000
04-23 19:46:42.279+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:42.289+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:42.289+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:42:282,2.156767,-1.258567,9.483394
04-23 19:46:42.299+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:42.299+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:42:299,0.319805,0.126762,-0.089171
04-23 19:46:42.299+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:42.299+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:42:288,7.350000,-0.280000,1.050000
04-23 19:46:42.299+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:42.299+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:42:307,-1.120000,-1.050000,0.630000
04-23 19:46:42.329+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:42.329+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:42:336,0.096182,-0.155568,0.160818
04-23 19:46:42.339+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:42.349+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:42.349+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:42:306,2.172213,-1.258590,9.479864
04-23 19:46:42.349+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:42:303,2.476572,-1.131805,9.394222
04-23 19:46:42.349+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:42.359+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:42:345,0.141761,0.091711,0.071159
04-23 19:46:42.359+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:42:360,-3.080000,1.330000,0.770000
04-23 19:46:42.359+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:42.359+0200 I/gravity (21647): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:42:368,2.174491,-1.264194,9.478596
04-23 19:46:42.369+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:42.369+0200 E/AUL_AMD ( 2478): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 19:46:42.369+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 19:46:42.369+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(21631), cmd(0)
04-23 19:46:42.379+0200 W/libgps_d( 3158): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 19:46:42.379+0200 W/libgps  ( 3158): [proxy__gps_stop][line = 1067]: called.
04-23 19:46:42.379+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:46:42.379+0200 W/libgps_d( 3158): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 19:46:42.379+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 19:46:42.389+0200 W/libgps_d( 3158): GpsiHookStateGps              : EXIT
04-23 19:46:42.389+0200 W/libgps_d( 3158): GpsiHookStateIdle             : ENTRY
04-23 19:46:42.389+0200 E/CAPI_LOCATION_MANAGER(21673): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 19:46:42.389+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:0, msg id:2
04-23 19:46:42.389+0200 W/AUL     (21685): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 19:46:42.389+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 19:46:42.389+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 19:46:42.389+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20970
04-23 19:46:42.389+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 19:46:42.389+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:46:42.389+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:46:42.399+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20970
04-23 19:46:42.399+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20970)
04-23 19:46:42.399+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:46:42.409+0200 I/heartrate(21618): capturing data from es.ugr.frailty.heartrate
04-23 19:46:42.409+0200 I/heartrate(21618): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:46:42:413,79
04-23 19:46:42.409+0200 I/linearacceleration(21644): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:42:387,0.157811,0.252123,0.059791
04-23 19:46:42.409+0200 I/gyroscope(21607): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:42.419+0200 I/gravity (21647): capturing data from es.ugr.frailty.gravity
04-23 19:46:42.419+0200 I/accelerometer(21604): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:42:372,2.268396,-1.414158,9.640682
04-23 19:46:42.419+0200 I/accelerometer(21604): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:42.429+0200 I/linearacceleration(21644): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:42.429+0200 I/gyroscope(21607): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:42:420,0.490000,-0.420000,0.700000
04-23 19:46:42.469+0200 W/CRASH_MANAGER(21684): worker.c: worker_job(1205) > 11216316c6f63152450560
