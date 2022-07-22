S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 15903
Date: 2018-06-07 17:06:23+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf720c52d, r5   = 0xf78e8f98
r6   = 0xff900f00, r7   = 0xff900db0
r8   = 0xf78e5c18, r9   = 0x00000000
r10  = 0xff900e8c, fp   = 0xff900f00
ip   = 0x00000001, sp   = 0xff900d88
lr   = 0xf720c539, pc   = 0xf7275228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    275600 KB
Buffers:      6768 KB
Cached:      52864 KB
VmPeak:      53460 KB
VmSize:      53444 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11824 KB
VmRSS:       11820 KB
VmData:      11172 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:         24 KB

Threads Information
Threads: 2
PID = 15903 TID = 15903
15903 15912 

Maps Information
f40d7000 f48d6000 rw-p [stack:15912]
f48dd000 f48df000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f48e7000 f48eb000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f48f4000 f48f6000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f48fe000 f4901000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4910000 f4915000 r-xp /usr/lib/libsystem.so.0.0.0
f4920000 f4923000 r-xp /lib/libattr.so.1.1.0
f492b000 f493b000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4943000 f494c000 r-xp /usr/lib/libedbus.so.1.7.99
f4954000 f4955000 r-xp /usr/lib/libresponse.so.0.2.96
f495e000 f4963000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6205000 f630b000 r-xp /usr/lib/libicuuc.so.57.1
f6321000 f64a9000 r-xp /usr/lib/libicui18n.so.57.1
f64b9000 f64c6000 r-xp /usr/lib/libail.so.0.1.0
f64cf000 f64d6000 r-xp /usr/lib/libminizip.so.1.0.0
f64df000 f6688000 r-xp /usr/lib/libcrypto.so.1.0.0
f66a8000 f66ef000 r-xp /usr/lib/libssl.so.1.0.0
f66fb000 f66fd000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6705000 f670c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6715000 f671c000 r-xp /lib/libcrypt-2.13.so
f674d000 f6750000 r-xp /lib/libcap.so.2.21
f6758000 f675a000 r-xp /usr/lib/libiri.so
f6762000 f67ab000 r-xp /usr/lib/libmdm.so.1.2.69
f67b3000 f67b9000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f67c1000 f67e4000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f67ee000 f67f0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f67f8000 f6815000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f681e000 f6822000 r-xp /usr/lib/libsmack.so.1.0.0
f682b000 f6844000 r-xp /usr/lib/libnetwork.so.0.0.0
f684d000 f6855000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f685d000 f6863000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f686c000 f686e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6877000 f6887000 r-xp /lib/libresolv-2.13.so
f688b000 f68a3000 r-xp /usr/lib/liblzma.so.5.0.3
f68ac000 f68ae000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f68b6000 f68d0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f68d8000 f6907000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6910000 f691f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6929000 f6933000 r-xp /usr/lib/libsensord-shared.so
f693c000 f6a0f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a1a000 f6a30000 r-xp /lib/libz.so.1.2.5
f6a38000 f6a3d000 r-xp /usr/lib/libffi.so.5.0.10
f6a45000 f6a46000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a4e000 f6a5e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a66000 f6a7f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a87000 f6a89000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a91000 f6b06000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b10000 f6b16000 r-xp /lib/librt-2.13.so
f6b1f000 f6b3d000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b47000 f6b48000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b50000 f6b73000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b7b000 f6b80000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b88000 f6bb2000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6bbb000 f6bd2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6bda000 f6c43000 r-xp /lib/libm-2.13.so
f6c4c000 f6ce0000 r-xp /usr/lib/libstdc++.so.6.0.16
f6cf3000 f6cf8000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d00000 f6d07000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d0f000 f6d39000 r-xp /usr/lib/libsensor.so.1.9.6
f6d42000 f6e0e000 r-xp /usr/lib/libxml2.so.2.7.8
f6e1b000 f6e1d000 r-xp /usr/lib/libiniparser.so.0
f6e26000 f6e2c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e35000 f6f05000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f06000 f6f3a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f43000 f6f7f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f87000 f6f8a000 r-xp /usr/lib/libbundle.so.0.1.22
f6f92000 f6f98000 r-xp /usr/lib/libappsvc.so.0.1.0
f6fa0000 f6fe1000 r-xp /usr/lib/libeina.so.1.7.99
f6fea000 f7001000 r-xp /usr/lib/libecore.so.1.7.99
f7018000 f7021000 r-xp /usr/lib/libvconf.so.0.2.45
f7029000 f703d000 r-xp /lib/libpthread-2.13.so
f7048000 f7055000 r-xp /usr/lib/libaul.so.0.1.0
f705f000 f7061000 r-xp /lib/libdl-2.13.so
f706a000 f7075000 r-xp /lib/libunwind.so.8.0.1
f70a2000 f70aa000 r-xp /lib/libgcc_s-4.6.so.1
f70ab000 f71cf000 r-xp /lib/libc-2.13.so
f71dd000 f71df000 r-xp /usr/lib/libdlog.so.0.0.0
f71e7000 f71f3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71fc000 f7201000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7209000 f7218000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7220000 f7224000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f722d000 f7230000 r-xp /usr/lib/libappcore-agent.so.1.1
f7238000 f723a000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7242000 f7246000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f724e000 f726b000 r-xp /lib/ld-2.13.so
f7274000 f7277000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7277000 f727b000 r-xp /usr/lib/libsys-assert.so
f78b5000 f7923000 rw-p [heap]
ff8e2000 ff903000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15903)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7275228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf720c539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f133f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f11c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f1de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f23be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f23dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f5875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f531f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f11c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f1de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f23be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f23dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f55e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f56017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f5df93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48f51fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf48e8171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf69bb663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e68fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e6a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6ffaca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6ff5b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6ff65a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6ff6879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf722e183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf722e7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72755c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf70c285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7274f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
yroscope: SM-R760,07/06/2018,17:06:22:577,0.420000,0.070000,0.140000
06-07 17:06:22.571+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.571+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:22.571+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:22.581+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:22:582,1.316052,-1.210768,9.683753
06-07 17:06:22.581+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:581,1.050000,-0.140000,0.140000
06-07 17:06:22.581+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.581+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:22.581+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:590,0.910000,0.140000,0.280000
06-07 17:06:22.581+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.591+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:594,1.190000,0.140000,0.140000
06-07 17:06:22.591+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.591+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:22.601+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:22:601,1.385444,-1.234696,9.659825
06-07 17:06:22.601+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:599,0.910000,-0.070000,0.140000
06-07 17:06:22.601+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.601+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:610,0.140000,0.140000,-0.070000
06-07 17:06:22.601+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.611+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:614,-0.420000,0.070000,0.070000
06-07 17:06:22.611+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.611+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:620,-0.350000,-0.210000,0.070000
06-07 17:06:22.621+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:22.631+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.631+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:639,0.280000,-0.210000,0.140000
06-07 17:06:22.641+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.641+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:646,0.700000,0.700000,0.140000
06-07 17:06:22.641+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.651+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:653,0.350000,0.700000,0.210000
06-07 17:06:22.651+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:06:22.661+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:06:22:661,525.000000
06-07 17:06:22.661+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.661+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:22:583,1.295668,-1.165455,9.650562
06-07 17:06:22.661+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:22.671+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:667,-0.140000,-0.280000,0.210000
06-07 17:06:22.671+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:22:674,1.296475,-1.167010,9.650266
06-07 17:06:22.671+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.671+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:22:629,1.275374,-1.177269,9.707682
06-07 17:06:22.671+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:22.671+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:22.681+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:681,-0.490000,-0.070000,0.140000
06-07 17:06:22.681+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:22:685,1.298176,-1.167976,9.649920
06-07 17:06:22.691+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:22.691+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.701+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:22:685,1.335195,-1.153341,9.719646
06-07 17:06:22.701+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:702,-0.210000,-0.210000,0.140000
06-07 17:06:22.701+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:22.701+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:06:22.701+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:22:696,1.294807,-1.166772,9.650518
06-07 17:06:22.701+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:22.711+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:22:712,1.296955,-1.166346,9.650281
06-07 17:06:22.711+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:22.711+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:06:22:708,81
06-07 17:06:22.721+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.721+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:727,0.280000,-0.210000,0.140000
06-07 17:06:22.721+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:22:690,0.053637,0.012042,0.057403
06-07 17:06:22.721+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:22.731+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.731+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:22:706,1.347159,-1.170090,9.726824
06-07 17:06:22.731+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:22.741+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:742,0.700000,0.280000,0.140000
06-07 17:06:22.741+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:22:721,1.299468,-1.167207,9.649839
06-07 17:06:22.741+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:22.751+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:22:733,0.017878,0.077923,0.002214
06-07 17:06:22.751+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:22.751+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.761+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:763,1.050000,0.420000,0.210000
06-07 17:06:22.771+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:22:749,1.301968,-1.167761,9.649435
06-07 17:06:22.771+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:22.771+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.771+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:22:761,-0.014921,0.000046,0.102781
06-07 17:06:22.771+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:22.781+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:782,1.050000,0.420000,0.210000
06-07 17:06:22.781+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:22:777,1.304106,-1.169727,9.648909
06-07 17:06:22.781+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:22:744,1.342373,-1.167697,9.671788
06-07 17:06:22.781+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:22.781+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:22.781+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:22:788,1.302362,-1.168894,9.649245
06-07 17:06:22.791+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:22.791+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:22:796,1.302169,-1.166536,9.649556
06-07 17:06:22.791+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:22.791+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.801+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:22:784,0.019835,-0.045851,0.033200
06-07 17:06:22.801+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:22.801+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:803,0.420000,0.420000,0.210000
06-07 17:06:22.801+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:22:788,1.354338,-1.225125,9.705289
06-07 17:06:22.801+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:22.801+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:22:809,1.299965,-1.164068,9.650151
06-07 17:06:22.801+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:22.811+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:22:815,1.298733,-1.164284,9.650291
06-07 17:06:22.811+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:22:807,0.089777,-0.069242,0.009263
06-07 17:06:22.821+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:22.821+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:22:810,1.304088,-1.194018,9.695717
06-07 17:06:22.821+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.821+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:828,0.210000,0.420000,0.280000
06-07 17:06:22.821+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:22.821+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:22.831+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:22:833,1.299024,-1.162136,9.650511
06-07 17:06:22.831+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.831+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:841,0.560000,0.420000,0.140000
06-07 17:06:22.841+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:22:834,1.354338,-1.182054,9.717253
06-07 17:06:22.841+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:22.841+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:22.841+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:22:848,1.297338,-1.162897,9.650646
06-07 17:06:22.841+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:22:849,1.313660,-1.179662,9.741181
06-07 17:06:22.841+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:22.841+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:22:826,-0.021101,-0.010259,0.057416
06-07 17:06:22.841+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:22.851+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:22:855,0.037020,0.014635,0.069725
06-07 17:06:22.851+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:22.851+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:06:22.861+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.861+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:866,1.190000,0.210000,0.070000
06-07 17:06:22.861+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:06:22:862,525.000000
06-07 17:06:22.861+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:22.861+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:22:871,1.297109,-1.163635,9.650588
06-07 17:06:22.871+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.871+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:22:853,1.308874,-1.198804,9.681360
06-07 17:06:22.871+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:22.881+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:882,0.770000,0.070000,0.070000
06-07 17:06:22.881+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:22.881+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:22:877,0.052352,-0.003319,0.076305
06-07 17:06:22.891+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:22.891+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:22:888,1.295043,-1.161851,9.651080
06-07 17:06:22.891+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:22:896,0.045419,-0.001352,0.021507
06-07 17:06:22.891+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:22:884,1.337588,-1.141376,9.700503
06-07 17:06:22.891+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.901+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:22.901+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:22.901+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:903,0.560000,0.210000,0.210000
06-07 17:06:22.901+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:06:22.901+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:22.911+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:22:908,1.295091,-1.160821,9.651197
06-07 17:06:22.911+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:22:914,0.054870,-0.057918,0.055449
06-07 17:06:22.911+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:06:22:910,81
06-07 17:06:22.911+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:22.921+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:22:922,0.002120,-0.026258,0.046282
06-07 17:06:22.921+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.921+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:22.921+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:22:931,1.296243,-1.159697,9.651178
06-07 17:06:22.931+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:928,0.070000,0.140000,0.140000
06-07 17:06:22.931+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:22:907,1.304088,-1.217947,9.702895
06-07 17:06:22.931+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:22.931+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:22.931+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.931+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:942,0.070000,0.210000,0.280000
06-07 17:06:22.941+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:22.941+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:22:938,1.342373,-1.246661,9.724431
06-07 17:06:22.941+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:22.961+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:22:946,1.295259,-1.160231,9.651246
06-07 17:06:22.961+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:22.961+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.971+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:22:939,0.050232,-0.012327,0.068344
06-07 17:06:22.971+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:22.971+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:970,-0.140000,0.280000,0.210000
06-07 17:06:22.971+0200 W/LOCATION(15903): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:06:22.971+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:22.981+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:22:985,0.280000,-0.070000,0.280000
06-07 17:06:22.981+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:22:978,0.011298,-0.010768,0.091936
06-07 17:06:22.981+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:22.991+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:22:992,0.006705,-0.032269,0.031804
06-07 17:06:22.991+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:22.991+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:22:997,0.037623,0.022691,0.050352
06-07 17:06:22.991+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.001+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:2,0.280000,-0.070000,-0.070000
06-07 17:06:23.001+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.001+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:7,0.005356,-0.053663,0.052604
06-07 17:06:23.001+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.001+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:22:955,1.280160,-1.165305,9.686146
06-07 17:06:23.001+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:23.011+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:12,0.043350,-0.084525,0.073920
06-07 17:06:23.011+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.011+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:22:969,1.295483,-1.161141,9.651107
06-07 17:06:23.011+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:17,-0.017178,-0.002408,0.035500
06-07 17:06:23.011+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.011+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:21,0.030908,-0.011241,0.052307
06-07 17:06:23.021+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.021+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.021+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:28,0.280000,0.210000,0.210000
06-07 17:06:23.021+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.031+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:26,0.037759,0.015689,0.030280
06-07 17:06:23.031+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.031+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:23:14,1.328017,-1.174876,9.702895
06-07 17:06:23.031+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:23.031+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:36,0.001818,-0.023626,0.063663
06-07 17:06:23.031+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.031+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:33,1.294414,-1.161515,9.651205
06-07 17:06:23.031+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.041+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:42,0.140000,0.070000,0.350000
06-07 17:06:23.041+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.041+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:48,0.024595,-0.027143,0.073253
06-07 17:06:23.041+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.051+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:23:39,1.332802,-1.146162,9.681360
06-07 17:06:23.061+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:06:23.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:06:23.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:06:23.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:06:23.061+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.061+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:06:23:66,526.000000
06-07 17:06:23.061+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:69,0.280000,-0.070000,0.280000
06-07 17:06:23.071+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:52,-0.007921,-0.026609,0.068399
06-07 17:06:23.071+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.071+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.071+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:43,1.294337,-1.160080,9.651388
06-07 17:06:23.071+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.071+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:80,0.700000,-0.070000,0.140000
06-07 17:06:23.081+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:79,0.001426,0.017372,0.008718
06-07 17:06:23.081+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:23.081+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.081+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:23:89,1.296910,-1.184447,9.714860
06-07 17:06:23.081+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:90,0.026424,-0.006182,0.051690
06-07 17:06:23.081+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:23.081+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.091+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:94,0.040858,-0.007617,0.056293
06-07 17:06:23.091+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.091+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.101+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:102,0.070000,-0.070000,0.140000
06-07 17:06:23.101+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:99,0.026424,-0.025050,0.061007
06-07 17:06:23.101+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:84,1.294414,-1.159397,9.651460
06-07 17:06:23.101+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.101+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:06:23.101+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:109,0.044445,-0.013305,0.037203
06-07 17:06:23.101+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.111+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:113,0.003240,-0.015329,0.054069
06-07 17:06:23.111+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:06:23:109,81
06-07 17:06:23.111+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.111+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.111+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:118,-0.005032,0.072194,0.032558
06-07 17:06:23.121+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.121+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:23:93,1.320838,-1.186840,9.724431
06-07 17:06:23.121+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:23.121+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:127,-0.420000,0.070000,0.280000
06-07 17:06:23.121+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.131+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:132,0.021505,0.024756,0.008652
06-07 17:06:23.131+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:118,1.295535,-1.159178,9.651336
06-07 17:06:23.131+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.131+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.131+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:141,-0.560000,-0.070000,-0.070000
06-07 17:06:23.141+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.141+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:23:129,1.287339,-1.186840,9.719646
06-07 17:06:23.141+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:148,-0.023875,-0.042576,0.087276
06-07 17:06:23.141+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:23.141+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:139,1.296062,-1.159547,9.651220
06-07 17:06:23.151+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.151+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.151+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:161,0.140000,-0.280000,0.070000
06-07 17:06:23.161+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:157,1.297157,-1.158536,9.651195
06-07 17:06:23.161+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.161+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.161+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:166,0.017409,-0.025692,0.070783
06-07 17:06:23.161+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:168,1.296940,-1.158954,9.651174
06-07 17:06:23.161+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:23:153,1.296910,-1.143769,9.659825
06-07 17:06:23.161+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.161+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:23.171+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:173,1.296856,-1.156228,9.651512
06-07 17:06:23.171+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.171+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.181+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:182,0.280000,-0.350000,0.280000
06-07 17:06:23.181+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.181+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:187,0.076183,-0.028973,0.025318
06-07 17:06:23.181+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:179,1.298643,-1.156363,9.651256
06-07 17:06:23.181+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.191+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:194,1.297298,-1.157867,9.651257
06-07 17:06:23.191+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:23:173,1.320838,-1.167697,9.702895
06-07 17:06:23.191+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.191+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:23.191+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.201+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:202,0.490000,-0.350000,0.420000
06-07 17:06:23.201+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.201+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:23:201,1.335195,-1.167697,9.707682
06-07 17:06:23.201+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:23.201+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:206,0.049103,-0.014087,0.080519
06-07 17:06:23.201+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:200,1.298056,-1.158396,9.651091
06-07 17:06:23.211+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.211+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:216,1.301419,-1.158947,9.650572
06-07 17:06:23.211+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:23:221,1.320838,-1.184447,9.712467
06-07 17:06:23.221+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:23.221+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.221+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.221+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:227,-0.210000,0.070000,0.210000
06-07 17:06:23.221+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.231+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:229,0.002670,0.005607,0.028396
06-07 17:06:23.231+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.231+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:241,-0.490000,-0.140000,0.070000
06-07 17:06:23.241+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.241+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:234,1.303053,-1.159539,9.650280
06-07 17:06:23.241+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.251+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:246,0.034535,0.066019,0.088509
06-07 17:06:23.251+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.251+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.251+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:06:23.261+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:264,0.012280,-0.048101,0.067159
06-07 17:06:23.261+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:253,1.303773,-1.160275,9.650094
06-07 17:06:23.261+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:23:251,1.339981,-1.172483,9.688539
06-07 17:06:23.261+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:23.261+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.261+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:06:23:265,524.000000
06-07 17:06:23.271+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:261,-0.770000,-0.070000,-0.280000
06-07 17:06:23.271+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.271+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.281+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:283,-0.025830,-0.074065,0.062428
06-07 17:06:23.281+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:279,1.305990,-1.158239,9.650040
06-07 17:06:23.281+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:287,-0.140000,-0.070000,-0.280000
06-07 17:06:23.281+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:23:274,1.299303,-1.174876,9.705289
06-07 17:06:23.291+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:23.291+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.291+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.291+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.301+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:06:23.301+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:23:297,1.292124,-1.086342,9.683753
06-07 17:06:23.301+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:298,1.306409,-1.160482,9.649714
06-07 17:06:23.301+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:06:23:309,81
06-07 17:06:23.311+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:23.311+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.311+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:305,0.560000,-0.350000,0.070000
06-07 17:06:23.311+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:305,0.035965,-0.021572,0.065146
06-07 17:06:23.321+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.321+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.321+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:23:319,1.318445,-1.134198,9.659825
06-07 17:06:23.331+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:327,0.011211,0.018883,0.017340
06-07 17:06:23.331+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:332,0.770000,-0.210000,0.140000
06-07 17:06:23.331+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:320,1.304841,-1.162652,9.649664
06-07 17:06:23.331+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.331+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:23.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:06:23.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:06:23.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:06:23.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:06:23.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:06:23.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:06:23.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:06:23.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:06:23.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:06:23.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:06:23.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:06:23.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:06:23.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391183348,000000, pattern:[H:mm][0;m
06-07 17:06:23.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:06:23.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:06:23.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:06:23.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:06:23.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:06:23.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:06][0;m
06-07 17:06:23.341+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.341+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.351+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:340,1.305674,-1.161770,9.649657
06-07 17:06:23.361+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:23:342,1.272982,-1.198804,9.738789
06-07 17:06:23.361+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:23.361+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.361+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:357,-0.011157,-0.005928,0.062810
06-07 17:06:23.361+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:23:370,1.316052,-1.182054,9.722038
06-07 17:06:23.361+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.371+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:360,0.700000,-0.070000,0.140000
06-07 17:06:23.371+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.371+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:376,0.022658,-0.008265,0.103164
06-07 17:06:23.381+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:380,0.420000,0.140000,0.140000
06-07 17:06:23.381+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:375,1.305359,-1.159433,9.649981
06-07 17:06:23.381+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:23.381+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.381+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.381+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.391+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:400,0.140000,0.140000,0.140000
06-07 17:06:23.401+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:393,1.303635,-1.158501,9.650326
06-07 17:06:23.401+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:397,0.010025,-0.033125,0.026249
06-07 17:06:23.401+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:23:392,1.373480,-1.186840,9.676575
06-07 17:06:23.401+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.401+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.401+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.401+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:23.421+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:423,0.140000,0.070000,-0.140000
06-07 17:06:23.421+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:23:419,1.347159,-1.172483,9.731609
06-07 17:06:23.431+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:415,1.303620,-1.157956,9.650393
06-07 17:06:23.431+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.431+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:413,0.031575,0.014187,0.126679
06-07 17:06:23.431+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:23.431+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.431+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.441+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:23:444,1.304088,-1.153341,9.678967
06-07 17:06:23.451+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:439,1.303636,-1.158981,9.650269
06-07 17:06:23.451+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:440,-0.004334,-0.051787,0.050235
06-07 17:06:23.451+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:448,-0.420000,-0.420000,0.070000
06-07 17:06:23.451+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.451+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.451+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:06:23.451+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:23.461+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.461+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:06:23:461,525.000000
06-07 17:06:23.471+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:463,0.041474,-0.035172,0.055282
06-07 17:06:23.471+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:466,1.305685,-1.158847,9.650007
06-07 17:06:23.471+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.471+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.471+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:23:468,1.337588,-1.093520,9.738789
06-07 17:06:23.471+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:471,-0.280000,-0.490000,-0.070000
06-07 17:06:23.471+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.481+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:23.491+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:487,1.306437,-1.162023,9.649524
06-07 17:06:23.491+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:485,0.026365,-0.015245,0.070122
06-07 17:06:23.501+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:23:491,1.316052,-1.208375,9.717253
06-07 17:06:23.501+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:487,-0.070000,-0.070000,0.140000
06-07 17:06:23.501+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.501+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:06:23.511+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.511+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.511+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:06:23:515,81
06-07 17:06:23.521+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:519,1.308146,-1.163431,9.649122
06-07 17:06:23.521+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:23.521+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:514,0.027049,-0.035373,0.063345
06-07 17:06:23.531+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.531+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:521,-0.140000,0.350000,0.210000
06-07 17:06:23.541+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.551+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.551+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:23:534,1.280160,-1.232304,9.712467
06-07 17:06:23.561+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:23.561+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:538,-0.016074,-0.001607,-0.001223
06-07 17:06:23.561+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.571+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:560,-0.490000,0.280000,0.350000
06-07 17:06:23.571+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:555,1.308199,-1.163698,9.649083
06-07 17:06:23.571+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.571+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.581+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:23:567,1.342373,-1.182054,9.714860
06-07 17:06:23.581+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:23.581+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:573,-0.000034,-0.047325,0.080487
06-07 17:06:23.581+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:23.581+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:23:579,1.308908,-1.165836,9.648729
06-07 17:06:23.591+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:585,-0.490000,0.070000,0.070000
06-07 17:06:23.591+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:23.591+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:23.601+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:23:591,1.316052,-1.143769,9.667004
06-07 17:06:23.601+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:23:607,-0.490000,-0.070000,0.210000
06-07 17:06:23.601+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:23.611+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:23:595,0.021883,-0.043944,0.068591
06-07 17:06:23.611+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11159036c6f63152838398
