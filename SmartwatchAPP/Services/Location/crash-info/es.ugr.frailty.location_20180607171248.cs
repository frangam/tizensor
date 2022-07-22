S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 17828
Date: 2018-06-07 17:12:48+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf75c252d, r5   = 0xf7d64f98
r6   = 0xff976370, r7   = 0xff976220
r8   = 0xf7d61c18, r9   = 0x00000000
r10  = 0xff9762fc, fp   = 0xff976370
ip   = 0x00000001, sp   = 0xff9761f8
lr   = 0xf75c2539, pc   = 0xf762b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    103204 KB
Buffers:     11952 KB
Cached:      55464 KB
VmPeak:      53480 KB
VmSize:      53460 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11784 KB
VmRSS:       11784 KB
VmData:      11188 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 17828 TID = 17828
17828 17832 

Maps Information
f448d000 f4c8c000 rw-p [stack:17832]
f4c93000 f4c95000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c9d000 f4ca1000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4caa000 f4cac000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4cb4000 f4cb7000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4cc6000 f4ccb000 r-xp /usr/lib/libsystem.so.0.0.0
f4cd6000 f4cd9000 r-xp /lib/libattr.so.1.1.0
f4ce1000 f4cf1000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4cf9000 f4d02000 r-xp /usr/lib/libedbus.so.1.7.99
f4d0a000 f4d0b000 r-xp /usr/lib/libresponse.so.0.2.96
f4d14000 f4d19000 r-xp /usr/lib/libproc-stat.so.0.2.96
f65bb000 f66c1000 r-xp /usr/lib/libicuuc.so.57.1
f66d7000 f685f000 r-xp /usr/lib/libicui18n.so.57.1
f686f000 f687c000 r-xp /usr/lib/libail.so.0.1.0
f6885000 f688c000 r-xp /usr/lib/libminizip.so.1.0.0
f6895000 f6a3e000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a5e000 f6aa5000 r-xp /usr/lib/libssl.so.1.0.0
f6ab1000 f6ab3000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6abb000 f6ac2000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6acb000 f6ad2000 r-xp /lib/libcrypt-2.13.so
f6b03000 f6b06000 r-xp /lib/libcap.so.2.21
f6b0e000 f6b10000 r-xp /usr/lib/libiri.so
f6b18000 f6b61000 r-xp /usr/lib/libmdm.so.1.2.69
f6b69000 f6b6f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b77000 f6b9a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6ba4000 f6ba6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6bae000 f6bcb000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6bd4000 f6bd8000 r-xp /usr/lib/libsmack.so.1.0.0
f6be1000 f6bfa000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c03000 f6c0b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c13000 f6c19000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c22000 f6c24000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c2d000 f6c3d000 r-xp /lib/libresolv-2.13.so
f6c41000 f6c59000 r-xp /usr/lib/liblzma.so.5.0.3
f6c62000 f6c64000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c6c000 f6c86000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c8e000 f6cbd000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6cc6000 f6cd5000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6cdf000 f6ce9000 r-xp /usr/lib/libsensord-shared.so
f6cf2000 f6dc5000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6dd0000 f6de6000 r-xp /lib/libz.so.1.2.5
f6dee000 f6df3000 r-xp /usr/lib/libffi.so.5.0.10
f6dfb000 f6dfc000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e04000 f6e14000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e1c000 f6e35000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e3d000 f6e3f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e47000 f6ebc000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ec6000 f6ecc000 r-xp /lib/librt-2.13.so
f6ed5000 f6ef3000 r-xp /usr/lib/libsystemd.so.0.4.0
f6efd000 f6efe000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f06000 f6f29000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f31000 f6f36000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f3e000 f6f68000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f71000 f6f88000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f90000 f6ff9000 r-xp /lib/libm-2.13.so
f7002000 f7096000 r-xp /usr/lib/libstdc++.so.6.0.16
f70a9000 f70ae000 r-xp /usr/lib/libctx-client.so.0.8.3
f70b6000 f70bd000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70c5000 f70ef000 r-xp /usr/lib/libsensor.so.1.9.6
f70f8000 f71c4000 r-xp /usr/lib/libxml2.so.2.7.8
f71d1000 f71d3000 r-xp /usr/lib/libiniparser.so.0
f71dc000 f71e2000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f71eb000 f72bb000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f72bc000 f72f0000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f72f9000 f7335000 r-xp /usr/lib/libSLP-location.so.0.9.24
f733d000 f7340000 r-xp /usr/lib/libbundle.so.0.1.22
f7348000 f734e000 r-xp /usr/lib/libappsvc.so.0.1.0
f7356000 f7397000 r-xp /usr/lib/libeina.so.1.7.99
f73a0000 f73b7000 r-xp /usr/lib/libecore.so.1.7.99
f73ce000 f73d7000 r-xp /usr/lib/libvconf.so.0.2.45
f73df000 f73f3000 r-xp /lib/libpthread-2.13.so
f73fe000 f740b000 r-xp /usr/lib/libaul.so.0.1.0
f7415000 f7417000 r-xp /lib/libdl-2.13.so
f7420000 f742b000 r-xp /lib/libunwind.so.8.0.1
f7458000 f7460000 r-xp /lib/libgcc_s-4.6.so.1
f7461000 f7585000 r-xp /lib/libc-2.13.so
f7593000 f7595000 r-xp /usr/lib/libdlog.so.0.0.0
f759d000 f75a9000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75b2000 f75b7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75bf000 f75ce000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f75d6000 f75da000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75e3000 f75e6000 r-xp /usr/lib/libappcore-agent.so.1.1
f75ee000 f75f0000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f75f8000 f75fc000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7604000 f7621000 r-xp /lib/ld-2.13.so
f762a000 f762d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f762d000 f7631000 r-xp /usr/lib/libsys-assert.so
f7d31000 f7da3000 rw-p [heap]
ff957000 ff978000 rw-p [stack]
End of Maps Information

