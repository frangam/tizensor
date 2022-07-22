S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 19450
Date: 2018-04-23 19:40:53+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6fe052d, r5   = 0xf721df98
r6   = 0xff942b60, r7   = 0xff942a10
r8   = 0xf721ac18, r9   = 0x00000000
r10  = 0xff942aec, fp   = 0xff942b60
ip   = 0x00000001, sp   = 0xff9429e8
lr   = 0xf6fe0539, pc   = 0xf7049228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      7844 KB
Buffers:     55668 KB
Cached:     234640 KB
VmPeak:      52512 KB
VmSize:      52508 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11952 KB
VmRSS:       11952 KB
VmData:      10236 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 19450 TID = 19450
19450 19466 

Maps Information
f3eab000 f46aa000 rw-p [stack:19466]
f46b1000 f46b3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f46bb000 f46bf000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f46c8000 f46ca000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f46d2000 f46d5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f46e4000 f46e9000 r-xp /usr/lib/libsystem.so.0.0.0
f46f4000 f46f7000 r-xp /lib/libattr.so.1.1.0
f46ff000 f470f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4717000 f4720000 r-xp /usr/lib/libedbus.so.1.7.99
f4728000 f4729000 r-xp /usr/lib/libresponse.so.0.2.96
f4732000 f4737000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5fd9000 f60df000 r-xp /usr/lib/libicuuc.so.57.1
f60f5000 f627d000 r-xp /usr/lib/libicui18n.so.57.1
f628d000 f629a000 r-xp /usr/lib/libail.so.0.1.0
f62a3000 f62aa000 r-xp /usr/lib/libminizip.so.1.0.0
f62b3000 f645c000 r-xp /usr/lib/libcrypto.so.1.0.0
f647c000 f64c3000 r-xp /usr/lib/libssl.so.1.0.0
f64cf000 f64d1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f64d9000 f64e0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f64e9000 f64f0000 r-xp /lib/libcrypt-2.13.so
f6521000 f6524000 r-xp /lib/libcap.so.2.21
f652c000 f652e000 r-xp /usr/lib/libiri.so
f6536000 f657f000 r-xp /usr/lib/libmdm.so.1.2.69
f6587000 f658d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6595000 f65b8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f65c2000 f65c4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f65cc000 f65e9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f65f2000 f65f6000 r-xp /usr/lib/libsmack.so.1.0.0
f65ff000 f6618000 r-xp /usr/lib/libnetwork.so.0.0.0
f6621000 f6629000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6631000 f6637000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6640000 f6642000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f664b000 f665b000 r-xp /lib/libresolv-2.13.so
f665f000 f6677000 r-xp /usr/lib/liblzma.so.5.0.3
f6680000 f6682000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f668a000 f66a4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f66ac000 f66db000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f66e4000 f66f3000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f66fd000 f6707000 r-xp /usr/lib/libsensord-shared.so
f6710000 f67e3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f67ee000 f6804000 r-xp /lib/libz.so.1.2.5
f680c000 f6811000 r-xp /usr/lib/libffi.so.5.0.10
f6819000 f681a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6822000 f6832000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f683a000 f6853000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f685b000 f685d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6865000 f68da000 r-xp /usr/lib/libsqlite3.so.0.8.6
f68e4000 f68ea000 r-xp /lib/librt-2.13.so
f68f3000 f6911000 r-xp /usr/lib/libsystemd.so.0.4.0
f691b000 f691c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6924000 f6947000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f694f000 f6954000 r-xp /usr/lib/libxdgmime.so.1.1.0
f695c000 f6986000 r-xp /usr/lib/libdbus-1.so.3.8.12
f698f000 f69a6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f69ae000 f6a17000 r-xp /lib/libm-2.13.so
f6a20000 f6ab4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ac7000 f6acc000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ad4000 f6adb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ae3000 f6b0d000 r-xp /usr/lib/libsensor.so.1.9.6
f6b16000 f6be2000 r-xp /usr/lib/libxml2.so.2.7.8
f6bef000 f6bf1000 r-xp /usr/lib/libiniparser.so.0
f6bfa000 f6c00000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c09000 f6cd9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6cda000 f6d0e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d17000 f6d53000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6d5b000 f6d5e000 r-xp /usr/lib/libbundle.so.0.1.22
f6d66000 f6d6c000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d74000 f6db5000 r-xp /usr/lib/libeina.so.1.7.99
f6dbe000 f6dd5000 r-xp /usr/lib/libecore.so.1.7.99
f6dec000 f6df5000 r-xp /usr/lib/libvconf.so.0.2.45
f6dfd000 f6e11000 r-xp /lib/libpthread-2.13.so
f6e1c000 f6e29000 r-xp /usr/lib/libaul.so.0.1.0
f6e33000 f6e35000 r-xp /lib/libdl-2.13.so
f6e3e000 f6e49000 r-xp /lib/libunwind.so.8.0.1
f6e76000 f6e7e000 r-xp /lib/libgcc_s-4.6.so.1
f6e7f000 f6fa3000 r-xp /lib/libc-2.13.so
f6fb1000 f6fb3000 r-xp /usr/lib/libdlog.so.0.0.0
f6fbb000 f6fc7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6fd0000 f6fd5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6fdd000 f6fec000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f6ff4000 f6ff8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7001000 f7004000 r-xp /usr/lib/libappcore-agent.so.1.1
f700c000 f700e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7016000 f701a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7022000 f703f000 r-xp /lib/ld-2.13.so
f7048000 f704b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f704b000 f704f000 r-xp /usr/lib/libsys-assert.so
f71ea000 f7274000 rw-p [heap]
ff924000 ff945000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19450)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7049228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf6fe0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6ce73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6ce5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6cf1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6cf7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6cf7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6d2c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6d271f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6ce5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6cf1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6cf7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6cf7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6d29e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6d2a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6d31f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf46c91fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf46bc171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf678f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6c3cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6c3e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6dceca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6dc9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6dca5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6dca879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7002183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70027fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70494f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6e9685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7048f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
,30.380001,74.480003
04-23 19:40:52.759+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:52.759+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:52.759+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:52.759+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:52:766,-10.437491,-2.182254,3.823731
04-23 19:40:52.759+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:52:766,-1.555977,-0.221336,0.157141
04-23 19:40:52.759+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:52.769+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:52:765,-8.975494,-1.790758,3.521942
04-23 19:40:52.769+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:52:770,-6.300000,29.049999,73.709999
04-23 19:40:52.779+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:52.779+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:52.779+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:52.789+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:52:791,-10.985448,-1.959722,3.498307
04-23 19:40:52.789+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:52:791,-2.009953,-0.168964,-0.023636
04-23 19:40:52.789+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:52.789+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:52:791,-9.061555,-1.624647,3.379221
04-23 19:40:52.789+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:52:796,-10.710000,23.799999,72.800003
04-23 19:40:52.799+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:52.799+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:52.799+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:52.799+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:52:805,-10.772489,-1.921437,3.285345
04-23 19:40:52.799+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:52:806,-1.710934,-0.296790,-0.093876
04-23 19:40:52.799+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:52.799+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:52:805,-9.128278,-1.487502,3.260717
04-23 19:40:52.809+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:52:810,-22.120001,12.180000,68.949997
04-23 19:40:52.819+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:52.819+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:52.819+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:52.819+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:52:826,-9.927821,-1.734797,3.134598
04-23 19:40:52.819+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:52:827,-0.799543,-0.247295,-0.126119
04-23 19:40:52.829+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:52.829+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:52:832,-9.177965,-1.387372,3.163943
04-23 19:40:52.839+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:52:834,-35.910000,-0.210000,61.880001
04-23 19:40:52.839+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:52.839+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:52.839+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:52.839+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:52:845,-0.163614,-0.268461,-0.230342
04-23 19:40:52.839+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:52:845,-9.341579,-1.655833,2.933600
04-23 19:40:52.839+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:52.849+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:52:845,-9.208534,-1.331331,3.098521
04-23 19:40:52.849+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:52:853,-51.310001,-10.080000,52.779999
04-23 19:40:52.859+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:52.859+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:52.869+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:52:866,-9.008978,-1.799403,2.670390
04-23 19:40:52.869+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:52.869+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:52.869+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:52:866,0.199556,-0.468071,-0.428131
04-23 19:40:52.869+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:52:874,-9.219522,-1.333212,3.064859
04-23 19:40:52.879+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:52:875,-65.449997,-20.370001,41.790001
04-23 19:40:52.879+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:52.879+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:52.889+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:52:890,-8.764909,-1.952543,2.593820
04-23 19:40:52.889+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:52.889+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:52.889+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:52:891,0.454613,-0.619331,-0.471039
04-23 19:40:52.899+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:52:898,-9.219855,-1.368626,3.048199
04-23 19:40:52.899+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:52.899+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:52.899+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:52:906,-8.949157,-2.270789,2.742175
04-23 19:40:52.909+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:52:897,-72.730003,-24.219999,36.049999
04-23 19:40:52.909+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:52.909+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:52.909+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:52:907,0.270699,-0.902163,-0.306024
04-23 19:40:52.909+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:52:914,-9.211655,-1.434407,3.042742
04-23 19:40:52.919+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:52.919+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:52.929+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:52:917,-84.279999,-25.969999,33.670002
04-23 19:40:52.929+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:52:927,-9.564112,-2.483750,2.591427
04-23 19:40:52.929+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:52.929+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:52.929+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:52:927,-0.352457,-1.049343,-0.451315
04-23 19:40:52.939+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:52.939+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:52.949+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:52:937,-9.201712,-1.521486,3.030506
04-23 19:40:52.949+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:52.949+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:52:941,-101.500000,-28.559999,34.230000
04-23 19:40:52.949+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:52:946,-0.611254,-1.060370,-0.597005
04-23 19:40:52.949+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:52:947,-9.812965,-2.581856,2.433501
04-23 19:40:52.949+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:52.959+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:52.959+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:52.959+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:52:966,-9.360723,-2.828316,2.318645
04-23 19:40:52.969+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:52:966,-0.175545,-1.194033,-0.703275
04-23 19:40:52.969+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:52:954,-9.185178,-1.634283,3.021920
04-23 19:40:52.969+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:52.969+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:52:961,-123.340004,-36.400002,36.750000
04-23 19:40:52.969+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:52.969+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:52:975,-9.155055,-1.790604,3.024746
04-23 19:40:52.979+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:52:978,-144.550003,-44.799999,39.270000
04-23 19:40:52.979+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:52.979+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:52.989+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:52:991,0.289647,-1.437314,-0.859241
04-23 19:40:52.989+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:52:992,-8.865408,-3.227918,2.165504
04-23 19:40:52.989+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:52.989+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:52.989+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:52:997,-158.899994,-47.320000,40.670002
04-23 19:40:52.999+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:52:998,-9.112884,-1.992895,3.025575
04-23 19:40:52.999+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:52.999+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.009+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.009+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:13,-9.065389,-2.218882,3.010926
04-23 19:40:53.009+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:9,-168.210007,-47.040001,41.930000
04-23 19:40:53.019+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.019+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.029+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:27,-170.240005,-45.920002,42.700001
04-23 19:40:53.029+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:32,-9.012723,-2.465783,2.976764
04-23 19:40:53.039+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:18,0.398223,-1.376199,-1.049104
04-23 19:40:53.039+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.049+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.049+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:53,-8.714661,-3.369094,1.976472
04-23 19:40:53.049+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.049+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.059+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.069+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:61,-8.657232,-3.586841,1.732404
04-23 19:40:53.069+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:48,-167.649994,-44.099998,43.959999
04-23 19:40:53.069+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:64,-8.954857,-2.719101,2.930428
04-23 19:40:53.069+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.069+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:69,0.408156,-1.367959,-1.278522
04-23 19:40:53.079+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.079+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.079+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.089+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:94,0.585202,-1.245485,-1.282646
04-23 19:40:53.089+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:89,-8.892237,-2.969715,2.877378
04-23 19:40:53.099+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:82,-160.580002,-40.529999,45.570000
04-23 19:40:53.099+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:85,-8.427521,-3.711268,1.694118
04-23 19:40:53.099+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.099+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.099+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.109+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.109+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:114,-8.082954,-3.919443,1.811367
04-23 19:40:53.119+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.119+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:123,-7.860423,-4.007978,2.021935
04-23 19:40:53.119+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.119+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:110,-148.820007,-35.139999,47.599998
04-23 19:40:53.119+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:123,0.871902,-1.200342,-1.119061
04-23 19:40:53.119+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:118,-8.831757,-3.195141,2.821620
04-23 19:40:53.119+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:128,-7.752745,-4.086941,1.919044
04-23 19:40:53.119+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.129+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.129+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.129+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.129+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:133,-7.939385,-4.067799,1.852045
04-23 19:40:53.129+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:137,-8.778922,-3.395995,2.751024
04-23 19:40:53.129+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:137,1.031814,-1.038263,-0.855443
04-23 19:40:53.129+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.139+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:135,-135.380005,-27.650000,49.000000
04-23 19:40:53.139+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.139+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.139+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.139+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:147,-7.996813,-4.106083,1.852045
04-23 19:40:53.149+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:142,1.079011,-0.891800,-0.902576
04-23 19:40:53.149+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.149+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:154,0.839537,-0.671803,-0.898979
04-23 19:40:53.149+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.159+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:159,0.742248,-0.543893,-0.814416
04-23 19:40:53.159+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:149,-8.739060,-3.562191,2.666460
04-23 19:40:53.159+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.159+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.159+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:164,-8.711415,-3.693802,2.576327
04-23 19:40:53.159+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.159+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:167,-7.896315,-4.118048,1.897508
04-23 19:40:53.159+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.169+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:170,-8.691817,-3.798898,2.488187
04-23 19:40:53.169+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:151,-123.480003,-18.900000,50.680000
04-23 19:40:53.169+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.169+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:172,0.815100,-0.424246,-0.678818
04-23 19:40:53.169+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:177,-110.180000,-10.640000,53.200001
04-23 19:40:53.169+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.179+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:181,-99.680000,-4.900000,55.160000
04-23 19:40:53.179+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.179+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.179+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.189+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:190,-8.682799,-3.875289,2.400317
04-23 19:40:53.189+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.189+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:190,0.814645,-0.359827,-0.540429
04-23 19:40:53.189+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:191,-7.877172,-4.158726,1.947758
04-23 19:40:53.189+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:195,-88.550003,2.940000,57.049999
04-23 19:40:53.199+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.199+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.199+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:206,0.659665,-0.304972,-0.416667
04-23 19:40:53.209+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.209+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:207,-8.687079,-3.918444,2.313186
04-23 19:40:53.209+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.209+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:213,-8.023134,-4.180261,1.983650
04-23 19:40:53.209+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:215,-77.000000,10.500000,59.500000
04-23 19:40:53.219+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.219+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.219+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:225,0.441413,-0.324030,-0.257752
04-23 19:40:53.219+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.219+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:225,-8.704255,-3.929637,2.228065
04-23 19:40:53.219+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.229+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:230,-8.245667,-4.242475,2.055435
04-23 19:40:53.229+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:231,-67.199997,17.290001,62.860001
04-23 19:40:53.239+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.239+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.239+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.249+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:252,0.326983,-0.315231,0.028366
04-23 19:40:53.249+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:40:53.259+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:40:53.259+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:40:53.259+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.259+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.269+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:251,-8.735092,-3.904543,2.150141
04-23 19:40:53.269+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.269+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:264,-8.377272,-4.244867,2.256432
04-23 19:40:53.269+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.279+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:266,-0.044174,-0.364253,0.340788
04-23 19:40:53.279+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.279+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:247,-59.220001,24.080000,66.849998
04-23 19:40:53.279+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.279+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:277,-8.779249,-3.845375,2.075636
04-23 19:40:53.279+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.279+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:286,-0.356547,-0.397100,0.587575
04-23 19:40:53.289+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:280,-8.779266,-4.268795,2.490928
04-23 19:40:53.289+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.289+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:292,-54.110001,30.799999,70.000000
04-23 19:40:53.289+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:296,-9.135797,-4.242475,2.663212
04-23 19:40:53.289+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.289+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:293,-8.832492,-3.763101,1.999136
04-23 19:40:53.299+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.299+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.299+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:306,-0.458838,-0.572694,1.030178
04-23 19:40:53.299+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.309+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:302,-52.920002,37.799999,71.470001
04-23 19:40:53.309+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.309+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:311,-9.291330,-4.335794,3.029313
04-23 19:40:53.309+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:314,-52.570000,40.599998,70.559998
04-23 19:40:53.309+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:307,-8.886339,-3.670398,1.931721
04-23 19:40:53.319+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.319+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.319+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.319+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:327,-0.249457,-0.682146,1.470873
04-23 19:40:53.319+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.329+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:327,-9.135797,-4.352544,3.402594
04-23 19:40:53.329+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:333,-47.880001,43.049999,67.900002
04-23 19:40:53.329+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:330,-8.940733,-3.564387,1.878517
04-23 19:40:53.339+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.339+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.339+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.339+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:347,-0.051495,-1.013083,1.961963
04-23 19:40:53.349+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.349+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:347,-8.992228,-4.577469,3.840480
04-23 19:40:53.349+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:351,-8.997885,-3.451931,1.814562
04-23 19:40:53.349+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:353,-36.400002,45.709999,62.230000
04-23 19:40:53.359+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.359+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.369+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.369+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:367,-0.140305,-1.261930,2.315450
04-23 19:40:53.369+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.369+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:373,-9.062684,-3.308712,1.758002
04-23 19:40:53.369+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:368,-9.138189,-4.713861,4.130012
04-23 19:40:53.369+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:375,-18.690001,49.560001,55.160000
04-23 19:40:53.379+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.379+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.389+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:390,-0.173612,-1.354899,2.584971
04-23 19:40:53.389+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.389+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.399+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.399+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:406,0.061063,-1.345945,3.113235
04-23 19:40:53.419+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:391,-9.236296,-4.663611,4.342973
04-23 19:40:53.419+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.429+0200 W/LOCATION(19450): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:40:53.429+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:402,-9.137039,-3.123847,1.710695
04-23 19:40:53.439+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.439+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:435,-9.075976,-4.469792,4.823930
04-23 19:40:53.439+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.449+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:398,3.430000,51.730000,46.340000
04-23 19:40:53.449+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.449+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:445,-9.215016,-2.903124,1.680992
04-23 19:40:53.449+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:452,-9.030513,-4.247260,5.254639
04-23 19:40:53.449+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.449+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:456,26.320000,49.980000,36.049999
04-23 19:40:53.449+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.459+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.459+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.459+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:463,0.184504,-1.344136,3.573647
04-23 19:40:53.459+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:461,-9.290020,-2.663007,1.665627
04-23 19:40:53.469+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.469+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.469+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:474,0.003476,-1.490933,3.734973
04-23 19:40:53.469+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:474,-9.350898,-2.444880,1.659417
04-23 19:40:53.469+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.469+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:465,-9.286544,-4.153940,5.400600
04-23 19:40:53.469+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.479+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:480,-9.367901,-3.527020,5.173282
04-23 19:40:53.479+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.479+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:461,51.310001,47.740002,21.139999
04-23 19:40:53.479+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.479+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.489+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:486,-9.396507,-2.261059,1.662421
04-23 19:40:53.489+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.489+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:491,-9.133404,-2.933600,5.216353
04-23 19:40:53.499+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:487,64.050003,41.720001,9.870000
04-23 19:40:53.499+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:479,-0.017003,-1.082140,3.513865
04-23 19:40:53.499+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.499+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.509+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.509+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:500,-9.420521,-2.140865,1.685487
04-23 19:40:53.509+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.509+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:508,-9.133404,-2.806781,5.137390
04-23 19:40:53.509+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:513,68.879997,33.740002,0.070000
04-23 19:40:53.509+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.509+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:515,-9.430482,-2.069420,1.718692
04-23 19:40:53.519+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:508,0.263103,-0.672542,3.553932
04-23 19:40:53.519+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.519+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.519+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:526,-9.147761,-2.199004,5.044070
04-23 19:40:53.519+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.529+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:531,-9.417718,-2.044809,1.815414
04-23 19:40:53.529+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:524,0.287117,-0.665916,3.451903
04-23 19:40:53.529+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.529+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:522,62.299999,23.379999,-9.730000
04-23 19:40:53.539+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.539+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.539+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:546,-9.087940,-2.505285,5.065606
04-23 19:40:53.539+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.549+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:542,0.282721,-0.129584,3.325378
04-23 19:40:53.549+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.549+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:551,-9.380322,-2.100964,1.940592
04-23 19:40:53.559+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:543,58.099998,18.270000,-17.360001
04-23 19:40:53.559+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.559+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.559+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:558,0.329778,-0.460476,3.250191
04-23 19:40:53.559+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.559+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:566,-9.343972,-3.220739,5.371887
04-23 19:40:53.559+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.569+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:571,-9.323080,-2.234584,2.063296
04-23 19:40:53.569+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:564,43.889999,6.300000,-23.240000
04-23 19:40:53.569+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.579+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:569,0.036349,-1.119776,3.431295
04-23 19:40:53.579+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:580,27.370001,-6.930000,-29.260000
04-23 19:40:53.579+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.579+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.579+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.589+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:588,9.940000,-24.780001,-39.270000
04-23 19:40:53.589+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.589+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.589+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:592,-9.621540,-3.716053,5.233103
04-23 19:40:53.589+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:591,-0.298460,-1.481470,3.169807
04-23 19:40:53.599+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:597,5.530000,-38.290001,-50.400002
04-23 19:40:53.599+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:597,-9.243221,-2.417050,2.211585
04-23 19:40:53.599+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.599+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.599+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.599+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:606,-0.794670,-1.497607,2.442455
04-23 19:40:53.599+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.609+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:611,-9.141891,-2.639234,2.372901
04-23 19:40:53.609+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:607,1.120000,-49.630001,-64.820000
04-23 19:40:53.619+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.619+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.619+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:625,-1.336279,-1.629562,2.226104
04-23 19:40:53.619+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.619+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:610,-10.037891,-3.914658,4.654040
04-23 19:40:53.619+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.629+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:625,-9.012094,-2.897745,2.560394
04-23 19:40:53.629+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:630,-10.478169,-4.268795,4.599005
04-23 19:40:53.629+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:629,5.110000,-63.630001,-80.430000
04-23 19:40:53.639+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.639+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.639+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:645,-1.516324,-2.012327,2.143895
04-23 19:40:53.639+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.639+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:645,-8.848372,-3.186331,2.779209
04-23 19:40:53.649+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:650,-10.528419,-4.910072,4.704289
04-23 19:40:53.649+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.659+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:656,16.450001,-77.769997,-95.410004
04-23 19:40:53.659+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.659+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:666,4.900000,-89.110001,-111.650002
04-23 19:40:53.659+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.669+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.669+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.669+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:677,-1.840366,-2.061129,2.221790
04-23 19:40:53.669+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:677,-8.645301,-3.514878,3.012438
04-23 19:40:53.669+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:670,-10.688738,-5.247460,5.000999
04-23 19:40:53.679+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.679+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.679+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.689+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.689+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:690,-8.386903,-3.907906,3.249386
04-23 19:40:53.689+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:690,-2.201365,-2.232682,1.840206
04-23 19:40:53.689+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:692,-10.846665,-5.747560,4.852644
04-23 19:40:53.689+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:693,-20.160000,-107.239998,-130.759995
04-23 19:40:53.699+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.699+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.699+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:706,-8.082339,-4.314147,3.497758
04-23 19:40:53.699+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:706,-2.203731,-2.607749,1.289798
04-23 19:40:53.699+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.709+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:710,-10.590633,-6.515656,4.539185
04-23 19:40:53.709+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.709+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:714,-4.620000,-120.750000,-149.869995
04-23 19:40:53.719+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.719+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.719+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:725,-1.948373,-2.632217,1.345315
04-23 19:40:53.719+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.719+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:729,-10.030712,-6.946364,4.843073
04-23 19:40:53.719+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:725,-7.740781,-4.709757,3.750850
04-23 19:40:53.729+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.729+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:734,7.910000,-126.070000,-165.270004
04-23 19:40:53.739+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.739+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.739+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:745,-1.715654,-2.758242,1.874676
04-23 19:40:53.739+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.739+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:749,-9.456435,-7.467999,5.625526
04-23 19:40:53.749+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:745,-7.353292,-5.096206,4.015989
04-23 19:40:53.749+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.749+0200 I/servicemanager(18878): es.ugr.frailty.location sleep timeout
04-23 19:40:53.749+0200 W/AUL     (18878): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 19:40:53.749+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:40:53.749+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18878
04-23 19:40:53.759+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.759+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:765,-1.538437,-2.998713,2.054603
04-23 19:40:53.759+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19450
04-23 19:40:53.769+0200 W/AUL     (18878): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19450)
04-23 19:40:53.769+0200 I/servicemanager(18878): es.ugr.frailty.location stop request sent!
04-23 19:40:53.769+0200 I/servicemanager(18878): App control destroyed.
04-23 19:40:53.769+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.769+0200 I/gravity (19453): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:53:774,-6.938520,-5.453635,4.276118
04-23 19:40:53.769+0200 I/accelerometer(19411): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:53.779+0200 I/accelerometer(19411): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:53:778,-8.891729,-8.094919,6.070591
04-23 19:40:53.779+0200 I/gyroscope(19424): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:53:755,13.650000,-136.639999,-178.850006
04-23 19:40:53.779+0200 I/gyroscope(19424): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:53.779+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.789+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:790,-1.041543,-0.913666,0.739238
04-23 19:40:53.789+0200 I/gravity (19453): capturing data from es.ugr.frailty.gravity
04-23 19:40:53.799+0200 I/linearacceleration(19437): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:53.799+0200 I/linearacceleration(19437): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:53:808,-0.413650,-0.690661,-0.480693
04-23 19:40:53.809+0200 W/CRASH_MANAGER(18968): worker.c: worker_job(1205) > 11194506c6f63152450525
