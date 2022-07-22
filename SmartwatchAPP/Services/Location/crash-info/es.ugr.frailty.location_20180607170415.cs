S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 15309
Date: 2018-06-07 17:04:15+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6fec52d, r5   = 0xf76bf958
r6   = 0xff81cbc0, r7   = 0xff81ca70
r8   = 0xf76d2c18, r9   = 0x00000000
r10  = 0xff81cb4c, fp   = 0xff81cbc0
ip   = 0x00000001, sp   = 0xff81ca48
lr   = 0xf6fec539, pc   = 0xf7055228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    293100 KB
Buffers:     11712 KB
Cached:      53728 KB
VmPeak:      53632 KB
VmSize:      53628 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11712 KB
VmRSS:       11712 KB
VmData:      11356 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 15309 TID = 15309
15309 15315 

Maps Information
f3eb7000 f46b6000 rw-p [stack:15315]
f46bd000 f46bf000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f46c7000 f46cb000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f46d4000 f46d6000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f46de000 f46e1000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f46f0000 f46f5000 r-xp /usr/lib/libsystem.so.0.0.0
f4700000 f4703000 r-xp /lib/libattr.so.1.1.0
f470b000 f471b000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4723000 f472c000 r-xp /usr/lib/libedbus.so.1.7.99
f4734000 f4735000 r-xp /usr/lib/libresponse.so.0.2.96
f473e000 f4743000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5fe5000 f60eb000 r-xp /usr/lib/libicuuc.so.57.1
f6101000 f6289000 r-xp /usr/lib/libicui18n.so.57.1
f6299000 f62a6000 r-xp /usr/lib/libail.so.0.1.0
f62af000 f62b6000 r-xp /usr/lib/libminizip.so.1.0.0
f62bf000 f6468000 r-xp /usr/lib/libcrypto.so.1.0.0
f6488000 f64cf000 r-xp /usr/lib/libssl.so.1.0.0
f64db000 f64dd000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f64e5000 f64ec000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f64f5000 f64fc000 r-xp /lib/libcrypt-2.13.so
f652d000 f6530000 r-xp /lib/libcap.so.2.21
f6538000 f653a000 r-xp /usr/lib/libiri.so
f6542000 f658b000 r-xp /usr/lib/libmdm.so.1.2.69
f6593000 f6599000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f65a1000 f65c4000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f65ce000 f65d0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f65d8000 f65f5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f65fe000 f6602000 r-xp /usr/lib/libsmack.so.1.0.0
f660b000 f6624000 r-xp /usr/lib/libnetwork.so.0.0.0
f662d000 f6635000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f663d000 f6643000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f664c000 f664e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6657000 f6667000 r-xp /lib/libresolv-2.13.so
f666b000 f6683000 r-xp /usr/lib/liblzma.so.5.0.3
f668c000 f668e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6696000 f66b0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f66b8000 f66e7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f66f0000 f66ff000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6709000 f6713000 r-xp /usr/lib/libsensord-shared.so
f671c000 f67ef000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f67fa000 f6810000 r-xp /lib/libz.so.1.2.5
f6818000 f681d000 r-xp /usr/lib/libffi.so.5.0.10
f6825000 f6826000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f682e000 f683e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6846000 f685f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6867000 f6869000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6871000 f68e6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f68f0000 f68f6000 r-xp /lib/librt-2.13.so
f68ff000 f691d000 r-xp /usr/lib/libsystemd.so.0.4.0
f6927000 f6928000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6930000 f6953000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f695b000 f6960000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6968000 f6992000 r-xp /usr/lib/libdbus-1.so.3.8.12
f699b000 f69b2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f69ba000 f6a23000 r-xp /lib/libm-2.13.so
f6a2c000 f6ac0000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ad3000 f6ad8000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ae0000 f6ae7000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6aef000 f6b19000 r-xp /usr/lib/libsensor.so.1.9.6
f6b22000 f6bee000 r-xp /usr/lib/libxml2.so.2.7.8
f6bfb000 f6bfd000 r-xp /usr/lib/libiniparser.so.0
f6c06000 f6c0c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c15000 f6ce5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6ce6000 f6d1a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d23000 f6d5f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6d67000 f6d6a000 r-xp /usr/lib/libbundle.so.0.1.22
f6d72000 f6d78000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d80000 f6dc1000 r-xp /usr/lib/libeina.so.1.7.99
f6dca000 f6de1000 r-xp /usr/lib/libecore.so.1.7.99
f6df8000 f6e01000 r-xp /usr/lib/libvconf.so.0.2.45
f6e09000 f6e1d000 r-xp /lib/libpthread-2.13.so
f6e28000 f6e35000 r-xp /usr/lib/libaul.so.0.1.0
f6e3f000 f6e41000 r-xp /lib/libdl-2.13.so
f6e4a000 f6e55000 r-xp /lib/libunwind.so.8.0.1
f6e82000 f6e8a000 r-xp /lib/libgcc_s-4.6.so.1
f6e8b000 f6faf000 r-xp /lib/libc-2.13.so
f6fbd000 f6fbf000 r-xp /usr/lib/libdlog.so.0.0.0
f6fc7000 f6fd3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6fdc000 f6fe1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6fe9000 f6ff8000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7000000 f7004000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f700d000 f7010000 r-xp /usr/lib/libappcore-agent.so.1.1
f7018000 f701a000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7022000 f7026000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f702e000 f704b000 r-xp /lib/ld-2.13.so
f7054000 f7057000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7057000 f705b000 r-xp /usr/lib/libsys-assert.so
f76a2000 f7740000 rw-p [heap]
ff7fe000 ff81f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15309)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7055228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf6fec539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6cf33f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6cf1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6cfde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6d03be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6d03dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6d3875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6d331f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6cf1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6cfde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6d03be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6d03dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6d35e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6d36017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6d3df93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf46d51fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf46c8171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf679b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6c48fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6c4a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6ddaca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6dd5b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6dd65a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6dd6879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf700e183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf700e7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70555c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6ea285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7054f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ta
06-07 17:04:14.351+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:354,0.011416,0.285140,0.062975
06-07 17:04:14.351+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.351+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.351+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:359,8.807083,1.124204,4.164353
06-07 17:04:14.351+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.361+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:361,8.822337,1.411765,4.218546
06-07 17:04:14.361+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:365,-2.730000,1.330000,0.350000
06-07 17:04:14.361+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:04:14.361+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.371+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.371+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:375,8.810372,1.258625,4.161119
06-07 17:04:14.371+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:375,0.003289,0.134421,-0.003235
06-07 17:04:14.371+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.371+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:04:14:374,424.000000
06-07 17:04:14.371+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.371+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:379,-6.300000,1.330000,1.750000
06-07 17:04:14.381+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:383,8.802154,1.130852,4.172967
06-07 17:04:14.381+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.381+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.391+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.391+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:394,0.022576,-0.006225,0.040793
06-07 17:04:14.391+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.391+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:394,8.824730,1.124627,4.213760
06-07 17:04:14.391+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:398,8.802943,1.129589,4.171642
06-07 17:04:14.391+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:396,-5.110000,-0.770000,2.310000
06-07 17:04:14.401+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.401+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.411+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:415,0.081607,-0.088711,0.116296
06-07 17:04:14.411+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.411+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:04:14.421+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.421+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:04:14:422,76
06-07 17:04:14.421+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:415,-1.960000,0.280000,2.030000
06-07 17:04:14.421+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:421,8.884550,1.040878,4.287938
06-07 17:04:14.421+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:426,8.804159,1.124453,4.170464
06-07 17:04:14.431+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.431+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.441+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.441+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.441+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:446,8.855836,1.124627,4.216154
06-07 17:04:14.441+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:446,8.803701,1.118158,4.173123
06-07 17:04:14.441+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:440,-0.070000,1.400000,1.120000
06-07 17:04:14.441+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.451+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:441,0.051677,0.000174,0.045690
06-07 17:04:14.451+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.451+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.451+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:457,0.025814,0.083039,-0.007219
06-07 17:04:14.451+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.451+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:454,-2.030000,1.120000,1.330000
06-07 17:04:14.461+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:464,8.803163,1.114785,4.175162
06-07 17:04:14.461+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:464,8.829515,1.201197,4.165904
06-07 17:04:14.461+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.461+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.471+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:475,-0.038254,-0.186370,-0.090614
06-07 17:04:14.471+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:475,-5.950000,0.070000,1.750000
06-07 17:04:14.471+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.471+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.481+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:481,8.802051,1.112173,4.178200
06-07 17:04:14.481+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:481,8.764909,0.928415,4.084548
06-07 17:04:14.491+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.491+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.491+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:496,-6.790000,-0.630000,0.350000
06-07 17:04:14.491+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:497,0.084893,-0.219651,0.097774
06-07 17:04:14.491+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.491+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.501+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:503,8.800998,1.099086,4.183878
06-07 17:04:14.501+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:503,8.886944,0.892523,4.275974
06-07 17:04:14.511+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.511+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.511+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:517,0.088339,-0.024708,0.058597
06-07 17:04:14.511+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:517,-0.210000,1.610000,-0.560000
06-07 17:04:14.511+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.511+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.521+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:524,8.889337,1.074377,4.242475
06-07 17:04:14.521+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:523,8.798576,1.090004,4.191339
06-07 17:04:14.531+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.531+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.541+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:543,0.052474,0.171014,0.043956
06-07 17:04:14.541+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:543,1.750000,2.380000,0.140000
06-07 17:04:14.541+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.541+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.541+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.541+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.551+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:555,-0.035203,0.190194,0.075649
06-07 17:04:14.551+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:549,8.797720,1.089967,4.193146
06-07 17:04:14.551+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.551+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:555,-1.120000,1.190000,1.260000
06-07 17:04:14.551+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:551,8.851050,1.261017,4.235296
06-07 17:04:14.561+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.561+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:564,8.796758,1.094930,4.193872
06-07 17:04:14.561+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.561+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:04:14.571+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.571+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:575,-4.200000,-0.840000,1.680000
06-07 17:04:14.571+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:575,-0.034241,-0.015767,0.046209
06-07 17:04:14.571+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:568,8.762517,1.280160,4.268795
06-07 17:04:14.571+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.581+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:04:14:575,422.000000
06-07 17:04:14.581+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.581+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.591+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.591+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:595,0.061039,-0.071457,0.047681
06-07 17:04:14.601+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:596,-1.190000,-0.140000,1.540000
06-07 17:04:14.601+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:589,8.794797,1.097977,4.197186
06-07 17:04:14.601+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.611+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.611+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:04:14.621+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:04:14:622,76
06-07 17:04:14.621+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:617,0.081676,0.021362,0.036483
06-07 17:04:14.621+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.621+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:610,8.795696,1.093693,4.196420
06-07 17:04:14.631+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:585,8.762517,1.079163,4.240082
06-07 17:04:14.631+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.631+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.631+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.631+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:633,0.840000,2.030000,0.980000
06-07 17:04:14.631+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.641+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:640,0.000037,0.193256,0.052682
06-07 17:04:14.641+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:637,8.855836,1.026521,4.244867
06-07 17:04:14.641+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.641+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:636,8.795979,1.089296,4.196971
06-07 17:04:14.641+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.641+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.651+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:642,0.840000,2.310000,2.100000
06-07 17:04:14.651+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.651+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:654,-0.025721,0.090032,0.118197
06-07 17:04:14.651+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:650,8.877372,1.115055,4.232903
06-07 17:04:14.651+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.661+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:652,8.797809,1.087237,4.193670
06-07 17:04:14.661+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.661+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:664,8.796017,1.282553,4.249653
06-07 17:04:14.661+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.661+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:668,8.797239,1.089872,4.194180
06-07 17:04:14.661+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:656,-3.080000,0.840000,2.660000
06-07 17:04:14.661+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.671+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.671+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:675,0.027491,0.128075,0.167935
06-07 17:04:14.671+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:675,-3.360000,1.050000,3.080000
06-07 17:04:14.671+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.671+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:670,8.772088,1.177269,4.311867
06-07 17:04:14.671+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.681+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:681,8.796247,1.086588,4.197112
06-07 17:04:14.681+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:682,8.824730,1.217947,4.362115
06-07 17:04:14.681+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.681+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.691+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:694,-6.090000,3.080000,3.990000
06-07 17:04:14.691+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.691+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:695,0.009340,0.262964,-0.059922
06-07 17:04:14.691+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.691+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:699,8.805587,1.349552,4.137190
06-07 17:04:14.691+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:700,8.792415,1.082138,4.206281
06-07 17:04:14.711+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.711+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.711+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:717,-11.970000,1.680000,6.160000
06-07 17:04:14.711+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:718,-0.058612,0.320056,0.040979
06-07 17:04:14.711+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.711+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.721+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:724,8.733803,1.402194,4.247260
06-07 17:04:14.721+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:725,8.793043,1.077173,4.206242
06-07 17:04:14.731+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.731+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.741+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:742,-14.560000,-0.420000,8.260000
06-07 17:04:14.741+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:743,-0.054455,0.169487,0.067339
06-07 17:04:14.741+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.741+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.741+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.741+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.751+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:754,-11.130000,-0.420000,9.380000
06-07 17:04:14.751+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:750,8.794219,1.069277,4.205800
06-07 17:04:14.751+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:749,8.738588,1.246661,4.273581
06-07 17:04:14.751+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:755,0.035296,0.103206,0.036675
06-07 17:04:14.751+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.751+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.761+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:764,8.829515,1.172483,4.242475
06-07 17:04:14.761+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:766,8.800104,1.054427,4.197230
06-07 17:04:14.761+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.761+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.771+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:774,-5.950000,2.030000,10.710000
06-07 17:04:14.771+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:04:14.781+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:04:14:782,422.000000
06-07 17:04:14.781+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.801+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.821+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:04:14.831+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:04:14:832,76
06-07 17:04:14.841+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:790,8.817552,1.272982,4.192225
06-07 17:04:14.841+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:806,-3.780000,3.360000,12.600000
06-07 17:04:14.841+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.851+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:850,-8.260000,2.730000,14.350000
06-07 17:04:14.851+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.861+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.861+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:857,-6.790000,2.100000,15.470000
06-07 17:04:14.871+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.871+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:874,8.812766,1.174876,4.144369
06-07 17:04:14.871+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:876,3.220000,0.700000,15.330000
06-07 17:04:14.871+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.881+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:882,17.150000,0.210000,15.890000
06-07 17:04:14.881+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:775,0.017447,0.218555,-0.005005
06-07 17:04:14.901+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.901+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.901+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.901+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:906,8.812766,1.057628,4.378866
06-07 17:04:14.901+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.911+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.921+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:911,20.930000,3.850000,16.940001
06-07 17:04:14.921+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:908,0.001604,0.137336,-0.033828
06-07 17:04:14.921+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.921+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:916,8.811162,1.037540,4.178196
06-07 17:04:14.921+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.921+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.921+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:931,8.825337,1.024415,4.151431
06-07 17:04:14.931+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:931,14.140000,6.580000,20.510000
06-07 17:04:14.931+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:915,8.729016,0.765703,4.493721
06-07 17:04:14.931+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.931+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:926,-0.012571,0.033212,0.227435
06-07 17:04:14.931+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.931+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.941+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.941+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:941,5.110000,5.110000,24.219999
06-07 17:04:14.941+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:946,8.841014,1.001546,4.123562
06-07 17:04:14.941+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.941+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.951+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:944,8.685946,0.610170,4.524827
06-07 17:04:14.951+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.951+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:955,3.360000,3.220000,25.900000
06-07 17:04:14.951+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:959,8.738588,0.591027,4.386044
06-07 17:04:14.951+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.961+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:942,-0.111998,-0.235843,0.370158
06-07 17:04:14.961+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.961+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:967,-0.170438,-0.362196,0.427347
06-07 17:04:14.961+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.961+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:04:14.961+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:950,8.856384,0.972366,4.097480
06-07 17:04:14.971+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.971+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.971+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:971,-0.140064,-0.345647,0.328638
06-07 17:04:14.971+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.971+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:975,7.840000,5.670000,26.389999
06-07 17:04:14.971+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:979,-0.059587,0.076746,0.180796
06-07 17:04:14.971+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:14.971+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:04:14:976,419.000000
06-07 17:04:14.981+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:976,8.878653,0.936675,4.057406
06-07 17:04:14.981+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.981+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:988,8.910638,0.901919,3.994679
06-07 17:04:14.981+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:14.981+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:14.991+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:964,8.851050,0.978664,4.175476
06-07 17:04:14.991+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.991+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:14:994,11.480000,8.750000,26.880001
06-07 17:04:14.991+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:14:997,8.779266,1.182054,4.103691
06-07 17:04:14.991+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:14.991+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:15:2,8.724231,0.806381,4.259224
06-07 17:04:15.001+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:14:982,-0.164789,0.313846,0.176800
06-07 17:04:15.001+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:15.001+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:15:7,-0.250751,-0.037773,0.398205
06-07 17:04:15.001+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:15.001+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:15.011+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:15.011+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:15:16,9.450000,10.920000,29.330000
06-07 17:04:15.011+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:04:15.021+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:04:15:22,76
06-07 17:04:15.021+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:15:12,8.807980,0.495314,4.316652
06-07 17:04:15.021+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:15.021+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:15:29,8.846266,0.404387,4.278367
06-07 17:04:15.021+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:15.021+0200 W/LOCATION(15309): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:04:15.031+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:15:34,8.817552,0.564706,4.259224
06-07 17:04:15.031+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:15.031+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:15.031+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:14:992,8.944056,0.868208,3.926890
06-07 17:04:15.031+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:15.031+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:15:41,4.970000,10.640000,32.480000
06-07 17:04:15.041+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:15:10,-0.196892,-0.323589,0.520329
06-07 17:04:15.041+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:15:46,8.748159,0.794417,4.237689
06-07 17:04:15.041+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:15.051+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:15:43,8.974982,0.844154,3.861020
06-07 17:04:15.051+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:15.051+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:04:15.051+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:04:15.051+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:04:15.061+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:15:57,9.004871,0.818904,3.796323
06-07 17:04:15.061+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:15:55,6.510000,10.500000,35.560001
06-07 17:04:15.061+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:15.061+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:15.061+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:15.071+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:15:75,14.700000,14.280000,37.939999
06-07 17:04:15.071+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:15.071+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:15:72,9.038981,0.771846,3.724439
06-07 17:04:15.071+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:15.071+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:15:81,-0.192716,-0.367459,0.553927
06-07 17:04:15.081+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:15:72,8.602197,0.595813,4.113262
06-07 17:04:15.081+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:15.081+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:15:83,9.076782,0.713146,3.643326
06-07 17:04:15.081+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:15.081+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:15.091+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:15.091+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:15:93,-0.259231,-0.148440,0.615898
06-07 17:04:15.091+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:15.091+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:15:94,9.114986,0.653803,3.558083
06-07 17:04:15.091+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:15.101+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:15:96,27.370001,17.430000,38.220001
06-07 17:04:15.101+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:15:89,8.657232,0.428315,4.110869
06-07 17:04:15.101+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:15.101+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:15:105,9.150559,0.599351,3.475402
06-07 17:04:15.111+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:15:104,-0.366827,0.140614,0.679605
06-07 17:04:15.111+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:15.111+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:15:117,38.990002,24.570000,38.009998
06-07 17:04:15.111+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:15.111+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:15.111+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:15:109,8.719445,0.002393,4.043870
06-07 17:04:15.121+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:15.121+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:15:122,9.183953,0.550036,3.394531
06-07 17:04:15.121+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:15.121+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:15:122,-0.548363,-0.003538,0.637860
06-07 17:04:15.121+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:15.121+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:15:132,-0.526721,-0.121721,0.716338
06-07 17:04:15.131+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:15:130,9.225178,0.487736,3.290684
06-07 17:04:15.131+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:15.141+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:15:144,9.269403,0.419572,3.173724
06-07 17:04:15.151+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:15.151+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:15.151+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:15:156,9.319645,0.338391,3.033165
06-07 17:04:15.151+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:15:156,29.190001,31.990000,38.500000
06-07 17:04:15.151+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:15.151+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:15:160,16.030001,33.740002,40.040001
06-07 17:04:15.161+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:15.161+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:15:126,8.709875,-0.244068,3.964907
06-07 17:04:15.161+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:15.161+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:15.161+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:15:166,9.366049,0.255880,2.895175
06-07 17:04:15.171+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:04:15.171+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:15.171+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:04:15:176,425.000000
06-07 17:04:15.171+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:15.171+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:15:180,18.900000,31.639999,35.980000
06-07 17:04:15.181+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:15:176,9.398388,0.184654,2.794027
06-07 17:04:15.181+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:15:168,8.889337,-0.016750,4.094120
06-07 17:04:15.181+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:15.181+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:15.181+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:15:187,8.688338,0.320638,4.211368
06-07 17:04:15.181+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:15.181+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:15.191+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:15:171,-0.505733,-0.485343,0.753187
06-07 17:04:15.191+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:15.191+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:15:191,9.419942,0.125444,2.723848
06-07 17:04:15.191+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:15.191+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:15:197,-0.559527,-0.663640,0.791183
06-07 17:04:15.191+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:15.191+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:15:200,-0.430308,-0.355141,1.060955
06-07 17:04:15.191+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:15.201+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:15:194,44.660000,23.240000,32.549999
06-07 17:04:15.201+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:15:200,9.438214,0.063515,2.662040
06-07 17:04:15.201+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:15.201+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:15:192,8.496914,-0.011964,4.905287
06-07 17:04:15.201+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:15.211+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:15.211+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:15:210,9.462786,-0.014713,2.574075
06-07 17:04:15.211+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:15.211+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:15:216,58.730000,18.270000,29.049999
06-07 17:04:15.211+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:04:15.221+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:04:15:222,76
06-07 17:04:15.221+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:15:204,-0.677711,0.064758,1.316192
06-07 17:04:15.221+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:15.221+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:15:221,9.485989,-0.090506,2.485601
06-07 17:04:15.221+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:15:230,-0.901474,-0.196618,2.111260
06-07 17:04:15.221+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:15.231+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:15:212,8.458629,-0.906880,6.053841
06-07 17:04:15.231+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:15.231+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:15.231+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:15.231+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:15:240,54.180000,15.820000,28.420000
06-07 17:04:15.231+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:15:241,9.499963,-0.141835,2.429192
06-07 17:04:15.241+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:15:237,8.327023,-1.234696,6.005985
06-07 17:04:15.241+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:15.241+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:15:248,8.317451,-0.691526,5.326423
06-07 17:04:15.241+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:15.241+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:15.251+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:15:255,9.511047,-0.184480,2.382505
06-07 17:04:15.251+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:15:255,57.820000,15.190001,28.490000
06-07 17:04:15.251+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:15:234,-0.961313,-1.032324,3.329993
06-07 17:04:15.251+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:15.251+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:15.261+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:15:262,-1.111192,-1.298212,3.343944
06-07 17:04:15.261+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:15.261+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:15:265,8.240881,-0.567099,4.857430
06-07 17:04:15.261+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:15.261+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:15.271+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:15.271+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:15:275,77.980003,18.760000,26.880001
06-07 17:04:15.271+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:15:276,9.510911,-0.204673,2.381400
06-07 17:04:15.271+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:15:268,-1.145334,-0.676812,2.752348
06-07 17:04:15.271+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:15.281+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:15:273,8.126025,-0.435494,4.302295
06-07 17:04:15.281+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:15.281+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:15.281+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:15.291+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:15:295,109.760002,26.320000,22.260000
06-07 17:04:15.291+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:15:295,9.495672,-0.206200,2.441326
06-07 17:04:15.291+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:15:283,-1.245108,-0.476593,2.371829
06-07 17:04:15.291+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:15.301+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:15:290,8.386844,-0.760918,4.797609
06-07 17:04:15.301+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:15.301+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:15:301,-1.373938,-0.293658,1.873103
06-07 17:04:15.301+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:15.301+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:15:309,-1.124204,-0.576438,2.415104
06-07 17:04:15.301+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:15.311+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:15.311+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:15.321+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:15:318,9.462076,-0.178673,2.570521
06-07 17:04:15.321+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:15:319,145.600006,32.200001,18.549999
06-07 17:04:15.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:04:15.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:04:15.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:04:15.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:04:15.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:04:15.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:04:15.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:04:15.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:04:15.331+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:15.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:04:15.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:04:15.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:04:15.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:04:15.331+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391055344,000000, pattern:[H:mm][0;m
06-07 17:04:15.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:04:15.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:04:15.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:04:15.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:04:15.331+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:04:15.331+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:04][0;m
06-07 17:04:15.341+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:15:345,9.407609,-0.105660,2.766969
06-07 17:04:15.341+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11153096c6f63152838385
