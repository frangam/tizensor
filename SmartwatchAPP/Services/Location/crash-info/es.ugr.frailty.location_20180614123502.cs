S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 5968
Date: 2018-06-14 12:35:02+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf72fa52d, r5   = 0xf7626150
r6   = 0xffe70260, r7   = 0xffe70110
r8   = 0xf7638c18, r9   = 0x00000000
r10  = 0xffe701ec, fp   = 0xffe70260
ip   = 0x00000001, sp   = 0xffe700e8
lr   = 0xf72fa539, pc   = 0xf7363270
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     47148 KB
Buffers:     26884 KB
Cached:     124596 KB
VmPeak:      53444 KB
VmSize:      53436 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11972 KB
VmRSS:       11972 KB
VmData:      11164 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 5968 TID = 5968
5968 6048 

Maps Information
f41c5000 f49c4000 rw-p [stack:6048]
f49cb000 f49cd000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f49d5000 f49d9000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f49e2000 f49e4000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f49ec000 f49ef000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f49fe000 f4a03000 r-xp /usr/lib/libsystem.so.0.0.0
f4a0e000 f4a11000 r-xp /lib/libattr.so.1.1.0
f4a19000 f4a29000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4a31000 f4a3a000 r-xp /usr/lib/libedbus.so.1.7.99
f4a42000 f4a43000 r-xp /usr/lib/libresponse.so.0.2.96
f4a4c000 f4a51000 r-xp /usr/lib/libproc-stat.so.0.2.96
f62f3000 f63f9000 r-xp /usr/lib/libicuuc.so.57.1
f640f000 f6597000 r-xp /usr/lib/libicui18n.so.57.1
f65a7000 f65b4000 r-xp /usr/lib/libail.so.0.1.0
f65bd000 f65c4000 r-xp /usr/lib/libminizip.so.1.0.0
f65cd000 f6776000 r-xp /usr/lib/libcrypto.so.1.0.0
f6796000 f67dd000 r-xp /usr/lib/libssl.so.1.0.0
f67e9000 f67eb000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f67f3000 f67fa000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6803000 f680a000 r-xp /lib/libcrypt-2.13.so
f683b000 f683e000 r-xp /lib/libcap.so.2.21
f6846000 f6848000 r-xp /usr/lib/libiri.so
f6850000 f6899000 r-xp /usr/lib/libmdm.so.1.2.69
f68a1000 f68a7000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f68af000 f68d2000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f68dc000 f68de000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f68e6000 f6903000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f690c000 f6910000 r-xp /usr/lib/libsmack.so.1.0.0
f6919000 f6932000 r-xp /usr/lib/libnetwork.so.0.0.0
f693b000 f6943000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f694b000 f6951000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f695a000 f695c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6965000 f6975000 r-xp /lib/libresolv-2.13.so
f6979000 f6991000 r-xp /usr/lib/liblzma.so.5.0.3
f699a000 f699c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f69a4000 f69be000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f69c6000 f69f5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f69fe000 f6a0d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a17000 f6a21000 r-xp /usr/lib/libsensord-shared.so
f6a2a000 f6afd000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b08000 f6b1e000 r-xp /lib/libz.so.1.2.5
f6b26000 f6b2b000 r-xp /usr/lib/libffi.so.5.0.10
f6b33000 f6b34000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b3c000 f6b4c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b54000 f6b6d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b75000 f6b77000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b7f000 f6bf4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6bfe000 f6c1c000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c26000 f6c27000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c2f000 f6c52000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c5a000 f6c5f000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c67000 f6c91000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c9a000 f6cb1000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6cb9000 f6cbf000 r-xp /lib/librt-2.13.so
f6cc8000 f6d31000 r-xp /lib/libm-2.13.so
f6d3a000 f6dce000 r-xp /usr/lib/libstdc++.so.6.0.16
f6de1000 f6de6000 r-xp /usr/lib/libctx-client.so.0.8.3
f6dee000 f6df5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6dfd000 f6e27000 r-xp /usr/lib/libsensor.so.1.9.6
f6e30000 f6efc000 r-xp /usr/lib/libxml2.so.2.7.8
f6f09000 f6f0b000 r-xp /usr/lib/libiniparser.so.0
f6f14000 f6f1a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f23000 f6ff3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6ff4000 f7028000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7031000 f706d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7075000 f7078000 r-xp /usr/lib/libbundle.so.0.1.22
f7080000 f7086000 r-xp /usr/lib/libappsvc.so.0.1.0
f708e000 f70cf000 r-xp /usr/lib/libeina.so.1.7.99
f70d8000 f70e1000 r-xp /usr/lib/libvconf.so.0.2.45
f70e9000 f70fd000 r-xp /lib/libpthread-2.13.so
f7108000 f7115000 r-xp /usr/lib/libaul.so.0.1.0
f711f000 f7121000 r-xp /lib/libdl-2.13.so
f712a000 f7135000 r-xp /lib/libunwind.so.8.0.1
f7162000 f716a000 r-xp /lib/libgcc_s-4.6.so.1
f716b000 f728f000 r-xp /lib/libc-2.13.so
f729d000 f72b4000 r-xp /usr/lib/libecore.so.1.7.99
f72cb000 f72cd000 r-xp /usr/lib/libdlog.so.0.0.0
f72d5000 f72e1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f72ea000 f72ef000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f72f7000 f7306000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f730e000 f7312000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f731b000 f731e000 r-xp /usr/lib/libappcore-agent.so.1.1
f7326000 f7328000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7330000 f7334000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f733c000 f7359000 r-xp /lib/ld-2.13.so
f7362000 f7365000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7365000 f7369000 r-xp /usr/lib/libsys-assert.so
f7608000 f7676000 rw-p [heap]
ffe51000 ffe72000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5968)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7363270) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1270
 1: (0xf72fa539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70013f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6fffc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf700be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7011be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7011dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf704675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70411f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6fffc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf700be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7011be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7011dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7043e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7044017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf704bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49e31fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf49d6171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6aa9663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f56fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f587a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf72adca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf72a8b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72a95a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf72a9879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf731c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf731c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf736360b) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x160b
