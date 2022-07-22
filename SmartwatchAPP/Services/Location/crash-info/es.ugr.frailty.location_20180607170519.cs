S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 15626
Date: 2018-06-07 17:05:19+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf773a52d, r5   = 0xf7e3ff98
r6   = 0xffa6d380, r7   = 0xffa6d230
r8   = 0xf7e3cc18, r9   = 0x00000000
r10  = 0xffa6d30c, fp   = 0xffa6d380
ip   = 0x00000001, sp   = 0xffa6d208
lr   = 0xf773a539, pc   = 0xf77a3228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     93252 KB
Buffers:     13720 KB
Cached:      67952 KB
VmPeak:      53460 KB
VmSize:      53396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11908 KB
VmRSS:       11908 KB
VmData:      11124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 15626 TID = 15626
15626 15630 

Maps Information
f4605000 f4e04000 rw-p [stack:15630]
f4e0b000 f4e0d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4e15000 f4e19000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4e22000 f4e24000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4e2c000 f4e2f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4e3e000 f4e43000 r-xp /usr/lib/libsystem.so.0.0.0
f4e4e000 f4e51000 r-xp /lib/libattr.so.1.1.0
f4e59000 f4e69000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e71000 f4e7a000 r-xp /usr/lib/libedbus.so.1.7.99
f4e82000 f4e83000 r-xp /usr/lib/libresponse.so.0.2.96
f4e8c000 f4e91000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6733000 f6839000 r-xp /usr/lib/libicuuc.so.57.1
f684f000 f69d7000 r-xp /usr/lib/libicui18n.so.57.1
f69e7000 f69f4000 r-xp /usr/lib/libail.so.0.1.0
f69fd000 f6a04000 r-xp /usr/lib/libminizip.so.1.0.0
f6a0d000 f6bb6000 r-xp /usr/lib/libcrypto.so.1.0.0
f6bd6000 f6c1d000 r-xp /usr/lib/libssl.so.1.0.0
f6c29000 f6c2b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6c33000 f6c3a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6c43000 f6c4a000 r-xp /lib/libcrypt-2.13.so
f6c7b000 f6c7e000 r-xp /lib/libcap.so.2.21
f6c86000 f6c88000 r-xp /usr/lib/libiri.so
f6c90000 f6cd9000 r-xp /usr/lib/libmdm.so.1.2.69
f6ce1000 f6ce7000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6cef000 f6d12000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6d1c000 f6d1e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6d26000 f6d43000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d4c000 f6d50000 r-xp /usr/lib/libsmack.so.1.0.0
f6d59000 f6d72000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d7b000 f6d83000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d8b000 f6d91000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d9a000 f6d9c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6da5000 f6db5000 r-xp /lib/libresolv-2.13.so
f6db9000 f6dd1000 r-xp /usr/lib/liblzma.so.5.0.3
f6dda000 f6ddc000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6de4000 f6dfe000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6e06000 f6e35000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e3e000 f6e4d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e57000 f6e61000 r-xp /usr/lib/libsensord-shared.so
f6e6a000 f6f3d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f48000 f6f5e000 r-xp /lib/libz.so.1.2.5
f6f66000 f6f6b000 r-xp /usr/lib/libffi.so.5.0.10
f6f73000 f6f74000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f7c000 f6f8c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f94000 f6fad000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6fb5000 f6fb7000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6fbf000 f7034000 r-xp /usr/lib/libsqlite3.so.0.8.6
f703e000 f7044000 r-xp /lib/librt-2.13.so
f704d000 f706b000 r-xp /usr/lib/libsystemd.so.0.4.0
f7075000 f7076000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f707e000 f70a1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f70a9000 f70ae000 r-xp /usr/lib/libxdgmime.so.1.1.0
f70b6000 f70e0000 r-xp /usr/lib/libdbus-1.so.3.8.12
f70e9000 f7100000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7108000 f7171000 r-xp /lib/libm-2.13.so
f717a000 f720e000 r-xp /usr/lib/libstdc++.so.6.0.16
f7221000 f7226000 r-xp /usr/lib/libctx-client.so.0.8.3
f722e000 f7235000 r-xp /usr/lib/libctx-shared.so.0.8.3
f723d000 f7267000 r-xp /usr/lib/libsensor.so.1.9.6
f7270000 f733c000 r-xp /usr/lib/libxml2.so.2.7.8
f7349000 f734b000 r-xp /usr/lib/libiniparser.so.0
f7354000 f735a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7363000 f7433000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7434000 f7468000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7471000 f74ad000 r-xp /usr/lib/libSLP-location.so.0.9.24
f74b5000 f74b8000 r-xp /usr/lib/libbundle.so.0.1.22
f74c0000 f74c6000 r-xp /usr/lib/libappsvc.so.0.1.0
f74ce000 f750f000 r-xp /usr/lib/libeina.so.1.7.99
f7518000 f752f000 r-xp /usr/lib/libecore.so.1.7.99
f7546000 f754f000 r-xp /usr/lib/libvconf.so.0.2.45
f7557000 f756b000 r-xp /lib/libpthread-2.13.so
f7576000 f7583000 r-xp /usr/lib/libaul.so.0.1.0
f758d000 f758f000 r-xp /lib/libdl-2.13.so
f7598000 f75a3000 r-xp /lib/libunwind.so.8.0.1
f75d0000 f75d8000 r-xp /lib/libgcc_s-4.6.so.1
f75d9000 f76fd000 r-xp /lib/libc-2.13.so
f770b000 f770d000 r-xp /usr/lib/libdlog.so.0.0.0
f7715000 f7721000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f772a000 f772f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7737000 f7746000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f774e000 f7752000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f775b000 f775e000 r-xp /usr/lib/libappcore-agent.so.1.1
f7766000 f7768000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7770000 f7774000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f777c000 f7799000 r-xp /lib/ld-2.13.so
f77a2000 f77a5000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f77a5000 f77a9000 r-xp /usr/lib/libsys-assert.so
f7e0c000 f7e6e000 rw-p [heap]
ffa4e000 ffa6f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15626)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf77a3228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf773a539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf74413f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf743fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf744be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7451be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7451dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf748675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf74811f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf743fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf744be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7451be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7451dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7483e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7484017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf748bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4e231fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4e16171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ee9663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7396fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73987a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7528ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7523b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf75245a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7524879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf775c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf775c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf77a35c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf75f085c) [/lib/libc.so.6] + 0x1785c
29: (0xf77a2f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
cceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:18.381+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:18:389,0.099329,-0.035719,0.053140
06-07 17:05:18.381+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:18:385,0.490000,-0.070000,0.140000
06-07 17:05:18.391+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:18:382,1.674400,-1.098111,9.600048
06-07 17:05:18.391+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:388,1.782653,-1.086342,9.631111
06-07 17:05:18.391+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:18.391+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:18.391+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:18.391+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:18.401+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:18:408,0.117727,-0.077098,0.080465
06-07 17:05:18.401+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:400,1.744368,-1.079163,9.616754
06-07 17:05:18.401+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:18:402,-0.420000,-0.070000,0.140000
06-07 17:05:18.401+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:18:405,1.671340,-1.097983,9.600595
06-07 17:05:18.411+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:05:18.411+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:18.411+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:18.411+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:18.411+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:18:420,-0.070000,0.420000,-0.070000
06-07 17:05:18.421+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:05:18:417,543.000000
06-07 17:05:18.421+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:18.421+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:18:425,0.062253,0.024979,0.096192
06-07 17:05:18.421+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:427,1.770689,-1.064806,9.688539
06-07 17:05:18.421+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:18.421+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:18:423,1.669269,-1.095809,9.601205
06-07 17:05:18.421+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:18.431+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:18.431+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:18:437,0.056105,0.036088,0.030992
06-07 17:05:18.441+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:18.441+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:18:435,0.210000,0.490000,-0.140000
06-07 17:05:18.441+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:18:442,1.669765,-1.093665,9.601362
06-07 17:05:18.441+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:446,1.761117,-1.007378,9.640682
06-07 17:05:18.441+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:18.441+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:18.441+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:18.451+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:18.451+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:459,1.694118,-0.966700,9.631111
06-07 17:05:18.451+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:18:455,0.490000,0.490000,-0.350000
06-07 17:05:18.461+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:18:453,-0.093699,-0.019083,0.039808
06-07 17:05:18.461+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:18.461+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:18.461+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:18:457,1.671965,-1.091461,9.601231
06-07 17:05:18.461+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:18.461+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:18:470,0.980000,-0.070000,-0.350000
06-07 17:05:18.471+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:05:18.471+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:05:18:476,81
06-07 17:05:18.471+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:18:474,-0.118753,0.031664,0.072571
06-07 17:05:18.471+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:18.481+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:18:475,1.675116,-1.094579,9.600327
06-07 17:05:18.481+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:18.481+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:18.481+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:486,1.741975,-1.074377,9.681360
06-07 17:05:18.481+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:18.481+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:18:490,-0.056475,0.088450,0.203761
06-07 17:05:18.491+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:18:487,0.980000,-0.210000,-0.350000
06-07 17:05:18.491+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:18.491+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:18.491+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:18:493,1.675554,-1.095285,9.600169
06-07 17:05:18.491+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:18.491+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:500,1.749153,-1.048056,9.678967
06-07 17:05:18.491+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:18.501+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:18:505,-0.700000,-0.140000,0.140000
06-07 17:05:18.501+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:18:509,-0.040157,-0.014794,0.164218
06-07 17:05:18.511+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:18.511+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:18.511+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:18:513,1.676192,-1.092070,9.600425
06-07 17:05:18.511+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:18.511+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:18:522,0.007658,-0.156308,-0.001614
06-07 17:05:18.521+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:18.521+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:525,1.737189,-1.057628,9.662218
06-07 17:05:18.521+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:18:529,1.676981,-1.087692,9.600783
06-07 17:05:18.521+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:18:525,0.070000,-0.140000,-0.070000
06-07 17:05:18.521+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:18.531+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:18.531+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:18.531+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:18.581+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:18:591,0.490000,0.140000,-0.070000
06-07 17:05:18.591+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:18:536,0.051923,-0.197371,0.084538
06-07 17:05:18.611+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:05:18.611+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:540,1.811367,-1.033699,9.652647
06-07 17:05:18.611+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:05:18:618,543.000000
06-07 17:05:18.621+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:18.661+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:05:18.661+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:05:18:666,81
06-07 17:05:18.661+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:18:670,0.084325,-0.170145,0.036091
06-07 17:05:18.661+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:18:595,1.680043,-1.085848,9.600457
06-07 17:05:18.661+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:18.661+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:18.671+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:18.671+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:675,1.782653,-1.060020,9.686146
06-07 17:05:18.671+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:18.681+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:18.681+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:18:676,0.350000,0.070000,-0.210000
06-07 17:05:18.681+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:18.681+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:18:688,0.118399,-0.014311,0.101871
06-07 17:05:18.681+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:18:679,1.681416,-1.086975,9.600089
06-07 17:05:18.691+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:18.691+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:680,1.753939,-1.067199,9.671788
06-07 17:05:18.691+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:18.701+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:18:699,1.684183,-1.092615,9.598964
06-07 17:05:18.701+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:18.701+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:18:695,-0.210000,0.490000,0.070000
06-07 17:05:18.701+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:18.711+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:702,1.741975,-0.957129,9.707682
06-07 17:05:18.711+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:18.711+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:18:720,-0.910000,0.280000,0.070000
06-07 17:05:18.721+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:18.721+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:719,1.732404,-0.969093,9.657433
06-07 17:05:18.721+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:18:713,0.007427,0.086918,0.087328
06-07 17:05:18.731+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:18.731+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:18.731+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:18.731+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:18:729,1.684113,-1.094332,9.598781
06-07 17:05:18.741+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:18:743,-0.062529,0.136150,0.086772
06-07 17:05:18.741+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:737,1.713261,-1.012164,9.631111
06-07 17:05:18.741+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:18.751+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:18.751+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:18.751+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:756,1.749153,-1.067199,9.695717
06-07 17:05:18.761+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:18:747,-0.420000,0.280000,0.210000
06-07 17:05:18.761+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:18.761+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:18.761+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:18:756,1.683919,-1.091889,9.599092
06-07 17:05:18.761+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:18:767,-0.084863,0.028689,0.088094
06-07 17:05:18.771+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:18:770,0.140000,0.280000,0.280000
06-07 17:05:18.771+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:18.771+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:768,1.718047,-1.124627,9.667004
06-07 17:05:18.781+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:18:781,1.683568,-1.089190,9.599461
06-07 17:05:18.781+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:18.781+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:18.781+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:18:791,-0.038630,-0.042940,0.038883
06-07 17:05:18.781+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:18.791+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:795,1.725225,-1.083949,9.683753
06-07 17:05:18.791+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:18.791+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:18.801+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:18.801+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:18:796,0.140000,0.280000,0.280000
06-07 17:05:18.811+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:802,1.777867,-0.993021,9.681360
06-07 17:05:18.811+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:05:18.811+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:18.811+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:18:806,1.681404,-1.090499,9.599691
06-07 17:05:18.821+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:05:18:817,542.000000
06-07 17:05:18.821+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:18.821+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:18.831+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:18:816,0.031086,-0.098282,0.049630
06-07 17:05:18.831+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:18.831+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:18:824,-0.420000,-0.140000,0.280000
06-07 17:05:18.831+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:18:841,0.092810,-0.120878,0.114045
06-07 17:05:18.841+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:18.841+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:829,1.739582,-0.995414,9.659825
06-07 17:05:18.841+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:18:834,1.679157,-1.087095,9.600471
06-07 17:05:18.841+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:18.841+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:849,1.751546,-0.969093,9.664611
06-07 17:05:18.841+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:18.841+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:18.851+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:18.861+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:05:18.871+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:05:18:867,81
06-07 17:05:18.871+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:854,1.722832,-1.007378,9.686146
06-07 17:05:18.871+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:18.891+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:18:889,0.115244,-0.117833,0.006974
06-07 17:05:18.891+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:18:849,-0.560000,0.140000,0.350000
06-07 17:05:18.901+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:18.901+0200 W/LOCATION(15626): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:05:18.901+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:18:906,0.140000,0.280000,0.210000
06-07 17:05:18.901+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:18:857,1.679562,-1.086500,9.600468
06-07 17:05:18.901+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:18.911+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:18.911+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:896,1.751546,-1.024128,9.698111
06-07 17:05:18.911+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:18.911+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:18.921+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:18:919,0.055080,-0.007255,0.014271
06-07 17:05:18.921+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:18:913,1.678775,-1.088074,9.600427
06-07 17:05:18.921+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:18.921+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:18.921+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:18:923,-0.210000,0.280000,0.350000
06-07 17:05:18.931+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:18:932,1.683962,-1.088557,9.599463
06-07 17:05:18.931+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:18.931+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:923,1.746760,-1.055235,9.690931
06-07 17:05:18.941+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:18.941+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:18:935,0.014450,0.048844,0.072238
06-07 17:05:18.941+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:18.941+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:18:942,-1.190000,0.070000,0.490000
06-07 17:05:18.951+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:18.951+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:18.951+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:947,1.730011,-1.055235,9.619147
06-07 17:05:18.951+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:18.961+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:18:957,-0.048492,0.137262,0.067303
06-07 17:05:18.961+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:18:953,1.686687,-1.091680,9.598630
06-07 17:05:18.961+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:18.961+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:18.961+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:18:962,-1.610000,0.210000,0.420000
06-07 17:05:18.971+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:18.971+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:963,1.734797,-1.055235,9.643075
06-07 17:05:18.981+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:18:972,1.690514,-1.093740,9.597722
06-07 17:05:18.981+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:18.981+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:18:975,-0.050159,0.168973,0.061922
06-07 17:05:18.981+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:18.981+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:18:981,-0.280000,0.350000,-0.070000
06-07 17:05:18.991+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:18.991+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:18:995,-0.024827,0.032565,0.075494
06-07 17:05:18.991+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:18.991+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:18:991,1.691182,-1.095775,9.597373
06-07 17:05:19.001+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:19.001+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:19.001+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:19:2,0.560000,0.280000,-0.070000
06-07 17:05:19.011+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:05:19.011+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:18:997,1.761117,-1.009771,9.700503
06-07 17:05:19.011+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:19.011+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:05:19:18,541.000000
06-07 17:05:19.011+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:19.021+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:19:12,1.688929,-1.091990,9.598201
06-07 17:05:19.021+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:19:15,0.020563,0.018106,0.074967
06-07 17:05:19.021+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:19.031+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:19:21,1.734797,-1.016950,9.614362
06-07 17:05:19.031+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:19:27,0.280000,0.140000,-0.070000
06-07 17:05:19.031+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:19.031+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:19:41,0.040888,-0.039442,0.077136
06-07 17:05:19.041+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:19.041+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:19:37,1.688501,-1.087570,9.598778
06-07 17:05:19.041+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:19.051+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:19.051+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:19.051+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:19:50,-0.070000,-0.070000,-0.070000
06-07 17:05:19.061+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:19.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:05:19.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:05:19.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:05:19.061+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:05:19.061+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:19:57,1.686681,-1.083778,9.599527
06-07 17:05:19.071+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:19:59,0.044084,-0.093651,0.099047
06-07 17:05:19.071+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:05:19:71,81
06-07 17:05:19.071+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:19:68,-0.210000,-0.070000,0.070000
06-07 17:05:19.071+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:19.071+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:19.071+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:19:77,1.741975,-1.033699,9.671788
06-07 17:05:19.081+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:19:81,1.688065,-1.081345,9.599558
06-07 17:05:19.081+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:19.081+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:19:89,-0.070000,0.140000,0.070000
06-07 17:05:19.081+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:19:82,0.040035,-0.079148,0.092445
06-07 17:05:19.091+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:19.091+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:19.091+0200 W/CAPI_APPFW_APP_CONTROL(15595): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:05:19.091+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:05:19.091+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(15595), cmd(0)
06-07 17:05:19.091+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:19:100,1.689288,-1.084033,9.599040
06-07 17:05:19.101+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:19.101+0200 I/utils   (15595): specific action
06-07 17:05:19.101+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:19.101+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:19:98,1.761117,-1.031307,9.585647
06-07 17:05:19.101+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:19.101+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:19:107,0.006559,0.035117,0.071105
06-07 17:05:19.111+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:19:108,-0.210000,0.140000,0.140000
06-07 17:05:19.111+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:19.111+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:19.111+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:19.121+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:19:121,1.691922,-1.085455,9.598415
06-07 17:05:19.121+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:19:108,1.768296,-1.043271,9.686146
06-07 17:05:19.131+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:19:127,-0.210000,0.140000,0.140000
06-07 17:05:19.131+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:19.131+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:19:125,-0.061996,0.051558,0.049385
06-07 17:05:19.131+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:19.131+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:19.141+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:19.141+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:19:144,-0.007555,0.022796,0.046137
06-07 17:05:19.141+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:19:141,1.690684,-1.085361,9.598644
06-07 17:05:19.151+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:19.151+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:19:146,1.710868,-1.028914,9.707682
06-07 17:05:19.151+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:19:147,-0.070000,0.280000,-0.070000
06-07 17:05:19.151+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:19:160,1.688228,-1.081412,9.599522
06-07 17:05:19.151+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:19.161+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:19.161+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:19.161+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:19.171+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:19:166,0.022641,-0.015004,0.135900
06-07 17:05:19.171+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:19.171+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:19:173,1.706082,-1.040878,9.674182
06-07 17:05:19.171+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:19:167,-0.140000,0.280000,0.140000
06-07 17:05:19.181+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:19.181+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:19.181+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:19:180,0.043153,0.008370,0.073117
06-07 17:05:19.181+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:19:189,1.777867,-1.033699,9.664611
06-07 17:05:19.181+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:19.181+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:19:178,1.688052,-1.079621,9.599754
06-07 17:05:19.191+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:19.191+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:19.191+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:19:186,-0.560000,-0.140000,0.140000
06-07 17:05:19.191+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:19:200,1.687452,-1.079428,9.599881
06-07 17:05:19.201+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:19.201+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:19:199,0.046319,0.001958,0.048874
06-07 17:05:19.201+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:19.211+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:19:209,-0.420000,-0.140000,0.070000
06-07 17:05:19.211+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:05:19.211+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:05:19:219,539.000000
06-07 17:05:19.211+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:19.221+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:19.221+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:19:193,1.713261,-1.016950,9.690931
06-07 17:05:19.231+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:19.231+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:19:225,1.690674,-1.082353,9.598986
06-07 17:05:19.231+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:19.231+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:19:229,0.061871,-0.013911,0.065673
06-07 17:05:19.231+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:19:237,1.730011,-1.028914,9.710074
06-07 17:05:19.231+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:19:231,-0.350000,0.420000,0.210000
06-07 17:05:19.241+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:19.241+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:19.251+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:19.251+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:19:245,1.693807,-1.083229,9.598334
06-07 17:05:19.251+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:19:247,0.097762,0.026992,0.070911
06-07 17:05:19.251+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:19.251+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:19.251+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:19:252,-0.420000,0.420000,0.210000
06-07 17:05:19.261+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:19.261+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:05:19.261+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:05:19:269,82
06-07 17:05:19.271+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:19:272,-0.840000,0.420000,0.210000
06-07 17:05:19.271+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:19:257,1.744368,-1.057628,9.657433
06-07 17:05:19.271+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:19:265,0.064814,0.050559,0.078380
06-07 17:05:19.271+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:19:269,1.694344,-1.085076,9.598031
06-07 17:05:19.271+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:19.271+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:19.271+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:19.281+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:19.281+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:19:284,-0.007840,0.021622,0.052358
06-07 17:05:19.291+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:19:288,1.691232,-1.083501,9.598758
06-07 17:05:19.291+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:19.291+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:19:290,-1.470000,0.070000,0.210000
06-07 17:05:19.291+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:19.301+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:19.301+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:19:280,1.710868,-1.052842,9.607183
06-07 17:05:19.301+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:19:308,-0.910000,0.070000,-0.140000
06-07 17:05:19.301+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:19:307,1.688950,-1.079982,9.599556
06-07 17:05:19.311+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:19:303,-0.014221,-0.030045,0.066587
06-07 17:05:19.311+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:19.311+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:19.311+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:19.311+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:19.321+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:19:322,1.773082,-1.076770,9.683753
06-07 17:05:19.321+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:19.331+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:19:324,0.027915,-0.051385,0.087624
06-07 17:05:19.331+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:19.331+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:19:325,1.688164,-1.079888,9.599705
06-07 17:05:19.341+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:19.341+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:19:328,-0.280000,0.210000,-0.070000
06-07 17:05:19.341+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:19:331,1.701297,-1.091127,9.676575
06-07 17:05:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:05:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:05:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:05:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:05:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:05:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:05:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:05:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:05:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:05:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:05:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:05:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:05:19.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391119354,000000, pattern:[H:mm][0;m
06-07 17:05:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:05:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:05:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:05:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:05:19.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:05:19.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:05][0;m
06-07 17:05:19.351+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:19.361+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:19:349,1.688352,-1.079114,9.599758
06-07 17:05:19.361+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:19.361+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:19:346,0.039689,-0.001170,0.053726
06-07 17:05:19.361+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:19:369,1.761117,-1.083949,9.671788
06-07 17:05:19.361+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:19.361+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:19.361+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:19.371+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:19:364,-0.070000,0.140000,-0.070000
06-07 17:05:19.381+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:19.381+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:19:373,1.770689,-1.088734,9.681360
06-07 17:05:19.381+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:19:376,0.032747,0.042940,0.120795
06-07 17:05:19.391+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:19:387,-0.070000,0.140000,-0.070000
06-07 17:05:19.391+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:19.391+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:19:379,1.692689,-1.080961,9.598787
06-07 17:05:19.401+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:19.401+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:19.411+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:19.411+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:05:19.421+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:05:19:419,539.000000
06-07 17:05:19.421+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:19:405,-0.002718,-0.014131,0.061365
06-07 17:05:19.421+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:19:410,1.739582,-1.076770,9.631111
06-07 17:05:19.431+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:19.431+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:19:428,-0.070000,0.140000,-0.070000
06-07 17:05:19.441+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:19:416,1.694023,-1.081338,9.598509
06-07 17:05:19.441+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:19.451+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:19:447,0.034432,0.046022,0.035025
06-07 17:05:19.451+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:19.451+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:19.451+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:19:449,1.761117,-1.021735,9.671788
06-07 17:05:19.461+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:05:19.461+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:05:19:466,82
06-07 17:05:19.461+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:19.471+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:19:460,1.693861,-1.081022,9.598574
06-07 17:05:19.471+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:19:462,-0.070000,0.140000,-0.140000
06-07 17:05:19.471+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:19.481+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:19:475,0.045545,0.052348,0.063371
06-07 17:05:19.481+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:19:483,1.695575,-1.079869,9.598400
06-07 17:05:19.491+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:19.491+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:19.491+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:19.501+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:19:496,-0.490000,0.490000,0.140000
06-07 17:05:19.501+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:19.501+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:19:496,1.708475,-1.045663,9.688539
06-07 17:05:19.511+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:19.511+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:19:502,0.026844,-0.037851,0.097040
06-07 17:05:19.511+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:19:512,1.696798,-1.074272,9.598812
06-07 17:05:19.511+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:19.521+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:19.521+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:19:520,-0.420000,0.350000,0.070000
06-07 17:05:19.521+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:19:525,1.751546,-1.127020,9.638289
06-07 17:05:19.521+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:19:529,0.014671,-0.017439,0.075851
06-07 17:05:19.521+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:19.531+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:19:540,1.697853,-1.070665,9.599029
06-07 17:05:19.531+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:19.531+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:19.541+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:19:545,-0.070000,-0.070000,0.280000
06-07 17:05:19.561+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:19.561+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:19.571+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:19:572,1.765903,-1.031307,9.554541
06-07 17:05:19.571+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:19:551,0.054612,-0.034739,-0.021924
06-07 17:05:19.571+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:19.581+0200 I/gravity (15533): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:19:574,1.699650,-1.070163,9.598766
06-07 17:05:19.581+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:19:588,-0.070000,-0.210000,0.140000
06-07 17:05:19.581+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:19.581+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:19.591+0200 I/gravity (15533): es.ugr.frailty.gravity - capturing data
06-07 17:05:19.601+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:19.601+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11156266c6f63152838391
