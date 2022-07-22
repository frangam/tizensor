S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 5753
Date: 2018-04-23 20:05:17+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70b252d, r5   = 0xf72b1f98
r6   = 0xffbb7ec0, r7   = 0xffbb7d70
r8   = 0xf72aec18, r9   = 0x00000000
r10  = 0xffbb7e4c, fp   = 0xffbb7ec0
ip   = 0x00000001, sp   = 0xffbb7d48
lr   = 0xf70b2539, pc   = 0xf711b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     39976 KB
Buffers:     36892 KB
Cached:     224080 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11784 KB
VmRSS:       11780 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 5753 TID = 5753
5753 5756 

Maps Information
f3f7d000 f477c000 rw-p [stack:5756]
f4783000 f4785000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f478d000 f4791000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f479a000 f479c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f47a4000 f47a7000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47b6000 f47bb000 r-xp /usr/lib/libsystem.so.0.0.0
f47c6000 f47c9000 r-xp /lib/libattr.so.1.1.0
f47d1000 f47e1000 r-xp /usr/lib/libmdm-common.so.1.1.24
f47e9000 f47f2000 r-xp /usr/lib/libedbus.so.1.7.99
f47fa000 f47fb000 r-xp /usr/lib/libresponse.so.0.2.96
f4804000 f4809000 r-xp /usr/lib/libproc-stat.so.0.2.96
f60ab000 f61b1000 r-xp /usr/lib/libicuuc.so.57.1
f61c7000 f634f000 r-xp /usr/lib/libicui18n.so.57.1
f635f000 f636c000 r-xp /usr/lib/libail.so.0.1.0
f6375000 f637c000 r-xp /usr/lib/libminizip.so.1.0.0
f6385000 f652e000 r-xp /usr/lib/libcrypto.so.1.0.0
f654e000 f6595000 r-xp /usr/lib/libssl.so.1.0.0
f65a1000 f65a3000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f65ab000 f65b2000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65bb000 f65c2000 r-xp /lib/libcrypt-2.13.so
f65f3000 f65f6000 r-xp /lib/libcap.so.2.21
f65fe000 f6600000 r-xp /usr/lib/libiri.so
f6608000 f6651000 r-xp /usr/lib/libmdm.so.1.2.69
f6659000 f665f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6667000 f668a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6694000 f6696000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f669e000 f66bb000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66c4000 f66c8000 r-xp /usr/lib/libsmack.so.1.0.0
f66d1000 f66ea000 r-xp /usr/lib/libnetwork.so.0.0.0
f66f3000 f66fb000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6703000 f6709000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6712000 f6714000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f671d000 f672d000 r-xp /lib/libresolv-2.13.so
f6731000 f6749000 r-xp /usr/lib/liblzma.so.5.0.3
f6752000 f6754000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f675c000 f6776000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f677e000 f67ad000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67b6000 f67c5000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67cf000 f67d9000 r-xp /usr/lib/libsensord-shared.so
f67e2000 f68b5000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68c0000 f68d6000 r-xp /lib/libz.so.1.2.5
f68de000 f68e3000 r-xp /usr/lib/libffi.so.5.0.10
f68eb000 f68ec000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f68f4000 f6904000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f690c000 f6925000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f692d000 f692f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6937000 f69ac000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69b6000 f69bc000 r-xp /lib/librt-2.13.so
f69c5000 f69e3000 r-xp /usr/lib/libsystemd.so.0.4.0
f69ed000 f69ee000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f69f6000 f6a19000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a21000 f6a26000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a2e000 f6a58000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a61000 f6a78000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a80000 f6ae9000 r-xp /lib/libm-2.13.so
f6af2000 f6b86000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b99000 f6b9e000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ba6000 f6bad000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6bb5000 f6bdf000 r-xp /usr/lib/libsensor.so.1.9.6
f6be8000 f6cb4000 r-xp /usr/lib/libxml2.so.2.7.8
f6cc1000 f6cc3000 r-xp /usr/lib/libiniparser.so.0
f6ccc000 f6cd2000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6cdb000 f6dab000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6dac000 f6de0000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6de9000 f6e25000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e2d000 f6e30000 r-xp /usr/lib/libbundle.so.0.1.22
f6e38000 f6e3e000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e46000 f6e87000 r-xp /usr/lib/libeina.so.1.7.99
f6e90000 f6ea7000 r-xp /usr/lib/libecore.so.1.7.99
f6ebe000 f6ec7000 r-xp /usr/lib/libvconf.so.0.2.45
f6ecf000 f6ee3000 r-xp /lib/libpthread-2.13.so
f6eee000 f6efb000 r-xp /usr/lib/libaul.so.0.1.0
f6f05000 f6f07000 r-xp /lib/libdl-2.13.so
f6f10000 f6f1b000 r-xp /lib/libunwind.so.8.0.1
f6f48000 f6f50000 r-xp /lib/libgcc_s-4.6.so.1
f6f51000 f7075000 r-xp /lib/libc-2.13.so
f7083000 f7085000 r-xp /usr/lib/libdlog.so.0.0.0
f708d000 f7099000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f70a2000 f70a7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70af000 f70be000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70c6000 f70ca000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70d3000 f70d6000 r-xp /usr/lib/libappcore-agent.so.1.1
f70de000 f70e0000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f70e8000 f70ec000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f70f4000 f7111000 r-xp /lib/ld-2.13.so
f711a000 f711d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f711d000 f7121000 r-xp /usr/lib/libsys-assert.so
f727e000 f72ef000 rw-p [heap]
ffb99000 ffbba000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5753)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf711b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf70b2539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6db93f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6db7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6dc3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6dc9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6dc9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6dfe75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6df91f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6db7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6dc3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6dc9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6dc9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6dfbe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6dfc017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e03f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf479b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf478e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6861663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d0efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d107a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6ea0ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e9bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e9c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e9c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70d4183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70d47fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf711b4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6f6885c) [/lib/libc.so.6] + 0x1785c
29: (0xf711af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
-23 20:05:16.769+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:16.779+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:16:781,0.015889,0.018534,0.009721
04-23 20:05:16.779+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:16.779+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:16.779+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:16.779+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:16:786,0.010513,0.025666,-0.018401
04-23 20:05:16.779+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:16.789+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:16:741,-0.070000,-0.210000,0.070000
04-23 20:05:16.789+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:16.789+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:16:740,0.023928,9.808180,0.808774
04-23 20:05:16.789+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:16.799+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:16:734,0.058474,9.772934,0.810388
04-23 20:05:16.799+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:16.799+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:16:790,-0.016162,0.037452,-0.040142
04-23 20:05:16.799+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:16.809+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:16:805,0.056995,9.772830,0.811748
04-23 20:05:16.809+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:16.809+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:16:810,-0.012833,0.042013,-0.035112
04-23 20:05:16.809+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:16:795,-0.070000,-0.070000,0.070000
04-23 20:05:16.819+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:16:800,0.057428,9.810574,0.796810
04-23 20:05:16.819+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:16.819+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:16:824,0.026321,9.822537,0.801596
04-23 20:05:16.819+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:16.829+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:16.829+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:16.829+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:16:837,0.019050,-0.003661,-0.006285
04-23 20:05:16.839+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:16:816,0.057168,9.772808,0.812002
04-23 20:05:16.839+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:16.839+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:16:845,0.055857,9.772737,0.812954
04-23 20:05:16.839+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:16:833,-0.070000,-0.070000,0.070000
04-23 20:05:16.839+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:16.849+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:16.849+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:16:850,-0.070000,-0.070000,0.070000
04-23 20:05:16.849+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:16.849+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:16:859,-0.070000,-0.140000,0.070000
04-23 20:05:16.859+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:16.859+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:16:853,-0.048703,0.005811,-0.067216
04-23 20:05:16.859+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:16.859+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:16:828,0.023928,9.791430,0.811167
04-23 20:05:16.859+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:16.869+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:16:864,0.054511,9.772632,0.814304
04-23 20:05:16.869+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:16:871,0.045464,9.789038,0.772882
04-23 20:05:16.869+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:16.869+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:16.879+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:16.879+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:16:883,0.054224,9.772673,0.813823
04-23 20:05:16.879+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:16.879+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:16:887,0.056357,9.772789,0.812282
04-23 20:05:16.889+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:16:867,-0.005499,0.036665,-0.033205
04-23 20:05:16.889+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:16.889+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:16:880,0.095713,9.810574,0.780060
04-23 20:05:16.889+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:16.899+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:16:882,-0.070000,0.070000,0.070000
04-23 20:05:16.899+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:16.899+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:16:895,-0.050539,-0.004225,0.012425
04-23 20:05:16.899+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:16.909+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:16:905,-0.070000,-0.070000,0.070000
04-23 20:05:16.909+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:16.919+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:16.919+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:16:901,0.045464,9.779467,0.777667
04-23 20:05:16.919+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:16.919+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:16:912,-0.017191,0.022258,-0.051908
04-23 20:05:16.929+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:16.929+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:16:923,0.055985,9.772802,0.812147
04-23 20:05:16.929+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:16.929+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:16:919,-0.070000,0.070000,0.070000
04-23 20:05:16.929+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:16.939+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:16:926,0.057428,9.789038,0.808774
04-23 20:05:16.939+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:16.939+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:16:947,0.071785,9.791430,0.820738
04-23 20:05:16.939+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:16.949+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:16:933,-0.038042,0.060477,0.008669
04-23 20:05:16.949+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:16.959+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:16:938,0.055896,9.772897,0.811017
04-23 20:05:16.959+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:16.959+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:16:940,-0.070000,0.070000,-0.070000
04-23 20:05:16.959+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:16.969+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:16:964,0.056486,9.772943,0.810425
04-23 20:05:16.969+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:16.969+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:16.969+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:16:957,0.018647,0.000815,0.001832
04-23 20:05:16.969+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:16:967,-0.070000,0.070000,-0.070000
04-23 20:05:16.969+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:16.969+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:16.979+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:16:951,0.066999,9.798609,0.792024
04-23 20:05:16.979+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:16.979+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:16.989+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:16:980,-0.003922,0.000941,-0.013996
04-23 20:05:16.989+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.059+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:16:979,-0.070000,-0.070000,-0.070000
04-23 20:05:17.059+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.059+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:16:989,0.056840,9.773122,0.808238
04-23 20:05:17.059+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.059+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:16:985,0.040678,9.810574,0.768096
04-23 20:05:17.069+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.069+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:67,-0.070000,0.070000,-0.070000
04-23 20:05:17.069+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:0,-0.018246,0.053666,-0.024581
04-23 20:05:17.069+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.079+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:68,0.055904,9.773345,0.805601
04-23 20:05:17.079+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.079+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:75,0.043071,9.815358,0.770489
04-23 20:05:17.079+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.079+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:89,0.074178,9.769895,0.796810
04-23 20:05:17.089+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.089+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:95,-0.070000,0.070000,-0.070000
04-23 20:05:17.089+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.099+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:82,-0.065369,0.029771,-0.027411
04-23 20:05:17.099+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.099+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:105,-0.007349,0.027484,-0.036051
04-23 20:05:17.099+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.109+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:85,0.055127,9.773556,0.803095
04-23 20:05:17.109+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.109+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.109+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:117,0.007178,9.779467,0.734596
04-23 20:05:17.109+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.119+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:101,-0.070000,0.070000,-0.070000
04-23 20:05:17.119+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.119+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:126,-0.070000,0.070000,-0.070000
04-23 20:05:17.119+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.129+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:115,0.055881,9.773656,0.801813
04-23 20:05:17.129+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.129+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:135,0.053355,9.773909,0.798909
04-23 20:05:17.129+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.139+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:109,-0.007142,0.046620,-0.021622
04-23 20:05:17.139+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.139+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:147,0.002630,0.017949,-0.031732
04-23 20:05:17.139+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.149+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:121,0.047856,9.810574,0.765703
04-23 20:05:17.149+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.149+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:17.149+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:17.149+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:130,-0.070000,0.070000,-0.070000
04-23 20:05:17.159+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:140,0.052932,9.774119,0.796349
04-23 20:05:17.159+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.159+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.159+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:164,0.050691,9.773958,0.798469
04-23 20:05:17.159+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.169+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:156,0.002393,9.769895,0.808774
04-23 20:05:17.169+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.169+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:151,0.031071,0.029909,-0.014919
04-23 20:05:17.169+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.179+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:165,-0.070000,0.070000,0.070000
04-23 20:05:17.179+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.179+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:174,0.033500,9.796216,0.746561
04-23 20:05:17.179+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.179+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:188,0.011964,9.834501,0.806381
04-23 20:05:17.179+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.189+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:181,-0.006457,0.022729,-0.021982
04-23 20:05:17.189+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.199+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:172,0.050006,9.774024,0.797712
04-23 20:05:17.199+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.199+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:185,-0.070000,0.070000,0.070000
04-23 20:05:17.199+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.209+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:207,-0.140000,0.070000,0.070000
04-23 20:05:17.209+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.209+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:199,0.010443,0.029932,-0.024687
04-23 20:05:17.209+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.219+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:205,0.048353,9.773865,0.799764
04-23 20:05:17.219+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.219+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:192,0.066999,9.774680,0.801596
04-23 20:05:17.219+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.229+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:224,0.049385,9.773739,0.801235
04-23 20:05:17.229+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.229+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:222,-0.002175,0.044275,0.009013
04-23 20:05:17.239+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:221,-0.070000,0.070000,0.070000
04-23 20:05:17.239+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.239+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.249+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:229,0.045464,9.774680,0.787239
04-23 20:05:17.249+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.249+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:245,-0.140000,0.070000,0.070000
04-23 20:05:17.249+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.259+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:254,0.031107,9.827322,0.777667
04-23 20:05:17.259+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:247,0.009740,0.025267,-0.006953
04-23 20:05:17.259+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:241,0.049353,9.773656,0.802248
04-23 20:05:17.259+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.259+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.269+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.269+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:268,0.048620,9.773623,0.802685
04-23 20:05:17.279+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:270,-0.045915,0.044430,-0.007172
04-23 20:05:17.279+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.279+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:262,-0.070000,0.070000,0.070000
04-23 20:05:17.279+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.279+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:276,-0.016750,9.803394,0.775275
04-23 20:05:17.289+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.289+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:293,0.045634,9.773518,0.804147
04-23 20:05:17.289+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.289+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:285,-0.029536,0.025408,-0.015930
04-23 20:05:17.289+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.299+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:289,-0.070000,0.070000,0.070000
04-23 20:05:17.299+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.299+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:309,-0.070000,0.070000,0.070000
04-23 20:05:17.309+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.309+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:298,0.038285,9.801002,0.768096
04-23 20:05:17.309+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.319+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:302,-0.009146,0.047029,-0.029004
04-23 20:05:17.319+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.319+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:313,0.045427,9.773524,0.804075
04-23 20:05:17.319+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.329+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.329+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:316,0.038285,9.820145,0.782453
04-23 20:05:17.329+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:05:17.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:05:17.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:05:17.339+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:328,-0.035171,0.027909,-0.010148
04-23 20:05:17.339+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.339+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:330,0.045226,9.773481,0.804613
04-23 20:05:17.349+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.349+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:334,-0.070000,0.070000,0.070000
04-23 20:05:17.359+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.359+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:336,0.047856,9.791430,0.772882
04-23 20:05:17.359+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.369+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:346,0.028554,0.028030,-0.028440
04-23 20:05:17.369+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.369+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:367,0.076570,9.803394,0.789631
04-23 20:05:17.369+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.369+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:363,0.045499,9.773485,0.804550
04-23 20:05:17.369+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.379+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:364,-0.070000,0.070000,0.070000
04-23 20:05:17.379+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.389+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:386,-0.070000,-0.140000,0.070000
04-23 20:05:17.389+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.389+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:379,0.040678,9.796216,0.782453
04-23 20:05:17.389+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.399+0200 W/LOCATION( 5753): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:05:17.399+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:17.399+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:17.409+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:374,0.003109,0.023185,0.001081
04-23 20:05:17.409+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.409+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:382,0.047135,9.773487,0.804435
04-23 20:05:17.419+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.419+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:423,0.046985,9.773462,0.804747
04-23 20:05:17.419+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.429+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:414,-0.037878,0.032857,-0.009691
04-23 20:05:17.429+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.429+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:400,0.057428,9.803394,0.780060
04-23 20:05:17.429+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.439+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:396,-0.070000,-0.070000,0.070000
04-23 20:05:17.439+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.439+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:446,-0.070000,-0.070000,0.070000
04-23 20:05:17.439+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.449+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:434,-0.014690,0.021040,-0.035476
04-23 20:05:17.449+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.449+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:427,0.047639,9.773476,0.804547
04-23 20:05:17.459+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.459+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:441,0.045464,9.817751,0.813560
04-23 20:05:17.469+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.479+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:450,-0.070000,-0.070000,0.070000
04-23 20:05:17.479+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.479+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:466,0.047687,9.773342,0.806156
04-23 20:05:17.489+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:456,-0.023717,0.052151,-0.023605
04-23 20:05:17.489+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.489+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.489+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:479,0.057428,9.798609,0.799203
04-23 20:05:17.499+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:498,-0.049060,0.052214,0.018657
04-23 20:05:17.499+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.499+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.509+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:488,0.070000,-0.210000,0.070000
04-23 20:05:17.509+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.509+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:496,0.048308,9.773321,0.806375
04-23 20:05:17.509+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.519+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:512,0.002393,9.817751,0.799203
04-23 20:05:17.519+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:521,0.046286,9.773201,0.807954
04-23 20:05:17.529+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:516,-0.070000,-0.070000,0.070000
04-23 20:05:17.539+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.539+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:508,-0.011032,0.030911,-0.024912
04-23 20:05:17.539+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.549+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.549+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:554,-0.005876,0.064458,-0.020719
04-23 20:05:17.549+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.549+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:17.549+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:17.549+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:543,0.016750,9.798609,0.792024
04-23 20:05:17.549+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.559+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:558,0.045038,9.773115,0.809064
04-23 20:05:17.559+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.559+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:551,-0.070000,-0.070000,0.070000
04-23 20:05:17.559+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.569+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:562,0.035892,9.820145,0.780060
04-23 20:05:17.579+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.579+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:585,-0.070000,0.070000,0.070000
04-23 20:05:17.579+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.589+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.589+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:568,0.044742,9.773092,0.809351
04-23 20:05:17.599+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:584,0.027753,0.040573,-0.002089
04-23 20:05:17.599+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.599+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:604,0.011937,0.038248,0.004368
04-23 20:05:17.599+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.599+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:608,-0.003134,0.026402,0.017347
04-23 20:05:17.599+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.609+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.609+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:613,0.043230,9.772971,0.810893
04-23 20:05:17.609+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.619+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:596,0.009571,9.801002,0.799203
04-23 20:05:17.619+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.619+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:624,0.071785,9.801002,0.782453
04-23 20:05:17.619+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:589,-0.070000,-0.070000,0.070000
04-23 20:05:17.619+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.639+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.639+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:632,-0.070000,-0.070000,0.070000
04-23 20:05:17.639+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:617,0.044748,9.773031,0.810086
04-23 20:05:17.639+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.639+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:649,0.045057,9.772930,0.811287
04-23 20:05:17.639+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.649+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.659+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:643,0.047856,9.796216,0.811167
04-23 20:05:17.659+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.659+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:665,0.007178,9.805787,0.801596
04-23 20:05:17.659+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.659+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:669,0.028714,9.793823,0.777667
04-23 20:05:17.669+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:611,0.030369,0.012261,-0.025909
04-23 20:05:17.669+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:660,-0.070000,-0.140000,0.070000
04-23 20:05:17.669+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.669+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:679,-0.070000,0.070000,0.070000
04-23 20:05:17.669+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.679+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:652,0.043404,9.772783,0.813144
04-23 20:05:17.679+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.679+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:688,0.042859,9.772779,0.813236
04-23 20:05:17.679+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.689+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.699+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:693,0.035937,0.019379,-0.065774
04-23 20:05:17.699+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.699+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.709+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:705,-0.018593,0.031083,-0.021914
04-23 20:05:17.709+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.719+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:683,-0.070000,-0.070000,0.070000
04-23 20:05:17.719+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.719+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:724,-0.070000,-0.070000,0.070000
04-23 20:05:17.719+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.719+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:728,-0.070000,-0.070000,0.070000
04-23 20:05:17.719+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.729+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:711,0.019143,9.824929,0.789631
04-23 20:05:17.729+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.729+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:692,0.041881,9.772716,0.814045
04-23 20:05:17.729+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.739+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:720,-0.015459,0.019197,-0.034849
04-23 20:05:17.739+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.739+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:748,-0.014865,0.043157,-0.025682
04-23 20:05:17.739+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.749+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:735,-0.007178,9.824929,0.832702
04-23 20:05:17.749+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.749+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:17.749+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:17.759+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:740,0.039745,9.772483,0.816936
04-23 20:05:17.759+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.759+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:765,0.039376,9.772435,0.817529
04-23 20:05:17.759+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.769+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:755,0.028714,9.803394,0.792024
04-23 20:05:17.769+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.789+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:775,0.033500,9.836893,0.796810
04-23 20:05:17.789+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.789+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:732,-0.070000,-0.070000,0.070000
04-23 20:05:17.789+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.789+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:798,-0.070000,-0.070000,0.070000
04-23 20:05:17.789+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:752,0.035950,0.036038,-0.007281
04-23 20:05:17.799+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:768,0.039246,9.772392,0.818042
04-23 20:05:17.799+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.799+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:806,0.040705,9.772326,0.818763
04-23 20:05:17.799+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.809+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.809+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.819+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:814,0.038900,0.057620,-0.060382
04-23 20:05:17.819+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.819+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:824,-0.032517,0.026240,-0.023505
04-23 20:05:17.819+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.819+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:796,0.066999,9.812965,0.815953
04-23 20:05:17.819+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.859+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:830,0.052642,9.810574,0.823131
04-23 20:05:17.859+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.859+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:821,-0.070000,-0.070000,0.070000
04-23 20:05:17.859+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.859+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:868,-0.070000,-0.070000,0.070000
04-23 20:05:17.859+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.869+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:810,0.041419,9.772207,0.820141
04-23 20:05:17.869+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.869+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:828,0.009552,0.055028,-0.014906
04-23 20:05:17.869+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.879+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:866,0.038285,9.798609,0.837488
04-23 20:05:17.879+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.879+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:887,0.071785,9.784252,0.796810
04-23 20:05:17.879+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.889+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:872,-0.070000,0.070000,0.070000
04-23 20:05:17.889+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.899+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:874,0.041415,9.771991,0.822719
04-23 20:05:17.899+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.899+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:904,0.043026,9.772052,0.821906
04-23 20:05:17.899+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.899+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:908,0.044914,9.772311,0.818724
04-23 20:05:17.899+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.909+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:881,0.023308,0.043086,-0.005559
04-23 20:05:17.909+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.919+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:916,-0.032977,0.023992,-0.037161
04-23 20:05:17.919+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.919+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:901,-0.070000,-0.140000,0.070000
04-23 20:05:17.919+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.929+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:890,0.078963,9.791430,0.756132
04-23 20:05:17.929+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.939+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:931,-0.070000,0.070000,0.070000
04-23 20:05:17.939+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.939+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:927,-0.000450,0.019238,-0.025666
04-23 20:05:17.939+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.949+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:912,0.044173,9.772233,0.819695
04-23 20:05:17.949+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:17.949+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:17.959+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:940,0.026321,9.803394,0.796810
04-23 20:05:17.959+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.959+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.959+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:947,-0.070000,0.070000,0.070000
04-23 20:05:17.969+0200 I/servicemanager( 5532): es.ugr.frailty.location sleep timeout
04-23 20:05:17.969+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:17.979+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:05:17.979+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:960,-0.005372,0.050351,-0.011371
04-23 20:05:17.979+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.979+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:985,0.025851,0.040863,-0.033908
04-23 20:05:17.979+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.979+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:17:989,-0.011415,0.033609,-0.016185
04-23 20:05:17.979+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:17.989+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:17:967,0.043579,9.772202,0.820099
04-23 20:05:17.989+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:17:968,0.028714,9.791430,0.784846
04-23 20:05:17.989+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:17.989+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:05:17.989+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.999+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:05:17.999+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:18:2,0.043013,9.772141,0.820841
04-23 20:05:17.999+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:17.999+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:17:977,-0.070000,0.070000,0.070000
04-23 20:05:17.999+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5753
04-23 20:05:18.009+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5753)
04-23 20:05:18.009+0200 I/servicemanager( 5532): es.ugr.frailty.location stop request sent!
04-23 20:05:18.009+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:05:18.059+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11057536c6f63152450671
