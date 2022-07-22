S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 18280
Date: 2018-06-07 17:13:52+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf75a452d, r5   = 0xf7ba7f98
r6   = 0xff958b10, r7   = 0xff9589c0
r8   = 0xf7ba4c18, r9   = 0x00000000
r10  = 0xff958a9c, fp   = 0xff958b10
ip   = 0x00000001, sp   = 0xff958998
lr   = 0xf75a4539, pc   = 0xf760d228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     69304 KB
Buffers:      1140 KB
Cached:      44592 KB
VmPeak:      53568 KB
VmSize:      53564 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       10440 KB
VmRSS:        9080 KB
VmData:      11292 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:         24 KB

Threads Information
Threads: 2
PID = 18280 TID = 18280
18280 18288 

Maps Information
f446f000 f4c6e000 rw-p [stack:18288]
f4c75000 f4c77000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c7f000 f4c83000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c8c000 f4c8e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c96000 f4c99000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4ca8000 f4cad000 r-xp /usr/lib/libsystem.so.0.0.0
f4cb8000 f4cbb000 r-xp /lib/libattr.so.1.1.0
f4cc3000 f4cd3000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4cdb000 f4ce4000 r-xp /usr/lib/libedbus.so.1.7.99
f4cec000 f4ced000 r-xp /usr/lib/libresponse.so.0.2.96
f4cf6000 f4cfb000 r-xp /usr/lib/libproc-stat.so.0.2.96
f659d000 f66a3000 r-xp /usr/lib/libicuuc.so.57.1
f66b9000 f6841000 r-xp /usr/lib/libicui18n.so.57.1
f6851000 f685e000 r-xp /usr/lib/libail.so.0.1.0
f6867000 f686e000 r-xp /usr/lib/libminizip.so.1.0.0
f6877000 f6a20000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a40000 f6a87000 r-xp /usr/lib/libssl.so.1.0.0
f6a93000 f6a95000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a9d000 f6aa4000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6aad000 f6ab4000 r-xp /lib/libcrypt-2.13.so
f6ae5000 f6ae8000 r-xp /lib/libcap.so.2.21
f6af0000 f6af2000 r-xp /usr/lib/libiri.so
f6afa000 f6b43000 r-xp /usr/lib/libmdm.so.1.2.69
f6b4b000 f6b51000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b59000 f6b7c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b86000 f6b88000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b90000 f6bad000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6bb6000 f6bba000 r-xp /usr/lib/libsmack.so.1.0.0
f6bc3000 f6bdc000 r-xp /usr/lib/libnetwork.so.0.0.0
f6be5000 f6bed000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6bf5000 f6bfb000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c04000 f6c06000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c0f000 f6c1f000 r-xp /lib/libresolv-2.13.so
f6c23000 f6c3b000 r-xp /usr/lib/liblzma.so.5.0.3
f6c44000 f6c46000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c4e000 f6c68000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c70000 f6c9f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ca8000 f6cb7000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6cc1000 f6ccb000 r-xp /usr/lib/libsensord-shared.so
f6cd4000 f6da7000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6db2000 f6dc8000 r-xp /lib/libz.so.1.2.5
f6dd0000 f6dd5000 r-xp /usr/lib/libffi.so.5.0.10
f6ddd000 f6dde000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6de6000 f6df6000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6dfe000 f6e17000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e1f000 f6e21000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e29000 f6e9e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ea8000 f6eae000 r-xp /lib/librt-2.13.so
f6eb7000 f6ed5000 r-xp /usr/lib/libsystemd.so.0.4.0
f6edf000 f6ee0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ee8000 f6f0b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f13000 f6f18000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f20000 f6f4a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f53000 f6f6a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f72000 f6fdb000 r-xp /lib/libm-2.13.so
f6fe4000 f7078000 r-xp /usr/lib/libstdc++.so.6.0.16
f708b000 f7090000 r-xp /usr/lib/libctx-client.so.0.8.3
f7098000 f709f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70a7000 f70d1000 r-xp /usr/lib/libsensor.so.1.9.6
f70da000 f71a6000 r-xp /usr/lib/libxml2.so.2.7.8
f71b3000 f71b5000 r-xp /usr/lib/libiniparser.so.0
f71be000 f71c4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f71cd000 f729d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f729e000 f72d2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f72db000 f7317000 r-xp /usr/lib/libSLP-location.so.0.9.24
f731f000 f7322000 r-xp /usr/lib/libbundle.so.0.1.22
f732a000 f7330000 r-xp /usr/lib/libappsvc.so.0.1.0
f7338000 f7379000 r-xp /usr/lib/libeina.so.1.7.99
f7382000 f7399000 r-xp /usr/lib/libecore.so.1.7.99
f73b0000 f73b9000 r-xp /usr/lib/libvconf.so.0.2.45
f73c1000 f73d5000 r-xp /lib/libpthread-2.13.so
f73e0000 f73ed000 r-xp /usr/lib/libaul.so.0.1.0
f73f7000 f73f9000 r-xp /lib/libdl-2.13.so
f7402000 f740d000 r-xp /lib/libunwind.so.8.0.1
f743a000 f7442000 r-xp /lib/libgcc_s-4.6.so.1
f7443000 f7567000 r-xp /lib/libc-2.13.so
f7575000 f7577000 r-xp /usr/lib/libdlog.so.0.0.0
f757f000 f758b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7594000 f7599000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75a1000 f75b0000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f75b8000 f75bc000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75c5000 f75c8000 r-xp /usr/lib/libappcore-agent.so.1.1
f75d0000 f75d2000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f75da000 f75de000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f75e6000 f7603000 r-xp /lib/ld-2.13.so
f760c000 f760f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f760f000 f7613000 r-xp /usr/lib/libsys-assert.so
f7b74000 f7c02000 rw-p [heap]
ff93a000 ff95b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18280)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf760d228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf75a4539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72ab3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf72a9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf72b5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf72bbbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf72bbdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf72f075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72eb1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf72a9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf72b5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf72bbbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf72bbdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf72ede5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf72ee017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf72f5f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c8d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4c80171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d53663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7200fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72027a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7392ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf738db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf738e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf738e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf75c6183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75c67fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf760d5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf745a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf760cf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
avity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.761+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:51:764,0.354138,-0.088534,9.887143
06-07 17:13:51.761+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:770,0.313169,-0.093299,9.801205
06-07 17:13:51.771+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.771+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:51:770,0.018651,-0.057883,0.075990
06-07 17:13:51.771+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:51.771+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:777,0.312864,-0.093543,9.801211
06-07 17:13:51.781+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.781+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:51.781+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:786,0.314484,-0.093166,9.801164
06-07 17:13:51.781+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.791+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:51:783,0.358923,-0.098106,9.872787
06-07 17:13:51.791+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:794,0.315857,-0.093186,9.801119
06-07 17:13:51.791+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.791+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:51.791+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:51:791,0.056244,-0.005166,0.107141
06-07 17:13:51.801+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:801,0.316313,-0.092053,9.801115
06-07 17:13:51.801+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.801+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:51.801+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:51:809,0.035131,-0.009904,0.111989
06-07 17:13:51.801+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:809,0.317448,-0.092676,9.801072
06-07 17:13:51.811+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:51:807,0.346959,-0.076570,9.858429
06-07 17:13:51.811+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.811+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:51.811+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:818,0.315340,-0.092725,9.801140
06-07 17:13:51.811+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(18010) cmd(0)
06-07 17:13:51.821+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:51.821+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.821+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:51:824,0.351745,-0.110070,9.901501
06-07 17:13:51.821+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:829,0.313653,-0.092668,9.801195
06-07 17:13:51.831+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.831+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:51:832,-0.011402,0.019057,0.095274
06-07 17:13:51.831+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:51.831+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:51.831+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:837,0.314414,-0.092719,9.801170
06-07 17:13:51.831+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.841+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:844,0.314726,-0.092315,9.801164
06-07 17:13:51.841+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.841+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:51:841,0.287139,-0.098106,9.930215
06-07 17:13:51.841+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:51:843,0.023160,-0.001222,0.083266
06-07 17:13:51.841+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:850,0.314656,-0.091591,9.801172
06-07 17:13:51.851+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:51.851+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.851+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:857,0.313946,-0.091706,9.801194
06-07 17:13:51.851+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.861+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:51.861+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:863,0.316366,-0.090760,9.801126
06-07 17:13:51.861+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.861+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:870,0.318294,-0.090515,9.801065
06-07 17:13:51.861+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:51:857,0.291924,-0.095713,9.887143
06-07 17:13:51.861+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:51.871+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:51:866,-0.001298,0.003416,0.066531
06-07 17:13:51.871+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.871+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:876,0.318358,-0.091850,9.801051
06-07 17:13:51.871+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:51.871+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.881+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:882,0.318230,-0.094099,9.801034
06-07 17:13:51.881+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:51:876,0.325424,-0.088534,9.891929
06-07 17:13:51.881+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:51.881+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.881+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:51:881,0.018417,-0.004129,0.088046
06-07 17:13:51.881+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:889,0.317248,-0.091086,9.801094
06-07 17:13:51.881+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:51.891+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.891+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:51:895,0.315853,-0.078963,9.879964
06-07 17:13:51.891+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:896,0.316249,-0.089305,9.801143
06-07 17:13:51.891+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.891+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:51:899,-0.000795,0.031596,0.049762
06-07 17:13:51.901+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:902,0.315297,-0.088330,9.801182
06-07 17:13:51.901+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.901+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:51.901+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:51.901+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:909,0.314669,-0.088368,9.801202
06-07 17:13:51.901+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.911+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(18054) cmd(0)
06-07 17:13:51.911+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:915,0.314031,-0.088398,9.801222
06-07 17:13:51.911+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:51:911,0.306281,-0.071785,9.851252
06-07 17:13:51.911+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:13:51.921+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:51.921+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:51:915,0.055021,-0.032484,0.107147
06-07 17:13:51.921+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:13:51:925,676.000000
06-07 17:13:51.921+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.921+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:51.921+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:51:929,0.294317,-0.088534,9.865608
06-07 17:13:51.921+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:931,0.316866,-0.088121,9.801133
06-07 17:13:51.931+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.931+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:937,0.317458,-0.088152,9.801114
06-07 17:13:51.931+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.931+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:51.931+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:51:935,0.000234,0.014264,0.071334
06-07 17:13:51.941+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:943,0.318809,-0.089413,9.801059
06-07 17:13:51.941+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.951+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:951,0.318025,-0.088921,9.801088
06-07 17:13:51.951+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:13:51.951+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.951+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:13:51.951+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:51.961+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:961,0.317848,-0.088820,9.801095
06-07 17:13:51.961+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.971+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:972,0.317692,-0.087880,9.801108
06-07 17:13:51.981+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.981+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:986,0.317896,-0.086678,9.801113
06-07 17:13:51.981+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:51.991+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:51:993,0.317374,-0.087991,9.801118
06-07 17:13:51.991+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.001+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:0,0.318328,-0.088598,9.801082
06-07 17:13:52.001+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.001+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:7,0.317658,-0.089366,9.801097
06-07 17:13:52.001+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.011+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:14,0.318053,-0.090580,9.801072
06-07 17:13:52.011+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.021+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:21,0.318451,-0.091747,9.801048
06-07 17:13:52.021+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.031+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:30,0.320291,-0.092037,9.800986
06-07 17:13:52.041+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:51:964,0.036656,-0.008156,0.061738
06-07 17:13:52.041+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:51:945,0.358923,-0.064606,9.927821
06-07 17:13:52.051+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.051+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.061+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:56,0.346959,-0.078963,9.887143
06-07 17:13:52.061+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:13:52.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:13:52.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:13:52.061+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:62,0.021354,-0.015294,0.100054
06-07 17:13:52.081+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.081+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:75,0.308674,-0.112463,9.879964
06-07 17:13:52.081+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.091+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:87,0.006771,-0.050838,0.066564
06-07 17:13:52.091+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.091+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.091+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:101,-0.069590,-0.008143,0.083325
06-07 17:13:52.101+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:97,0.311067,-0.133998,9.805787
06-07 17:13:52.101+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.111+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.111+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:114,0.291924,-0.031107,9.901501
06-07 17:13:52.121+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:13:52.121+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:13:52:126,677.000000
06-07 17:13:52.121+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.121+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:121,0.320595,-0.091764,9.800979
06-07 17:13:52.121+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:126,0.013709,-0.019967,0.071229
06-07 17:13:52.131+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.131+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:137,0.294317,-0.052642,9.863215
06-07 17:13:52.131+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.141+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:146,0.030259,-0.007270,0.056884
06-07 17:13:52.141+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:13:52.141+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:13:52.141+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.141+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:13:52.141+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:13:52.141+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:13:52.141+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:13:52.141+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:13:52.141+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:13:52.141+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:13:52.141+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:13:52.141+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:13:52.141+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:13:52.141+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:13:52.141+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:13:52.141+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391632155,000000, pattern:[H:mm][0;m
06-07 17:13:52.141+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:13:52.141+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:13:52.141+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:13:52.141+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:13:52.151+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:13:52.151+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:13][0;m
06-07 17:13:52.151+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:142,0.319675,-0.092069,9.801006
06-07 17:13:52.161+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.161+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.161+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:170,0.017379,0.026382,0.028200
06-07 17:13:52.171+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:166,0.294317,-0.066999,9.887143
06-07 17:13:52.171+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.181+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.181+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:172,0.318606,-0.090964,9.801051
06-07 17:13:52.181+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.191+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:187,0.313460,-0.093320,9.863215
06-07 17:13:52.191+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:191,0.033856,0.017765,0.083230
06-07 17:13:52.201+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.201+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.201+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:195,0.317016,-0.092007,9.801093
06-07 17:13:52.221+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:212,0.313460,-0.093320,9.884750
06-07 17:13:52.221+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.221+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:216,0.016201,-0.031114,0.056928
06-07 17:13:52.221+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.221+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.241+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:230,0.316133,-0.089791,9.801142
06-07 17:13:52.241+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:237,0.378066,-0.078963,9.870394
06-07 17:13:52.241+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.251+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:241,0.029370,-0.048645,0.083301
06-07 17:13:52.251+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.251+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.271+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:262,0.342174,-0.093320,9.906286
06-07 17:13:52.271+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:260,0.316459,-0.090296,9.801126
06-07 17:13:52.271+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:265,0.015495,-0.007976,0.090562
06-07 17:13:52.271+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.281+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.291+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.301+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:284,0.354138,-0.119641,9.846465
06-07 17:13:52.301+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:293,0.009721,-0.000285,0.114525
06-07 17:13:52.311+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:296,0.317933,-0.090687,9.801075
06-07 17:13:52.311+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.321+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.321+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:13:52.321+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.331+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:329,0.006663,-0.007324,0.064300
06-07 17:13:52.341+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:322,0.318245,-0.086142,9.834501
06-07 17:13:52.341+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:332,0.317777,-0.090729,9.801080
06-07 17:13:52.341+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.341+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:13:52.341+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:13:52.341+0200 W/LOCATION(18280): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:13:52.341+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:13:52:329,677.000000
06-07 17:13:52.351+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.351+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.361+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:362,0.319734,-0.090444,9.801019
06-07 17:13:52.361+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:359,0.063781,0.050552,0.061921
06-07 17:13:52.361+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.361+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:352,0.325424,-0.090927,9.860823
06-07 17:13:52.371+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.371+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.381+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:375,-0.008091,-0.004250,0.112227
06-07 17:13:52.381+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:377,0.318376,-0.091255,9.801056
06-07 17:13:52.381+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.381+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.391+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:377,0.313460,-0.066999,9.877571
06-07 17:13:52.391+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:395,0.315561,-0.091759,9.801142
06-07 17:13:52.391+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:392,0.002690,0.007543,0.083473
06-07 17:13:52.391+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.391+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.401+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:405,0.024642,0.045258,0.035598
06-07 17:13:52.401+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.401+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.411+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:410,0.313173,-0.093028,9.801207
06-07 17:13:52.411+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.421+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:423,0.311716,-0.092967,9.801253
06-07 17:13:52.421+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:417,0.045648,-0.019269,0.100201
06-07 17:13:52.421+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.431+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:413,0.339781,-0.069392,9.851252
06-07 17:13:52.431+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.431+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.441+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:437,0.008289,-0.016213,0.045218
06-07 17:13:52.441+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:444,0.309624,-0.092891,9.801321
06-07 17:13:52.441+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:442,0.308674,-0.112463,9.903893
06-07 17:13:52.451+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.451+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.461+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.461+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:459,0.334995,-0.098106,9.808180
06-07 17:13:52.471+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:456,-0.003467,-0.010877,0.097857
06-07 17:13:52.471+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.471+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.481+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:469,0.312265,-0.092778,9.801238
06-07 17:13:52.481+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.481+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:482,0.306281,-0.102891,9.911072
06-07 17:13:52.481+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.481+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:483,-0.008134,-0.005354,0.038040
06-07 17:13:52.491+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.491+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:491,0.334995,-0.119641,9.848858
06-07 17:13:52.491+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:500,-0.022390,-0.002437,0.045221
06-07 17:13:52.501+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.501+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:488,0.312118,-0.094315,9.801229
06-07 17:13:52.501+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.501+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:506,0.334995,-0.119641,9.834501
06-07 17:13:52.511+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.511+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:517,0.012173,0.007372,0.059546
06-07 17:13:52.511+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.521+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:13:52.521+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:513,0.312614,-0.095253,9.801203
06-07 17:13:52.521+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.521+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:13:52:526,675.000000
06-07 17:13:52.531+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:522,0.358923,-0.095713,9.891929
06-07 17:13:52.531+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.531+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.541+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:529,0.314811,-0.094081,9.801145
06-07 17:13:52.541+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.541+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:539,0.014512,0.028362,0.097828
06-07 17:13:52.541+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:13:52.541+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:13:52.541+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:543,0.325424,-0.083749,9.832108
06-07 17:13:52.551+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.551+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.561+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:552,0.315141,-0.093671,9.801138
06-07 17:13:52.561+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:560,0.301496,-0.095713,9.853643
06-07 17:13:52.561+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.561+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:560,0.024003,0.031597,0.085852
06-07 17:13:52.571+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.571+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.581+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:574,0.315282,-0.092284,9.801147
06-07 17:13:52.581+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:576,0.294317,-0.066999,9.858429
06-07 17:13:52.581+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.581+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.581+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:584,-0.014760,-0.003586,0.090637
06-07 17:13:52.591+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:590,0.299103,-0.117248,9.896714
06-07 17:13:52.591+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.591+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.601+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:608,0.306281,-0.050249,9.879964
06-07 17:13:52.601+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:595,0.314952,-0.093794,9.801143
06-07 17:13:52.611+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.611+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.611+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:605,0.024010,-0.022307,0.085840
06-07 17:13:52.611+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.621+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:620,0.315142,-0.092737,9.801147
06-07 17:13:52.621+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:622,0.334995,-0.105284,9.903893
06-07 17:13:52.631+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.631+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:633,0.017801,-0.035380,0.093076
06-07 17:13:52.631+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.641+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.641+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:637,0.358923,-0.102891,9.872787
06-07 17:13:52.641+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:644,0.316957,-0.095455,9.801062
06-07 17:13:52.641+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.651+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.651+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:658,0.315313,-0.096945,9.801100
06-07 17:13:52.651+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:646,-0.002506,-0.009568,0.081166
06-07 17:13:52.661+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.661+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.671+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:658,0.308674,-0.086142,9.863215
06-07 17:13:52.671+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:671,0.316207,-0.096542,9.801075
06-07 17:13:52.671+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.681+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.681+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:670,0.043109,-0.011412,0.054846
06-07 17:13:52.681+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.691+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:685,0.317651,-0.097800,9.801016
06-07 17:13:52.691+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:680,0.356531,-0.078963,9.906286
06-07 17:13:52.691+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.691+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.701+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:704,0.318256,-0.097277,9.801002
06-07 17:13:52.701+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:695,0.012353,-0.046655,0.038167
06-07 17:13:52.711+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.711+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.721+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:13:52.721+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:721,0.317945,-0.097555,9.801009
06-07 17:13:52.721+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:13:52:727,675.000000
06-07 17:13:52.721+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:707,0.294317,-0.105284,9.903893
06-07 17:13:52.721+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.731+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.731+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:720,-0.050474,0.015421,0.042995
06-07 17:13:52.741+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:738,0.317745,-0.098676,9.801004
06-07 17:13:52.741+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.741+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.751+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:737,0.263210,-0.098106,9.836893
06-07 17:13:52.751+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:13:52.751+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:13:52.751+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.751+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:752,-0.014444,0.024350,0.069229
06-07 17:13:52.751+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.751+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:757,0.318100,-0.098412,9.800996
06-07 17:13:52.761+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:758,0.270389,-0.114855,9.851252
06-07 17:13:52.761+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.761+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:767,-0.014133,0.016147,0.042888
06-07 17:13:52.771+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.771+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.781+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:774,0.277567,-0.086142,9.863215
06-07 17:13:52.781+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.791+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:783,-0.008544,0.000868,0.061996
06-07 17:13:52.791+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:785,0.320011,-0.098954,9.800928
06-07 17:13:52.791+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.791+0200 I/servicemanager(17973): es.ugr.frailty.accelerometer alive timeout
06-07 17:13:52.791+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:13:52.801+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:13:52.801+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:13:52.801+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:795,0.265603,-0.086142,9.934999
06-07 17:13:52.801+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.811+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18010
06-07 17:13:52.811+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18010)
06-07 17:13:52.811+0200 I/servicemanager(17973): es.ugr.frailty.accelerometer launch request sent!
06-07 17:13:52.811+0200 I/servicemanager(17973): App control destroyed.
06-07 17:13:52.811+0200 I/servicemanager(17973): es.ugr.frailty.gyroscope alive timeout
06-07 17:13:52.811+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:13:52.811+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:13:52.821+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:13:52.831+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 3
06-07 17:13:52.831+0200 W/AUL_AMD ( 2479): amd_launch.c: start_process(606) > child process: 18334
06-07 17:13:52.831+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.831+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:815,0.361316,-0.083749,9.824929
06-07 17:13:52.831+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:841,0.318483,-0.098783,9.800980
06-07 17:13:52.851+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.851+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:840,0.009121,-0.008944,0.088285
06-07 17:13:52.851+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:52.861+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.861+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:871,0.303888,-0.119641,9.841680
06-07 17:13:52.871+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:52.881+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:52:871,0.319258,-0.098761,9.800954
06-07 17:13:52.881+0200 W/AUL_AMD ( 2479): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 18334
06-07 17:13:52.881+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gyroscope) pid(18334) type(svcapp) bg(0)
06-07 17:13:52.891+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18334)
06-07 17:13:52.891+0200 I/servicemanager(17973): es.ugr.frailty.gyroscope launch request sent!
06-07 17:13:52.891+0200 I/servicemanager(17973): App control destroyed.
06-07 17:13:52.891+0200 I/servicemanager(17973): es.ugr.frailty.heartrate alive timeout
06-07 17:13:52.891+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:13:52.891+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:13:52.891+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:13:52.901+0200 W/STARTER ( 2696): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [18334]
06-07 17:13:52.911+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18034
06-07 17:13:52.911+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:13:52.911+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(18034), cmd(0)
06-07 17:13:52.911+0200 W/CAPI_APPFW_APP_CONTROL(18034): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:13:52.911+0200 I/utils   (18034): specific action
06-07 17:13:52.921+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:13:52.931+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18034)
06-07 17:13:52.931+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:13:52.941+0200 I/servicemanager(17973): es.ugr.frailty.heartrate launch request sent!
06-07 17:13:52.941+0200 I/servicemanager(17973): App control destroyed.
06-07 17:13:52.941+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18334
06-07 17:13:52.951+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:13:52.961+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:13:52.961+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:13:52.961+0200 I/servicemanager(17973): es.ugr.frailty.location alive timeout
06-07 17:13:52.961+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18334
06-07 17:13:52.961+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:13:52.961+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:13:52.961+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:13:52:926,674.000000
06-07 17:13:52.971+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:52:865,0.030917,-0.030295,0.073922
06-07 17:13:52.971+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18334
06-07 17:13:52.971+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:52.971+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 17:13:52.981+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:13:52.981+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:13:52.991+0200 E/RESOURCED( 2560): cgroup.c: cgroup_get_pids(425) > Failed to open '/sys/fs/cgroup/freezer/frozen/cgroup.procs': Not a directory
06-07 17:13:52.991+0200 E/RESOURCED( 2560): freezer-process.c: freezer_check_all_suspend_process(251) > Failed to get cgroup pids: Not a directory
06-07 17:13:53.001+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18280
06-07 17:13:53.001+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:52:881,0.323031,-0.112463,9.882358
06-07 17:13:53.001+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 17:13:53.001+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:53.001+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 17:13:53.011+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18280)
06-07 17:13:53.011+0200 I/servicemanager(17973): es.ugr.frailty.location launch request sent!
06-07 17:13:53.011+0200 I/servicemanager(17973): App control destroyed.
06-07 17:13:53.011+0200 I/servicemanager(17973): es.ugr.frailty.linearacceleration alive timeout
06-07 17:13:53.011+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:13:53.021+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:13:53.021+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:53:11,0.366102,-0.066999,9.851252
06-07 17:13:53.021+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11182806c6f63152838443
