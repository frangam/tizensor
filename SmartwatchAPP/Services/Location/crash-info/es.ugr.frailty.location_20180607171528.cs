S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 18770
Date: 2018-06-07 17:15:28+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf769252d, r5   = 0xf77cef98
r6   = 0xffd10b60, r7   = 0xffd10a10
r8   = 0xf77cbc18, r9   = 0x00000000
r10  = 0xffd10aec, fp   = 0xffd10b60
ip   = 0x00000001, sp   = 0xffd109e8
lr   = 0xf7692539, pc   = 0xf76fb228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    340448 KB
Buffers:      5528 KB
Cached:      52496 KB
VmPeak:      53600 KB
VmSize:      53436 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11504 KB
VmRSS:       11504 KB
VmData:      11164 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:         16 KB

Threads Information
Threads: 2
PID = 18770 TID = 18770
18770 18774 

Maps Information
f455d000 f4d5c000 rw-p [stack:18774]
f4d63000 f4d65000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4d6d000 f4d71000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4d7a000 f4d7c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d84000 f4d87000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d96000 f4d9b000 r-xp /usr/lib/libsystem.so.0.0.0
f4da6000 f4da9000 r-xp /lib/libattr.so.1.1.0
f4db1000 f4dc1000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4dc9000 f4dd2000 r-xp /usr/lib/libedbus.so.1.7.99
f4dda000 f4ddb000 r-xp /usr/lib/libresponse.so.0.2.96
f4de4000 f4de9000 r-xp /usr/lib/libproc-stat.so.0.2.96
f668b000 f6791000 r-xp /usr/lib/libicuuc.so.57.1
f67a7000 f692f000 r-xp /usr/lib/libicui18n.so.57.1
f693f000 f694c000 r-xp /usr/lib/libail.so.0.1.0
f6955000 f695c000 r-xp /usr/lib/libminizip.so.1.0.0
f6965000 f6b0e000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b2e000 f6b75000 r-xp /usr/lib/libssl.so.1.0.0
f6b81000 f6b83000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b8b000 f6b92000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b9b000 f6ba2000 r-xp /lib/libcrypt-2.13.so
f6bd3000 f6bd6000 r-xp /lib/libcap.so.2.21
f6bde000 f6be0000 r-xp /usr/lib/libiri.so
f6be8000 f6c31000 r-xp /usr/lib/libmdm.so.1.2.69
f6c39000 f6c3f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c47000 f6c6a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6c74000 f6c76000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c7e000 f6c9b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6ca4000 f6ca8000 r-xp /usr/lib/libsmack.so.1.0.0
f6cb1000 f6cca000 r-xp /usr/lib/libnetwork.so.0.0.0
f6cd3000 f6cdb000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6ce3000 f6ce9000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6cf2000 f6cf4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6cfd000 f6d0d000 r-xp /lib/libresolv-2.13.so
f6d11000 f6d29000 r-xp /usr/lib/liblzma.so.5.0.3
f6d32000 f6d34000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d3c000 f6d56000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d5e000 f6d8d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d96000 f6da5000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6daf000 f6db9000 r-xp /usr/lib/libsensord-shared.so
f6dc2000 f6e95000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ea0000 f6eb6000 r-xp /lib/libz.so.1.2.5
f6ebe000 f6ec3000 r-xp /usr/lib/libffi.so.5.0.10
f6ecb000 f6ecc000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ed4000 f6ee4000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6eec000 f6f05000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f0d000 f6f0f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f17000 f6f8c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f96000 f6f9c000 r-xp /lib/librt-2.13.so
f6fa5000 f6fc3000 r-xp /usr/lib/libsystemd.so.0.4.0
f6fcd000 f6fce000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6fd6000 f6ff9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7001000 f7006000 r-xp /usr/lib/libxdgmime.so.1.1.0
f700e000 f7038000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7041000 f7058000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7060000 f70c9000 r-xp /lib/libm-2.13.so
f70d2000 f7166000 r-xp /usr/lib/libstdc++.so.6.0.16
f7179000 f717e000 r-xp /usr/lib/libctx-client.so.0.8.3
f7186000 f718d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7195000 f71bf000 r-xp /usr/lib/libsensor.so.1.9.6
f71c8000 f7294000 r-xp /usr/lib/libxml2.so.2.7.8
f72a1000 f72a3000 r-xp /usr/lib/libiniparser.so.0
f72ac000 f72b2000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f72bb000 f738b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f738c000 f73c0000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f73c9000 f7405000 r-xp /usr/lib/libSLP-location.so.0.9.24
f740d000 f7410000 r-xp /usr/lib/libbundle.so.0.1.22
f7418000 f741e000 r-xp /usr/lib/libappsvc.so.0.1.0
f7426000 f7467000 r-xp /usr/lib/libeina.so.1.7.99
f7470000 f7487000 r-xp /usr/lib/libecore.so.1.7.99
f749e000 f74a7000 r-xp /usr/lib/libvconf.so.0.2.45
f74af000 f74c3000 r-xp /lib/libpthread-2.13.so
f74ce000 f74db000 r-xp /usr/lib/libaul.so.0.1.0
f74e5000 f74e7000 r-xp /lib/libdl-2.13.so
f74f0000 f74fb000 r-xp /lib/libunwind.so.8.0.1
f7528000 f7530000 r-xp /lib/libgcc_s-4.6.so.1
f7531000 f7655000 r-xp /lib/libc-2.13.so
f7663000 f7665000 r-xp /usr/lib/libdlog.so.0.0.0
f766d000 f7679000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7682000 f7687000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f768f000 f769e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f76a6000 f76aa000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f76b3000 f76b6000 r-xp /usr/lib/libappcore-agent.so.1.1
f76be000 f76c0000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f76c8000 f76cc000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f76d4000 f76f1000 r-xp /lib/ld-2.13.so
f76fa000 f76fd000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f76fd000 f7701000 r-xp /usr/lib/libsys-assert.so
f779b000 f7809000 rw-p [heap]
ffcf2000 ffd13000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18770)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf76fb228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7692539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73993f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7397c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf73a3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf73a9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf73a9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf73de75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73d91f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7397c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf73a3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf73a9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf73a9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf73dbe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf73dc017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf73e3f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4d7b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4d6e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e41663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf72eefcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72f07a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7480ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf747bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf747c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf747c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf76b4183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76b47fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76fb5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf754885c) [/lib/libc.so.6] + 0x1785c
29: (0xf76faf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
11
06-07 17:15:28.131+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:126,-0.140000,0.140000,0.070000
06-07 17:15:28.131+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:135,0.313460,-0.088534,9.894321
06-07 17:15:28.131+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.141+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.141+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:148,0.003824,0.060433,0.078853
06-07 17:15:28.141+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.151+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.151+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:159,0.314789,-0.095941,9.801126
06-07 17:15:28.181+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:15:28.191+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:15:28:189,729.000000
06-07 17:15:28.211+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:15:28.211+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:15:28.221+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.221+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:226,-0.015686,0.043299,0.045339
06-07 17:15:28.221+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:145,-0.070000,0.140000,0.070000
06-07 17:15:28.231+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:152,0.318245,-0.038285,9.879964
06-07 17:15:28.231+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.231+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.231+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.251+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:241,0.299103,-0.052642,9.846465
06-07 17:15:28.251+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.251+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:245,0.047010,0.000644,-0.007339
06-07 17:15:28.261+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.261+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:270,0.023184,-0.001617,0.066914
06-07 17:15:28.271+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.271+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:265,-0.070000,0.070000,0.070000
06-07 17:15:28.271+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:264,0.361316,-0.093320,9.793823
06-07 17:15:28.271+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.271+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.281+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:278,0.314306,-0.093964,9.801162
06-07 17:15:28.281+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.281+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.281+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:291,0.005345,-0.008613,0.088487
06-07 17:15:28.291+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:284,0.339781,-0.095713,9.868000
06-07 17:15:28.291+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.291+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:285,-0.070000,0.070000,0.140000
06-07 17:15:28.301+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.301+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.301+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:293,0.316597,-0.094096,9.801086
06-07 17:15:28.301+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:303,0.323031,-0.102891,9.889536
06-07 17:15:28.301+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:308,-0.070000,0.070000,0.070000
06-07 17:15:28.311+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.311+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:309,-0.002038,-0.020083,0.090891
06-07 17:15:28.311+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.311+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.321+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:316,0.317686,-0.094278,9.801049
06-07 17:15:28.321+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.321+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.321+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:329,0.317891,-0.094772,9.801038
06-07 17:15:28.331+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:324,-0.070000,0.070000,0.070000
06-07 17:15:28.331+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.331+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:324,0.315853,-0.114855,9.891929
06-07 17:15:28.331+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.331+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.331+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:327,-0.051596,-0.048070,0.059770
06-07 17:15:28.341+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.341+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:340,-0.070000,0.070000,0.070000
06-07 17:15:28.341+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:345,0.317199,-0.095499,9.801053
06-07 17:15:28.351+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.351+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:357,0.070000,0.070000,0.070000
06-07 17:15:28.351+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:345,0.265603,-0.143569,9.860823
06-07 17:15:28.351+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.351+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:354,0.006833,-0.000449,-0.002533
06-07 17:15:28.351+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.361+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.361+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.361+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:363,0.313805,-0.097657,9.801142
06-07 17:15:28.361+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:370,-0.028827,0.049627,0.093171
06-07 17:15:28.371+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.371+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:374,0.070000,0.070000,0.070000
06-07 17:15:28.371+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:365,0.320638,-0.098106,9.798609
06-07 17:15:28.381+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.381+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:376,0.313573,-0.097483,9.801150
06-07 17:15:28.381+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.381+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.381+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:15:28.381+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.391+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:15:28:390,729.000000
06-07 17:15:28.391+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:390,0.070000,0.140000,0.070000
06-07 17:15:28.391+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:386,0.284746,-0.047856,9.894321
06-07 17:15:28.411+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.411+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:399,-0.032051,0.056563,0.071560
06-07 17:15:28.421+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:15:28.421+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:15:28.421+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.421+0200 W/LOCATION(18770): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:15:28.421+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.421+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:395,0.312011,-0.094849,9.801227
06-07 17:15:28.431+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.431+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:433,0.070000,0.070000,0.070000
06-07 17:15:28.431+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.431+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:435,0.310421,-0.091870,9.801305
06-07 17:15:28.431+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.441+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:445,0.310304,-0.090954,9.801317
06-07 17:15:28.441+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:443,0.070000,0.070000,0.070000
06-07 17:15:28.441+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.451+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.451+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:424,0.279960,-0.038285,9.872787
06-07 17:15:28.451+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:454,0.070000,0.070000,0.070000
06-07 17:15:28.451+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.451+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:458,0.311036,-0.090975,9.801294
06-07 17:15:28.451+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.461+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:443,0.007825,0.015299,0.054731
06-07 17:15:28.461+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.461+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.471+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:467,0.309772,-0.092690,9.801318
06-07 17:15:28.471+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:464,0.070000,0.070000,0.070000
06-07 17:15:28.471+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.471+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.471+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:466,0.318245,-0.076570,9.856036
06-07 17:15:28.481+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:475,0.027084,-0.004759,0.078647
06-07 17:15:28.481+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.481+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:479,0.070000,0.070000,0.070000
06-07 17:15:28.481+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.481+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:482,0.309382,-0.094734,9.801311
06-07 17:15:28.491+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:495,0.070000,0.070000,0.070000
06-07 17:15:28.481+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:490,0.337388,-0.095713,9.879964
06-07 17:15:28.481+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.491+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.501+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.511+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.511+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:506,-0.070000,-0.070000,0.070000
06-07 17:15:28.511+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.521+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:504,-0.014326,-0.040630,0.069099
06-07 17:15:28.521+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.521+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:500,0.310234,-0.096790,9.801264
06-07 17:15:28.531+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:523,-0.070000,-0.070000,0.070000
06-07 17:15:28.531+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.531+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:521,0.296710,-0.131605,9.870394
06-07 17:15:28.531+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.531+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.541+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:539,0.311067,-0.141177,9.872787
06-07 17:15:28.541+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:530,0.001295,-0.048486,0.071468
06-07 17:15:28.541+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.551+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.551+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:539,0.311452,-0.096527,9.801228
06-07 17:15:28.551+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.551+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:542,0.070000,0.070000,0.070000
06-07 17:15:28.561+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.561+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:555,0.320638,-0.136391,9.903893
06-07 17:15:28.561+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.571+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:558,0.011256,-0.041657,0.102583
06-07 17:15:28.571+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:565,0.311315,-0.097192,9.801226
06-07 17:15:28.571+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.571+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:579,0.022368,0.008256,0.138521
06-07 17:15:28.571+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:568,0.070000,0.070000,0.070000
06-07 17:15:28.571+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.571+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:573,0.332602,-0.088534,9.939785
06-07 17:15:28.581+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.581+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.581+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:15:28.591+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:15:28:590,729.000000
06-07 17:15:28.591+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:586,0.318245,-0.114855,9.844072
06-07 17:15:28.591+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.591+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.601+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:584,-0.070000,0.070000,0.070000
06-07 17:15:28.601+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:597,0.310753,-0.094859,9.801266
06-07 17:15:28.601+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:605,0.306281,-0.052642,9.841680
06-07 17:15:28.601+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.611+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:15:28.611+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:15:28.611+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:611,0.342174,-0.064606,9.863215
06-07 17:15:28.611+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.611+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.611+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:618,0.279960,-0.114855,9.853643
06-07 17:15:28.611+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.611+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.621+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:624,0.284746,-0.083749,9.865608
06-07 17:15:28.621+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.621+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:610,0.006793,-0.018328,0.042845
06-07 17:15:28.621+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:630,0.303888,-0.138784,9.846465
06-07 17:15:28.631+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.631+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.631+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:626,-0.070000,0.070000,0.070000
06-07 17:15:28.631+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:636,0.320638,-0.131605,9.899107
06-07 17:15:28.631+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.631+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:619,0.312153,-0.093568,9.801234
06-07 17:15:28.641+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.641+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:645,0.332602,-0.131605,9.848858
06-07 17:15:28.641+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.651+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:652,0.332602,-0.090927,9.841680
06-07 17:15:28.651+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.651+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.661+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:658,0.325424,-0.090927,9.870394
06-07 17:15:28.661+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.661+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:658,-0.070000,0.070000,0.070000
06-07 17:15:28.661+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.671+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:674,0.070000,0.070000,0.070000
06-07 17:15:28.671+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.671+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:679,0.070000,0.070000,0.070000
06-07 17:15:28.671+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.671+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:642,-0.005034,0.044550,0.040454
06-07 17:15:28.681+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.681+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:685,0.070000,0.070000,0.140000
06-07 17:15:28.681+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:669,0.320638,-0.124427,9.863215
06-07 17:15:28.681+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.681+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:650,0.310485,-0.094718,9.801276
06-07 17:15:28.691+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.691+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:691,0.140000,0.070000,0.070000
06-07 17:15:28.691+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.691+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.691+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:697,0.140000,0.070000,0.070000
06-07 17:15:28.691+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:696,0.334995,-0.074178,9.860823
06-07 17:15:28.691+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.701+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:702,0.070000,0.070000,0.070000
06-07 17:15:28.701+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.711+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:689,0.031420,0.030253,0.061950
06-07 17:15:28.711+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:697,0.309276,-0.094298,9.801318
06-07 17:15:28.711+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.711+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:713,0.070000,0.070000,0.070000
06-07 17:15:28.711+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.721+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:722,-0.070000,0.070000,0.070000
06-07 17:15:28.721+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.721+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.721+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.731+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:734,-0.070000,0.070000,0.070000
06-07 17:15:28.731+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:735,0.306281,-0.110070,9.887143
06-07 17:15:28.731+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.741+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:721,-0.032193,-0.021287,0.052409
06-07 17:15:28.741+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.741+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:740,0.308569,-0.096188,9.801322
06-07 17:15:28.741+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:748,-0.070000,0.070000,0.070000
06-07 17:15:28.751+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:745,0.301496,-0.057428,9.891929
06-07 17:15:28.751+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.751+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.751+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:758,0.282353,-0.057428,9.877571
06-07 17:15:28.751+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.761+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.761+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.771+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:771,-0.070000,0.070000,0.070000
06-07 17:15:28.751+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:761,-0.025739,0.010969,0.064332
06-07 17:15:28.771+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:769,0.303888,-0.086142,9.856036
06-07 17:15:28.771+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.781+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:766,0.308656,-0.097608,9.801306
06-07 17:15:28.781+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.781+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:15:28.781+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:790,-0.070000,0.070000,0.070000
06-07 17:15:28.791+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.791+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:15:28:794,730.000000
06-07 17:15:28.791+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:784,-0.005387,-0.044485,0.045147
06-07 17:15:28.791+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.801+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.801+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.801+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:796,0.309409,-0.098984,9.801268
06-07 17:15:28.801+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:809,-0.070000,0.070000,0.070000
06-07 17:15:28.811+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:15:28.811+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:15:28.811+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.811+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:817,0.309778,-0.098269,9.801264
06-07 17:15:28.811+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:801,0.342174,-0.126820,9.858429
06-07 17:15:28.821+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.821+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.821+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:811,0.012069,-0.035417,0.097785
06-07 17:15:28.821+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.821+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:828,-0.070000,0.070000,0.070000
06-07 17:15:28.831+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.831+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:826,0.325424,-0.129212,9.891929
06-07 17:15:28.841+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.841+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:833,0.023946,-0.033998,0.047552
06-07 17:15:28.841+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.841+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:849,0.332602,-0.143569,9.848858
06-07 17:15:28.841+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:849,-0.070000,0.070000,0.070000
06-07 17:15:28.851+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.851+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:838,0.309757,-0.097570,9.801271
06-07 17:15:28.851+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.861+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.861+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.861+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:856,0.023193,0.008056,0.040412
06-07 17:15:28.861+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:869,-0.070000,0.070000,0.070000
06-07 17:15:28.861+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:864,0.309827,-0.098619,9.801258
06-07 17:15:28.871+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.871+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:876,0.015646,0.007342,0.069130
06-07 17:15:28.871+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:872,0.315853,-0.129212,9.894321
06-07 17:15:28.881+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.881+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.881+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:888,0.070000,0.070000,0.070000
06-07 17:15:28.881+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.881+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.891+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:898,0.330210,-0.138784,9.877571
06-07 17:15:28.891+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:886,0.310462,-0.097284,9.801251
06-07 17:15:28.901+0200 I/servicemanager(17973): es.ugr.frailty.accelerometer alive timeout
06-07 17:15:28.901+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:15:28.901+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.901+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:28.901+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:910,0.310209,-0.097979,9.801252
06-07 17:15:28.901+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:15:28.911+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:15:28.911+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:903,0.010881,-0.026857,0.061944
06-07 17:15:28.911+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.911+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.921+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.921+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18800
06-07 17:15:28.921+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18800)
06-07 17:15:28.921+0200 I/servicemanager(17973): es.ugr.frailty.accelerometer launch request sent!
06-07 17:15:28.921+0200 I/servicemanager(17973): App control destroyed.
06-07 17:15:28.921+0200 I/servicemanager(17973): es.ugr.frailty.gyroscope alive timeout
06-07 17:15:28.921+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:15:28.931+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:15:28.931+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:15:28.931+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:922,0.279960,-0.090927,9.848858
06-07 17:15:28.931+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.931+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:925,0.025168,0.024442,0.059565
06-07 17:15:28.941+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.941+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:930,0.309886,-0.096113,9.801281
06-07 17:15:28.941+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18781
06-07 17:15:28.941+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.941+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18781)
06-07 17:15:28.941+0200 I/servicemanager(17973): es.ugr.frailty.gyroscope launch request sent!
06-07 17:15:28.951+0200 I/servicemanager(17973): App control destroyed.
06-07 17:15:28.951+0200 I/servicemanager(17973): es.ugr.frailty.heartrate alive timeout
06-07 17:15:28.951+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:15:28.951+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:15:28.951+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:15:28.951+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:945,0.306281,-0.052642,9.887143
06-07 17:15:28.961+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:950,-0.004181,-0.012786,0.085892
06-07 17:15:28.961+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18034
06-07 17:15:28.961+0200 W/CAPI_APPFW_APP_CONTROL(18034): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:15:28.961+0200 I/utils   (18034): specific action
06-07 17:15:28.961+0200 W/CAPI_APPFW_APP_CONTROL(18800): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:15:28.961+0200 I/utils   (18800): specific action
06-07 17:15:28.961+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:28.961+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:28.961+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:15:28.961+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(18800), cmd(0)
06-07 17:15:28.961+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:15:28.961+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(18034), cmd(0)
06-07 17:15:28.971+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18034)
06-07 17:15:28.971+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:955,0.308773,-0.094323,9.801334
06-07 17:15:28.971+0200 I/servicemanager(17973): es.ugr.frailty.heartrate launch request sent!
06-07 17:15:28.971+0200 I/servicemanager(17973): App control destroyed.
06-07 17:15:28.971+0200 I/servicemanager(17973): es.ugr.frailty.location alive timeout
06-07 17:15:28.971+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:15:28.971+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:15:28.971+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:28.971+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:15:28.981+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:15:28.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18770
06-07 17:15:28.991+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:15:28:990,732.000000
06-07 17:15:28.991+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18770)
06-07 17:15:28.991+0200 I/servicemanager(17973): es.ugr.frailty.location launch request sent!
06-07 17:15:28.991+0200 I/servicemanager(17973): App control destroyed.
06-07 17:15:28.991+0200 I/servicemanager(17973): es.ugr.frailty.linearacceleration alive timeout
06-07 17:15:28.991+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:15:28.991+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:15:28.991+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:15:28.991+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:28:973,0.299103,-0.040678,9.834501
06-07 17:15:29.001+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:28:910,-0.070000,0.070000,0.070000
06-07 17:15:29.001+0200 W/CAPI_APPFW_APP_CONTROL(18781): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:15:29.001+0200 I/utils   (18781): specific action
06-07 17:15:29.001+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:29.001+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18828
06-07 17:15:29.011+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:15:29.011+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(18781), cmd(0)
06-07 17:15:29.011+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:15:29.011+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:15:29.011+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:29.011+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18828)
06-07 17:15:29.011+0200 I/servicemanager(17973): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:15:29.011+0200 I/servicemanager(17973): App control destroyed.
06-07 17:15:29.011+0200 I/servicemanager(17973): es.ugr.frailty.gravity alive timeout
06-07 17:15:29.011+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:15:29.011+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:15:29.011+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:15:29.021+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:29:8,0.070000,0.070000,0.070000
06-07 17:15:29.021+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:29.021+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:29:26,0.070000,0.070000,0.070000
06-07 17:15:29.021+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:29.031+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:29:32,0.070000,0.070000,0.070000
06-07 17:15:29.031+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18805
06-07 17:15:29.031+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:29.031+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:29:37,0.070000,0.070000,0.070000
06-07 17:15:29.031+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:29.031+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18805)
06-07 17:15:29.041+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:29:42,0.070000,0.070000,0.140000
06-07 17:15:29.041+0200 I/servicemanager(17973): es.ugr.frailty.gravity launch request sent!
06-07 17:15:29.041+0200 I/servicemanager(17973): App control destroyed.
06-07 17:15:29.041+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:29.041+0200 I/servicemanager(17973): es.ugr.frailty.pressure alive timeout
06-07 17:15:29.041+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:15:29.041+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:15:29.041+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:29:47,0.070000,0.070000,0.070000
06-07 17:15:29.041+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:15:29.041+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:29.051+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18075
06-07 17:15:29.061+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:15:29.061+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(18075), cmd(0)
06-07 17:15:29.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:15:29.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:15:29.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:15:29.061+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:29:52,0.070000,0.070000,0.070000
06-07 17:15:29.061+0200 W/CAPI_APPFW_APP_CONTROL(18075): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:15:29.061+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:29.061+0200 I/utils   (18075): specific action
06-07 17:15:29.061+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18075)
06-07 17:15:29.061+0200 I/servicemanager(17973): es.ugr.frailty.pressure launch request sent!
06-07 17:15:29.061+0200 I/servicemanager(17973): App control destroyed.
06-07 17:15:29.061+0200 I/servicemanager(17973): es.ugr.frailty.light alive timeout
06-07 17:15:29.061+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:15:29.071+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:15:29.071+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:15:29.071+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:29:74,0.070000,0.070000,0.070000
06-07 17:15:29.081+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:29.081+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18079
06-07 17:15:29.081+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:29:89,-0.070000,0.070000,0.070000
06-07 17:15:29.081+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18079)
06-07 17:15:29.081+0200 I/servicemanager(17973): es.ugr.frailty.light launch request sent!
06-07 17:15:29.081+0200 I/servicemanager(17973): App control destroyed.
06-07 17:15:29.081+0200 I/servicemanager(17973): es.ugr.frailty.pedometer alive timeout
06-07 17:15:29.081+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:15:29.081+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:15:29.081+0200 W/CAPI_APPFW_APP_CONTROL(18079): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:15:29.081+0200 I/utils   (18079): specific action
06-07 17:15:29.091+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:28:977,-0.008713,0.040551,0.090676
06-07 17:15:29.091+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:29.091+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:15:29.091+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:28:982,0.308563,-0.094040,9.801343
06-07 17:15:29.091+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:29.101+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18111
06-07 17:15:29.101+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:29:107,0.308674,-0.064606,9.877571
06-07 17:15:29.101+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:15:29.101+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(18079), cmd(0)
06-07 17:15:29.101+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:29.111+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:29:96,-0.027533,0.038685,0.076290
06-07 17:15:29.111+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:29.111+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:15:29.111+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(18111), cmd(0)
06-07 17:15:29.111+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18111)
06-07 17:15:29.111+0200 I/servicemanager(17973): es.ugr.frailty.pedometer launch request sent!
06-07 17:15:29.111+0200 I/servicemanager(17973): App control destroyed.
06-07 17:15:29.111+0200 W/CAPI_APPFW_APP_CONTROL(18111): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:15:29.111+0200 I/utils   (18111): specific action
06-07 17:15:29.121+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:29:100,0.310269,-0.095657,9.801273
06-07 17:15:29.121+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:29.121+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:29.121+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:29:117,-0.004885,0.008181,0.054702
06-07 17:15:29.121+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:29.131+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:29:130,-0.070000,0.070000,0.070000
06-07 17:15:29.141+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:29.141+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:29:147,-0.070000,0.070000,0.070000
06-07 17:15:29.151+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:29.161+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:29:113,0.289532,-0.059821,9.884750
06-07 17:15:29.161+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:29.161+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:29:163,-0.070000,0.070000,0.070000
06-07 17:15:29.171+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:29.171+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:29:126,0.311004,-0.097298,9.801234
06-07 17:15:29.171+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:29.181+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11187706c6f63152838452
