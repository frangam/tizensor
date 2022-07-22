S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 16071
Date: 2018-06-07 17:06:55+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf702852d, r5   = 0xf755cf98
r6   = 0xffcdedc0, r7   = 0xffcdec70
r8   = 0xf7559c18, r9   = 0x00000000
r10  = 0xffcded4c, fp   = 0xffcdedc0
ip   = 0x00000001, sp   = 0xffcdec48
lr   = 0xf7028539, pc   = 0xf7091228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     48500 KB
Buffers:      7196 KB
Cached:      52564 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11572 KB
VmRSS:       11568 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 16071 TID = 16071
16071 16079 

Maps Information
f3ef3000 f46f2000 rw-p [stack:16079]
f46f9000 f46fb000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4703000 f4707000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4710000 f4712000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f471a000 f471d000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f472c000 f4731000 r-xp /usr/lib/libsystem.so.0.0.0
f473c000 f473f000 r-xp /lib/libattr.so.1.1.0
f4747000 f4757000 r-xp /usr/lib/libmdm-common.so.1.1.24
f475f000 f4768000 r-xp /usr/lib/libedbus.so.1.7.99
f4770000 f4771000 r-xp /usr/lib/libresponse.so.0.2.96
f477a000 f477f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6021000 f6127000 r-xp /usr/lib/libicuuc.so.57.1
f613d000 f62c5000 r-xp /usr/lib/libicui18n.so.57.1
f62d5000 f62e2000 r-xp /usr/lib/libail.so.0.1.0
f62eb000 f62f2000 r-xp /usr/lib/libminizip.so.1.0.0
f62fb000 f64a4000 r-xp /usr/lib/libcrypto.so.1.0.0
f64c4000 f650b000 r-xp /usr/lib/libssl.so.1.0.0
f6517000 f6519000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6521000 f6528000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6531000 f6538000 r-xp /lib/libcrypt-2.13.so
f6569000 f656c000 r-xp /lib/libcap.so.2.21
f6574000 f6576000 r-xp /usr/lib/libiri.so
f657e000 f65c7000 r-xp /usr/lib/libmdm.so.1.2.69
f65cf000 f65d5000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f65dd000 f6600000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f660a000 f660c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6614000 f6631000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f663a000 f663e000 r-xp /usr/lib/libsmack.so.1.0.0
f6647000 f6660000 r-xp /usr/lib/libnetwork.so.0.0.0
f6669000 f6671000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6679000 f667f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6688000 f668a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6693000 f66a3000 r-xp /lib/libresolv-2.13.so
f66a7000 f66bf000 r-xp /usr/lib/liblzma.so.5.0.3
f66c8000 f66ca000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f66d2000 f66ec000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f66f4000 f6723000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f672c000 f673b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6745000 f674f000 r-xp /usr/lib/libsensord-shared.so
f6758000 f682b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6836000 f684c000 r-xp /lib/libz.so.1.2.5
f6854000 f6859000 r-xp /usr/lib/libffi.so.5.0.10
f6861000 f6862000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f686a000 f687a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6882000 f689b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f68a3000 f68a5000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f68ad000 f6922000 r-xp /usr/lib/libsqlite3.so.0.8.6
f692c000 f6932000 r-xp /lib/librt-2.13.so
f693b000 f6959000 r-xp /usr/lib/libsystemd.so.0.4.0
f6963000 f6964000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f696c000 f698f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6997000 f699c000 r-xp /usr/lib/libxdgmime.so.1.1.0
f69a4000 f69ce000 r-xp /usr/lib/libdbus-1.so.3.8.12
f69d7000 f69ee000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f69f6000 f6a5f000 r-xp /lib/libm-2.13.so
f6a68000 f6afc000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b0f000 f6b14000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b1c000 f6b23000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6b2b000 f6b55000 r-xp /usr/lib/libsensor.so.1.9.6
f6b5e000 f6c2a000 r-xp /usr/lib/libxml2.so.2.7.8
f6c37000 f6c39000 r-xp /usr/lib/libiniparser.so.0
f6c42000 f6c48000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c51000 f6d21000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d22000 f6d56000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d5f000 f6d9b000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6da3000 f6da6000 r-xp /usr/lib/libbundle.so.0.1.22
f6dae000 f6db4000 r-xp /usr/lib/libappsvc.so.0.1.0
f6dbc000 f6dfd000 r-xp /usr/lib/libeina.so.1.7.99
f6e06000 f6e1d000 r-xp /usr/lib/libecore.so.1.7.99
f6e34000 f6e3d000 r-xp /usr/lib/libvconf.so.0.2.45
f6e45000 f6e59000 r-xp /lib/libpthread-2.13.so
f6e64000 f6e71000 r-xp /usr/lib/libaul.so.0.1.0
f6e7b000 f6e7d000 r-xp /lib/libdl-2.13.so
f6e86000 f6e91000 r-xp /lib/libunwind.so.8.0.1
f6ebe000 f6ec6000 r-xp /lib/libgcc_s-4.6.so.1
f6ec7000 f6feb000 r-xp /lib/libc-2.13.so
f6ff9000 f6ffb000 r-xp /usr/lib/libdlog.so.0.0.0
f7003000 f700f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7018000 f701d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7025000 f7034000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f703c000 f7040000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7049000 f704c000 r-xp /usr/lib/libappcore-agent.so.1.1
f7054000 f7056000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f705e000 f7062000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f706a000 f7087000 r-xp /lib/ld-2.13.so
f7090000 f7093000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7093000 f7097000 r-xp /usr/lib/libsys-assert.so
f7529000 f759a000 rw-p [heap]
ffcc0000 ffce1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16071)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7091228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7028539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6d2f3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6d2dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6d39e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6d3fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6d3fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6d7475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6d6f1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6d2dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6d39e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6d3fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6d3fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6d71e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6d72017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6d79f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47111fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4704171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf67d7663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6c84fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6c867a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e16ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e11b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e125a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e12879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf704a183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf704a7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70915c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6ede85c) [/lib/libc.so.6] + 0x1785c
29: (0xf7090f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
6-07 17:06:54.761+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:54:758,0.770000,0.420000,0.210000
06-07 17:06:54.761+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:54.761+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:54:763,1.373480,-1.136591,9.724431
06-07 17:06:54.761+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:54:768,0.001849,0.202791,0.138633
06-07 17:06:54.761+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:54.761+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:54.761+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:54.771+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:54:775,1.381219,-1.088390,9.647696
06-07 17:06:54.771+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:54:772,0.980000,0.350000,-0.070000
06-07 17:06:54.771+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:54.771+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:54.781+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:54:775,1.361516,-1.050449,9.659825
06-07 17:06:54.781+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:54.781+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:54:786,0.029538,0.148081,0.045975
06-07 17:06:54.781+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:54.781+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:54:785,0.140000,0.210000,0.070000
06-07 17:06:54.791+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:54.791+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:54:792,1.373480,-1.153341,9.743573
06-07 17:06:54.791+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:54.791+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:54.791+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:54:793,1.382300,-1.098446,9.646400
06-07 17:06:54.791+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:54:797,-0.630000,0.070000,0.140000
06-07 17:06:54.801+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:54:805,1.363909,-1.115055,9.731609
06-07 17:06:54.801+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:54.801+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:54.801+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:54:802,0.071012,0.046791,0.048898
06-07 17:06:54.801+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:54:810,-0.560000,0.070000,0.140000
06-07 17:06:54.811+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:54:813,1.380159,-1.100317,9.646494
06-07 17:06:54.811+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:54.811+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:54.811+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:54.821+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:54:824,1.433301,-1.124627,9.745967
06-07 17:06:54.821+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:54.821+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:54:824,-0.070000,-0.070000,0.140000
06-07 17:06:54.821+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:54:820,0.013184,-0.037056,0.070526
06-07 17:06:54.831+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:54.831+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:54:837,-0.004976,-0.138243,0.049641
06-07 17:06:54.831+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:54:830,1.375847,-1.099395,9.647215
06-07 17:06:54.831+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:54.841+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:54:842,1.378654,-1.098356,9.646933
06-07 17:06:54.841+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:54.841+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:54.841+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:54:848,1.397408,-1.131805,9.712467
06-07 17:06:54.851+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:54.851+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:54.851+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:54.851+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:54:848,0.350000,0.210000,0.140000
06-07 17:06:54.861+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:54:865,1.409373,-1.069592,9.683753
06-07 17:06:54.871+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:54.871+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:06:54.881+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:54.881+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:06:54:885,524.000000
06-07 17:06:54.891+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:54:890,1.385444,-1.107877,9.681360
06-07 17:06:54.891+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:54:860,0.086732,-0.135772,0.106014
06-07 17:06:54.901+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:54:901,0.420000,0.210000,-0.070000
06-07 17:06:54.901+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:54.901+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:54.921+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:54:876,1.382159,-1.098930,9.646366
06-07 17:06:54.921+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:54.921+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:06:54.931+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:06:54:930,80
06-07 17:06:54.941+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:54.941+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:54:918,1.375873,-1.062413,9.707682
06-07 17:06:54.951+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:54.951+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:54:920,0.026480,-0.185148,0.076013
06-07 17:06:54.961+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:54:954,0.350000,0.420000,-0.280000
06-07 17:06:54.971+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:54.971+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:54:945,1.383581,-1.104030,9.645579
06-07 17:06:54.981+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:54:961,1.373480,-1.110270,9.707682
06-07 17:06:54.981+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:54.991+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:54:980,0.025803,-0.145698,0.078311
06-07 17:06:54.991+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.001+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.001+0200 W/LOCATION(16071): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:06:55.011+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:4,1.397408,-1.167697,9.726824
06-07 17:06:55.011+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.021+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:7,1.384621,-1.102813,9.645570
06-07 17:06:55.021+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:16,0.350000,0.210000,-0.070000
06-07 17:06:55.021+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.021+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.021+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.021+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:19,1.390230,-1.148555,9.738789
06-07 17:06:55.021+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.031+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:35,1.418944,-1.134198,9.700503
06-07 17:06:55.031+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:39,1.382762,-1.100704,9.646077
06-07 17:06:55.041+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:42,-0.560000,-0.280000,-0.140000
06-07 17:06:55.041+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.041+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.041+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.051+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:42,-0.018505,-0.070257,0.074408
06-07 17:06:55.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:06:55.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:06:55.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:06:55.061+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.061+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:51,1.392623,-1.115055,9.695717
06-07 17:06:55.071+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:70,-0.630000,-0.140000,-0.140000
06-07 17:06:55.071+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.071+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.071+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:06:55.081+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:53,1.381477,-1.101534,9.646167
06-07 17:06:55.081+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:83,1.363909,-1.141376,9.710074
06-07 17:06:55.081+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.081+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.091+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:06:55:85,525.000000
06-07 17:06:55.091+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:89,1.395016,-1.160519,9.690931
06-07 17:06:55.091+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.091+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:98,1.406980,-1.136591,9.690931
06-07 17:06:55.091+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.091+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:91,1.378214,-1.102534,9.646519
06-07 17:06:55.101+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:80,-0.140000,-0.280000,-0.140000
06-07 17:06:55.101+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.101+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.101+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:108,0.140000,-0.280000,-0.140000
06-07 17:06:55.101+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:74,-0.057369,0.045185,0.044879
06-07 17:06:55.101+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.111+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.111+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:108,1.376052,-1.106287,9.646398
06-07 17:06:55.111+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.121+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:120,1.373842,-1.106783,9.646656
06-07 17:06:55.121+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:06:55.121+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:102,1.395016,-1.141376,9.669396
06-07 17:06:55.121+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.121+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:114,0.070000,0.140000,-0.140000
06-07 17:06:55.121+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.131+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.131+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:138,1.374246,-1.106418,9.646641
06-07 17:06:55.131+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:06:55:131,80
06-07 17:06:55.131+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.141+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:132,1.392623,-1.143769,9.729217
06-07 17:06:55.141+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:117,-0.034476,0.053488,0.035842
06-07 17:06:55.141+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:135,0.140000,-0.070000,-0.140000
06-07 17:06:55.141+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.141+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.151+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:154,1.361516,-1.088734,9.693325
06-07 17:06:55.151+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.151+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.161+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:143,1.370647,-1.102455,9.647606
06-07 17:06:55.161+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:153,0.350000,-0.070000,-0.210000
06-07 17:06:55.161+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.161+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.171+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:159,1.395016,-1.095913,9.714860
06-07 17:06:55.171+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.171+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:164,-0.000611,0.056245,0.020308
06-07 17:06:55.171+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:170,0.420000,0.140000,-0.140000
06-07 17:06:55.171+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:173,1.370240,-1.100955,9.647835
06-07 17:06:55.181+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:177,1.395016,-1.129412,9.683753
06-07 17:06:55.181+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.181+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.181+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.191+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:195,1.373480,-1.074377,9.693325
06-07 17:06:55.191+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:192,0.093942,0.094945,0.000828
06-07 17:06:55.181+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.191+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.201+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:199,0.490000,0.140000,-0.070000
06-07 17:06:55.201+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:205,0.082723,0.069522,0.063515
06-07 17:06:55.201+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.211+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:202,1.374096,-1.099077,9.647501
06-07 17:06:55.211+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.211+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:214,1.423729,-1.124627,9.681360
06-07 17:06:55.211+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.211+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.221+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:223,0.560000,0.140000,-0.070000
06-07 17:06:55.221+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:218,1.374977,-1.097328,9.647574
06-07 17:06:55.221+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.231+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.231+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:228,-0.023651,-0.012460,0.069071
06-07 17:06:55.241+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.241+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.241+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:234,1.385444,-1.162912,9.683753
06-07 17:06:55.251+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:248,0.210000,0.070000,0.070000
06-07 17:06:55.251+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.251+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.261+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:240,1.374073,-1.098385,9.647583
06-07 17:06:55.261+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.271+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:253,0.000415,-0.081958,0.059741
06-07 17:06:55.271+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:264,0.210000,0.070000,0.140000
06-07 17:06:55.271+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:265,1.373480,-1.095913,9.705289
06-07 17:06:55.271+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:06:55.281+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:06:55:284,525.000000
06-07 17:06:55.281+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:273,1.373142,-1.099344,9.647606
06-07 17:06:55.291+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.291+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.291+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.291+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:295,-0.070000,0.070000,0.140000
06-07 17:06:55.301+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.311+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:308,1.375813,-1.100166,9.647132
06-07 17:06:55.311+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.311+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:301,1.351945,-1.100698,9.719646
06-07 17:06:55.311+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:304,0.023443,-0.019917,0.072363
06-07 17:06:55.321+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.321+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.321+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:06:55.331+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:327,-0.070000,-0.070000,0.140000
06-07 17:06:55.331+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:06:55:331,80
06-07 17:06:55.331+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.331+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:318,1.379171,-1.098194,9.646877
06-07 17:06:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:06:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:06:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:06:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:06:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:06:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:06:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:06:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:06:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:06:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:06:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:06:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:06:55.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391215351,000000, pattern:[H:mm][0;m
06-07 17:06:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:06:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:06:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:06:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:06:55.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:06:55.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:06][0;m
06-07 17:06:55.351+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:327,1.385444,-1.103091,9.710074
06-07 17:06:55.351+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.351+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.361+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:343,-0.027172,0.051571,0.072381
06-07 17:06:55.361+0200 W/CAPI_APPFW_APP_CONTROL(15960): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:06:55.361+0200 I/utils   (15960): specific action
06-07 17:06:55.361+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.361+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:06:55.361+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(15960), cmd(0)
06-07 17:06:55.371+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.371+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:365,-0.070000,-0.210000,-0.140000
06-07 17:06:55.371+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:360,1.368695,-1.141376,9.734003
06-07 17:06:55.371+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.371+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.381+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:383,1.368695,-1.165305,9.700503
06-07 17:06:55.381+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:378,-0.024167,0.030365,0.057082
06-07 17:06:55.391+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:371,1.377136,-1.095683,9.647453
06-07 17:06:55.391+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.391+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.391+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.401+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:398,1.404587,-1.129412,9.729217
06-07 17:06:55.401+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:400,-0.004979,-0.003530,0.092307
06-07 17:06:55.401+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.401+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.411+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:380,-0.280000,0.070000,-0.350000
06-07 17:06:55.411+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.411+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:412,1.406980,-1.122234,9.695717
06-07 17:06:55.411+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.421+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:414,0.026109,0.010935,0.063608
06-07 17:06:55.421+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:398,1.377968,-1.097844,9.647089
06-07 17:06:55.421+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:425,1.395016,-1.083949,9.698111
06-07 17:06:55.421+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.431+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.431+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.431+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:432,0.029056,-0.029891,0.035141
06-07 17:06:55.431+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:421,-0.280000,0.140000,-0.420000
06-07 17:06:55.431+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.431+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.431+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:436,1.392623,-1.095913,9.683753
06-07 17:06:55.441+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.441+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:449,1.378266,-1.095913,9.688539
06-07 17:06:55.451+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:445,0.031788,-0.008982,0.071529
06-07 17:06:55.451+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.451+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.451+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:436,1.380548,-1.102691,9.646168
06-07 17:06:55.461+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.461+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:441,0.140000,0.070000,-0.140000
06-07 17:06:55.461+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:459,1.402194,-1.107877,9.717253
06-07 17:06:55.461+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.461+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.461+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:461,0.049634,0.029168,0.071700
06-07 17:06:55.461+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.461+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:471,-0.280000,0.070000,-0.140000
06-07 17:06:55.471+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:474,1.390230,-1.143769,9.681360
06-07 17:06:55.471+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:06:55.481+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:465,1.379047,-1.109600,9.645590
06-07 17:06:55.481+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.481+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:06:55:484,525.000000
06-07 17:06:55.481+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.481+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:478,0.075961,-0.003665,0.050311
06-07 17:06:55.491+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.491+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:493,1.390230,-1.095913,9.774680
06-07 17:06:55.491+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.491+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.501+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:499,0.014189,-0.014672,0.048655
06-07 17:06:55.501+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:487,1.376743,-1.115110,9.645284
06-07 17:06:55.501+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.501+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:505,1.366302,-1.064806,9.712467
06-07 17:06:55.501+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.511+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:514,0.034589,-0.010468,0.092095
06-07 17:06:55.511+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.511+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.521+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:503,-0.210000,0.210000,0.280000
06-07 17:06:55.521+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:525,1.337588,-1.067199,9.707682
06-07 17:06:55.521+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:06:55.521+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:511,1.374396,-1.113802,9.645769
06-07 17:06:55.531+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:06:55:531,80
06-07 17:06:55.531+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:521,-0.002539,-0.074097,0.075636
06-07 17:06:55.531+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.531+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.531+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.541+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.541+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:551,1.397408,-1.155733,9.714860
06-07 17:06:55.541+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:542,0.017195,-0.017969,0.073557
06-07 17:06:55.551+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:541,0.280000,-0.070000,0.280000
06-07 17:06:55.551+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.551+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.551+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.561+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:544,1.371868,-1.106686,9.646948
06-07 17:06:55.561+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:563,1.459622,-1.184447,9.745967
06-07 17:06:55.561+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:559,0.000559,0.065974,0.066384
06-07 17:06:55.561+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.561+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:558,0.490000,-0.070000,0.140000
06-07 17:06:55.571+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.571+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.571+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:574,1.370203,-1.100898,9.647847
06-07 17:06:55.571+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.581+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:576,0.140000,0.210000,-0.070000
06-07 17:06:55.581+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:584,1.406980,-1.150948,9.719646
06-07 17:06:55.581+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.581+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.591+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:581,-0.025105,0.057902,0.075484
06-07 17:06:55.591+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.591+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:595,1.373587,-1.098487,9.647640
06-07 17:06:55.591+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.601+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:590,0.140000,0.210000,-0.070000
06-07 17:06:55.601+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.601+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:604,1.387837,-1.024128,9.757930
06-07 17:06:55.601+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.611+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:609,0.043356,-0.073808,0.055845
06-07 17:06:55.611+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.611+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.621+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:629,0.041067,-0.017099,0.061427
06-07 17:06:55.621+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:624,1.395016,-1.033699,9.669396
06-07 17:06:55.631+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:610,0.070000,-0.070000,-0.350000
06-07 17:06:55.631+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:617,1.380091,-1.103153,9.646180
06-07 17:06:55.631+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.631+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.631+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.641+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.641+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:643,0.070000,-0.140000,0.070000
06-07 17:06:55.641+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.641+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:649,1.378266,-1.086342,9.734003
06-07 17:06:55.641+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:651,0.210000,-0.070000,0.350000
06-07 17:06:55.651+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:641,1.382974,-1.104122,9.645656
06-07 17:06:55.651+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:643,0.008101,0.024566,0.107272
06-07 17:06:55.651+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.651+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.661+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:663,1.395016,-1.198804,9.705289
06-07 17:06:55.661+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.661+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:672,0.047240,-0.041802,0.073447
06-07 17:06:55.671+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:668,1.385771,-1.102687,9.645419
06-07 17:06:55.671+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.671+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.671+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:06:55.681+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.681+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:06:55:684,525.000000
06-07 17:06:55.681+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:686,1.351945,-1.091127,9.702895
06-07 17:06:55.691+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:679,0.210000,-0.070000,0.280000
06-07 17:06:55.691+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.691+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.691+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.701+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:704,1.406980,-1.095913,9.683753
06-07 17:06:55.711+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:697,0.022279,-0.013834,0.092928
06-07 17:06:55.711+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:698,1.385561,-1.098167,9.645965
06-07 17:06:55.711+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.711+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.721+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.721+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:729,1.380659,-1.103091,9.698111
06-07 17:06:55.721+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:06:55.731+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:697,0.770000,0.140000,0.140000
06-07 17:06:55.741+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.741+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:06:55:741,80
06-07 17:06:55.741+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.741+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:748,1.366302,-1.107877,9.717253
06-07 17:06:55.741+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:745,0.770000,-0.070000,-0.350000
06-07 17:06:55.741+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.751+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:723,-0.070806,-0.001609,0.052245
06-07 17:06:55.751+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:755,-0.770000,-0.140000,-0.140000
06-07 17:06:55.751+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.751+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.751+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:733,1.381949,-1.098611,9.646432
06-07 17:06:55.761+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:764,1.387837,-1.119841,9.700503
06-07 17:06:55.761+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.761+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:760,-0.910000,-0.420000,-0.140000
06-07 17:06:55.761+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.761+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.771+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:771,-0.280000,-0.350000,0.070000
06-07 17:06:55.771+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.771+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:778,0.210000,-0.350000,-0.070000
06-07 17:06:55.771+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.781+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:783,1.406980,-1.107877,9.698111
06-07 17:06:55.781+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:55.781+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:55:781,1.374612,-1.103308,9.646944
06-07 17:06:55.781+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer alive timeout
06-07 17:06:55.781+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:06:55.781+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:06:55.781+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:06:55.791+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:55:788,0.490000,0.140000,-0.070000
06-07 17:06:55.791+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:55:777,-0.025919,0.012569,0.080331
06-07 17:06:55.791+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16119
06-07 17:06:55.801+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16119)
06-07 17:06:55.801+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer launch request sent!
06-07 17:06:55.801+0200 I/servicemanager(12566): App control destroyed.
06-07 17:06:55.801+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope alive timeout
06-07 17:06:55.801+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:06:55.801+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:06:55.801+0200 W/CAPI_APPFW_APP_CONTROL(16119): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:06:55.801+0200 I/utils   (16119): specific action
06-07 17:06:55.801+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:06:55.801+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.811+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15981
06-07 17:06:55.811+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:55:813,1.383051,-1.081556,9.643075
06-07 17:06:55.811+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:06:55.811+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(16119), cmd(0)
06-07 17:06:55.811+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15981)
06-07 17:06:55.811+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope launch request sent!
06-07 17:06:55.811+0200 I/servicemanager(12566): App control destroyed.
06-07 17:06:55.811+0200 I/servicemanager(12566): es.ugr.frailty.heartrate alive timeout
06-07 17:06:55.811+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:06:55.811+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:06:55.811+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:06:55.821+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:55.821+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15106
06-07 17:06:55.821+0200 W/CAPI_APPFW_APP_CONTROL(15106): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:06:55.821+0200 I/utils   (15106): specific action
06-07 17:06:55.831+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:06:55.831+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(15106), cmd(0)
06-07 17:06:55.831+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15106)
06-07 17:06:55.831+0200 I/servicemanager(12566): es.ugr.frailty.heartrate launch request sent!
06-07 17:06:55.831+0200 I/servicemanager(12566): App control destroyed.
06-07 17:06:55.831+0200 I/servicemanager(12566): es.ugr.frailty.location alive timeout
06-07 17:06:55.831+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:06:55.831+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:06:55.831+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:06:55.831+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:55.831+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:55.841+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11160716c6f63152838401
