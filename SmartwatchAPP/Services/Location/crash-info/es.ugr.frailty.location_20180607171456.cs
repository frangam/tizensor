S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 18617
Date: 2018-06-07 17:14:56+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf761052d, r5   = 0xf7d6e958
r6   = 0xffb73770, r7   = 0xffb73620
r8   = 0xf7d81c18, r9   = 0x00000000
r10  = 0xffb736fc, fp   = 0xffb73770
ip   = 0x00000001, sp   = 0xffb735f8
lr   = 0xf7610539, pc   = 0xf7679228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    286260 KB
Buffers:      4876 KB
Cached:      54120 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11696 KB
VmRSS:       11696 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 18617 TID = 18617
18617 18633 

Maps Information
f44db000 f4cda000 rw-p [stack:18633]
f4ce1000 f4ce3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ceb000 f4cef000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4cf8000 f4cfa000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d02000 f4d05000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d14000 f4d19000 r-xp /usr/lib/libsystem.so.0.0.0
f4d24000 f4d27000 r-xp /lib/libattr.so.1.1.0
f4d2f000 f4d3f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d47000 f4d50000 r-xp /usr/lib/libedbus.so.1.7.99
f4d58000 f4d59000 r-xp /usr/lib/libresponse.so.0.2.96
f4d62000 f4d67000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6609000 f670f000 r-xp /usr/lib/libicuuc.so.57.1
f6725000 f68ad000 r-xp /usr/lib/libicui18n.so.57.1
f68bd000 f68ca000 r-xp /usr/lib/libail.so.0.1.0
f68d3000 f68da000 r-xp /usr/lib/libminizip.so.1.0.0
f68e3000 f6a8c000 r-xp /usr/lib/libcrypto.so.1.0.0
f6aac000 f6af3000 r-xp /usr/lib/libssl.so.1.0.0
f6aff000 f6b01000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b09000 f6b10000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b19000 f6b20000 r-xp /lib/libcrypt-2.13.so
f6b51000 f6b54000 r-xp /lib/libcap.so.2.21
f6b5c000 f6b5e000 r-xp /usr/lib/libiri.so
f6b66000 f6baf000 r-xp /usr/lib/libmdm.so.1.2.69
f6bb7000 f6bbd000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6bc5000 f6be8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6bf2000 f6bf4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6bfc000 f6c19000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c22000 f6c26000 r-xp /usr/lib/libsmack.so.1.0.0
f6c2f000 f6c48000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c51000 f6c59000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c61000 f6c67000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c70000 f6c72000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c7b000 f6c8b000 r-xp /lib/libresolv-2.13.so
f6c8f000 f6ca7000 r-xp /usr/lib/liblzma.so.5.0.3
f6cb0000 f6cb2000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6cba000 f6cd4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6cdc000 f6d0b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d14000 f6d23000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d2d000 f6d37000 r-xp /usr/lib/libsensord-shared.so
f6d40000 f6e13000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e1e000 f6e34000 r-xp /lib/libz.so.1.2.5
f6e3c000 f6e41000 r-xp /usr/lib/libffi.so.5.0.10
f6e49000 f6e4a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e52000 f6e62000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e6a000 f6e83000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e8b000 f6e8d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e95000 f6f0a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f14000 f6f1a000 r-xp /lib/librt-2.13.so
f6f23000 f6f41000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f4b000 f6f4c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f54000 f6f77000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f7f000 f6f84000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f8c000 f6fb6000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6fbf000 f6fd6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6fde000 f7047000 r-xp /lib/libm-2.13.so
f7050000 f70e4000 r-xp /usr/lib/libstdc++.so.6.0.16
f70f7000 f70fc000 r-xp /usr/lib/libctx-client.so.0.8.3
f7104000 f710b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7113000 f713d000 r-xp /usr/lib/libsensor.so.1.9.6
f7146000 f7212000 r-xp /usr/lib/libxml2.so.2.7.8
f721f000 f7221000 r-xp /usr/lib/libiniparser.so.0
f722a000 f7230000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7239000 f7309000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f730a000 f733e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7347000 f7383000 r-xp /usr/lib/libSLP-location.so.0.9.24
f738b000 f738e000 r-xp /usr/lib/libbundle.so.0.1.22
f7396000 f739c000 r-xp /usr/lib/libappsvc.so.0.1.0
f73a4000 f73e5000 r-xp /usr/lib/libeina.so.1.7.99
f73ee000 f7405000 r-xp /usr/lib/libecore.so.1.7.99
f741c000 f7425000 r-xp /usr/lib/libvconf.so.0.2.45
f742d000 f7441000 r-xp /lib/libpthread-2.13.so
f744c000 f7459000 r-xp /usr/lib/libaul.so.0.1.0
f7463000 f7465000 r-xp /lib/libdl-2.13.so
f746e000 f7479000 r-xp /lib/libunwind.so.8.0.1
f74a6000 f74ae000 r-xp /lib/libgcc_s-4.6.so.1
f74af000 f75d3000 r-xp /lib/libc-2.13.so
f75e1000 f75e3000 r-xp /usr/lib/libdlog.so.0.0.0
f75eb000 f75f7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7600000 f7605000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f760d000 f761c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7624000 f7628000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7631000 f7634000 r-xp /usr/lib/libappcore-agent.so.1.1
f763c000 f763e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7646000 f764a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7652000 f766f000 r-xp /lib/ld-2.13.so
f7678000 f767b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f767b000 f767f000 r-xp /usr/lib/libsys-assert.so
f7d51000 f7ddf000 rw-p [heap]
ffb54000 ffb75000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18617)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7679228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7610539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73173f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7315c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7321e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7327be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7327dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf735c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73571f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7315c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7321e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7327be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7327dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7359e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf735a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7361f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4cf91fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4cec171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6dbf663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf726cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf726e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf73feca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf73f9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73fa5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf73fa879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7632183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76327fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76795c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf74c685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7678f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
.070000
06-07 17:14:56.311+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.311+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:56:308,0.301771,-0.085047,9.801637
06-07 17:14:56.311+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:56.321+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:56.321+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:56:327,0.303888,-0.062213,9.870394
06-07 17:14:56.321+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:318,0.070000,0.140000,0.070000
06-07 17:14:56.331+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:56:334,0.301184,-0.083734,9.801666
06-07 17:14:56.331+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:56.331+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.331+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:56.341+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:56:341,0.032848,0.005415,0.090362
06-07 17:14:56.351+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:56.351+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:56:356,0.302667,-0.084294,9.801616
06-07 17:14:56.351+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:56.351+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:56:347,0.346959,-0.100499,9.882358
06-07 17:14:56.361+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:14:56.361+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:14:56:369,635.000000
06-07 17:14:56.361+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:56.371+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:56:365,0.005470,0.037383,0.080832
06-07 17:14:56.371+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:56:375,0.303888,-0.102891,9.908678
06-07 17:14:56.371+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:56.371+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:343,0.070000,0.140000,0.070000
06-07 17:14:56.381+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.381+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:56.381+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:14:56.381+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:14:56.391+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:56.391+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:56:385,0.302014,-0.084935,9.801630
06-07 17:14:56.401+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:386,0.070000,0.140000,0.070000
06-07 17:14:56.401+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.401+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:56.401+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:56:391,0.011759,0.022534,0.044962
06-07 17:14:56.401+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:56:411,0.301449,-0.085671,9.801641
06-07 17:14:56.411+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:56:402,0.303888,-0.105284,9.877571
06-07 17:14:56.411+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:406,0.070000,0.070000,0.070000
06-07 17:14:56.411+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.411+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:56.411+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:56:421,-0.007392,0.034969,0.080837
06-07 17:14:56.421+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:56.421+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:56.431+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:56.431+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:420,0.070000,0.070000,0.070000
06-07 17:14:56.431+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.431+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:56:430,0.327817,-0.055035,9.889536
06-07 17:14:56.441+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:56.451+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:56:438,0.301997,-0.084039,9.801639
06-07 17:14:56.451+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:56.461+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:56:442,-0.002949,0.000348,0.080837
06-07 17:14:56.461+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:56.471+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:56:457,0.327817,-0.081356,9.882358
06-07 17:14:56.471+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:56.471+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:56:470,0.302619,-0.083717,9.801622
06-07 17:14:56.471+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:56:474,-0.016778,0.017697,0.047305
06-07 17:14:56.481+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:56.481+0200 W/LOCATION(18617): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:14:56.491+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:442,0.070000,0.070000,0.070000
06-07 17:14:56.491+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.491+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:56:482,0.330210,-0.112463,9.894321
06-07 17:14:56.491+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:498,0.140000,0.070000,0.070000
06-07 17:14:56.491+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:56.491+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.501+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:56.501+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:56:498,0.303470,-0.084838,9.801586
06-07 17:14:56.511+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:56:508,0.022164,0.007989,0.145390
06-07 17:14:56.511+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:503,0.140000,0.070000,0.070000
06-07 17:14:56.511+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:56.521+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:56.521+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.531+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:532,0.070000,0.140000,0.070000
06-07 17:14:56.531+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.531+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:56:515,0.327817,-0.093320,9.894321
06-07 17:14:56.541+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:56.541+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:56:525,0.303787,-0.084877,9.801576
06-07 17:14:56.541+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:56.551+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:543,0.070000,0.140000,0.070000
06-07 17:14:56.551+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.551+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:56:535,0.002112,0.023546,0.068764
06-07 17:14:56.551+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:56.551+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:557,0.070000,0.140000,0.070000
06-07 17:14:56.561+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:14:56.561+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.561+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:14:56:569,634.000000
06-07 17:14:56.561+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:56:549,0.315853,-0.102891,9.903893
06-07 17:14:56.571+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:56.571+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:56:555,0.303555,-0.085355,9.801579
06-07 17:14:56.571+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:572,0.070000,0.140000,0.070000
06-07 17:14:56.571+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.571+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:56.581+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:56:562,0.045188,-0.015452,0.080721
06-07 17:14:56.581+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:56.581+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:583,0.210000,0.070000,0.070000
06-07 17:14:56.581+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.581+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:14:56.591+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:14:56.591+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:56:582,0.301496,-0.081356,9.879964
06-07 17:14:56.591+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:56.601+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:56:586,0.302761,-0.084939,9.801607
06-07 17:14:56.601+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:595,0.070000,0.070000,0.070000
06-07 17:14:56.601+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.601+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:56:598,0.002704,-0.019158,0.107012
06-07 17:14:56.601+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:56.611+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:607,0.070000,0.070000,0.070000
06-07 17:14:56.611+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:56.621+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.621+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:56:615,0.303440,-0.083672,9.801598
06-07 17:14:56.621+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:56:606,0.334995,-0.062213,9.868000
06-07 17:14:56.621+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:626,0.070000,0.070000,0.070000
06-07 17:14:56.631+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:56.631+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:56:638,0.325424,-0.069392,9.877571
06-07 17:14:56.631+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.641+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:56.641+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:56:623,0.001222,-0.020990,0.075955
06-07 17:14:56.641+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:643,0.210000,0.070000,0.140000
06-07 17:14:56.641+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:56.651+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.651+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:56:649,0.303698,-0.082786,9.801597
06-07 17:14:56.661+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:56.661+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:657,0.070000,0.070000,0.140000
06-07 17:14:56.661+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:56:654,0.025803,0.029900,0.087906
06-07 17:14:56.661+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:56.661+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.671+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:56.671+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:56:668,0.323031,-0.055035,9.894321
06-07 17:14:56.671+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:56:674,0.303779,-0.081257,9.801607
06-07 17:14:56.681+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:56.681+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:56:683,0.026368,0.004315,0.080716
06-07 17:14:56.681+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:674,0.140000,0.070000,0.070000
06-07 17:14:56.681+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.681+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:56.691+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:56.691+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:56:700,0.028213,-0.028423,0.092683
06-07 17:14:56.701+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:56:690,0.284746,-0.098106,9.836893
06-07 17:14:56.701+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:56.701+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:56:695,0.301807,-0.081589,9.801665
06-07 17:14:56.701+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:56.701+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:691,0.210000,0.070000,0.070000
06-07 17:14:56.701+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.711+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:56.711+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:56:710,0.294317,-0.074178,9.865608
06-07 17:14:56.721+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:56:719,0.025198,-0.009603,0.092699
06-07 17:14:56.721+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:56:713,0.300923,-0.081037,9.801697
06-07 17:14:56.721+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:56.721+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:712,0.070000,0.070000,0.070000
06-07 17:14:56.721+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.721+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:56.731+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:56.731+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:56:735,0.301119,-0.081526,9.801687
06-07 17:14:56.731+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:56:732,0.315853,-0.095713,9.877571
06-07 17:14:56.741+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:732,-0.070000,0.070000,0.070000
06-07 17:14:56.741+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.741+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:56:739,0.012382,-0.018053,0.102307
06-07 17:14:56.741+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:56.741+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:56:751,0.294317,-0.107677,9.865608
06-07 17:14:56.751+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:56.751+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:56.751+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:56:759,-0.002292,0.003521,0.078388
06-07 17:14:56.761+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:56.761+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:56:756,0.300308,-0.082576,9.801702
06-07 17:14:56.761+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:14:56.761+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:747,0.070000,0.070000,0.070000
06-07 17:14:56.761+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.761+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:14:56:769,634.000000
06-07 17:14:56.771+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:56.771+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:773,0.070000,0.070000,0.070000
06-07 17:14:56.771+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:56:775,0.330210,-0.119641,9.863215
06-07 17:14:56.771+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:56.781+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.781+0200 I/servicemanager(17973): es.ugr.frailty.accelerometer alive timeout
06-07 17:14:56.781+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:14:56.781+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:56.781+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:56.791+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:14:56.791+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:14:56.791+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:56.791+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:56:779,0.300852,-0.083794,9.801676
06-07 17:14:56.791+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:56:785,0.031440,0.023142,0.066421
06-07 17:14:56.791+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:56.791+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18571
06-07 17:14:56.801+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18571)
06-07 17:14:56.801+0200 I/servicemanager(17973): es.ugr.frailty.accelerometer launch request sent!
06-07 17:14:56.801+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:56.801+0200 I/servicemanager(17973): es.ugr.frailty.gyroscope alive timeout
06-07 17:14:56.801+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:14:56.801+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:56.801+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:56.811+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:56.811+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18556
06-07 17:14:56.811+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18556)
06-07 17:14:56.811+0200 I/servicemanager(17973): es.ugr.frailty.gyroscope launch request sent!
06-07 17:14:56.811+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:56.811+0200 I/servicemanager(17973): es.ugr.frailty.heartrate alive timeout
06-07 17:14:56.821+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:14:56.821+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:56.821+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:56.821+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:56:800,0.346959,-0.110070,9.882358
06-07 17:14:56.831+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18034
06-07 17:14:56.831+0200 W/CAPI_APPFW_APP_CONTROL(18034): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:14:56.831+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18034)
06-07 17:14:56.831+0200 I/servicemanager(17973): es.ugr.frailty.heartrate launch request sent!
06-07 17:14:56.831+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:56.831+0200 I/servicemanager(17973): es.ugr.frailty.location alive timeout
06-07 17:14:56.831+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:14:56.831+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(18034), cmd(0)
06-07 17:14:56.831+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:14:56.831+0200 I/utils   (18034): specific action
06-07 17:14:56.841+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:56.841+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:56.841+0200 W/CAPI_APPFW_APP_CONTROL(18571): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:14:56.841+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:56:804,0.302576,-0.084813,9.801614
06-07 17:14:56.841+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:56:823,0.022663,0.015547,0.075964
06-07 17:14:56.851+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:56.851+0200 I/utils   (18571): specific action
06-07 17:14:56.851+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:56.851+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18617
06-07 17:14:56.851+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18617)
06-07 17:14:56.851+0200 I/servicemanager(17973): es.ugr.frailty.location launch request sent!
06-07 17:14:56.851+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:56.851+0200 I/servicemanager(17973): es.ugr.frailty.linearacceleration alive timeout
06-07 17:14:56.851+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:14:56.851+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:14:56.851+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(18571), cmd(0)
06-07 17:14:56.851+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:56.851+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:56.861+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:56.861+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18620
06-07 17:14:56.871+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18620)
06-07 17:14:56.871+0200 I/servicemanager(17973): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:14:56.871+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:56.871+0200 I/servicemanager(17973): es.ugr.frailty.gravity alive timeout
06-07 17:14:56.871+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:14:56.871+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:56.871+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:56.881+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18583
06-07 17:14:56.881+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:789,0.070000,0.070000,0.070000
06-07 17:14:56.881+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18583)
06-07 17:14:56.881+0200 I/servicemanager(17973): es.ugr.frailty.gravity launch request sent!
06-07 17:14:56.881+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:56.881+0200 I/servicemanager(17973): es.ugr.frailty.pressure alive timeout
06-07 17:14:56.881+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:14:56.881+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:56.891+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:56.891+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:56:858,0.302465,-0.084875,9.801617
06-07 17:14:56.891+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:56:861,0.315853,-0.093320,9.841680
06-07 17:14:56.891+0200 W/CAPI_APPFW_APP_CONTROL(18556): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:14:56.901+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18075
06-07 17:14:56.901+0200 W/CAPI_APPFW_APP_CONTROL(18075): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:14:56.901+0200 I/utils   (18075): specific action
06-07 17:14:56.901+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:14:56.901+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(18556), cmd(0)
06-07 17:14:56.901+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:14:56.901+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(18075), cmd(0)
06-07 17:14:56.901+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:56.911+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18075)
06-07 17:14:56.911+0200 I/servicemanager(17973): es.ugr.frailty.pressure launch request sent!
06-07 17:14:56.911+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:56.911+0200 I/servicemanager(17973): es.ugr.frailty.light alive timeout
06-07 17:14:56.911+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:14:56.911+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:56.911+0200 I/utils   (18556): specific action
06-07 17:14:56.911+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.911+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:56.911+0200 W/CAPI_APPFW_APP_CONTROL(18583): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:14:56.921+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18079
06-07 17:14:56.921+0200 W/CAPI_APPFW_APP_CONTROL(18079): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:14:56.921+0200 I/utils   (18079): specific action
06-07 17:14:56.921+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:56:875,0.019591,0.028637,0.092724
06-07 17:14:56.921+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:14:56.921+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(18583), cmd(0)
06-07 17:14:56.921+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:14:56.921+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(18079), cmd(0)
06-07 17:14:56.921+0200 I/utils   (18583): specific action
06-07 17:14:56.921+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18079)
06-07 17:14:56.921+0200 I/servicemanager(17973): es.ugr.frailty.light launch request sent!
06-07 17:14:56.921+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:56.921+0200 I/servicemanager(17973): es.ugr.frailty.pedometer alive timeout
06-07 17:14:56.921+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:14:56.931+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:56.931+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:56.931+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:56.931+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:56:937,0.302543,-0.083318,9.801628
06-07 17:14:56.931+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:56.941+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18111
06-07 17:14:56.951+0200 W/CAPI_APPFW_APP_CONTROL(18111): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:14:56.951+0200 I/utils   (18111): specific action
06-07 17:14:56.951+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:14:56.941+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:917,0.070000,0.070000,0.140000
06-07 17:14:56.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(18111), cmd(0)
06-07 17:14:56.951+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.951+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18111)
06-07 17:14:56.951+0200 I/servicemanager(17973): es.ugr.frailty.pedometer launch request sent!
06-07 17:14:56.951+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:56.951+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:56:945,-0.018952,-0.015319,0.035296
06-07 17:14:56.961+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:965,0.070000,0.070000,0.070000
06-07 17:14:56.961+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:14:56.961+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.961+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:14:56:970,635.000000
06-07 17:14:56.961+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:971,-0.070000,0.070000,0.140000
06-07 17:14:56.971+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.971+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:56:932,0.330210,-0.062213,9.877571
06-07 17:14:56.971+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:56.981+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:56.981+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:56:983,0.303801,-0.082708,9.801594
06-07 17:14:56.981+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:56:980,-0.070000,0.070000,0.070000
06-07 17:14:56.971+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:56.981+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:56.981+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:14:56.981+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:14:56.991+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:56.991+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:56:990,0.304699,-0.083981,9.801556
06-07 17:14:56.991+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:57.001+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:56:987,0.344566,-0.074178,9.889536
06-07 17:14:57.001+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:57.001+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:56:992,-0.009462,0.007080,0.064001
06-07 17:14:57.001+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:57.001+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:57:0,-0.070000,0.070000,0.140000
06-07 17:14:57.011+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:57:10,0.320638,-0.107677,9.872787
06-07 17:14:57.011+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:57:9,0.303885,-0.082378,9.801595
06-07 17:14:57.011+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:57.011+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:57.021+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:57:13,0.014046,-0.014124,0.075906
06-07 17:14:57.021+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:57.021+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:57.031+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:57:23,0.304121,-0.083364,9.801579
06-07 17:14:57.031+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:57:23,-0.070000,0.070000,0.070000
06-07 17:14:57.031+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:57:34,-0.006605,-0.026640,0.063911
06-07 17:14:57.031+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:57.031+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:57:42,0.304698,-0.084199,9.801554
06-07 17:14:57.041+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:57.041+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:57:34,0.299103,-0.055035,9.896714
06-07 17:14:57.041+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:57.041+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:57:46,-0.070000,0.070000,0.070000
06-07 17:14:57.051+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:57.051+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:57:56,0.318245,-0.107677,9.870394
06-07 17:14:57.051+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:57.061+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:57.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:14:57.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:14:57.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:14:57.071+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:57.071+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:57:64,-0.070000,0.070000,0.070000
06-07 17:14:57.071+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:57.071+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:57:53,0.029091,-0.038115,0.061528
06-07 17:14:57.071+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:57:75,0.325424,-0.105284,9.856036
06-07 17:14:57.071+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:57.081+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:57.081+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:57:79,0.304250,-0.083762,9.801571
06-07 17:14:57.081+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:57.091+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:57:83,-0.070000,0.070000,0.070000
06-07 17:14:57.091+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:57.091+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:57:88,0.046651,-0.027494,0.080655
06-07 17:14:57.091+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:57.101+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:57:91,0.306281,-0.078963,9.851252
06-07 17:14:57.101+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:57.101+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:57:100,0.303176,-0.082876,9.801612
06-07 17:14:57.101+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:57:103,-0.070000,0.070000,0.070000
06-07 17:14:57.101+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:57.111+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:57:111,0.291924,-0.069392,9.851252
06-07 17:14:57.111+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:57:105,0.015001,-0.009526,0.040004
06-07 17:14:57.111+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:57.111+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:57.111+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:57:119,0.027634,0.022600,0.075957
06-07 17:14:57.121+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:57:124,-0.070000,0.070000,0.070000
06-07 17:14:57.121+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:57:115,0.304231,-0.082929,9.801579
06-07 17:14:57.121+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:57.121+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:57.121+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:57:131,0.325424,-0.081356,9.844072
06-07 17:14:57.131+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:57.131+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:57:135,0.304602,-0.084875,9.801551
06-07 17:14:57.131+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:57.131+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:57:139,0.042101,0.010698,0.087919
06-07 17:14:57.141+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:57.141+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:57.141+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:57.141+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:57:149,0.303734,-0.085158,9.801576
06-07 17:14:57.141+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:57:141,-0.070000,0.070000,0.140000
06-07 17:14:57.141+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:57.151+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:57:155,-0.070000,0.070000,0.070000
06-07 17:14:57.151+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:57:154,0.018095,-0.024359,0.071158
06-07 17:14:57.151+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:57.161+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:57:147,0.308674,-0.122034,9.858429
06-07 17:14:57.161+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:57.161+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:57.161+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:14:57.161+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:57:167,0.287139,-0.088534,9.887143
06-07 17:14:57.161+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:14:57:170,636.000000
06-07 17:14:57.171+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:57.171+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:57:163,0.305793,-0.086085,9.801503
06-07 17:14:57.171+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:57.181+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:57.181+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:57:179,-0.004699,0.027673,0.095120
06-07 17:14:57.181+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:57:181,0.070000,0.070000,0.070000
06-07 17:14:57.181+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:57:186,0.346959,-0.102891,9.882358
06-07 17:14:57.181+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:14:57.181+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(18620), cmd(0)
06-07 17:14:57.181+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:14:57.191+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:14:57.191+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:57.201+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:57.211+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:57:205,0.070000,0.070000,0.070000
06-07 17:14:57.211+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:57.221+0200 W/CAPI_APPFW_APP_CONTROL(18620): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:14:57.221+0200 I/utils   (18620): specific action
06-07 17:14:57.221+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:57.231+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:57:230,0.013546,-0.023696,0.068838
06-07 17:14:57.231+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:57.241+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:57:212,0.320638,-0.090927,9.877571
06-07 17:14:57.241+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:57:241,0.021539,-0.022907,0.054441
06-07 17:14:57.241+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:57.241+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:57:188,0.306488,-0.086416,9.801478
06-07 17:14:57.241+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:57.241+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:57.241+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:57:221,-0.070000,0.070000,0.070000
06-07 17:14:57.241+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:57.251+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:57:251,0.002160,0.004401,0.049673
06-07 17:14:57.251+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:57.251+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:57:246,0.318245,-0.081356,9.896714
06-07 17:14:57.251+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:57.251+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:57:258,-0.012774,0.014807,0.049698
06-07 17:14:57.251+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:57.261+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:57:254,-0.070000,0.070000,0.070000
06-07 17:14:57.261+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:57.261+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:57:264,0.021174,0.002406,0.042501
06-07 17:14:57.261+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:57:249,0.306994,-0.086272,9.801464
06-07 17:14:57.261+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:57.261+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:57.271+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:57:273,0.005498,-0.039158,0.056817
06-07 17:14:57.271+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:57.271+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:57:279,-0.017092,-0.005606,0.085565
06-07 17:14:57.271+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:57.281+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:57:273,0.307138,-0.087615,9.801448
06-07 17:14:57.281+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:57.281+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:57:285,0.042358,-0.018017,0.080807
06-07 17:14:57.281+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:57.291+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:57:294,0.016905,-0.005770,0.075995
06-07 17:14:57.291+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:57.291+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:57:269,-0.070000,0.070000,0.070000
06-07 17:14:57.291+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:57.291+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:57:300,0.012453,0.004729,0.095211
06-07 17:14:57.291+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:57.301+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:57:261,0.308674,-0.112463,9.858429
06-07 17:14:57.301+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:57.311+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:57:305,0.002186,-0.026047,0.056951
06-07 17:14:57.311+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:57:312,0.299103,-0.076570,9.851252
06-07 17:14:57.311+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:57.321+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11186176c6f63152838449
