S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 16099
Date: 2018-04-23 19:30:30+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf730052d, r5   = 0xf7563f98
r6   = 0xffc967e0, r7   = 0xffc96690
r8   = 0xf7560c18, r9   = 0x00000000
r10  = 0xffc9676c, fp   = 0xffc967e0
ip   = 0x00000001, sp   = 0xffc96668
lr   = 0xf7300539, pc   = 0xf7369228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     12692 KB
Buffers:     53436 KB
Cached:     234000 KB
VmPeak:      53504 KB
VmSize:      53500 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12312 KB
VmRSS:       12312 KB
VmData:      11228 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 16099 TID = 16099
16099 16133 

Maps Information
f41cb000 f49ca000 rw-p [stack:16133]
f49d1000 f49d3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f49db000 f49df000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f49e8000 f49ea000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f49f2000 f49f5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4a04000 f4a09000 r-xp /usr/lib/libsystem.so.0.0.0
f4a14000 f4a17000 r-xp /lib/libattr.so.1.1.0
f4a1f000 f4a2f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4a37000 f4a40000 r-xp /usr/lib/libedbus.so.1.7.99
f4a48000 f4a49000 r-xp /usr/lib/libresponse.so.0.2.96
f4a52000 f4a57000 r-xp /usr/lib/libproc-stat.so.0.2.96
f62f9000 f63ff000 r-xp /usr/lib/libicuuc.so.57.1
f6415000 f659d000 r-xp /usr/lib/libicui18n.so.57.1
f65ad000 f65ba000 r-xp /usr/lib/libail.so.0.1.0
f65c3000 f65ca000 r-xp /usr/lib/libminizip.so.1.0.0
f65d3000 f677c000 r-xp /usr/lib/libcrypto.so.1.0.0
f679c000 f67e3000 r-xp /usr/lib/libssl.so.1.0.0
f67ef000 f67f1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f67f9000 f6800000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6809000 f6810000 r-xp /lib/libcrypt-2.13.so
f6841000 f6844000 r-xp /lib/libcap.so.2.21
f684c000 f684e000 r-xp /usr/lib/libiri.so
f6856000 f689f000 r-xp /usr/lib/libmdm.so.1.2.69
f68a7000 f68ad000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f68b5000 f68d8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f68e2000 f68e4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f68ec000 f6909000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6912000 f6916000 r-xp /usr/lib/libsmack.so.1.0.0
f691f000 f6938000 r-xp /usr/lib/libnetwork.so.0.0.0
f6941000 f6949000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6951000 f6957000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6960000 f6962000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f696b000 f697b000 r-xp /lib/libresolv-2.13.so
f697f000 f6997000 r-xp /usr/lib/liblzma.so.5.0.3
f69a0000 f69a2000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f69aa000 f69c4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f69cc000 f69fb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a04000 f6a13000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a1d000 f6a27000 r-xp /usr/lib/libsensord-shared.so
f6a30000 f6b03000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b0e000 f6b24000 r-xp /lib/libz.so.1.2.5
f6b2c000 f6b31000 r-xp /usr/lib/libffi.so.5.0.10
f6b39000 f6b3a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b42000 f6b52000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b5a000 f6b73000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b7b000 f6b7d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b85000 f6bfa000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c04000 f6c0a000 r-xp /lib/librt-2.13.so
f6c13000 f6c31000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c3b000 f6c3c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c44000 f6c67000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c6f000 f6c74000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c7c000 f6ca6000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6caf000 f6cc6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6cce000 f6d37000 r-xp /lib/libm-2.13.so
f6d40000 f6dd4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6de7000 f6dec000 r-xp /usr/lib/libctx-client.so.0.8.3
f6df4000 f6dfb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e03000 f6e2d000 r-xp /usr/lib/libsensor.so.1.9.6
f6e36000 f6f02000 r-xp /usr/lib/libxml2.so.2.7.8
f6f0f000 f6f11000 r-xp /usr/lib/libiniparser.so.0
f6f1a000 f6f20000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f29000 f6ff9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6ffa000 f702e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7037000 f7073000 r-xp /usr/lib/libSLP-location.so.0.9.24
f707b000 f707e000 r-xp /usr/lib/libbundle.so.0.1.22
f7086000 f708c000 r-xp /usr/lib/libappsvc.so.0.1.0
f7094000 f70d5000 r-xp /usr/lib/libeina.so.1.7.99
f70de000 f70f5000 r-xp /usr/lib/libecore.so.1.7.99
f710c000 f7115000 r-xp /usr/lib/libvconf.so.0.2.45
f711d000 f7131000 r-xp /lib/libpthread-2.13.so
f713c000 f7149000 r-xp /usr/lib/libaul.so.0.1.0
f7153000 f7155000 r-xp /lib/libdl-2.13.so
f715e000 f7169000 r-xp /lib/libunwind.so.8.0.1
f7196000 f719e000 r-xp /lib/libgcc_s-4.6.so.1
f719f000 f72c3000 r-xp /lib/libc-2.13.so
f72d1000 f72d3000 r-xp /usr/lib/libdlog.so.0.0.0
f72db000 f72e7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f72f0000 f72f5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f72fd000 f730c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7314000 f7318000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7321000 f7324000 r-xp /usr/lib/libappcore-agent.so.1.1
f732c000 f732e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7336000 f733a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7342000 f735f000 r-xp /lib/ld-2.13.so
f7368000 f736b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f736b000 f736f000 r-xp /usr/lib/libsys-assert.so
f7530000 f75ac000 rw-p [heap]
ffc77000 ffc98000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16099)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7369228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7300539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70073f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7005c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7011e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7017be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7017dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf704c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70471f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7005c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7011e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7017be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7017dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7049e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf704a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7051f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49e91fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf49dc171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6aaf663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f5cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f5e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf70eeca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf70e9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70ea5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf70ea879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7322183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73227fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73694f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf71b685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7368f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
760,23/04/2018,19:30:29:636,9.425328,-1.804188,2.380858
04-23 19:30:29.639+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:29.639+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:29:644,0.076617,-0.170380,0.417640
04-23 19:30:29.639+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:29.639+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:29:641,9.425574,-1.571334,2.204504
04-23 19:30:29.639+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:29.649+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:29.649+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:29:650,-12.320000,-2.310000,-4.550000
04-23 19:30:29.649+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:29:653,-0.052889,0.240925,0.075856
04-23 19:30:29.649+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:29:647,9.504292,-1.741975,2.612962
04-23 19:30:29.649+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:29:651,9.431377,-1.553975,2.191954
04-23 19:30:29.649+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:29.649+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:29:658,9.372685,-1.330409,2.280360
04-23 19:30:29.669+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:29.669+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:29.669+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:29:675,0.053772,0.070425,0.052514
04-23 19:30:29.669+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:29.669+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:29:677,-15.750000,-6.580000,-2.450000
04-23 19:30:29.669+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:29.669+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:29:679,9.437818,-1.546602,2.169332
04-23 19:30:29.679+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:29:681,9.485149,-1.483550,2.244468
04-23 19:30:29.679+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:29.679+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:29.679+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:29.689+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:29:690,-7.770000,-6.230000,-1.890000
04-23 19:30:29.689+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:29.689+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:29:690,0.188508,-0.145124,-0.063648
04-23 19:30:29.689+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:29:692,9.443279,-1.546707,2.145359
04-23 19:30:29.689+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:29:696,9.626326,-1.691726,2.105684
04-23 19:30:29.699+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:29.699+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:29.709+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:29.709+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:29:710,-0.630000,-3.850000,-3.290000
04-23 19:30:29.709+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:29.709+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:29:713,9.452062,-1.533402,2.116033
04-23 19:30:29.709+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:29:710,0.113654,0.089478,-0.341171
04-23 19:30:29.709+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:29:716,9.556933,-1.457229,1.804188
04-23 19:30:29.719+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:29.719+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:29.719+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:29.729+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:29:732,0.140000,-2.590000,-3.360000
04-23 19:30:29.729+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:29.729+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:29:731,0.205371,0.224528,-0.175454
04-23 19:30:29.729+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:29:731,9.459601,-1.512879,2.097026
04-23 19:30:29.729+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:29:737,9.657433,-1.308874,1.940579
04-23 19:30:29.739+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:29.749+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:29.749+0200 I/heartrate(16081): capturing data from es.ugr.frailty.heartrate
04-23 19:30:29.749+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:29:753,-2.590000,-3.430000,-2.380000
04-23 19:30:29.749+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:29.749+0200 I/heartrate(16081): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:30:29:757,76
04-23 19:30:29.759+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:29.759+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:29:760,9.556933,-1.356731,1.890330
04-23 19:30:29.759+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:29:763,9.466572,-1.498837,2.075545
04-23 19:30:29.769+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:29.769+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:29.769+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:29:775,9.549755,-1.459622,1.911865
04-23 19:30:29.769+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:29:756,0.097332,0.156148,-0.206696
04-23 19:30:29.769+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:29.779+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:29:776,-1.610000,-4.130000,-2.030000
04-23 19:30:29.779+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:29.779+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:29:784,9.472343,-1.490208,2.055329
04-23 19:30:29.779+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:29.779+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:29.789+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:29:791,-1.190000,-3.640000,-3.010000
04-23 19:30:29.789+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:29:783,0.083183,0.039215,-0.163680
04-23 19:30:29.789+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:29.789+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:29.789+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:29:791,9.676575,-1.524228,1.722832
04-23 19:30:29.799+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:29:798,9.479827,-1.482973,2.025848
04-23 19:30:29.799+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:29:800,0.204231,-0.034021,-0.332496
04-23 19:30:29.799+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:29.799+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:29.809+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:29:811,7.280000,-2.030000,-2.100000
04-23 19:30:29.809+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:29:811,9.600004,-1.517050,1.653440
04-23 19:30:29.809+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:29.809+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:29.809+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:29:817,9.485601,-1.476475,2.003439
04-23 19:30:29.819+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:29:818,0.120177,-0.034077,-0.372407
04-23 19:30:29.819+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:29.819+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:29.829+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:29:831,9.640682,-1.562513,1.919044
04-23 19:30:29.829+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:29.829+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:29:832,14.140000,0.700000,-3.150000
04-23 19:30:29.829+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:29.839+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:29:838,0.155081,-0.086039,-0.084395
04-23 19:30:29.839+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:29:843,9.487211,-1.468542,2.001645
04-23 19:30:29.839+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:29.839+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:29.849+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:29:851,9.561719,-1.351945,1.909473
04-23 19:30:29.849+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:29:851,15.610000,0.490000,-2.310000
04-23 19:30:29.849+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:29.849+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:29.849+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:29:858,0.074508,0.116598,-0.092173
04-23 19:30:29.859+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:29:859,9.489589,-1.452773,2.001883
04-23 19:30:29.869+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:29.869+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:29.869+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:29:878,9.511470,-1.174876,1.861616
04-23 19:30:29.879+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:29.879+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:29:878,6.440000,0.840000,-1.960000
04-23 19:30:29.879+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:29.879+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:29:884,0.021881,0.277897,-0.140267
04-23 19:30:29.879+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:29.879+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:29.889+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:29:891,9.525827,-1.261017,2.007578
04-23 19:30:29.889+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:29.889+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:29:886,9.493290,-1.433766,1.998035
04-23 19:30:29.889+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:29:891,2.310000,-0.980000,-0.910000
04-23 19:30:29.889+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:29.889+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:29:897,0.032537,0.172749,0.009543
04-23 19:30:29.899+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:29:901,9.495443,-1.421958,1.996242
04-23 19:30:29.899+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:29.899+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:29.909+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:29:911,4.690000,-2.170000,-0.630000
04-23 19:30:29.909+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:29:910,9.564112,-1.607977,2.088934
04-23 19:30:29.909+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:29.909+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:29.919+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:29:917,0.068668,-0.186019,0.092693
04-23 19:30:29.919+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:29.929+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:29.939+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:29.939+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:29:930,9.645468,-1.866402,2.225325
04-23 19:30:29.939+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:29:918,9.494884,-1.425424,1.996430
04-23 19:30:29.949+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:29.949+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:29:943,0.150584,-0.440977,0.228895
04-23 19:30:29.949+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:29.959+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:29:939,11.060000,0.070000,-2.660000
04-23 19:30:29.959+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:29.969+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:29:954,9.647861,-1.179662,1.741975
04-23 19:30:29.969+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:29.969+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:29:959,9.491302,-1.434436,2.006983
04-23 19:30:29.969+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:29.969+0200 I/heartrate(16081): capturing data from es.ugr.frailty.heartrate
04-23 19:30:29.979+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:29:966,15.120000,1.330000,-4.550000
04-23 19:30:29.989+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:29.989+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:29:978,9.530612,-1.107877,1.787439
04-23 19:30:29.989+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:29:980,9.497232,-1.408174,1.997502
04-23 19:30:29.989+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:29.999+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:29:994,6.370000,2.520000,-3.290000
04-23 19:30:29.999+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:29.999+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:2,9.444471,-1.514657,1.909473
04-23 19:30:29.999+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.009+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.009+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:13,0.156559,0.254775,-0.265008
04-23 19:30:30.009+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.019+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.019+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:23,9.501557,-1.386593,1.992022
04-23 19:30:30.019+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.019+0200 I/heartrate(16081): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:30:29:988,76
04-23 19:30:30.029+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:7,-4.550000,-0.980000,-2.030000
04-23 19:30:30.029+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.029+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:36,-2.450000,-3.080000,-2.730000
04-23 19:30:30.029+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.039+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:18,0.033380,0.300297,-0.210064
04-23 19:30:30.049+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.049+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:53,-0.057086,-0.128064,-0.082549
04-23 19:30:30.049+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.049+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:12,9.583255,-1.674976,1.923829
04-23 19:30:30.049+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.049+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:28,9.503248,-1.389751,1.981731
04-23 19:30:30.049+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.059+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:58,0.080007,-0.285225,-0.057902
04-23 19:30:30.059+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.059+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:66,0.130414,-0.140858,0.148221
04-23 19:30:30.059+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:61,9.635897,-1.536192,2.115255
04-23 19:30:30.069+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.069+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:63,9.505483,-1.395334,1.967034
04-23 19:30:30.069+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:41,6.440000,-0.280000,-3.780000
04-23 19:30:30.069+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.069+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.069+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:73,0.051240,0.002712,0.076460
04-23 19:30:30.069+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.079+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.079+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:84,12.810000,0.210000,-5.390000
04-23 19:30:30.079+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.079+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:79,9.505693,-1.390549,1.969404
04-23 19:30:30.079+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.089+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:79,9.556933,-1.387837,2.045863
04-23 19:30:30.089+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.089+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:91,11.830000,0.700000,-4.270000
04-23 19:30:30.089+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.089+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:95,9.513863,-1.076770,2.079363
04-23 19:30:30.089+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.089+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:97,8.330000,-1.610000,-2.170000
04-23 19:30:30.089+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:81,0.006182,0.297896,0.108404
04-23 19:30:30.089+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.099+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:103,-0.032289,0.278391,-0.041152
04-23 19:30:30.099+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:92,9.507681,-1.374666,1.970958
04-23 19:30:30.099+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.099+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.099+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.109+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:110,0.157737,0.371701,-0.453824
04-23 19:30:30.109+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:110,7.070000,0.490000,-3.220000
04-23 19:30:30.109+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:99,9.477970,-1.069592,1.935793
04-23 19:30:30.109+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.109+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:108,9.510259,-1.347982,1.976946
04-23 19:30:30.109+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:116,9.671788,-0.954736,1.519442
04-23 19:30:30.109+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.119+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:120,9.514051,-1.326437,1.973266
04-23 19:30:30.119+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.119+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:125,9.522182,-1.299768,1.951678
04-23 19:30:30.119+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.119+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.129+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.129+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:130,9.523624,-1.289481,1.951459
04-23 19:30:30.129+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.129+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:131,1.680000,3.850000,-2.870000
04-23 19:30:30.129+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:135,9.635897,-1.177269,1.864009
04-23 19:30:30.129+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:133,0.113715,0.122499,-0.087669
04-23 19:30:30.139+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.139+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.149+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.149+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:151,9.520972,-1.294550,1.961022
04-23 19:30:30.149+0200 I/heartrate(16081): capturing data from es.ugr.frailty.heartrate
04-23 19:30:30.149+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.149+0200 I/heartrate(16081): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:30:30:156,76
04-23 19:30:30.149+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:157,9.525827,-1.552942,2.103291
04-23 19:30:30.149+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:153,0.002203,-0.263461,0.151832
04-23 19:30:30.149+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:151,9.170000,0.770000,-2.100000
04-23 19:30:30.169+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.169+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.169+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:177,20.790001,2.240000,-5.040000
04-23 19:30:30.169+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:177,9.521245,-1.288556,1.963646
04-23 19:30:30.169+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.179+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.179+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:182,9.578469,-1.509871,1.887937
04-23 19:30:30.179+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:184,0.057497,-0.215321,-0.073085
04-23 19:30:30.179+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.179+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.189+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:191,9.524252,-1.273916,1.958606
04-23 19:30:30.189+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.189+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:191,17.500000,4.410000,-5.390000
04-23 19:30:30.189+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.189+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:196,0.112259,0.015575,-0.279099
04-23 19:30:30.189+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:197,9.633504,-1.272982,1.684547
04-23 19:30:30.199+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.199+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.209+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:211,9.380000,4.340000,-3.920000
04-23 19:30:30.209+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.209+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.209+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:217,0.006360,0.015292,-0.046741
04-23 19:30:30.209+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:217,9.530612,-1.258625,1.911865
04-23 19:30:30.209+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:211,9.524386,-1.264907,1.963785
04-23 19:30:30.219+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.219+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.219+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.229+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:231,18.690001,2.310000,-4.690000
04-23 19:30:30.229+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.229+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:232,0.063654,-0.192322,-0.379736
04-23 19:30:30.229+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:238,9.588040,-1.457229,1.584049
04-23 19:30:30.239+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:233,9.527586,-1.260420,1.951110
04-23 19:30:30.239+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.239+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.239+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.249+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.249+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:252,34.720001,4.760000,-6.160000
04-23 19:30:30.259+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:255,9.731609,-1.569692,2.210968
04-23 19:30:30.259+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:252,9.523337,-1.251999,1.977100
04-23 19:30:30.259+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:256,0.204023,-0.309272,0.259858
04-23 19:30:30.269+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.269+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.269+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.279+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.279+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:276,0.110167,-0.540225,0.384616
04-23 19:30:30.279+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:277,9.515013,-1.243442,2.022072
04-23 19:30:30.289+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.289+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.299+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:299,9.517920,-1.182676,2.044711
04-23 19:30:30.299+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:294,-0.089684,0.365276,-0.012101
04-23 19:30:30.299+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:276,56.700001,7.140000,-8.540000
04-23 19:30:30.299+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:285,9.633504,-1.792224,2.361716
04-23 19:30:30.299+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.299+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.299+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.309+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:311,9.425328,-0.878166,2.009971
04-23 19:30:30.309+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.309+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:318,9.523434,-0.535992,1.871187
04-23 19:30:30.319+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.319+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:311,9.524595,-1.122531,2.047534
04-23 19:30:30.319+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.319+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:318,0.005513,0.646683,-0.173524
04-23 19:30:30.329+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.339+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:324,58.170002,8.190000,-14.420000
04-23 19:30:30.339+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.349+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:30:30.349+0200 I/heartrate(16081): capturing data from es.ugr.frailty.heartrate
04-23 19:30:30.349+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:30:30.349+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:30:30.349+0200 W/LOCATION(16099): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:30:30.359+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:331,9.583255,-1.526621,2.038685
04-23 19:30:30.359+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.359+0200 I/heartrate(16081): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:30:30:358,76
04-23 19:30:30.359+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:368,9.573684,-1.660619,2.029114
04-23 19:30:30.369+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.369+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:373,9.523558,-1.123370,2.051895
04-23 19:30:30.369+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.369+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:357,33.040001,3.640000,-9.450000
04-23 19:30:30.379+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.379+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:333,0.058660,-0.404090,-0.008850
04-23 19:30:30.379+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.379+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:383,9.518648,-2.072184,1.493121
04-23 19:30:30.379+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:379,9.520625,-1.121901,2.066258
04-23 19:30:30.379+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.379+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.389+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:386,0.050126,-0.537248,-0.022781
04-23 19:30:30.389+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:389,9.518721,-1.116279,2.078041
04-23 19:30:30.389+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.389+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:396,9.511062,-1.098177,2.122285
04-23 19:30:30.389+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.399+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:394,21.420000,1.960000,-5.670000
04-23 19:30:30.399+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.399+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:401,9.863215,-2.586641,1.708475
04-23 19:30:30.399+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.399+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.409+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.409+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:404,-0.001977,-0.950284,-0.573137
04-23 19:30:30.409+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.409+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:410,9.643075,-2.065006,2.160719
04-23 19:30:30.409+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:413,9.494601,-1.034109,2.225656
04-23 19:30:30.409+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:407,41.439999,2.870000,-6.860000
04-23 19:30:30.409+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.419+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:415,0.344495,-1.470362,-0.369566
04-23 19:30:30.419+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:423,94.010002,2.870000,-10.430000
04-23 19:30:30.419+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.419+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.419+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.429+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.429+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:433,9.475898,-0.923175,2.350637
04-23 19:30:30.429+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:429,0.132013,-0.966829,0.038434
04-23 19:30:30.429+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.429+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:430,9.387043,-1.148555,2.029114
04-23 19:30:30.439+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:439,-0.107558,-0.114445,-0.196542
04-23 19:30:30.439+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:428,150.570007,0.280000,-15.120000
04-23 19:30:30.439+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.439+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:444,199.850006,9.520000,-24.150000
04-23 19:30:30.439+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.439+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.439+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.439+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.449+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:451,-0.012284,-0.067454,-0.254524
04-23 19:30:30.449+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:452,9.448442,-0.806314,2.499439
04-23 19:30:30.449+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:451,9.463614,-0.990629,2.096112
04-23 19:30:30.459+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:448,222.320007,11.340000,-28.000000
04-23 19:30:30.459+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.459+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:464,224.490005,4.480000,-28.420000
04-23 19:30:30.469+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.469+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.469+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.469+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:475,0.299918,0.251179,-0.597146
04-23 19:30:30.479+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:476,9.408942,-0.673215,2.681224
04-23 19:30:30.479+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:479,9.748360,-0.555135,1.902294
04-23 19:30:30.479+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.479+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:486,211.960007,2.940000,-30.590000
04-23 19:30:30.479+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.479+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.479+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.489+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:491,0.210205,1.601630,-1.238352
04-23 19:30:30.489+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:491,9.281433,-0.479923,3.129705
04-23 19:30:30.489+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:493,9.619147,0.928415,1.442872
04-23 19:30:30.489+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.499+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:502,172.199997,7.770000,-30.030001
04-23 19:30:30.499+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.499+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.499+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.509+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:510,-0.042746,1.487301,-1.000093
04-23 19:30:30.509+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:513,8.933200,-0.322590,4.032897
04-23 19:30:30.509+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:511,9.238688,1.007378,2.129612
04-23 19:30:30.509+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.519+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:521,116.270004,6.230000,-19.250000
04-23 19:30:30.519+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.519+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.529+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.529+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:530,0.181061,1.047615,-1.759716
04-23 19:30:30.529+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:531,9.114261,0.725025,2.273181
04-23 19:30:30.529+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:533,9.473413,-0.195723,-2.527155
04-23 19:30:30.529+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.539+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:543,103.040001,-0.560000,-15.120000
04-23 19:30:30.539+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.539+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.539+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.549+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:550,0.126591,1.047568,4.955871
04-23 19:30:30.549+0200 I/heartrate(16081): capturing data from es.ugr.frailty.heartrate
04-23 19:30:30.549+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:551,9.600004,0.851845,2.428715
04-23 19:30:30.549+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:553,9.804210,-0.151957,-0.157357
04-23 19:30:30.549+0200 I/heartrate(16081): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:30:30:557,76
04-23 19:30:30.549+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.559+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:562,101.500000,-5.880000,-11.480000
04-23 19:30:30.569+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.569+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.569+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.569+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:576,-0.649271,1.716863,2.349182
04-23 19:30:30.579+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:579,9.767058,-0.046045,0.879110
04-23 19:30:30.579+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:577,9.154939,1.564906,2.191825
04-23 19:30:30.579+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.579+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.579+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.589+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.589+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:591,-1.095469,1.905269,0.243124
04-23 19:30:30.589+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:591,8.671589,1.859223,1.122234
04-23 19:30:30.589+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:593,9.727304,0.050301,1.243956
04-23 19:30:30.589+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:587,70.910004,0.420000,-5.740000
04-23 19:30:30.599+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.599+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:604,4.830000,0.910000,0.910000
04-23 19:30:30.599+0200 I/linearacceleration(16105): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:30.599+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.609+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.609+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:613,9.724757,0.055006,1.263512
04-23 19:30:30.609+0200 I/linearacceleration(16105): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:30:610,-0.976751,0.679510,0.928727
04-23 19:30:30.609+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:611,8.750552,0.729811,2.172683
04-23 19:30:30.609+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.629+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.629+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:633,9.030513,-0.160319,3.000600
04-23 19:30:30.629+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.639+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:637,9.742205,0.010389,1.122375
04-23 19:30:30.639+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:620,-43.540001,-6.440000,8.680000
04-23 19:30:30.639+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.639+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:649,-47.389999,-9.170000,11.130000
04-23 19:30:30.649+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.649+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.649+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:657,9.758116,-0.023161,0.974181
04-23 19:30:30.659+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:655,9.497113,-0.306281,3.058028
04-23 19:30:30.659+0200 I/gyroscope(16077): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:30.659+0200 I/gyroscope(16077): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:30:665,-11.200000,-7.210000,8.190000
04-23 19:30:30.669+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.679+0200 I/accelerometer(16065): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:30:683,10.442278,0.454636,2.517249
04-23 19:30:30.679+0200 I/gravity (16116): capturing data from es.ugr.frailty.gravity
04-23 19:30:30.689+0200 I/gravity (16116): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:30:687,9.744389,0.003764,1.103297
04-23 19:30:30.689+0200 I/accelerometer(16065): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:30.689+0200 W/CRASH_MANAGER(16141): worker.c: worker_job(1205) > 11160996c6f63152450463
