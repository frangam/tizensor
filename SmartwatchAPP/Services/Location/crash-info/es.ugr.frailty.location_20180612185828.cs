S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 19873
Date: 2018-06-12 18:58:28+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70aa52d, r5   = 0xf728f150
r6   = 0xffe46768, r7   = 0xffe46618
r8   = 0xf72a1c18, r9   = 0x00000000
r10  = 0xffe466f4, fp   = 0xffe46768
ip   = 0x00000001, sp   = 0xffe465f0
lr   = 0xf70aa539, pc   = 0xf7113270
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    123308 KB
Buffers:     47132 KB
Cached:     166784 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11848 KB
VmRSS:       11848 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 19873 TID = 19873
19873 19909 

Maps Information
f3f75000 f4774000 rw-p [stack:19909]
f477b000 f477d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4785000 f4789000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4792000 f4794000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f479c000 f479f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47ae000 f47b3000 r-xp /usr/lib/libsystem.so.0.0.0
f47be000 f47c1000 r-xp /lib/libattr.so.1.1.0
f47c9000 f47d9000 r-xp /usr/lib/libmdm-common.so.1.1.24
f47e1000 f47ea000 r-xp /usr/lib/libedbus.so.1.7.99
f47f2000 f47f3000 r-xp /usr/lib/libresponse.so.0.2.96
f47fc000 f4801000 r-xp /usr/lib/libproc-stat.so.0.2.96
f60a3000 f61a9000 r-xp /usr/lib/libicuuc.so.57.1
f61bf000 f6347000 r-xp /usr/lib/libicui18n.so.57.1
f6357000 f6364000 r-xp /usr/lib/libail.so.0.1.0
f636d000 f6374000 r-xp /usr/lib/libminizip.so.1.0.0
f637d000 f6526000 r-xp /usr/lib/libcrypto.so.1.0.0
f6546000 f658d000 r-xp /usr/lib/libssl.so.1.0.0
f6599000 f659b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f65a3000 f65aa000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65b3000 f65ba000 r-xp /lib/libcrypt-2.13.so
f65eb000 f65ee000 r-xp /lib/libcap.so.2.21
f65f6000 f65f8000 r-xp /usr/lib/libiri.so
f6600000 f6649000 r-xp /usr/lib/libmdm.so.1.2.69
f6651000 f6657000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f665f000 f6682000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f668c000 f668e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6696000 f66b3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66bc000 f66c0000 r-xp /usr/lib/libsmack.so.1.0.0
f66c9000 f66e2000 r-xp /usr/lib/libnetwork.so.0.0.0
f66eb000 f66f3000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f66fb000 f6701000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f670a000 f670c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6715000 f6725000 r-xp /lib/libresolv-2.13.so
f6729000 f6741000 r-xp /usr/lib/liblzma.so.5.0.3
f674a000 f674c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6754000 f676e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6776000 f67a5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67ae000 f67bd000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67c7000 f67d1000 r-xp /usr/lib/libsensord-shared.so
f67da000 f68ad000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68b8000 f68ce000 r-xp /lib/libz.so.1.2.5
f68d6000 f68db000 r-xp /usr/lib/libffi.so.5.0.10
f68e3000 f68e4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f68ec000 f68fc000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6904000 f691d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6925000 f6927000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f692f000 f69a4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69ae000 f69cc000 r-xp /usr/lib/libsystemd.so.0.4.0
f69d6000 f69d7000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f69df000 f6a02000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a0a000 f6a0f000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a17000 f6a41000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a4a000 f6a61000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a69000 f6a6f000 r-xp /lib/librt-2.13.so
f6a78000 f6ae1000 r-xp /lib/libm-2.13.so
f6aea000 f6b7e000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b91000 f6b96000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b9e000 f6ba5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6bad000 f6bd7000 r-xp /usr/lib/libsensor.so.1.9.6
f6be0000 f6cac000 r-xp /usr/lib/libxml2.so.2.7.8
f6cb9000 f6cbb000 r-xp /usr/lib/libiniparser.so.0
f6cc4000 f6cca000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6cd3000 f6da3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6da4000 f6dd8000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6de1000 f6e1d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e25000 f6e28000 r-xp /usr/lib/libbundle.so.0.1.22
f6e30000 f6e36000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e3e000 f6e7f000 r-xp /usr/lib/libeina.so.1.7.99
f6e88000 f6e91000 r-xp /usr/lib/libvconf.so.0.2.45
f6e99000 f6ead000 r-xp /lib/libpthread-2.13.so
f6eb8000 f6ec5000 r-xp /usr/lib/libaul.so.0.1.0
f6ecf000 f6ed1000 r-xp /lib/libdl-2.13.so
f6eda000 f6ee5000 r-xp /lib/libunwind.so.8.0.1
f6f12000 f6f1a000 r-xp /lib/libgcc_s-4.6.so.1
f6f1b000 f703f000 r-xp /lib/libc-2.13.so
f704d000 f7064000 r-xp /usr/lib/libecore.so.1.7.99
f707b000 f707d000 r-xp /usr/lib/libdlog.so.0.0.0
f7085000 f7091000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f709a000 f709f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70a7000 f70b6000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70be000 f70c2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70cb000 f70ce000 r-xp /usr/lib/libappcore-agent.so.1.1
f70d6000 f70d8000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f70e0000 f70e4000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f70ec000 f7109000 r-xp /lib/ld-2.13.so
f7112000 f7115000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7115000 f7119000 r-xp /usr/lib/libsys-assert.so
f7271000 f72e2000 rw-p [heap]
ffe27000 ffe48000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19873)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7113270) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1270
 1: (0xf70aa539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6db13f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6dafc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6dbbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6dc1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6dc1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6df675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6df11f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6dafc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6dbbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6dc1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6dc1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6df3e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6df4017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6df88d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf70e20bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4786171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6859663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d06fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d087a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf705dca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7058b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70595a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7059879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70cc183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70cc7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf711360b) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x160b
