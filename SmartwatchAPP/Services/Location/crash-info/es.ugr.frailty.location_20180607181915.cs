S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 27202
Date: 2018-06-07 18:19:15+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf755252d, r5   = 0xf7ca0f98
r6   = 0xff9a00f0, r7   = 0xff99ffa0
r8   = 0xf7c9dc18, r9   = 0x00000000
r10  = 0xff9a007c, fp   = 0xff9a00f0
ip   = 0x00000001, sp   = 0xff99ff78
lr   = 0xf7552539, pc   = 0xf75bb228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    275220 KB
Buffers:      6756 KB
Cached:     100160 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11548 KB
VmRSS:       11548 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 27202 TID = 27202
27202 27271 

Maps Information
f441d000 f4c1c000 rw-p [stack:27271]
f4c23000 f4c25000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c2d000 f4c31000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c3a000 f4c3c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c44000 f4c47000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4c56000 f4c5b000 r-xp /usr/lib/libsystem.so.0.0.0
f4c66000 f4c69000 r-xp /lib/libattr.so.1.1.0
f4c71000 f4c81000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c89000 f4c92000 r-xp /usr/lib/libedbus.so.1.7.99
f4c9a000 f4c9b000 r-xp /usr/lib/libresponse.so.0.2.96
f4ca4000 f4ca9000 r-xp /usr/lib/libproc-stat.so.0.2.96
f654b000 f6651000 r-xp /usr/lib/libicuuc.so.57.1
f6667000 f67ef000 r-xp /usr/lib/libicui18n.so.57.1
f67ff000 f680c000 r-xp /usr/lib/libail.so.0.1.0
f6815000 f681c000 r-xp /usr/lib/libminizip.so.1.0.0
f6825000 f69ce000 r-xp /usr/lib/libcrypto.so.1.0.0
f69ee000 f6a35000 r-xp /usr/lib/libssl.so.1.0.0
f6a41000 f6a43000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a4b000 f6a52000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a5b000 f6a62000 r-xp /lib/libcrypt-2.13.so
f6a93000 f6a96000 r-xp /lib/libcap.so.2.21
f6a9e000 f6aa0000 r-xp /usr/lib/libiri.so
f6aa8000 f6af1000 r-xp /usr/lib/libmdm.so.1.2.69
f6af9000 f6aff000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b07000 f6b2a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b34000 f6b36000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b3e000 f6b5b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b64000 f6b68000 r-xp /usr/lib/libsmack.so.1.0.0
f6b71000 f6b8a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b93000 f6b9b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6ba3000 f6ba9000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6bb2000 f6bb4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6bbd000 f6bcd000 r-xp /lib/libresolv-2.13.so
f6bd1000 f6be9000 r-xp /usr/lib/liblzma.so.5.0.3
f6bf2000 f6bf4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6bfc000 f6c16000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c1e000 f6c4d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c56000 f6c65000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c6f000 f6c79000 r-xp /usr/lib/libsensord-shared.so
f6c82000 f6d55000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d60000 f6d76000 r-xp /lib/libz.so.1.2.5
f6d7e000 f6d83000 r-xp /usr/lib/libffi.so.5.0.10
f6d8b000 f6d8c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d94000 f6da4000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6dac000 f6dc5000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6dcd000 f6dcf000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6dd7000 f6e4c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e56000 f6e5c000 r-xp /lib/librt-2.13.so
f6e65000 f6e83000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e8d000 f6e8e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e96000 f6eb9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ec1000 f6ec6000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ece000 f6ef8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f01000 f6f18000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f20000 f6f89000 r-xp /lib/libm-2.13.so
f6f92000 f7026000 r-xp /usr/lib/libstdc++.so.6.0.16
f7039000 f703e000 r-xp /usr/lib/libctx-client.so.0.8.3
f7046000 f704d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7055000 f707f000 r-xp /usr/lib/libsensor.so.1.9.6
f7088000 f7154000 r-xp /usr/lib/libxml2.so.2.7.8
f7161000 f7163000 r-xp /usr/lib/libiniparser.so.0
f716c000 f7172000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f717b000 f724b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f724c000 f7280000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7289000 f72c5000 r-xp /usr/lib/libSLP-location.so.0.9.24
f72cd000 f72d0000 r-xp /usr/lib/libbundle.so.0.1.22
f72d8000 f72de000 r-xp /usr/lib/libappsvc.so.0.1.0
f72e6000 f7327000 r-xp /usr/lib/libeina.so.1.7.99
f7330000 f7347000 r-xp /usr/lib/libecore.so.1.7.99
f735e000 f7367000 r-xp /usr/lib/libvconf.so.0.2.45
f736f000 f7383000 r-xp /lib/libpthread-2.13.so
f738e000 f739b000 r-xp /usr/lib/libaul.so.0.1.0
f73a5000 f73a7000 r-xp /lib/libdl-2.13.so
f73b0000 f73bb000 r-xp /lib/libunwind.so.8.0.1
f73e8000 f73f0000 r-xp /lib/libgcc_s-4.6.so.1
f73f1000 f7515000 r-xp /lib/libc-2.13.so
f7523000 f7525000 r-xp /usr/lib/libdlog.so.0.0.0
f752d000 f7539000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7542000 f7547000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f754f000 f755e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7566000 f756a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7573000 f7576000 r-xp /usr/lib/libappcore-agent.so.1.1
f757e000 f7580000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7588000 f758c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7594000 f75b1000 r-xp /lib/ld-2.13.so
f75ba000 f75bd000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f75bd000 f75c1000 r-xp /usr/lib/libsys-assert.so
f7c6d000 f7cdb000 rw-p [heap]
ff981000 ff9a2000 rw-p [stack]
End of Maps Information

