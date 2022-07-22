S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20646
Date: 2018-06-12 19:18:07+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf72be52d, r5   = 0xf7977150
r6   = 0xffbf2860, r7   = 0xffbf2710
r8   = 0xf7989c18, r9   = 0x00000000
r10  = 0xffbf27ec, fp   = 0xffbf2860
ip   = 0x00000001, sp   = 0xffbf26e8
lr   = 0xf72be539, pc   = 0xf7327270
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    122716 KB
Buffers:     47816 KB
Cached:     169020 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11764 KB
VmRSS:       11764 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20646 TID = 20646
20646 20663 

Maps Information
f4189000 f4988000 rw-p [stack:20663]
f498f000 f4991000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4999000 f499d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f49a6000 f49a8000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f49b0000 f49b3000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f49c2000 f49c7000 r-xp /usr/lib/libsystem.so.0.0.0
f49d2000 f49d5000 r-xp /lib/libattr.so.1.1.0
f49dd000 f49ed000 r-xp /usr/lib/libmdm-common.so.1.1.24
f49f5000 f49fe000 r-xp /usr/lib/libedbus.so.1.7.99
f4a06000 f4a07000 r-xp /usr/lib/libresponse.so.0.2.96
f4a10000 f4a15000 r-xp /usr/lib/libproc-stat.so.0.2.96
f62b7000 f63bd000 r-xp /usr/lib/libicuuc.so.57.1
f63d3000 f655b000 r-xp /usr/lib/libicui18n.so.57.1
f656b000 f6578000 r-xp /usr/lib/libail.so.0.1.0
f6581000 f6588000 r-xp /usr/lib/libminizip.so.1.0.0
f6591000 f673a000 r-xp /usr/lib/libcrypto.so.1.0.0
f675a000 f67a1000 r-xp /usr/lib/libssl.so.1.0.0
f67ad000 f67af000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f67b7000 f67be000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f67c7000 f67ce000 r-xp /lib/libcrypt-2.13.so
f67ff000 f6802000 r-xp /lib/libcap.so.2.21
f680a000 f680c000 r-xp /usr/lib/libiri.so
f6814000 f685d000 r-xp /usr/lib/libmdm.so.1.2.69
f6865000 f686b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6873000 f6896000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f68a0000 f68a2000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f68aa000 f68c7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f68d0000 f68d4000 r-xp /usr/lib/libsmack.so.1.0.0
f68dd000 f68f6000 r-xp /usr/lib/libnetwork.so.0.0.0
f68ff000 f6907000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f690f000 f6915000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f691e000 f6920000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6929000 f6939000 r-xp /lib/libresolv-2.13.so
f693d000 f6955000 r-xp /usr/lib/liblzma.so.5.0.3
f695e000 f6960000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6968000 f6982000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f698a000 f69b9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f69c2000 f69d1000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f69db000 f69e5000 r-xp /usr/lib/libsensord-shared.so
f69ee000 f6ac1000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6acc000 f6ae2000 r-xp /lib/libz.so.1.2.5
f6aea000 f6aef000 r-xp /usr/lib/libffi.so.5.0.10
f6af7000 f6af8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b00000 f6b10000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b18000 f6b31000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b39000 f6b3b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b43000 f6bb8000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6bc2000 f6be0000 r-xp /usr/lib/libsystemd.so.0.4.0
f6bea000 f6beb000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6bf3000 f6c16000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c1e000 f6c23000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c2b000 f6c55000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c5e000 f6c75000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c7d000 f6c83000 r-xp /lib/librt-2.13.so
f6c8c000 f6cf5000 r-xp /lib/libm-2.13.so
f6cfe000 f6d92000 r-xp /usr/lib/libstdc++.so.6.0.16
f6da5000 f6daa000 r-xp /usr/lib/libctx-client.so.0.8.3
f6db2000 f6db9000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6dc1000 f6deb000 r-xp /usr/lib/libsensor.so.1.9.6
f6df4000 f6ec0000 r-xp /usr/lib/libxml2.so.2.7.8
f6ecd000 f6ecf000 r-xp /usr/lib/libiniparser.so.0
f6ed8000 f6ede000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ee7000 f6fb7000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6fb8000 f6fec000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ff5000 f7031000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7039000 f703c000 r-xp /usr/lib/libbundle.so.0.1.22
f7044000 f704a000 r-xp /usr/lib/libappsvc.so.0.1.0
f7052000 f7093000 r-xp /usr/lib/libeina.so.1.7.99
f709c000 f70a5000 r-xp /usr/lib/libvconf.so.0.2.45
f70ad000 f70c1000 r-xp /lib/libpthread-2.13.so
f70cc000 f70d9000 r-xp /usr/lib/libaul.so.0.1.0
f70e3000 f70e5000 r-xp /lib/libdl-2.13.so
f70ee000 f70f9000 r-xp /lib/libunwind.so.8.0.1
f7126000 f712e000 r-xp /lib/libgcc_s-4.6.so.1
f712f000 f7253000 r-xp /lib/libc-2.13.so
f7261000 f7278000 r-xp /usr/lib/libecore.so.1.7.99
f728f000 f7291000 r-xp /usr/lib/libdlog.so.0.0.0
f7299000 f72a5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f72ae000 f72b3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f72bb000 f72ca000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f72d2000 f72d6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f72df000 f72e2000 r-xp /usr/lib/libappcore-agent.so.1.1
f72ea000 f72ec000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f72f4000 f72f8000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7300000 f731d000 r-xp /lib/ld-2.13.so
f7326000 f7329000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7329000 f732d000 r-xp /usr/lib/libsys-assert.so
f7959000 f79ca000 rw-p [heap]
ffbd3000 ffbf4000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20646)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7327270) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1270
 1: (0xf72be539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6fc53f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6fc3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6fcfe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6fd5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6fd5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf700a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70051f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6fc3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6fcfe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6fd5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6fd5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7007e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7008017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf700ff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49a71fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf499a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a6d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f1afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f1c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7271ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf726cb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf726d5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf726d879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf72e0183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72e07fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf732760b) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x160b
