S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 12790
Date: 2018-06-07 16:55:41+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6fd852d, r5   = 0xf7344f98
r6   = 0xffba2880, r7   = 0xffba2730
r8   = 0xf7341c18, r9   = 0x00000000
r10  = 0xffba280c, fp   = 0xffba2880
ip   = 0x00000001, sp   = 0xffba2708
lr   = 0xf6fd8539, pc   = 0xf7041228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    316420 KB
Buffers:      1932 KB
Cached:      66544 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       10752 KB
VmRSS:        9760 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:         16 KB

Threads Information
Threads: 2
PID = 12790 TID = 12790
12790 12796 

Maps Information
f3ea3000 f46a2000 rw-p [stack:12796]
f46a9000 f46ab000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f46b3000 f46b7000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f46c0000 f46c2000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f46ca000 f46cd000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f46dc000 f46e1000 r-xp /usr/lib/libsystem.so.0.0.0
f46ec000 f46ef000 r-xp /lib/libattr.so.1.1.0
f46f7000 f4707000 r-xp /usr/lib/libmdm-common.so.1.1.24
f470f000 f4718000 r-xp /usr/lib/libedbus.so.1.7.99
f4720000 f4721000 r-xp /usr/lib/libresponse.so.0.2.96
f472a000 f472f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5fd1000 f60d7000 r-xp /usr/lib/libicuuc.so.57.1
f60ed000 f6275000 r-xp /usr/lib/libicui18n.so.57.1
f6285000 f6292000 r-xp /usr/lib/libail.so.0.1.0
f629b000 f62a2000 r-xp /usr/lib/libminizip.so.1.0.0
f62ab000 f6454000 r-xp /usr/lib/libcrypto.so.1.0.0
f6474000 f64bb000 r-xp /usr/lib/libssl.so.1.0.0
f64c7000 f64c9000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f64d1000 f64d8000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f64e1000 f64e8000 r-xp /lib/libcrypt-2.13.so
f6519000 f651c000 r-xp /lib/libcap.so.2.21
f6524000 f6526000 r-xp /usr/lib/libiri.so
f652e000 f6577000 r-xp /usr/lib/libmdm.so.1.2.69
f657f000 f6585000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f658d000 f65b0000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f65ba000 f65bc000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f65c4000 f65e1000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f65ea000 f65ee000 r-xp /usr/lib/libsmack.so.1.0.0
f65f7000 f6610000 r-xp /usr/lib/libnetwork.so.0.0.0
f6619000 f6621000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6629000 f662f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6638000 f663a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6643000 f6653000 r-xp /lib/libresolv-2.13.so
f6657000 f666f000 r-xp /usr/lib/liblzma.so.5.0.3
f6678000 f667a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6682000 f669c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f66a4000 f66d3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f66dc000 f66eb000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f66f5000 f66ff000 r-xp /usr/lib/libsensord-shared.so
f6708000 f67db000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f67e6000 f67fc000 r-xp /lib/libz.so.1.2.5
f6804000 f6809000 r-xp /usr/lib/libffi.so.5.0.10
f6811000 f6812000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f681a000 f682a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6832000 f684b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6853000 f6855000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f685d000 f68d2000 r-xp /usr/lib/libsqlite3.so.0.8.6
f68dc000 f68e2000 r-xp /lib/librt-2.13.so
f68eb000 f6909000 r-xp /usr/lib/libsystemd.so.0.4.0
f6913000 f6914000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f691c000 f693f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6947000 f694c000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6954000 f697e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6987000 f699e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f69a6000 f6a0f000 r-xp /lib/libm-2.13.so
f6a18000 f6aac000 r-xp /usr/lib/libstdc++.so.6.0.16
f6abf000 f6ac4000 r-xp /usr/lib/libctx-client.so.0.8.3
f6acc000 f6ad3000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6adb000 f6b05000 r-xp /usr/lib/libsensor.so.1.9.6
f6b0e000 f6bda000 r-xp /usr/lib/libxml2.so.2.7.8
f6be7000 f6be9000 r-xp /usr/lib/libiniparser.so.0
f6bf2000 f6bf8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c01000 f6cd1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6cd2000 f6d06000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d0f000 f6d4b000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6d53000 f6d56000 r-xp /usr/lib/libbundle.so.0.1.22
f6d5e000 f6d64000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d6c000 f6dad000 r-xp /usr/lib/libeina.so.1.7.99
f6db6000 f6dcd000 r-xp /usr/lib/libecore.so.1.7.99
f6de4000 f6ded000 r-xp /usr/lib/libvconf.so.0.2.45
f6df5000 f6e09000 r-xp /lib/libpthread-2.13.so
f6e14000 f6e21000 r-xp /usr/lib/libaul.so.0.1.0
f6e2b000 f6e2d000 r-xp /lib/libdl-2.13.so
f6e36000 f6e41000 r-xp /lib/libunwind.so.8.0.1
f6e6e000 f6e76000 r-xp /lib/libgcc_s-4.6.so.1
f6e77000 f6f9b000 r-xp /lib/libc-2.13.so
f6fa9000 f6fab000 r-xp /usr/lib/libdlog.so.0.0.0
f6fb3000 f6fbf000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6fc8000 f6fcd000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6fd5000 f6fe4000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f6fec000 f6ff0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6ff9000 f6ffc000 r-xp /usr/lib/libappcore-agent.so.1.1
f7004000 f7006000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f700e000 f7012000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f701a000 f7037000 r-xp /lib/ld-2.13.so
f7040000 f7043000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7043000 f7047000 r-xp /usr/lib/libsys-assert.so
f7311000 f739f000 rw-p [heap]
ffb83000 ffba4000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12790)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7041228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf6fd8539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6cdf3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6cddc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6ce9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6cefbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6cefdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6d2475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6d1f1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6cddc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6ce9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6cefbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6cefdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6d21e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6d22017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6d29f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf46c11fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf46b4171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6787663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6c34fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6c367a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6dc6ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6dc1b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6dc25a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6dc2879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf6ffa183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf6ffa7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70415c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6e8e85c) [/lib/libc.so.6] + 0x1785c
29: (0xf7040f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
7 16:55:40.901+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:40.901+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:40.911+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:40:912,-2.320819,-0.218028,0.809301
06-07 16:55:40.911+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:40:913,5.105846,0.071360,8.372313
06-07 16:55:40.921+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:40.921+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:40.931+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:40:933,-3.710000,-3.570000,4.410000
06-07 16:55:40.931+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:40.931+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:40:933,2.481357,-0.342174,9.458827
06-07 16:55:40.931+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:40.941+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:40.941+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:40.941+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:40:947,1.120000,-1.330000,3.640000
06-07 16:55:40.941+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:40:940,5.912344,0.045909,7.823840
06-07 16:55:40.951+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:40.951+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:40:942,-2.624489,-0.413533,1.086514
06-07 16:55:40.951+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:40:948,2.557927,-0.241675,9.552148
06-07 16:55:40.951+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:40.951+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:40:956,6.350367,0.028197,7.472779
06-07 16:55:40.961+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:40.961+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:40.971+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:40.971+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:40:962,-3.354417,-0.287584,1.728308
06-07 16:55:40.971+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:40:968,2.660000,1.260000,3.430000
06-07 16:55:40.971+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:40:968,2.550749,-0.014357,9.470792
06-07 16:55:40.971+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:40:975,6.300925,0.024970,7.514526
06-07 16:55:40.981+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:40.981+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:40.981+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:40.991+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:40:988,-1.190000,0.980000,3.360000
06-07 16:55:40.991+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:40.991+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:40:988,6.327223,0.023337,7.492402
06-07 16:55:40.991+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:40:994,2.493321,0.055035,9.592826
06-07 16:55:41.001+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.001+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.001+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.001+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:7,-7.210000,0.980000,2.730000
06-07 16:55:41.001+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:40:998,-3.799618,-0.042554,1.998013
06-07 16:55:41.001+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:55:41.011+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.011+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:55:41:14,84
06-07 16:55:41.011+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:17,-3.807604,0.030065,2.078300
06-07 16:55:41.021+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:7,6.685144,0.015101,7.174887
06-07 16:55:41.021+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.021+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:9,2.510071,0.019143,9.537791
06-07 16:55:41.021+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.021+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.021+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:55:41.031+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:55:41:34,1015.000000
06-07 16:55:41.031+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:34,-6.720000,-1.330000,1.680000
06-07 16:55:41.031+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:27,-3.817153,-0.004194,2.045390
06-07 16:55:41.031+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.031+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.041+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.041+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:44,2.476572,-0.342174,9.583255
06-07 16:55:41.041+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.041+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:47,-2.100000,-1.190000,1.610000
06-07 16:55:41.051+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:33,6.613494,-0.023899,7.240961
06-07 16:55:41.051+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.051+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:56,5.947549,-0.047124,7.797103
06-07 16:55:41.051+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:50,2.677568,-0.220140,9.509077
06-07 16:55:41.061+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:43,-4.208573,-0.357275,2.408368
06-07 16:55:41.061+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:55:41.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:55:41.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:55:41.061+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.061+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.061+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:71,5.392365,-0.058162,8.190811
06-07 16:55:41.071+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.071+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:68,0.560000,1.680000,0.980000
06-07 16:55:41.071+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:71,2.720639,-0.162712,9.382257
06-07 16:55:41.071+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:76,-3.935925,-0.196240,2.268116
06-07 16:55:41.071+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.081+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.081+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.081+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:87,2.565106,-0.150748,9.497113
06-07 16:55:41.081+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:88,4.980590,-0.069237,8.447444
06-07 16:55:41.081+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.081+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:85,-3.226910,-0.115588,1.585154
06-07 16:55:41.091+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.091+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:93,-1.960000,2.590000,0.210000
06-07 16:55:41.091+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:96,-2.827260,-0.092586,1.306302
06-07 16:55:41.101+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.101+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.101+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:109,2.572284,-0.102891,9.571291
06-07 16:55:41.101+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:109,4.740267,-0.076431,8.584545
06-07 16:55:41.101+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.101+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.111+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:114,-2.408306,-0.033654,1.123847
06-07 16:55:41.111+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:115,-2.100000,1.750000,0.840000
06-07 16:55:41.121+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.121+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.131+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:133,4.415785,-0.089791,8.755751
06-07 16:55:41.131+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.131+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:133,2.675175,-0.222532,9.616754
06-07 16:55:41.131+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.131+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:139,-2.660000,1.330000,-0.350000
06-07 16:55:41.141+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.141+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.141+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:147,4.177463,-0.097235,8.871851
06-07 16:55:41.151+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.151+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:148,2.742175,-0.184247,9.729217
06-07 16:55:41.151+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:142,-2.065091,-0.146102,1.032208
06-07 16:55:41.151+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.161+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.161+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.191+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:165,-1.673610,-0.094456,0.973466
06-07 16:55:41.191+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.191+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:169,2.658426,-0.275175,9.623933
06-07 16:55:41.191+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.211+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:55:41.211+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:55:41:216,84
06-07 16:55:41.221+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:199,-1.519037,-0.177940,0.752082
06-07 16:55:41.221+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:55:41.231+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:55:41:236,1013.000000
06-07 16:55:41.231+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:205,2.581856,-0.196211,9.492328
06-07 16:55:41.241+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.241+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.251+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:247,-1.337591,-0.087132,0.503645
06-07 16:55:41.251+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:252,2.754139,-0.279960,9.470792
06-07 16:55:41.251+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.261+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.271+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:266,-1.056901,-0.162833,0.435714
06-07 16:55:41.271+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.281+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:282,-0.854503,-0.647345,0.280725
06-07 16:55:41.281+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.291+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:263,2.900101,-0.780060,9.339187
06-07 16:55:41.291+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:173,3.919446,-0.109080,8.988683
06-07 16:55:41.291+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.291+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:159,-0.980000,1.400000,0.140000
06-07 16:55:41.311+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:288,-0.830473,-0.787582,-0.021884
06-07 16:55:41.311+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.321+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.321+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:321,-0.806797,-0.410542,0.336195
06-07 16:55:41.321+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.321+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.321+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:328,-0.309355,0.383890,0.303848
06-07 16:55:41.321+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.331+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:303,2.679961,-0.954736,9.133404
06-07 16:55:41.331+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:334,0.040812,0.688342,0.349456
06-07 16:55:41.331+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.331+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:330,-1.400000,3.500000,-0.700000
06-07 16:55:41.331+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:339,-3.268480,0.834913,1.742538
06-07 16:55:41.331+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.341+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.341+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:329,3.811040,-0.117127,9.035078
06-07 16:55:41.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:55:41.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:55:41.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:55:41.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:55:41.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390541349,000000, pattern:[H:mm][0;m
06-07 16:55:41.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:55:41.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:55:41.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:55:41.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:55:41.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:55:41.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:55][0;m
06-07 16:55:41.341+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.341+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.351+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:355,-2.100000,5.600000,-1.050000
06-07 16:55:41.351+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.351+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:356,3.754604,-0.132716,9.058461
06-07 16:55:41.351+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.351+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:359,-4.480000,1.960000,-1.050000
06-07 16:55:41.351+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.361+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:347,-4.692985,0.160549,2.838007
06-07 16:55:41.361+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.361+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:365,-2.590000,2.100000,-2.170000
06-07 16:55:41.361+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.361+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:349,2.404787,-0.605384,9.600004
06-07 16:55:41.361+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.371+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:373,4.480000,7.280000,-4.830000
06-07 16:55:41.371+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.371+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:379,21.770000,8.260000,-3.850000
06-07 16:55:41.371+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:374,2.426322,0.212961,9.719646
06-07 16:55:41.371+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.381+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:370,-4.053013,-0.630889,2.127229
06-07 16:55:41.381+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.381+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:360,3.510435,-0.167155,9.155288
06-07 16:55:41.381+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.381+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:390,-0.597419,-0.122362,-0.072820
06-07 16:55:41.391+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.391+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:395,31.010000,9.870000,-4.900000
06-07 16:55:41.391+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.391+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:396,3.211584,-0.194842,9.263809
06-07 16:55:41.391+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.391+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:400,20.160000,9.170000,-8.190000
06-07 16:55:41.401+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.401+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:385,2.175076,0.600598,9.920642
06-07 16:55:41.401+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.401+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.401+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:408,4.410000,5.390000,-5.110000
06-07 16:55:41.401+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.401+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:55:41.411+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:55:41:415,84
06-07 16:55:41.411+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:409,1.694118,0.770489,10.200603
06-07 16:55:41.421+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:411,0.554518,0.624262,-0.327086
06-07 16:55:41.421+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:405,2.735677,-0.170929,9.415797
06-07 16:55:41.421+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.421+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.421+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.421+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:55:41.431+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:55:41:434,1032.000000
06-07 16:55:41.431+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:432,2.134263,-0.087744,9.571186
06-07 16:55:41.431+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:414,-17.920000,-8.610000,-6.580000
06-07 16:55:41.431+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:433,-3.703904,0.992185,1.672586
06-07 16:55:41.431+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.441+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.441+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:442,-10.850000,-16.799999,-6.090000
06-07 16:55:41.441+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:433,2.069792,0.162712,9.939785
06-07 16:55:41.441+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.441+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.441+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:449,2.438286,-0.626920,9.477970
06-07 16:55:41.441+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.451+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:451,16.660000,-9.520000,-2.520000
06-07 16:55:41.451+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.451+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:448,-1.352161,0.483803,0.360302
06-07 16:55:41.451+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.451+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:456,21.139999,-1.960000,0.140000
06-07 16:55:41.451+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.451+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:461,2.730000,-1.750000,-0.560000
06-07 16:55:41.461+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.461+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:459,4.962599,-0.064424,8.458064
06-07 16:55:41.461+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.461+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.471+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:466,-13.790000,-4.200000,-0.770000
06-07 16:55:41.471+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:453,2.471786,-0.162712,9.241080
06-07 16:55:41.471+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.471+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.471+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:468,6.762776,0.002163,7.101778
06-07 16:55:41.471+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.481+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:470,-0.506607,0.068297,-0.049809
06-07 16:55:41.481+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:481,-15.960000,-3.850000,0.350000
06-07 16:55:41.481+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.481+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:489,-14.070000,-1.680000,1.330000
06-07 16:55:41.481+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.491+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:494,-0.013229,-0.082513,-0.267792
06-07 16:55:41.491+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:480,2.249253,0.612563,9.332008
06-07 16:55:41.501+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.501+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.501+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.511+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:511,-13.860000,-0.980000,1.470000
06-07 16:55:41.511+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:483,6.491299,0.003969,7.350741
06-07 16:55:41.511+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:507,0.407650,-0.290507,-0.315722
06-07 16:55:41.521+0200 W/LOCATION(12790): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 16:55:41.521+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:506,2.108077,1.033699,9.571291
06-07 16:55:41.521+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.521+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.521+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.531+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:532,-2.971515,-0.500598,1.362453
06-07 16:55:41.531+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:527,2.177469,0.593420,9.509077
06-07 16:55:41.531+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.531+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:532,-8.120000,-1.330000,2.100000
06-07 16:55:41.531+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.531+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:537,2.282753,0.177069,9.351151
06-07 16:55:41.531+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.531+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:542,2.316252,-0.002393,9.257831
06-07 16:55:41.541+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.541+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.541+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:541,3.069204,-0.040350,9.313900
06-07 16:55:41.541+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:547,-4.144317,-0.327066,2.342851
06-07 16:55:41.541+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.541+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:546,2.316252,-0.244068,9.303294
06-07 16:55:41.541+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.551+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:555,2.330609,-0.442672,9.611969
06-07 16:55:41.551+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.551+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:554,-0.910000,0.280000,2.800000
06-07 16:55:41.551+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:559,2.414358,-0.303888,9.633504
06-07 16:55:41.551+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.561+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.561+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.561+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:567,-4.562882,-0.193888,2.425047
06-07 16:55:41.561+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.561+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:564,1.694735,-0.011699,9.659095
06-07 16:55:41.561+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.571+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:568,2.277967,-0.198604,9.451650
06-07 16:55:41.571+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:574,5.811981,0.041514,7.898705
06-07 16:55:41.571+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.571+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:572,2.310000,1.050000,2.100000
06-07 16:55:41.571+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:578,3.529630,0.109618,9.148775
06-07 16:55:41.571+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.581+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:582,2.789360,0.108772,9.400959
06-07 16:55:41.581+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.581+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.581+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.581+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:588,-4.147525,-0.203501,2.229098
06-07 16:55:41.581+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.581+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:586,2.329481,0.080120,9.525622
06-07 16:55:41.581+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.591+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:589,2.342573,-0.227318,9.580862
06-07 16:55:41.591+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:595,1.908602,0.046439,9.619016
06-07 16:55:41.591+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.591+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:592,1.050000,-0.070000,2.100000
06-07 16:55:41.591+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:599,5.302124,0.057926,8.249516
06-07 16:55:41.591+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.601+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:603,6.558675,0.023177,7.290653
06-07 16:55:41.601+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.601+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.601+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:607,-2.918267,-0.203605,1.373216
06-07 16:55:41.601+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.601+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.601+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:55:41.611+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:611,6.840849,-0.004717,7.026602
06-07 16:55:41.611+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.611+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:55:41:615,84
06-07 16:55:41.611+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:616,6.490098,-0.023817,7.351764
06-07 16:55:41.611+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:608,2.481357,-0.248854,9.559326
06-07 16:55:41.611+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.611+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:611,-4.550000,-0.210000,1.190000
06-07 16:55:41.611+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:620,5.399624,-0.045249,8.186110
06-07 16:55:41.611+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.621+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:623,4.623199,-0.068014,8.648225
06-07 16:55:41.621+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.621+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.621+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.621+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:55:41.631+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:55:41:634,1015.000000
06-07 16:55:41.631+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:635,2.371287,-0.272782,9.722038
06-07 16:55:41.641+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:633,-2.251912,-0.204767,1.073813
06-07 16:55:41.641+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:635,-4.760000,-2.940000,1.190000
06-07 16:55:41.641+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.641+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.641+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.651+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.651+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:649,2.543570,-0.222532,9.791430
06-07 16:55:41.651+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:659,4.147495,-0.089465,8.885982
06-07 16:55:41.651+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.651+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:652,1.330000,-4.340000,1.260000
06-07 16:55:41.661+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:652,-1.603925,-0.133068,0.905449
06-07 16:55:41.661+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.661+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.661+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.661+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:667,-1.079840,0.133793,0.513311
06-07 16:55:41.661+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:668,2.694318,0.038285,9.564112
06-07 16:55:41.671+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:663,3.774158,-0.095508,9.050800
06-07 16:55:41.671+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.671+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:668,4.830000,-4.270000,2.030000
06-07 16:55:41.671+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:679,3.582356,-0.081710,9.128551
06-07 16:55:41.681+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.681+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.681+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:688,-0.897609,0.711022,-0.729743
06-07 16:55:41.681+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.681+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:688,2.684747,0.629312,8.398808
06-07 16:55:41.681+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:691,0.070000,-3.570000,3.360000
06-07 16:55:41.691+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.691+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:696,4.460464,-0.045042,8.733419
06-07 16:55:41.701+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.701+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.701+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:707,2.565106,-0.016750,9.772287
06-07 16:55:41.701+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.701+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.711+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:707,4.491600,-0.062384,8.717340
06-07 16:55:41.711+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:712,-1.895358,0.028292,1.038868
06-07 16:55:41.711+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:712,-9.520000,-3.290000,6.160000
06-07 16:55:41.721+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.721+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.721+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:731,2.610569,-0.588634,9.975677
06-07 16:55:41.731+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.731+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.731+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:732,3.901710,-0.112770,8.996351
06-07 16:55:41.731+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:736,-1.881031,-0.526250,1.258337
06-07 16:55:41.741+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.741+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.741+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.741+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:736,-12.250000,-4.620000,4.200000
06-07 16:55:41.741+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.741+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:747,2.560320,-0.433101,9.588040
06-07 16:55:41.741+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:747,3.418889,-0.124681,9.190540
06-07 16:55:41.751+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:750,3.500000,-1.190000,3.570000
06-07 16:55:41.751+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:750,-1.341389,-0.320331,0.591689
06-07 16:55:41.761+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.761+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.761+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:768,3.122188,-0.105950,9.295757
06-07 16:55:41.761+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.771+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.771+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:775,-0.892068,0.122288,0.170182
06-07 16:55:41.781+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.781+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:788,2.992991,-0.102034,9.338200
06-07 16:55:41.781+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.791+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:793,-0.643224,0.048522,0.112822
06-07 16:55:41.791+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:769,2.526821,-0.002393,9.360723
06-07 16:55:41.791+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.791+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:774,7.840000,0.210000,4.340000
06-07 16:55:41.791+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.801+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.801+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.801+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:807,2.947154,-0.105672,9.352727
06-07 16:55:41.801+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:801,1.610000,0.210000,4.130000
06-07 16:55:41.801+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:55:41.801+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:808,-0.590597,0.015892,0.228306
06-07 16:55:41.811+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:55:41:816,84
06-07 16:55:41.811+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:798,2.478964,-0.057428,9.408579
06-07 16:55:41.811+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.821+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.821+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.821+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:55:41.831+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.831+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:55:41:834,1001.000000
06-07 16:55:41.831+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:825,-1.470000,0.070000,4.550000
06-07 16:55:41.831+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:834,2.893935,-0.115471,9.369215
06-07 16:55:41.831+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.831+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:835,-0.506475,-0.100111,0.338204
06-07 16:55:41.841+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.841+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.841+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:841,-1.890000,0.490000,4.200000
06-07 16:55:41.841+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.841+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:849,-4.200000,0.700000,3.430000
06-07 16:55:41.841+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:847,-0.417363,-0.221917,0.010650
06-07 16:55:41.841+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:827,2.402394,-0.086142,9.566505
06-07 16:55:41.851+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:848,2.896248,-0.135571,9.368231
06-07 16:55:41.851+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.851+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:857,2.440679,-0.205783,9.690931
06-07 16:55:41.851+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.851+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:861,2.476572,-0.337388,9.379865
06-07 16:55:41.861+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.861+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.861+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.861+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:867,-0.453176,-0.275995,0.164775
06-07 16:55:41.861+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:41:868,-2.100000,0.280000,3.990000
06-07 16:55:41.871+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.881+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:870,2.837750,-0.154215,9.385828
06-07 16:55:41.891+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.891+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:898,-0.370750,0.005860,0.185463
06-07 16:55:41.891+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.901+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:41.901+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:41:908,-0.226697,0.029014,0.247372
06-07 16:55:41.911+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:41.911+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:41:903,2.772660,-0.153441,9.405275
06-07 16:55:41.911+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:41.911+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:41:879,2.443072,-0.411566,9.533006
06-07 16:55:41.911+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:41.921+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11127906c6f63152838334
