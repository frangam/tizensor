S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 14282
Date: 2018-04-23 19:26:48+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf712652d, r5   = 0xf7410f98
r6   = 0xffdbfd90, r7   = 0xffdbfc40
r8   = 0xf740dc18, r9   = 0x00000000
r10  = 0xffdbfd1c, fp   = 0xffdbfd90
ip   = 0x00000001, sp   = 0xffdbfc18
lr   = 0xf7126539, pc   = 0xf718f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     18984 KB
Buffers:     51728 KB
Cached:     236408 KB
VmPeak:      53460 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12060 KB
VmRSS:       12056 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 14282 TID = 14282
14282 14322 

Maps Information
f3ff1000 f47f0000 rw-p [stack:14322]
f47f7000 f47f9000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4801000 f4805000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f480e000 f4810000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4818000 f481b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f482a000 f482f000 r-xp /usr/lib/libsystem.so.0.0.0
f483a000 f483d000 r-xp /lib/libattr.so.1.1.0
f4845000 f4855000 r-xp /usr/lib/libmdm-common.so.1.1.24
f485d000 f4866000 r-xp /usr/lib/libedbus.so.1.7.99
f486e000 f486f000 r-xp /usr/lib/libresponse.so.0.2.96
f4878000 f487d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f611f000 f6225000 r-xp /usr/lib/libicuuc.so.57.1
f623b000 f63c3000 r-xp /usr/lib/libicui18n.so.57.1
f63d3000 f63e0000 r-xp /usr/lib/libail.so.0.1.0
f63e9000 f63f0000 r-xp /usr/lib/libminizip.so.1.0.0
f63f9000 f65a2000 r-xp /usr/lib/libcrypto.so.1.0.0
f65c2000 f6609000 r-xp /usr/lib/libssl.so.1.0.0
f6615000 f6617000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f661f000 f6626000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f662f000 f6636000 r-xp /lib/libcrypt-2.13.so
f6667000 f666a000 r-xp /lib/libcap.so.2.21
f6672000 f6674000 r-xp /usr/lib/libiri.so
f667c000 f66c5000 r-xp /usr/lib/libmdm.so.1.2.69
f66cd000 f66d3000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f66db000 f66fe000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6708000 f670a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6712000 f672f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6738000 f673c000 r-xp /usr/lib/libsmack.so.1.0.0
f6745000 f675e000 r-xp /usr/lib/libnetwork.so.0.0.0
f6767000 f676f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6777000 f677d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6786000 f6788000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6791000 f67a1000 r-xp /lib/libresolv-2.13.so
f67a5000 f67bd000 r-xp /usr/lib/liblzma.so.5.0.3
f67c6000 f67c8000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f67d0000 f67ea000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f67f2000 f6821000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f682a000 f6839000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6843000 f684d000 r-xp /usr/lib/libsensord-shared.so
f6856000 f6929000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6934000 f694a000 r-xp /lib/libz.so.1.2.5
f6952000 f6957000 r-xp /usr/lib/libffi.so.5.0.10
f695f000 f6960000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6968000 f6978000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6980000 f6999000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f69a1000 f69a3000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f69ab000 f6a20000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a2a000 f6a30000 r-xp /lib/librt-2.13.so
f6a39000 f6a57000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a61000 f6a62000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a6a000 f6a8d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a95000 f6a9a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6aa2000 f6acc000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ad5000 f6aec000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6af4000 f6b5d000 r-xp /lib/libm-2.13.so
f6b66000 f6bfa000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c0d000 f6c12000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c1a000 f6c21000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c29000 f6c53000 r-xp /usr/lib/libsensor.so.1.9.6
f6c5c000 f6d28000 r-xp /usr/lib/libxml2.so.2.7.8
f6d35000 f6d37000 r-xp /usr/lib/libiniparser.so.0
f6d40000 f6d46000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d4f000 f6e1f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e20000 f6e54000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e5d000 f6e99000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6ea1000 f6ea4000 r-xp /usr/lib/libbundle.so.0.1.22
f6eac000 f6eb2000 r-xp /usr/lib/libappsvc.so.0.1.0
f6eba000 f6efb000 r-xp /usr/lib/libeina.so.1.7.99
f6f04000 f6f1b000 r-xp /usr/lib/libecore.so.1.7.99
f6f32000 f6f3b000 r-xp /usr/lib/libvconf.so.0.2.45
f6f43000 f6f57000 r-xp /lib/libpthread-2.13.so
f6f62000 f6f6f000 r-xp /usr/lib/libaul.so.0.1.0
f6f79000 f6f7b000 r-xp /lib/libdl-2.13.so
f6f84000 f6f8f000 r-xp /lib/libunwind.so.8.0.1
f6fbc000 f6fc4000 r-xp /lib/libgcc_s-4.6.so.1
f6fc5000 f70e9000 r-xp /lib/libc-2.13.so
f70f7000 f70f9000 r-xp /usr/lib/libdlog.so.0.0.0
f7101000 f710d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7116000 f711b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7123000 f7132000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f713a000 f713e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7147000 f714a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7152000 f7154000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f715c000 f7160000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7168000 f7185000 r-xp /lib/ld-2.13.so
f718e000 f7191000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7191000 f7195000 r-xp /usr/lib/libsys-assert.so
f73dd000 f744e000 rw-p [heap]
ffda1000 ffdc2000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14282)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf718f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7126539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e2d3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e2bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e37e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e3dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e3ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e7275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e6d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e2bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e37e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e3dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e3ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e6fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e70017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e77f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf480f1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4802171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf68d5663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d82fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d847a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f14ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f0fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f105a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f10879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7148183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71487fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf718f4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6fdc85c) [/lib/libc.so.6] + 0x1785c
29: (0xf718ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
.gravity
04-23 19:26:47.199+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:200,8.688338,1.067199,4.299902
04-23 19:26:47.199+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:204,8.698386,0.727957,4.469736
04-23 19:26:47.209+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.209+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.209+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.219+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:220,18.549999,-6.090000,-17.080000
04-23 19:26:47.219+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:221,0.171807,0.853699,-0.780004
04-23 19:26:47.219+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.219+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:220,8.870193,1.581656,3.689733
04-23 19:26:47.219+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:225,8.723988,0.808218,4.405588
04-23 19:26:47.229+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.229+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.229+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.239+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:240,0.337632,0.763867,-0.739783
04-23 19:26:47.239+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:240,-1.330000,-4.760000,-14.980000
04-23 19:26:47.239+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.239+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:240,9.061620,1.572084,3.665804
04-23 19:26:47.239+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:247,8.724223,0.868874,4.393560
04-23 19:26:47.249+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.249+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.249+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.259+0200 I/heartrate(14276): capturing data from es.ugr.frailty.heartrate
04-23 19:26:47.259+0200 I/heartrate(14276): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:26:47.259+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:260,-1.260000,-3.710000,-12.950000
04-23 19:26:47.259+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.259+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:260,0.145970,0.121755,-0.835433
04-23 19:26:47.259+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:267,8.722169,0.897289,4.391928
04-23 19:26:47.269+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:260,8.870193,0.990629,3.558127
04-23 19:26:47.269+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.269+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.269+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.279+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:280,9.800000,0.210000,-12.740000
04-23 19:26:47.279+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:280,0.124097,0.189052,-0.017848
04-23 19:26:47.279+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.289+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:279,8.846266,1.086342,4.374080
04-23 19:26:47.289+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:288,8.711682,0.932610,4.405362
04-23 19:26:47.289+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.289+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.289+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.299+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:300,8.050000,-2.170000,-12.810000
04-23 19:26:47.299+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.299+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:300,0.060406,0.646653,-0.538560
04-23 19:26:47.309+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:308,8.716443,0.990075,4.383349
04-23 19:26:47.309+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.309+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.319+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:318,0.352354,1.228071,-0.868293
04-23 19:26:47.319+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:299,8.772088,1.579263,3.866802
04-23 19:26:47.319+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.329+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:330,9.068797,2.218147,3.515057
04-23 19:26:47.329+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.329+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.329+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.339+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:340,0.271994,0.741477,-0.683340
04-23 19:26:47.339+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:319,-6.230000,-4.760000,-11.830000
04-23 19:26:47.339+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.339+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:339,8.997013,1.804188,3.665804
04-23 19:26:47.349+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:337,8.725019,1.062711,4.349144
04-23 19:26:47.349+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.349+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:349,-22.889999,-5.670000,-7.210000
04-23 19:26:47.349+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.349+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.359+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:359,0.257602,-0.078712,-0.792375
04-23 19:26:47.359+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.359+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:354,8.717876,1.095662,4.355288
04-23 19:26:47.359+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.359+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:366,-14.070000,-8.050000,-8.260000
04-23 19:26:47.359+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:358,8.975478,1.016950,3.562913
04-23 19:26:47.359+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:368,8.717319,1.097971,4.355822
04-23 19:26:47.369+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.369+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.379+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.379+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:380,0.100232,0.301831,-0.706768
04-23 19:26:47.379+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.379+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:383,8.727478,1.132730,4.326481
04-23 19:26:47.379+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:380,8.817552,1.399801,3.649055
04-23 19:26:47.379+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:386,4.200000,-2.730000,-9.730000
04-23 19:26:47.389+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.389+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.399+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:400,8.867801,1.732404,3.567699
04-23 19:26:47.399+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:400,0.140323,0.599674,-0.758783
04-23 19:26:47.399+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.399+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.399+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:405,8.729792,1.174924,4.310531
04-23 19:26:47.399+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:406,-6.930000,-2.450000,-9.870000
04-23 19:26:47.409+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.409+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.419+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:420,0.193045,0.624479,-0.929472
04-23 19:26:47.419+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.419+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.419+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:426,8.722438,1.201700,4.318029
04-23 19:26:47.419+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:427,-29.820000,-4.620000,-7.700000
04-23 19:26:47.419+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:420,8.922836,1.799403,3.381058
04-23 19:26:47.429+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.429+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.439+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:440,9.001799,1.464408,3.933800
04-23 19:26:47.439+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.449+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:449,0.279361,0.262707,-0.384229
04-23 19:26:47.449+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.449+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.449+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.459+0200 I/heartrate(14276): capturing data from es.ugr.frailty.heartrate
04-23 19:26:47.459+0200 I/heartrate(14276): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:26:47.469+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:460,0.146837,-0.221677,-0.192148
04-23 19:26:47.469+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:463,8.846266,0.976272,4.173083
04-23 19:26:47.479+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:440,-37.380001,-6.860000,-4.620000
04-23 19:26:47.479+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.479+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:457,8.699429,1.197949,4.365231
04-23 19:26:47.489+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.489+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.489+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.509+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:506,0.043256,-0.120102,-0.876418
04-23 19:26:47.519+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:492,-24.219999,-6.510000,-6.370000
04-23 19:26:47.519+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.519+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:503,8.676189,1.182515,4.415403
04-23 19:26:47.529+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:507,8.719445,1.062413,3.538985
04-23 19:26:47.529+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.529+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.529+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.539+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:538,8.678189,1.187573,4.410113
04-23 19:26:47.549+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:530,-8.960000,-3.990000,-8.260000
04-23 19:26:47.549+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:541,8.944371,1.198804,3.483950
04-23 19:26:47.549+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.549+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:540,0.266182,0.011232,-0.926163
04-23 19:26:47.549+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.559+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:559,9.016156,1.557728,3.744767
04-23 19:26:47.559+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.559+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.559+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:564,8.898908,1.811367,3.802195
04-23 19:26:47.559+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.559+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.569+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:569,8.827123,1.744368,3.613162
04-23 19:26:47.569+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:563,-4.200000,-6.790000,-7.350000
04-23 19:26:47.569+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.569+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:570,8.694261,1.199424,4.375113
04-23 19:26:47.569+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:574,-2.240000,-5.810000,-5.950000
04-23 19:26:47.569+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.569+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.569+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:571,0.321896,0.358304,-0.630345
04-23 19:26:47.569+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.579+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:580,8.973085,1.909473,3.424129
04-23 19:26:47.579+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.579+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:579,-10.080000,-6.440000,-2.800000
04-23 19:26:47.579+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.579+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:583,8.709291,1.224418,4.338138
04-23 19:26:47.579+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:584,0.189617,0.586949,-0.535943
04-23 19:26:47.589+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.589+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.589+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:26:47.589+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:26:47.589+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:26:47.599+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.599+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:589,-22.889999,-7.700000,-1.610000
04-23 19:26:47.599+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.599+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:604,9.164511,1.342373,3.546163
04-23 19:26:47.599+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:607,-29.610001,-9.800000,0.070000
04-23 19:26:47.599+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.609+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:612,-22.820000,-9.800000,1.400000
04-23 19:26:47.609+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.609+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.619+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:619,-16.590000,-2.380000,-0.490000
04-23 19:26:47.619+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:598,0.107500,0.494715,-0.696936
04-23 19:26:47.619+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.619+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:594,8.719623,1.249653,4.310098
04-23 19:26:47.619+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:620,9.032906,1.603191,3.749553
04-23 19:26:47.619+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.619+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:625,0.248555,0.646884,-0.872245
04-23 19:26:47.619+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.629+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:630,0.429252,0.066790,-0.724494
04-23 19:26:47.629+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.629+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:628,8.724530,1.262589,4.296374
04-23 19:26:47.629+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.629+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.629+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:634,0.284472,0.340907,-0.498025
04-23 19:26:47.629+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.639+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.639+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:643,-0.128109,0.657367,-0.560821
04-23 19:26:47.639+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:644,8.623734,1.926222,3.677768
04-23 19:26:47.639+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:640,-25.480000,-1.260000,1.540000
04-23 19:26:47.639+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:637,8.735259,1.275584,4.270658
04-23 19:26:47.649+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.649+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:654,8.748434,1.262284,4.247578
04-23 19:26:47.649+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.649+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.649+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.659+0200 I/heartrate(14276): capturing data from es.ugr.frailty.heartrate
04-23 19:26:47.659+0200 I/heartrate(14276): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:26:47.659+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:662,0.107831,0.752296,-0.920713
04-23 19:26:47.659+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:659,8.855836,2.036292,3.321238
04-23 19:26:47.659+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:658,8.751842,1.268855,4.238589
04-23 19:26:47.659+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.659+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.659+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:667,8.748005,1.283996,4.241951
04-23 19:26:47.659+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.669+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:668,-39.340000,-9.800000,3.710000
04-23 19:26:47.669+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:671,8.756653,1.291209,4.221871
04-23 19:26:47.669+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.669+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.669+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.679+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:679,0.261895,0.120556,-0.704422
04-23 19:26:47.679+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:680,9.018548,1.411765,3.517449
04-23 19:26:47.679+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.679+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:679,8.764071,1.255455,4.217257
04-23 19:26:47.679+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:687,-44.660000,-13.230000,8.890000
04-23 19:26:47.689+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.689+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.699+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:700,8.777181,1.229352,4.197639
04-23 19:26:47.699+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:701,0.369332,0.125203,-0.264314
04-23 19:26:47.699+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.699+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.699+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:705,9.133404,1.380659,3.952943
04-23 19:26:47.699+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:705,-24.219999,-10.710000,8.960000
04-23 19:26:47.709+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.709+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.719+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:720,8.809393,1.224901,4.130931
04-23 19:26:47.719+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:720,0.349045,0.510230,-0.328445
04-23 19:26:47.719+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.719+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.719+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:725,9.126225,1.739582,3.869194
04-23 19:26:47.719+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:725,-10.850000,-12.670000,10.640000
04-23 19:26:47.729+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.729+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.739+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:741,8.857206,1.226498,4.026908
04-23 19:26:47.739+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:741,0.398189,0.816177,-0.680481
04-23 19:26:47.739+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.739+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.739+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:746,9.207582,2.041078,3.450450
04-23 19:26:47.739+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:746,-14.770000,-17.710001,13.860000
04-23 19:26:47.749+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.749+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.759+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.759+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:761,0.288162,1.041898,-0.619529
04-23 19:26:47.759+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.769+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:760,8.891329,1.214429,3.954722
04-23 19:26:47.769+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:767,9.145369,2.268396,3.407379
04-23 19:26:47.769+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.769+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.779+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.779+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:770,-38.009998,-16.100000,20.090000
04-23 19:26:47.789+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:780,8.917590,1.147298,3.915442
04-23 19:26:47.789+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:780,0.014757,0.360048,-0.482736
04-23 19:26:47.789+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.789+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.789+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.799+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:788,8.906086,1.574477,3.471986
04-23 19:26:47.799+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.819+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:800,8.952892,1.056085,3.860154
04-23 19:26:47.819+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.819+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:797,-59.990002,-19.110001,28.770000
04-23 19:26:47.819+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:805,0.778127,-0.060956,-0.529598
04-23 19:26:47.829+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.829+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.829+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:812,9.695717,1.086342,3.385844
04-23 19:26:47.829+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.829+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:828,8.992540,0.962437,3.791874
04-23 19:26:47.829+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.839+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:835,10.025927,0.823131,3.058028
04-23 19:26:47.839+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.839+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:835,-61.810001,-26.320000,28.980000
04-23 19:26:47.839+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:835,1.073034,-0.232954,-0.802127
04-23 19:26:47.839+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.839+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.859+0200 I/heartrate(14276): capturing data from es.ugr.frailty.heartrate
04-23 19:26:47.859+0200 I/heartrate(14276): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:26:47.859+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:853,1.030994,-0.333124,-0.922880
04-23 19:26:47.859+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:854,-55.090000,-20.230000,28.980000
04-23 19:26:47.859+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.859+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.869+0200 W/LOCATION(14282): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:26:47.869+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:841,9.033615,0.875226,3.714587
04-23 19:26:47.879+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.879+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:872,0.748243,-0.415804,-0.594346
04-23 19:26:47.889+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:846,10.023535,0.629312,2.868994
04-23 19:26:47.889+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.889+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:873,-42.910000,-13.230000,27.230000
04-23 19:26:47.889+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:887,9.073600,0.790233,3.635342
04-23 19:26:47.889+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.889+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.889+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.899+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:894,9.781858,0.459422,3.120241
04-23 19:26:47.899+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.899+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:903,-29.750000,-6.860000,27.790001
04-23 19:26:47.899+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:904,9.750752,0.303888,3.036492
04-23 19:26:47.899+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.909+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:900,9.127491,0.706693,3.515661
04-23 19:26:47.909+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.909+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:901,0.677153,-0.486345,-0.598850
04-23 19:26:47.909+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.909+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.909+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:915,9.196192,0.608048,3.351226
04-23 19:26:47.909+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.919+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:909,10.047462,-0.016750,2.964707
04-23 19:26:47.919+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.919+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:921,9.272599,0.521593,3.149164
04-23 19:26:47.919+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:917,0.919971,-0.723443,-0.550954
04-23 19:26:47.919+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:924,10.124033,0.110070,2.713461
04-23 19:26:47.919+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:919,-18.760000,-12.460000,27.370001
04-23 19:26:47.929+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.929+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.929+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:934,0.927841,-0.497978,-0.637765
04-23 19:26:47.929+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:934,-11.270000,-16.870001,30.520000
04-23 19:26:47.929+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.929+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.939+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.939+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:939,9.354028,0.423486,2.914312
04-23 19:26:47.939+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:944,-5.320000,-12.110000,30.590000
04-23 19:26:47.939+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:940,9.413363,-0.212961,2.447858
04-23 19:26:47.939+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.949+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.949+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:951,5.810000,-5.810000,32.270000
04-23 19:26:47.949+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.949+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.959+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:959,9.459901,0.285809,2.568847
04-23 19:26:47.959+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:959,9.166903,-1.043271,3.354738
04-23 19:26:47.959+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:953,0.140764,-0.734554,-0.701307
04-23 19:26:47.959+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.959+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.959+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:966,-0.187124,-1.466756,0.440425
04-23 19:26:47.969+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:967,21.840000,5.110000,39.619999
04-23 19:26:47.969+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.969+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.979+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:979,9.555866,0.180929,2.196151
04-23 19:26:47.979+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.979+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:47:980,9.406186,-0.669990,3.361916
04-23 19:26:47.979+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:47.979+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:47:985,32.970001,-1.680000,34.860001
04-23 19:26:47.989+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:47:986,-0.053715,-0.955799,0.793069
04-23 19:26:47.989+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:47.989+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:47.999+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:47.999+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:47:999,9.679420,0.022332,1.574390
04-23 19:26:47.999+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:48:0,30.940001,-3.990000,36.470001
04-23 19:26:47.999+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:48:4,9.377472,-1.794617,2.790031
04-23 19:26:47.999+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:48.009+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:48:11,-0.178394,-1.975546,0.593881
04-23 19:26:48.009+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:48.009+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:48.009+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:48.009+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:48:18,9.777349,-0.120537,0.747856
04-23 19:26:48.019+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:48:19,60.340000,-2.450000,30.590000
04-23 19:26:48.019+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:48:21,9.475577,-1.830509,1.292124
04-23 19:26:48.019+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:48.029+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:48:30,-0.203843,-1.852841,-0.282266
04-23 19:26:48.029+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:48.029+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:48.029+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:48:39,9.800321,-0.217152,0.277381
04-23 19:26:48.039+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:48.039+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:48:43,9.518648,-1.677369,1.466800
04-23 19:26:48.039+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:48:39,120.889999,11.690000,26.950001
04-23 19:26:48.039+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:48.049+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:48:49,-0.258701,-1.556831,0.718944
04-23 19:26:48.049+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:48.049+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:48.049+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:48:58,9.801354,-0.296083,0.127181
04-23 19:26:48.049+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:48.059+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:48:59,154.979996,32.410000,20.299999
04-23 19:26:48.059+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:48.059+0200 I/heartrate(14276): capturing data from es.ugr.frailty.heartrate
04-23 19:26:48.059+0200 I/heartrate(14276): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:26:48.059+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:48:63,9.152546,-2.043471,1.617548
04-23 19:26:48.069+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:48:64,-0.647775,-1.826319,1.340167
04-23 19:26:48.069+0200 I/servicemanager(14243): es.ugr.frailty.location sleep timeout
04-23 19:26:48.069+0200 W/AUL     (14243): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 19:26:48.069+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:26:48.069+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14243
04-23 19:26:48.079+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:48.079+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:48:84,9.792084,-0.297508,0.443808
04-23 19:26:48.079+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14282
04-23 19:26:48.079+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:48.079+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:48.089+0200 W/AUL     (14243): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14282)
04-23 19:26:48.089+0200 I/servicemanager(14243): es.ugr.frailty.location stop request sent!
04-23 19:26:48.089+0200 I/servicemanager(14243): App control destroyed.
04-23 19:26:48.089+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:48:92,-0.584202,-0.534226,2.835133
04-23 19:26:48.089+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:48.089+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:48:89,130.410004,37.029999,9.870000
04-23 19:26:48.089+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:48.089+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:48.089+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:48:99,9.772437,-0.253800,0.778097
04-23 19:26:48.099+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:48:103,-1.101352,0.637289,3.387101
04-23 19:26:48.099+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:48:101,54.950001,36.119999,5.180000
04-23 19:26:48.099+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:48.109+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:48:110,9.217153,-0.830309,2.962314
04-23 19:26:48.109+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:48.109+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:48.109+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:48.109+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:48:118,9.771842,-0.247274,0.787616
04-23 19:26:48.109+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:48.119+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:48:122,-1.495664,0.397369,3.095882
04-23 19:26:48.119+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:48:119,-21.420000,17.010000,4.970000
04-23 19:26:48.119+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:48:115,8.690732,0.339781,3.830909
04-23 19:26:48.119+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:48.129+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:48:131,8.276773,0.143569,3.873980
04-23 19:26:48.129+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:48.129+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:48.129+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:48:139,9.797293,-0.292180,0.313167
04-23 19:26:48.129+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:48.139+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:48:143,-1.090682,-0.331789,2.169913
04-23 19:26:48.139+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:48:139,-63.910000,-0.070000,4.270000
04-23 19:26:48.139+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:48.139+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:48:148,8.681160,-0.579063,2.957529
04-23 19:26:48.159+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:48.159+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:48:169,-62.860001,2.380000,-0.210000
04-23 19:26:48.169+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:48.169+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:48:173,-0.419821,-0.205527,1.957622
04-23 19:26:48.169+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:48.169+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:48.169+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:48.179+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:48.189+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:48:183,-49.209999,23.940001,-7.420000
04-23 19:26:48.189+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:48:180,-0.071908,-0.724275,3.529435
04-23 19:26:48.189+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:48:177,9.377472,-0.497707,2.270789
04-23 19:26:48.189+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:48.189+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:48:198,9.722038,-1.038485,3.141776
04-23 19:26:48.199+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:48.199+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:48:203,-0.223346,-1.338382,5.927485
04-23 19:26:48.199+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:48.199+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:48:207,-33.740002,25.549999,-17.219999
04-23 19:26:48.199+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:48.209+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:48:211,9.497113,-1.651048,4.668397
04-23 19:26:48.209+0200 I/gravity (14300): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:48:183,9.793946,-0.314210,-0.387659
04-23 19:26:48.209+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:48.219+0200 I/gyroscope(14257): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:48.219+0200 I/gravity (14300): capturing data from es.ugr.frailty.gravity
04-23 19:26:48.219+0200 I/linearacceleration(14293): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:48:220,1.739683,-1.848269,-1.746935
04-23 19:26:48.219+0200 I/gyroscope(14257): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:48:223,-19.670000,12.320000,-24.430000
04-23 19:26:48.229+0200 I/accelerometer(14254): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:48.229+0200 I/accelerometer(14254): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:48:233,9.236296,-2.100898,4.570292
04-23 19:26:48.229+0200 I/linearacceleration(14293): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:48.239+0200 W/CRASH_MANAGER(14336): worker.c: worker_job(1205) > 11142826c6f63152450440
