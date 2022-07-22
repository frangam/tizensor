S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 14141
Date: 2018-06-07 17:00:14+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf72e452d, r5   = 0xf7506f98
r6   = 0xffbfbda0, r7   = 0xffbfbc50
r8   = 0xf7503c18, r9   = 0x00000000
r10  = 0xffbfbd2c, fp   = 0xffbfbda0
ip   = 0x00000001, sp   = 0xffbfbc28
lr   = 0xf72e4539, pc   = 0xf734d228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    194436 KB
Buffers:      7712 KB
Cached:      45332 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11292 KB
VmRSS:       11288 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 14141 TID = 14141
14141 14145 

Maps Information
f41af000 f49ae000 rw-p [stack:14145]
f49b5000 f49b7000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f49bf000 f49c3000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f49cc000 f49ce000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f49d6000 f49d9000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f49e8000 f49ed000 r-xp /usr/lib/libsystem.so.0.0.0
f49f8000 f49fb000 r-xp /lib/libattr.so.1.1.0
f4a03000 f4a13000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4a1b000 f4a24000 r-xp /usr/lib/libedbus.so.1.7.99
f4a2c000 f4a2d000 r-xp /usr/lib/libresponse.so.0.2.96
f4a36000 f4a3b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f62dd000 f63e3000 r-xp /usr/lib/libicuuc.so.57.1
f63f9000 f6581000 r-xp /usr/lib/libicui18n.so.57.1
f6591000 f659e000 r-xp /usr/lib/libail.so.0.1.0
f65a7000 f65ae000 r-xp /usr/lib/libminizip.so.1.0.0
f65b7000 f6760000 r-xp /usr/lib/libcrypto.so.1.0.0
f6780000 f67c7000 r-xp /usr/lib/libssl.so.1.0.0
f67d3000 f67d5000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f67dd000 f67e4000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f67ed000 f67f4000 r-xp /lib/libcrypt-2.13.so
f6825000 f6828000 r-xp /lib/libcap.so.2.21
f6830000 f6832000 r-xp /usr/lib/libiri.so
f683a000 f6883000 r-xp /usr/lib/libmdm.so.1.2.69
f688b000 f6891000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6899000 f68bc000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f68c6000 f68c8000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f68d0000 f68ed000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f68f6000 f68fa000 r-xp /usr/lib/libsmack.so.1.0.0
f6903000 f691c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6925000 f692d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6935000 f693b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6944000 f6946000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f694f000 f695f000 r-xp /lib/libresolv-2.13.so
f6963000 f697b000 r-xp /usr/lib/liblzma.so.5.0.3
f6984000 f6986000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f698e000 f69a8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f69b0000 f69df000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f69e8000 f69f7000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a01000 f6a0b000 r-xp /usr/lib/libsensord-shared.so
f6a14000 f6ae7000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6af2000 f6b08000 r-xp /lib/libz.so.1.2.5
f6b10000 f6b15000 r-xp /usr/lib/libffi.so.5.0.10
f6b1d000 f6b1e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b26000 f6b36000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b3e000 f6b57000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b5f000 f6b61000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b69000 f6bde000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6be8000 f6bee000 r-xp /lib/librt-2.13.so
f6bf7000 f6c15000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c1f000 f6c20000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c28000 f6c4b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c53000 f6c58000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c60000 f6c8a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c93000 f6caa000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6cb2000 f6d1b000 r-xp /lib/libm-2.13.so
f6d24000 f6db8000 r-xp /usr/lib/libstdc++.so.6.0.16
f6dcb000 f6dd0000 r-xp /usr/lib/libctx-client.so.0.8.3
f6dd8000 f6ddf000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6de7000 f6e11000 r-xp /usr/lib/libsensor.so.1.9.6
f6e1a000 f6ee6000 r-xp /usr/lib/libxml2.so.2.7.8
f6ef3000 f6ef5000 r-xp /usr/lib/libiniparser.so.0
f6efe000 f6f04000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f0d000 f6fdd000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6fde000 f7012000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f701b000 f7057000 r-xp /usr/lib/libSLP-location.so.0.9.24
f705f000 f7062000 r-xp /usr/lib/libbundle.so.0.1.22
f706a000 f7070000 r-xp /usr/lib/libappsvc.so.0.1.0
f7078000 f70b9000 r-xp /usr/lib/libeina.so.1.7.99
f70c2000 f70d9000 r-xp /usr/lib/libecore.so.1.7.99
f70f0000 f70f9000 r-xp /usr/lib/libvconf.so.0.2.45
f7101000 f7115000 r-xp /lib/libpthread-2.13.so
f7120000 f712d000 r-xp /usr/lib/libaul.so.0.1.0
f7137000 f7139000 r-xp /lib/libdl-2.13.so
f7142000 f714d000 r-xp /lib/libunwind.so.8.0.1
f717a000 f7182000 r-xp /lib/libgcc_s-4.6.so.1
f7183000 f72a7000 r-xp /lib/libc-2.13.so
f72b5000 f72b7000 r-xp /usr/lib/libdlog.so.0.0.0
f72bf000 f72cb000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f72d4000 f72d9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f72e1000 f72f0000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f72f8000 f72fc000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7305000 f7308000 r-xp /usr/lib/libappcore-agent.so.1.1
f7310000 f7312000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f731a000 f731e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7326000 f7343000 r-xp /lib/ld-2.13.so
f734c000 f734f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f734f000 f7353000 r-xp /usr/lib/libsys-assert.so
f74d3000 f7541000 rw-p [heap]
ffbdd000 ffbfe000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14141)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf734d228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf72e4539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6feb3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6fe9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6ff5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6ffbbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6ffbdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf703075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf702b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6fe9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6ff5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6ffbbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6ffbdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf702de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf702e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7035f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49cd1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf49c0171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a93663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f40fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f427a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf70d2ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf70cdb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70ce5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf70ce879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7306183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73067fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf734d5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf719a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf734cf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
apturing data
06-07 17:00:13.781+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:13.791+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:13:785,2.220540,-1.028914,9.631111
06-07 17:00:13.791+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:13:792,2.137438,-0.796047,9.537718
06-07 17:00:13.791+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:00:13.791+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:13:793,-2.100000,1.050000,0.840000
06-07 17:00:13.791+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:13.791+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:00:13:799,83
06-07 17:00:13.801+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:13.801+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:13:806,2.184647,-0.942772,9.559326
06-07 17:00:13.811+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:13:808,0.052415,-0.158213,0.019492
06-07 17:00:13.811+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:13.811+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:13.811+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:13:818,2.153143,-0.815577,9.532534
06-07 17:00:13.811+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:13:818,-3.780000,-1.190000,-0.490000
06-07 17:00:13.811+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:00:13.811+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:13.821+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:00:13:823,812.000000
06-07 17:00:13.821+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:13:825,2.215754,-1.052842,9.638289
06-07 17:00:13.821+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:13.821+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:13.821+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:13.831+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:13:832,0.210000,0.700000,-0.980000
06-07 17:00:13.831+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:13.831+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:13:831,2.159641,-0.824920,9.530259
06-07 17:00:13.831+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:13:830,0.078316,-0.256795,0.100572
06-07 17:00:13.831+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:13.831+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:13:840,2.299503,-1.033699,9.458827
06-07 17:00:13.841+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:13:844,0.146360,-0.218122,-0.073707
06-07 17:00:13.841+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:13.841+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:13.851+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:13:853,2.155511,-0.822336,9.531418
06-07 17:00:13.851+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:13:853,1.260000,2.030000,-0.980000
06-07 17:00:13.851+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:13.851+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:13.851+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:13:858,0.063291,-0.024532,0.007532
06-07 17:00:13.851+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:13:860,2.222932,-0.849452,9.537791
06-07 17:00:13.861+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:13.861+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:13.871+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:13:873,2.153614,-0.811907,9.532741
06-07 17:00:13.871+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:13:873,0.350000,0.560000,-0.840000
06-07 17:00:13.871+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer alive timeout
06-07 17:00:13.871+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:00:13.871+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:00:13.871+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:13.871+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:00:13.871+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:13:880,2.189433,-0.643669,9.748360
06-07 17:00:13.881+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:13.881+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14069
06-07 17:00:13.881+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14069)
06-07 17:00:13.881+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer launch request sent!
06-07 17:00:13.881+0200 I/servicemanager(12566): App control destroyed.
06-07 17:00:13.881+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:13.881+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:00:13.881+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(14069), cmd(0)
06-07 17:00:13.881+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope alive timeout
06-07 17:00:13.891+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:13.891+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:13:896,2.161895,-0.805109,9.531443
06-07 17:00:13.891+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:00:13.891+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:13:895,-3.570000,0.350000,-0.910000
06-07 17:00:13.891+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:00:13.891+0200 W/CAPI_APPFW_APP_CONTROL(14069): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:00:13.891+0200 I/utils   (14069): specific action
06-07 17:00:13.891+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:13.891+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:00:13.901+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:13:902,2.160719,-0.538385,9.750752
06-07 17:00:13.901+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:13:888,0.033921,0.178666,0.216942
06-07 17:00:13.901+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:13.901+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14151
06-07 17:00:13.911+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:13.911+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14151)
06-07 17:00:13.911+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope launch request sent!
06-07 17:00:13.911+0200 I/servicemanager(12566): App control destroyed.
06-07 17:00:13.911+0200 I/servicemanager(12566): es.ugr.frailty.heartrate alive timeout
06-07 17:00:13.911+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:00:13.911+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:00:13.911+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:13.911+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:00:13.911+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:13:918,1.947758,-0.756132,9.573684
06-07 17:00:13.911+0200 W/CAPI_APPFW_APP_CONTROL(14151): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:00:13.911+0200 I/utils   (14151): specific action
06-07 17:00:13.911+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:13.921+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:13:925,-7.420000,-1.190000,-0.560000
06-07 17:00:13.921+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12595
06-07 17:00:13.921+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:00:13.921+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(14151), cmd(0)
06-07 17:00:13.921+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12595)
06-07 17:00:13.921+0200 I/servicemanager(12566): es.ugr.frailty.heartrate launch request sent!
06-07 17:00:13.921+0200 I/servicemanager(12566): App control destroyed.
06-07 17:00:13.921+0200 I/servicemanager(12566): es.ugr.frailty.location alive timeout
06-07 17:00:13.921+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:00:13.921+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:13.921+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:00:13.921+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:13.931+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:00:13.931+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:13:935,-1.960000,-0.770000,0.070000
06-07 17:00:13.931+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:13:933,2.067399,-0.832702,9.595219
06-07 17:00:13.931+0200 W/CAPI_APPFW_APP_CONTROL(12595): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:00:13.931+0200 I/utils   (12595): specific action
06-07 17:00:13.941+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14141
06-07 17:00:13.941+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:00:13.941+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(12595), cmd(0)
06-07 17:00:13.941+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14141)
06-07 17:00:13.941+0200 I/servicemanager(12566): es.ugr.frailty.location launch request sent!
06-07 17:00:13.941+0200 I/servicemanager(12566): App control destroyed.
06-07 17:00:13.941+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration alive timeout
06-07 17:00:13.941+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:00:13.941+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:00:13.941+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:00:13.961+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14164
06-07 17:00:13.961+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14164)
06-07 17:00:13.961+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:00:13.961+0200 I/servicemanager(12566): App control destroyed.
06-07 17:00:13.961+0200 I/servicemanager(12566): es.ugr.frailty.gravity alive timeout
06-07 17:00:13.961+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:00:13.961+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:00:13.961+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:00:13.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14114
06-07 17:00:13.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14114)
06-07 17:00:13.981+0200 I/servicemanager(12566): es.ugr.frailty.gravity launch request sent!
06-07 17:00:13.981+0200 I/servicemanager(12566): App control destroyed.
06-07 17:00:13.981+0200 I/servicemanager(12566): es.ugr.frailty.pressure alive timeout
06-07 17:00:13.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:00:13.981+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:00:13.981+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:00:13.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12603
06-07 17:00:13.991+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12603)
06-07 17:00:13.991+0200 I/servicemanager(12566): es.ugr.frailty.pressure launch request sent!
06-07 17:00:13.991+0200 I/servicemanager(12566): App control destroyed.
06-07 17:00:13.991+0200 I/servicemanager(12566): es.ugr.frailty.light alive timeout
06-07 17:00:13.991+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:00:13.991+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:00:14.001+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:00:14.001+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:00:14.011+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12614
06-07 17:00:14.011+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:00:14.011+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(12614), cmd(0)
06-07 17:00:14.011+0200 W/CAPI_APPFW_APP_CONTROL(12614): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:00:14.011+0200 I/utils   (12614): specific action
06-07 17:00:14.011+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:00:14.021+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:00:14:23,810.000000
06-07 17:00:14.021+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:00:14:4,83
06-07 17:00:14.031+0200 W/CAPI_APPFW_APP_CONTROL(14141): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:00:14.031+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:00:14.031+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(14141), cmd(0)
06-07 17:00:14.031+0200 W/CAPI_APPFW_APP_CONTROL(12603): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:00:14.041+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:00:14.041+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(12603), cmd(0)
06-07 17:00:14.041+0200 I/utils   (14141): specific action
06-07 17:00:14.041+0200 I/utils   (12603): specific action
06-07 17:00:14.041+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.041+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12614)
06-07 17:00:14.041+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 17:00:14.041+0200 I/servicemanager(12566): App control destroyed.
06-07 17:00:14.041+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 17:00:14.041+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:00:14.041+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:00:14.041+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:00:14.051+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 17:00:14.051+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:00:14.051+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12618), cmd(0)
06-07 17:00:14.061+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:00:14.061+0200 I/utils   (12618): specific action
06-07 17:00:14.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:00:14.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:00:14.071+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:00:14.081+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:48,2.201397,-0.768096,9.454042
06-07 17:00:14.081+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 17:00:14.081+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 17:00:14.081+0200 I/servicemanager(12566): App control destroyed.
06-07 17:00:14.081+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.081+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:13:917,2.174403,-0.818453,9.527460
06-07 17:00:14.091+0200 W/CAPI_APPFW_APP_CONTROL(14114): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:00:14.091+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:00:14.091+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(14114), cmd(0)
06-07 17:00:14.091+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:13:912,0.007104,0.273522,0.218012
06-07 17:00:14.091+0200 I/utils   (14114): specific action
06-07 17:00:14.091+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.091+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.091+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:93,2.187040,-0.720240,9.576077
06-07 17:00:14.091+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.101+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:00:14.101+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(14164), cmd(0)
06-07 17:00:14.101+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:102,2.310000,1.750000,0.560000
06-07 17:00:14.101+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:102,2.175504,-0.823339,9.526788
06-07 17:00:14.101+0200 W/CAPI_APPFW_APP_CONTROL(14164): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:00:14.101+0200 I/utils   (14164): specific action
06-07 17:00:14.101+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:14.111+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:103,2.196611,-0.760918,9.690931
06-07 17:00:14.111+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.111+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:14:113,-0.214137,0.048977,0.042241
06-07 17:00:14.111+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.111+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:119,2.199004,-0.849452,9.633504
06-07 17:00:14.111+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.111+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.121+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:121,2.030000,1.680000,1.330000
06-07 17:00:14.121+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:14.131+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.131+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:122,2.167262,-0.815734,9.529320
06-07 17:00:14.131+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.131+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:123,2.151148,-0.930808,9.473185
06-07 17:00:14.131+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.131+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:141,2.163112,-1.074377,9.494720
06-07 17:00:14.131+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:14:129,-0.107004,-0.014249,0.067759
06-07 17:00:14.131+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.141+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:14.141+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:139,-0.840000,-0.840000,1.260000
06-07 17:00:14.151+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:141,2.157919,-0.806602,9.532217
06-07 17:00:14.151+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.151+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.151+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:145,2.196611,-0.988236,9.571291
06-07 17:00:14.151+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.161+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:14:150,0.025892,0.055243,-0.072745
06-07 17:00:14.161+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:14.161+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:161,2.177469,-0.787239,9.743573
06-07 17:00:14.161+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.161+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:159,2.161261,-0.806243,9.531490
06-07 17:00:14.161+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:158,-1.120000,-1.610000,1.890000
06-07 17:00:14.171+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.171+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.171+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:170,2.225325,-0.744168,9.640682
06-07 17:00:14.171+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.181+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:178,-2.380000,-1.190000,1.750000
06-07 17:00:14.181+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:14:167,0.019778,0.095494,0.046757
06-07 17:00:14.181+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:14.191+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:181,2.166942,-0.811284,9.529773
06-07 17:00:14.191+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:00:14.191+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.191+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.201+0200 W/LOCATION(14141): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:00:14.201+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:179,2.117648,-0.849452,9.681360
06-07 17:00:14.201+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.201+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:210,2.170290,-0.813560,9.635897
06-07 17:00:14.201+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.211+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:00:14:199,83
06-07 17:00:14.211+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:00:14.211+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:00:14:217,807.000000
06-07 17:00:14.211+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:205,-2.590000,-0.980000,1.120000
06-07 17:00:14.211+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.211+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:215,2.155933,-0.765703,9.399008
06-07 17:00:14.211+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.221+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:224,2.191825,-0.713061,9.707682
06-07 17:00:14.221+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:225,2.174327,-0.823005,9.527085
06-07 17:00:14.221+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.191+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:14:190,0.038692,0.045685,0.158714
06-07 17:00:14.221+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.221+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:229,2.191825,-0.741775,9.530612
06-07 17:00:14.221+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:14.221+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.231+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:235,2.146362,-0.878166,9.540184
06-07 17:00:14.231+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:14:235,0.037743,-0.043209,0.102014
06-07 17:00:14.231+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:222,-0.350000,0.910000,1.120000
06-07 17:00:14.231+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.231+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:241,1.750000,-0.350000,0.420000
06-07 17:00:14.231+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.241+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:14.241+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:245,0.910000,-0.770000,0.560000
06-07 17:00:14.241+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.241+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.241+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:229,2.182222,-0.840890,9.523718
06-07 17:00:14.251+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:252,2.220540,-0.935594,9.623933
06-07 17:00:14.251+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.251+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:250,0.910000,-1.820000,1.050000
06-07 17:00:14.251+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.251+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:14:246,-0.015794,-0.119524,-0.056588
06-07 17:00:14.251+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:14.251+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:260,2.030000,-2.170000,1.470000
06-07 17:00:14.251+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.261+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:261,2.180498,-0.848237,9.523461
06-07 17:00:14.261+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:265,1.890000,-1.050000,2.170000
06-07 17:00:14.261+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.261+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.271+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:273,2.201397,-0.914058,9.425328
06-07 17:00:14.271+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.271+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:270,3.780000,-1.400000,3.360000
06-07 17:00:14.271+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.271+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:280,-1.260000,-0.350000,2.800000
06-07 17:00:14.271+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.271+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:14:265,-0.011215,-0.251373,-0.032365
06-07 17:00:14.281+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:14.281+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:284,-2.660000,-2.590000,3.010000
06-07 17:00:14.281+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.281+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:288,0.630000,-0.770000,3.010000
06-07 17:00:14.281+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.291+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:280,2.174215,-0.841186,9.525522
06-07 17:00:14.291+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.291+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:293,2.244468,-1.028914,9.540184
06-07 17:00:14.291+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.291+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:298,-0.210000,0.980000,3.220000
06-07 17:00:14.291+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:14:286,0.014389,-0.147346,0.047573
06-07 17:00:14.291+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.301+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:14.301+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:303,-3.220000,0.280000,2.030000
06-07 17:00:14.301+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:297,2.174345,-0.834729,9.526061
06-07 17:00:14.301+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.301+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:14:306,-0.003029,0.060998,0.220112
06-07 17:00:14.301+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:309,2.170907,-0.834002,9.526909
06-07 17:00:14.301+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.311+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.311+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:14.311+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.311+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:320,2.282753,-1.093520,9.499505
06-07 17:00:14.311+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:317,-0.070000,1.610000,1.540000
06-07 17:00:14.321+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:313,2.168087,-0.829683,9.527928
06-07 17:00:14.321+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.321+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:14:321,0.051110,0.097018,0.115160
06-07 17:00:14.321+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:14.321+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.321+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.331+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:333,2.201397,-0.914058,9.616754
06-07 17:00:14.331+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:14:335,-0.056697,-0.014723,0.155299
06-07 17:00:14.331+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:332,1.470000,1.470000,1.190000
06-07 17:00:14.331+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:329,2.164712,-0.824260,9.529166
06-07 17:00:14.331+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.331+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:14.341+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:345,2.155027,-0.812021,9.532412
06-07 17:00:14.341+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:14:345,-0.000617,0.020442,0.108988
06-07 17:00:14.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:00:14.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:00:14.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:00:14.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:00:14.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390814350,000000, pattern:[H:mm][0;m
06-07 17:00:14.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:00:14.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:00:14.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:00:14.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:00:14.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:00:14.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:00][0;m
06-07 17:00:14.341+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.351+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.351+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.351+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:360,0.490000,0.840000,0.560000
06-07 17:00:14.361+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:359,2.239682,-0.863809,9.729217
06-07 17:00:14.361+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:355,2.158831,-0.812199,9.531535
06-07 17:00:14.361+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.361+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:14.361+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.361+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:370,2.168553,-0.822648,9.528432
06-07 17:00:14.361+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.361+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.371+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:374,2.167924,-0.827368,9.528166
06-07 17:00:14.371+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.371+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:373,0.490000,0.840000,0.210000
06-07 17:00:14.371+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:375,2.177469,-0.887737,9.592826
06-07 17:00:14.371+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:379,2.166903,-0.832850,9.527921
06-07 17:00:14.371+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.381+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:14:370,-0.012153,0.063980,-0.128921
06-07 17:00:14.381+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:14.381+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.391+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.391+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:00:14.391+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:383,2.176794,-0.848988,9.524241
06-07 17:00:14.391+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.391+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:00:14:400,83
06-07 17:00:14.401+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:393,0.070000,-0.140000,0.560000
06-07 17:00:14.401+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:396,2.151148,-0.890130,9.678967
06-07 17:00:14.401+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:401,2.178025,-0.860295,9.522945
06-07 17:00:14.401+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.401+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:14:388,0.027113,0.111199,0.178515
06-07 17:00:14.411+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:14.411+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:00:14.411+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.411+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:00:14:418,806.000000
06-07 17:00:14.411+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.411+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:412,2.170535,-0.859147,9.524758
06-07 17:00:14.421+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.421+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:420,0.420000,-0.280000,0.280000
06-07 17:00:14.421+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:422,2.191825,-0.906880,9.585647
06-07 17:00:14.421+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.421+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:427,2.168161,-0.857309,9.525465
06-07 17:00:14.431+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:14:416,0.036798,0.070246,-0.001800
06-07 17:00:14.431+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.431+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.431+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:14.441+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:442,2.164746,-0.857178,9.526254
06-07 17:00:14.441+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:14:445,-0.012470,-0.065967,0.008649
06-07 17:00:14.441+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.441+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:435,0.560000,-0.210000,0.280000
06-07 17:00:14.441+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:440,2.172683,-0.937986,9.480364
06-07 17:00:14.451+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:451,2.162319,-0.858201,9.526712
06-07 17:00:14.451+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.451+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.451+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.451+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:14.451+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:462,2.175076,-0.902094,9.631111
06-07 17:00:14.461+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:457,2.162393,-0.859547,9.526574
06-07 17:00:14.461+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.461+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.461+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:456,0.210000,-0.140000,0.070000
06-07 17:00:14.461+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:14:465,0.051986,-0.112945,0.095501
06-07 17:00:14.471+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:473,2.162216,-0.862446,9.526353
06-07 17:00:14.471+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.471+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:14.471+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.471+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:14:480,0.033473,-0.086690,-0.102838
06-07 17:00:14.481+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:475,2.187040,-0.870987,9.669396
06-07 17:00:14.481+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:14.481+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:482,0.770000,0.070000,0.210000
06-07 17:00:14.481+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.481+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.481+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:479,2.161442,-0.863513,9.526432
06-07 17:00:14.491+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.491+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:14:489,0.077565,-0.196063,0.012263
06-07 17:00:14.491+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:493,2.244468,-0.777667,9.595219
06-07 17:00:14.491+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:14.501+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:496,2.158944,-0.861707,9.527162
06-07 17:00:14.501+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.501+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:14:504,0.105959,-0.244532,-0.024736
06-07 17:00:14.501+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:493,0.210000,0.140000,0.210000
06-07 17:00:14.501+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:14.501+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:14:511,0.023371,-0.053763,0.093808
06-07 17:00:14.511+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.511+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:507,2.161085,-0.856990,9.527102
06-07 17:00:14.511+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.511+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.521+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:517,2.206182,-0.873380,9.597611
06-07 17:00:14.521+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:523,-0.140000,-0.070000,0.280000
06-07 17:00:14.521+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:14.521+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:522,2.162689,-0.857834,9.526662
06-07 17:00:14.521+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.521+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.531+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:533,2.191825,-0.863809,9.621540
06-07 17:00:14.531+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:533,2.159987,-0.856217,9.527420
06-07 17:00:14.531+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.531+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:14:531,0.069147,-0.004662,0.204458
06-07 17:00:14.541+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:14.541+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:543,0.630000,0.630000,0.210000
06-07 17:00:14.541+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.541+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.551+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.551+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:552,2.156549,-0.856427,9.528180
06-07 17:00:14.551+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:14:553,2.129612,-0.870987,9.566505
06-07 17:00:14.551+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:14:550,0.009308,-0.030428,0.067361
06-07 17:00:14.571+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.571+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:578,2.156986,-0.854543,9.528251
06-07 17:00:14.571+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:14.571+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:14.581+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:14:558,0.140000,0.490000,0.420000
06-07 17:00:14.581+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:14.591+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:14:592,2.167052,-0.856287,9.525809
06-07 17:00:14.591+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:00:14.591+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:14.591+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:00:14:599,83
06-07 17:00:14.601+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11141416c6f63152838361
