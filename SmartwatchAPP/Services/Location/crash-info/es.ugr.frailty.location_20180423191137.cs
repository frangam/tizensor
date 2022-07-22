S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 10045
Date: 2018-04-23 19:11:37+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf754c52d, r5   = 0xf79fbf98
r6   = 0xffac7db0, r7   = 0xffac7c60
r8   = 0xf79f8c18, r9   = 0x00000000
r10  = 0xffac7d3c, fp   = 0xffac7db0
ip   = 0x00000001, sp   = 0xffac7c38
lr   = 0xf754c539, pc   = 0xf75b5228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     42592 KB
Buffers:     46532 KB
Cached:     233076 KB
VmPeak:      53476 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11880 KB
VmRSS:       11876 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 10045 TID = 10045
10045 10074 

Maps Information
f4417000 f4c16000 rw-p [stack:10074]
f4c1d000 f4c1f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c27000 f4c2b000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c34000 f4c36000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c3e000 f4c41000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4c50000 f4c55000 r-xp /usr/lib/libsystem.so.0.0.0
f4c60000 f4c63000 r-xp /lib/libattr.so.1.1.0
f4c6b000 f4c7b000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c83000 f4c8c000 r-xp /usr/lib/libedbus.so.1.7.99
f4c94000 f4c95000 r-xp /usr/lib/libresponse.so.0.2.96
f4c9e000 f4ca3000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6545000 f664b000 r-xp /usr/lib/libicuuc.so.57.1
f6661000 f67e9000 r-xp /usr/lib/libicui18n.so.57.1
f67f9000 f6806000 r-xp /usr/lib/libail.so.0.1.0
f680f000 f6816000 r-xp /usr/lib/libminizip.so.1.0.0
f681f000 f69c8000 r-xp /usr/lib/libcrypto.so.1.0.0
f69e8000 f6a2f000 r-xp /usr/lib/libssl.so.1.0.0
f6a3b000 f6a3d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a45000 f6a4c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a55000 f6a5c000 r-xp /lib/libcrypt-2.13.so
f6a8d000 f6a90000 r-xp /lib/libcap.so.2.21
f6a98000 f6a9a000 r-xp /usr/lib/libiri.so
f6aa2000 f6aeb000 r-xp /usr/lib/libmdm.so.1.2.69
f6af3000 f6af9000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b01000 f6b24000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b2e000 f6b30000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b38000 f6b55000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b5e000 f6b62000 r-xp /usr/lib/libsmack.so.1.0.0
f6b6b000 f6b84000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b8d000 f6b95000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b9d000 f6ba3000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6bac000 f6bae000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6bb7000 f6bc7000 r-xp /lib/libresolv-2.13.so
f6bcb000 f6be3000 r-xp /usr/lib/liblzma.so.5.0.3
f6bec000 f6bee000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6bf6000 f6c10000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c18000 f6c47000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c50000 f6c5f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c69000 f6c73000 r-xp /usr/lib/libsensord-shared.so
f6c7c000 f6d4f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d5a000 f6d70000 r-xp /lib/libz.so.1.2.5
f6d78000 f6d7d000 r-xp /usr/lib/libffi.so.5.0.10
f6d85000 f6d86000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d8e000 f6d9e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6da6000 f6dbf000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6dc7000 f6dc9000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6dd1000 f6e46000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e50000 f6e56000 r-xp /lib/librt-2.13.so
f6e5f000 f6e7d000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e87000 f6e88000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e90000 f6eb3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ebb000 f6ec0000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ec8000 f6ef2000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6efb000 f6f12000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f1a000 f6f83000 r-xp /lib/libm-2.13.so
f6f8c000 f7020000 r-xp /usr/lib/libstdc++.so.6.0.16
f7033000 f7038000 r-xp /usr/lib/libctx-client.so.0.8.3
f7040000 f7047000 r-xp /usr/lib/libctx-shared.so.0.8.3
f704f000 f7079000 r-xp /usr/lib/libsensor.so.1.9.6
f7082000 f714e000 r-xp /usr/lib/libxml2.so.2.7.8
f715b000 f715d000 r-xp /usr/lib/libiniparser.so.0
f7166000 f716c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7175000 f7245000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7246000 f727a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7283000 f72bf000 r-xp /usr/lib/libSLP-location.so.0.9.24
f72c7000 f72ca000 r-xp /usr/lib/libbundle.so.0.1.22
f72d2000 f72d8000 r-xp /usr/lib/libappsvc.so.0.1.0
f72e0000 f7321000 r-xp /usr/lib/libeina.so.1.7.99
f732a000 f7341000 r-xp /usr/lib/libecore.so.1.7.99
f7358000 f7361000 r-xp /usr/lib/libvconf.so.0.2.45
f7369000 f737d000 r-xp /lib/libpthread-2.13.so
f7388000 f7395000 r-xp /usr/lib/libaul.so.0.1.0
f739f000 f73a1000 r-xp /lib/libdl-2.13.so
f73aa000 f73b5000 r-xp /lib/libunwind.so.8.0.1
f73e2000 f73ea000 r-xp /lib/libgcc_s-4.6.so.1
f73eb000 f750f000 r-xp /lib/libc-2.13.so
f751d000 f751f000 r-xp /usr/lib/libdlog.so.0.0.0
f7527000 f7533000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f753c000 f7541000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7549000 f7558000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7560000 f7564000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f756d000 f7570000 r-xp /usr/lib/libappcore-agent.so.1.1
f7578000 f757a000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7582000 f7586000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f758e000 f75ab000 r-xp /lib/ld-2.13.so
f75b4000 f75b7000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f75b7000 f75bb000 r-xp /usr/lib/libsys-assert.so
f79c8000 f7a39000 rw-p [heap]
ffaa9000 ffaca000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10045)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf75b5228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf754c539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72533f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7251c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf725de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7263be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7263dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf729875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72931f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7251c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf725de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7263be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7263dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7295e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7296017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf729df93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c351fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4c28171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6cfb663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf71a8fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71aa7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf733aca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7335b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73365a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7336879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf756e183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf756e7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75b54f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf740285c) [/lib/libc.so.6] + 0x1785c
29: (0xf75b4f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
elerometer: SM-R760,23/04/2018,19:11:36:888,9.681360,-1.399801,1.378266
04-23 19:11:36.889+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:36.889+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:36:879,11.550000,1.680000,8.050000
04-23 19:11:36.889+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:36.889+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:36:883,0.289527,0.009673,-0.624068
04-23 19:11:36.889+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:36.889+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:36:894,9.587445,-1.191338,1.682851
04-23 19:11:36.889+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:36.889+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:36:896,7.980000,-0.840000,5.530000
04-23 19:11:36.889+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:36.899+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:36:902,9.686146,-1.246661,1.105484
04-23 19:11:36.899+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:36.899+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:36:903,-1.120000,-3.010000,6.020000
04-23 19:11:36.899+0200 I/heartrate( 9753): capturing data from es.ugr.frailty.heartrate
04-23 19:11:36.899+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:36.899+0200 I/heartrate( 9753): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:11:36:908,78
04-23 19:11:36.899+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:36:908,-2.870000,-6.370000,5.670000
04-23 19:11:36.899+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:36.909+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:36:913,1.820000,-6.230000,2.870000
04-23 19:11:36.909+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:36.909+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:36:913,9.592241,-1.185796,1.659269
04-23 19:11:36.909+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:36:898,0.159180,-0.249451,-0.101575
04-23 19:11:36.909+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:36:917,5.460000,-2.940000,2.870000
04-23 19:11:36.909+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:36.909+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:36.919+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:36:921,3.080000,-2.240000,-2.100000
04-23 19:11:36.919+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:36.919+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:36.929+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:36:927,3.710000,-1.120000,-2.030000
04-23 19:11:36.929+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:36.929+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:36:931,9.523434,-1.265803,1.842474
04-23 19:11:36.929+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:36.929+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:36:933,11.760000,-2.310000,-2.660000
04-23 19:11:36.929+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:36.929+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:36.929+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:36:938,20.650000,-1.680000,-3.010000
04-23 19:11:36.939+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:36.939+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:36:937,9.586651,-1.192562,1.686508
04-23 19:11:36.939+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:36:943,22.680000,0.560000,-1.820000
04-23 19:11:36.939+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:36.939+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:36:942,9.492328,-1.311267,2.060220
04-23 19:11:36.939+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:36:947,14.770000,4.060000,1.890000
04-23 19:11:36.939+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:36.939+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:36:923,0.016746,-0.288824,0.046227
04-23 19:11:36.949+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:36.949+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:36.949+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:36:952,13.300000,4.270000,4.410000
04-23 19:11:36.949+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:36:954,9.577733,-1.206990,1.726439
04-23 19:11:36.949+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:36:956,-0.059613,-0.312668,-0.080228
04-23 19:11:36.949+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:36.949+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:36.959+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:36.959+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:36:962,29.610001,-2.870000,8.120000
04-23 19:11:36.959+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:36:963,9.461221,-1.339981,1.907080
04-23 19:11:36.959+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:36.959+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:36:967,9.570500,-1.220811,1.756565
04-23 19:11:36.969+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:36:971,0.017303,-0.421395,-0.261556
04-23 19:11:36.969+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:36.969+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:36:976,0.256057,-0.434540,-0.225055
04-23 19:11:36.969+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:36.969+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:36.969+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:36.979+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:36:982,44.799999,-4.410000,14.070000
04-23 19:11:36.979+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:36:982,9.595219,-1.119841,1.406980
04-23 19:11:36.979+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:36.979+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:36:986,9.565930,-1.231538,1.773886
04-23 19:11:36.979+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:36:981,0.122623,-0.539593,-0.346434
04-23 19:11:36.979+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:36.989+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:36:991,0.043333,-0.451726,-0.318249
04-23 19:11:36.989+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:36.989+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:36:995,0.028548,-0.388412,-0.064089
04-23 19:11:36.989+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:36.989+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:36.989+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:36.999+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:36.999+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:0,59.220001,1.260000,21.629999
04-23 19:11:36.999+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:36:999,-0.031401,-0.466277,-0.120639
04-23 19:11:36.999+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:5,9.590433,-0.914058,1.153341
04-23 19:11:36.999+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:36.999+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:1,9.556712,-1.248847,1.811081
04-23 19:11:37.009+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:11,0.097339,-0.204803,-0.321408
04-23 19:11:37.009+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.009+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:15,0.098701,-0.055323,-0.577367
04-23 19:11:37.009+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.009+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:19,-0.068808,-0.080007,0.183205
04-23 19:11:37.019+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.019+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.019+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.019+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.019+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:27,84.769997,15.680000,28.420000
04-23 19:11:37.029+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:23,-0.094323,-0.118705,0.373713
04-23 19:11:37.029+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.029+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:30,9.492328,-0.794417,1.406980
04-23 19:11:37.029+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:28,9.530818,-1.274674,1.925904
04-23 19:11:37.029+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:35,-0.116512,-0.132991,0.180641
04-23 19:11:37.029+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.029+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.029+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.039+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:42,122.639999,31.850000,32.549999
04-23 19:11:37.039+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.039+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:42,9.099905,-0.758525,1.253839
04-23 19:11:37.039+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:40,0.024718,0.100970,-0.349586
04-23 19:11:37.039+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.039+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:46,9.488589,-1.304948,2.105745
04-23 19:11:37.049+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:50,0.024503,0.317479,-0.620546
04-23 19:11:37.049+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.049+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:54,-0.064384,0.454430,-0.404101
04-23 19:11:37.049+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.049+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:57,-0.430913,0.516150,-0.672065
04-23 19:11:37.049+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.049+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.059+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:62,-0.831357,0.498567,-0.674837
04-23 19:11:37.059+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.059+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.059+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:62,164.850006,47.740002,40.529999
04-23 19:11:37.059+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:66,9.407316,-1.353829,2.416594
04-23 19:11:37.059+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:66,8.657232,-0.806381,1.430908
04-23 19:11:37.069+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.069+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.079+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:81,-0.680693,0.669482,-0.966544
04-23 19:11:37.079+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:81,198.520004,63.420002,48.160000
04-23 19:11:37.079+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.079+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.079+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:85,8.726624,-0.684347,1.450050
04-23 19:11:37.079+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:86,9.286914,-1.382706,2.830501
04-23 19:11:37.089+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.089+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.089+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.099+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:102,8.590233,-0.299103,1.725225
04-23 19:11:37.099+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.099+0200 I/heartrate( 9753): capturing data from es.ugr.frailty.heartrate
04-23 19:11:37.099+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:106,9.052639,-1.395940,3.503064
04-23 19:11:37.109+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:102,-0.696681,1.083603,-1.105276
04-23 19:11:37.109+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:102,231.210007,84.980003,57.540001
04-23 19:11:37.109+0200 I/heartrate( 9753): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:11:37:109,78
04-23 19:11:37.119+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.119+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:126,8.634450,-1.347657,4.449774
04-23 19:11:37.119+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.119+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:129,-1.122825,1.099230,-1.593592
04-23 19:11:37.129+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.129+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.139+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:138,7.929814,-0.296710,1.909473
04-23 19:11:37.139+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.139+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.139+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:133,253.119995,116.270004,60.619999
04-23 19:11:37.139+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.149+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:152,7.420143,-0.516850,2.069792
04-23 19:11:37.149+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:145,7.966617,-1.189993,5.593506
04-23 19:11:37.159+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.159+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:163,269.920013,138.180008,61.180000
04-23 19:11:37.159+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.159+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:148,-1.214307,0.830807,-2.379982
04-23 19:11:37.159+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.169+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:167,9.631613,-1.212447,-1.390106
04-23 19:11:37.169+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.169+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:176,281.959991,162.960007,59.010002
04-23 19:11:37.179+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.179+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:170,-1.125537,0.539145,-3.054721
04-23 19:11:37.179+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.179+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:186,6.841080,-0.650848,2.538785
04-23 19:11:37.189+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.189+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:193,6.336195,-0.904487,3.180061
04-23 19:11:37.189+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.189+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.199+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:184,9.709410,-1.316915,-0.404337
04-23 19:11:37.199+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.199+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.199+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:209,9.696666,-1.275452,0.719920
04-23 19:11:37.209+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:198,-3.295418,0.307960,4.570167
04-23 19:11:37.209+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.209+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:203,296.380005,184.869995,52.360001
04-23 19:11:37.209+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:215,-3.686675,0.637353,4.165854
04-23 19:11:37.209+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.209+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:207,6.022735,-0.679562,3.761517
04-23 19:11:37.219+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.219+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:221,317.799988,202.789993,40.040001
04-23 19:11:37.219+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.219+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:226,9.578996,-1.061555,1.812823
04-23 19:11:37.219+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.219+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:226,330.470001,222.460007,22.190001
04-23 19:11:37.219+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.229+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:230,-4.159674,1.115133,3.194737
04-23 19:11:37.229+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:232,5.536992,-0.160319,3.914658
04-23 19:11:37.229+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.229+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.239+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:241,333.269989,234.500000,6.440000
04-23 19:11:37.239+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:241,9.355828,-0.650941,2.866205
04-23 19:11:37.239+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.239+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.239+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:246,-4.939312,2.293858,3.602134
04-23 19:11:37.239+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:246,4.639683,1.232304,5.414958
04-23 19:11:37.249+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.249+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.259+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:262,314.929993,228.970001,-7.280000
04-23 19:11:37.259+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.259+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:262,9.065375,-0.120752,3.738286
04-23 19:11:37.259+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.259+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:266,-4.926713,2.849945,2.180257
04-23 19:11:37.259+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:267,4.429115,2.199004,5.046463
04-23 19:11:37.269+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.269+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.279+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.279+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:281,8.737141,0.440799,4.431529
04-23 19:11:37.279+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.279+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:281,262.709991,224.070007,-8.330000
04-23 19:11:37.289+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:288,4.371687,3.668197,5.022535
04-23 19:11:37.289+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:286,-4.693688,3.788949,1.284249
04-23 19:11:37.289+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.289+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.299+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:301,164.990005,218.050003,2.100000
04-23 19:11:37.299+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.299+0200 I/heartrate( 9753): capturing data from es.ugr.frailty.heartrate
04-23 19:11:37.309+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:307,-4.805733,5.658505,2.452622
04-23 19:11:37.309+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:302,8.330302,1.058567,5.065164
04-23 19:11:37.309+0200 I/heartrate( 9753): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:11:37:308,78
04-23 19:11:37.309+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.309+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:315,3.931407,6.099305,6.884151
04-23 19:11:37.319+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.319+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.319+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:326,53.689999,193.270004,12.810000
04-23 19:11:37.319+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.319+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:326,7.998433,1.372654,5.505568
04-23 19:11:37.329+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.329+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:332,-4.867888,5.062273,3.601639
04-23 19:11:37.329+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:333,3.462414,6.120840,8.666803
04-23 19:11:37.329+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.329+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.339+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:341,-22.750000,163.240005,24.150000
04-23 19:11:37.339+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:342,7.712608,1.524160,5.861996
04-23 19:11:37.339+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.339+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.339+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:348,-4.629339,3.123460,4.783569
04-23 19:11:37.349+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:348,3.369094,4.496114,10.289137
04-23 19:11:37.349+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.349+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.359+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.359+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.359+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:363,-3.843414,1.215622,5.379485
04-23 19:11:37.359+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:362,7.476671,1.550827,6.153430
04-23 19:11:37.369+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:362,3.869194,2.739782,11.241481
04-23 19:11:37.369+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:366,-57.959999,142.940002,35.000000
04-23 19:11:37.369+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.369+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.369+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.379+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.379+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:382,4.048656,1.696511,11.665009
04-23 19:11:37.389+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:381,-3.428015,0.145684,5.511579
04-23 19:11:37.389+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:383,-70.910004,119.629997,47.320000
04-23 19:11:37.389+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:382,7.297394,1.490038,6.379515
04-23 19:11:37.389+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.389+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.399+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:402,-2.729496,0.007869,5.359672
04-23 19:11:37.409+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.409+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.419+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:402,4.567898,1.497907,11.739187
04-23 19:11:37.419+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.429+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:427,-2.475347,-0.126701,4.574447
04-23 19:11:37.429+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.429+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.439+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:422,-61.599998,92.190002,56.420002
04-23 19:11:37.439+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:443,-2.634489,0.404676,3.502240
04-23 19:11:37.439+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:421,7.177243,1.394897,6.535429
04-23 19:11:37.449+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.449+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.449+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:436,4.701896,1.268196,11.109876
04-23 19:11:37.459+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.459+0200 W/LOCATION(10045): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:11:37.459+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:465,-2.984415,0.773098,3.519939
04-23 19:11:37.469+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.469+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.479+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:481,-4.119943,-1.161662,4.157921
04-23 19:11:37.479+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:454,7.094710,1.279871,6.648113
04-23 19:11:37.479+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:453,-59.010002,75.669998,59.849998
04-23 19:11:37.479+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.479+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.479+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:474,4.460221,1.684547,10.150353
04-23 19:11:37.489+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.489+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:490,7.035463,1.155517,6.733306
04-23 19:11:37.489+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:488,-69.440002,62.510002,62.860001
04-23 19:11:37.489+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.499+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.499+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:501,-3.564939,-1.149023,4.720245
04-23 19:11:37.499+0200 I/heartrate( 9753): capturing data from es.ugr.frailty.heartrate
04-23 19:11:37.499+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:494,4.051049,1.928615,10.253245
04-23 19:11:37.499+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.509+0200 I/heartrate( 9753): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:11:37:509,78
04-23 19:11:37.509+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.509+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:503,-69.650002,47.459999,65.099998
04-23 19:11:37.509+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.519+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:512,6.996115,1.032450,6.794027
04-23 19:11:37.519+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.519+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:521,-42.279999,30.100000,60.340000
04-23 19:11:37.519+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:526,-2.691772,-1.269035,4.765971
04-23 19:11:37.529+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.529+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.529+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:517,2.876173,-0.129212,10.951948
04-23 19:11:37.529+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.529+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.529+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:533,-17.010000,24.430000,55.020000
04-23 19:11:37.529+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.539+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:535,6.993855,0.878634,6.817946
04-23 19:11:37.549+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:541,-2.667250,-0.885053,4.586978
04-23 19:11:37.549+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.549+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:543,-29.330000,9.310000,50.470001
04-23 19:11:37.549+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.549+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:538,3.428915,-0.270389,11.538191
04-23 19:11:37.549+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.549+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.559+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:562,-2.779174,-0.300060,4.338819
04-23 19:11:37.559+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:555,-57.959999,6.440000,41.580002
04-23 19:11:37.559+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.569+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:556,6.994067,0.759364,6.832040
04-23 19:11:37.569+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.569+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:561,4.302295,-0.509671,11.598011
04-23 19:11:37.569+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:572,-92.750000,6.090000,29.680000
04-23 19:11:37.569+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.569+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.569+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.579+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:582,-111.930000,4.830000,14.560000
04-23 19:11:37.579+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:582,-3.098087,-0.577262,3.887099
04-23 19:11:37.589+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:581,4.364508,-0.267996,11.394621
04-23 19:11:37.589+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:576,7.031758,0.617057,6.807643
04-23 19:11:37.589+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.589+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.589+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.589+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.599+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:601,-103.599998,7.560000,2.380000
04-23 19:11:37.599+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:597,7.071898,0.462772,6.778236
04-23 19:11:37.599+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:602,-2.978444,-0.429836,3.244804
04-23 19:11:37.609+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.609+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:603,4.292724,0.162712,11.117055
04-23 19:11:37.609+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.619+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:614,7.108458,0.302088,6.748997
04-23 19:11:37.619+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:619,4.010371,-0.275175,10.636096
04-23 19:11:37.619+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.619+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.619+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:627,-76.510002,17.360001,-5.670000
04-23 19:11:37.619+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:627,-3.229115,-0.067434,2.485837
04-23 19:11:37.619+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.629+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.629+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:634,4.165904,-0.299103,9.961320
04-23 19:11:37.629+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.629+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.639+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:642,-58.170002,23.520000,-6.930000
04-23 19:11:37.639+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:642,-3.941041,0.012885,2.167107
04-23 19:11:37.639+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:632,7.144348,0.130733,6.716516
04-23 19:11:37.639+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.639+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.649+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:650,7.165308,-0.006743,6.695424
04-23 19:11:37.649+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:653,3.936193,-0.074178,9.181261
04-23 19:11:37.649+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.649+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.649+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.649+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.659+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:662,-45.849998,23.520000,-7.070000
04-23 19:11:37.659+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:662,-4.322410,-0.243414,2.462953
04-23 19:11:37.659+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:661,7.166566,-0.087062,6.693514
04-23 19:11:37.669+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:661,3.225525,-0.074178,8.860621
04-23 19:11:37.669+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.669+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.669+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.669+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.679+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:681,-4.425746,-1.134791,2.741125
04-23 19:11:37.679+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:681,-28.350000,23.309999,-9.380000
04-23 19:11:37.679+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:680,2.804388,-0.378066,9.198010
04-23 19:11:37.679+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:677,7.126798,-0.134652,6.735058
04-23 19:11:37.679+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.679+0200 I/servicemanager( 9717): es.ugr.frailty.location sleep timeout
04-23 19:11:37.679+0200 W/AUL     ( 9717): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 19:11:37.679+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:11:37.679+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9717
04-23 19:11:37.689+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.689+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10045
04-23 19:11:37.699+0200 W/AUL     ( 9717): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10045)
04-23 19:11:37.699+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.699+0200 I/servicemanager( 9717): es.ugr.frailty.location stop request sent!
04-23 19:11:37.699+0200 I/servicemanager( 9717): App control destroyed.
04-23 19:11:37.699+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:703,-4.265370,-1.306239,2.490727
04-23 19:11:37.699+0200 I/heartrate( 9753): capturing data from es.ugr.frailty.heartrate
04-23 19:11:37.699+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.699+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:708,2.627320,-1.320838,9.552148
04-23 19:11:37.699+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.709+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:702,-12.600000,26.809999,-8.890000
04-23 19:11:37.709+0200 I/heartrate( 9753): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:11:37:709,78
04-23 19:11:37.709+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:691,7.053066,-0.186047,6.811023
04-23 19:11:37.709+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.709+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:716,6.914225,-0.275417,6.948958
04-23 19:11:37.709+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.719+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.719+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.719+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:726,-4.116559,-0.522749,2.157767
04-23 19:11:37.719+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:712,2.648855,-1.581656,9.439686
04-23 19:11:37.719+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:726,-3.500000,29.330000,-7.910000
04-23 19:11:37.719+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.729+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:720,6.717557,-0.350631,7.135956
04-23 19:11:37.729+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.729+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:734,6.548869,-0.370360,7.290098
04-23 19:11:37.729+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:730,2.600998,-0.873380,9.293723
04-23 19:11:37.729+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.729+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.739+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:741,-4.129725,-0.007706,2.230944
04-23 19:11:37.739+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:741,-12.110000,28.210001,-5.600000
04-23 19:11:37.749+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.749+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:757,2.419144,-0.378066,9.521042
04-23 19:11:37.749+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.759+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.759+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:765,-4.065953,-0.073700,2.553405
04-23 19:11:37.769+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.769+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.769+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.779+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:782,-3.986154,-0.557140,2.360071
04-23 19:11:37.779+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:761,6.382205,-0.366580,7.436629
04-23 19:11:37.779+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.779+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:785,-23.730000,26.040001,-3.570000
04-23 19:11:37.779+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.779+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:778,2.316252,-0.440279,9.990034
04-23 19:11:37.779+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.789+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:791,-25.620001,22.400000,-1.190000
04-23 19:11:37.789+0200 I/gravity (10061): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:11:37:788,6.137302,-0.376061,7.639534
04-23 19:11:37.789+0200 I/gravity (10061): capturing data from es.ugr.frailty.gravity
04-23 19:11:37.789+0200 I/linearacceleration(10047): capturing data from es.ugr.frailty.linearacceleration
04-23 19:11:37.789+0200 I/gyroscope(10019): capturing data from es.ugr.frailty.gyroscope
04-23 19:11:37.799+0200 I/linearacceleration(10047): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:11:37:801,-3.755799,-0.772101,1.927975
04-23 19:11:37.799+0200 I/gyroscope(10019): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:11:37:802,-21.629999,17.850000,1.820000
04-23 19:11:37.799+0200 I/accelerometer(10006): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:11:37:792,2.151148,-0.933201,9.999605
04-23 19:11:37.799+0200 I/accelerometer(10006): capturing data from es.ugr.frailty.accelerometer
04-23 19:11:37.809+0200 W/CRASH_MANAGER( 9824): worker.c: worker_job(1205) > 11100456c6f63152450349
