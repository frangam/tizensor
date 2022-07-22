S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 23184
Date: 2018-06-07 17:38:37+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6fc252d, r5   = 0xf73a1f98
r6   = 0xffd28d60, r7   = 0xffd28c10
r8   = 0xf739ec18, r9   = 0x00000000
r10  = 0xffd28cec, fp   = 0xffd28d60
ip   = 0x00000001, sp   = 0xffd28be8
lr   = 0xf6fc2539, pc   = 0xf702b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    287512 KB
Buffers:      7964 KB
Cached:     106416 KB
VmPeak:      53460 KB
VmSize:      53432 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11828 KB
VmRSS:       11824 KB
VmData:      11160 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 23184 TID = 23184
23184 23260 

Maps Information
f3e8d000 f468c000 rw-p [stack:23260]
f4693000 f4695000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f469d000 f46a1000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f46aa000 f46ac000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f46b4000 f46b7000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f46c6000 f46cb000 r-xp /usr/lib/libsystem.so.0.0.0
f46d6000 f46d9000 r-xp /lib/libattr.so.1.1.0
f46e1000 f46f1000 r-xp /usr/lib/libmdm-common.so.1.1.24
f46f9000 f4702000 r-xp /usr/lib/libedbus.so.1.7.99
f470a000 f470b000 r-xp /usr/lib/libresponse.so.0.2.96
f4714000 f4719000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5fbb000 f60c1000 r-xp /usr/lib/libicuuc.so.57.1
f60d7000 f625f000 r-xp /usr/lib/libicui18n.so.57.1
f626f000 f627c000 r-xp /usr/lib/libail.so.0.1.0
f6285000 f628c000 r-xp /usr/lib/libminizip.so.1.0.0
f6295000 f643e000 r-xp /usr/lib/libcrypto.so.1.0.0
f645e000 f64a5000 r-xp /usr/lib/libssl.so.1.0.0
f64b1000 f64b3000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f64bb000 f64c2000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f64cb000 f64d2000 r-xp /lib/libcrypt-2.13.so
f6503000 f6506000 r-xp /lib/libcap.so.2.21
f650e000 f6510000 r-xp /usr/lib/libiri.so
f6518000 f6561000 r-xp /usr/lib/libmdm.so.1.2.69
f6569000 f656f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6577000 f659a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f65a4000 f65a6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f65ae000 f65cb000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f65d4000 f65d8000 r-xp /usr/lib/libsmack.so.1.0.0
f65e1000 f65fa000 r-xp /usr/lib/libnetwork.so.0.0.0
f6603000 f660b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6613000 f6619000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6622000 f6624000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f662d000 f663d000 r-xp /lib/libresolv-2.13.so
f6641000 f6659000 r-xp /usr/lib/liblzma.so.5.0.3
f6662000 f6664000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f666c000 f6686000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f668e000 f66bd000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f66c6000 f66d5000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f66df000 f66e9000 r-xp /usr/lib/libsensord-shared.so
f66f2000 f67c5000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f67d0000 f67e6000 r-xp /lib/libz.so.1.2.5
f67ee000 f67f3000 r-xp /usr/lib/libffi.so.5.0.10
f67fb000 f67fc000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6804000 f6814000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f681c000 f6835000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f683d000 f683f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6847000 f68bc000 r-xp /usr/lib/libsqlite3.so.0.8.6
f68c6000 f68cc000 r-xp /lib/librt-2.13.so
f68d5000 f68f3000 r-xp /usr/lib/libsystemd.so.0.4.0
f68fd000 f68fe000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6906000 f6929000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6931000 f6936000 r-xp /usr/lib/libxdgmime.so.1.1.0
f693e000 f6968000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6971000 f6988000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6990000 f69f9000 r-xp /lib/libm-2.13.so
f6a02000 f6a96000 r-xp /usr/lib/libstdc++.so.6.0.16
f6aa9000 f6aae000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ab6000 f6abd000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ac5000 f6aef000 r-xp /usr/lib/libsensor.so.1.9.6
f6af8000 f6bc4000 r-xp /usr/lib/libxml2.so.2.7.8
f6bd1000 f6bd3000 r-xp /usr/lib/libiniparser.so.0
f6bdc000 f6be2000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6beb000 f6cbb000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6cbc000 f6cf0000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6cf9000 f6d35000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6d3d000 f6d40000 r-xp /usr/lib/libbundle.so.0.1.22
f6d48000 f6d4e000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d56000 f6d97000 r-xp /usr/lib/libeina.so.1.7.99
f6da0000 f6db7000 r-xp /usr/lib/libecore.so.1.7.99
f6dce000 f6dd7000 r-xp /usr/lib/libvconf.so.0.2.45
f6ddf000 f6df3000 r-xp /lib/libpthread-2.13.so
f6dfe000 f6e0b000 r-xp /usr/lib/libaul.so.0.1.0
f6e15000 f6e17000 r-xp /lib/libdl-2.13.so
f6e20000 f6e2b000 r-xp /lib/libunwind.so.8.0.1
f6e58000 f6e60000 r-xp /lib/libgcc_s-4.6.so.1
f6e61000 f6f85000 r-xp /lib/libc-2.13.so
f6f93000 f6f95000 r-xp /usr/lib/libdlog.so.0.0.0
f6f9d000 f6fa9000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6fb2000 f6fb7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6fbf000 f6fce000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f6fd6000 f6fda000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6fe3000 f6fe6000 r-xp /usr/lib/libappcore-agent.so.1.1
f6fee000 f6ff0000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f6ff8000 f6ffc000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7004000 f7021000 r-xp /lib/ld-2.13.so
f702a000 f702d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f702d000 f7031000 r-xp /usr/lib/libsys-assert.so
f736e000 f73db000 rw-p [heap]
ffd0a000 ffd2b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:23184)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf702b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf6fc2539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6cc93f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6cc7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6cd3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6cd9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6cd9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6d0e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6d091f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6cc7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6cd3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6cd9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6cd9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6d0be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6d0c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6d13f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf46ab1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf469e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6771663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6c1efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6c207a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6db0ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6dabb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6dac5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6dac879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf6fe4183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf6fe47fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf702b5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6e7885c) [/lib/libc.so.6] + 0x1785c
29: (0xf702af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
0.033562,-0.019167,0.116440
06-07 17:38:37.051+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.051+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:49,0.332602,-0.093320,9.918249
06-07 17:38:37.051+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.051+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:57,0.300054,-0.074831,9.801773
06-07 17:38:37.051+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:58,0.070000,0.070000,0.070000
06-07 17:38:37.061+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.061+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.071+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:72,0.018191,-0.061560,0.078191
06-07 17:38:37.071+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.071+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:70,0.318245,-0.136391,9.879964
06-07 17:38:37.071+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.071+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:79,0.300700,-0.077467,9.801733
06-07 17:38:37.081+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:82,0.070000,0.070000,0.140000
06-07 17:38:37.081+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.081+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.081+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.091+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:91,0.339781,-0.105284,9.872787
06-07 17:38:37.091+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:92,0.039080,-0.027818,0.071054
06-07 17:38:37.091+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.091+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:90,0.070000,0.070000,0.070000
06-07 17:38:37.091+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:97,0.302121,-0.078556,9.801681
06-07 17:38:37.101+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.101+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.101+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:110,0.332602,-0.086142,9.839286
06-07 17:38:37.101+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:111,0.030481,-0.007586,0.037605
06-07 17:38:37.101+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.111+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.111+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:115,0.303054,-0.078733,9.801650
06-07 17:38:37.111+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:117,0.070000,0.070000,0.070000
06-07 17:38:37.121+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.121+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.121+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.121+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:131,0.303888,-0.052642,9.899107
06-07 17:38:37.131+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:131,0.000834,0.026091,0.097457
06-07 17:38:37.131+0200 I/heartrate(23168): es.ugr.frailty.heartrate - capturing data
06-07 17:38:37.131+0200 I/heartrate(23168): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:38:37.131+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.131+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:139,0.302504,-0.077286,9.801679
06-07 17:38:37.131+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:130,0.070000,0.070000,0.140000
06-07 17:38:37.141+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.141+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.141+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.151+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:150,0.323031,-0.074178,9.820145
06-07 17:38:37.151+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:151,0.020527,0.003108,0.018466
06-07 17:38:37.151+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.151+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:149,0.070000,0.070000,0.140000
06-07 17:38:37.151+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:157,0.302948,-0.076971,9.801667
06-07 17:38:37.161+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.161+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.171+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.171+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:172,0.034440,-0.018742,0.075904
06-07 17:38:37.171+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.171+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:177,0.337388,-0.095713,9.877571
06-07 17:38:37.171+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:179,0.304060,-0.077649,9.801627
06-07 17:38:37.181+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:170,0.070000,0.070000,0.140000
06-07 17:38:37.181+0200 I/light   (23223): es.ugr.frailty.light - capturing data
06-07 17:38:37.181+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.181+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.191+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:192,0.299103,-0.122034,9.879964
06-07 17:38:37.191+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:192,-0.004957,-0.044385,0.078337
06-07 17:38:37.191+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.191+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:38:37.191+0200 I/light   (23223): es.ugr.frailty.light: SM-R760,07/06/2018,17:38:37:191,1414.000000
06-07 17:38:37.191+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:38:37.191+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.191+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:198,0.303352,-0.079539,9.801635
06-07 17:38:37.201+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.201+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.201+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:209,0.315853,-0.112463,9.927821
06-07 17:38:37.211+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:211,0.012501,-0.032924,0.126186
06-07 17:38:37.211+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.211+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:203,0.070000,0.070000,0.070000
06-07 17:38:37.211+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.221+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:217,0.303418,-0.080850,9.801621
06-07 17:38:37.221+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.221+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.221+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:223,0.070000,0.070000,0.070000
06-07 17:38:37.221+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.231+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.231+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:231,-0.018673,-0.053148,0.107057
06-07 17:38:37.231+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:235,0.301967,-0.083158,9.801647
06-07 17:38:37.241+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:231,0.284746,-0.133998,9.908678
06-07 17:38:37.241+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:236,0.070000,0.070000,0.070000
06-07 17:38:37.241+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.241+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.241+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.241+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.251+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:253,0.301572,-0.083895,9.801653
06-07 17:38:37.251+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:250,0.001921,-0.019734,0.059175
06-07 17:38:37.251+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:251,0.070000,0.070000,0.070000
06-07 17:38:37.251+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:255,0.303888,-0.102891,9.860823
06-07 17:38:37.261+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.261+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.261+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.271+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:275,0.016673,-0.002247,0.118989
06-07 17:38:37.271+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.271+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:271,0.318245,-0.086142,9.920642
06-07 17:38:37.271+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:273,0.070000,0.070000,0.070000
06-07 17:38:37.271+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:280,0.301743,-0.083783,9.801649
06-07 17:38:37.281+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.281+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.281+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.291+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.291+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:290,-0.070000,0.070000,0.140000
06-07 17:38:37.291+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:295,0.303431,-0.086622,9.801572
06-07 17:38:37.291+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:292,0.028467,-0.059786,0.080709
06-07 17:38:37.291+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:292,0.330210,-0.143569,9.882358
06-07 17:38:37.301+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.301+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.301+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.301+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:310,0.012421,-0.021055,0.068822
06-07 17:38:37.311+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.311+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:315,0.304071,-0.087711,9.801542
06-07 17:38:37.311+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:311,-0.070000,0.070000,0.070000
06-07 17:38:37.311+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:310,0.315853,-0.107677,9.870394
06-07 17:38:37.321+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.321+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.321+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.331+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.331+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:332,0.296710,-0.045464,9.875179
06-07 17:38:37.331+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:330,-0.070000,0.070000,0.070000
06-07 17:38:37.341+0200 I/heartrate(23168): es.ugr.frailty.heartrate - capturing data
06-07 17:38:37.341+0200 I/heartrate(23168): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:38:37.341+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:331,-0.007361,0.042248,0.073637
06-07 17:38:37.341+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.341+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.341+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.351+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:350,0.023979,-0.017117,0.059256
06-07 17:38:37.351+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:336,0.303837,-0.085775,9.801567
06-07 17:38:37.351+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:351,0.327817,-0.102891,9.860823
06-07 17:38:37.351+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.351+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:354,0.070000,0.070000,0.070000
06-07 17:38:37.361+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.371+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.371+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:374,0.275175,-0.066999,9.865608
06-07 17:38:37.381+0200 I/light   (23223): es.ugr.frailty.light - capturing data
06-07 17:38:37.391+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:38:37.391+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:38:37.401+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.401+0200 I/light   (23223): es.ugr.frailty.light: SM-R760,07/06/2018,17:38:37:393,1064.000000
06-07 17:38:37.411+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:379,0.070000,0.070000,0.070000
06-07 17:38:37.411+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.441+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:418,-0.029325,0.019379,0.064067
06-07 17:38:37.441+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.451+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:363,0.304499,-0.086378,9.801541
06-07 17:38:37.451+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.451+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.451+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:450,0.029943,0.006279,0.066392
06-07 17:38:37.461+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:38:37.461+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:38:37.461+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:38:37.461+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.471+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:459,0.302660,-0.085242,9.801608
06-07 17:38:37.471+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:469,0.036299,0.034513,0.073593
06-07 17:38:37.471+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.471+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.471+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:407,0.332602,-0.078963,9.868000
06-07 17:38:37.481+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.481+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:481,0.303482,-0.084762,9.801586
06-07 17:38:37.481+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.491+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:492,0.303865,-0.082784,9.801592
06-07 17:38:37.491+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:483,0.057451,-0.048822,0.073587
06-07 17:38:37.491+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.491+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:497,0.043570,-0.011099,0.044949
06-07 17:38:37.491+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:458,0.070000,0.070000,0.070000
06-07 17:38:37.491+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.501+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.501+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.501+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:491,0.339781,-0.050249,9.875179
06-07 17:38:37.511+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:511,0.061473,0.013129,0.033027
06-07 17:38:37.511+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.511+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:501,0.305782,-0.084614,9.801517
06-07 17:38:37.511+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.511+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.511+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:508,0.140000,0.210000,0.070000
06-07 17:38:37.511+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.521+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:522,-0.000207,-0.042689,0.064185
06-07 17:38:37.521+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:519,0.307022,-0.084914,9.801475
06-07 17:38:37.521+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.521+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.521+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:529,0.308881,-0.084130,9.801423
06-07 17:38:37.531+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:519,0.361316,-0.131605,9.875179
06-07 17:38:37.531+0200 I/heartrate(23168): es.ugr.frailty.heartrate - capturing data
06-07 17:38:37.531+0200 I/heartrate(23168): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:38:37.531+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.531+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:525,0.140000,0.210000,0.070000
06-07 17:38:37.531+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:534,-0.014129,0.026114,0.021116
06-07 17:38:37.531+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.541+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.541+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.541+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:544,0.308446,-0.085934,9.801421
06-07 17:38:37.541+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:546,-0.001094,-0.061476,-0.000466
06-07 17:38:37.541+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.541+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.551+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:540,0.349352,-0.095713,9.846465
06-07 17:38:37.551+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:556,-0.003241,-0.051590,0.092870
06-07 17:38:37.551+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.551+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:550,0.070000,0.210000,0.140000
06-07 17:38:37.551+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:553,0.307376,-0.084486,9.801468
06-07 17:38:37.551+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.561+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.561+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:562,0.307130,-0.087194,9.801452
06-07 17:38:37.561+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.561+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.561+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:562,0.368495,-0.071785,9.834501
06-07 17:38:37.561+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.571+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:566,0.070000,0.210000,0.070000
06-07 17:38:37.571+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:573,0.006623,-0.015842,0.018704
06-07 17:38:37.571+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:568,0.306837,-0.089442,9.801440
06-07 17:38:37.571+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.571+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.571+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:581,0.307031,-0.090058,9.801429
06-07 17:38:37.581+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:578,0.308674,-0.126820,9.865608
06-07 17:38:37.581+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.581+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.581+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.581+0200 I/light   (23223): es.ugr.frailty.light - capturing data
06-07 17:38:37.591+0200 I/light   (23223): es.ugr.frailty.light: SM-R760,07/06/2018,17:38:37:593,1473.000000
06-07 17:38:37.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:38:37.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:38:37.591+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:585,0.070000,0.070000,0.070000
06-07 17:38:37.601+0200 W/LOCATION(23184): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:38:37.601+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:605,0.306233,-0.089323,9.801460
06-07 17:38:37.611+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:592,-0.005535,0.011095,0.080929
06-07 17:38:37.611+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.611+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.611+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.621+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:619,0.070000,0.070000,0.070000
06-07 17:38:37.621+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:619,0.009620,-0.011176,0.035433
06-07 17:38:37.621+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.621+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:589,0.294317,-0.059821,9.822537
06-07 17:38:37.621+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:621,0.306237,-0.089663,9.801457
06-07 17:38:37.621+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.621+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.621+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:628,0.070000,0.070000,0.070000
06-07 17:38:37.621+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.631+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.631+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:635,0.021580,0.029842,0.037828
06-07 17:38:37.641+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:635,0.306680,-0.088076,9.801457
06-07 17:38:37.641+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:632,0.306281,-0.145962,9.801002
06-07 17:38:37.641+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.641+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.641+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:641,0.070000,-0.070000,0.140000
06-07 17:38:37.641+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.641+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.651+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:648,0.303888,-0.138784,9.894321
06-07 17:38:37.651+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:652,0.004387,-0.010030,0.045008
06-07 17:38:37.651+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:651,0.306151,-0.088207,9.801473
06-07 17:38:37.651+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.651+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:653,0.070000,-0.070000,0.140000
06-07 17:38:37.661+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.661+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:663,0.313460,-0.105284,9.820145
06-07 17:38:37.661+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.661+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.671+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.671+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:676,0.074308,-0.005113,0.030636
06-07 17:38:37.671+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:666,0.070000,0.070000,0.140000
06-07 17:38:37.671+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.671+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:671,0.308764,-0.088158,9.801392
06-07 17:38:37.671+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:680,0.070000,0.070000,0.070000
06-07 17:38:37.681+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:669,0.301496,-0.078963,9.882358
06-07 17:38:37.681+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.681+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.681+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:687,0.315853,-0.100499,9.836893
06-07 17:38:37.681+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.681+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.681+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:687,0.070000,0.070000,0.070000
06-07 17:38:37.691+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:695,0.309829,-0.088874,9.801352
06-07 17:38:37.691+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:692,0.031017,-0.021911,0.061824
06-07 17:38:37.691+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.691+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.691+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:700,0.140000,0.070000,0.070000
06-07 17:38:37.701+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:701,0.327817,-0.059821,9.839286
06-07 17:38:37.701+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.701+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.701+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.701+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.701+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:712,0.140000,0.070000,0.070000
06-07 17:38:37.701+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:712,0.309080,-0.088233,9.801381
06-07 17:38:37.711+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:711,-0.010726,0.009911,0.090577
06-07 17:38:37.711+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.711+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:710,0.311067,-0.098106,9.846465
06-07 17:38:37.711+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.721+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:721,0.140000,-0.070000,0.070000
06-07 17:38:37.721+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:724,0.380459,-0.093320,9.832108
06-07 17:38:37.721+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.721+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.721+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.721+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:731,0.006773,-0.017051,0.045084
06-07 17:38:37.721+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.731+0200 I/heartrate(23168): es.ugr.frailty.heartrate - capturing data
06-07 17:38:37.731+0200 I/heartrate(23168): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:38:37.731+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:735,0.070000,-0.070000,0.070000
06-07 17:38:37.731+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:734,0.309246,-0.088894,9.801370
06-07 17:38:37.731+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.741+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:728,0.339781,-0.110070,9.863215
06-07 17:38:37.741+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.741+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.741+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.741+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:746,0.070000,-0.070000,0.140000
06-07 17:38:37.751+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.751+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:753,0.307416,-0.087746,9.801437
06-07 17:38:37.751+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:751,-0.026893,0.019502,0.013988
06-07 17:38:37.751+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:747,0.299103,-0.078963,9.891929
06-07 17:38:37.751+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.751+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:761,0.315853,-0.105284,9.846465
06-07 17:38:37.751+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.761+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:758,0.070000,0.140000,0.140000
06-07 17:38:37.761+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:765,0.282353,-0.069392,9.815358
06-07 17:38:37.761+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.761+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.771+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.771+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.771+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:776,0.307890,-0.086451,9.801435
06-07 17:38:37.771+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:776,0.334995,-0.064606,9.872787
06-07 17:38:37.771+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:772,0.070000,0.140000,0.140000
06-07 17:38:37.771+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:776,0.027579,0.023139,0.071349
06-07 17:38:37.781+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.781+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.781+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.781+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:791,0.308780,-0.085755,9.801413
06-07 17:38:37.781+0200 I/light   (23223): es.ugr.frailty.light - capturing data
06-07 17:38:37.791+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.791+0200 I/light   (23223): es.ugr.frailty.light: SM-R760,07/06/2018,17:38:37:796,1534.000000
06-07 17:38:37.791+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:796,0.041462,0.007488,0.056994
06-07 17:38:37.791+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:792,0.140000,0.140000,0.070000
06-07 17:38:37.791+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:38:37.791+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:38:37.791+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:795,0.349352,-0.078963,9.858429
06-07 17:38:37.801+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.801+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.801+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:810,0.308537,-0.085887,9.801419
06-07 17:38:37.801+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.801+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:810,0.070000,0.140000,0.070000
06-07 17:38:37.801+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.811+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:814,0.009466,-0.007565,0.078551
06-07 17:38:37.811+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:815,0.318245,-0.093320,9.879964
06-07 17:38:37.821+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.821+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.821+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.821+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:830,0.028851,-0.021790,0.073760
06-07 17:38:37.821+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:831,0.070000,0.140000,0.140000
06-07 17:38:37.831+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.831+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:830,0.309275,-0.086683,9.801389
06-07 17:38:37.831+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:836,0.337388,-0.107677,9.875179
06-07 17:38:37.841+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.841+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.841+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:850,0.309823,-0.087795,9.801361
06-07 17:38:37.841+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.841+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:851,0.070000,0.070000,0.140000
06-07 17:38:37.851+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.851+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:854,0.020935,-0.028173,0.076182
06-07 17:38:37.851+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:856,0.330210,-0.114855,9.877571
06-07 17:38:37.861+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.861+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.861+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.871+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:870,0.015601,-0.019882,0.052282
06-07 17:38:37.871+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:871,0.070000,0.070000,0.070000
06-07 17:38:37.871+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.871+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:870,0.310118,-0.088534,9.801346
06-07 17:38:37.871+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:880,0.325424,-0.107677,9.853643
06-07 17:38:37.881+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.881+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.881+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.891+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:892,0.070000,0.070000,0.070000
06-07 17:38:37.891+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.891+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:894,-0.020586,0.007178,0.066654
06-07 17:38:37.891+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:891,0.308627,-0.087991,9.801397
06-07 17:38:37.891+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:898,0.289532,-0.081356,9.868000
06-07 17:38:37.901+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.901+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.901+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.911+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:911,0.070000,0.070000,0.070000
06-07 17:38:37.911+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.911+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:911,0.308062,-0.090190,9.801395
06-07 17:38:37.911+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:912,-0.004739,-0.050792,0.049854
06-07 17:38:37.911+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:918,0.303888,-0.138784,9.851252
06-07 17:38:37.921+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.921+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.921+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.931+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:931,0.140000,0.070000,0.070000
06-07 17:38:37.931+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.931+0200 I/heartrate(23168): es.ugr.frailty.heartrate - capturing data
06-07 17:38:37.931+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:934,0.036505,-0.000737,0.092926
06-07 17:38:37.931+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:930,0.308905,-0.089873,9.801372
06-07 17:38:37.931+0200 I/heartrate(23168): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:38:37.941+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:937,0.344566,-0.090927,9.894321
06-07 17:38:37.941+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.941+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.951+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.951+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:953,0.307343,-0.086971,9.801447
06-07 17:38:37.951+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:955,0.018912,0.034838,0.052272
06-07 17:38:37.971+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:952,0.560000,0.070000,0.070000
06-07 17:38:37.981+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:37.981+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:37.981+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.981+0200 I/light   (23223): es.ugr.frailty.light - capturing data
06-07 17:38:37.981+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.991+0200 I/light   (23223): es.ugr.frailty.light: SM-R760,07/06/2018,17:38:37:992,1561.000000
06-07 17:38:37.991+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:992,0.022866,-0.023099,0.037839
06-07 17:38:37.991+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:37.991+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:37:989,0.327817,-0.055035,9.853643
06-07 17:38:37.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:38:37.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:38:37.991+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:37:990,0.309182,-0.088608,9.801374
06-07 17:38:37.991+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:37:986,-0.280000,0.140000,0.140000
06-07 17:38:37.991+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:37.991+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:38.001+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:38.001+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:38:11,0.330210,-0.110070,9.839286
06-07 17:38:38.011+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:38:4,0.309728,-0.087264,9.801369
06-07 17:38:38.011+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:38:4,0.350000,0.140000,0.070000
06-07 17:38:38.011+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:38.011+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:38.011+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:38.011+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:37:998,0.052134,0.012037,0.042698
06-07 17:38:38.011+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:38.021+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:38:22,0.361316,-0.076570,9.844072
06-07 17:38:38.021+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:38:20,0.630000,0.070000,0.070000
06-07 17:38:38.021+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:38.021+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:38:23,-0.115909,0.321761,0.042704
06-07 17:38:38.021+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:38.031+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:38.031+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:38:19,0.301609,-0.070229,9.801759
06-07 17:38:38.031+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:38.031+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:38:31,0.490000,0.420000,-0.420000
06-07 17:38:38.031+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:38:36,0.193819,0.234497,9.844072
06-07 17:38:38.031+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:38.041+0200 I/gravity (23203): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:38:36,0.309139,-0.078258,9.801464
06-07 17:38:38.041+0200 I/gravity (23203): es.ugr.frailty.gravity - capturing data
06-07 17:38:38.051+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:38:32,0.126706,-0.219302,0.109313
06-07 17:38:38.051+0200 I/linearacceleration(23193): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:38.091+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:38.101+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:38:103,0.490000,0.210000,0.420000
06-07 17:38:38.101+0200 I/gyroscope(23156): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:38.101+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:38:45,0.428315,-0.289532,9.911072
06-07 17:38:38.111+0200 I/accelerometer(23153): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:38.121+0200 W/CRASH_MANAGER(23265): worker.c: worker_job(1205) > 11231846c6f63152838591
