S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 12137
Date: 2018-06-07 16:54:08+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf71ea52d, r5   = 0xf7945f98
r6   = 0xff8f3030, r7   = 0xff8f2ee0
r8   = 0xf7942c18, r9   = 0x00000000
r10  = 0xff8f2fbc, fp   = 0xff8f3030
ip   = 0x00000001, sp   = 0xff8f2eb8
lr   = 0xf71ea539, pc   = 0xf7253228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    232828 KB
Buffers:      2492 KB
Cached:      55644 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11452 KB
VmRSS:       11448 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 12137 TID = 12137
12137 12143 

Maps Information
f40b5000 f48b4000 rw-p [stack:12143]
f48bb000 f48bd000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f48c5000 f48c9000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f48d2000 f48d4000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f48dc000 f48df000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f48ee000 f48f3000 r-xp /usr/lib/libsystem.so.0.0.0
f48fe000 f4901000 r-xp /lib/libattr.so.1.1.0
f4909000 f4919000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4921000 f492a000 r-xp /usr/lib/libedbus.so.1.7.99
f4932000 f4933000 r-xp /usr/lib/libresponse.so.0.2.96
f493c000 f4941000 r-xp /usr/lib/libproc-stat.so.0.2.96
f61e3000 f62e9000 r-xp /usr/lib/libicuuc.so.57.1
f62ff000 f6487000 r-xp /usr/lib/libicui18n.so.57.1
f6497000 f64a4000 r-xp /usr/lib/libail.so.0.1.0
f64ad000 f64b4000 r-xp /usr/lib/libminizip.so.1.0.0
f64bd000 f6666000 r-xp /usr/lib/libcrypto.so.1.0.0
f6686000 f66cd000 r-xp /usr/lib/libssl.so.1.0.0
f66d9000 f66db000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f66e3000 f66ea000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f66f3000 f66fa000 r-xp /lib/libcrypt-2.13.so
f672b000 f672e000 r-xp /lib/libcap.so.2.21
f6736000 f6738000 r-xp /usr/lib/libiri.so
f6740000 f6789000 r-xp /usr/lib/libmdm.so.1.2.69
f6791000 f6797000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f679f000 f67c2000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f67cc000 f67ce000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f67d6000 f67f3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f67fc000 f6800000 r-xp /usr/lib/libsmack.so.1.0.0
f6809000 f6822000 r-xp /usr/lib/libnetwork.so.0.0.0
f682b000 f6833000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f683b000 f6841000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f684a000 f684c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6855000 f6865000 r-xp /lib/libresolv-2.13.so
f6869000 f6881000 r-xp /usr/lib/liblzma.so.5.0.3
f688a000 f688c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6894000 f68ae000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f68b6000 f68e5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68ee000 f68fd000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6907000 f6911000 r-xp /usr/lib/libsensord-shared.so
f691a000 f69ed000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f69f8000 f6a0e000 r-xp /lib/libz.so.1.2.5
f6a16000 f6a1b000 r-xp /usr/lib/libffi.so.5.0.10
f6a23000 f6a24000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a2c000 f6a3c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a44000 f6a5d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a65000 f6a67000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a6f000 f6ae4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6aee000 f6af4000 r-xp /lib/librt-2.13.so
f6afd000 f6b1b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b25000 f6b26000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b2e000 f6b51000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b59000 f6b5e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b66000 f6b90000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b99000 f6bb0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6bb8000 f6c21000 r-xp /lib/libm-2.13.so
f6c2a000 f6cbe000 r-xp /usr/lib/libstdc++.so.6.0.16
f6cd1000 f6cd6000 r-xp /usr/lib/libctx-client.so.0.8.3
f6cde000 f6ce5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ced000 f6d17000 r-xp /usr/lib/libsensor.so.1.9.6
f6d20000 f6dec000 r-xp /usr/lib/libxml2.so.2.7.8
f6df9000 f6dfb000 r-xp /usr/lib/libiniparser.so.0
f6e04000 f6e0a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e13000 f6ee3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6ee4000 f6f18000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f21000 f6f5d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f65000 f6f68000 r-xp /usr/lib/libbundle.so.0.1.22
f6f70000 f6f76000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f7e000 f6fbf000 r-xp /usr/lib/libeina.so.1.7.99
f6fc8000 f6fdf000 r-xp /usr/lib/libecore.so.1.7.99
f6ff6000 f6fff000 r-xp /usr/lib/libvconf.so.0.2.45
f7007000 f701b000 r-xp /lib/libpthread-2.13.so
f7026000 f7033000 r-xp /usr/lib/libaul.so.0.1.0
f703d000 f703f000 r-xp /lib/libdl-2.13.so
f7048000 f7053000 r-xp /lib/libunwind.so.8.0.1
f7080000 f7088000 r-xp /lib/libgcc_s-4.6.so.1
f7089000 f71ad000 r-xp /lib/libc-2.13.so
f71bb000 f71bd000 r-xp /usr/lib/libdlog.so.0.0.0
f71c5000 f71d1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71da000 f71df000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f71e7000 f71f6000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f71fe000 f7202000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f720b000 f720e000 r-xp /usr/lib/libappcore-agent.so.1.1
f7216000 f7218000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7220000 f7224000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f722c000 f7249000 r-xp /lib/ld-2.13.so
f7252000 f7255000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7255000 f7259000 r-xp /usr/lib/libsys-assert.so
f7912000 f79a0000 rw-p [heap]
ff8d4000 ff8f5000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12137)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7253228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf71ea539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6ef13f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6eefc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6efbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f01be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f01dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f3675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f311f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6eefc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6efbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f01be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f01dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f33e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f34017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f3bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48d31fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf48c6171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6999663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e46fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e487a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6fd8ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6fd3b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6fd45a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6fd4879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf720c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf720c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72535c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf70a085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7252f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
831+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:839,0.291297,0.004273,0.010746
06-07 16:54:08.841+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:08.841+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:845,0.325178,-0.001274,0.006988
06-07 16:54:08.841+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:08.851+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:855,0.333292,0.048066,-0.072206
06-07 16:54:08.851+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:08.861+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:862,0.322320,0.012321,-0.036007
06-07 16:54:08.861+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:08.861+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:868,0.304681,0.023117,-0.040596
06-07 16:54:08.861+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:08.871+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:873,0.276566,0.019342,-0.032444
06-07 16:54:08.871+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:08.871+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:878,0.218328,-0.006018,-0.038880
06-07 16:54:08.871+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:08.881+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:884,0.313985,0.002837,-0.002982
06-07 16:54:08.881+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:08.881+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:889,0.285777,-0.012349,0.017732
06-07 16:54:08.881+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:08.891+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:895,0.281720,-0.009933,0.033052
06-07 16:54:08.891+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:08.901+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:903,0.294304,-0.023351,-0.056984
06-07 16:54:08.901+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:08.901+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:909,0.268050,-0.016501,-0.003948
06-07 16:54:08.901+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:08.911+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:915,0.286288,-0.003548,0.011724
06-07 16:54:08.911+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:08.911+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:920,0.249895,-0.062669,0.014871
06-07 16:54:08.921+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:08.921+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:927,0.188920,0.047883,0.001453
06-07 16:54:08.921+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:08.931+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:935,0.280277,0.034295,0.066291
06-07 16:54:08.931+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:08.941+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:943,0.263340,0.030132,0.001949
06-07 16:54:08.941+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:08.941+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:949,0.323988,0.012595,-0.051890
06-07 16:54:08.951+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:08.951+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:955,0.312812,0.051994,-0.010848
06-07 16:54:08.951+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:08.951+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:961,0.291036,-0.024944,-0.015601
06-07 16:54:08.961+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:08.961+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:966,0.267374,0.052545,-0.046913
06-07 16:54:08.961+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:08.961+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:971,0.308338,-0.065061,-0.015896
06-07 16:54:08.971+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:08.971+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:977,0.259656,-0.052327,-0.020160
06-07 16:54:08.971+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:08.981+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:983,0.257803,-0.029177,0.035898
06-07 16:54:08.981+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:08.991+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:993,0.244444,0.003881,0.002847
06-07 16:54:08.991+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:08.991+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:08:998,0.266341,0.038864,0.015119
06-07 16:54:08.991+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.001+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:4,0.354876,0.084734,-0.084351
06-07 16:54:09.001+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.001+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:10,0.370810,0.046639,-0.002104
06-07 16:54:09.011+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.011+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:16,0.312272,-0.002568,-0.007557
06-07 16:54:09.011+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.021+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:23,0.297565,-0.101373,-0.023553
06-07 16:54:09.021+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.021+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:28,0.277736,-0.057280,0.012086
06-07 16:54:09.021+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.031+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:33,0.266330,-0.074616,-0.000663
06-07 16:54:09.031+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.031+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:38,0.265811,0.040998,0.046269
06-07 16:54:09.031+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.041+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:45,0.283551,0.028291,0.031563
06-07 16:54:09.041+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.041+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:51,0.312677,0.022836,-0.038914
06-07 16:54:09.051+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.051+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:56,0.338161,0.043702,-0.058094
06-07 16:54:09.051+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:54:09.081+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:54:09.081+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:54:09.081+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:64,0.323354,0.007304,-0.069785
06-07 16:54:09.081+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.091+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:94,0.335067,-0.019995,-0.020035
06-07 16:54:09.091+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.101+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:101,0.369783,0.021055,-0.035411
06-07 16:54:09.101+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.101+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:110,0.341928,0.016520,0.012977
06-07 16:54:09.111+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.111+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:117,0.366437,0.067351,-0.036668
06-07 16:54:09.111+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.121+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:125,0.340821,0.052753,-0.060974
06-07 16:54:09.121+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.131+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:134,0.359606,0.012457,-0.042504
06-07 16:54:09.131+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.141+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:143,0.355452,-0.028172,-0.021473
06-07 16:54:09.141+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.141+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:149,0.301854,0.011895,0.013066
06-07 16:54:09.151+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.151+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:156,0.265176,-0.052839,0.038175
06-07 16:54:09.151+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.161+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:162,0.256687,-0.042793,0.008310
06-07 16:54:09.161+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.161+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:168,0.257559,0.062883,-0.032469
06-07 16:54:09.161+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.171+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:174,0.271601,-0.000723,-0.042440
06-07 16:54:09.171+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.171+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:180,0.315188,0.095724,-0.006972
06-07 16:54:09.181+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.181+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:187,0.292635,-0.011885,-0.016739
06-07 16:54:09.181+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.191+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:193,0.265475,-0.036839,0.022584
06-07 16:54:09.191+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.201+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:200,0.281305,-0.053419,-0.033141
06-07 16:54:09.201+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.201+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:209,0.225964,-0.038163,0.034267
06-07 16:54:09.211+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.211+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:216,0.240427,0.035944,0.009899
06-07 16:54:09.211+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.221+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:223,0.301197,0.031180,0.021080
06-07 16:54:09.221+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.231+0200 E/PKGMGR_SERVER(12226): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=0, queue_status=1] 
06-07 16:54:09.231+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:234,0.315109,0.044781,-0.032819
06-07 16:54:09.231+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.231+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:240,0.326289,-0.052879,-0.036880
06-07 16:54:09.241+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.241+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:247,0.329485,-0.063188,-0.015687
06-07 16:54:09.241+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.251+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:254,0.183868,-0.037276,0.028656
06-07 16:54:09.251+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.261+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:260,0.180854,0.002632,0.023381
06-07 16:54:09.261+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.271+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:268,0.195942,-0.033880,-0.005515
06-07 16:54:09.271+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.271+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:278,0.241200,0.040968,-0.046721
06-07 16:54:09.271+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.281+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:285,0.227317,-0.011719,0.053069
06-07 16:54:09.281+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.281+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:291,0.226578,0.026907,-0.014398
06-07 16:54:09.291+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.291+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:297,0.223905,-0.016802,-0.001255
06-07 16:54:09.291+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.301+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:304,0.196384,-0.048876,0.020512
06-07 16:54:09.301+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.301+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:310,0.165081,-0.026973,-0.015347
06-07 16:54:09.311+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.311+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:317,0.121452,-0.029077,0.075137
06-07 16:54:09.311+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.321+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:324,0.239667,-0.034420,-0.048846
06-07 16:54:09.321+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.321+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:330,0.284844,0.044100,0.005788
06-07 16:54:09.331+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.331+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:336,0.215658,0.021002,0.024537
06-07 16:54:09.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:54:09.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:54:09.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:54:09.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:54:09.331+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390449343,000000, pattern:[H:mm][0;m
06-07 16:54:09.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:54:09.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:54:09.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:54:09.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:54:09.331+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:54:09.331+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:54][0;m
06-07 16:54:09.331+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.341+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:345,0.234625,0.010277,0.024572
06-07 16:54:09.341+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.341+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:350,0.252435,0.017444,0.032551
06-07 16:54:09.351+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.351+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:357,0.239419,-0.013679,-0.042108
06-07 16:54:09.351+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.361+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:363,0.190011,-0.022519,-0.021478
06-07 16:54:09.361+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.361+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:370,0.203935,0.018606,0.019309
06-07 16:54:09.371+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.371+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:377,0.256250,0.050876,-0.009333
06-07 16:54:09.371+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.381+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:384,0.214207,0.010865,0.021429
06-07 16:54:09.381+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.391+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:391,0.124015,0.004115,-0.029051
06-07 16:54:09.391+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.391+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:399,0.147493,-0.025928,0.014786
06-07 16:54:09.401+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.401+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:407,0.126586,-0.066657,0.092577
06-07 16:54:09.401+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.411+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:414,0.053035,-0.039237,0.027985
06-07 16:54:09.411+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.421+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:421,0.109674,-0.007060,0.042470
06-07 16:54:09.421+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.421+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:428,0.040366,0.045062,0.057344
06-07 16:54:09.421+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.431+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:435,0.033672,0.027887,0.025979
06-07 16:54:09.431+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.441+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:441,0.091463,0.038400,0.027051
06-07 16:54:09.441+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.441+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:448,0.130802,0.000629,-0.022301
06-07 16:54:09.441+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.451+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:455,0.130247,-0.034232,0.060524
06-07 16:54:09.451+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.461+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:462,0.055791,0.003693,0.014054
06-07 16:54:09.461+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.471+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:475,0.057512,-0.022556,0.066335
06-07 16:54:09.471+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.471+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:480,0.062189,0.052474,0.030475
06-07 16:54:09.481+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.481+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:487,0.030263,-0.047390,0.057714
06-07 16:54:09.481+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.491+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:493,0.045869,-0.056826,0.009028
06-07 16:54:09.491+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.501+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:503,0.069090,0.019795,0.070191
06-07 16:54:09.501+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.501+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:509,0.104068,0.032744,0.035052
06-07 16:54:09.501+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.511+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:514,0.080899,-0.017122,0.067099
06-07 16:54:09.511+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.511+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:520,0.014417,-0.009069,0.006622
06-07 16:54:09.521+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.521+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:526,0.083063,-0.018162,0.043959
06-07 16:54:09.521+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.531+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:532,0.013917,-0.065061,0.076881
06-07 16:54:09.531+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.531+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:538,0.013875,-0.057413,0.023643
06-07 16:54:09.531+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.541+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:545,0.142290,0.104253,-0.012850
06-07 16:54:09.541+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.551+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:554,0.081701,0.043428,-0.045725
06-07 16:54:09.551+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.561+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:561,-0.001158,0.011862,0.097965
06-07 16:54:09.561+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.561+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:567,0.013080,-0.029757,0.110007
06-07 16:54:09.561+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.571+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:574,0.000827,-0.024925,0.075833
06-07 16:54:09.571+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.581+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:581,-0.012490,-0.010543,0.030383
06-07 16:54:09.581+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.581+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:587,0.010233,0.114133,-0.009550
06-07 16:54:09.581+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.591+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:594,0.114016,0.066292,0.064615
06-07 16:54:09.591+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.601+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:605,0.013211,-0.088730,0.082839
06-07 16:54:09.601+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.611+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:611,0.047590,0.003758,0.001753
06-07 16:54:09.611+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.611+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:617,0.035180,-0.089775,0.058034
06-07 16:54:09.611+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.621+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:623,-0.007253,0.052508,0.039876
06-07 16:54:09.621+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.621+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:628,0.033412,-0.034924,0.086140
06-07 16:54:09.621+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.631+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:633,0.068371,-0.090744,0.113246
06-07 16:54:09.631+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.631+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:639,0.091435,0.179747,0.094546
06-07 16:54:09.641+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.641+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:646,0.135620,0.212814,0.000998
06-07 16:54:09.641+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.651+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:653,-0.060680,0.185646,-0.587690
06-07 16:54:09.651+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.661+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:659,-0.947523,-0.143322,0.727382
06-07 16:54:09.661+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.661+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:668,-1.185383,-0.257357,0.556900
06-07 16:54:09.661+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.671+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:674,-0.699537,0.042197,0.327618
06-07 16:54:09.671+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.681+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:681,-0.961775,-0.144871,0.397086
06-07 16:54:09.681+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.681+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:689,-1.075885,0.013563,0.378509
06-07 16:54:09.691+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.691+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:696,-1.562268,0.034022,0.723612
06-07 16:54:09.691+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.701+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:702,-2.088201,-0.392085,0.944840
06-07 16:54:09.701+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.701+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:710,-2.085287,-0.586834,1.073943
06-07 16:54:09.711+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.711+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:717,-1.894733,-0.549802,0.728504
06-07 16:54:09.711+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.721+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:723,-1.743812,-0.637051,0.598860
06-07 16:54:09.721+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.721+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:728,-1.848042,-0.436395,0.499722
06-07 16:54:09.721+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.731+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:734,-1.654563,-0.035889,0.443867
06-07 16:54:09.731+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.741+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:742,-1.290018,0.072133,0.292151
06-07 16:54:09.741+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.741+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:750,-1.114621,-0.145345,0.573508
06-07 16:54:09.751+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.751+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:758,-0.962107,-0.119957,0.507739
06-07 16:54:09.751+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.761+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:765,-0.579686,-0.152197,0.087570
06-07 16:54:09.761+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.771+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:771,-0.476534,-0.278854,0.147131
06-07 16:54:09.771+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.771+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:778,-0.627528,-0.225555,0.193221
06-07 16:54:09.771+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.781+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:785,-0.644474,-0.165441,0.239614
06-07 16:54:09.781+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.791+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:795,-0.619780,-0.199393,0.449185
06-07 16:54:09.791+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.801+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:802,-0.559905,-0.236102,0.210835
06-07 16:54:09.801+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.801+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:808,-0.599106,-0.216477,0.082740
06-07 16:54:09.801+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.811+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:814,-0.519281,-0.147368,0.153631
06-07 16:54:09.811+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.811+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:820,-0.405867,0.016933,0.177916
06-07 16:54:09.821+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.821+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:827,-0.354064,0.025973,0.157391
06-07 16:54:09.821+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.831+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:833,-0.240384,-0.071431,0.099628
06-07 16:54:09.831+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.841+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:840,-0.337011,-0.147704,0.157207
06-07 16:54:09.841+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.841+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:847,-0.393462,-0.136519,0.212300
06-07 16:54:09.841+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.851+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:854,-0.386473,-0.076544,0.266243
06-07 16:54:09.851+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.861+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:861,-0.223968,-0.030325,0.155231
06-07 16:54:09.861+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.861+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:868,-0.241805,-0.022042,-0.001863
06-07 16:54:09.861+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.871+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:874,-0.235189,-0.186278,0.035915
06-07 16:54:09.871+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.881+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:883,-0.115435,-0.125607,0.253139
06-07 16:54:09.881+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.881+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:889,-0.055403,-0.006824,0.096944
06-07 16:54:09.891+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.891+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:896,-0.025553,-0.022354,0.061171
06-07 16:54:09.891+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.901+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:902,-0.088366,-0.068367,0.101492
06-07 16:54:09.901+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.901+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:910,-0.125455,-0.085992,-0.065874
06-07 16:54:09.911+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.911+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:917,-0.263055,-0.132783,0.326828
06-07 16:54:09.911+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.921+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:923,-0.157428,-0.172979,0.185349
06-07 16:54:09.921+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.921+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:929,-0.038841,-0.124067,0.219513
06-07 16:54:09.931+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.931+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:937,-0.047338,-0.015162,0.241570
06-07 16:54:09.931+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.941+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:947,0.014690,0.001679,0.050010
06-07 16:54:09.941+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.951+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:954,-0.025874,0.052200,-0.098927
06-07 16:54:09.951+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.961+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:965,0.059034,0.038401,0.014668
06-07 16:54:09.971+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.971+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:977,0.057312,0.145067,0.092269
06-07 16:54:09.971+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.981+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:984,0.071394,0.005243,-0.039635
06-07 16:54:09.981+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.991+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:991,0.160098,0.031347,-0.074450
06-07 16:54:09.991+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:09.991+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:09:998,0.146157,-0.036320,-0.037587
06-07 16:54:10.001+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:10.001+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:10:6,-0.065903,0.074288,0.086634
06-07 16:54:10.011+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:10.011+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:10:16,0.032259,0.064130,0.215682
06-07 16:54:10.011+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:10.021+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:10:24,0.091785,0.070487,0.221049
06-07 16:54:10.031+0200 W/AUL_AMD ( 2479): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
06-07 16:54:10.031+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:10.041+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:10:44,0.109725,0.054029,-0.076247
06-07 16:54:10.041+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:10.041+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:10:50,0.064932,-0.128389,-0.089701
06-07 16:54:10.051+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:10.051+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:10:57,0.020114,-0.014260,0.171969
06-07 16:54:10.051+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:10.071+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:54:10.081+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:54:10.081+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:54:10.081+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:10:64,0.085991,0.167056,0.172326
06-07 16:54:10.081+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:10.091+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:10:91,0.139303,0.082320,0.074168
06-07 16:54:10.091+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:10.091+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:10:99,0.180421,-0.010018,-0.029200
06-07 16:54:10.101+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:10.101+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:10:106,0.183122,-0.121222,-0.018145
06-07 16:54:10.101+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:10.111+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:10:111,-0.000724,-0.047078,0.000175
06-07 16:54:10.111+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:10.111+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:10:118,0.110650,0.088117,0.157961
06-07 16:54:10.111+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:10.121+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:10:125,0.200584,0.032587,0.070158
06-07 16:54:10.121+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:10.121+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:10:131,0.173771,-0.003591,0.022894
06-07 16:54:10.131+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:10.131+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:10:137,0.309038,-0.020539,-0.025462
06-07 16:54:10.131+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:10.141+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:10:144,0.161802,0.037890,-0.100506
06-07 16:54:10.141+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:10.151+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:10:151,0.022280,0.076582,-0.020835
06-07 16:54:10.151+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:10.151+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:10:158,0.180451,-0.105255,0.061311
06-07 16:54:10.161+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:10.171+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:54:10:171,0.135746,-0.093753,0.051707
06-07 16:54:10.171+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:54:10.181+0200 W/CRASH_MANAGER(11751): worker.c: worker_job(1205) > 11121376c6f63152838324
