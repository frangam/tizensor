S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 16267
Date: 2018-06-07 17:07:27+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf74aa52d, r5   = 0xf7d3cf98
r6   = 0xffa2a5a0, r7   = 0xffa2a450
r8   = 0xf7d39c18, r9   = 0x00000000
r10  = 0xffa2a52c, fp   = 0xffa2a5a0
ip   = 0x00000001, sp   = 0xffa2a428
lr   = 0xf74aa539, pc   = 0xf7513228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     68244 KB
Buffers:      8400 KB
Cached:      54664 KB
VmPeak:      53576 KB
VmSize:      53572 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11996 KB
VmRSS:       11996 KB
VmData:      11300 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 16267 TID = 16267
16267 16276 

Maps Information
f4375000 f4b74000 rw-p [stack:16276]
f4b7b000 f4b7d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b85000 f4b89000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b92000 f4b94000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b9c000 f4b9f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4bae000 f4bb3000 r-xp /usr/lib/libsystem.so.0.0.0
f4bbe000 f4bc1000 r-xp /lib/libattr.so.1.1.0
f4bc9000 f4bd9000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4be1000 f4bea000 r-xp /usr/lib/libedbus.so.1.7.99
f4bf2000 f4bf3000 r-xp /usr/lib/libresponse.so.0.2.96
f4bfc000 f4c01000 r-xp /usr/lib/libproc-stat.so.0.2.96
f64a3000 f65a9000 r-xp /usr/lib/libicuuc.so.57.1
f65bf000 f6747000 r-xp /usr/lib/libicui18n.so.57.1
f6757000 f6764000 r-xp /usr/lib/libail.so.0.1.0
f676d000 f6774000 r-xp /usr/lib/libminizip.so.1.0.0
f677d000 f6926000 r-xp /usr/lib/libcrypto.so.1.0.0
f6946000 f698d000 r-xp /usr/lib/libssl.so.1.0.0
f6999000 f699b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f69a3000 f69aa000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f69b3000 f69ba000 r-xp /lib/libcrypt-2.13.so
f69eb000 f69ee000 r-xp /lib/libcap.so.2.21
f69f6000 f69f8000 r-xp /usr/lib/libiri.so
f6a00000 f6a49000 r-xp /usr/lib/libmdm.so.1.2.69
f6a51000 f6a57000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a5f000 f6a82000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a8c000 f6a8e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a96000 f6ab3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6abc000 f6ac0000 r-xp /usr/lib/libsmack.so.1.0.0
f6ac9000 f6ae2000 r-xp /usr/lib/libnetwork.so.0.0.0
f6aeb000 f6af3000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6afb000 f6b01000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b0a000 f6b0c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b15000 f6b25000 r-xp /lib/libresolv-2.13.so
f6b29000 f6b41000 r-xp /usr/lib/liblzma.so.5.0.3
f6b4a000 f6b4c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b54000 f6b6e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b76000 f6ba5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bae000 f6bbd000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6bc7000 f6bd1000 r-xp /usr/lib/libsensord-shared.so
f6bda000 f6cad000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6cb8000 f6cce000 r-xp /lib/libz.so.1.2.5
f6cd6000 f6cdb000 r-xp /usr/lib/libffi.so.5.0.10
f6ce3000 f6ce4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6cec000 f6cfc000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d04000 f6d1d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d25000 f6d27000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d2f000 f6da4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6dae000 f6db4000 r-xp /lib/librt-2.13.so
f6dbd000 f6ddb000 r-xp /usr/lib/libsystemd.so.0.4.0
f6de5000 f6de6000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6dee000 f6e11000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e19000 f6e1e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e26000 f6e50000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e59000 f6e70000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e78000 f6ee1000 r-xp /lib/libm-2.13.so
f6eea000 f6f7e000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f91000 f6f96000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f9e000 f6fa5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6fad000 f6fd7000 r-xp /usr/lib/libsensor.so.1.9.6
f6fe0000 f70ac000 r-xp /usr/lib/libxml2.so.2.7.8
f70b9000 f70bb000 r-xp /usr/lib/libiniparser.so.0
f70c4000 f70ca000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f70d3000 f71a3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71a4000 f71d8000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f71e1000 f721d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7225000 f7228000 r-xp /usr/lib/libbundle.so.0.1.22
f7230000 f7236000 r-xp /usr/lib/libappsvc.so.0.1.0
f723e000 f727f000 r-xp /usr/lib/libeina.so.1.7.99
f7288000 f729f000 r-xp /usr/lib/libecore.so.1.7.99
f72b6000 f72bf000 r-xp /usr/lib/libvconf.so.0.2.45
f72c7000 f72db000 r-xp /lib/libpthread-2.13.so
f72e6000 f72f3000 r-xp /usr/lib/libaul.so.0.1.0
f72fd000 f72ff000 r-xp /lib/libdl-2.13.so
f7308000 f7313000 r-xp /lib/libunwind.so.8.0.1
f7340000 f7348000 r-xp /lib/libgcc_s-4.6.so.1
f7349000 f746d000 r-xp /lib/libc-2.13.so
f747b000 f747d000 r-xp /usr/lib/libdlog.so.0.0.0
f7485000 f7491000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f749a000 f749f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74a7000 f74b6000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f74be000 f74c2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74cb000 f74ce000 r-xp /usr/lib/libappcore-agent.so.1.1
f74d6000 f74d8000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f74e0000 f74e4000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f74ec000 f7509000 r-xp /lib/ld-2.13.so
f7512000 f7515000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7515000 f7519000 r-xp /usr/lib/libsys-assert.so
f7d09000 f7d97000 rw-p [heap]
ffa0b000 ffa2c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16267)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7513228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf74aa539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71b13f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf71afc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf71bbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf71c1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf71c1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf71f675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71f11f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf71afc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf71bbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf71c1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf71c1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf71f3e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf71f4017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf71fbf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b931fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b86171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c59663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7106fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71087a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7298ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7293b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72945a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7294879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf74cc183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74cc7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75135c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf736085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7512f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
77304,0.203196
06-07 17:07:26.971+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:26:980,8.839087,4.285545,0.136391
06-07 17:07:26.981+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:26:945,-0.700000,-1.750000,-0.630000
06-07 17:07:26.981+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.001+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.001+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:26:975,-0.069738,0.174754,-0.046658
06-07 17:07:27.011+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.011+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:3,0.980000,-0.350000,-1.050000
06-07 17:07:27.011+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.021+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:15,8.849339,4.220937,0.208027
06-07 17:07:27.021+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.021+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:24,-0.057767,0.141682,0.093380
06-07 17:07:27.021+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.021+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:17,8.786445,4.374080,0.143569
06-07 17:07:27.031+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.031+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:31,-0.097101,0.118827,0.035654
06-07 17:07:27.031+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.041+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.041+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:43,-0.119298,0.129831,-0.023843
06-07 17:07:27.041+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.041+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:28,0.210000,-0.980000,-0.070000
06-07 17:07:27.051+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.051+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:50,8.750552,4.414758,0.124427
06-07 17:07:27.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:07:27.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:07:27.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:07:27.061+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:49,-0.085173,0.174067,-0.124109
06-07 17:07:27.061+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.061+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:42,8.864316,4.189693,0.201867
06-07 17:07:27.071+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.071+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:71,-0.075541,0.382045,-0.015863
06-07 17:07:27.071+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:65,-1.400000,-2.520000,1.050000
06-07 17:07:27.071+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.081+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:84,-0.142073,0.408543,0.024292
06-07 17:07:27.081+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.081+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:91,8.793623,4.366901,0.145962
06-07 17:07:27.091+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.091+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:07:27.091+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.101+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:105,-0.176500,0.342554,-0.071600
06-07 17:07:27.101+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:07:27:105,280.000000
06-07 17:07:27.101+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:85,8.859672,4.199692,0.197967
06-07 17:07:27.111+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:102,-0.770000,-1.190000,0.630000
06-07 17:07:27.111+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.111+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.121+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.131+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.141+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:128,8.829515,4.283153,0.279960
06-07 17:07:27.141+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:121,8.863361,4.192148,0.192620
06-07 17:07:27.141+0200 W/LOCATION(16267): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:07:27.141+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:07:27.151+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:143,-0.169511,0.323840,-0.122937
06-07 17:07:27.151+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.151+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:07:27:153,80
06-07 17:07:27.161+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:161,-0.167354,0.367410,-0.112373
06-07 17:07:27.161+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.161+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:170,-0.176723,0.398921,0.036341
06-07 17:07:27.171+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.171+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.171+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:135,-1.610000,-1.610000,0.420000
06-07 17:07:27.171+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:179,8.887282,4.141470,0.186580
06-07 17:07:27.181+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.181+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.181+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:192,-2.030000,-2.730000,0.210000
06-07 17:07:27.191+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:185,8.798409,4.242475,0.224925
06-07 17:07:27.191+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:186,-0.213140,0.328274,-0.146168
06-07 17:07:27.201+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.201+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.201+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.201+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.201+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:206,-0.116006,0.416968,0.064282
06-07 17:07:27.211+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:210,8.791230,4.220939,0.165105
06-07 17:07:27.211+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:205,8.895510,4.123648,0.189271
06-07 17:07:27.211+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.221+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.221+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:213,-0.910000,-1.260000,-1.190000
06-07 17:07:27.221+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.231+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.231+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:226,-0.253778,0.427397,-0.062920
06-07 17:07:27.231+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:239,0.630000,-0.420000,-0.910000
06-07 17:07:27.241+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.241+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:232,8.910528,4.091108,0.188948
06-07 17:07:27.241+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.241+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:236,8.851050,4.208975,0.059821
06-07 17:07:27.251+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.251+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:246,-0.094081,0.344400,0.045842
06-07 17:07:27.251+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.261+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.261+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:265,-0.070000,-0.560000,-0.420000
06-07 17:07:27.261+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:256,8.936223,4.034908,0.183930
06-07 17:07:27.271+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.271+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:262,8.872586,4.390830,0.160319
06-07 17:07:27.271+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:269,-0.086871,0.201475,0.103029
06-07 17:07:27.271+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.271+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.281+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.291+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:286,-0.184556,0.499674,0.068161
06-07 17:07:27.291+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:285,8.948128,4.008785,0.176182
06-07 17:07:27.291+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:291,8.800802,4.429115,0.198604
06-07 17:07:27.291+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:288,-2.450000,-2.170000,0.280000
06-07 17:07:27.291+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:07:27.291+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.301+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:07:27:305,281.000000
06-07 17:07:27.301+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:304,-0.216893,0.464886,-0.034868
06-07 17:07:27.311+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.311+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.311+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.321+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.321+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:322,-1.820000,-1.750000,0.490000
06-07 17:07:27.321+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:318,8.942875,4.020572,0.174313
06-07 17:07:27.331+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:325,8.762517,4.371687,0.102891
06-07 17:07:27.331+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:326,-0.127071,0.293011,0.016793
06-07 17:07:27.331+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.331+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.331+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.341+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:07:27.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:07:27.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:07:27.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:07:27.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:07:27.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:07:27.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:07:27.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:07:27.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:07:27.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:07:27.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:07:27.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:07:27.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391247353,000000, pattern:[H:mm][0;m
06-07 17:07:27.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:07:27.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:07:27.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:07:27.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:07:27.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:07:27.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:07][0;m
06-07 17:07:27.351+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:347,-0.143475,0.243622,0.027789
06-07 17:07:27.351+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:07:27.351+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:07:27:360,80
06-07 17:07:27.361+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.371+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:344,8.939017,4.029133,0.174492
06-07 17:07:27.371+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:342,-2.660000,-0.630000,0.280000
06-07 17:07:27.371+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.371+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.381+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:349,8.791230,4.304688,0.045464
06-07 17:07:27.381+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:370,-0.156380,0.281668,-0.014416
06-07 17:07:27.381+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.391+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:386,-4.200000,-0.490000,0.350000
06-07 17:07:27.391+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:387,-0.156431,0.336195,-0.029105
06-07 17:07:27.391+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.391+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:392,8.960741,3.980848,0.168400
06-07 17:07:27.401+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.401+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:398,8.812766,4.304688,0.047856
06-07 17:07:27.401+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.411+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.411+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:407,-0.169834,0.398903,-0.026366
06-07 17:07:27.411+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:412,0.350000,-1.190000,0.630000
06-07 17:07:27.421+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.421+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.421+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:426,-0.075364,0.241698,0.102493
06-07 17:07:27.431+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:423,8.980120,3.937278,0.160229
06-07 17:07:27.431+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.431+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:426,8.815158,4.309474,0.191426
06-07 17:07:27.431+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.441+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.441+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.451+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:446,-0.155169,0.191737,-0.040748
06-07 17:07:27.451+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:443,3.360000,2.030000,-1.820000
06-07 17:07:27.461+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.461+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:452,8.991880,3.910552,0.155085
06-07 17:07:27.461+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.471+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:456,8.786445,4.220939,0.011964
06-07 17:07:27.471+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.481+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:476,0.980000,1.260000,-0.420000
06-07 17:07:27.481+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.481+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:475,-0.129835,0.347285,0.086634
06-07 17:07:27.481+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.491+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:480,8.999585,3.892666,0.158132
06-07 17:07:27.491+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:07:27.501+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:492,-0.137907,0.131318,0.015996
06-07 17:07:27.501+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.501+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:07:27:505,280.000000
06-07 17:07:27.511+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.511+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:489,8.894121,4.285545,0.212961
06-07 17:07:27.511+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.521+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.521+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:508,-0.113684,0.251324,-0.042184
06-07 17:07:27.521+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.531+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:516,-5.320000,-1.260000,0.420000
06-07 17:07:27.541+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:530,-0.148198,0.466348,-0.006636
06-07 17:07:27.541+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.541+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.541+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:529,9.010127,3.868577,0.148679
06-07 17:07:27.541+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:07:27.551+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:07:27:554,80
06-07 17:07:27.551+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:561,-3.220000,-1.540000,0.700000
06-07 17:07:27.561+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.561+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:533,8.717053,4.386044,0.090927
06-07 17:07:27.561+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.561+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:548,-0.182286,0.218480,-0.023389
06-07 17:07:27.561+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.571+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:570,8.970832,3.958647,0.153848
06-07 17:07:27.581+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.581+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:571,-0.049546,0.188517,-0.014553
06-07 17:07:27.581+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.581+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:587,-0.078246,0.232330,-0.040510
06-07 17:07:27.581+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.581+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:571,8.855836,4.350152,0.198604
06-07 17:07:27.591+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.591+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:598,8.949917,4.005751,0.152763
06-07 17:07:27.601+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:587,4.200000,0.770000,-1.330000
06-07 17:07:27.601+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.601+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.601+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:606,-0.115345,0.218170,-0.009853
06-07 17:07:27.611+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:602,8.884550,4.158726,0.258425
06-07 17:07:27.611+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.611+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.621+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.621+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:610,1.610000,0.560000,-0.280000
06-07 17:07:27.621+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.621+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:627,-0.148345,0.273516,0.014023
06-07 17:07:27.621+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:626,8.971421,3.957251,0.155396
06-07 17:07:27.641+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.641+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:629,8.803195,4.419543,0.227318
06-07 17:07:27.641+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.641+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.641+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:635,-2.240000,-0.560000,0.490000
06-07 17:07:27.641+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.651+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:647,-0.076697,0.273379,-0.001364
06-07 17:07:27.661+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.661+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:652,8.987751,3.919869,0.159158
06-07 17:07:27.661+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:655,8.738588,4.457829,0.126820
06-07 17:07:27.671+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:661,-1.260000,-0.280000,0.140000
06-07 17:07:27.671+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.671+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.671+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:670,-0.162593,0.353742,0.061341
06-07 17:07:27.681+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.681+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.681+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:688,8.810372,4.326223,0.177069
06-07 17:07:27.681+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:686,-0.189259,0.254939,-0.006388
06-07 17:07:27.691+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:695,0.700000,-0.560000,0.070000
06-07 17:07:27.691+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:685,8.955482,3.992942,0.161688
06-07 17:07:27.691+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.701+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:07:27.701+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.701+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:07:27:706,281.000000
06-07 17:07:27.701+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.701+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:705,-0.149103,0.342385,0.052013
06-07 17:07:27.711+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.711+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:717,8.937444,4.033212,0.160276
06-07 17:07:27.711+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.721+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:722,1.890000,-0.210000,-0.560000
06-07 17:07:27.731+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.731+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:721,8.800802,4.261617,0.189033
06-07 17:07:27.731+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.731+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.731+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:725,-0.181989,0.239949,-0.000759
06-07 17:07:27.741+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.741+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:746,-0.127795,0.417799,-0.040146
06-07 17:07:27.741+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:07:27.751+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:07:27:752,80
06-07 17:07:27.751+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:758,8.788837,4.297509,0.148355
06-07 17:07:27.751+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:744,8.944277,4.017995,0.161244
06-07 17:07:27.761+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.761+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:746,0.840000,-0.210000,-0.630000
06-07 17:07:27.761+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.761+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.771+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:771,-0.180048,0.423185,0.004544
06-07 17:07:27.771+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.771+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:777,8.786445,4.357330,0.131605
06-07 17:07:27.771+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.781+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:770,-1.470000,0.630000,-0.700000
06-07 17:07:27.781+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:771,8.945217,4.015841,0.162771
06-07 17:07:27.781+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.791+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.791+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:785,-0.150249,0.304358,0.028802
06-07 17:07:27.791+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.791+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.801+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:805,-0.114138,0.313265,0.025851
06-07 17:07:27.801+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:805,8.762517,4.443472,0.131605
06-07 17:07:27.811+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:803,8.942876,4.021135,0.160710
06-07 17:07:27.811+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:797,0.140000,0.770000,-0.140000
06-07 17:07:27.811+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.811+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.821+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.831+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:831,8.932351,4.044569,0.157971
06-07 17:07:27.831+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:822,-2.800000,0.210000,-0.420000
06-07 17:07:27.831+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.831+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.841+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.841+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:845,-3.570000,-2.380000,1.190000
06-07 17:07:27.841+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:847,8.848659,4.304688,0.258425
06-07 17:07:27.841+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.841+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:851,8.924023,4.062990,0.155932
06-07 17:07:27.841+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:852,8.760124,4.273581,0.122034
06-07 17:07:27.851+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:832,-0.189631,0.339409,0.025271
06-07 17:07:27.851+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.851+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.851+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.851+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:857,-0.204440,0.450839,-0.014855
06-07 17:07:27.851+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:860,1.190000,-0.980000,-0.280000
06-07 17:07:27.861+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.861+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.861+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.861+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:864,8.915293,4.081844,0.162782
06-07 17:07:27.871+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:874,-0.203135,0.461347,0.006049
06-07 17:07:27.871+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.871+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:867,8.774480,4.453043,0.248854
06-07 17:07:27.891+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.891+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:874,2.520000,0.910000,-0.210000
06-07 17:07:27.891+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.901+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:07:27.911+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.911+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:896,-0.171642,0.352231,0.016872
06-07 17:07:27.911+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:27.911+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:07:27:918,282.000000
06-07 17:07:27.911+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer alive timeout
06-07 17:07:27.911+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:07:27.911+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:07:27.921+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:07:27.921+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:916,8.764909,4.240082,0.184247
06-07 17:07:27.921+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:27.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16119
06-07 17:07:27.931+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16119)
06-07 17:07:27.931+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer launch request sent!
06-07 17:07:27.931+0200 I/servicemanager(12566): App control destroyed.
06-07 17:07:27.931+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope alive timeout
06-07 17:07:27.901+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:881,8.904315,4.105758,0.162220
06-07 17:07:27.931+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:07:27.931+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.931+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:07:27.931+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:07:27.941+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16204
06-07 17:07:27.941+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:899,-1.050000,-0.630000,0.770000
06-07 17:07:27.941+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:27.951+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:07:27.951+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:940,8.902816,4.108764,0.168251
06-07 17:07:27.951+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16204)
06-07 17:07:27.951+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope launch request sent!
06-07 17:07:27.951+0200 I/servicemanager(12566): App control destroyed.
06-07 17:07:27.951+0200 I/servicemanager(12566): es.ugr.frailty.heartrate alive timeout
06-07 17:07:27.951+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:07:27.951+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.951+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:07:27.951+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:07:27.951+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:959,8.933628,4.041400,0.166611
06-07 17:07:27.961+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:07:27:956,81
06-07 17:07:27.961+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15106
06-07 17:07:27.961+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15106)
06-07 17:07:27.961+0200 I/servicemanager(12566): es.ugr.frailty.heartrate launch request sent!
06-07 17:07:27.971+0200 I/servicemanager(12566): App control destroyed.
06-07 17:07:27.971+0200 I/servicemanager(12566): es.ugr.frailty.location alive timeout
06-07 17:07:27.971+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:07:27.971+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:07:27.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(15106), cmd(0)
06-07 17:07:27.971+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:07:27.971+0200 W/CAPI_APPFW_APP_CONTROL(15106): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:07:27.971+0200 I/utils   (15106): specific action
06-07 17:07:27.971+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:07:27.971+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:27.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16267
06-07 17:07:27.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16267)
06-07 17:07:27.981+0200 I/servicemanager(12566): es.ugr.frailty.location launch request sent!
06-07 17:07:27.981+0200 I/servicemanager(12566): App control destroyed.
06-07 17:07:27.981+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration alive timeout
06-07 17:07:27.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:07:27.981+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:27:921,-0.176187,0.295703,-0.010307
06-07 17:07:27.991+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:07:27.991+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:07:28.001+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16210
06-07 17:07:28.001+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16210)
06-07 17:07:28.001+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:07:28.001+0200 I/servicemanager(12566): App control destroyed.
06-07 17:07:28.001+0200 I/servicemanager(12566): es.ugr.frailty.gravity alive timeout
06-07 17:07:28.001+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:07:28.001+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:07:28.001+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:07:28.021+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16176
06-07 17:07:28.021+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16176)
06-07 17:07:28.021+0200 I/servicemanager(12566): es.ugr.frailty.gravity launch request sent!
06-07 17:07:28.021+0200 I/servicemanager(12566): App control destroyed.
06-07 17:07:28.021+0200 I/servicemanager(12566): es.ugr.frailty.pressure alive timeout
06-07 17:07:28.021+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:07:28.021+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:07:28.021+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:07:28.031+0200 I/gravity (16176): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:27:981,8.934643,4.039337,0.162170
06-07 17:07:28.031+0200 I/gravity (16176): es.ugr.frailty.gravity - capturing data
06-07 17:07:28.031+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12603
06-07 17:07:28.041+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:07:28.041+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(12603), cmd(0)
06-07 17:07:28.041+0200 W/CAPI_APPFW_APP_CONTROL(12603): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:07:28.041+0200 I/utils   (12603): specific action
06-07 17:07:28.041+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12603)
06-07 17:07:28.041+0200 I/servicemanager(12566): es.ugr.frailty.pressure launch request sent!
06-07 17:07:28.041+0200 I/servicemanager(12566): App control destroyed.
06-07 17:07:28.041+0200 I/servicemanager(12566): es.ugr.frailty.light alive timeout
06-07 17:07:28.041+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:07:28.041+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:07:28.041+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:07:28.041+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:27:932,8.819944,4.292724,0.124427
06-07 17:07:28.051+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14648
06-07 17:07:28.061+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:07:28.061+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(16210), cmd(0)
06-07 17:07:28.061+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14648)
06-07 17:07:28.061+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 17:07:28.061+0200 I/servicemanager(12566): App control destroyed.
06-07 17:07:28.061+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 17:07:28.061+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:07:28.061+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:07:28.061+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:07:28.071+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:07:28.071+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:07:28.071+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:07:28.071+0200 W/CAPI_APPFW_APP_CONTROL(14648): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:07:28.071+0200 I/utils   (14648): specific action
06-07 17:07:28.071+0200 W/CAPI_APPFW_APP_CONTROL(16210): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:07:28.071+0200 I/utils   (16210): specific action
06-07 17:07:28.071+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:28.071+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 17:07:28.071+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:07:28.071+0200 I/utils   (12618): specific action
06-07 17:07:28.071+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:07:28.071+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(14648), cmd(0)
06-07 17:07:28.081+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:07:28.081+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(12618), cmd(0)
06-07 17:07:28.081+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 17:07:28.081+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 17:07:28.081+0200 I/servicemanager(12566): App control destroyed.
06-07 17:07:28.081+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:28:81,-0.177269,0.397570,-0.102466
06-07 17:07:28.081+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:28.091+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:27:952,-1.470000,-1.540000,0.140000
06-07 17:07:28.091+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:28.091+0200 I/linearacceleration(16210): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:28:99,-0.149201,0.480555,-0.017735
06-07 17:07:28.101+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:07:28.101+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:07:28:106,282.000000
06-07 17:07:28.111+0200 I/accelerometer(16119): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:28.111+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11162676c6f63152838404
