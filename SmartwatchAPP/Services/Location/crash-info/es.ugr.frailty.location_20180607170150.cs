S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 14627
Date: 2018-06-07 17:01:50+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf74d652d, r5   = 0xf79a4f98
r6   = 0xffdfd630, r7   = 0xffdfd4e0
r8   = 0xf79a1c18, r9   = 0x00000000
r10  = 0xffdfd5bc, fp   = 0xffdfd630
ip   = 0x00000001, sp   = 0xffdfd4b8
lr   = 0xf74d6539, pc   = 0xf753f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     35972 KB
Buffers:      7988 KB
Cached:      52152 KB
VmPeak:      53460 KB
VmSize:      53396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11700 KB
VmRSS:       11700 KB
VmData:      11124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 14627 TID = 14627
14627 14633 

Maps Information
f43a1000 f4ba0000 rw-p [stack:14633]
f4ba7000 f4ba9000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4bb1000 f4bb5000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4bbe000 f4bc0000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4bc8000 f4bcb000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4bda000 f4bdf000 r-xp /usr/lib/libsystem.so.0.0.0
f4bea000 f4bed000 r-xp /lib/libattr.so.1.1.0
f4bf5000 f4c05000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c0d000 f4c16000 r-xp /usr/lib/libedbus.so.1.7.99
f4c1e000 f4c1f000 r-xp /usr/lib/libresponse.so.0.2.96
f4c28000 f4c2d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f64cf000 f65d5000 r-xp /usr/lib/libicuuc.so.57.1
f65eb000 f6773000 r-xp /usr/lib/libicui18n.so.57.1
f6783000 f6790000 r-xp /usr/lib/libail.so.0.1.0
f6799000 f67a0000 r-xp /usr/lib/libminizip.so.1.0.0
f67a9000 f6952000 r-xp /usr/lib/libcrypto.so.1.0.0
f6972000 f69b9000 r-xp /usr/lib/libssl.so.1.0.0
f69c5000 f69c7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f69cf000 f69d6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f69df000 f69e6000 r-xp /lib/libcrypt-2.13.so
f6a17000 f6a1a000 r-xp /lib/libcap.so.2.21
f6a22000 f6a24000 r-xp /usr/lib/libiri.so
f6a2c000 f6a75000 r-xp /usr/lib/libmdm.so.1.2.69
f6a7d000 f6a83000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a8b000 f6aae000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6ab8000 f6aba000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ac2000 f6adf000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6ae8000 f6aec000 r-xp /usr/lib/libsmack.so.1.0.0
f6af5000 f6b0e000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b17000 f6b1f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b27000 f6b2d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b36000 f6b38000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b41000 f6b51000 r-xp /lib/libresolv-2.13.so
f6b55000 f6b6d000 r-xp /usr/lib/liblzma.so.5.0.3
f6b76000 f6b78000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b80000 f6b9a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ba2000 f6bd1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bda000 f6be9000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6bf3000 f6bfd000 r-xp /usr/lib/libsensord-shared.so
f6c06000 f6cd9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ce4000 f6cfa000 r-xp /lib/libz.so.1.2.5
f6d02000 f6d07000 r-xp /usr/lib/libffi.so.5.0.10
f6d0f000 f6d10000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d18000 f6d28000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d30000 f6d49000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d51000 f6d53000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d5b000 f6dd0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6dda000 f6de0000 r-xp /lib/librt-2.13.so
f6de9000 f6e07000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e11000 f6e12000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e1a000 f6e3d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e45000 f6e4a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e52000 f6e7c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e85000 f6e9c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ea4000 f6f0d000 r-xp /lib/libm-2.13.so
f6f16000 f6faa000 r-xp /usr/lib/libstdc++.so.6.0.16
f6fbd000 f6fc2000 r-xp /usr/lib/libctx-client.so.0.8.3
f6fca000 f6fd1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6fd9000 f7003000 r-xp /usr/lib/libsensor.so.1.9.6
f700c000 f70d8000 r-xp /usr/lib/libxml2.so.2.7.8
f70e5000 f70e7000 r-xp /usr/lib/libiniparser.so.0
f70f0000 f70f6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f70ff000 f71cf000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71d0000 f7204000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f720d000 f7249000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7251000 f7254000 r-xp /usr/lib/libbundle.so.0.1.22
f725c000 f7262000 r-xp /usr/lib/libappsvc.so.0.1.0
f726a000 f72ab000 r-xp /usr/lib/libeina.so.1.7.99
f72b4000 f72cb000 r-xp /usr/lib/libecore.so.1.7.99
f72e2000 f72eb000 r-xp /usr/lib/libvconf.so.0.2.45
f72f3000 f7307000 r-xp /lib/libpthread-2.13.so
f7312000 f731f000 r-xp /usr/lib/libaul.so.0.1.0
f7329000 f732b000 r-xp /lib/libdl-2.13.so
f7334000 f733f000 r-xp /lib/libunwind.so.8.0.1
f736c000 f7374000 r-xp /lib/libgcc_s-4.6.so.1
f7375000 f7499000 r-xp /lib/libc-2.13.so
f74a7000 f74a9000 r-xp /usr/lib/libdlog.so.0.0.0
f74b1000 f74bd000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74c6000 f74cb000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74d3000 f74e2000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f74ea000 f74ee000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74f7000 f74fa000 r-xp /usr/lib/libappcore-agent.so.1.1
f7502000 f7504000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f750c000 f7510000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7518000 f7535000 r-xp /lib/ld-2.13.so
f753e000 f7541000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7541000 f7545000 r-xp /usr/lib/libsys-assert.so
f7971000 f79d3000 rw-p [heap]
ffdde000 ffdff000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14627)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf753f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf74d6539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71dd3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf71dbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf71e7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf71edbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf71eddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf722275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf721d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf71dbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf71e7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf71edbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf71eddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf721fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7220017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7227f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4bbf1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4bb2171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c85663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7132fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71347a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf72c4ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf72bfb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72c05a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf72c0879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf74f8183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74f87fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf753f5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf738c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf753ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ration - capturing data
06-07 17:01:50.091+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:55,8.906086,3.955336,1.136591
06-07 17:01:50.091+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:95,3.150000,-0.280000,1.190000
06-07 17:01:50.091+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.101+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.101+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:105,2.240000,-0.280000,0.420000
06-07 17:01:50.101+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:104,0.006530,0.041842,0.030616
06-07 17:01:50.101+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:110,8.898908,4.268795,1.040878
06-07 17:01:50.111+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.111+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.111+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:117,8.871712,4.034460,1.089154
06-07 17:01:50.111+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.111+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.111+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:121,-0.001649,-0.004426,-0.057391
06-07 17:01:50.121+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:122,-2.100000,-1.470000,0.770000
06-07 17:01:50.121+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:116,8.858230,4.187439,1.105484
06-07 17:01:50.121+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.121+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:130,8.800802,4.000800,1.048056
06-07 17:01:50.131+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.131+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.131+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.131+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:136,8.878564,4.019712,1.087843
06-07 17:01:50.131+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:136,0.020018,-0.098266,0.028294
06-07 17:01:50.131+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.131+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:141,-1.890000,-2.030000,0.770000
06-07 17:01:50.141+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:136,8.901299,3.902694,1.213161
06-07 17:01:50.141+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.141+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:150,8.908479,3.931407,1.086342
06-07 17:01:50.151+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.151+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:156,8.882885,4.009658,1.089674
06-07 17:01:50.151+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.151+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.151+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:160,-0.070000,-0.910000,-0.770000
06-07 17:01:50.161+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:160,0.039486,-0.193589,0.063105
06-07 17:01:50.161+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.161+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:167,8.874979,4.079762,1.100698
06-07 17:01:50.161+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.171+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:172,8.874979,4.082155,1.124627
06-07 17:01:50.171+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.171+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.171+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.171+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.181+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:185,2.590000,-0.350000,-1.190000
06-07 17:01:50.181+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:181,8.881179,4.014544,1.085575
06-07 17:01:50.181+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:178,8.865408,4.039084,1.036092
06-07 17:01:50.181+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:185,0.020808,0.000713,-0.046403
06-07 17:01:50.181+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.191+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.191+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.191+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.191+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:198,8.878919,4.020956,1.080330
06-07 17:01:50.191+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:196,0.980000,0.840000,-1.120000
06-07 17:01:50.201+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:198,0.053621,0.022148,-0.130839
06-07 17:01:50.201+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:194,8.891729,3.936193,1.117448
06-07 17:01:50.201+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.211+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:212,8.918050,3.826123,1.150948
06-07 17:01:50.211+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.211+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.211+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.211+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:218,8.878397,4.022642,1.078338
06-07 17:01:50.211+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.221+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:223,1.610000,-0.560000,1.120000
06-07 17:01:50.221+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:222,-0.082902,0.042057,-0.003560
06-07 17:01:50.221+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:217,8.903693,4.010371,1.043271
06-07 17:01:50.221+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.231+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:232,8.934800,4.036692,0.954736
06-07 17:01:50.231+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.231+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.231+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.231+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:238,1.750000,-0.210000,-0.490000
06-07 17:01:50.231+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:237,8.874909,4.031039,1.075684
06-07 17:01:50.241+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:242,-0.051274,0.114549,-0.030281
06-07 17:01:50.241+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.241+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:248,8.796017,4.063013,1.076770
06-07 17:01:50.241+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.251+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.251+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.251+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:256,8.875950,4.028046,1.078303
06-07 17:01:50.251+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:254,8.827123,4.137190,1.048056
06-07 17:01:50.251+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:01:50.251+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:257,1.050000,-1.260000,-0.210000
06-07 17:01:50.251+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.261+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:01:50:264,88
06-07 17:01:50.261+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.261+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:269,0.028784,-0.011097,0.118335
06-07 17:01:50.261+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:269,8.903693,4.019942,1.194018
06-07 17:01:50.271+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:01:50.271+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.271+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.271+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:281,-0.560000,-2.100000,-0.840000
06-07 17:01:50.271+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:281,8.879505,4.021787,1.072385
06-07 17:01:50.281+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:01:50:285,412.000000
06-07 17:01:50.281+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.291+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.291+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.291+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:296,8.881887,4.017736,1.067829
06-07 17:01:50.291+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:296,8.810372,3.976871,1.014557
06-07 17:01:50.291+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.291+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:294,-0.065578,-0.051175,-0.063746
06-07 17:01:50.291+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:301,8.886944,4.070191,1.050449
06-07 17:01:50.301+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.301+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.301+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:306,-0.350000,-2.030000,-0.420000
06-07 17:01:50.301+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:306,0.007439,0.048404,-0.021936
06-07 17:01:50.311+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.311+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.311+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:317,8.884341,4.013843,1.062039
06-07 17:01:50.311+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:317,0.070000,-1.120000,0.070000
06-07 17:01:50.311+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.321+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.321+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:323,0.060090,0.011777,-0.072415
06-07 17:01:50.321+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:325,8.941978,4.029513,0.995414
06-07 17:01:50.331+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.331+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.331+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:336,8.880368,4.023781,1.057649
06-07 17:01:50.331+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:336,2.240000,1.190000,0.140000
06-07 17:01:50.331+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.331+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.341+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:342,0.014566,0.085063,-0.107302
06-07 17:01:50.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:01:50.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:01:50.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:01:50.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:01:50.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:01:50.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:01:50.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:01:50.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:01:50.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:01:50.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:01:50.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:01:50.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:01:50.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390910353,000000, pattern:[H:mm][0;m
06-07 17:01:50.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:01:50.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:01:50.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:01:50.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:01:50.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:01:50.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:01][0;m
06-07 17:01:50.361+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.361+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:365,-0.024532,0.094266,-0.052664
06-07 17:01:50.361+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.371+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:375,4.060000,1.680000,-0.140000
06-07 17:01:50.371+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.391+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.391+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:399,8.873382,4.039619,1.055916
06-07 17:01:50.401+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:345,8.898908,4.098906,0.954736
06-07 17:01:50.401+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.401+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.411+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:420,8.855836,4.118048,1.004985
06-07 17:01:50.411+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.421+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:425,8.810372,4.118048,1.014557
06-07 17:01:50.421+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.431+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.431+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:383,-0.063009,0.078429,-0.041359
06-07 17:01:50.431+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.441+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:431,8.858230,4.098906,1.031307
06-07 17:01:50.441+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:408,8.866559,4.054523,1.056102
06-07 17:01:50.441+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.441+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.451+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:452,8.896514,4.074977,1.091127
06-07 17:01:50.451+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:01:50.461+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:443,-0.008329,0.044383,-0.024795
06-07 17:01:50.461+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.461+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:01:50:465,88
06-07 17:01:50.461+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.461+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:439,2.660000,1.890000,-0.350000
06-07 17:01:50.471+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.471+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:01:50.471+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:476,-0.210000,-0.350000,-0.070000
06-07 17:01:50.481+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:01:50:481,411.000000
06-07 17:01:50.481+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:474,8.961121,4.139583,1.050449
06-07 17:01:50.481+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:447,8.866457,4.055195,1.054384
06-07 17:01:50.481+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.481+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.491+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:494,8.867801,3.931407,1.052842
06-07 17:01:50.491+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:468,0.030057,0.019782,0.036743
06-07 17:01:50.491+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.501+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.501+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.501+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:493,8.871047,4.045970,1.051207
06-07 17:01:50.511+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:510,8.827123,4.053442,1.050449
06-07 17:01:50.521+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.511+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:510,-0.560000,-2.800000,-0.070000
06-07 17:01:50.511+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:502,0.090074,0.093613,-0.000758
06-07 17:01:50.521+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:527,8.889337,4.031906,1.141376
06-07 17:01:50.511+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.531+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.541+0200 W/LOCATION(14627): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:01:50.541+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:544,8.872267,4.044727,1.045677
06-07 17:01:50.541+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.551+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:552,8.869390,4.050247,1.048712
06-07 17:01:50.551+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.551+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:558,8.871630,4.044985,1.050081
06-07 17:01:50.551+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:537,-0.004466,-0.113320,0.007165
06-07 17:01:50.551+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.551+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.561+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:565,8.881224,4.023715,1.050701
06-07 17:01:50.561+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.561+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.561+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:570,8.887113,4.011081,1.049211
06-07 17:01:50.571+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.571+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:564,-0.042268,0.003194,0.001737
06-07 17:01:50.571+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:576,8.885023,4.016805,1.045000
06-07 17:01:50.571+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.581+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:571,2.450000,-1.890000,0.630000
06-07 17:01:50.581+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:583,8.881579,4.022817,1.051129
06-07 17:01:50.581+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.581+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.581+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.591+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.591+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:599,8.884550,3.950550,1.074377
06-07 17:01:50.591+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.601+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:592,0.017707,-0.013079,0.091296
06-07 17:01:50.601+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:597,8.885832,4.013173,1.052058
06-07 17:01:50.601+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.601+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:589,1.820000,1.820000,-0.770000
06-07 17:01:50.601+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.611+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.611+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:613,0.003326,-0.073165,0.023676
06-07 17:01:50.611+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:618,8.891161,4.000387,1.055717
06-07 17:01:50.621+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.621+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:612,-3.290000,-0.420000,-0.140000
06-07 17:01:50.621+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.621+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.631+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:604,8.918050,4.089334,0.993021
06-07 17:01:50.631+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.641+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:630,0.030937,0.078253,-0.056189
06-07 17:01:50.641+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.641+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:637,8.893003,3.997755,1.050168
06-07 17:01:50.641+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:630,-5.320000,-3.570000,0.560000
06-07 17:01:50.641+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.651+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.651+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:640,8.824730,4.158726,1.119841
06-07 17:01:50.651+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:01:50.651+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.661+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:01:50:664,88
06-07 17:01:50.661+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:655,-2.380000,-2.310000,-0.560000
06-07 17:01:50.661+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.661+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:648,-0.060293,0.141921,0.074841
06-07 17:01:50.661+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.661+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:670,1.680000,-0.280000,-0.770000
06-07 17:01:50.661+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.671+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:673,-0.095135,0.076088,0.016070
06-07 17:01:50.671+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:657,8.889552,4.006480,1.046116
06-07 17:01:50.671+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:01:50.671+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:01:50:681,410.000000
06-07 17:01:50.671+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:665,8.786445,4.098906,1.067199
06-07 17:01:50.681+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.681+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:690,8.891006,4.004253,1.042289
06-07 17:01:50.681+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.691+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.691+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:695,0.053753,0.037876,0.137175
06-07 17:01:50.691+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:697,8.939585,4.051049,1.189233
06-07 17:01:50.691+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.691+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.701+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:674,-2.170000,0.770000,-0.140000
06-07 17:01:50.701+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.701+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:709,-5.460000,-1.680000,0.490000
06-07 17:01:50.701+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.711+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:704,8.897535,3.989955,1.041396
06-07 17:01:50.711+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.721+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:714,-0.025753,-0.023516,-0.067481
06-07 17:01:50.721+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:703,8.865408,3.976871,0.988236
06-07 17:01:50.721+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.721+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.721+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:731,-0.001273,0.172935,-0.064325
06-07 17:01:50.731+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:730,8.891729,4.170690,0.985843
06-07 17:01:50.731+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:724,8.902489,3.979566,1.038816
06-07 17:01:50.731+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.731+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.741+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.741+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:746,-3.570000,-2.380000,0.350000
06-07 17:01:50.741+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:744,8.900455,3.985990,1.031589
06-07 17:01:50.751+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.751+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:750,-0.036109,0.090033,-0.110523
06-07 17:01:50.751+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.761+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.761+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.761+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:757,8.853443,4.096512,0.935594
06-07 17:01:50.761+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.761+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:765,8.890106,4.010002,1.027755
06-07 17:01:50.771+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:771,-0.071061,-0.051310,-0.042089
06-07 17:01:50.771+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.771+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:766,0.560000,-1.260000,-0.420000
06-07 17:01:50.771+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.771+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.781+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:780,8.883559,4.021986,1.037492
06-07 17:01:50.781+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:784,1.190000,-0.070000,-0.280000
06-07 17:01:50.791+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:772,8.819944,3.952943,1.000200
06-07 17:01:50.791+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:785,0.022907,-0.048976,-0.055553
06-07 17:01:50.791+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.791+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.801+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.801+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.801+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:802,8.888231,4.010075,1.043565
06-07 17:01:50.811+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:806,-0.013152,0.069090,-0.122365
06-07 17:01:50.811+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:800,8.920443,3.940979,0.985843
06-07 17:01:50.811+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.811+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:806,-3.360000,-0.210000,0.350000
06-07 17:01:50.811+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.811+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.821+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.821+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:822,8.888738,4.007614,1.048696
06-07 17:01:50.821+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:824,-0.006333,0.273234,-0.124709
06-07 17:01:50.831+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.831+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.841+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:827,8.889337,4.048656,0.916451
06-07 17:01:50.841+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.841+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:843,0.001623,0.234865,0.125586
06-07 17:01:50.841+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:840,8.883315,4.020125,1.046750
06-07 17:01:50.841+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:825,-5.950000,-1.400000,0.210000
06-07 17:01:50.851+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.851+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.851+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.851+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:856,-3.990000,-1.260000,-0.840000
06-07 17:01:50.861+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:01:50.861+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:847,8.894121,4.259224,0.906880
06-07 17:01:50.861+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:01:50:866,88
06-07 17:01:50.871+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.871+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:861,8.880220,4.026608,1.048089
06-07 17:01:50.871+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:859,-0.111471,-0.124077,0.111063
06-07 17:01:50.871+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.871+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:01:50.871+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:01:50:881,411.000000
06-07 17:01:50.881+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.881+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.891+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:877,8.891729,4.244867,1.153341
06-07 17:01:50.891+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:887,2.030000,-0.210000,-0.630000
06-07 17:01:50.891+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.891+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:898,3.780000,2.450000,-0.210000
06-07 17:01:50.891+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:888,0.017855,-0.078667,0.138490
06-07 17:01:50.891+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.891+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:890,8.879157,4.029446,1.046198
06-07 17:01:50.901+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.901+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.901+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.911+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:914,8.772088,3.897908,1.148555
06-07 17:01:50.911+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:908,0.010170,0.062578,-0.103531
06-07 17:01:50.911+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:911,8.881889,4.022691,1.048996
06-07 17:01:50.911+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.911+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.921+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:903,-1.190000,2.170000,1.120000
06-07 17:01:50.921+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.921+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:921,8.906086,3.931407,1.182054
06-07 17:01:50.921+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.931+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:924,-0.132763,0.042888,-0.017836
06-07 17:01:50.931+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.931+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:933,8.885176,4.014360,1.053067
06-07 17:01:50.931+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.941+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.941+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:943,-0.005241,0.129725,-0.014390
06-07 17:01:50.941+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:935,8.898908,4.070191,0.945165
06-07 17:01:50.951+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.951+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:942,-3.010000,-0.840000,0.840000
06-07 17:01:50.951+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.951+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:952,8.882086,4.021586,1.051557
06-07 17:01:50.951+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.961+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:50.961+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:961,0.050858,0.028781,0.059286
06-07 17:01:50.961+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.971+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:962,1.120000,-0.560000,-0.630000
06-07 17:01:50.971+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.971+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:970,8.877206,4.032856,1.049610
06-07 17:01:50.971+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:50.981+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:50:970,8.750552,4.063013,1.028914
06-07 17:01:50.981+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:50:987,8.875292,4.037209,1.049057
06-07 17:01:50.981+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:979,1.680000,2.170000,-0.490000
06-07 17:01:50.981+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:977,0.002661,-0.029070,0.097166
06-07 17:01:50.981+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:50.981+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:50.991+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:51.001+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:51.001+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:50:997,-0.029340,0.067795,-0.016975
06-07 17:01:51.001+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:51:5,8.874979,4.156333,1.033699
06-07 17:01:51.001+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:51.001+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:51.011+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:51:7,8.876184,4.036094,1.045791
06-07 17:01:51.011+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:51.011+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:50:992,-0.210000,0.840000,-0.070000
06-07 17:01:51.021+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:51:25,8.874533,4.039894,1.045133
06-07 17:01:51.021+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:51:15,0.000072,0.094069,-0.029822
06-07 17:01:51.021+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:51.021+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:51.031+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:51:11,8.930015,4.058227,1.105484
06-07 17:01:51.031+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:51.031+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:51.031+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:51:35,-0.016584,0.046907,-0.023089
06-07 17:01:51.031+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:51:38,8.884550,3.993621,1.146162
06-07 17:01:51.031+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:51.041+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:51:32,-0.700000,-0.840000,-0.700000
06-07 17:01:51.041+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:51.041+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:51.041+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:51:50,-3.360000,-0.910000,-0.490000
06-07 17:01:51.041+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:51:50,-0.064919,0.030590,-0.034501
06-07 17:01:51.041+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:51.051+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:51:43,8.855836,4.082155,1.036092
06-07 17:01:51.051+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:01:51.061+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:01:51:64,88
06-07 17:01:51.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:01:51.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:01:51.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:01:51.061+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:51:55,-2.450000,-1.050000,0.070000
06-07 17:01:51.061+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:51:44,8.873323,4.043680,1.040758
06-07 17:01:51.061+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:51.071+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:51.071+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:51.071+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:01:51.071+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:01:51:78,412.000000
06-07 17:01:51.081+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:51:76,8.882158,4.115655,1.021735
06-07 17:01:51.081+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:51.081+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:51:75,1.750000,0.070000,-0.630000
06-07 17:01:51.081+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:51.081+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:51.091+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:51:84,8.873718,4.044721,1.033314
06-07 17:01:51.091+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:51:90,2.940000,0.630000,-0.630000
06-07 17:01:51.101+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:51.101+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:51:93,8.860621,4.079762,1.026521
06-07 17:01:51.111+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:51:91,-0.029919,0.048454,0.007051
06-07 17:01:51.111+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:51.111+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:51.121+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:51:132,0.420000,0.420000,-0.140000
06-07 17:01:51.131+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:51.131+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:51:124,8.875835,4.040754,1.030648
06-07 17:01:51.141+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:51:129,8.810372,4.067799,1.014557
06-07 17:01:51.141+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:51.141+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:51.151+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:51:138,-0.054588,0.061404,-0.061683
06-07 17:01:51.151+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:51.151+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:51.161+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:51:165,8.846266,4.084548,1.052842
06-07 17:01:51.171+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11146276c6f63152838371