28: __libc_start_main + 0x114 (0xf718285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7362f74) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf74
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
33500
06-14 12:35:01.421+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.431+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:411,9.656009,-1.651357,-0.452654
06-14 12:35:01.431+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.431+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:439,9.648052,-1.700949,-0.438460
06-14 12:35:01.431+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.431+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:428,0.225984,-1.040447,0.695280
06-14 12:35:01.441+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.441+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:420,-16.520000,-8.050000,-17.290001
06-14 12:35:01.441+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.441+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:446,0.348383,-1.258315,0.799613
06-14 12:35:01.441+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.441+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:448,-11.410000,-7.980000,-16.730000
06-14 12:35:01.441+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.451+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:452,-0.172475,-1.141724,1.118022
06-14 12:35:01.451+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.451+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:434,9.588040,-2.574677,0.299103
06-14 12:35:01.451+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.451+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:458,-0.271465,-0.799780,1.218008
06-14 12:35:01.451+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:459,9.887143,-2.658426,0.232104
06-14 12:35:01.451+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.461+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:444,9.634581,-1.782076,-0.411627
06-14 12:35:01.461+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.461+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:454,-3.710000,-8.050000,-12.950000
06-14 12:35:01.461+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.461+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:467,9.609710,-1.917988,-0.381032
06-14 12:35:01.461+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:470,4.760000,-8.960000,-5.880000
06-14 12:35:01.471+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:464,10.004392,-2.909672,0.346959
06-14 12:35:01.471+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.471+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.471+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.471+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:478,9.730000,-8.540000,3.640000
06-14 12:35:01.471+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:478,-0.253773,-0.539441,1.149128
06-14 12:35:01.471+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.481+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:483,9.569125,-2.116382,-0.350942
06-14 12:35:01.481+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:477,9.475577,-2.842674,0.679562
06-14 12:35:01.481+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.481+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:490,9.363115,-2.581856,0.806381
06-14 12:35:01.481+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.491+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.491+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.491+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:497,13.860000,-8.680000,13.230000
06-14 12:35:01.491+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:497,0.014130,-0.384118,0.956326
06-14 12:35:01.491+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.491+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:494,9.355937,-2.457429,0.768096
06-14 12:35:01.491+0200 I/heartrate( 5955): es.ugr.frailty.heartrate - capturing data
06-14 12:35:01.491+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.501+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:505,9.583255,-2.500499,0.605384
06-14 12:35:01.501+0200 I/heartrate( 5955): es.ugr.frailty.heartrate: SM-R760,14/06/2018,12:35:01:505,87
06-14 12:35:01.501+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:502,9.505436,-2.389529,-0.327458
06-14 12:35:01.511+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.511+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.521+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:523,17.850000,-9.940000,22.049999
06-14 12:35:01.521+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.521+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:524,9.547362,-2.364109,0.689133
06-14 12:35:01.521+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.521+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:529,0.041926,0.025420,1.016591
06-14 12:35:01.521+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:530,9.386619,-2.823461,-0.299733
06-14 12:35:01.531+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.531+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.531+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:539,9.521042,-2.380858,0.897308
06-14 12:35:01.531+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:539,20.370001,-10.430000,27.299999
06-14 12:35:01.531+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.541+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.541+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:546,0.134423,0.442603,1.197042
06-14 12:35:01.541+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:545,9.125775,-3.581174,-0.256532
06-14 12:35:01.551+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.551+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.561+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.561+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.561+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:561,9.382257,-2.328217,1.024128
06-14 12:35:01.561+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:560,25.969999,-10.500000,31.150000
06-14 12:35:01.561+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:566,0.256482,1.252958,1.280660
06-14 12:35:01.571+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:566,8.412432,-5.036779,-0.179554
06-14 12:35:01.571+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.571+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.571+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:579,31.780001,-10.150000,33.529999
06-14 12:35:01.571+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:580,9.200402,-2.189433,0.952343
06-14 12:35:01.581+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.581+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.581+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:586,7.498379,-6.319894,-0.060267
06-14 12:35:01.581+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:586,0.787971,2.847346,1.131897
06-14 12:35:01.591+0200 I/light   ( 6008): es.ugr.frailty.light - capturing data
06-14 12:35:01.591+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.591+0200 I/light   ( 6008): es.ugr.frailty.light: SM-R760,14/06/2018,12:35:01:598,126.000000
06-14 12:35:01.591+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.601+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.601+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.601+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:604,9.028119,-2.129612,0.868595
06-14 12:35:01.611+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:610,1.529740,4.190282,0.928862
06-14 12:35:01.611+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:598,38.360001,-8.890000,34.299999
06-14 12:35:01.611+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.611+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.621+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:607,7.586145,-6.214418,0.042353
06-14 12:35:01.621+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.621+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:623,9.107083,-2.048256,0.715454
06-14 12:35:01.621+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.621+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:626,7.878901,-5.837740,0.118727
06-14 12:35:01.621+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:629,43.049999,-8.540000,32.900002
06-14 12:35:01.621+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:623,1.520938,4.166162,0.673101
06-14 12:35:01.631+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.631+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.631+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:639,9.219545,-1.998007,0.571885
06-14 12:35:01.641+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.641+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.641+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:646,1.340644,3.839733,0.453158
06-14 12:35:01.651+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.651+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:649,8.054374,-5.591382,0.184110
06-14 12:35:01.651+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.661+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:639,46.480000,-7.420000,31.360001
06-14 12:35:01.661+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:659,9.391829,-1.919044,0.492921
06-14 12:35:01.661+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.661+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.661+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:667,47.670002,-6.440000,29.330000
06-14 12:35:01.661+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:667,1.337455,3.672338,0.308811
06-14 12:35:01.671+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.671+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.671+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.681+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:663,8.155097,-5.441046,0.244538
06-14 12:35:01.681+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.681+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:680,1.377909,3.610537,0.193348
06-14 12:35:01.691+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:681,45.290001,-5.460000,27.020000
06-14 12:35:01.691+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:678,9.533006,-1.830509,0.437887
06-14 12:35:01.691+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.691+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.691+0200 I/heartrate( 5955): es.ugr.frailty.heartrate - capturing data
06-14 12:35:01.701+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:698,9.384650,-1.828116,0.375673
06-14 12:35:01.701+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:691,8.215480,-5.346660,0.299164
06-14 12:35:01.701+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.701+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.711+0200 I/heartrate( 5955): es.ugr.frailty.heartrate: SM-R760,14/06/2018,12:35:01:705,87
06-14 12:35:01.711+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:714,8.247914,-5.293645,0.345857
06-14 12:35:01.711+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:698,1.169170,3.518543,0.076509
06-14 12:35:01.711+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.721+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:714,41.299999,-4.270000,24.990000
06-14 12:35:01.721+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.721+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:728,37.450001,-4.620000,22.889999
06-14 12:35:01.721+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.731+0200 W/libgps_d( 3118): OnGpsExtensionMessage: message_id(1), data(0xf78e2f38), size(2752)
06-14 12:35:01.731+0200 W/libgps_d( 3118): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-14 12:35:01.731+0200 W/libgps  ( 3118): proxy__gps_sv_status_cb : called
06-14 12:35:01.731+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.741+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:734,8.233376,-5.314264,0.374854
06-14 12:35:01.741+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.741+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:723,9.214760,-1.816152,0.177069
06-14 12:35:01.741+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.741+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:743,0.966846,3.477493,-0.168788
06-14 12:35:01.741+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.751+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:751,9.245867,-1.959722,0.105284
06-14 12:35:01.751+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.751+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:747,8.199100,-5.365502,0.395618
06-14 12:35:01.751+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.751+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:759,9.516255,-2.098505,0.002393
06-14 12:35:01.751+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:760,8.145655,-5.445240,0.409944
06-14 12:35:01.761+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:753,1.012491,3.354543,-0.269569
06-14 12:35:01.761+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.761+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.761+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:770,36.189999,-5.950000,19.320000
06-14 12:35:01.761+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.771+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.771+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.771+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:779,10.143176,-2.249253,-0.081356
06-14 12:35:01.771+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:779,8.086652,-5.531705,0.420340
06-14 12:35:01.781+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:769,1.317155,3.266997,-0.393225
06-14 12:35:01.781+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:775,39.689999,-8.260000,15.540000
06-14 12:35:01.781+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.781+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.781+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:786,1.997521,3.195987,-0.491300
06-14 12:35:01.781+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:787,45.360001,-10.990000,10.570000
06-14 12:35:01.791+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.791+0200 I/light   ( 6008): es.ugr.frailty.light - capturing data
06-14 12:35:01.791+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:800,8.025067,-5.620416,0.423796
06-14 12:35:01.791+0200 I/light   ( 6008): es.ugr.frailty.light: SM-R760,14/06/2018,12:35:01:800,123.000000
06-14 12:35:01.791+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.791+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.801+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:805,49.630001,-12.530000,5.110000
06-14 12:35:01.801+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:805,10.504492,-2.380858,-0.217747
06-14 12:35:01.801+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.801+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:810,2.417840,3.150847,-0.638087
06-14 12:35:01.811+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.811+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.821+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:822,10.518847,-2.529213,-0.358923
06-14 12:35:01.821+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.821+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:823,7.980103,-5.683028,0.437636
06-14 12:35:01.821+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.831+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.831+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.841+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:839,10.499706,-2.476572,-0.339781
06-14 12:35:01.841+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:832,50.610001,-13.510000,-1.540000
06-14 12:35:01.841+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.841+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:828,2.493780,3.091202,-0.782720
06-14 12:35:01.841+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.841+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:841,7.935079,-5.744730,0.450539
06-14 12:35:01.841+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:849,2.519603,3.206457,-0.777417
06-14 12:35:01.851+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.851+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.851+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:859,7.893508,-5.801331,0.455492
06-14 12:35:01.851+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:859,10.827522,-2.629712,-0.447458
06-14 12:35:01.851+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.861+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:848,54.389999,-17.920000,-4.690000
06-14 12:35:01.861+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.861+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:865,2.892443,3.115018,-0.897997
06-14 12:35:01.861+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:867,50.889999,-18.900000,-7.840000
06-14 12:35:01.871+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.871+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.871+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:878,11.126624,-2.924029,-0.478565
06-14 12:35:01.871+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:878,7.865269,-5.839359,0.458057
06-14 12:35:01.871+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.871+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.881+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:884,3.233116,2.877301,-0.934056
06-14 12:35:01.881+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:884,51.450001,-20.160000,-12.530000
06-14 12:35:01.891+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.891+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.901+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:901,7.851638,-5.857175,0.464400
06-14 12:35:01.901+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.901+0200 I/heartrate( 5955): es.ugr.frailty.heartrate - capturing data
06-14 12:35:01.901+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:901,11.143374,-3.115455,-0.495314
06-14 12:35:01.901+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.911+0200 I/heartrate( 5955): es.ugr.frailty.heartrate: SM-R760,14/06/2018,12:35:01:909,88
06-14 12:35:01.911+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.911+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.921+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:925,7.855470,-5.850854,0.479046
06-14 12:35:01.921+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:913,3.278106,2.723904,-0.953371
06-14 12:35:01.921+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.931+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:907,54.950001,-18.620001,-12.880000
06-14 12:35:01.931+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.931+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:924,10.724631,-3.148954,-0.449851
06-14 12:35:01.931+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.931+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.931+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:940,9.915856,-3.069991,-0.375673
06-14 12:35:01.941+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:937,60.480000,-15.400000,-11.480000
06-14 12:35:01.941+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:934,2.872993,2.708221,-0.914251
06-14 12:35:01.941+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.941+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:943,7.840076,-5.870642,0.489035
06-14 12:35:01.941+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.951+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.951+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.951+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:959,7.814531,-5.902705,0.511423
06-14 12:35:01.951+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:959,9.138189,-2.957529,-0.406780
06-14 12:35:01.961+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:953,68.669998,-12.250000,-7.980000
06-14 12:35:01.961+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.961+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:951,2.060387,2.780863,-0.854719
06-14 12:35:01.961+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:01.961+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:967,78.540001,-9.590000,-1.400000
06-14 12:35:01.961+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:01:968,1.298113,2.913113,-0.895815
06-14 12:35:01.971+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:01.971+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:01.981+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:01:980,7.755677,-5.978104,0.531166
06-14 12:35:01.981+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:01.981+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:01:987,86.449997,-10.080000,6.860000
06-14 12:35:01.991+0200 I/light   ( 6008): es.ugr.frailty.light - capturing data
06-14 12:35:01.991+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:02.001+0200 W/LOCATION( 5968): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-14 12:35:02.001+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:02:1,7.673672,-6.081339,0.549961
06-14 12:35:02.001+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:02.011+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:02:11,92.750000,-9.870000,15.260000
06-14 12:35:02.011+0200 I/light   ( 6008): es.ugr.frailty.light: SM-R760,14/06/2018,12:35:01:999,113.000000
06-14 12:35:02.011+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:01:979,9.013763,-2.737389,-0.634098
06-14 12:35:02.011+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:02.011+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:02.011+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:02.021+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:02.021+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:02:23,1.199232,3.165316,-1.145521
06-14 12:35:02.021+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:02.021+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:02:26,7.581354,-6.193743,0.575329
06-14 12:35:02.021+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:02:29,1.576332,3.345999,-1.354297
06-14 12:35:02.021+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:02:23,96.599998,-7.560000,24.360001
06-14 12:35:02.031+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:02.031+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:02:20,9.332008,-2.632105,-0.823131
06-14 12:35:02.031+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:02.031+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:02:38,7.481641,-6.310899,0.606624
06-14 12:35:02.031+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:02.031+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:02:40,9.683753,-2.610569,-0.878166
06-14 12:35:02.031+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:02.041+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:02.041+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:02:44,98.980003,-6.860000,29.330000
06-14 12:35:02.041+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:02:45,10.107283,-2.761317,-0.916451
06-14 12:35:02.051+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:02:48,2.010081,3.470770,-1.428127
06-14 12:35:02.051+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:02.051+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:02.051+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:02:59,7.413502,-6.383456,0.679601
06-14 12:35:02.051+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:02:59,10.430314,-2.833102,-0.990629
06-14 12:35:02.051+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:02.051+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:02.061+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:02:64,2.525928,3.432426,-1.491780
06-14 12:35:02.061+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:02:64,100.940002,-4.900000,31.850000
06-14 12:35:02.061+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:02.061+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:02:69,2.948673,3.477797,-1.597253
06-14 12:35:02.071+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:02.071+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:02.071+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:02.071+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:02:78,10.557133,-2.797210,-1.093520
06-14 12:35:02.071+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:02.081+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:02:82,104.300003,-3.290000,31.990000
06-14 12:35:02.081+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:02:83,3.143631,3.586246,-1.773121
06-14 12:35:02.081+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:02:78,7.346686,-6.451780,0.755730
06-14 12:35:02.091+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:02.091+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:02.091+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:02:98,10.715059,-2.620141,-0.899701
06-14 12:35:02.091+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:02:98,3.368373,3.831639,-1.655431
06-14 12:35:02.091+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:02.091+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:02.091+0200 I/heartrate( 5955): es.ugr.frailty.heartrate - capturing data
06-14 12:35:02.101+0200 I/heartrate( 5955): es.ugr.frailty.heartrate: SM-R760,14/06/2018,12:35:02:105,88
06-14 12:35:02.101+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:02:105,104.090004,-1.750000,32.830002
06-14 12:35:02.111+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:02:102,7.288363,-6.507682,0.836797
06-14 12:35:02.111+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:02.111+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:02.121+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:02:123,9.985250,-2.435893,-0.887737
06-14 12:35:02.121+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:02:123,2.696887,4.071789,-1.724534
06-14 12:35:02.121+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:02.121+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:02.131+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:02.131+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:02.131+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:02:138,9.293723,-2.330609,-1.038485
06-14 12:35:02.131+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:02:139,2.074454,4.249962,-1.903709
06-14 12:35:02.131+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:02:128,7.219269,-6.580571,0.865224
06-14 12:35:02.131+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:02.141+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:02:130,96.250000,5.740000,35.840000
06-14 12:35:02.141+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:02.141+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:02:144,7.127693,-6.677860,0.878957
06-14 12:35:02.141+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:02:146,88.830002,8.330000,39.340000
06-14 12:35:02.151+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:02.151+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:02.151+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:02:158,8.896514,-2.201397,-1.122234
06-14 12:35:02.151+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:02:158,1.768821,4.476463,-2.001191
06-14 12:35:02.151+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:02.161+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:02.161+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:02:163,7.014087,-6.797410,0.876456
06-14 12:35:02.161+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:02:165,78.889999,9.240000,43.959999
06-14 12:35:02.171+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:02.171+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:02.171+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:02:179,8.788837,-2.189433,-1.062413
06-14 12:35:02.171+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:02:179,1.774750,4.607978,-1.938869
06-14 12:35:02.171+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:02.181+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:02.181+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:02:186,68.180000,9.870000,46.549999
06-14 12:35:02.181+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:02:183,6.893928,-6.920680,0.865064
06-14 12:35:02.191+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:02.191+0200 I/light   ( 6008): es.ugr.frailty.light - capturing data
06-14 12:35:02.191+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:02:198,1.969088,4.666640,-1.831765
06-14 12:35:02.191+0200 I/light   ( 6008): es.ugr.frailty.light: SM-R760,14/06/2018,12:35:02:198,115.000000
06-14 12:35:02.191+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:02.191+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:02.201+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:02:202,8.863015,-2.254039,-0.966700
06-14 12:35:02.201+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:02.201+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:02:206,58.310001,9.520000,46.830002
06-14 12:35:02.201+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:02:202,6.775594,-7.038682,0.847744
06-14 12:35:02.211+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:02.211+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:02.221+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:02:223,9.157332,-2.407180,-0.892523
06-14 12:35:02.221+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:02:223,2.381739,4.631502,-1.740267
06-14 12:35:02.221+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:02.221+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:02:227,6.665217,-7.145935,0.825151
06-14 12:35:02.221+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:02.221+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:02:231,49.490002,8.610000,44.660000
06-14 12:35:02.231+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:02.231+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:02.231+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:02:238,9.346365,-2.617748,-0.763310
06-14 12:35:02.231+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:02:238,2.681148,4.528187,-1.588461
06-14 12:35:02.231+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:02.241+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:02.241+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:02:246,44.520000,8.680000,40.250000
06-14 12:35:02.241+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:02:242,6.574730,-7.231437,0.805996
06-14 12:35:02.251+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:02.251+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:02:261,2.829062,4.450976,-1.397023
06-14 12:35:02.261+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:02.261+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:02.261+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:02:270,6.508184,-7.292454,0.796264
06-14 12:35:02.271+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:02:266,43.889999,7.910000,35.490002
06-14 12:35:02.271+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:02.271+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:02:278,2.955429,4.416281,-1.461469
06-14 12:35:02.271+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:02.281+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:02.281+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:02.281+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:02:285,9.403792,-2.780460,-0.591027
06-14 12:35:02.281+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:02:286,6.452182,-7.343435,0.783386
06-14 12:35:02.281+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:02:283,45.779999,7.840000,31.219999
06-14 12:35:02.281+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:02.281+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:02:290,9.463614,-2.876173,-0.665205
06-14 12:35:02.291+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:02.291+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:02.291+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:02:298,6.409383,-7.383078,0.761808
06-14 12:35:02.291+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:35:02:298,9.700503,-2.871387,-0.830309
06-14 12:35:02.291+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:02.291+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:02.291+0200 I/heartrate( 5955): es.ugr.frailty.heartrate - capturing data
06-14 12:35:02.301+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:02:302,50.259998,6.020000,25.200001
06-14 12:35:02.301+0200 I/heartrate( 5955): es.ugr.frailty.heartrate: SM-R760,14/06/2018,12:35:02:305,88
06-14 12:35:02.301+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:02:302,3.248322,4.472048,-1.613695
06-14 12:35:02.311+0200 W/AUL     ( 6073): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-14 12:35:02.311+0200 W/AUL_AMD ( 2477): amd_request.c: __request_handler(669) > __request_handler: 23
06-14 12:35:02.311+0200 W/AUL_AMD ( 2477): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-14 12:35:02.311+0200 W/AUL_AMD ( 2477): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5723
06-14 12:35:02.311+0200 W/AUL_AMD ( 2477): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-14 12:35:02.321+0200 I/AUL_AMD ( 2477): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5723
06-14 12:35:02.321+0200 W/AUL     ( 2477): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5723)
06-14 12:35:02.331+0200 I/accelerometer( 5941): es.ugr.frailty.accelerometer - capturing data
06-14 12:35:02.331+0200 W/libgps_d( 3118): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-14 12:35:02.331+0200 W/libgps  ( 3118): [proxy__gps_stop][line = 1067]: called.
06-14 12:35:02.331+0200 W/libgps_d( 3118): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-14 12:35:02.331+0200 W/libgps_d( 3118): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-14 12:35:02.331+0200 W/libgps_d( 3118): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-14 12:35:02.331+0200 W/libgps_d( 3118): GpsiHookStateGps              : EXIT
06-14 12:35:02.331+0200 W/libgps_d( 3118): GpsiHookStateIdle             : ENTRY
06-14 12:35:02.331+0200 W/gpsd    ( 3090): HandleIncomingMessage() dest id:0, msg id:2
06-14 12:35:02.331+0200 E/CAPI_LOCATION_MANAGER( 6049): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-14 12:35:02.341+0200 I/SECURE_STORAGE( 2511): ss_server_ipc.c: SsServerComm(251) > write succeed
06-14 12:35:02.351+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:02.351+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:02:359,51.520000,5.600000,20.230000
06-14 12:35:02.351+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:02.371+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:02.381+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:02:385,6.398339,-7.394439,0.744253
06-14 12:35:02.381+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:02.381+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:02:389,6.408281,-7.388651,0.715648
06-14 12:35:02.381+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:02.391+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:02.391+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:02:363,46.340000,5.810000,16.870001
06-14 12:35:02.391+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:02.391+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:02:400,32.900002,7.490000,16.660000
06-14 12:35:02.401+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:02:396,3.475368,4.595440,-1.482048
06-14 12:35:02.401+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:02.401+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:02:406,3.553411,4.884368,-1.440564
06-14 12:35:02.401+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:02.401+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:02:410,3.478862,5.036507,-1.344960
06-14 12:35:02.401+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:02.411+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:02:393,6.422533,-7.380125,0.674696
06-14 12:35:02.411+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:02.411+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:02:417,6.421333,-7.386148,0.617799
06-14 12:35:02.411+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:02.411+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope - capturing data
06-14 12:35:02.421+0200 I/gyroscope( 5943): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:35:02:422,15.750000,10.710000,18.830000
06-14 12:35:02.421+0200 I/gravity ( 5986): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:35:02:421,6.386351,-7.418544,0.591703
06-14 12:35:02.421+0200 I/gravity ( 5986): es.ugr.frailty.gravity - capturing data
06-14 12:35:02.421+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:35:02:414,2.612765,5.217013,-1.268116
06-14 12:35:02.421+0200 I/linearacceleration( 5980): es.ugr.frailty.linearacceleration - capturing data
06-14 12:35:02.441+0200 W/CRASH_MANAGER( 6074): worker.c: worker_job(1205) > 11059686c6f63152897250
