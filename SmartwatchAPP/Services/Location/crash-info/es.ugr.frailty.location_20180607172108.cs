S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20289
Date: 2018-06-07 17:21:08+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf745052d, r5   = 0xf7a21f98
r6   = 0xffcc7510, r7   = 0xffcc73c0
r8   = 0xf7a1ec18, r9   = 0x00000000
r10  = 0xffcc749c, fp   = 0xffcc7510
ip   = 0x00000001, sp   = 0xffcc7398
lr   = 0xf7450539, pc   = 0xf74b9228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     45684 KB
Buffers:      7640 KB
Cached:      53756 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11744 KB
VmRSS:       11744 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20289 TID = 20289
20289 20310 

Maps Information
f431b000 f4b1a000 rw-p [stack:20310]
f4b21000 f4b23000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b2b000 f4b2f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b38000 f4b3a000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b42000 f4b45000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b54000 f4b59000 r-xp /usr/lib/libsystem.so.0.0.0
f4b64000 f4b67000 r-xp /lib/libattr.so.1.1.0
f4b6f000 f4b7f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b87000 f4b90000 r-xp /usr/lib/libedbus.so.1.7.99
f4b98000 f4b99000 r-xp /usr/lib/libresponse.so.0.2.96
f4ba2000 f4ba7000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6449000 f654f000 r-xp /usr/lib/libicuuc.so.57.1
f6565000 f66ed000 r-xp /usr/lib/libicui18n.so.57.1
f66fd000 f670a000 r-xp /usr/lib/libail.so.0.1.0
f6713000 f671a000 r-xp /usr/lib/libminizip.so.1.0.0
f6723000 f68cc000 r-xp /usr/lib/libcrypto.so.1.0.0
f68ec000 f6933000 r-xp /usr/lib/libssl.so.1.0.0
f693f000 f6941000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6949000 f6950000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6959000 f6960000 r-xp /lib/libcrypt-2.13.so
f6991000 f6994000 r-xp /lib/libcap.so.2.21
f699c000 f699e000 r-xp /usr/lib/libiri.so
f69a6000 f69ef000 r-xp /usr/lib/libmdm.so.1.2.69
f69f7000 f69fd000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a05000 f6a28000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a32000 f6a34000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a3c000 f6a59000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a62000 f6a66000 r-xp /usr/lib/libsmack.so.1.0.0
f6a6f000 f6a88000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a91000 f6a99000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6aa1000 f6aa7000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6ab0000 f6ab2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6abb000 f6acb000 r-xp /lib/libresolv-2.13.so
f6acf000 f6ae7000 r-xp /usr/lib/liblzma.so.5.0.3
f6af0000 f6af2000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6afa000 f6b14000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b1c000 f6b4b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b54000 f6b63000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b6d000 f6b77000 r-xp /usr/lib/libsensord-shared.so
f6b80000 f6c53000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c5e000 f6c74000 r-xp /lib/libz.so.1.2.5
f6c7c000 f6c81000 r-xp /usr/lib/libffi.so.5.0.10
f6c89000 f6c8a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c92000 f6ca2000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6caa000 f6cc3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6ccb000 f6ccd000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6cd5000 f6d4a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d54000 f6d5a000 r-xp /lib/librt-2.13.so
f6d63000 f6d81000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d8b000 f6d8c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d94000 f6db7000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6dbf000 f6dc4000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6dcc000 f6df6000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6dff000 f6e16000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e1e000 f6e87000 r-xp /lib/libm-2.13.so
f6e90000 f6f24000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f37000 f6f3c000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f44000 f6f4b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f53000 f6f7d000 r-xp /usr/lib/libsensor.so.1.9.6
f6f86000 f7052000 r-xp /usr/lib/libxml2.so.2.7.8
f705f000 f7061000 r-xp /usr/lib/libiniparser.so.0
f706a000 f7070000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7079000 f7149000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f714a000 f717e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7187000 f71c3000 r-xp /usr/lib/libSLP-location.so.0.9.24
f71cb000 f71ce000 r-xp /usr/lib/libbundle.so.0.1.22
f71d6000 f71dc000 r-xp /usr/lib/libappsvc.so.0.1.0
f71e4000 f7225000 r-xp /usr/lib/libeina.so.1.7.99
f722e000 f7245000 r-xp /usr/lib/libecore.so.1.7.99
f725c000 f7265000 r-xp /usr/lib/libvconf.so.0.2.45
f726d000 f7281000 r-xp /lib/libpthread-2.13.so
f728c000 f7299000 r-xp /usr/lib/libaul.so.0.1.0
f72a3000 f72a5000 r-xp /lib/libdl-2.13.so
f72ae000 f72b9000 r-xp /lib/libunwind.so.8.0.1
f72e6000 f72ee000 r-xp /lib/libgcc_s-4.6.so.1
f72ef000 f7413000 r-xp /lib/libc-2.13.so
f7421000 f7423000 r-xp /usr/lib/libdlog.so.0.0.0
f742b000 f7437000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7440000 f7445000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f744d000 f745c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7464000 f7468000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7471000 f7474000 r-xp /usr/lib/libappcore-agent.so.1.1
f747c000 f747e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7486000 f748a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7492000 f74af000 r-xp /lib/ld-2.13.so
f74b8000 f74bb000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f74bb000 f74bf000 r-xp /usr/lib/libsys-assert.so
f79ee000 f7a5f000 rw-p [heap]
ffca8000 ffcc9000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20289)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf74b9228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7450539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71573f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7155c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7161e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7167be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7167dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf719c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71971f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7155c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7161e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7167be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7167dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7199e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf719a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf71a1f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b391fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b2c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6bff663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf70acfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70ae7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf723eca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7239b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf723a5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf723a879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7472183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74727fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74b95c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf730685c) [/lib/libc.so.6] + 0x1785c
29: (0xf74b8f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
e - capturing data
06-07 17:22:23.901+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:23.911+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:23:915,0.070000,-0.070000,0.070000
06-07 17:22:23.921+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:23:915,-0.006337,-0.013844,0.011522
06-07 17:22:23.931+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:23:910,0.306281,-0.119641,9.774680
06-07 17:22:23.931+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:23:924,0.316512,-0.098639,9.801044
06-07 17:22:23.941+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:23.941+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:23.941+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:23.941+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:23.941+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:22:23.941+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:22:23.941+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:23:951,0.289532,-0.069392,9.858429
06-07 17:22:23.961+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:22:23.961+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:22:23:966,757.000000
06-07 17:22:23.971+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:23:956,0.070000,-0.070000,0.140000
06-07 17:22:23.981+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:23:986,0.317216,-0.097054,9.801038
06-07 17:22:23.981+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:23.991+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:23:957,0.001068,-0.001091,-0.000441
06-07 17:22:23.991+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:24.001+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:24.001+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:24:8,0.027255,0.011056,0.021101
06-07 17:22:24.011+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:24.021+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:24:7,0.070000,-0.070000,0.070000
06-07 17:22:24.021+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:24:5,0.287139,-0.062213,9.784252
06-07 17:22:24.031+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:24:20,0.317387,-0.096693,9.801036
06-07 17:22:24.031+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:24.031+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:24.031+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:24.041+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:24.071+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:24:55,0.330210,-0.093320,9.820145
06-07 17:22:24.071+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:24:58,0.070000,-0.070000,0.070000
06-07 17:22:24.081+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:24:51,-0.033836,-0.018044,0.021136
06-07 17:22:24.081+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:24.081+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:24:61,0.317182,-0.095201,9.801057
06-07 17:22:24.091+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:24.091+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:24.091+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:24.111+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:24:101,-0.007522,0.030376,0.049782
06-07 17:22:24.121+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:24:98,0.140000,0.070000,0.070000
06-07 17:22:24.121+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:24.121+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:24:103,0.334995,-0.129212,9.832108
06-07 17:22:24.131+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:24:105,0.316791,-0.095719,9.801064
06-07 17:22:24.131+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:24.131+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:24.141+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:22:24.141+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:22:24.141+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:24.141+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:22:24.141+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:22:24.141+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:22:24.151+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:24:154,0.311067,-0.129212,9.827322
06-07 17:22:24.161+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:22:24.161+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:22:24:171,757.000000
06-07 17:22:24.171+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:24:144,0.140000,0.070000,0.070000
06-07 17:22:24.171+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:24:152,0.317852,-0.097312,9.801015
06-07 17:22:24.181+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:24.181+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:24:147,0.048538,-0.019295,0.023411
06-07 17:22:24.181+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:24.191+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:24.201+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:24.221+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:24:207,0.317783,-0.097060,9.801020
06-07 17:22:24.221+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:24:204,0.070085,-0.025444,-0.041111
06-07 17:22:24.221+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:24:202,0.140000,0.070000,0.140000
06-07 17:22:24.231+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:24.221+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:24:218,0.327817,-0.083749,9.891929
06-07 17:22:24.231+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:24.241+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(20297) cmd(0)
06-07 17:22:24.241+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:24.241+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:24:252,0.004837,-0.014819,0.011636
06-07 17:22:24.251+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:24.261+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:24:264,0.316626,-0.097536,9.801052
06-07 17:22:24.271+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:24:251,0.140000,0.070000,0.140000
06-07 17:22:24.271+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:24.271+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:24:265,0.334995,-0.105284,9.848858
06-07 17:22:24.281+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:24.291+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:24.291+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:24.301+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:24:305,0.315792,-0.095525,9.801099
06-07 17:22:24.321+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:24:300,0.140000,0.140000,0.070000
06-07 17:22:24.321+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:24:298,0.011696,0.024293,0.114545
06-07 17:22:24.321+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:24:309,0.315853,-0.105284,9.803394
06-07 17:22:24.321+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:24.321+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:24.331+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:24.341+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:24.341+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:24:342,-0.003107,-0.003095,-0.017056
06-07 17:22:24.341+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:22:24.341+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:22:24.351+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:22:24.361+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:22:24:364,757.000000
06-07 17:22:24.371+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:24:345,0.070000,0.140000,0.070000
06-07 17:22:24.371+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:24:356,0.289532,-0.071785,9.829715
06-07 17:22:24.381+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:24:349,0.314495,-0.093851,9.801157
06-07 17:22:24.381+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:24.381+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:24.391+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:24.391+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:24.401+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:24:393,-0.015035,-0.007593,0.088230
06-07 17:22:24.401+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:24:404,0.315388,-0.092743,9.801138
06-07 17:22:24.411+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(20375) cmd(0)
06-07 17:22:24.421+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:24:396,0.070000,0.070000,0.070000
06-07 17:22:24.431+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:24.431+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:24.441+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:24:424,0.301496,-0.066999,9.829715
06-07 17:22:24.441+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:24.451+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:24.461+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:24:439,0.024764,0.009159,-0.038637
06-07 17:22:24.471+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:24:452,0.070000,0.070000,0.070000
06-07 17:22:24.471+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:24:453,0.317448,-0.090768,9.801090
06-07 17:22:24.471+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:24.471+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:24:463,0.325424,-0.088534,9.834501
06-07 17:22:24.471+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:24.491+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:24.501+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:24:500,0.070000,0.070000,0.070000
06-07 17:22:24.501+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:24.511+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:24:495,0.009644,0.054048,0.018809
06-07 17:22:24.521+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:24:501,0.317037,-0.090639,9.801105
06-07 17:22:24.521+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:24.521+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:24.521+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:24:515,0.296710,-0.095713,9.839286
06-07 17:22:24.521+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:24.541+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:24.541+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:22:24.541+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:22:24.551+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:22:24.571+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:22:24:566,758.000000
06-07 17:22:24.571+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:24:537,0.070000,0.070000,0.070000
06-07 17:22:24.571+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:24:533,0.045525,0.008214,0.045104
06-07 17:22:24.571+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:24:538,0.317825,-0.090874,9.801077
06-07 17:22:24.571+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:24.571+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:24.581+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:24.581+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:24:587,0.043989,0.007667,0.028397
06-07 17:22:24.591+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:24:557,0.296710,-0.145962,9.815358
06-07 17:22:24.601+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:24.601+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:24:595,0.316604,-0.091591,9.801110
06-07 17:22:24.621+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:24.621+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:24:596,0.070000,0.070000,0.070000
06-07 17:22:24.621+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:24.621+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:24.631+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:24:613,0.325424,-0.107677,9.801002
06-07 17:22:24.641+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:24:640,0.140000,0.140000,0.070000
06-07 17:22:24.651+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:24.651+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:24:637,0.316209,-0.093560,9.801105
06-07 17:22:24.651+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:24:632,-0.029291,0.011937,-0.026595
06-07 17:22:24.661+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:24.661+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:24.661+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:24.681+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:24:657,0.313460,-0.057428,9.839286
06-07 17:22:24.681+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:24:675,0.010235,0.009112,-0.019461
06-07 17:22:24.681+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:24:675,0.316286,-0.093107,9.801106
06-07 17:22:24.691+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:24:678,0.140000,0.140000,0.140000
06-07 17:22:24.701+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:24.701+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:24:706,0.306281,-0.093320,9.834501
06-07 17:22:24.711+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:24.711+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:24.711+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:24.711+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:24:718,0.316172,-0.093166,9.801109
06-07 17:22:24.721+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:24:727,0.140000,0.140000,0.070000
06-07 17:22:24.731+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:24:726,-0.007109,-0.017500,0.021235
06-07 17:22:24.741+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:24.741+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:24.741+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:24.741+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:22:24.741+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:22:24.741+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:24.751+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:22:24.761+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:22:24:764,758.000000
06-07 17:22:24.771+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:24:746,0.301496,-0.117248,9.834501
06-07 17:22:24.781+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:24:775,0.070000,0.070000,0.070000
06-07 17:22:24.791+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:24:755,0.315486,-0.092417,9.801138
06-07 17:22:24.801+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:24.801+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:24:770,-0.014017,-0.006970,-0.017050
06-07 17:22:24.811+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:24.811+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:24.811+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:24.821+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:24:831,0.070000,0.070000,0.070000
06-07 17:22:24.831+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:24:825,-0.013759,-0.001661,0.018839
06-07 17:22:24.831+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:24:807,0.337388,-0.074178,9.846465
06-07 17:22:24.841+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:24.841+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:24:822,0.316343,-0.091884,9.801116
06-07 17:22:24.841+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:24.861+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:24.871+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:24.881+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:24:861,0.318066,-0.092009,9.801059
06-07 17:22:24.891+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:24:853,0.315853,-0.112463,9.769895
06-07 17:22:24.891+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:24.901+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:24:874,-0.001197,-0.013418,0.030786
06-07 17:22:24.901+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:24.901+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:24:880,0.070000,0.070000,0.070000
06-07 17:22:24.931+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:24.931+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:24.951+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:22:24.951+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:22:24.951+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:22:24.961+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:22:24:966,758.000000
06-07 17:22:24.971+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:24:912,0.313460,-0.083749,9.820145
06-07 17:22:24.981+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:24:919,0.317506,-0.092231,9.801075
06-07 17:22:24.981+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:24:941,0.070000,0.070000,0.140000
06-07 17:22:25.001+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:25.001+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:25.001+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:24:938,0.025128,-0.017449,0.016436
06-07 17:22:25.001+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:25.001+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:25.021+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:25:16,0.318555,-0.094306,9.801021
06-07 17:22:25.031+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:25:11,0.325424,-0.117248,9.820145
06-07 17:22:25.031+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:25.041+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:25:22,0.070000,0.070000,0.070000
06-07 17:22:25.041+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:25:17,0.019547,0.021474,0.023644
06-07 17:22:25.041+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:25.041+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:25.041+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:25.071+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:25:49,0.318468,-0.094717,9.801020
06-07 17:22:25.071+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:25:51,0.308674,-0.086142,9.839286
06-07 17:22:25.081+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:25.081+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:25:55,0.035875,-0.018000,0.052361
06-07 17:22:25.081+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:25.081+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:25:66,0.070000,0.070000,0.070000
06-07 17:22:25.081+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:25.091+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:25.101+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:25:95,0.318702,-0.094659,9.801013
06-07 17:22:25.111+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:25:101,0.299103,-0.086142,9.829715
06-07 17:22:25.121+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:25:102,0.020277,-0.019746,0.028478
06-07 17:22:25.121+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:25.131+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:25:105,0.140000,0.070000,0.070000
06-07 17:22:25.131+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:25.131+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:25.141+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:22:25.141+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:22:25.151+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:22:25.151+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:22:25.151+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:22:25.161+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:22:25.171+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:22:25:167,756.000000
06-07 17:22:25.181+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:25.191+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:25:146,0.318654,-0.093730,9.801023
06-07 17:22:25.201+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:25:192,0.017026,-0.011783,0.045263
06-07 17:22:25.201+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:25:161,0.334995,-0.122034,9.767502
06-07 17:22:25.201+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:25:195,0.070000,0.070000,0.070000
06-07 17:22:25.211+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:25.211+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:25.221+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:25:225,0.318721,-0.093497,9.801023
06-07 17:22:25.231+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:25.241+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:25.241+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:25:245,0.070000,-0.070000,0.070000
06-07 17:22:25.251+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:25:237,0.308674,-0.083749,9.824929
06-07 17:22:25.251+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:25.251+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:25:240,0.054158,0.005677,0.040522
06-07 17:22:25.261+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:25.261+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:25.271+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:25.271+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:25:278,0.339781,-0.102891,9.793823
06-07 17:22:25.281+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:25:261,0.316256,-0.093898,9.801100
06-07 17:22:25.291+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:25:277,-0.027049,0.014876,0.004698
06-07 17:22:25.301+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:25.301+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:25:289,0.070000,0.070000,0.140000
06-07 17:22:25.301+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:25.311+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:25.311+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:25.321+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:25:325,-0.008622,0.004411,0.030956
06-07 17:22:25.331+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:25:339,0.140000,0.070000,0.070000
06-07 17:22:25.341+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:25:309,0.316001,-0.094467,9.801103
06-07 17:22:25.341+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:25.341+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:22:25.341+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:22:25.351+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:25:323,0.284746,-0.095713,9.832108
06-07 17:22:25.351+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:25.351+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:22:25.361+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:22:25:365,756.000000
06-07 17:22:25.361+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:25.371+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:25.371+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:25:354,0.314938,-0.091403,9.801166
06-07 17:22:25.381+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:25:385,0.025749,0.020765,0.006996
06-07 17:22:25.391+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:25:396,0.315853,-0.126820,9.793823
06-07 17:22:25.401+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:25.401+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:25:385,0.140000,0.070000,0.070000
06-07 17:22:25.401+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:25.411+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:25.411+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:25.411+0200 I/servicemanager(19582): es.ugr.frailty.accelerometer alive timeout
06-07 17:22:25.411+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:22:25.421+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:25.421+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:25.421+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:25:422,-0.003662,-0.004305,0.100328
06-07 17:22:25.431+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20297
06-07 17:22:25.431+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:25:410,0.315300,-0.090280,9.801165
06-07 17:22:25.431+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20297)
06-07 17:22:25.431+0200 I/servicemanager(19582): es.ugr.frailty.accelerometer launch request sent!
06-07 17:22:25.431+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:25.431+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope alive timeout
06-07 17:22:25.431+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:22:25.431+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:25.441+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:25.441+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:25:443,0.260818,-0.100499,9.824929
06-07 17:22:25.441+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20330
06-07 17:22:25.451+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:25.461+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:25.461+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:25:440,0.140000,0.070000,0.070000
06-07 17:22:25.471+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20330)
06-07 17:22:25.471+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope launch request sent!
06-07 17:22:25.471+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:25.471+0200 I/servicemanager(19582): es.ugr.frailty.heartrate alive timeout
06-07 17:22:25.471+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:22:25.471+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:25.471+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:25.471+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:25.471+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:25:459,0.315698,-0.090327,9.801151
06-07 17:22:25.471+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:25.491+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19621
06-07 17:22:25.491+0200 W/CAPI_APPFW_APP_CONTROL(19621): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:22:25.491+0200 I/utils   (19621): specific action
06-07 17:22:25.491+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:22:25.491+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(31) , send fd(15), pid(19621), cmd(0)
06-07 17:22:25.501+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:25.501+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:25:490,0.140000,0.070000,0.140000
06-07 17:22:25.511+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:25:475,-0.017272,-0.052172,-0.000195
06-07 17:22:25.511+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:25.521+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:25:494,0.308674,-0.098106,9.801002
06-07 17:22:25.521+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19621)
06-07 17:22:25.521+0200 I/servicemanager(19582): es.ugr.frailty.heartrate launch request sent!
06-07 17:22:25.521+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:25.521+0200 I/servicemanager(19582): es.ugr.frailty.location alive timeout
06-07 17:22:25.521+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:22:25.521+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:25:517,0.318473,-0.093302,9.801033
06-07 17:22:25.521+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:25.531+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:25.541+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:25.541+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:25.541+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:22:25.541+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:22:25.551+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20530
06-07 17:22:25.561+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:22:25.571+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:22:25:572,756.000000
06-07 17:22:25.581+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:25.581+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:22:25.581+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(31) , send fd(15), pid(20530), cmd(0)
06-07 17:22:25.591+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:25:535,0.020057,-0.040441,0.054814
06-07 17:22:25.591+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:25:542,0.070000,0.070000,0.070000
06-07 17:22:25.601+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:25:547,0.311067,-0.095713,9.815358
06-07 17:22:25.601+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:25.601+0200 W/CAPI_APPFW_APP_CONTROL(20530): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:22:25.601+0200 I/utils   (20530): specific action
06-07 17:22:25.611+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20530)
06-07 17:22:25.611+0200 I/servicemanager(19582): es.ugr.frailty.location launch request sent!
06-07 17:22:25.611+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:25.611+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration alive timeout
06-07 17:22:25.611+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:22:25.611+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:25.611+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:25.611+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:25.621+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:25.621+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20358
06-07 17:22:25.621+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:25:587,0.319961,-0.095419,9.800964
06-07 17:22:25.631+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:25:629,0.311067,-0.088534,9.832108
06-07 17:22:25.641+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:25.641+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20358)
06-07 17:22:25.641+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:22:25.641+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:25.641+0200 I/servicemanager(19582): es.ugr.frailty.gravity alive timeout
06-07 17:22:25.641+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:22:25.651+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:25:653,0.320724,-0.096715,9.800927
06-07 17:22:25.661+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:25:621,0.070000,0.070000,0.070000
06-07 17:22:25.661+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:25:618,-0.002840,0.011942,0.069236
06-07 17:22:25.661+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:25.661+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:25.661+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:25.681+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:25.681+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:25.681+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:25.681+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:25:685,0.308674,-0.126820,9.808180
06-07 17:22:25.691+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20375
06-07 17:22:25.691+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:25:675,0.001531,0.009277,0.009427
06-07 17:22:25.701+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:25:706,0.321283,-0.096822,9.800907
06-07 17:22:25.701+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20375)
06-07 17:22:25.701+0200 I/servicemanager(19582): es.ugr.frailty.gravity launch request sent!
06-07 17:22:25.701+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:25.701+0200 I/servicemanager(19582): es.ugr.frailty.pressure alive timeout
06-07 17:22:25.701+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:22:25.711+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:25:681,0.070000,0.140000,0.070000
06-07 17:22:25.711+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:25.721+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:25.721+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:25:729,0.025060,0.016293,-0.004920
06-07 17:22:25.731+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:25.741+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:22:25.741+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:22:25.751+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:25.751+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:25.751+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:25.761+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19663
06-07 17:22:25.761+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:22:25.761+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:22:25:767,756.000000
06-07 17:22:25.761+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:22:25.761+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(33) , send fd(15), pid(19663), cmd(0)
06-07 17:22:25.771+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:25.781+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:25:737,0.070000,0.070000,0.070000
06-07 17:22:25.781+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:25:755,0.315853,-0.100499,9.805787
06-07 17:22:25.781+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:25.781+0200 W/CAPI_APPFW_APP_CONTROL(19663): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:22:25.781+0200 I/utils   (19663): specific action
06-07 17:22:25.801+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:25:758,0.316156,-0.096022,9.801082
06-07 17:22:25.801+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:25.801+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:25.801+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19663)
06-07 17:22:25.801+0200 I/servicemanager(19582): es.ugr.frailty.pressure launch request sent!
06-07 17:22:25.801+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:25.801+0200 I/servicemanager(19582): es.ugr.frailty.light alive timeout
06-07 17:22:25.801+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:22:25.821+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:25.821+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:25.821+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:25:792,0.002046,0.027787,0.021444
06-07 17:22:25.821+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:25:798,0.140000,0.070000,0.070000
06-07 17:22:25.821+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:25.831+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19670
06-07 17:22:25.841+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:25:820,0.314650,-0.094643,9.801144
06-07 17:22:25.841+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:25:815,0.287139,-0.069392,9.798609
06-07 17:22:25.841+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:25.841+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:25:851,0.070000,0.070000,0.070000
06-07 17:22:25.851+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:25.861+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:22:25.861+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(33) , send fd(15), pid(19670), cmd(0)
06-07 17:22:25.861+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:25.861+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:25:844,-0.034294,0.026735,0.042984
06-07 17:22:25.881+0200 W/CAPI_APPFW_APP_CONTROL(19670): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:22:25.881+0200 I/utils   (19670): specific action
06-07 17:22:25.881+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:25.881+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:25.891+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19670)
06-07 17:22:25.891+0200 I/servicemanager(19582): es.ugr.frailty.light launch request sent!
06-07 17:22:25.891+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:25.891+0200 I/servicemanager(19582): es.ugr.frailty.pedometer alive timeout
06-07 17:22:25.891+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:22:25.891+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:25:875,0.313471,-0.093083,9.801197
06-07 17:22:25.891+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:25.891+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:25.901+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19682
06-07 17:22:25.901+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:25:876,0.325424,-0.102891,9.798609
06-07 17:22:25.911+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:25.911+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:25:905,0.070000,0.070000,0.070000
06-07 17:22:25.921+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:25.931+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:22:25.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(33) , send fd(15), pid(19682), cmd(0)
06-07 17:22:25.951+0200 W/CAPI_APPFW_APP_CONTROL(19682): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:22:25.951+0200 I/utils   (19682): specific action
06-07 17:22:25.951+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19682)
06-07 17:22:25.951+0200 I/servicemanager(19582): es.ugr.frailty.pedometer launch request sent!
06-07 17:22:25.951+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:25.961+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:22:25.971+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:22:25.971+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11202896c6f63152838486
