S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 13413
Date: 2018-04-23 19:23:18+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf75ce52d, r5   = 0xf7c70f98
r6   = 0xffb24b00, r7   = 0xffb249b0
r8   = 0xf7c6dc18, r9   = 0x00000000
r10  = 0xffb24a8c, fp   = 0xffb24b00
ip   = 0x00000001, sp   = 0xffb24988
lr   = 0xf75ce539, pc   = 0xf7637228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     21480 KB
Buffers:     50592 KB
Cached:     234924 KB
VmPeak:      52512 KB
VmSize:      52508 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12004 KB
VmRSS:       12004 KB
VmData:      10236 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 13413 TID = 13413
13413 13455 

Maps Information
f4499000 f4c98000 rw-p [stack:13455]
f4c9f000 f4ca1000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ca9000 f4cad000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4cb6000 f4cb8000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4cc0000 f4cc3000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4cd2000 f4cd7000 r-xp /usr/lib/libsystem.so.0.0.0
f4ce2000 f4ce5000 r-xp /lib/libattr.so.1.1.0
f4ced000 f4cfd000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d05000 f4d0e000 r-xp /usr/lib/libedbus.so.1.7.99
f4d16000 f4d17000 r-xp /usr/lib/libresponse.so.0.2.96
f4d20000 f4d25000 r-xp /usr/lib/libproc-stat.so.0.2.96
f65c7000 f66cd000 r-xp /usr/lib/libicuuc.so.57.1
f66e3000 f686b000 r-xp /usr/lib/libicui18n.so.57.1
f687b000 f6888000 r-xp /usr/lib/libail.so.0.1.0
f6891000 f6898000 r-xp /usr/lib/libminizip.so.1.0.0
f68a1000 f6a4a000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a6a000 f6ab1000 r-xp /usr/lib/libssl.so.1.0.0
f6abd000 f6abf000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6ac7000 f6ace000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6ad7000 f6ade000 r-xp /lib/libcrypt-2.13.so
f6b0f000 f6b12000 r-xp /lib/libcap.so.2.21
f6b1a000 f6b1c000 r-xp /usr/lib/libiri.so
f6b24000 f6b6d000 r-xp /usr/lib/libmdm.so.1.2.69
f6b75000 f6b7b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b83000 f6ba6000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6bb0000 f6bb2000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6bba000 f6bd7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6be0000 f6be4000 r-xp /usr/lib/libsmack.so.1.0.0
f6bed000 f6c06000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c0f000 f6c17000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c1f000 f6c25000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c2e000 f6c30000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c39000 f6c49000 r-xp /lib/libresolv-2.13.so
f6c4d000 f6c65000 r-xp /usr/lib/liblzma.so.5.0.3
f6c6e000 f6c70000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c78000 f6c92000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c9a000 f6cc9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6cd2000 f6ce1000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6ceb000 f6cf5000 r-xp /usr/lib/libsensord-shared.so
f6cfe000 f6dd1000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ddc000 f6df2000 r-xp /lib/libz.so.1.2.5
f6dfa000 f6dff000 r-xp /usr/lib/libffi.so.5.0.10
f6e07000 f6e08000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e10000 f6e20000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e28000 f6e41000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e49000 f6e4b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e53000 f6ec8000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ed2000 f6ed8000 r-xp /lib/librt-2.13.so
f6ee1000 f6eff000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f09000 f6f0a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f12000 f6f35000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f3d000 f6f42000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f4a000 f6f74000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f7d000 f6f94000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f9c000 f7005000 r-xp /lib/libm-2.13.so
f700e000 f70a2000 r-xp /usr/lib/libstdc++.so.6.0.16
f70b5000 f70ba000 r-xp /usr/lib/libctx-client.so.0.8.3
f70c2000 f70c9000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70d1000 f70fb000 r-xp /usr/lib/libsensor.so.1.9.6
f7104000 f71d0000 r-xp /usr/lib/libxml2.so.2.7.8
f71dd000 f71df000 r-xp /usr/lib/libiniparser.so.0
f71e8000 f71ee000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f71f7000 f72c7000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f72c8000 f72fc000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7305000 f7341000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7349000 f734c000 r-xp /usr/lib/libbundle.so.0.1.22
f7354000 f735a000 r-xp /usr/lib/libappsvc.so.0.1.0
f7362000 f73a3000 r-xp /usr/lib/libeina.so.1.7.99
f73ac000 f73c3000 r-xp /usr/lib/libecore.so.1.7.99
f73da000 f73e3000 r-xp /usr/lib/libvconf.so.0.2.45
f73eb000 f73ff000 r-xp /lib/libpthread-2.13.so
f740a000 f7417000 r-xp /usr/lib/libaul.so.0.1.0
f7421000 f7423000 r-xp /lib/libdl-2.13.so
f742c000 f7437000 r-xp /lib/libunwind.so.8.0.1
f7464000 f746c000 r-xp /lib/libgcc_s-4.6.so.1
f746d000 f7591000 r-xp /lib/libc-2.13.so
f759f000 f75a1000 r-xp /usr/lib/libdlog.so.0.0.0
f75a9000 f75b5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75be000 f75c3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75cb000 f75da000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f75e2000 f75e6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75ef000 f75f2000 r-xp /usr/lib/libappcore-agent.so.1.1
f75fa000 f75fc000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7604000 f7608000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7610000 f762d000 r-xp /lib/ld-2.13.so
f7636000 f7639000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7639000 f763d000 r-xp /usr/lib/libsys-assert.so
f7c3d000 f7cc7000 rw-p [heap]
ffb06000 ffb27000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13413)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7637228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf75ce539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72d53f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf72d3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf72dfe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf72e5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf72e5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf731a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73151f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf72d3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf72dfe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf72e5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf72e5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7317e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7318017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf731ff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4cb71fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4caa171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d7d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf722afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf722c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf73bcca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf73b7b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73b85a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf73b8879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf75f0183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75f07fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76374f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf748485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7636f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
cope: SM-R760,23/04/2018,19:23:18:209,111.160004,5.390000,-6.230000
04-23 19:23:18.209+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.209+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:208,-0.163158,0.229535,0.062343
04-23 19:23:18.209+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:213,6.381658,5.864808,4.285545
04-23 19:23:18.209+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.209+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:213,6.256707,5.517312,5.155898
04-23 19:23:18.209+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.219+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.219+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:217,122.290001,5.250000,-5.950000
04-23 19:23:18.219+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.229+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:225,6.314659,6.025128,4.012764
04-23 19:23:18.229+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:221,6.243411,5.627208,5.052201
04-23 19:23:18.229+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.229+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:220,0.003602,-0.185902,0.186366
04-23 19:23:18.229+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.239+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.239+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:247,5.922236,7.051648,4.003192
04-23 19:23:18.239+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:243,-0.008025,-0.425083,0.181182
04-23 19:23:18.239+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.249+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:254,-0.224401,-0.324887,-0.339146
04-23 19:23:18.249+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.249+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:258,0.020999,0.067709,-0.788191
04-23 19:23:18.259+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.259+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:264,5.893522,7.783852,3.306881
04-23 19:23:18.259+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.269+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:272,0.154389,0.083191,-0.609801
04-23 19:23:18.269+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.269+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:277,0.111094,0.080645,-0.714740
04-23 19:23:18.269+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.279+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.279+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:285,6.142376,7.534998,2.971886
04-23 19:23:18.289+0200 I/heartrate(13102): capturing data from es.ugr.frailty.heartrate
04-23 19:23:18.289+0200 I/heartrate(13102): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:23:18:293,81
04-23 19:23:18.289+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:227,146.440002,6.090000,-5.110000
04-23 19:23:18.299+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:241,6.227269,5.781617,4.895346
04-23 19:23:18.299+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:281,-0.244164,0.913496,-0.521073
04-23 19:23:18.299+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.309+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:310,6.092126,6.697510,3.038885
04-23 19:23:18.309+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.309+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.309+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.319+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.319+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:324,154.000000,14.000000,-3.920000
04-23 19:23:18.319+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.319+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:328,105.349998,9.870000,-2.520000
04-23 19:23:18.319+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.329+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:332,69.300003,3.640000,-0.560000
04-23 19:23:18.329+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.329+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:336,78.050003,4.270000,2.100000
04-23 19:23:18.329+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.329+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:321,6.203565,5.944483,4.727504
04-23 19:23:18.329+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:325,6.082555,6.020342,2.744568
04-23 19:23:18.329+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:328,-0.187572,1.415725,-1.010253
04-23 19:23:18.329+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.339+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:340,119.000000,7.280000,2.310000
04-23 19:23:18.339+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.339+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.339+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.339+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:345,140.490005,15.820000,1.540000
04-23 19:23:18.339+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:346,6.230910,7.305287,2.598605
04-23 19:23:18.349+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:349,6.166400,6.138152,4.524266
04-23 19:23:18.349+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:349,0.132080,0.982322,-1.164436
04-23 19:23:18.349+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.349+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.349+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:356,0.117512,0.020626,-0.947790
04-23 19:23:18.349+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.349+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:356,6.081094,6.368126,4.317134
04-23 19:23:18.349+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.359+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.359+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:359,0.135204,-0.763291,-1.100135
04-23 19:23:18.359+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.359+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.359+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:364,0.323355,0.381080,-1.051945
04-23 19:23:18.359+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.359+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:369,0.355403,1.095715,-0.824744
04-23 19:23:18.369+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:365,6.171089,8.214561,2.591427
04-23 19:23:18.369+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:365,102.410004,17.500000,2.240000
04-23 19:23:18.369+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:361,6.010296,6.552677,4.136322
04-23 19:23:18.369+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.379+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.379+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.379+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.379+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:384,0.436623,0.606401,-0.573717
04-23 19:23:18.379+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:385,6.161518,7.881958,2.660819
04-23 19:23:18.379+0200 I/heartrate(13102): capturing data from es.ugr.frailty.heartrate
04-23 19:23:18.389+0200 I/heartrate(13102): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:23:18:391,81
04-23 19:23:18.389+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:381,5.974614,6.676885,3.986675
04-23 19:23:18.389+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.389+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:388,60.340000,7.140000,2.100000
04-23 19:23:18.389+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:23:18.389+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:23:18.399+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:398,5.947351,6.783633,3.844702
04-23 19:23:18.399+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.399+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.399+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.409+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.409+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:414,6.175875,7.511070,2.297110
04-23 19:23:18.409+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:412,0.499010,0.146836,-0.819242
04-23 19:23:18.419+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.419+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:425,6.056234,7.587641,1.899901
04-23 19:23:18.419+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.429+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:430,0.401513,0.163045,-1.111726
04-23 19:23:18.429+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:405,5.907556,6.924208,3.650550
04-23 19:23:18.429+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:412,43.610001,3.010000,3.290000
04-23 19:23:18.429+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.429+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.439+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:440,5.815686,7.118845,3.416170
04-23 19:23:18.439+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.439+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.439+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:445,5.724895,7.275557,3.234536
04-23 19:23:18.439+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.439+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.439+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:447,6.003592,7.207181,2.069792
04-23 19:23:18.449+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:450,5.676865,7.364234,3.116351
04-23 19:23:18.449+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.449+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:450,0.375879,-0.282415,-0.829379
04-23 19:23:18.449+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:441,41.790001,6.650000,4.340000
04-23 19:23:18.449+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:456,5.654722,7.424595,3.011627
04-23 19:23:18.449+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.449+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.459+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.459+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:460,5.627712,7.489596,2.899170
04-23 19:23:18.459+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.459+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.459+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:465,5.831308,7.176075,2.435893
04-23 19:23:18.469+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:466,5.614552,7.526945,2.827065
04-23 19:23:18.469+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.469+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:469,0.216756,-0.350870,-0.391172
04-23 19:23:18.469+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:460,27.719999,8.330000,3.080000
04-23 19:23:18.469+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:475,5.597817,7.555431,2.783936
04-23 19:23:18.469+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.479+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.479+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.479+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:484,5.771489,7.159326,2.632105
04-23 19:23:18.489+0200 I/heartrate(13102): capturing data from es.ugr.frailty.heartrate
04-23 19:23:18.489+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:488,0.173672,-0.396105,-0.151831
04-23 19:23:18.489+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:480,24.570000,10.220000,2.520000
04-23 19:23:18.489+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.489+0200 I/heartrate(13102): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:23:18:494,81
04-23 19:23:18.489+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:496,5.583850,7.576131,2.755583
04-23 19:23:18.489+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.499+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:502,20.160000,6.860000,0.490000
04-23 19:23:18.499+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.499+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.509+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:510,5.737988,6.809973,2.577070
04-23 19:23:18.509+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.509+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:510,0.154139,-0.766158,-0.178513
04-23 19:23:18.509+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.509+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:518,19.040001,2.800000,-0.210000
04-23 19:23:18.509+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:514,5.580612,7.588354,2.728377
04-23 19:23:18.519+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.519+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.519+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:524,5.562169,7.618075,2.682833
04-23 19:23:18.519+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.519+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.519+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:528,23.030001,5.390000,0.280000
04-23 19:23:18.519+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:528,0.150198,-0.338101,-0.369054
04-23 19:23:18.519+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:524,5.730811,7.250252,2.359323
04-23 19:23:18.539+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.539+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:545,5.883951,7.140182,2.672783
04-23 19:23:18.539+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.539+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.549+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.549+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:549,5.574293,7.606879,2.689430
04-23 19:23:18.549+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:551,-0.910000,2.940000,-1.260000
04-23 19:23:18.549+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:553,0.321782,-0.477892,-0.010051
04-23 19:23:18.559+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.559+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.569+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:565,-21.700001,-1.120000,0.770000
04-23 19:23:18.569+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.589+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.589+0200 I/heartrate(13102): capturing data from es.ugr.frailty.heartrate
04-23 19:23:18.589+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:23:18.589+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:23:18.609+0200 W/LOCATION(13413): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:23:18.609+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.619+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:563,6.056234,7.905886,2.727818
04-23 19:23:18.619+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.619+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:582,5.602034,7.576763,2.716665
04-23 19:23:18.619+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:619,-32.200001,-3.360000,0.980000
04-23 19:23:18.629+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.629+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:599,0.481942,0.299007,0.038388
04-23 19:23:18.629+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.639+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:633,5.644094,7.530343,2.758354
04-23 19:23:18.639+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.639+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.649+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:652,-24.639999,-6.160000,2.100000
04-23 19:23:18.649+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.649+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:656,-1.400000,-5.670000,0.420000
04-23 19:23:18.649+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.659+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:625,6.017949,7.726424,2.730211
04-23 19:23:18.659+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.659+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:640,0.415915,0.149662,0.013546
04-23 19:23:18.659+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.669+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:673,0.474353,0.186511,-0.341604
04-23 19:23:18.669+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.669+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:665,6.118448,7.716853,2.416751
04-23 19:23:18.669+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.669+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:679,6.195018,6.987042,1.933401
04-23 19:23:18.679+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:649,5.685105,7.495493,2.769032
04-23 19:23:18.679+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.679+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:686,5.717028,7.485995,2.728710
04-23 19:23:18.689+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:676,0.509912,-0.508451,-0.835631
04-23 19:23:18.689+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.689+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:693,0.590453,0.455782,-1.010663
04-23 19:23:18.689+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.689+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:697,0.310239,0.592021,-0.689288
04-23 19:23:18.699+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.699+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.709+0200 I/servicemanager(13086): es.ugr.frailty.location sleep timeout
04-23 19:23:18.709+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:709,5.702924,7.524434,2.651403
04-23 19:23:18.709+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.709+0200 W/AUL     (13086): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 19:23:18.709+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:660,17.080000,2.380000,-1.120000
04-23 19:23:18.709+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.719+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:705,6.307480,7.941778,1.718047
04-23 19:23:18.719+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.719+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:725,6.013163,8.116454,1.962115
04-23 19:23:18.719+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:719,5.320000,6.720000,-0.210000
04-23 19:23:18.719+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.729+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.729+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:715,5.687615,7.550182,2.610778
04-23 19:23:18.739+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:23:18.739+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13086
04-23 19:23:18.749+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13413
04-23 19:23:18.749+0200 W/AUL     (13086): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13413)
04-23 19:23:18.749+0200 I/servicemanager(13086): es.ugr.frailty.location stop request sent!
04-23 19:23:18.749+0200 I/servicemanager(13086): App control destroyed.
04-23 19:23:18.769+0200 I/heartrate(13102): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:23:18:606,81
04-23 19:23:18.769+0200 I/heartrate(13102): capturing data from es.ugr.frailty.heartrate
04-23 19:23:18.769+0200 I/heartrate(13102): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:23:18:779,82
04-23 19:23:18.779+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.789+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.789+0200 I/heartrate(13102): capturing data from es.ugr.frailty.heartrate
04-23 19:23:18.789+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:23:18.789+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:23:18.799+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:731,-8.050000,4.410000,1.050000
04-23 19:23:18.799+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.799+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:739,5.816952,7.525427,2.141576
04-23 19:23:18.799+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.809+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:808,-8.050000,5.390000,2.520000
04-23 19:23:18.809+0200 I/heartrate(13102): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:23:18:799,82
04-23 19:23:18.809+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.809+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:790,5.697400,7.544886,2.604749
04-23 19:23:18.809+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:815,8.750000,4.760000,2.590000
04-23 19:23:18.809+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.809+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.819+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:820,18.200001,6.090000,2.450000
04-23 19:23:18.819+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:804,0.129337,-0.024755,-0.469202
04-23 19:23:18.819+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.819+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.819+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:815,5.867201,7.680960,2.179861
04-23 19:23:18.819+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:827,20.440001,8.330000,2.590000
04-23 19:23:18.819+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.829+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.829+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:822,5.706605,7.539432,2.600387
04-23 19:23:18.829+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:832,11.690000,3.920000,1.680000
04-23 19:23:18.829+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.829+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.839+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:829,0.169801,0.136074,-0.424888
04-23 19:23:18.839+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:841,14.350000,-0.700000,0.490000
04-23 19:23:18.839+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.839+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.849+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:847,26.880001,4.410000,-2.310000
04-23 19:23:18.849+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.849+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:853,12.110000,6.930000,-0.560000
04-23 19:23:18.849+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:838,5.979663,7.010970,2.254039
04-23 19:23:18.849+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.849+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:847,5.715381,7.539644,2.580422
04-23 19:23:18.859+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.859+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:855,0.273058,-0.528462,-0.346348
04-23 19:23:18.859+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:863,-7.630000,6.090000,-0.070000
04-23 19:23:18.859+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.869+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:860,6.082555,6.879365,2.411965
04-23 19:23:18.869+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.869+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:872,5.717696,7.545820,2.557135
04-23 19:23:18.869+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.879+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.879+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:876,0.367174,-0.660279,-0.168457
04-23 19:23:18.879+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:884,-8.680000,7.350000,0.490000
04-23 19:23:18.879+0200 I/heartrate(13102): capturing data from es.ugr.frailty.heartrate
04-23 19:23:18.889+0200 I/heartrate(13102): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:23:18:893,82
04-23 19:23:18.889+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.899+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.899+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:882,6.082555,7.441679,2.459821
04-23 19:23:18.899+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.899+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.909+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:909,8.400000,10.290000,0.910000
04-23 19:23:18.909+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:902,5.702397,7.566631,2.529653
04-23 19:23:18.909+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:912,5.924629,7.331609,2.500499
04-23 19:23:18.909+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.919+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.919+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:905,0.364859,-0.104141,-0.097314
04-23 19:23:18.919+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:923,21.350000,11.900000,0.140000
04-23 19:23:18.919+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.919+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.929+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:925,5.698451,7.574159,2.515980
04-23 19:23:18.929+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.929+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:928,0.222232,-0.235023,-0.029154
04-23 19:23:18.929+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:931,5.785845,6.618547,2.084148
04-23 19:23:18.939+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:18.939+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.939+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:945,14.140000,10.640000,0.700000
04-23 19:23:18.939+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:18.939+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:18:940,5.707212,7.578414,2.483093
04-23 19:23:18.949+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:18:950,5.986843,7.125826,1.567299
04-23 19:23:18.959+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.959+0200 I/TDM     ( 1956): tdm_display.c: tdm_layer_unset_buffer(1602) > [1859.244428] layer(0x8fd2c0) now usable
04-23 19:23:18.959+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [1859.244457] layer[0x8fce10]zpos[1]
04-23 19:23:18.959+0200 I/TDM     ( 1956): tdm_display.c: tdm_layer_unset_buffer(1602) > [1859.244480] layer(0x8fd310) now usable
04-23 19:23:18.959+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [1859.244498] layer[0x8fcf30]zpos[2]
04-23 19:23:18.959+0200 I/TDM     ( 1956): tdm_display.c: tdm_layer_unset_buffer(1602) > [1859.244523] layer(0x8fd250) now usable
04-23 19:23:18.959+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [1859.244533] layer[0x8fccf0]zpos[0]
04-23 19:23:18.959+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [1859.244625] dpms[0 -> 3]sync[1]
04-23 19:23:18.959+0200 I/TDM     ( 1956): 
04-23 19:23:18.959+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:963,2.590000,11.340000,2.170000
04-23 19:23:18.969+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:18.979+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.979+0200 W/WATCH_CORE( 2849): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
04-23 19:23:18.979+0200 W/W_HOME  ( 2773): dbus.c: _dbus_message_recv_cb(204) > LCD off
04-23 19:23:18.979+0200 W/W_HOME  ( 2773): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 19:23:18.979+0200 W/W_HOME  ( 2773): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-23 19:23:18.979+0200 W/W_HOME  ( 2773): gesture.c: _manual_render_enable(138) > 1
04-23 19:23:18.979+0200 W/W_HOME  ( 2773): event_manager.c: _lcd_off_cb(729) > lcd state: 0
04-23 19:23:18.979+0200 W/W_HOME  ( 2773): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 19:23:18.979+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
04-23 19:23:18.979+0200 W/STARTER ( 2701): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-23 19:23:18.979+0200 E/STARTER ( 2701): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
04-23 19:23:18.979+0200 E/STARTER ( 2701): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
04-23 19:23:18.979+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
04-23 19:23:18.979+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
04-23 19:23:18.979+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:18:985,13.440001,11.410000,1.820000
04-23 19:23:18.989+0200 W/WAKEUP-SERVICE( 3256): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -145052916[0;m
04-23 19:23:18.989+0200 I/heartrate(13102): capturing data from es.ugr.frailty.heartrate
04-23 19:23:18.989+0200 W/WAKEUP-SERVICE( 3256): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-23 19:23:18.989+0200 W/WAKEUP-SERVICE( 3256): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-23 19:23:18.989+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:23:18.989+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:23:18.989+0200 E/WAKEUP-SERVICE( 3256): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 19:23:18.999+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:18.999+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:19:6,32.410000,15.680000,-2.310000
04-23 19:23:19.009+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:23:19.009+0200 E/WAKEUP-SERVICE( 3256): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 19:23:19.009+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:23:19.009+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:23:19.009+0200 E/WAKEUP-SERVICE( 3256): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 19:23:19.009+0200 I/TIZEN_N_SOUND_MANAGER( 3256): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-23 19:23:19.019+0200 I/heartrate(13102): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:23:18:997,82
04-23 19:23:19.019+0200 I/TIZEN_N_SOUND_MANAGER( 3256): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-23 19:23:19.019+0200 W/TIZEN_N_SOUND_MANAGER( 3256): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 19:23:19.019+0200 W/WAKEUP-SERVICE( 3256): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-23 19:23:19.019+0200 I/HIGEAR  ( 3256): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-23 19:23:19.019+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:18:947,0.087394,-0.955612,-0.431831
04-23 19:23:19.019+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:19.019+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:19.029+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:19.029+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:19:32,26.180000,18.900000,-3.570000
04-23 19:23:19.029+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:19:28,0.279631,-0.452589,-0.915794
04-23 19:23:19.029+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:19.029+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:19:38,0.147267,0.323421,-0.936268
04-23 19:23:19.029+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:19.039+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:19.039+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:19:33,5.831308,7.944171,1.469193
04-23 19:23:19.039+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:19.039+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:19:29,5.684041,7.620749,2.405461
04-23 19:23:19.039+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:19.039+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:19:44,4.830000,14.700000,-5.530000
04-23 19:23:19.049+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:19:48,5.658766,7.658040,2.345886
04-23 19:23:19.049+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:19.049+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:19:47,5.740381,7.879565,1.684547
04-23 19:23:19.049+0200 I/accelerometer(13387): capturing data from es.ugr.frailty.accelerometer
04-23 19:23:19.059+0200 I/linearacceleration(13428): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:23:19:42,0.081615,0.221525,-0.661338
04-23 19:23:19.059+0200 I/linearacceleration(13428): capturing data from es.ugr.frailty.linearacceleration
04-23 19:23:19.059+0200 I/gravity (13439): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:23:19:56,5.659223,7.662715,2.329459
04-23 19:23:19.059+0200 I/gravity (13439): capturing data from es.ugr.frailty.gravity
04-23 19:23:19.069+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:19.069+0200 I/gyroscope(13400): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:23:19:74,6.300000,9.310000,-8.470000
04-23 19:23:19.079+0200 I/accelerometer(13387): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:23:19:61,5.900701,7.271788,1.859223
04-23 19:23:19.079+0200 I/gyroscope(13400): capturing data from es.ugr.frailty.gyroscope
04-23 19:23:19.089+0200 I/heartrate(13102): capturing data from es.ugr.frailty.heartrate
04-23 19:23:19.089+0200 I/heartrate(13102): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:23:19:93,82
04-23 19:23:19.099+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [1859.381221] dpms[3 -> 3]done
04-23 19:23:19.099+0200 I/TDM     ( 1956): 
04-23 19:23:19.099+0200 W/SHealthCommon( 2923): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 19:23:19.109+0200 I/watchface-viewer( 2849): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
04-23 19:23:19.109+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
04-23 19:23:19.109+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
04-23 19:23:19.109+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
04-23 19:23:19.109+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[1]
04-23 19:23:19.109+0200 I/APP_CORE( 2773): appcore-efl.c: __do_app(453) > [APP 2773] Event: PAUSE State: RUNNING
04-23 19:23:19.109+0200 I/CAPI_APPFW_APPLICATION( 2773): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-23 19:23:19.109+0200 W/W_HOME  ( 2773): main.c: _appcore_pause_cb(488) > appcore pause
04-23 19:23:19.109+0200 W/W_HOME  ( 2773): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
04-23 19:23:19.109+0200 W/W_HOME  ( 2773): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 19:23:19.109+0200 W/W_HOME  ( 2773): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 19:23:19.109+0200 W/W_HOME  ( 2773): main.c: home_pause(547) > clock/widget paused
04-23 19:23:19.109+0200 W/W_HOME  ( 2773): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 19:23:19.119+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 19:23:19.119+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 19:23:19.119+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 19:23:19.119+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 19:23:19.119+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 19:23:19.119+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 19:23:19.119+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 19:23:19.119+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 19:23:19.119+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 19:23:19.119+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 19:23:19.119+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 19:23:19.119+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 19:23:19.119+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 19:23:19.119+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 19:23:19.119+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 19:23:19.119+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 19:23:19.119+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 19:23:19.119+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 19:23:19.129+0200 W/CRASH_MANAGER(13195): worker.c: worker_job(1205) > 11134136c6f63152450419
