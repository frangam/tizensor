S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 16339
Date: 2018-04-23 19:30:50+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6ff852d, r5   = 0xf753ef98
r6   = 0xffe06b60, r7   = 0xffe06a10
r8   = 0xf753bc18, r9   = 0x00000000
r10  = 0xffe06aec, fp   = 0xffe06b60
ip   = 0x00000001, sp   = 0xffe069e8
lr   = 0xf6ff8539, pc   = 0xf7061228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     10556 KB
Buffers:     53720 KB
Cached:     234712 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11904 KB
VmRSS:       11904 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 16339 TID = 16339
16339 16368 

Maps Information
f3ec3000 f46c2000 rw-p [stack:16368]
f46c9000 f46cb000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f46d3000 f46d7000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f46e0000 f46e2000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f46ea000 f46ed000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f46fc000 f4701000 r-xp /usr/lib/libsystem.so.0.0.0
f470c000 f470f000 r-xp /lib/libattr.so.1.1.0
f4717000 f4727000 r-xp /usr/lib/libmdm-common.so.1.1.24
f472f000 f4738000 r-xp /usr/lib/libedbus.so.1.7.99
f4740000 f4741000 r-xp /usr/lib/libresponse.so.0.2.96
f474a000 f474f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5ff1000 f60f7000 r-xp /usr/lib/libicuuc.so.57.1
f610d000 f6295000 r-xp /usr/lib/libicui18n.so.57.1
f62a5000 f62b2000 r-xp /usr/lib/libail.so.0.1.0
f62bb000 f62c2000 r-xp /usr/lib/libminizip.so.1.0.0
f62cb000 f6474000 r-xp /usr/lib/libcrypto.so.1.0.0
f6494000 f64db000 r-xp /usr/lib/libssl.so.1.0.0
f64e7000 f64e9000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f64f1000 f64f8000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6501000 f6508000 r-xp /lib/libcrypt-2.13.so
f6539000 f653c000 r-xp /lib/libcap.so.2.21
f6544000 f6546000 r-xp /usr/lib/libiri.so
f654e000 f6597000 r-xp /usr/lib/libmdm.so.1.2.69
f659f000 f65a5000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f65ad000 f65d0000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f65da000 f65dc000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f65e4000 f6601000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f660a000 f660e000 r-xp /usr/lib/libsmack.so.1.0.0
f6617000 f6630000 r-xp /usr/lib/libnetwork.so.0.0.0
f6639000 f6641000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6649000 f664f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6658000 f665a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6663000 f6673000 r-xp /lib/libresolv-2.13.so
f6677000 f668f000 r-xp /usr/lib/liblzma.so.5.0.3
f6698000 f669a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f66a2000 f66bc000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f66c4000 f66f3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f66fc000 f670b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6715000 f671f000 r-xp /usr/lib/libsensord-shared.so
f6728000 f67fb000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6806000 f681c000 r-xp /lib/libz.so.1.2.5
f6824000 f6829000 r-xp /usr/lib/libffi.so.5.0.10
f6831000 f6832000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f683a000 f684a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6852000 f686b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6873000 f6875000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f687d000 f68f2000 r-xp /usr/lib/libsqlite3.so.0.8.6
f68fc000 f6902000 r-xp /lib/librt-2.13.so
f690b000 f6929000 r-xp /usr/lib/libsystemd.so.0.4.0
f6933000 f6934000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f693c000 f695f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6967000 f696c000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6974000 f699e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f69a7000 f69be000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f69c6000 f6a2f000 r-xp /lib/libm-2.13.so
f6a38000 f6acc000 r-xp /usr/lib/libstdc++.so.6.0.16
f6adf000 f6ae4000 r-xp /usr/lib/libctx-client.so.0.8.3
f6aec000 f6af3000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6afb000 f6b25000 r-xp /usr/lib/libsensor.so.1.9.6
f6b2e000 f6bfa000 r-xp /usr/lib/libxml2.so.2.7.8
f6c07000 f6c09000 r-xp /usr/lib/libiniparser.so.0
f6c12000 f6c18000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c21000 f6cf1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6cf2000 f6d26000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d2f000 f6d6b000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6d73000 f6d76000 r-xp /usr/lib/libbundle.so.0.1.22
f6d7e000 f6d84000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d8c000 f6dcd000 r-xp /usr/lib/libeina.so.1.7.99
f6dd6000 f6ded000 r-xp /usr/lib/libecore.so.1.7.99
f6e04000 f6e0d000 r-xp /usr/lib/libvconf.so.0.2.45
f6e15000 f6e29000 r-xp /lib/libpthread-2.13.so
f6e34000 f6e41000 r-xp /usr/lib/libaul.so.0.1.0
f6e4b000 f6e4d000 r-xp /lib/libdl-2.13.so
f6e56000 f6e61000 r-xp /lib/libunwind.so.8.0.1
f6e8e000 f6e96000 r-xp /lib/libgcc_s-4.6.so.1
f6e97000 f6fbb000 r-xp /lib/libc-2.13.so
f6fc9000 f6fcb000 r-xp /usr/lib/libdlog.so.0.0.0
f6fd3000 f6fdf000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6fe8000 f6fed000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6ff5000 f7004000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f700c000 f7010000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7019000 f701c000 r-xp /usr/lib/libappcore-agent.so.1.1
f7024000 f7026000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f702e000 f7032000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f703a000 f7057000 r-xp /lib/ld-2.13.so
f7060000 f7063000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7063000 f7067000 r-xp /usr/lib/libsys-assert.so
f750b000 f7599000 rw-p [heap]
ffde8000 ffe09000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16339)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7061228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf6ff8539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6cff3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6cfdc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6d09e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6d0fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6d0fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6d4475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6d3f1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6cfdc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6d09e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6d0fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6d0fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6d41e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6d42017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6d49f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf46e11fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf46d4171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf67a7663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6c54fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6c567a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6de6ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6de1b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6de25a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6de2879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf701a183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf701a7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70614f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6eae85c) [/lib/libc.so.6] + 0x1785c
29: (0xf7060f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
pe(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:190,-25.620001,-0.840000,-2.240000
04-23 19:30:50.199+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.209+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:207,-0.004589,-0.197202,0.123130
04-23 19:30:50.209+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.209+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:195,9.602397,-1.438086,1.962115
04-23 19:30:50.209+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.209+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:214,0.021722,0.028578,0.254074
04-23 19:30:50.209+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.209+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:218,-0.060509,-0.004466,0.059747
04-23 19:30:50.209+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.219+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.219+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:212,-33.950001,-3.150000,-2.520000
04-23 19:30:50.219+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.219+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:224,9.514450,-1.411797,1.911140
04-23 19:30:50.219+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:218,9.518648,-1.485943,2.076970
04-23 19:30:50.219+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.229+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:226,-40.670002,-4.550000,1.260000
04-23 19:30:50.229+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.229+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:230,9.542577,-1.287339,2.201397
04-23 19:30:50.239+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.249+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:251,9.514895,-1.454200,1.876819
04-23 19:30:50.249+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:222,0.009471,-0.224460,0.047981
04-23 19:30:50.249+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.249+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:257,0.056599,-0.230372,0.108947
04-23 19:30:50.249+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.259+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.259+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:264,9.509651,-1.479691,1.883466
04-23 19:30:50.269+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.269+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:240,-41.509998,-1.890000,0.560000
04-23 19:30:50.269+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.269+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:261,-0.034086,-0.552711,-0.528089
04-23 19:30:50.269+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.279+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:273,9.458827,-1.337588,2.002793
04-23 19:30:50.279+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.279+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.289+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:289,9.500283,-1.512032,1.904931
04-23 19:30:50.289+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:277,-39.689999,0.700000,0.840000
04-23 19:30:50.289+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.299+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.299+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:304,9.493644,-1.541800,1.914147
04-23 19:30:50.299+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:280,0.144930,-0.345203,0.293471
04-23 19:30:50.299+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.309+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:287,9.528220,-1.579263,1.978864
04-23 19:30:50.309+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:310,-0.251821,-0.374747,0.370574
04-23 19:30:50.309+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.319+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.319+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:324,9.495397,-1.545838,1.902158
04-23 19:30:50.319+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:299,-40.670002,0.840000,1.470000
04-23 19:30:50.319+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.339+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:30:50.339+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:30:50.339+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:30:50.339+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.349+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:348,9.500546,-1.519734,1.897478
04-23 19:30:50.349+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.359+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.359+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:364,9.506138,-1.476462,1.903627
04-23 19:30:50.359+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:321,9.573684,-1.615155,2.026721
04-23 19:30:50.359+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.359+0200 I/heartrate(16081): capturing data from es.ugr.frailty.heartrate
04-23 19:30:50.369+0200 I/heartrate(16081): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:30:50:370,82
04-23 19:30:50.369+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:330,-43.400002,-0.070000,1.680000
04-23 19:30:50.369+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:356,-0.208953,-0.519475,0.222288
04-23 19:30:50.369+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.379+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.379+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.389+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:369,9.480364,-1.964507,1.383051
04-23 19:30:50.389+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:388,0.087218,-0.350922,-0.093209
04-23 19:30:50.389+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.389+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:389,9.504637,-1.482967,1.906061
04-23 19:30:50.389+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:381,-44.310001,-1.050000,2.870000
04-23 19:30:50.389+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.399+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.399+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.399+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:404,9.507562,-1.491599,1.884619
04-23 19:30:50.399+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:400,9.659825,-1.799403,2.170290
04-23 19:30:50.399+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.399+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:401,-39.830002,-2.170000,3.150000
04-23 19:30:50.409+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.409+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:404,0.370212,0.143644,-0.064470
04-23 19:30:50.409+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:410,9.257831,-1.854438,2.254039
04-23 19:30:50.409+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.409+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.409+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:416,9.291330,-2.031506,2.127219
04-23 19:30:50.409+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.419+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.419+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:413,-33.810001,-0.630000,2.240000
04-23 19:30:50.419+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.419+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:418,0.049210,0.687032,-0.028684
04-23 19:30:50.419+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:424,9.511724,-1.491239,1.863786
04-23 19:30:50.419+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.419+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:421,9.580862,-1.892723,1.820938
04-23 19:30:50.419+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.429+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:426,-29.540001,-1.820000,2.310000
04-23 19:30:50.429+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:429,-0.169344,-0.031017,0.235557
04-23 19:30:50.429+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:431,9.865608,-1.402194,1.837688
04-23 19:30:50.429+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.429+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.429+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.439+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.439+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:444,9.516457,-1.479312,1.849072
04-23 19:30:50.439+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:442,0.054689,-0.273365,0.065625
04-23 19:30:50.439+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:437,-26.250000,2.590000,-0.630000
04-23 19:30:50.449+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.449+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:453,-23.100000,5.530000,-0.350000
04-23 19:30:50.449+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.449+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:457,0.269511,-0.291054,-0.245535
04-23 19:30:50.449+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.459+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.459+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:465,9.525435,-1.452769,1.823712
04-23 19:30:50.459+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.459+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:461,-8.050000,-0.560000,0.770000
04-23 19:30:50.469+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.469+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:471,0.038032,0.101009,-0.440057
04-23 19:30:50.469+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:476,9.030000,-3.850000,-2.310000
04-23 19:30:50.469+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.479+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.479+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:481,0.045262,0.512611,-0.616768
04-23 19:30:50.479+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.479+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:489,9.527123,-1.443794,1.822021
04-23 19:30:50.489+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.489+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:494,0.131997,0.440605,-0.100879
04-23 19:30:50.489+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:485,20.090000,-0.840000,-3.780000
04-23 19:30:50.489+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.489+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:499,6.860000,3.990000,-3.920000
04-23 19:30:50.499+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.499+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:504,9.520538,-1.469588,1.835769
04-23 19:30:50.499+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.499+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:508,0.022632,-0.226396,0.331519
04-23 19:30:50.499+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.509+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:512,-10.710000,-3.150000,1.260000
04-23 19:30:50.509+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.509+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:518,-7.560000,-10.850000,1.260000
04-23 19:30:50.509+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.519+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.519+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.519+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:436,9.549755,-0.832702,1.868794
04-23 19:30:50.519+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.519+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:526,9.336794,-1.507478,2.139183
04-23 19:30:50.519+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.519+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:524,9.513982,-1.499107,1.845866
04-23 19:30:50.519+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:526,-0.040174,-0.518848,0.250772
04-23 19:30:50.529+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:530,9.559326,-1.756332,1.971686
04-23 19:30:50.529+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.529+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:534,9.777073,-1.782653,1.639083
04-23 19:30:50.529+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.529+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:522,13.370000,-5.180000,-1.540000
04-23 19:30:50.529+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.529+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:538,9.549755,-1.390230,1.423729
04-23 19:30:50.529+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.539+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.539+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.539+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:542,9.561719,-0.966700,1.232304
04-23 19:30:50.539+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.539+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:547,9.657433,-1.012164,1.722832
04-23 19:30:50.539+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.539+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:544,0.074059,0.230911,-0.132605
04-23 19:30:50.549+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:546,9.516048,-1.490467,1.842206
04-23 19:30:50.549+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:550,9.549755,-1.670190,2.153540
04-23 19:30:50.549+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.549+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:540,19.740000,-0.420000,-0.350000
04-23 19:30:50.549+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.549+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:555,9.480364,-1.988436,2.086541
04-23 19:30:50.549+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.549+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:557,8.260000,-0.630000,0.490000
04-23 19:30:50.549+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.549+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:559,9.588040,-1.268196,1.713261
04-23 19:30:50.559+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.559+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.559+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:564,0.033707,0.250985,-0.033232
04-23 19:30:50.559+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.559+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:565,9.515049,-1.491679,1.846380
04-23 19:30:50.559+0200 I/heartrate(16081): capturing data from es.ugr.frailty.heartrate
04-23 19:30:50.559+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:568,9.549755,-1.239482,1.808974
04-23 19:30:50.569+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:561,-10.430000,0.490000,4.620000
04-23 19:30:50.569+0200 I/heartrate(16081): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:30:50:570,82
04-23 19:30:50.569+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.569+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:575,-12.180000,-1.540000,6.090000
04-23 19:30:50.569+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.569+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:579,1.610000,-4.060000,4.830000
04-23 19:30:50.569+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.579+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:583,9.030000,-2.800000,3.990000
04-23 19:30:50.579+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.579+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.579+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.589+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:589,-0.056222,-0.140226,-0.183369
04-23 19:30:50.589+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:586,-0.560000,-1.330000,6.930000
04-23 19:30:50.589+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.589+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.589+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:590,9.458827,-1.631905,1.663012
04-23 19:30:50.589+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:596,-9.030000,-2.940000,8.540000
04-23 19:30:50.589+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:596,9.512464,-1.517461,1.838676
04-23 19:30:50.599+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.599+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.599+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:604,0.144969,-0.427904,0.010976
04-23 19:30:50.599+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:604,9.657433,-1.945365,1.849652
04-23 19:30:50.599+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.599+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.609+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:609,9.508125,-1.550885,1.833221
04-23 19:30:50.609+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:609,-8.190000,-5.390000,8.260000
04-23 19:30:50.619+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.619+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.619+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:624,0.199556,-0.150412,0.081037
04-23 19:30:50.619+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.619+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:624,9.707682,-1.701297,1.914258
04-23 19:30:50.619+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.629+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:629,9.505273,-1.568600,1.832940
04-23 19:30:50.629+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:630,-6.440000,-3.220000,6.230000
04-23 19:30:50.639+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.639+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.639+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:644,-0.005768,0.144871,-0.090965
04-23 19:30:50.639+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.639+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:644,9.499505,-1.423729,1.741975
04-23 19:30:50.639+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.649+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:650,9.504386,-1.578925,1.828668
04-23 19:30:50.649+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:651,-11.830000,-1.680000,6.860000
04-23 19:30:50.659+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.659+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.659+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:667,-0.016844,-0.127157,-0.022087
04-23 19:30:50.659+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:667,9.487542,-1.706082,1.806581
04-23 19:30:50.659+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.669+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.669+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:673,-11.060000,-4.480000,8.890000
04-23 19:30:50.669+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:674,9.501203,-1.603381,1.823924
04-23 19:30:50.679+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.679+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.689+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.689+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:690,0.082052,-0.411376,-0.201590
04-23 19:30:50.689+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.699+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.699+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:690,9.583255,-2.014757,1.622334
04-23 19:30:50.699+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.699+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:705,0.098272,-0.462914,-1.073315
04-23 19:30:50.699+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:706,9.595219,-2.098505,0.744168
04-23 19:30:50.699+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:696,3.780000,-3.920000,9.240000
04-23 19:30:50.699+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:698,9.496946,-1.635591,1.817483
04-23 19:30:50.699+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.709+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.709+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:713,23.940001,-2.800000,8.470000
04-23 19:30:50.709+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:715,9.499554,-1.665493,1.776229
04-23 19:30:50.719+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.719+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.719+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:725,0.366055,0.148444,0.145207
04-23 19:30:50.719+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:725,9.865608,-1.517050,1.921437
04-23 19:30:50.719+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.719+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.729+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:732,29.750000,12.530000,11.410000
04-23 19:30:50.729+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:733,9.486485,-1.680056,1.831498
04-23 19:30:50.739+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.739+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.739+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.739+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:745,-0.123370,0.174970,0.518254
04-23 19:30:50.739+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.739+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:745,9.363115,-1.505085,2.349752
04-23 19:30:50.749+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:752,9.468252,-1.703050,1.903211
04-23 19:30:50.749+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:744,22.820000,10.080000,14.210000
04-23 19:30:50.759+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.759+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.759+0200 I/heartrate(16081): capturing data from es.ugr.frailty.heartrate
04-23 19:30:50.769+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:765,-0.315706,-0.488775,0.975355
04-23 19:30:50.779+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.779+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.789+0200 W/LOCATION(16339): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:30:50.789+0200 I/heartrate(16081): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:30:50:771,82
04-23 19:30:50.789+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:791,-0.188038,-1.230015,0.272979
04-23 19:30:50.799+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.799+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:783,9.441083,-1.758620,1.985846
04-23 19:30:50.799+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:767,9.152546,-2.191825,2.878566
04-23 19:30:50.799+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.799+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.809+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.809+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:803,24.150000,2.170000,18.200001
04-23 19:30:50.819+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.819+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:810,9.416576,-1.826358,2.040317
04-23 19:30:50.819+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.819+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:811,9.253045,-2.988636,2.258825
04-23 19:30:50.819+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.819+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:813,0.188213,-1.092885,-1.391862
04-23 19:30:50.819+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.839+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:832,0.626922,0.436482,-1.243037
04-23 19:30:50.849+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:828,49.000000,-3.500000,18.200001
04-23 19:30:50.849+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.849+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:828,9.415754,-1.862604,2.011133
04-23 19:30:50.849+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:833,9.604790,-2.919244,0.648455
04-23 19:30:50.849+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.849+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.849+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.869+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:858,9.414679,-1.851335,2.026519
04-23 19:30:50.869+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.869+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:855,76.790001,-7.210000,13.160000
04-23 19:30:50.869+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.869+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:875,9.382792,-1.897849,2.128799
04-23 19:30:50.869+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.869+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:860,10.042676,-1.426122,0.768096
04-23 19:30:50.879+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.879+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:863,-0.053956,-0.491239,-0.370685
04-23 19:30:50.879+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.879+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:877,95.059998,10.360000,14.350000
04-23 19:30:50.889+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.889+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:889,-0.160852,-0.959181,0.153954
04-23 19:30:50.889+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.889+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:885,9.360723,-2.342573,1.655833
04-23 19:30:50.899+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.899+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:898,0.174932,0.548282,-0.191753
04-23 19:30:50.899+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.899+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:897,78.400002,29.400000,15.120000
04-23 19:30:50.899+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.909+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:905,9.221939,-2.857030,2.282753
04-23 19:30:50.909+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:880,9.346109,-1.952869,2.237616
04-23 19:30:50.909+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.909+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.909+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:911,69.370003,21.980000,12.320000
04-23 19:30:50.919+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.919+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:915,9.335986,-1.934160,2.295379
04-23 19:30:50.919+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.919+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:915,9.521042,-1.404587,2.045863
04-23 19:30:50.919+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:910,0.070200,0.694678,-0.627582
04-23 19:30:50.919+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.929+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.929+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:926,9.336200,-1.927821,2.299839
04-23 19:30:50.929+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.929+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:925,42.420002,15.610000,6.020000
04-23 19:30:50.929+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.939+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:933,9.406186,-1.239482,1.667797
04-23 19:30:50.939+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:930,0.017344,0.111669,-0.438223
04-23 19:30:50.939+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.939+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.949+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:941,-5.600000,13.160000,6.790000
04-23 19:30:50.949+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:937,9.330203,-1.965305,2.292436
04-23 19:30:50.949+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.949+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:952,9.353544,-1.816152,1.861616
04-23 19:30:50.949+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.949+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:956,9.314021,-2.008646,2.320504
04-23 19:30:50.959+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.959+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:949,0.035305,-0.063808,0.263098
04-23 19:30:50.959+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.959+0200 I/heartrate(16081): capturing data from es.ugr.frailty.heartrate
04-23 19:30:50.969+0200 I/heartrate(16081): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:30:50:971,82
04-23 19:30:50.969+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:969,-0.092082,-0.443997,0.440813
04-23 19:30:50.969+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.969+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:960,-39.480000,14.210000,8.190000
04-23 19:30:50.969+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:965,9.365508,-2.029114,2.555535
04-23 19:30:50.969+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.979+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:977,9.294330,-2.056476,2.357270
04-23 19:30:50.979+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.979+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.989+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.989+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:983,-42.560001,17.290001,5.810000
04-23 19:30:50.989+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.989+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:50:989,0.025715,-0.369847,0.834756
04-23 19:30:50.989+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:50:986,9.221939,-2.452643,2.761317
04-23 19:30:50.989+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:50:996,-31.710001,16.520000,1.400000
04-23 19:30:50.989+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:50.999+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:50.999+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:51:2,9.320045,-2.426322,3.192025
04-23 19:30:50.999+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:51:4,-0.045863,0.065821,0.528107
04-23 19:30:50.999+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:50.999+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:50:993,9.274981,-2.087756,2.405493
04-23 19:30:50.999+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:50.999+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:51:8,-21.210001,13.580000,-1.750000
04-23 19:30:50.999+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:51:9,9.267608,-2.094197,2.428205
04-23 19:30:51.009+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:51.009+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:51:14,9.229117,-2.021935,2.933600
04-23 19:30:51.009+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:51.009+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:51:18,-21.770000,7.280000,-3.010000
04-23 19:30:51.019+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:51.019+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:51.019+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:51:24,-0.057633,-0.097629,-0.145452
04-23 19:30:51.019+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:51.019+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:51.019+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:51:28,-21.490000,1.540000,-3.080000
04-23 19:30:51.019+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:51:28,9.270129,-2.104436,2.409655
04-23 19:30:51.019+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:51:24,9.209974,-2.191825,2.282753
04-23 19:30:51.039+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:51.039+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:51.039+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:51:44,9.266994,-2.125137,2.403538
04-23 19:30:51.039+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:51.039+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:51.039+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:51:48,0.229376,-0.472634,0.165022
04-23 19:30:51.039+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:51:44,9.499505,-2.577070,2.574677
04-23 19:30:51.049+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:51:48,-19.389999,2.310000,-3.920000
04-23 19:30:51.059+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:51.059+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:51.059+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:51:65,9.268717,-2.135934,2.387269
04-23 19:30:51.059+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:51.059+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:51.059+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:51:68,0.234904,-0.339470,0.096961
04-23 19:30:51.059+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:51:65,9.501899,-2.464607,2.500499
04-23 19:30:51.069+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:51:69,-21.490000,0.140000,-5.880000
04-23 19:30:51.079+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:51.079+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:51.089+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:51.089+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:51.089+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:51:93,-0.058743,-0.386101,0.067767
04-23 19:30:51.089+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:51:89,9.268335,-2.151061,2.375138
04-23 19:30:51.089+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:51:90,9.209974,-2.522035,2.455036
04-23 19:30:51.089+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:51:94,-17.430000,-0.420000,-5.180000
04-23 19:30:51.099+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:51.099+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:51.099+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:51.099+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:51:104,9.142976,-2.335395,2.749353
04-23 19:30:51.099+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:51:106,-0.125360,-0.184334,0.374215
04-23 19:30:51.099+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:51.099+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:51:104,9.267118,-2.149230,2.381539
04-23 19:30:51.109+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:51:109,-6.370000,-0.420000,-6.790000
04-23 19:30:51.119+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:51.119+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:51.119+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:51.119+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:51.119+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:51:124,9.274529,-2.121118,2.377887
04-23 19:30:51.119+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:51:125,0.012249,0.246936,0.264923
04-23 19:30:51.129+0200 I/accelerometer(16313): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:30:51:126,9.279366,-1.902294,2.646462
04-23 19:30:51.129+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:51:128,-0.070000,-4.690000,-6.160000
04-23 19:30:51.139+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:51.139+0200 I/accelerometer(16313): capturing data from es.ugr.frailty.accelerometer
04-23 19:30:51.139+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:51.149+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:51:148,0.088586,0.431785,-0.308095
04-23 19:30:51.149+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:51:144,9.291169,-2.078839,2.350104
04-23 19:30:51.159+0200 I/gravity (16355): capturing data from es.ugr.frailty.gravity
04-23 19:30:51.159+0200 I/linearacceleration(16342): capturing data from es.ugr.frailty.linearacceleration
04-23 19:30:51.159+0200 I/heartrate(16081): capturing data from es.ugr.frailty.heartrate
04-23 19:30:51.169+0200 I/gravity (16355): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:30:51:165,9.305500,-2.054383,2.314640
04-23 19:30:51.169+0200 I/heartrate(16081): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:30:51:171,82
04-23 19:30:51.169+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:51.169+0200 I/linearacceleration(16342): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:30:51:168,0.296871,0.152616,-0.447810
04-23 19:30:51.169+0200 I/gyroscope(16326): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:30:51:178,7.490000,-5.600000,-6.930000
04-23 19:30:51.169+0200 I/gyroscope(16326): capturing data from es.ugr.frailty.gyroscope
04-23 19:30:51.179+0200 W/CRASH_MANAGER(16141): worker.c: worker_job(1205) > 11163396c6f63152450465
