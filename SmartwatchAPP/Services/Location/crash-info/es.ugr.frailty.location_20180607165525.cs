S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 12735
Date: 2018-06-07 16:55:25+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf734a52d, r5   = 0xf76eef98
r6   = 0xfffbf430, r7   = 0xfffbf2e0
r8   = 0xf76ebc18, r9   = 0x00000000
r10  = 0xfffbf3bc, fp   = 0xfffbf430
ip   = 0x00000001, sp   = 0xfffbf2b8
lr   = 0xf734a539, pc   = 0xf73b3228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     20312 KB
Buffers:      7652 KB
Cached:     112604 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11904 KB
VmRSS:       11904 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 12735 TID = 12735
12735 12739 

Maps Information
f4215000 f4a14000 rw-p [stack:12739]
f4a1b000 f4a1d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4a25000 f4a29000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4a32000 f4a34000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4a3c000 f4a3f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4a4e000 f4a53000 r-xp /usr/lib/libsystem.so.0.0.0
f4a5e000 f4a61000 r-xp /lib/libattr.so.1.1.0
f4a69000 f4a79000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4a81000 f4a8a000 r-xp /usr/lib/libedbus.so.1.7.99
f4a92000 f4a93000 r-xp /usr/lib/libresponse.so.0.2.96
f4a9c000 f4aa1000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6343000 f6449000 r-xp /usr/lib/libicuuc.so.57.1
f645f000 f65e7000 r-xp /usr/lib/libicui18n.so.57.1
f65f7000 f6604000 r-xp /usr/lib/libail.so.0.1.0
f660d000 f6614000 r-xp /usr/lib/libminizip.so.1.0.0
f661d000 f67c6000 r-xp /usr/lib/libcrypto.so.1.0.0
f67e6000 f682d000 r-xp /usr/lib/libssl.so.1.0.0
f6839000 f683b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6843000 f684a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6853000 f685a000 r-xp /lib/libcrypt-2.13.so
f688b000 f688e000 r-xp /lib/libcap.so.2.21
f6896000 f6898000 r-xp /usr/lib/libiri.so
f68a0000 f68e9000 r-xp /usr/lib/libmdm.so.1.2.69
f68f1000 f68f7000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f68ff000 f6922000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f692c000 f692e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6936000 f6953000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f695c000 f6960000 r-xp /usr/lib/libsmack.so.1.0.0
f6969000 f6982000 r-xp /usr/lib/libnetwork.so.0.0.0
f698b000 f6993000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f699b000 f69a1000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f69aa000 f69ac000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f69b5000 f69c5000 r-xp /lib/libresolv-2.13.so
f69c9000 f69e1000 r-xp /usr/lib/liblzma.so.5.0.3
f69ea000 f69ec000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f69f4000 f6a0e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a16000 f6a45000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a4e000 f6a5d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a67000 f6a71000 r-xp /usr/lib/libsensord-shared.so
f6a7a000 f6b4d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b58000 f6b6e000 r-xp /lib/libz.so.1.2.5
f6b76000 f6b7b000 r-xp /usr/lib/libffi.so.5.0.10
f6b83000 f6b84000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b8c000 f6b9c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ba4000 f6bbd000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6bc5000 f6bc7000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6bcf000 f6c44000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c4e000 f6c54000 r-xp /lib/librt-2.13.so
f6c5d000 f6c7b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c85000 f6c86000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c8e000 f6cb1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6cb9000 f6cbe000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6cc6000 f6cf0000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6cf9000 f6d10000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d18000 f6d81000 r-xp /lib/libm-2.13.so
f6d8a000 f6e1e000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e31000 f6e36000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e3e000 f6e45000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e4d000 f6e77000 r-xp /usr/lib/libsensor.so.1.9.6
f6e80000 f6f4c000 r-xp /usr/lib/libxml2.so.2.7.8
f6f59000 f6f5b000 r-xp /usr/lib/libiniparser.so.0
f6f64000 f6f6a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f73000 f7043000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7044000 f7078000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7081000 f70bd000 r-xp /usr/lib/libSLP-location.so.0.9.24
f70c5000 f70c8000 r-xp /usr/lib/libbundle.so.0.1.22
f70d0000 f70d6000 r-xp /usr/lib/libappsvc.so.0.1.0
f70de000 f711f000 r-xp /usr/lib/libeina.so.1.7.99
f7128000 f713f000 r-xp /usr/lib/libecore.so.1.7.99
f7156000 f715f000 r-xp /usr/lib/libvconf.so.0.2.45
f7167000 f717b000 r-xp /lib/libpthread-2.13.so
f7186000 f7193000 r-xp /usr/lib/libaul.so.0.1.0
f719d000 f719f000 r-xp /lib/libdl-2.13.so
f71a8000 f71b3000 r-xp /lib/libunwind.so.8.0.1
f71e0000 f71e8000 r-xp /lib/libgcc_s-4.6.so.1
f71e9000 f730d000 r-xp /lib/libc-2.13.so
f731b000 f731d000 r-xp /usr/lib/libdlog.so.0.0.0
f7325000 f7331000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f733a000 f733f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7347000 f7356000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f735e000 f7362000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f736b000 f736e000 r-xp /usr/lib/libappcore-agent.so.1.1
f7376000 f7378000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7380000 f7384000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f738c000 f73a9000 r-xp /lib/ld-2.13.so
f73b2000 f73b5000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f73b5000 f73b9000 r-xp /usr/lib/libsys-assert.so
f76bb000 f772c000 rw-p [heap]
fffa0000 fffc1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12735)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf73b3228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf734a539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70513f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf704fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf705be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7061be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7061dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf709675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70911f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf704fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf705be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7061be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7061dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7093e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7094017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf709bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4a331fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4a26171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6af9663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6fa6fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6fa87a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7138ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7133b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71345a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7134879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf736c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf736c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73b35c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf720085c) [/lib/libc.so.6] + 0x1785c
29: (0xf73b2f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
SM-R760,07/06/2018,16:55:24:864,0.008743,0.111409,-0.070395
06-07 16:55:24.861+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:24.861+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:24:867,8.796017,1.524228,3.991228
06-07 16:55:24.861+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:24.861+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:24:871,0.034697,0.132499,0.004390
06-07 16:55:24.871+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:24.871+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:24:865,8.847605,1.609679,3.911421
06-07 16:55:24.871+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:24.871+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:24:877,-1.330000,0.630000,0.770000
06-07 16:55:24.871+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:24:872,8.927622,1.617548,3.921836
06-07 16:55:24.871+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:24.871+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:24.881+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:24:883,8.925228,1.653440,3.787838
06-07 16:55:24.881+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:24:884,0.018125,0.039209,0.123208
06-07 16:55:24.881+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:24.881+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:24:880,8.848318,1.609391,3.909925
06-07 16:55:24.881+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:24:889,8.858230,1.718047,3.914658
06-07 16:55:24.881+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:24.881+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:24.891+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:24.891+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:24:893,8.870193,1.596013,4.043870
06-07 16:55:24.891+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:24.891+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:24:897,-0.700000,-0.070000,0.070000
06-07 16:55:24.891+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:24.891+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:24:898,8.855836,1.572084,4.094120
06-07 16:55:24.891+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:24.901+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:24:901,-0.024976,-0.094131,0.186978
06-07 16:55:24.901+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:24:903,8.846266,1.540978,3.926622
06-07 16:55:24.901+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:24.901+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:24:908,8.944371,1.627119,3.816552
06-07 16:55:24.901+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:24.901+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:24:894,8.847046,1.609130,3.912910
06-07 16:55:24.901+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:24.911+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:24:912,8.874979,1.596013,3.900301
06-07 16:55:24.911+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:24.911+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:24:915,8.845326,1.608857,3.916908
06-07 16:55:24.911+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:24.911+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:24:917,8.884550,1.509871,3.979264
06-07 16:55:24.911+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:24.911+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:24.921+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:24:922,8.891729,1.598405,3.914658
06-07 16:55:24.921+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:24.921+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:24:921,0.028056,-0.033847,-0.024869
06-07 16:55:24.921+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:24:923,1.120000,-1.120000,0.560000
06-07 16:55:24.921+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:24:927,8.886944,1.718047,3.950550
06-07 16:55:24.921+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:24.931+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:24:932,8.860621,1.596013,4.051049
06-07 16:55:24.931+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:24.931+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:24.931+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:24:937,8.920443,1.624727,3.914658
06-07 16:55:24.931+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:24.931+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:24.931+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:24:941,0.130326,-0.026646,-0.141094
06-07 16:55:24.941+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:24.941+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:24:937,0.070000,-0.280000,0.140000
06-07 16:55:24.941+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:24:942,8.901299,1.624727,3.921836
06-07 16:55:24.941+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:24.941+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:24:946,8.844338,1.607912,3.919525
06-07 16:55:24.941+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:24:949,8.872586,1.672583,3.869194
06-07 16:55:24.941+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:24.941+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:24.951+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:24.951+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:24:954,8.896514,1.679761,3.878766
06-07 16:55:24.951+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:24.951+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:24.951+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:24:957,0.051955,0.006439,-0.055855
06-07 16:55:24.951+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:24:959,8.941978,1.665405,3.969693
06-07 16:55:24.951+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:24.961+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:24:958,-0.070000,0.910000,-0.140000
06-07 16:55:24.961+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:24:965,8.841480,1.641476,3.981657
06-07 16:55:24.961+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:24.961+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:24:953,8.844926,1.609937,3.917369
06-07 16:55:24.961+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:24.961+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:24:970,8.846266,1.634298,3.936193
06-07 16:55:24.961+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:24.971+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:24.971+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:24.971+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:24:974,8.915657,1.710868,3.929015
06-07 16:55:24.971+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:24.971+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:24:979,-0.070000,0.910000,0.070000
06-07 16:55:24.971+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:24:980,8.822337,1.612763,3.900301
06-07 16:55:24.971+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:24.971+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:24:977,0.054003,0.118286,0.033719
06-07 16:55:24.981+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:24:972,8.845828,1.610893,3.914936
06-07 16:55:24.981+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:24:985,8.927622,1.533799,3.964907
06-07 16:55:24.981+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:24.981+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:24.981+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:24:990,8.846983,1.610363,3.912545
06-07 16:55:24.981+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:24:990,8.930015,1.552942,3.955336
06-07 16:55:24.981+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:24.991+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:24.991+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:24.991+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:24:995,8.889337,1.634298,3.938586
06-07 16:55:24.991+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:24.991+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:55:24.991+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:0,8.877372,1.691726,3.938586
06-07 16:55:25.001+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.001+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:55:25:3,85
06-07 16:55:25.001+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:24:997,-0.020846,0.060580,0.051057
06-07 16:55:25.001+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:24:999,-1.120000,-0.070000,0.910000
06-07 16:55:25.001+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:6,8.879765,1.596013,3.909872
06-07 16:55:25.001+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.001+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.001+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:10,8.901299,1.607977,3.912265
06-07 16:55:25.001+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.011+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:13,8.847095,1.610302,3.912318
06-07 16:55:25.011+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.011+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:15,8.915657,1.658226,3.964907
06-07 16:55:25.011+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.011+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:55:25.011+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.011+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.011+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:21,8.831908,1.567299,3.883551
06-07 16:55:25.021+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.021+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:27,8.918050,1.536192,3.940979
06-07 16:55:25.021+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.021+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:55:25:25,582.000000
06-07 16:55:25.021+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:25:23,-1.400000,-0.070000,0.280000
06-07 16:55:25.031+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:32,8.932407,1.672583,3.976871
06-07 16:55:25.031+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.031+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.031+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:25,0.066062,-0.071497,0.188300
06-07 16:55:25.031+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.031+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:38,8.874979,1.658226,4.019942
06-07 16:55:25.031+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.041+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:19,8.847612,1.613207,3.909949
06-07 16:55:25.041+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:43,8.858230,1.567299,4.019942
06-07 16:55:25.041+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.041+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:25:42,-0.070000,-0.630000,0.630000
06-07 16:55:25.041+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:43,-0.001160,-0.123308,0.001612
06-07 16:55:25.041+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:48,8.882158,1.617548,3.933800
06-07 16:55:25.041+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.041+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.051+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.051+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.051+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:25:61,-0.070000,-0.350000,0.210000
06-07 16:55:25.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:55:25.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:55:25.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:55:25.061+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:53,8.860621,1.631905,3.900301
06-07 16:55:25.061+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:56,8.848877,1.615002,3.906344
06-07 16:55:25.061+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.061+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:65,0.037390,-0.070724,-0.015653
06-07 16:55:25.061+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.071+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:73,8.870193,1.617548,3.917051
06-07 16:55:25.071+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.071+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.071+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.071+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:79,8.884550,1.631905,3.988836
06-07 16:55:25.071+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.081+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:75,8.845873,1.614941,3.913168
06-07 16:55:25.081+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:85,8.812766,1.605584,4.003192
06-07 16:55:25.081+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.081+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.081+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:25:81,0.350000,0.140000,-0.070000
06-07 16:55:25.081+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:90,8.889337,1.593620,4.017549
06-07 16:55:25.091+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.091+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:83,0.076417,-0.057076,0.003158
06-07 16:55:25.091+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:97,8.858230,1.643869,3.933800
06-07 16:55:25.091+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.091+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.091+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:25:102,0.840000,0.350000,-0.070000
06-07 16:55:25.091+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:101,8.884550,1.658226,3.890730
06-07 16:55:25.101+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.101+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.101+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:106,0.046784,0.043811,-0.015045
06-07 16:55:25.101+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:97,8.845314,1.608504,3.917081
06-07 16:55:25.101+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:107,8.834301,1.629512,3.900301
06-07 16:55:25.101+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.101+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.111+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:112,8.901299,1.610370,3.907479
06-07 16:55:25.111+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.111+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:114,8.847048,1.607047,3.913761
06-07 16:55:25.111+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.111+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:117,8.848659,1.670190,3.888337
06-07 16:55:25.111+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.111+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.121+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:122,8.874979,1.670190,3.852444
06-07 16:55:25.121+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.121+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:25:121,-0.420000,-0.070000,-0.070000
06-07 16:55:25.121+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.121+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:127,8.891729,1.641476,4.024727
06-07 16:55:25.121+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.121+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:122,0.032159,-0.016084,0.142109
06-07 16:55:25.131+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:132,8.846266,1.490728,4.007978
06-07 16:55:25.131+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.131+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.131+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:137,8.891729,1.548156,3.909872
06-07 16:55:25.131+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.131+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.131+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:131,8.847093,1.613816,3.910875
06-07 16:55:25.141+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:142,8.886944,1.727618,3.850052
06-07 16:55:25.141+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.141+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:25:138,0.070000,-0.070000,0.140000
06-07 16:55:25.141+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.141+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:141,-0.011132,-0.026533,0.127001
06-07 16:55:25.141+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:147,8.855836,1.725225,3.840480
06-07 16:55:25.141+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.151+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:152,8.882158,1.751546,3.912265
06-07 16:55:25.151+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.151+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.151+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:157,8.865408,1.663012,4.029513
06-07 16:55:25.151+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:25:157,1.470000,-0.980000,0.210000
06-07 16:55:25.151+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.151+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.151+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:161,0.014602,-0.060670,-0.076401
06-07 16:55:25.161+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:151,8.847462,1.619047,3.907875
06-07 16:55:25.161+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:162,8.819944,1.529014,4.098906
06-07 16:55:25.161+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.161+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.161+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:167,8.870193,1.584049,3.895515
06-07 16:55:25.161+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.161+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:169,8.847283,1.623803,3.906305
06-07 16:55:25.171+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.171+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:172,8.975478,1.588834,3.773481
06-07 16:55:25.171+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.171+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.171+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:177,8.901299,1.619941,3.850052
06-07 16:55:25.171+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.171+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.171+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:181,0.125912,0.059111,-0.160346
06-07 16:55:25.171+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:25:177,0.630000,-0.490000,0.350000
06-07 16:55:25.181+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:182,8.903693,1.732404,3.938586
06-07 16:55:25.181+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.181+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:176,8.844920,1.623145,3.911927
06-07 16:55:25.181+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:187,8.827123,1.679761,3.957729
06-07 16:55:25.181+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.181+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.181+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:191,8.913264,1.548156,4.096512
06-07 16:55:25.191+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.191+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.191+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:197,8.843873,1.490728,3.917051
06-07 16:55:25.191+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.191+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.191+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:55:25.201+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:201,8.884550,1.536192,3.897908
06-07 16:55:25.201+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.201+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:55:25:204,85
06-07 16:55:25.201+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:25:197,-1.330000,0.770000,-0.140000
06-07 16:55:25.201+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:201,0.032807,0.009274,-0.051076
06-07 16:55:25.201+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:207,8.925228,1.545763,3.914658
06-07 16:55:25.201+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.201+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:193,8.842137,1.617896,3.920384
06-07 16:55:25.201+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:212,8.896514,1.643869,3.895515
06-07 16:55:25.211+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.211+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.211+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:217,8.845152,1.615480,3.914576
06-07 16:55:25.211+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:217,8.882158,1.586441,4.051049
06-07 16:55:25.211+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.211+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.211+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.211+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:55:25.221+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:222,8.836694,1.574477,4.041477
06-07 16:55:25.221+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.231+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:225,0.049813,0.042673,0.051273
06-07 16:55:25.241+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:55:25:223,583.000000
06-07 16:55:25.241+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:25:232,-0.840000,0.490000,-0.140000
06-07 16:55:25.241+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.241+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.251+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:255,0.032329,0.060428,0.095937
06-07 16:55:25.251+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.261+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:25:255,1.260000,-0.350000,-0.140000
06-07 16:55:25.261+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:265,8.849344,1.613502,3.905907
06-07 16:55:25.261+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.261+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.271+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:228,8.860621,1.538585,3.842873
06-07 16:55:25.281+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.291+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:285,8.975478,1.655833,3.751946
06-07 16:55:25.291+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.291+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:299,8.886944,1.607977,3.850052
06-07 16:55:25.291+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.301+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:304,8.903693,1.641476,3.952943
06-07 16:55:25.301+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.301+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.301+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:309,8.849690,1.614118,3.904867
06-07 16:55:25.301+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:309,8.884550,1.660619,4.000800
06-07 16:55:25.301+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.311+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:314,8.886944,1.658226,3.943372
06-07 16:55:25.311+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:276,0.035884,0.054908,0.037160
06-07 16:55:25.311+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.311+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:25:274,-1.190000,0.560000,0.070000
06-07 16:55:25.311+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:318,8.858230,1.512264,3.905087
06-07 16:55:25.311+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.321+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.321+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:324,8.908479,1.598405,3.919443
06-07 16:55:25.321+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.321+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.321+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:329,8.906086,1.684547,3.919443
06-07 16:55:25.321+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.331+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.331+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:337,8.841480,1.655833,3.945765
06-07 16:55:25.331+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:335,8.847969,1.619181,3.906672
06-07 16:55:25.331+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:326,0.008748,-0.092590,-0.004069
06-07 16:55:25.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:55:25.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:55:25.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:55:25.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:55:25.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390525347,000000, pattern:[H:mm][0;m
06-07 16:55:25.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:55:25.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:55:25.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:55:25.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:55:25.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:55:25.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:55][0;m
06-07 16:55:25.341+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:25:332,-0.280000,-0.630000,0.490000
06-07 16:55:25.341+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.341+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.351+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.351+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:357,8.906086,1.612763,3.972085
06-07 16:55:25.351+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:356,0.057156,-0.000861,0.012168
06-07 16:55:25.351+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.361+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:25:361,0.630000,0.350000,-0.210000
06-07 16:55:25.361+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:364,8.847202,1.619654,3.908212
06-07 16:55:25.371+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.371+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.371+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:378,0.054799,0.084905,0.012238
06-07 16:55:25.371+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.381+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:380,8.874979,1.562513,4.017549
06-07 16:55:25.381+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:385,-0.009051,0.053389,0.037996
06-07 16:55:25.391+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.391+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.401+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:400,0.056092,0.008791,0.063727
06-07 16:55:25.401+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.401+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:408,0.024989,-0.040759,0.108894
06-07 16:55:25.401+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.401+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:55:25.411+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:414,0.034002,0.012429,0.105935
06-07 16:55:25.411+0200 W/LOCATION(12735): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 16:55:25.411+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:55:25.421+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.431+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:431,0.058082,0.057889,-0.009881
06-07 16:55:25.431+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:55:25:415,85
06-07 16:55:25.431+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:55:25:424,584.000000
06-07 16:55:25.431+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.441+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.441+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.451+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:444,0.082395,0.017901,-0.059684
06-07 16:55:25.451+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.451+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:448,8.882158,1.612763,4.019942
06-07 16:55:25.461+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:397,8.845033,1.614036,3.915439
06-07 16:55:25.461+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:460,0.019699,0.013249,0.018550
06-07 16:55:25.461+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.471+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.471+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:25:450,-1.050000,0.140000,0.070000
06-07 16:55:25.471+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.471+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.481+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:484,-0.002720,-0.053633,0.049217
06-07 16:55:25.481+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:477,8.847160,1.606916,3.913561
06-07 16:55:25.491+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.491+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:25:484,-0.140000,-0.140000,0.420000
06-07 16:55:25.491+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:497,0.024331,-0.026291,0.146665
06-07 16:55:25.491+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.491+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:483,8.903693,1.658226,3.909872
06-07 16:55:25.491+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.501+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.501+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:504,8.848811,1.602840,3.911500
06-07 16:55:25.511+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.511+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:506,8.930015,1.619941,3.854837
06-07 16:55:25.521+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:522,0.040734,-0.050063,-0.021717
06-07 16:55:25.521+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.521+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:25:515,0.280000,-0.140000,0.350000
06-07 16:55:25.531+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.531+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.531+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:538,0.069303,-0.009371,-0.019350
06-07 16:55:25.531+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:538,8.870193,1.615155,3.926622
06-07 16:55:25.531+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.541+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:531,8.849730,1.600058,3.910561
06-07 16:55:25.541+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.541+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:547,8.849999,1.602525,3.908940
06-07 16:55:25.541+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:25:543,-0.770000,0.420000,0.140000
06-07 16:55:25.541+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.551+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.551+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.551+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:558,0.027904,-0.004710,0.011048
06-07 16:55:25.551+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.551+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:554,8.848659,1.548156,3.955336
06-07 16:55:25.561+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:25:560,-0.630000,0.700000,-0.070000
06-07 16:55:25.561+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:567,8.847826,1.601010,3.914477
06-07 16:55:25.561+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.571+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.571+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.571+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:577,0.044817,0.044572,0.003891
06-07 16:55:25.571+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.581+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:572,8.874979,1.572084,4.055835
06-07 16:55:25.581+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.581+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:25:578,1.260000,-0.560000,0.630000
06-07 16:55:25.581+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.591+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.591+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:597,0.049532,0.144131,-0.020908
06-07 16:55:25.591+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:585,8.846020,1.599255,3.919274
06-07 16:55:25.591+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:55:25.601+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:55:25:604,85
06-07 16:55:25.601+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:25:599,0.770000,-0.420000,0.490000
06-07 16:55:25.601+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:592,8.889337,1.545763,3.893122
06-07 16:55:25.601+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.601+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.611+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:614,8.849566,1.596722,3.912292
06-07 16:55:25.611+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.611+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:618,8.920443,1.584049,3.890730
06-07 16:55:25.611+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:55:25.611+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.621+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.621+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:55:25:625,585.000000
06-07 16:55:25.621+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:627,8.879765,1.588834,3.919443
06-07 16:55:25.621+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.621+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:624,0.030339,0.082839,0.070308
06-07 16:55:25.631+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.631+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:638,0.015230,-0.036308,0.096083
06-07 16:55:25.631+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.641+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:632,8.896514,1.639083,3.912265
06-07 16:55:25.641+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:25:620,0.770000,-0.280000,0.490000
06-07 16:55:25.641+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.641+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.641+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:645,8.854136,1.598703,3.901127
06-07 16:55:25.651+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.651+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.651+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:649,8.901299,1.741975,3.885944
06-07 16:55:25.661+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:25:654,-0.840000,0.210000,0.210000
06-07 16:55:25.671+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:658,-0.003350,-0.037606,0.148414
06-07 16:55:25.671+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.671+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.671+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:25.681+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:25:685,-0.490000,0.140000,0.280000
06-07 16:55:25.681+0200 I/gravity (12699): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:25:676,8.853880,1.598803,3.901670
06-07 16:55:25.691+0200 I/gravity (12699): es.ugr.frailty.gravity - capturing data
06-07 16:55:25.691+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:25:682,8.882158,1.686940,3.974478
06-07 16:55:25.691+0200 I/accelerometer(12588): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:25.691+0200 I/gyroscope(12592): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:25.691+0200 I/linearacceleration(12600): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:25:691,0.032702,0.049488,-0.010890
06-07 16:55:25.691+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11127356c6f63152838332
