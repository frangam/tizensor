S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 24756
Date: 2018-06-12 21:07:37+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf749a52d, r5   = 0xf7bef150
r6   = 0xffc264c0, r7   = 0xffc26370
r8   = 0xf7c01c18, r9   = 0x00000000
r10  = 0xffc2644c, fp   = 0xffc264c0
ip   = 0x00000001, sp   = 0xffc26348
lr   = 0xf749a539, pc   = 0xf7503270
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     85996 KB
Buffers:     52624 KB
Cached:     179696 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11800 KB
VmRSS:       11800 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 24756 TID = 24756
24756 24764 

Maps Information
f4365000 f4b64000 rw-p [stack:24764]
f4b6b000 f4b6d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b75000 f4b79000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b82000 f4b84000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b8c000 f4b8f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b9e000 f4ba3000 r-xp /usr/lib/libsystem.so.0.0.0
f4bae000 f4bb1000 r-xp /lib/libattr.so.1.1.0
f4bb9000 f4bc9000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4bd1000 f4bda000 r-xp /usr/lib/libedbus.so.1.7.99
f4be2000 f4be3000 r-xp /usr/lib/libresponse.so.0.2.96
f4bec000 f4bf1000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6493000 f6599000 r-xp /usr/lib/libicuuc.so.57.1
f65af000 f6737000 r-xp /usr/lib/libicui18n.so.57.1
f6747000 f6754000 r-xp /usr/lib/libail.so.0.1.0
f675d000 f6764000 r-xp /usr/lib/libminizip.so.1.0.0
f676d000 f6916000 r-xp /usr/lib/libcrypto.so.1.0.0
f6936000 f697d000 r-xp /usr/lib/libssl.so.1.0.0
f6989000 f698b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6993000 f699a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f69a3000 f69aa000 r-xp /lib/libcrypt-2.13.so
f69db000 f69de000 r-xp /lib/libcap.so.2.21
f69e6000 f69e8000 r-xp /usr/lib/libiri.so
f69f0000 f6a39000 r-xp /usr/lib/libmdm.so.1.2.69
f6a41000 f6a47000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a4f000 f6a72000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a7c000 f6a7e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a86000 f6aa3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6aac000 f6ab0000 r-xp /usr/lib/libsmack.so.1.0.0
f6ab9000 f6ad2000 r-xp /usr/lib/libnetwork.so.0.0.0
f6adb000 f6ae3000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6aeb000 f6af1000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6afa000 f6afc000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b05000 f6b15000 r-xp /lib/libresolv-2.13.so
f6b19000 f6b31000 r-xp /usr/lib/liblzma.so.5.0.3
f6b3a000 f6b3c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b44000 f6b5e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b66000 f6b95000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b9e000 f6bad000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6bb7000 f6bc1000 r-xp /usr/lib/libsensord-shared.so
f6bca000 f6c9d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ca8000 f6cbe000 r-xp /lib/libz.so.1.2.5
f6cc6000 f6ccb000 r-xp /usr/lib/libffi.so.5.0.10
f6cd3000 f6cd4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6cdc000 f6cec000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6cf4000 f6d0d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d15000 f6d17000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d1f000 f6d94000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d9e000 f6dbc000 r-xp /usr/lib/libsystemd.so.0.4.0
f6dc6000 f6dc7000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6dcf000 f6df2000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6dfa000 f6dff000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e07000 f6e31000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e3a000 f6e51000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e59000 f6e5f000 r-xp /lib/librt-2.13.so
f6e68000 f6ed1000 r-xp /lib/libm-2.13.so
f6eda000 f6f6e000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f81000 f6f86000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f8e000 f6f95000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f9d000 f6fc7000 r-xp /usr/lib/libsensor.so.1.9.6
f6fd0000 f709c000 r-xp /usr/lib/libxml2.so.2.7.8
f70a9000 f70ab000 r-xp /usr/lib/libiniparser.so.0
f70b4000 f70ba000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f70c3000 f7193000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7194000 f71c8000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f71d1000 f720d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7215000 f7218000 r-xp /usr/lib/libbundle.so.0.1.22
f7220000 f7226000 r-xp /usr/lib/libappsvc.so.0.1.0
f722e000 f726f000 r-xp /usr/lib/libeina.so.1.7.99
f7278000 f7281000 r-xp /usr/lib/libvconf.so.0.2.45
f7289000 f729d000 r-xp /lib/libpthread-2.13.so
f72a8000 f72b5000 r-xp /usr/lib/libaul.so.0.1.0
f72bf000 f72c1000 r-xp /lib/libdl-2.13.so
f72ca000 f72d5000 r-xp /lib/libunwind.so.8.0.1
f7302000 f730a000 r-xp /lib/libgcc_s-4.6.so.1
f730b000 f742f000 r-xp /lib/libc-2.13.so
f743d000 f7454000 r-xp /usr/lib/libecore.so.1.7.99
f746b000 f746d000 r-xp /usr/lib/libdlog.so.0.0.0
f7475000 f7481000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f748a000 f748f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7497000 f74a6000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f74ae000 f74b2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74bb000 f74be000 r-xp /usr/lib/libappcore-agent.so.1.1
f74c6000 f74c8000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f74d0000 f74d4000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f74dc000 f74f9000 r-xp /lib/ld-2.13.so
f7502000 f7505000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7505000 f7509000 r-xp /usr/lib/libsys-assert.so
f7bd1000 f7c3f000 rw-p [heap]
ffc07000 ffc28000 rw-p [stack]
End of Maps Information

