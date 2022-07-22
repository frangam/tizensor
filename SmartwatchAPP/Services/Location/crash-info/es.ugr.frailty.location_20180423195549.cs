S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 4145
Date: 2018-04-23 19:55:49+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70de52d, r5   = 0xf786af98
r6   = 0xff9a17e0, r7   = 0xff9a1690
r8   = 0xf7867c18, r9   = 0x00000000
r10  = 0xff9a176c, fp   = 0xff9a17e0
ip   = 0x00000001, sp   = 0xff9a1668
lr   = 0xf70de539, pc   = 0xf7147228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     67352 KB
Buffers:     32500 KB
Cached:     224892 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11920 KB
VmRSS:       11920 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 4145 TID = 4145
4145 4154 

Maps Information
f3fa9000 f47a8000 rw-p [stack:4154]
f47af000 f47b1000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f47b9000 f47bd000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f47c6000 f47c8000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f47d0000 f47d3000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47e2000 f47e7000 r-xp /usr/lib/libsystem.so.0.0.0
f47f2000 f47f5000 r-xp /lib/libattr.so.1.1.0
f47fd000 f480d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4815000 f481e000 r-xp /usr/lib/libedbus.so.1.7.99
f4826000 f4827000 r-xp /usr/lib/libresponse.so.0.2.96
f4830000 f4835000 r-xp /usr/lib/libproc-stat.so.0.2.96
f60d7000 f61dd000 r-xp /usr/lib/libicuuc.so.57.1
f61f3000 f637b000 r-xp /usr/lib/libicui18n.so.57.1
f638b000 f6398000 r-xp /usr/lib/libail.so.0.1.0
f63a1000 f63a8000 r-xp /usr/lib/libminizip.so.1.0.0
f63b1000 f655a000 r-xp /usr/lib/libcrypto.so.1.0.0
f657a000 f65c1000 r-xp /usr/lib/libssl.so.1.0.0
f65cd000 f65cf000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f65d7000 f65de000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65e7000 f65ee000 r-xp /lib/libcrypt-2.13.so
f661f000 f6622000 r-xp /lib/libcap.so.2.21
f662a000 f662c000 r-xp /usr/lib/libiri.so
f6634000 f667d000 r-xp /usr/lib/libmdm.so.1.2.69
f6685000 f668b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6693000 f66b6000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f66c0000 f66c2000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f66ca000 f66e7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66f0000 f66f4000 r-xp /usr/lib/libsmack.so.1.0.0
f66fd000 f6716000 r-xp /usr/lib/libnetwork.so.0.0.0
f671f000 f6727000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f672f000 f6735000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f673e000 f6740000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6749000 f6759000 r-xp /lib/libresolv-2.13.so
f675d000 f6775000 r-xp /usr/lib/liblzma.so.5.0.3
f677e000 f6780000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6788000 f67a2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f67aa000 f67d9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67e2000 f67f1000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67fb000 f6805000 r-xp /usr/lib/libsensord-shared.so
f680e000 f68e1000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68ec000 f6902000 r-xp /lib/libz.so.1.2.5
f690a000 f690f000 r-xp /usr/lib/libffi.so.5.0.10
f6917000 f6918000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6920000 f6930000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6938000 f6951000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6959000 f695b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6963000 f69d8000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69e2000 f69e8000 r-xp /lib/librt-2.13.so
f69f1000 f6a0f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a19000 f6a1a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a22000 f6a45000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a4d000 f6a52000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a5a000 f6a84000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a8d000 f6aa4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6aac000 f6b15000 r-xp /lib/libm-2.13.so
f6b1e000 f6bb2000 r-xp /usr/lib/libstdc++.so.6.0.16
f6bc5000 f6bca000 r-xp /usr/lib/libctx-client.so.0.8.3
f6bd2000 f6bd9000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6be1000 f6c0b000 r-xp /usr/lib/libsensor.so.1.9.6
f6c14000 f6ce0000 r-xp /usr/lib/libxml2.so.2.7.8
f6ced000 f6cef000 r-xp /usr/lib/libiniparser.so.0
f6cf8000 f6cfe000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d07000 f6dd7000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6dd8000 f6e0c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e15000 f6e51000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e59000 f6e5c000 r-xp /usr/lib/libbundle.so.0.1.22
f6e64000 f6e6a000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e72000 f6eb3000 r-xp /usr/lib/libeina.so.1.7.99
f6ebc000 f6ed3000 r-xp /usr/lib/libecore.so.1.7.99
f6eea000 f6ef3000 r-xp /usr/lib/libvconf.so.0.2.45
f6efb000 f6f0f000 r-xp /lib/libpthread-2.13.so
f6f1a000 f6f27000 r-xp /usr/lib/libaul.so.0.1.0
f6f31000 f6f33000 r-xp /lib/libdl-2.13.so
f6f3c000 f6f47000 r-xp /lib/libunwind.so.8.0.1
f6f74000 f6f7c000 r-xp /lib/libgcc_s-4.6.so.1
f6f7d000 f70a1000 r-xp /lib/libc-2.13.so
f70af000 f70b1000 r-xp /usr/lib/libdlog.so.0.0.0
f70b9000 f70c5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f70ce000 f70d3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70db000 f70ea000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70f2000 f70f6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70ff000 f7102000 r-xp /usr/lib/libappcore-agent.so.1.1
f710a000 f710c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7114000 f7118000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7120000 f713d000 r-xp /lib/ld-2.13.so
f7146000 f7149000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7149000 f714d000 r-xp /usr/lib/libsys-assert.so
f7837000 f78a8000 rw-p [heap]
ff982000 ff9a3000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4145)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7147228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf70de539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6de53f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6de3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6defe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6df5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6df5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e2a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e251f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6de3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6defe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6df5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6df5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e27e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e28017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e2ff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47c71fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf47ba171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf688d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d3afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d3c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6eccca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6ec7b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6ec85a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6ec8879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7100183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71007fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71474f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6f9485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7146f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
0,0.140000,-0.070000
04-23 19:55:48.609+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:48:606,0.031107,9.805787,0.847059
04-23 19:55:48.609+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:48:589,-0.009895,0.032120,0.044484
04-23 19:55:48.619+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:48.619+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:48:625,0.007489,0.013011,-0.013388
04-23 19:55:48.619+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:48:603,0.040368,9.773634,0.803019
04-23 19:55:48.619+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:48.629+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:48.629+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:48.629+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:48:637,0.047856,9.786645,0.789631
04-23 19:55:48.639+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:48.649+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:48:631,0.070000,0.140000,-0.070000
04-23 19:55:48.649+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:48:634,0.040556,9.773809,0.800869
04-23 19:55:48.649+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:48.659+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:48.659+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:48:649,0.016872,0.036764,0.010298
04-23 19:55:48.669+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:48:673,-0.070000,0.070000,-0.070000
04-23 19:55:48.669+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:48:673,0.041192,9.773875,0.800035
04-23 19:55:48.669+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:48.679+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:48.679+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:48:681,0.057428,9.810574,0.811167
04-23 19:55:48.689+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:48.689+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:48.699+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:48.749+0200 I/servicemanager( 3660): es.ugr.frailty.location sleep timeout
04-23 19:55:48.749+0200 W/AUL     ( 3660): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 19:55:48.759+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:55:48.759+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 3660
04-23 19:55:48.769+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4145
04-23 19:55:48.769+0200 W/AUL     ( 3660): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4145)
04-23 19:55:48.769+0200 I/servicemanager( 3660): es.ugr.frailty.location stop request sent!
04-23 19:55:48.769+0200 I/servicemanager( 3660): App control destroyed.
04-23 19:55:48.769+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:48:684,0.032986,0.019948,0.015918
04-23 19:55:48.769+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:48.769+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:48:701,0.042591,9.773895,0.799716
04-23 19:55:48.779+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:48:711,0.074178,9.793823,0.815953
04-23 19:55:48.779+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:48:700,-0.070000,0.070000,-0.070000
04-23 19:55:48.779+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:48.779+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:48.789+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:48:793,0.044159,9.774002,0.798324
04-23 19:55:48.799+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:48.799+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:48:783,0.036373,0.031892,-0.002906
04-23 19:55:48.809+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:48.809+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:48:815,-0.003481,0.024607,-0.001514
04-23 19:55:48.819+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:48.819+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:48:791,-0.070000,0.070000,-0.070000
04-23 19:55:48.819+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:48.819+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:48:806,0.078963,9.805787,0.796810
04-23 19:55:48.819+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:48:828,0.043835,9.774107,0.797057
04-23 19:55:48.829+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:48.839+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:48:831,-0.070000,0.070000,-0.070000
04-23 19:55:48.839+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:48.839+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:48:843,0.040678,9.798609,0.796810
04-23 19:55:48.849+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:48.849+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:48.849+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:48:851,-0.015121,0.041251,0.011717
04-23 19:55:48.849+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:48:856,0.042957,9.774176,0.796257
04-23 19:55:48.859+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:48.859+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:48:863,-0.070000,0.070000,-0.070000
04-23 19:55:48.859+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:48:869,0.028714,9.815358,0.808774
04-23 19:55:48.869+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:48.879+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:48.879+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:48.889+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:48:893,-0.070000,0.070000,-0.070000
04-23 19:55:48.889+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:48:883,0.002506,0.050754,0.024481
04-23 19:55:48.889+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:48:892,0.042911,9.774189,0.796099
04-23 19:55:48.899+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:48.899+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:48.899+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:48:904,0.045464,9.824929,0.820738
04-23 19:55:48.909+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:48.909+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:48.909+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:48:913,-0.009412,0.026813,-0.008860
04-23 19:55:48.919+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:48.929+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:48:933,0.033500,9.801002,0.787239
04-23 19:55:48.939+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:48.939+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:48:945,-0.037819,-0.008987,0.047416
04-23 19:55:48.939+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:48:921,0.042605,9.774096,0.797251
04-23 19:55:48.949+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:48:925,-0.070000,0.070000,0.070000
04-23 19:55:48.949+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:48.959+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:48.959+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:48.969+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:48.979+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:48:955,0.040985,9.773837,0.800512
04-23 19:55:48.979+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:48.979+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:48:965,-0.070000,0.070000,0.070000
04-23 19:55:48.989+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:48.989+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:48:972,0.004786,9.765109,0.844666
04-23 19:55:48.989+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:48.989+0200 E/location( 4145): es.ugr.frailty.location: error intentando obtener la última localización
04-23 19:55:48.999+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:7,0.007178,9.803394,0.787239
04-23 19:55:49.009+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:48:979,-0.033806,0.029557,-0.013274
04-23 19:55:49.009+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.009+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:48:990,0.039511,9.773744,0.801727
04-23 19:55:49.009+0200 W/AUL     ( 4145): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 19:55:49.009+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:17,-0.032332,0.027258,0.004654
04-23 19:55:49.019+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:55:49.019+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 4145
04-23 19:55:49.029+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 3660
04-23 19:55:49.029+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 19:55:49.029+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(3660), cmd(0)
04-23 19:55:49.029+0200 W/CAPI_APPFW_APP_CONTROL( 3660): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:55:49.029+0200 I/utils   ( 3660): specific action
04-23 19:55:49.029+0200 W/CAPI_APPFW_APP_CONTROL( 3660): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:55:49.029+0200 W/CAPI_APPFW_APP_CONTROL( 3660): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:55:49.029+0200 W/CAPI_APPFW_APP_CONTROL( 3660): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:55:49.029+0200 W/AUL     ( 3660): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 19:55:49.029+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:55:49.029+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 3660
04-23 19:55:49.039+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 3665
04-23 19:55:49.059+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 19:55:49.059+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(3665), cmd(0)
04-23 19:55:49.059+0200 W/CAPI_APPFW_APP_CONTROL( 3665): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:55:49.059+0200 I/utils   ( 3665): specific action
04-23 19:55:49.059+0200 W/CAPI_APPFW_APP_CONTROL( 3665): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:55:49.059+0200 W/CAPI_APPFW_APP_CONTROL( 3665): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:55:49.059+0200 W/CAPI_APPFW_APP_CONTROL( 3665): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:55:49.059+0200 W/CAPI_APPFW_APP_CONTROL( 3665): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:55:49.059+0200 I/recorder( 3665): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 19:55:49.059+0200 I/recorder( 3665): guardando datos en local
04-23 19:55:49.059+0200 W/AUL     ( 3660): launch.c: app_request_to_launchpad(298) > request cmd(0) result(3665)
04-23 19:55:49.059+0200 I/servicemanager( 3660): request sent to service es.ugr.frailty.recorder
04-23 19:55:49.059+0200 I/servicemanager( 3660): requesting to save local data
04-23 19:55:49.059+0200 W/AUL     ( 4145): launch.c: app_request_to_launchpad(298) > request cmd(0) result(3660)
04-23 19:55:49.059+0200 I/location( 4145): request sent to service es.ugr.frailty.servicemanager
04-23 19:55:49.059+0200 W/CAPI_APPFW_APP_CONTROL( 4145): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:55:49.059+0200 I/utils   ( 4145): specific action
04-23 19:55:49.059+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 19:55:49.059+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(4145), cmd(0)
04-23 19:55:49.069+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:48:994,-0.070000,0.070000,0.070000
04-23 19:55:49.069+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.069+0200 I/location( 4145): stopping es.ugr.frailty.location service
04-23 19:55:49.069+0200 E/CAPI_APPFW_APP_CONTROL( 4145): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 19:55:49.069+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:74,0.038119,9.773588,0.803679
04-23 19:55:49.079+0200 E/location( 4145): request sending failed to service es.ugr.frailty.servicemanager
04-23 19:55:49.079+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.079+0200 I/CAPI_APPFW_APPLICATION( 4145): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 19:55:49.079+0200 W/LOCATION( 4145): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:55:49.079+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.089+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:92,0.007178,9.801002,0.806381
04-23 19:55:49.089+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.089+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:97,0.002559,0.041770,0.005095
04-23 19:55:49.099+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.109+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:87,-0.070000,0.070000,0.070000
04-23 19:55:49.109+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:113,0.038374,9.773452,0.805321
04-23 19:55:49.119+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.119+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.119+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:125,0.070000,0.070000,0.070000
04-23 19:55:49.119+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.129+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:133,-0.012053,0.068228,0.001060
04-23 19:55:49.129+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:129,0.040678,9.815358,0.808774
04-23 19:55:49.129+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.129+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:139,0.037932,9.773336,0.806750
04-23 19:55:49.139+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.149+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.149+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.159+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:161,0.026321,9.841680,0.806381
04-23 19:55:49.159+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:153,0.070000,0.070000,0.070000
04-23 19:55:49.159+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.159+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:163,-0.021183,0.010916,-0.024297
04-23 19:55:49.169+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:173,0.037063,9.773253,0.807796
04-23 19:55:49.169+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.169+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:177,-0.070000,0.070000,0.070000
04-23 19:55:49.179+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.189+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.189+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:194,0.025150,0.049284,0.044049
04-23 19:55:49.199+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.199+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:209,0.038367,9.772903,0.811957
04-23 19:55:49.209+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.219+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:192,0.016750,9.784252,0.782453
04-23 19:55:49.219+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.219+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.229+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:222,-0.070000,0.140000,0.070000
04-23 19:55:49.229+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.239+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.239+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:242,0.038168,9.772741,0.813910
04-23 19:55:49.249+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:232,0.062213,9.822537,0.851845
04-23 19:55:49.259+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:229,-0.007261,0.020920,0.001603
04-23 19:55:49.259+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.259+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.279+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.279+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:253,-0.070000,0.070000,0.070000
04-23 19:55:49.279+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.289+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:274,-0.028596,0.035439,0.009221
04-23 19:55:49.299+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:269,0.031107,9.793823,0.813560
04-23 19:55:49.299+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.299+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.309+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:311,-0.003461,0.045208,0.006788
04-23 19:55:49.309+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:285,0.036960,9.772543,0.816343
04-23 19:55:49.319+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.319+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:294,-0.070000,0.070000,0.070000
04-23 19:55:49.329+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.329+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:326,0.036937,9.772363,0.818499
04-23 19:55:49.329+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:307,0.009571,9.808180,0.823131
04-23 19:55:49.339+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.339+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.349+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.349+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:333,-0.070000,0.070000,0.070000
04-23 19:55:49.369+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:361,0.037814,9.772311,0.819082
04-23 19:55:49.369+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.369+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:352,0.015705,0.066923,-0.019297
04-23 19:55:49.369+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:353,0.033500,9.817751,0.823131
04-23 19:55:49.379+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.379+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.379+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:387,0.029185,0.019119,-0.039022
04-23 19:55:49.389+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.399+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:396,0.052642,9.839286,0.799203
04-23 19:55:49.409+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:380,-0.070000,0.140000,0.070000
04-23 19:55:49.409+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:401,0.039060,9.772644,0.815034
04-23 19:55:49.409+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.409+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:418,-0.070000,0.070000,-0.070000
04-23 19:55:49.419+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.419+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.429+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.429+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:437,0.037388,9.772763,0.813687
04-23 19:55:49.439+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.439+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:431,0.066999,9.791430,0.780060
04-23 19:55:49.439+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:447,-0.070000,0.070000,-0.070000
04-23 19:55:49.449+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:425,-0.031881,0.042714,-0.003867
04-23 19:55:49.449+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.459+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.459+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.459+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:469,0.037389,9.772983,0.811051
04-23 19:55:49.469+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.469+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:456,0.003290,0.016274,-0.024056
04-23 19:55:49.469+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 19:55:49.469+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:55:49.469+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 19:55:49.479+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:482,-0.070000,0.070000,-0.070000
04-23 19:55:49.489+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.489+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:463,0.007178,9.815358,0.811167
04-23 19:55:49.489+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:494,0.010467,0.030412,0.009688
04-23 19:55:49.499+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.499+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.509+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.509+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:515,-0.070000,0.140000,-0.070000
04-23 19:55:49.519+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.519+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:513,0.037717,9.773054,0.810169
04-23 19:55:49.519+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:527,0.002961,0.044697,0.000998
04-23 19:55:49.529+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:509,0.040678,9.789038,0.789631
04-23 19:55:49.529+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.529+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.529+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:534,0.047856,9.803394,0.820738
04-23 19:55:49.549+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.549+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:543,0.037695,9.773176,0.808694
04-23 19:55:49.549+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:556,-0.070000,0.070000,-0.070000
04-23 19:55:49.559+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.559+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:565,0.000590,0.003897,0.009651
04-23 19:55:49.559+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.569+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.569+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:575,0.037568,9.773251,0.807800
04-23 19:55:49.569+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.579+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.579+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:586,-0.018426,0.030144,-0.003812
04-23 19:55:49.579+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:570,0.040678,9.817751,0.811167
04-23 19:55:49.589+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.609+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:580,-0.070000,0.070000,-0.070000
04-23 19:55:49.609+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.609+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:614,-0.070000,0.070000,-0.070000
04-23 19:55:49.609+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.609+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:618,-0.070000,0.070000,-0.070000
04-23 19:55:49.609+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.629+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.639+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:637,0.038285,9.777073,0.818345
04-23 19:55:49.639+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.639+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.649+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:634,0.036532,9.773387,0.806201
04-23 19:55:49.649+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.659+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:649,0.054395,0.044364,-0.006998
04-23 19:55:49.669+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:655,0.038956,9.773533,0.804315
04-23 19:55:49.669+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.669+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:647,0.019143,9.803394,0.803988
04-23 19:55:49.669+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.679+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.679+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:681,0.090927,9.817751,0.799203
04-23 19:55:49.699+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:675,-0.029384,0.025076,0.045137
04-23 19:55:49.699+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.699+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:683,0.037424,9.773526,0.804467
04-23 19:55:49.699+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:621,-0.070000,0.070000,-0.070000
04-23 19:55:49.699+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.699+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.699+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.719+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:715,0.009571,9.798609,0.849452
04-23 19:55:49.729+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:705,-0.013496,0.017904,-0.017228
04-23 19:55:49.729+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:710,-0.070000,0.070000,-0.070000
04-23 19:55:49.729+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.729+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:721,0.036620,9.773708,0.802289
04-23 19:55:49.739+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.739+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.739+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.749+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:742,0.016022,0.008150,-0.012658
04-23 19:55:49.759+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:750,0.023928,9.791430,0.787239
04-23 19:55:49.759+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.769+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:744,-0.070000,0.210000,-0.070000
04-23 19:55:49.769+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:751,0.037220,9.773846,0.800585
04-23 19:55:49.769+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.769+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:776,-0.070000,0.070000,-0.070000
04-23 19:55:49.769+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:773,0.027386,0.024763,0.020153
04-23 19:55:49.779+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.779+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.789+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:786,0.038355,9.773849,0.800483
04-23 19:55:49.789+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.799+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.799+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:786,0.052642,9.781858,0.789631
04-23 19:55:49.799+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:806,-0.140000,0.070000,-0.070000
04-23 19:55:49.809+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.809+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.809+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:801,0.023858,0.022367,-0.027601
04-23 19:55:49.809+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:817,0.064606,9.798609,0.820738
04-23 19:55:49.829+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.829+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.829+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:834,0.053968,-0.006557,-0.022607
04-23 19:55:49.829+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:820,0.039352,9.774058,0.797882
04-23 19:55:49.829+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:839,-0.140000,0.070000,-0.070000
04-23 19:55:49.839+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.839+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.849+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:853,0.062213,9.796216,0.772882
04-23 19:55:49.849+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:856,0.041803,9.774216,0.795834
04-23 19:55:49.849+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.849+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.859+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.869+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:861,0.001268,0.024393,-0.008596
04-23 19:55:49.869+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.869+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:863,-0.140000,0.070000,-0.070000
04-23 19:55:49.879+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:882,0.041709,9.774337,0.794340
04-23 19:55:49.879+0200 I/servicemanager( 3660): es.ugr.frailty.accelerometer sleep timeout
04-23 19:55:49.879+0200 W/AUL     ( 3660): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 19:55:49.879+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.889+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:55:49.889+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.889+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 3660
04-23 19:55:49.899+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:872,0.093320,9.767502,0.775275
04-23 19:55:49.899+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.899+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.899+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4118
04-23 19:55:49.909+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:906,0.043071,9.798609,0.787239
04-23 19:55:49.919+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:897,-0.140000,0.070000,-0.070000
04-23 19:55:49.919+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:894,0.018111,0.019486,-0.011887
04-23 19:55:49.919+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.929+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.929+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:905,0.042425,9.774460,0.792789
04-23 19:55:49.929+0200 W/AUL     ( 3660): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4118)
04-23 19:55:49.929+0200 I/servicemanager( 3660): es.ugr.frailty.accelerometer stop request sent!
04-23 19:55:49.929+0200 I/servicemanager( 3660): App control destroyed.
04-23 19:55:49.929+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.939+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.949+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:934,-0.140000,0.070000,-0.070000
04-23 19:55:49.949+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:927,0.000646,0.055255,0.006414
04-23 19:55:49.949+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.949+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:944,0.042295,9.774532,0.791902
04-23 19:55:49.959+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:945,0.059821,9.793823,0.782453
04-23 19:55:49.959+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.959+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:962,0.000776,0.021684,0.057550
04-23 19:55:49.959+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:969,-0.070000,0.070000,0.070000
04-23 19:55:49.969+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.979+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.979+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:49:984,0.043071,9.829715,0.799203
04-23 19:55:49.979+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:49:984,0.042477,9.774190,0.796109
04-23 19:55:49.979+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:49.989+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:49.989+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:49:992,-0.006585,0.041168,-0.016049
04-23 19:55:49.989+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:49:996,-0.070000,0.070000,0.070000
04-23 19:55:49.999+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:49.999+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:49.999+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:50:4,0.042302,9.774130,0.796859
04-23 19:55:50.009+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:50:18,0.043071,9.796216,0.849452
04-23 19:55:50.009+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:50.019+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:50.019+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:50:24,-0.070000,0.070000,0.070000
04-23 19:55:50.019+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:50:22,-0.030338,0.053192,0.011915
04-23 19:55:50.019+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:50.019+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:50.039+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:50.049+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:50:32,0.041002,9.773987,0.798671
04-23 19:55:50.049+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:50.049+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:50:37,0.035892,9.815358,0.780060
04-23 19:55:50.049+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:50.059+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:50.069+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:50:69,0.011964,9.827322,0.808774
04-23 19:55:50.069+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:50:56,-0.070000,-0.070000,0.070000
04-23 19:55:50.069+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:50:45,-0.007503,0.022229,0.012496
04-23 19:55:50.069+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:50.079+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:50.079+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:50:65,0.040803,9.773830,0.800602
04-23 19:55:50.079+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:50:87,-0.070000,-0.070000,0.070000
04-23 19:55:50.089+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:50.089+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:50:83,-0.016875,0.051099,0.000994
04-23 19:55:50.099+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:50.099+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:50:105,0.033500,9.796216,0.811167
04-23 19:55:50.099+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:50:103,0.040152,9.773724,0.801934
04-23 19:55:50.099+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:50.109+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:50:113,0.031633,0.000957,0.004447
04-23 19:55:50.109+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:50.119+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:50.119+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:50.129+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:50:118,-0.070000,0.140000,0.070000
04-23 19:55:50.129+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:50.139+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:50.159+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:50:133,0.023928,9.824929,0.801596
04-23 19:55:50.159+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:50:131,0.041798,9.773536,0.804132
04-23 19:55:50.159+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:50.169+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:50:143,-0.034620,0.013109,0.004642
04-23 19:55:50.169+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:50.179+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:50:146,-0.070000,0.070000,0.070000
04-23 19:55:50.189+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:50.189+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:50:194,0.033879,0.044362,-0.028331
04-23 19:55:50.189+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:50.199+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:50:177,0.040299,9.773389,0.805998
04-23 19:55:50.199+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:50:182,0.071785,9.774680,0.806381
04-23 19:55:50.199+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:50.199+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:50:207,0.042065,9.773395,0.805834
04-23 19:55:50.209+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:50.209+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:50:200,-0.070000,0.070000,0.070000
04-23 19:55:50.209+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:50.219+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:50.219+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:50:218,0.007178,9.786645,0.808774
04-23 19:55:50.229+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:50:223,-0.013351,0.046750,-0.040130
04-23 19:55:50.229+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:50.239+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:50.239+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:50:228,-0.070000,0.070000,0.140000
04-23 19:55:50.249+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:50.259+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:50.289+0200 I/gyroscope( 4132): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:50:264,-0.070000,0.070000,0.070000
04-23 19:55:50.289+0200 I/gravity ( 4162): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:50:242,0.041714,9.773287,0.807159
04-23 19:55:50.289+0200 I/accelerometer( 4118): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:50:252,0.074178,9.817751,0.777667
04-23 19:55:50.289+0200 I/gravity ( 4162): capturing data from es.ugr.frailty.gravity
04-23 19:55:50.299+0200 I/linearacceleration( 4148): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:50:259,0.013321,0.020536,0.008793
04-23 19:55:50.299+0200 I/accelerometer( 4118): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:50.309+0200 I/linearacceleration( 4148): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:50.319+0200 I/gyroscope( 4132): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:50.319+0200 W/CRASH_MANAGER( 3827): worker.c: worker_job(1205) > 11041456c6f63152450614
