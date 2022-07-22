S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 5678
Date: 2018-04-23 20:05:04+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf74b852d, r5   = 0xf75bcf98
r6   = 0xffa09900, r7   = 0xffa097b0
r8   = 0xf75b9c18, r9   = 0x00000000
r10  = 0xffa0988c, fp   = 0xffa09900
ip   = 0x00000001, sp   = 0xffa09788
lr   = 0xf74b8539, pc   = 0xf7521228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     59620 KB
Buffers:     36676 KB
Cached:     223784 KB
VmPeak:      53460 KB
VmSize:      53424 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11848 KB
VmRSS:       11848 KB
VmData:      11152 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 5678 TID = 5678
5678 5681 

Maps Information
f4383000 f4b82000 rw-p [stack:5681]
f4b89000 f4b8b000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b93000 f4b97000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4ba0000 f4ba2000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4baa000 f4bad000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4bbc000 f4bc1000 r-xp /usr/lib/libsystem.so.0.0.0
f4bcc000 f4bcf000 r-xp /lib/libattr.so.1.1.0
f4bd7000 f4be7000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4bef000 f4bf8000 r-xp /usr/lib/libedbus.so.1.7.99
f4c00000 f4c01000 r-xp /usr/lib/libresponse.so.0.2.96
f4c0a000 f4c0f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f64b1000 f65b7000 r-xp /usr/lib/libicuuc.so.57.1
f65cd000 f6755000 r-xp /usr/lib/libicui18n.so.57.1
f6765000 f6772000 r-xp /usr/lib/libail.so.0.1.0
f677b000 f6782000 r-xp /usr/lib/libminizip.so.1.0.0
f678b000 f6934000 r-xp /usr/lib/libcrypto.so.1.0.0
f6954000 f699b000 r-xp /usr/lib/libssl.so.1.0.0
f69a7000 f69a9000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f69b1000 f69b8000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f69c1000 f69c8000 r-xp /lib/libcrypt-2.13.so
f69f9000 f69fc000 r-xp /lib/libcap.so.2.21
f6a04000 f6a06000 r-xp /usr/lib/libiri.so
f6a0e000 f6a57000 r-xp /usr/lib/libmdm.so.1.2.69
f6a5f000 f6a65000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a6d000 f6a90000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a9a000 f6a9c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6aa4000 f6ac1000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6aca000 f6ace000 r-xp /usr/lib/libsmack.so.1.0.0
f6ad7000 f6af0000 r-xp /usr/lib/libnetwork.so.0.0.0
f6af9000 f6b01000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b09000 f6b0f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b18000 f6b1a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b23000 f6b33000 r-xp /lib/libresolv-2.13.so
f6b37000 f6b4f000 r-xp /usr/lib/liblzma.so.5.0.3
f6b58000 f6b5a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b62000 f6b7c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b84000 f6bb3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bbc000 f6bcb000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6bd5000 f6bdf000 r-xp /usr/lib/libsensord-shared.so
f6be8000 f6cbb000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6cc6000 f6cdc000 r-xp /lib/libz.so.1.2.5
f6ce4000 f6ce9000 r-xp /usr/lib/libffi.so.5.0.10
f6cf1000 f6cf2000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6cfa000 f6d0a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d12000 f6d2b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d33000 f6d35000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d3d000 f6db2000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6dbc000 f6dc2000 r-xp /lib/librt-2.13.so
f6dcb000 f6de9000 r-xp /usr/lib/libsystemd.so.0.4.0
f6df3000 f6df4000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6dfc000 f6e1f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e27000 f6e2c000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e34000 f6e5e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e67000 f6e7e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e86000 f6eef000 r-xp /lib/libm-2.13.so
f6ef8000 f6f8c000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f9f000 f6fa4000 r-xp /usr/lib/libctx-client.so.0.8.3
f6fac000 f6fb3000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6fbb000 f6fe5000 r-xp /usr/lib/libsensor.so.1.9.6
f6fee000 f70ba000 r-xp /usr/lib/libxml2.so.2.7.8
f70c7000 f70c9000 r-xp /usr/lib/libiniparser.so.0
f70d2000 f70d8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f70e1000 f71b1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71b2000 f71e6000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f71ef000 f722b000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7233000 f7236000 r-xp /usr/lib/libbundle.so.0.1.22
f723e000 f7244000 r-xp /usr/lib/libappsvc.so.0.1.0
f724c000 f728d000 r-xp /usr/lib/libeina.so.1.7.99
f7296000 f72ad000 r-xp /usr/lib/libecore.so.1.7.99
f72c4000 f72cd000 r-xp /usr/lib/libvconf.so.0.2.45
f72d5000 f72e9000 r-xp /lib/libpthread-2.13.so
f72f4000 f7301000 r-xp /usr/lib/libaul.so.0.1.0
f730b000 f730d000 r-xp /lib/libdl-2.13.so
f7316000 f7321000 r-xp /lib/libunwind.so.8.0.1
f734e000 f7356000 r-xp /lib/libgcc_s-4.6.so.1
f7357000 f747b000 r-xp /lib/libc-2.13.so
f7489000 f748b000 r-xp /usr/lib/libdlog.so.0.0.0
f7493000 f749f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74a8000 f74ad000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74b5000 f74c4000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f74cc000 f74d0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74d9000 f74dc000 r-xp /usr/lib/libappcore-agent.so.1.1
f74e4000 f74e6000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f74ee000 f74f2000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f74fa000 f7517000 r-xp /lib/ld-2.13.so
f7520000 f7523000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7523000 f7527000 r-xp /usr/lib/libsys-assert.so
f7589000 f75f4000 rw-p [heap]
ff9eb000 ffa0c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5678)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7521228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf74b8539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71bf3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf71bdc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf71c9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf71cfbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf71cfdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf720475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71ff1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf71bdc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf71c9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf71cfbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf71cfdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7201e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7202017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7209f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4ba11fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b94171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c67663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7114fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71167a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf72a6ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf72a1b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72a25a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf72a2879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf74da183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74da7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75214f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf736e85c) [/lib/libc.so.6] + 0x1785c
29: (0xf7520f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:321,0.048027,9.773414,0.805272
04-23 20:05:03.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:05:03.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:05:03.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:05:03.339+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:03.339+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:03.339+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:321,0.021365,0.022802,-0.003677
04-23 20:05:03.339+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.339+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.359+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.359+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:354,-0.070000,0.070000,0.070000
04-23 20:05:03.359+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:359,0.048958,9.773490,0.804293
04-23 20:05:03.359+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.359+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:363,0.008470,0.044261,-0.050554
04-23 20:05:03.369+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.369+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.369+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:309,0.069392,9.796216,0.801596
04-23 20:05:03.369+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.369+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:377,0.057428,9.817751,0.753739
04-23 20:05:03.379+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.379+0200 E/CAPI_TELEPHONY( 4477): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:05:03.379+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:383,0.081356,9.798609,0.741775
04-23 20:05:03.379+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.379+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:388,0.076570,9.810574,0.815953
04-23 20:05:03.389+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.389+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:372,-0.140000,0.070000,0.070000
04-23 20:05:03.389+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:393,0.011964,9.786645,0.830309
04-23 20:05:03.389+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.389+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:376,0.050071,9.773392,0.805410
04-23 20:05:03.389+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:377,0.031285,0.025217,-0.063635
04-23 20:05:03.389+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.389+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:397,0.040678,9.803394,0.784846
04-23 20:05:03.389+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.399+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.399+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:401,-0.140000,0.140000,0.070000
04-23 20:05:03.399+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:403,0.026004,0.037082,0.011781
04-23 20:05:03.399+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.399+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.399+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:408,-0.040237,0.012932,0.028941
04-23 20:05:03.399+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.399+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:409,0.035892,9.848858,0.765703
04-23 20:05:03.409+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:412,-0.012806,0.029833,-0.018282
04-23 20:05:03.409+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.409+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:403,0.050566,9.773492,0.804172
04-23 20:05:03.409+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.409+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.409+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:416,-0.015797,0.075526,-0.040334
04-23 20:05:03.419+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:420,0.052201,9.773713,0.801368
04-23 20:05:03.419+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.419+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:419,-0.070000,0.070000,0.070000
04-23 20:05:03.419+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.419+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.419+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.419+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:428,-0.008231,0.049256,-0.033791
04-23 20:05:03.419+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:429,0.043071,9.822537,0.772882
04-23 20:05:03.429+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:424,0.053484,9.773561,0.803127
04-23 20:05:03.429+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:426,-0.070000,0.070000,0.070000
04-23 20:05:03.429+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.429+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.429+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:435,0.051689,9.773332,0.806037
04-23 20:05:03.429+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.429+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:435,-0.070000,0.070000,0.070000
04-23 20:05:03.429+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.439+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:440,0.051302,9.773281,0.806673
04-23 20:05:03.439+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.439+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:443,-0.070000,0.140000,0.070000
04-23 20:05:03.439+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.439+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.439+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.439+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:447,-0.070000,0.070000,0.070000
04-23 20:05:03.439+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.449+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:452,-0.070000,0.070000,0.070000
04-23 20:05:03.449+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:447,0.050699,9.773316,0.806284
04-23 20:05:03.449+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.449+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:451,0.023478,0.001364,-0.011867
04-23 20:05:03.449+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:452,0.074178,9.774680,0.794417
04-23 20:05:03.459+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:460,0.050475,9.773331,0.806127
04-23 20:05:03.459+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.459+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.459+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.459+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:468,-0.070000,0.070000,0.070000
04-23 20:05:03.459+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.469+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:468,0.051747,9.773285,0.806598
04-23 20:05:03.469+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:468,-0.028939,0.037243,-0.045209
04-23 20:05:03.469+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:472,0.021535,9.810574,0.760918
04-23 20:05:03.479+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.479+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.489+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:491,-0.070000,0.070000,0.070000
04-23 20:05:03.489+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:491,0.043071,9.820145,0.794417
04-23 20:05:03.489+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.489+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.489+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:495,-0.008676,0.046860,-0.012180
04-23 20:05:03.489+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:495,0.050441,9.773292,0.806599
04-23 20:05:03.499+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.499+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.509+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:510,-0.070000,0.070000,0.070000
04-23 20:05:03.509+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:510,0.069392,9.808180,0.784846
04-23 20:05:03.509+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.509+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.509+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:514,0.018950,0.034888,-0.021753
04-23 20:05:03.509+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:515,0.050231,9.773223,0.807455
04-23 20:05:03.519+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.519+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.519+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.529+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:528,0.040678,9.793823,0.787239
04-23 20:05:03.529+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.529+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:529,-0.070000,0.070000,0.070000
04-23 20:05:03.529+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:534,-0.009553,0.020600,-0.020216
04-23 20:05:03.539+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:528,0.051282,9.773234,0.807244
04-23 20:05:03.539+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:03.539+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:03.539+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.539+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.549+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.549+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:552,-0.001033,0.039731,-0.017613
04-23 20:05:03.549+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:553,0.050249,9.812965,0.789631
04-23 20:05:03.549+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.549+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:551,-0.070000,0.070000,0.070000
04-23 20:05:03.559+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:561,0.050923,9.773184,0.807879
04-23 20:05:03.559+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.559+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.569+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.569+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:569,-0.010245,0.061317,0.032002
04-23 20:05:03.569+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.569+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:573,0.040678,9.834501,0.839881
04-23 20:05:03.569+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:569,-0.070000,0.070000,0.070000
04-23 20:05:03.569+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:576,0.051031,9.773148,0.808311
04-23 20:05:03.579+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.579+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.589+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.589+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:591,0.004004,0.008711,-0.013894
04-23 20:05:03.589+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.589+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:593,-0.070000,0.140000,0.070000
04-23 20:05:03.599+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:591,0.055035,9.781858,0.794417
04-23 20:05:03.599+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:598,0.050678,9.772906,0.811246
04-23 20:05:03.599+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.599+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.609+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.609+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:609,-0.029142,0.056808,-0.033578
04-23 20:05:03.609+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.609+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:613,0.021535,9.829715,0.777667
04-23 20:05:03.609+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:609,-0.070000,0.070000,0.070000
04-23 20:05:03.619+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:616,0.051031,9.772861,0.811768
04-23 20:05:03.619+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.619+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.629+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.629+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:629,0.001611,0.056853,-0.014958
04-23 20:05:03.629+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.629+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:633,0.052642,9.829715,0.796810
04-23 20:05:03.629+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:629,-0.070000,0.070000,0.070000
04-23 20:05:03.639+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:638,0.049762,9.772830,0.812216
04-23 20:05:03.639+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.639+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.649+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.649+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:650,0.000488,0.020993,-0.036941
04-23 20:05:03.649+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.649+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:653,0.050249,9.793823,0.775275
04-23 20:05:03.649+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:650,-0.070000,0.140000,0.070000
04-23 20:05:03.659+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:657,0.050028,9.772781,0.812788
04-23 20:05:03.659+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.659+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.659+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.669+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:670,-0.054813,0.006685,-0.061441
04-23 20:05:03.669+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.669+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:672,-0.004786,9.779467,0.751346
04-23 20:05:03.669+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:669,-0.070000,0.070000,0.070000
04-23 20:05:03.669+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:677,0.050184,9.772818,0.812338
04-23 20:05:03.679+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.679+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.679+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.689+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.689+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:689,-0.007114,0.030577,-0.046635
04-23 20:05:03.699+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:697,0.047677,9.772775,0.813014
04-23 20:05:03.699+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.709+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:709,0.012144,0.006692,-0.037739
04-23 20:05:03.709+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.719+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.729+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:689,-0.070000,0.070000,0.070000
04-23 20:05:03.729+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:693,0.043071,9.803394,0.765703
04-23 20:05:03.729+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:721,0.047601,9.772837,0.812273
04-23 20:05:03.729+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.729+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:729,-0.006923,-0.000549,-0.025034
04-23 20:05:03.729+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.749+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:748,0.059821,9.779467,0.775275
04-23 20:05:03.749+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:743,-0.070000,0.070000,0.070000
04-23 20:05:03.749+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.759+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:761,-0.019382,0.023408,-0.027744
04-23 20:05:03.759+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.769+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:771,-0.000240,0.028193,-0.032529
04-23 20:05:03.769+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:03.769+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:03.769+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.779+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:780,0.048316,9.772861,0.811932
04-23 20:05:03.779+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.779+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.789+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.789+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.799+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:797,0.040678,9.772287,0.787239
04-23 20:05:03.799+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:795,-0.070000,0.280000,0.070000
04-23 20:05:03.799+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.799+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.809+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:790,-0.023390,0.044996,-0.078674
04-23 20:05:03.819+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:813,0.028714,9.796216,0.784846
04-23 20:05:03.819+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.819+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:810,-0.070000,0.140000,0.070000
04-23 20:05:03.819+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:789,0.048096,9.772808,0.812589
04-23 20:05:03.819+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.819+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.819+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.819+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:826,0.047856,9.801002,0.780060
04-23 20:05:03.819+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.829+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:833,0.023928,9.817751,0.734596
04-23 20:05:03.829+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.829+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:831,0.047318,9.772755,0.813271
04-23 20:05:03.829+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:837,0.023928,9.805787,0.760918
04-23 20:05:03.829+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.839+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:832,-0.070000,0.070000,0.070000
04-23 20:05:03.839+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:842,0.038285,9.805787,0.794417
04-23 20:05:03.839+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:833,-0.023553,0.033027,-0.052273
04-23 20:05:03.839+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.839+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.839+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.839+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.849+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:847,-0.070000,0.140000,0.070000
04-23 20:05:03.849+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.849+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:853,-0.008197,0.032933,-0.017707
04-23 20:05:03.849+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:851,0.047481,9.772760,0.813191
04-23 20:05:03.849+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:857,-0.140000,0.140000,0.070000
04-23 20:05:03.849+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.859+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.859+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.859+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:850,0.059821,9.827322,0.756132
04-23 20:05:03.859+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.869+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:868,0.031107,9.832108,0.784846
04-23 20:05:03.869+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:865,0.014276,0.054453,-0.055863
04-23 20:05:03.869+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:864,0.046483,9.772854,0.812124
04-23 20:05:03.869+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:862,-0.070000,0.070000,0.070000
04-23 20:05:03.869+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.869+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.869+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.869+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:877,-0.070000,0.070000,0.070000
04-23 20:05:03.879+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.879+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:881,-0.014236,0.059309,-0.028001
04-23 20:05:03.879+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:883,-0.070000,0.070000,0.070000
04-23 20:05:03.879+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.879+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:879,0.045545,9.772869,0.811995
04-23 20:05:03.879+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.889+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:888,0.045464,9.784252,0.787239
04-23 20:05:03.889+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.889+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:891,0.045343,9.772799,0.812846
04-23 20:05:03.889+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.889+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:894,-0.070000,-0.070000,0.070000
04-23 20:05:03.889+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.889+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:897,0.046179,9.772967,0.810777
04-23 20:05:03.889+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.899+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:903,0.045613,9.772942,0.811125
04-23 20:05:03.899+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.899+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.909+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:909,0.078963,9.805787,0.806381
04-23 20:05:03.909+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.909+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:910,0.045753,9.772907,0.811530
04-23 20:05:03.909+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:899,-0.000715,0.011285,-0.023538
04-23 20:05:03.909+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.909+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:914,-0.070000,0.070000,0.070000
04-23 20:05:03.909+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:917,0.033350,0.032845,-0.004744
04-23 20:05:03.919+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.919+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.919+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:929,0.059821,9.791430,0.794417
04-23 20:05:03.919+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:929,0.047461,9.772845,0.812172
04-23 20:05:03.929+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.929+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.929+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:933,-0.140000,0.070000,0.070000
04-23 20:05:03.929+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:934,0.014068,0.018523,-0.017113
04-23 20:05:03.939+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:03.939+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:03.939+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.939+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.949+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:951,0.081356,9.808180,0.808774
04-23 20:05:03.949+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.949+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:951,0.048191,9.772818,0.812469
04-23 20:05:03.949+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.949+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:955,-0.070000,0.070000,0.070000
04-23 20:05:03.949+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:956,0.033895,0.035335,-0.003398
04-23 20:05:03.959+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.959+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.959+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:969,0.049891,9.772762,0.813028
04-23 20:05:03.969+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.969+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:969,-0.007513,0.004255,-0.053944
04-23 20:05:03.969+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.969+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:973,0.040678,9.777073,0.758525
04-23 20:05:03.969+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:974,-0.070000,0.070000,0.070000
04-23 20:05:03.979+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.979+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:03.989+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.989+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:03:990,-0.002035,0.040203,0.000532
04-23 20:05:03.989+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:03.989+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:03:991,0.049600,9.772838,0.812133
04-23 20:05:03.989+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:03:997,-0.070000,0.070000,0.070000
04-23 20:05:03.999+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:03:993,0.047856,9.812965,0.813560
04-23 20:05:03.999+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:03.999+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:03.999+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:04.009+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:04.009+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:04:9,-0.023278,-0.007729,-0.041644
04-23 20:05:04.009+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:04:14,-0.070000,0.070000,0.070000
04-23 20:05:04.019+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:04:16,0.049657,9.772717,0.813587
04-23 20:05:04.019+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:04:10,0.026321,9.765109,0.770489
04-23 20:05:04.019+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:04.019+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:04.029+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:04.029+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:04:30,0.048694,9.772693,0.813937
04-23 20:05:04.029+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:04:31,0.014950,0.052213,-0.000027
04-23 20:05:04.039+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:04.039+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:04:37,-0.140000,0.070000,0.070000
04-23 20:05:04.039+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:04.039+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:04.049+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:04.049+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:04:43,0.064606,9.824929,0.813560
04-23 20:05:04.049+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:04:51,-0.027159,0.025916,-0.014735
04-23 20:05:04.049+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:04:51,0.049571,9.772596,0.815043
04-23 20:05:04.059+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:04.059+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:04:57,-0.070000,0.140000,0.070000
04-23 20:05:04.059+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:04.059+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:04.069+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:04.069+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:04:70,-0.070000,0.140000,0.070000
04-23 20:05:04.069+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:04:71,0.048380,9.772478,0.816525
04-23 20:05:04.079+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:04:76,-0.068714,0.033191,0.020052
04-23 20:05:04.079+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:04:65,0.021535,9.798609,0.799203
04-23 20:05:04.079+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:04.079+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:04.089+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:04.089+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:04:89,-0.019143,9.805787,0.835095
04-23 20:05:04.089+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:04.089+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:04:96,0.035892,9.805787,0.763310
04-23 20:05:04.089+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:04.099+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:04:102,-0.012488,0.033309,-0.053215
04-23 20:05:04.109+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:04.109+0200 W/LOCATION( 5678): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:05:04.109+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:04:89,-0.070000,0.140000,0.070000
04-23 20:05:04.109+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:04.119+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:04:93,0.045361,9.772197,0.820062
04-23 20:05:04.119+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:04.119+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:04:115,0.055035,9.836893,0.782453
04-23 20:05:04.119+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:04.119+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:04.129+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:04:119,-0.070000,0.070000,0.070000
04-23 20:05:04.129+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:04.129+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:04:130,0.009674,0.064696,-0.037609
04-23 20:05:04.129+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:04:125,0.045051,9.772273,0.819167
04-23 20:05:04.129+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:04.139+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:04:135,-0.070000,0.070000,0.070000
04-23 20:05:04.139+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:04:142,0.045662,9.772337,0.818371
04-23 20:05:04.139+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:04.139+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:04.139+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:04.139+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:04:129,0.038285,9.779467,0.768096
04-23 20:05:04.139+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:04.149+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:04.149+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:04:151,-0.070000,0.070000,0.070000
04-23 20:05:04.149+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:04.149+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:04:153,-0.006766,0.007194,-0.051071
04-23 20:05:04.149+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:04.149+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:04:156,0.045458,9.772388,0.817771
04-23 20:05:04.149+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:04:158,-0.002387,0.002292,-0.078389
04-23 20:05:04.159+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:04:151,0.043071,9.774680,0.739382
04-23 20:05:04.159+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:04.169+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:04.179+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:04:169,-0.070000,0.070000,0.070000
04-23 20:05:04.179+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:04.179+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:04.189+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:04:175,0.045498,9.772573,0.815550
04-23 20:05:04.189+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:04:187,0.062213,9.796216,0.825524
04-23 20:05:04.189+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:04.199+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:04.209+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:04:209,0.046417,9.772414,0.817399
04-23 20:05:04.209+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:04.209+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:04:198,-0.070000,0.140000,0.070000
04-23 20:05:04.209+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:04:203,0.016755,0.023828,0.007753
04-23 20:05:04.209+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:04.219+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:04.219+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:04.219+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:04:223,-0.070000,0.140000,0.070000
04-23 20:05:04.229+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:04:220,0.043071,9.832108,0.799203
04-23 20:05:04.229+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:04:226,-0.002427,0.059535,-0.016347
04-23 20:05:04.229+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:04:232,0.046389,9.772356,0.818104
04-23 20:05:04.229+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:04.229+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:04.239+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:04.239+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:04:244,-0.070000,0.070000,0.070000
04-23 20:05:04.239+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:04.249+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:04:247,0.001439,0.045337,-0.018197
04-23 20:05:04.249+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:04:240,0.047856,9.817751,0.799203
04-23 20:05:04.249+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:04.249+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:04.249+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:04:251,0.046597,9.772316,0.818563
04-23 20:05:04.259+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:04:258,0.078963,9.793823,0.780060
04-23 20:05:04.259+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:04.259+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:04.269+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:04:273,0.048287,9.772433,0.817071
04-23 20:05:04.269+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:04:261,-0.070000,0.070000,0.070000
04-23 20:05:04.269+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:04.279+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:04.279+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:04:268,0.032575,0.021467,-0.038043
04-23 20:05:04.279+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:04.279+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:04.289+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:04:280,0.064606,9.777073,0.789631
04-23 20:05:04.289+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:04.289+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:04:284,-0.140000,0.070000,0.070000
04-23 20:05:04.289+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:04:295,0.050249,9.793823,0.792024
04-23 20:05:04.289+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:04.289+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:04:284,0.018009,0.004757,-0.028932
04-23 20:05:04.289+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:04:289,0.049217,9.772440,0.816935
04-23 20:05:04.289+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:04.289+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:04.299+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:04:301,0.001963,0.021390,-0.025047
04-23 20:05:04.299+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:04.299+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:04:299,-0.070000,0.140000,0.070000
04-23 20:05:04.299+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:04.299+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:04:305,-0.001360,0.023776,0.001411
04-23 20:05:04.299+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:04.299+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:04:303,0.049404,9.772414,0.817234
04-23 20:05:04.299+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:04.309+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:04:309,0.047856,9.796216,0.818345
04-23 20:05:04.309+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:04:316,-0.070000,0.140000,0.070000
04-23 20:05:04.309+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:04.319+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:04.319+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:04:310,-0.023083,0.014231,-0.034781
04-23 20:05:04.319+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:04:320,0.049468,9.772277,0.818863
04-23 20:05:04.329+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11056786c6f63152450670