28: __libc_start_main + 0x114 (0xf6f3285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7112f74) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf74
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
data
06-12 18:58:28.501+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:509,0.032433,0.001893,-0.004492
06-12 18:58:28.501+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.511+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 18:58:28.511+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
06-12 18:58:28.521+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:28.521+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
06-12 18:58:28.521+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 18:58:28.521+0200 E/CAPI_LOCATION_MANAGER(19941): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-12 18:58:28.531+0200 I/AUL     (19941): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 18:58:28.541+0200 I/heartrate(19862): es.ugr.frailty.heartrate - capturing data
06-12 18:58:28.541+0200 I/heartrate(19862): es.ugr.frailty.heartrate: waiting for rigth values
06-12 18:58:28.541+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:431,0.140000,0.140000,0.070000
06-12 18:58:28.541+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.551+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:555,0.070000,0.070000,0.070000
06-12 18:58:28.551+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.561+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:563,0.070000,0.140000,0.070000
06-12 18:58:28.561+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.561+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:28.571+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:573,0.070000,0.070000,0.070000
06-12 18:58:28.571+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.571+0200 I/AUL     (19941): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 18:58:28.571+0200 E/LOCATION(19941): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
06-12 18:58:28.571+0200 I/LOCATION(19941): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
06-12 18:58:28.571+0200 I/LOCATION(19941): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-12 18:58:28.571+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:580,0.140000,0.070000,0.070000
06-12 18:58:28.571+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.581+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:585,0.070000,-0.070000,0.070000
06-12 18:58:28.581+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.591+0200 I/light   (19911): es.ugr.frailty.light - capturing data
06-12 18:58:28.591+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 18:58:28.591+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 18:58:28.591+0200 I/light   (19911): es.ugr.frailty.light: SM-R760,12/06/2018,18:58:28:599,93.000000
06-12 18:58:28.601+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:28:527,9.734003,-0.995414,0.983450
06-12 18:58:28.601+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:28.601+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:590,0.140000,0.070000,0.070000
06-12 18:58:28.601+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:28:611,9.769895,-0.995414,0.981057
06-12 18:58:28.601+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:28.601+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.611+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:28:574,9.708985,-0.999251,0.952624
06-12 18:58:28.611+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:28.611+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:615,0.140000,0.070000,0.070000
06-12 18:58:28.611+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:28:616,9.708818,-0.999231,0.954343
06-12 18:58:28.611+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:28.621+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:513,0.044283,0.025931,0.013538
06-12 18:58:28.621+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.621+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.621+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:626,0.068223,0.016402,-0.017656
06-12 18:58:28.621+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.631+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:627,0.070000,0.070000,0.070000
06-12 18:58:28.631+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.641+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:642,0.070000,0.210000,0.070000
06-12 18:58:28.641+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.641+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:28:622,9.708682,-0.999189,0.955770
06-12 18:58:28.641+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:28:615,9.753145,-1.007378,0.969093
06-12 18:58:28.641+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:28.651+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:28.661+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:653,0.070000,0.140000,0.070000
06-12 18:58:28.671+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.671+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:630,0.032271,-0.018330,-0.006376
06-12 18:58:28.671+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.671+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:28:655,9.760324,-1.012164,0.930808
06-12 18:58:28.671+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:28.681+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:676,0.070000,0.140000,0.140000
06-12 18:58:28.681+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.681+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:28:657,9.708556,-0.999644,0.956574
06-12 18:58:28.681+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:28.681+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:686,0.070000,0.140000,0.070000
06-12 18:58:28.681+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:28:688,9.708618,-1.000215,0.955348
06-12 18:58:28.681+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:28.681+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:28:691,9.708516,-1.001936,0.954584
06-12 18:58:28.681+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:28.691+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.691+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:678,0.053632,0.002375,-0.010247
06-12 18:58:28.691+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.691+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:28:682,9.745967,-1.036092,0.937986
06-12 18:58:28.691+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:28.701+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:696,0.070000,0.070000,0.070000
06-12 18:58:28.701+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:702,0.072832,-0.027777,-0.040948
06-12 18:58:28.701+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.701+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.701+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:709,0.055971,-0.013771,-0.016249
06-12 18:58:28.701+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.711+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:709,0.070000,0.070000,0.070000
06-12 18:58:28.711+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:28:704,9.741181,-0.985843,0.940379
06-12 18:58:28.711+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.711+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:28.711+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:28:720,9.767502,-1.019342,0.949951
06-12 18:58:28.711+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:720,0.070000,0.070000,0.070000
06-12 18:58:28.721+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:713,0.060686,0.023334,-0.011851
06-12 18:58:28.721+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:28.731+0200 I/LOCATION(19873): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-12 18:58:28.731+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.731+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.731+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:28:695,9.708644,-1.001241,0.954009
06-12 18:58:28.731+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:28.741+0200 I/heartrate(19862): es.ugr.frailty.heartrate - capturing data
06-12 18:58:28.741+0200 I/heartrate(19862): es.ugr.frailty.heartrate: waiting for rigth values
06-12 18:58:28.741+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:28:742,9.708541,-1.002176,0.954077
06-12 18:58:28.741+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:28.741+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:740,0.072660,0.014383,0.017409
06-12 18:58:28.751+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:743,0.070000,0.210000,0.070000
06-12 18:58:28.761+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:28:747,9.708343,-1.004361,0.953797
06-12 18:58:28.761+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:28.761+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:28:767,9.708447,-1.003840,0.953291
06-12 18:58:28.761+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:28:736,9.760324,-1.048056,0.945165
06-12 18:58:28.761+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:28.761+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:28.761+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.761+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:28:771,9.708694,-1.002459,0.952215
06-12 18:58:28.761+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:28.771+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.771+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:28:775,9.708707,-1.001531,0.953061
06-12 18:58:28.771+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:28.771+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:28:781,9.708891,-0.999951,0.952845
06-12 18:58:28.771+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:28.781+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:776,0.048576,-0.015453,0.010636
06-12 18:58:28.781+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:28:784,9.708938,-1.000672,0.951610
06-12 18:58:28.781+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:28.781+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:779,0.070000,0.140000,0.070000
06-12 18:58:28.781+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:28:773,9.791430,-0.995414,0.942772
06-12 18:58:28.781+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:28.781+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:28:789,9.708828,-1.002276,0.951050
06-12 18:58:28.781+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.791+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:793,0.017488,0.031788,0.007423
06-12 18:58:28.791+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.791+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 18:58:28.791+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 18:58:28.791+0200 I/light   (19911): es.ugr.frailty.light - capturing data
06-12 18:58:28.791+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.791+0200 I/light   (19911): es.ugr.frailty.light: SM-R760,12/06/2018,18:58:28:801,93.000000
06-12 18:58:28.791+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:28.801+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:28:805,9.709071,-1.001169,0.949731
06-12 18:58:28.801+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:797,0.063094,0.006345,0.011670
06-12 18:58:28.801+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.801+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:28:793,9.745967,-0.973879,0.928415
06-12 18:58:28.801+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:28.811+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:813,0.060626,-0.028515,0.013395
06-12 18:58:28.811+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.811+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:804,0.070000,0.140000,0.070000
06-12 18:58:28.811+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:28.811+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.811+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:28:816,9.729217,-0.985843,0.976272
06-12 18:58:28.811+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:28:820,9.708805,-1.002718,0.950808
06-12 18:58:28.821+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:817,0.036711,-0.009700,-0.011002
06-12 18:58:28.821+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.821+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:827,0.096738,0.005999,0.002649
06-12 18:58:28.821+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.831+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:832,0.065628,0.016005,0.005532
06-12 18:58:28.831+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:28.831+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.831+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:28.831+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:823,0.140000,0.070000,0.070000
06-12 18:58:28.831+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:28:839,9.708567,-1.003631,0.952280
06-12 18:58:28.831+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.841+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:837,0.041638,-0.006099,0.043853
06-12 18:58:28.841+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.841+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:847,0.084599,-0.035799,-0.006305
06-12 18:58:28.841+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.841+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:28:837,9.784252,-0.971486,0.949951
06-12 18:58:28.841+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:844,0.140000,-0.140000,0.070000
06-12 18:58:28.841+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:851,0.015446,0.026736,0.015514
06-12 18:58:28.841+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.841+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:28.851+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:854,0.075363,0.035366,0.018450
06-12 18:58:28.851+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.851+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:28.851+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.851+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:28:861,9.708651,-1.003186,0.951897
06-12 18:58:28.861+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:858,0.025082,0.005449,0.031867
06-12 18:58:28.861+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.861+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:869,0.060973,0.005449,0.029474
06-12 18:58:28.861+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.861+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:28:856,9.726824,-1.012164,0.923629
06-12 18:58:28.871+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:28.871+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:873,0.044327,-0.008148,0.014750
06-12 18:58:28.871+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.871+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:861,0.140000,0.070000,0.070000
06-12 18:58:28.871+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:28.871+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.871+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:28:880,9.708875,-1.001582,0.951295
06-12 18:58:28.881+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:877,0.051641,-0.012975,-0.024962
06-12 18:58:28.881+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.881+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:28:876,9.765109,-1.036092,0.940379
06-12 18:58:28.881+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:887,0.037411,-0.036448,-0.018587
06-12 18:58:28.881+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.881+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:28.881+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:883,0.070000,0.070000,0.070000
06-12 18:58:28.881+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:891,0.032563,0.014372,-0.014969
06-12 18:58:28.881+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.881+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.891+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:28.891+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:28:899,9.708949,-1.001756,0.950359
06-12 18:58:28.891+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:895,0.058986,-0.017407,-0.004633
06-12 18:58:28.891+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.901+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:905,0.051680,-0.046816,-0.008844
06-12 18:58:28.901+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.901+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:28:893,9.762716,-0.978664,0.923629
06-12 18:58:28.901+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:909,0.082890,0.006762,-0.011305
06-12 18:58:28.901+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.901+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:28.911+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:904,0.070000,0.070000,0.070000
06-12 18:58:28.911+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:913,0.037624,0.030482,-0.025381
06-12 18:58:28.911+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.911+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:28.911+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:28:919,9.708783,-1.002150,0.951636
06-12 18:58:28.911+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.921+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:917,0.020770,0.017998,0.022981
06-12 18:58:28.921+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.921+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:28:915,9.745967,-1.033699,0.971486
06-12 18:58:28.921+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:926,0.075558,0.030973,-0.002264
06-12 18:58:28.921+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.921+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:28.921+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:930,0.018117,-0.010633,-0.029432
06-12 18:58:28.921+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.931+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:923,-0.070000,0.070000,0.070000
06-12 18:58:28.931+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:28.931+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.931+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:28:939,9.708903,-1.001491,0.951098
06-12 18:58:28.931+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:935,0.056218,-0.036141,-0.012466
06-12 18:58:28.931+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.941+0200 I/heartrate(19862): es.ugr.frailty.heartrate - capturing data
06-12 18:58:28.941+0200 I/heartrate(19862): es.ugr.frailty.heartrate: waiting for rigth values
06-12 18:58:28.941+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:945,0.053779,0.022008,-0.027980
06-12 18:58:28.941+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.941+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:28:936,9.722038,-1.024128,0.988236
06-12 18:58:28.941+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:949,0.037139,-0.031424,0.020436
06-12 18:58:28.941+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.941+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:28.941+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:942,0.070000,0.070000,0.070000
06-12 18:58:28.951+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:953,0.012967,-0.022959,0.038505
06-12 18:58:28.951+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.951+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.951+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:28.951+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:959,0.070000,-0.140000,0.070000
06-12 18:58:28.951+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:28:961,9.709010,-1.000000,0.951581
06-12 18:58:28.961+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:957,0.070662,0.002518,0.001535
06-12 18:58:28.961+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.961+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:967,0.020650,0.036930,-0.016686
06-12 18:58:28.961+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.961+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:28:955,9.779467,-1.000200,0.952343
06-12 18:58:28.961+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:971,0.044495,-0.001799,-0.021089
06-12 18:58:28.961+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.971+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:28.971+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.971+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:28.971+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:28:980,9.709023,-0.998977,0.952519
06-12 18:58:28.971+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:975,0.084949,-0.012975,0.029762
06-12 18:58:28.971+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.981+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:28:976,9.729217,-0.966700,0.935594
06-12 18:58:28.981+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:980,0.070000,-0.070000,0.070000
06-12 18:58:28.981+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:985,0.063338,0.013520,-0.012373
06-12 18:58:28.981+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.981+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:989,0.037184,0.035450,0.005493
06-12 18:58:28.981+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.981+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:28.991+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:28.991+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:993,0.060991,0.018041,0.027566
06-12 18:58:28.991+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:28.991+0200 I/light   (19911): es.ugr.frailty.light - capturing data
06-12 18:58:28.991+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 18:58:28.991+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 18:58:28.991+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:29.001+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:29:2,9.709227,-0.998846,0.950580
06-12 18:58:29.001+0200 I/light   (19911): es.ugr.frailty.light: SM-R760,12/06/2018,18:58:28:999,94.000000
06-12 18:58:29.001+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:28:994,9.753145,-1.004985,0.930808
06-12 18:58:29.001+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:29.001+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:28:997,0.010635,0.004586,-0.037523
06-12 18:58:29.001+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:29.001+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:28:997,0.070000,0.070000,0.070000
06-12 18:58:29.011+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:29.011+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:29:13,0.051300,0.008349,-0.002568
06-12 18:58:29.011+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:29.011+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:29:16,0.070000,0.070000,0.070000
06-12 18:58:29.011+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:29:19,9.709317,-0.998272,0.950259
06-12 18:58:29.011+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:29.011+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:29:11,9.793823,-1.014557,0.981057
06-12 18:58:29.021+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:29.021+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:29:23,0.070240,-0.025283,0.028084
06-12 18:58:29.021+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:29.021+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:29:28,0.070000,0.070000,0.070000
06-12 18:58:29.021+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:29.031+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:29:27,9.772287,-0.988236,0.937986
06-12 18:58:29.031+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:29.031+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:29.031+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:29.031+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:29:40,9.745967,-0.966700,0.957129
06-12 18:58:29.041+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:29.041+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:29:40,9.709131,-0.999193,0.951193
06-12 18:58:29.041+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:29:43,0.048613,0.005251,0.006870
06-12 18:58:29.041+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:29:46,9.769895,-0.983450,0.978664
06-12 18:58:29.041+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:29.041+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:29:51,9.719646,-0.995414,0.914058
06-12 18:58:29.051+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:29.051+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:29:57,9.760324,-0.990629,0.949951
06-12 18:58:29.051+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:29.061+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:29.061+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:29.061+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:29:62,9.779467,-1.024128,0.978664
06-12 18:58:29.061+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:29.071+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:29:32,0.070000,0.140000,0.070000
06-12 18:58:29.071+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:29.071+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:29:69,9.709135,-0.998878,0.951489
06-12 18:58:29.071+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:29.071+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:29:67,0.051192,0.018135,-0.025171
06-12 18:58:29.071+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:29:74,9.757930,-0.993021,0.957129
06-12 18:58:29.071+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:29.081+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:29:86,9.760324,-0.981057,0.926022
06-12 18:58:29.081+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:29.081+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:29:91,9.777073,-1.024128,0.930808
06-12 18:58:29.091+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:29.091+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:29.101+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:29:81,9.709339,-0.998025,0.950299
06-12 18:58:29.101+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:29.101+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:29:103,9.745967,-1.004985,0.935594
06-12 18:58:29.101+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:29:96,0.067938,-0.025250,-0.020681
06-12 18:58:29.101+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:29:106,9.709321,-0.999147,0.949298
06-12 18:58:29.101+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:29.101+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:29:111,0.036628,-0.006960,-0.014706
06-12 18:58:29.111+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:29:77,-0.140000,0.140000,0.070000
06-12 18:58:29.111+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:29.111+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:29.111+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:29:119,9.762716,-1.021735,0.969093
06-12 18:58:29.111+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:29:119,0.053395,-0.022588,0.019795
06-12 18:58:29.111+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:29.111+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:29.121+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:29:123,9.709391,-0.999342,0.948387
06-12 18:58:29.121+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:29:124,0.070000,-0.070000,0.070000
06-12 18:58:29.121+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:29.131+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:29:129,0.070000,-0.070000,0.070000
06-12 18:58:29.131+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:29.131+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 18:58:29.131+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 18:58:29.131+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 18:58:29.131+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 18:58:29.131+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:29.131+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:29.131+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:29:140,9.734003,-1.009771,0.964308
06-12 18:58:29.131+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:29:141,9.709239,-1.000215,0.949012
06-12 18:58:29.131+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:29.141+0200 I/heartrate(19862): es.ugr.frailty.heartrate - capturing data
06-12 18:58:29.141+0200 I/heartrate(19862): es.ugr.frailty.heartrate: waiting for rigth values
06-12 18:58:29.141+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:29:144,0.024612,-0.010429,0.015921
06-12 18:58:29.141+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:29:145,0.070000,-0.070000,0.070000
06-12 18:58:29.141+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:29.141+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:29:151,0.070000,-0.070000,0.070000
06-12 18:58:29.151+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:29.151+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:29.151+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:29.161+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:29:164,9.709147,-1.000627,0.949520
06-12 18:58:29.161+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:29.161+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:29:168,0.060656,-0.004771,0.041616
06-12 18:58:29.171+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:29:161,9.769895,-1.004985,0.990629
06-12 18:58:29.171+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:29.181+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:29:157,0.070000,0.070000,0.070000
06-12 18:58:29.181+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:29.181+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:29:182,9.765109,-1.024128,0.940379
06-12 18:58:29.181+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:29:188,0.070000,0.070000,0.070000
06-12 18:58:29.181+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:29.191+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:29.191+0200 I/light   (19911): es.ugr.frailty.light - capturing data
06-12 18:58:29.191+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 18:58:29.191+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 18:58:29.191+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:29.201+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:29.201+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:29:203,9.755538,-0.985843,0.985843
06-12 18:58:29.201+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:29:194,0.070000,0.070000,0.070000
06-12 18:58:29.201+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:29.211+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:29:211,-0.070000,-0.070000,0.070000
06-12 18:58:29.211+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:29.211+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:29:217,-0.070000,-0.070000,0.070000
06-12 18:58:29.211+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:29.211+0200 I/light   (19911): es.ugr.frailty.light: SM-R760,12/06/2018,18:58:29:200,95.000000
06-12 18:58:29.221+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:29:196,0.055962,-0.023501,-0.009141
06-12 18:58:29.231+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:29:224,9.789038,-1.021735,0.947558
06-12 18:58:29.231+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:29.231+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:29:239,-0.070000,-0.070000,0.070000
06-12 18:58:29.231+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:29.241+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:29.241+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:29:206,9.708997,-1.000619,0.951068
06-12 18:58:29.241+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:29.241+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:29:247,9.743573,-1.024128,0.969093
06-12 18:58:29.241+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:29:243,-0.070000,-0.070000,0.070000
06-12 18:58:29.241+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:29:249,9.708985,-1.001544,0.950205
06-12 18:58:29.241+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:29.241+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:29.251+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:29.251+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:29:254,-0.070000,-0.070000,0.070000
06-12 18:58:29.251+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:29.251+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:29.251+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:29:261,9.743573,-1.031307,0.971486
06-12 18:58:29.251+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:29:256,0.046541,0.014776,0.034775
06-12 18:58:29.261+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:29.261+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:29:259,-0.070000,-0.070000,0.070000
06-12 18:58:29.261+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:29.261+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:29:266,0.080052,-0.020192,-0.002647
06-12 18:58:29.261+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:29.271+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:29:253,9.708942,-1.000660,0.951577
06-12 18:58:29.271+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:29:273,-0.070000,-0.070000,0.070000
06-12 18:58:29.271+0200 I/gravity (19886): es.ugr.frailty.gravity - capturing data
06-12 18:58:29.271+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:29.271+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:29.271+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:29:280,9.779467,-0.990629,0.952343
06-12 18:58:29.281+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:29:279,-0.070000,-0.070000,0.070000
06-12 18:58:29.281+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:29.281+0200 I/gravity (19886): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:58:29:278,9.708936,-1.001352,0.950920
06-12 18:58:29.291+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:29.301+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:29:303,9.796216,-1.021735,0.983450
06-12 18:58:29.301+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:58:29:289,0.070000,-0.070000,0.070000
06-12 18:58:29.311+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:58:29:274,0.034631,-0.023468,0.017516
06-12 18:58:29.311+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:29.311+0200 I/linearacceleration(19875): es.ugr.frailty.linearacceleration - capturing data
06-12 18:58:29.311+0200 I/gyroscope(19849): es.ugr.frailty.gyroscope - capturing data
06-12 18:58:29.341+0200 I/heartrate(19862): es.ugr.frailty.heartrate - capturing data
06-12 18:58:29.341+0200 I/heartrate(19862): es.ugr.frailty.heartrate: waiting for rigth values
06-12 18:58:29.341+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:29:344,9.779467,-0.985843,0.935594
06-12 18:58:29.341+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer - capturing data
06-12 18:58:29.351+0200 I/accelerometer(19836): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:58:29:353,9.755538,-1.004985,0.957129
06-12 18:58:29.381+0200 W/AUL     (19960): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-12 18:58:29.391+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 18:58:29.391+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 18:58:29.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
06-12 18:58:29.401+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-12 18:58:29.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 19587
06-12 18:58:29.401+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-12 18:58:29.451+0200 I/light   (19911): es.ugr.frailty.light - capturing data
06-12 18:58:29.461+0200 I/light   (19911): es.ugr.frailty.light: SM-R760,12/06/2018,18:58:29:464,97.000000
06-12 18:58:29.461+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 18:58:29.461+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,G)
06-12 18:58:29.461+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
06-12 18:58:29.461+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 18:58:29.471+0200 W/CRASH_MANAGER(19956): worker.c: worker_job(1205) > 11198736c6f63152882270
