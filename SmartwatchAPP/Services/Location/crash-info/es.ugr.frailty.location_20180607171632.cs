S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 19088
Date: 2018-06-07 17:16:32+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70d052d, r5   = 0xf72daf98
r6   = 0xffd06db0, r7   = 0xffd06c60
r8   = 0xf72d7c18, r9   = 0x00000000
r10  = 0xffd06d3c, fp   = 0xffd06db0
ip   = 0x00000001, sp   = 0xffd06c38
lr   = 0xf70d0539, pc   = 0xf7139228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    185308 KB
Buffers:      7876 KB
Cached:      51648 KB
VmPeak:      53608 KB
VmSize:      53464 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11940 KB
VmRSS:       11936 KB
VmData:      11192 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 19088 TID = 19088
19088 19093 

Maps Information
f3f9b000 f479a000 rw-p [stack:19093]
f47a1000 f47a3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f47ab000 f47af000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f47b8000 f47ba000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f47c2000 f47c5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47d4000 f47d9000 r-xp /usr/lib/libsystem.so.0.0.0
f47e4000 f47e7000 r-xp /lib/libattr.so.1.1.0
f47ef000 f47ff000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4807000 f4810000 r-xp /usr/lib/libedbus.so.1.7.99
f4818000 f4819000 r-xp /usr/lib/libresponse.so.0.2.96
f4822000 f4827000 r-xp /usr/lib/libproc-stat.so.0.2.96
f60c9000 f61cf000 r-xp /usr/lib/libicuuc.so.57.1
f61e5000 f636d000 r-xp /usr/lib/libicui18n.so.57.1
f637d000 f638a000 r-xp /usr/lib/libail.so.0.1.0
f6393000 f639a000 r-xp /usr/lib/libminizip.so.1.0.0
f63a3000 f654c000 r-xp /usr/lib/libcrypto.so.1.0.0
f656c000 f65b3000 r-xp /usr/lib/libssl.so.1.0.0
f65bf000 f65c1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f65c9000 f65d0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65d9000 f65e0000 r-xp /lib/libcrypt-2.13.so
f6611000 f6614000 r-xp /lib/libcap.so.2.21
f661c000 f661e000 r-xp /usr/lib/libiri.so
f6626000 f666f000 r-xp /usr/lib/libmdm.so.1.2.69
f6677000 f667d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6685000 f66a8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f66b2000 f66b4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f66bc000 f66d9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66e2000 f66e6000 r-xp /usr/lib/libsmack.so.1.0.0
f66ef000 f6708000 r-xp /usr/lib/libnetwork.so.0.0.0
f6711000 f6719000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6721000 f6727000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6730000 f6732000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f673b000 f674b000 r-xp /lib/libresolv-2.13.so
f674f000 f6767000 r-xp /usr/lib/liblzma.so.5.0.3
f6770000 f6772000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f677a000 f6794000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f679c000 f67cb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67d4000 f67e3000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67ed000 f67f7000 r-xp /usr/lib/libsensord-shared.so
f6800000 f68d3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68de000 f68f4000 r-xp /lib/libz.so.1.2.5
f68fc000 f6901000 r-xp /usr/lib/libffi.so.5.0.10
f6909000 f690a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6912000 f6922000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f692a000 f6943000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f694b000 f694d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6955000 f69ca000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69d4000 f69da000 r-xp /lib/librt-2.13.so
f69e3000 f6a01000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a0b000 f6a0c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a14000 f6a37000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a3f000 f6a44000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a4c000 f6a76000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a7f000 f6a96000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a9e000 f6b07000 r-xp /lib/libm-2.13.so
f6b10000 f6ba4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6bb7000 f6bbc000 r-xp /usr/lib/libctx-client.so.0.8.3
f6bc4000 f6bcb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6bd3000 f6bfd000 r-xp /usr/lib/libsensor.so.1.9.6
f6c06000 f6cd2000 r-xp /usr/lib/libxml2.so.2.7.8
f6cdf000 f6ce1000 r-xp /usr/lib/libiniparser.so.0
f6cea000 f6cf0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6cf9000 f6dc9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6dca000 f6dfe000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e07000 f6e43000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e4b000 f6e4e000 r-xp /usr/lib/libbundle.so.0.1.22
f6e56000 f6e5c000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e64000 f6ea5000 r-xp /usr/lib/libeina.so.1.7.99
f6eae000 f6ec5000 r-xp /usr/lib/libecore.so.1.7.99
f6edc000 f6ee5000 r-xp /usr/lib/libvconf.so.0.2.45
f6eed000 f6f01000 r-xp /lib/libpthread-2.13.so
f6f0c000 f6f19000 r-xp /usr/lib/libaul.so.0.1.0
f6f23000 f6f25000 r-xp /lib/libdl-2.13.so
f6f2e000 f6f39000 r-xp /lib/libunwind.so.8.0.1
f6f66000 f6f6e000 r-xp /lib/libgcc_s-4.6.so.1
f6f6f000 f7093000 r-xp /lib/libc-2.13.so
f70a1000 f70a3000 r-xp /usr/lib/libdlog.so.0.0.0
f70ab000 f70b7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f70c0000 f70c5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70cd000 f70dc000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70e4000 f70e8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70f1000 f70f4000 r-xp /usr/lib/libappcore-agent.so.1.1
f70fc000 f70fe000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7106000 f710a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7112000 f712f000 r-xp /lib/ld-2.13.so
f7138000 f713b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f713b000 f713f000 r-xp /usr/lib/libsys-assert.so
f72a7000 f731a000 rw-p [heap]
ffce8000 ffd09000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19088)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7139228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf70d0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6dd73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6dd5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6de1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6de7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6de7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e1c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e171f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6dd5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6de1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6de7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6de7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e19e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e1a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e21f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47b91fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf47ac171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf687f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d2cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d2e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6ebeca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6eb9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6eba5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6eba879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70f2183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70f27fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71395c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6f8685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7138f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
frailty.accelerometer: SM-R760,07/06/2018,17:16:32:106,0.282353,-0.023928,9.705289
06-07 17:16:32.101+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:32.101+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:32.101+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:32.111+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:32:114,-0.014331,-0.007276,0.037723
06-07 17:16:32.111+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:32.111+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:32:115,0.302745,-0.086104,9.801598
06-07 17:16:32.121+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:32:112,0.349352,-0.088534,9.934999
06-07 17:16:32.121+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:32.121+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:32:123,0.140000,-0.070000,0.070000
06-07 17:16:32.121+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:32.121+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:32.121+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:32.131+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:32:133,0.301591,-0.088330,9.801614
06-07 17:16:32.131+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:32:131,-0.008428,-0.057466,0.032904
06-07 17:16:32.131+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:32:135,0.210000,0.070000,0.070000
06-07 17:16:32.141+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:32:130,0.267996,-0.122034,9.875179
06-07 17:16:32.141+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:32.141+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:32.141+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:32.141+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:32.151+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:32:155,0.301992,-0.091219,9.801575
06-07 17:16:32.151+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:32:152,0.011869,-0.067204,0.097493
06-07 17:16:32.151+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:32:152,0.070000,0.070000,0.070000
06-07 17:16:32.151+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:32:148,0.289532,-0.093320,9.839286
06-07 17:16:32.151+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:32.161+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:32:165,0.294317,-0.143569,9.834501
06-07 17:16:32.161+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:32.161+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:32.161+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:32.161+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:32:171,0.001897,0.026612,0.078389
06-07 17:16:32.171+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:32:175,0.301536,-0.089734,9.801602
06-07 17:16:32.171+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:32:171,0.070000,0.070000,0.070000
06-07 17:16:32.171+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:32.181+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:32:181,0.313460,-0.155533,9.899107
06-07 17:16:32.181+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:32.181+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:32.181+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:32.181+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:32.181+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:32:191,0.002353,0.027521,0.040077
06-07 17:16:32.191+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:32:195,0.301145,-0.088221,9.801628
06-07 17:16:32.191+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:32:192,0.070000,0.070000,0.070000
06-07 17:16:32.191+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:32:187,0.303888,-0.064606,9.879964
06-07 17:16:32.191+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:32.201+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:32:203,0.303888,-0.062213,9.841680
06-07 17:16:32.201+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:32.201+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:32.201+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:32.211+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:32:215,0.301853,-0.087718,9.801611
06-07 17:16:32.211+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:32:212,0.026672,0.006865,0.037658
06-07 17:16:32.211+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:32:212,0.070000,0.070000,0.070000
06-07 17:16:32.211+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:32.221+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:32:222,0.327817,-0.081356,9.839286
06-07 17:16:32.221+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:16:32.221+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:32.231+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:32.231+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:32.231+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:32:236,0.073820,0.003970,0.099890
06-07 17:16:32.231+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:32:233,0.070000,0.070000,0.070000
06-07 17:16:32.231+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:32:239,0.304477,-0.087381,9.801533
06-07 17:16:32.231+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:16:32:232,1080.000000
06-07 17:16:32.241+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:32.241+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:32.241+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:32.241+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:32.251+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:32:248,0.375673,-0.083749,9.901501
06-07 17:16:32.251+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:16:32.251+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:16:32.251+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:32.251+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:32:252,0.035304,-0.020296,0.004254
06-07 17:16:32.251+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:32:254,0.305792,-0.088162,9.801485
06-07 17:16:32.251+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:32:252,0.070000,0.070000,0.070000
06-07 17:16:32.261+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:32:264,0.339781,-0.107677,9.805787
06-07 17:16:32.261+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:32.261+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:32.271+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:32.271+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:32:276,0.306474,-0.089177,9.801455
06-07 17:16:32.271+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:32:273,0.026810,-0.026693,0.080873
06-07 17:16:32.271+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:32:273,0.070000,0.140000,0.070000
06-07 17:16:32.271+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:32.281+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:32:283,0.332602,-0.114855,9.882358
06-07 17:16:32.281+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:32.281+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:32.281+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:32:291,0.040485,-0.037643,0.049797
06-07 17:16:32.281+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:32:291,0.070000,0.140000,0.070000
06-07 17:16:32.281+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:32.391+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:32.401+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:32:307,0.307946,-0.090703,9.801394
06-07 17:16:32.401+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:32.401+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:32.401+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:32.421+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:16:32.451+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:16:32.451+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:16:32.451+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:32:408,0.007907,-0.016974,0.068999
06-07 17:16:32.451+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:32:412,0.346959,-0.126820,9.851252
06-07 17:16:32.451+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:32:414,0.307845,-0.091300,9.801392
06-07 17:16:32.451+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:32.461+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:32.461+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:32.461+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:16:32:435,1064.000000
06-07 17:16:32.471+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:32:418,0.070000,0.070000,0.070000
06-07 17:16:32.501+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:32:505,0.307576,-0.090935,9.801404
06-07 17:16:32.501+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:32.511+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:32:484,0.315853,-0.107677,9.870394
06-07 17:16:32.511+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:32:471,0.010400,0.000373,0.054645
06-07 17:16:32.511+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:32.511+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:32.511+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:32.521+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:32:511,0.140000,0.070000,0.070000
06-07 17:16:32.541+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:32.551+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:32:523,-0.020438,0.031114,-0.002795
06-07 17:16:32.551+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:32.561+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:32:544,0.306014,-0.089086,9.801470
06-07 17:16:32.571+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:32:538,0.318245,-0.090927,9.856036
06-07 17:16:32.571+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:32.571+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:32.581+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:32:560,0.140000,0.070000,0.070000
06-07 17:16:32.581+0200 W/LOCATION(19088): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:16:32.591+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:32.601+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:32:562,-0.011696,-0.011412,0.088066
06-07 17:16:32.601+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:32.621+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:32:617,0.036443,0.037134,0.104815
06-07 17:16:32.621+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:32:587,0.287139,-0.059821,9.798609
06-07 17:16:32.621+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:32.621+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:16:32.621+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:32:590,0.305731,-0.089776,9.801472
06-07 17:16:32.631+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:32.641+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:32:613,-0.070000,-0.070000,0.070000
06-07 17:16:32.641+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:32.651+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:32:632,0.294317,-0.100499,9.889536
06-07 17:16:32.651+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:32:640,0.306621,-0.087848,9.801461
06-07 17:16:32.651+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:32.661+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:16:32.661+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:16:32.661+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:16:32:633,999.000000
06-07 17:16:32.661+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:32.671+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:32.671+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:32:679,0.342174,-0.052642,9.906286
06-07 17:16:32.681+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:32:673,-0.024268,0.025635,0.018683
06-07 17:16:32.681+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:32.681+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:32:647,0.070000,0.070000,0.070000
06-07 17:16:32.681+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:32.681+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:32:687,0.018189,-0.007065,0.073648
06-07 17:16:32.691+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:32.711+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:32.711+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:32:697,0.056393,0.074265,0.150221
06-07 17:16:32.711+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:32:663,0.304842,-0.086255,9.801531
06-07 17:16:32.711+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:32.711+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:32.721+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:32:690,0.140000,0.070000,-0.070000
06-07 17:16:32.721+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:32:719,0.013730,-0.038971,0.085649
06-07 17:16:32.721+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:32.721+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:32.731+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:32:733,0.039076,-0.020194,-0.010015
06-07 17:16:32.731+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:32:722,0.282353,-0.062213,9.820145
06-07 17:16:32.731+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:32:726,0.304923,-0.086229,9.801529
06-07 17:16:32.741+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:32.741+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:32.741+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:32.751+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:32:748,-0.004063,0.002440,0.040320
06-07 17:16:32.751+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:32.751+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:32:733,0.140000,0.070000,-0.070000
06-07 17:16:32.751+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:32.751+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:32:753,0.323031,-0.093320,9.875179
06-07 17:16:32.761+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:32:757,0.006041,-0.043373,0.092942
06-07 17:16:32.761+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:32.771+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:32:771,-0.016275,-0.038744,0.071452
06-07 17:16:32.771+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:32.781+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:32:756,0.306908,-0.083063,9.801495
06-07 17:16:32.781+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:32.791+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:32.791+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:32:769,-0.140000,0.140000,-0.070000
06-07 17:16:32.801+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:32.801+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:32:802,0.307884,-0.085090,9.801446
06-07 17:16:32.801+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:32:795,0.361316,-0.011964,9.951750
06-07 17:16:32.811+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:32.811+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:32:809,-0.140000,0.140000,-0.350000
06-07 17:16:32.821+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:32.821+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:32:822,0.320638,-0.122034,9.887143
06-07 17:16:32.821+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:32.831+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:32.841+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:32:831,0.310344,-0.086188,9.801359
06-07 17:16:32.851+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:32.851+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:32:840,-0.070000,-0.070000,-0.770000
06-07 17:16:32.851+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:32:858,0.309812,-0.085839,9.801379
06-07 17:16:32.861+0200 I/servicemanager(17973): es.ugr.frailty.accelerometer alive timeout
06-07 17:16:32.861+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:16:32.861+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:32.861+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:32:852,0.346959,-0.105284,9.791430
06-07 17:16:32.861+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:32:869,0.070000,0.070000,-1.120000
06-07 17:16:32.871+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:32.871+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:32:877,0.306281,-0.083749,9.841680
06-07 17:16:32.871+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:32.871+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:32.881+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:32.891+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19019
06-07 17:16:32.891+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:32.891+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19019)
06-07 17:16:32.891+0200 I/servicemanager(17973): es.ugr.frailty.accelerometer launch request sent!
06-07 17:16:32.891+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:32.891+0200 I/servicemanager(17973): es.ugr.frailty.gyroscope alive timeout
06-07 17:16:32.891+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:16:32.891+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:32.891+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:32.891+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:32:892,0.310592,-0.088076,9.801334
06-07 17:16:32.901+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:32.901+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:32:899,-0.140000,0.070000,-0.840000
06-07 17:16:32.911+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19004
06-07 17:16:32.911+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:32.911+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19004)
06-07 17:16:32.911+0200 I/servicemanager(17973): es.ugr.frailty.gyroscope launch request sent!
06-07 17:16:32.911+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:32.911+0200 I/servicemanager(17973): es.ugr.frailty.heartrate alive timeout
06-07 17:16:32.911+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:16:32.911+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:32.911+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:32.921+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:32.921+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:32:911,0.315853,-0.129212,9.894321
06-07 17:16:32.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18034
06-07 17:16:32.931+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:16:32.931+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:16:32.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(18034), cmd(0)
06-07 17:16:32.931+0200 W/CAPI_APPFW_APP_CONTROL(18034): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:16:32.931+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18034)
06-07 17:16:32.941+0200 I/utils   (18034): specific action
06-07 17:16:32.941+0200 I/servicemanager(17973): es.ugr.frailty.heartrate launch request sent!
06-07 17:16:32.941+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:32.941+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:16:32.941+0200 I/servicemanager(17973): es.ugr.frailty.location alive timeout
06-07 17:16:32.941+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:16:32.941+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:16:32.941+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:16:32:939,1213.000000
06-07 17:16:32.941+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:32.941+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:32.941+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:32.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19088
06-07 17:16:32.951+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19088)
06-07 17:16:32.951+0200 I/servicemanager(17973): es.ugr.frailty.location launch request sent!
06-07 17:16:32.951+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:32.951+0200 I/servicemanager(17973): es.ugr.frailty.linearacceleration alive timeout
06-07 17:16:32.951+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:16:32.961+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:32.961+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:32.961+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:32:918,0.310027,-0.089960,9.801335
06-07 17:16:32.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19049
06-07 17:16:32.971+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:32:932,-0.070000,0.070000,-1.610000
06-07 17:16:32.971+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19049)
06-07 17:16:32.971+0200 I/servicemanager(17973): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:16:32.971+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:32.971+0200 I/servicemanager(17973): es.ugr.frailty.gravity alive timeout
06-07 17:16:32.971+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:16:32.981+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:32.981+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:32.981+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:32.981+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:32:783,0.005825,-0.036859,0.061880
06-07 17:16:32.991+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:32.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19031
06-07 17:16:32.991+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:32.991+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19031)
06-07 17:16:32.991+0200 I/servicemanager(17973): es.ugr.frailty.gravity launch request sent!
06-07 17:16:32.991+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:32.991+0200 I/servicemanager(17973): es.ugr.frailty.pressure alive timeout
06-07 17:16:32.991+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:16:32.991+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:33.001+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:33.011+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18075
06-07 17:16:33.011+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18075)
06-07 17:16:33.011+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:16:33.011+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(18075), cmd(0)
06-07 17:16:33.011+0200 I/servicemanager(17973): es.ugr.frailty.pressure launch request sent!
06-07 17:16:33.011+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:33.011+0200 I/servicemanager(17973): es.ugr.frailty.light alive timeout
06-07 17:16:33.011+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:16:33.021+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:32:965,0.294317,-0.126820,9.872787
06-07 17:16:33.021+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:33.021+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:33.021+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:16:33.031+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18079
06-07 17:16:33.031+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18079)
06-07 17:16:33.031+0200 I/servicemanager(17973): es.ugr.frailty.light launch request sent!
06-07 17:16:33.031+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:33.031+0200 I/servicemanager(17973): es.ugr.frailty.pedometer alive timeout
06-07 17:16:33.031+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:16:33.031+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:16:33:34,1211.000000
06-07 17:16:33.031+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:33.031+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:33.041+0200 W/CAPI_APPFW_APP_CONTROL(18079): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:16:33.041+0200 I/utils   (18079): specific action
06-07 17:16:33.041+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:4,0.283011,-0.023134,0.073873
06-07 17:16:33.051+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:33.061+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:16:33.061+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:16:33.061+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:33:65,0.315853,-0.126820,9.863215
06-07 17:16:33.061+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18111
06-07 17:16:33.071+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:16:33.071+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(18079), cmd(0)
06-07 17:16:33.071+0200 W/CAPI_APPFW_APP_CONTROL(18111): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:16:33.071+0200 I/utils   (18111): specific action
06-07 17:16:33.071+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:32:991,0.310409,-0.091722,9.801307
06-07 17:16:33.071+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:16:33.071+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(15), pid(18111), cmd(0)
06-07 17:16:33.071+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:33.071+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:33:17,-0.070000,0.140000,-1.190000
06-07 17:16:33.071+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:16:33.071+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:16:33.071+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:16:33.071+0200 W/CAPI_APPFW_APP_CONTROL(18075): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:16:33.071+0200 I/utils   (18075): specific action
06-07 17:16:33.071+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18111)
06-07 17:16:33.071+0200 I/servicemanager(17973): es.ugr.frailty.pedometer launch request sent!
06-07 17:16:33.071+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:33.081+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:33.081+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.081+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:88,0.215761,0.016799,0.071890
06-07 17:16:33.081+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.091+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:93,0.014224,-0.002808,0.067356
06-07 17:16:33.091+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.091+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:33.091+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:99,0.672006,-0.019526,0.033866
06-07 17:16:33.091+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.101+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:33:81,0.322624,-0.093369,9.800897
06-07 17:16:33.101+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:104,-0.261856,0.191037,0.022960
06-07 17:16:33.101+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:16:33.101+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(19049), cmd(0)
06-07 17:16:33.101+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:33.111+0200 W/CAPI_APPFW_APP_CONTROL(19049): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:16:33.111+0200 I/utils   (19049): specific action
06-07 17:16:33.111+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.111+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:116,-1.011850,-0.056333,0.077915
06-07 17:16:33.111+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.111+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:33:95,-0.070000,-0.070000,-0.070000
06-07 17:16:33.111+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:121,-0.086064,-0.056064,0.035832
06-07 17:16:33.121+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.121+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:33:99,0.593420,-0.114855,9.875179
06-07 17:16:33.121+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:127,0.024664,0.013585,0.021323
06-07 17:16:33.121+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.131+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:33.131+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:133,0.007768,-0.028318,0.160100
06-07 17:16:33.131+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:33.131+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.131+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:139,-0.016884,-0.042510,0.090656
06-07 17:16:33.131+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.141+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:33:123,0.330343,-0.092904,9.800644
06-07 17:16:33.141+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:144,-0.054026,0.007430,0.064318
06-07 17:16:33.141+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.141+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:149,0.032115,-0.069140,0.042782
06-07 17:16:33.141+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.151+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:33:147,0.538385,-0.076570,9.872787
06-07 17:16:33.151+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:154,0.029723,0.009823,0.076281
06-07 17:16:33.151+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.151+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:33.151+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:160,0.029723,-0.011713,0.061925
06-07 17:16:33.151+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.161+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:164,0.027611,0.001684,0.064322
06-07 17:16:33.161+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.171+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:172,-0.118351,-0.086850,0.016464
06-07 17:16:33.171+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.171+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:33:140,0.070000,0.070000,2.240000
06-07 17:16:33.171+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:33.171+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:33.171+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:177,-0.314716,-0.545194,0.066524
06-07 17:16:33.181+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.181+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:185,0.181269,0.006853,0.011684
06-07 17:16:33.181+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.181+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:190,0.034272,0.270115,0.038264
06-07 17:16:33.191+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.191+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:196,0.150772,0.087617,0.069260
06-07 17:16:33.191+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:33:165,0.330587,-0.092936,9.800635
06-07 17:16:33.191+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.191+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:33:181,0.070000,-0.070000,1.470000
06-07 17:16:33.201+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:202,0.134043,0.128971,0.078942
06-07 17:16:33.201+0200 W/CAPI_APPFW_APP_CONTROL(19031): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:16:33.201+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:16:33.201+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(19031), cmd(0)
06-07 17:16:33.201+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.201+0200 I/utils   (19031): specific action
06-07 17:16:33.201+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:33:184,0.344566,-0.095713,9.868000
06-07 17:16:33.211+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:33.201+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:33.211+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:33.221+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:33:222,1.002593,-0.112463,9.834501
06-07 17:16:33.221+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:33.221+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:215,0.016900,0.030482,0.064691
06-07 17:16:33.221+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:16:33.231+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:33:217,0.359962,-0.095324,9.799578
06-07 17:16:33.231+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.231+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:33.231+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:33:225,-0.210000,-0.280000,-17.010000
06-07 17:16:33.231+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:33.241+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:16:33:234,1212.000000
06-07 17:16:33.241+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:33:239,0.361002,-0.082451,9.799656
06-07 17:16:33.241+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:33.251+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:16:33.251+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:16:33.251+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:238,-0.063252,0.005378,0.057540
06-07 17:16:33.251+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:33:245,0.098106,0.095713,9.822537
06-07 17:16:33.251+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.261+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:33:243,0.140000,-0.070000,-3.640000
06-07 17:16:33.261+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:33.261+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:33:249,0.320560,-0.082720,9.801061
06-07 17:16:33.271+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:33.271+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:264,0.002908,-0.011786,0.074157
06-07 17:16:33.271+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.281+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:33:270,-0.650848,-0.138784,9.877571
06-07 17:16:33.281+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:33.281+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:33.281+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:33:276,0.140000,-0.070000,0.700000
06-07 17:16:33.291+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:33.291+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:285,-0.034837,0.024482,0.076534
06-07 17:16:33.291+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:33:291,0.315117,-0.085369,9.801214
06-07 17:16:33.291+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:33.301+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:33:296,0.070000,-0.070000,-1.960000
06-07 17:16:33.301+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:33.301+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:33:289,0.234497,-0.138784,9.836893
06-07 17:16:33.311+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:16:33.311+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(19019), cmd(0)
06-07 17:16:33.311+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.321+0200 W/CAPI_APPFW_APP_CONTROL(19019): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:16:33.321+0200 I/utils   (19019): specific action
06-07 17:16:33.321+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:33.331+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:322,0.024720,-0.024762,0.071669
06-07 17:16:33.331+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.331+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:33:303,0.315263,-0.084145,9.801220
06-07 17:16:33.341+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:33.341+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:33:332,0.339781,-0.071785,9.822537
06-07 17:16:33.341+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:33:310,0.280000,-0.070000,-0.140000
06-07 17:16:33.341+0200 I/accelerometer(19019): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:33.371+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:16:33.371+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(19004), cmd(0)
06-07 17:16:33.371+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:337,0.000309,-0.023844,0.028621
06-07 17:16:33.371+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:33.381+0200 W/CAPI_APPFW_APP_CONTROL(19004): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:16:33.381+0200 I/utils   (19004): specific action
06-07 17:16:33.381+0200 I/gyroscope(19004): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:33.421+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:16:33.421+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:33:346,0.313594,-0.084310,9.801272
06-07 17:16:33.421+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:33.441+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:16:33:433,1210.000000
06-07 17:16:33.451+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:16:33.451+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:16:33.471+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:33:383,0.015157,-0.020512,0.062114
06-07 17:16:33.481+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11190886c6f63152838459
