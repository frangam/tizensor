S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 15316
Date: 2018-04-23 19:28:47+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf76e452d, r5   = 0xf7c90958
r6   = 0xffb56400, r7   = 0xffb562b0
r8   = 0xf7ca3c18, r9   = 0x00000000
r10  = 0xffb5638c, fp   = 0xffb56400
ip   = 0x00000001, sp   = 0xffb56288
lr   = 0xf76e4539, pc   = 0xf774d228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     10764 KB
Buffers:     52656 KB
Cached:     234776 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11668 KB
VmRSS:       11668 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 15316 TID = 15316
15316 15346 

Maps Information
f45af000 f4dae000 rw-p [stack:15346]
f4db5000 f4db7000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4dbf000 f4dc3000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4dcc000 f4dce000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4dd6000 f4dd9000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4de8000 f4ded000 r-xp /usr/lib/libsystem.so.0.0.0
f4df8000 f4dfb000 r-xp /lib/libattr.so.1.1.0
f4e03000 f4e13000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e1b000 f4e24000 r-xp /usr/lib/libedbus.so.1.7.99
f4e2c000 f4e2d000 r-xp /usr/lib/libresponse.so.0.2.96
f4e36000 f4e3b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f66dd000 f67e3000 r-xp /usr/lib/libicuuc.so.57.1
f67f9000 f6981000 r-xp /usr/lib/libicui18n.so.57.1
f6991000 f699e000 r-xp /usr/lib/libail.so.0.1.0
f69a7000 f69ae000 r-xp /usr/lib/libminizip.so.1.0.0
f69b7000 f6b60000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b80000 f6bc7000 r-xp /usr/lib/libssl.so.1.0.0
f6bd3000 f6bd5000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6bdd000 f6be4000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6bed000 f6bf4000 r-xp /lib/libcrypt-2.13.so
f6c25000 f6c28000 r-xp /lib/libcap.so.2.21
f6c30000 f6c32000 r-xp /usr/lib/libiri.so
f6c3a000 f6c83000 r-xp /usr/lib/libmdm.so.1.2.69
f6c8b000 f6c91000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c99000 f6cbc000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6cc6000 f6cc8000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6cd0000 f6ced000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6cf6000 f6cfa000 r-xp /usr/lib/libsmack.so.1.0.0
f6d03000 f6d1c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d25000 f6d2d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d35000 f6d3b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d44000 f6d46000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d4f000 f6d5f000 r-xp /lib/libresolv-2.13.so
f6d63000 f6d7b000 r-xp /usr/lib/liblzma.so.5.0.3
f6d84000 f6d86000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d8e000 f6da8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6db0000 f6ddf000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6de8000 f6df7000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e01000 f6e0b000 r-xp /usr/lib/libsensord-shared.so
f6e14000 f6ee7000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ef2000 f6f08000 r-xp /lib/libz.so.1.2.5
f6f10000 f6f15000 r-xp /usr/lib/libffi.so.5.0.10
f6f1d000 f6f1e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f26000 f6f36000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f3e000 f6f57000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f5f000 f6f61000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f69000 f6fde000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6fe8000 f6fee000 r-xp /lib/librt-2.13.so
f6ff7000 f7015000 r-xp /usr/lib/libsystemd.so.0.4.0
f701f000 f7020000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7028000 f704b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7053000 f7058000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7060000 f708a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7093000 f70aa000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70b2000 f711b000 r-xp /lib/libm-2.13.so
f7124000 f71b8000 r-xp /usr/lib/libstdc++.so.6.0.16
f71cb000 f71d0000 r-xp /usr/lib/libctx-client.so.0.8.3
f71d8000 f71df000 r-xp /usr/lib/libctx-shared.so.0.8.3
f71e7000 f7211000 r-xp /usr/lib/libsensor.so.1.9.6
f721a000 f72e6000 r-xp /usr/lib/libxml2.so.2.7.8
f72f3000 f72f5000 r-xp /usr/lib/libiniparser.so.0
f72fe000 f7304000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f730d000 f73dd000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f73de000 f7412000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f741b000 f7457000 r-xp /usr/lib/libSLP-location.so.0.9.24
f745f000 f7462000 r-xp /usr/lib/libbundle.so.0.1.22
f746a000 f7470000 r-xp /usr/lib/libappsvc.so.0.1.0
f7478000 f74b9000 r-xp /usr/lib/libeina.so.1.7.99
f74c2000 f74d9000 r-xp /usr/lib/libecore.so.1.7.99
f74f0000 f74f9000 r-xp /usr/lib/libvconf.so.0.2.45
f7501000 f7515000 r-xp /lib/libpthread-2.13.so
f7520000 f752d000 r-xp /usr/lib/libaul.so.0.1.0
f7537000 f7539000 r-xp /lib/libdl-2.13.so
f7542000 f754d000 r-xp /lib/libunwind.so.8.0.1
f757a000 f7582000 r-xp /lib/libgcc_s-4.6.so.1
f7583000 f76a7000 r-xp /lib/libc-2.13.so
f76b5000 f76b7000 r-xp /usr/lib/libdlog.so.0.0.0
f76bf000 f76cb000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f76d4000 f76d9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f76e1000 f76f0000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f76f8000 f76fc000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7705000 f7708000 r-xp /usr/lib/libappcore-agent.so.1.1
f7710000 f7712000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f771a000 f771e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7726000 f7743000 r-xp /lib/ld-2.13.so
f774c000 f774f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f774f000 f7753000 r-xp /usr/lib/libsys-assert.so
f7c73000 f7d01000 rw-p [heap]
ffb37000 ffb58000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15316)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf774d228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf76e4539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73eb3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf73e9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf73f5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf73fbbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf73fbdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf743075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf742b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf73e9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf73f5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf73fbbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf73fbdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf742de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf742e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7435f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4dcd1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4dc0171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e93663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7340fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73427a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf74d2ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf74cdb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74ce5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf74ce879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7706183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf77067fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf774d4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf759a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf774cf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ter
04-23 19:28:46.799+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:46:800,0.964308,-1.040878,9.942179
04-23 19:28:46.799+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:46.799+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:46:804,1.162912,-2.433501,9.899107
04-23 19:28:46.809+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:46.809+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:46:814,1.409373,-2.414358,9.769895
04-23 19:28:46.809+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:46.819+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:46:818,1.866402,-2.234896,9.332008
04-23 19:28:46.819+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:46.819+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:28:46.819+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:28:46.819+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:28:46.829+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:46:824,1.866402,-2.723032,8.697910
04-23 19:28:46.829+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:46.869+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:46.879+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:46.879+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:46:883,-27.230000,-8.890000,18.620001
04-23 19:28:46.879+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:46.879+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:46.889+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:46:882,2.286220,-1.894946,9.346270
04-23 19:28:46.889+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:46.889+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:46:898,2.331874,-1.975565,9.318255
04-23 19:28:46.889+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:46.899+0200 I/heartrate(15180): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:28:46:791,72
04-23 19:28:46.899+0200 I/heartrate(15180): capturing data from es.ugr.frailty.heartrate
04-23 19:28:46.909+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:46:888,0.270526,-0.601048,-0.177349
04-23 19:28:46.909+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:46.919+0200 I/heartrate(15180): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:28:46:913,73
04-23 19:28:46.939+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:46:887,-38.080002,-3.570000,14.840000
04-23 19:28:46.939+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:46.949+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:46:840,2.311467,-2.773281,9.597611
04-23 19:28:46.949+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:46.949+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:46:955,2.512464,-2.390430,9.200402
04-23 19:28:46.949+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:46.959+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:46:914,0.372206,0.141007,-0.220044
04-23 19:28:46.959+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:46.959+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:46:964,0.003521,0.185734,-0.720844
04-23 19:28:46.959+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:46.969+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:46:951,-60.689999,-0.070000,12.530000
04-23 19:28:46.969+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:46.979+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:46:902,2.382163,-2.101628,9.277868
04-23 19:28:46.979+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:46.979+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:46:985,2.396461,-2.271209,9.234119
04-23 19:28:46.979+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:46:975,-54.389999,0.910000,13.300000
04-23 19:28:46.979+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:46.989+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:46:967,-0.527725,-1.099969,0.099604
04-23 19:28:46.989+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:46:958,2.658426,-1.753939,9.126225
04-23 19:28:46.989+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:46.989+0200 I/heartrate(15180): capturing data from es.ugr.frailty.heartrate
04-23 19:28:47.009+0200 I/heartrate(15180): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:28:47:0,72
04-23 19:28:47.019+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.019+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:24,-0.580308,-1.243848,0.844450
04-23 19:28:47.019+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.039+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.049+0200 E/CAPI_TELEPHONY(14323): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 19:28:47.049+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:50,2.386801,-2.373478,9.210873
04-23 19:28:47.049+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.049+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:55,2.366326,-2.500090,9.182616
04-23 19:28:47.049+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.059+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:62,2.369333,-2.660996,9.136506
04-23 19:28:47.059+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.059+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:68,2.371200,-2.812942,9.090387
04-23 19:28:47.059+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.069+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:73,2.373916,-2.916967,9.056832
04-23 19:28:47.069+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.069+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:79,2.404143,-2.957478,9.035696
04-23 19:28:47.079+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.079+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:46:993,-39.619999,10.220000,8.400000
04-23 19:28:47.079+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.079+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:84,2.410239,-2.962012,9.032586
04-23 19:28:47.079+0200 I/heartrate(15180): capturing data from es.ugr.frailty.heartrate
04-23 19:28:47.079+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.079+0200 I/heartrate(15180): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:28:47:88,72
04-23 19:28:47.079+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:88,2.371371,-2.996794,9.031402
04-23 19:28:47.079+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.089+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:46:996,2.335395,-1.789831,8.597411
04-23 19:28:47.089+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.089+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:93,2.340382,-3.003305,9.037320
04-23 19:28:47.089+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:94,1.854438,-3.201597,9.377472
04-23 19:28:47.089+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.089+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.089+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:28,-0.795574,-0.430910,0.542273
04-23 19:28:47.089+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.099+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:99,2.314618,-3.009547,9.041878
04-23 19:28:47.099+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.099+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:85,-57.889999,11.200000,4.200000
04-23 19:28:47.099+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.099+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:104,2.286612,-3.005203,9.050445
04-23 19:28:47.099+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.109+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:102,-0.605208,-0.818755,0.541815
04-23 19:28:47.109+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:109,2.243082,-2.981256,9.069239
04-23 19:28:47.109+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:106,-67.620003,6.720000,1.470000
04-23 19:28:47.109+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:98,1.816152,-3.515057,10.078569
04-23 19:28:47.109+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.109+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.119+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.119+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:122,-0.897747,-1.011986,0.449141
04-23 19:28:47.129+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.129+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:133,-1.064719,-0.659044,-0.751401
04-23 19:28:47.129+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.129+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.129+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:126,-54.950001,-3.570000,-2.380000
04-23 19:28:47.129+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.139+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:121,2.174323,-2.919929,9.105862
04-23 19:28:47.139+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:142,-20.719999,-16.870001,0.420000
04-23 19:28:47.139+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.139+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:141,1.591227,-2.804388,9.753145
04-23 19:28:47.139+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.139+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:146,5.180000,-20.370001,6.580000
04-23 19:28:47.139+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.139+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.149+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:137,-0.521871,-0.265487,-1.749152
04-23 19:28:47.149+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.149+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:149,16.520000,-13.090000,13.510000
04-23 19:28:47.149+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:149,2.100859,-2.816630,9.155511
04-23 19:28:47.149+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:154,-0.205139,-0.026372,-0.730208
04-23 19:28:47.149+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.149+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.159+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:152,1.761117,-3.318845,9.724431
04-23 19:28:47.159+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.159+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:162,2.039194,-2.726317,9.196699
04-23 19:28:47.159+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:163,13.160000,-8.260000,11.830000
04-23 19:28:47.159+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.159+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.169+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:168,1.471586,-3.672983,9.585647
04-23 19:28:47.169+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.169+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:162,-0.816619,-1.110572,0.454956
04-23 19:28:47.169+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:177,1.306481,-3.471986,8.338986
04-23 19:28:47.169+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.179+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:182,1.852045,-3.182454,7.307681
04-23 19:28:47.179+0200 I/heartrate(15180): capturing data from es.ugr.frailty.heartrate
04-23 19:28:47.179+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.179+0200 I/heartrate(15180): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:28:47:188,72
04-23 19:28:47.189+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:189,1.997973,-2.662925,9.224278
04-23 19:28:47.189+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.189+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.199+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:198,2.199004,-2.983850,8.305488
04-23 19:28:47.199+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:167,9.100000,-2.940000,5.880000
04-23 19:28:47.199+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.199+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.199+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:194,-0.507362,-0.489548,0.547068
04-23 19:28:47.199+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.199+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:206,1.968221,-2.637025,9.238106
04-23 19:28:47.199+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.209+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:206,9.170000,-0.490000,-0.350000
04-23 19:28:47.209+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.209+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:212,1.593620,-4.072584,9.487542
04-23 19:28:47.209+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.209+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:215,14.700000,3.990000,-1.260000
04-23 19:28:47.209+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.209+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.209+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:210,-0.471588,-0.485431,-0.042700
04-23 19:28:47.209+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.219+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:221,-0.371646,-0.486367,-0.504287
04-23 19:28:47.219+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.219+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:221,1.937969,-2.628223,9.247005
04-23 19:28:47.219+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:217,1.864009,-3.486342,9.578469
04-23 19:28:47.219+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.219+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:226,-0.317319,-0.696494,-0.314249
04-23 19:28:47.219+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.229+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:229,1.868794,-3.488736,8.994620
04-23 19:28:47.229+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.229+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:219,22.540001,10.500000,-3.010000
04-23 19:28:47.229+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.229+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:234,1.942972,-3.495914,8.537591
04-23 19:28:47.229+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.229+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:235,41.020000,11.970000,-3.360000
04-23 19:28:47.229+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.229+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.239+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:230,-0.486750,-0.926224,0.193377
04-23 19:28:47.239+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.239+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:242,1.910058,-2.606308,9.259007
04-23 19:28:47.239+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:244,-0.327064,-0.513771,0.333824
04-23 19:28:47.239+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.239+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:239,1.969293,-3.701697,8.736196
04-23 19:28:47.239+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.239+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:248,-0.409133,-0.093043,0.415780
04-23 19:28:47.239+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.249+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:249,1.756332,-3.907479,9.262616
04-23 19:28:47.249+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.249+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:239,50.119999,14.840000,-4.760000
04-23 19:28:47.249+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.249+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:254,1.847259,-3.433701,9.439686
04-23 19:28:47.249+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.249+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:256,36.959999,10.570000,-5.250000
04-23 19:28:47.249+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.249+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.259+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:261,1.887059,-2.592999,9.267456
04-23 19:28:47.259+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:251,-0.273291,0.053534,0.647373
04-23 19:28:47.259+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.259+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:259,1.691726,-2.909672,9.571291
04-23 19:28:47.259+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:265,-0.229677,-0.103178,0.114908
04-23 19:28:47.259+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.259+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.259+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:269,-0.384173,-0.179327,0.254222
04-23 19:28:47.259+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.269+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:269,1.765903,-2.672783,9.844072
04-23 19:28:47.269+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.269+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:261,20.860001,7.000000,-4.760000
04-23 19:28:47.269+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.269+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:274,1.768296,-2.766103,9.339187
04-23 19:28:47.269+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:275,6.930000,8.610000,-6.650000
04-23 19:28:47.269+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.269+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.269+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.269+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:278,2.940000,5.390000,-3.920000
04-23 19:28:47.279+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.279+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:282,1.868477,-2.583933,9.273751
04-23 19:28:47.279+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:283,7.210000,2.380000,-1.890000
04-23 19:28:47.279+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.279+0200 I/heartrate(15180): capturing data from es.ugr.frailty.heartrate
04-23 19:28:47.279+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:279,1.584049,-2.816352,9.492328
04-23 19:28:47.279+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.279+0200 I/heartrate(15180): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:28:47:288,73
04-23 19:28:47.289+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:289,1.552942,-2.596212,9.547362
04-23 19:28:47.289+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.289+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:273,-0.385028,0.032011,0.300357
04-23 19:28:47.289+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.289+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:294,1.533799,-2.598605,9.442079
04-23 19:28:47.289+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.299+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:296,-0.376258,0.007702,0.183071
04-23 19:28:47.299+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.299+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:287,5.320000,0.910000,-1.190000
04-23 19:28:47.299+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.299+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:306,4.760000,-1.190000,-0.350000
04-23 19:28:47.299+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.309+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:304,-0.386759,0.042250,0.078909
04-23 19:28:47.309+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.309+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.309+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:315,0.070000,-2.380000,0.210000
04-23 19:28:47.319+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:314,-0.325106,0.052327,0.137220
04-23 19:28:47.319+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.319+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:326,-0.359356,0.010129,0.163925
04-23 19:28:47.319+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.329+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:332,-3.220000,-4.690000,1.400000
04-23 19:28:47.329+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:332,1.857263,-2.584806,9.275761
04-23 19:28:47.329+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.339+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:342,1.850246,-2.598307,9.273391
04-23 19:28:47.339+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.339+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.339+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:349,-6.090000,-6.090000,1.050000
04-23 19:28:47.349+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.349+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:353,-0.192020,-0.201295,0.151937
04-23 19:28:47.359+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:358,1.855186,-2.627743,9.264105
04-23 19:28:47.359+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.359+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:365,-5.040000,-3.290000,2.170000
04-23 19:28:47.359+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.369+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.369+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:301,1.500300,-2.550749,9.346365
04-23 19:28:47.369+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:376,1.868316,-2.670181,9.249320
04-23 19:28:47.369+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.379+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:370,0.078214,-0.533176,-0.224021
04-23 19:28:47.379+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:384,-1.050000,-0.560000,1.890000
04-23 19:28:47.379+0200 I/heartrate(15180): capturing data from es.ugr.frailty.heartrate
04-23 19:28:47.379+0200 I/heartrate(15180): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:28:47:389,72
04-23 19:28:47.389+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.389+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:393,0.129691,-0.586451,-0.127880
04-23 19:28:47.389+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.389+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:398,1.543371,-2.531606,9.410972
04-23 19:28:47.389+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.399+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.399+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.399+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:402,1.875157,-2.701270,9.238902
04-23 19:28:47.399+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:406,6.790000,2.100000,3.430000
04-23 19:28:47.399+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.409+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.409+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:410,1.497907,-2.574677,9.439686
04-23 19:28:47.409+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.409+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:414,1.658226,-2.799603,9.425328
04-23 19:28:47.409+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.409+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:409,-0.061398,0.102665,0.133783
04-23 19:28:47.409+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:414,1.861946,-2.680636,9.247580
04-23 19:28:47.409+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.409+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.419+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:420,2.380000,-0.140000,4.200000
04-23 19:28:47.419+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:418,1.933401,-3.160919,9.040084
04-23 19:28:47.419+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.419+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.419+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:426,1.998007,-3.256632,9.121440
04-23 19:28:47.419+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.419+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:421,-0.220470,0.129887,0.225605
04-23 19:28:47.419+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:426,1.847592,-2.671239,9.253177
04-23 19:28:47.419+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:429,1.813759,-2.598605,9.372685
04-23 19:28:47.429+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.429+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:433,1.641476,-2.550749,9.473185
04-23 19:28:47.429+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.429+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.439+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:441,4.200000,-1.890000,3.920000
04-23 19:28:47.439+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.439+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.439+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:446,1.751546,-2.878566,9.427721
04-23 19:28:47.439+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:442,-0.096046,-0.207327,0.174544
04-23 19:28:47.439+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:446,1.841084,-2.675421,9.253265
04-23 19:28:47.449+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.449+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.459+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.459+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:461,2.870000,-0.070000,2.100000
04-23 19:28:47.459+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.459+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:463,1.801795,-2.751746,9.236296
04-23 19:28:47.459+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:461,1.836785,-2.674784,9.254304
04-23 19:28:47.459+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:467,-0.039289,-0.076325,-0.016970
04-23 19:28:47.469+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.469+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.479+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:481,-3.990000,0.280000,1.260000
04-23 19:28:47.479+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.479+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:481,-0.240772,-0.220531,-0.202256
04-23 19:28:47.479+0200 I/heartrate(15180): capturing data from es.ugr.frailty.heartrate
04-23 19:28:47.479+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:486,1.596013,-2.895315,9.052048
04-23 19:28:47.479+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.479+0200 I/heartrate(15180): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:28:47:489,72
04-23 19:28:47.489+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:490,1.828272,-2.696729,9.249619
04-23 19:28:47.499+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.499+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.499+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:508,2.030000,0.140000,4.200000
04-23 19:28:47.509+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.509+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.509+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:514,-0.088690,-0.169872,-0.022895
04-23 19:28:47.509+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:510,1.739582,-2.866602,9.226725
04-23 19:28:47.509+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.509+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.519+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:520,2.660000,0.770000,4.620000
04-23 19:28:47.519+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.519+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:521,1.797010,-2.605784,9.365508
04-23 19:28:47.519+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:514,1.820866,-2.703468,9.249113
04-23 19:28:47.529+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:527,-0.023856,0.097684,0.116395
04-23 19:28:47.529+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.529+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:535,1.814031,-2.694142,9.253177
04-23 19:28:47.529+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.529+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.539+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.539+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:542,1.727618,-2.627320,9.375079
04-23 19:28:47.539+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:547,-0.086413,0.066823,0.121902
04-23 19:28:47.549+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:541,-4.340000,1.890000,4.550000
04-23 19:28:47.549+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.549+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.559+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.569+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:565,1.603191,-2.543570,9.382257
04-23 19:28:47.579+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.589+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:589,-0.202898,0.155468,0.128955
04-23 19:28:47.589+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.589+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:562,-8.470000,1.260000,5.110000
04-23 19:28:47.589+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.589+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:555,1.806089,-2.699039,9.253303
04-23 19:28:47.589+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.599+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:599,-14.630000,0.980000,4.620000
04-23 19:28:47.599+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.609+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:595,-0.116564,-0.120578,0.154224
04-23 19:28:47.609+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:601,1.796325,-2.710131,9.251962
04-23 19:28:47.619+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.609+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:612,-12.880000,-1.680000,7.280000
04-23 19:28:47.609+0200 I/heartrate(15180): capturing data from es.ugr.frailty.heartrate
04-23 19:28:47.619+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.629+0200 I/heartrate(15180): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:28:47:632,73
04-23 19:28:47.629+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.629+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:623,1.793920,-2.745284,9.242059
04-23 19:28:47.639+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:629,-0.274478,0.019859,0.243091
04-23 19:28:47.639+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.639+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.649+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:638,1.679761,-2.830709,9.406186
04-23 19:28:47.649+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.649+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.669+0200 W/LOCATION(15316): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:28:47.689+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:653,1.786873,-2.776280,9.234161
04-23 19:28:47.689+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:664,-0.068826,-0.547351,-0.040936
04-23 19:28:47.689+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:648,-11.410000,-1.400000,4.340000
04-23 19:28:47.689+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.699+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.699+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:673,1.519442,-2.725425,9.485149
04-23 19:28:47.709+0200 I/heartrate(15180): capturing data from es.ugr.frailty.heartrate
04-23 19:28:47.709+0200 I/heartrate(15180): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:28:47:713,72
04-23 19:28:47.709+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.709+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.719+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:702,-8.400000,-1.190000,3.990000
04-23 19:28:47.719+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:709,1.790478,-2.828335,9.217651
04-23 19:28:47.729+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.729+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:731,1.718047,-3.323631,9.193225
04-23 19:28:47.729+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.739+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:723,-0.120288,-0.658007,0.021036
04-23 19:28:47.739+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:745,1.789220,-2.877201,9.202760
04-23 19:28:47.739+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.739+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.749+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:753,-0.123816,-0.266968,0.196248
04-23 19:28:47.759+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:762,1.670190,-3.486342,9.238688
04-23 19:28:47.759+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:738,0.770000,-1.960000,3.570000
04-23 19:28:47.759+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.759+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.769+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.769+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.779+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:769,1.610000,-2.940000,3.640000
04-23 19:28:47.779+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.779+0200 I/heartrate(15180): capturing data from es.ugr.frailty.heartrate
04-23 19:28:47.779+0200 I/heartrate(15180): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:28:47:789,72
04-23 19:28:47.789+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:771,1.783378,-2.890371,9.199766
04-23 19:28:47.789+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:794,-1.960000,-5.110000,2.520000
04-23 19:28:47.789+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.789+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:782,1.665405,-3.144169,9.399008
04-23 19:28:47.789+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:777,-0.137116,-0.265762,0.012601
04-23 19:28:47.799+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.799+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.809+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:799,1.779772,-2.905857,9.195585
04-23 19:28:47.809+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.819+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:28:47.819+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:28:47.819+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:28:47.829+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.829+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:806,1.646262,-3.156133,9.212367
04-23 19:28:47.829+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.829+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:804,-0.001904,-0.434523,0.177100
04-23 19:28:47.839+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.839+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:818,0.700000,-6.020000,2.380000
04-23 19:28:47.839+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.849+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:835,1.787289,-2.935252,9.184785
04-23 19:28:47.849+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.849+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:844,-0.052493,-0.357272,0.185509
04-23 19:28:47.859+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:837,1.777867,-3.340380,9.372685
04-23 19:28:47.859+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.859+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:847,5.460000,-7.280000,0.700000
04-23 19:28:47.859+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.859+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.869+0200 I/gyroscope(15303): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:28:47:869,5.740000,-6.650000,-0.420000
04-23 19:28:47.869+0200 I/gyroscope(15303): capturing data from es.ugr.frailty.gyroscope
04-23 19:28:47.869+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:855,1.793003,-2.957464,9.176542
04-23 19:28:47.879+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.879+0200 I/gravity (15330): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:28:47:883,1.795953,-2.963096,9.174149
04-23 19:28:47.879+0200 I/gravity (15330): capturing data from es.ugr.frailty.gravity
04-23 19:28:47.879+0200 I/heartrate(15180): capturing data from es.ugr.frailty.heartrate
04-23 19:28:47.879+0200 I/heartrate(15180): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:28:47:889,72
04-23 19:28:47.889+0200 I/accelerometer(15291): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:28:47:871,1.734797,-3.292524,9.370294
04-23 19:28:47.889+0200 I/accelerometer(15291): capturing data from es.ugr.frailty.accelerometer
04-23 19:28:47.889+0200 I/linearacceleration(15318): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:28:47:865,-0.125206,-0.186705,0.255964
04-23 19:28:47.889+0200 I/linearacceleration(15318): capturing data from es.ugr.frailty.linearacceleration
04-23 19:28:47.909+0200 W/CRASH_MANAGER(15241): worker.c: worker_job(1205) > 11153166c6f63152450452