Callstack Information (PID:24756)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7503270) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1270
 1: (0xf749a539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71a13f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf719fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf71abe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf71b1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf71b1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf71e675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71e11f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf719fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf71abe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf71b1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf71b1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf71e3e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf71e4017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf71ebf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b831fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b76171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c49663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf70f6fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70f87a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf744dca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7448b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74495a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7449879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf74bc183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74bc7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf750360b) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x160b
28: __libc_start_main + 0x114 (0xf732285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7502f74) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf74
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
2.380000
06-12 21:07:36.931+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:36.931+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:36.931+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:36:936,2.883338,0.033011,9.373135
06-12 21:07:36.931+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:36.931+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:36:940,0.507278,-0.411566,9.676575
06-12 21:07:36.941+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:36.941+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:36:943,3.036205,0.027654,9.324757
06-12 21:07:36.941+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:36.941+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:36:947,-0.890316,-0.113023,0.311379
06-12 21:07:36.941+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:36:938,-1.190000,0.980000,1.960000
06-12 21:07:36.941+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:36.941+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:36.951+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:36:951,2.427239,0.040071,9.501436
06-12 21:07:36.951+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:36.951+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:36:954,0.535992,-0.141177,9.540184
06-12 21:07:36.951+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:36.951+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:36:952,-1.610000,-0.490000,0.420000
06-12 21:07:36.951+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:36.961+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:36:958,0.669990,-0.059821,9.671788
06-12 21:07:36.961+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 21:07:36.961+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 21:07:36.961+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:36.961+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 21:07:36.961+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 21:07:36.961+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:36:957,2.155382,0.045688,9.566746
06-12 21:07:36.961+0200 I/heartrate(24744): es.ugr.frailty.heartrate - capturing data
06-12 21:07:36.961+0200 I/heartrate(24744): es.ugr.frailty.heartrate: waiting for rigth values
06-12 21:07:36.961+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:36.961+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:36:971,-0.804123,-0.013096,-0.110529
06-12 21:07:36.971+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:36:963,0.210000,0.700000,0.420000
06-12 21:07:36.971+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:36.971+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:36:973,1.882669,0.052522,9.624094
06-12 21:07:36.971+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:36.971+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:36:976,0.070000,1.540000,0.070000
06-12 21:07:36.971+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:36.971+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:36.971+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:36:979,1.812270,0.055830,9.637580
06-12 21:07:36.971+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:36:981,0.514457,0.052642,10.028319
06-12 21:07:36.971+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:36.971+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:36.981+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:36.981+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:36:985,2.290367,0.041789,9.535348
06-12 21:07:36.981+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:36.981+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:36:988,-0.742233,0.032445,-0.060819
06-12 21:07:36.991+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:36:991,3.310604,0.020172,9.230920
06-12 21:07:36.991+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:36.991+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:36:980,-0.350000,1.260000,-0.980000
06-12 21:07:36.991+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:36.991+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:36:985,0.677169,-0.033500,10.308280
06-12 21:07:36.991+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:36.991+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:36:998,3.985746,0.007648,8.960143
06-12 21:07:36.991+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.001+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.001+0200 I/light   (24799): es.ugr.frailty.light - capturing data
06-12 21:07:37.001+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:7,-0.615581,0.116348,0.039226
06-12 21:07:37.001+0200 I/light   (24799): es.ugr.frailty.light: SM-R760,12/06/2018,21:07:37:7,8.000000
06-12 21:07:37.001+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:36:998,1.540000,0.420000,-1.820000
06-12 21:07:37.001+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.001+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:1,0.466600,-0.165105,9.564112
06-12 21:07:37.001+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.011+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:4,4.176758,0.003722,8.872715
06-12 21:07:37.011+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.011+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:14,0.351745,-0.038285,9.552148
06-12 21:07:37.011+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.011+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:18,3.986793,0.006828,8.959678
06-12 21:07:37.011+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.021+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:12,-1.330000,-0.560000,-1.120000
06-12 21:07:37.021+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.021+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.021+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:24,4.129575,0.004558,8.894773
06-12 21:07:37.021+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:27,-0.444985,0.083248,0.203369
06-12 21:07:37.021+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.031+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:20,0.423530,-0.038285,9.774680
06-12 21:07:37.031+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.031+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:32,5.227908,-0.021733,8.296921
06-12 21:07:37.031+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.031+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:25,-6.020000,-1.330000,-0.560000
06-12 21:07:37.031+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.031+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:37,5.338602,-0.033277,8.226093
06-12 21:07:37.031+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.031+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:39,-3.430000,-0.700000,0.700000
06-12 21:07:37.031+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.041+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:36,0.497707,-0.136391,10.205389
06-12 21:07:37.041+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.041+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.041+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:43,5.192690,-0.043833,8.318920
06-12 21:07:37.041+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.041+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:47,-0.410822,-0.141573,0.262586
06-12 21:07:37.041+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:50,3.441876,-0.076209,9.182487
06-12 21:07:37.051+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.051+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:46,0.734596,-0.323031,10.188639
06-12 21:07:37.051+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.051+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:55,1.923251,-0.095577,9.615735
06-12 21:07:37.051+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.051+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:58,0.830309,0.059821,9.777073
06-12 21:07:37.051+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.051+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:60,2.091588,-0.086408,9.580615
06-12 21:07:37.051+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.051+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:61,0.643669,-0.212961,9.595219
06-12 21:07:37.061+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:43,-2.030000,0.770000,0.630000
06-12 21:07:37.061+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.061+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.061+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:65,1.544521,-0.093263,9.683808
06-12 21:07:37.061+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:68,-0.590779,-0.164106,0.148493
06-12 21:07:37.061+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.061+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:66,2.170000,2.240000,1.120000
06-12 21:07:37.071+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.071+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:72,2.376296,-0.075274,9.514091
06-12 21:07:37.071+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.071+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:75,-2.100000,0.770000,1.330000
06-12 21:07:37.071+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.071+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.071+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:77,2.994458,-0.068524,9.338036
06-12 21:07:37.071+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.071+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:80,0.397209,0.155533,9.408579
06-12 21:07:37.071+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.081+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.081+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:87,-0.361641,-0.133929,-0.165423
06-12 21:07:37.081+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:79,0.560000,-0.630000,0.070000
06-12 21:07:37.081+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.091+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:84,0.385244,0.040678,9.769895
06-12 21:07:37.091+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.091+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:101,0.485743,-0.244068,10.262815
06-12 21:07:37.101+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:95,-1.680000,-1.820000,-1.190000
06-12 21:07:37.101+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.101+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:107,-0.140000,0.140000,-1.050000
06-12 21:07:37.101+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.101+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:111,0.140000,0.420000,-0.910000
06-12 21:07:37.101+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.111+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.111+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:115,0.686740,-0.196211,9.990034
06-12 21:07:37.111+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.111+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:119,0.492921,-0.100499,9.609575
06-12 21:07:37.111+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.121+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:115,-0.630000,0.280000,-0.210000
06-12 21:07:37.121+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.121+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:129,-0.490000,-0.840000,-0.770000
06-12 21:07:37.121+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.131+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 21:07:37.131+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 21:07:37.131+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 21:07:37.131+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:134,-0.274403,-0.062009,-0.073484
06-12 21:07:37.131+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.131+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:123,0.457029,-0.059821,9.671788
06-12 21:07:37.131+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.131+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:83,1.577056,-0.083188,9.678655
06-12 21:07:37.131+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.141+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:139,-0.245689,0.088739,0.074870
06-12 21:07:37.141+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.141+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:144,1.297045,-0.087403,9.720104
06-12 21:07:37.141+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:147,0.770000,-1.260000,-0.980000
06-12 21:07:37.141+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.141+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.141+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.151+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:152,-0.142725,0.162583,0.139893
06-12 21:07:37.151+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:143,0.478565,0.028714,9.784252
06-12 21:07:37.151+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.151+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:152,1.199262,-0.092265,9.732607
06-12 21:07:37.151+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.151+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:159,0.641276,0.004786,9.949356
06-12 21:07:37.151+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.161+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:162,1.094145,-0.087634,9.745027
06-12 21:07:37.161+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.161+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.161+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:168,0.001934,-0.176586,0.245059
06-12 21:07:37.161+0200 I/heartrate(24744): es.ugr.frailty.heartrate - capturing data
06-12 21:07:37.161+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:152,0.210000,-1.610000,-1.330000
06-12 21:07:37.161+0200 I/heartrate(24744): es.ugr.frailty.heartrate: waiting for rigth values
06-12 21:07:37.161+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.161+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:168,1.086262,-0.078462,9.745987
06-12 21:07:37.171+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.171+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:163,0.691526,-0.217747,10.006784
06-12 21:07:37.171+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.171+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:176,1.102348,-0.076174,9.744199
06-12 21:07:37.171+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.171+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:174,1.050000,0.210000,-1.400000
06-12 21:07:37.171+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.181+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.181+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:187,-0.084755,-0.077971,-0.007006
06-12 21:07:37.181+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:179,0.452243,-0.253639,9.899107
06-12 21:07:37.181+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.191+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:184,-1.120000,0.280000,-0.490000
06-12 21:07:37.191+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.191+0200 W/LOCATION(24756): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 21:07:37.201+0200 I/light   (24799): es.ugr.frailty.light - capturing data
06-12 21:07:37.201+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.201+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:206,-0.319704,0.036707,-0.245865
06-12 21:07:37.201+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:198,-0.560000,-0.980000,-1.610000
06-12 21:07:37.201+0200 I/light   (24799): es.ugr.frailty.light: SM-R760,12/06/2018,21:07:37:207,8.000000
06-12 21:07:37.201+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:194,0.531207,-0.232104,9.600004
06-12 21:07:37.201+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.211+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.211+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:218,0.420000,-1.120000,-1.750000
06-12 21:07:37.211+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.211+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:213,0.519243,-0.160319,9.700503
06-12 21:07:37.211+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.221+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.221+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:219,1.043023,-0.089533,9.750614
06-12 21:07:37.221+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.221+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:227,-0.271806,0.209014,0.001549
06-12 21:07:37.221+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:223,0.547956,-0.009571,9.848858
06-12 21:07:37.221+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.231+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:222,-1.820000,-1.260000,-1.050000
06-12 21:07:37.231+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.231+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:233,0.892847,-0.098175,9.765428
06-12 21:07:37.231+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:235,0.595813,0.069392,9.918249
06-12 21:07:37.231+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.231+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.241+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.241+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:247,-0.339950,-0.010914,0.469007
06-12 21:07:37.241+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:238,1.540000,0.280000,-1.050000
06-12 21:07:37.241+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.251+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:245,0.793646,-0.098310,9.773988
06-12 21:07:37.251+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.251+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:244,0.770489,-0.265603,10.021141
06-12 21:07:37.251+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.251+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:253,1.680000,-0.420000,0.840000
06-12 21:07:37.251+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.261+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.261+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:256,0.735392,-0.096349,9.778563
06-12 21:07:37.261+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.261+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:268,-0.097114,0.132315,0.007775
06-12 21:07:37.261+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:257,0.672383,-0.174676,9.769895
06-12 21:07:37.261+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.271+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:262,-0.700000,-0.420000,1.470000
06-12 21:07:37.271+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.271+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:276,-3.430000,-0.350000,0.490000
06-12 21:07:37.271+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.271+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:270,0.738538,-0.093192,9.778357
06-12 21:07:37.271+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.271+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:274,0.411566,-0.059821,9.533006
06-12 21:07:37.281+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.281+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.281+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:284,0.768554,-0.089017,9.776082
06-12 21:07:37.281+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:289,-0.052348,-0.182127,-0.074386
06-12 21:07:37.291+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.291+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:285,0.440279,0.114855,9.781858
06-12 21:07:37.291+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.291+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:281,-0.210000,-0.700000,0.140000
06-12 21:07:37.291+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.301+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.301+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:297,0.757138,-0.096705,9.776900
06-12 21:07:37.301+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.301+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:307,0.070426,0.028024,-0.335073
06-12 21:07:37.301+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:298,0.385244,-0.093320,10.248460
06-12 21:07:37.301+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.311+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:311,0.731270,-0.096528,9.778871
06-12 21:07:37.311+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:302,2.940000,-0.490000,-0.700000
06-12 21:07:37.311+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.311+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:312,0.602991,0.047856,9.789038
06-12 21:07:37.311+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:316,2.310000,0.140000,-0.350000
06-12 21:07:37.311+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.311+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.311+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.321+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.321+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:326,-0.060569,-0.178871,0.054621
06-12 21:07:37.321+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:322,0.712086,-0.094159,9.780310
06-12 21:07:37.321+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.321+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:324,0.669990,-0.263210,9.705289
06-12 21:07:37.321+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.331+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:321,-0.420000,-0.420000,0.560000
06-12 21:07:37.331+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.331+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:333,0.725194,-0.082406,9.779452
06-12 21:07:37.331+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:334,0.760918,-0.057428,9.446864
06-12 21:07:37.331+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:337,-1.540000,-0.350000,0.700000
06-12 21:07:37.341+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.341+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.341+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.341+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.341+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:348,-0.197961,-0.269906,0.484078
06-12 21:07:37.351+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:347,-0.140000,-1.260000,0.070000
06-12 21:07:37.351+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:348,0.700106,-0.084458,9.781262
06-12 21:07:37.351+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.351+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:345,0.658026,-0.267996,9.834501
06-12 21:07:37.351+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.351+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.361+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.361+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:359,0.722338,-0.081083,9.779675
06-12 21:07:37.361+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:367,-0.316926,-0.066268,0.339440
06-12 21:07:37.361+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.361+0200 I/heartrate(24744): es.ugr.frailty.heartrate - capturing data
06-12 21:07:37.361+0200 I/heartrate(24744): es.ugr.frailty.heartrate: waiting for rigth values
06-12 21:07:37.361+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:360,0.502493,-0.366102,10.265208
06-12 21:07:37.361+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.371+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:364,1.680000,-1.050000,-1.750000
06-12 21:07:37.371+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.371+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:374,0.332602,-0.167498,10.124033
06-12 21:07:37.371+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:372,0.690491,-0.085451,9.781938
06-12 21:07:37.371+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:376,0.350000,-0.350000,-1.190000
06-12 21:07:37.371+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.381+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.381+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.381+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:388,-0.133758,-0.059420,-0.078147
06-12 21:07:37.381+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.391+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:388,0.718595,-0.089125,9.779881
06-12 21:07:37.391+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:392,0.459422,-0.155533,9.710074
06-12 21:07:37.391+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:384,0.490000,0.560000,-0.560000
06-12 21:07:37.391+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.391+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.391+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:398,-0.560000,-0.630000,0.490000
06-12 21:07:37.391+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.391+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:399,0.700454,-0.096196,9.781130
06-12 21:07:37.401+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:403,-1.190000,-1.400000,1.470000
06-12 21:07:37.401+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.401+0200 I/light   (24799): es.ugr.frailty.light - capturing data
06-12 21:07:37.401+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:407,0.361316,-0.002393,9.533006
06-12 21:07:37.401+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.401+0200 I/light   (24799): es.ugr.frailty.light: SM-R760,12/06/2018,21:07:37:408,8.000000
06-12 21:07:37.411+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:411,-0.220727,0.095200,-0.255870
06-12 21:07:37.411+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.411+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.411+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:416,1.820000,-1.400000,0.840000
06-12 21:07:37.411+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.411+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:420,-2.170000,-0.630000,0.910000
06-12 21:07:37.411+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.411+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:416,0.649529,-0.101229,9.784593
06-12 21:07:37.411+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.421+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.421+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:427,0.514457,0.366102,9.533006
06-12 21:07:37.421+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:425,0.593180,-0.096114,9.788221
06-12 21:07:37.421+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.421+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:431,-0.063861,0.459721,-0.256129
06-12 21:07:37.431+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.431+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:424,0.350000,0.770000,-0.280000
06-12 21:07:37.431+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.431+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:437,3.150000,-0.140000,-2.870000
06-12 21:07:37.431+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.431+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:435,0.582043,-0.097593,9.788876
06-12 21:07:37.441+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:441,4.130000,-0.070000,-3.080000
06-12 21:07:37.441+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.441+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.441+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.441+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.441+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:448,0.252953,0.321732,0.169860
06-12 21:07:37.451+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:451,0.578318,-0.093619,9.789135
06-12 21:07:37.451+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:447,0.835095,0.246461,9.958927
06-12 21:07:37.451+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:446,0.840000,-1.330000,-0.840000
06-12 21:07:37.451+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.451+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.451+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:459,-0.420000,-0.140000,1.610000
06-12 21:07:37.451+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.461+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:463,-1.400000,1.120000,3.430000
06-12 21:07:37.461+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.461+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.461+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:460,0.582142,-0.075271,9.789067
06-12 21:07:37.461+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.461+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.461+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:470,0.604049,-0.067599,9.787795
06-12 21:07:37.461+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:470,0.463150,0.065206,0.307524
06-12 21:07:37.471+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:468,1.067199,-0.002393,10.095319
06-12 21:07:37.471+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:467,-2.520000,0.420000,3.500000
06-12 21:07:37.471+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.471+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.471+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:480,-2.870000,-1.260000,1.120000
06-12 21:07:37.481+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:481,0.651841,-0.071629,9.784700
06-12 21:07:37.481+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.481+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.481+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:488,-2.940000,-2.030000,-0.210000
06-12 21:07:37.481+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.491+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:492,0.314859,-0.373436,0.119193
06-12 21:07:37.491+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:488,0.966700,-0.445065,9.903893
06-12 21:07:37.491+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.491+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:497,0.709528,-0.093453,9.780502
06-12 21:07:37.501+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.501+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.501+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.501+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:507,2.100000,-0.420000,-2.380000
06-12 21:07:37.511+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:509,-0.140036,-0.538252,-0.144606
06-12 21:07:37.511+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:507,0.569492,-0.631705,9.635897
06-12 21:07:37.511+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.511+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:518,0.687320,-0.112370,9.781889
06-12 21:07:37.521+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.521+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.521+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.521+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:527,-0.457609,0.002300,-0.033529
06-12 21:07:37.521+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:527,3.150000,1.050000,-2.240000
06-12 21:07:37.531+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:528,0.229711,-0.110070,9.748360
06-12 21:07:37.531+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.531+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:536,0.627071,-0.106811,9.785998
06-12 21:07:37.541+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.541+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.541+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:550,-0.519394,-0.046330,-0.013711
06-12 21:07:37.551+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.551+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:555,0.107677,-0.153141,9.772287
06-12 21:07:37.551+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.551+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:547,2.100000,0.420000,-0.420000
06-12 21:07:37.561+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.561+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.561+0200 I/heartrate(24744): es.ugr.frailty.heartrate - capturing data
06-12 21:07:37.561+0200 I/heartrate(24744): es.ugr.frailty.heartrate: waiting for rigth values
06-12 21:07:37.571+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:572,2.450000,0.700000,1.400000
06-12 21:07:37.581+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.581+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.601+0200 I/light   (24799): es.ugr.frailty.light - capturing data
06-12 21:07:37.601+0200 I/light   (24799): es.ugr.frailty.light: SM-R760,12/06/2018,21:07:37:610,7.000000
06-12 21:07:37.601+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:588,-3.710000,-0.560000,3.360000
06-12 21:07:37.611+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.621+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:07:37:624,-3.220000,-0.560000,2.730000
06-12 21:07:37.621+0200 I/gyroscope(24731): es.ugr.frailty.gyroscope - capturing data
06-12 21:07:37.631+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:568,-0.235274,0.458360,-0.017714
06-12 21:07:37.631+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-12 21:07:37.631+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
06-12 21:07:37.631+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-12 21:07:37.631+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-12 21:07:37.631+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-12 21:07:37.631+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
06-12 21:07:37.631+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
06-12 21:07:37.631+0200 E/CAPI_LOCATION_MANAGER(24795): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-12 21:07:37.641+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:0, msg id:2
06-12 21:07:37.641+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:591,0.325424,0.349352,9.772287
06-12 21:07:37.641+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.641+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.651+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:560,0.560698,-0.109008,9.790001
06-12 21:07:37.651+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.651+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 21:07:37.651+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:648,-0.034635,0.446581,0.035724
06-12 21:07:37.651+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.661+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:653,0.502493,0.366102,9.827322
06-12 21:07:37.661+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.661+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:657,0.537127,-0.080479,9.791598
06-12 21:07:37.661+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.671+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:664,0.434640,-0.154283,0.335923
06-12 21:07:37.671+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.671+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:672,0.558381,-0.068249,9.790503
06-12 21:07:37.671+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.681+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:669,0.993021,-0.222532,10.126426
06-12 21:07:37.681+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.681+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:07:37:686,1.012164,-0.330210,9.968499
06-12 21:07:37.681+0200 I/accelerometer(24717): es.ugr.frailty.accelerometer - capturing data
06-12 21:07:37.691+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:684,0.609552,-0.081814,9.787346
06-12 21:07:37.691+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:681,0.402612,-0.248396,0.181153
06-12 21:07:37.691+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.701+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.701+0200 I/gravity (24773): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:07:37:708,0.652074,-0.096245,9.784473
06-12 21:07:37.701+0200 I/gravity (24773): es.ugr.frailty.gravity - capturing data
06-12 21:07:37.711+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:704,0.101665,-0.202858,-0.074399
06-12 21:07:37.711+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.711+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:07:37:717,-0.258460,-0.353297,-0.160208
06-12 21:07:37.711+0200 I/linearacceleration(24759): es.ugr.frailty.linearacceleration - capturing data
06-12 21:07:37.721+0200 W/CRASH_MANAGER(24845): worker.c: worker_job(1205) > 11247566c6f63152883045
