S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 14397
Date: 2018-06-07 17:01:02+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf718452d, r5   = 0xf7246f98
r6   = 0xffc9bb30, r7   = 0xffc9b9e0
r8   = 0xf7243c18, r9   = 0x00000000
r10  = 0xffc9babc, fp   = 0xffc9bb30
ip   = 0x00000001, sp   = 0xffc9b9b8
lr   = 0xf7184539, pc   = 0xf71ed228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     93788 KB
Buffers:      8328 KB
Cached:      46016 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11388 KB
VmRSS:       11388 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 14397 TID = 14397
14397 14403 

Maps Information
f404f000 f484e000 rw-p [stack:14403]
f4855000 f4857000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f485f000 f4863000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f486c000 f486e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4876000 f4879000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4888000 f488d000 r-xp /usr/lib/libsystem.so.0.0.0
f4898000 f489b000 r-xp /lib/libattr.so.1.1.0
f48a3000 f48b3000 r-xp /usr/lib/libmdm-common.so.1.1.24
f48bb000 f48c4000 r-xp /usr/lib/libedbus.so.1.7.99
f48cc000 f48cd000 r-xp /usr/lib/libresponse.so.0.2.96
f48d6000 f48db000 r-xp /usr/lib/libproc-stat.so.0.2.96
f617d000 f6283000 r-xp /usr/lib/libicuuc.so.57.1
f6299000 f6421000 r-xp /usr/lib/libicui18n.so.57.1
f6431000 f643e000 r-xp /usr/lib/libail.so.0.1.0
f6447000 f644e000 r-xp /usr/lib/libminizip.so.1.0.0
f6457000 f6600000 r-xp /usr/lib/libcrypto.so.1.0.0
f6620000 f6667000 r-xp /usr/lib/libssl.so.1.0.0
f6673000 f6675000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f667d000 f6684000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f668d000 f6694000 r-xp /lib/libcrypt-2.13.so
f66c5000 f66c8000 r-xp /lib/libcap.so.2.21
f66d0000 f66d2000 r-xp /usr/lib/libiri.so
f66da000 f6723000 r-xp /usr/lib/libmdm.so.1.2.69
f672b000 f6731000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6739000 f675c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6766000 f6768000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6770000 f678d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6796000 f679a000 r-xp /usr/lib/libsmack.so.1.0.0
f67a3000 f67bc000 r-xp /usr/lib/libnetwork.so.0.0.0
f67c5000 f67cd000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f67d5000 f67db000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f67e4000 f67e6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f67ef000 f67ff000 r-xp /lib/libresolv-2.13.so
f6803000 f681b000 r-xp /usr/lib/liblzma.so.5.0.3
f6824000 f6826000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f682e000 f6848000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6850000 f687f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6888000 f6897000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f68a1000 f68ab000 r-xp /usr/lib/libsensord-shared.so
f68b4000 f6987000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6992000 f69a8000 r-xp /lib/libz.so.1.2.5
f69b0000 f69b5000 r-xp /usr/lib/libffi.so.5.0.10
f69bd000 f69be000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f69c6000 f69d6000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f69de000 f69f7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f69ff000 f6a01000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a09000 f6a7e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a88000 f6a8e000 r-xp /lib/librt-2.13.so
f6a97000 f6ab5000 r-xp /usr/lib/libsystemd.so.0.4.0
f6abf000 f6ac0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ac8000 f6aeb000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6af3000 f6af8000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b00000 f6b2a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b33000 f6b4a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b52000 f6bbb000 r-xp /lib/libm-2.13.so
f6bc4000 f6c58000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c6b000 f6c70000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c78000 f6c7f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c87000 f6cb1000 r-xp /usr/lib/libsensor.so.1.9.6
f6cba000 f6d86000 r-xp /usr/lib/libxml2.so.2.7.8
f6d93000 f6d95000 r-xp /usr/lib/libiniparser.so.0
f6d9e000 f6da4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6dad000 f6e7d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e7e000 f6eb2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ebb000 f6ef7000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6eff000 f6f02000 r-xp /usr/lib/libbundle.so.0.1.22
f6f0a000 f6f10000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f18000 f6f59000 r-xp /usr/lib/libeina.so.1.7.99
f6f62000 f6f79000 r-xp /usr/lib/libecore.so.1.7.99
f6f90000 f6f99000 r-xp /usr/lib/libvconf.so.0.2.45
f6fa1000 f6fb5000 r-xp /lib/libpthread-2.13.so
f6fc0000 f6fcd000 r-xp /usr/lib/libaul.so.0.1.0
f6fd7000 f6fd9000 r-xp /lib/libdl-2.13.so
f6fe2000 f6fed000 r-xp /lib/libunwind.so.8.0.1
f701a000 f7022000 r-xp /lib/libgcc_s-4.6.so.1
f7023000 f7147000 r-xp /lib/libc-2.13.so
f7155000 f7157000 r-xp /usr/lib/libdlog.so.0.0.0
f715f000 f716b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7174000 f7179000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7181000 f7190000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7198000 f719c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f71a5000 f71a8000 r-xp /usr/lib/libappcore-agent.so.1.1
f71b0000 f71b2000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f71ba000 f71be000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f71c6000 f71e3000 r-xp /lib/ld-2.13.so
f71ec000 f71ef000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f71ef000 f71f3000 r-xp /usr/lib/libsys-assert.so
f7213000 f72a1000 rw-p [heap]
ffc7d000 ffc9e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14397)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf71ed228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7184539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e8b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e89c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e95e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e9bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e9bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6ed075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6ecb1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e89c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e95e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e9bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e9bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6ecde5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6ece017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6ed5f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf486d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4860171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6933663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6de0fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6de27a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f72ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f6db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f6e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f6e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf71a6183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71a67fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71ed5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf703a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf71ecf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
gr.frailty.pressure)
06-07 17:01:01.971+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:01:01.971+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:01:01.971+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:01:971,9.590000,-8.960000,-12.180000
06-07 17:01:01.981+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:01.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12603
06-07 17:01:01.981+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:01:973,3.098706,0.543171,9.257831
06-07 17:01:01.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12603)
06-07 17:01:01.981+0200 I/servicemanager(12566): es.ugr.frailty.pressure launch request sent!
06-07 17:01:01.981+0200 I/servicemanager(12566): App control destroyed.
06-07 17:01:01.981+0200 I/servicemanager(12566): es.ugr.frailty.light alive timeout
06-07 17:01:01.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:01:01.981+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:01:01.981+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:01:01.991+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:01.991+0200 W/CAPI_APPFW_APP_CONTROL(14311): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:01:01.991+0200 I/utils   (14311): specific action
06-07 17:01:01.991+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:01:919,1.422305,0.588002,-0.792686
06-07 17:01:01.991+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:01.991+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:01:998,2.191900,-0.446346,9.548127
06-07 17:01:01.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12614
06-07 17:01:01.991+0200 W/CAPI_APPFW_APP_CONTROL(12614): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:01:02.001+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:01:02.001+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(14311), cmd(0)
06-07 17:01:02.001+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:01:02.001+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(12614), cmd(0)
06-07 17:01:02.001+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12614)
06-07 17:01:02.001+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:01:02.001+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(12603), cmd(0)
06-07 17:01:02.001+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 17:01:02.001+0200 W/CAPI_APPFW_APP_CONTROL(12603): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:01:02.001+0200 I/utils   (12603): specific action
06-07 17:01:02.001+0200 I/servicemanager(12566): App control destroyed.
06-07 17:01:02.001+0200 I/utils   (12614): specific action
06-07 17:01:02.001+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 17:01:02.001+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:01:02.001+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:01:02.001+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:01:02.001+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:2,2.770889,0.390030,9.140583
06-07 17:01:02.001+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:01:993,17.010000,-4.620000,-7.490000
06-07 17:01:02.001+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.011+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:15,2.660000,-3.850000,-9.800000
06-07 17:01:02.011+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.011+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 17:01:02.011+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 17:01:02.011+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 17:01:02.011+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:01:02.011+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(12618), cmd(0)
06-07 17:01:02.011+0200 I/servicemanager(12566): App control destroyed.
06-07 17:01:02.021+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.021+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:01:02.021+0200 I/utils   (12618): specific action
06-07 17:01:02.021+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.021+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:01:02.021+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:28,1.551152,1.071205,-0.535266
06-07 17:01:02.021+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.031+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:01:02:32,82
06-07 17:01:02.031+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:34,1.393736,0.985833,-0.069781
06-07 17:01:02.031+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.031+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.031+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:28,2.617748,-0.253639,9.363115
06-07 17:01:02.031+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:39,0.879601,1.138269,-0.275889
06-07 17:01:02.031+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:22,2.165314,-0.404034,9.556074
06-07 17:01:02.041+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:01:02.041+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(14354), cmd(0)
06-07 17:01:02.041+0200 W/CAPI_APPFW_APP_CONTROL(14354): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:01:02.041+0200 I/utils   (14354): specific action
06-07 17:01:02.041+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.041+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:01:02.041+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.041+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.051+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:01:02:50,770.000000
06-07 17:01:02.061+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:50,0.595764,0.896254,-0.408394
06-07 17:01:02.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:01:02.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:01:02.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:01:02.061+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:45,-1.470000,-3.780000,-9.240000
06-07 17:01:02.061+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.061+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.071+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:52,2.127430,-0.366341,9.566097
06-07 17:01:02.071+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:71,0.449221,0.201627,-0.189926
06-07 17:01:02.071+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.071+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:76,6.090000,-2.100000,-6.160000
06-07 17:01:02.071+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:77,0.306207,0.556416,-0.330975
06-07 17:01:02.071+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.071+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:59,2.498107,0.110070,9.217153
06-07 17:01:02.071+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.071+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.081+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:84,2.084955,-0.329010,9.576800
06-07 17:01:02.081+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:82,0.280151,0.363356,-0.264744
06-07 17:01:02.081+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.081+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:89,2.445465,-0.040678,9.291330
06-07 17:01:02.081+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:89,0.368284,0.418983,-0.284338
06-07 17:01:02.081+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.081+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.091+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.091+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:93,0.475365,0.463008,-0.192150
06-07 17:01:02.091+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.091+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:94,8.120000,0.070000,-6.370000
06-07 17:01:02.091+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:98,0.677431,0.294543,0.071819
06-07 17:01:02.091+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.091+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.101+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:102,0.869480,0.348480,-0.009780
06-07 17:01:02.101+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.101+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:102,2.495714,0.052642,9.281759
06-07 17:01:02.101+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.101+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:107,0.920266,0.311676,-0.139095
06-07 17:01:02.101+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:97,2.038423,-0.292150,9.588006
06-07 17:01:02.101+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.101+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:110,6.720000,2.660000,-4.340000
06-07 17:01:02.101+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:111,0.774363,0.072869,-0.169196
06-07 17:01:02.111+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.111+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.111+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.111+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:118,5.600000,4.410000,-3.080000
06-07 17:01:02.111+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.111+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.111+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:116,2.006693,-0.267124,9.595427
06-07 17:01:02.121+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.121+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:120,2.560320,0.133998,9.384650
06-07 17:01:02.121+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:124,0.723895,0.062559,-0.230783
06-07 17:01:02.121+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:122,4.340000,4.060000,-1.820000
06-07 17:01:02.121+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.121+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.131+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:128,1.975049,-0.239891,9.602709
06-07 17:01:02.131+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:132,4.900000,2.030000,-0.420000
06-07 17:01:02.131+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.131+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:133,2.715853,0.002393,9.659825
06-07 17:01:02.131+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.131+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:136,0.700000,0.840000,-0.630000
06-07 17:01:02.131+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.131+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.131+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:141,-5.670000,-0.770000,0.210000
06-07 17:01:02.131+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.141+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:145,-4.410000,1.540000,0.770000
06-07 17:01:02.141+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.141+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:139,1.970204,-0.223617,9.604096
06-07 17:01:02.141+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.141+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:149,0.650278,0.054680,-0.134076
06-07 17:01:02.141+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:144,2.876173,0.081356,9.585647
06-07 17:01:02.141+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.151+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.151+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:154,0.560000,1.540000,-1.120000
06-07 17:01:02.151+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:151,2.018279,-0.232449,9.593899
06-07 17:01:02.151+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.151+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:156,2.895315,0.071785,9.463614
06-07 17:01:02.151+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.151+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.161+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.161+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:163,2.056005,-0.238928,9.585726
06-07 17:01:02.161+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:165,0.674600,0.208222,0.070663
06-07 17:01:02.161+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:169,2.744568,-0.150748,9.434900
06-07 17:01:02.161+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:170,1.960000,2.030000,0.560000
06-07 17:01:02.161+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.171+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.171+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:174,2.062789,-0.234543,9.584376
06-07 17:01:02.171+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.171+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:176,2.742175,-0.169890,9.363115
06-07 17:01:02.171+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.171+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:179,2.046617,-0.220174,9.588183
06-07 17:01:02.171+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.171+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.181+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:185,-1.120000,0.630000,0.630000
06-07 17:01:02.181+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:185,0.621380,0.212995,0.119498
06-07 17:01:02.181+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.181+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:180,2.706282,-0.184247,9.451650
06-07 17:01:02.181+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.181+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:190,2.050530,-0.212195,9.587527
06-07 17:01:02.181+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:191,2.737389,-0.026321,9.655040
06-07 17:01:02.191+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.191+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:196,2.667997,-0.007178,9.707682
06-07 17:01:02.191+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.191+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.201+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:205,-4.200000,0.490000,1.890000
06-07 17:01:02.201+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:205,2.075102,-0.210602,9.582274
06-07 17:01:02.201+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.201+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.201+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:209,0.572004,0.224159,-0.006665
06-07 17:01:02.201+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:211,2.622534,0.011964,9.580862
06-07 17:01:02.211+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.221+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:224,2.125145,-0.209082,9.571334
06-07 17:01:02.221+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:01:02.231+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:01:02:232,82
06-07 17:01:02.231+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.241+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:01:02.241+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.251+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:01:02:250,774.000000
06-07 17:01:02.251+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:243,2.574677,0.303888,9.236296
06-07 17:01:02.251+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:253,2.256731,-0.238965,9.540463
06-07 17:01:02.261+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.261+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:270,0.499575,0.514490,-0.345979
06-07 17:01:02.261+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.271+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:275,-10.850000,2.730000,3.780000
06-07 17:01:02.281+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.281+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:290,0.406462,0.091834,-0.277611
06-07 17:01:02.281+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.291+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.291+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.291+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.291+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:296,-16.450001,2.800000,0.630000
06-07 17:01:02.291+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.301+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:295,0.262911,0.085825,0.038006
06-07 17:01:02.301+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:301,-16.730000,3.710000,3.710000
06-07 17:01:02.301+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.301+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:299,2.381525,-0.270010,9.509249
06-07 17:01:02.301+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.301+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:300,2.531606,-0.117248,9.293723
06-07 17:01:02.311+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.311+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.311+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:314,0.372614,-0.340159,0.229540
06-07 17:01:02.311+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:311,-9.520000,1.610000,1.820000
06-07 17:01:02.311+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.311+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.321+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:328,-2.940000,2.310000,4.760000
06-07 17:01:02.321+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:323,0.248048,-0.147095,0.112076
06-07 17:01:02.321+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.321+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:320,2.470198,-0.305149,9.485536
06-07 17:01:02.331+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.331+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:325,2.519642,-0.153141,9.578469
06-07 17:01:02.331+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:335,-5.460000,2.030000,5.530000
06-07 17:01:02.331+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.331+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:335,0.206254,0.117959,0.019723
06-07 17:01:02.341+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.341+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:01:02.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:01:02.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:01:02.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:01:02.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390862351,000000, pattern:[H:mm][0;m
06-07 17:01:02.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:01:02.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:01:02.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:01:02.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:01:02.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:01:02.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:01][0;m
06-07 17:01:02.341+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.351+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:349,0.205231,0.057911,-0.143825
06-07 17:01:02.351+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:352,-10.850000,3.710000,6.020000
06-07 17:01:02.351+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:358,2.754139,-0.610170,9.738789
06-07 17:01:02.351+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:344,2.490457,-0.318956,9.479782
06-07 17:01:02.351+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.361+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.361+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:366,0.004185,0.160136,0.043185
06-07 17:01:02.361+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.361+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.361+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:370,-12.040000,2.660000,5.950000
06-07 17:01:02.361+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:365,2.522587,-0.325907,9.471046
06-07 17:01:02.371+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.371+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:371,2.718246,-0.452243,9.597611
06-07 17:01:02.371+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.371+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.381+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.381+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:377,2.592028,-0.346776,9.451535
06-07 17:01:02.381+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:382,2.696711,-0.200997,9.499505
06-07 17:01:02.381+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:385,0.064211,-0.087344,0.481859
06-07 17:01:02.381+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.381+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:385,-7.140000,-0.420000,5.530000
06-07 17:01:02.381+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.391+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:390,2.661214,-0.364899,9.431605
06-07 17:01:02.391+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.391+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:395,2.727818,-0.267996,9.327222
06-07 17:01:02.391+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.401+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.401+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:402,2.696634,-0.384191,9.420773
06-07 17:01:02.401+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.401+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:406,0.012042,-0.271443,0.064377
06-07 17:01:02.401+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:409,2.596212,-0.186640,9.494720
06-07 17:01:02.401+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:404,-4.340000,-1.400000,5.740000
06-07 17:01:02.401+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.411+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:414,2.714365,-0.407403,9.414702
06-07 17:01:02.421+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.421+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.421+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:01:02.421+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.431+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:01:02:433,82
06-07 17:01:02.431+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.431+0200 W/LOCATION(14397): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:01:02.441+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:439,-0.343078,-0.085519,0.039340
06-07 17:01:02.441+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:432,-13.020000,-2.380000,8.260000
06-07 17:01:02.441+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:01:02.441+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.441+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.441+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:01:02:451,765.000000
06-07 17:01:02.451+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:451,-0.380426,0.000517,-0.027842
06-07 17:01:02.451+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:452,-14.840000,-0.770000,9.100000
06-07 17:01:02.451+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:427,2.725425,-0.452243,9.913465
06-07 17:01:02.451+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.461+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.461+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.461+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:430,2.766070,-0.440796,9.398135
06-07 17:01:02.461+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:466,-19.320000,1.330000,9.310000
06-07 17:01:02.461+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.461+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:468,2.708675,-0.655633,9.485149
06-07 17:01:02.471+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:464,-0.353126,0.054960,-0.125014
06-07 17:01:02.471+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:475,2.820126,-0.473704,9.380452
06-07 17:01:02.471+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.471+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.471+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.481+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.481+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:486,-0.320051,0.055492,-0.002110
06-07 17:01:02.481+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:480,2.371287,-0.492921,9.454042
06-07 17:01:02.481+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:484,-21.000000,2.030000,10.850000
06-07 17:01:02.481+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:483,2.894728,-0.512522,9.355654
06-07 17:01:02.491+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.491+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.491+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:499,2.967500,-0.554474,9.330428
06-07 17:01:02.491+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.491+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:496,2.385644,-0.440279,9.370294
06-07 17:01:02.501+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.501+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.501+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.501+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:505,-0.230111,-0.223193,0.166685
06-07 17:01:02.501+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:509,3.002412,-0.601193,9.316356
06-07 17:01:02.501+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:505,-17.150000,3.290000,11.480000
06-07 17:01:02.511+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:508,2.467000,-0.418744,9.255438
06-07 17:01:02.511+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.511+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:519,2.574677,-0.457029,9.353544
06-07 17:01:02.511+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.511+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.521+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.521+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:524,3.029389,-0.656958,9.303848
06-07 17:01:02.521+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:525,-0.255451,-0.384650,-0.178166
06-07 17:01:02.521+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.521+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:524,-17.780001,6.160000,11.060000
06-07 17:01:02.521+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:531,2.737389,-0.777667,9.497113
06-07 17:01:02.531+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.531+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:537,2.746960,-0.985843,9.138189
06-07 17:01:02.541+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.541+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.541+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.541+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:550,-0.392498,-0.450919,-0.134552
06-07 17:01:02.541+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:549,3.066339,-0.728459,9.286404
06-07 17:01:02.551+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.551+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:549,-24.780001,8.750000,10.080000
06-07 17:01:02.551+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:556,2.636890,-1.107877,9.169296
06-07 17:01:02.551+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.551+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.561+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.561+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:565,3.101227,-0.805195,9.268465
06-07 17:01:02.561+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.561+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:564,-29.820000,9.870000,8.120000
06-07 17:01:02.561+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:565,-0.541911,-0.405739,0.241817
06-07 17:01:02.571+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:571,2.524428,-1.134198,9.528220
06-07 17:01:02.571+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.571+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.571+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.581+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:585,3.069463,-0.871184,9.273069
06-07 17:01:02.581+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:584,-15.400000,9.100000,3.990000
06-07 17:01:02.581+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.581+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:585,-0.598334,-0.833888,0.266933
06-07 17:01:02.581+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:591,2.502892,-1.639083,9.535398
06-07 17:01:02.591+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.601+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.601+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.601+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:606,-0.298574,-0.629116,0.480076
06-07 17:01:02.601+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:606,3.004536,-0.899677,9.291595
06-07 17:01:02.601+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.601+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:605,-1.750000,10.990000,5.250000
06-07 17:01:02.611+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:612,2.770889,-1.500300,9.753145
06-07 17:01:02.611+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.611+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.621+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.621+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:625,2.941442,-0.922228,9.309554
06-07 17:01:02.621+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:626,-0.506429,-0.418769,0.289268
06-07 17:01:02.621+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.621+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:01:02.621+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:624,-2.660000,10.570000,3.640000
06-07 17:01:02.631+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:01:02:632,82
06-07 17:01:02.631+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:631,2.498107,-1.318445,9.580862
06-07 17:01:02.641+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.641+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.641+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:01:02.641+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.641+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:651,-0.742437,-0.515859,0.288057
06-07 17:01:02.651+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:650,-3.570000,5.530000,2.590000
06-07 17:01:02.651+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:01:02:651,749.000000
06-07 17:01:02.651+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:655,2.876700,-0.952698,9.326701
06-07 17:01:02.651+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.651+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.651+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.661+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.661+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:664,2.805832,-0.968369,9.346655
06-07 17:01:02.661+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:665,2.310000,5.670000,2.310000
06-07 17:01:02.661+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:664,-0.598732,-0.468639,0.337910
06-07 17:01:02.661+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:662,2.199004,-1.438086,9.597611
06-07 17:01:02.671+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.671+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:676,2.277967,-1.421337,9.664611
06-07 17:01:02.681+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.681+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.681+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.681+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:686,2.739402,-0.959611,9.367241
06-07 17:01:02.681+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.681+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:686,6.510000,6.090000,2.660000
06-07 17:01:02.681+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:688,-0.487187,-0.094044,0.109780
06-07 17:01:02.691+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:692,2.318645,-1.062413,9.456435
06-07 17:01:02.691+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.691+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.701+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.701+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:705,2.701885,-0.981583,9.375857
06-07 17:01:02.701+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.701+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:705,-0.380079,-0.437798,0.151407
06-07 17:01:02.701+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:705,-1.890000,5.740000,1.120000
06-07 17:01:02.711+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:712,2.359323,-1.397408,9.518648
06-07 17:01:02.711+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.711+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.721+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.721+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:725,2.670923,-0.997939,9.382999
06-07 17:01:02.721+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:725,-0.352133,-0.265078,0.449072
06-07 17:01:02.721+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.721+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:724,-3.500000,4.830000,1.400000
06-07 17:01:02.731+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:731,2.349752,-1.246661,9.824929
06-07 17:01:02.741+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.741+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:750,2.625919,-0.990457,9.396485
06-07 17:01:02.741+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.751+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.751+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.761+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:756,-0.500633,0.083881,0.444323
06-07 17:01:02.761+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.761+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:756,1.120000,4.130000,2.170000
06-07 17:01:02.761+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.771+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.771+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:770,-0.441272,0.133826,0.296840
06-07 17:01:02.771+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:772,1.260000,1.330000,3.010000
06-07 17:01:02.771+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:754,2.170290,-0.914058,9.827322
06-07 17:01:02.771+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.771+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:02.781+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:02.781+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:778,2.591508,-0.981822,9.406939
06-07 17:01:02.781+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:01:02.781+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:02:785,-0.313540,-0.047091,0.142817
06-07 17:01:02.791+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:02:788,-2.450000,0.490000,2.870000
06-07 17:01:02.791+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:02:791,2.574753,-0.989435,9.410741
06-07 17:01:02.791+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:02:784,2.184647,-0.856631,9.693325
06-07 17:01:02.791+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:02.791+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11143976c6f63152838366
