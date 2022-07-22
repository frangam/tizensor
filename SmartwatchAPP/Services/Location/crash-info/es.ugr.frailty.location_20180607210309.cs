S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 2486
Date: 2018-06-07 21:03:09+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf74c052d, r5   = 0xf7bbf150
r6   = 0xfff97068, r7   = 0xfff96f18
r8   = 0xf7bd1c18, r9   = 0x00000000
r10  = 0xfff96ff4, fp   = 0xfff97068
ip   = 0x00000001, sp   = 0xfff96ef0
lr   = 0xf74c0539, pc   = 0xf7529228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    166900 KB
Buffers:     18584 KB
Cached:     148260 KB
VmPeak:      53444 KB
VmSize:      53416 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12036 KB
VmRSS:       12032 KB
VmData:      11144 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 2486 TID = 2486
2486 2583 

Maps Information
f438b000 f4b8a000 rw-p [stack:2583]
f4b91000 f4b93000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b9b000 f4b9f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4ba8000 f4baa000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4bb2000 f4bb5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4bc4000 f4bc9000 r-xp /usr/lib/libsystem.so.0.0.0
f4bd4000 f4bd7000 r-xp /lib/libattr.so.1.1.0
f4bdf000 f4bef000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4bf7000 f4c00000 r-xp /usr/lib/libedbus.so.1.7.99
f4c08000 f4c09000 r-xp /usr/lib/libresponse.so.0.2.96
f4c12000 f4c17000 r-xp /usr/lib/libproc-stat.so.0.2.96
f64b9000 f65bf000 r-xp /usr/lib/libicuuc.so.57.1
f65d5000 f675d000 r-xp /usr/lib/libicui18n.so.57.1
f676d000 f677a000 r-xp /usr/lib/libail.so.0.1.0
f6783000 f678a000 r-xp /usr/lib/libminizip.so.1.0.0
f6793000 f693c000 r-xp /usr/lib/libcrypto.so.1.0.0
f695c000 f69a3000 r-xp /usr/lib/libssl.so.1.0.0
f69af000 f69b1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f69b9000 f69c0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f69c9000 f69d0000 r-xp /lib/libcrypt-2.13.so
f6a01000 f6a04000 r-xp /lib/libcap.so.2.21
f6a0c000 f6a0e000 r-xp /usr/lib/libiri.so
f6a16000 f6a5f000 r-xp /usr/lib/libmdm.so.1.2.69
f6a67000 f6a6d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a75000 f6a98000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6aa2000 f6aa4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6aac000 f6ac9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6ad2000 f6ad6000 r-xp /usr/lib/libsmack.so.1.0.0
f6adf000 f6af8000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b01000 f6b09000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b11000 f6b17000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b20000 f6b22000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b2b000 f6b3b000 r-xp /lib/libresolv-2.13.so
f6b3f000 f6b57000 r-xp /usr/lib/liblzma.so.5.0.3
f6b60000 f6b62000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b6a000 f6b84000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b8c000 f6bbb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bc4000 f6bd3000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6bdd000 f6be7000 r-xp /usr/lib/libsensord-shared.so
f6bf0000 f6cc3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6cce000 f6ce4000 r-xp /lib/libz.so.1.2.5
f6cec000 f6cf1000 r-xp /usr/lib/libffi.so.5.0.10
f6cf9000 f6cfa000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d02000 f6d12000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d1a000 f6d33000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d3b000 f6d3d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d45000 f6dba000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6dc4000 f6dca000 r-xp /lib/librt-2.13.so
f6dd3000 f6df1000 r-xp /usr/lib/libsystemd.so.0.4.0
f6dfb000 f6dfc000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e04000 f6e27000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e2f000 f6e34000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e3c000 f6e66000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e6f000 f6e86000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e8e000 f6ef7000 r-xp /lib/libm-2.13.so
f6f00000 f6f94000 r-xp /usr/lib/libstdc++.so.6.0.16
f6fa7000 f6fac000 r-xp /usr/lib/libctx-client.so.0.8.3
f6fb4000 f6fbb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6fc3000 f6fed000 r-xp /usr/lib/libsensor.so.1.9.6
f6ff6000 f70c2000 r-xp /usr/lib/libxml2.so.2.7.8
f70cf000 f70d1000 r-xp /usr/lib/libiniparser.so.0
f70da000 f70e0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f70e9000 f71b9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71ba000 f71ee000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f71f7000 f7233000 r-xp /usr/lib/libSLP-location.so.0.9.24
f723b000 f723e000 r-xp /usr/lib/libbundle.so.0.1.22
f7246000 f724c000 r-xp /usr/lib/libappsvc.so.0.1.0
f7254000 f7295000 r-xp /usr/lib/libeina.so.1.7.99
f729e000 f72b5000 r-xp /usr/lib/libecore.so.1.7.99
f72cc000 f72d5000 r-xp /usr/lib/libvconf.so.0.2.45
f72dd000 f72f1000 r-xp /lib/libpthread-2.13.so
f72fc000 f7309000 r-xp /usr/lib/libaul.so.0.1.0
f7313000 f7315000 r-xp /lib/libdl-2.13.so
f731e000 f7329000 r-xp /lib/libunwind.so.8.0.1
f7356000 f735e000 r-xp /lib/libgcc_s-4.6.so.1
f735f000 f7483000 r-xp /lib/libc-2.13.so
f7491000 f7493000 r-xp /usr/lib/libdlog.so.0.0.0
f749b000 f74a7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74b0000 f74b5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74bd000 f74cc000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f74d4000 f74d8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74e1000 f74e4000 r-xp /usr/lib/libappcore-agent.so.1.1
f74ec000 f74ee000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f74f6000 f74fa000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7502000 f751f000 r-xp /lib/ld-2.13.so
f7528000 f752b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f752b000 f752f000 r-xp /usr/lib/libsys-assert.so
f7ba1000 f7c04000 rw-p [heap]
fff78000 fff99000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2486)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7529228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf74c0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71c73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf71c5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf71d1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf71d7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf71d7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf720c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72071f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf71c5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf71d1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf71d7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf71d7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7209e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf720a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf720e8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf74f80bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4b9c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c6f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf711cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf711e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf72aeca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf72a9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72aa5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf72aa879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf74e2183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74e27fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75295c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf737685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7528f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
06-07 21:03:08.571+0200 W/AUL_AMD ( 2479): amd_status.c: __socket_monitor_cb(1277) > (2408) was created
06-07 21:03:08.581+0200 E/AUL     ( 2479): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
06-07 21:03:08.581+0200 W/AUL     ( 2397): launch.c: app_request_to_launchpad(298) > request cmd(0) result(2408)
06-07 21:03:08.581+0200 E/W_TASKMANAGER( 2397): task.c: taskmanager_launch_task_info(1075) > [taskmanager_launch_task_info:1075] _launch_app() failed(2408)
06-07 21:03:08.591+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:08.591+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:08:490,-0.035832,0.002198,0.053348
06-07 21:03:08.591+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:08.601+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:08:597,-9.940000,4.830000,-0.840000
06-07 21:03:08.601+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:08.611+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:08:599,0.140390,-0.240804,0.075919
06-07 21:03:08.611+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:08.611+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:08:613,-4.830000,1.750000,-2.030000
06-07 21:03:08.611+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:08.621+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:08:617,-0.022322,-0.066128,0.004135
06-07 21:03:08.621+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:08.621+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:08:630,-0.008150,0.024939,0.105000
06-07 21:03:08.621+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:08.631+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:08:622,-1.470000,-0.280000,-1.820000
06-07 21:03:08.631+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:08.631+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:08:634,0.114909,-0.046473,0.018490
06-07 21:03:08.631+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:08.641+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:08:639,-2.170000,-1.330000,-0.980000
06-07 21:03:08.641+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:08.641+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:08:647,-4.130000,-1.120000,-2.240000
06-07 21:03:08.641+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:08:644,0.012849,-0.016323,0.110584
06-07 21:03:08.641+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:08.651+0200 I/light   ( 2536): es.ugr.frailty.light: SM-R760,07/06/2018,21:03:08:576,14.000000
06-07 21:03:08.651+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:08.651+0200 E/EFL     ( 2408): ecore_evas<2408> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
06-07 21:03:08.661+0200 I/gravity ( 2508): es.ugr.frailty.gravity: SM-R760,07/06/2018,21:03:08:574,3.053490,0.857194,9.279645
06-07 21:03:08.661+0200 I/gravity ( 2508): es.ugr.frailty.gravity - capturing data
06-07 21:03:08.661+0200 I/gravity ( 2508): es.ugr.frailty.gravity: SM-R760,07/06/2018,21:03:08:669,2.995369,0.827378,9.301269
06-07 21:03:08.661+0200 I/gravity ( 2508): es.ugr.frailty.gravity - capturing data
06-07 21:03:08.671+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:08:658,-6.440000,-0.980000,-0.980000
06-07 21:03:08.671+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:08.671+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:08:678,-9.800000,1.400000,-3.360000
06-07 21:03:08.671+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:08.681+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:08:654,0.083668,-0.011782,0.099293
06-07 21:03:08.691+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:08.701+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:08:697,3.077170,0.701097,9.006584
06-07 21:03:08.701+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:08.701+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:08:707,3.148954,0.696311,9.099905
06-07 21:03:08.701+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:08.701+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:08:711,3.163311,0.653241,9.315259
06-07 21:03:08.701+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:08.711+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:08.711+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:08:717,0.022575,-0.075646,0.100997
06-07 21:03:08.711+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:08.711+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:08:721,0.146859,-0.253653,0.082578
06-07 21:03:08.721+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:08:682,-6.230000,0.630000,-3.710000
06-07 21:03:08.721+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:08.731+0200 I/gravity ( 2508): es.ugr.frailty.gravity: SM-R760,07/06/2018,21:03:08:672,2.948276,0.805722,9.318201
06-07 21:03:08.731+0200 I/gravity ( 2508): es.ugr.frailty.gravity - capturing data
06-07 21:03:08.731+0200 I/gravity ( 2508): es.ugr.frailty.gravity: SM-R760,07/06/2018,21:03:08:739,2.928070,0.788854,9.326012
06-07 21:03:08.741+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:08.741+0200 I/APP_CORE( 2408): appcore-efl.c: __do_app(453) > [APP 2408] Event: RESET State: CREATED
06-07 21:03:08.741+0200 I/CAPI_APPFW_APPLICATION( 2408): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
06-07 21:03:08.751+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:08:734,-5.880000,0.840000,-3.360000
06-07 21:03:08.751+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:08.761+0200 I/APP_CORE( 2408): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
06-07 21:03:08.761+0200 I/APP_CORE( 2408): appcore-efl.c: __do_app(524) > [APP 2408] Initial Launching, call the resume_cb
06-07 21:03:08.761+0200 I/CAPI_APPFW_APPLICATION( 2408): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
06-07 21:03:08.761+0200 I/gravity ( 2508): es.ugr.frailty.gravity - capturing data
06-07 21:03:08.761+0200 I/heartrate( 2448): es.ugr.frailty.heartrate - capturing data
06-07 21:03:08.761+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:08:714,3.175276,0.753739,9.310472
06-07 21:03:08.761+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:08.761+0200 W/APP_CORE( 2408): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3400002
06-07 21:03:08.761+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:08:748,-0.088823,0.035882,0.060689
06-07 21:03:08.761+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:08.781+0200 I/gravity ( 2508): es.ugr.frailty.gravity: SM-R760,07/06/2018,21:03:08:767,2.928421,0.785289,9.326202
06-07 21:03:08.781+0200 I/gravity ( 2508): es.ugr.frailty.gravity - capturing data
06-07 21:03:08.781+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:08:758,-8.330000,2.730000,-1.120000
06-07 21:03:08.781+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:08.781+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:08:774,-0.060965,0.109362,0.029074
06-07 21:03:08.791+0200 I/light   ( 2536): es.ugr.frailty.light - capturing data
06-07 21:03:08.791+0200 I/heartrate( 2448): es.ugr.frailty.heartrate: waiting for rigth values
06-07 21:03:08.801+0200 I/light   ( 2536): es.ugr.frailty.light: SM-R760,07/06/2018,21:03:08:802,17.000000
06-07 21:03:08.801+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:08.801+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:08:771,3.139383,0.526421,9.200402
06-07 21:03:08.811+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:08.811+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:08:792,-4.270000,1.400000,0.210000
06-07 21:03:08.821+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:08.831+0200 I/gravity ( 2508): es.ugr.frailty.gravity: SM-R760,07/06/2018,21:03:08:788,2.932569,0.778693,9.325453
06-07 21:03:08.831+0200 I/APP_CORE( 2408): appcore-efl.c: __do_app(453) > [APP 2408] Event: RESUME State: RUNNING
06-07 21:03:08.841+0200 I/APP_CORE( 2397): appcore-efl.c: __do_app(453) > [APP 2397] Event: PAUSE State: RUNNING
06-07 21:03:08.841+0200 I/CAPI_APPFW_APPLICATION( 2397): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-07 21:03:08.841+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-taskmanager) pid(2397) status(bg) type(uiapp)
06-07 21:03:08.851+0200 W/STARTER ( 2696): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2397] goes to (4)
06-07 21:03:08.851+0200 W/STARTER ( 2696): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2408] goes to (3)
06-07 21:03:08.851+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(es.ugr.frailty.frailtylauncher) pid(2408) status(fg) type(uiapp)
06-07 21:03:08.871+0200 I/gravity ( 2508): es.ugr.frailty.gravity - capturing data
06-07 21:03:08.881+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:08:835,-2.170000,0.700000,1.540000
06-07 21:03:08.881+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:08:816,0.002831,0.001031,0.029370
06-07 21:03:08.881+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:08:826,3.093920,0.346959,9.262616
06-07 21:03:08.881+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:08.881+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:08.881+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:08.891+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:08:901,3.086741,0.488136,9.396614
06-07 21:03:08.901+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:08:891,-4.900000,0.350000,1.820000
06-07 21:03:08.901+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:08.911+0200 I/gravity ( 2508): es.ugr.frailty.gravity: SM-R760,07/06/2018,21:03:08:891,2.929532,0.768353,9.327264
06-07 21:03:08.911+0200 I/gravity ( 2508): es.ugr.frailty.gravity - capturing data
06-07 21:03:08.911+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:08:907,-3.220000,2.800000,-0.140000
06-07 21:03:08.911+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:08.911+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:08:895,-0.015450,0.134829,0.018952
06-07 21:03:08.911+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:08.911+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:08.921+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:08:920,-0.140000,0.280000,0.840000
06-07 21:03:08.921+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:08.931+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:08:934,-3.010000,-0.560000,0.980000
06-07 21:03:08.931+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:08.941+0200 I/heartrate( 2448): es.ugr.frailty.heartrate - capturing data
06-07 21:03:08.941+0200 I/heartrate( 2448): es.ugr.frailty.heartrate: waiting for rigth values
06-07 21:03:08.951+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:08:940,-3.500000,0.350000,0.700000
06-07 21:03:08.951+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:08.951+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:08:923,-0.007490,0.232361,0.150113
06-07 21:03:08.951+0200 I/gravity ( 2508): es.ugr.frailty.gravity: SM-R760,07/06/2018,21:03:08:918,2.916705,0.750543,9.332733
06-07 21:03:08.951+0200 I/gravity ( 2508): es.ugr.frailty.gravity - capturing data
06-07 21:03:08.951+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:08:944,3.182454,0.299103,9.401401
06-07 21:03:08.961+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:08:956,-0.210000,0.560000,0.070000
06-07 21:03:08.961+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:08.961+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:08.961+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:08.961+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:08:971,0.350000,1.680000,0.490000
06-07 21:03:08.961+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:08.971+0200 I/light   ( 2536): es.ugr.frailty.light - capturing data
06-07 21:03:08.971+0200 I/light   ( 2536): es.ugr.frailty.light: SM-R760,07/06/2018,21:03:08:978,15.000000
06-07 21:03:08.981+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:08:975,0.980000,0.770000,0.490000
06-07 21:03:08.981+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:08.981+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:08:987,-1.120000,0.490000,0.140000
06-07 21:03:08.981+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:08.981+0200 I/gravity ( 2508): es.ugr.frailty.gravity: SM-R760,07/06/2018,21:03:08:961,2.886569,0.731928,9.343575
06-07 21:03:08.991+0200 I/gravity ( 2508): es.ugr.frailty.gravity - capturing data
06-07 21:03:08.991+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:08:987,0.334948,-0.236282,0.006907
06-07 21:03:08.991+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:08:991,-1.540000,1.610000,-3.570000
06-07 21:03:08.991+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:09.001+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:08:988,3.096312,0.241675,9.384650
06-07 21:03:09.001+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:09:3,-1.820000,2.030000,-3.080000
06-07 21:03:09.001+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:09.001+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:09.011+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.011+0200 I/gravity ( 2508): es.ugr.frailty.gravity: SM-R760,07/06/2018,21:03:09:0,2.868804,0.711156,9.350647
06-07 21:03:09.011+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:09:13,0.699979,-0.047723,-0.248752
06-07 21:03:09.011+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:09:8,-7.560000,-1.750000,1.120000
06-07 21:03:09.021+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:09.021+0200 I/gravity ( 2508): es.ugr.frailty.gravity - capturing data
06-07 21:03:09.021+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:18,3.060420,0.471386,9.281759
06-07 21:03:09.021+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.021+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:31,3.046063,0.667598,9.420543
06-07 21:03:09.031+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.031+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:09.031+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:36,3.290131,0.543171,9.533006
06-07 21:03:09.031+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.031+0200 I/gravity ( 2508): es.ugr.frailty.gravity: SM-R760,07/06/2018,21:03:09:29,2.847816,0.682976,9.359159
06-07 21:03:09.041+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 22
06-07 21:03:09.041+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(999) > app status : 4
06-07 21:03:09.041+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:09:28,-12.530000,-0.840000,-3.640000
06-07 21:03:09.041+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:09.041+0200 E/APP_CORE( 2397): appcore.c: __del_vconf(453) > [FAILED]vconfkey_ignore_key_changed
06-07 21:03:09.041+0200 I/APP_CORE( 2397): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
06-07 21:03:09.041+0200 I/CAPI_APPFW_APPLICATION( 2397): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
06-07 21:03:09.041+0200 I/efl-extension( 2397): efl_extension_rotary.c: _object_deleted_cb(589) > In: data: 0xf02a6478, obj: 0xf02a6478
06-07 21:03:09.041+0200 I/efl-extension( 2397): efl_extension_rotary.c: _remove_ecore_handlers(571) > In
06-07 21:03:09.041+0200 I/efl-extension( 2397): efl_extension_rotary.c: _remove_ecore_handlers(576) > removed _motion_handler
06-07 21:03:09.041+0200 I/efl-extension( 2397): efl_extension_rotary.c: _remove_ecore_handlers(582) > removed _rotate_handler
06-07 21:03:09.041+0200 I/efl-extension( 2397): efl_extension_rotary.c: _object_deleted_cb(618) > done
06-07 21:03:09.041+0200 E/EFL     ( 2397): elementary<2397> elm_interface_scrollable.c:1962 _elm_scroll_content_region_show_internal() [0xf02a6478 : elm_scroller] x(0), y(0), nx(0), px(0), ny(0) py(0)
06-07 21:03:09.041+0200 I/gravity ( 2508): es.ugr.frailty.gravity - capturing data
06-07 21:03:09.051+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:09:41,-0.299587,-0.071665,0.186731
06-07 21:03:09.051+0200 I/efl-extension( 2397): efl_extension_rotary.c: _activated_obj_del_cb(624) > _activated_obj_del_cb : 0xf02c4580
06-07 21:03:09.051+0200 I/efl-extension( 2397): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(687) > Surface is going to free in delete callback for image widget.
06-07 21:03:09.051+0200 I/efl-extension( 2397): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(988) > surface 0xf02e4f28 is freed
06-07 21:03:09.051+0200 I/efl-extension( 2397): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
06-07 21:03:09.051+0200 I/efl-extension( 2397): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf02a6478, elm_scroller, func : 0xf3c68419
06-07 21:03:09.051+0200 I/efl-extension( 2397): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
06-07 21:03:09.051+0200 I/efl-extension( 2397): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
06-07 21:03:09.051+0200 I/efl-extension( 2397): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf02c4580, elm_image, func : 0xf3c68419
06-07 21:03:09.051+0200 I/efl-extension( 2397): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
06-07 21:03:09.051+0200 I/efl-extension( 2397): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(852) > [0xf02a6478 : elm_scroller] rotary callabck is deleted
06-07 21:03:09.051+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:09.051+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:40,2.734996,0.555135,9.494720
06-07 21:03:09.061+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.061+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:09:53,-16.520000,2.730000,-11.340000
06-07 21:03:09.061+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:65,3.199204,-0.033500,9.451650
06-07 21:03:09.061+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.061+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:69,3.237489,0.150748,9.300901
06-07 21:03:09.061+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.061+0200 I/gravity ( 2508): es.ugr.frailty.gravity: SM-R760,07/06/2018,21:03:09:54,2.815877,0.656328,9.370723
06-07 21:03:09.061+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:09.071+0200 I/gravity ( 2508): es.ugr.frailty.gravity - capturing data
06-07 21:03:09.071+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:09:64,0.396219,0.004809,0.138652
06-07 21:03:09.081+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:09.081+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:73,2.981457,0.428315,9.250652
06-07 21:03:09.081+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.091+0200 I/gravity ( 2508): es.ugr.frailty.gravity: SM-R760,07/06/2018,21:03:09:85,2.804341,0.630061,9.375984
06-07 21:03:09.091+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:09:79,-9.940000,2.310000,-4.760000
06-07 21:03:09.091+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:09.091+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:09:90,-0.014388,0.147075,0.211587
06-07 21:03:09.091+0200 I/gravity ( 2508): es.ugr.frailty.gravity - capturing data
06-07 21:03:09.101+0200 I/APP_CORE( 2397): appcore-efl.c: __after_loop(1243) > [APP 2397] After terminate() callback
06-07 21:03:09.101+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:09.101+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:09:105,-2.450000,0.700000,-0.210000
06-07 21:03:09.121+0200 I/gravity ( 2508): es.ugr.frailty.gravity: SM-R760,07/06/2018,21:03:09:106,2.800276,0.606117,9.378778
06-07 21:03:09.121+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:09:115,0.231337,0.223522,0.365190
06-07 21:03:09.121+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:90,3.117848,0.287139,9.329616
06-07 21:03:09.121+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.121+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:09.121+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:131,2.993421,0.375673,9.396614
06-07 21:03:09.121+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.131+0200 I/gravity ( 2508): es.ugr.frailty.gravity - capturing data
06-07 21:03:09.131+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:135,3.048456,0.550349,9.322437
06-07 21:03:09.131+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.131+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:09.131+0200 I/heartrate( 2448): es.ugr.frailty.heartrate - capturing data
06-07 21:03:09.141+0200 I/heartrate( 2448): es.ugr.frailty.heartrate: waiting for rigth values
06-07 21:03:09.141+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:09:145,0.045489,-0.107551,0.197028
06-07 21:03:09.141+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:140,3.079563,0.342174,9.382257
06-07 21:03:09.141+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:09:131,-2.940000,3.640000,0.420000
06-07 21:03:09.141+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.141+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:09.151+0200 I/gravity ( 2508): es.ugr.frailty.gravity: SM-R760,07/06/2018,21:03:09:138,2.789700,0.589052,9.383016
06-07 21:03:09.151+0200 I/gravity ( 2508): es.ugr.frailty.gravity - capturing data
06-07 21:03:09.161+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:09.161+0200 I/gravity ( 2508): es.ugr.frailty.gravity: SM-R760,07/06/2018,21:03:09:160,2.780243,0.585372,9.386052
06-07 21:03:09.161+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:154,2.830709,0.614955,9.334401
06-07 21:03:09.161+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.161+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:09:170,0.078969,-0.255979,0.155925
06-07 21:03:09.171+0200 I/efl-extension( 2595): efl_extension.c: eext_mod_init(40) > Init
06-07 21:03:09.171+0200 I/light   ( 2536): es.ugr.frailty.light - capturing data
06-07 21:03:09.171+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:172,2.837888,0.732204,9.298509
06-07 21:03:09.171+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.171+0200 I/light   ( 2536): es.ugr.frailty.light: SM-R760,07/06/2018,21:03:09:180,14.000000
06-07 21:03:09.181+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:09:156,-0.910000,3.010000,0.210000
06-07 21:03:09.181+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:09.181+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:183,3.574877,0.358923,9.248260
06-07 21:03:09.191+0200 I/gravity ( 2508): es.ugr.frailty.gravity - capturing data
06-07 21:03:09.191+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.201+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:198,3.079563,0.428315,9.451650
06-07 21:03:09.201+0200 I/gravity ( 2508): es.ugr.frailty.gravity: SM-R760,07/06/2018,21:03:09:198,2.795588,0.582139,9.381694
06-07 21:03:09.201+0200 I/gravity ( 2508): es.ugr.frailty.gravity - capturing data
06-07 21:03:09.201+0200 I/gravity ( 2508): es.ugr.frailty.gravity: SM-R760,07/06/2018,21:03:09:210,2.780136,0.574129,9.386778
06-07 21:03:09.211+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.211+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:221,2.921637,-0.227318,9.389436
06-07 21:03:09.221+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.221+0200 E/AUL     ( 2479): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
06-07 21:03:09.231+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:226,3.077170,0.184247,9.528220
06-07 21:03:09.231+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.231+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:239,3.160919,0.126820,9.370294
06-07 21:03:09.231+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.241+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:244,3.146562,0.279960,9.396614
06-07 21:03:09.241+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.241+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:249,3.005385,0.086142,9.384650
06-07 21:03:09.241+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.251+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:253,2.880959,0.162712,9.367901
06-07 21:03:09.251+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.251+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:257,2.828316,0.339781,9.322437
06-07 21:03:09.251+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.261+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:262,2.945565,0.141177,9.355937
06-07 21:03:09.261+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.261+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:268,3.062813,0.236889,9.300901
06-07 21:03:09.261+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.261+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 21:03:09.261+0200 W/libgps_d( 3131): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
06-07 21:03:09.271+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:273,3.103491,-0.093320,9.446864
06-07 21:03:09.271+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.271+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
06-07 21:03:09.271+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 21:03:09.271+0200 E/CAPI_LOCATION_MANAGER( 3823): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-07 21:03:09.271+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:279,3.254239,0.217747,9.454042
06-07 21:03:09.281+0200 I/AUL     ( 3823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-07 21:03:09.291+0200 I/AUL     ( 3823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-07 21:03:09.291+0200 E/LOCATION( 3823): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
06-07 21:03:09.291+0200 I/LOCATION( 3823): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
06-07 21:03:09.291+0200 I/LOCATION( 3823): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-07 21:03:09.291+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.301+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:09.301+0200 I/gravity ( 2508): es.ugr.frailty.gravity - capturing data
06-07 21:03:09.301+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:303,2.928815,0.110070,9.360723
06-07 21:03:09.301+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.301+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:09:191,-2.170000,4.480000,-2.590000
06-07 21:03:09.301+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:311,2.715853,0.404387,9.446864
06-07 21:03:09.301+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.311+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:315,3.067599,0.315853,9.367901
06-07 21:03:09.311+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.311+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:321,2.852244,0.342174,9.384650
06-07 21:03:09.311+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.321+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:09.321+0200 I/gravity ( 2508): es.ugr.frailty.gravity: SM-R760,07/06/2018,21:03:09:311,2.767570,0.537814,9.392640
06-07 21:03:09.321+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:325,2.885744,0.205783,9.403792
06-07 21:03:09.331+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:09:310,0.103514,-0.029372,0.122738
06-07 21:03:09.331+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.331+0200 I/gravity ( 2508): es.ugr.frailty.gravity - capturing data
06-07 21:03:09.331+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:337,3.136991,-0.045464,9.544970
06-07 21:03:09.331+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:09.331+0200 I/heartrate( 2448): es.ugr.frailty.heartrate - capturing data
06-07 21:03:09.331+0200 I/heartrate( 2448): es.ugr.frailty.heartrate: waiting for rigth values
06-07 21:03:09.341+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:09:330,0.210000,2.660000,-3.080000
06-07 21:03:09.351+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:09.351+0200 I/gravity ( 2508): es.ugr.frailty.gravity: SM-R760,07/06/2018,21:03:09:344,2.775073,0.519034,9.391483
06-07 21:03:09.351+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.351+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:09:345,-0.136639,-0.050813,0.038006
06-07 21:03:09.361+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:361,2.974278,0.186640,9.324830
06-07 21:03:09.361+0200 I/gravity ( 2508): es.ugr.frailty.gravity - capturing data
06-07 21:03:09.371+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.371+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:377,2.842674,0.196211,9.317651
06-07 21:03:09.371+0200 I/light   ( 2536): es.ugr.frailty.light - capturing data
06-07 21:03:09.371+0200 I/light   ( 2536): es.ugr.frailty.light: SM-R760,07/06/2018,21:03:09:381,14.000000
06-07 21:03:09.381+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:09:361,-0.420000,0.700000,-2.100000
06-07 21:03:09.381+0200 I/LOCATION( 2486): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-07 21:03:09.381+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:09.391+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.391+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:09.391+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:397,3.101098,0.105284,9.454042
06-07 21:03:09.401+0200 I/gravity ( 2508): es.ugr.frailty.gravity: SM-R760,07/06/2018,21:03:09:387,2.781077,0.515012,9.389929
06-07 21:03:09.401+0200 I/gravity ( 2508): es.ugr.frailty.gravity - capturing data
06-07 21:03:09.401+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:09:388,0.017195,-0.176530,0.037918
06-07 21:03:09.401+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:09.411+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.411+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:09:402,-3.360000,0.630000,0.420000
06-07 21:03:09.411+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:417,2.902494,0.373280,9.437292
06-07 21:03:09.411+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:09:417,0.076252,-0.061554,-0.215903
06-07 21:03:09.421+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:09.421+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:09:427,-3.080000,0.560000,-2.030000
06-07 21:03:09.421+0200 I/UXT     ( 2397): uxt_theme_private.c: uxt_theme_delete_file_monitor(1655) > deleted color config file monitor
06-07 21:03:09.431+0200 I/UXT     ( 2397): uxt_theme_private.c: uxt_theme_delete_file_monitor(1662) > deleted font config file monitor
06-07 21:03:09.431+0200 I/UXT     ( 2397): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
06-07 21:03:09.431+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.431+0200 I/gravity ( 2508): es.ugr.frailty.gravity: SM-R760,07/06/2018,21:03:09:415,2.793206,0.505786,9.386829
06-07 21:03:09.431+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:439,2.902494,0.296710,9.389436
06-07 21:03:09.441+0200 I/gravity ( 2508): es.ugr.frailty.gravity - capturing data
06-07 21:03:09.451+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:09.451+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.451+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:09.461+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:461,2.892922,0.270389,9.444471
06-07 21:03:09.461+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:09:459,0.149100,-0.087757,-0.319427
06-07 21:03:09.471+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.471+0200 I/gravity ( 2508): es.ugr.frailty.gravity: SM-R760,07/06/2018,21:03:09:456,2.791572,0.496959,9.387787
06-07 21:03:09.471+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:476,3.113062,0.110070,9.375079
06-07 21:03:09.471+0200 I/gravity ( 2508): es.ugr.frailty.gravity - capturing data
06-07 21:03:09.471+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:09.471+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:09:465,-1.540000,1.330000,-2.170000
06-07 21:03:09.481+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:09.491+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.491+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:09:485,0.220533,-0.088978,-0.226297
06-07 21:03:09.491+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:497,2.801995,0.270389,9.317651
06-07 21:03:09.491+0200 I/gravity ( 2508): es.ugr.frailty.gravity: SM-R760,07/06/2018,21:03:09:485,2.787402,0.497410,9.389002
06-07 21:03:09.501+0200 I/gravity ( 2508): es.ugr.frailty.gravity - capturing data
06-07 21:03:09.501+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration - capturing data
06-07 21:03:09.501+0200 I/gravity ( 2508): es.ugr.frailty.gravity: SM-R760,07/06/2018,21:03:09:508,2.777968,0.486958,9.392345
06-07 21:03:09.501+0200 I/UXT     ( 2595): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
06-07 21:03:09.511+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.511+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,21:03:09:495,1.890000,1.120000,-2.450000
06-07 21:03:09.511+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:516,2.912065,0.291924,9.406186
06-07 21:03:09.511+0200 I/linearacceleration( 2493): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,21:03:09:514,0.230743,-0.125452,-0.010194
06-07 21:03:09.531+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.531+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:537,3.058028,0.229711,9.415757
06-07 21:03:09.551+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.561+0200 I/heartrate( 2448): es.ugr.frailty.heartrate - capturing data
06-07 21:03:09.561+0200 I/heartrate( 2448): es.ugr.frailty.heartrate: waiting for rigth values
06-07 21:03:09.561+0200 I/gyroscope( 2432): es.ugr.frailty.gyroscope - capturing data
06-07 21:03:09.591+0200 I/light   ( 2536): es.ugr.frailty.light - capturing data
06-07 21:03:09.611+0200 E/EFL     ( 2408): ecore_x<2408> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=20618536 button=1
06-07 21:03:09.611+0200 E/EFL     ( 2408): elementary<2408> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf76f9100 : elm_list] mouse move
06-07 21:03:09.611+0200 E/EFL     ( 2408): elementary<2408> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf76f9100 : elm_list] mouse move
06-07 21:03:09.611+0200 E/EFL     ( 2408): elementary<2408> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf76f9100 : elm_list] hold(0), freeze(0)
06-07 21:03:09.621+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:562,2.974278,0.184247,9.482756
06-07 21:03:09.631+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.641+0200 E/AUL     ( 2479): app_sock.c: __app_recv_raw(518) > recv error: 4
06-07 21:03:09.641+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 21:03:09.641+0200 W/AUL     ( 2610): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-07 21:03:09.641+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:636,3.120241,0.165105,9.281759
06-07 21:03:09.651+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2408
06-07 21:03:09.651+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.651+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 23
06-07 21:03:09.651+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-07 21:03:09.651+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 1821
06-07 21:03:09.651+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 21:03:09.661+0200 E/EFL     ( 2408): elementary<2408> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf76f9100 : elm_list] mouse move
06-07 21:03:09.661+0200 E/EFL     ( 2408): elementary<2408> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf76f9100 : elm_list] hold(0), freeze(0)
06-07 21:03:09.661+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 21:03:09.661+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:660,2.720639,0.153141,9.260223
06-07 21:03:09.671+0200 E/EFL     ( 2408): elementary<2408> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf76f9100 : elm_list] mouse move
06-07 21:03:09.671+0200 E/EFL     ( 2408): elementary<2408> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf76f9100 : elm_list] hold(0), freeze(0)
06-07 21:03:09.671+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.681+0200 E/EFL     ( 2408): elementary<2408> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf76f9100 : elm_list] mouse move
06-07 21:03:09.681+0200 E/EFL     ( 2408): elementary<2408> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf76f9100 : elm_list] hold(0), freeze(0)
06-07 21:03:09.681+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 21:03:09.691+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:680,3.141776,0.119641,9.293723
06-07 21:03:09.691+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2408
06-07 21:03:09.691+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.691+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 21:03:09.711+0200 E/EFL     ( 2408): elementary<2408> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf76f9100 : elm_list] mouse move
06-07 21:03:09.711+0200 E/EFL     ( 2408): elementary<2408> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf76f9100 : elm_list] hold(0), freeze(0)
06-07 21:03:09.711+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 1821
06-07 21:03:09.711+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(1821)
06-07 21:03:09.721+0200 W/libgps_d( 3131): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
06-07 21:03:09.721+0200 W/libgps  ( 3131): [proxy__gps_stop][line = 1067]: called.
06-07 21:03:09.721+0200 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
06-07 21:03:09.721+0200 W/libgps_d( 3131): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-07 21:03:09.721+0200 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
06-07 21:03:09.721+0200 W/libgps_d( 3131): GpsiHookStateGps              : EXIT
06-07 21:03:09.721+0200 W/libgps_d( 3131): GpsiHookStateIdle             : ENTRY
06-07 21:03:09.721+0200 E/CAPI_LOCATION_MANAGER( 3823): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-07 21:03:09.721+0200 W/gpsd    ( 3111): HandleIncomingMessage() dest id:0, msg id:2
06-07 21:03:09.731+0200 I/light   ( 2536): es.ugr.frailty.light: SM-R760,07/06/2018,21:03:09:729,13.000000
06-07 21:03:09.741+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:701,3.002992,0.248854,9.595219
06-07 21:03:09.741+0200 E/EFL     ( 2408): elementary<2408> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf76f9100 : elm_list] mouse move
06-07 21:03:09.741+0200 E/EFL     ( 2408): elementary<2408> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf76f9100 : elm_list] hold(0), freeze(0)
06-07 21:03:09.751+0200 I/heartrate( 2448): es.ugr.frailty.heartrate - capturing data
06-07 21:03:09.751+0200 I/heartrate( 2448): es.ugr.frailty.heartrate: waiting for rigth values
06-07 21:03:09.751+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.751+0200 I/gravity ( 2508): es.ugr.frailty.gravity - capturing data
06-07 21:03:09.761+0200 E/EFL     ( 2408): ecore_x<2408> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=20618689 button=1
06-07 21:03:09.761+0200 W/AUL     ( 2408): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-07 21:03:09.761+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 21:03:09.761+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 2408
06-07 21:03:09.771+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 2321
06-07 21:03:09.781+0200 W/AUL     ( 2408): launch.c: app_request_to_launchpad(298) > request cmd(0) result(2321)
06-07 21:03:09.781+0200 I/utils   ( 2408): es.ugr.frailty.servicemanager stop request sent!
06-07 21:03:09.781+0200 I/utils   ( 2408): App control destroyed.
06-07 21:03:09.781+0200 I/CAPI_APPFW_APPLICATION( 2408): app_main.c: ui_app_exit(715) > ui_app_exit
06-07 21:03:09.781+0200 I/CAPI_APPFW_APPLICATION( 2408): app_main.c: app_efl_exit(145) > app_efl_exit
06-07 21:03:09.781+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,21:03:09:759,3.168097,0.119641,9.573684
06-07 21:03:09.781+0200 I/accelerometer( 2414): es.ugr.frailty.accelerometer - capturing data
06-07 21:03:09.791+0200 W/CRASH_MANAGER( 2600): worker.c: worker_job(1205) > 11024866c6f63152839818
