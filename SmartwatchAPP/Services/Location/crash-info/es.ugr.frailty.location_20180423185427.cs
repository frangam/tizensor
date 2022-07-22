S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 3661
Date: 2018-04-23 18:54:27+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf771652d, r5   = 0xf7931f98
r6   = 0xff92b210, r7   = 0xff92b0c0
r8   = 0xf792ec18, r9   = 0x00000000
r10  = 0xff92b19c, fp   = 0xff92b210
ip   = 0x00000001, sp   = 0xff92b098
lr   = 0xf7716539, pc   = 0xf777f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     83328 KB
Buffers:     31104 KB
Cached:     214368 KB
VmPeak:      53460 KB
VmSize:      53444 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11888 KB
VmRSS:       11888 KB
VmData:      11172 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3661 TID = 3661
3661 3700 

Maps Information
f45e1000 f4de0000 rw-p [stack:3700]
f4de7000 f4de9000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4df1000 f4df5000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4dfe000 f4e00000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4e08000 f4e0b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4e1a000 f4e1f000 r-xp /usr/lib/libsystem.so.0.0.0
f4e2a000 f4e2d000 r-xp /lib/libattr.so.1.1.0
f4e35000 f4e45000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e4d000 f4e56000 r-xp /usr/lib/libedbus.so.1.7.99
f4e5e000 f4e5f000 r-xp /usr/lib/libresponse.so.0.2.96
f4e68000 f4e6d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f670f000 f6815000 r-xp /usr/lib/libicuuc.so.57.1
f682b000 f69b3000 r-xp /usr/lib/libicui18n.so.57.1
f69c3000 f69d0000 r-xp /usr/lib/libail.so.0.1.0
f69d9000 f69e0000 r-xp /usr/lib/libminizip.so.1.0.0
f69e9000 f6b92000 r-xp /usr/lib/libcrypto.so.1.0.0
f6bb2000 f6bf9000 r-xp /usr/lib/libssl.so.1.0.0
f6c05000 f6c07000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6c0f000 f6c16000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6c1f000 f6c26000 r-xp /lib/libcrypt-2.13.so
f6c57000 f6c5a000 r-xp /lib/libcap.so.2.21
f6c62000 f6c64000 r-xp /usr/lib/libiri.so
f6c6c000 f6cb5000 r-xp /usr/lib/libmdm.so.1.2.69
f6cbd000 f6cc3000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6ccb000 f6cee000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6cf8000 f6cfa000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6d02000 f6d1f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d28000 f6d2c000 r-xp /usr/lib/libsmack.so.1.0.0
f6d35000 f6d4e000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d57000 f6d5f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d67000 f6d6d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d76000 f6d78000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d81000 f6d91000 r-xp /lib/libresolv-2.13.so
f6d95000 f6dad000 r-xp /usr/lib/liblzma.so.5.0.3
f6db6000 f6db8000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6dc0000 f6dda000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6de2000 f6e11000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e1a000 f6e29000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e33000 f6e3d000 r-xp /usr/lib/libsensord-shared.so
f6e46000 f6f19000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f24000 f6f3a000 r-xp /lib/libz.so.1.2.5
f6f42000 f6f47000 r-xp /usr/lib/libffi.so.5.0.10
f6f4f000 f6f50000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f58000 f6f68000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f70000 f6f89000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f91000 f6f93000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f9b000 f7010000 r-xp /usr/lib/libsqlite3.so.0.8.6
f701a000 f7020000 r-xp /lib/librt-2.13.so
f7029000 f7047000 r-xp /usr/lib/libsystemd.so.0.4.0
f7051000 f7052000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f705a000 f707d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7085000 f708a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7092000 f70bc000 r-xp /usr/lib/libdbus-1.so.3.8.12
f70c5000 f70dc000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70e4000 f714d000 r-xp /lib/libm-2.13.so
f7156000 f71ea000 r-xp /usr/lib/libstdc++.so.6.0.16
f71fd000 f7202000 r-xp /usr/lib/libctx-client.so.0.8.3
f720a000 f7211000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7219000 f7243000 r-xp /usr/lib/libsensor.so.1.9.6
f724c000 f7318000 r-xp /usr/lib/libxml2.so.2.7.8
f7325000 f7327000 r-xp /usr/lib/libiniparser.so.0
f7330000 f7336000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f733f000 f740f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7410000 f7444000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f744d000 f7489000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7491000 f7494000 r-xp /usr/lib/libbundle.so.0.1.22
f749c000 f74a2000 r-xp /usr/lib/libappsvc.so.0.1.0
f74aa000 f74eb000 r-xp /usr/lib/libeina.so.1.7.99
f74f4000 f750b000 r-xp /usr/lib/libecore.so.1.7.99
f7522000 f752b000 r-xp /usr/lib/libvconf.so.0.2.45
f7533000 f7547000 r-xp /lib/libpthread-2.13.so
f7552000 f755f000 r-xp /usr/lib/libaul.so.0.1.0
f7569000 f756b000 r-xp /lib/libdl-2.13.so
f7574000 f757f000 r-xp /lib/libunwind.so.8.0.1
f75ac000 f75b4000 r-xp /lib/libgcc_s-4.6.so.1
f75b5000 f76d9000 r-xp /lib/libc-2.13.so
f76e7000 f76e9000 r-xp /usr/lib/libdlog.so.0.0.0
f76f1000 f76fd000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7706000 f770b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7713000 f7722000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f772a000 f772e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7737000 f773a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7742000 f7744000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f774c000 f7750000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7758000 f7775000 r-xp /lib/ld-2.13.so
f777e000 f7781000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7781000 f7785000 r-xp /usr/lib/libsys-assert.so
f78fe000 f796e000 rw-p [heap]
ff90c000 ff92d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3661)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf777f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7716539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf741d3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf741bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7427e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf742dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf742ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf746275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf745d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf741bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7427e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf742dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf742ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf745fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7460017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7467f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4dff1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4df2171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ec5663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7372fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73747a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7504ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf74ffb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf75005a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7500879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7738183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf77387fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf777f4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf75cc85c) [/lib/libc.so.6] + 0x1785c
29: (0xf777ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
49+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.369+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.379+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:378,-34.720001,-13.370000,-8.960000
04-23 18:54:26.379+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:350,-0.346374,-0.445753,0.758515
04-23 18:54:26.379+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.379+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.389+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:392,-36.119999,-15.610000,-5.880000
04-23 18:54:26.389+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:388,-0.358785,-0.873754,0.975460
04-23 18:54:26.389+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.399+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.409+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:411,-38.570000,-12.530000,-3.220000
04-23 18:54:26.409+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:402,0.009329,-1.056778,0.858647
04-23 18:54:26.409+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.419+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:419,0.206506,-1.157635,0.908506
04-23 18:54:26.419+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:350,9.061620,0.720240,3.268596
04-23 18:54:26.419+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.429+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.429+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:431,9.087940,0.330210,3.316452
04-23 18:54:26.429+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:433,-38.500000,-6.510000,-1.890000
04-23 18:54:26.429+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.429+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.439+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:438,9.487542,0.157926,3.062813
04-23 18:54:26.439+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:440,0.011557,-1.403319,1.153805
04-23 18:54:26.439+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.439+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.449+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:453,-27.090000,-6.440000,-0.490000
04-23 18:54:26.449+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.459+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:447,9.712467,0.038285,3.000600
04-23 18:54:26.459+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:459,0.029433,-1.721167,1.078200
04-23 18:54:26.459+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.469+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.469+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:474,-18.830000,-4.200000,-2.100000
04-23 18:54:26.479+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.489+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.489+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:494,-14.420000,-0.700000,-1.750000
04-23 18:54:26.489+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:469,9.542577,-0.241675,3.148954
04-23 18:54:26.489+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.499+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:500,9.580862,-0.605384,3.000600
04-23 18:54:26.499+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:483,0.155807,-1.400485,0.746722
04-23 18:54:26.499+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.499+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.499+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:504,-0.080841,-1.674647,1.200853
04-23 18:54:26.499+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:504,9.724431,-0.342174,2.615355
04-23 18:54:26.499+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.499+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.509+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:512,-8.680000,-0.910000,-1.470000
04-23 18:54:26.509+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:509,9.501899,-0.684347,3.034099
04-23 18:54:26.509+0200 I/heartrate( 3654): capturing data from es.ugr.frailty.heartrate
04-23 18:54:26.509+0200 I/heartrate( 3654): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:54:26.509+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.519+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:519,-0.459723,-1.857472,1.427352
04-23 18:54:26.519+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.519+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:524,9.138189,-0.916451,3.206382
04-23 18:54:26.529+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.529+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:533,-6.230000,-1.890000,-1.190000
04-23 18:54:26.529+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.529+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:537,-0.457736,-1.666637,1.624509
04-23 18:54:26.529+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.539+0200 E/CAPI_TELEPHONY( 3701): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 18:54:26.539+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:542,9.150154,-0.792024,3.383451
04-23 18:54:26.549+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.549+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.549+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:553,-5.040000,-4.270000,-0.770000
04-23 18:54:26.549+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:553,-0.382590,-1.400239,1.226859
04-23 18:54:26.549+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.549+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:557,9.231510,-0.602991,2.988636
04-23 18:54:26.559+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.559+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.569+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:572,-6.720000,-5.460000,-0.980000
04-23 18:54:26.569+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:572,-0.185231,-1.282958,1.477187
04-23 18:54:26.569+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.569+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:577,9.434900,-0.552742,3.235096
04-23 18:54:26.589+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.589+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.589+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:595,-0.210203,-1.615096,1.240290
04-23 18:54:26.589+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.599+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:595,6.930000,-8.120000,0.070000
04-23 18:54:26.599+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:600,9.418150,-0.937986,2.974278
04-23 18:54:26.599+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.599+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.609+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:612,-0.033100,-1.381778,1.129469
04-23 18:54:26.609+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.609+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:617,9.604790,-0.746561,2.825923
04-23 18:54:26.609+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:612,28.420000,-6.860000,-3.360000
04-23 18:54:26.629+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.629+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.629+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:633,29.540001,-5.810000,-5.950000
04-23 18:54:26.629+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:634,9.731609,0.033500,2.397608
04-23 18:54:26.629+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.639+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:640,0.084705,-0.558336,0.737077
04-23 18:54:26.649+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.649+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.649+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:653,9.734003,-0.129212,2.761317
04-23 18:54:26.649+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:653,12.810000,-7.420000,-6.650000
04-23 18:54:26.649+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.659+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:659,0.076324,-0.694832,1.155179
04-23 18:54:26.669+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.669+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.669+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:674,9.477970,-0.526421,3.139383
04-23 18:54:26.669+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:674,-1.470000,-4.410000,-5.530000
04-23 18:54:26.669+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.679+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 18:54:26.679+0200 W/libgps  ( 3158): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(126965), time2(58015)
04-23 18:54:26.679+0200 W/libgps  ( 3158): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 18:54:26.679+0200 W/libgps  ( 3158): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 18:54:26.679+0200 I/libgps_d( 3158): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 18:54:26.679+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:2, msg id:25
04-23 18:54:26.679+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:681,-0.197696,-1.104475,1.650180
04-23 18:54:26.679+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.689+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.689+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:692,9.556933,-0.782453,2.979064
04-23 18:54:26.689+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:693,0.280000,-9.240000,-7.700000
04-23 18:54:26.689+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.699+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:702,-0.128844,-1.348927,1.552458
04-23 18:54:26.699+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.709+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.709+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.709+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:712,9.903893,-0.703490,2.462214
04-23 18:54:26.719+0200 I/heartrate( 3654): capturing data from es.ugr.frailty.heartrate
04-23 18:54:26.719+0200 I/heartrate( 3654): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:54:26.719+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:713,13.650000,-12.670000,-10.640000
04-23 18:54:26.719+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:714,0.212222,-1.242671,1.065373
04-23 18:54:26.729+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.729+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.729+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.729+0200 I/APP_CORE( 2773): appcore-efl.c: __do_app(453) > [APP 2773] Event: MEM_FLUSH State: PAUSED
04-23 18:54:26.739+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:733,9.927821,-0.217747,2.356930
04-23 18:54:26.739+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:738,0.229267,-0.731400,0.998772
04-23 18:54:26.749+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.749+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.759+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:734,17.360001,-10.430000,-14.490000
04-23 18:54:26.759+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:754,9.705289,0.086142,2.206182
04-23 18:54:26.759+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:755,-0.013288,-0.423204,0.997788
04-23 18:54:26.759+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.759+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:766,1.330000,-7.280000,-14.700000
04-23 18:54:26.769+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.769+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.769+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:773,-0.063537,-0.734271,1.246642
04-23 18:54:26.769+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:773,9.655040,-0.224925,2.455036
04-23 18:54:26.769+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.779+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:779,-1.050000,-7.910000,-14.700000
04-23 18:54:26.779+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.779+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.789+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:792,9.724431,-0.598206,2.464607
04-23 18:54:26.789+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:792,-0.007324,-1.129532,1.377858
04-23 18:54:26.789+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.799+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:799,10.780000,-7.140000,-18.410000
04-23 18:54:26.799+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.799+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.809+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:812,9.619147,-0.162712,2.435893
04-23 18:54:26.809+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:812,-0.122379,-0.707940,1.448084
04-23 18:54:26.809+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.809+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:817,21.350000,-1.960000,-21.210001
04-23 18:54:26.829+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.829+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.829+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.829+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:834,9.477970,0.265603,2.366502
04-23 18:54:26.839+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:834,-0.269631,-0.281127,1.441444
04-23 18:54:26.849+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.849+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:853,9.207582,0.464208,2.196611
04-23 18:54:26.859+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:840,11.410000,2.450000,-21.350000
04-23 18:54:26.859+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.869+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.869+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.879+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:872,-0.547407,-0.100607,1.365011
04-23 18:54:26.879+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:877,9.657433,0.217747,2.533999
04-23 18:54:26.889+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.889+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.899+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:870,-7.000000,0.560000,-17.710001
04-23 18:54:26.899+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:894,9.698111,0.150748,2.620141
04-23 18:54:26.899+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.909+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:895,-0.105467,-0.372028,1.821016
04-23 18:54:26.909+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.919+0200 I/heartrate( 3654): capturing data from es.ugr.frailty.heartrate
04-23 18:54:26.919+0200 I/heartrate( 3654): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:54:26.919+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.919+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:910,-10.430000,-4.410000,-17.430000
04-23 18:54:26.929+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.929+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:918,-0.073220,-0.472514,2.069660
04-23 18:54:26.939+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.939+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:926,9.377472,0.318245,2.914458
04-23 18:54:26.939+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.949+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:945,9.131011,0.471386,2.574677
04-23 18:54:26.949+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:937,-0.770000,0.140000,-18.410000
04-23 18:54:26.949+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:944,-0.398743,-0.325342,2.488065
04-23 18:54:26.959+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.959+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.959+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.969+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:971,9.552148,0.803988,2.050649
04-23 18:54:26.969+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:963,-0.070000,5.110000,-19.180000
04-23 18:54:26.969+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.979+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:970,-0.648139,-0.187699,2.251847
04-23 18:54:26.979+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.979+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.989+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:989,-0.228771,0.126493,1.838489
04-23 18:54:26.989+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:982,-3.710000,4.410000,-18.830000
04-23 18:54:26.989+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.989+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.989+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:26:989,9.489935,0.545564,2.505285
04-23 18:54:26.989+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:995,-0.291451,-0.155855,2.451420
04-23 18:54:26.989+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.999+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:26.999+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:26:999,-0.490769,0.166887,2.976551
04-23 18:54:26.999+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:26:995,-5.250000,1.260000,-18.270000
04-23 18:54:26.999+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:26.999+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:4,9.286544,0.899701,2.782853
04-23 18:54:26.999+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:26.999+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.009+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:12,-0.544861,0.011451,3.030834
04-23 18:54:27.009+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:12,9.226725,0.760918,2.677568
04-23 18:54:27.009+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:6,-10.570000,3.150000,-16.309999
04-23 18:54:27.009+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.019+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:20,-11.130000,3.430000,-17.360001
04-23 18:54:27.019+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.019+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:25,-18.969999,1.820000,-15.960000
04-23 18:54:27.029+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.029+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.029+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.029+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:34,-0.283600,-0.098885,3.247050
04-23 18:54:27.039+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:35,9.477970,0.672383,2.711068
04-23 18:54:27.039+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:35,-27.650000,-1.260000,-15.470000
04-23 18:54:27.049+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.049+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.049+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.049+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:53,-0.190450,0.351802,3.132804
04-23 18:54:27.049+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:53,-34.930000,2.870000,-13.300000
04-23 18:54:27.049+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:53,9.561719,1.136591,2.462214
04-23 18:54:27.069+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.069+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.069+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.079+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:73,-0.237848,-0.358200,2.896876
04-23 18:54:27.079+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:79,9.509077,0.430708,2.158326
04-23 18:54:27.079+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:79,-26.600000,4.480000,-11.410000
04-23 18:54:27.089+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.089+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.089+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:94,9.614362,0.741775,3.156133
04-23 18:54:27.089+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.089+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:93,-0.113533,-0.059692,4.102759
04-23 18:54:27.099+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:101,-2.380000,10.430000,-14.630000
04-23 18:54:27.109+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.109+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.109+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.109+0200 I/heartrate( 3654): capturing data from es.ugr.frailty.heartrate
04-23 18:54:27.109+0200 I/heartrate( 3654): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:54:27.119+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:113,-0.580743,0.606253,4.062139
04-23 18:54:27.119+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:113,9.131011,1.404587,2.959922
04-23 18:54:27.119+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:119,6.230000,7.770000,-12.600000
04-23 18:54:27.129+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.129+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.129+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.139+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 18:54:27.139+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:54:27.139+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 18:54:27.149+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:134,-0.472938,0.293489,4.144882
04-23 18:54:27.149+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:134,9.217153,1.088734,2.864209
04-23 18:54:27.149+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.149+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.159+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:140,3.990000,1.540000,-9.800000
04-23 18:54:27.159+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:163,-0.395467,0.375895,4.161310
04-23 18:54:27.169+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.169+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.169+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:161,9.253045,1.172483,2.598605
04-23 18:54:27.179+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.179+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:176,-1.470000,4.900000,-8.120000
04-23 18:54:27.179+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.179+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:174,-0.195300,0.463757,4.157567
04-23 18:54:27.189+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.189+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:187,-12.180000,4.690000,-4.410000
04-23 18:54:27.189+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.189+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:183,9.425328,1.249053,2.426322
04-23 18:54:27.189+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.199+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:194,-0.062253,0.248238,4.584365
04-23 18:54:27.199+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:200,-13.580000,6.090000,-2.030000
04-23 18:54:27.209+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.209+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.209+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:213,1.845105,0.191228,-3.123469
04-23 18:54:27.209+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:214,-3.990000,5.740000,-1.190000
04-23 18:54:27.209+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:202,9.535398,1.016950,2.723032
04-23 18:54:27.219+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.219+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:223,9.410972,0.839881,3.081956
04-23 18:54:27.229+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.229+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.229+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:234,4.480000,5.040000,-1.260000
04-23 18:54:27.229+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.239+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:241,9.226725,1.004985,3.177669
04-23 18:54:27.239+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:234,1.503526,0.309097,-2.825525
04-23 18:54:27.249+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.259+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:257,0.490000,3.080000,0.490000
04-23 18:54:27.259+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.259+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:264,1.276343,0.263408,-2.775147
04-23 18:54:27.269+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.269+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.279+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.279+0200 W/LOCATION( 3661): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 18:54:27.289+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:288,-10.710000,2.170000,1.890000
04-23 18:54:27.289+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.289+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:275,9.131011,0.993021,3.050849
04-23 18:54:27.289+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.299+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:297,-6.510000,0.560000,5.530000
04-23 18:54:27.299+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:279,1.277712,0.372043,-3.180658
04-23 18:54:27.299+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.309+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.309+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:301,9.260223,1.134198,2.464607
04-23 18:54:27.309+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.309+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:313,-4.270000,1.750000,5.530000
04-23 18:54:27.309+0200 I/heartrate( 3654): capturing data from es.ugr.frailty.heartrate
04-23 18:54:27.309+0200 I/heartrate( 3654): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:54:27.319+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:309,1.499191,0.451270,-2.265929
04-23 18:54:27.319+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.329+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.329+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:331,0.860796,0.567552,-1.595833
04-23 18:54:27.329+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:334,-2.730000,-6.510000,7.350000
04-23 18:54:27.339+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.349+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.349+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:319,9.573684,1.229911,3.244668
04-23 18:54:27.349+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.349+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:353,-0.280000,-5.530000,6.020000
04-23 18:54:27.349+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:355,9.205189,1.397408,3.488736
04-23 18:54:27.349+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.349+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:349,0.535372,0.069845,-2.328037
04-23 18:54:27.359+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.359+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:364,0.815725,-0.086303,-2.063499
04-23 18:54:27.369+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.369+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:374,2.450000,-1.610000,5.880000
04-23 18:54:27.369+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.369+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:360,8.879765,0.899701,2.756532
04-23 18:54:27.379+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.379+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:379,0.894689,-0.174837,-2.374566
04-23 18:54:27.379+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:383,9.367901,0.770489,2.658426
04-23 18:54:27.379+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.389+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.389+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.389+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:394,0.914656,-0.040425,-1.908988
04-23 18:54:27.389+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:394,1.190000,1.960000,5.180000
04-23 18:54:27.399+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:392,9.446864,0.681954,2.347359
04-23 18:54:27.399+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.399+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:404,9.556933,0.813560,2.646462
04-23 18:54:27.399+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.409+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.409+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:412,0.468966,-0.024315,-1.686603
04-23 18:54:27.409+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:413,-4.760000,2.800000,7.350000
04-23 18:54:27.409+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.409+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:418,9.193225,0.823131,2.711068
04-23 18:54:27.429+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.429+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.429+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:434,0.414721,-0.294083,-1.389772
04-23 18:54:27.429+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:434,-3.360000,-2.240000,8.400000
04-23 18:54:27.429+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.439+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:441,9.202796,0.543171,2.880959
04-23 18:54:27.449+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.449+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.449+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:453,0.248640,-0.050737,-0.845516
04-23 18:54:27.449+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:453,8.120000,0.140000,11.550000
04-23 18:54:27.449+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.459+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:460,9.099905,0.775275,3.294917
04-23 18:54:27.469+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.469+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.469+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:474,-0.086777,0.403626,-0.733320
04-23 18:54:27.469+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:474,13.860000,0.980000,15.120000
04-23 18:54:27.469+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.469+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:479,8.827123,1.203590,3.275774
04-23 18:54:27.489+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.489+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.489+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:493,-0.141799,0.750377,-0.690089
04-23 18:54:27.489+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:493,11.620000,-4.270000,21.350000
04-23 18:54:27.489+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.489+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:498,8.839087,1.531406,3.170490
04-23 18:54:27.499+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.509+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.509+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:512,-0.287872,0.876517,-0.547247
04-23 18:54:27.509+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:513,6.440000,-5.810000,29.750000
04-23 18:54:27.509+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.509+0200 I/heartrate( 3654): capturing data from es.ugr.frailty.heartrate
04-23 18:54:27.509+0200 I/heartrate( 3654): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:54:27.519+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:518,8.769694,1.646262,3.132205
04-23 18:54:27.529+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.529+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:534,-0.674217,0.779455,-0.004855
04-23 18:54:27.539+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.539+0200 I/servicemanager( 3619): es.ugr.frailty.location sleep timeout
04-23 18:54:27.539+0200 W/AUL     ( 3619): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 18:54:27.539+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:54:27.539+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 3619
04-23 18:54:27.539+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:543,9.660000,-6.930000,39.200001
04-23 18:54:27.539+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.549+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.549+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:554,-0.897109,0.469961,0.309209
04-23 18:54:27.549+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 3661
04-23 18:54:27.559+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:552,8.463413,1.533799,3.474378
04-23 18:54:27.559+0200 E/AUL_AMD ( 2478): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 18:54:27.559+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 18:54:27.559+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(3661), cmd(0)
04-23 18:54:27.569+0200 W/libgps_d( 3158): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 18:54:27.569+0200 W/libgps  ( 3158): [proxy__gps_stop][line = 1067]: called.
04-23 18:54:27.569+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:54:27.569+0200 W/libgps_d( 3158): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 18:54:27.569+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 18:54:27.569+0200 W/libgps_d( 3158): GpsiHookStateGps              : EXIT
04-23 18:54:27.569+0200 W/libgps_d( 3158): GpsiHookStateIdle             : ENTRY
04-23 18:54:27.569+0200 E/CAPI_LOCATION_MANAGER( 3701): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 18:54:27.569+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.579+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:0, msg id:2
04-23 18:54:27.579+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:54:27.579+0200 W/AUL     ( 3619): launch.c: app_request_to_launchpad(298) > request cmd(0) result(3661)
04-23 18:54:27.599+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.639+0200 I/CAPI_NETWORK_CONNECTION( 3701): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 18:54:27.639+0200 I/CAPI_NETWORK_CONNECTION( 3701): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 18:54:27.639+0200 I/CAPI_NETWORK_CONNECTION( 3701): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 18:54:27.639+0200 I/CAPI_NETWORK_CONNECTION( 3701): connection.c: connection_destroy(471) > Destroy handle: 0xf3f00960
04-23 18:54:27.649+0200 I/servicemanager( 3619): es.ugr.frailty.location stop request sent!
04-23 18:54:27.649+0200 I/servicemanager( 3619): App control destroyed.
04-23 18:54:27.649+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.659+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:609,19.600000,-11.130000,47.810001
04-23 18:54:27.659+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:582,-0.841313,0.232114,0.368753
04-23 18:54:27.659+0200 I/linearacceleration( 3684): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:27.659+0200 I/gyroscope( 3631): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:27.659+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:661,8.324631,1.196411,3.565305
04-23 18:54:27.669+0200 I/accelerometer( 3630): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:27.669+0200 I/accelerometer( 3630): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:27:675,8.461020,0.911665,3.397808
04-23 18:54:27.669+0200 I/gyroscope( 3631): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:27:668,31.150000,-16.309999,57.260002
04-23 18:54:27.669+0200 I/linearacceleration( 3684): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:27:667,-0.870021,0.204548,0.452198
04-23 18:54:27.689+0200 W/CRASH_MANAGER( 3712): worker.c: worker_job(1205) > 11036616c6f63152450246
