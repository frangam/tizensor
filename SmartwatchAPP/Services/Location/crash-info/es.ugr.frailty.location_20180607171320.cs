S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 18150
Date: 2018-06-07 17:13:20+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf726452d, r5   = 0xf7669f98
r6   = 0xff9bffb0, r7   = 0xff9bfe60
r8   = 0xf7666c18, r9   = 0x00000000
r10  = 0xff9bff3c, fp   = 0xff9bffb0
ip   = 0x00000001, sp   = 0xff9bfe38
lr   = 0xf7264539, pc   = 0xf72cd228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    236764 KB
Buffers:     14792 KB
Cached:      85380 KB
VmPeak:      53568 KB
VmSize:      53564 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11492 KB
VmRSS:       11488 KB
VmData:      11292 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 18150 TID = 18150
18150 18155 

Maps Information
f412f000 f492e000 rw-p [stack:18155]
f4935000 f4937000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f493f000 f4943000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f494c000 f494e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4956000 f4959000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4968000 f496d000 r-xp /usr/lib/libsystem.so.0.0.0
f4978000 f497b000 r-xp /lib/libattr.so.1.1.0
f4983000 f4993000 r-xp /usr/lib/libmdm-common.so.1.1.24
f499b000 f49a4000 r-xp /usr/lib/libedbus.so.1.7.99
f49ac000 f49ad000 r-xp /usr/lib/libresponse.so.0.2.96
f49b6000 f49bb000 r-xp /usr/lib/libproc-stat.so.0.2.96
f625d000 f6363000 r-xp /usr/lib/libicuuc.so.57.1
f6379000 f6501000 r-xp /usr/lib/libicui18n.so.57.1
f6511000 f651e000 r-xp /usr/lib/libail.so.0.1.0
f6527000 f652e000 r-xp /usr/lib/libminizip.so.1.0.0
f6537000 f66e0000 r-xp /usr/lib/libcrypto.so.1.0.0
f6700000 f6747000 r-xp /usr/lib/libssl.so.1.0.0
f6753000 f6755000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f675d000 f6764000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f676d000 f6774000 r-xp /lib/libcrypt-2.13.so
f67a5000 f67a8000 r-xp /lib/libcap.so.2.21
f67b0000 f67b2000 r-xp /usr/lib/libiri.so
f67ba000 f6803000 r-xp /usr/lib/libmdm.so.1.2.69
f680b000 f6811000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6819000 f683c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6846000 f6848000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6850000 f686d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6876000 f687a000 r-xp /usr/lib/libsmack.so.1.0.0
f6883000 f689c000 r-xp /usr/lib/libnetwork.so.0.0.0
f68a5000 f68ad000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f68b5000 f68bb000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f68c4000 f68c6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f68cf000 f68df000 r-xp /lib/libresolv-2.13.so
f68e3000 f68fb000 r-xp /usr/lib/liblzma.so.5.0.3
f6904000 f6906000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f690e000 f6928000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6930000 f695f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6968000 f6977000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6981000 f698b000 r-xp /usr/lib/libsensord-shared.so
f6994000 f6a67000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a72000 f6a88000 r-xp /lib/libz.so.1.2.5
f6a90000 f6a95000 r-xp /usr/lib/libffi.so.5.0.10
f6a9d000 f6a9e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6aa6000 f6ab6000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6abe000 f6ad7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6adf000 f6ae1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ae9000 f6b5e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b68000 f6b6e000 r-xp /lib/librt-2.13.so
f6b77000 f6b95000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b9f000 f6ba0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ba8000 f6bcb000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6bd3000 f6bd8000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6be0000 f6c0a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c13000 f6c2a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c32000 f6c9b000 r-xp /lib/libm-2.13.so
f6ca4000 f6d38000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d4b000 f6d50000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d58000 f6d5f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d67000 f6d91000 r-xp /usr/lib/libsensor.so.1.9.6
f6d9a000 f6e66000 r-xp /usr/lib/libxml2.so.2.7.8
f6e73000 f6e75000 r-xp /usr/lib/libiniparser.so.0
f6e7e000 f6e84000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e8d000 f6f5d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f5e000 f6f92000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f9b000 f6fd7000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6fdf000 f6fe2000 r-xp /usr/lib/libbundle.so.0.1.22
f6fea000 f6ff0000 r-xp /usr/lib/libappsvc.so.0.1.0
f6ff8000 f7039000 r-xp /usr/lib/libeina.so.1.7.99
f7042000 f7059000 r-xp /usr/lib/libecore.so.1.7.99
f7070000 f7079000 r-xp /usr/lib/libvconf.so.0.2.45
f7081000 f7095000 r-xp /lib/libpthread-2.13.so
f70a0000 f70ad000 r-xp /usr/lib/libaul.so.0.1.0
f70b7000 f70b9000 r-xp /lib/libdl-2.13.so
f70c2000 f70cd000 r-xp /lib/libunwind.so.8.0.1
f70fa000 f7102000 r-xp /lib/libgcc_s-4.6.so.1
f7103000 f7227000 r-xp /lib/libc-2.13.so
f7235000 f7237000 r-xp /usr/lib/libdlog.so.0.0.0
f723f000 f724b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7254000 f7259000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7261000 f7270000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7278000 f727c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7285000 f7288000 r-xp /usr/lib/libappcore-agent.so.1.1
f7290000 f7292000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f729a000 f729e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f72a6000 f72c3000 r-xp /lib/ld-2.13.so
f72cc000 f72cf000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f72cf000 f72d3000 r-xp /usr/lib/libsys-assert.so
f7636000 f76c4000 rw-p [heap]
ff9a1000 ff9c2000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18150)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf72cd228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7264539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f6b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f69c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f75e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f7bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f7bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6fb075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6fab1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f69c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f75e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f7bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f7bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6fade5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6fae017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6fb5f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf494d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4940171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a13663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6ec0fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6ec27a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7052ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf704db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf704e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf704e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7286183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72867fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72cd5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf711a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf72ccf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
00
06-07 17:13:19.511+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:19:513,1.049457,9.494325,-2.219644
06-07 17:13:19.511+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:19:487,83.160004,801.780029,-212.520004
06-07 17:13:19.511+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:19.511+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:19.511+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:19.511+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:19:519,1.302668,9.508462,-2.015585
06-07 17:13:19.511+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:19.521+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:19:525,1.539933,9.478458,-1.989426
06-07 17:13:19.521+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:13:19.521+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:13:19.521+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:19.521+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:500,1.031307,5.625526,4.240082
06-07 17:13:19.531+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:19:522,-0.776755,-1.721775,-0.384832
06-07 17:13:19.531+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:19.531+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:19:530,1.523152,9.480140,-1.994326
06-07 17:13:19.531+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:19:526,128.029999,595.770020,-167.369995
06-07 17:13:19.531+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:19.531+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.541+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:19.541+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:19:545,-27.510000,331.730011,-124.180000
06-07 17:13:19.541+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:19:547,1.560280,9.540038,-1.650325
06-07 17:13:19.541+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:19.551+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:19:540,-1.081829,-0.019124,0.451333
06-07 17:13:19.551+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:19.551+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:551,1.751546,5.484349,9.384650
06-07 17:13:19.551+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:19.561+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.561+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:19:554,-98.419998,180.600006,-79.870003
06-07 17:13:19.561+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:19.561+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:19:561,2.861079,-0.443823,2.305815
06-07 17:13:19.571+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:567,0.851845,5.773881,6.532406
06-07 17:13:19.571+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.571+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:19.581+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:579,0.224925,4.417150,8.504091
06-07 17:13:19.581+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.581+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:19:572,-122.779999,259.350006,-69.019997
06-07 17:13:19.581+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:588,0.445065,1.349552,9.973285
06-07 17:13:19.581+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:19:560,1.593990,9.599231,-1.218337
06-07 17:13:19.581+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:19.581+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.591+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:594,1.028914,4.039084,11.318050
06-07 17:13:19.591+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:13:19.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:13:19.601+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:19.601+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:599,1.100698,4.993821,11.897114
06-07 17:13:19.601+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.601+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:610,1.655833,5.991628,6.872187
06-07 17:13:19.601+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.611+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:19:580,-0.214356,-1.768597,0.926810
06-07 17:13:19.611+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:19.611+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:19:596,1.706650,9.638901,-0.591033
06-07 17:13:19.611+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:615,2.093720,4.960321,9.384650
06-07 17:13:19.611+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.621+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:620,2.543570,3.558127,8.382057
06-07 17:13:19.621+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.621+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:19:606,-183.750000,226.660004,-68.180000
06-07 17:13:19.621+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:19.621+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:627,2.199004,2.914458,8.951550
06-07 17:13:19.621+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.621+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:19:619,-0.109360,-1.693842,-1.704594
06-07 17:13:19.631+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:632,3.845266,5.316852,14.636896
06-07 17:13:19.631+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:19.631+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.631+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:19.641+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:640,2.998207,6.340980,14.012369
06-07 17:13:19.641+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.641+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:19:628,1.795904,9.638974,0.187865
06-07 17:13:19.641+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:19:640,-170.309998,204.119995,-67.550003
06-07 17:13:19.641+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:648,2.699104,6.611369,8.573483
06-07 17:13:19.641+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.651+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:653,3.787838,4.010371,8.389235
06-07 17:13:19.651+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.651+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:19.651+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:657,2.907279,3.759124,6.195018
06-07 17:13:19.651+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:19.651+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.651+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:19:647,-1.423019,-2.430831,-0.783358
06-07 17:13:19.661+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:664,2.924029,5.637490,5.297709
06-07 17:13:19.661+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:19.661+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.661+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:19:658,1.783499,9.599517,0.915857
06-07 17:13:19.671+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:673,3.108276,5.733203,7.123433
06-07 17:13:19.671+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.671+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:19.671+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:19:666,-147.490005,259.769989,-89.529999
06-07 17:13:19.681+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:19.681+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:19:686,-114.169998,222.809998,-80.779999
06-07 17:13:19.681+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:19.681+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:19:690,-64.959999,121.309998,-75.669998
06-07 17:13:19.681+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:19.691+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:19:672,-0.969257,-0.857934,2.874816
06-07 17:13:19.671+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:678,2.711068,5.249853,6.250053
06-07 17:13:19.691+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:19.691+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.691+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:19:698,-1.045164,0.141708,1.165975
06-07 17:13:19.691+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:19.701+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:13:19.701+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:19:703,-2.105232,0.350391,1.339459
06-07 17:13:19.701+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:13:19:707,649.000000
06-07 17:13:19.701+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:19.711+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:19:694,-115.220001,87.849998,-61.529999
06-07 17:13:19.711+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:19:682,1.674069,9.493795,1.798814
06-07 17:13:19.711+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:19.711+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:19.711+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:19:717,-157.009995,40.040001,-38.290001
06-07 17:13:19.711+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:19:712,-2.809977,1.925590,0.381509
06-07 17:13:19.711+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:19.711+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:712,2.414358,4.345366,4.352544
06-07 17:13:19.721+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:19:724,-2.874075,2.722986,-1.417401
06-07 17:13:19.721+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.721+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:13:19.721+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:13:19.721+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:19.721+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:729,1.885544,4.646862,7.235896
06-07 17:13:19.731+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:19.731+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:19:718,1.489067,9.355585,2.534973
06-07 17:13:19.731+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:19:731,-133.910004,70.139999,-42.000000
06-07 17:13:19.731+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:19.731+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:19.741+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:19:736,-1.895718,3.321539,-0.188684
06-07 17:13:19.741+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:19.741+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:19:742,-143.990005,80.779999,-37.939999
06-07 17:13:19.751+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:19.751+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:19:750,-2.786946,4.302881,-0.415772
06-07 17:13:19.751+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:19.751+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:19:757,-128.309998,98.559998,-23.240000
06-07 17:13:19.761+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:19.771+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:19:762,-1.830383,3.282424,-2.929388
06-07 17:13:19.791+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.791+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:13:19.791+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:13:19.811+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:19.811+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:19:769,-61.670002,103.459999,-14.490000
06-07 17:13:19.821+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:19.831+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:19:820,-2.554674,3.183740,-3.559228
06-07 17:13:19.831+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:19.831+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:19:827,-25.549999,-5.110000,4.480000
06-07 17:13:19.841+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:830,2.888137,4.630112,9.174082
06-07 17:13:19.841+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.851+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:853,3.038885,2.854637,8.228917
06-07 17:13:19.851+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.851+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:19:741,1.275664,9.251663,2.991620
06-07 17:13:19.851+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:19.851+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:858,2.325824,3.893122,7.556533
06-07 17:13:19.851+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.861+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:19:839,-1.934024,3.812229,-0.911314
06-07 17:13:19.861+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:864,2.794817,4.658825,12.248858
06-07 17:13:19.861+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.871+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:19.871+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:874,0.847059,2.778067,8.262416
06-07 17:13:19.871+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.881+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:882,0.969093,1.799403,8.599805
06-07 17:13:19.881+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.881+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:19.881+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:889,0.495314,3.215954,9.573684
06-07 17:13:19.881+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.891+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:895,4.103691,2.323431,11.631511
06-07 17:13:19.891+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.901+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:13:19.901+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:13:19:907,642.000000
06-07 17:13:19.901+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:19:865,-180.039993,86.870003,-61.110001
06-07 17:13:19.901+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:19.911+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:900,0.827917,0.813560,10.329816
06-07 17:13:19.911+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.911+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:19:889,1.077719,9.069005,3.572403
06-07 17:13:19.911+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:918,0.512064,-0.112463,7.953743
06-07 17:13:19.921+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.921+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:13:19.921+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:13:19.921+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:926,-0.801596,-0.849452,8.874979
06-07 17:13:19.921+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:19:898,-4.676818,0.016020,1.256086
06-07 17:13:19.921+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.921+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:19.931+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:933,-0.579063,0.256032,12.610175
06-07 17:13:19.931+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.941+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:19.941+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:19:917,-184.800003,70.139999,-54.810001
06-07 17:13:19.941+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:943,-1.129412,0.600598,10.961520
06-07 17:13:19.941+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.941+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:951,-2.459821,0.497707,11.138590
06-07 17:13:19.951+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.951+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:956,-3.280560,1.986043,10.176675
06-07 17:13:19.951+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.951+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:19.951+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:19:948,0.313466,4.400696,3.083060
06-07 17:13:19.961+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:961,-3.579663,2.589034,8.362915
06-07 17:13:19.961+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.961+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:19:935,0.930325,8.836971,4.148834
06-07 17:13:19.971+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:973,-2.868994,2.995814,9.564112
06-07 17:13:19.971+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:19.971+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:19.971+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:19.991+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:19:981,-3.893122,3.847659,9.317651
06-07 17:13:19.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:13:19.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:13:20.011+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:19:984,0.706147,8.437578,4.947627
06-07 17:13:20.011+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.011+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:19:968,-130.550003,36.049999,-40.459999
06-07 17:13:20.021+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:20.021+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:20.031+0200 W/LOCATION(18150): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:13:20.031+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:17,0.489519,7.813278,5.906221
06-07 17:13:20.041+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.041+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:46,0.184415,6.775978,7.086783
06-07 17:13:20.051+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.051+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:19:994,-2.032312,-3.745384,3.711820
06-07 17:13:20.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:13:20.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:13:20.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:13:20.071+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:67,-0.127843,5.954695,7.790741
06-07 17:13:20.071+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.071+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:20:33,-2.840281,2.888137,6.817152
06-07 17:13:20.081+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:80,-0.185086,5.786533,7.915312
06-07 17:13:20.081+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.081+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:20.081+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:87,-0.465886,5.945627,7.784784
06-07 17:13:20.081+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.091+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:20:59,-96.180000,4.620000,-48.090000
06-07 17:13:20.091+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:93,-0.527775,8.742133,4.412137
06-07 17:13:20.091+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.091+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:20.091+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:99,-0.814141,8.247494,5.242748
06-07 17:13:20.101+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.101+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:107,-1.034829,7.733605,5.940611
06-07 17:13:20.101+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.101+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:13:20.111+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:114,-1.166140,6.837930,6.932043
06-07 17:13:20.111+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.111+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:13:20:115,617.000000
06-07 17:13:20.111+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:20.121+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:120,-1.053005,5.969532,7.708843
06-07 17:13:20.121+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.121+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:20:90,-1.862404,-2.727637,2.283396
06-07 17:13:20.121+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:13:20.121+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:128,-1.033150,5.274960,8.202304
06-07 17:13:20.121+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.121+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:13:20.131+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:133,-1.008980,4.763915,8.512195
06-07 17:13:20.131+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.141+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:142,-0.895074,4.196599,8.818038
06-07 17:13:20.141+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.141+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:20.141+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:148,-0.442606,3.470250,9.161432
06-07 17:13:20.141+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.151+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:20:122,-3.515057,2.797210,6.192625
06-07 17:13:20.151+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:155,0.476177,2.334250,9.512881
06-07 17:13:20.151+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.151+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:161,0.235418,2.518315,9.474864
06-07 17:13:20.161+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:20.161+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.161+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:20:126,-75.320000,-125.720001,-50.820000
06-07 17:13:20.161+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:20.161+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:167,0.909503,2.206874,9.511724
06-07 17:13:20.161+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.171+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:175,0.668509,2.610146,9.429243
06-07 17:13:20.171+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.181+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:20:153,-1.490971,-0.128763,0.764005
06-07 17:13:20.181+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:181,0.670183,2.471717,9.466353
06-07 17:13:20.181+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.181+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:20.181+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:188,0.730544,2.301100,9.504822
06-07 17:13:20.181+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.191+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:194,0.786537,2.026846,9.562616
06-07 17:13:20.191+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:13:20.191+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:13:20.191+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.201+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:201,0.714829,1.968380,9.580442
06-07 17:13:20.201+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.201+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:20:179,-41.790001,-150.220001,-58.380001
06-07 17:13:20.211+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:211,0.768234,1.690305,9.629282
06-07 17:13:20.211+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.211+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:20:174,-2.969493,3.402594,8.831908
06-07 17:13:20.211+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:217,0.815723,1.385032,9.674020
06-07 17:13:20.211+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:20.211+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.211+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:20.221+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:20:198,-0.962504,-0.273545,2.122874
06-07 17:13:20.221+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:223,0.843415,1.084745,9.709910
06-07 17:13:20.221+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.221+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:230,0.870862,0.716678,9.741579
06-07 17:13:20.221+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.231+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:234,0.888826,0.279285,9.762294
06-07 17:13:20.231+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.241+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:20.241+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:242,0.886426,-0.197015,9.764519
06-07 17:13:20.241+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.251+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:250,0.864895,-0.754051,9.739289
06-07 17:13:20.251+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.251+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:20:230,-5.668597,-0.375673,11.004591
06-07 17:13:20.251+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:257,0.816191,-1.317548,9.683402
06-07 17:13:20.251+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.261+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:264,0.668520,6.261813,7.517523
06-07 17:13:20.261+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.261+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:20:239,-26.460001,-128.869995,-47.529999
06-07 17:13:20.261+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:20.271+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:270,0.811252,5.495983,8.081239
06-07 17:13:20.271+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.271+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:278,0.915424,4.729068,8.542149
06-07 17:13:20.281+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.281+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:20.281+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:286,0.979464,4.085069,8.861335
06-07 17:13:20.281+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.291+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:20:252,3.121769,-0.133152,3.492471
06-07 17:13:20.291+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:20.291+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:292,1.022173,3.576689,9.073745
06-07 17:13:20.291+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.291+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:298,1.048826,3.172479,9.219854
06-07 17:13:20.291+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.301+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:304,1.067079,2.849054,9.322801
06-07 17:13:20.301+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:13:20.301+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.311+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:312,1.079131,2.581295,9.399084
06-07 17:13:20.311+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:13:20:312,610.000000
06-07 17:13:20.311+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.311+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:20:278,-0.605384,3.326023,12.787244
06-07 17:13:20.311+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:20:286,-35.139999,-98.980003,-11.480000
06-07 17:13:20.311+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:318,1.087794,2.359746,9.456145
06-07 17:13:20.321+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.321+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:13:20.321+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:326,1.093062,2.164149,9.502213
06-07 17:13:20.321+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:13:20.321+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.321+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:20.331+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:332,1.096171,2.001278,9.537488
06-07 17:13:20.331+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.341+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:20.341+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:343,1.098572,1.852017,9.567317
06-07 17:13:20.341+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.341+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:20:299,3.117270,2.413602,3.361245
06-07 17:13:20.351+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:350,1.099825,1.721576,9.591504
06-07 17:13:20.351+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.351+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:20.351+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:357,1.101705,1.601896,9.612000
06-07 17:13:20.351+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.361+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:20:341,-2.706282,2.770889,11.009377
06-07 17:13:20.361+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:362,1.102966,1.496313,9.628858
06-07 17:13:20.361+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.371+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:373,1.103803,1.397458,9.643605
06-07 17:13:20.371+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.381+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:383,1.105240,1.308141,9.655962
06-07 17:13:20.381+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.381+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:20:353,-39.689999,-133.350006,-17.710001
06-07 17:13:20.391+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:390,1.105293,1.228858,9.666366
06-07 17:13:20.391+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.391+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:20.391+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:13:20.391+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:13:20.411+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:20:367,5.025148,12.121447,6.268292
06-07 17:13:20.401+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:399,1.108079,1.151582,9.675557
06-07 17:13:20.401+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:20.411+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:20.411+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.421+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:421,1.109977,1.081916,9.683377
06-07 17:13:20.421+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.441+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:20:410,-2.567499,3.570091,9.767502
06-07 17:13:20.441+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:432,1.112060,1.017476,9.690122
06-07 17:13:20.441+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:20:419,-61.880001,-243.040009,-24.150000
06-07 17:13:20.441+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.441+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:20:417,4.496449,3.619673,5.512353
06-07 17:13:20.451+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:20.441+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:20.441+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:20.451+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:453,1.111618,0.958580,9.696176
06-07 17:13:20.461+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.471+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:468,1.115649,0.901168,9.701217
06-07 17:13:20.471+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.491+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:487,1.119667,0.848164,9.705532
06-07 17:13:20.491+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.491+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:20:462,-2.277967,5.915058,8.446664
06-07 17:13:20.501+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:13:20.501+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:500,1.127864,0.796752,9.708939
06-07 17:13:20.511+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.521+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:13:20:511,614.000000
06-07 17:13:20.521+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:518,1.134045,0.750156,9.711930
06-07 17:13:20.521+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:20.521+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:20:464,-123.270004,-429.170013,-56.630001
06-07 17:13:20.521+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:13:20.521+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:13:20.521+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.521+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:20:474,2.719717,-1.464681,-0.769010
06-07 17:13:20.531+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:20.541+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:533,1.146963,0.704624,9.713823
06-07 17:13:20.541+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:20.541+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.551+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:553,1.155313,0.664382,9.715670
06-07 17:13:20.551+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.561+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:561,1.177329,0.622374,9.715808
06-07 17:13:20.561+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.571+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:575,1.187640,0.587388,9.716731
06-07 17:13:20.581+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:20:535,-1.751546,5.508278,10.004392
06-07 17:13:20.561+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:20:550,21.350000,178.220001,-9.310000
06-07 17:13:20.581+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:20.581+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:20.581+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.581+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:20:552,0.270294,-0.937091,2.558058
06-07 17:13:20.581+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:20.591+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:590,1.202366,0.553848,9.716890
06-07 17:13:20.591+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:13:20.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:13:20.601+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:596,1.229620,0.520126,9.715343
06-07 17:13:20.601+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.611+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:20:595,84.070000,-310.380005,-28.280001
06-07 17:13:20.611+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:20:591,2.495714,5.527420,11.475977
06-07 17:13:20.611+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:20.611+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:608,1.268642,0.487305,9.712027
06-07 17:13:20.611+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.621+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:20:597,-3.600598,-5.534291,-3.001069
06-07 17:13:20.621+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:20.621+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:623,1.303239,0.458272,9.708858
06-07 17:13:20.621+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:20.621+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.631+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:634,1.357948,0.429187,9.702688
06-07 17:13:20.641+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.641+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:20:623,3.084348,5.927022,12.516854
06-07 17:13:20.651+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:650,1.405818,0.403091,9.696988
06-07 17:13:20.651+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.651+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:20.661+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:20:640,-0.714353,-5.157060,1.083426
06-07 17:13:20.661+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:661,1.470645,0.378058,9.688377
06-07 17:13:20.661+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:20:634,121.449997,37.590000,-34.860001
06-07 17:13:20.661+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.671+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:20.671+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:20.671+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:674,1.528972,0.355663,9.680193
06-07 17:13:20.681+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.681+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:692,1.636809,0.332203,9.663379
06-07 17:13:20.691+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.691+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:20:674,5.984450,14.531611,15.725630
06-07 17:13:20.701+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:696,1.738436,0.311061,9.646318
06-07 17:13:20.701+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.701+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:13:20.701+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:13:20:710,619.000000
06-07 17:13:20.711+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:706,1.930466,0.287870,9.610454
06-07 17:13:20.711+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.711+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:20.721+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:20:686,-5.530000,-1.680000,-5.180000
06-07 17:13:20.721+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:718,2.202813,0.265040,9.552369
06-07 17:13:20.721+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.741+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:732,2.591380,0.241477,9.454989
06-07 17:13:20.751+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.751+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:20:756,3.137472,0.214989,9.288726
06-07 17:13:20.761+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:20.761+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11181506c6f63152838440
