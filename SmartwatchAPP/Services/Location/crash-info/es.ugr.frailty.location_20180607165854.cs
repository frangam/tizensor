S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 13769
Date: 2018-06-07 16:58:54+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf75f252d, r5   = 0xf7764f98
r6   = 0xff82a650, r7   = 0xff82a500
r8   = 0xf7761c18, r9   = 0x00000000
r10  = 0xff82a5dc, fp   = 0xff82a650
ip   = 0x00000001, sp   = 0xff82a4d8
lr   = 0xf75f2539, pc   = 0xf765b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    173296 KB
Buffers:      7936 KB
Cached:      51180 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11528 KB
VmRSS:       11528 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 13769 TID = 13769
13769 13773 

Maps Information
f44bd000 f4cbc000 rw-p [stack:13773]
f4cc3000 f4cc5000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ccd000 f4cd1000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4cda000 f4cdc000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4ce4000 f4ce7000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4cf6000 f4cfb000 r-xp /usr/lib/libsystem.so.0.0.0
f4d06000 f4d09000 r-xp /lib/libattr.so.1.1.0
f4d11000 f4d21000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d29000 f4d32000 r-xp /usr/lib/libedbus.so.1.7.99
f4d3a000 f4d3b000 r-xp /usr/lib/libresponse.so.0.2.96
f4d44000 f4d49000 r-xp /usr/lib/libproc-stat.so.0.2.96
f65eb000 f66f1000 r-xp /usr/lib/libicuuc.so.57.1
f6707000 f688f000 r-xp /usr/lib/libicui18n.so.57.1
f689f000 f68ac000 r-xp /usr/lib/libail.so.0.1.0
f68b5000 f68bc000 r-xp /usr/lib/libminizip.so.1.0.0
f68c5000 f6a6e000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a8e000 f6ad5000 r-xp /usr/lib/libssl.so.1.0.0
f6ae1000 f6ae3000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6aeb000 f6af2000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6afb000 f6b02000 r-xp /lib/libcrypt-2.13.so
f6b33000 f6b36000 r-xp /lib/libcap.so.2.21
f6b3e000 f6b40000 r-xp /usr/lib/libiri.so
f6b48000 f6b91000 r-xp /usr/lib/libmdm.so.1.2.69
f6b99000 f6b9f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6ba7000 f6bca000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6bd4000 f6bd6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6bde000 f6bfb000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c04000 f6c08000 r-xp /usr/lib/libsmack.so.1.0.0
f6c11000 f6c2a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c33000 f6c3b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c43000 f6c49000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c52000 f6c54000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c5d000 f6c6d000 r-xp /lib/libresolv-2.13.so
f6c71000 f6c89000 r-xp /usr/lib/liblzma.so.5.0.3
f6c92000 f6c94000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c9c000 f6cb6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6cbe000 f6ced000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6cf6000 f6d05000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d0f000 f6d19000 r-xp /usr/lib/libsensord-shared.so
f6d22000 f6df5000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e00000 f6e16000 r-xp /lib/libz.so.1.2.5
f6e1e000 f6e23000 r-xp /usr/lib/libffi.so.5.0.10
f6e2b000 f6e2c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e34000 f6e44000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e4c000 f6e65000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e6d000 f6e6f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e77000 f6eec000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ef6000 f6efc000 r-xp /lib/librt-2.13.so
f6f05000 f6f23000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f2d000 f6f2e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f36000 f6f59000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f61000 f6f66000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f6e000 f6f98000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6fa1000 f6fb8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6fc0000 f7029000 r-xp /lib/libm-2.13.so
f7032000 f70c6000 r-xp /usr/lib/libstdc++.so.6.0.16
f70d9000 f70de000 r-xp /usr/lib/libctx-client.so.0.8.3
f70e6000 f70ed000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70f5000 f711f000 r-xp /usr/lib/libsensor.so.1.9.6
f7128000 f71f4000 r-xp /usr/lib/libxml2.so.2.7.8
f7201000 f7203000 r-xp /usr/lib/libiniparser.so.0
f720c000 f7212000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f721b000 f72eb000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f72ec000 f7320000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7329000 f7365000 r-xp /usr/lib/libSLP-location.so.0.9.24
f736d000 f7370000 r-xp /usr/lib/libbundle.so.0.1.22
f7378000 f737e000 r-xp /usr/lib/libappsvc.so.0.1.0
f7386000 f73c7000 r-xp /usr/lib/libeina.so.1.7.99
f73d0000 f73e7000 r-xp /usr/lib/libecore.so.1.7.99
f73fe000 f7407000 r-xp /usr/lib/libvconf.so.0.2.45
f740f000 f7423000 r-xp /lib/libpthread-2.13.so
f742e000 f743b000 r-xp /usr/lib/libaul.so.0.1.0
f7445000 f7447000 r-xp /lib/libdl-2.13.so
f7450000 f745b000 r-xp /lib/libunwind.so.8.0.1
f7488000 f7490000 r-xp /lib/libgcc_s-4.6.so.1
f7491000 f75b5000 r-xp /lib/libc-2.13.so
f75c3000 f75c5000 r-xp /usr/lib/libdlog.so.0.0.0
f75cd000 f75d9000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75e2000 f75e7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75ef000 f75fe000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7606000 f760a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7613000 f7616000 r-xp /usr/lib/libappcore-agent.so.1.1
f761e000 f7620000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7628000 f762c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7634000 f7651000 r-xp /lib/ld-2.13.so
f765a000 f765d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f765d000 f7661000 r-xp /usr/lib/libsys-assert.so
f7731000 f77bf000 rw-p [heap]
ff80b000 ff82c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13769)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf765b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf75f2539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72f93f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf72f7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7303e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7309be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7309dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf733e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73391f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf72f7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7303e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7309be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7309dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf733be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf733c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7343f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4cdb1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4cce171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6da1663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf724efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72507a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf73e0ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf73dbb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73dc5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf73dc879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7614183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76147fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf765b5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf74a885c) [/lib/libc.so.6] + 0x1785c
29: (0xf765af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
614): es.ugr.frailty.light: SM-R760,07/06/2018,16:58:53:765,815.000000
06-07 16:58:53.761+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:53.771+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:53:766,2.352145,-0.495314,9.501899
06-07 16:58:53.771+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:53:769,0.910000,0.490000,-0.350000
06-07 16:58:53.771+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:53:765,2.108773,-0.591970,9.558925
06-07 16:58:53.771+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:53.771+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:53.781+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:53.781+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:53:772,0.247967,0.103785,-0.057594
06-07 16:58:53.781+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:53.781+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:53:788,2.376073,-0.524028,9.499505
06-07 16:58:53.781+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:53:789,0.267300,0.067942,-0.059420
06-07 16:58:53.791+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:53:786,0.280000,0.910000,-0.350000
06-07 16:58:53.791+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:53:783,2.115787,-0.587776,9.557633
06-07 16:58:53.791+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:53.791+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:53.791+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:53.801+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:53.801+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:53:805,0.280000,0.700000,-0.350000
06-07 16:58:53.801+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:53:806,0.233965,0.094854,0.032800
06-07 16:58:53.801+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:53:801,2.120807,-0.582094,9.556868
06-07 16:58:53.811+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:53:811,2.349752,-0.492921,9.590433
06-07 16:58:53.811+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:53.811+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:53.811+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:53:819,0.272015,0.084387,0.095779
06-07 16:58:53.821+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:53.821+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:53.821+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:53:826,2.126405,-0.577228,9.555920
06-07 16:58:53.821+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:53:828,2.392823,-0.497707,9.652647
06-07 16:58:53.821+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:53:820,0.140000,0.910000,0.350000
06-07 16:58:53.831+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:53.831+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:53.831+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:53:839,0.192241,0.012522,0.127833
06-07 16:58:53.841+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:53.841+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:53.841+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:53:840,0.140000,-0.560000,0.350000
06-07 16:58:53.841+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:53:846,2.132653,-0.576108,9.554595
06-07 16:58:53.851+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:53:847,2.318645,-0.564706,9.683753
06-07 16:58:53.851+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:53.851+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:53.861+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:53.861+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:53.861+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer alive timeout
06-07 16:58:53.861+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 16:58:53.861+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:53:864,0.280000,-0.420000,0.280000
06-07 16:58:53.861+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:58:53.871+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:58:53.871+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:53:869,2.333002,-0.598206,9.564112
06-07 16:58:53.871+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:53.881+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:53.881+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:53:880,0.560000,-0.700000,0.280000
06-07 16:58:53.881+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13664
06-07 16:58:53.881+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13664)
06-07 16:58:53.881+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer launch request sent!
06-07 16:58:53.881+0200 I/servicemanager(12566): App control destroyed.
06-07 16:58:53.881+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope alive timeout
06-07 16:58:53.881+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 16:58:53.881+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:58:53.881+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:58:53.881+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:53:885,2.364109,-0.569492,9.547362
06-07 16:58:53.891+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:53:864,0.200350,-0.022098,0.009517
06-07 16:58:53.891+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:53.891+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:53:899,0.910000,-0.280000,0.070000
06-07 16:58:53.891+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13724
06-07 16:58:53.901+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13724)
06-07 16:58:53.901+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope launch request sent!
06-07 16:58:53.901+0200 I/servicemanager(12566): App control destroyed.
06-07 16:58:53.901+0200 I/servicemanager(12566): es.ugr.frailty.heartrate alive timeout
06-07 16:58:53.901+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 16:58:53.901+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:58:53.901+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:58:53.901+0200 W/CAPI_APPFW_APP_CONTROL(13724): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:53.901+0200 I/utils   (13724): specific action
06-07 16:58:53.901+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:53:869,2.140141,-0.576631,9.552889
06-07 16:58:53.901+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:53.911+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:53:913,2.148063,-0.575313,9.551189
06-07 16:58:53.911+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12595
06-07 16:58:53.911+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:53.911+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12595)
06-07 16:58:53.911+0200 I/servicemanager(12566): es.ugr.frailty.heartrate launch request sent!
06-07 16:58:53.911+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:53.911+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(13724), cmd(0)
06-07 16:58:53.911+0200 I/servicemanager(12566): App control destroyed.
06-07 16:58:53.911+0200 I/servicemanager(12566): es.ugr.frailty.location alive timeout
06-07 16:58:53.911+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 16:58:53.911+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:58:53.911+0200 W/CAPI_APPFW_APP_CONTROL(12595): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:53.911+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:58:53.921+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:53.921+0200 I/utils   (12595): specific action
06-07 16:58:53.921+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:53:926,1.330000,0.210000,0.070000
06-07 16:58:53.921+0200 W/CAPI_APPFW_APP_CONTROL(13664): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:53.931+0200 I/utils   (13664): specific action
06-07 16:58:53.931+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:53.931+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:53.931+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:53.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13769
06-07 16:58:53.931+0200 W/CAPI_APPFW_APP_CONTROL(13769): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:53.931+0200 I/utils   (13769): specific action
06-07 16:58:53.931+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:53.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(13664), cmd(0)
06-07 16:58:53.931+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:53.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(12595), cmd(0)
06-07 16:58:53.931+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:53.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(13769), cmd(0)
06-07 16:58:53.931+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13769)
06-07 16:58:53.931+0200 I/servicemanager(12566): es.ugr.frailty.location launch request sent!
06-07 16:58:53.931+0200 I/servicemanager(12566): App control destroyed.
06-07 16:58:53.931+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration alive timeout
06-07 16:58:53.931+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 16:58:53.931+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:58:53.931+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:58:53.941+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:58:53.941+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:58:53:946,84
06-07 16:58:53.941+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13728
06-07 16:58:53.951+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13728)
06-07 16:58:53.951+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration launch request sent!
06-07 16:58:53.951+0200 I/servicemanager(12566): App control destroyed.
06-07 16:58:53.951+0200 I/servicemanager(12566): es.ugr.frailty.gravity alive timeout
06-07 16:58:53.951+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 16:58:53.951+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:58:53.951+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:58:53.951+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:53:952,0.223968,0.007139,-0.005527
06-07 16:58:53.951+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:53:939,0.700000,-0.070000,0.140000
06-07 16:58:53.951+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:58:53.961+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:58:53:964,815.000000
06-07 16:58:53.961+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13685
06-07 16:58:53.961+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13685)
06-07 16:58:53.961+0200 I/servicemanager(12566): es.ugr.frailty.gravity launch request sent!
06-07 16:58:53.961+0200 I/servicemanager(12566): App control destroyed.
06-07 16:58:53.961+0200 I/servicemanager(12566): es.ugr.frailty.pressure alive timeout
06-07 16:58:53.961+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 16:58:53.961+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:58:53.961+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:58:53.961+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:53:938,2.342573,-0.576670,9.559326
06-07 16:58:53.971+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:53.971+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:53.971+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:53:980,2.335395,-0.507278,9.611969
06-07 16:58:53.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12603
06-07 16:58:53.981+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:53.981+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:53.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(12603), cmd(0)
06-07 16:58:53.981+0200 W/CAPI_APPFW_APP_CONTROL(12603): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:53.981+0200 I/utils   (12603): specific action
06-07 16:58:53.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12603)
06-07 16:58:53.981+0200 I/servicemanager(12566): es.ugr.frailty.pressure launch request sent!
06-07 16:58:53.981+0200 I/servicemanager(12566): App control destroyed.
06-07 16:58:53.981+0200 I/servicemanager(12566): es.ugr.frailty.light alive timeout
06-07 16:58:53.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 16:58:53.981+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:58:53.981+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:53:986,0.194510,-0.001357,0.008137
06-07 16:58:53.981+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:58:53.981+0200 W/CAPI_APPFW_APP_CONTROL(13728): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:53.981+0200 I/utils   (13728): specific action
06-07 16:58:53.981+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:53.991+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:53:976,-0.210000,0.070000,0.140000
06-07 16:58:53.991+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:53.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12614
06-07 16:58:53.991+0200 W/CAPI_APPFW_APP_CONTROL(12614): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:53.991+0200 I/utils   (12614): specific action
06-07 16:58:53.991+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:53.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(13728), cmd(0)
06-07 16:58:53.991+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:53.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(12614), cmd(0)
06-07 16:58:53.991+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12614)
06-07 16:58:53.991+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 16:58:54.001+0200 I/servicemanager(12566): App control destroyed.
06-07 16:58:54.001+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 16:58:54.001+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 16:58:54.001+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.001+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:58:54.001+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:58:54.001+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:6,2.292324,-0.502493,9.578469
06-07 16:58:54.001+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.011+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 16:58:54.011+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:1,-0.280000,0.070000,0.490000
06-07 16:58:54.011+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:54.011+0200 I/utils   (12618): specific action
06-07 16:58:54.011+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:54.011+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12618), cmd(0)
06-07 16:58:54.011+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.011+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 16:58:54.011+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 16:58:54.011+0200 I/servicemanager(12566): App control destroyed.
06-07 16:58:54.011+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:53:921,2.152839,-0.573447,9.550226
06-07 16:58:54.011+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:21,0.280000,-0.070000,0.140000
06-07 16:58:54.021+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:53:992,0.182556,0.066168,0.061743
06-07 16:58:54.021+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.021+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:54.021+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(13685), cmd(0)
06-07 16:58:54.021+0200 W/CAPI_APPFW_APP_CONTROL(13685): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:54.021+0200 I/utils   (13685): specific action
06-07 16:58:54.021+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.021+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:27,0.138969,0.064701,0.027986
06-07 16:58:54.021+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:29,2.153355,-0.567194,9.550484
06-07 16:58:54.021+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.021+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.031+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.031+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:12,2.366502,-0.547956,9.559326
06-07 16:58:54.031+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:34,2.155259,-0.562508,9.550331
06-07 16:58:54.031+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.031+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.031+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:36,0.980000,-0.280000,0.140000
06-07 16:58:54.041+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:41,2.359323,-0.524028,9.583255
06-07 16:58:54.041+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:33,0.211243,0.014552,0.008995
06-07 16:58:54.041+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:58:54.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:58:54.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:58:54.061+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.071+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.071+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:53,0.195580,0.038113,0.034821
06-07 16:58:54.071+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.081+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:77,2.352145,-0.550349,9.600004
06-07 16:58:54.081+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:72,0.980000,-0.280000,0.070000
06-07 16:58:54.081+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.081+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.091+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:91,0.770000,-0.280000,-0.140000
06-07 16:58:54.091+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:83,0.181008,0.010483,0.053171
06-07 16:58:54.091+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:94,2.335395,-0.533599,9.568897
06-07 16:58:54.101+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.101+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:106,0.630000,-0.070000,-0.070000
06-07 16:58:54.101+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.101+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:110,0.980000,-0.140000,0.070000
06-07 16:58:54.111+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.111+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.121+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:116,0.158771,0.025967,0.023240
06-07 16:58:54.121+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.121+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:120,2.318645,-0.492921,9.523434
06-07 16:58:54.121+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:127,0.139368,0.063333,-0.021812
06-07 16:58:54.121+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.121+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.131+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.131+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:40,2.163743,-0.562141,9.548434
06-07 16:58:54.141+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:58:54.141+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:58:54:146,84
06-07 16:58:54.141+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:135,2.383251,-0.495314,9.482756
06-07 16:58:54.151+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:141,0.770000,-0.350000,-0.070000
06-07 16:58:54.151+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.151+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.151+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.151+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:134,0.201957,0.055942,-0.062320
06-07 16:58:54.151+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:58:54.161+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:58:54:164,815.000000
06-07 16:58:54.161+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.161+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:158,2.171137,-0.560832,9.546833
06-07 16:58:54.161+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:160,2.356930,-0.507278,9.544970
06-07 16:58:54.161+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.171+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:157,0.140000,0.070000,0.070000
06-07 16:58:54.171+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.171+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.171+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:170,0.169688,0.039817,0.001017
06-07 16:58:54.171+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.181+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:175,2.342573,-0.502493,9.640682
06-07 16:58:54.181+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:182,2.176624,-0.559567,9.545657
06-07 16:58:54.181+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.181+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:180,-1.120000,-0.280000,-0.140000
06-07 16:58:54.191+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.191+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:184,0.151171,0.041314,0.097495
06-07 16:58:54.191+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.191+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:192,2.179277,-0.556254,9.545246
06-07 16:58:54.191+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.201+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.201+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:197,2.356930,-0.502493,9.590433
06-07 16:58:54.201+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.201+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:202,0.164410,0.037035,0.047260
06-07 16:58:54.201+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.211+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:206,2.181294,-0.551256,9.545075
06-07 16:58:54.211+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:205,-0.700000,-0.420000,0.420000
06-07 16:58:54.211+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.211+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.221+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:221,2.187243,-0.547095,9.543953
06-07 16:58:54.221+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:211,2.337788,-0.437887,9.578469
06-07 16:58:54.221+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:219,-0.070000,-0.350000,0.280000
06-07 16:58:54.231+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:215,0.141717,0.098149,0.035915
06-07 16:58:54.231+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.241+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.241+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.241+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.241+0200 W/LOCATION(13769): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 16:58:54.251+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:252,2.191402,-0.543807,9.543187
06-07 16:58:54.251+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.251+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:259,2.192521,-0.539528,9.543173
06-07 16:58:54.261+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.261+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:248,2.344966,-0.454636,9.571291
06-07 16:58:54.261+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.261+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:267,2.196070,-0.536036,9.542554
06-07 16:58:54.261+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.261+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:270,2.395216,-0.521635,9.561719
06-07 16:58:54.271+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:246,0.070000,-0.280000,0.280000
06-07 16:58:54.271+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:272,2.199726,-0.530891,9.541999
06-07 16:58:54.271+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.271+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:243,0.145240,0.076255,0.029292
06-07 16:58:54.271+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.271+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:280,2.209724,-0.529456,9.539768
06-07 16:58:54.281+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.281+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.281+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:286,2.220270,-0.530627,9.537254
06-07 16:58:54.281+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:284,0.770000,-0.770000,-0.070000
06-07 16:58:54.281+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.291+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:292,2.227777,-0.531517,9.535454
06-07 16:58:54.291+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:287,0.185492,0.007820,0.021951
06-07 16:58:54.291+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.291+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.291+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.291+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:300,2.233893,-0.535314,9.533811
06-07 16:58:54.301+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.301+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.301+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:306,2.237316,-0.536867,9.532921
06-07 16:58:54.301+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.301+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:300,0.177338,-0.017329,0.062750
06-07 16:58:54.311+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:312,2.236984,-0.533605,9.533181
06-07 16:58:54.311+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:301,1.610000,-0.350000,-0.350000
06-07 16:58:54.311+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.311+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:306,2.397608,-0.547956,9.600004
06-07 16:58:54.311+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.311+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.311+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:320,2.237061,-0.528525,9.533446
06-07 16:58:54.321+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.321+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.321+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:326,2.241379,-0.524726,9.532642
06-07 16:58:54.321+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.321+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:325,0.138725,-0.083438,0.031052
06-07 16:58:54.331+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:333,2.241787,-0.520582,9.532773
06-07 16:58:54.331+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:323,1.470000,-0.140000,-0.280000
06-07 16:58:54.331+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.331+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.331+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:322,2.366502,-0.614955,9.566505
06-07 16:58:54.331+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.341+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:58:54.341+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:342,2.246551,-0.520710,9.531645
06-07 16:58:54.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:58:54.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:58:54.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:58:54.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:58:54.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390734349,000000, pattern:[H:mm][0;m
06-07 16:58:54.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:58:54.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:58:54.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:58:54.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:58:54.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:58:54.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:58][0;m
06-07 16:58:54.341+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:58:54:347,84
06-07 16:58:54.351+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.351+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:340,0.700000,-0.070000,-0.420000
06-07 16:58:54.351+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.351+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.351+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:58:54.361+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:364,2.251562,-0.520124,9.530495
06-07 16:58:54.361+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:58:54:364,813.000000
06-07 16:58:54.361+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:345,2.344966,-0.600598,9.556933
06-07 16:58:54.361+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.371+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:356,0.111073,-0.065285,0.023123
06-07 16:58:54.371+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.371+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.371+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:381,2.258075,-0.521837,9.528860
06-07 16:58:54.371+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:381,0.136364,-0.006304,0.057512
06-07 16:58:54.381+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:375,2.373680,-0.543171,9.590433
06-07 16:58:54.381+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:362,0.700000,0.070000,0.140000
06-07 16:58:54.381+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.391+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.391+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.391+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.391+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:399,2.263883,-0.521954,9.527475
06-07 16:58:54.391+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:400,2.376073,-0.492921,9.528220
06-07 16:58:54.391+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.401+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:395,0.139089,0.040684,-0.004961
06-07 16:58:54.401+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.401+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:409,0.174904,0.045175,0.016309
06-07 16:58:54.401+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.411+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:393,0.210000,-0.210000,0.140000
06-07 16:58:54.411+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.411+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.411+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:418,0.280000,-0.140000,0.210000
06-07 16:58:54.411+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:419,2.267196,-0.523513,9.526602
06-07 16:58:54.421+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.421+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:426,-0.070000,-0.280000,0.420000
06-07 16:58:54.421+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.421+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:405,2.411965,-0.483350,9.549755
06-07 16:58:54.431+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:413,0.120337,0.050947,0.096076
06-07 16:58:54.431+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.431+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.431+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.431+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:440,2.267879,-0.521129,9.526569
06-07 16:58:54.441+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:440,2.361716,-0.473779,9.628718
06-07 16:58:54.441+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.441+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:448,2.376073,-0.533599,9.564112
06-07 16:58:54.441+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.451+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:431,-0.140000,-0.210000,0.560000
06-07 16:58:54.451+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.451+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:458,-0.140000,0.070000,0.280000
06-07 16:58:54.451+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.451+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:437,0.134286,-0.013017,0.031339
06-07 16:58:54.451+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.451+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.461+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:464,2.270236,-0.518039,9.526177
06-07 16:58:54.461+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:465,0.143878,0.001468,-0.012997
06-07 16:58:54.461+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.461+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:469,0.148439,-0.032618,0.036011
06-07 16:58:54.461+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.471+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.471+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:452,2.390430,-0.519243,9.518648
06-07 16:58:54.471+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.471+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:479,2.271491,-0.513592,9.526118
06-07 16:58:54.471+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:462,0.490000,-0.140000,0.350000
06-07 16:58:54.481+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.481+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:481,2.400001,-0.552742,9.566505
06-07 16:58:54.481+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:474,0.137141,0.004987,0.032859
06-07 16:58:54.481+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.491+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:485,0.560000,-0.140000,0.280000
06-07 16:58:54.491+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.491+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.491+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.491+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:500,2.278748,-0.514039,9.524362
06-07 16:58:54.501+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:504,0.560000,0.210000,0.630000
06-07 16:58:54.501+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.501+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:500,2.395216,-0.516850,9.561719
06-07 16:58:54.501+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.511+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:494,0.081084,-0.028396,0.036636
06-07 16:58:54.511+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.511+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.511+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:517,0.082556,0.028199,0.047082
06-07 16:58:54.511+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:519,2.282556,-0.516840,9.523297
06-07 16:58:54.511+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.521+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:511,-1.120000,0.490000,0.630000
06-07 16:58:54.521+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:54.521+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:514,2.344966,-0.550349,9.564112
06-07 16:58:54.531+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.541+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:543,2.283144,-0.518436,9.523070
06-07 16:58:54.541+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:54.541+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:54:548,2.349752,-0.495314,9.573684
06-07 16:58:54.551+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:58:54.551+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:58:54:556,83
06-07 16:58:54.551+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:58:54.561+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:58:54:565,811.000000
06-07 16:58:54.561+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.561+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:54:570,2.293389,-0.519954,9.520525
06-07 16:58:54.571+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:54:529,-0.770000,0.280000,0.140000
06-07 16:58:54.571+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:54:524,0.127336,0.040171,0.035150
06-07 16:58:54.571+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:54.571+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:54.571+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11137696c6f63152838353
