S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 4226
Date: 2018-06-12 13:14:43+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf73d652d, r5   = 0xf74b1150
r6   = 0xff861c50, r7   = 0xff861b00
r8   = 0xf74c3c18, r9   = 0x00000000
r10  = 0xff861bdc, fp   = 0xff861c50
ip   = 0x00000001, sp   = 0xff861ad8
lr   = 0xf73d6539, pc   = 0xf743f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     29824 KB
Buffers:     35028 KB
Cached:     214724 KB
VmPeak:      53484 KB
VmSize:      53432 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11672 KB
VmRSS:       11668 KB
VmData:      11160 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 4226 TID = 4226
4226 4273 

Maps Information
f42a1000 f4aa0000 rw-p [stack:4273]
f4aa7000 f4aa9000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ab1000 f4ab5000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4abe000 f4ac0000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4ac8000 f4acb000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4ada000 f4adf000 r-xp /usr/lib/libsystem.so.0.0.0
f4aea000 f4aed000 r-xp /lib/libattr.so.1.1.0
f4af5000 f4b05000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b0d000 f4b16000 r-xp /usr/lib/libedbus.so.1.7.99
f4b1e000 f4b1f000 r-xp /usr/lib/libresponse.so.0.2.96
f4b28000 f4b2d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f63cf000 f64d5000 r-xp /usr/lib/libicuuc.so.57.1
f64eb000 f6673000 r-xp /usr/lib/libicui18n.so.57.1
f6683000 f6690000 r-xp /usr/lib/libail.so.0.1.0
f6699000 f66a0000 r-xp /usr/lib/libminizip.so.1.0.0
f66a9000 f6852000 r-xp /usr/lib/libcrypto.so.1.0.0
f6872000 f68b9000 r-xp /usr/lib/libssl.so.1.0.0
f68c5000 f68c7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f68cf000 f68d6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f68df000 f68e6000 r-xp /lib/libcrypt-2.13.so
f6917000 f691a000 r-xp /lib/libcap.so.2.21
f6922000 f6924000 r-xp /usr/lib/libiri.so
f692c000 f6975000 r-xp /usr/lib/libmdm.so.1.2.69
f697d000 f6983000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f698b000 f69ae000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f69b8000 f69ba000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f69c2000 f69df000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f69e8000 f69ec000 r-xp /usr/lib/libsmack.so.1.0.0
f69f5000 f6a0e000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a17000 f6a1f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a27000 f6a2d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a36000 f6a38000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a41000 f6a51000 r-xp /lib/libresolv-2.13.so
f6a55000 f6a6d000 r-xp /usr/lib/liblzma.so.5.0.3
f6a76000 f6a78000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a80000 f6a9a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6aa2000 f6ad1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ada000 f6ae9000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6af3000 f6afd000 r-xp /usr/lib/libsensord-shared.so
f6b06000 f6bd9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6be4000 f6bfa000 r-xp /lib/libz.so.1.2.5
f6c02000 f6c07000 r-xp /usr/lib/libffi.so.5.0.10
f6c0f000 f6c10000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c18000 f6c28000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c30000 f6c49000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c51000 f6c53000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c5b000 f6cd0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6cda000 f6ce0000 r-xp /lib/librt-2.13.so
f6ce9000 f6d07000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d11000 f6d12000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d1a000 f6d3d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d45000 f6d4a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d52000 f6d7c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d85000 f6d9c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6da4000 f6e0d000 r-xp /lib/libm-2.13.so
f6e16000 f6eaa000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ebd000 f6ec2000 r-xp /usr/lib/libctx-client.so.0.8.3
f6eca000 f6ed1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ed9000 f6f03000 r-xp /usr/lib/libsensor.so.1.9.6
f6f0c000 f6fd8000 r-xp /usr/lib/libxml2.so.2.7.8
f6fe5000 f6fe7000 r-xp /usr/lib/libiniparser.so.0
f6ff0000 f6ff6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6fff000 f70cf000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70d0000 f7104000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f710d000 f7149000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7151000 f7154000 r-xp /usr/lib/libbundle.so.0.1.22
f715c000 f7162000 r-xp /usr/lib/libappsvc.so.0.1.0
f716a000 f71ab000 r-xp /usr/lib/libeina.so.1.7.99
f71b4000 f71cb000 r-xp /usr/lib/libecore.so.1.7.99
f71e2000 f71eb000 r-xp /usr/lib/libvconf.so.0.2.45
f71f3000 f7207000 r-xp /lib/libpthread-2.13.so
f7212000 f721f000 r-xp /usr/lib/libaul.so.0.1.0
f7229000 f722b000 r-xp /lib/libdl-2.13.so
f7234000 f723f000 r-xp /lib/libunwind.so.8.0.1
f726c000 f7274000 r-xp /lib/libgcc_s-4.6.so.1
f7275000 f7399000 r-xp /lib/libc-2.13.so
f73a7000 f73a9000 r-xp /usr/lib/libdlog.so.0.0.0
f73b1000 f73bd000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f73c6000 f73cb000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f73d3000 f73e2000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f73ea000 f73ee000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f73f7000 f73fa000 r-xp /usr/lib/libappcore-agent.so.1.1
f7402000 f7404000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f740c000 f7410000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7418000 f7435000 r-xp /lib/ld-2.13.so
f743e000 f7441000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7441000 f7445000 r-xp /usr/lib/libsys-assert.so
f7493000 f7500000 rw-p [heap]
ff843000 ff864000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4226)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf743f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf73d6539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70dd3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf70dbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf70e7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf70edbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf70eddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf712275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf711d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf70dbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf70e7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf70edbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf70eddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf711fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7120017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7127f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4abf1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4ab2171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6b85663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7032fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70347a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf71c4ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf71bfb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71c05a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf71c0879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf73f8183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73f87fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf743f5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf728c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf743ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
2:327,2.399483,0.492806,9.495789
06-12 13:14:42.321+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.331+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:328,-1.260000,0.070000,0.770000
06-12 13:14:42.331+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:328,-0.119192,-0.063360,0.155437
06-12 13:14:42.331+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:332,2.292324,0.435494,9.647861
06-12 13:14:42.341+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.341+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.341+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.341+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.351+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:349,-0.049731,-0.016634,0.144894
06-12 13:14:42.351+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:350,2.404340,0.495229,9.494434
06-12 13:14:42.351+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:351,2.349752,0.476172,9.640682
06-12 13:14:42.351+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:349,1.820000,0.420000,0.420000
06-12 13:14:42.361+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.361+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.361+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.361+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:367,-0.097658,-0.071699,0.048142
06-12 13:14:42.361+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.361+0200 I/heartrate( 4206): es.ugr.frailty.heartrate - capturing data
06-12 13:14:42.361+0200 I/heartrate( 4206): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:14:42.371+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:368,2.406114,0.493971,9.494050
06-12 13:14:42.371+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:372,1.190000,0.280000,0.630000
06-12 13:14:42.371+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:371,2.306681,0.423530,9.542577
06-12 13:14:42.381+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.381+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.381+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.391+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.391+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:389,-0.008506,-0.089584,0.017420
06-12 13:14:42.391+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:392,1.820000,0.630000,0.350000
06-12 13:14:42.401+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:389,2.414490,0.493201,9.491963
06-12 13:14:42.401+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:394,2.397608,0.404387,9.511470
06-12 13:14:42.401+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.401+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.401+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.411+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.411+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:408,-0.122166,0.057148,0.184611
06-12 13:14:42.411+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:408,3.010000,0.700000,-0.140000
06-12 13:14:42.411+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:415,2.292324,0.550349,9.676575
06-12 13:14:42.421+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:411,2.418987,0.501568,9.490380
06-12 13:14:42.421+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.421+0200 I/light   ( 4266): es.ugr.frailty.light - capturing data
06-12 13:14:42.421+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.431+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.431+0200 I/light   ( 4266): es.ugr.frailty.light: SM-R760,12/06/2018,13:14:42:427,71.000000
06-12 13:14:42.431+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.431+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:427,-0.126663,-0.109145,0.222087
06-12 13:14:42.441+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:434,2.292324,0.392423,9.712467
06-12 13:14:42.441+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.441+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:439,2.419081,0.499596,9.490460
06-12 13:14:42.441+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.441+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:448,-0.141114,-0.021032,0.190900
06-12 13:14:42.451+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:434,1.680000,0.140000,-0.630000
06-12 13:14:42.451+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.451+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.451+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:455,2.800000,-0.490000,-0.700000
06-12 13:14:42.451+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:456,2.277967,0.478565,9.681360
06-12 13:14:42.461+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.461+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.461+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:466,-0.072052,-0.001762,0.068026
06-12 13:14:42.461+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:467,2.240000,-0.840000,-0.910000
06-12 13:14:42.461+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:451,2.424197,0.504255,9.488908
06-12 13:14:42.471+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.471+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.471+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:475,2.352145,0.502493,9.556933
06-12 13:14:42.471+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:475,2.431252,0.509012,9.486849
06-12 13:14:42.481+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.481+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.491+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.491+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:489,-0.083894,-0.006519,0.091620
06-12 13:14:42.491+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.491+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:490,1.680000,-0.770000,-0.910000
06-12 13:14:42.501+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:494,2.434574,0.512353,9.485817
06-12 13:14:42.501+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:498,2.347359,0.502493,9.578469
06-12 13:14:42.501+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.501+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.501+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.511+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:508,-0.022609,-0.093609,0.200329
06-12 13:14:42.511+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.511+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:508,6.860000,-0.350000,-1.330000
06-12 13:14:42.521+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:516,2.411965,0.418744,9.686146
06-12 13:14:42.521+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:513,2.464475,0.521895,9.477572
06-12 13:14:42.521+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.521+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.531+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:528,7.420000,-0.700000,-1.120000
06-12 13:14:42.531+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.531+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:533,2.494848,0.542691,9.468453
06-12 13:14:42.541+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.541+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.551+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:555,-0.066867,0.114596,0.007577
06-12 13:14:42.551+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.561+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.561+0200 I/heartrate( 4206): es.ugr.frailty.heartrate - capturing data
06-12 13:14:42.561+0200 I/heartrate( 4206): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:14:42.571+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:548,2.240000,-0.770000,-0.560000
06-12 13:14:42.571+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.571+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:578,0.490000,-0.840000,-0.770000
06-12 13:14:42.581+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:553,2.498137,0.548942,9.467226
06-12 13:14:42.581+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.591+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:560,-0.123561,0.033979,0.098052
06-12 13:14:42.591+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.591+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:568,2.397608,0.636491,9.485149
06-12 13:14:42.591+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.601+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.601+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:589,2.493442,0.545660,9.468653
06-12 13:14:42.611+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:595,-0.174706,-0.099092,0.034673
06-12 13:14:42.611+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:606,0.700000,-0.140000,-0.560000
06-12 13:14:42.611+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.611+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:599,2.371287,0.576670,9.566505
06-12 13:14:42.611+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.621+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.621+0200 I/light   ( 4266): es.ugr.frailty.light - capturing data
06-12 13:14:42.631+0200 I/light   ( 4266): es.ugr.frailty.light: SM-R760,12/06/2018,13:14:42:627,72.000000
06-12 13:14:42.631+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.631+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:624,-0.117369,-0.000096,0.030852
06-12 13:14:42.631+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.641+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:634,2.489800,0.547250,9.469520
06-12 13:14:42.641+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:623,2.323431,0.449851,9.501899
06-12 13:14:42.651+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.651+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.661+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 13:14:42.661+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 13:14:42.661+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 13:14:42.661+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:619,1.330000,0.560000,-0.840000
06-12 13:14:42.671+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.671+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:654,2.489491,0.551312,9.469365
06-12 13:14:42.671+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.681+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:642,-0.077835,0.024635,-0.022655
06-12 13:14:42.681+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.681+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:688,-0.127774,0.128250,0.032534
06-12 13:14:42.681+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.681+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:658,2.376073,0.545564,9.499505
06-12 13:14:42.691+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.691+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:694,2.411965,0.571885,9.446864
06-12 13:14:42.691+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.691+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:674,1.190000,0.980000,-0.490000
06-12 13:14:42.691+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.691+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:698,2.361716,0.679562,9.501899
06-12 13:14:42.691+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:699,-0.770000,0.980000,0.140000
06-12 13:14:42.691+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.701+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.701+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:677,2.483681,0.559670,9.470400
06-12 13:14:42.701+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.701+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:704,2.465200,0.562626,9.475053
06-12 13:14:42.701+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.701+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:704,2.311467,0.672383,9.722038
06-12 13:14:42.701+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.701+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:709,2.465048,0.563929,9.475015
06-12 13:14:42.701+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.711+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:710,2.347359,0.519243,9.786645
06-12 13:14:42.711+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.711+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:692,-0.172215,0.112713,0.251638
06-12 13:14:42.711+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.711+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:716,2.316252,0.677169,9.741181
06-12 13:14:42.711+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:716,-0.117841,-0.043384,0.311592
06-12 13:14:42.711+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.711+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.721+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:721,2.294717,0.602991,9.676575
06-12 13:14:42.721+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:703,2.170000,0.980000,0.630000
06-12 13:14:42.721+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.721+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.721+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:729,2.354537,0.416351,9.585647
06-12 13:14:42.731+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:728,5.530000,-0.910000,0.770000
06-12 13:14:42.731+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.731+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:720,-0.148796,0.113240,0.266167
06-12 13:14:42.731+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.731+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:713,2.480509,0.579774,9.470022
06-12 13:14:42.731+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.731+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:739,-0.185792,0.023218,0.206553
06-12 13:14:42.731+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.741+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:736,2.310000,-2.870000,0.980000
06-12 13:14:42.741+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.741+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.741+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:747,2.301895,0.725025,9.511470
06-12 13:14:42.741+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:741,2.485943,0.585477,9.468246
06-12 13:14:42.741+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.751+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:743,-0.131406,-0.169126,0.117400
06-12 13:14:42.751+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.751+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:753,2.502582,0.584390,9.463929
06-12 13:14:42.751+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.751+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:744,3.290000,-3.150000,0.700000
06-12 13:14:42.751+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.751+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:756,-0.200687,0.140635,0.047541
06-12 13:14:42.761+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:757,2.518744,0.602728,9.458490
06-12 13:14:42.761+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:761,5.600000,-2.030000,0.280000
06-12 13:14:42.761+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.761+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.761+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:767,-0.118742,-0.049986,-0.016412
06-12 13:14:42.761+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:767,2.400001,0.552742,9.442079
06-12 13:14:42.761+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.771+0200 I/heartrate( 4206): es.ugr.frailty.heartrate - capturing data
06-12 13:14:42.771+0200 I/heartrate( 4206): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:14:42.771+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.771+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:772,2.170000,-2.660000,-0.140000
06-12 13:14:42.771+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:775,2.528199,0.605466,9.455792
06-12 13:14:42.781+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.781+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.781+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.781+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:788,0.010586,-0.129294,0.024571
06-12 13:14:42.781+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:789,2.538785,0.476172,9.480364
06-12 13:14:42.781+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.791+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:788,5.950000,-0.840000,-0.490000
06-12 13:14:42.791+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:793,2.556175,0.611632,9.447870
06-12 13:14:42.801+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.801+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.801+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.801+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:808,2.469393,0.763310,9.427721
06-12 13:14:42.801+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:809,-0.086782,0.151679,-0.020149
06-12 13:14:42.801+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.811+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:813,2.552927,0.620284,9.448185
06-12 13:14:42.811+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:808,0.630000,-0.420000,-0.490000
06-12 13:14:42.821+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.821+0200 I/light   ( 4266): es.ugr.frailty.light - capturing data
06-12 13:14:42.821+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.821+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.821+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:827,-0.047642,-0.208719,-0.089855
06-12 13:14:42.831+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:829,2.505285,0.411566,9.358330
06-12 13:14:42.831+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:827,-3.360000,-0.210000,-1.120000
06-12 13:14:42.831+0200 I/light   ( 4266): es.ugr.frailty.light: SM-R760,12/06/2018,13:14:42:827,72.000000
06-12 13:14:42.831+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.841+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:838,2.538289,0.604290,9.453164
06-12 13:14:42.841+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.841+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.841+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:848,2.170000,2.030000,-1.540000
06-12 13:14:42.841+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.851+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:849,-0.023432,-0.140083,0.134876
06-12 13:14:42.851+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.851+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:853,2.514857,0.464208,9.588040
06-12 13:14:42.851+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:855,2.539867,0.601820,9.452897
06-12 13:14:42.861+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.861+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.861+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:866,1.400000,1.680000,-1.960000
06-12 13:14:42.861+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.861+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:866,-0.154223,0.020314,0.108822
06-12 13:14:42.861+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.871+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:872,2.385644,0.622134,9.561719
06-12 13:14:42.871+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:873,2.530357,0.605652,9.455203
06-12 13:14:42.881+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.881+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.891+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:891,-0.182998,-0.127088,0.235728
06-12 13:14:42.891+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.891+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:892,2.030000,0.770000,-2.240000
06-12 13:14:42.891+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.891+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:897,2.347359,0.478565,9.690931
06-12 13:14:42.901+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:900,2.524604,0.603809,9.456859
06-12 13:14:42.901+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.901+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.901+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:908,-0.079140,0.073360,0.171860
06-12 13:14:42.911+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:908,5.530000,-0.210000,-1.890000
06-12 13:14:42.911+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.911+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.911+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:914,2.445465,0.677169,9.628718
06-12 13:14:42.911+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:916,2.538928,0.618526,9.452071
06-12 13:14:42.921+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.921+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.931+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:928,2.940000,-1.050000,-0.420000
06-12 13:14:42.931+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:929,-0.091070,0.209391,0.119220
06-12 13:14:42.931+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.931+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.931+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:935,2.544371,0.634173,9.449571
06-12 13:14:42.931+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:936,2.447858,0.827917,9.571291
06-12 13:14:42.941+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.941+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.941+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:947,-0.144370,0.105209,0.016436
06-12 13:14:42.941+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:948,-0.070000,-1.260000,0.490000
06-12 13:14:42.951+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:42.951+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:42.951+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:42:954,2.538649,0.639173,9.450772
06-12 13:14:42.951+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:42:955,2.400001,0.739382,9.466006
06-12 13:14:42.961+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.971+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:971,1.890000,-0.490000,1.050000
06-12 13:14:42.971+0200 I/heartrate( 4206): es.ugr.frailty.heartrate - capturing data
06-12 13:14:42.971+0200 I/heartrate( 4206): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:14:42.971+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.981+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:980,-0.129076,0.109780,0.058305
06-12 13:14:42.981+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:42.981+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:42.991+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:43.001+0200 W/LOCATION( 4226): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 13:14:43.001+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:42:991,-0.106745,0.101117,-0.019640
06-12 13:14:43.001+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:42:990,4.270000,0.420000,1.470000
06-12 13:14:43.001+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:43:1,2.409572,0.748954,9.509077
06-12 13:14:43.001+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:43.011+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:43.011+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:43.011+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:43.011+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:43:14,2.540246,0.647837,9.449754
06-12 13:14:43.011+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:43.021+0200 I/light   ( 4266): es.ugr.frailty.light - capturing data
06-12 13:14:43.021+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:43:16,2.433501,0.748954,9.430114
06-12 13:14:43.031+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:43:20,-0.128062,0.138447,-0.022758
06-12 13:14:43.031+0200 I/light   ( 4266): es.ugr.frailty.light: SM-R760,12/06/2018,13:14:43:29,72.000000
06-12 13:14:43.031+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:43.031+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:43:21,2.240000,0.910000,1.960000
06-12 13:14:43.031+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:43.041+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:43.041+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:43:20,2.551991,0.660756,9.445694
06-12 13:14:43.051+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:43.051+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:43:44,-3.080000,0.700000,2.240000
06-12 13:14:43.051+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:43:40,2.423929,0.799203,9.422935
06-12 13:14:43.051+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:43.051+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:43:44,-0.129764,0.096993,0.145929
06-12 13:14:43.051+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:43.051+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:43:54,2.553693,0.671103,9.444504
06-12 13:14:43.051+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:43.051+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:43.061+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:43:66,-2.590000,0.700000,1.960000
06-12 13:14:43.071+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:43:59,2.423929,0.768096,9.590433
06-12 13:14:43.071+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:43:64,-0.131394,-0.129837,0.133187
06-12 13:14:43.071+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:43:59,2.533787,0.668222,9.450068
06-12 13:14:43.071+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:43.071+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:43.071+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:43:76,2.518221,0.655868,9.455093
06-12 13:14:43.071+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:43.071+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:43.071+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:43.081+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:43:81,2.517517,0.656841,9.455213
06-12 13:14:43.081+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:43.081+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:43:83,-0.111041,-0.028949,0.142518
06-12 13:14:43.081+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:43:77,2.402394,0.538385,9.583255
06-12 13:14:43.091+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:43:83,1.680000,1.120000,1.540000
06-12 13:14:43.091+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:43.091+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:43.091+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:43.101+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:43:91,2.511669,0.651503,9.457137
06-12 13:14:43.101+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:43.101+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:43:95,2.407180,0.626920,9.597611
06-12 13:14:43.101+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:43:103,-0.115123,-0.089742,0.075399
06-12 13:14:43.101+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:43:107,2.512523,0.646712,9.457239
06-12 13:14:43.101+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:43:100,-0.210000,0.560000,1.400000
06-12 13:14:43.101+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:43.111+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:43.111+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:43.111+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:43:113,2.402394,0.567099,9.530612
06-12 13:14:43.121+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:43.121+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:43:120,0.350000,0.770000,0.980000
06-12 13:14:43.121+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:43.121+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:43:119,-0.001598,-0.103547,0.059118
06-12 13:14:43.121+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:43:127,2.507942,0.640869,9.458853
06-12 13:14:43.121+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:43.121+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:43.131+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:43:130,2.510071,0.547956,9.516255
06-12 13:14:43.141+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:43:133,-0.074237,-0.110720,0.066195
06-12 13:14:43.141+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:43.141+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:43:133,-0.070000,0.770000,0.560000
06-12 13:14:43.141+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:43.141+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:43.141+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:43.141+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:43:147,2.506374,0.632104,9.459858
06-12 13:14:43.151+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:43:148,2.438286,0.535992,9.523434
06-12 13:14:43.151+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:43:151,-0.064870,-0.198197,0.038260
06-12 13:14:43.151+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:43:152,0.560000,1.330000,0.560000
06-12 13:14:43.151+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:43.161+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:43.161+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:43.161+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:43.161+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:43:166,2.507372,0.637032,9.459263
06-12 13:14:43.171+0200 I/heartrate( 4206): es.ugr.frailty.heartrate - capturing data
06-12 13:14:43.171+0200 I/heartrate( 4206): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:14:43.171+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:43:163,2.443072,0.442672,9.497113
06-12 13:14:43.171+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:43:171,2.870000,1.820000,-0.840000
06-12 13:14:43.171+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:43:168,-0.092016,-0.009970,0.104254
06-12 13:14:43.171+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:43.181+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:43:181,2.414358,0.622134,9.564112
06-12 13:14:43.181+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:43.181+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:43.181+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:43:187,2.497246,0.638365,9.461852
06-12 13:14:43.181+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:43.191+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:43:191,0.280000,1.050000,-0.910000
06-12 13:14:43.191+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:43.191+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:43:187,-0.136084,0.018601,0.088099
06-12 13:14:43.191+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:43:197,2.371287,0.655633,9.547362
06-12 13:14:43.201+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:43.201+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:43.201+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:43:208,2.487811,0.634476,9.464599
06-12 13:14:43.201+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:43.211+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:43:212,0.210000,0.840000,-1.260000
06-12 13:14:43.211+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:43:208,-0.145101,-0.092801,0.078332
06-12 13:14:43.211+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:43.211+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:43:217,2.352145,0.545564,9.540184
06-12 13:14:43.221+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:43.221+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:43.221+0200 I/light   ( 4266): es.ugr.frailty.light - capturing data
06-12 13:14:43.221+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:43:229,1.540000,0.840000,-1.610000
06-12 13:14:43.221+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:43.231+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:43:232,-0.083024,-0.012343,0.168905
06-12 13:14:43.231+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:43:230,2.484289,0.636876,9.465363
06-12 13:14:43.231+0200 I/light   ( 4266): es.ugr.frailty.light: SM-R760,12/06/2018,13:14:43:229,70.000000
06-12 13:14:43.231+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:43.231+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:43:239,2.404787,0.622134,9.633504
06-12 13:14:43.241+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:43.241+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:43.241+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:43.241+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:43:247,2.488521,0.644350,9.463745
06-12 13:14:43.241+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer - capturing data
06-12 13:14:43.241+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:43:249,-0.079502,0.016365,0.098749
06-12 13:14:43.251+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:43:247,3.220000,0.490000,-1.820000
06-12 13:14:43.251+0200 I/accelerometer( 4189): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:14:43:253,2.404787,0.653241,9.564112
06-12 13:14:43.271+0200 E/WMS     ( 2465): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23480) > _wms_event_handler_cb_nomove_detector is called
06-12 13:14:43.271+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:43.271+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:43:278,1.680000,0.630000,-1.610000
06-12 13:14:43.271+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:43.281+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:43:282,-0.119626,0.075889,0.028583
06-12 13:14:43.281+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:43.281+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:43.281+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:43:288,-0.770000,0.630000,-1.610000
06-12 13:14:43.281+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:43.291+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:43:291,-0.106439,-0.005601,0.090346
06-12 13:14:43.301+0200 W/AUL     ( 4307): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-12 13:14:43.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
06-12 13:14:43.301+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-12 13:14:43.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 4226
06-12 13:14:43.301+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-12 13:14:43.301+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:43.301+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration - capturing data
06-12 13:14:43.311+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-12 13:14:43.311+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
06-12 13:14:43.311+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-12 13:14:43.311+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-12 13:14:43.311+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-12 13:14:43.311+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
06-12 13:14:43.311+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
06-12 13:14:43.311+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:0, msg id:2
06-12 13:14:43.311+0200 E/CAPI_LOCATION_MANAGER( 4297): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-12 13:14:43.311+0200 I/linearacceleration( 4229): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:14:43:311,0.004080,-0.111605,-0.025481
06-12 13:14:43.311+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:14:43:311,1.400000,1.050000,-1.820000
06-12 13:14:43.321+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4226
06-12 13:14:43.321+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(4226)
06-12 13:14:43.331+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 13:14:43.361+0200 I/gravity ( 4241): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:14:43:291,2.484905,0.651663,9.464194
06-12 13:14:43.361+0200 I/gravity ( 4241): es.ugr.frailty.gravity - capturing data
06-12 13:14:43.391+0200 I/heartrate( 4206): es.ugr.frailty.heartrate - capturing data
06-12 13:14:43.391+0200 I/heartrate( 4206): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:14:43.391+0200 I/gyroscope( 4201): es.ugr.frailty.gyroscope - capturing data
06-12 13:14:43.401+0200 I/CAPI_NETWORK_CONNECTION( 4297): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
06-12 13:14:43.401+0200 I/CAPI_NETWORK_CONNECTION( 4297): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
06-12 13:14:43.401+0200 I/CAPI_NETWORK_CONNECTION( 4297): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
06-12 13:14:43.401+0200 I/CAPI_NETWORK_CONNECTION( 4297): connection.c: connection_destroy(471) > Destroy handle: 0xf3f00468
06-12 13:14:43.401+0200 W/CRASH_MANAGER( 4308): worker.c: worker_job(1205) > 11042266c6f63152880208
