S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 25454
Date: 2018-06-12 21:20:13+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf71fa52d, r5   = 0xf77dffe0
r6   = 0xffca8040, r7   = 0xffca7ef0
r8   = 0xf77b1c18, r9   = 0x00000000
r10  = 0xffca7fcc, fp   = 0xffca8040
ip   = 0x00000001, sp   = 0xffca7ec8
lr   = 0xf71fa539, pc   = 0xf7263270
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     40004 KB
Buffers:     56292 KB
Cached:     187576 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11860 KB
VmRSS:       11856 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 25454 TID = 25454
25454 25493 

Maps Information
f40c5000 f48c4000 rw-p [stack:25493]
f48cb000 f48cd000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f48d5000 f48d9000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f48e2000 f48e4000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f48ec000 f48ef000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f48fe000 f4903000 r-xp /usr/lib/libsystem.so.0.0.0
f490e000 f4911000 r-xp /lib/libattr.so.1.1.0
f4919000 f4929000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4931000 f493a000 r-xp /usr/lib/libedbus.so.1.7.99
f4942000 f4943000 r-xp /usr/lib/libresponse.so.0.2.96
f494c000 f4951000 r-xp /usr/lib/libproc-stat.so.0.2.96
f61f3000 f62f9000 r-xp /usr/lib/libicuuc.so.57.1
f630f000 f6497000 r-xp /usr/lib/libicui18n.so.57.1
f64a7000 f64b4000 r-xp /usr/lib/libail.so.0.1.0
f64bd000 f64c4000 r-xp /usr/lib/libminizip.so.1.0.0
f64cd000 f6676000 r-xp /usr/lib/libcrypto.so.1.0.0
f6696000 f66dd000 r-xp /usr/lib/libssl.so.1.0.0
f66e9000 f66eb000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f66f3000 f66fa000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6703000 f670a000 r-xp /lib/libcrypt-2.13.so
f673b000 f673e000 r-xp /lib/libcap.so.2.21
f6746000 f6748000 r-xp /usr/lib/libiri.so
f6750000 f6799000 r-xp /usr/lib/libmdm.so.1.2.69
f67a1000 f67a7000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f67af000 f67d2000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f67dc000 f67de000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f67e6000 f6803000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f680c000 f6810000 r-xp /usr/lib/libsmack.so.1.0.0
f6819000 f6832000 r-xp /usr/lib/libnetwork.so.0.0.0
f683b000 f6843000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f684b000 f6851000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f685a000 f685c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6865000 f6875000 r-xp /lib/libresolv-2.13.so
f6879000 f6891000 r-xp /usr/lib/liblzma.so.5.0.3
f689a000 f689c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f68a4000 f68be000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f68c6000 f68f5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68fe000 f690d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6917000 f6921000 r-xp /usr/lib/libsensord-shared.so
f692a000 f69fd000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a08000 f6a1e000 r-xp /lib/libz.so.1.2.5
f6a26000 f6a2b000 r-xp /usr/lib/libffi.so.5.0.10
f6a33000 f6a34000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a3c000 f6a4c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a54000 f6a6d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a75000 f6a77000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a7f000 f6af4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6afe000 f6b1c000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b26000 f6b27000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b2f000 f6b52000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b5a000 f6b5f000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b67000 f6b91000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b9a000 f6bb1000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6bb9000 f6bbf000 r-xp /lib/librt-2.13.so
f6bc8000 f6c31000 r-xp /lib/libm-2.13.so
f6c3a000 f6cce000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ce1000 f6ce6000 r-xp /usr/lib/libctx-client.so.0.8.3
f6cee000 f6cf5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6cfd000 f6d27000 r-xp /usr/lib/libsensor.so.1.9.6
f6d30000 f6dfc000 r-xp /usr/lib/libxml2.so.2.7.8
f6e09000 f6e0b000 r-xp /usr/lib/libiniparser.so.0
f6e14000 f6e1a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e23000 f6ef3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6ef4000 f6f28000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f31000 f6f6d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f75000 f6f78000 r-xp /usr/lib/libbundle.so.0.1.22
f6f80000 f6f86000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f8e000 f6fcf000 r-xp /usr/lib/libeina.so.1.7.99
f6fd8000 f6fe1000 r-xp /usr/lib/libvconf.so.0.2.45
f6fe9000 f6ffd000 r-xp /lib/libpthread-2.13.so
f7008000 f7015000 r-xp /usr/lib/libaul.so.0.1.0
f701f000 f7021000 r-xp /lib/libdl-2.13.so
f702a000 f7035000 r-xp /lib/libunwind.so.8.0.1
f7062000 f706a000 r-xp /lib/libgcc_s-4.6.so.1
f706b000 f718f000 r-xp /lib/libc-2.13.so
f719d000 f71b4000 r-xp /usr/lib/libecore.so.1.7.99
f71cb000 f71cd000 r-xp /usr/lib/libdlog.so.0.0.0
f71d5000 f71e1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71ea000 f71ef000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f71f7000 f7206000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f720e000 f7212000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f721b000 f721e000 r-xp /usr/lib/libappcore-agent.so.1.1
f7226000 f7228000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7230000 f7234000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f723c000 f7259000 r-xp /lib/ld-2.13.so
f7262000 f7265000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7265000 f7269000 r-xp /usr/lib/libsys-assert.so
f77ab000 f781c000 rw-p [heap]
ffc89000 ffcaa000 rw-p [stack]
End of Maps Information

