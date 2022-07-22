S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 5069
Date: 2018-04-23 18:58:48+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf73fa52d, r5   = 0xf7841958
r6   = 0xffb949d0, r7   = 0xffb94880
r8   = 0xf7854c18, r9   = 0x00000000
r10  = 0xffb9495c, fp   = 0xffb949d0
ip   = 0x00000001, sp   = 0xffb94858
lr   = 0xf73fa539, pc   = 0xf7463228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     71296 KB
Buffers:     35668 KB
Cached:     222836 KB
VmPeak:      53548 KB
VmSize:      53544 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12104 KB
VmRSS:       12104 KB
VmData:      11272 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 5069 TID = 5069
5069 5108 

Maps Information
f42c5000 f4ac4000 rw-p [stack:5108]
f4acb000 f4acd000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ad5000 f4ad9000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4ae2000 f4ae4000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4aec000 f4aef000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4afe000 f4b03000 r-xp /usr/lib/libsystem.so.0.0.0
f4b0e000 f4b11000 r-xp /lib/libattr.so.1.1.0
f4b19000 f4b29000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b31000 f4b3a000 r-xp /usr/lib/libedbus.so.1.7.99
f4b42000 f4b43000 r-xp /usr/lib/libresponse.so.0.2.96
f4b4c000 f4b51000 r-xp /usr/lib/libproc-stat.so.0.2.96
f63f3000 f64f9000 r-xp /usr/lib/libicuuc.so.57.1
f650f000 f6697000 r-xp /usr/lib/libicui18n.so.57.1
f66a7000 f66b4000 r-xp /usr/lib/libail.so.0.1.0
f66bd000 f66c4000 r-xp /usr/lib/libminizip.so.1.0.0
f66cd000 f6876000 r-xp /usr/lib/libcrypto.so.1.0.0
f6896000 f68dd000 r-xp /usr/lib/libssl.so.1.0.0
f68e9000 f68eb000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f68f3000 f68fa000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6903000 f690a000 r-xp /lib/libcrypt-2.13.so
f693b000 f693e000 r-xp /lib/libcap.so.2.21
f6946000 f6948000 r-xp /usr/lib/libiri.so
f6950000 f6999000 r-xp /usr/lib/libmdm.so.1.2.69
f69a1000 f69a7000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f69af000 f69d2000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f69dc000 f69de000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f69e6000 f6a03000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a0c000 f6a10000 r-xp /usr/lib/libsmack.so.1.0.0
f6a19000 f6a32000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a3b000 f6a43000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a4b000 f6a51000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a5a000 f6a5c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a65000 f6a75000 r-xp /lib/libresolv-2.13.so
f6a79000 f6a91000 r-xp /usr/lib/liblzma.so.5.0.3
f6a9a000 f6a9c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6aa4000 f6abe000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ac6000 f6af5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6afe000 f6b0d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b17000 f6b21000 r-xp /usr/lib/libsensord-shared.so
f6b2a000 f6bfd000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c08000 f6c1e000 r-xp /lib/libz.so.1.2.5
f6c26000 f6c2b000 r-xp /usr/lib/libffi.so.5.0.10
f6c33000 f6c34000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c3c000 f6c4c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c54000 f6c6d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c75000 f6c77000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c7f000 f6cf4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6cfe000 f6d04000 r-xp /lib/librt-2.13.so
f6d0d000 f6d2b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d35000 f6d36000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d3e000 f6d61000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d69000 f6d6e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d76000 f6da0000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6da9000 f6dc0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6dc8000 f6e31000 r-xp /lib/libm-2.13.so
f6e3a000 f6ece000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ee1000 f6ee6000 r-xp /usr/lib/libctx-client.so.0.8.3
f6eee000 f6ef5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6efd000 f6f27000 r-xp /usr/lib/libsensor.so.1.9.6
f6f30000 f6ffc000 r-xp /usr/lib/libxml2.so.2.7.8
f7009000 f700b000 r-xp /usr/lib/libiniparser.so.0
f7014000 f701a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7023000 f70f3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70f4000 f7128000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7131000 f716d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7175000 f7178000 r-xp /usr/lib/libbundle.so.0.1.22
f7180000 f7186000 r-xp /usr/lib/libappsvc.so.0.1.0
f718e000 f71cf000 r-xp /usr/lib/libeina.so.1.7.99
f71d8000 f71ef000 r-xp /usr/lib/libecore.so.1.7.99
f7206000 f720f000 r-xp /usr/lib/libvconf.so.0.2.45
f7217000 f722b000 r-xp /lib/libpthread-2.13.so
f7236000 f7243000 r-xp /usr/lib/libaul.so.0.1.0
f724d000 f724f000 r-xp /lib/libdl-2.13.so
f7258000 f7263000 r-xp /lib/libunwind.so.8.0.1
f7290000 f7298000 r-xp /lib/libgcc_s-4.6.so.1
f7299000 f73bd000 r-xp /lib/libc-2.13.so
f73cb000 f73cd000 r-xp /usr/lib/libdlog.so.0.0.0
f73d5000 f73e1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f73ea000 f73ef000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f73f7000 f7406000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f740e000 f7412000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f741b000 f741e000 r-xp /usr/lib/libappcore-agent.so.1.1
f7426000 f7428000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7430000 f7434000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f743c000 f7459000 r-xp /lib/ld-2.13.so
f7462000 f7465000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7465000 f7469000 r-xp /usr/lib/libsys-assert.so
f7824000 f78ad000 rw-p [heap]
ffb76000 ffb97000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5069)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7463228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf73fa539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71013f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf70ffc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf710be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7111be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7111dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf714675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71411f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf70ffc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf710be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7111be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7111dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7143e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7144017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf714bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4ae31fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4ad6171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ba9663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7056fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70587a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf71e8ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf71e3b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71e45a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf71e4879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf741c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf741c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74634f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf72b085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7462f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ion( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:47.609+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:47:610,0.067003,0.025605,0.014975
04-23 18:58:47.619+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:47.619+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:47.619+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:47:625,1.670190,-1.823331,9.592826
04-23 18:58:47.619+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:47:625,2.170000,0.560000,-0.070000
04-23 18:58:47.619+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:47.629+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:47:631,0.065644,0.045358,0.100523
04-23 18:58:47.639+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:47.639+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:47.639+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:47:645,1.643869,-1.763510,9.597611
04-23 18:58:47.639+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:47:645,0.910000,0.560000,0.350000
04-23 18:58:47.639+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:47.649+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:47:650,0.039963,0.096921,0.103579
04-23 18:58:47.659+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:47.659+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:47.669+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:47:670,1.670190,-1.892723,9.516255
04-23 18:58:47.669+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:47:670,0.910000,-0.070000,0.350000
04-23 18:58:47.669+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:47.679+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:47:677,0.067100,-0.040149,0.020548
04-23 18:58:47.679+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:47.679+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:47.679+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:47:686,1.646262,-1.952543,9.585647
04-23 18:58:47.689+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:47.689+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:47:686,0.910000,0.280000,0.560000
04-23 18:58:47.689+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:47:693,0.041061,-0.100061,0.090278
04-23 18:58:47.699+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:47.699+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:47.699+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:47:706,1.634298,-1.945365,9.585647
04-23 18:58:47.699+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:47:705,1.540000,0.490000,0.420000
04-23 18:58:47.709+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:47.709+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:47:713,0.029564,-0.091162,0.090535
04-23 18:58:47.719+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:47.719+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:47.729+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:47:726,1.703690,-1.899901,9.489935
04-23 18:58:47.729+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:47.729+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:47:732,1.050000,0.420000,0.280000
04-23 18:58:47.729+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:47:734,0.100854,-0.045976,-0.005551
04-23 18:58:47.739+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:47.739+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:47.739+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:47.739+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:47:745,1.686940,-1.825724,9.549755
04-23 18:58:47.749+0200 I/heartrate( 4929): capturing data from es.ugr.frailty.heartrate
04-23 18:58:47.749+0200 I/heartrate( 4929): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:58:47.759+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:47:745,0.081373,0.027698,0.054632
04-23 18:58:47.759+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:47:746,1.190000,0.560000,0.140000
04-23 18:58:47.759+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:47.769+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:47:772,0.018034,-0.010728,0.034719
04-23 18:58:47.769+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:47.789+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:47.819+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:47:801,1.050000,1.050000,0.070000
04-23 18:58:47.819+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:47.819+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:47.829+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:47:827,0.910000,0.840000,0.280000
04-23 18:58:47.829+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:47.839+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:47:781,1.624727,-1.859223,9.530612
04-23 18:58:47.839+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:47:831,0.020574,-0.011531,0.105453
04-23 18:58:47.839+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:47.839+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:47.849+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:47:849,0.039800,-0.074505,0.099637
04-23 18:58:47.849+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:47:841,0.560000,0.140000,0.280000
04-23 18:58:47.859+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:47.859+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:47:851,1.624727,-1.856830,9.602397
04-23 18:58:47.869+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:47.889+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:47.889+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:47:877,1.641476,-1.916651,9.597611
04-23 18:58:47.899+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:47:894,0.490000,0.210000,0.350000
04-23 18:58:47.899+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:47.899+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:47:871,0.073185,-0.128276,0.059223
04-23 18:58:47.899+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:47.899+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:47.899+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:47:906,0.770000,0.350000,0.280000
04-23 18:58:47.899+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:47.909+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:47:910,1.330000,1.260000,0.350000
04-23 18:58:47.909+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:47.919+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:47:909,1.674976,-1.971686,9.556933
04-23 18:58:47.919+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:47:908,0.059437,-0.114603,-0.001891
04-23 18:58:47.919+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:47.919+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:47.919+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:47:922,1.120000,1.050000,0.280000
04-23 18:58:47.919+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:47.929+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:47:927,1.663012,-1.962115,9.494720
04-23 18:58:47.929+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:47:927,0.010437,-0.049107,0.020476
04-23 18:58:47.929+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:47.929+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:47.929+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:47:937,0.016425,-0.041545,0.067334
04-23 18:58:47.939+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:47:931,1.050000,0.490000,0.280000
04-23 18:58:47.939+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:47.939+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:47:938,1.615155,-1.899901,9.516255
04-23 18:58:47.939+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:47:945,1.120000,0.420000,0.140000
04-23 18:58:47.939+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:47.939+0200 I/heartrate( 4929): capturing data from es.ugr.frailty.heartrate
04-23 18:58:47.939+0200 I/heartrate( 4929): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:58:47.949+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:47.949+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:47.949+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:47:953,1.617548,-1.890330,9.564112
04-23 18:58:47.959+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:47:950,0.098416,-0.108279,0.104695
04-23 18:58:47.959+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:47.959+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:47:957,1.260000,0.280000,0.210000
04-23 18:58:47.959+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:47.959+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:47.969+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:47:964,0.056182,0.007830,0.040595
04-23 18:58:47.969+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:47:966,1.696511,-1.954936,9.602397
04-23 18:58:47.969+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:47:970,1.120000,0.420000,0.210000
04-23 18:58:47.969+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:47.969+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:47.979+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:47.989+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:47:979,0.072522,-0.041181,0.047153
04-23 18:58:47.989+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:47:987,0.490000,0.420000,0.350000
04-23 18:58:47.989+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:47.999+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:47.999+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:5,0.350000,0.980000,0.210000
04-23 18:58:47.999+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:0,0.037843,-0.035474,0.087744
04-23 18:58:47.999+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.009+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:47:982,1.655833,-1.840081,9.537791
04-23 18:58:48.009+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.009+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:14,1.672583,-1.885544,9.544970
04-23 18:58:48.009+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.019+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:12,0.062643,-0.073282,0.046548
04-23 18:58:48.019+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.019+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:26,0.770000,0.630000,0.140000
04-23 18:58:48.019+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.029+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:25,0.097521,-0.064597,0.054190
04-23 18:58:48.029+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:22,1.639083,-1.878366,9.585647
04-23 18:58:48.029+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.029+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.039+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.039+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:38,1.663012,-1.914258,9.544970
04-23 18:58:48.039+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.039+0200 E/CAPI_TELEPHONY( 3701): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 18:58:48.049+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:50,1.698904,-1.907080,9.552148
04-23 18:58:48.049+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.049+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:44,0.840000,0.560000,0.210000
04-23 18:58:48.049+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:40,0.055291,-0.037670,0.056962
04-23 18:58:48.049+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:55,1.658226,-1.880759,9.554541
04-23 18:58:48.049+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.049+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.059+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:60,0.064821,-0.029206,0.099825
04-23 18:58:48.059+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:60,1.667797,-1.871187,9.597611
04-23 18:58:48.059+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.059+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.069+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:70,1.653440,-1.842474,9.571291
04-23 18:58:48.069+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:70,0.350000,0.070000,0.210000
04-23 18:58:48.069+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.069+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:74,0.050247,-0.002407,0.073170
04-23 18:58:48.079+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.079+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.079+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:87,0.700000,0.070000,0.350000
04-23 18:58:48.079+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:87,1.706082,-1.907080,9.583255
04-23 18:58:48.079+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.089+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:91,0.101661,-0.068328,0.085086
04-23 18:58:48.099+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.099+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.099+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:107,1.670190,-1.890330,9.463614
04-23 18:58:48.099+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:107,1.120000,0.490000,0.350000
04-23 18:58:48.099+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.109+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:111,0.062743,-0.050711,-0.033875
04-23 18:58:48.119+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.119+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.119+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:127,0.630000,0.770000,0.140000
04-23 18:58:48.129+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:127,1.648655,-1.919044,9.530612
04-23 18:58:48.129+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.139+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:135,0.040227,-0.079614,0.033252
04-23 18:58:48.139+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.139+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.139+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:146,1.658226,-1.890330,9.530612
04-23 18:58:48.149+0200 I/heartrate( 4929): capturing data from es.ugr.frailty.heartrate
04-23 18:58:48.149+0200 I/heartrate( 4929): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:58:48.149+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:147,0.700000,1.400000,0.140000
04-23 18:58:48.149+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.149+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:156,0.050481,-0.049737,0.033362
04-23 18:58:48.159+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.159+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.169+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:170,0.910000,0.980000,0.210000
04-23 18:58:48.169+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:170,1.634298,-1.878366,9.566505
04-23 18:58:48.169+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.179+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.179+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.179+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:186,0.910000,0.700000,0.490000
04-23 18:58:48.189+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:186,1.641476,-1.902294,9.592826
04-23 18:58:48.189+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:180,0.028102,-0.038841,0.068787
04-23 18:58:48.189+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.199+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:198,0.037444,-0.064547,0.094397
04-23 18:58:48.199+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.199+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.199+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:207,0.420000,0.490000,0.490000
04-23 18:58:48.209+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.209+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:207,1.679761,-1.861616,9.547362
04-23 18:58:48.209+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:214,0.077210,-0.024284,0.048603
04-23 18:58:48.219+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.219+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.219+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:226,0.630000,0.350000,0.280000
04-23 18:58:48.229+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.229+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:226,1.629512,-1.938186,9.516255
04-23 18:58:48.229+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:233,0.025379,-0.101486,0.017641
04-23 18:58:48.239+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.239+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.239+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:245,1.190000,0.910000,0.070000
04-23 18:58:48.249+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.249+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:245,1.672583,-1.873580,9.564112
04-23 18:58:48.249+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:253,0.068889,-0.034039,0.065973
04-23 18:58:48.259+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 18:58:48.259+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:58:48.259+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 18:58:48.259+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.259+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.269+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:271,1.646262,-1.840081,9.542577
04-23 18:58:48.269+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:271,1.190000,1.190000,-0.140000
04-23 18:58:48.269+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.279+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.279+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.289+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:287,1.653440,-1.840081,9.614362
04-23 18:58:48.289+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:280,0.042889,-0.003121,0.043884
04-23 18:58:48.299+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.299+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.299+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:306,1.646262,-1.885544,9.592826
04-23 18:58:48.309+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:303,0.051868,-0.007299,0.114558
04-23 18:58:48.309+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.319+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:318,0.046483,-0.056852,0.091932
04-23 18:58:48.319+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.319+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:326,1.646262,-1.938186,9.585647
04-23 18:58:48.329+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:288,1.050000,1.120000,0.210000
04-23 18:58:48.329+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.329+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:334,0.350000,0.420000,0.420000
04-23 18:58:48.329+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.339+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.339+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:345,1.686940,-1.923829,9.501899
04-23 18:58:48.339+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:339,0.046438,-0.108787,0.084897
04-23 18:58:48.339+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.349+0200 I/heartrate( 4929): capturing data from es.ugr.frailty.heartrate
04-23 18:58:48.349+0200 I/heartrate( 4929): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:58:48.349+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.349+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:353,0.700000,0.210000,0.350000
04-23 18:58:48.349+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.359+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:351,0.086910,-0.091842,0.001682
04-23 18:58:48.359+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:358,0.770000,0.350000,0.420000
04-23 18:58:48.359+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.369+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.369+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:374,0.070223,-0.075228,0.028832
04-23 18:58:48.369+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:370,1.672583,-1.909473,9.528220
04-23 18:58:48.369+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.379+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.379+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:386,1.679761,-1.928615,9.564112
04-23 18:58:48.379+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.389+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:390,0.076548,-0.093269,0.065081
04-23 18:58:48.389+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:381,0.700000,0.630000,0.420000
04-23 18:58:48.389+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.389+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:396,1.050000,0.840000,0.210000
04-23 18:58:48.399+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.399+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.399+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:405,1.636691,-1.842474,9.623933
04-23 18:58:48.399+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.409+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:409,0.033296,-0.006592,0.125035
04-23 18:58:48.409+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:410,0.980000,0.630000,0.350000
04-23 18:58:48.419+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.419+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.419+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:428,0.910000,0.630000,0.420000
04-23 18:58:48.429+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:428,1.627119,-1.921437,9.528220
04-23 18:58:48.429+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.429+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:434,0.025415,-0.088983,0.028376
04-23 18:58:48.439+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.439+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.439+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:446,1.470000,0.280000,0.560000
04-23 18:58:48.439+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.439+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:447,1.643869,-1.854438,9.623933
04-23 18:58:48.449+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:452,0.043546,-0.020646,0.124114
04-23 18:58:48.459+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.459+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.459+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.469+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:470,0.700000,0.280000,0.700000
04-23 18:58:48.479+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:470,1.660619,-1.899901,9.554541
04-23 18:58:48.479+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.479+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:470,0.061303,-0.069439,0.053910
04-23 18:58:48.479+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.489+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:486,0.280000,0.280000,0.770000
04-23 18:58:48.489+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.489+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:490,0.096310,-0.080265,0.035136
04-23 18:58:48.489+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:496,1.696511,-1.911865,9.535398
04-23 18:58:48.499+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.499+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.509+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:510,0.980000,0.420000,0.490000
04-23 18:58:48.509+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:509,0.055083,-0.115881,0.093575
04-23 18:58:48.509+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.519+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:519,1.658226,-1.950150,9.592826
04-23 18:58:48.519+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.519+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.529+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:528,0.980000,0.770000,0.210000
04-23 18:58:48.529+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.529+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:528,1.636691,-1.844866,9.552148
04-23 18:58:48.529+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:534,0.033748,-0.008542,0.053260
04-23 18:58:48.539+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.539+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.549+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:545,1.260000,0.350000,0.280000
04-23 18:58:48.549+0200 I/heartrate( 4929): capturing data from es.ugr.frailty.heartrate
04-23 18:58:48.549+0200 I/heartrate( 4929): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:58:48.549+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.549+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:546,1.624727,-1.842474,9.604790
04-23 18:58:48.549+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:554,0.023157,-0.009092,0.105102
04-23 18:58:48.559+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.559+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.559+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.569+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:571,0.910000,0.630000,0.210000
04-23 18:58:48.569+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:572,0.072656,-0.010123,0.049130
04-23 18:58:48.579+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:571,1.672583,-1.840081,9.549755
04-23 18:58:48.579+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.579+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.579+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.589+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:587,0.140000,0.560000,0.350000
04-23 18:58:48.589+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:587,1.643869,-1.866402,9.561719
04-23 18:58:48.589+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:588,0.043164,-0.039016,0.060730
04-23 18:58:48.599+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.599+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.609+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.609+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:607,0.083776,-0.086450,0.053644
04-23 18:58:48.609+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:606,0.420000,0.420000,0.420000
04-23 18:58:48.609+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:613,1.684547,-1.914258,9.554541
04-23 18:58:48.619+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.619+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.619+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.619+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:626,0.770000,1.050000,0.280000
04-23 18:58:48.629+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:626,1.689333,-1.921437,9.578469
04-23 18:58:48.629+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:627,0.086622,-0.091429,0.078323
04-23 18:58:48.639+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.639+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.639+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.649+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:647,1.120000,0.630000,0.350000
04-23 18:58:48.649+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:647,1.610370,-1.878366,9.552148
04-23 18:58:48.649+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:648,0.007345,-0.047654,0.052191
04-23 18:58:48.659+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.659+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.669+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.669+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:671,0.057710,-0.027301,0.053932
04-23 18:58:48.669+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:671,1.400000,0.350000,0.350000
04-23 18:58:48.679+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:677,1.658226,-1.856830,9.554541
04-23 18:58:48.679+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.689+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.709+0200 W/LOCATION( 5069): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 18:58:48.709+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:701,0.840000,0.280000,0.490000
04-23 18:58:48.709+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.719+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:719,0.350000,0.350000,0.280000
04-23 18:58:48.719+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:690,0.074313,-0.048898,0.058270
04-23 18:58:48.719+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.719+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.719+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:726,0.700000,0.560000,0.140000
04-23 18:58:48.719+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:727,1.674976,-1.875973,9.559326
04-23 18:58:48.719+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.729+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.729+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:733,0.056147,-0.108940,0.032146
04-23 18:58:48.729+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.729+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:738,0.040701,-0.047912,0.049772
04-23 18:58:48.739+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.739+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:732,1.658226,-1.935793,9.533006
04-23 18:58:48.739+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.739+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:745,1.120000,0.560000,0.210000
04-23 18:58:48.749+0200 I/heartrate( 4929): capturing data from es.ugr.frailty.heartrate
04-23 18:58:48.749+0200 I/heartrate( 4929): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:58:48.749+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.749+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:754,0.076975,-0.076952,0.016146
04-23 18:58:48.749+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:748,1.643869,-1.878366,9.549755
04-23 18:58:48.749+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.759+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:759,1.679761,-1.907080,9.516255
04-23 18:58:48.759+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.759+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.769+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:770,0.910000,0.910000,0.210000
04-23 18:58:48.769+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.769+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:777,1.696511,-1.871187,9.561719
04-23 18:58:48.769+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:771,0.092610,-0.040650,0.061876
04-23 18:58:48.779+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.779+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.779+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:786,0.560000,0.770000,0.210000
04-23 18:58:48.779+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:786,0.055757,-0.020732,0.013870
04-23 18:58:48.779+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.789+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:791,1.660619,-1.849652,9.513863
04-23 18:58:48.799+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.799+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.799+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:805,0.910000,0.840000,0.210000
04-23 18:58:48.799+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:806,0.019589,-0.115239,0.066331
04-23 18:58:48.799+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.809+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:811,1.624727,-1.942972,9.566505
04-23 18:58:48.819+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.819+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.819+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:826,1.050000,0.700000,0.210000
04-23 18:58:48.819+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:827,0.060195,-0.036799,0.066299
04-23 18:58:48.819+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.829+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:831,1.663012,-1.866402,9.566505
04-23 18:58:48.839+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.839+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.839+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:845,0.770000,0.490000,0.420000
04-23 18:58:48.839+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:846,0.067596,-0.091297,0.046762
04-23 18:58:48.839+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.849+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:850,1.670190,-1.919044,9.547362
04-23 18:58:48.859+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.859+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.869+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:870,0.840000,0.350000,0.350000
04-23 18:58:48.869+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:871,0.059610,-0.058503,0.049615
04-23 18:58:48.869+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.869+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:877,1.663012,-1.887937,9.549755
04-23 18:58:48.879+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.879+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.879+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:886,0.700000,0.770000,0.210000
04-23 18:58:48.879+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:886,0.116329,-0.072690,0.035411
04-23 18:58:48.879+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.889+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:892,1.720440,-1.902294,9.535398
04-23 18:58:48.899+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.899+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.899+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:905,0.490000,0.840000,0.210000
04-23 18:58:48.899+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:906,0.063407,-0.081607,0.047953
04-23 18:58:48.899+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.909+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:911,1.670190,-1.911865,9.547362
04-23 18:58:48.919+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.919+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.919+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:927,0.910000,0.770000,0.280000
04-23 18:58:48.929+0200 I/linearacceleration( 5081): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:58:48:928,0.072771,-0.044370,0.031496
04-23 18:58:48.929+0200 I/accelerometer( 5036): capturing data from es.ugr.frailty.accelerometer
04-23 18:58:48.929+0200 I/accelerometer( 5036): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:58:48:937,1.679761,-1.875973,9.530612
04-23 18:58:48.939+0200 I/gyroscope( 5049): capturing data from es.ugr.frailty.gyroscope
04-23 18:58:48.939+0200 I/linearacceleration( 5081): capturing data from es.ugr.frailty.linearacceleration
04-23 18:58:48.939+0200 I/gyroscope( 5049): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:58:48:945,1.120000,0.910000,0.420000
04-23 18:58:48.949+0200 I/heartrate( 4929): capturing data from es.ugr.frailty.heartrate
04-23 18:58:48.949+0200 I/heartrate( 4929): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:58:48.949+0200 W/CRASH_MANAGER( 4992): worker.c: worker_job(1205) > 11050696c6f63152450272
