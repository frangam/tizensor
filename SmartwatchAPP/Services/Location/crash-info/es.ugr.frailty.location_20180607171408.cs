S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 18372
Date: 2018-06-07 17:14:08+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf711252d, r5   = 0xf796af98
r6   = 0xffcc99b0, r7   = 0xffcc9860
r8   = 0xf7967c18, r9   = 0x00000000
r10  = 0xffcc993c, fp   = 0xffcc99b0
ip   = 0x00000001, sp   = 0xffcc9838
lr   = 0xf7112539, pc   = 0xf717b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    288832 KB
Buffers:      2676 KB
Cached:      58236 KB
VmPeak:      53556 KB
VmSize:      53552 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11540 KB
VmRSS:       11540 KB
VmData:      11280 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 18372 TID = 18372
18372 18394 

Maps Information
f3fdd000 f47dc000 rw-p [stack:18394]
f47e3000 f47e5000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f47ed000 f47f1000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f47fa000 f47fc000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4804000 f4807000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4816000 f481b000 r-xp /usr/lib/libsystem.so.0.0.0
f4826000 f4829000 r-xp /lib/libattr.so.1.1.0
f4831000 f4841000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4849000 f4852000 r-xp /usr/lib/libedbus.so.1.7.99
f485a000 f485b000 r-xp /usr/lib/libresponse.so.0.2.96
f4864000 f4869000 r-xp /usr/lib/libproc-stat.so.0.2.96
f610b000 f6211000 r-xp /usr/lib/libicuuc.so.57.1
f6227000 f63af000 r-xp /usr/lib/libicui18n.so.57.1
f63bf000 f63cc000 r-xp /usr/lib/libail.so.0.1.0
f63d5000 f63dc000 r-xp /usr/lib/libminizip.so.1.0.0
f63e5000 f658e000 r-xp /usr/lib/libcrypto.so.1.0.0
f65ae000 f65f5000 r-xp /usr/lib/libssl.so.1.0.0
f6601000 f6603000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f660b000 f6612000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f661b000 f6622000 r-xp /lib/libcrypt-2.13.so
f6653000 f6656000 r-xp /lib/libcap.so.2.21
f665e000 f6660000 r-xp /usr/lib/libiri.so
f6668000 f66b1000 r-xp /usr/lib/libmdm.so.1.2.69
f66b9000 f66bf000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f66c7000 f66ea000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f66f4000 f66f6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f66fe000 f671b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6724000 f6728000 r-xp /usr/lib/libsmack.so.1.0.0
f6731000 f674a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6753000 f675b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6763000 f6769000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6772000 f6774000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f677d000 f678d000 r-xp /lib/libresolv-2.13.so
f6791000 f67a9000 r-xp /usr/lib/liblzma.so.5.0.3
f67b2000 f67b4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f67bc000 f67d6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f67de000 f680d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6816000 f6825000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f682f000 f6839000 r-xp /usr/lib/libsensord-shared.so
f6842000 f6915000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6920000 f6936000 r-xp /lib/libz.so.1.2.5
f693e000 f6943000 r-xp /usr/lib/libffi.so.5.0.10
f694b000 f694c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6954000 f6964000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f696c000 f6985000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f698d000 f698f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6997000 f6a0c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a16000 f6a1c000 r-xp /lib/librt-2.13.so
f6a25000 f6a43000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a4d000 f6a4e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a56000 f6a79000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a81000 f6a86000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a8e000 f6ab8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ac1000 f6ad8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ae0000 f6b49000 r-xp /lib/libm-2.13.so
f6b52000 f6be6000 r-xp /usr/lib/libstdc++.so.6.0.16
f6bf9000 f6bfe000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c06000 f6c0d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c15000 f6c3f000 r-xp /usr/lib/libsensor.so.1.9.6
f6c48000 f6d14000 r-xp /usr/lib/libxml2.so.2.7.8
f6d21000 f6d23000 r-xp /usr/lib/libiniparser.so.0
f6d2c000 f6d32000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d3b000 f6e0b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e0c000 f6e40000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e49000 f6e85000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e8d000 f6e90000 r-xp /usr/lib/libbundle.so.0.1.22
f6e98000 f6e9e000 r-xp /usr/lib/libappsvc.so.0.1.0
f6ea6000 f6ee7000 r-xp /usr/lib/libeina.so.1.7.99
f6ef0000 f6f07000 r-xp /usr/lib/libecore.so.1.7.99
f6f1e000 f6f27000 r-xp /usr/lib/libvconf.so.0.2.45
f6f2f000 f6f43000 r-xp /lib/libpthread-2.13.so
f6f4e000 f6f5b000 r-xp /usr/lib/libaul.so.0.1.0
f6f65000 f6f67000 r-xp /lib/libdl-2.13.so
f6f70000 f6f7b000 r-xp /lib/libunwind.so.8.0.1
f6fa8000 f6fb0000 r-xp /lib/libgcc_s-4.6.so.1
f6fb1000 f70d5000 r-xp /lib/libc-2.13.so
f70e3000 f70e5000 r-xp /usr/lib/libdlog.so.0.0.0
f70ed000 f70f9000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7102000 f7107000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f710f000 f711e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7126000 f712a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7133000 f7136000 r-xp /usr/lib/libappcore-agent.so.1.1
f713e000 f7140000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7148000 f714c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7154000 f7171000 r-xp /lib/ld-2.13.so
f717a000 f717d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f717d000 f7181000 r-xp /usr/lib/libsys-assert.so
f7937000 f79c2000 rw-p [heap]
ffcab000 ffccc000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18372)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf717b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7112539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e193f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e17c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e23e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e29be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e29dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e5e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e591f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e17c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e23e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e29be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e29dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e5be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e5c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e63f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47fb1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf47ee171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf68c1663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d6efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d707a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f00ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6efbb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6efc5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6efc879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7134183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71347fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf717b5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6fc885c) [/lib/libc.so.6] + 0x1785c
29: (0xf717af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
gr.frailty.linearacceleration - capturing data
06-07 17:14:07.651+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:07.651+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:07:652,0.308372,-0.092615,9.801363
06-07 17:14:07.661+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:07:665,0.356531,-0.112463,9.918249
06-07 17:14:07.661+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:07.661+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:660,0.006257,0.011797,0.071147
06-07 17:14:07.661+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:07.661+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.671+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:07:674,-0.070000,0.070000,0.070000
06-07 17:14:07.671+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:07.671+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:07:669,0.309038,-0.091900,9.801349
06-07 17:14:07.671+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:676,0.034430,-0.021426,0.099808
06-07 17:14:07.681+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.681+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:07.681+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:07:687,0.309895,-0.092398,9.801317
06-07 17:14:07.681+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:07:683,0.373280,-0.122034,9.887143
06-07 17:14:07.681+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:07.681+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:07.681+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:686,0.056124,-0.067668,0.080652
06-07 17:14:07.691+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:07:694,-0.070000,0.070000,0.070000
06-07 17:14:07.691+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.691+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:07:693,0.375673,-0.090927,9.901501
06-07 17:14:07.691+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:07.701+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:07:704,0.310047,-0.090242,9.801332
06-07 17:14:07.701+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:699,0.035836,-0.042922,0.083088
06-07 17:14:07.701+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:07.701+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.701+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:709,0.014132,0.019727,0.102336
06-07 17:14:07.701+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:07.711+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:07:715,0.070000,0.070000,0.070000
06-07 17:14:07.711+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.711+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:07.711+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:07:720,0.308189,-0.088319,9.801408
06-07 17:14:07.711+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:07:709,0.334995,-0.081356,9.863215
06-07 17:14:07.711+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:07.721+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:720,-0.008643,-0.038455,0.109569
06-07 17:14:07.721+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:07:725,0.327817,-0.100499,9.887143
06-07 17:14:07.721+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:07.721+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.731+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:07.731+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:07:736,0.140000,0.070000,0.070000
06-07 17:14:07.731+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:07.731+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:14:07.731+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:14:07:740,682.000000
06-07 17:14:07.731+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:07:740,0.306187,-0.088078,9.801474
06-07 17:14:07.741+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:07:731,0.313460,-0.045464,9.901501
06-07 17:14:07.741+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:07.741+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:07:747,0.277567,-0.055035,9.851252
06-07 17:14:07.741+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:731,-0.025394,0.005781,0.068878
06-07 17:14:07.741+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:07.741+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.741+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:07.741+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:07.751+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:753,-0.007750,0.052896,0.102366
06-07 17:14:07.751+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:07:758,0.070000,0.070000,0.070000
06-07 17:14:07.751+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:14:07.751+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:14:07.751+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:07:755,0.305508,-0.088894,9.801487
06-07 17:14:07.751+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.761+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:07:752,0.284746,-0.090927,9.925428
06-07 17:14:07.761+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:07.761+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:764,-0.027634,0.009267,0.128632
06-07 17:14:07.761+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:07:768,0.303888,-0.110070,9.918249
06-07 17:14:07.761+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:07.761+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:07.761+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.771+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:07:775,0.140000,0.070000,0.070000
06-07 17:14:07.771+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:775,0.020958,-0.022203,0.114224
06-07 17:14:07.771+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:07:774,0.304966,-0.089514,9.801498
06-07 17:14:07.771+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.771+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:07.781+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:07:784,0.311067,-0.110070,9.915856
06-07 17:14:07.781+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:07.781+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:785,0.006062,-0.008381,0.121342
06-07 17:14:07.781+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:07:789,0.339781,-0.119641,9.868000
06-07 17:14:07.781+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:07.781+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:07.791+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:07:794,0.140000,0.070000,0.070000
06-07 17:14:07.791+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.791+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:07:798,0.305967,-0.090557,9.801457
06-07 17:14:07.791+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:799,0.027021,-0.064975,0.059155
06-07 17:14:07.791+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:07.801+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.801+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:07:805,0.351745,-0.155533,9.839286
06-07 17:14:07.801+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:806,0.007706,0.007241,0.102235
06-07 17:14:07.801+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.801+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:07.801+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:07.811+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:07:815,0.307878,-0.093179,9.801373
06-07 17:14:07.811+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:07:820,0.140000,0.070000,0.070000
06-07 17:14:07.811+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:07.821+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:07:826,0.325424,-0.086142,9.918249
06-07 17:14:07.821+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:812,0.071140,-0.004359,0.061619
06-07 17:14:07.821+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:07.821+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.831+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:834,0.040281,-0.012232,0.061604
06-07 17:14:07.831+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:07:835,0.070000,0.070000,0.070000
06-07 17:14:07.831+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.831+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:839,0.013636,0.021351,0.066473
06-07 17:14:07.831+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:07.831+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.841+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:843,0.012353,-0.006989,0.088053
06-07 17:14:07.841+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.841+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:07:843,0.308087,-0.092627,9.801372
06-07 17:14:07.841+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:07.841+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:848,-0.014011,0.044421,0.078470
06-07 17:14:07.841+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.841+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:07.851+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:853,-0.028428,0.025451,0.076080
06-07 17:14:07.851+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.851+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:07:858,0.070000,0.140000,0.070000
06-07 17:14:07.851+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:858,-0.030812,0.047502,0.088027
06-07 17:14:07.851+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:07.851+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.861+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:863,-0.000071,-0.011432,0.083165
06-07 17:14:07.861+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.861+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:07:850,0.325424,-0.088534,9.923036
06-07 17:14:07.861+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:867,0.032692,-0.035442,0.090270
06-07 17:14:07.861+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.861+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:07:862,0.308131,-0.092188,9.801374
06-07 17:14:07.861+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:07.871+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:07.871+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:07.871+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:872,0.056757,-0.022983,0.116590
06-07 17:14:07.871+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.871+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:879,0.072347,-0.031154,0.085533
06-07 17:14:07.871+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.881+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:07:878,0.306281,-0.074178,9.934999
06-07 17:14:07.881+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:883,0.072680,0.000740,0.099961
06-07 17:14:07.881+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.881+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:07:883,0.307295,-0.091076,9.801411
06-07 17:14:07.881+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:889,0.029140,0.011512,0.061776
06-07 17:14:07.881+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.891+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:07:878,0.070000,0.140000,0.070000
06-07 17:14:07.891+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:07.891+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:894,0.019445,-0.007883,0.085780
06-07 17:14:07.891+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:07.891+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:07.891+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.901+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:07:900,0.305747,-0.089074,9.801477
06-07 17:14:07.901+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:904,0.004422,0.046436,0.100152
06-07 17:14:07.901+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.911+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:07.911+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:07:904,0.289532,-0.057428,9.901501
06-07 17:14:07.911+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:07:916,0.304925,-0.086036,9.801531
06-07 17:14:07.911+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:07:902,0.140000,0.070000,0.070000
06-07 17:14:07.911+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:07.911+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:913,-0.032328,0.037363,0.049934
06-07 17:14:07.921+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.921+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:07.921+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:926,-0.025301,-0.000685,0.124096
06-07 17:14:07.921+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.921+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:14:07.931+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:14:07:935,683.000000
06-07 17:14:07.931+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:930,-0.004301,-0.021751,0.116841
06-07 17:14:07.931+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:07.931+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:07:926,0.140000,0.070000,0.070000
06-07 17:14:07.931+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:07.931+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:07:941,0.303411,-0.086160,9.801577
06-07 17:14:07.941+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.941+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:07:931,0.303888,-0.033500,9.889536
06-07 17:14:07.941+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:07.941+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:946,0.004880,-0.021992,0.114383
06-07 17:14:07.941+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.941+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:07.951+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:07:955,0.304472,-0.086501,9.801540
06-07 17:14:07.951+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:07:942,0.140000,0.070000,0.070000
06-07 17:14:07.951+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:07:951,0.289532,-0.095713,9.856036
06-07 17:14:07.951+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:14:07.951+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:14:07.951+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:07.951+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:951,0.034273,-0.030747,0.066513
06-07 17:14:07.951+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:07.951+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.961+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:07:964,0.140000,-0.070000,0.070000
06-07 17:14:07.961+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:964,0.046779,-0.066019,0.037787
06-07 17:14:07.961+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.961+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:07:968,0.337388,-0.100499,9.920642
06-07 17:14:07.961+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:969,0.019457,0.004416,0.116792
06-07 17:14:07.961+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:07.961+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:07.971+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:07:974,0.304982,-0.087561,9.801516
06-07 17:14:07.971+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.971+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:979,0.017546,0.004644,0.121662
06-07 17:14:07.971+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:07:979,0.140000,0.070000,0.070000
06-07 17:14:07.971+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:07.971+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.981+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:984,-0.001805,0.018450,0.133628
06-07 17:14:07.981+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:07:984,0.330210,-0.117248,9.901501
06-07 17:14:07.981+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.981+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:989,-0.018600,0.034761,0.100126
06-07 17:14:07.981+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:07.981+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:07.981+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:07.991+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:07.991+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:07:994,0.306283,-0.087853,9.801472
06-07 17:14:07.991+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:07:994,-0.003406,0.057576,0.088125
06-07 17:14:07.991+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.001+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:3,-0.016215,-0.006639,0.054559
06-07 17:14:08.001+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:08:3,0.344566,-0.098106,9.889536
06-07 17:14:08.001+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.001+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:07:996,0.070000,0.070000,0.070000
06-07 17:14:08.001+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:08.001+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:8,0.032463,-0.014463,0.119111
06-07 17:14:08.001+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.001+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:08.001+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.011+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:15,0.070000,0.070000,0.070000
06-07 17:14:08.011+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:08:15,0.308511,-0.088359,9.801397
06-07 17:14:08.011+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:13,0.026798,-0.031088,0.099924
06-07 17:14:08.011+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.021+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:23,0.040095,-0.011605,0.087996
06-07 17:14:08.021+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.021+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:08:12,0.366102,-0.102891,9.894321
06-07 17:14:08.021+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:08.021+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:28,0.061120,-0.015330,0.092806
06-07 17:14:08.021+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.021+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:08.021+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.031+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:35,0.140000,0.070000,0.070000
06-07 17:14:08.031+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:08:34,0.310442,-0.088911,9.801332
06-07 17:14:08.031+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:32,0.059819,-0.019824,0.078492
06-07 17:14:08.031+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.031+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:08:32,0.366102,-0.107677,9.879964
06-07 17:14:08.041+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:43,0.009734,0.021360,0.097710
06-07 17:14:08.041+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:08.041+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:08:48,0.318245,-0.066999,9.899107
06-07 17:14:08.041+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:08.041+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.051+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:08:55,0.310205,-0.087657,9.801351
06-07 17:14:08.051+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.051+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:60,-0.032874,0.024305,0.076240
06-07 17:14:08.061+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:08.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:14:08.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:14:08.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:14:08.061+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:69,0.070000,0.070000,0.070000
06-07 17:14:08.091+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:08:66,0.277567,-0.064606,9.877571
06-07 17:14:08.101+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:08.101+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.121+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:08:119,0.308208,-0.086331,9.801425
06-07 17:14:08.121+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:08.121+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:124,-0.030244,-0.036770,0.121685
06-07 17:14:08.131+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:14:08.131+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:14:08:136,682.000000
06-07 17:14:08.131+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.131+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:08.131+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:08:131,0.305797,-0.087779,9.801488
06-07 17:14:08.141+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.141+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:145,-0.030641,0.016939,0.064183
06-07 17:14:08.151+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:08:141,0.279960,-0.124427,9.923036
06-07 17:14:08.151+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:08.151+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.151+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:08.151+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:14:08.151+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:14:08.151+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:14:08.151+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:14:08.151+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:14:08.151+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:14:08.151+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:14:08.151+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:14:08.151+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:14:08.151+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:14:08.151+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:14:08.151+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:14:08.151+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:14:08.151+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:14:08.151+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391648165,000000, pattern:[H:mm][0;m
06-07 17:14:08.151+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:14:08.151+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:14:08.151+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:14:08.151+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:14:08.161+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:14:08.161+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:14][0;m
06-07 17:14:08.171+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:08:156,0.303581,-0.086512,9.801568
06-07 17:14:08.171+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:08:160,0.277567,-0.069392,9.865608
06-07 17:14:08.171+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:171,-0.006694,0.039922,0.119154
06-07 17:14:08.181+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:151,0.070000,0.070000,0.070000
06-07 17:14:08.181+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:08.181+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:08.191+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.191+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.201+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:204,0.140000,0.140000,0.070000
06-07 17:14:08.201+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.201+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:08:190,0.302663,-0.084409,9.801615
06-07 17:14:08.201+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:209,0.140000,0.140000,0.070000
06-07 17:14:08.211+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.211+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:216,0.070000,0.140000,0.070000
06-07 17:14:08.211+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.221+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:08.221+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:222,0.070000,0.140000,0.070000
06-07 17:14:08.221+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.221+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:204,0.024236,0.021906,0.040112
06-07 17:14:08.221+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:08:205,0.299103,-0.047856,9.920642
06-07 17:14:08.221+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:228,-0.070000,0.140000,0.070000
06-07 17:14:08.221+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.231+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:234,0.070000,0.140000,0.070000
06-07 17:14:08.231+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.231+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:08.231+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:240,-0.070000,0.140000,0.070000
06-07 17:14:08.231+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.241+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.241+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:246,0.140000,0.070000,0.070000
06-07 17:14:08.241+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:245,0.032332,-0.032840,0.087921
06-07 17:14:08.241+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.251+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:08:241,0.327817,-0.064606,9.841680
06-07 17:14:08.251+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:255,0.070000,0.070000,0.140000
06-07 17:14:08.251+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.251+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:08:231,0.303084,-0.083278,9.801612
06-07 17:14:08.251+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:08.261+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:262,0.039089,-0.014828,0.080746
06-07 17:14:08.261+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.261+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:08.261+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:268,0.063910,-0.039502,0.109521
06-07 17:14:08.261+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.261+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.271+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:275,0.070000,0.070000,0.070000
06-07 17:14:08.271+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:08:268,0.304585,-0.084925,9.801551
06-07 17:14:08.271+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:273,0.007791,-0.041500,0.076057
06-07 17:14:08.271+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.281+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:285,-0.014307,0.008215,0.057024
06-07 17:14:08.281+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:08.281+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.281+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:08:275,0.334995,-0.117248,9.889536
06-07 17:14:08.291+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:08.291+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:294,0.070000,0.070000,0.070000
06-07 17:14:08.291+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.301+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:303,0.010070,0.059963,0.097701
06-07 17:14:08.301+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:08:291,0.305669,-0.085320,9.801514
06-07 17:14:08.301+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:08.301+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.311+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:08:302,0.342174,-0.098106,9.882358
06-07 17:14:08.311+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:316,0.070000,0.070000,0.070000
06-07 17:14:08.311+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.311+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:08.321+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:08:311,0.308625,-0.087178,9.801405
06-07 17:14:08.321+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:08.331+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.331+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:14:08.331+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:337,0.070000,0.070000,0.070000
06-07 17:14:08.341+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:324,-0.015091,0.037768,0.073731
06-07 17:14:08.341+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:14:08:339,682.000000
06-07 17:14:08.341+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.341+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:08:333,0.308175,-0.088677,9.801406
06-07 17:14:08.351+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.351+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:14:08.351+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:14:08.371+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:360,0.070000,-0.070000,0.070000
06-07 17:14:08.371+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.371+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:08.381+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:08:326,0.368495,-0.124427,9.911072
06-07 17:14:08.381+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:08.391+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:352,-0.012615,-0.003547,0.100023
06-07 17:14:08.391+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.411+0200 W/LOCATION(18372): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:14:08.421+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:08:384,0.307016,-0.088017,9.801448
06-07 17:14:08.421+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:08.421+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:08:428,0.306932,-0.084987,9.801477
06-07 17:14:08.421+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:08.431+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:398,0.000501,-0.038935,0.054507
06-07 17:14:08.431+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.431+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:440,0.006419,-0.012562,0.085579
06-07 17:14:08.431+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.451+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:382,0.070000,0.140000,0.070000
06-07 17:14:08.451+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.451+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:08:388,0.313460,-0.126820,9.877571
06-07 17:14:08.451+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:08.471+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:459,0.140000,0.070000,0.070000
06-07 17:14:08.471+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.471+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:477,0.070000,0.070000,0.070000
06-07 17:14:08.471+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.471+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:482,0.070000,0.070000,0.070000
06-07 17:14:08.481+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:08:461,0.294317,-0.078963,9.858429
06-07 17:14:08.481+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:08.481+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:08:487,0.318245,-0.028714,9.899107
06-07 17:14:08.481+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:08.491+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:08:433,0.305781,-0.083099,9.801529
06-07 17:14:08.491+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:08.491+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:08:499,0.304648,-0.083151,9.801564
06-07 17:14:08.491+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:08.501+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:444,-0.000440,-0.034855,-0.000559
06-07 17:14:08.501+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.511+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:514,0.021518,-0.033063,0.083193
06-07 17:14:08.521+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:08:492,0.291924,-0.050249,9.875179
06-07 17:14:08.521+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:08.521+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.521+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.531+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:14:08.531+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:14:08:536,683.000000
06-07 17:14:08.531+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:08:504,0.304328,-0.084786,9.801560
06-07 17:14:08.531+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:08.541+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:529,-0.070000,0.070000,0.070000
06-07 17:14:08.541+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.541+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:08:527,0.294317,-0.088534,9.901501
06-07 17:14:08.551+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:530,0.062196,-0.016313,0.116692
06-07 17:14:08.551+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.551+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:08:545,0.304413,-0.085138,9.801555
06-07 17:14:08.551+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:08.551+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:14:08.551+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:14:08.561+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:08.561+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:08:570,0.306281,-0.122034,9.856036
06-07 17:14:08.561+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:08.571+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:556,0.021173,-0.019923,0.085607
06-07 17:14:08.571+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.571+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:580,0.016499,0.006898,0.107217
06-07 17:14:08.571+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.581+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:550,-0.070000,0.070000,0.070000
06-07 17:14:08.581+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.591+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:592,-0.070000,0.070000,0.070000
06-07 17:14:08.601+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:08:574,0.311067,-0.095713,9.887143
06-07 17:14:08.601+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:08.601+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:08:609,0.303888,-0.119641,9.801002
06-07 17:14:08.601+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:08.611+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:08:562,0.303906,-0.086578,9.801558
06-07 17:14:08.611+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:08.611+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:08:621,0.304251,-0.087754,9.801537
06-07 17:14:08.621+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.621+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:08:631,0.070000,0.070000,0.070000
06-07 17:14:08.631+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:08:584,0.001743,-0.021117,0.097665
06-07 17:14:08.631+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:08.641+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:08.641+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:08:649,0.306532,-0.088254,9.801461
06-07 17:14:08.641+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:08.651+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11183726c6f63152838444