Callstack Information (PID:25454)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7263270) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1270
 1: (0xf71fa539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f013f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6effc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f0be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f11be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f11dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f4675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f411f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6effc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f0be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f11be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f11dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f43e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f44017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f4bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48e31fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf48d6171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf69a9663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e56fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e587a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf71adca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf71a8b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71a95a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf71a9879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf721c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf721c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf726360b) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x160b
28: __libc_start_main + 0x114 (0xf708285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7262f74) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf74
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
gr.frailty.gravity: SM-R760,12/06/2018,21:20:12:417,5.539067,-0.181463,8.090500
06-12 21:20:12.419+0200 I/light   (25492): es.ugr.frailty.light - capturing data
06-12 21:20:12.419+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.419+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:427,-7.630000,-0.910000,4.620000
06-12 21:20:12.419+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.429+0200 I/light   (25492): es.ugr.frailty.light: SM-R760,12/06/2018,21:20:12:426,11.000000
06-12 21:20:12.429+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.429+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:434,5.208570,-0.213019,8.306372
06-12 21:20:12.429+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.429+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:437,-2.658108,-0.194210,1.365935
06-12 21:20:12.439+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.439+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.439+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.439+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:447,-3.850000,-0.910000,3.850000
06-12 21:20:12.449+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:447,4.848544,-0.243458,8.520723
06-12 21:20:12.449+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:442,2.880959,-0.375673,9.456435
06-12 21:20:12.449+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.449+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:452,-2.279755,-0.308617,1.197920
06-12 21:20:12.449+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:458,2.928815,-0.521635,9.504292
06-12 21:20:12.459+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.459+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.459+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 21:20:12.459+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 21:20:12.459+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 21:20:12.459+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 21:20:12.459+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:467,1.190000,1.470000,2.870000
06-12 21:20:12.459+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.469+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.469+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:476,-1.888623,-0.165714,0.921355
06-12 21:20:12.469+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:469,4.579451,-0.255475,8.667973
06-12 21:20:12.469+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:475,2.959922,-0.409173,9.442079
06-12 21:20:12.479+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.479+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.479+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.479+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:486,1.190000,2.100000,1.610000
06-12 21:20:12.479+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.479+0200 I/heartrate(25441): es.ugr.frailty.heartrate - capturing data
06-12 21:20:12.479+0200 I/heartrate(25441): es.ugr.frailty.heartrate: waiting for rigth values
06-12 21:20:12.489+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:487,4.334476,-0.267722,8.792668
06-12 21:20:12.489+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:493,-1.710456,-0.203947,0.728642
06-12 21:20:12.489+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:492,2.868994,-0.459422,9.396614
06-12 21:20:12.499+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.499+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.519+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 21:20:12.519+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 21:20:12.519+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 21:20:12.529+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:508,-2.520000,1.330000,0.630000
06-12 21:20:12.529+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.529+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.549+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 21:20:12.549+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 21:20:12.549+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 21:20:12.559+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:544,-4.270000,1.330000,-0.770000
06-12 21:20:12.559+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.569+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:541,-1.503767,-0.220414,0.714016
06-12 21:20:12.569+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.569+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:579,-1.311581,-0.344089,0.696936
06-12 21:20:12.569+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.579+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:573,-0.490000,-0.070000,-1.750000
06-12 21:20:12.579+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.579+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:590,3.220000,-0.070000,-2.590000
06-12 21:20:12.579+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.589+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:584,-1.208623,-0.366785,0.638637
06-12 21:20:12.589+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:595,3.500000,-0.700000,-4.060000
06-12 21:20:12.599+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.599+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:608,0.840000,-0.210000,-3.990000
06-12 21:20:12.609+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.609+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:616,-1.024442,-0.211291,0.496305
06-12 21:20:12.609+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.619+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.619+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.619+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:629,2.830709,-0.488136,9.506684
06-12 21:20:12.619+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.629+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:623,-0.872515,-0.120886,0.395505
06-12 21:20:12.629+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.629+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:628,-1.960000,-0.980000,-3.780000
06-12 21:20:12.639+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:509,4.168612,-0.285223,8.871962
06-12 21:20:12.639+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.639+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:648,4.029761,-0.310383,8.935047
06-12 21:20:12.639+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.649+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.659+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:634,2.857030,-0.629312,9.568897
06-12 21:20:12.659+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.659+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:640,-0.733523,-0.072242,0.271593
06-12 21:20:12.659+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.669+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:658,-1.610000,-0.630000,-3.150000
06-12 21:20:12.669+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.669+0200 I/light   (25492): es.ugr.frailty.light - capturing data
06-12 21:20:12.669+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:652,3.879080,-0.329487,9.000809
06-12 21:20:12.679+0200 I/light   (25492): es.ugr.frailty.light: SM-R760,12/06/2018,21:20:12:680,11.000000
06-12 21:20:12.679+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:678,1.120000,0.070000,-2.240000
06-12 21:20:12.679+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:672,2.821138,-0.677169,9.573684
06-12 21:20:12.679+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.679+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.679+0200 I/heartrate(25441): es.ugr.frailty.heartrate - capturing data
06-12 21:20:12.679+0200 I/heartrate(25441): es.ugr.frailty.heartrate: waiting for rigth values
06-12 21:20:12.679+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.689+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:690,2.240000,-0.140000,-1.960000
06-12 21:20:12.689+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:675,-0.679892,-0.090724,0.278845
06-12 21:20:12.689+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.689+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:695,3.753474,-0.333750,9.053752
06-12 21:20:12.689+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.689+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:698,-0.703404,-0.165452,0.295706
06-12 21:20:12.689+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.699+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:690,2.854637,-0.540778,9.497113
06-12 21:20:12.699+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.699+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.699+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:699,3.667124,-0.332145,9.089129
06-12 21:20:12.699+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.699+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:709,1.540000,-0.140000,-0.910000
06-12 21:20:12.699+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:706,2.880959,-0.454636,9.449257
06-12 21:20:12.709+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:704,-0.681328,-0.078995,0.312305
06-12 21:20:12.709+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.709+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:710,3.625457,-0.332806,9.105805
06-12 21:20:12.709+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.709+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.709+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:716,-0.593236,-0.058777,0.327918
06-12 21:20:12.709+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.719+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.719+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:719,3.613077,-0.339434,9.110480
06-12 21:20:12.719+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.719+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:726,-0.280000,-0.210000,0.280000
06-12 21:20:12.719+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:722,-0.472946,0.027747,0.239542
06-12 21:20:12.719+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:730,3.581429,-0.349320,9.122595
06-12 21:20:12.719+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.719+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:721,2.933600,-0.404387,9.360723
06-12 21:20:12.729+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.729+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:735,-0.468901,0.073530,0.263516
06-12 21:20:12.729+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.729+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:736,2.945565,-0.423530,9.384650
06-12 21:20:12.729+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.729+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:740,3.529229,-0.350395,9.142874
06-12 21:20:12.729+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:740,2.909672,-0.504886,9.406186
06-12 21:20:12.729+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.729+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.739+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.739+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:744,3.473546,-0.348385,9.164250
06-12 21:20:12.739+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.739+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:746,-0.516508,0.037209,0.236142
06-12 21:20:12.739+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.739+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:744,2.900101,-0.428315,9.434900
06-12 21:20:12.739+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.739+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:751,-0.700000,-0.070000,1.050000
06-12 21:20:12.749+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:754,2.935993,-0.409173,9.470792
06-12 21:20:12.749+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.749+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:750,3.436001,-0.343919,9.178562
06-12 21:20:12.749+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.749+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:758,3.000600,-0.320638,9.403792
06-12 21:20:12.749+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.749+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:760,3.414216,-0.341097,9.186793
06-12 21:20:12.749+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.759+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:762,2.967100,-0.270389,9.442079
06-12 21:20:12.759+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.759+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.759+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:764,3.387352,-0.341160,9.196730
06-12 21:20:12.759+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.759+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:767,-0.566214,0.087521,0.288420
06-12 21:20:12.759+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:771,3.358242,-0.339342,9.207467
06-12 21:20:12.769+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:766,-0.840000,0.490000,1.890000
06-12 21:20:12.769+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.769+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:776,2.897708,-0.303888,9.422935
06-12 21:20:12.769+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.769+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:780,2.821138,-0.253639,9.485149
06-12 21:20:12.769+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.779+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.779+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.779+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:785,3.329613,-0.340767,9.217806
06-12 21:20:12.779+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.789+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:787,-1.470000,1.120000,2.450000
06-12 21:20:12.789+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:790,2.801995,-0.289532,9.420543
06-12 21:20:12.789+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:786,-0.556247,0.049810,0.213076
06-12 21:20:12.799+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.799+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.799+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.799+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:811,3.303800,-0.345667,9.226907
06-12 21:20:12.799+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.809+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:811,-2.310000,1.680000,3.080000
06-12 21:20:12.809+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:810,-0.537189,0.015343,0.174023
06-12 21:20:12.809+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:815,2.792424,-0.325424,9.391829
06-12 21:20:12.819+0200 I/light   (25492): es.ugr.frailty.light - capturing data
06-12 21:20:12.819+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.819+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.819+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:826,-2.450000,2.450000,3.500000
06-12 21:20:12.819+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.819+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:828,3.279667,-0.351881,9.235277
06-12 21:20:12.819+0200 I/light   (25492): es.ugr.frailty.light: SM-R760,12/06/2018,21:20:12:825,11.000000
06-12 21:20:12.819+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.819+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:831,2.857030,-0.351745,9.379865
06-12 21:20:12.829+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:834,-0.446770,-0.006078,0.152958
06-12 21:20:12.839+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.839+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.839+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:846,3.251196,-0.361520,9.244967
06-12 21:20:12.839+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.839+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:847,-2.170000,2.730000,3.010000
06-12 21:20:12.839+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.849+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:851,-0.386745,-0.097969,0.221158
06-12 21:20:12.849+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:852,2.892922,-0.449851,9.456435
06-12 21:20:12.859+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.859+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.859+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.859+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:869,-3.570000,3.990000,3.920000
06-12 21:20:12.859+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:869,3.236210,-0.369830,9.249895
06-12 21:20:12.859+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.869+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:874,2.880959,-0.368495,9.399008
06-12 21:20:12.869+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:869,-0.370237,-0.006974,0.154040
06-12 21:20:12.879+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.879+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.879+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.879+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:887,-8.050000,3.710000,4.900000
06-12 21:20:12.879+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.879+0200 I/heartrate(25441): es.ugr.frailty.heartrate - capturing data
06-12 21:20:12.879+0200 I/heartrate(25441): es.ugr.frailty.heartrate: waiting for rigth values
06-12 21:20:12.879+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:887,3.260695,-0.386110,9.240626
06-12 21:20:12.889+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:892,2.955136,-0.358923,9.382257
06-12 21:20:12.889+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:886,-0.281074,0.010906,0.132362
06-12 21:20:12.899+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.899+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.909+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.909+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:910,-0.398879,-0.195346,0.196666
06-12 21:20:12.909+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:912,3.272836,-0.414942,9.235083
06-12 21:20:12.909+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.919+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.919+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.919+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:916,-9.450000,3.500000,5.320000
06-12 21:20:12.919+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.929+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:928,3.257970,-0.439800,9.239188
06-12 21:20:12.929+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:929,-0.454091,-0.207192,0.180675
06-12 21:20:12.929+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:923,2.861816,-0.581456,9.437292
06-12 21:20:12.929+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.929+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:934,-7.070000,4.760000,5.250000
06-12 21:20:12.939+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.939+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.939+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:942,2.818745,-0.622134,9.415757
06-12 21:20:12.939+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.949+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:948,3.223109,-0.455765,9.250634
06-12 21:20:12.949+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.949+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:948,-0.470331,-0.136870,0.229211
06-12 21:20:12.949+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:955,-4.130000,4.690000,5.460000
06-12 21:20:12.959+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.959+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.959+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:12.969+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:960,2.787638,-0.576670,9.468399
06-12 21:20:12.969+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.969+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:968,-0.440257,-0.140048,0.289550
06-12 21:20:12.969+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:968,3.176719,-0.468959,9.266008
06-12 21:20:12.979+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:12.979+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:12:987,3.120472,-0.474216,9.284835
06-12 21:20:12.979+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:977,2.782853,-0.595813,9.540184
06-12 21:20:12.979+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:12.989+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:12.989+0200 I/CAPI_WATCH_APPLICATION(25214): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 21:20:12.989+0200 E/watchface-app(25214): watchface.cpp: OnAppTimeTick(834) > 
06-12 21:20:12.999+0200 W/LOCATION(25454): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 21:20:12.999+0200 I/watchface-viewer(25214): viewer-part-resource-evas.cpp: CreateTextImage(807) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=center ']
06-12 21:20:13.009+0200 I/watchface-viewer(25214): viewer-part-resource-evas.cpp: CreateTextImage(821) > formatted size 36x35
06-12 21:20:13.009+0200 I/watchface-viewer(25214): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(561) > ImagesLoadingDoneSignal().Emit()
06-12 21:20:13.009+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:12:974,-2.590000,4.900000,6.160000
06-12 21:20:13.009+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:13.009+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:13.009+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:12:996,-0.482401,-0.064641,0.283747
06-12 21:20:13.019+0200 I/light   (25492): es.ugr.frailty.light - capturing data
06-12 21:20:13.019+0200 I/light   (25492): es.ugr.frailty.light: SM-R760,12/06/2018,21:20:13:27,11.000000
06-12 21:20:13.019+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:13:23,3.046758,-0.479719,9.309002
06-12 21:20:13.019+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:13.019+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:13.029+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:12:995,2.694318,-0.533599,9.549755
06-12 21:20:13.029+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:13.029+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:13:18,-0.140000,3.080000,6.230000
06-12 21:20:13.029+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:13:34,-0.418976,-0.207739,0.341491
06-12 21:20:13.029+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:13.029+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:13:38,2.701497,-0.681954,9.626326
06-12 21:20:13.029+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:13.029+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:13.039+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:13:41,2.940000,2.590000,5.530000
06-12 21:20:13.039+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:13.049+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:13:33,2.990630,-0.480790,9.327130
06-12 21:20:13.049+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:13:44,-0.426618,-0.037131,0.262289
06-12 21:20:13.049+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:13:55,1.400000,2.030000,6.650000
06-12 21:20:13.049+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:13.059+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:13.059+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:13.059+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:13:66,-0.339382,-0.071952,0.172375
06-12 21:20:13.069+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:13.069+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:13:67,2.977037,-0.493854,9.330795
06-12 21:20:13.069+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:13.069+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:13:42,2.620141,-0.516850,9.571291
06-12 21:20:13.069+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:13:71,-3.780000,-0.210000,6.440000
06-12 21:20:13.079+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:13.079+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:13:76,-0.301861,-0.207243,0.161532
06-12 21:20:13.079+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:13.079+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:13.079+0200 I/heartrate(25441): es.ugr.frailty.heartrate - capturing data
06-12 21:20:13.079+0200 I/heartrate(25441): es.ugr.frailty.heartrate: waiting for rigth values
06-12 21:20:13.089+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:13:87,-6.650000,-0.210000,5.880000
06-12 21:20:13.089+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:13.089+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:13:77,2.979721,-0.518649,9.328593
06-12 21:20:13.089+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:13.089+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:13:91,-0.302153,-0.196805,0.106307
06-12 21:20:13.089+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:13:92,2.651247,-0.552742,9.499505
06-12 21:20:13.089+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:13.099+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:13:100,-8.540000,-0.280000,5.530000
06-12 21:20:13.099+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:13.099+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:13.109+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:13:108,-0.184342,-0.235797,0.150609
06-12 21:20:13.109+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:13:113,-8.120000,-0.490000,3.990000
06-12 21:20:13.109+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:13:104,2.675175,-0.701097,9.492328
06-12 21:20:13.119+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:13:100,2.993515,-0.546656,9.322576
06-12 21:20:13.119+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:13.119+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:13.119+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:13:127,-0.193409,-0.198219,0.134373
06-12 21:20:13.119+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:13:126,-4.900000,0.420000,3.220000
06-12 21:20:13.119+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:13.129+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:13.129+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:13:134,3.012154,-0.574663,9.314884
06-12 21:20:13.129+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:13.129+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:13:136,2.677568,-0.715454,9.434900
06-12 21:20:13.129+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:13.139+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:13.139+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:13.139+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:13:147,-0.235294,-0.080478,0.131209
06-12 21:20:13.149+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:13:147,-3.710000,1.400000,3.080000
06-12 21:20:13.159+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:13.159+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:13.159+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:13:167,-0.314983,-0.224269,0.220808
06-12 21:20:13.159+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:13:167,-4.200000,1.260000,1.960000
06-12 21:20:13.169+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:13:142,3.013361,-0.594298,9.313262
06-12 21:20:13.169+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:13:145,2.809174,-0.782453,9.473185
06-12 21:20:13.169+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:13.169+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:13.179+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:13.179+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:13.179+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:13:186,-0.258873,-0.293884,0.177949
06-12 21:20:13.179+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:13:186,-2.520000,0.910000,0.630000
06-12 21:20:13.179+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:13:178,3.006909,-0.606041,9.314590
06-12 21:20:13.179+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:13.179+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:13:191,2.996262,-0.624960,9.316772
06-12 21:20:13.179+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:13.189+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:13:178,2.818745,-0.772882,9.449257
06-12 21:20:13.189+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:13.189+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:13:196,2.778067,-0.674776,9.444471
06-12 21:20:13.189+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:13.189+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:13:200,2.691926,-0.830309,9.535398
06-12 21:20:13.189+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:13.199+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:13.199+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:13.199+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:13:208,0.910000,0.840000,-0.210000
06-12 21:20:13.199+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:13:208,-0.300969,-0.330525,0.158299
06-12 21:20:13.199+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:13:195,2.983324,-0.643354,9.319671
06-12 21:20:13.199+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:13.209+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:13:214,2.954150,-0.656655,9.328032
06-12 21:20:13.209+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:13:204,2.737389,-0.918844,9.494720
06-12 21:20:13.209+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:13.209+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:13:221,2.682354,-0.973879,9.477970
06-12 21:20:13.219+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:13.219+0200 I/light   (25492): es.ugr.frailty.light - capturing data
06-12 21:20:13.219+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:13.219+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:13.219+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:13:226,1.610000,0.420000,-1.470000
06-12 21:20:13.219+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:13:231,-0.202404,-0.233475,0.145152
06-12 21:20:13.229+0200 I/light   (25492): es.ugr.frailty.light: SM-R760,12/06/2018,21:20:13:228,11.000000
06-12 21:20:13.229+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:13:230,2.932840,-0.663529,9.334269
06-12 21:20:13.229+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:13.229+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:13:237,2.751746,-0.890130,9.473185
06-12 21:20:13.239+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:13.239+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:13.239+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:13:247,-0.305521,-0.243351,0.349484
06-12 21:20:13.239+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:13:247,2.909131,-0.671117,9.341143
06-12 21:20:13.239+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:13.249+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:13:252,1.400000,-1.610000,-1.890000
06-12 21:20:13.249+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:13.249+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:13:257,2.627320,-0.906880,9.683753
06-12 21:20:13.259+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:13.259+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:13.259+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:13:268,2.909104,-0.671926,9.341092
06-12 21:20:13.259+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:13:267,0.034041,-0.089801,0.151185
06-12 21:20:13.259+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:13.259+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:13:272,0.700000,0.560000,-3.640000
06-12 21:20:13.269+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:13.269+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:13:276,2.943172,-0.760918,9.492328
06-12 21:20:13.279+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:13.279+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:13.279+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:13.279+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:13:286,-0.233929,0.035435,-0.162225
06-12 21:20:13.279+0200 I/heartrate(25441): es.ugr.frailty.heartrate - capturing data
06-12 21:20:13.279+0200 I/heartrate(25441): es.ugr.frailty.heartrate: waiting for rigth values
06-12 21:20:13.279+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:13:287,2.909700,-0.673693,9.340780
06-12 21:20:13.289+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:13:288,-1.890000,1.050000,-2.240000
06-12 21:20:13.289+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer - capturing data
06-12 21:20:13.289+0200 I/accelerometer(25417): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,21:20:13:297,2.675175,-0.636491,9.178867
06-12 21:20:13.299+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:13.299+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:13.299+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:13.309+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,21:20:13:313,-6.510000,-2.310000,-3.360000
06-12 21:20:13.309+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:13:310,2.941157,-0.685668,9.330050
06-12 21:20:13.309+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:13:308,-0.057455,-0.013047,0.230511
06-12 21:20:13.319+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:13.319+0200 I/gravity (25467): es.ugr.frailty.gravity - capturing data
06-12 21:20:13.319+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:13:326,-0.074555,-0.223604,-0.043507
06-12 21:20:13.319+0200 I/gyroscope(25429): es.ugr.frailty.gyroscope - capturing data
06-12 21:20:13.359+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:13.359+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:13:372,-0.310551,0.024603,0.209286
06-12 21:20:13.369+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:13.369+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:13:375,-0.366626,-0.088870,-0.021639
06-12 21:20:13.409+0200 I/gravity (25467): es.ugr.frailty.gravity: SM-R760,12/06/2018,21:20:13:330,2.949835,-0.701772,9.326113
06-12 21:20:13.409+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-12 21:20:13.409+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
06-12 21:20:13.409+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-12 21:20:13.409+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-12 21:20:13.409+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-12 21:20:13.409+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:13.409+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
06-12 21:20:13.409+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
06-12 21:20:13.409+0200 E/CAPI_LOCATION_MANAGER(25516): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-12 21:20:13.409+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:0, msg id:2
06-12 21:20:13.419+0200 W/AUL     (25539): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-12 21:20:13.419+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 21:20:13.429+0200 I/light   (25492): es.ugr.frailty.light - capturing data
06-12 21:20:13.439+0200 I/light   (25492): es.ugr.frailty.light: SM-R760,12/06/2018,21:20:13:445,11.000000
06-12 21:20:13.439+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
06-12 21:20:13.439+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-12 21:20:13.439+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 24935
06-12 21:20:13.439+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-12 21:20:13.469+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 21:20:13.469+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 21:20:13.469+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 21:20:13.469+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 21:20:13.489+0200 I/heartrate(25441): es.ugr.frailty.heartrate - capturing data
06-12 21:20:13.489+0200 I/heartrate(25441): es.ugr.frailty.heartrate: waiting for rigth values
06-12 21:20:13.499+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:13:422,-0.326581,-0.078076,0.202546
06-12 21:20:13.499+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:13.509+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,21:20:13:513,-0.118662,-0.016828,0.117121
06-12 21:20:13.509+0200 I/linearacceleration(25455): es.ugr.frailty.linearacceleration - capturing data
06-12 21:20:13.509+0200 W/CRASH_MANAGER(25538): worker.c: worker_job(1205) > 11254546c6f63152883121
