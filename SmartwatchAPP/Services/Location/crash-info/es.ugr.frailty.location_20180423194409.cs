S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20704
Date: 2018-04-23 19:44:09+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf76d052d, r5   = 0xf7c4ff98
r6   = 0xff8309e0, r7   = 0xff830890
r8   = 0xf7c4cc18, r9   = 0x00000000
r10  = 0xff83096c, fp   = 0xff8309e0
ip   = 0x00000001, sp   = 0xff830868
lr   = 0xf76d0539, pc   = 0xf7739228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      9788 KB
Buffers:     56700 KB
Cached:     232708 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11872 KB
VmRSS:       11872 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20704 TID = 20704
20704 20720 

Maps Information
f459b000 f4d9a000 rw-p [stack:20720]
f4da1000 f4da3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4dab000 f4daf000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4db8000 f4dba000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4dc2000 f4dc5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4dd4000 f4dd9000 r-xp /usr/lib/libsystem.so.0.0.0
f4de4000 f4de7000 r-xp /lib/libattr.so.1.1.0
f4def000 f4dff000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e07000 f4e10000 r-xp /usr/lib/libedbus.so.1.7.99
f4e18000 f4e19000 r-xp /usr/lib/libresponse.so.0.2.96
f4e22000 f4e27000 r-xp /usr/lib/libproc-stat.so.0.2.96
f66c9000 f67cf000 r-xp /usr/lib/libicuuc.so.57.1
f67e5000 f696d000 r-xp /usr/lib/libicui18n.so.57.1
f697d000 f698a000 r-xp /usr/lib/libail.so.0.1.0
f6993000 f699a000 r-xp /usr/lib/libminizip.so.1.0.0
f69a3000 f6b4c000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b6c000 f6bb3000 r-xp /usr/lib/libssl.so.1.0.0
f6bbf000 f6bc1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6bc9000 f6bd0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6bd9000 f6be0000 r-xp /lib/libcrypt-2.13.so
f6c11000 f6c14000 r-xp /lib/libcap.so.2.21
f6c1c000 f6c1e000 r-xp /usr/lib/libiri.so
f6c26000 f6c6f000 r-xp /usr/lib/libmdm.so.1.2.69
f6c77000 f6c7d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c85000 f6ca8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6cb2000 f6cb4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6cbc000 f6cd9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6ce2000 f6ce6000 r-xp /usr/lib/libsmack.so.1.0.0
f6cef000 f6d08000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d11000 f6d19000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d21000 f6d27000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d30000 f6d32000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d3b000 f6d4b000 r-xp /lib/libresolv-2.13.so
f6d4f000 f6d67000 r-xp /usr/lib/liblzma.so.5.0.3
f6d70000 f6d72000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d7a000 f6d94000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d9c000 f6dcb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6dd4000 f6de3000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6ded000 f6df7000 r-xp /usr/lib/libsensord-shared.so
f6e00000 f6ed3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ede000 f6ef4000 r-xp /lib/libz.so.1.2.5
f6efc000 f6f01000 r-xp /usr/lib/libffi.so.5.0.10
f6f09000 f6f0a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f12000 f6f22000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f2a000 f6f43000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f4b000 f6f4d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f55000 f6fca000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6fd4000 f6fda000 r-xp /lib/librt-2.13.so
f6fe3000 f7001000 r-xp /usr/lib/libsystemd.so.0.4.0
f700b000 f700c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7014000 f7037000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f703f000 f7044000 r-xp /usr/lib/libxdgmime.so.1.1.0
f704c000 f7076000 r-xp /usr/lib/libdbus-1.so.3.8.12
f707f000 f7096000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f709e000 f7107000 r-xp /lib/libm-2.13.so
f7110000 f71a4000 r-xp /usr/lib/libstdc++.so.6.0.16
f71b7000 f71bc000 r-xp /usr/lib/libctx-client.so.0.8.3
f71c4000 f71cb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f71d3000 f71fd000 r-xp /usr/lib/libsensor.so.1.9.6
f7206000 f72d2000 r-xp /usr/lib/libxml2.so.2.7.8
f72df000 f72e1000 r-xp /usr/lib/libiniparser.so.0
f72ea000 f72f0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f72f9000 f73c9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f73ca000 f73fe000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7407000 f7443000 r-xp /usr/lib/libSLP-location.so.0.9.24
f744b000 f744e000 r-xp /usr/lib/libbundle.so.0.1.22
f7456000 f745c000 r-xp /usr/lib/libappsvc.so.0.1.0
f7464000 f74a5000 r-xp /usr/lib/libeina.so.1.7.99
f74ae000 f74c5000 r-xp /usr/lib/libecore.so.1.7.99
f74dc000 f74e5000 r-xp /usr/lib/libvconf.so.0.2.45
f74ed000 f7501000 r-xp /lib/libpthread-2.13.so
f750c000 f7519000 r-xp /usr/lib/libaul.so.0.1.0
f7523000 f7525000 r-xp /lib/libdl-2.13.so
f752e000 f7539000 r-xp /lib/libunwind.so.8.0.1
f7566000 f756e000 r-xp /lib/libgcc_s-4.6.so.1
f756f000 f7693000 r-xp /lib/libc-2.13.so
f76a1000 f76a3000 r-xp /usr/lib/libdlog.so.0.0.0
f76ab000 f76b7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f76c0000 f76c5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f76cd000 f76dc000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f76e4000 f76e8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f76f1000 f76f4000 r-xp /usr/lib/libappcore-agent.so.1.1
f76fc000 f76fe000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7706000 f770a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7712000 f772f000 r-xp /lib/ld-2.13.so
f7738000 f773b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f773b000 f773f000 r-xp /usr/lib/libsys-assert.so
f7c1c000 f7c8d000 rw-p [heap]
ff812000 ff833000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20704)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7739228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf76d0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73d73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf73d5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf73e1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf73e7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf73e7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf741c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf74171f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf73d5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf73e1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf73e7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf73e7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7419e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf741a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7421f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4db91fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4dac171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e7f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf732cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf732e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf74beca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf74b9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74ba5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf74ba879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf76f2183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76f27fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf77394f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf758685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7738f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
,1.574477
04-23 19:44:08.909+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:08.909+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:08:899,9.574963,1.527016,1.469251
04-23 19:44:08.909+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:08.919+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:08:921,0.037006,0.667203,0.009514
04-23 19:44:08.919+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:08:916,9.607183,1.722832,1.576870
04-23 19:44:08.919+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:08.919+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:08:926,9.504292,1.483550,1.414158
04-23 19:44:08.919+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:08.929+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:08:931,9.635897,1.562513,0.969093
04-23 19:44:08.929+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:08.929+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:08:936,-0.096391,0.140669,0.085892
04-23 19:44:08.929+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:08.939+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:08:940,9.609575,2.258825,1.129412
04-23 19:44:08.939+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:08.939+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:08:945,9.611969,2.194218,1.478764
04-23 19:44:08.939+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:08.939+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:08:948,9.473185,1.694118,1.562513
04-23 19:44:08.949+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:08.949+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:08.949+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:08:956,0.080503,-0.074312,0.293837
04-23 19:44:08.949+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:08:953,9.569575,1.553449,1.476621
04-23 19:44:08.949+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:08.959+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:08.959+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:08:895,19.530001,7.070000,-0.420000
04-23 19:44:08.959+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:08.959+0200 E/CAPI_TELEPHONY(18958): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 19:44:08.959+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:08:965,16.660000,7.910000,-3.360000
04-23 19:44:08.959+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:08.959+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:08:963,9.647861,1.481157,1.782653
04-23 19:44:08.969+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:08:970,12.950000,5.810000,-2.030000
04-23 19:44:08.969+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:08.969+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:08.969+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:08:975,18.620001,4.760000,-0.420000
04-23 19:44:08.969+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:08.969+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:08:976,0.040072,-0.453103,0.093911
04-23 19:44:08.969+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:08.969+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:08:979,16.660000,4.200000,-0.280000
04-23 19:44:08.979+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:08.979+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:08:963,9.567357,1.555469,1.488815
04-23 19:44:08.979+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:08.979+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:08:983,14.980000,3.150000,1.260000
04-23 19:44:08.979+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:08.979+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:08:984,9.567111,1.541837,1.504494
04-23 19:44:08.979+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:08.979+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:08:987,14.350000,3.780000,1.190000
04-23 19:44:08.979+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:08.989+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:08:981,9.607183,1.088734,1.598405
04-23 19:44:08.989+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:08:988,9.571068,1.512194,1.509410
04-23 19:44:08.989+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:08:991,8.120000,5.670000,4.270000
04-23 19:44:08.989+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:08.989+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:08.989+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:08:996,-1.820000,4.340000,3.920000
04-23 19:44:08.989+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:08.999+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:08.999+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:3,-9.450000,3.850000,2.450000
04-23 19:44:08.999+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:08.999+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:2,9.595219,1.246661,1.586441
04-23 19:44:08.999+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:08:998,0.024151,-0.265534,0.077031
04-23 19:44:09.009+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.009+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:13,9.571388,1.502842,1.516701
04-23 19:44:09.009+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:14,-10.360000,2.100000,2.730000
04-23 19:44:09.009+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.009+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.009+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:19,1.330000,2.240000,3.430000
04-23 19:44:09.019+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.019+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.019+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:20,-0.143667,0.353988,0.191774
04-23 19:44:09.019+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:23,7.910000,3.570000,0.840000
04-23 19:44:09.019+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.019+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:23,9.427721,1.856830,1.708475
04-23 19:44:09.019+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.019+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:28,2.660000,3.430000,-0.840000
04-23 19:44:09.029+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:30,9.564941,1.527025,1.533124
04-23 19:44:09.029+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.029+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.029+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:36,-0.089364,0.459018,0.031782
04-23 19:44:09.029+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:36,9.475577,1.986043,1.564906
04-23 19:44:09.029+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.029+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.039+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:41,9.560604,1.545030,1.542113
04-23 19:44:09.039+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:42,-6.160000,3.430000,2.520000
04-23 19:44:09.049+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.049+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:57,0.092043,-0.121301,-0.137527
04-23 19:44:09.049+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.059+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.069+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.069+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:71,9.652647,1.423729,1.404587
04-23 19:44:09.069+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.079+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:77,-12.390000,-1.190000,2.240000
04-23 19:44:09.079+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:82,9.650253,1.083949,1.368695
04-23 19:44:09.079+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:44:09.079+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:44:09.079+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:44:09.079+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.089+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.089+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:99,9.571291,1.586441,1.450050
04-23 19:44:09.099+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:93,1.330000,1.470000,2.870000
04-23 19:44:09.099+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.099+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:106,10.080000,5.530000,2.590000
04-23 19:44:09.109+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.109+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:113,0.085422,-0.442942,-0.165246
04-23 19:44:09.109+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:62,9.564832,1.526891,1.533941
04-23 19:44:09.109+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.119+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:121,9.511470,1.725225,1.572084
04-23 19:44:09.119+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.119+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:125,5.390000,5.810000,2.450000
04-23 19:44:09.119+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.129+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.129+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.129+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:136,9.511470,1.737189,1.263410
04-23 19:44:09.139+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.139+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:144,1.260000,5.180000,3.220000
04-23 19:44:09.139+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:129,0.000875,0.087403,-0.076511
04-23 19:44:09.139+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.139+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:148,-0.057100,0.217228,0.042774
04-23 19:44:09.139+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:134,9.570416,1.499038,1.526561
04-23 19:44:09.149+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.149+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.149+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:156,9.717253,1.557728,1.237089
04-23 19:44:09.159+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.159+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.159+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:164,5.460000,4.620000,0.840000
04-23 19:44:09.159+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:168,-0.053185,0.215132,-0.276427
04-23 19:44:09.169+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:154,9.568570,1.507997,1.529310
04-23 19:44:09.169+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.169+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.179+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.179+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.179+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:176,9.750752,1.598405,1.067199
04-23 19:44:09.189+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:179,9.564655,1.522057,1.539837
04-23 19:44:09.189+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:185,8.400000,6.650000,0.350000
04-23 19:44:09.189+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.189+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.189+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.199+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:187,0.153664,0.024447,-0.298230
04-23 19:44:09.199+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:202,6.090000,8.750000,2.240000
04-23 19:44:09.199+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.199+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:197,9.563589,1.533281,1.535319
04-23 19:44:09.199+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:200,9.657433,1.880759,1.380659
04-23 19:44:09.199+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:206,0.187109,0.058237,-0.460869
04-23 19:44:09.199+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.199+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.209+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:210,0.094357,0.326220,-0.136366
04-23 19:44:09.209+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:211,9.563643,1.540168,1.528068
04-23 19:44:09.209+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.209+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.209+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.209+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.219+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:220,-0.210000,8.470000,3.990000
04-23 19:44:09.219+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:221,9.604790,1.710868,1.694118
04-23 19:44:09.219+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:216,9.563076,1.554539,1.517025
04-23 19:44:09.219+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.219+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:220,0.046771,0.133289,0.169025
04-23 19:44:09.219+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:226,9.558019,1.577580,1.525094
04-23 19:44:09.219+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.229+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:230,9.553597,1.584187,1.545802
04-23 19:44:09.229+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.229+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.229+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:237,9.547362,1.564906,1.801795
04-23 19:44:09.229+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:237,-0.006235,-0.019281,0.255993
04-23 19:44:09.229+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.229+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.239+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:241,5.110000,7.420000,2.240000
04-23 19:44:09.249+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.249+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.249+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:259,10.570000,5.880000,2.030000
04-23 19:44:09.259+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:255,9.509077,1.569692,1.631905
04-23 19:44:09.259+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.259+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:265,-0.040188,-0.018587,0.063688
04-23 19:44:09.259+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:242,9.549265,1.588278,1.568217
04-23 19:44:09.259+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.269+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:270,9.546657,1.593993,1.578265
04-23 19:44:09.269+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.269+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:276,9.592826,1.395016,1.672583
04-23 19:44:09.269+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.279+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:280,8.330000,4.340000,1.330000
04-23 19:44:09.279+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.279+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:284,0.046169,-0.198977,0.094318
04-23 19:44:09.279+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.279+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:288,9.546139,1.588350,1.587059
04-23 19:44:09.289+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.289+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:298,9.564112,1.395016,1.677369
04-23 19:44:09.289+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.299+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:301,8.120000,4.410000,1.890000
04-23 19:44:09.299+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.299+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:306,0.017973,-0.193334,0.090310
04-23 19:44:09.299+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.309+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:310,9.545778,1.581989,1.595558
04-23 19:44:09.309+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.319+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.319+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.319+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:323,1.890000,5.110000,2.520000
04-23 19:44:09.319+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:325,0.090118,0.095380,0.285200
04-23 19:44:09.319+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.319+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:321,9.635897,1.677369,1.880759
04-23 19:44:09.319+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:328,9.541965,1.586115,1.614160
04-23 19:44:09.329+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.329+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.329+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.329+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:336,-0.083138,-0.155207,0.120636
04-23 19:44:09.329+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.339+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:340,9.542742,1.571677,1.623667
04-23 19:44:09.339+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:337,9.458827,1.430908,1.734797
04-23 19:44:09.339+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:339,-3.570000,3.290000,3.990000
04-23 19:44:09.349+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.349+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.349+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:356,9.544388,1.563337,1.622042
04-23 19:44:09.349+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.349+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:357,0.045299,-0.092912,-0.085082
04-23 19:44:09.349+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.359+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:360,1.330000,3.010000,3.290000
04-23 19:44:09.359+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:362,9.588040,1.478764,1.538585
04-23 19:44:09.369+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.369+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.369+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:376,9.547976,1.553953,1.609895
04-23 19:44:09.369+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.369+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:377,0.113045,-0.204214,-0.384953
04-23 19:44:09.379+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.379+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:382,0.980000,4.060000,2.170000
04-23 19:44:09.379+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:383,9.657433,1.359123,1.237089
04-23 19:44:09.389+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.389+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.389+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:396,9.552121,1.539986,1.598688
04-23 19:44:09.389+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:397,0.087920,-0.259436,-0.456555
04-23 19:44:09.389+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.389+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.399+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:401,-5.530000,5.390000,2.730000
04-23 19:44:09.399+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:402,9.635897,1.294517,1.153341
04-23 19:44:09.409+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.409+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.419+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.419+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:421,0.181882,0.072777,-0.036175
04-23 19:44:09.419+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.419+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:421,9.551372,1.533504,1.609363
04-23 19:44:09.429+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.429+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.439+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:437,-0.030330,0.562608,0.283359
04-23 19:44:09.439+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:427,-15.050000,6.580000,4.340000
04-23 19:44:09.439+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:429,9.734003,1.612763,1.562513
04-23 19:44:09.439+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.439+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:437,9.544441,1.545946,1.638316
04-23 19:44:09.439+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.449+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:447,9.521042,2.096112,1.892723
04-23 19:44:09.449+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.449+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.459+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:450,-18.549999,8.190000,6.790000
04-23 19:44:09.459+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:457,-0.123899,0.085959,0.240050
04-23 19:44:09.459+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.459+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.469+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:460,9.542683,1.531916,1.661573
04-23 19:44:09.469+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.469+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.479+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:477,0.028608,-0.536501,-0.015311
04-23 19:44:09.479+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:480,9.549775,1.479949,1.667910
04-23 19:44:09.479+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:471,9.420543,1.631905,1.878366
04-23 19:44:09.479+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.479+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:476,-22.049999,6.370000,7.560000
04-23 19:44:09.479+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.489+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.489+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.499+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:496,0.141156,0.439095,0.033387
04-23 19:44:09.499+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:492,-31.150000,1.540000,5.670000
04-23 19:44:09.499+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:490,9.571291,0.995414,1.646262
04-23 19:44:09.499+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.499+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.499+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:497,9.548533,1.473123,1.681012
04-23 19:44:09.499+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:507,9.690931,1.919044,1.701297
04-23 19:44:09.509+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:508,-34.930000,4.760000,7.980000
04-23 19:44:09.509+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.509+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.519+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:521,9.546329,1.462229,1.702896
04-23 19:44:09.519+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:521,-0.003564,0.618204,-0.051500
04-23 19:44:09.519+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.519+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.529+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:528,9.544970,2.091327,1.629512
04-23 19:44:09.529+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:528,-65.730003,5.740000,9.100000
04-23 19:44:09.529+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.529+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.529+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.539+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:538,-0.054002,0.444851,0.347752
04-23 19:44:09.539+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:538,9.547052,1.414758,1.738575
04-23 19:44:09.539+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.539+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:537,-104.370003,0.700000,14.070000
04-23 19:44:09.539+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:545,9.492328,1.907080,2.050649
04-23 19:44:09.549+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.549+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.549+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:556,-0.085832,-0.215954,0.441287
04-23 19:44:09.549+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:556,9.552963,1.328983,1.773437
04-23 19:44:09.559+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.559+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.559+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:563,-120.190002,-3.780000,14.490000
04-23 19:44:09.569+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:564,9.461221,1.198804,2.179861
04-23 19:44:09.569+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.569+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.579+0200 W/LOCATION(20704): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:44:09.579+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:580,0.097290,0.089961,0.516494
04-23 19:44:09.579+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.579+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:576,9.552103,1.259023,1.828271
04-23 19:44:09.589+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.589+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.589+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.589+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:591,-127.190002,4.130000,16.450001
04-23 19:44:09.599+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:596,0.090972,0.480559,0.595659
04-23 19:44:09.599+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.599+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:604,9.544457,1.200997,1.905605
04-23 19:44:09.599+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:607,-152.250000,6.510000,16.660000
04-23 19:44:09.609+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.609+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.619+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:621,-0.076058,-0.231904,0.312541
04-23 19:44:09.619+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.619+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:626,-185.779999,-1.960000,18.620001
04-23 19:44:09.619+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:600,9.650253,1.418944,2.289931
04-23 19:44:09.619+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.629+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.629+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:621,9.543861,1.094569,1.971552
04-23 19:44:09.629+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.629+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:636,-0.051534,-1.628169,0.007312
04-23 19:44:09.629+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:637,9.547122,0.923739,2.041950
04-23 19:44:09.629+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.639+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:632,9.643075,1.739582,2.423929
04-23 19:44:09.639+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:642,-192.990005,-8.050000,16.450001
04-23 19:44:09.639+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.649+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.649+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.649+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.649+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:656,0.170131,-1.629622,0.190554
04-23 19:44:09.649+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:656,9.541368,0.779960,2.127052
04-23 19:44:09.659+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:650,9.468399,0.969093,2.218147
04-23 19:44:09.659+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:661,-153.860001,-6.440000,12.880000
04-23 19:44:09.659+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.669+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:669,9.492328,-0.533599,1.978864
04-23 19:44:09.669+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.669+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.669+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:676,9.526837,0.678556,2.224707
04-23 19:44:09.669+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.679+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:676,0.111279,-1.158026,0.201164
04-23 19:44:09.679+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:680,-111.790001,-0.840000,9.730000
04-23 19:44:09.679+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.679+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:688,9.717253,-0.705883,2.232504
04-23 19:44:09.689+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.689+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.689+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.689+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:696,9.504669,0.613407,2.335677
04-23 19:44:09.689+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.699+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:696,-0.022546,-0.649842,0.354756
04-23 19:44:09.699+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:700,-88.970001,-0.630000,6.510000
04-23 19:44:09.699+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:695,9.652647,-0.378066,2.328217
04-23 19:44:09.699+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.709+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:710,9.504292,0.028714,2.579463
04-23 19:44:09.709+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.709+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.709+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.719+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:721,9.467525,0.578883,2.490229
04-23 19:44:09.719+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:723,-97.580002,1.960000,3.290000
04-23 19:44:09.719+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:721,0.162334,-0.043916,0.160037
04-23 19:44:09.719+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.729+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:730,9.667004,0.569492,2.495714
04-23 19:44:09.729+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.729+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.729+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.729+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:737,9.394468,0.513012,2.766073
04-23 19:44:09.739+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.739+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:739,0.003266,-0.504706,-0.664505
04-23 19:44:09.739+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:737,-127.470001,-0.490000,3.150000
04-23 19:44:09.739+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:743,9.470792,0.074178,1.825724
04-23 19:44:09.749+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.749+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.749+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.749+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:756,9.128220,0.400209,3.561717
04-23 19:44:09.749+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.759+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:757,-146.649994,-7.000000,3.710000
04-23 19:44:09.759+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:761,9.439686,-0.516850,1.497907
04-23 19:44:09.759+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:759,0.045218,-1.029861,-1.268166
04-23 19:44:09.769+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.769+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.769+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.769+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.779+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:777,9.362867,0.244402,-2.906435
04-23 19:44:09.779+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:776,9.827322,-0.746561,1.617548
04-23 19:44:09.779+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:776,-138.460007,-7.560000,5.950000
04-23 19:44:09.779+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:778,0.699102,-1.146770,-1.944169
04-23 19:44:09.789+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.789+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.789+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.789+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.799+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:797,9.764104,0.244908,-0.879021
04-23 19:44:09.799+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:797,9.879964,-0.636491,1.787439
04-23 19:44:09.799+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:797,-116.059998,0.630000,4.200000
04-23 19:44:09.799+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:801,0.517097,-0.880893,4.693873
04-23 19:44:09.809+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.809+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.809+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.819+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.819+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:822,9.804589,0.193391,0.054844
04-23 19:44:09.819+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:821,9.662218,-0.418744,1.710868
04-23 19:44:09.819+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:823,-0.101886,-0.663652,2.589889
04-23 19:44:09.819+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:821,-105.279999,4.760000,3.010000
04-23 19:44:09.829+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.829+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.829+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.859+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.859+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:840,-112.279999,4.900000,4.200000
04-23 19:44:09.869+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:842,-0.211763,-0.322603,1.600989
04-23 19:44:09.869+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.869+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.869+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:837,9.795148,0.145905,0.451848
04-23 19:44:09.869+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.869+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:878,9.778678,0.082831,0.735513
04-23 19:44:09.869+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.879+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:870,9.592826,-0.129212,1.655833
04-23 19:44:09.879+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:875,-126.419998,1.890000,8.750000
04-23 19:44:09.879+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.879+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.879+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:878,-0.300427,-0.351688,1.065202
04-23 19:44:09.879+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.879+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:884,9.494720,-0.205783,1.517050
04-23 19:44:09.879+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.879+0200 I/accelerometer(20675): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:09:888,9.585647,-0.830309,1.634298
04-23 19:44:09.879+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:888,-0.193031,-0.913140,0.898785
04-23 19:44:09.889+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:886,-131.669998,-2.730000,11.970000
04-23 19:44:09.889+0200 I/gyroscope(20691): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:09.889+0200 I/gravity (20721): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:09:881,9.757298,-0.015651,0.982484
04-23 19:44:09.889+0200 I/gravity (20721): capturing data from es.ugr.frailty.gravity
04-23 19:44:09.889+0200 I/linearacceleration(20707): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:09.899+0200 I/linearacceleration(20707): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:09:899,-0.095079,-1.563612,0.960487
04-23 19:44:09.899+0200 I/gyroscope(20691): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:09:897,-115.779999,-0.350000,12.740000
04-23 19:44:09.899+0200 I/accelerometer(20675): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:09.899+0200 W/CRASH_MANAGER(20380): worker.c: worker_job(1205) > 11207046c6f63152450544
