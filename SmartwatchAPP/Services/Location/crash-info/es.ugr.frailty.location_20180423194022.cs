S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 19030
Date: 2018-04-23 19:40:22+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf721452d, r5   = 0xf7a20f98
r6   = 0xfffd6520, r7   = 0xfffd63d0
r8   = 0xf7a1dc18, r9   = 0x00000000
r10  = 0xfffd64ac, fp   = 0xfffd6520
ip   = 0x00000001, sp   = 0xfffd63a8
lr   = 0xf7214539, pc   = 0xf727d228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      7740 KB
Buffers:     55440 KB
Cached:     235728 KB
VmPeak:      53460 KB
VmSize:      53396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11824 KB
VmRSS:       11824 KB
VmData:      11124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 19030 TID = 19030
19030 19059 

Maps Information
f40df000 f48de000 rw-p [stack:19059]
f48e5000 f48e7000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f48ef000 f48f3000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f48fc000 f48fe000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4906000 f4909000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4918000 f491d000 r-xp /usr/lib/libsystem.so.0.0.0
f4928000 f492b000 r-xp /lib/libattr.so.1.1.0
f4933000 f4943000 r-xp /usr/lib/libmdm-common.so.1.1.24
f494b000 f4954000 r-xp /usr/lib/libedbus.so.1.7.99
f495c000 f495d000 r-xp /usr/lib/libresponse.so.0.2.96
f4966000 f496b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f620d000 f6313000 r-xp /usr/lib/libicuuc.so.57.1
f6329000 f64b1000 r-xp /usr/lib/libicui18n.so.57.1
f64c1000 f64ce000 r-xp /usr/lib/libail.so.0.1.0
f64d7000 f64de000 r-xp /usr/lib/libminizip.so.1.0.0
f64e7000 f6690000 r-xp /usr/lib/libcrypto.so.1.0.0
f66b0000 f66f7000 r-xp /usr/lib/libssl.so.1.0.0
f6703000 f6705000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f670d000 f6714000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f671d000 f6724000 r-xp /lib/libcrypt-2.13.so
f6755000 f6758000 r-xp /lib/libcap.so.2.21
f6760000 f6762000 r-xp /usr/lib/libiri.so
f676a000 f67b3000 r-xp /usr/lib/libmdm.so.1.2.69
f67bb000 f67c1000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f67c9000 f67ec000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f67f6000 f67f8000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6800000 f681d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6826000 f682a000 r-xp /usr/lib/libsmack.so.1.0.0
f6833000 f684c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6855000 f685d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6865000 f686b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6874000 f6876000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f687f000 f688f000 r-xp /lib/libresolv-2.13.so
f6893000 f68ab000 r-xp /usr/lib/liblzma.so.5.0.3
f68b4000 f68b6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f68be000 f68d8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f68e0000 f690f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6918000 f6927000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6931000 f693b000 r-xp /usr/lib/libsensord-shared.so
f6944000 f6a17000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a22000 f6a38000 r-xp /lib/libz.so.1.2.5
f6a40000 f6a45000 r-xp /usr/lib/libffi.so.5.0.10
f6a4d000 f6a4e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a56000 f6a66000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a6e000 f6a87000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a8f000 f6a91000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a99000 f6b0e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b18000 f6b1e000 r-xp /lib/librt-2.13.so
f6b27000 f6b45000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b4f000 f6b50000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b58000 f6b7b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b83000 f6b88000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b90000 f6bba000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6bc3000 f6bda000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6be2000 f6c4b000 r-xp /lib/libm-2.13.so
f6c54000 f6ce8000 r-xp /usr/lib/libstdc++.so.6.0.16
f6cfb000 f6d00000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d08000 f6d0f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d17000 f6d41000 r-xp /usr/lib/libsensor.so.1.9.6
f6d4a000 f6e16000 r-xp /usr/lib/libxml2.so.2.7.8
f6e23000 f6e25000 r-xp /usr/lib/libiniparser.so.0
f6e2e000 f6e34000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e3d000 f6f0d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f0e000 f6f42000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f4b000 f6f87000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f8f000 f6f92000 r-xp /usr/lib/libbundle.so.0.1.22
f6f9a000 f6fa0000 r-xp /usr/lib/libappsvc.so.0.1.0
f6fa8000 f6fe9000 r-xp /usr/lib/libeina.so.1.7.99
f6ff2000 f7009000 r-xp /usr/lib/libecore.so.1.7.99
f7020000 f7029000 r-xp /usr/lib/libvconf.so.0.2.45
f7031000 f7045000 r-xp /lib/libpthread-2.13.so
f7050000 f705d000 r-xp /usr/lib/libaul.so.0.1.0
f7067000 f7069000 r-xp /lib/libdl-2.13.so
f7072000 f707d000 r-xp /lib/libunwind.so.8.0.1
f70aa000 f70b2000 r-xp /lib/libgcc_s-4.6.so.1
f70b3000 f71d7000 r-xp /lib/libc-2.13.so
f71e5000 f71e7000 r-xp /usr/lib/libdlog.so.0.0.0
f71ef000 f71fb000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7204000 f7209000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7211000 f7220000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7228000 f722c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7235000 f7238000 r-xp /usr/lib/libappcore-agent.so.1.1
f7240000 f7242000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f724a000 f724e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7256000 f7273000 r-xp /lib/ld-2.13.so
f727c000 f727f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f727f000 f7283000 r-xp /usr/lib/libsys-assert.so
f79ed000 f7a4f000 rw-p [heap]
fffb7000 fffd8000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19030)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf727d228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7214539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f1b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f19c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f25e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f2bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f2bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f6075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f5b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f19c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f25e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f2bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f2bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f5de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f5e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f65f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48fd1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf48f0171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf69c3663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e70fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e727a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7002ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6ffdb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6ffe5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6ffe879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7236183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72367fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf727d4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf70ca85c) [/lib/libc.so.6] + 0x1785c
29: (0xf727cf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ometer
04-23 19:40:21.769+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:21:766,-3.232464,-9.154723,4.045555
04-23 19:40:21.769+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:21.769+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:21:771,-2.053491,-9.583750,-0.324499
04-23 19:40:21.769+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:21:771,5.180461,-13.560125,-1.337588
04-23 19:40:21.769+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:21.769+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:21:768,107.730003,69.300003,-51.029999
04-23 19:40:21.769+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:21.769+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:21:779,6.001199,-12.090932,-2.062613
04-23 19:40:21.769+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:21.779+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:21:775,-2.838905,-8.937180,1.901012
04-23 19:40:21.779+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:21.779+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:21.779+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:21:785,-2.048108,-7.283032,0.811954
04-23 19:40:21.779+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:21.789+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:21:786,2.023718,-9.579578,0.553740
04-23 19:40:21.789+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:21:782,5.525027,-11.301301,-0.205783
04-23 19:40:21.789+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:21.789+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:21:791,-2.493625,-6.167701,2.143208
04-23 19:40:21.789+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:21.789+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:21:783,93.239998,125.230003,-68.809998
04-23 19:40:21.789+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:21.799+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:21:796,2.904887,-8.554340,2.742175
04-23 19:40:21.799+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:21.799+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:21:799,-5.875699,-4.502041,4.370232
04-23 19:40:21.799+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:21.799+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:21.799+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:21:806,4.060484,-8.811636,1.427557
04-23 19:40:21.799+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:21:807,1.926222,-8.513663,1.148555
04-23 19:40:21.799+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:21.809+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:21:801,87.500000,164.289993,-69.440002
04-23 19:40:21.809+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:21.809+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:21:807,10.399544,-3.660275,2.052887
04-23 19:40:21.809+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:21.809+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:21:816,115.150002,128.869995,-64.959999
04-23 19:40:21.809+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:21.809+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:21:812,2.603391,-7.714460,-0.253639
04-23 19:40:21.819+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:21.819+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:21.819+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:21:817,4.656882,1.869289,0.070860
04-23 19:40:21.819+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:21.819+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:21:825,1.710837,-9.625280,0.772920
04-23 19:40:21.819+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:21:825,2.663212,-7.968100,0.478565
04-23 19:40:21.829+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:21.829+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:21:821,137.059998,102.410004,-66.080002
04-23 19:40:21.829+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:21.829+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:21:834,144.410004,117.110001,-65.940002
04-23 19:40:21.829+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:21:829,0.639493,1.611479,-0.075176
04-23 19:40:21.829+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:21.829+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:21.839+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:21:833,1.177269,-8.188239,0.801596
04-23 19:40:21.839+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:21:839,-2.883216,0.623397,-0.625961
04-23 19:40:21.839+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:21.839+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:21.839+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:21:845,-1.617517,1.652395,-0.390069
04-23 19:40:21.839+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:21.839+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:21:846,1.908834,-9.558368,1.079047
04-23 19:40:21.839+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:21:840,127.889999,134.470001,-65.449997
04-23 19:40:21.849+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:21.849+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:21:850,0.093320,-7.972885,0.382852
04-23 19:40:21.849+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:21:854,139.580002,123.410004,-62.020000
04-23 19:40:21.859+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:21.859+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:21.869+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:21:869,-1.688694,1.492163,-0.957013
04-23 19:40:21.869+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:21.869+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:21.869+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:21:874,152.600006,107.660004,-62.160000
04-23 19:40:21.869+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:21:870,2.187462,-9.457314,1.394487
04-23 19:40:21.869+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:21:874,0.220140,-8.066205,0.122034
04-23 19:40:21.879+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:21.879+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:21.879+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:21.879+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:21:885,-2.168320,0.642157,-0.071256
04-23 19:40:21.879+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:21.889+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:21:885,159.949997,96.739998,-62.369999
04-23 19:40:21.889+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:21:889,2.261226,-9.381408,1.745403
04-23 19:40:21.889+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:21:889,0.019143,-8.815158,1.323231
04-23 19:40:21.899+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:21.899+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:21.899+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:21:905,-2.522044,0.973029,0.006144
04-23 19:40:21.899+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:21.899+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:21.899+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:21:909,-0.260818,-8.408379,1.751546
04-23 19:40:21.899+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:21:909,2.428375,-9.260956,2.123223
04-23 19:40:21.909+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:21:906,172.690002,80.500000,-52.849998
04-23 19:40:21.919+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:21.919+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:21.919+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:21.919+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:21:926,-2.794477,0.091660,1.317656
04-23 19:40:21.919+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:21.929+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:21:931,190.470001,82.809998,-33.670002
04-23 19:40:21.929+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:21:931,2.459389,-9.144032,2.551169
04-23 19:40:21.929+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:21:926,-0.366102,-9.169296,3.440879
04-23 19:40:21.939+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:21.939+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:21.939+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:21.939+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:21:946,-2.356498,-1.975415,4.309053
04-23 19:40:21.939+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:21.939+0200 I/heartrate(18904): capturing data from es.ugr.frailty.heartrate
04-23 19:40:21.949+0200 I/heartrate(18904): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:40:21:952,79
04-23 19:40:21.949+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:21:952,2.540159,-8.933016,3.149476
04-23 19:40:21.949+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:21:947,0.102891,-11.119448,6.860222
04-23 19:40:21.949+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:21:951,288.260010,111.930000,16.100000
04-23 19:40:21.959+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:21.959+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:21.969+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:21.969+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:21:971,294.839996,84.489998,-12.880000
04-23 19:40:21.969+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:21.969+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:21:973,2.658082,-8.661676,3.752378
04-23 19:40:21.979+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:21.979+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:21:971,-2.635872,-1.971076,4.895193
04-23 19:40:21.979+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:21.989+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:21:981,-0.095713,-10.904092,8.044669
04-23 19:40:21.989+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:21:985,237.860001,29.120001,-27.580000
04-23 19:40:21.989+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:21.999+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:21.999+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:5,-0.801596,-9.686146,8.662018
04-23 19:40:22.009+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:14,171.779999,-4.060000,-39.410000
04-23 19:40:22.009+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.019+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.029+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.039+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:21:988,-3.459678,-1.024469,4.909640
04-23 19:40:22.039+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:23,0.378066,-5.213961,7.599605
04-23 19:40:22.049+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.049+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.049+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:36,2.768227,-8.404017,4.228451
04-23 19:40:22.049+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:30,88.550003,-15.050000,-46.130001
04-23 19:40:22.059+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.059+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.079+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:71,-21.139999,-6.930000,-44.939999
04-23 19:40:22.079+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:78,2.859716,-8.149196,4.645753
04-23 19:40:22.089+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:61,-2.390161,3.190056,3.371153
04-23 19:40:22.089+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:63,2.522035,-3.153740,7.659425
04-23 19:40:22.089+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.089+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.099+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.099+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.109+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:96,2.536392,-4.230510,7.642675
04-23 19:40:22.119+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:112,-83.300003,-7.140000,-40.180000
04-23 19:40:22.119+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:102,-0.337681,4.995456,3.013672
04-23 19:40:22.119+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:117,3.060812,-7.920914,4.905194
04-23 19:40:22.119+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.129+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.129+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.129+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:132,2.321038,-6.108876,7.034898
04-23 19:40:22.129+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:136,3.172661,-7.799807,5.026690
04-23 19:40:22.129+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.129+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.139+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:140,3.182369,-7.821153,4.987231
04-23 19:40:22.139+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.139+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:135,-0.524420,3.690404,2.737481
04-23 19:40:22.139+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:147,3.156064,-7.910391,4.861621
04-23 19:40:22.139+0200 I/heartrate(18904): capturing data from es.ugr.frailty.heartrate
04-23 19:40:22.139+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.149+0200 I/heartrate(18904): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:40:22:152,78
04-23 19:40:22.149+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:152,3.137594,-8.003248,4.719524
04-23 19:40:22.149+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.149+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.149+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:158,3.147849,-8.054333,4.624842
04-23 19:40:22.159+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.159+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.159+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:141,-103.459999,-11.200000,-39.130001
04-23 19:40:22.159+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.159+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:163,3.172869,-8.057036,4.602982
04-23 19:40:22.159+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:159,2.249253,-7.848458,6.082555
04-23 19:40:22.159+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.159+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:165,-0.851623,1.690931,2.008208
04-23 19:40:22.169+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.169+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:167,-93.519997,-15.540000,-36.330002
04-23 19:40:22.169+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.169+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:173,3.201431,-8.034989,4.621706
04-23 19:40:22.169+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:170,2.464607,-8.764909,5.340781
04-23 19:40:22.169+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.169+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.179+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:179,2.878566,-8.927622,5.036892
04-23 19:40:22.179+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.179+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.179+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:185,3.022135,-8.525627,5.166104
04-23 19:40:22.179+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.179+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:185,3.228792,-7.987276,4.684945
04-23 19:40:22.179+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:177,-0.933116,-0.027305,1.095324
04-23 19:40:22.189+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:189,2.967100,-8.463413,5.302495
04-23 19:40:22.189+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.189+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.189+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:194,2.986243,-7.642675,5.469993
04-23 19:40:22.189+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:180,-59.639999,-14.070000,-32.340000
04-23 19:40:22.189+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:195,-0.691456,-0.854518,0.479159
04-23 19:40:22.189+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.189+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.199+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.199+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.199+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:204,2.926422,-6.716653,5.673382
04-23 19:40:22.199+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:205,3.253313,-7.929629,4.765219
04-23 19:40:22.199+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:200,-0.259028,-0.924374,0.317368
04-23 19:40:22.199+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.199+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:200,-25.549999,-6.370000,-28.980000
04-23 19:40:22.199+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.209+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:210,-0.125714,-0.471294,0.541263
04-23 19:40:22.209+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.209+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:211,-4.200000,-6.370000,-26.670000
04-23 19:40:22.209+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.209+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:215,-0.205769,-0.406377,0.699512
04-23 19:40:22.209+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.209+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:216,7.350000,5.320000,-23.450001
04-23 19:40:22.209+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.209+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:219,-0.215189,0.392314,0.848287
04-23 19:40:22.219+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.219+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.219+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.219+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:224,2.696711,-7.494320,6.037091
04-23 19:40:22.219+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:225,3.240073,-7.903574,4.817243
04-23 19:40:22.219+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:221,3.850000,8.400000,-18.969999
04-23 19:40:22.219+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.219+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:223,-0.302370,1.270623,0.988438
04-23 19:40:22.219+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.229+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:232,-5.670000,7.560000,-14.140000
04-23 19:40:22.229+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:233,-0.556602,0.435309,1.271872
04-23 19:40:22.239+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.239+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.239+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.239+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:246,2.629712,-8.042276,6.008378
04-23 19:40:22.249+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:245,-0.610362,-0.138702,1.191135
04-23 19:40:22.249+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:40:22.249+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:40:22.249+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:40:22.249+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.249+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:246,3.216208,-7.897694,4.842813
04-23 19:40:22.259+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:260,-11.130000,2.730000,-12.040000
04-23 19:40:22.259+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.259+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.259+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.269+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:271,-0.414212,0.209555,0.828177
04-23 19:40:22.269+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:270,2.801995,-7.688138,5.670990
04-23 19:40:22.269+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.269+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:276,3.208044,-7.892456,4.856745
04-23 19:40:22.269+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:275,-14.280000,-0.560000,-11.410000
04-23 19:40:22.279+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.279+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.279+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:283,-0.312729,0.295244,0.603676
04-23 19:40:22.279+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:284,2.895315,-7.597212,5.460421
04-23 19:40:22.279+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.279+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.279+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:288,3.205020,-7.891299,4.860620
04-23 19:40:22.279+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:288,-15.470000,-2.660000,-9.310000
04-23 19:40:22.299+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.299+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.299+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:307,3.067599,-7.724032,5.398208
04-23 19:40:22.299+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:307,-0.137421,0.167267,0.537588
04-23 19:40:22.299+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.299+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.309+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:311,3.211684,-7.890890,4.856885
04-23 19:40:22.309+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:311,-14.770000,-6.720000,-8.680000
04-23 19:40:22.319+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.319+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.319+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:325,0.109554,0.111824,0.526966
04-23 19:40:22.319+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.329+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:325,3.321238,-7.779066,5.383851
04-23 19:40:22.329+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.329+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:332,-13.790000,-13.580000,-6.440000
04-23 19:40:22.339+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:336,3.231647,-7.890101,4.844908
04-23 19:40:22.339+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.339+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.339+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.339+0200 I/heartrate(18904): capturing data from es.ugr.frailty.heartrate
04-23 19:40:22.349+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:346,0.094376,0.094285,0.232662
04-23 19:40:22.349+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:347,3.326023,-7.795816,5.077570
04-23 19:40:22.349+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:352,-16.940001,-17.639999,-3.220000
04-23 19:40:22.349+0200 I/heartrate(18904): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:40:22:353,78
04-23 19:40:22.359+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.359+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.359+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.369+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:372,0.073754,-0.292799,0.145725
04-23 19:40:22.369+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:367,3.249876,-7.902619,4.812203
04-23 19:40:22.369+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.379+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.379+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.379+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:372,3.323631,-8.195417,4.957928
04-23 19:40:22.379+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.389+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:380,-19.670000,-17.080000,-0.980000
04-23 19:40:22.389+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.389+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:386,-0.151293,-0.367095,0.048040
04-23 19:40:22.389+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:385,3.257177,-7.928821,4.763926
04-23 19:40:22.389+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.399+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.399+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:392,3.105884,-8.295916,4.811966
04-23 19:40:22.409+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:396,-16.799999,-12.810000,-0.980000
04-23 19:40:22.409+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.409+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:403,3.251538,-7.956782,4.720965
04-23 19:40:22.419+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.419+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:405,-0.284438,-0.197958,0.076644
04-23 19:40:22.419+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.429+0200 W/LOCATION(19030): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:40:22.449+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:425,2.967100,-8.154739,4.797609
04-23 19:40:22.449+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:417,-11.690000,-8.330000,-3.150000
04-23 19:40:22.449+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.449+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.449+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:457,-7.000000,-1.890000,-7.910000
04-23 19:40:22.449+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.449+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:457,3.019742,-8.190632,4.989035
04-23 19:40:22.459+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.459+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.459+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:463,3.243383,-7.974377,4.696825
04-23 19:40:22.459+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.459+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:464,2.931208,-8.073383,5.075177
04-23 19:40:22.459+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.469+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:473,2.921637,-7.728817,4.934000
04-23 19:40:22.469+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:428,-0.223641,-0.216255,0.292211
04-23 19:40:22.469+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:468,3.240266,-7.975924,4.696350
04-23 19:40:22.469+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.469+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.479+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.479+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:462,-4.200000,4.760000,-10.570000
04-23 19:40:22.479+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:479,3.233914,-7.968009,4.714130
04-23 19:40:22.489+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.489+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:486,2.766103,-8.212167,5.053641
04-23 19:40:22.489+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:481,-0.309059,-0.097460,0.378827
04-23 19:40:22.489+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.489+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:493,-9.730000,11.480000,-9.870000
04-23 19:40:22.489+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.489+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.489+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:496,-0.312277,0.239192,0.219870
04-23 19:40:22.489+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.499+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.499+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:505,2.627320,-8.788837,5.158926
04-23 19:40:22.499+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:500,3.223431,-7.963222,4.729374
04-23 19:40:22.499+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.509+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:502,-0.457329,-0.248945,0.324267
04-23 19:40:22.509+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.509+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:498,-16.170000,16.100000,-7.490000
04-23 19:40:22.509+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.509+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:517,-0.562188,-0.813433,0.427083
04-23 19:40:22.509+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:517,-13.230000,17.710001,-5.250000
04-23 19:40:22.519+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.519+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:513,3.189508,-7.975405,4.731843
04-23 19:40:22.519+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.519+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:525,2.533999,-8.362915,5.094319
04-23 19:40:22.519+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:526,3.140895,-7.993461,4.733893
04-23 19:40:22.519+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.519+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.529+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.529+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:533,-2.170000,15.680000,-3.990000
04-23 19:40:22.529+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:530,3.099422,-7.995485,4.757750
04-23 19:40:22.529+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:530,-0.606896,-0.369454,0.360426
04-23 19:40:22.539+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.539+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.539+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:545,4.340000,18.200001,-0.420000
04-23 19:40:22.539+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.539+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:546,3.060443,-7.987617,4.796046
04-23 19:40:22.539+0200 I/heartrate(18904): capturing data from es.ugr.frailty.heartrate
04-23 19:40:22.549+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:550,2.687140,-8.350951,5.273781
04-23 19:40:22.549+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.549+0200 I/heartrate(18904): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:40:22:552,79
04-23 19:40:22.549+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:556,-0.412282,-0.355466,0.516031
04-23 19:40:22.559+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.559+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.569+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:570,10.640000,17.290001,4.830000
04-23 19:40:22.569+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.569+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:570,3.012167,-7.983329,4.833601
04-23 19:40:22.569+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:574,2.493321,-8.207381,5.012963
04-23 19:40:22.569+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.579+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.579+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.579+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:585,24.290001,12.600000,8.260000
04-23 19:40:22.579+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.579+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:585,2.952147,-7.974414,4.885073
04-23 19:40:22.589+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:581,-0.567122,-0.219765,0.216918
04-23 19:40:22.589+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:589,2.213361,-8.599805,5.156533
04-23 19:40:22.589+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.589+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:597,-0.798806,-0.616476,0.322932
04-23 19:40:22.599+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.599+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.599+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:604,52.920002,6.020000,11.410000
04-23 19:40:22.599+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.599+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:608,2.187040,-8.315059,5.276174
04-23 19:40:22.599+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:605,2.905445,-7.931549,4.981899
04-23 19:40:22.609+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.609+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:618,-0.765107,-0.340645,0.391101
04-23 19:40:22.619+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.619+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.619+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:625,63.420002,2.170000,14.770000
04-23 19:40:22.619+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.619+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:629,2.682354,-7.520642,6.020342
04-23 19:40:22.619+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:625,2.888733,-7.849974,5.118937
04-23 19:40:22.629+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.629+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:634,-0.223091,0.410907,1.038443
04-23 19:40:22.639+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.639+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.639+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:646,55.510002,2.730000,25.129999
04-23 19:40:22.639+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.649+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:646,2.836468,-7.806059,5.214430
04-23 19:40:22.649+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:650,2.450250,-8.068598,5.984450
04-23 19:40:22.649+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.649+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:659,-0.438483,-0.218624,0.865513
04-23 19:40:22.659+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.659+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.669+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.669+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:670,61.950001,-2.240000,29.330000
04-23 19:40:22.669+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:673,2.732604,-7.743174,6.142376
04-23 19:40:22.669+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:670,2.801060,-7.750178,5.315937
04-23 19:40:22.669+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.679+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:679,-0.103865,0.062885,0.927946
04-23 19:40:22.679+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.689+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.689+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.689+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:694,77.349998,-2.590000,25.900000
04-23 19:40:22.699+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.699+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:706,103.320000,9.100000,7.140000
04-23 19:40:22.699+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:689,2.771720,-7.686687,5.422434
04-23 19:40:22.699+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.709+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.709+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:699,2.782853,-9.265009,6.597012
04-23 19:40:22.709+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.709+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:711,2.765102,-7.537121,5.631731
04-23 19:40:22.709+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:715,-0.018207,-1.514831,1.281075
04-23 19:40:22.709+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.709+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:718,2.598605,-7.527820,6.707082
04-23 19:40:22.709+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:719,-0.173115,0.158867,1.284648
04-23 19:40:22.719+0200 I/gravity (19046): capturing data from es.ugr.frailty.gravity
04-23 19:40:22.719+0200 I/gyroscope(19017): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:22.719+0200 I/gravity (19046): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:22:724,2.782306,-7.360337,5.852743
04-23 19:40:22.719+0200 I/accelerometer(19004): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:22.719+0200 I/linearacceleration(19033): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:22.719+0200 I/gyroscope(19017): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:22:726,112.279999,7.700000,-2.800000
04-23 19:40:22.729+0200 I/accelerometer(19004): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:22:729,2.711068,-7.207181,6.503692
04-23 19:40:22.729+0200 I/linearacceleration(19033): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:22:731,-0.054034,0.329940,0.871961
04-23 19:40:22.739+0200 W/CRASH_MANAGER(18968): worker.c: worker_job(1205) > 11190306c6f63152450522
