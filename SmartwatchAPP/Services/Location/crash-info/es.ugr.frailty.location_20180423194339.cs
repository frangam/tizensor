S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20328
Date: 2018-04-23 19:43:39+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf75f252d, r5   = 0xf7768f98
r6   = 0xffd97ca0, r7   = 0xffd97b50
r8   = 0xf7765c18, r9   = 0x00000000
r10  = 0xffd97c2c, fp   = 0xffd97ca0
ip   = 0x00000001, sp   = 0xffd97b28
lr   = 0xf75f2539, pc   = 0xf765b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      9952 KB
Buffers:     56460 KB
Cached:     231752 KB
VmPeak:      53460 KB
VmSize:      53440 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11804 KB
VmRSS:       11800 KB
VmData:      11168 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20328 TID = 20328
20328 20370 

Maps Information
f44bd000 f4cbc000 rw-p [stack:20370]
f4cc3000 f4cc5000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ccd000 f4cd1000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4cda000 f4cdc000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4ce4000 f4ce7000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4cf6000 f4cfb000 r-xp /usr/lib/libsystem.so.0.0.0
f4d06000 f4d09000 r-xp /lib/libattr.so.1.1.0
f4d11000 f4d21000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d29000 f4d32000 r-xp /usr/lib/libedbus.so.1.7.99
f4d3a000 f4d3b000 r-xp /usr/lib/libresponse.so.0.2.96
f4d44000 f4d49000 r-xp /usr/lib/libproc-stat.so.0.2.96
f65eb000 f66f1000 r-xp /usr/lib/libicuuc.so.57.1
f6707000 f688f000 r-xp /usr/lib/libicui18n.so.57.1
f689f000 f68ac000 r-xp /usr/lib/libail.so.0.1.0
f68b5000 f68bc000 r-xp /usr/lib/libminizip.so.1.0.0
f68c5000 f6a6e000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a8e000 f6ad5000 r-xp /usr/lib/libssl.so.1.0.0
f6ae1000 f6ae3000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6aeb000 f6af2000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6afb000 f6b02000 r-xp /lib/libcrypt-2.13.so
f6b33000 f6b36000 r-xp /lib/libcap.so.2.21
f6b3e000 f6b40000 r-xp /usr/lib/libiri.so
f6b48000 f6b91000 r-xp /usr/lib/libmdm.so.1.2.69
f6b99000 f6b9f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6ba7000 f6bca000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6bd4000 f6bd6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6bde000 f6bfb000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c04000 f6c08000 r-xp /usr/lib/libsmack.so.1.0.0
f6c11000 f6c2a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c33000 f6c3b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c43000 f6c49000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c52000 f6c54000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c5d000 f6c6d000 r-xp /lib/libresolv-2.13.so
f6c71000 f6c89000 r-xp /usr/lib/liblzma.so.5.0.3
f6c92000 f6c94000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c9c000 f6cb6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6cbe000 f6ced000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6cf6000 f6d05000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d0f000 f6d19000 r-xp /usr/lib/libsensord-shared.so
f6d22000 f6df5000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e00000 f6e16000 r-xp /lib/libz.so.1.2.5
f6e1e000 f6e23000 r-xp /usr/lib/libffi.so.5.0.10
f6e2b000 f6e2c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e34000 f6e44000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e4c000 f6e65000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e6d000 f6e6f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e77000 f6eec000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ef6000 f6efc000 r-xp /lib/librt-2.13.so
f6f05000 f6f23000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f2d000 f6f2e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f36000 f6f59000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f61000 f6f66000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f6e000 f6f98000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6fa1000 f6fb8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6fc0000 f7029000 r-xp /lib/libm-2.13.so
f7032000 f70c6000 r-xp /usr/lib/libstdc++.so.6.0.16
f70d9000 f70de000 r-xp /usr/lib/libctx-client.so.0.8.3
f70e6000 f70ed000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70f5000 f711f000 r-xp /usr/lib/libsensor.so.1.9.6
f7128000 f71f4000 r-xp /usr/lib/libxml2.so.2.7.8
f7201000 f7203000 r-xp /usr/lib/libiniparser.so.0
f720c000 f7212000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f721b000 f72eb000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f72ec000 f7320000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7329000 f7365000 r-xp /usr/lib/libSLP-location.so.0.9.24
f736d000 f7370000 r-xp /usr/lib/libbundle.so.0.1.22
f7378000 f737e000 r-xp /usr/lib/libappsvc.so.0.1.0
f7386000 f73c7000 r-xp /usr/lib/libeina.so.1.7.99
f73d0000 f73e7000 r-xp /usr/lib/libecore.so.1.7.99
f73fe000 f7407000 r-xp /usr/lib/libvconf.so.0.2.45
f740f000 f7423000 r-xp /lib/libpthread-2.13.so
f742e000 f743b000 r-xp /usr/lib/libaul.so.0.1.0
f7445000 f7447000 r-xp /lib/libdl-2.13.so
f7450000 f745b000 r-xp /lib/libunwind.so.8.0.1
f7488000 f7490000 r-xp /lib/libgcc_s-4.6.so.1
f7491000 f75b5000 r-xp /lib/libc-2.13.so
f75c3000 f75c5000 r-xp /usr/lib/libdlog.so.0.0.0
f75cd000 f75d9000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75e2000 f75e7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75ef000 f75fe000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7606000 f760a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7613000 f7616000 r-xp /usr/lib/libappcore-agent.so.1.1
f761e000 f7620000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7628000 f762c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7634000 f7651000 r-xp /lib/ld-2.13.so
f765a000 f765d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f765d000 f7661000 r-xp /usr/lib/libsys-assert.so
f7735000 f77a4000 rw-p [heap]
ffd79000 ffd9a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20328)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf765b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf75f2539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72f93f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf72f7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7303e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7309be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7309dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf733e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73391f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf72f7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7303e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7309be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7309dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf733be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf733c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7343f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4cdb1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4cce171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6da1663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf724efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72507a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf73e0ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf73dbb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73dc5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf73dc879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7614183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76147fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf765b4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf74a885c) [/lib/libc.so.6] + 0x1785c
29: (0xf765af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
4-23 19:43:38.589+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:38.599+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:38.599+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:38.599+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:38:603,1.264227,2.328585,9.441917
04-23 19:43:38.599+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:38.599+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:38:600,1.330000,5.390000,-3.990000
04-23 19:43:38.599+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:38:608,1.259407,2.322516,9.444057
04-23 19:43:38.609+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:38:608,-0.036708,0.016381,-0.332442
04-23 19:43:38.609+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:38:606,1.227518,2.344966,9.109475
04-23 19:43:38.609+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:38.609+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:38.609+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:38:618,1.529014,2.275574,9.145369
04-23 19:43:38.609+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:38.609+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:38.619+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:38:618,0.210000,7.770000,-3.360000
04-23 19:43:38.619+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:38:622,0.269606,-0.046941,-0.298688
04-23 19:43:38.619+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:38:622,1.242826,2.315835,9.447892
04-23 19:43:38.629+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:38.629+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:38.629+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:38:637,0.207224,-0.358506,-0.577699
04-23 19:43:38.629+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:38.629+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:38.639+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:38:636,1.450050,1.957329,8.870193
04-23 19:43:38.639+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:38:642,1.239599,2.303821,9.451253
04-23 19:43:38.639+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:38:642,0.070000,8.890000,-1.890000
04-23 19:43:38.649+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:38.649+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:38.659+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:38.659+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:38:657,0.105168,-0.298635,-0.200601
04-23 19:43:38.659+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:38.659+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:38:663,1.231717,2.286077,9.456591
04-23 19:43:38.659+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:38:660,1.344766,2.005185,9.250652
04-23 19:43:38.669+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:38:667,5.250000,12.110000,-2.730000
04-23 19:43:38.669+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:38.669+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:38:676,1.225384,2.283383,9.458064
04-23 19:43:38.669+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:38.669+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:38.669+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:38.679+0200 I/heartrate(20311): capturing data from es.ugr.frailty.heartrate
04-23 19:43:38.679+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:38:680,10.850000,9.310000,-2.170000
04-23 19:43:38.679+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:38:682,1.186840,2.036292,9.884750
04-23 19:43:38.689+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:38.699+0200 I/heartrate(20311): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:43:38:683,73
04-23 19:43:38.699+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:38.709+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:38.709+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:38:702,1.221872,2.296865,9.455254
04-23 19:43:38.709+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:38.719+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:38:680,-0.044876,-0.249785,0.428160
04-23 19:43:38.719+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:38:715,1.579263,2.208575,10.291530
04-23 19:43:38.729+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:38.729+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:38:709,16.870001,4.270000,-1.540000
04-23 19:43:38.729+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:38.739+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:38:720,1.239076,2.312873,9.449111
04-23 19:43:38.739+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:38.739+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:38:746,1.732404,2.411965,9.848858
04-23 19:43:38.739+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:38.759+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:38:740,0.357391,-0.088290,0.836276
04-23 19:43:38.759+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:38:743,14.630000,1.470000,0.420000
04-23 19:43:38.759+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:38.759+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:38.759+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:38:754,1.266760,2.321076,9.443427
04-23 19:43:38.769+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:38.769+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:38.769+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:38:768,0.510532,0.115100,0.393604
04-23 19:43:38.779+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:38:774,1.643869,1.986043,10.011569
04-23 19:43:38.779+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:38:782,1.301698,2.316479,9.439803
04-23 19:43:38.779+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:38:770,1.330000,-3.150000,1.750000
04-23 19:43:38.789+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:38.789+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:38.789+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:38:794,0.404793,-0.326830,0.562458
04-23 19:43:38.789+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:38.789+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:38.789+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:43:38.789+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:43:38.799+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:38.799+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:38:798,0.458465,-0.820776,0.814603
04-23 19:43:38.799+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:38.799+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:38:804,0.593417,-0.670217,0.976153
04-23 19:43:38.799+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:38.799+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:38:798,1.725225,1.500300,10.258030
04-23 19:43:38.799+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:38:796,-0.070000,-9.660000,0.140000
04-23 19:43:38.799+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:38.799+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:38:808,0.552754,-0.080710,1.410145
04-23 19:43:38.799+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:38.809+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:38:804,1.351933,2.310821,9.434128
04-23 19:43:38.809+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:38.809+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:38:812,1.895115,1.646262,10.415956
04-23 19:43:38.809+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:38.809+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:38:817,0.764377,0.001496,0.970585
04-23 19:43:38.809+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:38:818,1.904687,2.230111,10.844273
04-23 19:43:38.809+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:38.819+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:38:822,2.179861,2.316252,10.394422
04-23 19:43:38.819+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:38.819+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:38:811,8.960000,-12.950000,-1.470000
04-23 19:43:38.819+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:38.819+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:38:828,1.415484,2.314757,9.423837
04-23 19:43:38.829+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:38:830,7.420000,-18.340000,0.350000
04-23 19:43:38.829+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:38.829+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:38.829+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:38.829+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:38.829+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:38:834,-4.270000,-24.990000,2.730000
04-23 19:43:38.829+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:38.839+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:38:837,0.723850,-0.856640,1.412189
04-23 19:43:38.839+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:38:840,-15.960000,-36.049999,3.150000
04-23 19:43:38.839+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:38:840,2.196611,1.476372,10.822738
04-23 19:43:38.839+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:38:835,1.472761,2.333011,9.410548
04-23 19:43:38.839+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:38.839+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:38:849,1.551367,2.345763,9.394734
04-23 19:43:38.849+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:38.859+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:38.859+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:38.859+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:38:856,-2.590000,-45.220001,-7.700000
04-23 19:43:38.859+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:38.859+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:38:866,1.652025,2.380267,9.368859
04-23 19:43:38.869+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:38:863,0.358106,-2.398405,0.887224
04-23 19:43:38.869+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:38.869+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:38:877,30.590000,-45.360001,-9.240000
04-23 19:43:38.869+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:38.869+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:38:865,1.909473,-0.052642,10.281959
04-23 19:43:38.869+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:38.879+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:38.879+0200 I/heartrate(20311): capturing data from es.ugr.frailty.heartrate
04-23 19:43:38.879+0200 I/heartrate(20311): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:43:38:884,73
04-23 19:43:38.879+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:38:882,2.969493,1.450050,10.238889
04-23 19:43:38.879+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:38:884,1.317469,-0.930216,0.870029
04-23 19:43:38.889+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:38:882,1.786376,2.367070,9.347525
04-23 19:43:38.889+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:38.889+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:38.889+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:38.899+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:38:901,28.350000,-47.320000,-10.150000
04-23 19:43:38.899+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:38.899+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:38:901,1.912928,0.781884,-0.295477
04-23 19:43:38.899+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:38:901,1.939319,2.437411,9.298841
04-23 19:43:38.899+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:38:907,3.699304,3.148954,9.052048
04-23 19:43:38.909+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:38.909+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:38.909+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:38.909+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:38:917,-6.090000,-47.599998,-9.730000
04-23 19:43:38.909+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:38.919+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:38:922,4.335794,2.993421,7.345965
04-23 19:43:38.919+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:38:916,2.096371,2.524186,9.241434
04-23 19:43:38.919+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:38:919,2.396475,0.556010,-1.952876
04-23 19:43:38.929+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:38.929+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:38.929+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:38.929+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:38.929+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:38:937,-69.440002,-46.830002,-9.660000
04-23 19:43:38.939+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:38:937,2.250162,2.502855,9.211020
04-23 19:43:38.939+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:38:938,2.591169,-0.657785,-1.105837
04-23 19:43:38.939+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:38:939,4.687540,1.866402,8.135597
04-23 19:43:38.949+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:38.949+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:38.949+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:38.949+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:38.959+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:38:960,-129.289993,-54.180000,-17.500000
04-23 19:43:38.959+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:38:957,2.354309,2.301090,9.237564
04-23 19:43:38.959+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:38:960,2.796300,-1.617511,-0.850497
04-23 19:43:38.959+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:38:961,5.046463,0.885344,8.360522
04-23 19:43:38.969+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:38.969+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:38.969+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:38.969+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:38.969+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:38:977,-159.460007,-52.639999,-35.000000
04-23 19:43:38.979+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:38:977,2.413714,2.001801,9.291780
04-23 19:43:38.979+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:38:979,5.618347,-2.237289,8.671589
04-23 19:43:38.979+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:38:979,3.264038,-4.538379,-0.565975
04-23 19:43:38.989+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:43:38.989+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:43:38.989+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:38.999+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:38.999+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:38.999+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:38.999+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:1,-151.270004,-39.970001,-53.549999
04-23 19:43:38.999+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:39:6,5.771489,-2.155933,8.729016
04-23 19:43:39.009+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:39.009+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:7,3.357775,-4.157734,-0.562763
04-23 19:43:39.009+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.009+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:6,2.411272,1.592684,9.371206
04-23 19:43:39.009+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.009+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:39.019+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:18,-166.389999,-27.230000,-66.639999
04-23 19:43:39.019+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:39:16,4.618148,-1.808974,7.925028
04-23 19:43:39.029+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:25,2.206876,-3.401658,-1.446178
04-23 19:43:39.029+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:22,6.181065,3.140253,6.935678
04-23 19:43:39.029+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:39.029+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.029+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:39:38,4.991428,-1.797010,8.666803
04-23 19:43:39.039+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:39.039+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:39,-165.970001,-34.369999,-77.559998
04-23 19:43:39.039+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.039+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:43,-1.189637,-4.937263,1.731125
04-23 19:43:39.039+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:46,6.676365,3.049381,6.503677
04-23 19:43:39.049+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.059+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:43:39.059+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:43:39.059+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:43:39.059+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:59,-117.529999,-20.790001,-88.900002
04-23 19:43:39.059+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:39.069+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.069+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:39.079+0200 I/heartrate(20311): capturing data from es.ugr.frailty.heartrate
04-23 19:43:39.079+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:39:80,4.847858,-2.347359,9.305687
04-23 19:43:39.089+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:79,6.972223,2.969102,6.224382
04-23 19:43:39.089+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.089+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:39.089+0200 W/LOCATION(20328): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:43:39.089+0200 I/heartrate(20311): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:43:39:88,73
04-23 19:43:39.099+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.099+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:72,-1.828506,-5.396740,2.802010
04-23 19:43:39.099+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:103,-54.670002,-9.660000,-91.139999
04-23 19:43:39.099+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.109+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:39.109+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:39:96,4.015156,-1.768296,9.480364
04-23 19:43:39.109+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:39.109+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:94,7.124136,2.879467,6.093089
04-23 19:43:39.109+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.109+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:114,5.040000,-10.290000,-96.110001
04-23 19:43:39.119+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:119,7.168025,2.822433,6.068251
04-23 19:43:39.119+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:115,-2.957067,-4.737398,3.255982
04-23 19:43:39.119+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.129+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:39.129+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.129+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:39:117,2.545963,-2.256432,10.600205
04-23 19:43:39.129+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:39.139+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:138,-4.578174,-5.135899,4.507116
04-23 19:43:39.139+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:132,7.127013,2.938679,6.061372
04-23 19:43:39.139+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:134,89.879997,-32.830002,-100.800003
04-23 19:43:39.139+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.139+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.139+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:39.139+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:147,6.826333,3.132787,6.305331
04-23 19:43:39.159+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:39:142,1.909473,-2.557927,11.023734
04-23 19:43:39.159+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:39.159+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:148,260.399994,-23.730000,-112.770004
04-23 19:43:39.159+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.169+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:39:164,2.653640,-1.332802,9.310472
04-23 19:43:39.169+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:39.169+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:151,-5.258553,-5.380361,4.955483
04-23 19:43:39.179+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.179+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:39.179+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:173,2.837844,1.636363,9.243340
04-23 19:43:39.179+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:185,306.110016,3.430000,-100.309998
04-23 19:43:39.189+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:188,-4.473372,-4.271482,3.249100
04-23 19:43:39.189+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.189+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.189+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:43:39.189+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:43:39.189+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:39:179,2.021935,1.471586,8.863015
04-23 19:43:39.199+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:39.199+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:39.199+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:206,-4.804398,-1.661201,2.557684
04-23 19:43:39.199+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:198,220.500000,-10.570000,-83.650002
04-23 19:43:39.199+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.209+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:197,3.007297,2.142217,9.085012
04-23 19:43:39.209+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.209+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:39.209+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:39:206,0.401994,4.780859,8.291130
04-23 19:43:39.209+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:39.209+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:39:218,0.370888,5.158926,7.922636
04-23 19:43:39.209+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:216,-2.435850,3.144497,-0.952210
04-23 19:43:39.209+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:39.219+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:212,119.910004,-35.420002,-77.910004
04-23 19:43:39.219+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.219+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:39.219+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:214,3.049477,2.603914,8.949341
04-23 19:43:39.219+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.229+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:228,70.629997,-22.400000,-64.820000
04-23 19:43:39.229+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:231,-2.636409,3.016709,-1.162376
04-23 19:43:39.239+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.239+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:39.239+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:232,3.010012,2.946199,8.856078
04-23 19:43:39.239+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.239+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:39:222,0.954736,5.541777,7.623533
04-23 19:43:39.239+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:39.249+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:243,39.689999,-16.520000,-55.299999
04-23 19:43:39.249+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:246,-2.094741,2.937863,-1.325808
04-23 19:43:39.249+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.249+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:39.259+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:249,2.961406,3.216718,8.777994
04-23 19:43:39.259+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.259+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:39:252,0.375673,5.522634,8.068598
04-23 19:43:39.259+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:259,18.830000,-14.280000,-44.240002
04-23 19:43:39.259+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:39.259+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:263,-2.634339,2.576435,-0.787480
04-23 19:43:39.269+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:39.269+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.269+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:266,2.868466,3.421108,8.731456
04-23 19:43:39.269+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.279+0200 I/heartrate(20311): capturing data from es.ugr.frailty.heartrate
04-23 19:43:39.279+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:39:270,0.617348,5.166104,8.415558
04-23 19:43:39.279+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:39.279+0200 I/heartrate(20311): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:43:39:284,73
04-23 19:43:39.289+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:278,14.980000,-6.930000,-38.500000
04-23 19:43:39.289+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:281,2.770064,3.583611,8.697981
04-23 19:43:39.289+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:274,-2.344058,1.949387,-0.362436
04-23 19:43:39.289+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.299+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:39:287,0.141177,4.333402,8.774480
04-23 19:43:39.299+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:39.299+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:39.299+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.299+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:303,10.920000,-4.200000,-27.160000
04-23 19:43:39.299+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:308,2.647863,3.697064,8.688552
04-23 19:43:39.309+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:306,-2.727289,0.912294,0.043024
04-23 19:43:39.309+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:39.309+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.309+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.309+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:317,-5.670000,-9.240000,-17.150000
04-23 19:43:39.309+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:319,2.539052,3.792614,8.679844
04-23 19:43:39.319+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:315,-2.700672,1.359961,-0.363780
04-23 19:43:39.319+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:39:306,0.069392,4.943572,8.334201
04-23 19:43:39.319+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:39.319+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:39.329+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.329+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.339+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:339,-10.990000,-7.910000,-13.440001
04-23 19:43:39.339+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:331,-1.980265,1.593467,-0.677382
04-23 19:43:39.339+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:39:333,0.667598,5.290531,8.011170
04-23 19:43:39.339+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:39.339+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:39.339+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:347,-1.244535,1.129423,-0.714138
04-23 19:43:39.349+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:341,2.461011,3.878660,8.664284
04-23 19:43:39.349+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:39:346,1.294517,4.922036,7.965706
04-23 19:43:39.349+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.349+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.359+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:362,-9.590000,-2.170000,-7.980000
04-23 19:43:39.359+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:39.359+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:356,2.408046,3.935539,8.653509
04-23 19:43:39.359+0200 I/servicemanager(20291): es.ugr.frailty.location sleep timeout
04-23 19:43:39.359+0200 W/AUL     (20291): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 19:43:39.359+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:43:39.359+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20291
04-23 19:43:39.369+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20328
04-23 19:43:39.379+0200 W/AUL     (20291): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20328)
04-23 19:43:39.379+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.379+0200 I/servicemanager(20291): es.ugr.frailty.location stop request sent!
04-23 19:43:39.379+0200 I/servicemanager(20291): App control destroyed.
04-23 19:43:39.379+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.379+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:385,2.370951,3.960078,8.652557
04-23 19:43:39.379+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:367,-0.788428,0.839986,-0.686613
04-23 19:43:39.389+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:39.389+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:39:394,1.672583,4.718646,7.977671
04-23 19:43:39.389+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:39.389+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:385,-12.460000,1.890000,-0.770000
04-23 19:43:39.389+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:43:39.389+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:43:39.389+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.389+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.399+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:403,2.329132,3.940690,8.672744
04-23 19:43:39.399+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:400,-0.986710,0.263865,-0.024990
04-23 19:43:39.399+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:39.409+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:39.409+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:403,-16.030001,-0.700000,8.960000
04-23 19:43:39.409+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.409+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:39:411,1.421337,4.199404,8.628519
04-23 19:43:39.409+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.409+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:418,2.300144,3.919192,8.690205
04-23 19:43:39.419+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:39.419+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:414,-0.794081,0.457072,0.205672
04-23 19:43:39.429+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:39.429+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:420,-19.809999,-4.200000,10.990000
04-23 19:43:39.429+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.429+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.439+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:439,2.292948,3.880554,8.709424
04-23 19:43:39.439+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:39:429,1.576870,4.417150,8.858230
04-23 19:43:39.439+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:438,-18.059999,-3.430000,10.220000
04-23 19:43:39.439+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:39.439+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:434,-0.189949,0.256321,0.561159
04-23 19:43:39.439+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:39:448,2.139183,4.197011,9.233903
04-23 19:43:39.449+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:39.449+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.459+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:39.459+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.459+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:454,0.068751,-0.507027,1.149081
04-23 19:43:39.459+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:463,2.297539,3.793275,8.746586
04-23 19:43:39.459+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:458,-19.879999,-4.620000,13.020000
04-23 19:43:39.459+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:39.469+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.469+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.469+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:478,2.319439,3.716593,8.773684
04-23 19:43:39.479+0200 I/heartrate(20311): capturing data from es.ugr.frailty.heartrate
04-23 19:43:39.479+0200 I/heartrate(20311): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:43:39:483,73
04-23 19:43:39.479+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:39:467,2.368894,3.412165,9.839286
04-23 19:43:39.479+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:39.489+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:473,0.566475,-0.480353,1.400251
04-23 19:43:39.489+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:39.489+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:477,-24.360001,-8.960000,14.490000
04-23 19:43:39.489+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.489+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.499+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:502,2.352848,3.610224,8.809130
04-23 19:43:39.509+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.509+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:518,2.416564,3.557038,8.813517
04-23 19:43:39.529+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.529+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:538,2.492978,3.556083,8.792594
04-23 19:43:39.549+0200 E/AUL_AMD ( 2478): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 19:43:39.549+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 19:43:39.549+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20328), cmd(0)
04-23 19:43:39.579+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.589+0200 W/libgps_d( 3158): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 19:43:39.589+0200 W/libgps  ( 3158): [proxy__gps_stop][line = 1067]: called.
04-23 19:43:39.589+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:43:39.589+0200 W/libgps_d( 3158): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 19:43:39.589+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 19:43:39.589+0200 W/libgps_d( 3158): GpsiHookStateGps              : EXIT
04-23 19:43:39.589+0200 W/libgps_d( 3158): GpsiHookStateIdle             : ENTRY
04-23 19:43:39.589+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:0, msg id:2
04-23 19:43:39.599+0200 E/CAPI_LOCATION_MANAGER(18958): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 19:43:39.599+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:43:39.599+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:43:39.599+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:590,2.543842,3.500008,8.800523
04-23 19:43:39.599+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.609+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:43:39.619+0200 W/AUL     (20382): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 19:43:39.619+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 19:43:39.619+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 19:43:39.619+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 19638
04-23 19:43:39.619+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 19:43:39.619+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 19638
04-23 19:43:39.619+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(19638)
04-23 19:43:39.619+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:39:492,2.859423,3.400201,10.109675
04-23 19:43:39.629+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:39.629+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:497,0.645633,-1.060671,1.217128
04-23 19:43:39.629+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:503,-14.000000,-6.230000,14.420000
04-23 19:43:39.629+0200 I/linearacceleration(20340): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:39.629+0200 I/gyroscope(20305): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:39.639+0200 I/accelerometer(20302): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:39:635,2.943172,2.732604,9.963714
04-23 19:43:39.659+0200 I/accelerometer(20302): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:39.659+0200 I/gravity (20351): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:39:612,2.609603,3.444242,8.803269
04-23 19:43:39.659+0200 I/linearacceleration(20340): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:39:642,1.339187,-0.538924,0.137188
04-23 19:43:39.659+0200 I/gyroscope(20305): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:39:647,-6.160000,-3.920000,15.470000
04-23 19:43:39.659+0200 I/gravity (20351): capturing data from es.ugr.frailty.gravity
04-23 19:43:39.679+0200 W/CRASH_MANAGER(20380): worker.c: worker_job(1205) > 11203286c6f63152450541