Callstack Information (PID:27202)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf75bb228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7552539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72593f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7257c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7263e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7269be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7269dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf729e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72991f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7257c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7263e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7269be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7269dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf729be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf729c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf72a3f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c3b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4c2e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d01663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf71aefcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71b07a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7340ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf733bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf733c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf733c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7574183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75747fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75bb5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf740885c) [/lib/libc.so.6] + 0x1785c
29: (0xf75baf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
eration - capturing data
06-07 18:19:14.141+0200 I/light   (27222): es.ugr.frailty.light - capturing data
06-07 18:19:14.141+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:143,0.070000,0.070000,0.070000
06-07 18:19:14.141+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:145,-0.018321,0.006901,0.030799
06-07 18:19:14.141+0200 I/light   (27222): es.ugr.frailty.light: SM-R760,07/06/2018,18:19:14:150,2056.000000
06-07 18:19:14.151+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.151+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.151+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:141,0.294317,-0.076570,9.832108
06-07 18:19:14.151+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:139,0.312929,-0.081607,9.801316
06-07 18:19:14.151+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.151+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.151+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:159,-0.025790,-0.069141,0.011649
06-07 18:19:14.161+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:157,0.070000,0.070000,0.070000
06-07 18:19:14.161+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.161+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:161,0.311553,-0.081184,9.801364
06-07 18:19:14.161+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.161+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:165,0.287139,-0.150748,9.812965
06-07 18:19:14.161+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.161+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.171+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:171,0.070000,0.070000,0.070000
06-07 18:19:14.171+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:173,0.006692,-0.038457,0.021173
06-07 18:19:14.171+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:175,0.310084,-0.084332,9.801384
06-07 18:19:14.171+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:179,0.318245,-0.119641,9.822537
06-07 18:19:14.181+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.181+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.181+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.181+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:189,0.015340,-0.004203,0.035509
06-07 18:19:14.181+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.191+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:194,0.070000,0.070000,0.070000
06-07 18:19:14.191+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:189,0.310144,-0.085813,9.801369
06-07 18:19:14.191+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:194,0.325424,-0.088534,9.836893
06-07 18:19:14.201+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.201+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.201+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:211,0.310373,-0.085757,9.801362
06-07 18:19:14.201+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.201+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.211+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:215,0.349352,-0.088534,9.841680
06-07 18:19:14.211+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:215,0.039208,-0.002722,0.040311
06-07 18:19:14.211+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:211,0.070000,0.070000,0.070000
06-07 18:19:14.221+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.221+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.221+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.221+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.231+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:233,0.012658,-0.024313,0.018783
06-07 18:19:14.231+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:231,0.070000,0.070000,0.070000
06-07 18:19:14.251+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 18:19:14.251+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 18:19:14.251+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 18:19:14.251+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.251+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.261+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:233,0.323031,-0.110070,9.820145
06-07 18:19:14.261+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.271+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:269,0.334995,-0.066999,9.798609
06-07 18:19:14.271+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:231,0.311665,-0.085714,9.801321
06-07 18:19:14.271+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.271+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.271+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:262,0.023331,0.018715,-0.002712
06-07 18:19:14.271+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:277,0.323031,-0.102891,9.822537
06-07 18:19:14.271+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:261,0.070000,0.070000,0.070000
06-07 18:19:14.271+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.281+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.281+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.291+0200 I/heartrate(27182): es.ugr.frailty.heartrate - capturing data
06-07 18:19:14.291+0200 I/heartrate(27182): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:19:14.291+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:281,0.311828,-0.086680,9.801308
06-07 18:19:14.291+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:284,0.011203,-0.016211,0.021230
06-07 18:19:14.291+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.291+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.291+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:300,-0.015673,0.020981,0.040380
06-07 18:19:14.301+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:290,0.070000,0.070000,0.070000
06-07 18:19:14.301+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:290,0.296710,-0.064606,9.841680
06-07 18:19:14.301+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.301+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.301+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:309,0.070000,0.070000,0.070000
06-07 18:19:14.301+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:308,0.339781,-0.045464,9.846465
06-07 18:19:14.301+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.301+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:301,0.312383,-0.085588,9.801300
06-07 18:19:14.311+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.311+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:314,0.027308,0.040761,0.045174
06-07 18:19:14.311+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.311+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:317,0.312473,-0.086225,9.801291
06-07 18:19:14.321+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.321+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.321+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.321+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:329,0.332602,-0.059821,9.858429
06-07 18:19:14.331+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:330,0.021331,0.025167,0.057089
06-07 18:19:14.331+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:323,0.070000,0.070000,0.070000
06-07 18:19:14.331+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:326,0.311271,-0.084987,9.801340
06-07 18:19:14.331+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.331+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.341+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:341,0.311893,-0.082953,9.801338
06-07 18:19:14.341+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:342,0.070000,0.070000,0.070000
06-07 18:19:14.341+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.341+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.341+0200 I/light   (27222): es.ugr.frailty.light - capturing data
06-07 18:19:14.351+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:350,0.003959,-0.010367,0.035555
06-07 18:19:14.351+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.351+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:351,0.315853,-0.093320,9.836893
06-07 18:19:14.351+0200 I/light   (27222): es.ugr.frailty.light: SM-R760,07/06/2018,18:19:14:352,2056.000000
06-07 18:19:14.351+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:358,0.070000,0.070000,0.070000
06-07 18:19:14.351+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.361+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:363,0.312226,-0.081675,9.801338
06-07 18:19:14.361+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.361+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.361+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:369,0.356531,-0.117248,9.793823
06-07 18:19:14.361+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.371+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:369,0.044304,-0.035573,-0.007515
06-07 18:19:14.371+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:374,0.070000,0.070000,0.070000
06-07 18:19:14.371+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.371+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:380,0.311922,-0.082044,9.801345
06-07 18:19:14.381+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.381+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.381+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.381+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:389,0.368495,-0.095713,9.848858
06-07 18:19:14.381+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.391+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:389,-0.070000,0.070000,0.070000
06-07 18:19:14.391+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:389,0.314384,-0.083817,9.801251
06-07 18:19:14.391+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:393,0.056572,-0.013669,0.047513
06-07 18:19:14.401+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.401+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.401+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:410,0.070000,0.070000,0.070000
06-07 18:19:14.401+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.401+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.411+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:415,-0.008102,-0.062145,0.038034
06-07 18:19:14.411+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:410,0.306281,-0.145962,9.839286
06-07 18:19:14.411+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:415,0.316396,-0.084198,9.801183
06-07 18:19:14.421+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.421+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.421+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.431+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.431+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:431,0.070000,0.070000,0.070000
06-07 18:19:14.431+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:431,0.378066,-0.112463,9.848858
06-07 18:19:14.431+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:434,0.315613,-0.086926,9.801185
06-07 18:19:14.441+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:436,0.061670,-0.028264,0.047675
06-07 18:19:14.441+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.441+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.441+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:450,0.301496,-0.119641,9.803394
06-07 18:19:14.441+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.441+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.451+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:455,0.317863,-0.087777,9.801105
06-07 18:19:14.451+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:450,0.140000,0.070000,0.070000
06-07 18:19:14.451+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:455,-0.014117,-0.032715,0.002210
06-07 18:19:14.461+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.461+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.461+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:470,0.339781,-0.045464,9.856036
06-07 18:19:14.461+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.471+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.471+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:470,0.140000,-0.070000,0.070000
06-07 18:19:14.471+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:475,0.316706,-0.089031,9.801130
06-07 18:19:14.471+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:476,0.021917,0.042313,0.054932
06-07 18:19:14.481+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.481+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.481+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:489,0.337388,-0.050249,9.841680
06-07 18:19:14.481+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.481+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.491+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:489,0.070000,0.070000,0.140000
06-07 18:19:14.491+0200 I/heartrate(27182): es.ugr.frailty.heartrate - capturing data
06-07 18:19:14.491+0200 I/heartrate(27182): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:19:14.491+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:494,0.317100,-0.086790,9.801138
06-07 18:19:14.491+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:494,0.020682,0.038781,0.040549
06-07 18:19:14.501+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.501+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.511+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.511+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:512,0.070000,0.070000,0.140000
06-07 18:19:14.511+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.511+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:511,0.284746,-0.102891,9.789038
06-07 18:19:14.511+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:516,0.317405,-0.084883,9.801145
06-07 18:19:14.521+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:518,-0.032354,-0.016101,-0.012100
06-07 18:19:14.521+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.521+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.531+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.531+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.531+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:529,0.323031,-0.090927,9.848858
06-07 18:19:14.531+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:530,0.070000,0.070000,0.070000
06-07 18:19:14.531+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:536,0.315357,-0.085617,9.801205
06-07 18:19:14.531+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:535,0.005626,-0.006044,0.047713
06-07 18:19:14.541+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.541+0200 I/light   (27222): es.ugr.frailty.light - capturing data
06-07 18:19:14.551+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.551+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.551+0200 I/light   (27222): es.ugr.frailty.light: SM-R760,07/06/2018,18:19:14:552,2055.000000
06-07 18:19:14.551+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:552,0.070000,0.070000,0.070000
06-07 18:19:14.551+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.561+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:558,0.000496,0.066474,0.006975
06-07 18:19:14.561+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:558,0.315853,-0.019143,9.808180
06-07 18:19:14.561+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.561+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:565,0.315216,-0.085678,9.801208
06-07 18:19:14.561+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.571+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.571+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:573,0.314798,-0.082286,9.801250
06-07 18:19:14.571+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:570,0.070000,0.070000,0.070000
06-07 18:19:14.571+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.571+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:576,0.012601,0.006715,-0.000207
06-07 18:19:14.581+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.581+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.581+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.591+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:583,0.327817,-0.078963,9.801002
06-07 18:19:14.591+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.591+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:589,0.070000,0.070000,0.140000
06-07 18:19:14.591+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:595,0.041733,-0.042140,0.057178
06-07 18:19:14.591+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:589,0.314930,-0.081964,9.801250
06-07 18:19:14.591+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:599,0.356531,-0.124427,9.858429
06-07 18:19:14.601+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.601+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.601+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:609,0.316637,-0.083730,9.801179
06-07 18:19:14.601+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.601+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:609,0.070000,0.070000,0.070000
06-07 18:19:14.601+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.611+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:614,-0.003863,-0.016142,0.054787
06-07 18:19:14.611+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:615,0.311067,-0.098106,9.856036
06-07 18:19:14.621+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.621+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.621+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:629,0.315580,-0.084072,9.801210
06-07 18:19:14.621+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.621+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:630,0.140000,0.070000,0.070000
06-07 18:19:14.631+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.631+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:636,0.339781,-0.098106,9.824929
06-07 18:19:14.631+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:635,0.023144,-0.014376,0.023750
06-07 18:19:14.641+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.641+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.651+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:651,0.070000,0.070000,0.070000
06-07 18:19:14.651+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:651,0.316286,-0.084554,9.801184
06-07 18:19:14.651+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.651+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.661+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:660,0.334995,-0.083749,9.836893
06-07 18:19:14.661+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.661+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.671+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:670,0.140000,0.070000,0.070000
06-07 18:19:14.671+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.671+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:671,0.316365,-0.084182,9.801184
06-07 18:19:14.671+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:663,0.019415,0.000323,0.035683
06-07 18:19:14.671+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.681+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:681,0.299103,-0.062213,9.824929
06-07 18:19:14.681+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.681+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.691+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:689,0.070000,0.070000,0.070000
06-07 18:19:14.691+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.691+0200 I/heartrate(27182): es.ugr.frailty.heartrate - capturing data
06-07 18:19:14.691+0200 I/heartrate(27182): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:19:14.691+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:697,0.318245,-0.088534,9.817751
06-07 18:19:14.691+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:690,0.315104,-0.082930,9.801235
06-07 18:19:14.691+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:686,-0.017183,0.022340,0.023746
06-07 18:19:14.701+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.701+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.701+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.701+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:709,0.070000,0.070000,0.070000
06-07 18:19:14.701+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.701+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:709,0.314791,-0.083021,9.801245
06-07 18:19:14.711+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:714,0.258425,-0.047856,9.858429
06-07 18:19:14.711+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:706,0.001881,-0.004352,0.016567
06-07 18:19:14.711+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.721+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:723,-0.056679,0.035074,0.057194
06-07 18:19:14.721+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.721+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.721+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:730,0.311552,-0.080925,9.801366
06-07 18:19:14.721+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:729,0.140000,0.070000,0.070000
06-07 18:19:14.731+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.731+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.731+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:736,0.334995,-0.055035,9.839286
06-07 18:19:14.731+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:736,0.020204,0.027986,0.038041
06-07 18:19:14.741+0200 I/light   (27222): es.ugr.frailty.light - capturing data
06-07 18:19:14.741+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.741+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.751+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:753,-0.070000,0.070000,0.070000
06-07 18:19:14.751+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.751+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:753,0.312588,-0.079832,9.801342
06-07 18:19:14.751+0200 I/light   (27222): es.ugr.frailty.light: SM-R760,07/06/2018,18:19:14:752,2057.000000
06-07 18:19:14.761+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:760,0.330210,-0.078963,9.856036
06-07 18:19:14.761+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.761+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.761+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.771+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.771+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:770,0.070000,0.070000,0.070000
06-07 18:19:14.771+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:776,0.312855,-0.079603,9.801335
06-07 18:19:14.771+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:770,0.334995,-0.107677,9.860823
06-07 18:19:14.771+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:768,0.018657,0.001962,0.054670
06-07 18:19:14.771+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.781+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.781+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.781+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.791+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:790,0.070000,0.070000,0.070000
06-07 18:19:14.791+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:784,0.022408,-0.027845,0.059481
06-07 18:19:14.791+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.791+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:795,0.313485,-0.080719,9.801306
06-07 18:19:14.791+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:790,0.390030,-0.076570,9.860823
06-07 18:19:14.801+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.801+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.801+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:809,0.334995,-0.055035,9.839286
06-07 18:19:14.801+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:809,0.070000,0.070000,0.070000
06-07 18:19:14.801+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.811+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:800,0.077175,0.003033,0.059487
06-07 18:19:14.811+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.811+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:815,0.316264,-0.080393,9.801219
06-07 18:19:14.811+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:818,0.021510,0.025684,0.037980
06-07 18:19:14.821+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.821+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.821+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.831+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:830,0.334995,-0.090927,9.834501
06-07 18:19:14.841+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:834,0.316514,-0.079015,9.801223
06-07 18:19:14.841+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.841+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.851+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:854,0.316610,-0.079243,9.801217
06-07 18:19:14.851+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:850,0.334995,-0.083749,9.839286
06-07 18:19:14.881+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:830,0.070000,0.070000,0.070000
06-07 18:19:14.881+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.881+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.891+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.891+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.911+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:893,0.140000,0.070000,0.070000
06-07 18:19:14.911+0200 I/heartrate(27182): es.ugr.frailty.heartrate - capturing data
06-07 18:19:14.911+0200 I/heartrate(27182): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:19:14.911+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:896,0.351745,-0.095713,9.877571
06-07 18:19:14.921+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.921+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:902,0.316657,-0.079122,9.801217
06-07 18:19:14.921+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:895,0.018731,-0.010534,0.033282
06-07 18:19:14.921+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.921+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.921+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.941+0200 I/light   (27222): es.ugr.frailty.light - capturing data
06-07 18:19:14.951+0200 I/light   (27222): es.ugr.frailty.light: SM-R760,07/06/2018,18:19:14:950,2058.000000
06-07 18:19:14.951+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:930,0.313460,-0.035892,9.774680
06-07 18:19:14.961+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:934,0.140000,0.070000,0.070000
06-07 18:19:14.961+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:937,0.317788,-0.079702,9.801175
06-07 18:19:14.961+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.971+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.971+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:14.971+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:946,0.018481,-0.004734,0.038063
06-07 18:19:14.971+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.981+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:14:984,0.035135,-0.016470,0.076354
06-07 18:19:14.991+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:14:980,0.070000,0.070000,0.070000
06-07 18:19:14.991+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:14:977,0.339781,-0.066999,9.829715
06-07 18:19:14.991+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:14.991+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:14:983,0.316855,-0.077271,9.801226
06-07 18:19:14.991+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:14.991+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:14.991+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:15.011+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:15:1,0.291924,-0.066999,9.839286
06-07 18:19:15.011+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:15:7,-0.003197,0.043230,-0.026537
06-07 18:19:15.011+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:15:8,0.140000,0.070000,0.070000
06-07 18:19:15.011+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:15.011+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:15:5,0.317324,-0.076616,9.801215
06-07 18:19:15.011+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:15.021+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:15.021+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:15.031+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:15:32,0.021993,0.012703,0.028540
06-07 18:19:15.031+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:15:24,0.334995,-0.088534,9.824929
06-07 18:19:15.031+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:15:34,0.070000,0.070000,0.140000
06-07 18:19:15.031+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:15:28,0.315295,-0.075817,9.801287
06-07 18:19:15.041+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:15.041+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:15.041+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:15.041+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:15.061+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:15:56,-0.024931,0.010272,0.038060
06-07 18:19:15.061+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:15:47,0.344566,-0.078963,9.824929
06-07 18:19:15.061+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:15:49,0.315452,-0.076089,9.801280
06-07 18:19:15.061+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:15.061+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:15.061+0200 W/LOCATION(27202): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 18:19:15.061+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:15:59,0.140000,0.070000,0.070000
06-07 18:19:15.071+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:15.071+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:15.081+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:15:72,0.316592,-0.076091,9.801243
06-07 18:19:15.081+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:15:71,0.332602,-0.090927,9.822537
06-07 18:19:15.081+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:15:81,0.017671,-0.011918,0.023714
06-07 18:19:15.081+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:15.081+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:15.081+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:15:83,0.140000,0.070000,0.070000
06-07 18:19:15.091+0200 I/heartrate(27182): es.ugr.frailty.heartrate - capturing data
06-07 18:19:15.091+0200 I/heartrate(27182): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:19:15.091+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:15.091+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:15.101+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:15:95,0.346959,-0.114855,9.801002
06-07 18:19:15.101+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:15:96,0.317819,-0.076955,9.801196
06-07 18:19:15.101+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:15.101+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:15.111+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:15:102,0.029271,-0.003146,0.023643
06-07 18:19:15.111+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:15:104,0.070000,-0.070000,0.070000
06-07 18:19:15.111+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:15:117,0.318680,-0.078287,9.801158
06-07 18:19:15.121+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:15.121+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:15.131+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:15:127,0.017150,-0.014839,0.021257
06-07 18:19:15.131+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:15:118,0.344566,-0.081356,9.798609
06-07 18:19:15.131+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:15.131+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:15.141+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:15:128,-0.070000,-0.070000,0.070000
06-07 18:19:15.141+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:15.141+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:15.141+0200 I/light   (27222): es.ugr.frailty.light - capturing data
06-07 18:19:15.141+0200 I/light   (27222): es.ugr.frailty.light: SM-R760,07/06/2018,18:19:15:151,2057.000000
06-07 18:19:15.151+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:15:142,0.303888,-0.105284,9.860823
06-07 18:19:15.151+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:15:139,0.318809,-0.077966,9.801156
06-07 18:19:15.151+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:15.151+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:15.161+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:15:163,0.317280,-0.078938,9.801198
06-07 18:19:15.161+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:15:149,0.210000,-0.070000,0.070000
06-07 18:19:15.161+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:15:148,0.030368,-0.038765,-0.000241
06-07 18:19:15.161+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:15.161+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:15.171+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:15:178,0.210000,0.070000,0.070000
06-07 18:19:15.171+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:15:172,0.026748,-0.004401,-0.002587
06-07 18:19:15.171+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:15.171+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:15:166,0.301496,-0.093320,9.836893
06-07 18:19:15.181+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:15.181+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:15.181+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:15.191+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:15:185,0.315718,-0.079305,9.801246
06-07 18:19:15.191+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:15:186,0.323031,-0.076570,9.820145
06-07 18:19:15.201+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:15.201+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:15.201+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:15:193,-0.014792,-0.026997,0.059665
06-07 18:19:15.211+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:15:207,0.315258,-0.078846,9.801264
06-07 18:19:15.211+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:15:198,0.140000,0.070000,0.070000
06-07 18:19:15.211+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:15.211+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:15.221+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:15:208,0.301496,-0.052642,9.829715
06-07 18:19:15.221+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:15.221+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:15.221+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:15:219,-0.017313,-0.015355,0.035737
06-07 18:19:15.231+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:15:222,0.140000,0.070000,0.140000
06-07 18:19:15.231+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:15.231+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:15:233,0.334995,-0.088534,9.805787
06-07 18:19:15.241+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:15.241+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 18:19:15.241+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 18:19:15.251+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 18:19:15.251+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:15:231,0.314725,-0.077692,9.801291
06-07 18:19:15.261+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:15.261+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer - capturing data
06-07 18:19:15.261+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:19:15:256,0.140000,0.070000,0.070000
06-07 18:19:15.261+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:15:245,0.005751,0.002368,0.018947
06-07 18:19:15.271+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration - capturing data
06-07 18:19:15.271+0200 I/gyroscope(27175): es.ugr.frailty.gyroscope - capturing data
06-07 18:19:15.281+0200 I/gravity (27207): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:19:15:268,0.315845,-0.078340,9.801250
06-07 18:19:15.291+0200 I/heartrate(27182): es.ugr.frailty.heartrate - capturing data
06-07 18:19:15.291+0200 I/heartrate(27182): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:19:15.291+0200 I/accelerometer(27164): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:19:15:268,0.291924,-0.083749,9.820145
06-07 18:19:15.301+0200 I/linearacceleration(27204): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:19:15:279,-0.014223,0.026663,0.028469
06-07 18:19:15.301+0200 I/gravity (27207): es.ugr.frailty.gravity - capturing data
06-07 18:19:15.311+0200 W/CRASH_MANAGER(27109): worker.c: worker_job(1205) > 11272026c6f63152838835