Callstack Information (PID:17828)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf762b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf75c2539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72c93f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf72c7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf72d3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf72d9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf72d9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf730e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73091f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf72c7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf72d3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf72d9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf72d9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf730be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf730c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7313f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4cab1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4c9e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d71663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf721efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72207a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf73b0ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf73abb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73ac5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf73ac879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf75e4183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75e47fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf762b5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf747885c) [/lib/libc.so.6] + 0x1785c
29: (0xf762af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
.771+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:47.771+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:47:775,1.246661,-1.639083,9.798609
06-07 17:12:47.771+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:47.771+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:47:766,1.194783,-1.559968,9.607777
06-07 17:12:47.771+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:47.781+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:47:776,0.052563,0.055290,0.021907
06-07 17:12:47.781+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:47.791+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:47.791+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:47:781,0.070000,0.490000,-0.700000
06-07 17:12:47.791+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:47.791+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:47:785,1.197455,-1.564601,9.606691
06-07 17:12:47.801+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:47:790,0.024011,0.097157,-0.026255
06-07 17:12:47.801+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:47.801+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:47.801+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:47:808,1.198884,-1.562768,9.606812
06-07 17:12:47.811+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:47:797,0.560000,1.260000,-1.120000
06-07 17:12:47.811+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:47.811+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:47:807,0.032279,0.104651,0.030611
06-07 17:12:47.811+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:47.821+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:47:796,1.210768,-1.555335,9.736395
06-07 17:12:47.831+0200 W/LOCATION(17828): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:12:47.831+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:47.831+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:47.841+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:47:844,1.225125,-1.529014,9.686146
06-07 17:12:47.841+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:47:822,0.005895,0.042283,0.020550
06-07 17:12:47.841+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:47.841+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:47:850,-0.019733,-0.001590,0.125233
06-07 17:12:47.851+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:47:818,1.190000,1.680000,-0.560000
06-07 17:12:47.851+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:47.851+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:47:853,1.201114,-1.559172,9.607117
06-07 17:12:47.851+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:47.861+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:47:856,0.630000,-0.490000,0.210000
06-07 17:12:47.861+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:47.861+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:47.871+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:47:871,1.202417,-1.554702,9.607678
06-07 17:12:47.871+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:47:868,1.217947,-1.502693,9.552148
06-07 17:12:47.871+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:47.881+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:47:874,0.490000,-1.680000,0.910000
06-07 17:12:47.881+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:47.881+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:47.881+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:47.891+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer alive timeout
06-07 17:12:47.891+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:12:47.891+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:47.891+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:47.901+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:47:888,1.204873,-1.549761,9.608169
06-07 17:12:47.901+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:47:889,1.194018,-1.533799,9.566505
06-07 17:12:47.901+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:47.901+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17664
06-07 17:12:47.901+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:47.911+0200 I/heartrate(17619): es.ugr.frailty.heartrate - capturing data
06-07 17:12:47.911+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:47:915,1.204181,-1.546566,9.608770
06-07 17:12:47.911+0200 I/heartrate(17619): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:12:47:916,76
06-07 17:12:47.911+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17664)
06-07 17:12:47.911+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer launch request sent!
06-07 17:12:47.911+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:47.911+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope alive timeout
06-07 17:12:47.911+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:12:47.911+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:47.911+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:47.921+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:47:922,1.150948,-1.469193,9.643075
06-07 17:12:47.921+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:47.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17781
06-07 17:12:47.931+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:12:47.941+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17781)
06-07 17:12:47.941+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope launch request sent!
06-07 17:12:47.941+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:47.941+0200 I/servicemanager(12566): es.ugr.frailty.heartrate alive timeout
06-07 17:12:47.941+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:12:47.941+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:47.941+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:47.941+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:47.951+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:47:936,1.199775,-1.542514,9.609973
06-07 17:12:47.951+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:47.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17619
06-07 17:12:47.961+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:47:887,1.190000,-0.700000,1.120000
06-07 17:12:47.951+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17619)
06-07 17:12:47.961+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:47.961+0200 I/servicemanager(12566): es.ugr.frailty.heartrate launch request sent!
06-07 17:12:47.961+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:47.961+0200 I/servicemanager(12566): es.ugr.frailty.location alive timeout
06-07 17:12:47.951+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:12:47:942,646.000000
06-07 17:12:47.961+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:12:47.961+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:47:948,1.201197,-1.507478,9.667004
06-07 17:12:47.961+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:47.961+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(17619), cmd(0)
06-07 17:12:47.961+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:47.961+0200 W/CAPI_APPFW_APP_CONTROL(17619): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:47.971+0200 I/utils   (17619): specific action
06-07 17:12:47.971+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:47.971+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:47.971+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:47:979,1.244268,-1.574477,9.705289
06-07 17:12:47.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17828
06-07 17:12:47.981+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:47:971,-0.140000,-0.280000,1.120000
06-07 17:12:47.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17828)
06-07 17:12:47.981+0200 I/servicemanager(12566): es.ugr.frailty.location launch request sent!
06-07 17:12:47.981+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:47.981+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration alive timeout
06-07 17:12:47.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:12:47.981+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:47.981+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:47.981+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:47.991+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.001+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17793
06-07 17:12:48.001+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:47:994,1.182054,-1.682154,9.736395
06-07 17:12:48.001+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17793)
06-07 17:12:48.001+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:12:48.001+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:48.001+0200 I/servicemanager(12566): es.ugr.frailty.gravity alive timeout
06-07 17:12:48.001+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:12:48.001+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:48.001+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:48.001+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:3,-0.770000,-0.280000,0.910000
06-07 17:12:48.001+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:48.011+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.011+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17731
06-07 17:12:48.021+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17731)
06-07 17:12:48.021+0200 I/servicemanager(12566): es.ugr.frailty.gravity launch request sent!
06-07 17:12:48.021+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:48.021+0200 I/servicemanager(12566): es.ugr.frailty.pressure alive timeout
06-07 17:12:47.961+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:47:880,-0.041649,-0.060678,0.119244
06-07 17:12:48.021+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:12:48.021+0200 W/CAPI_APPFW_APP_CONTROL(17793): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:48.021+0200 I/utils   (17793): specific action
06-07 17:12:48.021+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.021+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:48:18,1.184447,-1.708475,9.793823
06-07 17:12:48.021+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:47.961+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:47:963,1.192801,-1.539539,9.611318
06-07 17:12:48.021+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:32,-0.008354,-0.133044,0.153791
06-07 17:12:48.031+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.031+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:21,-0.280000,0.070000,0.280000
06-07 17:12:48.031+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:48.031+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:48.041+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:38,1.191976,-1.543853,9.610728
06-07 17:12:48.041+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.041+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12603
06-07 17:12:48.051+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:48.051+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(17793), cmd(0)
06-07 17:12:48.051+0200 W/CAPI_APPFW_APP_CONTROL(12603): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:48.051+0200 I/utils   (12603): specific action
06-07 17:12:48.051+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:48.051+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(12603), cmd(0)
06-07 17:12:48.061+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12603)
06-07 17:12:48.061+0200 I/servicemanager(12566): es.ugr.frailty.pressure launch request sent!
06-07 17:12:48.061+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:48.061+0200 I/servicemanager(12566): es.ugr.frailty.light alive timeout
06-07 17:12:48.061+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:12:48.061+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:48.061+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:48.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:12:48.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:12:48.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:12:48.071+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:75,1.196659,-1.550685,9.609046
06-07 17:12:48.071+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.071+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16749
06-07 17:12:48.081+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16749)
06-07 17:12:48.081+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 17:12:48.081+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:48.081+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 17:12:48.081+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:12:48.081+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:48.081+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:83,1.200050,-1.550463,9.608659
06-07 17:12:48.081+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:48.081+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.091+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:92,1.203029,-1.550472,9.608285
06-07 17:12:48.091+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.091+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 17:12:48.091+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:48.091+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(12618), cmd(0)
06-07 17:12:48.101+0200 W/CAPI_APPFW_APP_CONTROL(16749): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:48.101+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:48.101+0200 I/utils   (16749): specific action
06-07 17:12:48.101+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:48.101+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(16749), cmd(0)
06-07 17:12:48.101+0200 I/utils   (12618): specific action
06-07 17:12:48.101+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 17:12:48.101+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 17:12:48.101+0200 I/heartrate(17619): es.ugr.frailty.heartrate - capturing data
06-07 17:12:48.101+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:48.101+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:101,1.207273,-1.552284,9.607460
06-07 17:12:48.101+0200 I/heartrate(17619): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:12:48:110,77
06-07 17:12:48.101+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.101+0200 W/CAPI_APPFW_APP_CONTROL(17781): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:48.111+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:48.111+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(17781), cmd(0)
06-07 17:12:48.111+0200 I/utils   (17781): specific action
06-07 17:12:48.111+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:48:41,1.241875,-1.715654,9.824929
06-07 17:12:48.111+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:114,0.059470,-0.143087,0.156774
06-07 17:12:48.111+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.111+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.121+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:123,0.083501,-0.040542,0.115385
06-07 17:12:48.121+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.121+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:12:48.121+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:128,0.063360,0.011878,0.060738
06-07 17:12:48.121+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.131+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:12:48:130,645.000000
06-07 17:12:48.131+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:133,0.077131,0.002316,0.046755
06-07 17:12:48.131+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.131+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:139,-0.010861,0.059163,0.042793
06-07 17:12:48.131+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.141+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:144,0.008968,0.150001,0.075806
06-07 17:12:48.141+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.141+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.141+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:48.141+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:150,-0.022105,0.039517,0.081758
06-07 17:12:48.141+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.151+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:122,-0.280000,0.280000,-0.350000
06-07 17:12:48.151+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:155,-0.006887,-0.007005,0.099940
06-07 17:12:48.151+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.151+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:160,0.022547,-0.159566,0.147117
06-07 17:12:48.161+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.161+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:154,1.206586,-1.549802,9.607947
06-07 17:12:48.161+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:166,-0.005857,-0.124227,0.150533
06-07 17:12:48.161+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.161+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.161+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:170,0.014435,-0.030331,0.071903
06-07 17:12:48.171+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.171+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:176,0.045679,0.046754,0.023728
06-07 17:12:48.171+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.171+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:181,0.045705,0.044500,0.004136
06-07 17:12:48.181+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.181+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.181+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:188,0.016747,0.028916,-0.031624
06-07 17:12:48.181+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.181+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:48:172,1.234696,-1.619941,9.741181
06-07 17:12:48.191+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:177,-0.280000,1.050000,-0.700000
06-07 17:12:48.191+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:193,0.008673,-0.113944,0.064315
06-07 17:12:48.191+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.191+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:198,0.034662,-0.088005,0.086983
06-07 17:12:48.191+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.201+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:203,-0.007361,-0.078017,0.111918
06-07 17:12:48.201+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.201+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:194,1.206552,-1.542209,9.609173
06-07 17:12:48.201+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:208,-0.043543,-0.026579,0.095097
06-07 17:12:48.201+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.201+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:48.201+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.211+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:213,-0.048364,0.030735,0.098885
06-07 17:12:48.211+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.211+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:219,0.012181,0.028861,0.111483
06-07 17:12:48.211+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.221+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:223,0.040630,-0.007835,0.075110
06-07 17:12:48.221+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.221+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:48:215,1.251446,-1.507478,9.628718
06-07 17:12:48.221+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:230,0.010929,-0.104519,0.037858
06-07 17:12:48.221+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.231+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.231+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:235,-0.008115,-0.096187,0.053160
06-07 17:12:48.231+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.231+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:215,-0.070000,1.120000,-0.280000
06-07 17:12:48.241+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.241+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:247,-0.420000,0.350000,0.210000
06-07 17:12:48.241+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.251+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:243,0.070369,-0.050609,0.082039
06-07 17:12:48.251+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:253,1.120000,-0.490000,0.420000
06-07 17:12:48.251+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.261+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:261,1.750000,-0.560000,0.630000
06-07 17:12:48.261+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.261+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.261+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:48.261+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:239,1.203298,-1.538759,9.610134
06-07 17:12:48.261+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:48.261+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(17731), cmd(0)
06-07 17:12:48.271+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:272,1.750000,-0.910000,0.770000
06-07 17:12:48.271+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:269,0.062678,0.017375,0.166309
06-07 17:12:48.271+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:48:277,1.225125,-1.462015,9.580862
06-07 17:12:48.271+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.271+0200 W/CAPI_APPFW_APP_CONTROL(17731): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:48.271+0200 I/utils   (17731): specific action
06-07 17:12:48.271+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.271+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.281+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:285,-0.003504,0.009459,0.256928
06-07 17:12:48.281+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:289,-0.140000,-0.280000,0.770000
06-07 17:12:48.291+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.291+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:48.291+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.301+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:303,-0.039629,-0.070915,0.053041
06-07 17:12:48.301+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:297,-0.910000,0.280000,0.840000
06-07 17:12:48.301+0200 I/heartrate(17619): es.ugr.frailty.heartrate - capturing data
06-07 17:12:48.301+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:284,1.200186,-1.536946,9.610813
06-07 17:12:48.301+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.301+0200 I/heartrate(17619): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:12:48:310,76
06-07 17:12:48.311+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.311+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:316,-0.980000,0.140000,0.490000
06-07 17:12:48.311+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.321+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:48:298,1.234696,-1.450050,9.638289
06-07 17:12:48.321+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:311,1.199875,-1.543571,9.609791
06-07 17:12:48.321+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.321+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:12:48.321+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.331+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:12:48:329,645.000000
06-07 17:12:48.321+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:322,-0.980000,0.210000,0.140000
06-07 17:12:48.331+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:330,-0.095457,-0.013018,0.053006
06-07 17:12:48.331+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.341+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:330,1.198726,-1.546539,9.609457
06-07 17:12:48.341+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:12:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:12:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:12:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:12:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:12:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:12:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:12:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:12:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:12:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:12:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:12:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:12:48.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391568349,000000, pattern:[H:mm][0;m
06-07 17:12:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:12:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:12:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:12:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:12:48.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:12:48.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:12][0;m
06-07 17:12:48.351+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.351+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:48.351+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:347,1.198589,-1.544661,9.609776
06-07 17:12:48.361+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:342,0.004755,-0.018039,-0.045696
06-07 17:12:48.361+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.361+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.371+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:359,0.490000,0.350000,-0.210000
06-07 17:12:48.371+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.371+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:48:363,1.210768,-1.507478,9.628718
06-07 17:12:48.371+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:373,0.105311,0.056345,0.141267
06-07 17:12:48.381+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:48.381+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:375,1.200956,-1.540015,9.610226
06-07 17:12:48.381+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.381+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.391+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:48:387,1.184447,-1.548156,9.734003
06-07 17:12:48.391+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:384,0.980000,0.700000,-0.280000
06-07 17:12:48.391+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.391+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:392,1.203593,-1.538787,9.610093
06-07 17:12:48.401+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:48.401+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:393,0.100057,-0.008404,0.167446
06-07 17:12:48.401+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.401+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.411+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:415,1.204489,-1.539496,9.609867
06-07 17:12:48.411+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:415,0.013408,0.024058,0.153583
06-07 17:12:48.411+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.411+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:401,1.680000,0.700000,-0.280000
06-07 17:12:48.411+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.411+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:48:411,1.158126,-1.603191,9.729217
06-07 17:12:48.421+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:48.421+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.421+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:424,0.840000,-0.490000,0.280000
06-07 17:12:48.431+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.441+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:434,-0.000887,0.066634,0.119612
06-07 17:12:48.441+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:420,1.204820,-1.546293,9.608734
06-07 17:12:48.441+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.441+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:48:435,1.184447,-1.672583,9.765109
06-07 17:12:48.441+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.451+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:444,-1.540000,-0.420000,0.630000
06-07 17:12:48.451+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:48.461+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.461+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:48:463,1.251446,-1.686940,9.767502
06-07 17:12:48.461+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:455,0.007914,-0.025952,0.073978
06-07 17:12:48.461+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:472,-0.770000,0.350000,0.770000
06-07 17:12:48.471+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:453,1.206165,-1.551495,9.607727
06-07 17:12:48.471+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.471+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.471+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:48.481+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:479,1.204062,-1.552684,9.607799
06-07 17:12:48.481+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.481+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:479,-0.024724,-0.067500,-0.025700
06-07 17:12:48.481+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.491+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.491+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:489,0.700000,0.210000,0.700000
06-07 17:12:48.491+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:48:486,1.280160,-1.591227,9.724431
06-07 17:12:48.491+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:496,1.199312,-1.550177,9.608797
06-07 17:12:48.501+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.501+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:48.501+0200 I/heartrate(17619): es.ugr.frailty.heartrate - capturing data
06-07 17:12:48.501+0200 I/heartrate(17619): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:12:48:510,77
06-07 17:12:48.511+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:496,0.009241,-0.072508,-0.041086
06-07 17:12:48.511+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.511+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:508,0.700000,-0.420000,0.630000
06-07 17:12:48.511+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:48:514,1.263410,-1.538585,9.669396
06-07 17:12:48.511+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.521+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:12:48.521+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:524,1.193802,-1.543517,9.610556
06-07 17:12:48.521+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:12:48:527,645.000000
06-07 17:12:48.521+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.521+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.531+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:522,0.076679,-0.026119,0.029475
06-07 17:12:48.531+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:48.531+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.541+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:533,1.194067,-1.540321,9.611035
06-07 17:12:48.541+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:537,0.770000,-0.210000,0.840000
06-07 17:12:48.541+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.551+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.551+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:48:545,1.280160,-1.548156,9.655040
06-07 17:12:48.551+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:549,0.016300,0.202800,0.153069
06-07 17:12:48.561+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:559,-0.490000,0.350000,0.840000
06-07 17:12:48.561+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.561+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.561+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:549,1.197447,-1.544136,9.610003
06-07 17:12:48.561+0200 W/CAPI_APPFW_APP_CONTROL(17664): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:48.561+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:48.571+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(17664), cmd(0)
06-07 17:12:48.571+0200 I/utils   (17664): specific action
06-07 17:12:48.571+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:48.571+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.571+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:569,0.027296,0.181691,0.094169
06-07 17:12:48.581+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.581+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:584,1.197347,-1.550076,9.609058
06-07 17:12:48.581+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:48:580,1.196411,-1.493121,9.650253
06-07 17:12:48.581+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.581+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:574,-0.420000,0.910000,0.770000
06-07 17:12:48.581+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.591+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:48.601+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:588,0.050119,-0.108155,0.114272
06-07 17:12:48.601+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.601+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:48:601,1.215554,-1.399801,9.683753
06-07 17:12:48.601+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:597,0.700000,-0.490000,0.630000
06-07 17:12:48.601+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:591,1.195434,-1.552582,9.608892
06-07 17:12:48.611+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.611+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:48.611+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:618,1.540000,-1.540000,0.630000
06-07 17:12:48.611+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:608,0.081685,-0.184426,0.066134
06-07 17:12:48.621+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.621+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:48:623,1.184447,-1.502693,9.690931
06-07 17:12:48.631+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.631+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.641+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:48:628,0.023055,-0.318502,0.117033
06-07 17:12:48.641+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:48.651+0200 I/linearacceleration(17793): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:48.651+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:653,1.198339,-1.553567,9.608371
06-07 17:12:48.661+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.661+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:666,1.199916,-1.550437,9.608680
06-07 17:12:48.661+0200 I/gravity (17731): es.ugr.frailty.gravity - capturing data
06-07 17:12:48.671+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:48:647,1.540000,-1.260000,1.120000
06-07 17:12:48.671+0200 I/gravity (17731): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:48:672,1.197755,-1.549026,9.609178
06-07 17:12:48.671+0200 I/gyroscope(17781): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:48.671+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11178286c6f63152838436
