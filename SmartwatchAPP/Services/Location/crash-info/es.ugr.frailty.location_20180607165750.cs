S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 13418
Date: 2018-06-07 16:57:50+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf743a52d, r5   = 0xf76e7958
r6   = 0xffd5afc0, r7   = 0xffd5ae70
r8   = 0xf76fac18, r9   = 0x00000000
r10  = 0xffd5af4c, fp   = 0xffd5afc0
ip   = 0x00000001, sp   = 0xffd5ae48
lr   = 0xf743a539, pc   = 0xf74a3228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    102100 KB
Buffers:      6016 KB
Cached:      54264 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11148 KB
VmRSS:       11144 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          8 KB

Threads Information
Threads: 2
PID = 13418 TID = 13418
13418 13427 

Maps Information
f4305000 f4b04000 rw-p [stack:13427]
f4b0b000 f4b0d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b15000 f4b19000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b22000 f4b24000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b2c000 f4b2f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b3e000 f4b43000 r-xp /usr/lib/libsystem.so.0.0.0
f4b4e000 f4b51000 r-xp /lib/libattr.so.1.1.0
f4b59000 f4b69000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b71000 f4b7a000 r-xp /usr/lib/libedbus.so.1.7.99
f4b82000 f4b83000 r-xp /usr/lib/libresponse.so.0.2.96
f4b8c000 f4b91000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6433000 f6539000 r-xp /usr/lib/libicuuc.so.57.1
f654f000 f66d7000 r-xp /usr/lib/libicui18n.so.57.1
f66e7000 f66f4000 r-xp /usr/lib/libail.so.0.1.0
f66fd000 f6704000 r-xp /usr/lib/libminizip.so.1.0.0
f670d000 f68b6000 r-xp /usr/lib/libcrypto.so.1.0.0
f68d6000 f691d000 r-xp /usr/lib/libssl.so.1.0.0
f6929000 f692b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6933000 f693a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6943000 f694a000 r-xp /lib/libcrypt-2.13.so
f697b000 f697e000 r-xp /lib/libcap.so.2.21
f6986000 f6988000 r-xp /usr/lib/libiri.so
f6990000 f69d9000 r-xp /usr/lib/libmdm.so.1.2.69
f69e1000 f69e7000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f69ef000 f6a12000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a1c000 f6a1e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a26000 f6a43000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a4c000 f6a50000 r-xp /usr/lib/libsmack.so.1.0.0
f6a59000 f6a72000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a7b000 f6a83000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a8b000 f6a91000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a9a000 f6a9c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6aa5000 f6ab5000 r-xp /lib/libresolv-2.13.so
f6ab9000 f6ad1000 r-xp /usr/lib/liblzma.so.5.0.3
f6ada000 f6adc000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6ae4000 f6afe000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b06000 f6b35000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b3e000 f6b4d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b57000 f6b61000 r-xp /usr/lib/libsensord-shared.so
f6b6a000 f6c3d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c48000 f6c5e000 r-xp /lib/libz.so.1.2.5
f6c66000 f6c6b000 r-xp /usr/lib/libffi.so.5.0.10
f6c73000 f6c74000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c7c000 f6c8c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c94000 f6cad000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6cb5000 f6cb7000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6cbf000 f6d34000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d3e000 f6d44000 r-xp /lib/librt-2.13.so
f6d4d000 f6d6b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d75000 f6d76000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d7e000 f6da1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6da9000 f6dae000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6db6000 f6de0000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6de9000 f6e00000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e08000 f6e71000 r-xp /lib/libm-2.13.so
f6e7a000 f6f0e000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f21000 f6f26000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f2e000 f6f35000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f3d000 f6f67000 r-xp /usr/lib/libsensor.so.1.9.6
f6f70000 f703c000 r-xp /usr/lib/libxml2.so.2.7.8
f7049000 f704b000 r-xp /usr/lib/libiniparser.so.0
f7054000 f705a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7063000 f7133000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7134000 f7168000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7171000 f71ad000 r-xp /usr/lib/libSLP-location.so.0.9.24
f71b5000 f71b8000 r-xp /usr/lib/libbundle.so.0.1.22
f71c0000 f71c6000 r-xp /usr/lib/libappsvc.so.0.1.0
f71ce000 f720f000 r-xp /usr/lib/libeina.so.1.7.99
f7218000 f722f000 r-xp /usr/lib/libecore.so.1.7.99
f7246000 f724f000 r-xp /usr/lib/libvconf.so.0.2.45
f7257000 f726b000 r-xp /lib/libpthread-2.13.so
f7276000 f7283000 r-xp /usr/lib/libaul.so.0.1.0
f728d000 f728f000 r-xp /lib/libdl-2.13.so
f7298000 f72a3000 r-xp /lib/libunwind.so.8.0.1
f72d0000 f72d8000 r-xp /lib/libgcc_s-4.6.so.1
f72d9000 f73fd000 r-xp /lib/libc-2.13.so
f740b000 f740d000 r-xp /usr/lib/libdlog.so.0.0.0
f7415000 f7421000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f742a000 f742f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7437000 f7446000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f744e000 f7452000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f745b000 f745e000 r-xp /usr/lib/libappcore-agent.so.1.1
f7466000 f7468000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7470000 f7474000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f747c000 f7499000 r-xp /lib/ld-2.13.so
f74a2000 f74a5000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f74a5000 f74a9000 r-xp /usr/lib/libsys-assert.so
f76ca000 f773b000 rw-p [heap]
ffd3c000 ffd5d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13418)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf74a3228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf743a539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71413f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf713fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf714be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7151be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7151dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf718675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71811f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf713fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf714be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7151be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7151dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7183e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7184017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf718bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b231fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b16171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6be9663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7096fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70987a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7228ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7223b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72245a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7224879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf745c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf745c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74a35c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf72f085c) [/lib/libc.so.6] + 0x1785c
29: (0xf74a2f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
.350000
06-07 16:57:50.011+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.011+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:19,2.201593,-0.504268,9.543013
06-07 16:57:50.011+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:49:977,-0.013498,-0.036804,0.018448
06-07 16:57:50.011+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.021+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.021+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.031+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:34,2.204211,-0.504598,9.542391
06-07 16:57:50.031+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:31,-0.490000,0.140000,0.210000
06-07 16:57:50.031+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.041+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:7,2.230111,-0.547956,9.597611
06-07 16:57:50.041+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:57:50.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:57:50.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:57:50.061+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:24,-0.042247,-0.030605,0.023869
06-07 16:57:50.061+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.061+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.061+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:67,2.208878,-0.507004,9.541183
06-07 16:57:50.061+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:68,-0.007433,-0.027827,0.069729
06-07 16:57:50.061+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:50,2.282753,-0.519243,9.547362
06-07 16:57:50.061+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.071+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:75,2.213361,-0.516850,9.614362
06-07 16:57:50.071+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.071+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:80,2.237289,-0.557528,9.623933
06-07 16:57:50.071+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.081+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.081+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:42,0.070000,0.140000,0.070000
06-07 16:57:50.081+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:87,2.206758,-0.506506,9.541700
06-07 16:57:50.081+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.081+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:85,2.232504,-0.459422,9.556933
06-07 16:57:50.081+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.081+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.091+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:94,2.208428,-0.506945,9.541291
06-07 16:57:50.091+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.091+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:94,2.227718,-0.464208,9.573684
06-07 16:57:50.091+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.091+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:99,2.201397,-0.495314,9.556933
06-07 16:57:50.091+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.101+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:57:50.101+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:103,2.230111,-0.583849,9.645468
06-07 16:57:50.101+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.101+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:57:50:106,81
06-07 16:57:50.101+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:108,2.249253,-0.531207,9.592826
06-07 16:57:50.101+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:91,0.070000,0.140000,0.210000
06-07 16:57:50.101+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.101+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.111+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:113,2.218147,-0.488136,9.604790
06-07 16:57:50.111+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.111+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:118,2.256432,-0.528814,9.535398
06-07 16:57:50.111+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.121+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:57:50.121+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.121+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:57:50:126,856.000000
06-07 16:57:50.121+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:126,2.207755,-0.506761,9.541456
06-07 16:57:50.121+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:98,-0.018705,0.005607,-0.004484
06-07 16:57:50.121+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.121+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:123,2.175076,-0.492921,9.609575
06-07 16:57:50.121+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.131+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:132,-0.064810,-0.000689,0.069337
06-07 16:57:50.131+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.131+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.131+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:138,2.230111,-0.502493,9.614362
06-07 16:57:50.131+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:139,0.001335,0.022832,0.009139
06-07 16:57:50.131+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.131+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:134,2.207474,-0.506265,9.541548
06-07 16:57:50.131+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.141+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:146,2.227718,-0.507278,9.626326
06-07 16:57:50.141+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.141+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.151+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:114,-0.560000,0.350000,0.350000
06-07 16:57:50.151+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.151+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:154,2.203255,-0.505896,9.542542
06-07 16:57:50.151+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:151,2.234896,-0.512064,9.554541
06-07 16:57:50.151+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.151+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:157,-0.840000,0.210000,0.350000
06-07 16:57:50.151+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.151+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:161,2.194218,-0.526421,9.626326
06-07 16:57:50.161+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.161+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:166,2.215754,-0.509671,9.590433
06-07 16:57:50.161+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:162,-0.910000,0.280000,0.210000
06-07 16:57:50.161+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.191+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:143,0.017995,-0.074176,-0.024833
06-07 16:57:50.191+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.211+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:202,-0.023216,-0.054414,0.026124
06-07 16:57:50.221+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.231+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:232,-0.420000,0.280000,0.210000
06-07 16:57:50.231+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.231+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:174,2.202849,-0.505623,9.542651
06-07 16:57:50.241+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:238,-0.420000,0.350000,0.210000
06-07 16:57:50.241+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.251+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:253,-0.140000,0.210000,0.280000
06-07 16:57:50.251+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.251+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:259,-0.070000,0.210000,0.350000
06-07 16:57:50.251+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.261+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:265,0.070000,0.070000,0.420000
06-07 16:57:50.261+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.261+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.261+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:269,2.201524,-0.505041,9.542988
06-07 16:57:50.261+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:270,-0.420000,0.280000,0.420000
06-07 16:57:50.271+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.271+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.271+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:276,2.210968,-0.504886,9.580862
06-07 16:57:50.271+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.271+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:276,-0.420000,0.070000,0.280000
06-07 16:57:50.271+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.281+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.281+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.291+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:282,0.210000,0.840000,-0.280000
06-07 16:57:50.291+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.291+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:297,0.350000,0.840000,-0.280000
06-07 16:57:50.291+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:57:50.291+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.301+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:57:50:302,81
06-07 16:57:50.301+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:304,0.420000,0.140000,0.280000
06-07 16:57:50.301+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:280,2.254039,-0.500100,9.635897
06-07 16:57:50.301+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.311+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:312,0.420000,-0.210000,0.280000
06-07 16:57:50.311+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.311+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:292,2.204959,-0.505701,9.542159
06-07 16:57:50.311+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:57:50.311+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:318,-0.630000,-0.420000,0.420000
06-07 16:57:50.311+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:57:50:320,856.000000
06-07 16:57:50.311+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.321+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:288,-0.005671,-0.041843,0.027336
06-07 16:57:50.321+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.321+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:325,-0.630000,-0.210000,0.350000
06-07 16:57:50.321+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.321+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.331+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:331,0.840000,-0.280000,0.350000
06-07 16:57:50.331+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.331+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.331+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:335,2.202619,-0.505353,9.542718
06-07 16:57:50.331+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:57:50.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:57:50.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:57:50.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:57:50.331+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390670342,000000, pattern:[H:mm][0;m
06-07 16:57:50.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:57:50.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:57:50.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:57:50.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:57:50.331+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:57:50.331+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:57][0;m
06-07 16:57:50.331+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:339,0.980000,-0.140000,0.070000
06-07 16:57:50.331+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.341+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:345,0.280000,-0.140000,0.140000
06-07 16:57:50.341+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.341+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:351,-0.210000,-0.140000,0.210000
06-07 16:57:50.351+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.351+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:328,-0.045684,-0.033929,0.070425
06-07 16:57:50.351+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.351+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:357,-0.070000,-0.140000,0.280000
06-07 16:57:50.351+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.351+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:360,-0.021991,-0.009790,0.037122
06-07 16:57:50.351+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.361+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:363,0.140000,-0.140000,0.210000
06-07 16:57:50.361+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.361+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:336,2.189433,-0.509671,9.611969
06-07 16:57:50.361+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.361+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:370,0.210000,0.140000,0.280000
06-07 16:57:50.371+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.371+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:342,2.202375,-0.505123,9.542787
06-07 16:57:50.371+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:376,-1.050000,0.630000,0.140000
06-07 16:57:50.381+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.381+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:373,2.230111,-0.509671,9.547362
06-07 16:57:50.381+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.391+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.401+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:393,-0.350000,0.210000,-0.070000
06-07 16:57:50.401+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:390,2.256432,-0.502493,9.609575
06-07 16:57:50.401+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.401+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:396,2.204866,-0.505398,9.542197
06-07 16:57:50.401+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.411+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.411+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:412,1.190000,0.280000,-0.070000
06-07 16:57:50.411+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:416,2.220540,-0.521635,9.590433
06-07 16:57:50.411+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.421+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:413,2.203266,-0.505566,9.542558
06-07 16:57:50.421+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.421+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.421+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:365,-0.047618,0.042114,0.017357
06-07 16:57:50.431+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.431+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:430,0.490000,-0.070000,-0.070000
06-07 16:57:50.441+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:425,2.218147,-0.540778,9.604790
06-07 16:57:50.441+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.441+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.441+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:427,2.201260,-0.506433,9.542974
06-07 16:57:50.451+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:437,-0.021904,-0.029176,0.055258
06-07 16:57:50.451+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.451+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.451+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:459,2.201964,-0.507081,9.542778
06-07 16:57:50.451+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:448,-0.420000,-0.350000,0.280000
06-07 16:57:50.451+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.471+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.481+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:457,-0.023655,-0.009733,-0.012555
06-07 16:57:50.481+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:448,2.230111,-0.514457,9.595219
06-07 16:57:50.481+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.481+0200 W/LOCATION(13418): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 16:57:50.491+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.491+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:476,2.206068,-0.508205,9.541770
06-07 16:57:50.491+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.491+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:57:50.501+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:57:50:502,81
06-07 16:57:50.501+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:494,2.251646,-0.509671,9.573684
06-07 16:57:50.511+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.511+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:467,-0.280000,-0.210000,0.280000
06-07 16:57:50.511+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:57:50.511+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:57:50:520,855.000000
06-07 16:57:50.521+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:496,-0.032467,-0.057715,0.092679
06-07 16:57:50.521+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.521+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.521+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:501,2.209150,-0.510868,9.540915
06-07 16:57:50.521+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.531+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:516,2.222932,-0.540778,9.530612
06-07 16:57:50.531+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.531+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:537,2.203789,-0.504886,9.549755
06-07 16:57:50.531+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.531+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:540,2.189433,-0.500100,9.595219
06-07 16:57:50.531+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.531+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:529,-0.140000,-0.280000,0.280000
06-07 16:57:50.541+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:532,2.208759,-0.510862,9.541005
06-07 16:57:50.541+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.541+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.541+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:548,2.206436,-0.509857,9.541596
06-07 16:57:50.541+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.551+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:528,-0.001748,-0.037248,0.018663
06-07 16:57:50.551+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.551+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:557,0.010404,0.036280,-0.013490
06-07 16:57:50.551+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:549,0.210000,-0.420000,0.210000
06-07 16:57:50.551+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.551+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.561+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:564,0.350000,0.140000,0.210000
06-07 16:57:50.571+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.571+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:551,2.204323,-0.510159,9.542069
06-07 16:57:50.571+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.571+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:576,-0.490000,-0.210000,0.140000
06-07 16:57:50.571+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:577,2.204171,-0.508165,9.542211
06-07 16:57:50.571+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.571+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:544,2.213361,-0.535992,9.585647
06-07 16:57:50.581+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.581+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:562,0.015832,-0.025301,0.031313
06-07 16:57:50.581+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.591+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.591+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:591,0.140000,0.070000,0.070000
06-07 16:57:50.591+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:596,0.010195,0.022396,0.009283
06-07 16:57:50.591+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.591+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.591+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:601,0.006564,-0.060868,0.009046
06-07 16:57:50.601+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:601,0.490000,0.140000,0.210000
06-07 16:57:50.601+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.611+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:615,0.280000,-0.140000,0.280000
06-07 16:57:50.611+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:595,2.232504,-0.473779,9.578469
06-07 16:57:50.611+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.611+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.621+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:580,2.201826,-0.511318,9.542583
06-07 16:57:50.621+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.621+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:627,2.203253,-0.512687,9.542181
06-07 16:57:50.621+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.621+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:625,0.070000,-0.280000,0.280000
06-07 16:57:50.621+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.631+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:622,2.196611,-0.581456,9.616754
06-07 16:57:50.631+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.641+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:636,-0.140000,-0.210000,0.280000
06-07 16:57:50.641+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:630,2.202928,-0.513820,9.542194
06-07 16:57:50.641+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.641+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.641+0200 W/CAPI_APPFW_APP_CONTROL(13292): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:57:50.641+0200 I/utils   (13292): specific action
06-07 16:57:50.641+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:57:50.641+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(13292), cmd(0)
06-07 16:57:50.641+0200 W/CAPI_APPFW_APP_CONTROL(13292): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:57:50.641+0200 I/utils   (13292): specific action
06-07 16:57:50.641+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.641+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:57:50.641+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(13292), cmd(0)
06-07 16:57:50.641+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:637,2.230111,-0.535992,9.600004
06-07 16:57:50.651+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.651+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:655,2.191825,-0.528814,9.580862
06-07 16:57:50.651+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.651+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:649,-0.210000,0.210000,0.140000
06-07 16:57:50.651+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.651+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:659,2.251646,-0.538385,9.571291
06-07 16:57:50.651+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.661+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:663,0.350000,0.210000,0.280000
06-07 16:57:50.661+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.671+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:647,2.202813,-0.514296,9.542195
06-07 16:57:50.671+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.671+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:676,2.203434,-0.511644,9.542195
06-07 16:57:50.671+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.671+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:679,2.203683,-0.510537,9.542196
06-07 16:57:50.671+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.681+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:650,0.005424,-0.038933,0.052948
06-07 16:57:50.681+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.681+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:674,0.770000,-0.210000,0.280000
06-07 16:57:50.681+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:687,0.031460,-0.008337,0.065763
06-07 16:57:50.691+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.691+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.691+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:57:50.701+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:57:50:702,81
06-07 16:57:50.701+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:663,2.249253,-0.466600,9.580862
06-07 16:57:50.701+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.701+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:683,2.203715,-0.510656,9.542183
06-07 16:57:50.701+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.711+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:697,-0.019319,0.032896,0.037817
06-07 16:57:50.711+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:701,0.560000,-0.350000,-0.140000
06-07 16:57:50.711+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.711+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:57:50.711+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:57:50:721,855.000000
06-07 16:57:50.721+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:708,2.237289,-0.488136,9.659825
06-07 16:57:50.721+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.721+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:727,2.210968,-0.504886,9.623933
06-07 16:57:50.721+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.721+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.731+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:711,2.201894,-0.513315,9.542460
06-07 16:57:50.731+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:732,0.560000,-0.280000,-0.210000
06-07 16:57:50.731+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.731+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.731+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:718,0.033323,0.068789,0.021068
06-07 16:57:50.731+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.741+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:740,2.200763,-0.513838,9.542693
06-07 16:57:50.741+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.751+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:745,0.006820,-0.033857,0.025228
06-07 16:57:50.751+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:752,2.200043,-0.515801,9.542753
06-07 16:57:50.751+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.751+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:731,2.153540,-0.552742,9.600004
06-07 16:57:50.751+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.751+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:747,0.140000,0.070000,-0.210000
06-07 16:57:50.761+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.761+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:764,2.191825,-0.524028,9.607183
06-07 16:57:50.761+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.761+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.771+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:762,2.197819,-0.514713,9.543324
06-07 16:57:50.771+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.771+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:776,-0.070000,0.070000,-0.210000
06-07 16:57:50.771+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:779,2.199377,-0.516395,9.542875
06-07 16:57:50.771+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.781+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:766,0.025982,-0.026984,0.073479
06-07 16:57:50.781+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:770,2.230111,-0.559920,9.681360
06-07 16:57:50.781+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.781+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.791+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.791+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:793,0.037729,-0.015496,-0.010115
06-07 16:57:50.791+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:791,2.201397,-0.507278,9.664611
06-07 16:57:50.791+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.801+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:782,2.202472,-0.515616,9.542203
06-07 16:57:50.801+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.801+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.801+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:797,0.350000,-0.070000,0.070000
06-07 16:57:50.811+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:809,2.201409,-0.516102,9.542422
06-07 16:57:50.811+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.811+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:804,2.246860,-0.552742,9.592826
06-07 16:57:50.811+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.811+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.821+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:810,0.021086,-0.031462,0.042545
06-07 16:57:50.821+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.831+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:821,2.201445,-0.515646,9.542439
06-07 16:57:50.831+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.831+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:824,0.770000,-0.280000,0.140000
06-07 16:57:50.831+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:824,2.220540,-0.476172,9.482756
06-07 16:57:50.831+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.831+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.831+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:828,-0.063028,-0.019189,0.013932
06-07 16:57:50.831+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.841+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:837,2.199414,-0.516050,9.542885
06-07 16:57:50.841+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.851+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:849,0.560000,-0.280000,0.350000
06-07 16:57:50.851+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:845,0.017362,-0.034924,0.115391
06-07 16:57:50.851+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.851+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:860,-0.011578,-0.014366,0.064723
06-07 16:57:50.851+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.861+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:839,2.182254,-0.519243,9.578469
06-07 16:57:50.861+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.861+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.861+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:866,2.234896,-0.516850,9.633504
06-07 16:57:50.861+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.861+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:870,0.140000,-0.350000,0.140000
06-07 16:57:50.871+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:850,2.198498,-0.516586,9.543067
06-07 16:57:50.871+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.871+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:877,2.204567,-0.519382,9.541515
06-07 16:57:50.871+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.871+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:881,2.205833,-0.523252,9.541011
06-07 16:57:50.871+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.881+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:870,2.184647,-0.533599,9.576077
06-07 16:57:50.881+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.881+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.881+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:887,2.179861,-0.524028,9.580862
06-07 16:57:50.881+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.891+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:865,-0.039330,0.056149,-0.010839
06-07 16:57:50.891+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.891+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:57:50.901+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:57:50:902,81
06-07 16:57:50.901+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:893,-0.210000,-0.420000,0.140000
06-07 16:57:50.901+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:884,2.199005,-0.523529,9.542572
06-07 16:57:50.901+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.901+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:891,2.258825,-0.528814,9.573684
06-07 16:57:50.901+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.901+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.911+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:57:50.921+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:57:50:922,854.000000
06-07 16:57:50.921+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:899,0.049537,-0.016065,0.045941
06-07 16:57:50.921+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:916,0.910000,-0.280000,-0.140000
06-07 16:57:50.921+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.931+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:911,2.196809,-0.521647,9.543180
06-07 16:57:50.931+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.931+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.931+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:915,2.194218,-0.579063,9.540184
06-07 16:57:50.931+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.931+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:936,2.197755,-0.521064,9.542994
06-07 16:57:50.941+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:930,0.048798,-0.053546,-0.004228
06-07 16:57:50.951+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:941,1.190000,-0.140000,-0.070000
06-07 16:57:50.951+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.951+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:50:962,-0.004490,-0.001903,0.063542
06-07 16:57:50.961+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.961+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:939,2.170290,-0.562313,9.678967
06-07 16:57:50.961+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.961+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:966,2.198041,-0.520716,9.542948
06-07 16:57:50.961+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:50.971+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:50.971+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:969,2.213361,-0.495314,9.621540
06-07 16:57:50.981+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:50.991+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:50:981,0.210000,-0.490000,-0.070000
06-07 16:57:50.991+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:50.991+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:51:0,0.030777,-0.070812,0.057216
06-07 16:57:51.001+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:51.001+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:50:983,2.192835,-0.520081,9.544180
06-07 16:57:51.001+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:51:6,0.024781,0.019638,-0.014867
06-07 16:57:51.001+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:51.001+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:51.001+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:50:993,2.199004,-0.492921,9.609575
06-07 16:57:51.011+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:51:11,0.028239,0.019733,0.001780
06-07 16:57:51.011+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:57:51.011+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:51.011+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:51.011+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:51:20,0.017437,-0.037619,0.074398
06-07 16:57:51.021+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:51.031+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11134186c6f63152838347
