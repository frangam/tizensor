S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 3811
Date: 2018-04-23 18:54:37+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf765452d, r5   = 0xf7b1cf98
r6   = 0xffced620, r7   = 0xffced4d0
r8   = 0xf7b19c18, r9   = 0x00000000
r10  = 0xffced5ac, fp   = 0xffced620
ip   = 0x00000001, sp   = 0xffced4a8
lr   = 0xf7654539, pc   = 0xf76bd228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     75060 KB
Buffers:     31472 KB
Cached:     218776 KB
VmPeak:      53524 KB
VmSize:      53520 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11668 KB
VmRSS:       11668 KB
VmData:      11248 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3811 TID = 3811
3811 3829 

Maps Information
f451f000 f4d1e000 rw-p [stack:3829]
f4d25000 f4d27000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4d2f000 f4d33000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4d3c000 f4d3e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d46000 f4d49000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d58000 f4d5d000 r-xp /usr/lib/libsystem.so.0.0.0
f4d68000 f4d6b000 r-xp /lib/libattr.so.1.1.0
f4d73000 f4d83000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d8b000 f4d94000 r-xp /usr/lib/libedbus.so.1.7.99
f4d9c000 f4d9d000 r-xp /usr/lib/libresponse.so.0.2.96
f4da6000 f4dab000 r-xp /usr/lib/libproc-stat.so.0.2.96
f664d000 f6753000 r-xp /usr/lib/libicuuc.so.57.1
f6769000 f68f1000 r-xp /usr/lib/libicui18n.so.57.1
f6901000 f690e000 r-xp /usr/lib/libail.so.0.1.0
f6917000 f691e000 r-xp /usr/lib/libminizip.so.1.0.0
f6927000 f6ad0000 r-xp /usr/lib/libcrypto.so.1.0.0
f6af0000 f6b37000 r-xp /usr/lib/libssl.so.1.0.0
f6b43000 f6b45000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b4d000 f6b54000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b5d000 f6b64000 r-xp /lib/libcrypt-2.13.so
f6b95000 f6b98000 r-xp /lib/libcap.so.2.21
f6ba0000 f6ba2000 r-xp /usr/lib/libiri.so
f6baa000 f6bf3000 r-xp /usr/lib/libmdm.so.1.2.69
f6bfb000 f6c01000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c09000 f6c2c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6c36000 f6c38000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c40000 f6c5d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c66000 f6c6a000 r-xp /usr/lib/libsmack.so.1.0.0
f6c73000 f6c8c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c95000 f6c9d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6ca5000 f6cab000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6cb4000 f6cb6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6cbf000 f6ccf000 r-xp /lib/libresolv-2.13.so
f6cd3000 f6ceb000 r-xp /usr/lib/liblzma.so.5.0.3
f6cf4000 f6cf6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6cfe000 f6d18000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d20000 f6d4f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d58000 f6d67000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d71000 f6d7b000 r-xp /usr/lib/libsensord-shared.so
f6d84000 f6e57000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e62000 f6e78000 r-xp /lib/libz.so.1.2.5
f6e80000 f6e85000 r-xp /usr/lib/libffi.so.5.0.10
f6e8d000 f6e8e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e96000 f6ea6000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6eae000 f6ec7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6ecf000 f6ed1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ed9000 f6f4e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f58000 f6f5e000 r-xp /lib/librt-2.13.so
f6f67000 f6f85000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f8f000 f6f90000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f98000 f6fbb000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6fc3000 f6fc8000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6fd0000 f6ffa000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7003000 f701a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7022000 f708b000 r-xp /lib/libm-2.13.so
f7094000 f7128000 r-xp /usr/lib/libstdc++.so.6.0.16
f713b000 f7140000 r-xp /usr/lib/libctx-client.so.0.8.3
f7148000 f714f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7157000 f7181000 r-xp /usr/lib/libsensor.so.1.9.6
f718a000 f7256000 r-xp /usr/lib/libxml2.so.2.7.8
f7263000 f7265000 r-xp /usr/lib/libiniparser.so.0
f726e000 f7274000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f727d000 f734d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f734e000 f7382000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f738b000 f73c7000 r-xp /usr/lib/libSLP-location.so.0.9.24
f73cf000 f73d2000 r-xp /usr/lib/libbundle.so.0.1.22
f73da000 f73e0000 r-xp /usr/lib/libappsvc.so.0.1.0
f73e8000 f7429000 r-xp /usr/lib/libeina.so.1.7.99
f7432000 f7449000 r-xp /usr/lib/libecore.so.1.7.99
f7460000 f7469000 r-xp /usr/lib/libvconf.so.0.2.45
f7471000 f7485000 r-xp /lib/libpthread-2.13.so
f7490000 f749d000 r-xp /usr/lib/libaul.so.0.1.0
f74a7000 f74a9000 r-xp /lib/libdl-2.13.so
f74b2000 f74bd000 r-xp /lib/libunwind.so.8.0.1
f74ea000 f74f2000 r-xp /lib/libgcc_s-4.6.so.1
f74f3000 f7617000 r-xp /lib/libc-2.13.so
f7625000 f7627000 r-xp /usr/lib/libdlog.so.0.0.0
f762f000 f763b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7644000 f7649000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7651000 f7660000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7668000 f766c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7675000 f7678000 r-xp /usr/lib/libappcore-agent.so.1.1
f7680000 f7682000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f768a000 f768e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7696000 f76b3000 r-xp /lib/ld-2.13.so
f76bc000 f76bf000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f76bf000 f76c3000 r-xp /usr/lib/libsys-assert.so
f7ae9000 f7b6c000 rw-p [heap]
ffcce000 ffcef000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3811)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf76bd228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7654539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf735b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7359c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7365e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf736bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf736bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf73a075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf739b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7359c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7365e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf736bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf736bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf739de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf739e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf73a5f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4d3d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4d30171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e03663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf72b0fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72b27a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7442ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf743db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf743e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf743e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7676183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76767fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76bd4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf750a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf76bcf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
,9.159724
04-23 18:54:36.189+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.189+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.199+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.199+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:199,3.548556,-0.524028,9.403792
04-23 18:54:36.199+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:199,-0.494353,0.105426,0.491494
04-23 18:54:36.209+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:203,-2.450000,-0.280000,0.210000
04-23 18:54:36.209+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.209+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.219+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.219+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:220,-6.790000,-2.310000,0.070000
04-23 18:54:36.219+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:220,3.586841,-0.555135,9.327222
04-23 18:54:36.229+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:226,-0.441580,0.073461,0.408305
04-23 18:54:36.239+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.239+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.239+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:244,-9.380000,-2.310000,1.680000
04-23 18:54:36.239+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:244,3.474378,-0.612563,9.071191
04-23 18:54:36.239+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.249+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.249+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.259+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:259,-9.450000,-0.840000,7.420000
04-23 18:54:36.259+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:251,-0.569467,0.024484,0.159857
04-23 18:54:36.259+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.259+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:261,3.038885,-0.873380,9.839286
04-23 18:54:36.269+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:268,-1.023539,-0.219380,0.937635
04-23 18:54:36.269+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.279+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.279+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.289+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:282,-11.340000,-5.670000,2.730000
04-23 18:54:36.289+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:283,4.058227,-1.143769,9.243474
04-23 18:54:36.289+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:290,0.049396,-0.458487,0.319907
04-23 18:54:36.289+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.289+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.299+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:300,-0.492380,-0.146815,0.191272
04-23 18:54:36.299+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.299+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:300,1.050000,-1.260000,3.150000
04-23 18:54:36.309+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:306,3.558127,-0.873380,9.092726
04-23 18:54:36.309+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.309+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.319+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.319+0200 I/heartrate( 3654): capturing data from es.ugr.frailty.heartrate
04-23 18:54:36.319+0200 I/heartrate( 3654): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:54:36.319+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:319,3.744767,-0.751346,9.171689
04-23 18:54:36.319+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:319,-0.070000,-0.980000,2.660000
04-23 18:54:36.319+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:319,-0.262123,-0.017488,0.251114
04-23 18:54:36.339+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.339+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.339+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.389+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:351,-0.320892,-0.072798,0.186142
04-23 18:54:36.389+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:345,3.663411,-0.808774,9.116654
04-23 18:54:36.389+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.389+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.399+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:397,-0.381876,-0.245246,0.203913
04-23 18:54:36.399+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.409+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:409,-0.202982,-0.180842,0.261891
04-23 18:54:36.409+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.409+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:350,-2.380000,-1.260000,3.150000
04-23 18:54:36.409+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.409+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:415,-0.247508,-0.213180,0.177402
04-23 18:54:36.409+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.419+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:402,3.586841,-0.990629,9.140583
04-23 18:54:36.419+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.439+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:422,-0.233313,-0.201175,0.157130
04-23 18:54:36.439+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.439+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:417,-3.290000,-0.910000,2.730000
04-23 18:54:36.439+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.439+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:425,3.747160,-0.945165,9.205189
04-23 18:54:36.439+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:447,-0.182366,-0.175064,0.167328
04-23 18:54:36.449+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.449+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:449,-0.770000,-0.770000,2.800000
04-23 18:54:36.459+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.459+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:454,3.682554,-0.988236,9.128618
04-23 18:54:36.459+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.479+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.479+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:463,-0.420000,-1.050000,2.660000
04-23 18:54:36.479+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:471,-0.210517,-0.159999,0.271859
04-23 18:54:36.479+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.479+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:484,3.675375,-0.988236,9.116654
04-23 18:54:36.489+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.489+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.489+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:489,-0.182671,-0.075917,0.201424
04-23 18:54:36.489+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.499+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:494,-0.560000,-1.610000,2.520000
04-23 18:54:36.499+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.499+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:500,-0.241823,-0.117081,0.104324
04-23 18:54:36.509+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:496,3.708875,-0.973879,9.133404
04-23 18:54:36.509+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.509+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:507,-0.560000,-1.190000,2.450000
04-23 18:54:36.519+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.519+0200 I/heartrate( 3654): capturing data from es.ugr.frailty.heartrate
04-23 18:54:36.519+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.519+0200 I/heartrate( 3654): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:54:36:526,80
04-23 18:54:36.519+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:515,3.665804,-0.969093,9.243474
04-23 18:54:36.519+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.529+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:524,-0.110963,-0.082534,0.060982
04-23 18:54:36.529+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:526,0.420000,-1.470000,2.380000
04-23 18:54:36.529+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.539+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:532,3.672983,-0.892523,9.181261
04-23 18:54:36.539+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.539+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.539+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:549,-0.170289,-0.134484,0.050165
04-23 18:54:36.549+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:540,-1.050000,-1.960000,2.660000
04-23 18:54:36.549+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.559+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.559+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:546,3.603590,-0.940379,9.087940
04-23 18:54:36.559+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.559+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:564,-0.188684,-0.104241,0.075465
04-23 18:54:36.569+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:555,-0.490000,-2.240000,2.800000
04-23 18:54:36.569+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.569+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:568,3.720839,-0.914058,9.049655
04-23 18:54:36.569+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.569+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.579+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:575,1.260000,-1.260000,2.730000
04-23 18:54:36.579+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:577,3.646662,-0.969093,9.044869
04-23 18:54:36.579+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.589+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:592,3.613162,-0.945165,9.075976
04-23 18:54:36.589+0200 E/CAPI_TELEPHONY( 3701): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 18:54:36.589+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.589+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.599+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:582,-0.086344,-0.160976,0.027089
04-23 18:54:36.599+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:597,3.701697,-1.007378,9.032906
04-23 18:54:36.599+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.599+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.599+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:604,-0.066352,-0.148766,0.098595
04-23 18:54:36.599+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:605,3.713661,-1.002593,9.107083
04-23 18:54:36.599+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:588,0.770000,-1.050000,2.240000
04-23 18:54:36.599+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.609+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:611,0.280000,-0.700000,1.820000
04-23 18:54:36.609+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.609+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.609+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:615,0.350000,-0.280000,0.910000
04-23 18:54:36.609+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.609+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:618,-0.102753,-0.141312,0.154098
04-23 18:54:36.609+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:619,0.910000,0.770000,0.420000
04-23 18:54:36.619+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.619+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.619+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:623,1.400000,0.770000,-0.070000
04-23 18:54:36.619+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:623,3.665804,-1.000200,9.166903
04-23 18:54:36.639+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.639+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.639+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.639+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:648,-0.073601,-0.039775,0.157825
04-23 18:54:36.649+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:645,3.680161,-0.902094,9.176475
04-23 18:54:36.649+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:644,0.910000,0.700000,0.280000
04-23 18:54:36.649+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.649+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.659+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.659+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:659,-0.140000,-0.280000,1.330000
04-23 18:54:36.659+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:659,-0.064605,-0.035268,0.098031
04-23 18:54:36.659+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:663,3.677768,-0.897308,9.121440
04-23 18:54:36.669+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.669+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.679+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.679+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:681,-0.041936,-0.092741,0.146051
04-23 18:54:36.679+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:683,0.210000,-0.630000,1.540000
04-23 18:54:36.679+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:681,3.694518,-0.957129,9.171689
04-23 18:54:36.689+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.689+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.699+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.699+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:701,-0.049285,-0.057324,0.083747
04-23 18:54:36.699+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:704,3.680161,-0.926022,9.111869
04-23 18:54:36.699+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:701,0.560000,-0.560000,1.680000
04-23 18:54:36.709+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.709+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.719+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.719+0200 I/heartrate( 3654): capturing data from es.ugr.frailty.heartrate
04-23 18:54:36.719+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:719,3.692125,-0.957129,9.121440
04-23 18:54:36.729+0200 I/heartrate( 3654): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:54:36:727,80
04-23 18:54:36.729+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:719,-0.029663,-0.086098,0.090384
04-23 18:54:36.729+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:725,0.560000,-0.420000,1.330000
04-23 18:54:36.739+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.739+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.739+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:744,3.665804,-0.990629,9.049655
04-23 18:54:36.739+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:744,-0.049311,-0.116186,0.016181
04-23 18:54:36.739+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.749+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:751,0.980000,0.070000,1.400000
04-23 18:54:36.749+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.749+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.759+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:760,0.033783,-0.083144,0.056009
04-23 18:54:36.759+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:760,3.739982,-0.961915,9.092726
04-23 18:54:36.759+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.769+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:768,1.050000,0.280000,0.630000
04-23 18:54:36.769+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.769+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.779+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.779+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:779,-0.080625,-0.148240,0.001409
04-23 18:54:36.779+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:783,0.420000,0.700000,0.210000
04-23 18:54:36.789+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:779,3.620341,-1.028914,9.040084
04-23 18:54:36.789+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.789+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.799+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.799+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:801,1.400000,1.190000,-0.420000
04-23 18:54:36.809+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:801,0.003223,-0.161075,0.099548
04-23 18:54:36.809+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:809,3.696911,-1.048056,9.140583
04-23 18:54:36.809+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.809+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.819+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.819+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:821,1.890000,1.820000,-0.420000
04-23 18:54:36.819+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:819,0.033499,-0.082847,0.067665
04-23 18:54:36.829+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:827,3.718446,-0.973879,9.111869
04-23 18:54:36.839+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.839+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.839+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:844,-0.002313,-0.104927,0.011044
04-23 18:54:36.839+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.849+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:845,0.350000,1.680000,-0.420000
04-23 18:54:36.849+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.849+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.859+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:860,0.014159,-0.094057,0.023933
04-23 18:54:36.859+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:851,3.672983,-0.995414,9.059227
04-23 18:54:36.859+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.859+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:860,0.770000,2.100000,-0.420000
04-23 18:54:36.869+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:868,3.684947,-0.988236,9.073583
04-23 18:54:36.879+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.879+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.889+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:885,3.665804,-0.892523,9.162118
04-23 18:54:36.889+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:885,1.750000,2.520000,-0.280000
04-23 18:54:36.899+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.899+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:904,0.001327,0.003881,0.110132
04-23 18:54:36.899+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.909+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.909+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.919+0200 I/heartrate( 3654): capturing data from es.ugr.frailty.heartrate
04-23 18:54:36.929+0200 I/heartrate( 3654): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:54:36:927,81
04-23 18:54:36.929+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:912,0.016221,0.042425,0.202740
04-23 18:54:36.939+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:919,1.470000,1.960000,-0.420000
04-23 18:54:36.939+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.939+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:915,3.668197,-0.849452,9.260223
04-23 18:54:36.939+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:947,0.029532,0.098507,0.063745
04-23 18:54:36.949+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.949+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.959+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:955,0.560000,2.100000,-0.210000
04-23 18:54:36.959+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:954,3.670590,-0.787239,9.126225
04-23 18:54:36.959+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.959+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.959+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.979+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:969,3.634698,-0.839881,9.097511
04-23 18:54:36.979+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:968,-0.000932,0.039374,0.032221
04-23 18:54:36.979+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.979+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:970,-0.350000,1.470000,0.560000
04-23 18:54:36.979+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.979+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:36.989+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:36:988,3.684947,-0.928415,9.085547
04-23 18:54:36.989+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:36:986,0.052349,-0.050510,0.018910
04-23 18:54:36.999+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:36:988,0.210000,1.190000,0.210000
04-23 18:54:36.999+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:36.999+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:36.999+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:5,0.037313,-0.020119,0.068636
04-23 18:54:36.999+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.009+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:6,3.668197,-0.899701,9.135797
04-23 18:54:37.009+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:11,1.330000,1.960000,0.770000
04-23 18:54:37.009+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.009+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.009+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.009+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:16,3.720839,-0.818345,9.102298
04-23 18:54:37.009+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.019+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:16,-0.210000,2.310000,0.910000
04-23 18:54:37.019+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.019+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:21,3.692125,-0.911665,9.171689
04-23 18:54:37.019+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:19,0.099454,0.059335,0.031155
04-23 18:54:37.019+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.019+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:26,-2.730000,1.400000,0.980000
04-23 18:54:37.029+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:29,0.072408,-0.036665,0.099622
04-23 18:54:37.039+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.039+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.039+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:44,-2.240000,1.400000,1.750000
04-23 18:54:37.039+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:44,3.696911,-0.937986,9.066404
04-23 18:54:37.039+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.049+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:48,0.070527,-0.056479,-0.002370
04-23 18:54:37.049+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.049+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.059+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:60,3.706482,-1.103091,9.128618
04-23 18:54:37.059+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:60,0.140000,1.120000,1.820000
04-23 18:54:37.059+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.059+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:66,0.074863,-0.214295,0.062651
04-23 18:54:37.069+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.069+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.079+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:79,0.560000,2.450000,2.800000
04-23 18:54:37.079+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.079+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:79,3.661019,-1.036092,9.099905
04-23 18:54:37.079+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:85,0.033221,-0.137359,0.033387
04-23 18:54:37.089+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.089+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.099+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:99,3.531806,-1.150948,9.116654
04-23 18:54:37.099+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:100,-0.420000,3.150000,2.660000
04-23 18:54:37.099+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.109+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:106,-0.085425,-0.246204,0.046514
04-23 18:54:37.109+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.109+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.109+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.119+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:119,3.507878,-0.937986,9.221939
04-23 18:54:37.119+0200 I/heartrate( 3654): capturing data from es.ugr.frailty.heartrate
04-23 18:54:37.119+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:120,-0.095432,-0.020333,0.147554
04-23 18:54:37.119+0200 I/heartrate( 3654): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:54:37:126,81
04-23 18:54:37.129+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:120,1.190000,3.640000,2.100000
04-23 18:54:37.139+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.139+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.139+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:144,3.474378,-0.885344,9.188439
04-23 18:54:37.149+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 18:54:37.149+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:54:37.149+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 18:54:37.149+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.149+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.159+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:144,-0.108068,0.030827,0.105648
04-23 18:54:37.159+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.169+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:160,3.596412,-1.036092,9.260223
04-23 18:54:37.169+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:167,0.020542,-0.116415,0.175196
04-23 18:54:37.169+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:157,-2.590000,3.080000,2.100000
04-23 18:54:37.169+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.169+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.179+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.179+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:178,-4.830000,1.540000,1.820000
04-23 18:54:37.179+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.179+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:183,3.620341,-1.043271,9.087940
04-23 18:54:37.189+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:180,0.036339,-0.109348,0.007571
04-23 18:54:37.189+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:188,-4.270000,1.190000,1.960000
04-23 18:54:37.189+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.189+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.199+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.199+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:200,-0.770000,0.980000,1.820000
04-23 18:54:37.209+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:203,3.548556,-1.040878,8.994620
04-23 18:54:37.209+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:200,-0.045425,-0.093264,-0.080384
04-23 18:54:37.219+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.219+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.219+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.229+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:225,0.072449,-0.055232,0.206285
04-23 18:54:37.239+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:225,1.400000,0.770000,0.280000
04-23 18:54:37.239+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.239+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.239+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:224,3.663411,-1.009771,9.281759
04-23 18:54:37.249+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:249,-3.080000,1.190000,0.490000
04-23 18:54:37.249+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.249+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:249,0.041183,-0.082660,0.220144
04-23 18:54:37.249+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.259+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.259+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:258,3.625126,-1.036092,9.298509
04-23 18:54:37.259+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.259+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:262,0.053111,-0.222454,0.234917
04-23 18:54:37.269+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:260,-5.320000,-0.420000,0.490000
04-23 18:54:37.269+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:269,3.641876,-1.184447,9.310472
04-23 18:54:37.269+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.269+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.279+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.279+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:280,-0.028789,-0.274872,0.235720
04-23 18:54:37.279+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:280,-4.620000,-3.570000,0.490000
04-23 18:54:37.289+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:283,3.574877,-1.256232,9.303294
04-23 18:54:37.289+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.289+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.299+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.299+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:301,3.448057,-1.136591,9.332008
04-23 18:54:37.309+0200 W/LOCATION( 3811): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 18:54:37.319+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:300,2.310000,-6.720000,1.330000
04-23 18:54:37.319+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.319+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.319+0200 I/heartrate( 3654): capturing data from es.ugr.frailty.heartrate
04-23 18:54:37.329+0200 I/heartrate( 3654): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:54:37:328,81
04-23 18:54:37.329+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:328,4.200000,-8.610000,0.910000
04-23 18:54:37.329+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:325,3.560520,-0.868595,9.442079
04-23 18:54:37.339+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:305,-0.170441,-0.133889,0.272679
04-23 18:54:37.339+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.339+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.339+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.339+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:345,-0.049958,0.137348,0.379909
04-23 18:54:37.339+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.349+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:344,-4.130000,-10.920000,2.380000
04-23 18:54:37.349+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:347,3.596412,-0.887737,9.377472
04-23 18:54:37.349+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.359+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.359+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:352,-0.009700,0.104856,0.312093
04-23 18:54:37.369+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:363,3.617948,-1.153341,9.135797
04-23 18:54:37.369+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:360,-14.980000,-14.770000,3.710000
04-23 18:54:37.369+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.369+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.379+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.379+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:383,3.895515,-0.937986,9.049655
04-23 18:54:37.389+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:376,-0.014807,-0.155567,0.081631
04-23 18:54:37.389+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:382,-17.570000,-16.520000,4.550000
04-23 18:54:37.389+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.389+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.389+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.399+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:400,-16.100000,-14.840000,4.060000
04-23 18:54:37.409+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:398,0.194827,0.099774,0.027552
04-23 18:54:37.409+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:401,4.065405,-0.978664,9.217153
04-23 18:54:37.409+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.409+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.409+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.419+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:416,0.277823,0.092412,0.235092
04-23 18:54:37.419+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:419,3.979264,-1.021735,8.851050
04-23 18:54:37.419+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:420,-23.520000,-12.600000,4.620000
04-23 18:54:37.419+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.429+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:433,0.113234,0.078347,-0.094005
04-23 18:54:37.439+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.439+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.439+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.439+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:448,0.071065,-0.028147,-0.332659
04-23 18:54:37.449+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:444,-35.840000,-11.620000,5.250000
04-23 18:54:37.449+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:444,4.029513,-1.172483,8.566305
04-23 18:54:37.449+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.449+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.449+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.459+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:459,-0.087754,-0.434673,-0.233835
04-23 18:54:37.459+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:460,-42.980000,-11.480000,5.180000
04-23 18:54:37.459+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:460,3.993621,-1.651048,8.599805
04-23 18:54:37.469+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.469+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.469+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.479+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:479,-0.170182,-0.705807,-0.022361
04-23 18:54:37.479+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:480,-32.480000,-9.380000,4.970000
04-23 18:54:37.479+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:480,4.034299,-2.024328,8.738588
04-23 18:54:37.489+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.489+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.499+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.499+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:500,-0.247849,-0.579082,-0.059772
04-23 18:54:37.499+0200 I/gyroscope( 3775): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:37:503,-9.240000,-1.890000,4.060000
04-23 18:54:37.499+0200 I/accelerometer( 3756): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:37:500,4.031906,-1.990828,8.650054
04-23 18:54:37.509+0200 I/linearacceleration( 3816): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:37.509+0200 I/gyroscope( 3775): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:37.509+0200 I/accelerometer( 3756): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:37.509+0200 I/linearacceleration( 3816): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:37:519,-0.389663,-0.561700,-0.110504
04-23 18:54:37.519+0200 I/heartrate( 3654): capturing data from es.ugr.frailty.heartrate
04-23 18:54:37.539+0200 W/CRASH_MANAGER( 3712): worker.c: worker_job(1205) > 11038116c6f63152450247
