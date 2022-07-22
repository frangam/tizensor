S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 15521
Date: 2018-06-07 17:05:03+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf773452d, r5   = 0xf7ed7f98
r6   = 0xffab2e70, r7   = 0xffab2d20
r8   = 0xf7ed4c18, r9   = 0x00000000
r10  = 0xffab2dfc, fp   = 0xffab2e70
ip   = 0x00000001, sp   = 0xffab2cf8
lr   = 0xf7734539, pc   = 0xf779d228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    249536 KB
Buffers:     13396 KB
Cached:      66504 KB
VmPeak:      53520 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11388 KB
VmRSS:       11384 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 15521 TID = 15521
15521 15528 

Maps Information
f45ff000 f4dfe000 rw-p [stack:15528]
f4e05000 f4e07000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4e0f000 f4e13000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4e1c000 f4e1e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4e26000 f4e29000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4e38000 f4e3d000 r-xp /usr/lib/libsystem.so.0.0.0
f4e48000 f4e4b000 r-xp /lib/libattr.so.1.1.0
f4e53000 f4e63000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e6b000 f4e74000 r-xp /usr/lib/libedbus.so.1.7.99
f4e7c000 f4e7d000 r-xp /usr/lib/libresponse.so.0.2.96
f4e86000 f4e8b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f672d000 f6833000 r-xp /usr/lib/libicuuc.so.57.1
f6849000 f69d1000 r-xp /usr/lib/libicui18n.so.57.1
f69e1000 f69ee000 r-xp /usr/lib/libail.so.0.1.0
f69f7000 f69fe000 r-xp /usr/lib/libminizip.so.1.0.0
f6a07000 f6bb0000 r-xp /usr/lib/libcrypto.so.1.0.0
f6bd0000 f6c17000 r-xp /usr/lib/libssl.so.1.0.0
f6c23000 f6c25000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6c2d000 f6c34000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6c3d000 f6c44000 r-xp /lib/libcrypt-2.13.so
f6c75000 f6c78000 r-xp /lib/libcap.so.2.21
f6c80000 f6c82000 r-xp /usr/lib/libiri.so
f6c8a000 f6cd3000 r-xp /usr/lib/libmdm.so.1.2.69
f6cdb000 f6ce1000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6ce9000 f6d0c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6d16000 f6d18000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6d20000 f6d3d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d46000 f6d4a000 r-xp /usr/lib/libsmack.so.1.0.0
f6d53000 f6d6c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d75000 f6d7d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d85000 f6d8b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d94000 f6d96000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d9f000 f6daf000 r-xp /lib/libresolv-2.13.so
f6db3000 f6dcb000 r-xp /usr/lib/liblzma.so.5.0.3
f6dd4000 f6dd6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6dde000 f6df8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6e00000 f6e2f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e38000 f6e47000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e51000 f6e5b000 r-xp /usr/lib/libsensord-shared.so
f6e64000 f6f37000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f42000 f6f58000 r-xp /lib/libz.so.1.2.5
f6f60000 f6f65000 r-xp /usr/lib/libffi.so.5.0.10
f6f6d000 f6f6e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f76000 f6f86000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f8e000 f6fa7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6faf000 f6fb1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6fb9000 f702e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f7038000 f703e000 r-xp /lib/librt-2.13.so
f7047000 f7065000 r-xp /usr/lib/libsystemd.so.0.4.0
f706f000 f7070000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7078000 f709b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f70a3000 f70a8000 r-xp /usr/lib/libxdgmime.so.1.1.0
f70b0000 f70da000 r-xp /usr/lib/libdbus-1.so.3.8.12
f70e3000 f70fa000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7102000 f716b000 r-xp /lib/libm-2.13.so
f7174000 f7208000 r-xp /usr/lib/libstdc++.so.6.0.16
f721b000 f7220000 r-xp /usr/lib/libctx-client.so.0.8.3
f7228000 f722f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7237000 f7261000 r-xp /usr/lib/libsensor.so.1.9.6
f726a000 f7336000 r-xp /usr/lib/libxml2.so.2.7.8
f7343000 f7345000 r-xp /usr/lib/libiniparser.so.0
f734e000 f7354000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f735d000 f742d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f742e000 f7462000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f746b000 f74a7000 r-xp /usr/lib/libSLP-location.so.0.9.24
f74af000 f74b2000 r-xp /usr/lib/libbundle.so.0.1.22
f74ba000 f74c0000 r-xp /usr/lib/libappsvc.so.0.1.0
f74c8000 f7509000 r-xp /usr/lib/libeina.so.1.7.99
f7512000 f7529000 r-xp /usr/lib/libecore.so.1.7.99
f7540000 f7549000 r-xp /usr/lib/libvconf.so.0.2.45
f7551000 f7565000 r-xp /lib/libpthread-2.13.so
f7570000 f757d000 r-xp /usr/lib/libaul.so.0.1.0
f7587000 f7589000 r-xp /lib/libdl-2.13.so
f7592000 f759d000 r-xp /lib/libunwind.so.8.0.1
f75ca000 f75d2000 r-xp /lib/libgcc_s-4.6.so.1
f75d3000 f76f7000 r-xp /lib/libc-2.13.so
f7705000 f7707000 r-xp /usr/lib/libdlog.so.0.0.0
f770f000 f771b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7724000 f7729000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7731000 f7740000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7748000 f774c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7755000 f7758000 r-xp /usr/lib/libappcore-agent.so.1.1
f7760000 f7762000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f776a000 f776e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7776000 f7793000 r-xp /lib/ld-2.13.so
f779c000 f779f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f779f000 f77a3000 r-xp /usr/lib/libsys-assert.so
f7ea4000 f7f15000 rw-p [heap]
ffa94000 ffab5000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15521)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf779d228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7734539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf743b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7439c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7445e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf744bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf744bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf748075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf747b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7439c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7445e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf744bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf744bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf747de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf747e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7485f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4e1d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4e10171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ee3663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7390fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73927a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7522ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf751db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf751e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf751e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7756183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf77567fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf779d5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf75ea85c) [/lib/libc.so.6] + 0x1785c
29: (0xf779cf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
on(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:02.441+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:02:448,0.023260,-0.032038,0.061411
06-07 17:05:02.441+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:02.441+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:05:02.441+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.451+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:05:02:455,79
06-07 17:05:02.451+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:455,1.789831,-0.942772,9.645468
06-07 17:05:02.451+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.451+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:02:453,-0.070000,0.140000,0.350000
06-07 17:05:02.451+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:445,1.751798,-0.951999,9.601837
06-07 17:05:02.451+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:461,1.749153,-0.923629,9.683753
06-07 17:05:02.461+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.461+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:466,1.753038,-0.954173,9.601396
06-07 17:05:02.461+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.461+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.461+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:02.471+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:02:472,0.023045,-0.052207,0.078334
06-07 17:05:02.471+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:02.471+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:472,1.787439,-0.921237,9.753145
06-07 17:05:02.471+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.471+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:02:476,0.070000,-0.070000,0.350000
06-07 17:05:02.471+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:471,1.750683,-0.955285,9.601714
06-07 17:05:02.481+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:02.481+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:480,1.753939,-0.894916,9.628718
06-07 17:05:02.481+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:02.481+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.481+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:02:489,0.140000,-0.490000,0.350000
06-07 17:05:02.481+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:490,1.734797,-0.926022,9.650253
06-07 17:05:02.481+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.481+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:02:487,0.068271,-0.035801,0.023544
06-07 17:05:02.491+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.491+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:498,1.749719,-0.954396,9.601978
06-07 17:05:02.491+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.501+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:502,1.747921,-0.952160,9.602528
06-07 17:05:02.501+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:02.501+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:02.501+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:494,1.773082,-0.973879,9.664611
06-07 17:05:02.501+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.501+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:02:509,0.140000,-0.070000,0.210000
06-07 17:05:02.501+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:509,1.773082,-0.995414,9.681360
06-07 17:05:02.501+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.511+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:02:507,0.083886,0.011254,0.079379
06-07 17:05:02.511+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.511+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:518,1.749012,-0.951988,9.602346
06-07 17:05:02.511+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.521+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:523,1.749934,-0.951009,9.602276
06-07 17:05:02.521+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:02.521+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:514,1.818545,-0.981057,9.626326
06-07 17:05:02.521+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:02.521+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.521+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:529,1.837688,-0.935594,9.681360
06-07 17:05:02.521+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.531+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:02:529,0.030704,-0.040126,0.084589
06-07 17:05:02.531+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:02:529,0.560000,0.140000,0.210000
06-07 17:05:02.531+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.531+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:539,1.751856,-0.950933,9.601933
06-07 17:05:02.531+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.541+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:543,1.751402,-0.949451,9.602162
06-07 17:05:02.541+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:02.541+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:02.541+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:534,1.787439,-0.985843,9.686146
06-07 17:05:02.541+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.541+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:549,1.753939,-0.851845,9.561719
06-07 17:05:02.551+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:02:548,-0.002024,0.094146,-0.039951
06-07 17:05:02.551+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:02:549,0.560000,0.280000,0.210000
06-07 17:05:02.551+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.551+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:559,1.750839,-0.946028,9.602603
06-07 17:05:02.551+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.561+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:564,1.750454,-0.942615,9.603008
06-07 17:05:02.561+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.561+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:02.561+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:02.571+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.571+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:02:575,-0.700000,0.070000,0.210000
06-07 17:05:02.571+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:576,1.710868,-0.940379,9.678967
06-07 17:05:02.571+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:02:572,-0.043699,0.000026,0.076493
06-07 17:05:02.571+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:569,1.749821,-0.941841,9.603200
06-07 17:05:02.571+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.581+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:02.581+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.581+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:02.581+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:589,1.761117,-0.942772,9.690931
06-07 17:05:02.591+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:02:587,-0.700000,-0.070000,0.070000
06-07 17:05:02.591+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:02:590,0.008114,-0.001180,0.088287
06-07 17:05:02.591+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:584,1.750036,-0.943207,9.603026
06-07 17:05:02.601+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:05:02.611+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:05:02:611,552.000000
06-07 17:05:02.631+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:02.631+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:02.631+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.641+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:02:640,0.630000,0.210000,0.070000
06-07 17:05:02.651+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:05:02.651+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:05:02:656,79
06-07 17:05:02.651+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:02:639,0.026170,0.045463,0.033567
06-07 17:05:02.661+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.661+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:02.661+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:02.671+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:641,1.780260,-0.897308,9.635897
06-07 17:05:02.671+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.671+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:671,1.750274,-0.945257,9.602781
06-07 17:05:02.671+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:02:669,-0.770000,0.140000,0.210000
06-07 17:05:02.681+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:02:670,0.036456,-0.003732,0.042642
06-07 17:05:02.681+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:02.681+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.681+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:02.681+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:682,1.789831,-0.942772,9.645468
06-07 17:05:02.691+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:02:690,0.067571,-0.042860,0.105443
06-07 17:05:02.691+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:694,1.753802,-0.946847,9.601981
06-07 17:05:02.691+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:02:693,-0.560000,0.210000,0.070000
06-07 17:05:02.691+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:02.701+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:02.701+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.701+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.711+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:02:708,0.067194,-0.047485,0.079879
06-07 17:05:02.721+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:712,1.756735,-0.945717,9.601557
06-07 17:05:02.721+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:02:710,0.420000,0.210000,0.210000
06-07 17:05:02.721+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:712,1.823331,-0.983450,9.707682
06-07 17:05:02.721+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:02.721+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.721+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.721+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:02.721+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:02:732,-0.140000,-0.420000,0.210000
06-07 17:05:02.731+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:737,1.755963,-0.945991,9.601670
06-07 17:05:02.731+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:729,1.825724,-0.990629,9.681360
06-07 17:05:02.731+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:02:736,0.054191,0.017986,0.070582
06-07 17:05:02.731+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:02.741+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:02.741+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.741+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.751+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:02:751,0.005774,0.014977,0.013638
06-07 17:05:02.751+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:755,1.813759,-0.926022,9.671788
06-07 17:05:02.751+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:02:747,-0.420000,-0.140000,0.420000
06-07 17:05:02.751+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:753,1.754567,-0.940405,9.602474
06-07 17:05:02.751+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:02.761+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:02.761+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.761+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.771+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:772,1.753003,-0.941592,9.602644
06-07 17:05:02.771+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:02:766,-0.490000,0.560000,0.210000
06-07 17:05:02.771+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:02:770,-0.014439,-0.039767,0.028219
06-07 17:05:02.771+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:02.781+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:02.781+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:02:788,-0.020333,-0.053985,0.085660
06-07 17:05:02.781+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.781+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:773,1.768296,-0.928415,9.614362
06-07 17:05:02.791+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.791+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:02:783,0.070000,0.490000,0.210000
06-07 17:05:02.801+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:05:02.801+0200 W/LOCATION(15521): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:05:02.801+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:798,1.749153,-0.983450,9.628718
06-07 17:05:02.811+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.811+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:05:02:808,553.000000
06-07 17:05:02.821+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:02.821+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:02.821+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:793,1.754090,-0.942771,9.602329
06-07 17:05:02.821+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:821,1.741975,-1.000200,9.686146
06-07 17:05:02.821+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.831+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:02:832,-0.350000,0.350000,0.210000
06-07 17:05:02.831+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.831+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:833,1.770689,-0.916451,9.669396
06-07 17:05:02.831+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.841+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:02:833,0.011347,0.031565,0.068544
06-07 17:05:02.841+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:840,1.753376,-0.939041,9.602826
06-07 17:05:02.841+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:02.841+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:05:02.851+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:05:02:855,79
06-07 17:05:02.851+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:843,1.706082,-0.981057,9.667004
06-07 17:05:02.851+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:02.851+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.861+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.871+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:862,1.780260,-0.906880,9.662218
06-07 17:05:02.871+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.871+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:876,1.755760,-0.940591,9.602239
06-07 17:05:02.871+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:877,1.751546,-0.957129,9.650253
06-07 17:05:02.871+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.871+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:02:861,-0.280000,0.140000,0.210000
06-07 17:05:02.871+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:02.871+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:02:867,-0.053073,-0.034246,0.065998
06-07 17:05:02.871+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:02.881+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.891+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:02:885,0.210000,-0.070000,0.490000
06-07 17:05:02.891+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:881,1.801795,-0.894916,9.662218
06-07 17:05:02.891+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.901+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:02:887,0.024022,0.041868,0.060870
06-07 17:05:02.901+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:02.901+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:02.901+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:904,1.777867,-0.961915,9.681360
06-07 17:05:02.901+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.911+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:897,1.758529,-0.943144,9.601481
06-07 17:05:02.911+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.911+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:02:913,0.350000,-0.210000,0.490000
06-07 17:05:02.921+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:02:914,-0.004860,-0.010917,0.048685
06-07 17:05:02.921+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:913,1.741975,-0.887737,9.690931
06-07 17:05:02.921+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.931+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:02.931+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:02.931+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:02:937,0.350000,-0.490000,0.700000
06-07 17:05:02.931+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:935,1.708475,-0.851845,9.693325
06-07 17:05:02.931+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:924,1.759569,-0.944009,9.601206
06-07 17:05:02.941+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.941+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.951+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:02:941,0.046471,0.051103,0.060433
06-07 17:05:02.951+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:02.951+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:02.951+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:951,1.765903,-0.882952,9.688539
06-07 17:05:02.951+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.961+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:949,1.762522,-0.943392,9.600724
06-07 17:05:02.961+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:02:961,0.070000,-0.420000,0.490000
06-07 17:05:02.961+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.961+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:961,1.727618,-0.959522,9.647861
06-07 17:05:02.961+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.971+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:02:974,1.763592,-0.943684,9.600499
06-07 17:05:02.971+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:02:963,0.020824,-0.018884,0.079596
06-07 17:05:02.971+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:02.981+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:02.981+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:975,1.799403,-1.016950,9.734003
06-07 17:05:02.981+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:02:990,-0.015880,0.056015,0.089387
06-07 17:05:02.991+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:02.991+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:02.991+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:02:988,0.210000,-0.070000,0.210000
06-07 17:05:03.001+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:05:03.001+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:05:03:8,553.000000
06-07 17:05:03.001+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:03.001+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:03.011+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:02:997,1.782653,-0.966700,9.683753
06-07 17:05:03.011+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.011+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:03:17,1.797010,-0.916451,9.676575
06-07 17:05:03.011+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:03:0,1.762308,-0.946214,9.600486
06-07 17:05:03.021+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:03.021+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.021+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:03:14,0.770000,-0.140000,0.210000
06-07 17:05:03.021+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:03:16,-0.047648,0.088530,0.091132
06-07 17:05:03.031+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:03.031+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:03.031+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:03:28,1.787439,-0.940379,9.611969
06-07 17:05:03.041+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:03:28,1.759341,-0.948016,9.600852
06-07 17:05:03.041+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:03.041+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.041+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:03:50,1.753939,-0.923629,9.643075
06-07 17:05:03.051+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:05:03.051+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:05:03:56,79
06-07 17:05:03.051+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:03:41,0.770000,-0.140000,0.070000
06-07 17:05:03.051+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:03.061+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:03:45,0.013825,0.051377,0.085016
06-07 17:05:03.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:05:03.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:05:03.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:05:03.061+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:03.071+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:03:53,1.759155,-0.946811,9.601006
06-07 17:05:03.071+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.071+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:03:68,-0.980000,-0.140000,0.070000
06-07 17:05:03.071+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:03.071+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:03:72,-0.023237,-0.029521,0.043695
06-07 17:05:03.081+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:03.081+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:03.081+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:03:80,1.753939,-0.969093,9.662218
06-07 17:05:03.091+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:03:95,0.047864,-0.083580,0.130289
06-07 17:05:03.091+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.091+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:03:94,-0.140000,0.210000,0.070000
06-07 17:05:03.101+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:03:85,1.756238,-0.948748,9.601348
06-07 17:05:03.101+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:03.101+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:03:99,1.820938,-1.043271,9.719646
06-07 17:05:03.101+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.101+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:03.101+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:03.111+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:03:114,0.770000,-0.070000,-0.140000
06-07 17:05:03.111+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:03:112,1.746760,-0.961915,9.671788
06-07 17:05:03.111+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:03:109,1.756406,-0.946212,9.601568
06-07 17:05:03.121+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:03.121+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.121+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:03.121+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:03:119,0.030240,-0.029873,0.080535
06-07 17:05:03.131+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:03:130,1.801795,-0.926022,9.683753
06-07 17:05:03.131+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:03.141+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.141+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:03:130,1.755324,-0.946019,9.601785
06-07 17:05:03.141+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:03.141+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:03:149,1.765903,-0.949951,9.655040
06-07 17:05:03.151+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:03:140,0.210000,-0.070000,-0.210000
06-07 17:05:03.151+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:03.151+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:03:144,0.045156,0.019781,0.073197
06-07 17:05:03.161+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:03:164,-0.210000,0.070000,-0.420000
06-07 17:05:03.161+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:03.161+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:03:160,1.757043,-0.943030,9.601765
06-07 17:05:03.171+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.171+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:03.171+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:03.171+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:03:176,1.765903,-0.942772,9.643075
06-07 17:05:03.171+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:03:169,0.034279,-0.005886,0.008660
06-07 17:05:03.181+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:03.181+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.181+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:03:189,1.732404,-0.945165,9.705289
06-07 17:05:03.191+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:03:180,1.757855,-0.943752,9.601544
06-07 17:05:03.191+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:03:182,-0.070000,0.350000,-0.350000
06-07 17:05:03.191+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:03.191+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:03.191+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:03:189,-0.001160,0.011372,0.040170
06-07 17:05:03.201+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:05:03.201+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.201+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:05:03:208,553.000000
06-07 17:05:03.201+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:03:211,1.780260,-0.957129,9.626326
06-07 17:05:03.211+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:03.211+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:03:216,-0.000335,-0.034938,0.059080
06-07 17:05:03.221+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.221+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:03:204,1.756123,-0.940375,9.602193
06-07 17:05:03.221+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:03:213,-0.350000,0.490000,-0.350000
06-07 17:05:03.221+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:03.221+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:03.231+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:03.231+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:03:228,1.773082,-0.935594,9.676575
06-07 17:05:03.241+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:03:241,0.067404,-0.107360,0.116543
06-07 17:05:03.241+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:03:237,0.280000,-0.070000,-0.490000
06-07 17:05:03.241+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.241+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:03:233,1.752078,-0.934329,9.603522
06-07 17:05:03.241+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:03.251+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:05:03.251+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:03:252,1.794617,-0.921237,9.647861
06-07 17:05:03.251+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:05:03:256,79
06-07 17:05:03.251+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:03.261+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:03.261+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:03:268,0.630000,0.210000,-0.140000
06-07 17:05:03.271+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.271+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:03:276,1.744368,-0.923629,9.705289
06-07 17:05:03.271+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:03:265,1.750855,-0.930001,9.604165
06-07 17:05:03.271+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:03:273,-0.008714,-0.022285,0.069404
06-07 17:05:03.271+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:03.271+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:03.271+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:03.281+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.291+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:03:287,1.751539,-0.933370,9.603714
06-07 17:05:03.291+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:03:287,1.777867,-0.902094,9.626326
06-07 17:05:03.291+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:03:292,0.048898,0.012882,0.080827
06-07 17:05:03.291+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:03:285,0.280000,-0.140000,-0.140000
06-07 17:05:03.301+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:03.301+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:03.301+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.301+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:03.311+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:03:312,1.856830,-0.937986,9.669396
06-07 17:05:03.311+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:03:310,0.070000,-0.140000,0.210000
06-07 17:05:03.321+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:03:314,1.752412,-0.936828,9.603218
06-07 17:05:03.321+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:03.321+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:03:317,0.011615,-0.012588,0.052217
06-07 17:05:03.321+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.321+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:03.331+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:03.331+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:03:333,1.753939,-0.947558,9.628718
06-07 17:05:03.341+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:03:337,1.751854,-0.936232,9.603377
06-07 17:05:03.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:05:03.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:05:03.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:05:03.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:05:03.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:05:03.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:05:03.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:05:03.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:05:03.341+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:03.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:05:03.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:05:03.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:05:03.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:05:03.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391103349,000000, pattern:[H:mm][0;m
06-07 17:05:03.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:05:03.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:05:03.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:05:03.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:05:03.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:05:03.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:05][0;m
06-07 17:05:03.351+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.351+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:03:348,1.753159,-0.934493,9.603309
06-07 17:05:03.351+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:03.351+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:03:359,1.753939,-0.961915,9.686146
06-07 17:05:03.361+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:03:335,-0.070000,0.070000,0.420000
06-07 17:05:03.361+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:03.361+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.361+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:03:363,1.755099,-0.935002,9.602905
06-07 17:05:03.361+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:03.371+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:03:338,0.011457,-0.005076,0.040314
06-07 17:05:03.381+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:03.381+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:03:375,1.754274,-0.934155,9.603138
06-07 17:05:03.381+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:03.381+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:03:373,1.746760,-0.928415,9.717253
06-07 17:05:03.381+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.381+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:03:376,0.140000,-0.070000,0.280000
06-07 17:05:03.391+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:03:388,-0.022023,-0.007203,0.102550
06-07 17:05:03.391+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:03.401+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:03.401+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:05:03.401+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:03:391,1.753534,-0.935910,9.603103
06-07 17:05:03.401+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:05:03:408,553.000000
06-07 17:05:03.411+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:03.411+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:03:398,1.770689,-0.935594,9.705289
06-07 17:05:03.411+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.421+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:03:424,1.792224,-0.940379,9.623933
06-07 17:05:03.421+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:03:402,0.280000,-0.140000,0.280000
06-07 17:05:03.421+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:03.431+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:03:419,1.755475,-0.939629,9.602385
06-07 17:05:03.431+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.431+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:03:413,0.027946,-0.019444,0.023173
06-07 17:05:03.431+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:03.431+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:03:438,1.808974,-0.973879,9.628718
06-07 17:05:03.431+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:03.451+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:05:03.441+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.441+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:03:434,-0.070000,-0.070000,0.210000
06-07 17:05:03.451+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:05:03:457,80
06-07 17:05:03.471+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:03.471+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:03:467,1.794617,-1.028914,9.688539
06-07 17:05:03.471+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:03:445,0.020053,0.002442,0.073587
06-07 17:05:03.471+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:03:481,-0.070000,0.140000,0.210000
06-07 17:05:03.481+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:03.481+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.481+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:03:451,1.752897,-0.938904,9.602926
06-07 17:05:03.481+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:03.501+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:03.501+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:03:495,1.794617,-0.964308,9.678967
06-07 17:05:03.501+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:03:494,0.041093,0.016581,0.044943
06-07 17:05:03.511+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:03:497,1.754288,-0.937362,9.602823
06-07 17:05:03.511+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.511+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:03.521+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:03:524,-0.010409,0.013305,0.102513
06-07 17:05:03.531+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:03.531+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:03:513,-0.210000,0.070000,0.420000
06-07 17:05:03.541+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:03.551+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:03.551+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:03:544,1.754446,-0.937696,9.602761
06-07 17:05:03.551+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:03:541,1.758725,-0.949951,9.669396
06-07 17:05:03.551+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:03:559,0.024337,0.034281,0.023268
06-07 17:05:03.561+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:03:553,-0.490000,-0.210000,0.490000
06-07 17:05:03.561+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:03.561+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:03.561+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11155216c6f63152838390
