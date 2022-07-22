S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 12407
Date: 2018-04-23 20:41:19+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf737252d, r5   = 0xf7ab9f98
r6   = 0xffee1de0, r7   = 0xffee1c90
r8   = 0xf7ab6c18, r9   = 0x00000000
r10  = 0xffee1d6c, fp   = 0xffee1de0
ip   = 0x00000001, sp   = 0xffee1c68
lr   = 0xf7372539, pc   = 0xf73db228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     27196 KB
Buffers:     40420 KB
Cached:     161420 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11768 KB
VmRSS:       11764 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 12407 TID = 12407
12407 12410 

Maps Information
f423d000 f4a3c000 rw-p [stack:12410]
f4a43000 f4a45000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4a4d000 f4a51000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4a5a000 f4a5c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4a64000 f4a67000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4a76000 f4a7b000 r-xp /usr/lib/libsystem.so.0.0.0
f4a86000 f4a89000 r-xp /lib/libattr.so.1.1.0
f4a91000 f4aa1000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4aa9000 f4ab2000 r-xp /usr/lib/libedbus.so.1.7.99
f4aba000 f4abb000 r-xp /usr/lib/libresponse.so.0.2.96
f4ac4000 f4ac9000 r-xp /usr/lib/libproc-stat.so.0.2.96
f636b000 f6471000 r-xp /usr/lib/libicuuc.so.57.1
f6487000 f660f000 r-xp /usr/lib/libicui18n.so.57.1
f661f000 f662c000 r-xp /usr/lib/libail.so.0.1.0
f6635000 f663c000 r-xp /usr/lib/libminizip.so.1.0.0
f6645000 f67ee000 r-xp /usr/lib/libcrypto.so.1.0.0
f680e000 f6855000 r-xp /usr/lib/libssl.so.1.0.0
f6861000 f6863000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f686b000 f6872000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f687b000 f6882000 r-xp /lib/libcrypt-2.13.so
f68b3000 f68b6000 r-xp /lib/libcap.so.2.21
f68be000 f68c0000 r-xp /usr/lib/libiri.so
f68c8000 f6911000 r-xp /usr/lib/libmdm.so.1.2.69
f6919000 f691f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6927000 f694a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6954000 f6956000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f695e000 f697b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6984000 f6988000 r-xp /usr/lib/libsmack.so.1.0.0
f6991000 f69aa000 r-xp /usr/lib/libnetwork.so.0.0.0
f69b3000 f69bb000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f69c3000 f69c9000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f69d2000 f69d4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f69dd000 f69ed000 r-xp /lib/libresolv-2.13.so
f69f1000 f6a09000 r-xp /usr/lib/liblzma.so.5.0.3
f6a12000 f6a14000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a1c000 f6a36000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a3e000 f6a6d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a76000 f6a85000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a8f000 f6a99000 r-xp /usr/lib/libsensord-shared.so
f6aa2000 f6b75000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b80000 f6b96000 r-xp /lib/libz.so.1.2.5
f6b9e000 f6ba3000 r-xp /usr/lib/libffi.so.5.0.10
f6bab000 f6bac000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6bb4000 f6bc4000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6bcc000 f6be5000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6bed000 f6bef000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6bf7000 f6c6c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c76000 f6c7c000 r-xp /lib/librt-2.13.so
f6c85000 f6ca3000 r-xp /usr/lib/libsystemd.so.0.4.0
f6cad000 f6cae000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6cb6000 f6cd9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ce1000 f6ce6000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6cee000 f6d18000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d21000 f6d38000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d40000 f6da9000 r-xp /lib/libm-2.13.so
f6db2000 f6e46000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e59000 f6e5e000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e66000 f6e6d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e75000 f6e9f000 r-xp /usr/lib/libsensor.so.1.9.6
f6ea8000 f6f74000 r-xp /usr/lib/libxml2.so.2.7.8
f6f81000 f6f83000 r-xp /usr/lib/libiniparser.so.0
f6f8c000 f6f92000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f9b000 f706b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f706c000 f70a0000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f70a9000 f70e5000 r-xp /usr/lib/libSLP-location.so.0.9.24
f70ed000 f70f0000 r-xp /usr/lib/libbundle.so.0.1.22
f70f8000 f70fe000 r-xp /usr/lib/libappsvc.so.0.1.0
f7106000 f7147000 r-xp /usr/lib/libeina.so.1.7.99
f7150000 f7167000 r-xp /usr/lib/libecore.so.1.7.99
f717e000 f7187000 r-xp /usr/lib/libvconf.so.0.2.45
f718f000 f71a3000 r-xp /lib/libpthread-2.13.so
f71ae000 f71bb000 r-xp /usr/lib/libaul.so.0.1.0
f71c5000 f71c7000 r-xp /lib/libdl-2.13.so
f71d0000 f71db000 r-xp /lib/libunwind.so.8.0.1
f7208000 f7210000 r-xp /lib/libgcc_s-4.6.so.1
f7211000 f7335000 r-xp /lib/libc-2.13.so
f7343000 f7345000 r-xp /usr/lib/libdlog.so.0.0.0
f734d000 f7359000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7362000 f7367000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f736f000 f737e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7386000 f738a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7393000 f7396000 r-xp /usr/lib/libappcore-agent.so.1.1
f739e000 f73a0000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f73a8000 f73ac000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f73b4000 f73d1000 r-xp /lib/ld-2.13.so
f73da000 f73dd000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f73dd000 f73e1000 r-xp /usr/lib/libsys-assert.so
f7a86000 f7af4000 rw-p [heap]
ffec3000 ffee4000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12407)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf73db228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7372539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70793f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7077c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7083e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7089be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7089dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf70be75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70b91f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7077c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7083e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7089be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7089dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf70bbe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf70bc017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf70c3f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4a5b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4a4e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6b21663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6fcefcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6fd07a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7160ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf715bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf715c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf715c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7394183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73947fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73db5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf722885c) [/lib/libc.so.6] + 0x1785c
29: (0xf73daf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
.039+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:43,0.057428,9.820145,0.775275
04-23 20:41:18.039+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:30,0.040929,9.772878,0.812135
04-23 20:41:18.049+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.049+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.049+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.059+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:63,-0.012216,0.037696,0.003817
04-23 20:41:18.059+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.059+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:60,0.041859,9.772938,0.811370
04-23 20:41:18.069+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:61,-0.070000,0.070000,0.070000
04-23 20:41:18.069+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:72,0.028714,9.810574,0.815953
04-23 20:41:18.069+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.079+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.079+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.079+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.089+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:87,-0.027502,0.028064,-0.009774
04-23 20:41:18.089+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:98,0.014357,9.801002,0.801596
04-23 20:41:18.099+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:85,0.041079,9.773022,0.810400
04-23 20:41:18.099+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:88,-0.070000,0.070000,-0.070000
04-23 20:41:18.099+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.109+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.109+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.109+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.129+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:123,-0.070000,0.070000,-0.070000
04-23 20:41:18.129+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:41:18.129+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:41:18.129+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:114,0.039653,9.773135,0.809103
04-23 20:41:18.129+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:120,0.006778,0.032765,-0.013590
04-23 20:41:18.189+0200 E/CAPI_TELEPHONY(12139): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:41:18.199+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.199+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.199+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.199+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:129,0.047856,9.805787,0.796810
04-23 20:41:18.199+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:209,0.039883,9.773313,0.806942
04-23 20:41:18.209+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:213,-0.070000,0.070000,-0.070000
04-23 20:41:18.209+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.219+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:217,-0.015725,0.018295,-0.033829
04-23 20:41:18.219+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.219+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.219+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:221,0.023928,9.791430,0.775275
04-23 20:41:18.219+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.229+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.239+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:236,0.070000,0.070000,-0.070000
04-23 20:41:18.249+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:233,0.038955,9.773547,0.804136
04-23 20:41:18.249+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:244,0.057428,9.848858,0.827917
04-23 20:41:18.249+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.249+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.249+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:239,0.017545,0.075545,0.020975
04-23 20:41:18.249+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.259+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.269+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:267,-0.036562,0.046597,0.011817
04-23 20:41:18.269+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:263,-0.070000,0.140000,-0.070000
04-23 20:41:18.269+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:261,0.039643,9.773575,0.803770
04-23 20:41:18.279+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.279+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.279+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.289+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:270,0.002393,9.820145,0.815953
04-23 20:41:18.289+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.289+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:293,0.037739,9.773699,0.802348
04-23 20:41:18.299+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:290,0.070000,-0.140000,-0.070000
04-23 20:41:18.299+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.299+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.299+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:294,0.005820,0.029819,0.024146
04-23 20:41:18.309+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.309+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:300,0.045464,9.803394,0.827917
04-23 20:41:18.319+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.319+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:313,0.038256,9.773509,0.804635
04-23 20:41:18.329+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:316,0.070000,-0.140000,0.070000
04-23 20:41:18.329+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.329+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:41:18.329+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:41:18.329+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:320,0.010118,0.036875,-0.010324
04-23 20:41:18.329+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.339+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.339+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:325,0.047856,9.810574,0.792024
04-23 20:41:18.349+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.349+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:343,0.038866,9.773484,0.804907
04-23 20:41:18.349+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:356,0.047856,9.765109,0.787239
04-23 20:41:18.349+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:339,0.070000,-0.140000,0.070000
04-23 20:41:18.349+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.359+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.359+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:348,0.009601,-0.008400,-0.017396
04-23 20:41:18.359+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.369+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.369+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:374,-0.014938,0.025125,-0.015276
04-23 20:41:18.369+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:378,0.023928,9.798609,0.789631
04-23 20:41:18.379+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:364,-0.070000,-0.140000,0.070000
04-23 20:41:18.379+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.379+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:370,0.039465,9.773442,0.805392
04-23 20:41:18.379+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.379+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.389+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.389+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:388,-0.070000,-0.140000,0.070000
04-23 20:41:18.399+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:391,0.038887,9.773374,0.806256
04-23 20:41:18.399+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:398,0.047856,9.808180,0.803988
04-23 20:41:18.409+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.409+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:394,0.008392,0.034738,-0.001404
04-23 20:41:18.409+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.409+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.409+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.439+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:417,0.039466,9.773270,0.807487
04-23 20:41:18.499+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:413,-0.070000,-0.070000,0.070000
04-23 20:41:18.509+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:422,-0.005388,0.025235,-0.033375
04-23 20:41:18.509+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.519+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:424,0.033500,9.798609,0.772882
04-23 20:41:18.519+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.529+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:41:18.529+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:41:18.529+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.529+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.529+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:537,0.040678,9.810574,0.799203
04-23 20:41:18.539+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:526,-0.070000,-0.070000,0.070000
04-23 20:41:18.539+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.539+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:528,0.039338,9.773273,0.807439
04-23 20:41:18.549+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.549+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.549+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:557,0.039555,9.773189,0.808454
04-23 20:41:18.549+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:541,0.001212,0.037304,-0.008284
04-23 20:41:18.549+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.559+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:553,-0.070000,-0.070000,0.070000
04-23 20:41:18.559+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:562,0.016750,9.784252,0.746561
04-23 20:41:18.569+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:565,-0.022588,0.010979,-0.060878
04-23 20:41:18.569+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.569+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.569+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.579+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.579+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:579,0.038610,9.773241,0.807869
04-23 20:41:18.589+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:576,-0.070000,-0.070000,0.070000
04-23 20:41:18.589+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:592,0.023603,0.058867,-0.015844
04-23 20:41:18.589+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.599+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.599+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:583,0.062213,9.832108,0.792024
04-23 20:41:18.599+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.609+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.619+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:604,-0.070000,-0.070000,0.070000
04-23 20:41:18.619+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:611,0.045464,9.781858,0.830309
04-23 20:41:18.619+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:609,0.039880,9.773228,0.807964
04-23 20:41:18.619+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.619+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.629+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.629+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:618,0.006853,0.008617,0.022441
04-23 20:41:18.629+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:631,-0.070000,-0.070000,0.070000
04-23 20:41:18.629+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.639+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:633,0.040301,9.773014,0.810530
04-23 20:41:18.649+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:643,-0.020737,0.032559,-0.025511
04-23 20:41:18.649+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.649+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.649+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:642,0.019143,9.805787,0.782453
04-23 20:41:18.649+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.659+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.659+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:657,-0.070000,-0.070000,0.070000
04-23 20:41:18.669+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:661,0.039446,9.772964,0.811173
04-23 20:41:18.669+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:671,-0.009194,0.027987,-0.013720
04-23 20:41:18.669+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.679+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:41:18.679+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:18.679+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:41:18.689+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:664,0.031107,9.801002,0.796810
04-23 20:41:18.689+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.689+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.699+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.709+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:700,0.039206,9.772885,0.812138
04-23 20:41:18.709+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:694,-0.070000,-0.070000,0.070000
04-23 20:41:18.709+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:708,0.010803,0.004108,-0.043077
04-23 20:41:18.709+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.709+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.719+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:704,0.050249,9.777073,0.768096
04-23 20:41:18.719+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.729+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.729+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:41:18.729+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:41:18.729+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:724,0.039900,9.772964,0.811161
04-23 20:41:18.729+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:720,-0.070000,-0.070000,0.070000
04-23 20:41:18.729+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.739+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:736,0.001472,0.006581,-0.034471
04-23 20:41:18.739+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.739+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:733,0.040678,9.779467,0.777667
04-23 20:41:18.749+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.749+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:750,0.040085,9.772950,0.811305
04-23 20:41:18.749+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.759+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:746,-0.070000,0.070000,0.070000
04-23 20:41:18.759+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.759+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.759+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:763,-0.004007,0.011289,-0.043065
04-23 20:41:18.769+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:760,0.035892,9.784252,0.768096
04-23 20:41:18.779+0200 W/LOCATION(12407): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:41:18.799+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.799+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.809+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:808,0.040026,9.772956,0.811245
04-23 20:41:18.809+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:772,-0.070000,0.140000,0.070000
04-23 20:41:18.809+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.819+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:814,0.012557,0.004123,-0.024067
04-23 20:41:18.819+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:813,0.052642,9.777073,0.787239
04-23 20:41:18.819+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.829+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.829+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.839+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:832,0.040487,9.773206,0.808210
04-23 20:41:18.849+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:826,-0.070000,-0.070000,-0.070000
04-23 20:41:18.849+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.859+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.859+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:839,0.015009,0.018475,-0.067077
04-23 20:41:18.859+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.869+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:843,0.055035,9.791430,0.744168
04-23 20:41:18.869+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.869+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:878,0.052642,9.822537,0.806381
04-23 20:41:18.879+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:860,-0.070000,-0.070000,-0.070000
04-23 20:41:18.879+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:864,0.041053,9.773640,0.802910
04-23 20:41:18.879+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.889+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:874,0.012155,0.049332,-0.001829
04-23 20:41:18.889+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.889+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.899+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.909+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:893,-0.070000,-0.070000,0.070000
04-23 20:41:18.909+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.909+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:899,0.041750,9.773525,0.804266
04-23 20:41:18.919+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.919+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:910,0.026321,9.827322,0.756132
04-23 20:41:18.929+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:906,-0.014732,0.053682,-0.046778
04-23 20:41:18.929+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:41:18.929+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:41:18.929+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.929+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:932,0.041161,9.773574,0.803709
04-23 20:41:18.939+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:943,-0.015429,0.060976,-0.040956
04-23 20:41:18.939+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.959+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:923,-0.070000,-0.070000,0.070000
04-23 20:41:18.959+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.959+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.969+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:949,0.026321,9.834501,0.763310
04-23 20:41:18.969+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:18.969+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.979+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:964,-0.070000,-0.070000,0.070000
04-23 20:41:18.979+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:18.979+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:18:970,0.040600,9.773595,0.803481
04-23 20:41:18.989+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:18:977,0.016267,0.015464,0.007458
04-23 20:41:18.989+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:18:990,-0.070000,0.070000,0.070000
04-23 20:41:18.989+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:18.989+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:18.989+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:18:980,0.057428,9.789038,0.811167
04-23 20:41:18.999+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:19:3,-0.035815,0.029799,0.002900
04-23 20:41:19.009+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:19.009+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:19.009+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:19:0,0.041538,9.773434,0.805394
04-23 20:41:19.019+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:19:14,0.004786,9.803394,0.806381
04-23 20:41:19.019+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:19.019+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:19.019+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:19:19,0.070000,-0.140000,0.070000
04-23 20:41:19.029+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:19:33,0.032639,0.027568,-0.010977
04-23 20:41:19.029+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:19.029+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:19.059+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:19:45,0.074178,9.801002,0.794417
04-23 20:41:19.059+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:19:32,0.039955,9.773311,0.806964
04-23 20:41:19.059+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:19.059+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:19.069+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:19:47,-0.070000,-0.070000,0.070000
04-23 20:41:19.069+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:19.069+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:19.069+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:19:79,0.031107,9.805787,0.775275
04-23 20:41:19.079+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:19:71,0.041733,9.773289,0.807134
04-23 20:41:19.079+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:19:73,-0.008848,0.032476,-0.031690
04-23 20:41:19.079+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:19.079+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:19.089+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:19:93,0.041079,9.773530,0.804246
04-23 20:41:19.089+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:19:97,0.008516,0.037285,-0.017503
04-23 20:41:19.099+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:19.099+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:19:85,-0.070000,-0.070000,-0.070000
04-23 20:41:19.099+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:19.109+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:19.109+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:19.109+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:19:105,0.050249,9.810574,0.789631
04-23 20:41:19.129+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:19:123,-0.007579,0.032257,0.016493
04-23 20:41:19.129+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:19:109,-0.070000,0.070000,-0.070000
04-23 20:41:19.129+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:41:19.129+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:41:19.129+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:19.129+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:19.139+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:19:121,0.041354,9.773712,0.802015
04-23 20:41:19.139+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:19.139+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:19.149+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:19:140,0.033500,9.805787,0.820738
04-23 20:41:19.159+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:19:143,-0.070000,-0.070000,0.070000
04-23 20:41:19.159+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:19:153,0.041139,9.773522,0.804332
04-23 20:41:19.159+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:19.169+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:19.179+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:19.179+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:19:161,0.008896,0.032075,-0.000420
04-23 20:41:19.179+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:19.179+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:19:189,0.041730,9.773438,0.805337
04-23 20:41:19.189+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:19:173,0.050249,9.805787,0.801596
04-23 20:41:19.189+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:19:177,-0.070000,-0.140000,0.070000
04-23 20:41:19.199+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:19.199+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:19.209+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:19.209+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:19:193,0.021074,0.015515,0.023584
04-23 20:41:19.209+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:19:205,0.062213,9.789038,0.827917
04-23 20:41:19.219+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:19.229+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:19.229+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:19:208,-0.070000,-0.140000,0.070000
04-23 20:41:19.229+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:19.239+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:19:223,0.042855,9.773241,0.807651
04-23 20:41:19.239+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:19:228,-0.013016,0.020386,0.005830
04-23 20:41:19.239+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:19.239+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:19.249+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:19:238,0.028714,9.793823,0.811167
04-23 20:41:19.249+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:19:258,-0.016534,0.058867,0.003515
04-23 20:41:19.259+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:19:241,-0.070000,-0.070000,0.070000
04-23 20:41:19.259+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:19.269+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:19:273,0.026321,9.832108,0.811167
04-23 20:41:19.269+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:19.269+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:19:251,0.042343,9.773102,0.809367
04-23 20:41:19.269+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:19.279+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:19.279+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:19:289,0.041737,9.772975,0.810930
04-23 20:41:19.289+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:19:293,-0.023201,0.051827,-0.019735
04-23 20:41:19.289+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:19:277,-0.070000,-0.070000,0.070000
04-23 20:41:19.289+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:19.299+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:19.299+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:19.309+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:19.319+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:19:303,0.019143,9.824929,0.789631
04-23 20:41:19.319+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:19:311,-0.070000,0.070000,0.070000
04-23 20:41:19.329+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:19.329+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:41:19.329+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:41:19.329+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:19.329+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:19:316,0.040799,9.772889,0.812008
04-23 20:41:19.339+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:19:321,-0.020202,0.016063,0.000237
04-23 20:41:19.339+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:19.339+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:19.349+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:19:344,-0.070000,-0.140000,0.070000
04-23 20:41:19.349+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:19:338,0.021535,9.789038,0.811167
04-23 20:41:19.359+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:19.369+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:19:352,0.040053,9.772758,0.813613
04-23 20:41:19.369+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:19.369+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:19:375,0.059821,9.805787,0.827917
04-23 20:41:19.369+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:19:357,0.019021,0.032898,0.015909
04-23 20:41:19.379+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:19.379+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:19.389+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:19:385,0.041135,9.772594,0.815531
04-23 20:41:19.389+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:19.389+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:19:380,-0.070000,-0.070000,0.070000
04-23 20:41:19.399+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:19:403,0.026321,9.798609,0.832702
04-23 20:41:19.399+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:19:391,-0.013732,0.025850,0.019090
04-23 20:41:19.399+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:19.399+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:19.409+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:19.419+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:19.419+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:19:413,-0.070000,-0.070000,0.070000
04-23 20:41:19.429+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:19.429+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:19:432,0.011964,9.784252,0.837488
04-23 20:41:19.429+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:19:418,0.040595,9.772396,0.817930
04-23 20:41:19.439+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:19:420,-0.029171,0.011658,0.021957
04-23 20:41:19.439+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:19.439+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:19.449+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:19.459+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:19:444,-0.070000,-0.070000,0.070000
04-23 20:41:19.459+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:19:454,0.002476,0.081247,-0.021120
04-23 20:41:19.469+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:19.469+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:19:474,-0.070000,-0.070000,0.070000
04-23 20:41:19.469+0200 I/servicemanager(12059): es.ugr.frailty.location sleep timeout
04-23 20:41:19.469+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:41:19.469+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:41:19.469+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12059
04-23 20:41:19.489+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12407
04-23 20:41:19.489+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12407)
04-23 20:41:19.489+0200 I/servicemanager(12059): es.ugr.frailty.location stop request sent!
04-23 20:41:19.489+0200 I/servicemanager(12059): App control destroyed.
04-23 20:41:19.489+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:19:453,0.039410,9.772174,0.820645
04-23 20:41:19.489+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:19.489+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:19.489+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:19:466,0.043071,9.853643,0.796810
04-23 20:41:19.509+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:19.509+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:19:509,0.039730,9.772172,0.820652
04-23 20:41:19.509+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:19.509+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:19:505,0.006054,0.033613,-0.076477
04-23 20:41:19.519+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:19.529+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:19:517,0.045464,9.805787,0.744168
04-23 20:41:19.529+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:41:19.529+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:41:19.529+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:19.539+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:19:535,0.040170,9.772393,0.817989
04-23 20:41:19.539+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:19.539+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:19:524,-0.070000,-0.070000,0.070000
04-23 20:41:19.549+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:19.549+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:19:537,0.005733,0.036008,-0.007092
04-23 20:41:19.559+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:19.559+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:19.559+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:19:550,0.045464,9.808180,0.813560
04-23 20:41:19.559+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:19:561,-0.070000,-0.070000,-0.070000
04-23 20:41:19.569+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:19.569+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:19:566,0.040272,9.772560,0.815982
04-23 20:41:19.569+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:19:571,0.007686,0.050144,-0.023572
04-23 20:41:19.569+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:19.579+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:19.579+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:19.589+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:19:580,0.047856,9.822537,0.794417
04-23 20:41:19.599+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:19.599+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:19:583,-0.070000,0.070000,-0.070000
04-23 20:41:19.599+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:19.599+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:19:591,0.040470,9.772783,0.813300
04-23 20:41:19.599+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:19:608,0.019143,9.784252,0.796810
04-23 20:41:19.609+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:19:593,-0.021129,0.011692,-0.019172
04-23 20:41:19.609+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:19:612,-0.070000,0.070000,-0.070000
04-23 20:41:19.609+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:19.609+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:19.609+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:19:619,0.039297,9.772933,0.811553
04-23 20:41:19.619+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:19:623,-0.028506,0.001897,-0.006919
04-23 20:41:19.629+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:19.659+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:19.679+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:41:19.679+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:19.679+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:41:19.689+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:19.689+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:19.689+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:19:678,-0.070000,0.070000,-0.070000
04-23 20:41:19.699+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:19:675,0.011964,9.774680,0.806381
04-23 20:41:19.709+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:19.709+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:19.709+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:19:716,0.047856,9.844072,0.777667
04-23 20:41:19.719+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:19:699,0.037839,9.773044,0.810292
04-23 20:41:19.719+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:19:704,0.008559,0.071139,-0.033886
04-23 20:41:19.719+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:19.719+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:19.729+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:41:19.729+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:41:19.729+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:19:721,-0.070000,0.070000,-0.070000
04-23 20:41:19.739+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:19.739+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:19.749+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:19:756,-0.140000,0.070000,0.070000
04-23 20:41:19.749+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:19:732,0.038152,9.773325,0.806879
04-23 20:41:19.749+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:19:733,-0.045018,0.025565,0.005661
04-23 20:41:19.749+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:19.749+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:19.759+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:19:763,0.009704,0.044426,0.006680
04-23 20:41:19.759+0200 W/CRASH_MANAGER(12149): worker.c: worker_job(1205) > 11124076c6f63152450887
