S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 13040
Date: 2018-06-07 16:56:30+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf74ae52d, r5   = 0xf760ef98
r6   = 0xffc1a340, r7   = 0xffc1a1f0
r8   = 0xf760bc18, r9   = 0x00000000
r10  = 0xffc1a2cc, fp   = 0xffc1a340
ip   = 0x00000001, sp   = 0xffc1a1c8
lr   = 0xf74ae539, pc   = 0xf7517228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    293616 KB
Buffers:      4468 KB
Cached:      61008 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11552 KB
VmRSS:       11552 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 13040 TID = 13040
13040 13045 

Maps Information
f4379000 f4b78000 rw-p [stack:13045]
f4b7f000 f4b81000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b89000 f4b8d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b96000 f4b98000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4ba0000 f4ba3000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4bb2000 f4bb7000 r-xp /usr/lib/libsystem.so.0.0.0
f4bc2000 f4bc5000 r-xp /lib/libattr.so.1.1.0
f4bcd000 f4bdd000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4be5000 f4bee000 r-xp /usr/lib/libedbus.so.1.7.99
f4bf6000 f4bf7000 r-xp /usr/lib/libresponse.so.0.2.96
f4c00000 f4c05000 r-xp /usr/lib/libproc-stat.so.0.2.96
f64a7000 f65ad000 r-xp /usr/lib/libicuuc.so.57.1
f65c3000 f674b000 r-xp /usr/lib/libicui18n.so.57.1
f675b000 f6768000 r-xp /usr/lib/libail.so.0.1.0
f6771000 f6778000 r-xp /usr/lib/libminizip.so.1.0.0
f6781000 f692a000 r-xp /usr/lib/libcrypto.so.1.0.0
f694a000 f6991000 r-xp /usr/lib/libssl.so.1.0.0
f699d000 f699f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f69a7000 f69ae000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f69b7000 f69be000 r-xp /lib/libcrypt-2.13.so
f69ef000 f69f2000 r-xp /lib/libcap.so.2.21
f69fa000 f69fc000 r-xp /usr/lib/libiri.so
f6a04000 f6a4d000 r-xp /usr/lib/libmdm.so.1.2.69
f6a55000 f6a5b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a63000 f6a86000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a90000 f6a92000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a9a000 f6ab7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6ac0000 f6ac4000 r-xp /usr/lib/libsmack.so.1.0.0
f6acd000 f6ae6000 r-xp /usr/lib/libnetwork.so.0.0.0
f6aef000 f6af7000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6aff000 f6b05000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b0e000 f6b10000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b19000 f6b29000 r-xp /lib/libresolv-2.13.so
f6b2d000 f6b45000 r-xp /usr/lib/liblzma.so.5.0.3
f6b4e000 f6b50000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b58000 f6b72000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b7a000 f6ba9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bb2000 f6bc1000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6bcb000 f6bd5000 r-xp /usr/lib/libsensord-shared.so
f6bde000 f6cb1000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6cbc000 f6cd2000 r-xp /lib/libz.so.1.2.5
f6cda000 f6cdf000 r-xp /usr/lib/libffi.so.5.0.10
f6ce7000 f6ce8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6cf0000 f6d00000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d08000 f6d21000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d29000 f6d2b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d33000 f6da8000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6db2000 f6db8000 r-xp /lib/librt-2.13.so
f6dc1000 f6ddf000 r-xp /usr/lib/libsystemd.so.0.4.0
f6de9000 f6dea000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6df2000 f6e15000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e1d000 f6e22000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e2a000 f6e54000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e5d000 f6e74000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e7c000 f6ee5000 r-xp /lib/libm-2.13.so
f6eee000 f6f82000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f95000 f6f9a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6fa2000 f6fa9000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6fb1000 f6fdb000 r-xp /usr/lib/libsensor.so.1.9.6
f6fe4000 f70b0000 r-xp /usr/lib/libxml2.so.2.7.8
f70bd000 f70bf000 r-xp /usr/lib/libiniparser.so.0
f70c8000 f70ce000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f70d7000 f71a7000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71a8000 f71dc000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f71e5000 f7221000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7229000 f722c000 r-xp /usr/lib/libbundle.so.0.1.22
f7234000 f723a000 r-xp /usr/lib/libappsvc.so.0.1.0
f7242000 f7283000 r-xp /usr/lib/libeina.so.1.7.99
f728c000 f72a3000 r-xp /usr/lib/libecore.so.1.7.99
f72ba000 f72c3000 r-xp /usr/lib/libvconf.so.0.2.45
f72cb000 f72df000 r-xp /lib/libpthread-2.13.so
f72ea000 f72f7000 r-xp /usr/lib/libaul.so.0.1.0
f7301000 f7303000 r-xp /lib/libdl-2.13.so
f730c000 f7317000 r-xp /lib/libunwind.so.8.0.1
f7344000 f734c000 r-xp /lib/libgcc_s-4.6.so.1
f734d000 f7471000 r-xp /lib/libc-2.13.so
f747f000 f7481000 r-xp /usr/lib/libdlog.so.0.0.0
f7489000 f7495000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f749e000 f74a3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74ab000 f74ba000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f74c2000 f74c6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74cf000 f74d2000 r-xp /usr/lib/libappcore-agent.so.1.1
f74da000 f74dc000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f74e4000 f74e8000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f74f0000 f750d000 r-xp /lib/ld-2.13.so
f7516000 f7519000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7519000 f751d000 r-xp /usr/lib/libsys-assert.so
f75db000 f7669000 rw-p [heap]
ffbfb000 ffc1c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13040)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7517228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf74ae539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71b53f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf71b3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf71bfe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf71c5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf71c5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf71fa75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71f51f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf71b3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf71bfe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf71c5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf71c5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf71f7e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf71f8017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf71fff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b971fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b8a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c5d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf710afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf710c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf729cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7297b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72985a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7298879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf74d0183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74d07fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75175c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf736485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7516f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
6-07 16:56:29.761+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:29.771+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:29.771+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:29.781+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:29:772,0.059260,0.050943,-0.009192
06-07 16:56:29.781+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:29.781+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:29:773,8.874979,0.490529,4.264010
06-07 16:56:29.781+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:29.781+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:29:780,8.815287,0.441062,4.273942
06-07 16:56:29.781+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:29:788,0.035660,0.003244,0.091014
06-07 16:56:29.791+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:29:779,-0.910000,0.070000,0.140000
06-07 16:56:29.791+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:29.791+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:29.801+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:29:800,-0.840000,0.140000,-0.210000
06-07 16:56:29.801+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:29.801+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:29:801,8.811602,0.438782,4.281767
06-07 16:56:29.801+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:29:792,8.853443,0.445065,4.359723
06-07 16:56:29.801+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:29.801+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:29:808,0.071657,-0.041461,0.112103
06-07 16:56:29.811+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:29.811+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:29.811+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:29:819,1.680000,-0.350000,-0.210000
06-07 16:56:29.821+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:29.821+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:29:820,8.813175,0.437946,4.278614
06-07 16:56:29.821+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:29:813,8.886944,0.399601,4.386044
06-07 16:56:29.821+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:29.821+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:29:826,0.001164,-0.043966,0.061206
06-07 16:56:29.831+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:29:830,8.812766,0.394816,4.342973
06-07 16:56:29.831+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:29.831+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:29.841+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:29:841,8.812279,0.437551,4.280499
06-07 16:56:29.841+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:29:840,0.560000,-0.070000,-0.420000
06-07 16:56:29.841+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:56:29.841+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:29.841+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:56:29:847,94
06-07 16:56:29.841+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:29.851+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:29:849,8.841480,0.409173,4.316652
06-07 16:56:29.851+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:29:854,0.028305,-0.028773,0.038038
06-07 16:56:29.851+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:56:29.851+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:29.861+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:29.861+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:29:866,8.809716,0.439018,4.285622
06-07 16:56:29.861+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:56:29:864,497.000000
06-07 16:56:29.861+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:29.871+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:29.871+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:29.871+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:29:866,0.210000,0.140000,-0.420000
06-07 16:56:29.871+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:29.881+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer alive timeout
06-07 16:56:29.881+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 16:56:29.881+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:29.881+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:29.881+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:29:884,0.700000,0.490000,0.210000
06-07 16:56:29.881+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:29:879,0.019629,0.014692,0.072045
06-07 16:56:29.891+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:29.901+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13026
06-07 16:56:29.901+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13026)
06-07 16:56:29.901+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer launch request sent!
06-07 16:56:29.901+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:29.901+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope alive timeout
06-07 16:56:29.901+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 16:56:29.901+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:29.901+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:29.901+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:29:880,8.810570,0.441139,4.283649
06-07 16:56:29.901+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:29.911+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:29:913,8.810155,0.442436,4.284368
06-07 16:56:29.911+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:29.911+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13058
06-07 16:56:29.921+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13058)
06-07 16:56:29.921+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope launch request sent!
06-07 16:56:29.921+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:29.921+0200 I/servicemanager(12566): es.ugr.frailty.heartrate alive timeout
06-07 16:56:29.921+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 16:56:29.921+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:29.921+0200 W/CAPI_APPFW_APP_CONTROL(13058): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:29.921+0200 I/utils   (13058): specific action
06-07 16:56:29.921+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:29.921+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:29.921+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:29:928,0.210000,0.140000,0.140000
06-07 16:56:29.921+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:29.931+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:29:875,8.831908,0.452243,4.352544
06-07 16:56:29.931+0200 W/CAPI_APPFW_APP_CONTROL(13026): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:29.931+0200 I/utils   (13026): specific action
06-07 16:56:29.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12595
06-07 16:56:29.931+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:29.931+0200 W/CAPI_APPFW_APP_CONTROL(12595): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:29.931+0200 I/utils   (12595): specific action
06-07 16:56:29.931+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12595)
06-07 16:56:29.931+0200 I/servicemanager(12566): es.ugr.frailty.heartrate launch request sent!
06-07 16:56:29.931+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:29.931+0200 I/servicemanager(12566): es.ugr.frailty.location alive timeout
06-07 16:56:29.931+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 16:56:29.931+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:29.941+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:29.941+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:29:897,0.050905,0.046725,0.057352
06-07 16:56:29.941+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:29.941+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:29:947,0.030910,0.032640,0.073681
06-07 16:56:29.941+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:29.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13040
06-07 16:56:29.951+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13040)
06-07 16:56:29.951+0200 I/servicemanager(12566): es.ugr.frailty.location launch request sent!
06-07 16:56:29.951+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:29.951+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration alive timeout
06-07 16:56:29.951+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 16:56:29.951+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:29.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(13026), cmd(0)
06-07 16:56:29.951+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:29.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(13058), cmd(0)
06-07 16:56:29.951+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:29.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(12595), cmd(0)
06-07 16:56:29.951+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:29:942,8.860621,0.485743,4.342973
06-07 16:56:29.951+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:29.951+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:29.951+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:29:933,0.420000,-0.490000,-0.350000
06-07 16:56:29.951+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:29.961+0200 W/CAPI_APPFW_APP_CONTROL(13040): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:29.961+0200 I/utils   (13040): specific action
06-07 16:56:29.961+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:29.961+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13072
06-07 16:56:29.961+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13072)
06-07 16:56:29.961+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration launch request sent!
06-07 16:56:29.961+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:29.961+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(13040), cmd(0)
06-07 16:56:29.961+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:29.961+0200 I/servicemanager(12566): es.ugr.frailty.gravity alive timeout
06-07 16:56:29.961+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 16:56:29.961+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:29:922,8.808775,0.444745,4.286966
06-07 16:56:29.961+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:29.961+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:29.971+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:29:963,8.841480,0.473779,4.357330
06-07 16:56:29.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13086
06-07 16:56:29.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13086)
06-07 16:56:29.981+0200 I/servicemanager(12566): es.ugr.frailty.gravity launch request sent!
06-07 16:56:29.981+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:29.981+0200 I/servicemanager(12566): es.ugr.frailty.pressure alive timeout
06-07 16:56:29.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 16:56:29.981+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:29:952,0.064824,0.036129,0.094498
06-07 16:56:29.981+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:29.981+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:29.981+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:29.981+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:29:990,8.874979,0.478565,4.378866
06-07 16:56:29.991+0200 W/CAPI_APPFW_APP_CONTROL(13072): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:29.991+0200 I/utils   (13072): specific action
06-07 16:56:29.991+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:29.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12603
06-07 16:56:29.991+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:29.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(13072), cmd(0)
06-07 16:56:29.991+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:29.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(12603), cmd(0)
06-07 16:56:29.991+0200 W/CAPI_APPFW_APP_CONTROL(12603): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:29.991+0200 I/utils   (12603): specific action
06-07 16:56:29.991+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:29.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(13086), cmd(0)
06-07 16:56:29.991+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12603)
06-07 16:56:29.991+0200 W/CAPI_APPFW_APP_CONTROL(13086): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:29.991+0200 I/utils   (13086): specific action
06-07 16:56:29.991+0200 I/servicemanager(12566): es.ugr.frailty.pressure launch request sent!
06-07 16:56:29.991+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:29.991+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:29.991+0200 I/servicemanager(12566): es.ugr.frailty.light alive timeout
06-07 16:56:29.991+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 16:56:29.991+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:29.991+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:29:975,0.490000,-0.840000,-0.350000
06-07 16:56:30.001+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:30.001+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:30.001+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:30:6,0.350000,0.140000,0.350000
06-07 16:56:30.001+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:29:996,0.059026,0.012284,-0.037313
06-07 16:56:30.001+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:30.011+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12614
06-07 16:56:30.011+0200 W/CAPI_APPFW_APP_CONTROL(12614): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:30.011+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12614)
06-07 16:56:30.011+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 16:56:30.011+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:30.011+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:30.011+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12614), cmd(0)
06-07 16:56:30.011+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 16:56:30.011+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 16:56:30.011+0200 I/utils   (12614): specific action
06-07 16:56:30.011+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:30.011+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:30.011+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.011+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:30:16,8.867801,0.457029,4.249653
06-07 16:56:30.021+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:30.021+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 16:56:30.021+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 16:56:30.021+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 16:56:30.021+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:30.021+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:30.021+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12618), cmd(0)
06-07 16:56:30.021+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:30.021+0200 I/utils   (12618): specific action
06-07 16:56:30.021+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:30:28,-0.630000,0.980000,0.280000
06-07 16:56:30.021+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:4,8.810339,0.446084,4.283611
06-07 16:56:30.031+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.031+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:25,0.086175,0.039658,-0.069850
06-07 16:56:30.031+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:30.031+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.031+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:36,8.814178,0.447464,4.275563
06-07 16:56:30.031+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.031+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:40,8.813070,0.450934,4.277479
06-07 16:56:30.031+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.041+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:30.041+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:45,8.806337,0.448551,4.291574
06-07 16:56:30.041+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.051+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:52,8.807241,0.442666,4.290330
06-07 16:56:30.051+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.051+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:56:30.051+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:56:30.051+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:56:30.061+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:56,8.810449,0.439653,4.284050
06-07 16:56:30.061+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:56:30.061+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:56:30:67,498.000000
06-07 16:56:30.061+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.071+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:72,8.815207,0.444962,4.273699
06-07 16:56:30.071+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:56:30.071+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:56:30:77,94
06-07 16:56:30.071+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.081+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:83,8.819524,0.449439,4.264316
06-07 16:56:30.101+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:30:38,8.896514,0.485743,4.213760
06-07 16:56:30.101+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:30.111+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:41,0.067981,0.093314,0.026732
06-07 16:56:30.111+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.111+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.131+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:30:122,-2.100000,0.770000,0.280000
06-07 16:56:30.131+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:30.131+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:116,-0.012268,-0.013048,0.180349
06-07 16:56:30.141+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:30:114,8.882158,0.540778,4.302295
06-07 16:56:30.151+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:30.161+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:125,8.819766,0.452501,4.263491
06-07 16:56:30.161+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.161+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.171+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:30:156,8.800802,0.437887,4.457829
06-07 16:56:30.171+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:30.181+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:167,8.820525,0.452675,4.261902
06-07 16:56:30.181+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.191+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:30:142,0.280000,-0.770000,0.560000
06-07 16:56:30.191+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:30.191+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:174,-0.017500,-0.103985,0.149505
06-07 16:56:30.191+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.201+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:30:182,8.788837,0.344566,4.441079
06-07 16:56:30.201+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:30.201+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:194,8.820117,0.449571,4.263074
06-07 16:56:30.211+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:30:196,2.240000,-0.630000,-0.140000
06-07 16:56:30.211+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:30.211+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.211+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:198,0.067738,-0.090921,0.098107
06-07 16:56:30.221+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.221+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:230,0.023852,0.079590,0.013459
06-07 16:56:30.231+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:218,8.817973,0.448025,4.267670
06-07 16:56:30.231+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.231+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:30:216,2.660000,-0.630000,-0.070000
06-07 16:56:30.231+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:30:212,8.874979,0.351745,4.388437
06-07 16:56:30.231+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:30.231+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:30.241+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:56:30.251+0200 W/LOCATION(13040): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 16:56:30.251+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:237,8.818642,0.445116,4.266593
06-07 16:56:30.251+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.251+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:56:30.261+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:56:30:251,94
06-07 16:56:30.261+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:56:30:264,498.000000
06-07 16:56:30.261+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:261,8.820819,0.444089,4.262197
06-07 16:56:30.261+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.261+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.261+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:271,8.822944,0.444535,4.257751
06-07 16:56:30.271+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.271+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:276,8.823688,0.444474,4.256215
06-07 16:56:30.271+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.271+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:281,8.823534,0.447093,4.256259
06-07 16:56:30.281+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.281+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:30:243,1.120000,-0.280000,0.420000
06-07 16:56:30.281+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:30.281+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:287,8.821744,0.448223,4.259849
06-07 16:56:30.281+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:30:241,8.834301,0.519243,4.297509
06-07 16:56:30.281+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:30.291+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:271,0.040628,0.098209,-0.024046
06-07 16:56:30.291+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.291+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.291+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:300,8.822144,0.447758,4.259070
06-07 16:56:30.291+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:30:288,-0.840000,0.420000,0.490000
06-07 16:56:30.301+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:297,0.043491,0.093731,-0.007484
06-07 16:56:30.301+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.301+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:30:292,8.855836,0.543171,4.249653
06-07 16:56:30.301+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:30.311+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:30.311+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.311+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:30:312,8.863015,0.543171,4.256832
06-07 16:56:30.311+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:30.311+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:320,8.820648,0.450945,4.261830
06-07 16:56:30.321+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:30:316,-0.560000,0.560000,0.700000
06-07 16:56:30.321+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:30.321+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:30:327,0.210000,-0.350000,0.070000
06-07 16:56:30.321+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:307,0.040855,0.038028,0.031626
06-07 16:56:30.321+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.331+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:333,0.066419,-0.060252,0.121748
06-07 16:56:30.331+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.331+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.331+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:30:323,8.860621,0.490529,4.295116
06-07 16:56:30.331+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:30.331+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:339,8.821463,0.454545,4.259763
06-07 16:56:30.331+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:30.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:56:30.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:56:30.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:56:30.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:56:30.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390590349,000000, pattern:[H:mm][0;m
06-07 16:56:30.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:56:30.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:56:30.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:56:30.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:56:30.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:56:30.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:56][0;m
06-07 16:56:30.341+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:338,0.026149,-0.045184,0.120577
06-07 16:56:30.341+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.351+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:30:341,8.886944,0.392423,4.383651
06-07 16:56:30.351+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:30.351+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:30:344,0.420000,0.070000,-0.280000
06-07 16:56:30.351+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:30.351+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.361+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:351,0.013935,-0.057995,0.108802
06-07 16:56:30.361+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:364,8.822648,0.458973,4.256831
06-07 16:56:30.361+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.361+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:368,0.020445,-0.021587,0.059631
06-07 16:56:30.361+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.371+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:30:359,0.630000,-0.420000,0.210000
06-07 16:56:30.371+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:30.371+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.371+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:30:357,8.846266,0.404387,4.383651
06-07 16:56:30.371+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:30.371+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:379,8.824759,0.461224,4.252210
06-07 16:56:30.371+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:30:376,1.050000,-0.140000,0.280000
06-07 16:56:30.381+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:30:381,8.831908,0.390030,4.376472
06-07 16:56:30.381+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:30.381+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:30.391+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:372,0.051767,0.015333,0.030527
06-07 16:56:30.391+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.391+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.391+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:30:391,0.630000,-0.140000,0.280000
06-07 16:56:30.391+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:30.391+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:400,8.823574,0.457910,4.255026
06-07 16:56:30.401+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:30:389,8.839087,0.423530,4.326223
06-07 16:56:30.401+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:30.401+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:398,0.068786,-0.013827,0.049330
06-07 16:56:30.411+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:30:403,0.910000,0.070000,-0.140000
06-07 16:56:30.411+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:30.411+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.411+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.411+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:420,8.823723,0.457984,4.254709
06-07 16:56:30.421+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:30:407,8.872586,0.459422,4.292724
06-07 16:56:30.421+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:30.421+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:418,0.044113,0.031698,0.000617
06-07 16:56:30.421+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.431+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:30:416,0.770000,0.210000,-0.420000
06-07 16:56:30.431+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:30.431+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.431+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:440,8.825853,0.460320,4.250035
06-07 16:56:30.441+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:56:30.441+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:30:431,8.891729,0.430708,4.307081
06-07 16:56:30.441+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:56:30:447,94
06-07 16:56:30.441+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:30.441+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:434,-0.015554,0.002758,0.115427
06-07 16:56:30.441+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:30:436,0.840000,-0.350000,-0.350000
06-07 16:56:30.451+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.451+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:30.451+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:456,0.019736,-0.017515,0.075946
06-07 16:56:30.451+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.451+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:30:459,0.700000,-0.630000,-0.070000
06-07 16:56:30.451+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.461+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:56:30.461+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:56:30:466,498.000000
06-07 16:56:30.461+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:465,8.827489,0.463218,4.246321
06-07 16:56:30.461+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:30:453,8.867801,0.476172,4.256832
06-07 16:56:30.461+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:461,0.028907,0.049949,0.083903
06-07 16:56:30.461+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.461+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:471,0.056724,0.051547,0.073964
06-07 16:56:30.461+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:30.471+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.471+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:30.471+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.471+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:475,0.046338,0.064698,0.080817
06-07 16:56:30.471+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.471+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:479,8.824455,0.462523,4.252698
06-07 16:56:30.481+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:482,0.064296,0.019591,0.026321
06-07 16:56:30.481+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.481+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:30:479,0.630000,-0.210000,-0.350000
06-07 16:56:30.481+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:487,-0.000029,-0.068801,0.028549
06-07 16:56:30.481+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.481+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:30:475,8.807980,0.449851,4.371687
06-07 16:56:30.481+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:30.491+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:492,0.070547,-0.015238,0.028126
06-07 16:56:30.491+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.491+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.491+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:496,0.082363,0.032545,-0.048127
06-07 16:56:30.491+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.491+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:500,8.824494,0.463933,4.252464
06-07 16:56:30.491+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:502,0.037162,0.068494,-0.021917
06-07 16:56:30.501+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.501+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:506,0.057061,-0.039689,0.082295
06-07 16:56:30.501+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.501+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:30.501+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:511,-0.021260,0.018434,0.071133
06-07 16:56:30.501+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:30:495,8.841480,0.430708,4.335794
06-07 16:56:30.511+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:30.511+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:30:511,1.540000,-0.280000,-0.280000
06-07 16:56:30.511+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:30.511+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.511+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.511+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:520,8.824119,0.462404,4.253409
06-07 16:56:30.511+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:520,0.024164,-0.035618,0.042652
06-07 16:56:30.521+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:30:519,1.610000,-1.400000,-0.420000
06-07 16:56:30.521+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:30:516,8.851050,0.497707,4.342973
06-07 16:56:30.521+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:30.531+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:30.531+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.531+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.531+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:539,8.824338,0.463234,4.252866
06-07 16:56:30.531+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:539,0.029325,-0.005374,0.027350
06-07 16:56:30.541+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:30:533,8.877372,0.502493,4.335794
06-07 16:56:30.541+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:30:537,1.610000,-0.700000,-0.350000
06-07 16:56:30.541+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:30.541+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:30:550,8.867801,0.519243,4.340580
06-07 16:56:30.541+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:30.551+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:30:554,-0.560000,-0.840000,-0.210000
06-07 16:56:30.551+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:30.551+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:30.551+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.561+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:564,0.060212,0.079936,0.097286
06-07 16:56:30.561+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.571+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:573,8.822322,0.468485,4.256472
06-07 16:56:30.571+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.571+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.581+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:30:578,8.886944,0.478565,4.283153
06-07 16:56:30.581+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:584,8.820666,0.473367,4.259361
06-07 16:56:30.591+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:30:579,0.630000,-0.210000,-0.350000
06-07 16:56:30.591+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:30.591+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:30.591+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:580,0.026337,0.072293,0.055395
06-07 16:56:30.591+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:30.591+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:30:600,8.820369,0.475846,4.259700
06-07 16:56:30.591+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:30.591+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:30:601,0.047134,0.024340,0.038148
06-07 16:56:30.601+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11130406c6f63152838339