28: __libc_start_main + 0x114 (0xf714685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7326f74) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf74
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
ion - capturing data
06-12 19:18:06.401+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:409,0.021695,0.052348,-0.004683
06-12 19:18:06.401+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.411+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:403,0.070000,0.070000,0.140000
06-12 19:18:06.411+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:406,9.834501,0.009571,0.916451
06-12 19:18:06.411+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:412,9.764998,0.052916,0.901325
06-12 19:18:06.411+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.421+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.421+0200 E/CAPI_TELEPHONY(20696): telephony_common.c: telephony_init(358) > telephony feature is disabled
06-12 19:18:06.421+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.431+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:435,0.033610,-0.005060,0.039055
06-12 19:18:06.431+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.431+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:439,9.764956,0.052514,0.901818
06-12 19:18:06.431+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:422,0.070000,0.140000,0.070000
06-12 19:18:06.441+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:426,9.820145,0.040678,0.918844
06-12 19:18:06.441+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.441+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.441+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.441+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.451+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:447,-0.070000,0.070000,0.070000
06-12 19:18:06.451+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:450,9.765008,0.053051,0.901218
06-12 19:18:06.451+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:453,9.808180,0.064606,0.904487
06-12 19:18:06.451+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.461+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.461+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.461+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:469,9.765144,0.051266,0.899842
06-12 19:18:06.461+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:450,0.012117,0.014485,0.005062
06-12 19:18:06.461+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.461+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:466,9.798609,0.071785,0.952343
06-12 19:18:06.471+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:473,0.019244,-0.033908,0.005662
06-12 19:18:06.471+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:462,-0.070000,0.070000,0.070000
06-12 19:18:06.471+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.471+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.481+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:479,-0.070000,0.070000,0.070000
06-12 19:18:06.481+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.481+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:490,9.765306,0.050218,0.898145
06-12 19:18:06.481+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.481+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.491+0200 I/heartrate(20634): es.ugr.frailty.heartrate - capturing data
06-12 19:18:06.491+0200 I/heartrate(20634): es.ugr.frailty.heartrate: waiting for rigth values
06-12 19:18:06.491+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:483,9.789038,0.031107,0.930808
06-12 19:18:06.491+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.491+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:497,9.786645,0.102891,0.897308
06-12 19:18:06.491+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.491+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:495,0.047821,-0.015374,0.026181
06-12 19:18:06.501+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.501+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:505,-0.070000,0.070000,0.140000
06-12 19:18:06.501+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.501+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:509,9.765430,0.049709,0.896818
06-12 19:18:06.501+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.501+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:510,-0.070000,0.070000,0.070000
06-12 19:18:06.511+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:501,9.798609,0.047856,0.940379
06-12 19:18:06.511+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.511+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:514,0.050053,-0.007147,0.001556
06-12 19:18:06.511+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:517,9.777073,0.066999,0.906880
06-12 19:18:06.511+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.511+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:521,9.784252,0.019143,0.906880
06-12 19:18:06.521+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.521+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.521+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.521+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:528,-0.070000,0.070000,0.070000
06-12 19:18:06.521+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:529,9.765527,0.050029,0.895747
06-12 19:18:06.521+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.521+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:526,9.812965,0.035892,0.926022
06-12 19:18:06.521+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.531+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:534,9.815358,0.043071,0.899701
06-12 19:18:06.531+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.531+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:533,0.042749,0.010112,0.000490
06-12 19:18:06.531+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:538,9.808180,0.059821,0.897308
06-12 19:18:06.541+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.541+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.541+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:550,0.057011,0.014578,0.030276
06-12 19:18:06.541+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:550,-0.070000,0.070000,0.070000
06-12 19:18:06.541+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.551+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.551+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:556,9.765488,0.050551,0.896148
06-12 19:18:06.551+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:556,9.822537,0.064606,0.926022
06-12 19:18:06.561+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.561+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.561+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.561+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:568,0.070000,0.070000,0.070000
06-12 19:18:06.561+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.571+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:568,9.765736,0.050626,0.893440
06-12 19:18:06.571+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:571,0.018764,0.004484,-0.029946
06-12 19:18:06.571+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:574,9.784252,0.055035,0.866202
06-12 19:18:06.581+0200 I/light   (20685): es.ugr.frailty.light - capturing data
06-12 19:18:06.581+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.581+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:590,0.070000,0.070000,0.070000
06-12 19:18:06.581+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.581+0200 I/light   (20685): es.ugr.frailty.light: SM-R760,12/06/2018,19:18:06:590,57.000000
06-12 19:18:06.581+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.591+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.591+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:595,9.801002,0.052642,0.937986
06-12 19:18:06.591+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:594,9.765677,0.050573,0.894079
06-12 19:18:06.591+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:596,0.035266,0.002016,0.044546
06-12 19:18:06.601+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.601+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.601+0200 W/SHealthService( 6349): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
06-12 19:18:06.601+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.611+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:610,-0.140000,0.070000,0.140000
06-12 19:18:06.611+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:611,9.798609,0.064606,0.937986
06-12 19:18:06.611+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:613,0.032931,0.014033,0.043907
06-12 19:18:06.641+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 19:18:06.651+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 19:18:06.651+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 19:18:06.651+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.651+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:659,0.028148,-0.000667,0.000835
06-12 19:18:06.661+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.661+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:666,0.049459,0.004464,0.027185
06-12 19:18:06.661+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.671+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.691+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 19:18:06.691+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 19:18:06.691+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 19:18:06.701+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:674,0.075768,-0.012346,0.012975
06-12 19:18:06.701+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.701+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:710,0.032480,-0.009041,0.020085
06-12 19:18:06.711+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.711+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:716,0.027645,0.020268,0.011031
06-12 19:18:06.711+0200 I/heartrate(20634): es.ugr.frailty.heartrate - capturing data
06-12 19:18:06.711+0200 I/heartrate(20634): es.ugr.frailty.heartrate: waiting for rigth values
06-12 19:18:06.711+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.711+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:721,-0.070000,0.070000,0.140000
06-12 19:18:06.721+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.721+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:682,9.793823,0.050249,0.894916
06-12 19:18:06.721+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.721+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.721+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:729,0.053947,-0.033182,0.023254
06-12 19:18:06.731+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:726,0.070000,0.070000,0.070000
06-12 19:18:06.731+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.731+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:737,-0.070000,0.070000,0.140000
06-12 19:18:06.731+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.741+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:742,-0.070000,0.070000,0.070000
06-12 19:18:06.741+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.741+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.741+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:750,0.015435,0.011790,0.028030
06-12 19:18:06.751+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:746,-0.070000,0.070000,0.070000
06-12 19:18:06.751+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.751+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:758,-0.070000,0.070000,0.140000
06-12 19:18:06.751+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.761+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:762,-0.070000,0.070000,0.140000
06-12 19:18:06.761+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.761+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:769,0.048853,-0.033926,0.055260
06-12 19:18:06.761+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.771+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:726,9.815358,0.055035,0.918844
06-12 19:18:06.771+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.771+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:774,-0.070000,0.070000,0.070000
06-12 19:18:06.771+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:780,9.841680,0.038285,0.904487
06-12 19:18:06.781+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.781+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.781+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:785,9.765676,0.050916,0.894081
06-12 19:18:06.781+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.781+0200 I/light   (20685): es.ugr.frailty.light - capturing data
06-12 19:18:06.781+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.781+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.781+0200 I/light   (20685): es.ugr.frailty.light: SM-R760,12/06/2018,19:18:06:790,57.000000
06-12 19:18:06.791+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:789,9.765899,0.050571,0.891659
06-12 19:18:06.791+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.791+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:798,9.765911,0.050631,0.891512
06-12 19:18:06.791+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.801+0200 W/SHealthService( 6349): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-12 19:18:06.801+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:792,0.022520,-0.005840,0.036162
06-12 19:18:06.801+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:795,-0.070000,0.070000,0.070000
06-12 19:18:06.801+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.801+0200 W/SHealthService( 6349): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-12 19:18:06.801+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.811+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:786,9.798609,0.040678,0.909273
06-12 19:18:06.811+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:810,0.029714,0.052026,0.074260
06-12 19:18:06.811+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.811+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:820,9.793823,0.069392,0.899701
06-12 19:18:06.811+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:813,-0.070000,0.070000,0.070000
06-12 19:18:06.821+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.821+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:828,9.820145,0.016750,0.911665
06-12 19:18:06.821+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.831+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:835,9.781858,0.059821,0.914058
06-12 19:18:06.831+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.831+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:839,9.815358,0.014357,0.940379
06-12 19:18:06.831+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.831+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.831+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.841+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:849,0.070000,0.070000,0.070000
06-12 19:18:06.851+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:845,0.056422,0.018640,0.012689
06-12 19:18:06.851+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.851+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.861+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:863,0.070000,0.070000,0.070000
06-12 19:18:06.871+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:859,0.034838,0.015510,0.018049
06-12 19:18:06.871+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.871+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.871+0200 W/SHealthCommon( 6349): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1528761600000,000000[0;m
06-12 19:18:06.871+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:877,0.044389,-0.004224,0.023102
06-12 19:18:06.871+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:865,9.789038,0.040678,0.921237
06-12 19:18:06.871+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:804,9.766129,0.049719,0.889188
06-12 19:18:06.871+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.881+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:884,9.766178,0.049124,0.888670
06-12 19:18:06.881+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.881+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:889,9.766197,0.049932,0.888412
06-12 19:18:06.881+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.891+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:893,9.766423,0.048030,0.886028
06-12 19:18:06.891+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.891+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:897,9.766505,0.048283,0.885119
06-12 19:18:06.891+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.891+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:901,9.766518,0.046518,0.885074
06-12 19:18:06.891+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.901+0200 I/heartrate(20634): es.ugr.frailty.heartrate - capturing data
06-12 19:18:06.901+0200 I/heartrate(20634): es.ugr.frailty.heartrate: waiting for rigth values
06-12 19:18:06.901+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:905,9.766502,0.046080,0.885262
06-12 19:18:06.901+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.901+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:910,9.766115,0.048359,0.889405
06-12 19:18:06.901+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.911+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:914,9.766164,0.049096,0.888831
06-12 19:18:06.911+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.911+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:919,9.766185,0.049688,0.888564
06-12 19:18:06.911+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.921+0200 W/SHealthCommon( 6349): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
06-12 19:18:06.931+0200 I/HealthDataService( 6231): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
06-12 19:18:06.941+0200 W/healthData( 6251): health_fw_share.c: __health_notify_share_cb(331) > [1;40;33mNotification is called [category:shealth_pedometer_info][0;m
06-12 19:18:06.941+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.941+0200 I/healthData( 6349): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
06-12 19:18:06.951+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:923,9.766232,0.049347,0.888062
06-12 19:18:06.951+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.951+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:952,0.049126,-0.046954,0.040353
06-12 19:18:06.951+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.951+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.951+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:881,0.140000,0.140000,0.070000
06-12 19:18:06.951+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:958,0.051394,0.041557,0.029631
06-12 19:18:06.951+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.951+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.951+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:962,0.140000,0.070000,0.070000
06-12 19:18:06.961+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:962,0.065845,0.003843,0.033482
06-12 19:18:06.961+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.961+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:956,9.766356,0.046978,0.886820
06-12 19:18:06.961+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.961+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:958,9.796216,0.098106,0.959522
06-12 19:18:06.961+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.961+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:967,0.039525,-0.020111,-0.004818
06-12 19:18:06.961+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:970,9.822537,0.066999,0.902094
06-12 19:18:06.961+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.961+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.971+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:974,0.034546,0.002543,0.006826
06-12 19:18:06.971+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:968,9.766263,0.048799,0.887755
06-12 19:18:06.971+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.971+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.971+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:979,9.766262,0.048825,0.887769
06-12 19:18:06.971+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:06.971+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:980,0.070000,0.070000,0.070000
06-12 19:18:06.971+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.981+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:974,9.801002,0.064606,0.906880
06-12 19:18:06.981+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.981+0200 I/light   (20685): es.ugr.frailty.light - capturing data
06-12 19:18:06.981+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:06.981+0200 I/light   (20685): es.ugr.frailty.light: SM-R760,12/06/2018,19:18:06:990,57.000000
06-12 19:18:06.981+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:06:990,0.015301,-0.009395,-0.006405
06-12 19:18:06.981+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:985,0.070000,0.070000,0.070000
06-12 19:18:06.991+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.991+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:988,9.810574,0.045464,0.911665
06-12 19:18:06.991+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.991+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:06:996,0.070000,0.070000,0.070000
06-12 19:18:06.991+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:06:997,9.815358,0.002393,0.928415
06-12 19:18:06.991+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.991+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:06.991+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:07:1,9.817751,0.088534,0.916451
06-12 19:18:06.991+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:06.991+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:07:1,0.070000,0.070000,0.070000
06-12 19:18:07.001+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:07.001+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:06:983,9.766456,0.047707,0.885697
06-12 19:18:07.001+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:07.001+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:07.001+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:07:7,9.766558,0.047680,0.884571
06-12 19:18:07.001+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:07.001+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:07:9,0.019928,0.015127,0.045574
06-12 19:18:07.011+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:07:12,9.766717,0.047086,0.882841
06-12 19:18:07.011+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:07.011+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:07:6,0.070000,0.140000,0.070000
06-12 19:18:07.011+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:07.011+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:07:4,9.832108,0.052642,0.921237
06-12 19:18:07.011+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:07.011+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:07:18,0.070000,0.070000,0.070000
06-12 19:18:07.011+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:07:16,9.766614,0.047658,0.883944
06-12 19:18:07.021+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:07:22,9.805787,0.028714,0.882952
06-12 19:18:07.021+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:07.021+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:07.021+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:07.021+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:07:27,9.801002,0.050249,0.892523
06-12 19:18:07.031+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:07:30,0.065495,-0.016552,-0.000992
06-12 19:18:07.031+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:07:29,0.070000,0.070000,-0.070000
06-12 19:18:07.031+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:07.031+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:07.031+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:07:37,9.766549,0.047010,0.884695
06-12 19:18:07.031+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:07:36,9.781858,0.038285,0.878166
06-12 19:18:07.031+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:07.041+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:07:43,9.786645,0.062213,0.928415
06-12 19:18:07.041+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:07.041+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:07:48,9.832108,0.031107,0.882952
06-12 19:18:07.041+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:07.041+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 19:18:07.041+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 19:18:07.041+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 19:18:07.041+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 19:18:07.041+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:07.051+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:07:55,-0.008619,-0.011117,0.031756
06-12 19:18:07.051+0200 W/LOCATION(20646): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 19:18:07.051+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:07:55,9.766319,0.046644,0.887247
06-12 19:18:07.051+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:07.061+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:07.061+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:07.061+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:07:65,0.070000,0.070000,-0.070000
06-12 19:18:07.061+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:07.061+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:07.061+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:07:70,0.070000,0.070000,0.070000
06-12 19:18:07.071+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:07:69,9.766368,0.045196,0.886788
06-12 19:18:07.071+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:07:70,0.022718,-0.027501,0.041168
06-12 19:18:07.071+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:07:65,9.757930,0.035892,0.916451
06-12 19:18:07.071+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:07.071+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:07:80,9.789038,0.019143,0.928415
06-12 19:18:07.081+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:07.081+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:07.081+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:07.081+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:07:90,0.070000,0.070000,0.070000
06-12 19:18:07.091+0200 I/heartrate(20634): es.ugr.frailty.heartrate - capturing data
06-12 19:18:07.091+0200 I/heartrate(20634): es.ugr.frailty.heartrate: waiting for rigth values
06-12 19:18:07.091+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:07:91,0.029848,0.064874,0.024878
06-12 19:18:07.091+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:07:94,9.766236,0.048132,0.888088
06-12 19:18:07.091+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:07.101+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:07:102,9.796216,0.110070,0.911665
06-12 19:18:07.101+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:07.101+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:07.101+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:07.101+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:07:108,0.070000,0.140000,0.070000
06-12 19:18:07.111+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:07:109,9.766274,0.049126,0.887617
06-12 19:18:07.111+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:07:112,0.015622,0.023652,0.006827
06-12 19:18:07.111+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:07.111+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:07:119,9.781858,0.071785,0.894916
06-12 19:18:07.121+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:07.121+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:07.121+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:07.121+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:07:128,0.070000,0.070000,0.070000
06-12 19:18:07.131+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:07:129,9.766380,0.049711,0.886418
06-12 19:18:07.131+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:07:132,0.063440,0.015480,0.002513
06-12 19:18:07.131+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:07.131+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:07:138,9.829715,0.064606,0.890130
06-12 19:18:07.141+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:07.141+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:07.141+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:07.141+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:07:150,0.070000,0.070000,0.070000
06-12 19:18:07.151+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:07:154,0.041800,0.017288,0.013284
06-12 19:18:07.151+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:07:151,9.766423,0.050386,0.885904
06-12 19:18:07.151+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:07.151+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:07:160,9.808180,0.066999,0.899701
06-12 19:18:07.161+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:07.161+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:07.161+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:07:168,0.070000,0.140000,0.070000
06-12 19:18:07.161+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:07.171+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:07:172,0.044150,0.004649,0.035333
06-12 19:18:07.171+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:07:169,9.766385,0.050460,0.886314
06-12 19:18:07.171+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:07.171+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:07:179,9.810574,0.055035,0.921237
06-12 19:18:07.181+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:07.181+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:07.181+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:07:190,0.070000,0.070000,0.070000
06-12 19:18:07.181+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:07.181+0200 I/light   (20685): es.ugr.frailty.light - capturing data
06-12 19:18:07.191+0200 I/light   (20685): es.ugr.frailty.light: SM-R760,12/06/2018,19:18:07:194,57.000000
06-12 19:18:07.191+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:07:190,9.766410,0.049739,0.886083
06-12 19:18:07.191+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:07:194,0.005902,-0.012175,0.030137
06-12 19:18:07.191+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:07.191+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:07:201,9.772287,0.038285,0.916451
06-12 19:18:07.201+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:07.201+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:07.201+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:07:209,0.070000,0.070000,0.070000
06-12 19:18:07.201+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:07.211+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:07:213,0.046556,0.014867,-0.005524
06-12 19:18:07.211+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:07:210,9.766544,0.050302,0.884574
06-12 19:18:07.211+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:07.211+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:07:219,9.812965,0.064606,0.880559
06-12 19:18:07.221+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:07.221+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:07.221+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:07:229,0.070000,0.140000,0.070000
06-12 19:18:07.221+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:07:229,9.766678,0.050386,0.883090
06-12 19:18:07.221+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:07.241+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope - capturing data
06-12 19:18:07.251+0200 I/gyroscope(20622): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:18:07:254,0.070000,0.070000,0.070000
06-12 19:18:07.271+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-12 19:18:07.271+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
06-12 19:18:07.271+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-12 19:18:07.271+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-12 19:18:07.271+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-12 19:18:07.271+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
06-12 19:18:07.271+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
06-12 19:18:07.271+0200 E/CAPI_LOCATION_MANAGER(20696): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-12 19:18:07.271+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:0, msg id:2
06-12 19:18:07.281+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 19:18:07.291+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:07.291+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:07:233,0.034457,0.004733,-0.006408
06-12 19:18:07.291+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:07.291+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:07:299,-0.008748,0.019006,0.021396
06-12 19:18:07.291+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:07.321+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:07:297,9.766656,0.051155,0.883284
06-12 19:18:07.321+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:07.331+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:07.331+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:07:335,9.801002,0.055035,0.878166
06-12 19:18:07.331+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:07.331+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:07:340,9.757930,0.069392,0.904487
06-12 19:18:07.331+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:07.341+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:07:332,9.766644,0.050954,0.883432
06-12 19:18:07.341+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:07.341+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:07:303,0.070237,-0.000905,0.037953
06-12 19:18:07.351+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:07.351+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:07:348,9.766560,0.051676,0.884319
06-12 19:18:07.351+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:07.351+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:07:360,9.766513,0.050785,0.884893
06-12 19:18:07.351+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:07.361+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:07:344,9.836893,0.050249,0.921237
06-12 19:18:07.361+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:07:356,0.039143,0.018438,0.040197
06-12 19:18:07.361+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:07.361+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:07.371+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:07:371,0.032049,-0.015784,0.053667
06-12 19:18:07.371+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:07.371+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:07:374,9.805787,0.069392,0.923629
06-12 19:18:07.371+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:07.381+0200 I/gravity (20660): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:18:07:364,9.766477,0.052208,0.885205
06-12 19:18:07.381+0200 I/gravity (20660): es.ugr.frailty.gravity - capturing data
06-12 19:18:07.381+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:18:07:378,0.044061,0.032964,0.024379
06-12 19:18:07.381+0200 I/linearacceleration(20648): es.ugr.frailty.linearacceleration - capturing data
06-12 19:18:07.391+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:07:382,9.798609,0.035892,0.937986
06-12 19:18:07.391+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:07.391+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:07:397,9.810574,0.083749,0.909273
06-12 19:18:07.391+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:07.391+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:18:07:400,9.805787,0.043071,0.880559
06-12 19:18:07.391+0200 I/accelerometer(20609): es.ugr.frailty.accelerometer - capturing data
06-12 19:18:07.401+0200 I/CAPI_NETWORK_CONNECTION(20696): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
06-12 19:18:07.401+0200 I/CAPI_NETWORK_CONNECTION(20696): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
06-12 19:18:07.401+0200 I/CAPI_NETWORK_CONNECTION(20696): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
06-12 19:18:07.401+0200 I/CAPI_NETWORK_CONNECTION(20696): connection.c: connection_destroy(471) > Destroy handle: 0xf78b3228
06-12 19:18:07.411+0200 W/CRASH_MANAGER(20729): worker.c: worker_job(1205) > 11206466c6f63152882388
