S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 16218
Date: 2018-04-23 19:30:41+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf72d252d, r5   = 0xf739a958
r6   = 0xff8ddbe0, r7   = 0xff8dda90
r8   = 0xf73adc18, r9   = 0x00000000
r10  = 0xff8ddb6c, fp   = 0xff8ddbe0
ip   = 0x00000001, sp   = 0xff8dda68
lr   = 0xf72d2539, pc   = 0xf733b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     10276 KB
Buffers:     53632 KB
Cached:     234400 KB
VmPeak:      52508 KB
VmSize:      52504 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11852 KB
VmRSS:       11848 KB
VmData:      10232 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 16218 TID = 16218
16218 16247 

Maps Information
f419d000 f499c000 rw-p [stack:16247]
f49a3000 f49a5000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f49ad000 f49b1000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f49ba000 f49bc000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f49c4000 f49c7000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f49d6000 f49db000 r-xp /usr/lib/libsystem.so.0.0.0
f49e6000 f49e9000 r-xp /lib/libattr.so.1.1.0
f49f1000 f4a01000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4a09000 f4a12000 r-xp /usr/lib/libedbus.so.1.7.99
f4a1a000 f4a1b000 r-xp /usr/lib/libresponse.so.0.2.96
f4a24000 f4a29000 r-xp /usr/lib/libproc-stat.so.0.2.96
f62cb000 f63d1000 r-xp /usr/lib/libicuuc.so.57.1
f63e7000 f656f000 r-xp /usr/lib/libicui18n.so.57.1
f657f000 f658c000 r-xp /usr/lib/libail.so.0.1.0
f6595000 f659c000 r-xp /usr/lib/libminizip.so.1.0.0
f65a5000 f674e000 r-xp /usr/lib/libcrypto.so.1.0.0
f676e000 f67b5000 r-xp /usr/lib/libssl.so.1.0.0
f67c1000 f67c3000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f67cb000 f67d2000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f67db000 f67e2000 r-xp /lib/libcrypt-2.13.so
f6813000 f6816000 r-xp /lib/libcap.so.2.21
f681e000 f6820000 r-xp /usr/lib/libiri.so
f6828000 f6871000 r-xp /usr/lib/libmdm.so.1.2.69
f6879000 f687f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6887000 f68aa000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f68b4000 f68b6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f68be000 f68db000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f68e4000 f68e8000 r-xp /usr/lib/libsmack.so.1.0.0
f68f1000 f690a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6913000 f691b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6923000 f6929000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6932000 f6934000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f693d000 f694d000 r-xp /lib/libresolv-2.13.so
f6951000 f6969000 r-xp /usr/lib/liblzma.so.5.0.3
f6972000 f6974000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f697c000 f6996000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f699e000 f69cd000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f69d6000 f69e5000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f69ef000 f69f9000 r-xp /usr/lib/libsensord-shared.so
f6a02000 f6ad5000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ae0000 f6af6000 r-xp /lib/libz.so.1.2.5
f6afe000 f6b03000 r-xp /usr/lib/libffi.so.5.0.10
f6b0b000 f6b0c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b14000 f6b24000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b2c000 f6b45000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b4d000 f6b4f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b57000 f6bcc000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6bd6000 f6bdc000 r-xp /lib/librt-2.13.so
f6be5000 f6c03000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c0d000 f6c0e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c16000 f6c39000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c41000 f6c46000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c4e000 f6c78000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c81000 f6c98000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ca0000 f6d09000 r-xp /lib/libm-2.13.so
f6d12000 f6da6000 r-xp /usr/lib/libstdc++.so.6.0.16
f6db9000 f6dbe000 r-xp /usr/lib/libctx-client.so.0.8.3
f6dc6000 f6dcd000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6dd5000 f6dff000 r-xp /usr/lib/libsensor.so.1.9.6
f6e08000 f6ed4000 r-xp /usr/lib/libxml2.so.2.7.8
f6ee1000 f6ee3000 r-xp /usr/lib/libiniparser.so.0
f6eec000 f6ef2000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6efb000 f6fcb000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6fcc000 f7000000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7009000 f7045000 r-xp /usr/lib/libSLP-location.so.0.9.24
f704d000 f7050000 r-xp /usr/lib/libbundle.so.0.1.22
f7058000 f705e000 r-xp /usr/lib/libappsvc.so.0.1.0
f7066000 f70a7000 r-xp /usr/lib/libeina.so.1.7.99
f70b0000 f70c7000 r-xp /usr/lib/libecore.so.1.7.99
f70de000 f70e7000 r-xp /usr/lib/libvconf.so.0.2.45
f70ef000 f7103000 r-xp /lib/libpthread-2.13.so
f710e000 f711b000 r-xp /usr/lib/libaul.so.0.1.0
f7125000 f7127000 r-xp /lib/libdl-2.13.so
f7130000 f713b000 r-xp /lib/libunwind.so.8.0.1
f7168000 f7170000 r-xp /lib/libgcc_s-4.6.so.1
f7171000 f7295000 r-xp /lib/libc-2.13.so
f72a3000 f72a5000 r-xp /usr/lib/libdlog.so.0.0.0
f72ad000 f72b9000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f72c2000 f72c7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f72cf000 f72de000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f72e6000 f72ea000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f72f3000 f72f6000 r-xp /usr/lib/libappcore-agent.so.1.1
f72fe000 f7300000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7308000 f730c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7314000 f7331000 r-xp /lib/ld-2.13.so
f733a000 f733d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f733d000 f7341000 r-xp /usr/lib/libsys-assert.so
f737d000 f7406000 rw-p [heap]
ff8bf000 ff8e0000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16218)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf733b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf72d2539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6fd93f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6fd7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6fe3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6fe9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6fe9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf701e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70191f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6fd7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6fe3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6fe9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6fe9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf701be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf701c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7023f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49bb1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf49ae171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a81663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f2efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f307a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf70c0ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf70bbb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70bc5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf70bc879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf72f4183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72f47fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf733b4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf718885c) [/lib/libc.so.6] + 0x1785c
29: (0xf733af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:40:487,-1.330000,-1.750000,-0.560000
04-23 19:30:40.489+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.489+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:40.499+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:493,-0.135336,-0.053119,0.193426
04-23 19:30:40.499+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.499+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:40:492,3.113611,-1.680050,9.146214
04-23 19:30:40.499+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.499+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:40.499+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:40:499,3.048456,-1.727618,9.355937
04-23 19:30:40.509+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:40.509+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:40:512,3.109444,-1.683689,9.146963
04-23 19:30:40.509+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:508,-0.065155,-0.047568,0.209723
04-23 19:30:40.519+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:40:510,-0.770000,-1.820000,0.140000
04-23 19:30:40.519+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.519+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:40.519+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.529+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:40:522,3.089134,-1.770689,9.085547
04-23 19:30:40.529+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:40.539+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:40:525,-0.840000,-1.750000,1.050000
04-23 19:30:40.539+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.539+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:530,-0.020310,-0.087000,-0.061416
04-23 19:30:40.539+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:40:529,3.107821,-1.687234,9.146861
04-23 19:30:40.539+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:40.549+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.549+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:40:540,3.058028,-1.835295,9.004191
04-23 19:30:40.549+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:40:550,3.112638,-1.696494,9.143510
04-23 19:30:40.549+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:40.549+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:40:544,-1.470000,-2.170000,2.240000
04-23 19:30:40.549+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.559+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:40.559+0200 I/heartrate(16081): capturing data from es.ugr.frailty.heartrate
04-23 19:30:40.559+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:40:558,3.002992,-1.823331,9.068797
04-23 19:30:40.559+0200 I/heartrate(16081): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:30:40:564,78
04-23 19:30:40.569+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:40:564,3.117220,-1.710449,9.139348
04-23 19:30:40.569+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:553,-0.049794,-0.148061,-0.142670
04-23 19:30:40.569+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.569+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:40:560,-1.890000,-2.380000,3.220000
04-23 19:30:40.569+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:574,-0.109645,-0.126837,-0.074713
04-23 19:30:40.579+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:40.579+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.579+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:40:586,-2.660000,-2.030000,4.340000
04-23 19:30:40.579+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:40.579+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.589+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:40:586,3.127419,-1.725225,9.111869
04-23 19:30:40.589+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:591,0.010199,-0.014776,-0.027479
04-23 19:30:40.589+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:40.589+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:30:40.589+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:30:40.589+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:40:591,3.117853,-1.724703,9.136454
04-23 19:30:40.589+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.599+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:40.599+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:40:598,3.256632,-1.574477,9.133404
04-23 19:30:40.599+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:40:602,-1.750000,-1.400000,5.390000
04-23 19:30:40.599+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.599+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:40:606,3.120043,-1.731519,9.134416
04-23 19:30:40.599+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:607,0.138779,0.150226,-0.003050
04-23 19:30:40.619+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:40.639+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:40:644,3.213561,-1.529014,8.913264
04-23 19:30:40.649+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:40.659+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:40:661,3.266203,-1.639083,8.997013
04-23 19:30:40.659+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:40.669+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:40:672,3.309274,-1.813759,9.119047
04-23 19:30:40.669+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.669+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.669+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:677,0.093518,0.202506,-0.221151
04-23 19:30:40.679+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.679+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:40.679+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:40:686,3.282953,-1.933401,9.198010
04-23 19:30:40.689+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:40.689+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:40.719+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:40:726,3.127536,-1.734002,9.131382
04-23 19:30:40.719+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:40:698,3.268596,-1.897508,9.329616
04-23 19:30:40.729+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:40.729+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:684,0.138667,0.094919,-0.134369
04-23 19:30:40.729+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:40:680,-3.500000,-0.350000,6.510000
04-23 19:30:40.729+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:40:735,3.136991,-1.495514,9.018548
04-23 19:30:40.729+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:40.729+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.739+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:40:740,3.046063,-1.292124,8.542377
04-23 19:30:40.739+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.739+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:40.739+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:40:744,3.137498,-1.741372,9.126561
04-23 19:30:40.739+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:40.739+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:40:744,-6.720000,1.470000,6.720000
04-23 19:30:40.739+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:741,0.171776,-0.072388,-0.007514
04-23 19:30:40.739+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.749+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:40:749,3.150541,-1.755773,9.119306
04-23 19:30:40.749+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:40.749+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.749+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:40:754,3.167036,-1.775769,9.109715
04-23 19:30:40.749+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:40.749+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:40:756,-8.820000,2.240000,5.250000
04-23 19:30:40.749+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:752,0.132411,-0.177627,0.078705
04-23 19:30:40.749+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:40:759,3.448057,-1.019342,8.315059
04-23 19:30:40.759+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.759+0200 I/heartrate(16081): capturing data from es.ugr.frailty.heartrate
04-23 19:30:40.759+0200 I/heartrate(16081): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:30:40:763,78
04-23 19:30:40.759+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:40.759+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.759+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:40:769,3.181035,-1.793718,9.101317
04-23 19:30:40.769+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:40.769+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:764,0.101560,-0.121739,0.219900
04-23 19:30:40.769+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:40:774,3.191105,-1.800678,9.096416
04-23 19:30:40.769+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:40.769+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.769+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:40:773,-9.380000,1.890000,1.400000
04-23 19:30:40.769+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:40:778,3.209158,-1.796327,9.090924
04-23 19:30:40.769+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:40.769+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.779+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:40.779+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:40:781,3.235547,-1.791739,9.082472
04-23 19:30:40.779+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:40.779+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:40:786,3.404987,-1.323231,8.372486
04-23 19:30:40.779+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:40:787,3.291632,-1.787266,9.063179
04-23 19:30:40.779+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:778,-0.044044,0.298203,-0.082769
04-23 19:30:40.779+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:40:783,-6.860000,0.700000,-1.820000
04-23 19:30:40.789+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.789+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.789+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:40.789+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:40.789+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:30:40.789+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:30:40.799+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:40:798,3.356338,-1.808679,9.035157
04-23 19:30:40.799+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:40:793,-3.290000,-0.630000,-4.480000
04-23 19:30:40.799+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.799+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:40:798,3.151347,-1.418944,8.494520
04-23 19:30:40.799+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:40:804,-6.300000,-1.190000,-6.930000
04-23 19:30:40.799+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.799+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:793,-0.145042,0.508554,-0.554039
04-23 19:30:40.799+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.799+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:40:808,-9.660000,-0.770000,-7.350000
04-23 19:30:40.799+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.809+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:810,0.238899,0.776984,-0.775866
04-23 19:30:40.809+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.809+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:40:812,-16.730000,0.910000,-7.980000
04-23 19:30:40.809+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.809+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:40.809+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:40.809+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:40:816,-23.240000,0.210000,-10.640000
04-23 19:30:40.809+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.819+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:40:821,-27.790001,-4.480000,-17.360001
04-23 19:30:40.819+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:40:821,3.428215,-1.839875,9.001810
04-23 19:30:40.819+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:40:818,3.268596,-1.421337,8.429914
04-23 19:30:40.819+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:815,0.169440,0.468508,-0.709986
04-23 19:30:40.819+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.819+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:828,-0.140285,0.368322,-0.568659
04-23 19:30:40.819+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.829+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:832,-0.087742,0.387342,-0.605244
04-23 19:30:40.829+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.829+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:40.829+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.829+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:40:838,-30.660000,-10.220000,-23.660000
04-23 19:30:40.829+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:40.839+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:40:842,3.526098,-1.873472,8.956960
04-23 19:30:40.839+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:838,-0.018443,0.215148,-0.447470
04-23 19:30:40.839+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:40:839,3.409772,-1.624727,8.554340
04-23 19:30:40.849+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.849+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.859+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:40:859,-29.469999,-16.730000,-31.010000
04-23 19:30:40.859+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:40.859+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:40.859+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:859,-0.118718,0.375565,-0.271013
04-23 19:30:40.859+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:40:865,3.407379,-1.497907,8.685946
04-23 19:30:40.869+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:40:865,3.641396,-1.909139,8.903134
04-23 19:30:40.879+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.879+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.879+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:886,-0.312980,0.236556,-0.480399
04-23 19:30:40.879+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:40.889+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:40:886,-33.950001,-22.610001,-38.709999
04-23 19:30:40.889+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:40.899+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.899+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.909+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:40:906,-36.119999,-28.630001,-49.279999
04-23 19:30:40.909+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.919+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:40:896,3.328416,-1.672583,8.422735
04-23 19:30:40.929+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:40:893,3.779103,-1.940381,8.838760
04-23 19:30:40.929+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:907,-0.079800,0.052444,-0.942445
04-23 19:30:40.929+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.939+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:40.939+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:40.949+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:40:947,3.937805,-1.978211,8.760751
04-23 19:30:40.949+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:945,0.108458,0.327164,-1.149182
04-23 19:30:40.949+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:40.949+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.959+0200 I/heartrate(16081): capturing data from es.ugr.frailty.heartrate
04-23 19:30:40.959+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:40:921,-43.400002,-33.599998,-60.200001
04-23 19:30:40.959+0200 I/heartrate(16081): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:30:40:964,79
04-23 19:30:40.969+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.969+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:40:958,4.150181,-2.030887,8.649964
04-23 19:30:40.969+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:959,-0.491555,-0.515076,-0.045374
04-23 19:30:40.969+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:40.969+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.969+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:40:947,3.699304,-1.887937,7.896315
04-23 19:30:40.969+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:40.979+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:40:973,-57.540001,-32.480000,-69.720001
04-23 19:30:40.979+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.979+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:979,-0.882189,-0.921174,1.233811
04-23 19:30:40.979+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:40:978,4.409209,-2.086604,8.507370
04-23 19:30:40.979+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:40.979+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.979+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:40:980,4.046263,-1.651048,7.611568
04-23 19:30:40.979+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:40.989+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:40:991,4.623536,-2.135963,8.380392
04-23 19:30:40.989+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:40.989+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:40:993,-1.247263,-0.276002,1.430182
04-23 19:30:40.989+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:30:40.989+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:30:40.999+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:40:988,-45.849998,-39.619999,-82.739998
04-23 19:30:40.999+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.999+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:40.999+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:41:5,-29.540001,-53.480000,-93.239998
04-23 19:30:40.999+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:40.999+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:40:993,3.658626,-2.545963,8.604590
04-23 19:30:40.999+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:40.999+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:41:3,4.861619,-2.140925,8.243269
04-23 19:30:40.999+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:41:6,-0.432505,0.358272,0.698709
04-23 19:30:41.009+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:41.009+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:41.009+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:41:11,3.527020,-3.007778,9.741181
04-23 19:30:41.009+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:41.019+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:41:10,-22.750000,-66.849998,-99.610001
04-23 19:30:41.019+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:41:19,-0.224329,0.305225,-0.139571
04-23 19:30:41.019+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:41.019+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:41:14,5.069795,-2.121377,8.122027
04-23 19:30:41.019+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:41.019+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:41:25,-16.309999,-68.879997,-101.919998
04-23 19:30:41.019+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:41:26,5.350563,-2.050333,7.958518
04-23 19:30:41.019+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:41:19,3.376273,-2.411965,9.810574
04-23 19:30:41.019+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:41.029+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:41.029+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:41.029+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:41:31,4.429115,-1.782653,8.941978
04-23 19:30:41.029+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:41.049+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:41:38,-0.806592,0.143254,-0.741765
04-23 19:30:41.049+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:41.059+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:41:60,-1.310040,0.692965,-0.629123
04-23 19:30:41.059+0200 W/LOCATION(16218): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:30:41.069+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:41:39,5.664978,-1.965947,7.759734
04-23 19:30:41.069+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:41.069+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:41.069+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:41:77,5.984352,-1.869699,7.540699
04-23 19:30:41.069+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:41:78,4.845466,-1.816152,7.982457
04-23 19:30:41.069+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:41.079+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:41:41,-12.110000,-71.120003,-106.610001
04-23 19:30:41.079+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:41.079+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:41.079+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:41:86,6.310481,-1.738495,7.302455
04-23 19:30:41.079+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:41:87,-0.722535,-0.066094,0.740860
04-23 19:30:41.079+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:41.089+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:41:82,4.543970,-1.907080,7.216753
04-23 19:30:41.089+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:41.089+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:41:90,-3.710000,-73.570000,-104.860001
04-23 19:30:41.089+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:41.089+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:41.089+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:41.089+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:41:98,6.636643,-1.623440,7.034898
04-23 19:30:41.099+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:41:98,-0.622741,0.092233,1.292563
04-23 19:30:41.099+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:41:96,1.120000,-74.690002,-106.260002
04-23 19:30:41.099+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:41.099+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:41:95,4.354938,-1.272982,7.130611
04-23 19:30:41.099+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:41.109+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:41.109+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:41.109+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:41:118,7.016222,-1.485103,6.688608
04-23 19:30:41.109+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:41:119,-0.573230,0.639990,0.461815
04-23 19:30:41.119+0200 I/servicemanager(16054): es.ugr.frailty.location sleep timeout
04-23 19:30:41.119+0200 W/AUL     (16054): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 19:30:41.119+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:30:41.119+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:41:112,5.261817,-1.935793,8.281559
04-23 19:30:41.119+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 16054
04-23 19:30:41.119+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:41.119+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:41:125,5.687739,-1.646262,8.595018
04-23 19:30:41.119+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:41.129+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16218
04-23 19:30:41.129+0200 W/AUL     (16054): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16218)
04-23 19:30:41.129+0200 I/servicemanager(16054): es.ugr.frailty.location stop request sent!
04-23 19:30:41.129+0200 I/servicemanager(16054): App control destroyed.
04-23 19:30:41.129+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:41:110,-11.480000,-81.129997,-114.449997
04-23 19:30:41.129+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:41.129+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:41.129+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:41.129+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:41:138,7.438303,-1.288477,6.259541
04-23 19:30:41.139+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:41:140,-1.077236,0.896469,-0.850121
04-23 19:30:41.139+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:41:129,6.063413,-0.983450,7.496714
04-23 19:30:41.139+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:41.139+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:41:137,-25.830000,-95.340004,-121.379997
04-23 19:30:41.139+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:41.139+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:41:147,-20.580000,-106.330002,-123.340004
04-23 19:30:41.139+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:41:146,5.938986,-0.588634,5.838487
04-23 19:30:41.149+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:41.149+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:41.149+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:41:159,7.857811,-1.039125,5.774548
04-23 19:30:41.149+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:41:159,-1.585459,0.374419,-1.564823
04-23 19:30:41.159+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:41.159+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:41.159+0200 I/heartrate(16081): capturing data from es.ugr.frailty.heartrate
04-23 19:30:41.169+0200 I/heartrate(16081): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:30:41:164,79
04-23 19:30:41.169+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:41:163,15.050000,-115.080002,-117.809998
04-23 19:30:41.169+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:41:174,5.852845,-0.914058,4.694718
04-23 19:30:41.179+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:41.179+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:41.179+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:41.179+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:41:187,-1.366084,0.512704,-0.893190
04-23 19:30:41.179+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:41.179+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:41:185,47.740002,-119.629997,-105.980003
04-23 19:30:41.189+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:41:186,8.231581,-0.780488,5.272788
04-23 19:30:41.189+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:41:191,6.491727,-0.526421,4.881358
04-23 19:30:41.189+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:41.189+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:41.189+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:41.189+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:41:198,18.129999,-119.770004,-93.029999
04-23 19:30:41.189+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:30:41.189+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:30:41.199+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:41:198,8.565715,-0.552082,4.742796
04-23 19:30:41.199+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:41:199,-1.038756,2.465035,-0.448858
04-23 19:30:41.199+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:41.209+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:41:209,7.192825,1.684547,4.823930
04-23 19:30:41.209+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:41.209+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:41.209+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:41:218,-54.040001,-112.629997,-79.940002
04-23 19:30:41.209+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:41.209+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:41:219,-1.083358,1.777207,0.703268
04-23 19:30:41.219+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:41.219+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:41:222,8.861254,-0.335874,4.187572
04-23 19:30:41.219+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:41:224,7.482357,1.225125,5.446064
04-23 19:30:41.229+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:41.229+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:41.229+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:41:237,-85.190002,-108.080002,-68.879997
04-23 19:30:41.229+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:41.239+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:41:240,-1.855069,-0.192940,1.320706
04-23 19:30:41.239+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:41.239+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:41:242,9.083057,-0.144705,3.694253
04-23 19:30:41.239+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:41:245,7.006185,-0.528814,5.508278
04-23 19:30:41.249+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:41.249+0200 W/WATCH_CORE( 2849): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 2
04-23 19:30:41.249+0200 I/WATCH_CORE( 2849): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
04-23 19:30:41.249+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:30:41.249+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:30:41.259+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:41:259,-1.734699,-1.190490,0.713326
04-23 19:30:41.259+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:41.259+0200 W/WATCH_CORE( 2849): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
04-23 19:30:41.269+0200 W/W_HOME  ( 2773): dbus.c: _dbus_message_recv_cb(204) > LCD off
04-23 19:30:41.269+0200 W/W_HOME  ( 2773): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 19:30:41.269+0200 W/W_HOME  ( 2773): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-23 19:30:41.269+0200 W/W_HOME  ( 2773): gesture.c: _manual_render_enable(138) > 1
04-23 19:30:41.269+0200 W/W_HOME  ( 2773): event_manager.c: _lcd_off_cb(729) > lcd state: 0
04-23 19:30:41.269+0200 W/W_HOME  ( 2773): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 19:30:41.269+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [gesture]
04-23 19:30:41.269+0200 W/STARTER ( 2701): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-23 19:30:41.269+0200 E/STARTER ( 2701): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
04-23 19:30:41.269+0200 E/STARTER ( 2701): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
04-23 19:30:41.269+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
04-23 19:30:41.269+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
04-23 19:30:41.269+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:41:265,9.217460,-0.040668,3.347711
04-23 19:30:41.269+0200 W/WAKEUP-SERVICE( 3256): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -145052916[0;m
04-23 19:30:41.269+0200 W/WAKEUP-SERVICE( 3256): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-23 19:30:41.269+0200 W/WAKEUP-SERVICE( 3256): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-23 19:30:41.269+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:41.269+0200 E/WAKEUP-SERVICE( 3256): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 19:30:41.269+0200 E/WAKEUP-SERVICE( 3256): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 19:30:41.269+0200 E/WAKEUP-SERVICE( 3256): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 19:30:41.269+0200 I/TIZEN_N_SOUND_MANAGER( 3256): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-23 19:30:41.279+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:41:280,-30.240000,-113.750000,-56.420002
04-23 19:30:41.279+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:41.279+0200 I/TDM     ( 1956): tdm_display.c: tdm_layer_unset_buffer(1602) > [2301.565592] layer(0x8fd2c0) now usable
04-23 19:30:41.279+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [2301.565620] layer[0x8fce10]zpos[1]
04-23 19:30:41.279+0200 I/TDM     ( 1956): tdm_display.c: tdm_layer_unset_buffer(1602) > [2301.565643] layer(0x8fd310) now usable
04-23 19:30:41.279+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [2301.565654] layer[0x8fcf30]zpos[2]
04-23 19:30:41.279+0200 I/TDM     ( 1956): tdm_display.c: tdm_layer_unset_buffer(1602) > [2301.565678] layer(0x8fd250) now usable
04-23 19:30:41.279+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [2301.565688] layer[0x8fccf0]zpos[0]
04-23 19:30:41.279+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [2301.565775] dpms[0 -> 3]sync[1]
04-23 19:30:41.279+0200 I/TDM     ( 1956): 
04-23 19:30:41.279+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:41.289+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:41.289+0200 I/TIZEN_N_SOUND_MANAGER( 3256): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-23 19:30:41.289+0200 W/TIZEN_N_SOUND_MANAGER( 3256): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 19:30:41.289+0200 W/WAKEUP-SERVICE( 3256): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-23 19:30:41.289+0200 I/HIGEAR  ( 3256): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-23 19:30:41.289+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:41.299+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:41:290,9.331963,0.049534,3.013703
04-23 19:30:41.309+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:41:294,13.720000,-109.900002,-40.040001
04-23 19:30:41.309+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:41:287,-1.275682,-0.421147,-0.629464
04-23 19:30:41.309+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:41:299,7.348359,-1.335195,4.407579
04-23 19:30:41.309+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:41.309+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:41.319+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:41:323,-9.380000,-90.160004,-24.570000
04-23 19:30:41.319+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:41.329+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:30:41.329+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:30:41.329+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:30:41.339+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:41.349+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:41:322,-0.071739,0.390745,0.460675
04-23 19:30:41.349+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:41.369+0200 I/heartrate(16081): capturing data from es.ugr.frailty.heartrate
04-23 19:30:41.369+0200 I/heartrate(16081): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:30:41:375,79
04-23 19:30:41.379+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:41.379+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:41:385,-60.830002,-69.860001,-9.030000
04-23 19:30:41.379+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:41.389+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:41:390,-75.040001,-59.080002,3.430000
04-23 19:30:41.389+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:41.389+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:30:41.389+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:30:41.389+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:41:327,9.419198,0.113222,2.726952
04-23 19:30:41.389+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:41:396,-43.889999,-60.060001,9.870000
04-23 19:30:41.389+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:41.389+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:41.399+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:41:344,7.941778,-0.461815,2.718246
04-23 19:30:41.399+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:41.399+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:41:403,1.400000,-53.900002,15.260000
04-23 19:30:41.399+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:41.399+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:41:408,-7.840000,-8.960000,11.900000
04-23 19:30:41.409+0200 I/linearacceleration(16221): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:41:358,0.609121,0.152381,2.187905
04-23 19:30:41.409+0200 I/linearacceleration(16221): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:41.409+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:41:402,9.479970,0.146225,2.505829
04-23 19:30:41.409+0200 I/gyroscope(16204): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:41.409+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:41.409+0200 I/gravity (16223): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:41:418,9.497340,0.118697,2.440661
04-23 19:30:41.409+0200 I/gyroscope(16204): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:41:418,-21.000000,11.130000,18.410000
04-23 19:30:41.409+0200 I/gravity (16223): capturing data from es.ugr.frailty.gravity
04-23 19:30:41.409+0200 I/accelerometer(16192): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:41:405,9.260223,0.440279,3.474378
04-23 19:30:41.419+0200 I/accelerometer(16192): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:41.419+0200 W/CRASH_MANAGER(16141): worker.c: worker_job(1205) > 11162186c6f63152450464
