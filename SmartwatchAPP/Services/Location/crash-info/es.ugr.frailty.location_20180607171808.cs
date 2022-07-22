S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 19725
Date: 2018-06-07 17:18:08+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf75d652d, r5   = 0xf7b42f98
r6   = 0xff8ea530, r7   = 0xff8ea3e0
r8   = 0xf7b3fc18, r9   = 0x00000000
r10  = 0xff8ea4bc, fp   = 0xff8ea530
ip   = 0x00000001, sp   = 0xff8ea3b8
lr   = 0xf75d6539, pc   = 0xf763f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    194932 KB
Buffers:     12464 KB
Cached:     110912 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11672 KB
VmRSS:       11672 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 19725 TID = 19725
19725 19730 

Maps Information
f44a1000 f4ca0000 rw-p [stack:19730]
f4ca7000 f4ca9000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4cb1000 f4cb5000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4cbe000 f4cc0000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4cc8000 f4ccb000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4cda000 f4cdf000 r-xp /usr/lib/libsystem.so.0.0.0
f4cea000 f4ced000 r-xp /lib/libattr.so.1.1.0
f4cf5000 f4d05000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d0d000 f4d16000 r-xp /usr/lib/libedbus.so.1.7.99
f4d1e000 f4d1f000 r-xp /usr/lib/libresponse.so.0.2.96
f4d28000 f4d2d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f65cf000 f66d5000 r-xp /usr/lib/libicuuc.so.57.1
f66eb000 f6873000 r-xp /usr/lib/libicui18n.so.57.1
f6883000 f6890000 r-xp /usr/lib/libail.so.0.1.0
f6899000 f68a0000 r-xp /usr/lib/libminizip.so.1.0.0
f68a9000 f6a52000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a72000 f6ab9000 r-xp /usr/lib/libssl.so.1.0.0
f6ac5000 f6ac7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6acf000 f6ad6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6adf000 f6ae6000 r-xp /lib/libcrypt-2.13.so
f6b17000 f6b1a000 r-xp /lib/libcap.so.2.21
f6b22000 f6b24000 r-xp /usr/lib/libiri.so
f6b2c000 f6b75000 r-xp /usr/lib/libmdm.so.1.2.69
f6b7d000 f6b83000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b8b000 f6bae000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6bb8000 f6bba000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6bc2000 f6bdf000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6be8000 f6bec000 r-xp /usr/lib/libsmack.so.1.0.0
f6bf5000 f6c0e000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c17000 f6c1f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c27000 f6c2d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c36000 f6c38000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c41000 f6c51000 r-xp /lib/libresolv-2.13.so
f6c55000 f6c6d000 r-xp /usr/lib/liblzma.so.5.0.3
f6c76000 f6c78000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c80000 f6c9a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ca2000 f6cd1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6cda000 f6ce9000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6cf3000 f6cfd000 r-xp /usr/lib/libsensord-shared.so
f6d06000 f6dd9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6de4000 f6dfa000 r-xp /lib/libz.so.1.2.5
f6e02000 f6e07000 r-xp /usr/lib/libffi.so.5.0.10
f6e0f000 f6e10000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e18000 f6e28000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e30000 f6e49000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e51000 f6e53000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e5b000 f6ed0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6eda000 f6ee0000 r-xp /lib/librt-2.13.so
f6ee9000 f6f07000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f11000 f6f12000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f1a000 f6f3d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f45000 f6f4a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f52000 f6f7c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f85000 f6f9c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6fa4000 f700d000 r-xp /lib/libm-2.13.so
f7016000 f70aa000 r-xp /usr/lib/libstdc++.so.6.0.16
f70bd000 f70c2000 r-xp /usr/lib/libctx-client.so.0.8.3
f70ca000 f70d1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70d9000 f7103000 r-xp /usr/lib/libsensor.so.1.9.6
f710c000 f71d8000 r-xp /usr/lib/libxml2.so.2.7.8
f71e5000 f71e7000 r-xp /usr/lib/libiniparser.so.0
f71f0000 f71f6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f71ff000 f72cf000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f72d0000 f7304000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f730d000 f7349000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7351000 f7354000 r-xp /usr/lib/libbundle.so.0.1.22
f735c000 f7362000 r-xp /usr/lib/libappsvc.so.0.1.0
f736a000 f73ab000 r-xp /usr/lib/libeina.so.1.7.99
f73b4000 f73cb000 r-xp /usr/lib/libecore.so.1.7.99
f73e2000 f73eb000 r-xp /usr/lib/libvconf.so.0.2.45
f73f3000 f7407000 r-xp /lib/libpthread-2.13.so
f7412000 f741f000 r-xp /usr/lib/libaul.so.0.1.0
f7429000 f742b000 r-xp /lib/libdl-2.13.so
f7434000 f743f000 r-xp /lib/libunwind.so.8.0.1
f746c000 f7474000 r-xp /lib/libgcc_s-4.6.so.1
f7475000 f7599000 r-xp /lib/libc-2.13.so
f75a7000 f75a9000 r-xp /usr/lib/libdlog.so.0.0.0
f75b1000 f75bd000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75c6000 f75cb000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75d3000 f75e2000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f75ea000 f75ee000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75f7000 f75fa000 r-xp /usr/lib/libappcore-agent.so.1.1
f7602000 f7604000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f760c000 f7610000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7618000 f7635000 r-xp /lib/ld-2.13.so
f763e000 f7641000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7641000 f7645000 r-xp /usr/lib/libsys-assert.so
f7b0f000 f7b9d000 rw-p [heap]
ff8cb000 ff8ec000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19725)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf763f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf75d6539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72dd3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf72dbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf72e7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf72edbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf72eddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf732275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf731d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf72dbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf72e7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf72edbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf72eddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf731fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7320017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7327f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4cbf1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4cb2171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d85663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7232fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72347a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf73c4ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf73bfb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73c05a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf73c0879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf75f8183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75f87fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf763f5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf748c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf763ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
5,0.038237
06-07 17:18:08.101+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.111+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:113,0.351745,-0.143569,9.875179
06-07 17:18:08.121+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:18:08.121+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:18:08.121+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:18:08.131+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.131+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.141+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:90,0.314002,-0.098913,9.801123
06-07 17:18:08.141+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.141+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:105,-0.070000,-0.070000,0.070000
06-07 17:18:08.141+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.141+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:143,0.337388,-0.098106,9.872787
06-07 17:18:08.151+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:136,-0.006883,0.009350,0.064603
06-07 17:18:08.151+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.151+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:150,0.070000,-0.070000,0.070000
06-07 17:18:08.151+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:147,0.315428,-0.098877,9.801077
06-07 17:18:08.161+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:157,0.024107,0.023098,0.050268
06-07 17:18:08.161+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.161+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.171+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.171+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.171+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:08.171+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:08.171+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:173,0.313460,-0.122034,9.851252
06-07 17:18:08.171+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.181+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:170,-0.011252,-0.006306,0.078956
06-07 17:18:08.181+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:08.191+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:08:192,937.000000
06-07 17:18:08.191+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:176,0.314572,-0.097753,9.801116
06-07 17:18:08.191+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:176,0.070000,-0.070000,0.070000
06-07 17:18:08.191+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.191+0200 W/LOCATION(19725): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:18:08.201+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:185,0.291924,-0.071785,9.824929
06-07 17:18:08.201+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.201+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:208,0.294317,-0.107677,9.858429
06-07 17:18:08.201+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.201+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.211+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:213,0.315853,-0.076570,9.863215
06-07 17:18:08.211+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.211+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:213,0.313688,-0.098325,9.801139
06-07 17:18:08.211+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.211+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:220,-0.033410,0.009093,0.074178
06-07 17:18:08.211+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:221,0.313241,-0.099010,9.801146
06-07 17:18:08.221+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:200,0.070000,0.070000,0.070000
06-07 17:18:08.221+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.221+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.221+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:227,-0.010856,0.018720,0.043038
06-07 17:18:08.221+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.221+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.231+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:232,0.313460,-0.098106,9.896714
06-07 17:18:08.231+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:233,-0.006726,0.003768,0.035797
06-07 17:18:08.231+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.231+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:241,0.015402,0.007529,0.045340
06-07 17:18:08.241+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:227,0.070000,0.070000,0.070000
06-07 17:18:08.241+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.241+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.241+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:247,0.003886,-0.023852,0.054894
06-07 17:18:08.241+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.241+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.251+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:252,0.303888,-0.071785,9.870394
06-07 17:18:08.251+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.251+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:253,-0.013139,0.001831,0.086003
06-07 17:18:08.251+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.251+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:257,0.312996,-0.097507,9.801168
06-07 17:18:08.261+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:261,-0.032340,0.026767,0.064481
06-07 17:18:08.261+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:247,0.070000,0.070000,0.070000
06-07 17:18:08.261+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.261+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.261+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.261+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.261+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:267,-0.007560,0.000146,0.052485
06-07 17:18:08.261+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.271+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:271,0.325424,-0.117248,9.856036
06-07 17:18:08.271+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:275,0.015584,0.010656,0.071563
06-07 17:18:08.271+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.271+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:270,0.314843,-0.098121,9.801104
06-07 17:18:08.281+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:281,-0.000704,-0.025323,0.035654
06-07 17:18:08.281+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:267,-0.070000,0.070000,0.070000
06-07 17:18:08.281+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.281+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.281+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.281+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:289,0.037096,-0.028373,0.085914
06-07 17:18:08.291+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.291+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:292,0.354138,-0.076570,9.824929
06-07 17:18:08.291+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.291+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:296,-0.026821,-0.034658,0.014115
06-07 17:18:08.291+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.291+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:299,0.316683,-0.098002,9.801045
06-07 17:18:08.301+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:289,0.070000,0.070000,0.070000
06-07 17:18:08.301+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:302,-0.016205,-0.031198,0.071596
06-07 17:18:08.301+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.301+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.301+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.301+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:310,0.028643,0.010945,0.097875
06-07 17:18:08.311+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.311+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:313,0.332602,-0.124427,9.877571
06-07 17:18:08.311+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.311+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:317,0.058505,0.009771,0.057173
06-07 17:18:08.311+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.311+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:321,0.315687,-0.099046,9.801067
06-07 17:18:08.311+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.321+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:323,0.019470,-0.014936,0.030869
06-07 17:18:08.321+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.321+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.321+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:330,0.012675,0.010809,0.054854
06-07 17:18:08.331+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.331+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:308,0.070000,-0.070000,0.070000
06-07 17:18:08.331+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.331+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:332,0.361316,-0.086142,9.827322
06-07 17:18:08.331+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:336,-0.011671,0.004175,0.059659
06-07 17:18:08.331+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.341+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:345,-0.007238,0.005878,0.069235
06-07 17:18:08.341+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.341+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.351+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:352,0.024625,0.015129,0.085957
06-07 17:18:08.351+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:353,0.308674,-0.153141,9.836893
06-07 17:18:08.351+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.351+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:339,0.070000,-0.070000,0.140000
06-07 17:18:08.351+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.351+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:325,0.315464,-0.098924,9.801076
06-07 17:18:08.351+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.361+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:360,0.010779,-0.004438,0.057222
06-07 17:18:08.361+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.361+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:360,-0.070000,-0.070000,0.070000
06-07 17:18:08.361+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:368,-0.014001,-0.014859,0.057241
06-07 17:18:08.361+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.361+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.371+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:373,0.301496,-0.105284,9.856036
06-07 17:18:08.371+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:08.371+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:08.371+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:376,0.007251,-0.029118,-0.000176
06-07 17:18:08.371+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.381+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:363,0.316743,-0.098038,9.801044
06-07 17:18:08.381+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.381+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:383,0.003320,0.038443,0.076371
06-07 17:18:08.381+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.381+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:08.391+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:391,-0.001856,0.008562,0.095539
06-07 17:18:08.391+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:08:392,934.000000
06-07 17:18:08.391+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.391+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.391+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:397,0.332602,-0.081356,9.827322
06-07 17:18:08.391+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.391+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:398,0.012604,-0.017437,0.050053
06-07 17:18:08.391+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.401+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:387,0.316011,-0.096973,9.801078
06-07 17:18:08.401+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:406,-0.025345,-0.003561,0.052429
06-07 17:18:08.401+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.401+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.411+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:401,-0.070000,-0.070000,0.070000
06-07 17:18:08.411+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:414,-0.008380,-0.000695,0.069178
06-07 17:18:08.411+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.411+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.411+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.421+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:420,0.015088,-0.010455,0.076291
06-07 17:18:08.421+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.421+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:414,0.327817,-0.100499,9.875179
06-07 17:18:08.421+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:427,0.042471,-0.049051,0.073863
06-07 17:18:08.421+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.431+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:422,0.070000,-0.070000,0.070000
06-07 17:18:08.431+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.431+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:425,0.313927,-0.095952,9.801154
06-07 17:18:08.431+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.431+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.431+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:434,0.028096,-0.003440,0.071472
06-07 17:18:08.431+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.441+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:442,0.002629,-0.025477,0.050004
06-07 17:18:08.441+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.441+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:448,-0.019368,0.024492,0.023694
06-07 17:18:08.441+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.451+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:438,0.275175,-0.028714,9.844072
06-07 17:18:08.451+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.451+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:455,-0.016431,-0.010527,0.057185
06-07 17:18:08.451+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.451+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:440,0.315434,-0.096258,9.801103
06-07 17:18:08.451+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.461+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:437,0.140000,0.070000,0.070000
06-07 17:18:08.461+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.461+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:462,0.006633,0.019002,0.061908
06-07 17:18:08.461+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.461+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:467,0.070000,0.070000,0.140000
06-07 17:18:08.461+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:469,0.005426,-0.002146,0.095373
06-07 17:18:08.471+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.471+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:456,0.315853,-0.076570,9.889536
06-07 17:18:08.471+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:476,-0.003731,0.022895,0.069027
06-07 17:18:08.471+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.471+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.481+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:464,0.315976,-0.096877,9.801080
06-07 17:18:08.481+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.481+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:483,0.018314,-0.022776,0.054651
06-07 17:18:08.481+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.481+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.481+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:489,0.047941,0.016450,0.023502
06-07 17:18:08.491+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.491+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:482,0.299103,-0.071785,9.834501
06-07 17:18:08.491+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:497,0.026137,-0.030620,0.076159
06-07 17:18:08.491+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.491+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.501+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:493,0.070000,0.070000,0.140000
06-07 17:18:08.501+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.501+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:503,0.053530,0.006557,0.025942
06-07 17:18:08.501+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.501+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:487,0.316172,-0.097369,9.801068
06-07 17:18:08.501+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.501+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:510,-0.000695,-0.058819,0.035578
06-07 17:18:08.511+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.511+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:516,-0.009366,-0.008894,0.054789
06-07 17:18:08.511+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.511+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:507,0.070000,0.070000,0.070000
06-07 17:18:08.511+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.511+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:521,0.021741,0.015034,0.026074
06-07 17:18:08.521+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.521+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:501,0.344566,-0.086142,9.858429
06-07 17:18:08.521+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.521+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:526,0.017872,-0.003879,0.073905
06-07 17:18:08.521+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.521+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:514,0.316298,-0.097361,9.801064
06-07 17:18:08.521+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.531+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:532,-0.035304,0.067005,0.042806
06-07 17:18:08.531+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.531+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:537,0.007492,0.015298,0.088165
06-07 17:18:08.531+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.531+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:542,-0.009258,0.020083,0.033131
06-07 17:18:08.541+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.541+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:534,0.317144,-0.098299,9.801027
06-07 17:18:08.541+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.541+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:547,0.037318,0.003672,0.057005
06-07 17:18:08.541+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:527,0.346959,-0.105284,9.863215
06-07 17:18:08.541+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.541+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.551+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:522,0.070000,-0.070000,0.070000
06-07 17:18:08.551+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.551+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:554,0.039711,-0.015470,0.061791
06-07 17:18:08.551+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.551+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:558,0.140000,-0.070000,0.070000
06-07 17:18:08.551+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.551+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:561,0.057953,-0.015975,0.076171
06-07 17:18:08.561+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.561+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:567,0.013824,-0.005318,0.049970
06-07 17:18:08.561+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:554,0.366102,-0.105284,9.877571
06-07 17:18:08.561+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.561+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:549,0.316530,-0.098129,9.801049
06-07 17:18:08.571+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.571+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:573,0.023395,-0.014889,0.028433
06-07 17:18:08.571+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:08.571+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:08.571+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.571+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:575,0.325424,-0.095713,9.851252
06-07 17:18:08.571+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.581+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:562,0.070000,-0.070000,0.070000
06-07 17:18:08.581+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.581+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:584,0.334995,-0.105284,9.829715
06-07 17:18:08.581+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.581+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:08.591+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:08:592,938.000000
06-07 17:18:08.591+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:593,-0.017442,-0.022009,0.073903
06-07 17:18:08.591+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:580,0.317950,-0.097885,9.801005
06-07 17:18:08.591+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.591+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.591+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:589,0.140000,-0.070000,0.070000
06-07 17:18:08.601+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:598,0.318067,-0.099669,9.800983
06-07 17:18:08.601+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.601+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.601+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.611+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:607,0.140000,-0.070000,0.070000
06-07 17:18:08.611+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:613,0.013253,0.002284,0.105027
06-07 17:18:08.611+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.611+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:600,0.294317,-0.112463,9.875179
06-07 17:18:08.611+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.611+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:608,0.317533,-0.098979,9.801008
06-07 17:18:08.611+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.621+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:618,0.140000,-0.070000,0.070000
06-07 17:18:08.621+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.621+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.621+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:622,0.318156,-0.097627,9.801002
06-07 17:18:08.621+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.631+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:632,0.007357,0.000369,0.030813
06-07 17:18:08.631+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:628,0.070000,-0.070000,0.070000
06-07 17:18:08.631+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.631+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:622,0.325424,-0.088534,9.906286
06-07 17:18:08.631+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.631+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:633,0.317137,-0.097683,9.801034
06-07 17:18:08.631+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.641+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:638,0.070000,0.070000,0.070000
06-07 17:18:08.641+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.641+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:641,0.318245,-0.090927,9.832108
06-07 17:18:08.641+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:647,0.070000,0.070000,0.070000
06-07 17:18:08.641+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.641+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:643,0.315400,-0.097088,9.801096
06-07 17:18:08.641+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.651+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:653,-0.026143,0.057797,0.071491
06-07 17:18:08.651+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:655,0.314807,-0.096064,9.801126
06-07 17:18:08.651+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.651+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.651+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:660,0.314359,-0.095789,9.801142
06-07 17:18:08.651+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.661+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.661+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:664,0.284746,-0.033500,9.872787
06-07 17:18:08.661+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:666,0.070000,0.070000,0.070000
06-07 17:18:08.661+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.661+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.671+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:672,0.007481,0.026487,0.040378
06-07 17:18:08.671+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:664,0.314634,-0.095151,9.801140
06-07 17:18:08.671+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.671+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.671+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:672,0.070000,-0.070000,0.070000
06-07 17:18:08.671+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.681+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:682,0.070000,-0.070000,0.140000
06-07 17:18:08.681+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.681+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:681,0.318245,-0.064606,9.841680
06-07 17:18:08.681+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.681+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:679,0.314693,-0.096159,9.801127
06-07 17:18:08.691+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.691+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:692,0.044873,0.006686,0.064231
06-07 17:18:08.691+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:690,-0.140000,-0.140000,0.070000
06-07 17:18:08.691+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.691+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.691+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:695,0.313841,-0.095859,9.801158
06-07 17:18:08.691+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.701+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:701,0.070000,-0.140000,0.070000
06-07 17:18:08.701+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.701+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.711+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:705,0.312233,-0.094405,9.801224
06-07 17:18:08.711+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.711+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:710,0.070000,-0.140000,0.070000
06-07 17:18:08.711+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.711+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:713,0.035687,-0.040236,0.035491
06-07 17:18:08.711+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:722,0.070000,-0.070000,0.070000
06-07 17:18:08.711+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:703,0.354138,-0.081356,9.865608
06-07 17:18:08.721+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:716,0.311771,-0.094318,9.801239
06-07 17:18:08.721+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.721+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:728,0.312257,-0.093661,9.801229
06-07 17:18:08.721+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.731+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.731+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.731+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.731+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:734,0.311567,-0.094555,9.801243
06-07 17:18:08.731+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.731+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:737,0.210000,-0.070000,0.070000
06-07 17:18:08.741+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.751+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:747,0.070000,-0.070000,0.070000
06-07 17:18:08.751+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.751+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:742,0.312915,-0.095622,9.801190
06-07 17:18:08.751+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.761+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:761,0.311138,-0.097087,9.801232
06-07 17:18:08.761+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.761+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:757,0.070000,-0.070000,0.070000
06-07 17:18:08.761+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.771+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:742,0.344566,-0.126820,9.836893
06-07 17:18:08.771+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:767,0.309989,-0.098306,9.801256
06-07 17:18:08.771+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:743,0.070114,-0.038261,0.054677
06-07 17:18:08.771+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:08.771+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:08.771+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:771,0.070000,-0.070000,0.070000
06-07 17:18:08.771+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.771+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.771+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.781+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:781,0.070000,-0.070000,0.140000
06-07 17:18:08.781+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.781+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:08.781+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.791+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:08:792,947.000000
06-07 17:18:08.791+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:783,0.310739,-0.097526,9.801240
06-07 17:18:08.791+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.791+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:793,0.047619,-0.041522,0.064293
06-07 17:18:08.791+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:781,0.380459,-0.124427,9.856036
06-07 17:18:08.801+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:799,0.312749,-0.096951,9.801182
06-07 17:18:08.801+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.801+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:789,0.140000,-0.070000,0.070000
06-07 17:18:08.801+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.811+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.811+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:809,0.140000,-0.070000,0.070000
06-07 17:18:08.811+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.811+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:807,0.313167,-0.097495,9.801164
06-07 17:18:08.811+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.821+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.821+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:819,0.070000,-0.070000,0.070000
06-07 17:18:08.831+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:822,0.313519,-0.096805,9.801159
06-07 17:18:08.831+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:829,0.030588,-0.025812,0.038068
06-07 17:18:08.831+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:820,0.358923,-0.129212,9.865608
06-07 17:18:08.831+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.831+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.831+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.841+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.841+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:846,0.070000,-0.070000,0.070000
06-07 17:18:08.851+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:844,-0.054720,-0.005164,0.062061
06-07 17:18:08.851+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:843,0.312763,-0.096485,9.801187
06-07 17:18:08.851+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.851+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.851+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:841,0.344566,-0.114855,9.839286
06-07 17:18:08.851+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.861+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.871+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:859,0.001211,-0.044587,0.076477
06-07 17:18:08.871+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.881+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:882,-0.050236,0.000776,0.112254
06-07 17:18:08.881+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.881+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:888,-0.004387,0.024045,0.054830
06-07 17:18:08.881+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.891+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:857,0.312252,-0.096060,9.801207
06-07 17:18:08.891+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:872,0.260818,-0.095713,9.863215
06-07 17:18:08.891+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.901+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:903,0.318245,-0.136391,9.877571
06-07 17:18:08.901+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.911+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:911,0.263210,-0.090927,9.913465
06-07 17:18:08.911+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:864,0.070000,-0.070000,0.070000
06-07 17:18:08.911+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.911+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:918,0.308674,-0.069392,9.856036
06-07 17:18:08.911+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.911+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.921+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:893,0.053900,-0.002734,0.059508
06-07 17:18:08.921+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.921+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:924,0.363709,-0.095713,9.860823
06-07 17:18:08.921+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.921+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.931+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:931,0.361316,-0.076570,9.822537
06-07 17:18:08.931+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:923,0.313104,-0.095210,9.801188
06-07 17:18:08.931+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.931+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:938,0.342174,-0.124427,9.846465
06-07 17:18:08.931+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.931+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:08:928,0.140000,-0.070000,0.140000
06-07 17:18:08.941+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.941+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:08:932,0.052064,0.015076,0.021194
06-07 17:18:08.941+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:08.941+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:945,0.346959,-0.141177,9.848858
06-07 17:18:08.941+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:08.941+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:08.951+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:08:953,0.375673,-0.114855,9.875179
06-07 17:18:08.951+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:08:947,0.313387,-0.095309,9.801178
06-07 17:18:08.951+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:08.951+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11197256c6f63152838468
